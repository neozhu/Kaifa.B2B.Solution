namespace Kaifa.B2B.Schemas.Wms {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://kaifa.b2b.schemas/OrderShipmentPOD",@"CMShipmentPODReport")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CMShipmentPODReport"})]
    public sealed class CMShipmentPODReport : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://kaifa.b2b.schemas/OrderShipmentPOD"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CMShipmentPODReport"">
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
        <xs:element name=""NOASIC"">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs=""unbounded"" name=""ORDER"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ORDERKEY"" type=""xs:string"" />
                    <xs:element name=""EXTERNORDERKEY"" type=""xs:string"" />
                    <xs:element name=""DELIVERYORDER"" type=""xs:string"" />
                    <xs:element name=""CMCODE"" type=""xs:string"" />
                    <xs:element maxOccurs=""unbounded"" name=""ORDERDETAIL"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element minOccurs=""0"" name=""STORERKEY"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ORDERKEY"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""TRANSACTIONDATE"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""EXTERNORDERKEY"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""COMCODE"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""CONSIGNEEKEY"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""CMDUNS"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""SKU"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""SKUGROUP"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""COMMODITYCLASS"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""LOTTABLE02"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""LOTTABLE03"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""LOTTABLE04"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""LOTTABLE06"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""LOTTABLE07"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""LOTTABLE08"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""SPREMARK"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""QTY"" type=""xs:string"" />
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
      <xs:attribute name=""CMCode"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""CMDuns"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CMShipmentPODReport() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CMShipmentPODReport";
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
