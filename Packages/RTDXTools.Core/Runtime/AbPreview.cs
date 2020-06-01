using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#if UNITY_EDITOR
using Newtonsoft.Json.Linq;
using UnityEditor;
using UnityEditor.Animations;
#endif
using UnityEngine;
using UnityEngine.Serialization;
using Debug = UnityEngine.Debug;
using Object = UnityEngine.Object;

[Serializable]
public struct FileIdTaggedShader
{
    public Shader Shader;
    [FormerlySerializedAs("FileId")] public long PathId;

    public FileIdTaggedShader(Shader shader, long pathId)
    {
        Shader = shader;
        PathId = pathId;
    }
}

public class AbPreview : MonoBehaviour
{
    [FormerlySerializedAs("Path")] public string SourcePath = "../tools/1.6/romfs/Data/StreamingAssets/ab/";
    public string BundleName;
    public int SelectedIndex;
    public bool ReplaceShaders = true;
    public bool ReplaceAnimator = true;
    
    public List<Object> AssetRefs;
    public List<FileIdTaggedShader> ShaderRefs;

    private AssetBundle ab;
    private GameObject _preview;
    
    #if UNITY_EDITOR

    // Start is called before the first frame update
    [ContextMenu("Extract")]
    void Extract()
    {
        AssetRefs.Clear();

        ab = AssetBundle.LoadFromFile(SourcePath + BundleName);
        Debug.Log(string.Join(", ", ab.GetAllAssetNames()));

        var assets = ab.LoadAllAssets();
        AssetRefs.AddRange(assets);
    }

    [ContextMenu("Load shader_pack.ab")]
    void LoadShaderPack()
    {
        var pack = AssetBundle.LoadFromFile(SourcePath + "shader_pack.ab");
        var shaderAssets = pack.LoadAllAssets();
        
        ShaderRefs = new List<FileIdTaggedShader>();

        foreach (var asset in shaderAssets)
        {
            var shader = asset as Shader;
            if (shader == null)
                continue;

            AssetDatabase.TryGetGUIDAndLocalFileIdentifier(shader, out string guid, out long localId);
            ShaderRefs.Add(new FileIdTaggedShader(shader, localId));

            string jsonShader = EditorJsonUtility.ToJson(shader);
            var data = JObject.Parse(jsonShader);
            if (!data["Shader"]["m_CompileInfo"]["m_Snippets"].Any())
            {
                Debug.LogWarning("No code found for shader: " + asset.name);
                continue;
            }
            
            var code = data["Shader"]["m_CompileInfo"]["m_Snippets"].Last["second"]["m_Code"].ToString();
            var name = data["Shader"]["m_ParsedForm"]["m_Name"].ToString();
            //Debug.Log(name);
            //Debug.Log(code);
        }

        Debug.Log("Shaders loaded.");
    }
    
    [ContextMenu("Load texture.ab")]
    void LoadTextureAb()
    {
        var pack = AssetBundle.LoadFromFile(SourcePath + "texture.ab");
        var assets = pack.LoadAllAssets();

        Debug.Log("texture.ab loaded.");
    }

    [ContextMenu("Unload")]
    void Unload()
    {
        if (ab != null)
        {
            ab.Unload(true);
            AssetRefs.Clear();
        }
    }
    
    [ContextMenu("To Json")]
    void ToJson()
    {
        string json = EditorJsonUtility.ToJson(AssetRefs[SelectedIndex], true);
        Debug.Log(json);
        
        Helpers.SetClipboard(json);
    }
    
    [ContextMenu("Print Types")]
    void PrintTypes()
    {
        foreach (var assetRef in AssetRefs)
        {
            Debug.Log(assetRef.GetType().FullName);
        }
    }

    [ContextMenu("Preview")]
    void Preview()
    {
        AnimationClip firstClip = null;

        if (Selection.activeGameObject)
        {
            _preview = Selection.activeGameObject;
        }
        
        foreach (var assetRef in AssetRefs)
        {
            if (assetRef is GameObject && (Selection.activeGameObject == null || Selection.activeGameObject == gameObject) 
                                       && PrefabUtility.GetPrefabAssetType(assetRef) != PrefabAssetType.Model)
            {
                try
                {
                    _preview = (GameObject) Instantiate(assetRef);
                    if (ReplaceShaders)
                    {
                        Helpers.ReplaceModelShaders(_preview);
                    }
                }
                catch
                {
                    Debug.LogWarning("Error while loading prefab.");
                }
            }
        }

        var clips = new List<AnimationClip>();
        foreach (var assetRef in AssetRefs)
        {
            if (assetRef is Material)
            {
                FixShader((Material) assetRef);
            }

            if (assetRef is AnimationClip)
            {
                var anim = (AnimationClip) assetRef;
                //anim.legacy = true;
                anim.wrapMode = WrapMode.Loop;

                if (firstClip == null)
                {
                    firstClip = anim;
                }

                clips.Add(anim);
            }
        }

        var animator = _preview.GetComponentInChildren<Animator>();
        if (animator != null && ReplaceAnimator)
        {
            var animatorController = Resources.Load<AnimatorController>("PreviewAnimController");
            var layer = animatorController.layers[0];
            var state = layer.stateMachine.states[0];
            state.state.motion = clips[SelectedIndex];
            animator.runtimeAnimatorController = animatorController;
        }
    }

    [ContextMenu("Unload All")]
    void UnloadAll()
    {
        AssetBundle.UnloadAllAssetBundles(true);
    }
    
    [ContextMenu("Get TextAsset bytes")]
    void GetTextAssetText()
    {
        var text = ((TextAsset) AssetRefs[SelectedIndex]).bytes;
        Debug.Log(text);
        Helpers.SetClipboard(ByteArrayToString(text));
    }

    void FixShader(Material mat)
    {
        if (ReplaceShaders)
        {
            //if (mat.GetTexture("_MainTex") != null)
            {
                mat.shader = Shader.Find("Custom/Preview");
            }
            /*else
            {
                mat.shader = Shader.Find("Custom/Invisible");
            }*/
        }
    }

    [ContextMenu("PlayAnimation")]
    void PlayAnimation()
    {
        var animatorController = Resources.Load<AnimatorController>("PreviewAnimController");
        var layer = animatorController.layers[0];
        var state = layer.stateMachine.states[0];
        state.state.motion = AssetRefs[SelectedIndex] as AnimationClip;
    }

    public static string ByteArrayToString(byte[] ba)
    {
        StringBuilder hex = new StringBuilder(ba.Length * 2);
        foreach (byte b in ba)
            hex.AppendFormat("{0:x2}", b);
        return hex.ToString();
    }
    #endif
}
