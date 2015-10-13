namespace Kaifa.B2B.Orchestration._940.Mapping {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.Schemas._940.CM_940_Inbound", typeof(Kaifa.B2B.Schemas._940.CM_940_Inbound))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.Schemas.InforAPI.InforShipmentOrder", typeof(Kaifa.B2B.Schemas.InforAPI.InforShipmentOrder))]
    public sealed class Cm_940_To_ShipmentOrder : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://Kaifa.B2B.Schemas.InforAPI/InforShipmentOrder"" xmlns:s0=""http://Kaifa.B2B.Schemas.940.CM_940_Inbound"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:CMInbound"" />
  </xsl:template>
  <xsl:template match=""/s0:CMInbound"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringTrimLeft(&quot;ShipmentOrder&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringTrimLeft(&quot;EXceed&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringTrimLeft(&quot;sceadmin&quot;)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringTrimLeft(&quot;STEST_wmwhse1&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringTrimLeft(&quot;SZT&quot;)"" />
    <xsl:variable name=""var:v6"" select=""./s0:Row[1]/s0:PullNo/text()"" />
    <xsl:variable name=""var:v7"" select=""./s0:Row[1]/s0:PO/text()"" />
    <xsl:variable name=""var:v8"" select=""./s0:Row[1]/s0:Site/text()"" />
    <xsl:variable name=""var:v10"" select=""./s0:Row[1]/s0:RequestDate/text()"" />
    <xsl:variable name=""var:v11"" select=""./s0:Row[1]/s0:RequestTime/text()"" />
    <xsl:variable name=""var:v13"" select=""./s0:Row[1]/s0:PrimeOnly/text()"" />
    <ns0:Message>
      <ns0:Head>
        <ns0:MessageType>
          <xsl:value-of select=""$var:v1"" />
        </ns0:MessageType>
        <ns0:Sender>
          <ns0:SystemID>
            <xsl:value-of select=""$var:v2"" />
          </ns0:SystemID>
          <ns0:User>
            <xsl:value-of select=""$var:v3"" />
          </ns0:User>
          <ns0:Password>
            <xsl:value-of select=""$var:v3"" />
          </ns0:Password>
        </ns0:Sender>
        <ns0:Recipient>
          <ns0:SystemID>
            <xsl:value-of select=""$var:v4"" />
          </ns0:SystemID>
        </ns0:Recipient>
      </ns0:Head>
      <ns0:Body>
        <ns0:ShipmentOrder>
          <ns0:ShipmentOrderHeader>
            <ns0:StorerKey>
              <xsl:value-of select=""$var:v5"" />
            </ns0:StorerKey>
            <ns0:ExternOrderKey>
              <xsl:value-of select=""$var:v6"" />
            </ns0:ExternOrderKey>
            <ns0:ExternalOrderKey2>
              <xsl:value-of select=""$var:v7"" />
            </ns0:ExternalOrderKey2>
            <xsl:variable name=""var:v9"" select=""userCSharp:SpiltSite(string($var:v8))"" />
            <ns0:ConsigneeKey>
              <xsl:value-of select=""$var:v9"" />
            </ns0:ConsigneeKey>
            <xsl:variable name=""var:v12"" select=""userCSharp:dateformat(string($var:v10) , string($var:v11))"" />
            <ns0:RequestedShipDate>
              <xsl:value-of select=""$var:v12"" />
            </ns0:RequestedShipDate>
            <xsl:variable name=""var:v14"" select=""userCSharp:getType(string($var:v13))"" />
            <ns0:Type>
              <xsl:value-of select=""$var:v14"" />
            </ns0:Type>
            <xsl:for-each select=""s0:Row"">
              <xsl:variable name=""var:v15"" select=""userCSharp:StringTrimLeft(&quot;SZT&quot;)"" />
              <ns0:ShipmentOrderDetail>
                <xsl:variable name=""var:v16"" select=""userCSharp:PrimeRemark(string(s0:PrimeOnly/text()) , string(s0:Remarks/text()) , string($var:v15))"" />
                <ns0:StorerKey>
                  <xsl:value-of select=""$var:v16"" />
                </ns0:StorerKey>
                <ns0:PriSku>
                  <xsl:value-of select=""s0:SKU/text()"" />
                </ns0:PriSku>
                <ns0:Sku>
                  <xsl:value-of select=""s0:SKU/text()"" />
                </ns0:Sku>
                <ns0:Remark>
                  <xsl:value-of select=""s0:Remarks/text()"" />
                </ns0:Remark>
                <ns0:ReqLoc>
                  <xsl:value-of select=""s0:RequestLocation/text()"" />
                </ns0:ReqLoc>
                <ns0:OpenQty>
                  <xsl:value-of select=""s0:Qty/text()"" />
                </ns0:OpenQty>
                <ns0:PrimeOnly>
                  <xsl:value-of select=""s0:PrimeOnly/text()"" />
                </ns0:PrimeOnly>
                <ns0:SUsr1>
                  <xsl:value-of select=""s0:NOofFeeder/text()"" />
                </ns0:SUsr1>
                <ns0:SUsr2>
                  <xsl:value-of select=""s0:LineNo/text()"" />
                </ns0:SUsr2>
              </ns0:ShipmentOrderDetail>
            </xsl:for-each>
          </ns0:ShipmentOrderHeader>
        </ns0:ShipmentOrder>
      </ns0:Body>
    </ns0:Message>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string SpiltSite(string site) {

            //SNK-KFM
            return site.Trim().Substring(4, 3);
        
        }

public string dateformat(string strdate,string strmin){
            string dt = string.Format(""{0}/{1}/{2}"", strdate.Substring(0, 4), strdate.Substring(4, 2), strdate.Substring(6, 2));
            return string.Format(""{0} {1}"", dt, strmin.Trim().Replace(""-"","":"") + "":00"");
        }

public string getType(string PrimeOnly) {

            if (PrimeOnly.Trim() != ""2"")
                return ""0"";
            else
                return ""10"";

        }

public string StringTrimLeft(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.TrimStart(null);
}


public string PrimeRemark(string pcode, string remark, string storerkey) {

            if (pcode.ToUpper().Trim() == ""2"")
            {
                return remark;
            }
            else
            {
                return storerkey;
            }
        }


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Kaifa.B2B.Schemas._940.CM_940_Inbound";
        
        private const Kaifa.B2B.Schemas._940.CM_940_Inbound _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Kaifa.B2B.Schemas.InforAPI.InforShipmentOrder";
        
        private const Kaifa.B2B.Schemas.InforAPI.InforShipmentOrder _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Kaifa.B2B.Schemas._940.CM_940_Inbound";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Kaifa.B2B.Schemas.InforAPI.InforShipmentOrder";
                return _TrgSchemas;
            }
        }
    }
}
