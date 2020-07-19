using System.IO;
using System.Linq;
using System.Text;
using ModelResourceInfo = kamina.GameObjectManager.ModelResourceInfo;

public static class ModelResourceInfoEditorUtility
{
    public static ModelResourceInfo CreateResourceInfo(string[] modelNames, ModelResourceInfo.AnimationInfo[] animationInfos)
    {
        var resourceInfo = new ModelResourceInfo();
        resourceInfo.ModelInfoList.AddRange(modelNames.Select(fileName => new ModelResourceInfo.ModelInfo(fileName)));
        resourceInfo.AnimationInfoList.AddRange(animationInfos);
        return resourceInfo;
    }

    public static void WriteToFile(ModelResourceInfo resourceInfo, string path)
    {
        using (var memoryStream = new MemoryStream())
        {
            var writer = new BinaryWriter(memoryStream);
            
            WriteStringDuplicateLengthPrefixed(writer, "mr"); // Header
            
            writer.Write(resourceInfo.ModelInfoList.Count);
            foreach (var modelInfo in resourceInfo.ModelInfoList)
            {
                WriteStringDuplicateLengthPrefixed(writer, modelInfo.file);
            }
            
            writer.Write(resourceInfo.AnimationInfoList.Count);
            foreach (var animationInfo in resourceInfo.AnimationInfoList)
            {
                WriteStringDuplicateLengthPrefixed(writer, animationInfo.symbol);
                WriteStringDuplicateLengthPrefixed(writer, animationInfo.skeletal);
                WriteStringDuplicateLengthPrefixed(writer, animationInfo.material);
            }
            
            File.WriteAllBytes(path, memoryStream.ToArray());
        }
    }

    private static void WriteStringDuplicateLengthPrefixed(BinaryWriter writer, string str)
    {
        // The string length is encoded two times in the resource files for some reason
        writer.Write(str.Length);
        writer.Write(str.Length);
        writer.Write(Encoding.ASCII.GetBytes(str));
    }
}