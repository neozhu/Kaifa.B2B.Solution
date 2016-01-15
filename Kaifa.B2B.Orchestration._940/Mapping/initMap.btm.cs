namespace Kaifa.B2B.Orchestration._940.Mapping {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.Schemas.InforAPI.InforShipmentOrder", typeof(Kaifa.B2B.Schemas.InforAPI.InforShipmentOrder))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.Schemas.InforAPI.WmsWebService_com_ssaglobal_com+callBackEnd", typeof(Kaifa.B2B.Schemas.InforAPI.WmsWebService_com_ssaglobal_com.callBackEnd))]
    public sealed class initMap : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://com.ssaglobal.com"" xmlns:s0=""http://Kaifa.B2B.Schemas.InforAPI/InforShipmentOrder"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Message"" />
  </xsl:template>
  <xsl:template match=""/s0:Message"">
    <ns0:callBackEnd>
      <ns0:in0>
        <xsl:value-of select=""s0:Head/s0:MessageType/text()"" />
      </ns0:in0>
      <ns0:in1>
        <xsl:value-of select=""s0:Head/s0:MessageType/text()"" />
      </ns0:in1>
      <ns0:in2>
        <xsl:value-of select=""s0:Head/s0:MessageType/text()"" />
      </ns0:in2>
      <ns0:in3>
        <xsl:value-of select=""s0:Head/s0:MessageType/text()"" />
      </ns0:in3>
    </ns0:callBackEnd>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Kaifa.B2B.Schemas.InforAPI.InforShipmentOrder";
        
        private const Kaifa.B2B.Schemas.InforAPI.InforShipmentOrder _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Kaifa.B2B.Schemas.InforAPI.WmsWebService_com_ssaglobal_com+callBackEnd";
        
        private const Kaifa.B2B.Schemas.InforAPI.WmsWebService_com_ssaglobal_com.callBackEnd _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"Kaifa.B2B.Schemas.InforAPI.InforShipmentOrder";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Kaifa.B2B.Schemas.InforAPI.WmsWebService_com_ssaglobal_com+callBackEnd";
                return _TrgSchemas;
            }
        }
    }
}
