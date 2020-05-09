using System;
using UnityEditor;

[CustomEditor(typeof(ProxyModel))]
public class ProxyModelInspector : Editor
{
    private void OnEnable()
    {
        Edit();
    }

    public override void OnInspectorGUI()
    {
        Edit();
    }

    private void Edit()
    {
        // Delegate to the PlacementDataEntryInspector
        var proxyModel = (ProxyModel) target;
        PlacementDataEntryInspector.Edit((PlacementDataAsset) proxyModel.PlacementDataAsset);
    }
}
