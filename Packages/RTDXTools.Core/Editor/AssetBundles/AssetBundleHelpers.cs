using UnityEditor;

public static class AssetBundleHelpers
{
    [MenuItem("Tools/Manual PostProcess")]
    public static void ManualPostprocess()
    {
        string file = EditorUtility.OpenFilePanel("Open AssetBundle for post process", "", "ab");

        if (!string.IsNullOrEmpty(file))
        {
            new BuildPostprocessor(file).Run();
        }
    }
}
