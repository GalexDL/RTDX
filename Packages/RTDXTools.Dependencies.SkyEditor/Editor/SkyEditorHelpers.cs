using SkyEditor.IO.FileSystem;
using SkyEditor.RomEditor.Domain.Rtdx;

public static class SkyEditorHelpers
{
    public static RtdxRom GetRom(bool useBuiltRom = false)
    {
        return new RtdxRom(useBuiltRom ? ConfigManager.BuildDir : ConfigManager.SourceDir, PhysicalFileSystem.Instance);
    }
    
    public static void SaveRom(IRtdxRom rom)
    {
        rom.Save(ConfigManager.BuildDir, PhysicalFileSystem.Instance);
    }
}