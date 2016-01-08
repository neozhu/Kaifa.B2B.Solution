namespace IntegrationExperts.Samples.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://IntegrationExperts_v1.0",@"CustomerInfo")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CustomerInfo"})]
    public sealed class Customer : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://IntegrationExperts_v1.0"" elementFormDefault=""qualified"" targetNamespace=""http://IntegrationExperts_v1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CustomerInfo"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""ID"" type=""xs:string"" />
        <xs:element name=""FNAME"" type=""xs:string"" />
        <xs:element name=""LNAME"" type=""xs:string"" />
        <xs:element name=""ADDRESS"" type=""xs:string"" />
        <xs:element name=""PHONE"" type=""xs:string"" />
        <xs:element name=""EMAIL"" type=""xs:string"" />
        <xs:element name=""POSTCODE"" type=""xs:string"" />
        <xs:element name=""STATE"" type=""xs:string"" />
        <xs:element name=""COUNTRY"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Customer() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CustomerInfo";
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
