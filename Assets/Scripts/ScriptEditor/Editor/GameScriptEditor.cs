using System;
using System.IO;
using UnityEditor;
using UnityEngine;

public class GameScriptEditor : IDataFileEditor
{
    private Vector2 _scrollPos;

    private bool _useSourceFile;
    private DataFileBrowser.Node _file;
    private GameScript _script;
    private bool[] _blobsExpanded;

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
        }
        finally
        {
            EditorUtility.ClearProgressBar();
        }
    }

    private void Save()
    {
        throw new NotImplementedException();
    }

    public void Close()
    {
        throw new NotImplementedException();
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
                _blobsExpanded[i] = EditorGUILayout.Foldout(_blobsExpanded[i], blob.GetType().Name);

                if (_blobsExpanded[i])
                {
                    EditorGUI.indentLevel++;
                    if (blob is StubBlob stubBlob)
                    {
                        stubBlob.Contents = EditorGUILayout.TextArea(stubBlob.Contents);
                    }

                    EditorGUI.indentLevel--;
                }
            }
        }
    }

    public void DrawSceneGUI()
    {
    }
}