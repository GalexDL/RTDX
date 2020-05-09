using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Linq;
using System.Reflection;

[InitializeOnLoad]
public class EditorMeshHelper
{
    private static readonly MethodInfo intersectRayMeshMethod;

    static EditorMeshHelper()
    {
        var editorTypes = typeof(Editor).Assembly.GetTypes();
        var handleUtility = editorTypes.FirstOrDefault(t => t.Name == "HandleUtility");
        intersectRayMeshMethod =
            handleUtility?.GetMethod("IntersectRayMesh", BindingFlags.Static | BindingFlags.NonPublic);
    }

    public static bool IntersectRayMesh(Ray ray, MeshFilter meshFilter, out RaycastHit hit)
    {
        return IntersectRayMesh(ray, meshFilter.mesh, meshFilter.transform.localToWorldMatrix, out hit);
    }

    private static bool IntersectRayMesh(Ray ray, Mesh mesh, Matrix4x4 matrix, out RaycastHit hit)
    {
        var parameters = new object[] {ray, mesh, matrix, null};
        bool result = (bool) intersectRayMeshMethod.Invoke(null, parameters);
        hit = (RaycastHit) parameters[3];
        return result;
    }
}