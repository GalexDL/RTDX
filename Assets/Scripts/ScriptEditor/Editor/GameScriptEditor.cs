using System;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;

public class GameScriptEditor : IDataFileEditor
{
    private Vector2 _scrollPos;

    private bool _useSourceFile;
    private DataFileBrowser.Node _file;
    private GameScript _script;
    private bool[] _blobsExpanded;
    private Vector2[] _blobScrollPositions;

    public DataFileBrowser.Node CurrentFile => _file;

    public void Open(DataFileBrowser.Node file, bool useSourceFile)
    {
        EditorUtility.DisplayProgressBar("GameScriptEditor", "Parsing...", 0f);

        try
        {
            _file = file;
            _useSourceFile = useSourceFile;

            var contents = File.ReadAllText(useSourceFile ? _file.SourceFile.FullName : _file.LayeredFSFile.FullName);
            _script = new GameScript(contents);
            _blobsExpanded = new bool[_script.Blobs.Count];
            _blobScrollPositions = new Vector2[_script.Blobs.Count];
        }
        finally
        {
            EditorUtility.ClearProgressBar();
        }
    }

    private void Save()
    {
        var fileName = _file.DestinationFile.FullName;
        if (_file.DestinationFile.Exists)
        {
            ((FileInfo) _file.DestinationFile).CopyTo(fileName + ".bak", true);
        }
        
        ImportHelpers.EnsureDirectoryExists(Path.GetDirectoryName(fileName));
        File.WriteAllText(fileName, _script.ToString());
        Debug.Log("Saved to " + fileName);
    }

    public void Close()
    {
    }

    public void DrawGUI()
    {
        EditorGUILayout.LabelField($"Editing {(_useSourceFile ? _file.SourceFile.FullName : _file.LayeredFSFile.FullName)}");

        if (GUILayout.Button("Save"))
        {
            Save();
        }

        using (var scrollView = new EditorGUILayout.ScrollViewScope(_scrollPos))
        {
            _scrollPos = scrollView.scrollPosition;
            
            for (var i = 0; i < _script.Blobs.Count; i++)
            {
                var blob = _script.Blobs[i];

                using (new EditorGUILayout.HorizontalScope())
                {
                    var lastBgCol = GUI.backgroundColor;
                    var lastContentCol = GUI.contentColor;
                    var blobColor = blob.Skipped ? Color.gray : blob.Color;
                    GUI.backgroundColor = blobColor;
                    GUI.contentColor = blobColor;

                    _blobsExpanded[i] = EditorGUILayout.Foldout(_blobsExpanded[i],
                        $"{i}: {blob.Name}{(blob.Skipped ? " (skipped)" : "")}");
                    
                    GUI.backgroundColor = lastBgCol;
                    GUI.contentColor = lastContentCol;

                    if (GUILayout.Button("Skip", EditorStyles.miniButton, GUILayout.Width(60f)))
                    {
                        blob.Skipped = !blob.Skipped;
                    }
                }

                if (_blobsExpanded[i])
                {
                    using (var innerScrollView = new EditorGUILayout.ScrollViewScope(_blobScrollPositions[i], GUILayout.MinHeight(200)))
                    {
                        EditorGUI.indentLevel++;
                        _blobScrollPositions[i] = innerScrollView.scrollPosition;
                        blob.Contents = EditorGUILayout.TextArea(blob.Contents, GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));
                        EditorGUI.indentLevel--;
                    }
                    EditorGUILayout.Space();
                }
            }
        }
    }

    public void DrawSceneGUI()
    {
    }
}