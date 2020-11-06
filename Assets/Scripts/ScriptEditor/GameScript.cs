using System.Collections;
using System.Collections.Generic;

public class GameScript
{
    public List<ScriptDataBlobBase> Blobs { get; } = new List<ScriptDataBlobBase>();
    
    public GameScript(string contents)
    {
        int blobStartLine = 0;
        var lines = contents.Split('\n');
        
        for (int i = 0; i < lines.Length; i++)
        {
            if (i == lines.Length - 1 || lines[i+1].StartsWith("-- <<★"))
            {
                string blobContents = string.Join("\n", lines, blobStartLine, i - blobStartLine + 1);
                Blobs.Add(new StubBlob(blobContents));
                
                // Ignore empty lines
                while (i < lines.Length && lines[i].Trim() == string.Empty)
                {
                    i++;
                }
                blobStartLine = i;
            }
        }
    }
}

public class StubBlob : ScriptDataBlobBase
{
    public string Contents { get; set; }

    public StubBlob(string contents)
    {
        Contents = contents;
    }
    
    public override void ForceSerialize()
    {
        throw new System.NotImplementedException();
    }

    public override void OnBlobSerialize(out string serializeType, out string serializeData)
    {
        throw new System.NotImplementedException();
    }

    public override void OnBlobDeserialize(string serializeData)
    {
        throw new System.NotImplementedException();
    }

    public override IEnumerator Play(ScriptDataPlayer.PlayerContext playerContext)
    {
        throw new System.NotImplementedException();
    }
}

public class CustomScenePartitionBlob : ScenePartitionBlob
{
    public override IEnumerator Play(ScriptDataPlayer.PlayerContext playerContext)
    {
        yield return null;
    }
}

