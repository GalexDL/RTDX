using SkyEditor.IO.FileSystem;
using SkyEditor.RomEditor.Rtdx.Domain;
using SkyEditor.RomEditor.Rtdx.Domain.Automation;

public static class SkyEditorHelpers
{
    public static RtdxRom GetRom(bool useBuiltRom = false)
    {
        return new RtdxRom(useBuiltRom ? ConfigManager.BuildDir : ConfigManager.SourceDir, PhysicalFileSystem.Instance);
    }
    
    public static void SaveRom(RtdxRom rom)
    {
        rom.Save(ConfigManager.BuildDir, PhysicalFileSystem.Instance);
    }
}