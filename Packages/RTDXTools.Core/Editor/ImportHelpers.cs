using System;
using System.IO;
using UnityEditor;
using UnityEngine;

public static class ImportHelpers
{
    public static void GeneratePrefabForModel(string modelPath, string prefabPath, string meshesOutputFolder = null)
    {
        var prefab = GameObject.Instantiate(AssetDatabase.LoadAssetAtPath<GameObject>(modelPath.ToAssetPath()));
        var rigRoot = prefab.transform.Find("root/PG_root");
        rigRoot.transform.parent = prefab.transform;

        var skinnedMeshRenderers = prefab.GetComponentsInChildren<SkinnedMeshRenderer>();
        foreach (var meshRenderer in skinnedMeshRenderers)
        {
            meshRenderer.rootBone = rigRoot;

            if (meshesOutputFolder != null)
            {
                meshRenderer.sharedMesh = Helpers.CreateVertexPaintedClone(meshRenderer.sharedMesh, Color.black, 
                    Path.Combine(meshesOutputFolder, $"{meshRenderer.sharedMesh.name}_Painted.asset"));
            }
        }

        PrefabUtility.SaveAsPrefabAsset(prefab, prefabPath);
        GameObject.DestroyImmediate(prefab);
    }

    /// <summary>
    /// Creates a material with sensible default values for characters
    /// <param name="matType">body, eye or mouth</param>
    /// </summary>
    public static Material CreateCharacterMaterial(CharacterMaterialType materialType)
    {
        var material = new Material(Shader.Find("Pegasus/CH/CH_Base"));
        material.EnableKeyword($"_MATERIALTYPE_{materialType.ToKeywordString()}");
        material.SetInt("_MaterialType", (int) materialType);
        
        material.SetFloat("_OutlineWidth", 0.2f);
        material.SetColor("_OutlineColor", new Color(0.1f, 0.1f, 0.1f, 1f)); // TODO: Calculate from average texture color
        material.SetFloat("_OutlineOffset", 0.5f);
        material.SetColor("_HighlightColor", Color.white);
        material.SetColor("_AddColor", Color.black);
        material.SetColor("_Condition", Color.gray);
        material.SetColor("_Visible", Color.white);
        
        material.SetTexture("_ShadowColor", TextureHelpers.GetDefaultTexture("ShadowColor"));
        material.SetTexture("_MatCap", TextureHelpers.GetDefaultTexture("CH_LightMap"));
        material.SetTexture("_Kamishitu", TextureHelpers.GetDefaultTexture("Gayousi_loop"));
        material.SetTexture("_HSVMaskTex", TextureHelpers.GetDefaultTexture("HSVMaskTex"));

        return material;
    }

    public static CharacterMaterialType GuessCharacterMaterialType(string materialName)
    {
        materialName = materialName.ToLower();
        if (materialName.Contains("eye"))
        {
            return CharacterMaterialType.Eyes;
        }
        if (materialName.Contains("mouth"))
        {
            return CharacterMaterialType.Mouth;
        }

        return CharacterMaterialType.Body;
    }

    public static string ToKeywordString(this CharacterMaterialType materialType)
    {
        switch (materialType)
        {
            case CharacterMaterialType.Eyes:
                return "eye";
            case CharacterMaterialType.Mouth:
                return "mouth"; 
            default:
                return "body";
        }
    }
}

public enum CharacterMaterialType
{
    Body = 0,
    Eyes = 1,
    Mouth = 2
}
