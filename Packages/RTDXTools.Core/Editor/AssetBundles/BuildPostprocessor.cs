using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class BuildPostprocessor
{
    private const string ExtractorPath = "Tools/AssetBundleExtractor/AssetBundleExtractor.exe";
    
    private readonly string _bundlePath;
    
    #if UNITY_EDITOR

    public BuildPostprocessor(string bundlePath)
    {
        _bundlePath = bundlePath;
    }
    
    public void Run()
    {
        byte[] bytes = File.ReadAllBytes(_bundlePath);
        PatchPlatform(bytes);
        PatchAbDependencies(bytes);
        PatchDependencyPointers(bytes);
        File.WriteAllBytes(_bundlePath, bytes);
    }

    private void PatchPlatform(byte[] bytes)
    {
        Debug.Log("Patching platform...");
        
        // The platform is located after the second version string
        string str = Encoding.ASCII.GetString(bytes);
        string unityVersion = Application.unityVersion;
        int index = str.LastIndexOf(unityVersion, StringComparison.InvariantCulture);
        if (index < 0)
        {
            Debug.LogError("Could not patch platform");
        }
        
        index += unityVersion.Length + 1; // 00 terminated string
        
        using (var s = new BinaryWriter(new MemoryStream(bytes)))
        {
            s.Seek(index, SeekOrigin.Begin);
            s.Write((uint) BuildTarget.Switch); // Change it to a Switch bundle
        }
    }
    
    private void PatchAbDependencies(byte[] bytes)
    {
        Debug.Log("Patching shader pack archive dependency...");

        string ourShaderPack = "archive:/cab-411f45211d405148b72c6a1e052b5a20/cab-411f45211d405148b72c6a1e052b5a20";
        string originalPath =  "archive:/cab-caafd6a11c9514e386d3454c9c3a0782/cab-caafd6a11c9514e386d3454c9c3a0782";
        
        string str = Encoding.ASCII.GetString(bytes);
        // Loop through all instances of our path.
        int count = 0;
        int i = 0;
        while ((i = str.IndexOf(ourShaderPack, i, StringComparison.Ordinal)) != -1)
        {
            var originalPathBytes = Encoding.ASCII.GetBytes(originalPath);
            Array.Copy(originalPathBytes, 0, bytes, i, originalPathBytes.Length);

            i += ourShaderPack.Length;
            count++;
        }
        
        Debug.Log($"Replaced {count} times.");
    }
    
    private void PatchDependencyPointers(byte[] bytes)
    {
        Debug.Log("Patching dependency pointers...");

        var dependencyMap = DependencyPathIdMap.Load().OptimizedMap;

        int count = 0;
        var memStream = new MemoryStream(bytes);
        using (var s = new BinaryReader(memStream))
        {
            while (s.BaseStream.Position < s.BaseStream.Length - 8)
            {
                long ourPathId = s.ReadInt64();
                s.BaseStream.Position -= 6;

                if (dependencyMap.ContainsKey(ourPathId))
                {
                    long origPathId = dependencyMap[ourPathId];
                    var wr = new BinaryWriter(memStream);
                    wr.Seek((int) wr.BaseStream.Position - 2, SeekOrigin.Begin);
                    wr.Write(origPathId);
                    wr.Flush();
                    
                    count++;
                }
            }
        }
        
        Debug.Log($"Replaced {count} dependency path IDs.");
    }

    private void ExtractBundle()
    {
        string batchFilePath = _bundlePath + ".batch";
        
        // Batch file for UABE
        File.WriteAllText(batchFilePath, "+FILE " + _bundlePath);
        
        var extractProcess = new Process(); 
        extractProcess.StartInfo = new ProcessStartInfo
        {
            FileName = Directory.GetCurrentDirectory() + "/" + ExtractorPath,
            Arguments = "-fd batchexport " + batchFilePath,
            UseShellExecute = true,
        };
        extractProcess.Start();
        extractProcess.WaitForExit();
    }
    
    #endif
}
