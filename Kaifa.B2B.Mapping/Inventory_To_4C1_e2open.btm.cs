namespace Kaifa.B2B.Mapping {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.Schemas.Wms.VendorInventoryReport", typeof(Kaifa.B2B.Schemas.Wms.VendorInventoryReport))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4C1_MS_1_0_SupplierOwnInventory", typeof(Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4C1_MS_1_0_SupplierOwnInventory))]
    public sealed class Inventory_To_4C1_e2open : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://kaifa.b2b.schemas/InventoryReport"" xmlns:ns0=""http://kaifa.b2b.schemas/SGRTHUB4C1_MS_1_0_SupplierOwnInventory"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:VendorInventoryReport"" />
  </xsl:template>
  <xsl:template match=""/s0:VendorInventoryReport"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringTrimLeft(&quot;Inventory Information Provider&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringTrimLeft(&quot;545196698&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringTrimLeft(&quot;Request&quot;)"" />
    <xsl:variable name=""var:v15"" select=""userCSharp:StringTrimLeft(&quot;Inventory Information User&quot;)"" />
    <xsl:variable name=""var:v16"" select=""userCSharp:StringTrimLeft(&quot;Electronic Components&quot;)"" />
    <xsl:variable name=""var:v17"" select=""userCSharp:StringTrimLeft(&quot;Manufacturer&quot;)"" />
    <ns0:Pip4C1InventoryReportNotification>
      <ns0:fromRole>
        <ns0:PartnerRoleDescription>
          <ns0:ContactInformation>
            <ns0:contactName>
              <xsl:if test=""s0:config/s0:fromRole/s0:contactName"">
                <ns0:FreeFormText>
                  <xsl:value-of select=""s0:config/s0:fromRole/s0:contactName/text()"" />
                </ns0:FreeFormText>
              </xsl:if>
            </ns0:contactName>
            <xsl:if test=""s0:config/s0:fromRole/s0:EmailAddress"">
              <ns0:EmailAddress>
                <xsl:value-of select=""s0:config/s0:fromRole/s0:EmailAddress/text()"" />
              </ns0:EmailAddress>
            </xsl:if>
            <ns0:facsimileNumber>
              <xsl:if test=""s0:config/s0:fromRole/s0:facsimileNumber"">
                <ns0:CommunicationsNumber>
                  <xsl:value-of select=""s0:config/s0:fromRole/s0:facsimileNumber/text()"" />
                </ns0:CommunicationsNumber>
              </xsl:if>
            </ns0:facsimileNumber>
            <ns0:telephoneNumber>
              <xsl:if test=""s0:config/s0:fromRole/s0:telephoneNumber"">
                <ns0:CommunicationsNumber>
                  <xsl:value-of select=""s0:config/s0:fromRole/s0:telephoneNumber/text()"" />
                </ns0:CommunicationsNumber>
              </xsl:if>
            </ns0:telephoneNumber>
          </ns0:ContactInformation>
          <ns0:GlobalPartnerRoleClassificationCode>
            <xsl:value-of select=""$var:v1"" />
          </ns0:GlobalPartnerRoleClassificationCode>
          <ns0:PartnerDescription>
            <ns0:BusinessDescription>
              <ns0:BusinessIdentification>
                <ns0:GlobalBusinessIdentifier>
                  <xsl:value-of select=""$var:v2"" />
                </ns0:GlobalBusinessIdentifier>
              </ns0:BusinessIdentification>
              <xsl:if test=""s0:config/s0:fromRole/s0:GlobalSupplyChainCode"">
                <ns0:GlobalSupplyChainCode>
                  <xsl:value-of select=""s0:config/s0:fromRole/s0:GlobalSupplyChainCode/text()"" />
                </ns0:GlobalSupplyChainCode>
              </xsl:if>
            </ns0:BusinessDescription>
            <xsl:if test=""s0:config/s0:fromRole/s0:GlobalPartnerClassificationCode"">
              <ns0:GlobalPartnerClassificationCode>
                <xsl:value-of select=""s0:config/s0:fromRole/s0:GlobalPartnerClassificationCode/text()"" />
              </ns0:GlobalPartnerClassificationCode>
            </xsl:if>
          </ns0:PartnerDescription>
        </ns0:PartnerRoleDescription>
      </ns0:fromRole>
      <ns0:GlobalDocumentFunctionCode>
        <xsl:value-of select=""$var:v3"" />
      </ns0:GlobalDocumentFunctionCode>
      <ns0:InventoryReport>
        <ns0:inventoryReportDateTime>
          <xsl:variable name=""var:v4"" select=""userCSharp:dateTimeNow()"" />
          <ns0:DateTimeStamp>
            <xsl:value-of select=""$var:v4"" />
          </ns0:DateTimeStamp>
        </ns0:inventoryReportDateTime>
        <xsl:for-each select=""s0:INVENTORY"">
          <xsl:variable name=""var:v5"" select=""userCSharp:StringTrimLeft(&quot;Each&quot;)"" />
          <xsl:variable name=""var:v6"" select=""userCSharp:StringTrimLeft(&quot;Manufacturer&quot;)"" />
          <xsl:variable name=""var:v7"" select=""userCSharp:StringTrimLeft(&quot;Available&quot;)"" />
          <xsl:variable name=""var:v9"" select=""userCSharp:StringConcat(string(../s0:config/s0:fromRole/s0:Site/text()) , string(s0:STORERKEY/text()))"" />
          <xsl:variable name=""var:v10"" select=""string(../s0:config/s0:fromRole/s0:Site/text())"" />
          <xsl:variable name=""var:v11"" select=""string(s0:LOTTABLE04/text())"" />
          <ns0:InventoryReportLineItem>
            <ns0:GlobalProductUnitOfMeasureCode>
              <xsl:value-of select=""$var:v5"" />
            </ns0:GlobalProductUnitOfMeasureCode>
            <ns0:inventoryLocation>
              <ns0:PartnerDescription>
                <ns0:BusinessDescription>
                  <ns0:BusinessIdentification>
                    <ns0:GlobalBusinessIdentifier>
                      <xsl:value-of select=""../@VendorDuns"" />
                    </ns0:GlobalBusinessIdentifier>
                  </ns0:BusinessIdentification>
                </ns0:BusinessDescription>
                <ns0:GlobalPartnerClassificationCode>
                  <xsl:value-of select=""$var:v6"" />
                </ns0:GlobalPartnerClassificationCode>
              </ns0:PartnerDescription>
            </ns0:inventoryLocation>
            <ns0:InventoryProductQuantity>
              <ns0:GlobalInventoryCode>
                <xsl:value-of select=""$var:v7"" />
              </ns0:GlobalInventoryCode>
              <ns0:InventoryItemIdentification>
                <ns0:manufactureDate>
                  <xsl:variable name=""var:v8"" select=""userCSharp:DateTimeFormat(string(s0:LOTTABLE04/text()))"" />
                  <ns0:DateTimeStamp>
                    <xsl:value-of select=""$var:v8"" />
                  </ns0:DateTimeStamp>
                </ns0:manufactureDate>
                <xsl:variable name=""var:v12"" select=""userCSharp:ProprietaryLotIdentifier($var:v10 , &quot;ONHOLD&quot; , string(s0:LOTTABLE06/text()) , $var:v11 , string($var:v9) , string(s0:LOTTABLE02/text()) , string(s0:LOTTABLE08/text()) , string(s0:LOTTABLE03/text()) , string(s0:HOLDQTY/text()))"" />
                <ns0:ProprietaryLotIdentifier>
                  <xsl:value-of select=""$var:v12"" />
                </ns0:ProprietaryLotIdentifier>
              </ns0:InventoryItemIdentification>
              <xsl:if test=""s0:QTY"">
                <ns0:ProductQuantity>
                  <xsl:value-of select=""s0:QTY/text()"" />
                </ns0:ProductQuantity>
              </xsl:if>
            </ns0:InventoryProductQuantity>
            <ns0:ProductIdentification>
              <ns0:PartnerProductIdentification>
                <ns0:GlobalPartnerClassificationCode>
                  <xsl:value-of select=""$var:v6"" />
                </ns0:GlobalPartnerClassificationCode>
                <xsl:if test=""s0:SKU"">
                  <ns0:ProprietaryProductIdentifier>
                    <xsl:value-of select=""s0:SKU/text()"" />
                  </ns0:ProprietaryProductIdentifier>
                </xsl:if>
                <ns0:revisionIdentifier>
                  <xsl:if test=""s0:HOLDQTY"">
                    <ns0:FreeFormText>
                      <xsl:value-of select=""s0:HOLDQTY/text()"" />
                    </ns0:FreeFormText>
                  </xsl:if>
                </ns0:revisionIdentifier>
              </ns0:PartnerProductIdentification>
            </ns0:ProductIdentification>
          </ns0:InventoryReportLineItem>
        </xsl:for-each>
      </ns0:InventoryReport>
      <ns0:thisDocumentGenerationDateTime>
        <xsl:variable name=""var:v13"" select=""userCSharp:dateTimeNow()"" />
        <ns0:DateTimeStamp>
          <xsl:value-of select=""$var:v13"" />
        </ns0:DateTimeStamp>
      </ns0:thisDocumentGenerationDateTime>
      <ns0:thisDocumentIdentifier>
        <xsl:variable name=""var:v14"" select=""userCSharp:ProprietaryDocumentIdentifier(string(s0:config/s0:fromRole/s0:Site/text()) , &quot;SOI&quot; , string(@VendorDuns))"" />
        <ns0:ProprietaryDocumentIdentifier>
          <xsl:value-of select=""$var:v14"" />
        </ns0:ProprietaryDocumentIdentifier>
      </ns0:thisDocumentIdentifier>
      <ns0:toRole>
        <ns0:PartnerRoleDescription>
          <ns0:GlobalPartnerRoleClassificationCode>
            <xsl:value-of select=""$var:v15"" />
          </ns0:GlobalPartnerRoleClassificationCode>
          <ns0:PartnerDescription>
            <ns0:BusinessDescription>
              <ns0:BusinessIdentification>
                <ns0:GlobalBusinessIdentifier>
                  <xsl:value-of select=""@VendorDuns"" />
                </ns0:GlobalBusinessIdentifier>
              </ns0:BusinessIdentification>
              <ns0:GlobalSupplyChainCode>
                <xsl:value-of select=""$var:v16"" />
              </ns0:GlobalSupplyChainCode>
            </ns0:BusinessDescription>
            <ns0:GlobalPartnerClassificationCode>
              <xsl:value-of select=""$var:v17"" />
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
	return DateTime.Now.ToString(""yyyyMMddTHHmmss.fff"") + ""Z"";
}

///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

public string ProprietaryDocumentIdentifier(string Site,string msgType,string supplierDuns) {
            string str = DateTime.Now.ToString(""yyyyMMddHHmmssfff"");
            string seq = ""000001"";
            return string.Format(""{0}{1}{2}{3}{5}{4}"", Site, msgType, str, supplierDuns, seq,""663050425"");
        }

//For ON Hold Qty
        //<Site>/<InventoryType>/<Original Hub Receipt Date>*<Storer Key>*<Supplier DO#>*<Special Remarks from Supplier DO>*<Seagate PO#> *<RMA/RTV Number>
        //<Site>*<Storer Key>*<Supplier DO#>*<Special Remarks from Supplier DO>*<Seagate PO#>
       public string ProprietaryLotIdentifier(string Site, string InventoryType,
             string onholdRemark,
             string ReceiptDate, string StorerKey, string SupplierDO,
             string SpecialRemarks, string SeagatePO, string OnHoldQty)
        {

            string receivedate = """";
            if (decimal.Parse(OnHoldQty) > 0)
            {
                if (!string.IsNullOrEmpty(ReceiptDate))
                {
                    receivedate = DateTime.Parse(ReceiptDate).ToString(""MMMddyyyy"", System.Globalization.CultureInfo.CreateSpecificCulture(""en-US""));
                }
                if (onholdRemark.ToUpper().Trim() == ""RTV"")
                {
                    return string.Format(""{0}/{1}/{2}*{3}*{4}*{5}*{6}*{7}"", Site.Substring(0, 2), InventoryType + "" "" + onholdRemark, receivedate, StorerKey, SupplierDO, onholdRemark, """", SeagatePO);
                }
                else
                {
                    return string.Format(""{0}/{1}/{2}*{3}*{4}*{5}*{6}*{7}"", Site.Substring(0, 2), InventoryType + "" "" + onholdRemark, receivedate, StorerKey, SupplierDO, SpecialRemarks,  SeagatePO,"""");
                }
            }
            else
            {
                return string.Format(""{0}*{1}*{2}*{3}*{4}"", Site.Substring(0, 2), StorerKey, SupplierDO, SpecialRemarks, SeagatePO);
            }
        }

public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}


public string DateTimeFormat(string str) {
            //20150616T021822.000Z
            //2015-03-31T21:44:21
            //return str.Replace(""-"", string.Empty).Replace("":"", string.Empty).Substring(0,15) + "".000Z"";
              return str.Replace(""-"", string.Empty).Replace("":"", string.Empty).Substring(0,9) + ""000000.000Z"";
        }


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Kaifa.B2B.Schemas.Wms.VendorInventoryReport";
        
        private const Kaifa.B2B.Schemas.Wms.VendorInventoryReport _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4C1_MS_1_0_SupplierOwnInventory";
        
        private const Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4C1_MS_1_0_SupplierOwnInventory _trgSchemaTypeReference0 = null;
        
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
