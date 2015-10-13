namespace Kaifa.B2B.Schemas._940 {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Kaifa.B2B.Schemas.OrderTDN940",@"OrderTDN940")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"OrderTDN940"})]
    public sealed class OrderTND940 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://Kaifa.B2B.Schemas.OrderTDN940"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""OrderTDN940"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""CM_TDN_940"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""SITE"" type=""xs:string"" />
              <xs:element name=""ORDERKEY"" type=""xs:string"" />
              <xs:element name=""ORDERLINENUMBER"" type=""xs:string"" />
              <xs:element name=""REQUESTORDER"" type=""xs:string"" />
              <xs:element name=""REQUESTORDERLINE"" type=""xs:string"" />
              <xs:element name=""CMPO"" type=""xs:string"" />
              <xs:element name=""COMPONENTTYPE"" type=""xs:string"" />
              <xs:element name=""STATUS"" type=""xs:string"" />
              <xs:element name=""CMSITE"" type=""xs:string"" />
              <xs:element name=""REQUESTEDSHIPDATE"" type=""xs:string"" />
              <xs:element name=""CMDUNS"" type=""xs:string"" />
              <xs:element name=""STORERKEY"" type=""xs:string"" />
              <xs:element name=""SKU"" type=""xs:string"" />
              <xs:element name=""SKUGROUP"" type=""xs:string"" />
              <xs:element name=""DESCR"" type=""xs:string"" />
              <xs:element name=""REMARK"" type=""xs:string"" />
              <xs:element name=""ASIC"" type=""xs:string"" />
              <xs:element name=""SUPPLIERDO"" type=""xs:string"" />
              <xs:element name=""SEAGATEPO"" type=""xs:string"" />
              <xs:element name=""COUNTRY"" type=""xs:string"" />
              <xs:element name=""PRIMEONLY"" type=""xs:string"" />
              <xs:element name=""NOOFFEEDER"" type=""xs:string"" />
              <xs:element name=""REQLOC"" type=""xs:string"" />
              <xs:element name=""QTY"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public OrderTND940() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "OrderTDN940";
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
