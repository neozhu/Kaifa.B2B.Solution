namespace Kaifa.B2B.Mapping {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.Schemas.Wms.VendorShipmentPODReport", typeof(Kaifa.B2B.Schemas.Wms.VendorShipmentPODReport))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.Schemas.RosettaNet.Pip4B2PODShipmentReceiptNotification", typeof(Kaifa.B2B.Schemas.RosettaNet.Pip4B2PODShipmentReceiptNotification))]
    public sealed class Order_To_4B2POD_e2open : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://kaifa.b2b.schemas/Pip4B2PODShipmentReceiptNotification"" xmlns:s0=""http://kaifa.b2b.schemas/OrderShipmentPOD"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:VendorShipmentPODReport"" />
  </xsl:template>
  <xsl:template match=""/s0:VendorShipmentPODReport"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringTrimLeft(&quot;Consignee&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringTrimLeft(&quot;545196698&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringTrimLeft(&quot;Electronic Components&quot;)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringTrimLeft(&quot;Manufacturer&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringTrimLeft(&quot;Request&quot;)"" />
    <xsl:variable name=""var:v23"" select=""userCSharp:StringTrimLeft(&quot;Shipment Information User&quot;)"" />
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
      <xsl:for-each select=""s0:NOASIC/s0:ORDER"">
        <xsl:variable name=""var:v7"" select=""userCSharp:StringTrimLeft(&quot;Purchase Order&quot;)"" />
        <xsl:variable name=""var:v8"" select=""position()"" />
        <xsl:variable name=""var:v9"" select=""string(s0:CMCODE/text())"" />
        <xsl:variable name=""var:v11"" select=""userCSharp:StringTrimLeft(&quot;Each&quot;)"" />
        <xsl:variable name=""var:v12"" select=""userCSharp:StringTrimLeft(&quot;Manufacturer&quot;)"" />
        <xsl:variable name=""var:v13"" select=""userCSharp:StringTrimLeft(&quot;RECEIVE&quot;)"" />
        <xsl:variable name=""var:v15"" select=""userCSharp:StringTrimLeft(&quot;&quot;)"" />
        <xsl:variable name=""var:v16"" select=""userCSharp:StringTrimLeft(&quot;545196698&quot;)"" />
        <xsl:variable name=""var:v17"" select=""string(../../s0:config/s0:fromRole/s0:Site/text())"" />
        <xsl:variable name=""var:v20"" select=""userCSharp:StringTrimLeft(&quot;Packing Slip Number&quot;)"" />
        <ns0:ShipmentReceiptInformationResource>
          <ns0:shipmentIdentifier>
            <xsl:variable name=""var:v6"" select=""userCSharp:ProprietaryReferenceIdentifier(string(../../s0:config/s0:fromRole/s0:Site/text()) , string(../../@VendorCode) , string(s0:CMCODE/text()) , string(s0:EXTERNORDERKEY/text()))"" />
            <ns0:ProprietaryReferenceIdentifier>
              <xsl:value-of select=""$var:v6"" />
            </ns0:ProprietaryReferenceIdentifier>
          </ns0:shipmentIdentifier>
          <ns0:ShipmentReceiptNotificationLineItem>
            <ns0:acceptedQuantity>
              <ns0:ProductQuantity>
                <xsl:value-of select=""s0:ORDERDETAIL/s0:QTY/text()"" />
              </ns0:ProductQuantity>
            </ns0:acceptedQuantity>
            <ns0:DocumentSubLineReference>
              <ns0:GlobalDocumentReferenceTypeCode>
                <xsl:value-of select=""$var:v7"" />
              </ns0:GlobalDocumentReferenceTypeCode>
              <ns0:LineNumber>
                <xsl:value-of select=""$var:v8"" />
              </ns0:LineNumber>
              <xsl:variable name=""var:v10"" select=""userCSharp:NONASICPurchaseOrder(string(s0:ORDERDETAIL/s0:LOTTABLE03/text()) , $var:v9)"" />
              <ns0:ProprietaryDocumentIdentifier>
                <xsl:value-of select=""$var:v10"" />
              </ns0:ProprietaryDocumentIdentifier>
            </ns0:DocumentSubLineReference>
            <ns0:GlobalProductUnitOfMeasureCode>
              <xsl:value-of select=""$var:v11"" />
            </ns0:GlobalProductUnitOfMeasureCode>
            <ns0:ProductIdentification>
              <ns0:PartnerProductIdentification>
                <ns0:GlobalPartnerClassificationCode>
                  <xsl:value-of select=""$var:v12"" />
                </ns0:GlobalPartnerClassificationCode>
                <ns0:ProprietaryProductIdentifier>
                  <xsl:value-of select=""s0:ORDERDETAIL/s0:SKU/text()"" />
                </ns0:ProprietaryProductIdentifier>
                <ns0:SeagateProprietaryTransactionType>
                  <ns0:FreeFormText>
                    <xsl:value-of select=""$var:v13"" />
                  </ns0:FreeFormText>
                </ns0:SeagateProprietaryTransactionType>
                <ns0:SeagateProprietaryRTVReason>
                  <xsl:variable name=""var:v14"" select=""userCSharp:SeagateProprietaryRTVReason(string(s0:ORDERDETAIL/s0:LOTTABLE06/text()) , string(s0:ORDERDETAIL/s0:LOTTABLE02/text()))"" />
                  <ns0:FreeFormText>
                    <xsl:value-of select=""$var:v14"" />
                  </ns0:FreeFormText>
                </ns0:SeagateProprietaryRTVReason>
                <ns0:SeagateProprietaryPOBalance>
                  <xsl:value-of select=""$var:v15"" />
                </ns0:SeagateProprietaryPOBalance>
              </ns0:PartnerProductIdentification>
            </ns0:ProductIdentification>
            <ns0:receivedBy>
              <ns0:PartnerDescription>
                <ns0:BusinessDescription>
                  <ns0:GlobalBusinessIdentifier>
                    <xsl:value-of select=""$var:v16"" />
                  </ns0:GlobalBusinessIdentifier>
                  <ns0:businessName>
                    <xsl:variable name=""var:v18"" select=""userCSharp:SeagateProprietarySite($var:v17 , $var:v9)"" />
                    <ns0:FreeFormText>
                      <xsl:value-of select=""$var:v18"" />
                    </ns0:FreeFormText>
                  </ns0:businessName>
                </ns0:BusinessDescription>
              </ns0:PartnerDescription>
            </ns0:receivedBy>
            <ns0:receivedQuantity>
              <ns0:ProductQuantity>
                <xsl:value-of select=""s0:ORDERDETAIL/s0:QTY/text()"" />
              </ns0:ProductQuantity>
            </ns0:receivedQuantity>
            <ns0:shipmentReceiptReportDateTime>
              <xsl:variable name=""var:v19"" select=""userCSharp:dateTimeNow0(string(s0:ORDERDETAIL/s0:TRANSACTIONDATE/text()))"" />
              <ns0:DateTimeStamp>
                <xsl:value-of select=""$var:v19"" />
              </ns0:DateTimeStamp>
            </ns0:shipmentReceiptReportDateTime>
          </ns0:ShipmentReceiptNotificationLineItem>
          <ns0:TrackingReference>
            <ns0:GlobalTrackingReferenceTypeCode>
              <xsl:value-of select=""$var:v20"" />
            </ns0:GlobalTrackingReferenceTypeCode>
            <ns0:ProprietaryShipmentTrackingIdentifier>
              <xsl:value-of select=""s0:DELIVERYORDER/text()"" />
            </ns0:ProprietaryShipmentTrackingIdentifier>
            <ns0:SeagateProprietaryDONumber>
              <xsl:value-of select=""s0:ORDERKEY/text()"" />
            </ns0:SeagateProprietaryDONumber>
          </ns0:TrackingReference>
        </ns0:ShipmentReceiptInformationResource>
      </xsl:for-each>
      <ns0:thisDocumentGenerationDateTime>
        <xsl:variable name=""var:v21"" select=""userCSharp:dateTimeNow()"" />
        <ns0:DateTimeStamp>
          <xsl:value-of select=""$var:v21"" />
        </ns0:DateTimeStamp>
      </ns0:thisDocumentGenerationDateTime>
      <ns0:thisDocumentIdentifier>
        <xsl:variable name=""var:v22"" select=""userCSharp:ProprietaryDocumentIdentifier(string(s0:config/s0:fromRole/s0:Site/text()) , string(@VendorCode) , &quot;POD&quot;)"" />
        <ns0:ProprietaryDocumentIdentifier>
          <xsl:value-of select=""$var:v22"" />
        </ns0:ProprietaryDocumentIdentifier>
      </ns0:thisDocumentIdentifier>
      <ns0:toRole>
        <ns0:PartnerRoleDescription>
          <ns0:GlobalPartnerRoleClassificationCode>
            <xsl:value-of select=""$var:v23"" />
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
              <xsl:value-of select=""$var:v4"" />
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


public string ProprietaryDocumentIdentifier(string Site, string vendorCode, string msgType)
        {
            string str = DateTime.Now.ToString(""yyyyMMddHHmmss"");
            string seq = ""100001"";
            return string.Format(""{0}{1}{2}SUP{3}{5}{4}"", Site, vendorCode,msgType, str, seq,""663050425"");
        }

public string dateTimeNow()
{
	return DateTime.Now.ToString(""yyyyMMddTHHmmss"") + ""Z"";
                   //return DateTime.Now.ToString(""yyyyMMddT000000.000"") + ""Z"";
}

public string ProprietaryReferenceIdentifier(string site, string VendorCode,string cmCode,string kitlist)
        {
            return string.Format(""{0}{1}~{2}~{3}"", site, VendorCode, cmCode, kitlist);
         }

public string dateTimeNow0(string str)
{
	//return DateTime.Now.ToString(""yyyyMMddTHHmmss"") + ""Z"";
                  // return DateTime.Now.ToString(""yyyyMMddT000000.000"") + ""Z"";
                 return str.Replace(""-"", string.Empty).Replace("":"", string.Empty).Substring(0,9) + ""000000.000Z"";

}

public string NONASICPurchaseOrder(string PO,string CmCode) {
            return string.Format(""{0}-{1}"", PO, CmCode);
        
        }

public string SeagateProprietaryRTVReason(string l06,string ldo) {
             if (l06.Trim().ToUpper() == ""RTV"" )
             {
                 return ldo;
             }
             else
             {
                 return """";
             }
         }

public string SeagateProprietarySite(string hubsite, string cmsite) {
            return string.Format(""{0}-{1}"", hubsite, cmsite);
        }


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Kaifa.B2B.Schemas.Wms.VendorShipmentPODReport";
        
        private const Kaifa.B2B.Schemas.Wms.VendorShipmentPODReport _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Kaifa.B2B.Schemas.RosettaNet.Pip4B2PODShipmentReceiptNotification";
        
        private const Kaifa.B2B.Schemas.RosettaNet.Pip4B2PODShipmentReceiptNotification _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Kaifa.B2B.Schemas.Wms.VendorShipmentPODReport";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Kaifa.B2B.Schemas.RosettaNet.Pip4B2PODShipmentReceiptNotification";
                return _TrgSchemas;
            }
        }
    }
}
