namespace Microsoft.Solutions.BTARN.Schemas.RNPIPs {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd",@"Pip0A1FailureNotification")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(Microsoft.Solutions.BTARN.Schemas.RNPIPs.NoFPIPCode), XPath = @"/*[local-name()='Pip0A1FailureNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='ProcessIdentity' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='GlobalProcessIndicatorCode' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(Microsoft.Solutions.BTARN.Schemas.RNPIPs.NoFPIPInstanceID), XPath = @"/*[local-name()='Pip0A1FailureNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='ProcessIdentity' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='InstanceIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(Microsoft.Solutions.BTARN.Schemas.RNPIPs.NoFPIPVersion), XPath = @"/*[local-name()='Pip0A1FailureNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='ProcessIdentity' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='VersionIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(Microsoft.Solutions.BTARN.Schemas.RNPIPs.NoFSourcePartnerID), XPath = @"/*[local-name()='Pip0A1FailureNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='fromRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(Microsoft.Solutions.BTARN.Schemas.RNPIPs.NoFDestinationPartnerID), XPath = @"/*[local-name()='Pip0A1FailureNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='toRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "fromRole.PartnerRoleDescription.PartnerDescription.BusinessDescription.GlobalBusinessIdentifier", XPath = @"/*[local-name()='Pip0A1FailureNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='fromRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "toRole.PartnerRoleDescription.PartnerDescription.BusinessDescription.GlobalBusinessIdentifier", XPath = @"/*[local-name()='Pip0A1FailureNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='toRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Pip0A1FailureNotification"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Microsoft.Solutions.BTARN.Schemas.RNPIPs.xml", typeof(Microsoft.Solutions.BTARN.Schemas.RNPIPs.xml))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Microsoft.Solutions.BTARN.Schemas.RNPIPs._0A1_V1_FailureNotificationPropertySchema", typeof(Microsoft.Solutions.BTARN.Schemas.RNPIPs._0A1_V1_FailureNotificationPropertySchema))]
    public sealed class _0A1_MS_V02_00_FailureNotification : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns0=""http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns1=""http://schemas.microsoft.com/biztalk/btarn/2004/0A1_FailureNotificationPropertySchema"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Microsoft.Solutions.BTARN.Schemas.RNPIPs.xml"" namespace=""http://www.w3.org/XML/1998/namespace"" />
  <xs:annotation>
    <xs:appinfo>
      <schemaInfo displayroot_reference=""Pip0A1FailureNotification"" root_reference=""Pip0A1FailureNotification"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
      <b:references>
        <b:reference targetNamespace=""http://www.w3.org/XML/1998/namespace"" />
      </b:references>
      <b:imports>
        <b:namespace prefix=""ns1"" uri=""http://schemas.microsoft.com/biztalk/btarn/2004/0A1_FailureNotificationPropertySchema"" location=""Microsoft.Solutions.BTARN.Schemas.RNPIPs._0A1_V1_FailureNotificationPropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""CommunicationsNumber"" type=""xs:string"" />
  <xs:element name=""FreeFormText"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute ref=""xml:lang"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""thisDocumentGenerationDateTime"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:DateTimeStamp"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""failedInitiatingDocumentDateTime"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:DateTimeStamp"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalSupplyChainCode"" type=""xs:string"" />
  <xs:element name=""ProprietaryDocumentIdentifier"" type=""xs:string"" />
  <xs:element name=""ActionControl"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ActionIdentity"" />
        <xs:element ref=""ns0:messageTrackingID"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalPartnerClassificationCode"" type=""xs:string"" />
  <xs:element name=""GlobalBusinessActionCode"" type=""xs:string"" />
  <xs:element name=""ContactInformation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:contactName"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:facsimileNumber"" />
        <xs:element ref=""ns0:telephoneNumber"" />
        <xs:element ref=""ns0:EmailAddress"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalBusinessIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:pattern value=""^[0-9]{9}$"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""DateTimeStamp"" type=""xs:string"" />
  <xs:element name=""ActionIdentity"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:GlobalBusinessActionCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:messageStandard"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:standardVersion"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalDocumentFunctionCode"" type=""xs:string"" />
  <xs:element name=""BusinessDescription"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:GlobalBusinessIdentifier"" />
        <xs:element ref=""ns0:GlobalSupplyChainCode"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalPartnerRoleClassificationCode"" type=""xs:string"" />
  <xs:element name=""reason"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Pip0A1FailureNotification"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns1:NoFPIPCode"" xpath=""/*[local-name()='Pip0A1FailureNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='ProcessIdentity' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='GlobalProcessIndicatorCode' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']"" />
          <b:property name=""ns1:NoFPIPInstanceID"" xpath=""/*[local-name()='Pip0A1FailureNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='ProcessIdentity' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='InstanceIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']"" />
          <b:property name=""ns1:NoFPIPVersion"" xpath=""/*[local-name()='Pip0A1FailureNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='ProcessIdentity' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='VersionIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']"" />
          <b:property name=""ns1:NoFSourcePartnerID"" xpath=""/*[local-name()='Pip0A1FailureNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='fromRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']"" />
          <b:property name=""ns1:NoFDestinationPartnerID"" xpath=""/*[local-name()='Pip0A1FailureNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='toRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Pip0A1FailureNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='fromRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Pip0A1FailureNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='toRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ActionControl"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:failedInitiatingDocumentDateTime"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:failedInitiatingDocumentIdentifier"" />
        <xs:element ref=""ns0:fromRole"" />
        <xs:element ref=""ns0:GlobalDocumentFunctionCode"" />
        <xs:element ref=""ns0:ProcessIdentity"" />
        <xs:element ref=""ns0:reason"" />
        <xs:element ref=""ns0:thisDocumentGenerationDateTime"" />
        <xs:element ref=""ns0:thisDocumentIdentifier"" />
        <xs:element ref=""ns0:toRole"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""messageTrackingID"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:InstanceIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PartnerDescription"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:BusinessDescription"" />
        <xs:element ref=""ns0:GlobalPartnerClassificationCode"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalProcessIndicatorCode"" type=""xs:string"" />
  <xs:element name=""standardVersion"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:VersionIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PartnerRoleDescription"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:ContactInformation"" />
        <xs:element ref=""ns0:GlobalPartnerRoleClassificationCode"" />
        <xs:element ref=""ns0:PartnerDescription"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""telephoneNumber"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:CommunicationsNumber"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""messageStandard"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""failedInitiatingDocumentIdentifier"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProprietaryDocumentIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""fromRole"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:PartnerRoleDescription"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""thisDocumentIdentifier"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProprietaryDocumentIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""EmailAddress"" type=""xs:string"" />
  <xs:element name=""facsimileNumber"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:CommunicationsNumber"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""contactName"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""InstanceIdentifier"" type=""xs:string"" />
  <xs:element name=""ProcessIdentity"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:GlobalProcessIndicatorCode"" />
        <xs:element ref=""ns0:InstanceIdentifier"" />
        <xs:element ref=""ns0:VersionIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""toRole"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:PartnerRoleDescription"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""VersionIdentifier"" type=""xs:string"" />
</xs:schema>";
        
        public _0A1_MS_V02_00_FailureNotification() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Pip0A1FailureNotification";
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
