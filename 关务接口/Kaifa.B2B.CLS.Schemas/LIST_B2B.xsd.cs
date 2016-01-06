namespace Kaifa.B2B.CLS.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"LIST_B2B")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"LIST_B2B"})]
    public sealed class LIST_B2B : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""LIST_B2B"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""PRE_DIS_B2B_RET"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ERP_OBJECT_ID"" type=""xs:string"" />
              <xs:element name=""PRE_GATEPASS_NO"" type=""xs:string"" />
              <xs:element name=""IMPORT_STATUS"" type=""xs:string"" />
              <xs:element name=""IMPORT_DATE"" type=""xs:string"" />
              <xs:element name=""MESSAGE"" type=""xs:string"" />
              <xs:element name=""GATEPASS_NO"" type=""xs:string"" />
              <xs:element name=""GOODS_PASS_DATE"" type=""xs:string"" />
              <xs:element name=""PASS_NO"" type=""xs:string"" />
              <xs:element name=""IN_ENTITY_ID"" type=""xs:string"" />
              <xs:element name=""OUT_ENTITY_ID"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public LIST_B2B() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "LIST_B2B";
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
