namespace Kaifa.B2B.SAP.AR {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    public sealed class ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_rfc_functions : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""urn:sap-com:document:sap:rfc:functions"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""qualified"" targetNamespace=""urn:sap-com:document:sap:rfc:functions"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:simpleType name=""char1"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""char10"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""10"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""char220"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""220"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""char4"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""4"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""char50"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""50"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""cuky5"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""5"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""date"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""10"" />
      <xs:pattern value=""\d\d\d\d-\d\d-\d\d"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""decimal23.4"">
    <xs:restriction base=""xs:decimal"">
      <xs:totalDigits value=""23"" />
      <xs:fractionDigits value=""4"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""numeric4"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""4"" />
      <xs:pattern value=""\d*"" />
    </xs:restriction>
  </xs:simpleType>
</xs:schema>";
        
        public ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_rfc_functions() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [0];
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
