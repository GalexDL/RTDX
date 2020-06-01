using System;
using System.IO;

public interface IDataFileEditor
{
    DataFileBrowser.Node CurrentFile { get; }
    void Open(DataFileBrowser.Node file, bool useSourceFile);
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