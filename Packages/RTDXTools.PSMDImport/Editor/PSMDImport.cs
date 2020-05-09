using System.IO;
using Newtonsoft.Json;
using UnityEditor;

public static class PSMDImport
{
    [MenuItem("Tools/PSMD Model Import", false, 0)]
    public static void Import()
    {
        string manifestJson = File.ReadAllText("Data/psmd_import.manifest.json");
        var manifest = JsonConvert.DeserializeObject<PSMDImportManifest>(manifestJson);
        
        new PSMDModelImporter(manifest).Run();
    }
}