using UnityEditor;
using UnityEngine;

public class AnimationSnapshotData
{
    public string Path;
    public AnimationCurve TranslateX = new AnimationCurve();
    public AnimationCurve TranslateY = new AnimationCurve();
    public AnimationCurve TranslateZ = new AnimationCurve();
    public AnimationCurve RotateX = new AnimationCurve();
    public AnimationCurve RotateY = new AnimationCurve();
    public AnimationCurve RotateZ = new AnimationCurve();
    public AnimationCurve RotateW = new AnimationCurve();
    public bool HasTranslationKeys;

    public AnimationSnapshotData(string path)
    {
        Path = path;
    }

    public void ApplyToClip(AnimationClip clip)
    {
        if (HasTranslationKeys)
        {
            AnimationUtility.SetEditorCurve(clip,
                new EditorCurveBinding {path = Path, type = typeof(Transform), propertyName = "m_LocalPosition.x"},
                TranslateX);
            AnimationUtility.SetEditorCurve(clip,
                new EditorCurveBinding {path = Path, type = typeof(Transform), propertyName = "m_LocalPosition.y"},
                TranslateY);
            AnimationUtility.SetEditorCurve(clip,
                new EditorCurveBinding {path = Path, type = typeof(Transform), propertyName = "m_LocalPosition.z"},
                TranslateZ);
        }

        AnimationUtility.SetEditorCurve(clip,
            new EditorCurveBinding {path = Path, type = typeof(Transform), propertyName = "m_LocalRotation.x"},
            RotateX);
        AnimationUtility.SetEditorCurve(clip,
            new EditorCurveBinding {path = Path, type = typeof(Transform), propertyName = "m_LocalRotation.y"},
            RotateY);
        AnimationUtility.SetEditorCurve(clip,
            new EditorCurveBinding {path = Path, type = typeof(Transform), propertyName = "m_LocalRotation.z"},
            RotateZ);
        AnimationUtility.SetEditorCurve(clip,
            new EditorCurveBinding {path = Path, type = typeof(Transform), propertyName = "m_LocalRotation.w"},
            RotateW);
    }
}