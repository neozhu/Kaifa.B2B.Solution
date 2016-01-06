namespace Kaifa.B2B.CLS.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"HTTP://CLIS.HB_DEC",@"HB_DEC")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"HB_DEC"})]
    public sealed class HB_DEC : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""HTTP://CLIS.HB_DEC"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""HB_DEC"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""HB_DEC_HEAD"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""SEQ_NO"" type=""xs:string"" />
              <xs:element name=""ENTRY_ID"" type=""xs:unsignedLong"" />
              <xs:element name=""I_E_FLAG"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element maxOccurs=""unbounded"" name=""HB_DEC_LIST"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""COP_G_NO"" type=""xs:string"" />
              <xs:element name=""QTY"" type=""xs:decimal"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public HB_DEC() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "HB_DEC";
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
