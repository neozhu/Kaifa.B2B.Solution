namespace Kaifa.B2B.SZD.Mapping {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.Schemas.Wms.VendorReceiptReport", typeof(Kaifa.B2B.Schemas.Wms.VendorReceiptReport))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification", typeof(Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification))]
    public sealed class ASN_To_4B2_STX : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://kaifa.b2b.schemas/AdvancedShipNotice"" xmlns:ns0=""http://kaifa.b2b.schemas/SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:VendorReceiptReport"" />
  </xsl:template>
  <xsl:template match=""/s0:VendorReceiptReport"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringTrimLeft(&quot;Consignee&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringTrimLeft(&quot;894720952&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringTrimLeft(&quot;Electronic Components&quot;)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringTrimLeft(&quot;Freight Forwarder&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringTrimLeft(&quot;Request&quot;)"" />
    <xsl:variable name=""var:v14"" select=""userCSharp:StringTrimLeft(&quot;Shipment Information User&quot;)"" />
    <xsl:variable name=""var:v15"" select=""userCSharp:StringTrimLeft(&quot;Manufacturer&quot;)"" />
    <ns0:Pip4B2ShipmentReceiptNotification>
      <ns0:fromRole>
        <ns0:PartnerRoleDescription>
          <ns0:ContactInformation>
            <ns0:contactName>
              <ns0:FreeFormText>
                <xsl:value-of select=""s0:config/s0:fromRole/s0:contactName/text()"" />
              </ns0:FreeFormText>
            </ns0:contactName>
            <ns0:EmailAddress>
              <xsl:value-of select=""s0:config/s0:fromRole/s0:EmailAddress/text()"" />
            </ns0:EmailAddress>
            <ns0:facsimileNumber>
              <ns0:CommunicationsNumber>
                <xsl:value-of select=""s0:config/s0:fromRole/s0:facsimileNumber/text()"" />
              </ns0:CommunicationsNumber>
            </ns0:facsimileNumber>
            <ns0:telephoneNumber>
              <ns0:CommunicationsNumber>
                <xsl:value-of select=""s0:config/s0:fromRole/s0:telephoneNumber/text()"" />
              </ns0:CommunicationsNumber>
            </ns0:telephoneNumber>
          </ns0:ContactInformation>
          <ns0:GlobalPartnerRoleClassificationCode>
            <xsl:value-of select=""$var:v1"" />
          </ns0:GlobalPartnerRoleClassificationCode>
          <ns0:PartnerDescription>
            <ns0:BusinessDescription>
              <ns0:GlobalBusinessIdentifier>
                <xsl:value-of select=""$var:v2"" />
              </ns0:GlobalBusinessIdentifier>
              <ns0:GlobalSupplyChainCode>
                <xsl:value-of select=""$var:v3"" />
              </ns0:GlobalSupplyChainCode>
            </ns0:BusinessDescription>
            <ns0:GlobalPartnerClassificationCode>
              <xsl:value-of select=""$var:v4"" />
            </ns0:GlobalPartnerClassificationCode>
          </ns0:PartnerDescription>
        </ns0:PartnerRoleDescription>
      </ns0:fromRole>
      <ns0:GlobalDocumentFunctionCode>
        <xsl:value-of select=""$var:v5"" />
      </ns0:GlobalDocumentFunctionCode>
      <xsl:for-each select=""s0:RECEIPT"">
        <xsl:for-each select=""s0:RECEIPTDETAIL"">
          <xsl:variable name=""var:v6"" select=""userCSharp:StringTrimLeft(&quot;Work Order&quot;)"" />
          <xsl:variable name=""var:v7"" select=""userCSharp:StringTrimLeft(&quot;1&quot;)"" />
          <xsl:variable name=""var:v8"" select=""userCSharp:StringTrimLeft(&quot;Each&quot;)"" />
          <xsl:variable name=""var:v9"" select=""userCSharp:StringTrimLeft(&quot;Manufacturer&quot;)"" />
          <ns0:ShipmentReceiptInformationResource>
            <ns0:shipmentIdentifier>
              <xsl:if test=""../s0:RECEIPTKEY"">
                <ns0:ProprietaryReferenceIdentifier>
                  <xsl:value-of select=""../s0:RECEIPTKEY/text()"" />
                </ns0:ProprietaryReferenceIdentifier>
              </xsl:if>
            </ns0:shipmentIdentifier>
            <ns0:ShipmentReceiptNotificationLineItem>
              <ns0:acceptedQuantity>
                <xsl:if test=""s0:QTYRECEIVED"">
                  <ns0:ProductQuantity>
                    <xsl:value-of select=""s0:QTYRECEIVED/text()"" />
                  </ns0:ProductQuantity>
                </xsl:if>
              </ns0:acceptedQuantity>
              <ns0:DocumentSubLineReference>
                <ns0:GlobalDocumentReferenceTypeCode>
                  <xsl:value-of select=""$var:v6"" />
                </ns0:GlobalDocumentReferenceTypeCode>
                <ns0:LineNumber>
                  <xsl:value-of select=""$var:v7"" />
                </ns0:LineNumber>
                <xsl:if test=""s0:LOTTABLE02"">
                  <ns0:ProprietaryDocumentIdentifier>
                    <xsl:value-of select=""s0:LOTTABLE02/text()"" />
                  </ns0:ProprietaryDocumentIdentifier>
                </xsl:if>
              </ns0:DocumentSubLineReference>
              <ns0:GlobalProductUnitOfMeasureCode>
                <xsl:value-of select=""$var:v8"" />
              </ns0:GlobalProductUnitOfMeasureCode>
              <ns0:ProductIdentification>
                <ns0:PartnerProductIdentification>
                  <ns0:GlobalPartnerClassificationCode>
                    <xsl:value-of select=""$var:v9"" />
                  </ns0:GlobalPartnerClassificationCode>
                  <xsl:if test=""s0:SKU"">
                    <ns0:ProprietaryProductIdentifier>
                      <xsl:value-of select=""s0:SKU/text()"" />
                    </ns0:ProprietaryProductIdentifier>
                  </xsl:if>
                  <ns0:SeagateProprietaryLocator>
                    <xsl:variable name=""var:v10"" select=""userCSharp:SeagateProprietaryLocator(string(../../s0:config/s0:fromRole/s0:Site/text()) , string(../s0:STORERKEY/text()) , string(s0:LOTTABLE02/text()) , string(s0:DOREMARK/text()) , string(s0:LOTTABLE03/text()) , string(../s0:TYPE/text()))"" />
                    <ns0:FreeFormText>
                      <xsl:value-of select=""$var:v10"" />
                    </ns0:FreeFormText>
                  </ns0:SeagateProprietaryLocator>
                </ns0:PartnerProductIdentification>
              </ns0:ProductIdentification>
              <ns0:receivedBy>
                <ns0:PartnerDescription>
                  <ns0:BusinessDescription>
                    <ns0:GlobalBusinessIdentifier>
                      <xsl:value-of select=""../../s0:config/s0:fromRole/s0:GlobalBusinessIdentifier/text()"" />
                    </ns0:GlobalBusinessIdentifier>
                  </ns0:BusinessDescription>
                </ns0:PartnerDescription>
              </ns0:receivedBy>
              <ns0:receivedQuantity>
                <xsl:if test=""s0:QTYRECEIVED"">
                  <ns0:ProductQuantity>
                    <xsl:value-of select=""s0:QTYRECEIVED/text()"" />
                  </ns0:ProductQuantity>
                </xsl:if>
              </ns0:receivedQuantity>
              <ns0:shipmentReceiptReportDateTime>
                <xsl:variable name=""var:v11"" select=""userCSharp:convertdatetimestring(string(s0:LOTTABLE04/text()))"" />
                <ns0:DateTimeStamp>
                  <xsl:value-of select=""$var:v11"" />
                </ns0:DateTimeStamp>
              </ns0:shipmentReceiptReportDateTime>
            </ns0:ShipmentReceiptNotificationLineItem>
          </ns0:ShipmentReceiptInformationResource>
        </xsl:for-each>
      </xsl:for-each>
      <ns0:thisDocumentGenerationDateTime>
        <xsl:variable name=""var:v12"" select=""userCSharp:datetimenowstring()"" />
        <ns0:DateTimeStamp>
          <xsl:value-of select=""$var:v12"" />
        </ns0:DateTimeStamp>
      </ns0:thisDocumentGenerationDateTime>
      <ns0:thisDocumentIdentifier>
        <xsl:variable name=""var:v13"" select=""userCSharp:ProprietaryDocumentIdentifier(string(s0:config/s0:fromRole/s0:Site/text()) , &quot;HUB&quot; , string(@VendorDuns))"" />
        <ns0:ProprietaryDocumentIdentifier>
          <xsl:value-of select=""$var:v13"" />
        </ns0:ProprietaryDocumentIdentifier>
      </ns0:thisDocumentIdentifier>
      <ns0:toRole>
        <ns0:PartnerRoleDescription>
          <ns0:GlobalPartnerRoleClassificationCode>
            <xsl:value-of select=""$var:v14"" />
          </ns0:GlobalPartnerRoleClassificationCode>
          <ns0:PartnerDescription>
            <ns0:BusinessDescription>
              <ns0:GlobalBusinessIdentifier>
                <xsl:value-of select=""@VendorDuns"" />
              </ns0:GlobalBusinessIdentifier>
              <ns0:GlobalSupplyChainCode>
                <xsl:value-of select=""$var:v3"" />
              </ns0:GlobalSupplyChainCode>
            </ns0:BusinessDescription>
            <ns0:GlobalPartnerClassificationCode>
              <xsl:value-of select=""$var:v15"" />
            </ns0:GlobalPartnerClassificationCode>
          </ns0:PartnerDescription>
        </ns0:PartnerRoleDescription>
      </ns0:toRole>
    </ns0:Pip4B2ShipmentReceiptNotification>
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


//[Site]*[Storer Key]*[Supplier DO#]*[Special Remarks from Supplier DO]*[Seagate PO#] e.g. TH*TTKABC12345*U276D11-MC0*15P/1440*PO1234

        //<Site>*<Storer Key>*<Supplier DO#>*< Trace Code as special remark>*<Seagate PO#>*<RTV/Ref Number, if applicable>
        //Examples:
        //SZ*SZT12345*U276D11-MC0*TC123*PO1234*
        //SZ*SZT60558*RBCA-00001040*TC123*PO#123*RTV/rmaref-2015-1222
        public string SeagateProprietaryLocator(string site, string storerkey, string suppliterDO, string specialRemarks, string seagatePO, string ordertype)
        {
            site=""SZD"";
            if (ordertype.Trim().ToUpper() == ""20"")
                //return string.Format(""{0}*SZD{1}*{2}*{3}*{4}*{5}"", site.Substring(0, 2), storerkey, suppliterDO, ""RTV"", """", seagatePO);
                return string.Format(""{0}*SZD{1}*{2}*{3}*{4}*{5}"", site.Substring(0, 2), storerkey, suppliterDO, specialRemarks, """", ""RTV/"" + seagatePO);
            else
                return string.Format(""{0}*SZD{1}*{2}*{3}*{4}*"", site.Substring(0, 2), storerkey, suppliterDO, specialRemarks, seagatePO);
        }

//ZT+ASN+yyyymmddhhmmssfff+ supplierDuns+kaifa hub DUNS + one up number
//Pls refer this link for proposed doc id format enhancement to address possible duplicate docids from UPS and Kaifa during transition period. Need to include KAIFA DUNS (663050425) in the prop doc id to both STX and e2open feeds.
public string ProprietaryDocumentIdentifier(string Site,string msgType,string supplierDuns) {
            Site=""SZD"";
            string str = DateTime.Now.ToString(""yyyyMMddHHmmssfff"");
            string seq = ""000001"";
            return string.Format(""{0}{1}{2}{3}{5}{4}"", Site, msgType, str, supplierDuns, seq,""663050425"");
        }

public string convertdatetimestring(string dtstr)
        {
            //2015-11-02T12:00:00
            //20151101T000052.791Z

            return dtstr.Replace(""-"", """").Replace("":"", """") + "".000Z"";
        }

public string datetimenowstring()
        {
            //2015-11-02T12:00:00
            //20151101T000052.791Z

           return DateTime.Now.ToString(""yyyyMMddTHHmmss"") + "".000Z"";
        }


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Kaifa.B2B.Schemas.Wms.VendorReceiptReport";
        
        private const Kaifa.B2B.Schemas.Wms.VendorReceiptReport _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification";
        
        private const Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Kaifa.B2B.Schemas.Wms.VendorReceiptReport";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification";
                return _TrgSchemas;
            }
        }
    }
}
