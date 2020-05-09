using System;
using System.IO;
using UnityEditor;

[InitializeOnLoad]
public class PlacementDataEditorFactory : IDataFileEditorFactory
{
    static PlacementDataEditorFactory()
    {
        DataFileBrowser.RegisterFileHandlerFactory(new PlacementDataEditorFactory());
    }

    public bool CanHandle(FileInfo file)
    {
        return file.Name.EndsWith(".data") && file.DirectoryName != null &&
               file.DirectoryName.ToLower().EndsWith("actassetset");
    }

    public IDataFileEditor Create()
    {
        return new PlacementDataEditor();
    }

    public Type EditorType => typeof(PlacementDataEditor);
}