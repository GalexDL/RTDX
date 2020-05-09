using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Wrapper))]
public class PlacementDataEntryInspector : Editor
{
    public static void Edit(PlacementDataEntry entry)
    {
        var wrapper = CreateInstance<Wrapper>();
        wrapper.Entry = entry;

        Selection.activeObject = wrapper;
    }

    private void DrawSceneGUI(SceneView sceneView)
    {
        var transformEntry = ((Wrapper) target).Entry as IHasTransform;
        if (transformEntry == null)
            return;

        // TODO: try to implement the combined transform (position+rotation+scale) handle?
        switch (Tools.current)
        {
            case Tool.Move:
                transformEntry.Position = Handles.PositionHandle(transformEntry.Position, transformEntry.Rotation);
                break;
            case Tool.Rotate:
                transformEntry.Rotation = Handles.RotationHandle(transformEntry.Rotation, transformEntry.Position);
                break;
        }

        var charaPreview = (transformEntry as CharaAsset)?.PreviewModel;
        if (charaPreview != null)
        {
            charaPreview.transform.position = transformEntry.Position;
            charaPreview.transform.rotation = transformEntry.Rotation;
        }
    }

    private void OnEnable()
    {
        SceneView.onSceneGUIDelegate += this.DrawSceneGUI; // OnSceneGUI doesn't seem to work
    }

    private void OnDisable()
    {
        SceneView.onSceneGUIDelegate -= this.DrawSceneGUI;
    }

    public override void OnInspectorGUI()
    {
        var wrapper = (Wrapper) target;
        var entry = wrapper.Entry;
        if (entry == null)
        {
            name = "";
            Selection.activeObject = null;
            return;
        }

        var asset = entry as PlacementDataAsset;
        Draw3DTransformGUI(entry);
        Draw2DTransformGUI(entry);
        DrawAreaGUI(entry);

        EditorGUILayout.LabelField("All Data", EditorStyles.boldLabel);
        
        DrawEntryData(entry.Data);
        
        if (entry.Data.ContainsKey("symbolName") && asset != null)
        {
            asset.Name = entry.Data["symbolName"].Value<string>();
        }
        wrapper.name = entry.ToString();
    }

    private static void Draw3DTransformGUI(PlacementDataEntry entry)
    {
        var asset = entry as Transform3DAsset;
        if (asset == null)
            return;
        
        EditorGUILayout.LabelField("Transform 3D", EditorStyles.boldLabel);
        asset.Position = EditorGUILayout.Vector3Field("Position", asset.Position);
        using (var changeCheck = new EditorGUI.ChangeCheckScope())
        {
            var euler = asset.Rotation.eulerAngles;
            euler = EditorGUILayout.Vector3Field("Rotation", euler);
            if (changeCheck.changed)
            {
                asset.Rotation = Quaternion.Euler(euler);
            }
        }            
        EditorGUILayout.Separator();
    }
    
    private static void Draw2DTransformGUI(PlacementDataEntry entry)
    {
        var asset = entry as Transform2DAsset;
        if (asset == null)
            return;
        
        EditorGUILayout.LabelField("Transform 2D", EditorStyles.boldLabel);
        asset.Position2D = EditorGUILayout.Vector2Field("Position", asset.Position2D);
        asset.Angle = EditorGUILayout.FloatField("Angle (Yaw)", asset.Angle);
        EditorGUILayout.Separator();
    }
    
    private static void DrawAreaGUI(PlacementDataEntry entry)
    {
        var asset = entry as AreaAsset;
        if (asset == null)
            return;
        
        EditorGUILayout.LabelField("Area", EditorStyles.boldLabel);
        asset.Size = EditorGUILayout.Vector2Field("Size", asset.Size);
        EditorGUILayout.Separator();
    }

    private void DrawEntryData(JToken data)
    {
        foreach (var child in data)
        {
            var childProp = child as JProperty;
            if (childProp == null)
                continue;
            
            var childObj = childProp.Value;
            var childObjValue = childObj as JValue;
            var childObjArray = childObj as JArray;
            if (childObjValue != null)
            {
                DrawValueEditField(childProp.Name, childObjValue);
            }
            else if (childObjArray != null)
            {
                EditorGUILayout.LabelField(childProp.Name, $"Array[{childObjArray.Count}]");
            }
            else
            {
                if (DrawAsSpecialType(childProp))
                {
                    continue;
                }
                
                EditorGUILayout.LabelField(childProp.Name);
                EditorGUI.indentLevel++;
                if (childObj != null)
                {
                    DrawEntryData(childObj);
                }
                EditorGUI.indentLevel--;
            }
        }
    }
    
    private bool DrawAsSpecialType(JProperty prop)
    {
        if (!prop.HasValues)
            return false;

        JObject obj = prop.Value as JObject;
        if (obj == null)
            return false;

        float? x = obj.ContainsKey("x") ? obj["x"].Value<float>() : (float?) null;
        float? y = obj.ContainsKey("y") ? obj["y"].Value<float>() : (float?) null;
        float? z = obj.ContainsKey("z") ? obj["z"].Value<float>() : (float?) null;
        float? w = obj.ContainsKey("w") ? obj["w"].Value<float>() : (float?) null;

        var childCount = obj.Children().Count();

        using (var changeCheck = new EditorGUI.ChangeCheckScope())
        {
            if (childCount == 2 && x.HasValue && y.HasValue) // Vector2
            {
                var val = new Vector2(x.Value, y.Value);
                val = EditorGUILayout.Vector2Field(prop.Name, val);
                if (changeCheck.changed)
                {
                    obj["x"] = val.x;
                    obj["y"] = val.y;
                }
                return true;
            }
            
            if (childCount == 3 && x.HasValue && y.HasValue && z.HasValue) // Vector3
            {
                var val = new Vector3(x.Value, y.Value, z.Value);
                val = EditorGUILayout.Vector3Field(prop.Name, val);
                if (changeCheck.changed)
                {
                    obj["x"] = val.x;
                    obj["y"] = val.y;
                    obj["z"] = val.z;
                }
                return true;
            }
            
            if (childCount == 4 && x.HasValue && y.HasValue && z.HasValue && w.HasValue) // Vector4/Quaternion
            {
                var val = new Vector4(x.Value, y.Value, z.Value, w.Value);
                val = EditorGUILayout.Vector4Field(prop.Name, val);
                if (changeCheck.changed)
                {
                    obj["x"] = val.x;
                    obj["y"] = val.y;
                    obj["z"] = val.z;
                    obj["w"] = val.w;
                }
                return true;
            }
        }
        
        return false;
    }


    private void DrawValueEditField(string name, JValue value)
    {
        if (value.Value is string)
        {
            value.Value = EditorGUILayout.TextField(name, (string) value.Value);
        }
        else if (value.Value is float)
        {
            value.Value = EditorGUILayout.FloatField(name, (float) value.Value);
        }
        else if (value.Value is double)
        {
            // Some floats are treated as doubles
            value.Value = EditorGUILayout.FloatField(name, (float) (double) value.Value);
        }
        else if (value.Value is int)
        {
            value.Value = EditorGUILayout.IntField(name, (int) value.Value);
        }
        else if (value.Value is long)
        {
            value.Value = EditorGUILayout.LongField(name, (long) value.Value);
        }
        else if (value.Value is bool)
        {
            // Ints are treated as longs
            value.Value = EditorGUILayout.Toggle(name, (bool) value.Value);
        }
        else
        {
            EditorGUILayout.LabelField(name, value.Value.ToString());
        }
    }

    public class Wrapper : ScriptableObject
    {
        public PlacementDataEntry Entry;
    }
}