namespace Kaifa.B2B.Mapping {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.Schemas.Wms.VendorReceiptReport", typeof(global::Kaifa.B2B.Schemas.Wms.VendorReceiptReport))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification+Pip4B2ShipmentReceiptNotification", typeof(global::Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification.Pip4B2ShipmentReceiptNotification))]
    public sealed class ASN_To_4B2 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://kaifa.b2b.schemas/AdvancedShipNotice"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:VendorReceiptReport"" />
  </xsl:template>
  <xsl:template match=""/s0:VendorReceiptReport"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringTrimLeft(&quot;Request&quot;)"" />
    <Pip4B2ShipmentReceiptNotification>
      <fromRole>
        <PartnerRoleDescription>
          <ContactInformation>
            <contactName>
              <FreeFormText>
                <xsl:value-of select=""s0:config/s0:fromRole/s0:contactName/text()"" />
              </FreeFormText>
            </contactName>
            <EmailAddress>
              <xsl:value-of select=""s0:config/s0:fromRole/s0:EmailAddress/text()"" />
            </EmailAddress>
            <facsimileNumber>
              <CommunicationsNumber>
                <xsl:value-of select=""s0:config/s0:fromRole/s0:facsimileNumber/text()"" />
              </CommunicationsNumber>
            </facsimileNumber>
            <telephoneNumber>
              <CommunicationsNumber>
                <xsl:value-of select=""s0:config/s0:fromRole/s0:telephoneNumber/text()"" />
              </CommunicationsNumber>
            </telephoneNumber>
          </ContactInformation>
          <GlobalPartnerRoleClassificationCode>
            <xsl:value-of select=""s0:config/s0:fromRole/s0:GlobalPartnerRoleClassificationCode/text()"" />
          </GlobalPartnerRoleClassificationCode>
          <PartnerDescription>
            <BusinessDescription>
              <GlobalBusinessIdentifier>
                <xsl:value-of select=""s0:config/s0:fromRole/s0:GlobalBusinessIdentifier/text()"" />
              </GlobalBusinessIdentifier>
              <GlobalSupplyChainCode>
                <xsl:value-of select=""s0:config/s0:fromRole/s0:GlobalSupplyChainCode/text()"" />
              </GlobalSupplyChainCode>
            </BusinessDescription>
            <GlobalPartnerClassificationCode>
              <xsl:value-of select=""s0:config/s0:fromRole/s0:GlobalPartnerClassificationCode/text()"" />
            </GlobalPartnerClassificationCode>
          </PartnerDescription>
        </PartnerRoleDescription>
      </fromRole>
      <GlobalDocumentFunctionCode>
        <xsl:value-of select=""$var:v1"" />
      </GlobalDocumentFunctionCode>
      <xsl:for-each select=""s0:RECEIPT"">
        <ShipmentReceiptInformationResource>
          <shipmentIdentifier>
            <xsl:if test=""s0:RECEIPTKEY"">
              <ProprietaryReferenceIdentifier>
                <xsl:value-of select=""s0:RECEIPTKEY/text()"" />
              </ProprietaryReferenceIdentifier>
            </xsl:if>
          </shipmentIdentifier>
          <xsl:for-each select=""s0:RECEIPTDETAIL"">
            <xsl:variable name=""var:v2"" select=""userCSharp:StringTrimLeft(&quot;Work Order&quot;)"" />
            <xsl:variable name=""var:v3"" select=""userCSharp:StringTrimLeft(&quot;Each&quot;)"" />
            <xsl:variable name=""var:v4"" select=""userCSharp:StringTrimLeft(&quot;Manufacturer&quot;)"" />
            <ShipmentReceiptNotificationLineItem>
              <acceptedQuantity>
                <xsl:if test=""s0:QTYRECEIVED"">
                  <ProductQuantity>
                    <xsl:value-of select=""s0:QTYRECEIVED/text()"" />
                  </ProductQuantity>
                </xsl:if>
              </acceptedQuantity>
              <DocumentSubLineReference>
                <GlobalDocumentReferenceTypeCode>
                  <xsl:value-of select=""$var:v2"" />
                </GlobalDocumentReferenceTypeCode>
                <xsl:if test=""s0:RECEIPTLINENUMBER"">
                  <LineNumber>
                    <xsl:value-of select=""s0:RECEIPTLINENUMBER/text()"" />
                  </LineNumber>
                </xsl:if>
                <xsl:if test=""s0:LOTTABLE02"">
                  <ProprietaryDocumentIdentifier>
                    <xsl:value-of select=""s0:LOTTABLE02/text()"" />
                  </ProprietaryDocumentIdentifier>
                </xsl:if>
                <subLineNumber>
                  <xsl:if test=""s0:SUBLINENUMBER"">
                    <LineNumber>
                      <xsl:value-of select=""s0:SUBLINENUMBER/text()"" />
                    </LineNumber>
                  </xsl:if>
                </subLineNumber>
              </DocumentSubLineReference>
              <GlobalProductUnitOfMeasureCode>
                <xsl:value-of select=""$var:v3"" />
              </GlobalProductUnitOfMeasureCode>
              <ProductIdentification>
                <xsl:if test=""s0:SKU"">
                  <GlobalProductIdentifier>
                    <xsl:value-of select=""s0:SKU/text()"" />
                  </GlobalProductIdentifier>
                </xsl:if>
                <PartnerProductIdentification>
                  <GlobalPartnerClassificationCode>
                    <xsl:value-of select=""$var:v4"" />
                  </GlobalPartnerClassificationCode>
                  <xsl:if test=""s0:SKU"">
                    <ProprietaryProductIdentifier>
                      <xsl:value-of select=""s0:SKU/text()"" />
                    </ProprietaryProductIdentifier>
                  </xsl:if>
                  <SeagateProprietaryTransactionType>
                    <xsl:variable name=""var:v5"" select=""userCSharp:SeagateProprietaryLocator(string(../../s0:config/s0:hub/s0:Partner/text()) , string(../s0:STORERKEY/text()) , string(s0:LOTTABLE02/text()) , string(s0:LOTTABLE06/text()) , string(s0:LOTTABLE03/text()))"" />
                    <FreeFormText>
                      <xsl:value-of select=""$var:v5"" />
                    </FreeFormText>
                  </SeagateProprietaryTransactionType>
                  <SeagateProprietaryRTVReason>
                    <xsl:if test=""s0:LOTTABLE06"">
                      <FreeFormText>
                        <xsl:value-of select=""s0:LOTTABLE06/text()"" />
                      </FreeFormText>
                    </xsl:if>
                  </SeagateProprietaryRTVReason>
                </PartnerProductIdentification>
              </ProductIdentification>
              <receivedBy>
                <PartnerDescription>
                  <BusinessDescription>
                    <GlobalBusinessIdentifier>
                      <xsl:value-of select=""../../s0:config/s0:hub/s0:GlobalBusinessIdentifier/text()"" />
                    </GlobalBusinessIdentifier>
                    <GlobalSupplyChainCode>
                      <xsl:value-of select=""../../s0:config/s0:hub/s0:GlobalSupplyChainCode/text()"" />
                    </GlobalSupplyChainCode>
                  </BusinessDescription>
                  <GlobalPartnerClassificationCode>
                    <xsl:value-of select=""../../s0:config/s0:hub/s0:GlobalPartnerClassificationCode/text()"" />
                  </GlobalPartnerClassificationCode>
                </PartnerDescription>
              </receivedBy>
              <receivedQuantity>
                <xsl:if test=""s0:QTYRECEIVED"">
                  <ProductQuantity>
                    <xsl:value-of select=""s0:QTYRECEIVED/text()"" />
                  </ProductQuantity>
                </xsl:if>
              </receivedQuantity>
              <shipmentReceiptReportDateTime>
                <xsl:variable name=""var:v6"" select=""userCSharp:dateTimeNow()"" />
                <DateTimeStamp>
                  <xsl:value-of select=""$var:v6"" />
                </DateTimeStamp>
              </shipmentReceiptReportDateTime>
            </ShipmentReceiptNotificationLineItem>
          </xsl:for-each>
        </ShipmentReceiptInformationResource>
      </xsl:for-each>
      <thisDocumentGenerationDateTime>
        <xsl:variable name=""var:v7"" select=""userCSharp:dateTimeNow()"" />
        <DateTimeStamp>
          <xsl:value-of select=""$var:v7"" />
        </DateTimeStamp>
      </thisDocumentGenerationDateTime>
      <thisDocumentIdentifier>
        <xsl:variable name=""var:v8"" select=""userCSharp:ProprietaryDocumentIdentifier(string(s0:config/s0:hub/s0:Partner/text()) , &quot;HUB&quot; , string(@VendorDuns))"" />
        <ProprietaryDocumentIdentifier>
          <xsl:value-of select=""$var:v8"" />
        </ProprietaryDocumentIdentifier>
      </thisDocumentIdentifier>
      <toRole>
        <PartnerRoleDescription>
          <ContactInformation>
            <contactName>
              <FreeFormText>
                <xsl:value-of select=""s0:config/s0:toRole/s0:contactName/text()"" />
              </FreeFormText>
            </contactName>
            <EmailAddress>
              <xsl:value-of select=""s0:config/s0:toRole/s0:EmailAddress/text()"" />
            </EmailAddress>
            <facsimileNumber>
              <CommunicationsNumber>
                <xsl:value-of select=""s0:config/s0:toRole/s0:facsimileNumber/text()"" />
              </CommunicationsNumber>
            </facsimileNumber>
            <telephoneNumber>
              <CommunicationsNumber>
                <xsl:value-of select=""s0:config/s0:toRole/s0:telephoneNumber/text()"" />
              </CommunicationsNumber>
            </telephoneNumber>
          </ContactInformation>
          <GlobalPartnerRoleClassificationCode>
            <xsl:value-of select=""s0:config/s0:toRole/s0:GlobalPartnerRoleClassificationCode/text()"" />
          </GlobalPartnerRoleClassificationCode>
          <PartnerDescription>
            <BusinessDescription>
              <GlobalBusinessIdentifier>
                <xsl:value-of select=""s0:config/s0:toRole/s0:GlobalBusinessIdentifier/text()"" />
              </GlobalBusinessIdentifier>
              <GlobalSupplyChainCode>
                <xsl:value-of select=""s0:config/s0:toRole/s0:GlobalSupplyChainCode/text()"" />
              </GlobalSupplyChainCode>
            </BusinessDescription>
            <GlobalPartnerClassificationCode>
              <xsl:value-of select=""s0:config/s0:toRole/s0:GlobalPartnerClassificationCode/text()"" />
            </GlobalPartnerClassificationCode>
          </PartnerDescription>
        </PartnerRoleDescription>
      </toRole>
    </Pip4B2ShipmentReceiptNotification>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

public string dateTimeNow()
{
	return DateTime.Now.ToString(""yyyyMMddTHHmmss.fff"") + ""z"";
}


public string StringTrimLeft(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.TrimStart(null);
}


///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

public string ProprietaryDocumentIdentifier(string Site,string msgType,string supplierDuns) {
            string str = DateTime.Now.ToString(""yyyyMMddHHmmssfff"");
            string seq = ""000001"";
            return string.Format(""{0}{2}{3}{4}"", Site, msgType, str, supplierDuns, seq);
        }


///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

public string SeagateProprietaryLocator(string site,string storerkey,string suppliterDO,string specialRemarks,string seagatePO) {
            return string.Format(""{0}*{1}*{2}*{3}*{4}"", site, storerkey, suppliterDO, specialRemarks, seagatePO);
        }



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Kaifa.B2B.Schemas.Wms.VendorReceiptReport";
        
        private const global::Kaifa.B2B.Schemas.Wms.VendorReceiptReport _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification+Pip4B2ShipmentReceiptNotification";
        
        private const global::Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification.Pip4B2ShipmentReceiptNotification _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification+Pip4B2ShipmentReceiptNotification";
                return _TrgSchemas;
            }
        }
    }
}
