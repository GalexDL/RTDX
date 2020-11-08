using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class GameScript
{
    public List<CustomBlobBase> Blobs { get; } = new List<CustomBlobBase>();
    
    public GameScript(string contents)
    {
        int blobStartLine = 0;
        var lines = contents.Replace("\r\n", "\n").Split(new []{"\n"}, StringSplitOptions.None);

        for (int i = 0; i < lines.Length; i++)
        {
            if (i == lines.Length - 1 || lines[i+1].StartsWith("-- <<★"))
            {
                string blobContents = string.Join("\n", lines, blobStartLine + 1, i - blobStartLine);
                string blobHeader = lines[blobStartLine].Substring(6);
                var splitHeader = blobHeader.Split('★');
                string blobType = splitHeader[0];
                bool skipBlob = splitHeader.Length > 1 && splitHeader[1].Trim() == "[Skip]";
                CustomBlobBase blob;
                
                switch (blobType)
                {
                    case "LuaBlob":
                        blob = new CustomLuaBlob();
                        break;
                    case "ScenePartitionBlob":
                        blob = new CustomScenePartitionBlob();
                        break;
                    case "ActAssetBlob":
                        blob = new CustomActAssetBlob();
                        break;
                    case "ActCommandBlob":
                        blob = new CustomActCommandBlob();
                        break;
                    case "CutsceneBlob":
                    case "BranchLabelBlob":
                    case "BranchEndBlob":
                    default:
                        blob = new StubBlob();
                        break;
                }

                blob.Name = blobType;
                blob.Skipped = skipBlob;
                blob.Contents = blobContents;
                blob.Read();

                Blobs.Add(blob);
                
                blobStartLine = i+1;
            }
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        
        foreach (var blob in Blobs)
        {
            sb.Append($"-- <<★{blob.Name}");
            if (blob.Skipped)
            {
                sb.Append("★[Skip]");
            }
            sb.AppendLine();
            sb.AppendLine(blob.Save());
        }

        sb.AppendLine();

        return sb.ToString();
    }
}

public abstract class CustomBlobBase
{
    public string Name { get; set; }
    public string Contents { get; set; }
    public bool Skipped { get; set; }
    public abstract bool IsPlayable { get; }
    public abstract UnityEngine.Color Color { get; }

    public abstract void Read();
    public abstract string Save();

    public abstract IEnumerator Play();
}

public class StubBlob : CustomBlobBase
{
    public override bool IsPlayable => false;
    public override UnityEngine.Color Color => UnityEngine.Color.gray;

    public override void Read()
    {
    }

    public override string Save()
    {
        return Contents;
    }

    public override IEnumerator Play()
    {
        throw new NotSupportedException();
    }
}

public class CustomScenePartitionBlob : CustomBlobBase
{
    public static UnityEngine.Color StaticColor = new Color(1f, 0.46f, 0.32f);
    
    public override bool IsPlayable => false;
    public override UnityEngine.Color Color => StaticColor;

    public override void Read()
    {
    }

    public override string Save()
    {
        return Contents;
    }

    public override IEnumerator Play()
    {
        throw new NotSupportedException();
    }
}

public class CustomActAssetBlob : CustomBlobBase
{
    public override bool IsPlayable => false;
    public override UnityEngine.Color Color => UnityEngine.Color.green;

    public override void Read()
    {
    }

    public override string Save()
    {
        return Contents;
    }

    public override IEnumerator Play()
    {
        throw new NotSupportedException();
    }
}

public class CustomActCommandBlob : CustomBlobBase
{
    public override bool IsPlayable => false;
    public override UnityEngine.Color Color => UnityEngine.Color.cyan;

    public override void Read()
    {
    }

    public override string Save()
    {
        return Contents;
    }

    public override IEnumerator Play()
    {
        throw new NotSupportedException();
    }
}

public class CustomLuaBlob : CustomBlobBase
{
    public override bool IsPlayable => false;
    public override UnityEngine.Color Color => UnityEngine.Color.yellow;

    public override void Read()
    {
    }

    public override string Save()
    {
        return Contents;
    }

    public override IEnumerator Play()
    {
        throw new NotSupportedException();
    }
}
