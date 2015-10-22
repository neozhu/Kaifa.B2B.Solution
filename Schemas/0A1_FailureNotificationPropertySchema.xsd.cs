namespace Microsoft.Solutions.BTARN.Schemas.RNPIPs {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Property)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"NoFPIPCode", @"NoFPIPVersion", @"NoFPIPInstanceID", @"NoFSourcePartnerID", @"NoFDestinationPartnerID"})]
    public sealed class _0A1_V1_FailureNotificationPropertySchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://schemas.microsoft.com/biztalk/btarn/2004/0A1_FailureNotificationPropertySchema"" targetNamespace=""http://schemas.microsoft.com/biztalk/btarn/2004/0A1_FailureNotificationPropertySchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo schema_type=""property"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""NoFPIPCode"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""e35d5c5e-9d93-4b9a-88f8-56e83cd61d76"" propSchFieldBase=""MessageDataPropertyBase"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""NoFPIPVersion"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""66280f6f-a108-4e04-8000-bc3852ecc3d4"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""NoFPIPInstanceID"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""c036801e-ef05-4367-bdd4-b2cc497b03e6"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""NoFSourcePartnerID"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""a2f60a2d-6e6a-4509-a1c5-5e213ce37890"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""NoFDestinationPartnerID"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""364c1320-d16b-45e4-8e6d-576e256b1175"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public _0A1_V1_FailureNotificationPropertySchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [5];
                _RootElements[0] = "NoFPIPCode";
                _RootElements[1] = "NoFPIPVersion";
                _RootElements[2] = "NoFPIPInstanceID";
                _RootElements[3] = "NoFSourcePartnerID";
                _RootElements[4] = "NoFDestinationPartnerID";
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
    
    [System.SerializableAttribute()]
    [PropertyType(@"NoFPIPCode",@"http://schemas.microsoft.com/biztalk/btarn/2004/0A1_FailureNotificationPropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"e35d5c5e-9d93-4b9a-88f8-56e83cd61d76")]
    public sealed class NoFPIPCode : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"NoFPIPCode", @"http://schemas.microsoft.com/biztalk/btarn/2004/0A1_FailureNotificationPropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [System.SerializableAttribute()]
    [PropertyType(@"NoFPIPVersion",@"http://schemas.microsoft.com/biztalk/btarn/2004/0A1_FailureNotificationPropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"66280f6f-a108-4e04-8000-bc3852ecc3d4")]
    public sealed class NoFPIPVersion : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"NoFPIPVersion", @"http://schemas.microsoft.com/biztalk/btarn/2004/0A1_FailureNotificationPropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [System.SerializableAttribute()]
    [PropertyType(@"NoFPIPInstanceID",@"http://schemas.microsoft.com/biztalk/btarn/2004/0A1_FailureNotificationPropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"c036801e-ef05-4367-bdd4-b2cc497b03e6")]
    public sealed class NoFPIPInstanceID : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"NoFPIPInstanceID", @"http://schemas.microsoft.com/biztalk/btarn/2004/0A1_FailureNotificationPropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [System.SerializableAttribute()]
    [PropertyType(@"NoFSourcePartnerID",@"http://schemas.microsoft.com/biztalk/btarn/2004/0A1_FailureNotificationPropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"a2f60a2d-6e6a-4509-a1c5-5e213ce37890")]
    public sealed class NoFSourcePartnerID : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"NoFSourcePartnerID", @"http://schemas.microsoft.com/biztalk/btarn/2004/0A1_FailureNotificationPropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [System.SerializableAttribute()]
    [PropertyType(@"NoFDestinationPartnerID",@"http://schemas.microsoft.com/biztalk/btarn/2004/0A1_FailureNotificationPropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"364c1320-d16b-45e4-8e6d-576e256b1175")]
    public sealed class NoFDestinationPartnerID : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"NoFDestinationPartnerID", @"http://schemas.microsoft.com/biztalk/btarn/2004/0A1_FailureNotificationPropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
}
