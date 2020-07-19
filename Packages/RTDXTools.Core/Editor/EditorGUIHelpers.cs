using UnityEditor;
using UnityEngine;

public static class EditorGUIHelpers
{
    public static void SetHierarchyExpanded(GameObject go, bool expand)
    {
        var type = typeof(EditorWindow).Assembly.GetType("UnityEditor.SceneHierarchyWindow");
        var methodInfo = type.GetMethod("SetExpandedRecursive");
 
        EditorApplication.ExecuteMenuItem("Window/General/Hierarchy");
        var window = EditorWindow.focusedWindow;
 
        methodInfo?.Invoke(window, new object[] { go.GetInstanceID(), expand });
    }
}