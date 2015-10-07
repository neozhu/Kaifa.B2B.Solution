namespace Kaifa.B2B.Schemas.Wms {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://kaifa.b2b.schemas/InventoryReport",@"VendorInventoryReport")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"VendorInventoryReport"})]
    public sealed class VendorInventoryReport : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns1=""http://kaifa.b2b.schemas/InventoryReport"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://kaifa.b2b.schemas/InventoryReport"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""VendorInventoryReport"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""config"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""fromRole"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""Site"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""Partner"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""roleType"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""contactName"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""EmailAddress"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""facsimileNumber"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""telephoneNumber"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""GlobalBusinessIdentifier"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""GlobalSupplyChainCode"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""GlobalPartnerClassificationCode"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""GlobalPartnerRoleClassificationCode"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""tostxRole"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""Site"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""Partner"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""roleType"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""contactName"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""EmailAddress"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""facsimileNumber"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""telephoneNumber"" type=""xs:string"" />
                    <xs:element name=""GlobalBusinessIdentifier"" type=""xs:string"" />
                    <xs:element name=""GlobalSupplyChainCode"" type=""xs:string"" />
                    <xs:element name=""GlobalPartnerClassificationCode"" type=""xs:string"" />
                    <xs:element name=""GlobalPartnerRoleClassificationCode"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""toe2openRole"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""Site"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""Partner"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""roleType"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""contactName"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""EmailAddress"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""facsimileNumber"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""telephoneNumber"" type=""xs:string"" />
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
        <xs:element maxOccurs=""unbounded"" name=""INVENTORY"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""SERIALKEY"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""WHSEID"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""STORERKEY"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""STORERDUNS"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""SKU"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""LOT"" type=""xs:string"" />
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
              <xs:element minOccurs=""0"" name=""STATUS"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""QTY"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""HOLDQTY"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
      <xs:attribute name=""VendorCode"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""VendorDuns"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public VendorInventoryReport() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "VendorInventoryReport";
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
