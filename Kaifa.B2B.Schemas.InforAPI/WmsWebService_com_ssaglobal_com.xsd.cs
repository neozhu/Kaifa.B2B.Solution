namespace Kaifa.B2B.Schemas.InforAPI {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"callBackEnd", @"callBackEndResponse"})]
    public sealed class WmsWebService_com_ssaglobal_com : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""http://com.ssaglobal.com"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""qualified"" elementFormDefault=""qualified"" targetNamespace=""http://com.ssaglobal.com"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""callBackEnd"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""in0"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""in1"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""in2"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""in3"" nillable=""true"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""callBackEndResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""out"" nillable=""true"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public WmsWebService_com_ssaglobal_com() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "callBackEnd";
                _RootElements[1] = "callBackEndResponse";
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
        
        [Schema(@"http://com.ssaglobal.com",@"callBackEnd")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"callBackEnd"})]
        public sealed class callBackEnd : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public callBackEnd() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "callBackEnd";
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
        
        [Schema(@"http://com.ssaglobal.com",@"callBackEndResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"callBackEndResponse"})]
        public sealed class callBackEndResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public callBackEndResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "callBackEndResponse";
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
