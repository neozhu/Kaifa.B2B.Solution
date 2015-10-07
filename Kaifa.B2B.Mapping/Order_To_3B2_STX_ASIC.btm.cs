namespace Kaifa.B2B.Mapping {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.Schemas.Wms.OrderShipment", typeof(Kaifa.B2B.Schemas.Wms.OrderShipment))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.Schemas.RosettaNet.Pip3B2AdvanceShipmentNotification", typeof(Kaifa.B2B.Schemas.RosettaNet.Pip3B2AdvanceShipmentNotification))]
    public sealed class Order_To_3B2_STX_ASIC : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://kaifa.b2b.schemas/Pip3B2AdvanceShipmentNotification"" xmlns:s0=""http://kaifa.b2b.schemas/OrderShipment"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:OrderShipment"" />
  </xsl:template>
  <xsl:template match=""/s0:OrderShipment"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringTrimLeft(&quot;894730147&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringTrimLeft(&quot;663050425&quot;)"" />
    <xsl:variable name=""var:v3"" select=""s0:ASIC/s0:ORDER/s0:ORDERDETAIL[1]/s0:CONSIGNEEKEY/text()"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringTrimLeft(&quot;Same Day&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringTrimLeft(&quot;1&quot;)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:StringTrimLeft(&quot;YuQiXing&quot;)"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:StringTrimLeft(&quot;CN&quot;)"" />
    <xsl:variable name=""var:v15"" select=""userCSharp:StringTrimLeft(&quot;Each&quot;)"" />
    <xsl:variable name=""var:v16"" select=""userCSharp:StringTrimLeft(&quot;No&quot;)"" />
    <xsl:variable name=""var:v17"" select=""userCSharp:StringTrimLeft(&quot;Manufacturer&quot;)"" />
    <xsl:variable name=""var:v18"" select=""userCSharp:StringTrimLeft(&quot;YuQiXing@kaifa.cn&quot;)"" />
    <xsl:variable name=""var:v19"" select=""userCSharp:StringTrimLeft(&quot;(86-755) 83275000-36633&quot;)"" />
    <xsl:variable name=""var:v20"" select=""userCSharp:StringTrimLeft(&quot;Shipper&quot;)"" />
    <xsl:variable name=""var:v21"" select=""userCSharp:StringTrimLeft(&quot;Electronic Components&quot;)"" />
    <xsl:variable name=""var:v22"" select=""userCSharp:StringTrimLeft(&quot;Freight Forwarder&quot;)"" />
    <xsl:variable name=""var:v23"" select=""userCSharp:StringTrimLeft(&quot;Request&quot;)"" />
    <xsl:variable name=""var:v26"" select=""userCSharp:StringTrimLeft(&quot;Receiver&quot;)"" />
    <xsl:variable name=""var:v27"" select=""userCSharp:StringTrimLeft(&quot;098533326&quot;)"" />
    <ns0:Pip3B2AdvanceShipmentNotification>
      <ns0:AdvancedShipmentNotification>
        <ns0:BuyingPartner>
          <ns0:purchasedBy>
            <ns0:PartnerDescription>
              <ns0:BusinessDescription>
                <ns0:GlobalBusinessIdentifier>
                  <xsl:value-of select=""$var:v1"" />
                </ns0:GlobalBusinessIdentifier>
              </ns0:BusinessDescription>
            </ns0:PartnerDescription>
          </ns0:purchasedBy>
        </ns0:BuyingPartner>
        <ns0:OriginatingPartner>
          <ns0:shipFrom>
            <ns0:PartnerDescription>
              <ns0:BusinessDescription>
                <ns0:GlobalBusinessIdentifier>
                  <xsl:value-of select=""$var:v2"" />
                </ns0:GlobalBusinessIdentifier>
              </ns0:BusinessDescription>
            </ns0:PartnerDescription>
          </ns0:shipFrom>
        </ns0:OriginatingPartner>
        <ns0:SellingPartner>
          <ns0:soldBy>
            <ns0:PartnerDescription>
              <ns0:BusinessDescription>
                <ns0:GlobalBusinessIdentifier>
                  <xsl:value-of select=""$var:v2"" />
                </ns0:GlobalBusinessIdentifier>
              </ns0:BusinessDescription>
            </ns0:PartnerDescription>
          </ns0:soldBy>
        </ns0:SellingPartner>
        <ns0:Shipment>
          <ns0:GlobalCarrierCode>
            <xsl:value-of select=""$var:v3"" />
          </ns0:GlobalCarrierCode>
          <ns0:GlobalShippingServiceLevelCode>
            <xsl:value-of select=""$var:v4"" />
          </ns0:GlobalShippingServiceLevelCode>
          <ns0:numberOfShippingContainers>
            <ns0:CountableAmount>
              <xsl:value-of select=""$var:v5"" />
            </ns0:CountableAmount>
          </ns0:numberOfShippingContainers>
          <ns0:ReceivingPartner>
            <ns0:shipto>
              <ns0:PartnerDescription>
                <ns0:BusinessDescription>
                  <ns0:GlobalBusinessIdentifier>
                    <xsl:value-of select=""$var:v1"" />
                  </ns0:GlobalBusinessIdentifier>
                </ns0:BusinessDescription>
                <ns0:ContactInformation>
                  <ns0:contactName>
                    <ns0:FreeFormText>
                      <xsl:value-of select=""$var:v6"" />
                    </ns0:FreeFormText>
                  </ns0:contactName>
                  <ns0:PhysicalAddress>
                    <ns0:GlobalCountryCode>
                      <xsl:value-of select=""$var:v7"" />
                    </ns0:GlobalCountryCode>
                  </ns0:PhysicalAddress>
                </ns0:ContactInformation>
              </ns0:PartnerDescription>
            </ns0:shipto>
          </ns0:ReceivingPartner>
          <ns0:shipmentIdentifier>
            <ns0:ProprietaryReferenceIdentifier>
              <xsl:value-of select=""$var:v5"" />
            </ns0:ProprietaryReferenceIdentifier>
          </ns0:shipmentIdentifier>
          <ns0:ShippingContainer>
            <ns0:shippingContainerIdentifier>
              <ns0:ProprietarySerialIdentifier>
                <xsl:value-of select=""$var:v5"" />
              </ns0:ProprietarySerialIdentifier>
            </ns0:shippingContainerIdentifier>
            <ns0:ShippingContainerItem>
              <xsl:for-each select=""s0:ASIC"">
                <xsl:for-each select=""s0:ORDER"">
                  <xsl:for-each select=""s0:ORDERDETAIL"">
                    <xsl:variable name=""var:v8"" select=""userCSharp:StringTrimLeft(&quot;Delivery Note&quot;)"" />
                    <xsl:variable name=""var:v10"" select=""userCSharp:StringTrimLeft(&quot;PICK&quot;)"" />
                    <xsl:variable name=""var:v11"" select=""userCSharp:StringTrimLeft(&quot;&quot;)"" />
                    <xsl:variable name=""var:v12"" select=""userCSharp:StringConcat(&quot;SZT&quot; , string(s0:STORERKEY/text()))"" />
                    <xsl:variable name=""var:v14"" select=""userCSharp:StringTrimLeft(&quot;RT&quot;)"" />
                    <ns0:DocumentSubLineLotShipReference>
                      <ns0:GlobalDocumentReferenceTypeCode>
                        <xsl:value-of select=""$var:v8"" />
                      </ns0:GlobalDocumentReferenceTypeCode>
                      <ns0:ProprietaryDocumentIdentifier>
                        <xsl:value-of select=""../s0:EXTERNORDERKEY/text()"" />
                      </ns0:ProprietaryDocumentIdentifier>
                      <xsl:variable name=""var:v9"" select=""userCSharp:SeagateProprietarySite(&quot;SZT&quot; , string(s0:CONSIGNEEKEY/text()))"" />
                      <ns0:SeagateProprietarySite>
                        <xsl:value-of select=""$var:v9"" />
                      </ns0:SeagateProprietarySite>
                      <ns0:SeagateProprietaryComCode>
                        <xsl:value-of select=""s0:COMCODE/text()"" />
                      </ns0:SeagateProprietaryComCode>
                      <ns0:SeagateProprietaryItems>
                        <ns0:SeagateProprietaryPart>
                          <xsl:value-of select=""s0:SKU/text()"" />
                        </ns0:SeagateProprietaryPart>
                        <ns0:SeagateProprietaryKitQty>
                          <xsl:value-of select=""s0:QTY/text()"" />
                        </ns0:SeagateProprietaryKitQty>
                        <ns0:SeagateProprietaryPartStatus>
                          <xsl:value-of select=""$var:v10"" />
                        </ns0:SeagateProprietaryPartStatus>
                        <ns0:SeagateProprietaryRemarks>
                          <xsl:value-of select=""$var:v11"" />
                        </ns0:SeagateProprietaryRemarks>
                        <ns0:SeagateProprietaryDONumber>
                          <xsl:value-of select=""s0:ORDERKEY/text()"" />
                        </ns0:SeagateProprietaryDONumber>
                        <ns0:SeagateProprietaryVendorCode>
                          <xsl:value-of select=""$var:v12"" />
                        </ns0:SeagateProprietaryVendorCode>
                        <ns0:SeagateProprietaryPONumber>
                          <xsl:value-of select=""s0:LOTTABLE03/text()"" />
                        </ns0:SeagateProprietaryPONumber>
                        <xsl:variable name=""var:v13"" select=""userCSharp:DateTimeFormat(string(s0:TRANSACTIONDATE/text()))"" />
                        <ns0:SeagateProprietaryTransactionDate>
                          <xsl:value-of select=""$var:v13"" />
                        </ns0:SeagateProprietaryTransactionDate>
                        <ns0:SeagateProprietaryTransactionType>
                          <xsl:value-of select=""$var:v14"" />
                        </ns0:SeagateProprietaryTransactionType>
                        <ns0:SeagateProprietaryTradingPartnerDONumber>
                          <xsl:value-of select=""s0:LOTTABLE02/text()"" />
                        </ns0:SeagateProprietaryTradingPartnerDONumber>
                      </ns0:SeagateProprietaryItems>
                    </ns0:DocumentSubLineLotShipReference>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
              <ns0:GlobalProductUnitOfMeasureCode>
                <xsl:value-of select=""$var:v15"" />
              </ns0:GlobalProductUnitOfMeasureCode>
              <ns0:isContainsHazardousMaterial>
                <ns0:AffirmationIndicator>
                  <xsl:value-of select=""$var:v16"" />
                </ns0:AffirmationIndicator>
              </ns0:isContainsHazardousMaterial>
              <ns0:ProductIdentification>
                <ns0:PartnerProductIdentification>
                  <ns0:GlobalPartnerClassificationCode>
                    <xsl:value-of select=""$var:v17"" />
                  </ns0:GlobalPartnerClassificationCode>
                  <ns0:ProprietaryProductIdentifier>
                    <xsl:value-of select=""$var:v5"" />
                  </ns0:ProprietaryProductIdentifier>
                </ns0:PartnerProductIdentification>
              </ns0:ProductIdentification>
              <ns0:shippedQuantity>
                <ns0:ProductQuantity>
                  <xsl:value-of select=""$var:v5"" />
                </ns0:ProductQuantity>
              </ns0:shippedQuantity>
            </ns0:ShippingContainerItem>
          </ns0:ShippingContainer>
          <ns0:transportedBy>
            <ns0:PartnerDescription>
              <ns0:BusinessDescription>
                <ns0:GlobalBusinessIdentifier>
                  <xsl:value-of select=""$var:v2"" />
                </ns0:GlobalBusinessIdentifier>
              </ns0:BusinessDescription>
            </ns0:PartnerDescription>
          </ns0:transportedBy>
        </ns0:Shipment>
      </ns0:AdvancedShipmentNotification>
      <ns0:fromRole>
        <ns0:PartnerRoleDescription>
          <ns0:ContactInformation>
            <ns0:contactName>
              <ns0:FreeFormText>
                <xsl:value-of select=""$var:v6"" />
              </ns0:FreeFormText>
            </ns0:contactName>
            <ns0:EmailAddress>
              <xsl:value-of select=""$var:v18"" />
            </ns0:EmailAddress>
            <ns0:facsimileNumber>
              <ns0:CommunicationsNumber>
                <xsl:value-of select=""$var:v19"" />
              </ns0:CommunicationsNumber>
            </ns0:facsimileNumber>
            <ns0:telephoneNumber>
              <ns0:CommunicationsNumber>
                <xsl:value-of select=""$var:v19"" />
              </ns0:CommunicationsNumber>
            </ns0:telephoneNumber>
          </ns0:ContactInformation>
          <ns0:GlobalPartnerRoleClassificationCode>
            <xsl:value-of select=""$var:v20"" />
          </ns0:GlobalPartnerRoleClassificationCode>
          <ns0:PartnerDescription>
            <ns0:BusinessDescription>
              <ns0:GlobalBusinessIdentifier>
                <xsl:value-of select=""$var:v2"" />
              </ns0:GlobalBusinessIdentifier>
              <ns0:GlobalSupplyChainCode>
                <xsl:value-of select=""$var:v21"" />
              </ns0:GlobalSupplyChainCode>
            </ns0:BusinessDescription>
            <ns0:GlobalPartnerClassificationCode>
              <xsl:value-of select=""$var:v22"" />
            </ns0:GlobalPartnerClassificationCode>
          </ns0:PartnerDescription>
        </ns0:PartnerRoleDescription>
      </ns0:fromRole>
      <ns0:GlobalDocumentFunctionCode>
        <xsl:value-of select=""$var:v23"" />
      </ns0:GlobalDocumentFunctionCode>
      <ns0:thisDocumentGenerationDateTime>
        <xsl:variable name=""var:v24"" select=""userCSharp:dateTimeNow()"" />
        <ns0:DateTimeStamp>
          <xsl:value-of select=""$var:v24"" />
        </ns0:DateTimeStamp>
      </ns0:thisDocumentGenerationDateTime>
      <ns0:thisDocumentIdentifier>
        <xsl:variable name=""var:v25"" select=""userCSharp:ProprietaryDocumentIdentifier(&quot;SZT&quot; , &quot;ASN&quot;)"" />
        <ns0:ProprietaryDocumentIdentifier>
          <xsl:value-of select=""$var:v25"" />
        </ns0:ProprietaryDocumentIdentifier>
      </ns0:thisDocumentIdentifier>
      <ns0:toRole>
        <ns0:PartnerRoleDescription>
          <ns0:GlobalPartnerRoleClassificationCode>
            <xsl:value-of select=""$var:v26"" />
          </ns0:GlobalPartnerRoleClassificationCode>
          <ns0:PartnerDescription>
            <ns0:BusinessDescription>
              <ns0:GlobalBusinessIdentifier>
                <xsl:value-of select=""$var:v27"" />
              </ns0:GlobalBusinessIdentifier>
              <ns0:GlobalSupplyChainCode>
                <xsl:value-of select=""$var:v21"" />
              </ns0:GlobalSupplyChainCode>
            </ns0:BusinessDescription>
            <ns0:GlobalPartnerClassificationCode>
              <xsl:value-of select=""$var:v17"" />
            </ns0:GlobalPartnerClassificationCode>
          </ns0:PartnerDescription>
        </ns0:PartnerRoleDescription>
      </ns0:toRole>
    </ns0:Pip3B2AdvanceShipmentNotification>
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


public string dateTimeNow()
{
	return DateTime.Now.ToString(""yyyyMMddTHHmmss.fff"") + ""Z"";
}

public string ProprietaryDocumentIdentifier(string Site,string msgType) {
            string str = DateTime.Now.ToString(""yyyyMMddHHmmssfff"");
            string seq = ""000001"";
            return string.Format(""{0}HUB{1}{2}{3}"", ""SNK"", msgType, str, seq);
        }

public string SeagateProprietarySite(string hubsite, string cmsite) {
            return string.Format(""{0}-{1}"", hubsite, cmsite);
        }

public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}


public string DateTimeFormat(string str) {
            //20150616T021822.000Z
            //2015-03-31T21:44:21
            return str.Replace(""-"", string.Empty).Replace("":"", string.Empty).Substring(0,15) + "".000Z"";
        }


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Kaifa.B2B.Schemas.Wms.OrderShipment";
        
        private const Kaifa.B2B.Schemas.Wms.OrderShipment _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Kaifa.B2B.Schemas.RosettaNet.Pip3B2AdvanceShipmentNotification";
        
        private const Kaifa.B2B.Schemas.RosettaNet.Pip3B2AdvanceShipmentNotification _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Kaifa.B2B.Schemas.Wms.OrderShipment";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Kaifa.B2B.Schemas.RosettaNet.Pip3B2AdvanceShipmentNotification";
                return _TrgSchemas;
            }
        }
    }
}
