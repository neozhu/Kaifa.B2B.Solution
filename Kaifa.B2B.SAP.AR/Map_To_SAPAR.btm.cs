namespace Kaifa.B2B.SAP.AR {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.Schemas.Wms.CustARReport", typeof(Kaifa.B2B.Schemas.Wms.CustARReport))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.SAP.AR.ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style+ZfiCreateArForWms", typeof(Kaifa.B2B.SAP.AR.ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style.ZfiCreateArForWms))]
    public sealed class Map_To_SAPAR : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""urn:sap-com:document:sap:soap:functions:mc-style"" xmlns:n0=""urn:sap-com:document:sap:rfc:functions"" xmlns:s0=""http://Kaifa.B2B.Schemas.WMSAR"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:CustARReport"" />
  </xsl:template>
  <xsl:template match=""/s0:CustARReport"">
    <xsl:variable name=""var:v2"" select=""userCSharp:StringTrimLeft(&quot;S&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringTrimLeft(&quot;&quot;)"" />
    <ns0:ZfiCreateArForWms>
      <ArData>
        <xsl:for-each select=""s0:AR"">
          <xsl:variable name=""var:v1"" select=""userCSharp:StringTrimLeft(&quot;RMB&quot;)"" />
          <item>
            <CustomerNo>
              <xsl:value-of select=""s0:CUST_CODE/text()"" />
            </CustomerNo>
            <AmountValue>
              <xsl:value-of select=""s0:COST/text()"" />
            </AmountValue>
            <Currency>
              <xsl:value-of select=""$var:v1"" />
            </Currency>
            <ArType>
              <xsl:value-of select=""s0:INVOICE_TYPE/text()"" />
            </ArType>
          </item>
        </xsl:for-each>
      </ArData>
      <MsgTab>
        <item>
          <Type>
            <xsl:value-of select=""$var:v2"" />
          </Type>
          <Message>
            <xsl:value-of select=""$var:v3"" />
          </Message>
        </item>
      </MsgTab>
      <xsl:variable name=""var:v4"" select=""userCSharp:dtnowstring()"" />
      <PostingDate>
        <xsl:value-of select=""$var:v4"" />
      </PostingDate>
      <WmsBatchid>
        <xsl:value-of select=""s0:AR/s0:ARBATCHID/text()"" />
      </WmsBatchid>
    </ns0:ZfiCreateArForWms>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringTrimLeft(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.TrimStart(null);
}


public string dtnowstring() {
            return DateTime.Now.ToString(""yyyy-MM-dd"");
        }


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Kaifa.B2B.Schemas.Wms.CustARReport";
        
        private const Kaifa.B2B.Schemas.Wms.CustARReport _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Kaifa.B2B.SAP.AR.ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style+ZfiCreateArForWms";
        
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
                _SrcSchemas[0] = @"Kaifa.B2B.Schemas.Wms.CustARReport";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Kaifa.B2B.SAP.AR.ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style+ZfiCreateArForWms";
                return _TrgSchemas;
            }
        }
    }
}
