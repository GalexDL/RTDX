using SkyEditor.IO.FileSystem;
using SkyEditor.RomEditor.Rtdx.Domain;
using SkyEditor.RomEditor.Rtdx.Domain.Automation;

public static class SkyEditorHelpers
{
    public static RtdxRom GetRom()
    {
        return new RtdxRom(RomTools.GetRomPath(), PhysicalFileSystem.Instance);
    }
}