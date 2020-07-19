using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public static class MainSeriesRigHelper
{
    private static readonly Dictionary<string, string> _boneNameMap = new Dictionary<string, string>
    {
        {"Origin", "PG_root"},
        {"Waist", "Pelvis"},
        {"LThigh", "L_Thigh"},
        {"RThigh", "R_Thigh"},
        {"LLeg", "L_Calf"},
        {"RLeg", "R_Calf"},
        {"LFoot", "L_Foot"},
        {"RFoot", "R_Foot"},
        {"Spine1", "Spine"},
        {"Neck", "PG_Neck"},
        {"LArm", "L_UpperArm"},
        {"RArm", "R_UpperArm"},
        {"LForeArm", "L_Forearm"},
        {"RForeArm", "R_Forearm"},
        {"LHand", "L_Hand"},
        {"RHand", "R_Hand"},
        {"EffOverHead01", "PT_head"},
    };
    
    private static readonly Dictionary<string, string> _reparentMap = new Dictionary<string, string>
    {
        {"Head", "PG_Neck"},
        {"PG_Neck", "Spine"},
        {"L_UpperArm", "Spine"},
        {"R_UpperArm", "Spine"},
        {"Spine", "Pelvis"},
        {"L_Thigh", "Pelvis"},
        {"R_Thigh", "Pelvis"},
    };

    [MenuItem("Tools/Process Main Series Rig")]
    public static void Process()
    {
        if (Selection.activeGameObject == null)
            return;

        Process(Selection.activeGameObject.transform);
    }

    public static void Process(Transform transform)
    {
        if (PrefabUtility.GetPrefabInstanceStatus(transform.gameObject) != PrefabInstanceStatus.NotAPrefab)
        {
            PrefabUtility.UnpackPrefabInstance(transform.gameObject, PrefabUnpackMode.Completely,
                InteractionMode.AutomatedAction);
        }

        Rename(transform);
        Reparent(transform);

        var pgRoot = transform.FindDeepChild("PG_root");
        if (pgRoot != null)
        {
            pgRoot.parent = transform;
        }

        if (!transform.FindDeepChild("PT_head"))
        {
            // If there's no head effector we could use as PT_Head, add it as a direct child to the head so
            // that Manpu show up somewhat correctly
            var head = transform.FindDeepChild("Head");
            if (head != null)
            {
                var ptHead = new GameObject("PT_head");
                ptHead.transform.SetParent(head);
                ptHead.transform.localPosition = Vector3.zero;
                ptHead.transform.localRotation = Quaternion.identity;
            }
        }
    }

    private static void Rename(Transform t)
    {
        if (_boneNameMap.ContainsKey(t.gameObject.name))
        {
            t.gameObject.name = _boneNameMap[t.gameObject.name];
        }

        foreach (Transform child in t)
        {
            Rename(child);
        }
    }
    
    private static void Reparent(Transform t)
    {
        foreach (var pair in _reparentMap)
        {
            var jointToReparent = t.FindDeepChild(pair.Key);
            var targetParent = t.FindDeepChild(pair.Value);
            if (jointToReparent != null && targetParent != null)
            {
                jointToReparent.parent = targetParent;
            }
            else
            {
                Debug.LogWarning($"Couldn't reparent {pair.Key} to {pair.Value}");
            }
        }
    }
}