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
        
        EditorUtility.DisplayProgressBar("PSMD Import - Adding to database...", 
            "Adding models to GraphicsDatabase", 1f);

        var rom = SkyEditorHelpers.GetRom();
        foreach (var model in manifest.Models)
        {
            var graphicsDatabase = rom.GetPokemonGraphicsDatabase();
            var entry = graphicsDatabase.Entries[model.GraphicsDatabaseSlot];
            entry.ModelName = model.TargetName ?? entry.ModelName;
            entry.AnimationName = model.RtdxAnimation ?? entry.AnimationName;
        }
        
        EditorUtility.DisplayProgressBar("PSMD Import - Adding to database...", 
            "Saving ROM", 1f);
        
        SkyEditorHelpers.SaveRom(rom);
        
        EditorUtility.DisplayProgressBar("PSMD Import - Building AssetBundles...", 
            "Building AssetBundles...", 1f);
        
        AbBuilder.Build(manifest.Models.Select(model => model.TargetName));

        EditorUtility.ClearProgressBar();
    }
}