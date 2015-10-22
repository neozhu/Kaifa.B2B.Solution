namespace Kaifa.B2B.Schemas.Wms {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://kaifa.b2b.schemas/AdvancedShipNotice",@"AdvancedShipNotice")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AdvancedShipNotice"})]
    public sealed class AdvancedShipNotice : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://kaifa.b2b.schemas/AdvancedShipNotice"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://kaifa.b2b.schemas/AdvancedShipNotice"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""AdvancedShipNotice"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""VendorReceiptReport"">
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
                          <xs:element name=""facsimileNumber"" type=""xs:string"" />
                          <xs:element name=""telephoneNumber"" type=""xs:string"" />
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
                          <xs:element name=""facsimileNumber"" type=""xs:string"" />
                          <xs:element name=""telephoneNumber"" type=""xs:string"" />
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
              <xs:element maxOccurs=""unbounded"" name=""RECEIPT"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""WHSEID"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""RECEIPTKEY"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""STORERKEY"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""TYPE"" type=""xs:string"" />
                    <xs:element maxOccurs=""unbounded"" name=""RECEIPTDETAIL"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element minOccurs=""0"" name=""SKU"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""LOTTABLE01"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""LOTTABLE02"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""LOTTABLE03"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""LOTTABLE04"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""LOTTABLE05"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""LOTTABLE06"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""LOTTABLE07"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""LOTTABLE08"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""LOTTABLE09"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""LOTTABLE10"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""QTYEXPECTED"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""QTYADJUSTED"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""QTYRECEIVED"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""DOREMARK"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
            <xs:attribute name=""VendorCode"" type=""xs:string"" />
            <xs:attribute name=""VendorDuns"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public AdvancedShipNotice() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "AdvancedShipNotice";
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
