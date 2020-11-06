using System;
using System.IO;
using UnityEditor;

[InitializeOnLoad]
public class GameScriptEditorFactory : IDataFileEditorFactory
{
    static GameScriptEditorFactory()
    {
        DataFileBrowser.RegisterFileHandlerFactory(new GameScriptEditorFactory());
    }

    public bool CanHandle(FileInfo file)
    {
        return file.Name.EndsWith(".lua");
    }

    public IDataFileEditor Create()
    {
        return new GameScriptEditor();
    }

    public Type EditorType => typeof(GameScriptEditor);
}