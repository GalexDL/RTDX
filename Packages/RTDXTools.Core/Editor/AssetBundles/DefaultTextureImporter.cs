using System;
using System.IO;
using System.Linq;
using SkyEditor.IO.FileSystem;
using UnityEditor;

public static class DefaultTextureImporter
{
    [MenuItem("Tools/Import default textures")]
    // Start is called before the first frame update
    public static void ImportDefaultTextures()
    {
        var assetManager = new AssetStudio.AssetsManager();
        assetManager.LoadFiles(PhysicalFileSystem.Instance, Path.Combine(ConfigManager.AssetBundleSourcePath, "texture.ab"));
        
        var textures = assetManager.assetsFileList[0].Objects.OfType<AssetStudio.Texture2D>().ToArray();
        if (textures.Length <= 0)
        {
            throw new Exception("Couldn't read default textures.");
        }

        try
        {
            for (int i = 0; i < textures.Length; i++)
            {
                var texture = textures[i];
                EditorUtility.DisplayProgressBar("Texture import", "Importing default textures",
                    (float) i / textures.Length);

                var textureData = texture.image_data.GetData();
                var compressedTexture = new UnityEngine.Texture2D(texture.m_Width, texture.m_Height,
                    (UnityEngine.TextureFormat) texture.m_TextureFormat, false);
                compressedTexture.LoadRawTextureData(textureData);
                compressedTexture.Apply(true);
                var pixels = compressedTexture.GetPixels32();

                // We need to create an uncompressed texture to use ImageConversion.EncodeToPNG()
                var uncompressedTexture = new UnityEngine.Texture2D(texture.m_Width, texture.m_Height,
                    UnityEngine.TextureFormat.RGBA32, false);
                uncompressedTexture.SetPixels32(pixels);

                var pngData = UnityEngine.ImageConversion.EncodeToPNG(uncompressedTexture);

                string path = $"Assets/Resources/DefaultTextures/{texture.m_Name}.png";
                File.WriteAllBytes(path, pngData);
                AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate);
                UnityEngine.Object.DestroyImmediate(compressedTexture);
                UnityEngine.Object.DestroyImmediate(uncompressedTexture);
            }
        }
        finally
        {
            EditorUtility.ClearProgressBar();
        }
    }
}
