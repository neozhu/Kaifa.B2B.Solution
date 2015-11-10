namespace Kaifa.B2B.Schemas.Wms {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Kaifa.B2B.Schemas.WMSAR",@"ARReport")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ARReport"})]
    public sealed class ARReport : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://Kaifa.B2B.Schemas.WMSAR"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ARReport"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""CustARReport"">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs=""unbounded"" name=""AR"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ARBATCHID"" type=""xs:string"" />
                    <xs:element name=""CUST_CODE"" type=""xs:string"" />
                    <xs:element name=""INVOICE_TYPE"" type=""xs:string"" />
                    <xs:element name=""COST"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
            <xs:attribute name=""CUSTCODE"" type=""xs:string"" use=""required"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ARReport() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ARReport";
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
