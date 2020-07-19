using System.Collections.Generic;
using System.Linq;
using AssetStudio;
using SkyEditor.IO.FileSystem;
using UnityEditor;
using Vector2 = UnityEngine.Vector2;

public static class TextureAnimationImporter
{
    private static CoordinateAttributeSet _eyeAnimAttributes = new CoordinateAttributeSet
        {UAttribute = 703419309, VAttribute = 971854765};

    private static CoordinateAttributeSet _mouthAnimAttributes = new CoordinateAttributeSet
        {UAttribute = 751950860, VAttribute = 1020386316};

    private static Dictionary<Vector2, Vector2> RtdxTextureTo2x4Mappings = new Dictionary<Vector2, Vector2>
    {
        {new Vector2(0f, 0f), new Vector2(0f, 0f)},
        {new Vector2(0.25f, 0f), new Vector2(0f, 0.5f)},
        {new Vector2(0.5f, 0f), new Vector2(0.5f, 0f)},
        {new Vector2(0.75f, 0f), new Vector2(0.5f, 0.75f)},
        {new Vector2(0f, 0.5f), new Vector2(0f, 0.25f)},
        {new Vector2(0.25f, 0.5f), new Vector2(0.5f, 0.5f)},
        {new Vector2(0.5f, 0.5f), new Vector2(0f, 0.25f)},
        {new Vector2(0.75f, 0.5f), new Vector2(0f, 0f)},
    };
    
    public static List<UnityEngine.AnimationClip> Import(string bundlePath, string savePath, string targetBundleName, AnimationType type,
        UnityEngine.SkinnedMeshRenderer[] skinnedMeshRenderers)
    {
        string animationNamePrefix = type == AnimationType.Eyes ? "ey_" : "mo_";
        string materialAttributeName = type == AnimationType.Eyes ? "_MainTex_eye_ST" : "_MainTex_mouth_ST";
        var attributeSet = type == AnimationType.Eyes ? _eyeAnimAttributes : _mouthAnimAttributes;
        
        var assetManager = new AssetsManager();
        assetManager.LoadFiles(PhysicalFileSystem.Instance, bundlePath);
        var assetFile = assetManager.assetsFileList[0];
        
        var animationClips = assetFile.Objects.OfType<AssetStudio.AnimationClip>()
            .Where(clip => clip.m_Name.StartsWith(animationNamePrefix));
        
        var importedAssets = new List<UnityEngine.AnimationClip>();
        foreach (var animationClip in animationClips)
        {
            var newClip = ProcessClip(animationClip, savePath, targetBundleName, materialAttributeName, attributeSet,
                skinnedMeshRenderers, type == AnimationType.Eyes);
            importedAssets.Add(newClip);
        }

        return importedAssets;
    }

    private static UnityEngine.AnimationClip ProcessClip(AssetStudio.AnimationClip animationClip, string savePath, string bundleName,
        string materialAttributeName, CoordinateAttributeSet attributeSet, UnityEngine.SkinnedMeshRenderer[] skinnedMeshRenderers,
        bool remap)
    {
        var uCurve = new UnityEngine.AnimationCurve();
        var vCurve = new UnityEngine.AnimationCurve();

        var clip = animationClip.m_MuscleClip.m_Clip;
        var streamedFrames = clip.m_StreamedClip.ReadData();
        var clipBindingConstant = animationClip.m_ClipBindingConstant;
        for (int frameIndex = 1; frameIndex < streamedFrames.Count - 1; frameIndex++)
        {
            StreamedClip.StreamedCurveKey uCoordKey = null, vCoordKey = null;
            foreach (var key in streamedFrames[frameIndex].keyList)
            {
                var binding = clipBindingConstant.FindBinding(key.index);
                if (binding.attribute == attributeSet.UAttribute)
                {
                    uCoordKey = key;
                }
                else if (binding.attribute == attributeSet.VAttribute)
                {
                    vCoordKey = key;
                }
            }

            if (uCoordKey == null || vCoordKey == null)
                continue;

            Vector2 value = new Vector2(uCoordKey.value, vCoordKey.value);
            if (remap)
            {
                value = RtdxTextureTo2x4Mappings[value];
            }

            uCurve.AddKey(streamedFrames[frameIndex].time, value.x);
            vCurve.AddKey(streamedFrames[frameIndex].time, value.y);
        }

        var newClip = new UnityEngine.AnimationClip {frameRate = animationClip.m_SampleRate};
        foreach (var skinnedMeshRenderer in skinnedMeshRenderers)
        {
            AnimationUtility.SetEditorCurve(newClip, new EditorCurveBinding
            {
                path = skinnedMeshRenderer.gameObject.name,
                type = typeof(UnityEngine.SkinnedMeshRenderer),
                propertyName = $"material.{materialAttributeName}.z"
            }, uCurve);
            AnimationUtility.SetEditorCurve(newClip, new EditorCurveBinding
            {
                path = skinnedMeshRenderer.gameObject.name,
                type = typeof(UnityEngine.SkinnedMeshRenderer),
                propertyName = $"material.{materialAttributeName}.w"
            }, vCurve);
        }
        
        // We need to use this stupid workaround instead of doing it when adding the key because
        // apparently it glitches if the curve wasn't added to an animation
       AnimationHelpers.SetAnimationTangentsToConstant(newClip);

        string animationPath = $"{savePath}/{animationClip.m_Name}.anim";
        AssetDatabase.CreateAsset(newClip, animationPath);
        AssetImporter.GetAtPath(animationPath).assetBundleName = bundleName;

        return newClip;
    }

    public class CoordinateAttributeSet
    {
        public uint UAttribute { get; set; }
        public uint VAttribute { get; set; }
    }

    public enum AnimationType
    {
        Eyes,
        Mouth
    }
}