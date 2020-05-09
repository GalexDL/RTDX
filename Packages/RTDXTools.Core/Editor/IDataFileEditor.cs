using System;
using System.IO;

public interface IDataFileEditor
{
    FileInfo CurrentFile { get; }
    void Open(FileInfo file);
    void DrawGUI();
    void DrawSceneGUI();
    void Close();
}

public interface IDataFileEditorFactory
{
    bool CanHandle(FileInfo file);
    IDataFileEditor Create();
    Type EditorType { get;  }
}