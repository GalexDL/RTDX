using Newtonsoft.Json.Linq;
using UnityEngine;

public abstract class PlacementDataEntry
{
    public abstract string Type { get; }

    public JObject Data;

    public override string ToString()
    {
        return Type;
    }
}

public abstract class PlacementDataAsset : PlacementDataEntry
{
    public string Name;
        
    public override string Type => "ASSET";
    public abstract string AssetType { get; }

    public override string ToString()
    {
        return $"{Name} ({AssetType})";
    }
}

public abstract class Transform3DAsset : PlacementDataAsset, IHasTransform
{
    public Vector3 Position
    {
        get { return Data["pos"]["pos"].Vector3Value(); }
        set { Data["pos"]["pos"].Vector3Value(value); }
    }
    
    public Quaternion Rotation
    {
        get { return Data["rot"]["rotQ"].QuaternionValue(); }
        set { Data["rot"]["rotQ"].QuaternionValue(value); }
    }
}

public abstract class Transform2DAsset : PlacementDataAsset, IHasTransform
{
    public Vector3 Position
    {
        get
        {
            var pos2d = Position2D;
            return new Vector3(pos2d.x, 0, pos2d.y);
        }
        set
        {
            Position2D = new Vector2(value.x, value.z);
        }
    }

    public Quaternion Rotation
    {
        get { return Quaternion.Euler(0, Angle, 0); }
        set { Angle = value.eulerAngles.y; }
    }

    public Vector2 Position2D
    {
        get { return Data["pos2d"].Vector2Value(); }
        set { Data["pos2d"].Vector2Value(value); }
    }
    
    public float Angle
    {
        get { return Data["rotYaw"].Value<float>(); }
        set { Data["rotYaw"] = value; }
    }
}

public abstract class AreaAsset : Transform2DAsset
{
    public Vector2 Size
    {
        get { return Data["size"].Vector2Value(); }
        set { Data["size"].Vector2Value(value); }
    }

    public abstract Color HandleColor { get; }
}

public class CharaAsset : Transform3DAsset
{
    public override string AssetType => "ActAsset_Chara";
    public GameObject PreviewModel { get; set; }
}

public class PointAsset : Transform3DAsset
{
    public override string AssetType => "ActAsset_Point";
}

public class TriggerAsset : AreaAsset
{
    public override string AssetType => "ActAsset_Trigger";
    public override Color HandleColor => Color.red;
}

public class BgmAreaAsset : AreaAsset
{
    public override string AssetType => "ActAsset_BgmArea";
    public override Color HandleColor => Color.green;
}

public class MoveAreaAsset : AreaAsset
{
    public override string AssetType => "ActAsset_MoveArea";
    public override Color HandleColor => Color.blue;
}

public class OtherAsset : PlacementDataAsset
{
    public OtherAsset(string assetType)
    {
        AssetType = assetType;
    }

    public override string AssetType { get; }
}

public class Misc : PlacementDataEntry
{
    public override string Type => "MISC";
}

public interface IHasTransform
{
    Vector3 Position { get; set; }
    Quaternion Rotation { get; set; }
}