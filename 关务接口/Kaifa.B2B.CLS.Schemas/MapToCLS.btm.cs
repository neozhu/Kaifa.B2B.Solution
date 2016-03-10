namespace Kaifa.B2B.CLS.Schemas {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.CLS.Schemas.PREDIS", typeof(Kaifa.B2B.CLS.Schemas.PREDIS))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.CLS.Schemas.PRE_DIS_B2B", typeof(Kaifa.B2B.CLS.Schemas.PRE_DIS_B2B))]
    public sealed class MapToCLS : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://Kaifa.B2B.Schemas.PREDIS"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PREDIS"" />
  </xsl:template>
  <xsl:template match=""/s0:PREDIS"">
    <xsl:variable name=""var:v1"" select=""./s0:PREDISB2B[1]/s0:ORDERKEY/text()"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringUpperCase(&quot; &quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringUpperCase(&quot;E&quot;)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringUpperCase(&quot;LS55&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringUpperCase(&quot;CT01&quot;)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:StringUpperCase(&quot;3225540006&quot;)"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:StringUpperCase(&quot;3205632001&quot;)"" />
    <xsl:variable name=""var:v8"" select=""./s0:PREDISB2B[1]/s0:TOTALQTY/text()"" />
    <xsl:variable name=""var:v9"" select=""./s0:PREDISB2B[1]/s0:TOTALGROSSWGT/text()"" />
    <xsl:variable name=""var:v10"" select=""userCSharp:StringUpperCase(&quot;kaifa&quot;)"" />
    <xsl:variable name=""var:v11"" select=""s0:PREDISB2B/s0:ACTUALSHIPDATE/text()"" />
    <xsl:variable name=""var:v12"" select=""userCSharp:StringUpperCase(&quot;3225540001&quot;)"" />
    <xsl:variable name=""var:v13"" select=""userCSharp:StringUpperCase(&quot;苏州长城开发科技有限公司&quot;)"" />
    <xsl:variable name=""var:v14"" select=""userCSharp:StringUpperCase(&quot;Q23582015000038&quot;)"" />
    <xsl:variable name=""var:v15"" select=""userCSharp:StringUpperCase(&quot;5&quot;)"" />
    <xsl:variable name=""var:v16"" select=""userCSharp:StringUpperCase(&quot;NJ&quot;)"" />
    <xsl:variable name=""var:v17"" select=""userCSharp:StringUpperCase(&quot;7301&quot;)"" />
    <PRE_DIS_B2B>
      <PRE_DIS_HEAD_B2B>
        <B2B_OBJECT_ID>
          <xsl:value-of select=""$var:v1"" />
        </B2B_OBJECT_ID>
        <COR_NO>
          <xsl:value-of select=""$var:v2"" />
        </COR_NO>
        <IE_MARK>
          <xsl:value-of select=""$var:v3"" />
        </IE_MARK>
        <BIZ_TYPE>
          <xsl:value-of select=""$var:v4"" />
        </BIZ_TYPE>
        <TRAF_WAY>
          <xsl:value-of select=""$var:v5"" />
        </TRAF_WAY>
        <IN_COMP_CODE>
          <xsl:value-of select=""$var:v6"" />
        </IN_COMP_CODE>
        <OUT_COMP_CODE>
          <xsl:value-of select=""$var:v7"" />
        </OUT_COMP_CODE>
        <NUM>
          <xsl:value-of select=""$var:v8"" />
        </NUM>
        <GROSS_WT>
          <xsl:value-of select=""$var:v9"" />
        </GROSS_WT>
        <NET_WT>
          <xsl:value-of select=""$var:v9"" />
        </NET_WT>
        <PRE_MAN>
          <xsl:value-of select=""$var:v2"" />
        </PRE_MAN>
        <PRE_DATE>
          <xsl:value-of select=""$var:v9"" />
        </PRE_DATE>
        <REMARK>
          <xsl:value-of select=""$var:v1"" />
        </REMARK>
        <CREATEUSERID>
          <xsl:value-of select=""$var:v10"" />
        </CREATEUSERID>
        <CREATETIMESTAMP>
          <xsl:value-of select=""$var:v11"" />
        </CREATETIMESTAMP>
        <INPUTER_CODE>
          <xsl:value-of select=""$var:v12"" />
        </INPUTER_CODE>
        <INPUTER_NAME>
          <xsl:value-of select=""$var:v13"" />
        </INPUTER_NAME>
        <APP_NO>
          <xsl:value-of select=""$var:v14"" />
        </APP_NO>
        <WRAP_TYPE>
          <xsl:value-of select=""$var:v15"" />
        </WRAP_TYPE>
        <B2B_UPLOAD_DATE>
          <xsl:value-of select=""$var:v11"" />
        </B2B_UPLOAD_DATE>
        <AREA_NO>
          <xsl:value-of select=""$var:v16"" />
        </AREA_NO>
        <DOWNGOODS_NO>
          <xsl:value-of select=""$var:v17"" />
        </DOWNGOODS_NO>
      </PRE_DIS_HEAD_B2B>
      <xsl:for-each select=""s0:PREDISB2B"">
        <xsl:variable name=""var:v18"" select=""userCSharp:StringUpperCase(&quot;502&quot;)"" />
        <xsl:variable name=""var:v19"" select=""userCSharp:StringUpperCase(&quot; &quot;)"" />
        <PRE_DIS_BODY_B2B>
          <B2B_OBJECT_ID>
            <xsl:value-of select=""s0:ORDERKEY/text()"" />
          </B2B_OBJECT_ID>
          <PART_NO>
            <xsl:value-of select=""s0:SKU/text()"" />
          </PART_NO>
          <PO_NO>
            <xsl:value-of select=""s0:LOTTABLE03/text()"" />
          </PO_NO>
          <DO_NO>
            <xsl:value-of select=""s0:LOTTABLE02/text()"" />
          </DO_NO>
          <CURR>
            <xsl:value-of select=""$var:v18"" />
          </CURR>
          <COMMON_NUM>
            <xsl:value-of select=""s0:QTY/text()"" />
          </COMMON_NUM>
          <TOTAL>
            <xsl:value-of select=""s0:TOTALPRICE/text()"" />
          </TOTAL>
          <NOTE>
            <xsl:value-of select=""$var:v19"" />
          </NOTE>
          <WEIGHT>
            <xsl:value-of select=""s0:NETWGT/text()"" />
          </WEIGHT>
        </PRE_DIS_BODY_B2B>
      </xsl:for-each>
    </PRE_DIS_B2B>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringUpperCase(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.ToUpper(System.Globalization.CultureInfo.InvariantCulture);
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Kaifa.B2B.CLS.Schemas.PREDIS";
        
        private const string _strTrgSchemasList0 = @"Kaifa.B2B.CLS.Schemas.PRE_DIS_B2B";
        
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
                _SrcSchemas[0] = @"Kaifa.B2B.CLS.Schemas.PREDIS";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Kaifa.B2B.CLS.Schemas.PRE_DIS_B2B";
                return _TrgSchemas;
            }
        }
    }
}
