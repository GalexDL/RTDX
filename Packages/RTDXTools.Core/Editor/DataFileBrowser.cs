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
    private bool _useSourceFile = false;
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
        _showFileExplorer = EditorGUILayout.ToggleLeft("Show File Browser", _showFileExplorer);
        if (_showFileExplorer)
        {
            using (var changeCheck = new EditorGUI.ChangeCheckScope())
            {
                _onlyShowEditableFiles = EditorGUILayout.ToggleLeft("Only show editable files", _onlyShowEditableFiles);
                _useSourceFile = EditorGUILayout.ToggleLeft(new GUIContent("Force using source files", "If checked, the " +
                   "editor will open files from the source romfs directory instead of the build romfs directory. If unchecked, it will " +
                   "open the file in the build directory or otherwise fall back to the source directory (LayeredFS)." +
                   "The editor will always save to the build directory."),
                    _useSourceFile);
                if (changeCheck.changed)
                {
                    Refresh();
                }
            }
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
        if (node.SourceFile is DirectoryInfo)
        {
            node.Expanded = EditorGUILayout.Foldout(node.Expanded, node.SourceFile.Name);
        }
        else
        {
            using (new EditorGUILayout.HorizontalScope())
            {
                var factory = node.HandlerFactory;
                EditorGUILayout.LabelField(node.SourceFile.Name);

                if (factory != null)
                {
                    if (_openEditor?.GetType() == factory.EditorType && _openEditor?.CurrentFile != node)
                    {
                        if (GUILayout.Button("Overwrite", GUILayout.Width(80)))
                        {
                            if (EditorUtility.DisplayDialog("Overwrite with current file",
                                $"Are you sure that you want to overwrite '{node.SourceFile.Name}' with the currently open file?" +
                                $"(You must save the open file first to apply all changes.)", "OK", "Cancel"))
                            {
                                var sourceFile = (FileInfo) (_useSourceFile ? _openEditor.CurrentFile.SourceFile : _openEditor.CurrentFile.LayeredFSFile);
                                if (node.DestinationFile.Exists)
                                {
                                    ((FileInfo) node.DestinationFile).CopyTo(node.DestinationFile.FullName + ".bak", true);
                                }

                                sourceFile.CopyTo(node.DestinationFile.FullName, true);
                                node.DestinationFile.Refresh();
                            }
                        }
                    }

                    if (GUILayout.Button("Open", GUILayout.Width(60)))
                    {
                        _openEditor?.Close();
                        try
                        {
                            var handler = factory.Create();
                            handler.Open(node, _useSourceFile);
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
        string romfsPath = ConfigManager.RomFsSourcePath;
        if (!Directory.Exists(romfsPath))
        {
            // TODO: show error message
            return;
        }

        _root = new Node
        {
            SourceFile = new DirectoryInfo(ConfigManager.StreamingAssetsSourcePath), 
            DestinationFile = new DirectoryInfo(ConfigManager.StreamingAssetsBuildPath),
            Expanded = true
        };
       
        ProcessDirectory(_root);
        
        foreach (var child in _root.Children)
        {
            child.Expanded = true;

            if (child.SourceFile.Name.ToLower() == "native_data")
            {
                foreach (var innerChild in child.Children)
                {
                    innerChild.Expanded = innerChild.SourceFile.Name.ToLower() == "script";
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

    private void ProcessDirectory(Node source)
    {
        foreach (var info in ((DirectoryInfo) source.SourceFile).EnumerateDirectories())
        {
            var node = new Node
            {
                SourceFile = info, 
                DestinationFile = new DirectoryInfo(source.DestinationFile.FullName + Path.DirectorySeparatorChar + info.Name)
            };
            ProcessDirectory(node);

            source.Children.Add(node);
        }
        foreach (var info in ((DirectoryInfo) source.SourceFile).EnumerateFiles())
        {
            var node = new Node
            {
                SourceFile = info,
                DestinationFile = new FileInfo(source.DestinationFile.FullName + Path.DirectorySeparatorChar + info.Name),
                HandlerFactory = GetFileHandler(info)
            };
            
            if (!_onlyShowEditableFiles || node.HandlerFactory != null)
            {
                source.Children.Add(node);
            }
        }
    }

    public class Node
    {
        public bool Expanded = false;
        public FileSystemInfo SourceFile;
        public FileSystemInfo DestinationFile;
        public FileSystemInfo LayeredFSFile => DestinationFile.Exists ? DestinationFile : SourceFile;
        public IDataFileEditorFactory HandlerFactory;

        public List<Node> Children = new List<Node>();
    }
    
}