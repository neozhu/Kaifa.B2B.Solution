namespace Kaifa.B2B.Mapping {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.Schemas._940.OrderTND940", typeof(Kaifa.B2B.Schemas._940.OrderTND940))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.Schemas._940.CM_TDN_940_Oubound", typeof(Kaifa.B2B.Schemas._940.CM_TDN_940_Oubound))]
    public sealed class CM940_To_TDN : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://Kaifa.B2B.Schemas.940.CM_TDN_940_Oubound"" xmlns:s0=""http://Kaifa.B2B.Schemas.OrderTDN940"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:OrderTDN940"" />
  </xsl:template>
  <xsl:template match=""/s0:OrderTDN940"">
    <ns0:CM_TDN_940_Oubound>
      <xsl:for-each select=""s0:CM_TDN_940"">
        <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(s0:ORDERKEY/text()) , string(s0:ORDERLINENUMBER/text()))"" />
        <ns0:Row>
          <ns0:DeliveryOrder>
            <xsl:value-of select=""s0:ORDERKEY/text()"" />
          </ns0:DeliveryOrder>
          <ns0:CASEID>
            <xsl:value-of select=""$var:v1"" />
          </ns0:CASEID>
          <ns0:RequestOrderLine>
            <xsl:value-of select=""s0:REQUESTORDERLINE/text()"" />
          </ns0:RequestOrderLine>
          <ns0:SKU>
            <xsl:value-of select=""s0:SKU/text()"" />
          </ns0:SKU>
          <ns0:ComponentType>
            <xsl:value-of select=""s0:COMPONENTTYPE/text()"" />
          </ns0:ComponentType>
          <ns0:ComponentTypeDesc>
            <xsl:value-of select=""s0:DESCR/text()"" />
          </ns0:ComponentTypeDesc>
          <ns0:Remarks>
            <xsl:value-of select=""s0:REMARK/text()"" />
          </ns0:Remarks>
          <ns0:Qty>
            <xsl:value-of select=""s0:QTY/text()"" />
          </ns0:Qty>
          <ns0:RequestLocation>
            <xsl:value-of select=""s0:REQLOC/text()"" />
          </ns0:RequestLocation>
          <xsl:variable name=""var:v2"" select=""userCSharp:getrequestime(string(s0:REQUESTEDSHIPDATE/text()))"" />
          <ns0:RequestTime>
            <xsl:value-of select=""$var:v2"" />
          </ns0:RequestTime>
          <ns0:PO>
            <xsl:value-of select=""s0:CMPO/text()"" />
          </ns0:PO>
          <ns0:NOofFeeder>
            <xsl:value-of select=""s0:NOOFFEEDER/text()"" />
          </ns0:NOofFeeder>
          <ns0:SiteCode>
            <xsl:value-of select=""s0:SITE/text()"" />
          </ns0:SiteCode>
          <ns0:VendorCode>
            <xsl:value-of select=""s0:STORERKEY/text()"" />
          </ns0:VendorCode>
          <ns0:SupplierDO>
            <xsl:value-of select=""s0:SUPPLIERDO/text()"" />
          </ns0:SupplierDO>
          <ns0:CountryofOrigin>
            <xsl:value-of select=""s0:COUNTRY/text()"" />
          </ns0:CountryofOrigin>
          <ns0:PrimeOnly>
            <xsl:value-of select=""s0:PRIMEONLY/text()"" />
          </ns0:PrimeOnly>
          <xsl:variable name=""var:v3"" select=""userCSharp:POformatter(string(s0:ASIC/text()) , string(s0:SEAGATEPO/text()) , string(s0:CMSITE/text()))"" />
          <ns0:RequestSite>
            <xsl:value-of select=""$var:v3"" />
          </ns0:RequestSite>
        </ns0:Row>
      </xsl:for-each>
    </ns0:CM_TDN_940_Oubound>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}


public string POformatter(string asic, string po, string cmsite)
        {
            if (asic.ToUpper().Trim() == ""ASIC"")
            {
                return po;
            }
            else
            {
                return po + ""-"" + cmsite;
            }
        }

public string getrequestime(string datetime) {
            //2015-09-22T01:10:00;
            return datetime.Substring(11, 5).Replace("":"", ""-"");
        }


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Kaifa.B2B.Schemas._940.OrderTND940";
        
        private const Kaifa.B2B.Schemas._940.OrderTND940 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Kaifa.B2B.Schemas._940.CM_TDN_940_Oubound";
        
        private const Kaifa.B2B.Schemas._940.CM_TDN_940_Oubound _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Kaifa.B2B.Schemas._940.OrderTND940";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Kaifa.B2B.Schemas._940.CM_TDN_940_Oubound";
                return _TrgSchemas;
            }
        }
    }
}
