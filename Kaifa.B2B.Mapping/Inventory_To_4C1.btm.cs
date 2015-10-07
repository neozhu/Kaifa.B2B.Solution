namespace Kaifa.B2B.Mapping {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.Schemas.Wms.VendorInventoryReport", typeof(global::Kaifa.B2B.Schemas.Wms.VendorInventoryReport))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4C1_MS_1_0_SupplierOwnInventory", typeof(global::Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4C1_MS_1_0_SupplierOwnInventory))]
    public sealed class Inventory_To_4C1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://kaifa.b2b.schemas/InventoryReport"" xmlns:ns0=""http://kaifa.b2b.schemas/SGRTHUB4C1_MS_1_0_SupplierOwnInventory"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:VendorInventoryReport"" />
  </xsl:template>
  <xsl:template match=""/s0:VendorInventoryReport"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringTrimLeft(&quot;Request&quot;)"" />
    <ns0:Pip4C1InventoryReportNotification>
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
            <xsl:value-of select=""s0:config/s0:fromRole/s0:GlobalPartnerRoleClassificationCode/text()"" />
          </ns0:GlobalPartnerRoleClassificationCode>
          <ns0:PartnerDescription>
            <ns0:BusinessDescription>
              <ns0:BusinessIdentification>
                <ns0:GlobalBusinessIdentifier>
                  <xsl:value-of select=""s0:config/s0:fromRole/s0:GlobalBusinessIdentifier/text()"" />
                </ns0:GlobalBusinessIdentifier>
              </ns0:BusinessIdentification>
              <ns0:GlobalSupplyChainCode>
                <xsl:value-of select=""s0:config/s0:fromRole/s0:GlobalSupplyChainCode/text()"" />
              </ns0:GlobalSupplyChainCode>
            </ns0:BusinessDescription>
            <ns0:GlobalPartnerClassificationCode>
              <xsl:value-of select=""s0:config/s0:fromRole/s0:GlobalPartnerClassificationCode/text()"" />
            </ns0:GlobalPartnerClassificationCode>
          </ns0:PartnerDescription>
        </ns0:PartnerRoleDescription>
      </ns0:fromRole>
      <ns0:GlobalDocumentFunctionCode>
        <xsl:value-of select=""$var:v1"" />
      </ns0:GlobalDocumentFunctionCode>
      <ns0:InventoryReport>
        <ns0:inventoryReportDateTime>
          <xsl:variable name=""var:v2"" select=""userCSharp:dateTimeNow()"" />
          <ns0:DateTimeStamp>
            <xsl:value-of select=""$var:v2"" />
          </ns0:DateTimeStamp>
        </ns0:inventoryReportDateTime>
        <xsl:for-each select=""s0:INVENTORY"">
          <xsl:variable name=""var:v3"" select=""userCSharp:StringTrimLeft(&quot;Each&quot;)"" />
          <xsl:variable name=""var:v4"" select=""userCSharp:StringTrimLeft(&quot;Available&quot;)"" />
          <xsl:variable name=""var:v7"" select=""userCSharp:StringTrimLeft(&quot;Manufacturer&quot;)"" />
          <ns0:InventoryReportLineItem>
            <ns0:GlobalProductUnitOfMeasureCode>
              <xsl:value-of select=""$var:v3"" />
            </ns0:GlobalProductUnitOfMeasureCode>
            <ns0:inventoryLocation>
              <ns0:PartnerDescription>
                <ns0:BusinessDescription>
                  <ns0:BusinessIdentification>
                    <ns0:GlobalBusinessIdentifier>
                      <xsl:value-of select=""../s0:config/s0:hub/s0:GlobalBusinessIdentifier/text()"" />
                    </ns0:GlobalBusinessIdentifier>
                  </ns0:BusinessIdentification>
                </ns0:BusinessDescription>
                <ns0:GlobalPartnerClassificationCode>
                  <xsl:value-of select=""../s0:config/s0:hub/s0:GlobalPartnerClassificationCode/text()"" />
                </ns0:GlobalPartnerClassificationCode>
              </ns0:PartnerDescription>
            </ns0:inventoryLocation>
            <ns0:InventoryProductQuantity>
              <ns0:GlobalInventoryCode>
                <xsl:value-of select=""$var:v4"" />
              </ns0:GlobalInventoryCode>
              <ns0:InventoryItemIdentification>
                <ns0:manufactureDate>
                  <xsl:variable name=""var:v5"" select=""userCSharp:dateTimeNow()"" />
                  <ns0:DateTimeStamp>
                    <xsl:value-of select=""$var:v5"" />
                  </ns0:DateTimeStamp>
                </ns0:manufactureDate>
                <xsl:variable name=""var:v6"" select=""userCSharp:ProprietaryLotIdentifier(string(../s0:config/s0:hub/s0:Partner/text()) , &quot;ONHOLD&quot; , string(s0:LOTTABLE04/text()) , string(s0:STORERKEY/text()) , string(s0:LOTTABLE02/text()) , string(s0:LOTTABLE06/text()) , string(s0:LOTTABLE03/text()))"" />
                <ns0:ProprietaryLotIdentifier>
                  <xsl:value-of select=""$var:v6"" />
                </ns0:ProprietaryLotIdentifier>
              </ns0:InventoryItemIdentification>
              <ns0:ProductQuantity>
                <xsl:value-of select=""s0:QTY/text()"" />
              </ns0:ProductQuantity>
            </ns0:InventoryProductQuantity>
            <ns0:ProductIdentification>
              <ns0:PartnerProductIdentification>
                <ns0:GlobalPartnerClassificationCode>
                  <xsl:value-of select=""$var:v7"" />
                </ns0:GlobalPartnerClassificationCode>
                <ns0:ProprietaryProductIdentifier>
                  <xsl:value-of select=""s0:SKU/text()"" />
                </ns0:ProprietaryProductIdentifier>
                <ns0:revisionIdentifier>
                  <ns0:FreeFormText>
                    <xsl:value-of select=""s0:HOLDQTY/text()"" />
                  </ns0:FreeFormText>
                </ns0:revisionIdentifier>
              </ns0:PartnerProductIdentification>
            </ns0:ProductIdentification>
          </ns0:InventoryReportLineItem>
        </xsl:for-each>
      </ns0:InventoryReport>
      <ns0:thisDocumentGenerationDateTime>
        <xsl:variable name=""var:v8"" select=""userCSharp:dateTimeNow()"" />
        <ns0:DateTimeStamp>
          <xsl:value-of select=""$var:v8"" />
        </ns0:DateTimeStamp>
      </ns0:thisDocumentGenerationDateTime>
      <ns0:thisDocumentIdentifier>
        <xsl:variable name=""var:v9"" select=""userCSharp:ProprietaryDocumentIdentifier(string(s0:config/s0:toRole/s0:Partner/text()) , &quot;SOI&quot; , string(@VendorDuns))"" />
        <ns0:ProprietaryDocumentIdentifier>
          <xsl:value-of select=""$var:v9"" />
        </ns0:ProprietaryDocumentIdentifier>
      </ns0:thisDocumentIdentifier>
      <ns0:toRole>
        <ns0:PartnerRoleDescription>
          <ns0:GlobalPartnerRoleClassificationCode>
            <xsl:value-of select=""s0:config/s0:toRole/s0:GlobalPartnerRoleClassificationCode/text()"" />
          </ns0:GlobalPartnerRoleClassificationCode>
          <ns0:PartnerDescription>
            <ns0:BusinessDescription>
              <ns0:BusinessIdentification>
                <ns0:GlobalBusinessIdentifier>
                  <xsl:value-of select=""s0:config/s0:toRole/s0:GlobalBusinessIdentifier/text()"" />
                </ns0:GlobalBusinessIdentifier>
              </ns0:BusinessIdentification>
              <ns0:GlobalSupplyChainCode>
                <xsl:value-of select=""s0:config/s0:toRole/s0:GlobalSupplyChainCode/text()"" />
              </ns0:GlobalSupplyChainCode>
            </ns0:BusinessDescription>
            <ns0:GlobalPartnerClassificationCode>
              <xsl:value-of select=""s0:config/s0:toRole/s0:GlobalPartnerClassificationCode/text()"" />
            </ns0:GlobalPartnerClassificationCode>
          </ns0:PartnerDescription>
        </ns0:PartnerRoleDescription>
      </ns0:toRole>
    </ns0:Pip4C1InventoryReportNotification>
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


///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

public string dateTimeNow()
{
	return DateTime.Now.ToString(""yyyyMMddTHHmmss.fff"") + ""z"";
}


///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

public string ProprietaryLotIdentifier(string Site, string InventoryType, 
            string ReceiptDate, string StorerKey, string SupplierDO,
            string SpecialRemarks,string SeagatePO)
        { 
             
            string receivedate = """";
            if (SpecialRemarks.ToUpper().Trim()!=""OK"")
            {
                if(!string.IsNullOrEmpty(ReceiptDate)){
                    receivedate = DateTime.Parse(ReceiptDate).ToString(""MMMddyyyy"", System.Globalization.CultureInfo.CreateSpecificCulture(""en-US""));
                }
                return string.Format(""{0}/{1}/{2}*{3}*{4}*{5}*{6}"", Site, InventoryType, receivedate, StorerKey, SupplierDO, SpecialRemarks, SeagatePO);
            }
            else
            {
                return string.Format(""{0}*{1}*{2}*{3}*{4}"",Site,StorerKey,SupplierDO,SpecialRemarks,SeagatePO);
            }
        }


///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

public string ProprietaryDocumentIdentifier(string Site,string msgType,string supplierDuns) {
            string str = DateTime.Now.ToString(""yyyyMMddHHmmssfff"");
            string seq = ""000001"";
            return string.Format(""{0}{2}{3}{4}"", Site, msgType, str, supplierDuns, seq);
        }



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Kaifa.B2B.Schemas.Wms.VendorInventoryReport";
        
        private const global::Kaifa.B2B.Schemas.Wms.VendorInventoryReport _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4C1_MS_1_0_SupplierOwnInventory";
        
        private const global::Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4C1_MS_1_0_SupplierOwnInventory _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Kaifa.B2B.Schemas.Wms.VendorInventoryReport";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4C1_MS_1_0_SupplierOwnInventory";
                return _TrgSchemas;
            }
        }
    }
}
