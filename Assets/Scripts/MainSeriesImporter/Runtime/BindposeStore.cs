using System;
using UnityEngine;

[ExecuteInEditMode]
public class BindposeStore : MonoBehaviour
{
    public Vector3 PositionAtRest;
    public Quaternion RotationAtRest;

    [ContextMenu("Activate")]
    public void Activate()
    {
        PositionAtRest = transform.localPosition;
        RotationAtRest = transform.localRotation;
    }
    
    [ContextMenu("Restore")]
    public void Restore()
    {
        transform.localPosition = PositionAtRest;
        transform.localRotation = RotationAtRest;
    }
}