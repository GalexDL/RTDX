using SkyEditor.IO.FileSystem;
using SkyEditor.RomEditor.Rtdx.Domain;
using SkyEditor.RomEditor.Rtdx.Domain.Automation;

public static class SkyEditorHelpers
{
    public static RtdxRom GetRom()
    {
        return new RtdxRom(ConfigManager.SourceDir, PhysicalFileSystem.Instance);
    }
    
    public static void SaveRom(RtdxRom rom)
    {
        rom.Save(ConfigManager.BuildDir, PhysicalFileSystem.Instance);
    }
}