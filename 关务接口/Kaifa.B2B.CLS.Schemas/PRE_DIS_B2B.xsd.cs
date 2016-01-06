namespace Kaifa.B2B.CLS.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"PRE_DIS_B2B")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PRE_DIS_B2B"})]
    public sealed class PRE_DIS_B2B : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PRE_DIS_B2B"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""PRE_DIS_HEAD_B2B"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""B2B_OBJECT_ID"" type=""xs:string"" />
              <xs:element name=""COR_NO"" type=""xs:string"" />
              <xs:element name=""IE_MARK"" type=""xs:string"" />
              <xs:element name=""BIZ_TYPE"" type=""xs:string"" />
              <xs:element name=""TRAF_WAY"" type=""xs:string"" />
              <xs:element name=""IN_COMP_CODE"" type=""xs:string"" />
              <xs:element name=""OUT_COMP_CODE"" type=""xs:string"" />
              <xs:element name=""NUM"" type=""xs:string"" />
              <xs:element name=""GROSS_WT"" type=""xs:string"" />
              <xs:element name=""NET_WT"" type=""xs:string"" />
              <xs:element name=""PRE_MAN"" type=""xs:string"" />
              <xs:element name=""PRE_DATE"" type=""xs:string"" />
              <xs:element name=""REMARK"" type=""xs:string"" />
              <xs:element name=""CREATEUSERID"" type=""xs:string"" />
              <xs:element name=""CREATETIMESTAMP"" type=""xs:string"" />
              <xs:element name=""INPUTER_CODE"" type=""xs:string"" />
              <xs:element name=""INPUTER_NAME"" type=""xs:string"" />
              <xs:element name=""APP_NO"" type=""xs:string"" />
              <xs:element name=""WRAP_TYPE"" type=""xs:string"" />
              <xs:element name=""B2B_UPLOAD_DATE"" type=""xs:string"" />
              <xs:element name=""AREA_NO"" type=""xs:string"" />
              <xs:element name=""DOWNGOODS_NO"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element maxOccurs=""unbounded"" name=""PRE_DIS_BODY_B2B"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""B2B_OBJECT_ID"" type=""xs:string"" />
              <xs:element name=""PART_NO"" type=""xs:string"" />
              <xs:element name=""PO_NO"" type=""xs:string"" />
              <xs:element name=""DO_NO"" type=""xs:string"" />
              <xs:element name=""CURR"" type=""xs:string"" />
              <xs:element name=""COMMON_NUM"" type=""xs:string"" />
              <xs:element name=""TOTAL"" type=""xs:string"" />
              <xs:element name=""NOTE"" type=""xs:string"" />
              <xs:element name=""WEIGHT"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PRE_DIS_B2B() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PRE_DIS_B2B";
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
