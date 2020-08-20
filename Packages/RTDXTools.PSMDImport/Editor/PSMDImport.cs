using System.IO;
using System.Linq;
using UnityEditor;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

public static class PSMDImport
{
    [MenuItem("Tools/PSMD Model Import", false, 0)]
    public static void Import()
    {
        string manifestYaml = File.ReadAllText("Data/psmd_import.manifest.yml");
        var manifest = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .Build()
            .Deserialize<PSMDImportManifest>(manifestYaml);
        
        new PSMDModelImporter(manifest).Run();
        
        EditorUtility.DisplayProgressBar("PSMD Import - Building AssetBundles...", 
            "Building AssetBundles...", 1f);
        
        AbBuilder.Build(manifest.Models.Select(model => model.TargetName));

        EditorUtility.ClearProgressBar();
    }
}