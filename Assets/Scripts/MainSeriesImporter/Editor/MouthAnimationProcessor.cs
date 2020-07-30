using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public static class MouthAnimationProcessor
{
    private static Dictionary<Vector2, int> RtdxTextureToMouthType = new Dictionary<Vector2, int>
    {
        {new Vector2(0f, 0f), 0},
        {new Vector2(0f, 0.5f), 1},
        {new Vector2(0.5f, 0f), 2},
        {new Vector2(0.5f, 0.75f), 3},
        {new Vector2(0f, 0.25f), 4},
        {new Vector2(0.5f, 0.5f), 5},
        {new Vector2(0f, 0.25f), 0},
    };

    public static void CreateSkeletalMouthAnimationsFromTextureAnimations(List<AnimationClip> textureAnimations,
        MouthModel mouthModel, Transform animationRoot)
    {
        var jawRoot = animationRoot.FindDeepChild("RootJaw");
        if (jawRoot == null)
        {
            Debug.LogError("Couldn't create mouth animation since RootJaw bone is missing.");
            return;
        }
        
        foreach (var textureAnimation in textureAnimations)
        {
            ProcessAnimation(textureAnimation, mouthModel, animationRoot, jawRoot);
        }
    }
    
    private static void ProcessAnimation(AnimationClip clip, MouthModel mouthModel, Transform animationRoot, Transform jawRoot)
    {
        var bindings = AnimationUtility.GetCurveBindings(clip);
        var uBinding = bindings.FirstOrDefault(binding => binding.propertyName == "material._MainTex_mouth_ST.z");
        var vBinding = bindings.FirstOrDefault(binding => binding.propertyName == "material._MainTex_mouth_ST.w");

        if (uBinding.path == null || vBinding.path == null)
        {
            Debug.LogWarning("Couldn't find animation binding for clip " + clip.name);
            return;
        }

        var uCurve = AnimationUtility.GetEditorCurve(clip, uBinding);
        var vCurve = AnimationUtility.GetEditorCurve(clip, vBinding);
        
        var snapshotsAtPath = new Dictionary<string, AnimationSnapshotData>();

        for (int i = 0; i < uCurve.keys.Length; i++)
        {
            // We can assume that that the curves for the U and V value have the same keyframes
            Vector2 uvValue = new Vector2(uCurve.keys[i].value, vCurve.keys[i].value);
            mouthModel.CurrentPoseIndex = RtdxTextureToMouthType.ContainsKey(uvValue) ? RtdxTextureToMouthType[uvValue] : 0;
            
            TraverseRig(jawRoot, snapshotsAtPath, GetRelativePath(jawRoot, animationRoot), uCurve.keys[i].time);
        }
        
        foreach (var snapshot in snapshotsAtPath)
        {
            snapshot.Value.ApplyToClip(clip);
            clip.EnsureQuaternionContinuity();
        }
        AnimationHelpers.SetAnimationTangentsToConstant(clip);
    }
    
    public static void TraverseRig(Transform current, Dictionary<string, AnimationSnapshotData> snapshotsAtPath, string path,
        float time)
    {
        if (!snapshotsAtPath.ContainsKey(path))
        {
            snapshotsAtPath.Add(path, new AnimationSnapshotData(path));
        }

        var snapshot = snapshotsAtPath[path];

        snapshot.HasTranslationKeys = true;

        var localPos = current.localPosition;
        snapshot.TranslateX.AddKey(time, localPos.x);
        snapshot.TranslateY.AddKey(time, localPos.y);
        snapshot.TranslateZ.AddKey(time, localPos.z);

        var localRot = current.localRotation;
        snapshot.RotateX.AddKey(time, localRot.x);
        snapshot.RotateY.AddKey(time, localRot.y);
        snapshot.RotateZ.AddKey(time, localRot.z);
        snapshot.RotateW.AddKey(time, localRot.w);

        foreach (Transform child in current)
        {
            TraverseRig(child, snapshotsAtPath, path + "/" + child.name, time);
        }
    }
    
    public static string GetRelativePath(Transform current, Transform relativeTo) {
        if (current.parent == null)
            return "/" + current.name;
        if (current.parent == relativeTo)
            return relativeTo.name + "/" + current.name;
        return GetRelativePath(current.parent, relativeTo) + "/" + current.name;
    }
}