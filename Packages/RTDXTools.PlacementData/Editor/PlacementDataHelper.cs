using Newtonsoft.Json.Linq;
using UnityEngine;

public static class PlacementDataHelper
{
    public static Vector2 Vector2Value(this JToken token)
    {
        float x = token["x"].Value<float>();
        float y = token["y"].Value<float>();
        return new Vector2(x, y);
    }
    
    public static void Vector2Value(this JToken token, Vector2 value)
    {
        token["x"] = value.x;
        token["y"] = value.y;
    }

    
    public static Vector3 Vector3Value(this JToken token)
    {
        float x = token["x"].Value<float>();
        float y = token["y"].Value<float>();
        float z = token["z"].Value<float>();
        return new Vector3(x, y, z);
    }
    
    public static void Vector3Value(this JToken token, Vector3 value)
    {
        token["x"] = value.x;
        token["y"] = value.y;
        token["z"] = value.z;
    }
    
    public static Quaternion QuaternionValue(this JToken token)
    {
        float x = token["x"].Value<float>();
        float y = token["y"].Value<float>();
        float z = token["z"].Value<float>();
        float w = token["w"].Value<float>();
        return new Quaternion(x, y, z, w);
    }
    
    public static void QuaternionValue(this JToken token, Quaternion value)
    {
        token["x"] = value.x;
        token["y"] = value.y;
        token["z"] = value.z;
        token["w"] = value.w;
    }
}