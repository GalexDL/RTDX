using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SPICA.Formats.CtrH3D;
using SPICA.Formats.CtrH3D.Model.Material;
using SPICA.Formats.Generic.COLLADA;
using UnityEditor;
using UnityEngine;

public class PSMDModelImporter
{
    private PSMDImportManifest _manifest;
    
    public PSMDModelImporter(PSMDImportManifest manifest)
    {
        _manifest = manifest;
    }

    public void Run()
    {
        for (var i = 0; i < _manifest.Models.Count; i++)
        {
            var model = _manifest.Models[i];
            EditorUtility.DisplayProgressBar("PSMD Import - Importing models...", 
                $"{i+1}/{_manifest.Models.Count}: Importing {model.PsmdModel}", i / (float) _manifest.Models.Count);
            try
            {
                ImportModel(model);
            }
            finally
            {
                EditorUtility.ClearProgressBar();
            }
        }
    }

    public void ImportModel(PSMDImportManifest.Model modelManifest)
    {
        string path = Path.Combine(_manifest.PsmdPkGraphicPath, modelManifest.PsmdModel);
        var spicaHandle = H3D.Open(File.ReadAllBytes(path));

        string targetDir = Path.Combine("Assets", "GameAssets", "Models", modelManifest.TargetName);
        string targetTexturesDir = Path.Combine(targetDir, "Textures");
        string targetMaterialsDir = Path.Combine(targetDir, "Materials");
        string targetMeshesDir = Path.Combine(targetDir, "Meshes");
        EnsureDirectoryExists(targetDir);
        EnsureDirectoryExists(targetTexturesDir);
        EnsureDirectoryExists(targetMaterialsDir);
        EnsureDirectoryExists(targetMeshesDir);
        
        string modelPath = Path.Combine(targetDir, $"{modelManifest.TargetName}.dae");
        new DAE(spicaHandle, 0).Save(modelPath);
        
        AssetDatabase.ImportAsset(modelPath.ToAssetPath());

        var unityTextures = new List<Texture>();
        foreach (var spicaTexture in spicaHandle.Textures)
        {
            var tempTexture = new Texture2D(spicaTexture.Width, spicaTexture.Height, TextureFormat.RGBA32, false);
            tempTexture.LoadRawTextureData(spicaTexture.ToRGBA());
            
            var unityTexture = new Texture2D(tempTexture.width, tempTexture.height, TextureFormat.RGBA32, true);
            unityTexture.SetPixels(tempTexture.GetPixels()); // Workaround to get mipmaps
            unityTexture.Apply(true);
            AssetDatabase.CreateAsset(unityTexture, Path.Combine(targetTexturesDir, $"{spicaTexture.Name}.asset").ToAssetPath());
            unityTextures.Add(unityTexture);
        }

        var modelImporter = AssetImporter.GetAtPath(modelPath.ToAssetPath()) as ModelImporter;
        if (modelImporter == null)
        {
            throw new Exception("Couldn't import model.");
        }

        var spicaMaterials = spicaHandle.Models[0].Materials;
        foreach (var spicaMaterial in spicaMaterials)
        {
            var material = CreateMaterial(spicaMaterial, unityTextures);
            AssetDatabase.CreateAsset(material, Path.Combine(targetMaterialsDir, $"{spicaMaterial.Name}.asset").ToAssetPath());
            
            modelImporter.AddRemap(new AssetImporter.SourceAssetIdentifier(typeof(Material), material.name + "_mat"), material);
        }

        modelImporter.SaveAndReimport();
        
        string prefabPath = Path.Combine(targetDir, $"{modelManifest.TargetName}.prefab").ToAssetPath();
        ImportHelpers.GeneratePrefabForModel(modelPath, prefabPath, targetMeshesDir);

        AssetImporter.GetAtPath(prefabPath).assetBundleName = modelManifest.TargetName;
    }

    private Material CreateMaterial(H3DMaterial spicaMaterial, List<Texture> unityTextures)
    {
        var material = ImportHelpers.CreateCharacterMaterial(ImportHelpers.GuessCharacterMaterialType(spicaMaterial.Name));
        material.name = spicaMaterial.Name;
        material.mainTexture = unityTextures.First(t => t.name == spicaMaterial.Texture0Name);
        return material;
    }


    private void EnsureDirectoryExists(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
    }
    
}