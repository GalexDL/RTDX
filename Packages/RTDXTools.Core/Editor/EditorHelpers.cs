using System.IO;
using UnityEditor;
using UnityEngine;

public static class EditorHelpers
{
    public static string GetRomFsPath()
    {
        var romfsPath = Directory.GetCurrentDirectory() + "/" + EditorPrefs.GetString("romfspath", "");
        if (string.IsNullOrEmpty(romfsPath))
        {
            Debug.LogWarning("RomFS path not set. Please open the RomTools window in Tools/RomTools and set the " +
                             "path to ensure that this tool works correctly.");
        }

        return romfsPath;
    }

    public static string GetRomFsAssetBundlePath()
    {
        var romFsPath = GetRomFsPath();
        if (!romFsPath.EndsWith("/"))
        {
            romFsPath += "/";
        }

        return GetRomFsPath() + "Data/StreamingAssets/ab/";
    }
}
