namespace Kaifa.B2B.SAP.AR {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ZfiCreateArForWms", @"ZfiCreateArForWmsResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.SAP.AR.ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_rfc_functions", typeof(Kaifa.B2B.SAP.AR.ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_rfc_functions))]
    public sealed class ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:n0=""urn:sap-com:document:sap:rfc:functions"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""qualified"" targetNamespace=""urn:sap-com:document:sap:soap:functions:mc-style"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Kaifa.B2B.SAP.AR.ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_rfc_functions"" namespace=""urn:sap-com:document:sap:rfc:functions"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""urn:sap-com:document:sap:rfc:functions"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""ZfiWmsStru"">
    <xs:sequence>
      <xs:element name=""CustomerNo"" type=""xs:string"" />
      <xs:element name=""AmountValue"" type=""xs:decimal"" />
      <xs:element name=""Currency"" type=""xs:string"" />
      <xs:element name=""ArType"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ZmesMsgStru"">
    <xs:sequence>
      <xs:element name=""Type"" type=""xs:string"" />
      <xs:element name=""Message"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""TableOfZfiWmsStru"">
    <xs:sequence>
      <xs:element xmlns:q1=""urn:sap-com:document:sap:soap:functions:mc-style"" minOccurs=""0"" maxOccurs=""unbounded"" name=""item"" type=""q1:ZfiWmsStru"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""TableOfZmesMsgStru"">
    <xs:sequence>
      <xs:element xmlns:q2=""urn:sap-com:document:sap:soap:functions:mc-style"" minOccurs=""0"" maxOccurs=""unbounded"" name=""item"" type=""q2:ZmesMsgStru"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ZfiCreateArForWms"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q3=""urn:sap-com:document:sap:soap:functions:mc-style"" name=""ArData"" type=""q3:TableOfZfiWmsStru"" />
        <xs:element xmlns:q4=""urn:sap-com:document:sap:soap:functions:mc-style"" name=""MsgTab"" type=""q4:TableOfZmesMsgStru"" />
        <xs:element name=""PostingDate"" type=""xs:string"" />
        <xs:element name=""WmsBatchid"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ZfiCreateArForWmsResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q5=""urn:sap-com:document:sap:soap:functions:mc-style"" name=""ArData"" type=""q5:TableOfZfiWmsStru"" />
        <xs:element name=""CompanyCode"" type=""xs:string"" />
        <xs:element name=""DocumentNumber"" type=""xs:string"" />
        <xs:element name=""DocumentYear"" type=""xs:string"" />
        <xs:element xmlns:q6=""urn:sap-com:document:sap:soap:functions:mc-style"" name=""MsgTab"" type=""q6:TableOfZmesMsgStru"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "ZfiCreateArForWms";
                _RootElements[1] = "ZfiCreateArForWmsResponse";
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
        
        [Schema(@"urn:sap-com:document:sap:soap:functions:mc-style",@"ZfiCreateArForWms")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ZfiCreateArForWms"})]
        public sealed class ZfiCreateArForWms : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ZfiCreateArForWms() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ZfiCreateArForWms";
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
        
        [Schema(@"urn:sap-com:document:sap:soap:functions:mc-style",@"ZfiCreateArForWmsResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ZfiCreateArForWmsResponse"})]
        public sealed class ZfiCreateArForWmsResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ZfiCreateArForWmsResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ZfiCreateArForWmsResponse";
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
}
