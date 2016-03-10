namespace Kaifa.B2B.CLS.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Kaifa.B2B.Schemas.PREDIS",@"PREDIS")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PREDIS"})]
    public sealed class PREDIS : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://Kaifa.B2B.Schemas.PREDIS"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PREDIS"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""PREDISB2B"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ORDERKEY"" type=""xs:string"" />
              <xs:element name=""ACTUALSHIPDATE"" type=""xs:string"" />
              <xs:element name=""TOTALGROSSWGT"" type=""xs:string"" />
              <xs:element name=""TOTALQTY"" type=""xs:string"" />
              <xs:element name=""CONSIGNEEKEY"" type=""xs:string"" />
              <xs:element name=""SKU"" type=""xs:string"" />
              <xs:element name=""LOTTABLE02"" type=""xs:string"" />
              <xs:element name=""LOTTABLE03"" type=""xs:string"" />
              <xs:element name=""TOTALPRICE"" type=""xs:string"" />
              <xs:element name=""QTY"" type=""xs:string"" />
              <xs:element name=""GROSSWGT"" type=""xs:string"" />
              <xs:element name=""NETWGT"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PREDIS() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PREDIS";
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
