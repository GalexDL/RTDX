using System.Collections.Generic;

public class PSMDImportManifest
{
    public string PsmdPkGraphicPath { get; set; }
    public List<Model> Models { get; set; }
    
    public class Model
    {
        public string TargetName { get; set; }
        public int GraphicsDatabaseSlot { get; set; }
        public string PsmdModel { get; set; }
        public string RtdxAnimation { get; set; }
    }
}