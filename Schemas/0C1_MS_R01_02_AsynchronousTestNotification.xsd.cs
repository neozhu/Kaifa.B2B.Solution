namespace Microsoft.Solutions.BTARN.Schemas.RNPIPs {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd",@"Pip0C1AsynchronousTestNotification")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "fromRole.PartnerRoleDescription.PartnerDescription.BusinessDescription.GlobalBusinessIdentifier", XPath = @"/*[local-name()='Pip0C1AsynchronousTestNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']/*[local-name()='fromRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "toRole.PartnerRoleDescription.PartnerDescription.BusinessDescription.GlobalBusinessIdentifier", XPath = @"/*[local-name()='Pip0C1AsynchronousTestNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']/*[local-name()='toRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Pip0C1AsynchronousTestNotification"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Microsoft.Solutions.BTARN.Schemas.RNPIPs.xml", typeof(Microsoft.Solutions.BTARN.Schemas.RNPIPs.xml))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes", typeof(Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes))]
    public sealed class _0C1_MS_R01_02_AsynchronousTestNotification : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns0=""http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:btarn=""http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Microsoft.Solutions.BTARN.Schemas.RNPIPs.xml"" namespace=""http://www.w3.org/XML/1998/namespace"" />
  <xs:import schemaLocation=""Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" namespace=""http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" />
  <xs:annotation>
    <xs:appinfo>
      <schemaInfo displayroot_reference=""Pip0C1AsynchronousTestNotification"" root_reference=""Pip0C1AsynchronousTestNotification"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" document_type=""PIP0C1"" schema_name=""Asynchronous Notification"" version=""R01.02"" />
      <b:references>
        <b:reference targetNamespace=""http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" />
        <b:reference targetNamespace=""http://www.w3.org/XML/1998/namespace"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""FreeFormText"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute ref=""xml:lang"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AsynchronousTest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:Attachment"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""toRole"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""PartnerRoleDescription"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:ContactInformation"" />
              <xs:element name=""GlobalPartnerRoleClassificationCode"">
                <xs:simpleType>
                  <xs:restriction xmlns:q1=""http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" base=""q1:globalpartnerroleclassificationcodeType"">
                    <xs:enumeration value=""Responder"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element ref=""ns0:PartnerDescription"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalDocumentFunctionCode"">
    <xs:simpleType>
      <xs:restriction xmlns:q2=""http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" base=""q2:globaldocumentfunctioncodeType"">
        <xs:enumeration value=""Request"" />
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""thisDocumentIdentifier"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" ref=""ns0:ProprietaryDocumentIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Attachment"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:description"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalAttachmentDescriptionCode"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" ref=""ns0:GlobalMimeTypeQualifierCode"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" ref=""ns0:UniversalResourceIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""BusinessDescription"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:GlobalBusinessIdentifier"" />
        <xs:element ref=""ns0:GlobalSupplyChainCode"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""thisDocumentGenerationDateTime"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" ref=""ns0:DateTimeStamp"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Pip0C1AsynchronousTestNotification"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Pip0C1AsynchronousTestNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']/*[local-name()='fromRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Pip0C1AsynchronousTestNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']/*[local-name()='toRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/0C1_MS_R01_02_AsynchronousTestNotification.dtd']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:AsynchronousTest"" />
        <xs:element ref=""ns0:fromRole"" />
        <xs:element ref=""ns0:GlobalDocumentFunctionCode"" />
        <xs:element ref=""ns0:thisDocumentGenerationDateTime"" />
        <xs:element ref=""ns0:thisDocumentIdentifier"" />
        <xs:element ref=""ns0:toRole"" />
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
  <xs:element name=""GlobalPartnerRoleClassificationCode"">
    <xs:simpleType>
      <xs:restriction xmlns:q3=""http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" base=""q3:globalpartnerroleclassificationcodeType"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Initiator"" />
        <xs:enumeration value=""Responder"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""facsimileNumber"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:CommunicationsNumber"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ContactInformation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" ref=""ns0:contactName"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" ref=""ns0:EmailAddress"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:facsimileNumber"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" ref=""ns0:telephoneNumber"" />
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
  <xs:element name=""contactName"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalPartnerClassificationCode"">
    <xs:simpleType>
      <xs:restriction xmlns:q4=""http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" base=""q4:globalpartnerclassificationcodeType"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""GlobalMimeTypeQualifierCode"">
    <xs:simpleType>
      <xs:restriction xmlns:q5=""http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" base=""q5:globalmimetypequalifierCodeType"" />
    </xs:simpleType>
  </xs:element>
  <xs:element name=""GlobalAttachmentDescriptionCode"">
    <xs:simpleType>
      <xs:restriction xmlns:q6=""http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" base=""q6:globalattachmentdescriptioncodeType"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""description"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
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
  <xs:element name=""UniversalResourceIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""CommunicationsNumber"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:maxLength value=""30"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""GlobalSupplyChainCode"">
    <xs:simpleType>
      <xs:restriction xmlns:q7=""http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" base=""q7:globalsupplychaincodeType"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""DateTimeStamp"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""13"" />
        <xs:maxLength value=""20"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""EmailAddress"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""ProprietaryDocumentIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""fromRole"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""PartnerRoleDescription"">
          <xs:complexType>
            <xs:sequence>
              <xs:element ref=""ns0:ContactInformation"" />
              <xs:element name=""GlobalPartnerRoleClassificationCode"">
                <xs:simpleType>
                  <xs:restriction xmlns:q8=""http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" base=""q8:globalpartnerroleclassificationcodeType"">
                    <xs:enumeration value=""Initiator"" />
                    <xs:minLength value=""1"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element ref=""ns0:PartnerDescription"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public _0C1_MS_R01_02_AsynchronousTestNotification() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Pip0C1AsynchronousTestNotification";
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
