using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;

public class BodyAnimationProcessor
{
    public GameObject SourceObject { get; set; }
    public GameObject TargetObject { get; set; }
    public (AnimationClip clip, bool belongsToModelBundle)[] BodyAnimations { get; set; }

    public IEnumerator ExportBodyAnimation(string modelAnimationsDir, string animationsDir, string targetModelName, 
        string targetAnimationBundleName, bool footCorrection)
    {
        var bodyClips = BodyAnimations;
        for (int i = 0; i < bodyClips.Length; i++)
        {
            var clip = bodyClips[i];
            bool canceled = EditorUtility.DisplayCancelableProgressBar("Animation transfer", $"Saving {clip.clip.name}...",
                ((float) i / bodyClips.Length) * 0.9f);
            if (canceled)
            {
                break;
            }

            AnimationClip newAnim = null;
            yield return RetargetAnimation(clip.clip, footCorrection, result => newAnim = result);

            string assetName = clip.clip.name + ".anim";
            if (clip.belongsToModelBundle)
            {
                string animationPath = Path.Combine(modelAnimationsDir, assetName).ToAssetPath();
                AssetDatabase.CreateAsset(newAnim, animationPath);
                AssetImporter.GetAtPath(animationPath).assetBundleName = targetModelName;
            }
            else
            {
                string animationPath = Path.Combine(animationsDir, assetName).ToAssetPath();
                AssetDatabase.CreateAsset(newAnim, animationPath);
                AssetImporter.GetAtPath(animationPath).assetBundleName = targetAnimationBundleName;
            }
        }
    }

    private IEnumerator RetargetAnimation(AnimationClip clip, bool footCorrection, Action<AnimationClip> onFinish)
    {
        var newClip = new AnimationClip();
        var targetObjRoot = TargetObject.transform.Find("PG_root");
        float timeStep = 1 / clip.frameRate;

        var snapshotsAtPath = new Dictionary<string, AnimationSnapshotData>();

        for (float time = 0; time < clip.length; time += timeStep)
        {
            if (footCorrection)
            {
                JointConstraintHelper.ApplyFootCorrection(SourceObject.transform, TargetObject.transform);
            }
            clip.SampleAnimation(SourceObject, time);
            yield return null;

            TraverseRig(targetObjRoot, snapshotsAtPath, targetObjRoot.name, time, true);
        }

        foreach (var snapshot in snapshotsAtPath)
        {
            snapshot.Value.ApplyToClip(newClip);
            newClip.EnsureQuaternionContinuity();
        }

        onFinish(newClip);
    }

    private static void TraverseRig(Transform current, Dictionary<string, AnimationSnapshotData> snapshotsAtPath, string path,
        float time, bool isRoot)
    {
        var constraint = current.gameObject.GetComponent<RotationConstraint>();
        if (isRoot || constraint != null)
        {
            if (!snapshotsAtPath.ContainsKey(path))
            {
                snapshotsAtPath.Add(path, new AnimationSnapshotData(path));
            }

            var snapshot = snapshotsAtPath[path];

            if (isRoot)
            {
                snapshot.HasTranslationKeys = true;

                var localPos = current.localPosition;
                snapshot.TranslateX.AddKey(time, localPos.x);
                snapshot.TranslateY.AddKey(time, localPos.y);
                snapshot.TranslateZ.AddKey(time, localPos.z);
            }

            if (constraint != null)
            {
                var localRot = current.localRotation;
                snapshot.RotateX.AddKey(time, localRot.x);
                snapshot.RotateY.AddKey(time, localRot.y);
                snapshot.RotateZ.AddKey(time, localRot.z);
                snapshot.RotateW.AddKey(time, localRot.w);
            }
        }

        foreach (Transform child in current)
        {
            TraverseRig(child, snapshotsAtPath, path + "/" + child.name, time, false);
        }
    }
}