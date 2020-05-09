using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class DataFileBrowser : EditorWindow
{
    private Node _root;
    private Vector2 _scrollPos;

    private bool _onlyShowEditableFiles = true;
    private bool _showFileExplorer = true;
    private IDataFileEditor _openEditor;

    private static readonly List<IDataFileEditorFactory> _fileHandlerFactories = new List<IDataFileEditorFactory>();

    public static void RegisterFileHandlerFactory(IDataFileEditorFactory factory)
    {
        if (!_fileHandlerFactories.Contains(factory))
        {
            _fileHandlerFactories.Add(factory);
        }
    }

    [MenuItem("Tools/Data File Editor", false, 0)]
    static void Init()
    {
        GetWindow<DataFileBrowser>().Show();
    }

    private void OnEnable()
    {
        Refresh();
        Selection.selectionChanged += Repaint;
        SceneView.onSceneGUIDelegate += DrawSceneGUI;
    }

    private void OnDisable()
    {
        Selection.selectionChanged -= Repaint;
        SceneView.onSceneGUIDelegate -= DrawSceneGUI;
        _openEditor?.Close();
    }

    private void OnGUI()
    {
        using (var changeCheck = new EditorGUI.ChangeCheckScope())
        {
            _onlyShowEditableFiles = EditorGUILayout.ToggleLeft("Only show editable files", _onlyShowEditableFiles);
            if (changeCheck.changed)
            {
                Refresh();
            }
        }
        _showFileExplorer = EditorGUILayout.ToggleLeft("Show File Browser", _showFileExplorer);
        if (_showFileExplorer)
        {
            if (GUILayout.Button("Refresh"))
            {
                Refresh();
            }
        }

        if (position.width > 700)
        {
            using (new EditorGUILayout.HorizontalScope())
            {
                if (_showFileExplorer)
                {
                    DrawFileSelect();
                }
                DrawEditorPanel();                        
            }
        }
        else
        {
            if (_showFileExplorer)
            {
                DrawFileSelect();
                EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
            }
            DrawEditorPanel();
        }
    }

    private void DrawSceneGUI(SceneView sceneView)
    {
        _openEditor?.DrawSceneGUI();
    }

    private void DrawEditorPanel()
    {
        if (_openEditor != null)
        {
            using (new EditorGUILayout.VerticalScope())
            {
                _openEditor.DrawGUI();
            }
        }
    }

    private void DrawFileSelect()
    {
        if (!_showFileExplorer)
            return;
        
        using (new EditorGUILayout.VerticalScope(GUILayout.MaxWidth(position.width > 700 ? 400 : 700)))
        {
            var options = new GUILayoutOption[0];
            if (position.width <= 700)
            {
                options = new[] {GUILayout.Height(300)};
            }
            using (var scroll = new EditorGUILayout.ScrollViewScope(_scrollPos, options))
            {
                _scrollPos = scroll.scrollPosition;
                DrawNode(_root);
            }
        }
    }

    private void DrawNode(Node node)
    {
        if (node.File is DirectoryInfo)
        {
            node.Expanded = EditorGUILayout.Foldout(node.Expanded, node.File.Name);
        }
        else
        {
            using (new EditorGUILayout.HorizontalScope())
            {
                var factory = node.HandlerFactory;
                EditorGUILayout.LabelField(node.File.Name);

                if (factory != null)
                {
                    if (_openEditor?.GetType() == factory.EditorType && _openEditor.CurrentFile != node.File)
                    {
                        if (GUILayout.Button("Overwrite", GUILayout.Width(80)))
                        {
                            if (EditorUtility.DisplayDialog("Overwrite with current file",
                                $"Are you sure that you want to overwrite '{node.File.Name}' with the currently open file?" +
                                $"(You must save the open file first to apply all changes.)", "OK", "Cancel"))
                            {
                                _openEditor.CurrentFile.CopyTo(_openEditor.CurrentFile.FullName + ".bak", true);
                                File.Copy(_openEditor.CurrentFile.FullName, node.File.FullName, true);
                                node.File.Refresh();
                            }
                        }
                    }

                    if (GUILayout.Button("Open", GUILayout.Width(60)))
                    {
                        _openEditor?.Close();
                        try
                        {
                            var handler = factory.Create();
                            handler.Open((FileInfo) node.File);
                            _openEditor = handler;
                        }
                        catch (Exception e)
                        {
                            Debug.LogException(e);
                        }
                    }
                }
            }
        }

        if (!node.Expanded)
            return;
        
        foreach (var child in node.Children)
        {
            EditorGUI.indentLevel++;
            DrawNode(child);
            EditorGUI.indentLevel--;
        }
    }

    private void Refresh()
    {
        string romfsPath = EditorHelpers.GetRomFsPath();
        if (!Directory.Exists(romfsPath))
        {
            // TODO: show error message
            return;
        }

        var rootDir = new DirectoryInfo(romfsPath);
        var dataDir = rootDir.EnumerateDirectories().FirstOrDefault(dir => dir.Name.ToLower() == "data");
        if (dataDir != null)
        {
            rootDir = dataDir;
        }
        var streamingAssetsDir = rootDir.EnumerateDirectories().FirstOrDefault(dir => dir.Name.ToLower() == "streamingassets");
        if (streamingAssetsDir != null)
        {
            rootDir = streamingAssetsDir;
        }
        _root = new Node {File = rootDir, Expanded = true};
       
        ProcessDirectory(_root);
        
        foreach (var child in _root.Children)
        {
            child.Expanded = true;

            if (child.File.Name.ToLower() == "native_data")
            {
                foreach (var innerChild in child.Children)
                {
                    innerChild.Expanded = innerChild.File.Name.ToLower() == "script";
                }
            }
        }
    }

    private IDataFileEditorFactory GetFileHandler(FileInfo file)
    {
        foreach (var handlerFactory in _fileHandlerFactories)
        {
            if (handlerFactory.CanHandle(file))
            {
                return handlerFactory;
            }
        }

        return null;
    }

    private void ProcessDirectory(Node current)
    {
        foreach (var info in ((DirectoryInfo) current.File).EnumerateDirectories())
        {
            var node = new Node {File = info};
            ProcessDirectory(node);

            current.Children.Add(node);
        }
        foreach (var info in ((DirectoryInfo) current.File).EnumerateFiles())
        {
            var node = new Node
            {
                File = info,
                HandlerFactory = GetFileHandler(info)
            };
            
            if (!_onlyShowEditableFiles || node.HandlerFactory != null)
            {
                current.Children.Add(node);
            }
        }
    }

    private class Node
    {
        public bool Expanded = false;
        public FileSystemInfo File;
        public IDataFileEditorFactory HandlerFactory;

        public List<Node> Children = new List<Node>();
    }
    
}