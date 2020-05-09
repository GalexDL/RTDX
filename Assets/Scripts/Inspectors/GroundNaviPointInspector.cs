using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GroundNaviPoint))]
public class GroundNaviPointInspector : UnityEditor.Editor
{
    public bool Edit;

    private int _selectedPointIndex = -1;
    private bool _ctrlDown = false;
    private bool _altDown = false;
    private bool _spaceDown = false;

    private void OnEnable()
    {
        System.Reflection.FieldInfo info = typeof (EditorApplication).GetField ("globalEventHandler", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
        EditorApplication.CallbackFunction value = (EditorApplication.CallbackFunction)info.GetValue (null);
        value += HandleKeyEvents;
        info.SetValue (null, value);
    }

    private void OnDisable()
    {
        System.Reflection.FieldInfo info = typeof (EditorApplication).GetField ("globalEventHandler", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
        EditorApplication.CallbackFunction value = (EditorApplication.CallbackFunction)info.GetValue (null);
        value -= HandleKeyEvents;
        info.SetValue (null, value);

        _ctrlDown = false;
        _altDown = false;
        _spaceDown = false;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        
        EditorGUILayout.Space();
        Edit = EditorGUILayout.ToggleLeft("Edit", Edit);
    }

    private void OnSceneGUI()
    {
        if (!Edit)
            return;

        HandleKeyEvents();

        var assetSo = GetAsset();
        var points = assetSo.FindProperty("wayPoints");
        if (points == null)
            return;
        
        for (int i = 0; i < points.arraySize; i++)
        {
            var waypoint = points.GetArrayElementAtIndex(i);
            var posProp = waypoint.FindPropertyRelative("pos");
            var pointXZ = posProp.vector2Value;
            
            var point = new Vector3(pointXZ.x, 0, pointXZ.y);

            if (_selectedPointIndex == i)
            {
                point = Handles.PositionHandle(point, Quaternion.identity);
                var newPoint = new Vector2(point.x, point.z);
                if (newPoint != pointXZ)
                {
                    posProp.vector2Value = newPoint;
                    assetSo.ApplyModifiedProperties();
                }
            }
            else 
            {
                if (_ctrlDown)
                    Handles.color = Color.red;
                else if (_altDown)
                    Handles.color = Color.blue;
                else if (_spaceDown)
                    Handles.color = Color.green;
                else
                    Handles.color = Color.cyan;
                if (Handles.Button(point, Quaternion.Euler(90, 0, 0), 0.5f, 0.5f, Handles.ConeHandleCap))
                {
                    if (_ctrlDown)
                    {
                        // Unlink
                        UnlinkIfLinked(points, i, _selectedPointIndex);
                        assetSo.ApplyModifiedProperties();
                    }
                    else if (_altDown)
                    {
                        // Unlink first to prevent duplicate link
                        UnlinkIfLinked(points, i, _selectedPointIndex);
                        Link(points, i, _selectedPointIndex);
                        assetSo.ApplyModifiedProperties();
                    }
                    
                    _selectedPointIndex = i;
                }
            }
        }

    }

    private SerializedObject GetAsset()
    {
        var asset = serializedObject.FindProperty("asset")?.objectReferenceValue;
        if (asset == null)
            return null;
        
        return new SerializedObject(asset);
    }

    private void UnlinkIfLinked(SerializedProperty points, int a, int b)
    {
        if (a < 0 || b < 0)
            return;
        
        var waypointA = points.GetArrayElementAtIndex(a);
        var waypointB = points.GetArrayElementAtIndex(b);
        
        RemoveLink(waypointA, b);
        RemoveLink(waypointB, a);
    }
    
    private void Link(SerializedProperty points, int a, int b)
    {
        if (a < 0 || b < 0)
            return;
        
        var waypointA = points.GetArrayElementAtIndex(a);
        var waypointB = points.GetArrayElementAtIndex(b);

        AddLink(waypointA, b);
        AddLink(waypointB, a);
    }
    
    private void AddLink(SerializedProperty waypoint, int link)
    {
        var linksProp = waypoint.FindPropertyRelative("link");
        linksProp.InsertArrayElementAtIndex(linksProp.arraySize);
        linksProp.GetArrayElementAtIndex(linksProp.arraySize - 1).intValue = link;
    }

    private void RemoveLink(SerializedProperty waypoint, int link)
    {
        var linksProp = waypoint.FindPropertyRelative("link");
        for (int i = 0; i < linksProp.arraySize; i++)
        {
            if (linksProp.GetArrayElementAtIndex(i).intValue == link)
            {
                linksProp.DeleteArrayElementAtIndex(i);
                return;
            }
        }
    }
    
    private void ShiftLinks(SerializedProperty waypoint)
    {
        var linksProp = waypoint.FindPropertyRelative("link");
        for (int i = 0; i < linksProp.arraySize; i++)
        {
            if (linksProp.GetArrayElementAtIndex(i).intValue >= _selectedPointIndex)
            {
                linksProp.GetArrayElementAtIndex(i).intValue--;
            }
        }
    }

    private void DeleteSelectedPoint()
    {
        var assetSo = GetAsset();
        var waypoints = assetSo.FindProperty("wayPoints");

        for (int i = 0; i < waypoints.arraySize; i++)
        {
            // Remove all links to this point
            RemoveLink(waypoints.GetArrayElementAtIndex(i), _selectedPointIndex);
        }

        for (int i = _selectedPointIndex; i < waypoints.arraySize - 1; i++)
        {
            // Delete the waypoint
            ShiftLinks(waypoints.GetArrayElementAtIndex(i));
            waypoints.MoveArrayElement(i + 1, i);
        }

        waypoints.arraySize--;

        assetSo.ApplyModifiedProperties();
        _selectedPointIndex = -1;
    }

    private void HandleKeyEvents()
    {
        var e = Event.current;
        if (e.type == EventType.KeyDown)
        {
            if (e.keyCode == KeyCode.A)
            {
                e.Use();
                
                if (_selectedPointIndex >= 0)
                {
                    var asset = GetAsset();
                    var waypoints = asset.FindProperty("wayPoints");
                    waypoints.InsertArrayElementAtIndex(waypoints.arraySize);

                    int idx = waypoints.arraySize - 1;
                    waypoints.GetArrayElementAtIndex(idx).FindPropertyRelative("pos").vector2Value
                        = waypoints.GetArrayElementAtIndex(_selectedPointIndex).FindPropertyRelative("pos").vector2Value + Vector2.right * 0.5f;
                    var links = waypoints.GetArrayElementAtIndex(idx).FindPropertyRelative("link");
                    links.arraySize = 1;
                    links.GetArrayElementAtIndex(0).intValue = idx;

                    _selectedPointIndex = idx;
                    asset.ApplyModifiedProperties();
                }
            }
            if (e.keyCode == KeyCode.LeftControl || e.keyCode == KeyCode.RightControl)
            {
                _ctrlDown = true;
            }
            if (e.keyCode == KeyCode.LeftAlt || e.keyCode == KeyCode.RightAlt)
            {
                _altDown = true;
            }
            if (e.keyCode == KeyCode.Space)
            {
                _spaceDown = true;
                e.Use();
            }
            if (e.keyCode == KeyCode.Delete)
            {
                if (!Edit)
                    return;
                
                e.Use();
                if (_selectedPointIndex >= 0)
                {
                    DeleteSelectedPoint();
                }
            }
        }
        else if (e.type == EventType.KeyUp)
        {
            if (e.keyCode == KeyCode.LeftControl || e.keyCode == KeyCode.RightControl)
            {
                _ctrlDown = false;
            }
            if (e.keyCode == KeyCode.LeftAlt || e.keyCode == KeyCode.RightAlt)
            {
                _altDown = false;
            }
            if (e.keyCode == KeyCode.Space)
            {
                _spaceDown = false;
            }
        }
    }
    
}
