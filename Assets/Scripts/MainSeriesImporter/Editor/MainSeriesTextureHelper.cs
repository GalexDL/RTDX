using System;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public static class MainSeriesTextureHelper
{
    public static void ExpandTexture(string texturePath, Vector2 normalizedOffset = default(Vector2))
    {
        var origTexture = AssetDatabase.LoadAssetAtPath<Texture2D>(texturePath);
        if (!origTexture.isReadable)
        {
            EnsureTextureIsReadable(texturePath);
        }
        
        var newTexture = new Texture2D(origTexture.width * 2, origTexture.height, TextureFormat.RGBA32, true);
        int origWidth = origTexture.width;
        int newWidth = newTexture.width;
        int height = origTexture.height;

        var origPixels = origTexture.GetPixels32();
        var newPixels = new Color32[newWidth * height];
        
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < origWidth; x++)
            {
                var pixel = origPixels[GetFlatArrayCoordinate(x, y, origWidth)];
                
                newPixels[GetFlatArrayCoordinate(x, y, newWidth)] = pixel;
                newPixels[GetFlatArrayCoordinate(newWidth - x - 1, y, newWidth)] = pixel;
            }
        }

        if (normalizedOffset != Vector2.zero)
        { 
            var newPixelsOffset = new Color32[newPixels.Length];
            
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    int xWithOffset = Mathf.FloorToInt(x + normalizedOffset.x * newWidth) % newWidth;
                    int yWithOffset = Mathf.FloorToInt(y + normalizedOffset.y * height) % height;
                
                    newPixelsOffset[GetFlatArrayCoordinate(x, y, newWidth)] = newPixels[GetFlatArrayCoordinate(xWithOffset, yWithOffset, newWidth)];
                }
            }

            newPixels = newPixelsOffset;
        }
        
        newTexture.SetPixels32(newPixels);
        newTexture.Apply(true);

        File.WriteAllBytes(texturePath, newTexture.EncodeToPNG());
        AssetDatabase.ImportAsset(texturePath.ToAssetPath(), ImportAssetOptions.ForceUpdate);
    }

    public static void EnsureTextureIsReadable(string texturePath)
    {
        var importer = AssetImporter.GetAtPath(texturePath) as TextureImporter;
        if (!importer)
            throw new ArgumentException("The given texture path is invalid.");
            
        importer.isReadable = true;
        importer.SaveAndReimport();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetFlatArrayCoordinate(int x, int y, int width)
    {
        return y * width + x;
    }
}