using System.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

#if UNITY_EDITOR
[InitializeOnLoad]
#endif
public class ConfigManager
{
    public static Config CurrentConfig { get; private set; }

    public static string SourceDir => CurrentConfig.SourceDir;
    public static string BuildDir => CurrentConfig.BuildDir;
    
    public static string ExeFsSourcePath => Path.Combine(SourceDir, "exefs");
    public static string RomFsSourcePath => Path.Combine(SourceDir, "romfs");
    
    public static string ExeFsBuildPath => Path.Combine(BuildDir, "exefs");
    public static string RomFsBuildPath => Path.Combine(BuildDir, "romfs");
    
    public static string StreamingAssetsSourcePath =>
        Path.Combine(RomFsSourcePath, "Data", "StreamingAssets");
    
    public static string StreamingAssetsBuildPath =>
        Path.Combine(RomFsBuildPath, "Data", "StreamingAssets");
    
    public static string AssetBundleSourcePath =>
        Path.Combine(StreamingAssetsSourcePath, "ab");

    public static string AssetBundleBuildPath =>
        Path.Combine(StreamingAssetsBuildPath, "ab");
    
    static ConfigManager()
    {
        string configYaml = File.ReadAllText(Path.Combine("Data", "config.yml"));
        CurrentConfig = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance).Build()
            .Deserialize<Config>(configYaml);
    }

    public class Config
    {
        // ReSharper disable MemberHidesStaticFromOuterClass
        public string SourceDir { get; set; }
        public string BuildDir { get; set; }
    }
}