using System;
using UnityEngine;

public class ProxyModel : MonoBehaviour
{
    // Cannot use types in the Editor folder here
    [NonSerialized] public object PlacementDataAsset;
}