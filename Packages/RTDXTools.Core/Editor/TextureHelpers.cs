using System.IO;
using UnityEditor;
using UnityEngine;

public static class TextureHelpers
{
    public const string DefaultTexturesPath = "DefaultTextures";

    public static Texture GetDefaultTexture(string name)
    {
        return Resources.Load<Texture>($"{DefaultTexturesPath}/{name}");
    }
}