using System.IO;
using System.Linq;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

[UsedImplicitly]
public class TextureExport
{
    [MenuItem("Tools/Export Model Textures")]
    public static void ExportModelTextures()
    {
        var rootDestinationDirPath = "TextureExport";
        ImportHelpers.EnsureDirectoryExists(rootDestinationDirPath);

        var relativeModelsDirPath = Path.Combine("Assets", "GameAssets", "Models");
        var modelsDir = new DirectoryInfo(relativeModelsDirPath);
        foreach (var subDir in modelsDir.EnumerateDirectories())
        {
            var texturesDir = subDir.GetDirectories().FirstOrDefault(dir => dir.Name.ToLower() == "textures");
            if (texturesDir == null)
            {
                continue;
            }
            
            var destinationDir = Path.Combine(rootDestinationDirPath, subDir.Name);
            ImportHelpers.EnsureDirectoryExists(destinationDir);

            foreach (var file in texturesDir.GetFiles().Where(file => file.Name.EndsWith(".asset")))
            {
                string relativeAssetPath = Path.Combine(relativeModelsDirPath, subDir.Name, texturesDir.Name, file.Name)
                    .ToAssetPath();
                var asset = AssetDatabase.LoadAssetAtPath<Texture2D>(relativeAssetPath);
                if (asset == null)
                {
                    continue;
                }
                File.WriteAllBytes(Path.Combine(destinationDir, asset.name + ".png"),asset.EncodeToPNG());
            }
        }
    }
}