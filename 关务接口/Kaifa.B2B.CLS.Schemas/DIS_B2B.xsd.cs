namespace Kaifa.B2B.CLS.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"DIS_B2B")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"DIS_B2B"})]
    public sealed class DIS_B2B : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""DIS_B2B"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""DIS_B2B_HEAD"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""GATEPASS_NO"" type=""xs:string"" />
              <xs:element name=""PRE_GATEPASS_NO"" type=""xs:string"" />
              <xs:element name=""PASS_NO"" type=""xs:string"" />
              <xs:element name=""COR_NO"" type=""xs:string"" />
              <xs:element name=""IE_MARK"" type=""xs:string"" />
              <xs:element name=""WMS"" type=""xs:string"" />
              <xs:element name=""APP_NO"" type=""xs:string"" />
              <xs:element name=""IN_COMP_CODE"" type=""xs:string"" />
              <xs:element name=""IN_COMP_NAME"" type=""xs:string"" />
              <xs:element name=""OUT_COMP_CODE"" type=""xs:string"" />
              <xs:element name=""OUT_COMP_NAME"" type=""xs:string"" />
              <xs:element name=""CREATETIMESTAMP"" type=""xs:string"" />
              <xs:element name=""CLOSE_DATE"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element maxOccurs=""unbounded"" name=""DIS_B2B_BODY"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""PRE_GATEPASS_NO"" type=""xs:string"" />
              <xs:element name=""G_NO"" type=""xs:string"" />
              <xs:element name=""C_NAME"" type=""xs:string"" />
              <xs:element name=""COMMON_UNIT"" type=""xs:string"" />
              <xs:element name=""COMMON_NUM"" type=""xs:string"" />
              <xs:element name=""CURR"" type=""xs:string"" />
              <xs:element name=""TOTAL"" type=""xs:string"" />
              <xs:element name=""PRIC"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element maxOccurs=""unbounded"" name=""DIS_B2B_BODY_ORG"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""PRE_GATEPASS_NO"" type=""xs:string"" />
              <xs:element name=""PART_NO"" type=""xs:string"" />
              <xs:element name=""G_NO"" type=""xs:string"" />
              <xs:element name=""C_NAME"" type=""xs:string"" />
              <xs:element name=""COMMON_UNIT"" type=""xs:string"" />
              <xs:element name=""COMMON_NUM"" type=""xs:string"" />
              <xs:element name=""CURR"" type=""xs:string"" />
              <xs:element name=""TOTAL"" type=""xs:string"" />
              <xs:element name=""PRIC"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public DIS_B2B() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "DIS_B2B";
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
