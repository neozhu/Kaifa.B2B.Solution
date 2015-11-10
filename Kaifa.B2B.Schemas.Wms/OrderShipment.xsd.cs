namespace Kaifa.B2B.Schemas.Wms {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://kaifa.b2b.schemas/OrderShipment",@"OrderShipment")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"OrderShipment"})]
    public sealed class OrderShipment : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://kaifa.b2b.schemas/OrderShipment"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://kaifa.b2b.schemas/OrderShipment"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""OrderShipment"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""VendorShipmentReport"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""config"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""fromRole"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""Site"" type=""xs:string"" />
                          <xs:element name=""Partner"" type=""xs:string"" />
                          <xs:element name=""roleType"" type=""xs:string"" />
                          <xs:element name=""contactName"" type=""xs:string"" />
                          <xs:element name=""EmailAddress"" type=""xs:string"" />
                          <xs:element name=""facsimileNumber"" type=""xs:string"" />
                          <xs:element name=""telephoneNumber"" type=""xs:string"" />
                          <xs:element name=""GlobalBusinessIdentifier"" type=""xs:string"" />
                          <xs:element name=""GlobalSupplyChainCode"" type=""xs:string"" />
                          <xs:element name=""GlobalPartnerClassificationCode"" type=""xs:string"" />
                          <xs:element name=""GlobalPartnerRoleClassificationCode"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""tostxRole"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""Site"" type=""xs:string"" />
                          <xs:element name=""Partner"" type=""xs:string"" />
                          <xs:element name=""roleType"" type=""xs:string"" />
                          <xs:element name=""contactName"" type=""xs:string"" />
                          <xs:element name=""EmailAddress"" type=""xs:string"" />
                          <xs:element name=""facsimileNumber"" type=""xs:anyType"" />
                          <xs:element name=""telephoneNumber"" type=""xs:anyType"" />
                          <xs:element name=""GlobalBusinessIdentifier"" type=""xs:string"" />
                          <xs:element name=""GlobalSupplyChainCode"" type=""xs:string"" />
                          <xs:element name=""GlobalPartnerClassificationCode"" type=""xs:string"" />
                          <xs:element name=""GlobalPartnerRoleClassificationCode"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""toe2openRole"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""Site"" type=""xs:string"" />
                          <xs:element name=""Partner"" type=""xs:string"" />
                          <xs:element name=""roleType"" type=""xs:string"" />
                          <xs:element name=""contactName"" type=""xs:string"" />
                          <xs:element name=""EmailAddress"" type=""xs:string"" />
                          <xs:element name=""facsimileNumber"" type=""xs:anyType"" />
                          <xs:element name=""telephoneNumber"" type=""xs:anyType"" />
                          <xs:element name=""GlobalBusinessIdentifier"" type=""xs:string"" />
                          <xs:element name=""GlobalSupplyChainCode"" type=""xs:string"" />
                          <xs:element name=""GlobalPartnerClassificationCode"" type=""xs:string"" />
                          <xs:element name=""GlobalPartnerRoleClassificationCode"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""ALL"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element maxOccurs=""unbounded"" name=""ORDER"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""ORDERKEY"" type=""xs:string"" />
                          <xs:element name=""EXTERNORDERKEY"" type=""xs:string"" />
                          <xs:element name=""COMCODE"" type=""xs:string"" />
                          <xs:element maxOccurs=""unbounded"" name=""ORDERDETAIL"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""STORERKEY"" type=""xs:string"" />
                                <xs:element name=""ORDERKEY"" type=""xs:string"" />
                                <xs:element name=""EXTERNORDERKEY"" type=""xs:string"" />
                                <xs:element name=""COMCODE"" type=""xs:string"" />
                                <xs:element name=""CONSIGNEEKEY"" type=""xs:string"" />
                                <xs:element name=""CMDUNS"" type=""xs:string"" />
                                <xs:element name=""TRANSACTIONDATE"" type=""xs:string"" />
                                <xs:element name=""SKU"" type=""xs:string"" />
                                <xs:element name=""SKUGROUP"" type=""xs:string"" />
                                <xs:element name=""COMMODITYCLASS"" type=""xs:string"" />
                                <xs:element name=""LOTTABLE02"" type=""xs:string"" />
                                <xs:element name=""LOTTABLE03"" type=""xs:string"" />
                                <xs:element name=""LOTTABLE06"" type=""xs:string"" />
                                <xs:element name=""LOTTABLE07"" type=""xs:string"" />
                                <xs:element name=""LOTTABLE08"" type=""xs:string"" />
                                <xs:element minOccurs=""0"" name=""SPREMARK"" type=""xs:string"" />
                                <xs:element name=""QTY"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""ASIC"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element maxOccurs=""unbounded"" name=""ORDER"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""ORDERKEY"" type=""xs:string"" />
                          <xs:element name=""EXTERNORDERKEY"" type=""xs:string"" />
                          <xs:element name=""COMCODE"" type=""xs:string"" />
                          <xs:element maxOccurs=""unbounded"" name=""ORDERDETAIL"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""STORERKEY"" type=""xs:string"" />
                                <xs:element name=""ORDERKEY"" type=""xs:string"" />
                                <xs:element name=""EXTERNORDERKEY"" type=""xs:string"" />
                                <xs:element name=""COMCODE"" type=""xs:string"" />
                                <xs:element name=""CONSIGNEEKEY"" type=""xs:string"" />
                                <xs:element name=""CMDUNS"" type=""xs:string"" />
                                <xs:element name=""TRANSACTIONDATE"" type=""xs:string"" />
                                <xs:element name=""SKU"" type=""xs:string"" />
                                <xs:element name=""SKUGROUP"" type=""xs:string"" />
                                <xs:element name=""COMMODITYCLASS"" type=""xs:string"" />
                                <xs:element name=""LOTTABLE02"" type=""xs:string"" />
                                <xs:element name=""LOTTABLE03"" type=""xs:string"" />
                                <xs:element name=""LOTTABLE06"" type=""xs:string"" />
                                <xs:element name=""LOTTABLE07"" type=""xs:string"" />
                                <xs:element name=""LOTTABLE08"" type=""xs:string"" />
                                <xs:element minOccurs=""0"" name=""SPREMARK"" type=""xs:string"" />
                                <xs:element name=""QTY"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
            <xs:attribute name=""VendorCode"" type=""xs:string"" use=""required"" />
            <xs:attribute name=""VendorDuns"" type=""xs:string"" use=""required"" />
            <xs:attribute name=""CMCode"" type=""xs:string"" use=""required"" />
            <xs:attribute name=""CMDuns"" type=""xs:string"" use=""required"" />
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""ASIC"">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs=""unbounded"" name=""ORDER"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ORDERKEY"" type=""xs:string"" />
                    <xs:element name=""EXTERNORDERKEY"" type=""xs:string"" />
                    <xs:element name=""COMCODE"" type=""xs:string"" />
                    <xs:element maxOccurs=""unbounded"" name=""ORDERDETAIL"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""STORERKEY"" type=""xs:string"" />
                          <xs:element name=""ORDERKEY"" type=""xs:string"" />
                          <xs:element name=""EXTERNORDERKEY"" type=""xs:string"" />
                          <xs:element name=""COMCODE"" type=""xs:string"" />
                          <xs:element name=""CONSIGNEEKEY"" type=""xs:string"" />
                          <xs:element name=""CMDUNS"" type=""xs:string"" />
                          <xs:element name=""TRANSACTIONDATE"" type=""xs:string"" />
                          <xs:element name=""SKU"" type=""xs:string"" />
                          <xs:element name=""SKUGROUP"" type=""xs:string"" />
                          <xs:element name=""COMMODITYCLASS"" type=""xs:string"" />
                          <xs:element name=""LOTTABLE02"" type=""xs:string"" />
                          <xs:element name=""LOTTABLE03"" type=""xs:string"" />
                          <xs:element name=""LOTTABLE06"" type=""xs:string"" />
                          <xs:element name=""LOTTABLE07"" type=""xs:string"" />
                          <xs:element name=""LOTTABLE08"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""SPREMARK"" type=""xs:string"" />
                          <xs:element name=""QTY"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public OrderShipment() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "OrderShipment";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
