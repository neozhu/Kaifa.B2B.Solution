namespace Microsoft.Solutions.BTARN.Schemas.RNPIPs {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd",@"Pip2A12ProductMasterNotification")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "fromRole.PartnerRoleDescription.PartnerDescription.BusinessDescription.GlobalBusinessIdentifier", XPath = @"/*[local-name()='Pip2A12ProductMasterNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']/*[local-name()='fromRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "toRole.PartnerRoleDescription.PartnerDescription.BusinessDescription.GlobalBusinessIdentifier", XPath = @"/*[local-name()='Pip2A12ProductMasterNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']/*[local-name()='toRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Pip2A12ProductMasterNotification"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Microsoft.Solutions.BTARN.Schemas.RNPIPs.xml", typeof(Microsoft.Solutions.BTARN.Schemas.RNPIPs.xml))]
    public sealed class _2A12_MS_V01_03_ProductMasterNotification : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns0=""http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Microsoft.Solutions.BTARN.Schemas.RNPIPs.xml"" namespace=""http://www.w3.org/XML/1998/namespace"" />
  <xs:annotation>
    <xs:appinfo>
      <schemaInfo displayroot_reference=""Pip2A12ProductMasterNotification"" root_reference=""Pip2A12ProductMasterNotification"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
      <b:references>
        <b:reference targetNamespace=""http://www.w3.org/XML/1998/namespace"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""DateTimeStamp"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""13"" />
        <xs:maxLength value=""20"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""ProductAttributeInformation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:GlobalAssemblyLevelCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalProductClassificationCode"" />
        <xs:element ref=""ns0:ProductIdentificationInformation"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:ProprietaryCommodityIdentifier"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:TextualDescription"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element default=""00000000000000"" name=""GlobalProductIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:integer"">
        <xs:minInclusive value=""00000000000000"" />
        <xs:maxInclusive value=""10000000000000"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""BusinessDescription"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalBusinessIdentifier"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""GlobalSupplyChainCode"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:minLength value=""1"" />
              <xs:enumeration value=""Electronic Components"" />
              <xs:enumeration value=""Information Technology"" />
              <xs:enumeration value=""Semiconductor Manufacturing"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:businessName"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:PartnerBusinessIdentification"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalProductClassificationCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""GlobalDocumentFunctionCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Request"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""ProprietaryContactRoleIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""ProductQuantity"">
    <xs:simpleType>
      <xs:restriction base=""xs:decimal"">
        <xs:minInclusive value=""0"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""ProductIdentificationInformation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalProductIdentifier"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:PartnerProductFamilyIdentification"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:PartnerProductIdentification"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ProprietaryIdentifierAuthority"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""ChangeOrderWindow"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:cancelOrderWindow"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:changeOrderWindow"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element default=""0"" name=""CountableAmount"">
    <xs:simpleType>
      <xs:restriction base=""xs:nonNegativeInteger"">
        <xs:minInclusive value=""0"" />
        <xs:maxInclusive value=""100000000000000"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""orderingAvailabilityDate"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:DatePeriod"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""thisDocumentGenerationDateTime"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:DateTimeStamp"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Pip2A12ProductMasterNotification"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Pip2A12ProductMasterNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']/*[local-name()='fromRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Pip2A12ProductMasterNotification' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']/*[local-name()='toRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/2A12_MS_V01_03_ProductMasterNotification.dtd']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:fromRole"" />
        <xs:element ref=""ns0:GlobalDocumentFunctionCode"" />
        <xs:element ref=""ns0:ProductMaster"" />
        <xs:element ref=""ns0:thisDocumentGenerationDateTime"" />
        <xs:element ref=""ns0:thisDocumentIdentifier"" />
        <xs:element ref=""ns0:toRole"" />
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
  <xs:element name=""GlobalAssemblyLevelCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Component"" />
        <xs:enumeration value=""Phantom"" />
        <xs:enumeration value=""Sub Assembly"" />
        <xs:enumeration value=""Top Level Assembly"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""ProductLeadTime"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:GlobalIntervalCode"" />
        <xs:element ref=""ns0:GlobalLeadTimeClassificationCode"" />
        <xs:element ref=""ns0:PeriodNumber"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalSupplyChainCode"" type=""xs:string"" />
  <xs:element name=""endDate"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:DateStamp"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""releasedDate"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:DateStamp"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ProductDistributionInformation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:isAvailableToShip"" />
        <xs:element ref=""ns0:isWaiverRequiredToShip"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:safetyStockQuantity"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:shippingAvailabilityDate"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""isOnAllocation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:AffirmationIndicator"" />
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
  <xs:element name=""detail"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""shippingAvailabilityDate"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:DatePeriod"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PartnerContact"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ContactInformation"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:ProprietaryContactRoleIdentifier"" />
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
  <xs:element name=""OrderQuantity"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:minimumOrderQuantity"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:multipleOrderQuantity"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:sampleOrderQuantity"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PartnerBusinessIdentification"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""ProprietaryBusinessIdentifier"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:minLength value=""1"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element name=""ProprietaryDomainIdentifier"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:minLength value=""1"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:ProprietaryIdentifierAuthority"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""safetyStockQuantity"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProductQuantity"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AffirmationIndicator"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""2"" />
        <xs:maxLength value=""3"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""sampleOrderQuantity"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProductQuantity"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PeriodNumber"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""GlobalABCCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""A"" />
        <xs:enumeration value=""B"" />
        <xs:enumeration value=""C"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""isWaiverRequiredToShip"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:AffirmationIndicator"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ProprietaryCommodityIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""manufactureDate"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:DatePeriod"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""changeOrderWindow"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:TimeDuration"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""orderPolicyDays"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:CountableAmount"" />
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
  <xs:element name=""GlobalPartnerRoleClassificationCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Account Supplier"" />
        <xs:enumeration value=""Account User"" />
        <xs:enumeration value=""Anonymous Buyer"" />
        <xs:enumeration value=""Appointment Provider"" />
        <xs:enumeration value=""Authorized Service Provider"" />
        <xs:enumeration value=""Authorizer"" />
        <xs:enumeration value=""Buyer"" />
        <xs:enumeration value=""Catalog Distributor"" />
        <xs:enumeration value=""Catalog Producer"" />
        <xs:enumeration value=""Change Requester"" />
        <xs:enumeration value=""Change Review Forum"" />
        <xs:enumeration value=""Claim Requester"" />
        <xs:enumeration value=""Consignee"" />
        <xs:enumeration value=""Credit Provider"" />
        <xs:enumeration value=""Credit Reference Requester"" />
        <xs:enumeration value=""Customer"" />
        <xs:enumeration value=""Customer Manager"" />
        <xs:enumeration value=""Decision Stakeholder"" />
        <xs:enumeration value=""Delivery Appointment Provider"" />
        <xs:enumeration value=""Delivery Appointment Requester"" />
        <xs:enumeration value=""Demand Creator"" />
        <xs:enumeration value=""Failure Report Administrator"" />
        <xs:enumeration value=""Financing Processor"" />
        <xs:enumeration value=""Forecast Owner"" />
        <xs:enumeration value=""Forecast Recipient"" />
        <xs:enumeration value=""Forecast Reply Recipient"" />
        <xs:enumeration value=""Implementation Plan Creator"" />
        <xs:enumeration value=""Integrator"" />
        <xs:enumeration value=""In-transit Information User"" />
        <xs:enumeration value=""Inventory Information Provider"" />
        <xs:enumeration value=""Inventory Information User"" />
        <xs:enumeration value=""Invoice Provider"" />
        <xs:enumeration value=""Invoice Receiver"" />
        <xs:enumeration value=""Invoice Reject Provider"" />
        <xs:enumeration value=""Invoice Reject Receiver"" />
        <xs:enumeration value=""Marketing Activity Information User"" />
        <xs:enumeration value=""Marketing Activity Initiator"" />
        <xs:enumeration value=""Payee"" />
        <xs:enumeration value=""Payer"" />
        <xs:enumeration value=""PIP Failure Notifier"" />
        <xs:enumeration value=""Product Distributor"" />
        <xs:enumeration value=""Product Information Distributor"" />
        <xs:enumeration value=""Product Information Subscriber"" />
        <xs:enumeration value=""Product Information User"" />
        <xs:enumeration value=""Product Provider"" />
        <xs:enumeration value=""Product Supplier"" />
        <xs:enumeration value=""Qualification Owner"" />
        <xs:enumeration value=""Quality Data Provider"" />
        <xs:enumeration value=""Quality Data User"" />
        <xs:enumeration value=""Receiver"" />
        <xs:enumeration value=""Return Provider"" />
        <xs:enumeration value=""Return Receiver"" />
        <xs:enumeration value=""Return Requester"" />
        <xs:enumeration value=""Sales Facilitator"" />
        <xs:enumeration value=""Sales Lead Originator"" />
        <xs:enumeration value=""Sales Lead Processor"" />
        <xs:enumeration value=""Sales Marketing Claim Processor"" />
        <xs:enumeration value=""Sales Marketing Claimant"" />
        <xs:enumeration value=""Sales Marketing Program Reimbursement Recipient"" />
        <xs:enumeration value=""Sales Marketing Program Reimburser"" />
        <xs:enumeration value=""Seller"" />
        <xs:enumeration value=""Service Provider"" />
        <xs:enumeration value=""Shipment Information User"" />
        <xs:enumeration value=""Shipment Requester"" />
        <xs:enumeration value=""ShipmentController"" />
        <xs:enumeration value=""Shipper"" />
        <xs:enumeration value=""Solution Provider"" />
        <xs:enumeration value=""Solution Requester"" />
        <xs:enumeration value=""Specification Provider"" />
        <xs:enumeration value=""Specification User"" />
        <xs:enumeration value=""Stakeholder"" />
        <xs:enumeration value=""Status Requester"" />
        <xs:enumeration value=""Status Responder"" />
        <xs:enumeration value=""Supplier"" />
        <xs:enumeration value=""Tender Information User"" />
        <xs:enumeration value=""Transport Service Provider"" />
        <xs:enumeration value=""Warranty Provider"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""GlobalProductProcurementTypeCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Allocation"" />
        <xs:enumeration value=""Bulk"" />
        <xs:enumeration value=""JIT"" />
        <xs:enumeration value=""NCNR"" />
        <xs:enumeration value=""Not Applicable"" />
        <xs:enumeration value=""Sub Contract"" />
        <xs:enumeration value=""Supply Split"" />
        <xs:enumeration value=""VMI"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""businessName"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""FreeFormText"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute ref=""xml:lang"" />
        </xs:extension>
      </xs:simpleContent>
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
  <xs:element name=""summary"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""isAvailableToShip"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:AffirmationIndicator"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""cancelOrderWindow"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:TimeDuration"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DateStamp"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""9"" />
        <xs:maxLength value=""9"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""internalBusinessEntity"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:PartnerDescription"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TextualDescription"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:detail"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:primary"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:summary"" />
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
  <xs:element name=""isAvailableToOrder"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:AffirmationIndicator"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""scrapPercent"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:PercentAmount"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""minimumOrderQuantity"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProductQuantity"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalProductUnitOfMeasureCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:enumeration value=""10 Kilogram Drum"" />
        <xs:enumeration value=""10,000 Gallon Tankcar"" />
        <xs:enumeration value=""100 Board Feet"" />
        <xs:enumeration value=""100 Pound Drum"" />
        <xs:enumeration value=""1000-pack"" />
        <xs:enumeration value=""100-Pack"" />
        <xs:enumeration value=""10-pack"" />
        <xs:enumeration value=""115 Kilogram Drum"" />
        <xs:enumeration value=""15 Kilogram Drum"" />
        <xs:enumeration value=""20 Foot Container"" />
        <xs:enumeration value=""20,000 Gallon Tankcar"" />
        <xs:enumeration value=""20-Pack"" />
        <xs:enumeration value=""25 Kilogram Bulk Bag"" />
        <xs:enumeration value=""300 Kilogram Bulk Bag"" />
        <xs:enumeration value=""40 Foot Container"" />
        <xs:enumeration value=""50 Pound Bag"" />
        <xs:enumeration value=""500 Kilogram Bulk Bag"" />
        <xs:enumeration value=""50-pack"" />
        <xs:enumeration value=""55 Gallon Drum"" />
        <xs:enumeration value=""Acre"" />
        <xs:enumeration value=""Actual Pounds"" />
        <xs:enumeration value=""Aluminum Pounds Only"" />
        <xs:enumeration value=""Ampere"" />
        <xs:enumeration value=""Bag"" />
        <xs:enumeration value=""Bale"" />
        <xs:enumeration value=""Ball"" />
        <xs:enumeration value=""Band"" />
        <xs:enumeration value=""Bar"" />
        <xs:enumeration value=""Barrel"" />
        <xs:enumeration value=""Barrel, Imperial"" />
        <xs:enumeration value=""Barrels Per Day"" />
        <xs:enumeration value=""Barrels Per Minute"" />
        <xs:enumeration value=""Base Box"" />
        <xs:enumeration value=""Base Weight"" />
        <xs:enumeration value=""Basket"" />
        <xs:enumeration value=""Batch"" />
        <xs:enumeration value=""Batt"" />
        <xs:enumeration value=""Batting Pound"" />
        <xs:enumeration value=""Beam"" />
        <xs:enumeration value=""Becquerel/kilogram"" />
        <xs:enumeration value=""Belt"" />
        <xs:enumeration value=""Billet"" />
        <xs:enumeration value=""Bin"" />
        <xs:enumeration value=""Block"" />
        <xs:enumeration value=""Board"" />
        <xs:enumeration value=""Board Feet"" />
        <xs:enumeration value=""Bolt"" />
        <xs:enumeration value=""Bottle"" />
        <xs:enumeration value=""Box"" />
        <xs:enumeration value=""British Thermal Unit (BTU)"" />
        <xs:enumeration value=""British Thermal Units (BTUs) Per Cubic Foot"" />
        <xs:enumeration value=""British Thermal Units (BTUs) Per Pound"" />
        <xs:enumeration value=""Bucket"" />
        <xs:enumeration value=""Bulk"" />
        <xs:enumeration value=""Bulk Car Load"" />
        <xs:enumeration value=""Bulk Pack"" />
        <xs:enumeration value=""Bundle"" />
        <xs:enumeration value=""Bunks"" />
        <xs:enumeration value=""Bushel"" />
        <xs:enumeration value=""Bushel, Dry Imperial"" />
        <xs:enumeration value=""Calorie"" />
        <xs:enumeration value=""Can"" />
        <xs:enumeration value=""Candela"" />
        <xs:enumeration value=""Canister"" />
        <xs:enumeration value=""Car"" />
        <xs:enumeration value=""Carat"" />
        <xs:enumeration value=""Carboy"" />
        <xs:enumeration value=""Card"" />
        <xs:enumeration value=""Carload"" />
        <xs:enumeration value=""Carton"" />
        <xs:enumeration value=""Cartridge"" />
        <xs:enumeration value=""Case"" />
        <xs:enumeration value=""Cask"" />
        <xs:enumeration value=""Cassette"" />
        <xs:enumeration value=""Catchweight"" />
        <xs:enumeration value=""Cell"" />
        <xs:enumeration value=""Centiliter"" />
        <xs:enumeration value=""Centimeter"" />
        <xs:enumeration value=""Centipoise (CPS)"" />
        <xs:enumeration value=""Chains (Land Survey)"" />
        <xs:enumeration value=""Chest"" />
        <xs:enumeration value=""Coil"" />
        <xs:enumeration value=""Coil Group"" />
        <xs:enumeration value=""Composite Product Pounds (Total Weight)"" />
        <xs:enumeration value=""Cone"" />
        <xs:enumeration value=""Connector"" />
        <xs:enumeration value=""Container"" />
        <xs:enumeration value=""Cover"" />
        <xs:enumeration value=""Crate"" />
        <xs:enumeration value=""Cubic centimeter"" />
        <xs:enumeration value=""Cubic centimeter/second"" />
        <xs:enumeration value=""Cubic Foot"" />
        <xs:enumeration value=""Cubic inch"" />
        <xs:enumeration value=""Cubic yard"" />
        <xs:enumeration value=""Cubicmeter"" />
        <xs:enumeration value=""Cup"" />
        <xs:enumeration value=""Cycles"" />
        <xs:enumeration value=""Cylinder"" />
        <xs:enumeration value=""Day"" />
        <xs:enumeration value=""Deal"" />
        <xs:enumeration value=""Decimeter"" />
        <xs:enumeration value=""Degree Celsius"" />
        <xs:enumeration value=""Degree Fahrenheit"" />
        <xs:enumeration value=""Dep. Factor"" />
        <xs:enumeration value=""Die"" />
        <xs:enumeration value=""Disk (Disc)"" />
        <xs:enumeration value=""Dispenser"" />
        <xs:enumeration value=""Display"" />
        <xs:enumeration value=""Dozen"" />
        <xs:enumeration value=""Dram"" />
        <xs:enumeration value=""Drum"" />
        <xs:enumeration value=""Dry Pounds"" />
        <xs:enumeration value=""Each"" />
        <xs:enumeration value=""Electrical Capacitance"" />
        <xs:enumeration value=""Fluid Ounce"" />
        <xs:enumeration value=""Fluid Ounce (Imperial)"" />
        <xs:enumeration value=""Fluid Ounce US"" />
        <xs:enumeration value=""Foot"" />
        <xs:enumeration value=""Fuel Usage (Gallons)"" />
        <xs:enumeration value=""Gage Systems"" />
        <xs:enumeration value=""Gallon"" />
        <xs:enumeration value=""Gigajoules"" />
        <xs:enumeration value=""Gill (Imperial)"" />
        <xs:enumeration value=""Grain"" />
        <xs:enumeration value=""Gram"" />
        <xs:enumeration value=""Gram/Cubic Centimeter"" />
        <xs:enumeration value=""Gram/square meter"" />
        <xs:enumeration value=""Grams Per 100 Centimeters"" />
        <xs:enumeration value=""Grams Per 100 Grams"" />
        <xs:enumeration value=""Grams Per Cubic Centimeter"" />
        <xs:enumeration value=""Grams Per Kilogram"" />
        <xs:enumeration value=""Grams Per Liter"" />
        <xs:enumeration value=""Grams Per Milliliter"" />
        <xs:enumeration value=""Grams Per Square Centimeter"" />
        <xs:enumeration value=""Grams Per Square Meter"" />
        <xs:enumeration value=""Great Gross (Dozen Gross)"" />
        <xs:enumeration value=""Gross"" />
        <xs:enumeration value=""Gross Barrels"" />
        <xs:enumeration value=""Gross Gallons"" />
        <xs:enumeration value=""Gross Kilogram"" />
        <xs:enumeration value=""Gross Ton"" />
        <xs:enumeration value=""Gross Yard"" />
        <xs:enumeration value=""Group"" />
        <xs:enumeration value=""Half Gallon"" />
        <xs:enumeration value=""Half Hour"" />
        <xs:enumeration value=""Half Liter"" />
        <xs:enumeration value=""Hank"" />
        <xs:enumeration value=""Heat lots"" />
        <xs:enumeration value=""Hectare"" />
        <xs:enumeration value=""Hectoliter"" />
        <xs:enumeration value=""Hectopascal"" />
        <xs:enumeration value=""Hertz"" />
        <xs:enumeration value=""Hour"" />
        <xs:enumeration value=""Hours"" />
        <xs:enumeration value=""Hundred Boxes"" />
        <xs:enumeration value=""Hundred Count"" />
        <xs:enumeration value=""Hundred Sheets"" />
        <xs:enumeration value=""Hundredth of a Carat"" />
        <xs:enumeration value=""Imperial Gallons"" />
        <xs:enumeration value=""Inch"" />
        <xs:enumeration value=""Jar"" />
        <xs:enumeration value=""Joint"" />
        <xs:enumeration value=""Joule"" />
        <xs:enumeration value=""Keg"" />
        <xs:enumeration value=""Kelvin"" />
        <xs:enumeration value=""Kiloampere"" />
        <xs:enumeration value=""Kilobecquerel/Kilogram"" />
        <xs:enumeration value=""Kilogram"" />
        <xs:enumeration value=""Kilogram per cubic meter"" />
        <xs:enumeration value=""Kilogram/Kilogram"" />
        <xs:enumeration value=""Kilogram/square meter"" />
        <xs:enumeration value=""Kilogramm pro Sekunde"" />
        <xs:enumeration value=""Kilohertz"" />
        <xs:enumeration value=""Kilojoule"" />
        <xs:enumeration value=""Kilometer"" />
        <xs:enumeration value=""Kilometer/hour"" />
        <xs:enumeration value=""Kiloohm"" />
        <xs:enumeration value=""Kilovolt"" />
        <xs:enumeration value=""Kilowatt"" />
        <xs:enumeration value=""Kilowatt-hour"" />
        <xs:enumeration value=""Kit"" />
        <xs:enumeration value=""Kubikdezimeter"" />
        <xs:enumeration value=""Kubikmeter pro Sekunde"" />
        <xs:enumeration value=""Lifts"" />
        <xs:enumeration value=""Link"" />
        <xs:enumeration value=""Liquid Pounds"" />
        <xs:enumeration value=""Liter"" />
        <xs:enumeration value=""Load"" />
        <xs:enumeration value=""Lot"" />
        <xs:enumeration value=""Lug"" />
        <xs:enumeration value=""Mat"" />
        <xs:enumeration value=""Megagram"" />
        <xs:enumeration value=""Megagrams Per Hour"" />
        <xs:enumeration value=""Megahertz"" />
        <xs:enumeration value=""Megapascal"" />
        <xs:enumeration value=""Megawatt"" />
        <xs:enumeration value=""Meter"" />
        <xs:enumeration value=""Meter pro Quadratsekunde"" />
        <xs:enumeration value=""Meters per second"" />
        <xs:enumeration value=""Micrograms Per Cubic Meter"" />
        <xs:enumeration value=""Micrometer"" />
        <xs:enumeration value=""Microsecond"" />
        <xs:enumeration value=""Mikrogram/cubic meter"" />
        <xs:enumeration value=""Mile"" />
        <xs:enumeration value=""Milliampere"" />
        <xs:enumeration value=""Millibar"" />
        <xs:enumeration value=""Milligram/cubic meter"" />
        <xs:enumeration value=""Milligram/kilogram"" />
        <xs:enumeration value=""Milligram/Liter"" />
        <xs:enumeration value=""Milligrams Per Cubic Meter"" />
        <xs:enumeration value=""Milligrams Per Square Meter"" />
        <xs:enumeration value=""Millijoule"" />
        <xs:enumeration value=""Milliliter"" />
        <xs:enumeration value=""Millimeter"" />
        <xs:enumeration value=""Millimeter H20"" />
        <xs:enumeration value=""Millimol"" />
        <xs:enumeration value=""Millimol/kilogram"" />
        <xs:enumeration value=""Million BTU's"" />
        <xs:enumeration value=""Millipascal seconds"" />
        <xs:enumeration value=""Millisecond"" />
        <xs:enumeration value=""Millitesla"" />
        <xs:enumeration value=""Millivolt"" />
        <xs:enumeration value=""Milliwatt"" />
        <xs:enumeration value=""Minute"" />
        <xs:enumeration value=""Miter"" />
        <xs:enumeration value=""Mol"" />
        <xs:enumeration value=""Mol/kilogram"" />
        <xs:enumeration value=""Month"" />
        <xs:enumeration value=""Multichip"" />
        <xs:enumeration value=""Nanometer"" />
        <xs:enumeration value=""Nanosecond"" />
        <xs:enumeration value=""Net Barrels"" />
        <xs:enumeration value=""Net Gallons"" />
        <xs:enumeration value=""Net Imperial Gallons"" />
        <xs:enumeration value=""Net Liters"" />
        <xs:enumeration value=""Newton"" />
        <xs:enumeration value=""Ohm"" />
        <xs:enumeration value=""One"" />
        <xs:enumeration value=""One Thousand Pieces"" />
        <xs:enumeration value=""Ounce"" />
        <xs:enumeration value=""Ounce"" />
        <xs:enumeration value=""Pack (PAK)"" />
        <xs:enumeration value=""Package"" />
        <xs:enumeration value=""Packet"" />
        <xs:enumeration value=""Pad"" />
        <xs:enumeration value=""Pail"" />
        <xs:enumeration value=""Pair"" />
        <xs:enumeration value=""Pallet"" />
        <xs:enumeration value=""Pallet (Lift)"" />
        <xs:enumeration value=""Pallet/Unit Load"" />
        <xs:enumeration value=""Pallete"" />
        <xs:enumeration value=""Panel"" />
        <xs:enumeration value=""Parcel"" />
        <xs:enumeration value=""Parts per billion (US)"" />
        <xs:enumeration value=""Parts per million"" />
        <xs:enumeration value=""Pascal"" />
        <xs:enumeration value=""Pascal second"" />
        <xs:enumeration value=""Pennyweight"" />
        <xs:enumeration value=""Per Hundred Pieces"" />
        <xs:enumeration value=""Percent"" />
        <xs:enumeration value=""Percent Per 1000 Hours"" />
        <xs:enumeration value=""Percent Weight"" />
        <xs:enumeration value=""Percentage"" />
        <xs:enumeration value=""Piece"" />
        <xs:enumeration value=""Pint - US liquid"" />
        <xs:enumeration value=""Pint U.S. Dry"" />
        <xs:enumeration value=""Plate"" />
        <xs:enumeration value=""Pound"" />
        <xs:enumeration value=""Pounds Per 1000 Square Feet"" />
        <xs:enumeration value=""Pounds Per Foot"" />
        <xs:enumeration value=""Pounds Per Gallon"" />
        <xs:enumeration value=""Pounds Per Piece of Product"" />
        <xs:enumeration value=""Pounds Per Pound of Product"" />
        <xs:enumeration value=""Pounds Per Thousand"" />
        <xs:enumeration value=""Quart - US liquid"" />
        <xs:enumeration value=""Rack"" />
        <xs:enumeration value=""Ream of 500 Sheets"" />
        <xs:enumeration value=""Reel"" />
        <xs:enumeration value=""Ring"" />
        <xs:enumeration value=""Rod"" />
        <xs:enumeration value=""Roll"" />
        <xs:enumeration value=""Sack"" />
        <xs:enumeration value=""Second"" />
        <xs:enumeration value=""Set"" />
        <xs:enumeration value=""SET"" />
        <xs:enumeration value=""Sheet"" />
        <xs:enumeration value=""Sheet-Metric measure"" />
        <xs:enumeration value=""Shipment"" />
        <xs:enumeration value=""Shot"" />
        <xs:enumeration value=""Skein"" />
        <xs:enumeration value=""Skid"" />
        <xs:enumeration value=""Sleeve"" />
        <xs:enumeration value=""Slip Sheet"" />
        <xs:enumeration value=""Spool"" />
        <xs:enumeration value=""Square"" />
        <xs:enumeration value=""Square foot"" />
        <xs:enumeration value=""Square inch"" />
        <xs:enumeration value=""Square kilometer"" />
        <xs:enumeration value=""Square meter"" />
        <xs:enumeration value=""Square meter/second"" />
        <xs:enumeration value=""Square mile"" />
        <xs:enumeration value=""Square millimeter"" />
        <xs:enumeration value=""Square Yard"" />
        <xs:enumeration value=""Statute Mile"" />
        <xs:enumeration value=""Stick"" />
        <xs:enumeration value=""Strip"" />
        <xs:enumeration value=""Super Bulk Bag"" />
        <xs:enumeration value=""Tablet"" />
        <xs:enumeration value=""Tank"" />
        <xs:enumeration value=""Tank Truck"" />
        <xs:enumeration value=""Tesla"" />
        <xs:enumeration value=""Thousand"" />
        <xs:enumeration value=""Ton"" />
        <xs:enumeration value=""Tonne"" />
        <xs:enumeration value=""Torr"" />
        <xs:enumeration value=""Tote"" />
        <xs:enumeration value=""Track Foot"" />
        <xs:enumeration value=""Trailer"" />
        <xs:enumeration value=""Train"" />
        <xs:enumeration value=""Tray"" />
        <xs:enumeration value=""Troy"" />
        <xs:enumeration value=""Troy OZ"" />
        <xs:enumeration value=""Truckload"" />
        <xs:enumeration value=""Tube"" />
        <xs:enumeration value=""Unitless Unit of Measure"" />
        <xs:enumeration value=""US gallon"" />
        <xs:enumeration value=""US pound"" />
        <xs:enumeration value=""US ton"" />
        <xs:enumeration value=""Vial"" />
        <xs:enumeration value=""Volt"" />
        <xs:enumeration value=""Wafer"" />
        <xs:enumeration value=""Watt"" />
        <xs:enumeration value=""Week"" />
        <xs:enumeration value=""WF"" />
        <xs:enumeration value=""Wrap"" />
        <xs:enumeration value=""Yard"" />
        <xs:enumeration value=""Year"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""ProprietaryProductIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""PartnerProductIdentification"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:GlobalPartnerClassificationCode"" />
        <xs:element ref=""ns0:ProprietaryProductIdentifier"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:revisionIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PercentAmount"">
    <xs:simpleType>
      <xs:restriction base=""xs:decimal"" />
    </xs:simpleType>
  </xs:element>
  <xs:element name=""facsimileNumber"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""CommunicationsNumber"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""isWaiverRequiredToOrder"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:AffirmationIndicator"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ProprietaryDomainIdentifier"" type=""xs:string"" />
  <xs:element name=""TimeDuration"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:maxLength value=""20"" />
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
  <xs:element name=""ProductLifecycleInformation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:discontinuationDate"" />
        <xs:element ref=""ns0:GlobalProductLifeCycleStatusCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:manufactureDate"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:releasedDate"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalIntervalCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""1st week of the month"" />
        <xs:enumeration value=""2nd week of the month"" />
        <xs:enumeration value=""3rd week of the month"" />
        <xs:enumeration value=""4th week of the month"" />
        <xs:enumeration value=""5 day work week"" />
        <xs:enumeration value=""5th week of the month"" />
        <xs:enumeration value=""Calendar day"" />
        <xs:enumeration value=""Calendar week"" />
        <xs:enumeration value=""Day"" />
        <xs:enumeration value=""Four month period"" />
        <xs:enumeration value=""Friday"" />
        <xs:enumeration value=""Half month"" />
        <xs:enumeration value=""Half week"" />
        <xs:enumeration value=""Half year"" />
        <xs:enumeration value=""Hour"" />
        <xs:enumeration value=""Indefinite"" />
        <xs:enumeration value=""Minute"" />
        <xs:enumeration value=""Monday"" />
        <xs:enumeration value=""Monday through Friday"" />
        <xs:enumeration value=""Monday through Saturday"" />
        <xs:enumeration value=""Monday through Sunday"" />
        <xs:enumeration value=""Month"" />
        <xs:enumeration value=""Quarter"" />
        <xs:enumeration value=""Saturday"" />
        <xs:enumeration value=""Sunday"" />
        <xs:enumeration value=""Ten days period"" />
        <xs:enumeration value=""Thursday"" />
        <xs:enumeration value=""Tuesday"" />
        <xs:enumeration value=""Two month period"" />
        <xs:enumeration value=""Two week period"" />
        <xs:enumeration value=""Wednesday"" />
        <xs:enumeration value=""Week"" />
        <xs:enumeration value=""Work day"" />
        <xs:enumeration value=""Working days"" />
        <xs:enumeration value=""Year"" />
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
  <xs:element name=""PartnerProductFamilyIdentification"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:GlobalPartnerClassificationCode"" />
        <xs:element ref=""ns0:ProprietaryProductIdentifier"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:revisionIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ProprietaryDocumentIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""telephoneNumber"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""CommunicationsNumber"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ProductMaster"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:internalBusinessEntity"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""ns0:ProductMasterLineItem"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ProductProcurementInformation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:ChangeOrderWindow"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalABCCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:GlobalProductProcurementTypeCode"" />
        <xs:element ref=""ns0:isAvailableToOrder"" />
        <xs:element ref=""ns0:isOnAllocation"" />
        <xs:element ref=""ns0:isWaiverRequiredToOrder"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:orderingAvailabilityDate"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:orderPolicyDays"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:OrderQuantity"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:ProductLeadTime"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:scrapPercent"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""discontinuationDate"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:DateStamp"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DatePeriod"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:beginDate"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:endDate"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""primary"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""multipleOrderQuantity"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProductQuantity"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ProprietaryBusinessIdentifier"" type=""xs:string"" />
  <xs:element name=""ContactInformation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:contactName"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""EmailAddress"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:minLength value=""1"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:facsimileNumber"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:telephoneNumber"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""beginDate"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:DateStamp"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ProductMasterLineItem"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""GlobalProductUnitOfMeasureCode"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:minLength value=""1"" />
              <xs:enumeration value=""10 Kilogram Drum"" />
              <xs:enumeration value=""10,000 Gallon Tankcar"" />
              <xs:enumeration value=""100 Board Feet"" />
              <xs:enumeration value=""100 Pound Drum"" />
              <xs:enumeration value=""1000-pack"" />
              <xs:enumeration value=""100-Pack"" />
              <xs:enumeration value=""10-pack"" />
              <xs:enumeration value=""115 Kilogram Drum"" />
              <xs:enumeration value=""15 Kilogram Drum"" />
              <xs:enumeration value=""20 Foot Container"" />
              <xs:enumeration value=""20,000 Gallon Tankcar"" />
              <xs:enumeration value=""20-Pack"" />
              <xs:enumeration value=""25 Kilogram Bulk Bag"" />
              <xs:enumeration value=""300 Kilogram Bulk Bag"" />
              <xs:enumeration value=""40 Foot Container"" />
              <xs:enumeration value=""50 Pound Bag"" />
              <xs:enumeration value=""500 Kilogram Bulk Bag"" />
              <xs:enumeration value=""50-pack"" />
              <xs:enumeration value=""55 Gallon Drum"" />
              <xs:enumeration value=""Acre"" />
              <xs:enumeration value=""Actual Pounds"" />
              <xs:enumeration value=""Aluminum Pounds Only"" />
              <xs:enumeration value=""Ampere"" />
              <xs:enumeration value=""Bag"" />
              <xs:enumeration value=""Bale"" />
              <xs:enumeration value=""Ball"" />
              <xs:enumeration value=""Band"" />
              <xs:enumeration value=""Bar"" />
              <xs:enumeration value=""Barrel"" />
              <xs:enumeration value=""Barrel, Imperial"" />
              <xs:enumeration value=""Barrels Per Day"" />
              <xs:enumeration value=""Barrels Per Minute"" />
              <xs:enumeration value=""Base Box"" />
              <xs:enumeration value=""Base Weight"" />
              <xs:enumeration value=""Basket"" />
              <xs:enumeration value=""Batch"" />
              <xs:enumeration value=""Batt"" />
              <xs:enumeration value=""Batting Pound"" />
              <xs:enumeration value=""Beam"" />
              <xs:enumeration value=""Becquerel/kilogram"" />
              <xs:enumeration value=""Belt"" />
              <xs:enumeration value=""Billet"" />
              <xs:enumeration value=""Bin"" />
              <xs:enumeration value=""Block"" />
              <xs:enumeration value=""Board"" />
              <xs:enumeration value=""Board Feet"" />
              <xs:enumeration value=""Bolt"" />
              <xs:enumeration value=""Bottle"" />
              <xs:enumeration value=""Box"" />
              <xs:enumeration value=""British Thermal Unit (BTU)"" />
              <xs:enumeration value=""British Thermal Units (BTUs) Per Cubic Foot"" />
              <xs:enumeration value=""British Thermal Units (BTUs) Per Pound"" />
              <xs:enumeration value=""Bucket"" />
              <xs:enumeration value=""Bulk"" />
              <xs:enumeration value=""Bulk Car Load"" />
              <xs:enumeration value=""Bulk Pack"" />
              <xs:enumeration value=""Bundle"" />
              <xs:enumeration value=""Bunks"" />
              <xs:enumeration value=""Bushel"" />
              <xs:enumeration value=""Bushel, Dry Imperial"" />
              <xs:enumeration value=""Calorie"" />
              <xs:enumeration value=""Can"" />
              <xs:enumeration value=""Candela"" />
              <xs:enumeration value=""Canister"" />
              <xs:enumeration value=""Car"" />
              <xs:enumeration value=""Carat"" />
              <xs:enumeration value=""Carboy"" />
              <xs:enumeration value=""Card"" />
              <xs:enumeration value=""Carload"" />
              <xs:enumeration value=""Carton"" />
              <xs:enumeration value=""Cartridge"" />
              <xs:enumeration value=""Case"" />
              <xs:enumeration value=""Cask"" />
              <xs:enumeration value=""Cassette"" />
              <xs:enumeration value=""Catchweight"" />
              <xs:enumeration value=""Cell"" />
              <xs:enumeration value=""Centiliter"" />
              <xs:enumeration value=""Centimeter"" />
              <xs:enumeration value=""Centipoise (CPS)"" />
              <xs:enumeration value=""Chains (Land Survey)"" />
              <xs:enumeration value=""Chest"" />
              <xs:enumeration value=""Coil"" />
              <xs:enumeration value=""Coil Group"" />
              <xs:enumeration value=""Composite Product Pounds (Total Weight)"" />
              <xs:enumeration value=""Cone"" />
              <xs:enumeration value=""Connector"" />
              <xs:enumeration value=""Container"" />
              <xs:enumeration value=""Cover"" />
              <xs:enumeration value=""Crate"" />
              <xs:enumeration value=""Cubic centimeter"" />
              <xs:enumeration value=""Cubic centimeter/second"" />
              <xs:enumeration value=""Cubic Foot"" />
              <xs:enumeration value=""Cubic inch"" />
              <xs:enumeration value=""Cubic yard"" />
              <xs:enumeration value=""Cubicmeter"" />
              <xs:enumeration value=""Cup"" />
              <xs:enumeration value=""Cycles"" />
              <xs:enumeration value=""Cylinder"" />
              <xs:enumeration value=""Day"" />
              <xs:enumeration value=""Deal"" />
              <xs:enumeration value=""Decimeter"" />
              <xs:enumeration value=""Degree Celsius"" />
              <xs:enumeration value=""Degree Fahrenheit"" />
              <xs:enumeration value=""Dep. Factor"" />
              <xs:enumeration value=""Die"" />
              <xs:enumeration value=""Disk (Disc)"" />
              <xs:enumeration value=""Dispenser"" />
              <xs:enumeration value=""Display"" />
              <xs:enumeration value=""Dozen"" />
              <xs:enumeration value=""Dram"" />
              <xs:enumeration value=""Drum"" />
              <xs:enumeration value=""Dry Pounds"" />
              <xs:enumeration value=""Each"" />
              <xs:enumeration value=""Electrical Capacitance"" />
              <xs:enumeration value=""Fluid Ounce"" />
              <xs:enumeration value=""Fluid Ounce (Imperial)"" />
              <xs:enumeration value=""Fluid Ounce US"" />
              <xs:enumeration value=""Foot"" />
              <xs:enumeration value=""Fuel Usage (Gallons)"" />
              <xs:enumeration value=""Gage Systems"" />
              <xs:enumeration value=""Gallon"" />
              <xs:enumeration value=""Gigajoules"" />
              <xs:enumeration value=""Gill (Imperial)"" />
              <xs:enumeration value=""Grain"" />
              <xs:enumeration value=""Gram"" />
              <xs:enumeration value=""Gram/Cubic Centimeter"" />
              <xs:enumeration value=""Gram/square meter"" />
              <xs:enumeration value=""Grams Per 100 Centimeters"" />
              <xs:enumeration value=""Grams Per 100 Grams"" />
              <xs:enumeration value=""Grams Per Cubic Centimeter"" />
              <xs:enumeration value=""Grams Per Kilogram"" />
              <xs:enumeration value=""Grams Per Liter"" />
              <xs:enumeration value=""Grams Per Milliliter"" />
              <xs:enumeration value=""Grams Per Square Centimeter"" />
              <xs:enumeration value=""Grams Per Square Meter"" />
              <xs:enumeration value=""Great Gross (Dozen Gross)"" />
              <xs:enumeration value=""Gross"" />
              <xs:enumeration value=""Gross Barrels"" />
              <xs:enumeration value=""Gross Gallons"" />
              <xs:enumeration value=""Gross Kilogram"" />
              <xs:enumeration value=""Gross Ton"" />
              <xs:enumeration value=""Gross Yard"" />
              <xs:enumeration value=""Group"" />
              <xs:enumeration value=""Half Gallon"" />
              <xs:enumeration value=""Half Hour"" />
              <xs:enumeration value=""Half Liter"" />
              <xs:enumeration value=""Hank"" />
              <xs:enumeration value=""Heat lots"" />
              <xs:enumeration value=""Hectare"" />
              <xs:enumeration value=""Hectoliter"" />
              <xs:enumeration value=""Hectopascal"" />
              <xs:enumeration value=""Hertz"" />
              <xs:enumeration value=""Hour"" />
              <xs:enumeration value=""Hours"" />
              <xs:enumeration value=""Hundred Boxes"" />
              <xs:enumeration value=""Hundred Count"" />
              <xs:enumeration value=""Hundred Sheets"" />
              <xs:enumeration value=""Hundredth of a Carat"" />
              <xs:enumeration value=""Imperial Gallons"" />
              <xs:enumeration value=""Inch"" />
              <xs:enumeration value=""Jar"" />
              <xs:enumeration value=""Joint"" />
              <xs:enumeration value=""Joule"" />
              <xs:enumeration value=""Keg"" />
              <xs:enumeration value=""Kelvin"" />
              <xs:enumeration value=""Kiloampere"" />
              <xs:enumeration value=""Kilobecquerel/Kilogram"" />
              <xs:enumeration value=""Kilogram"" />
              <xs:enumeration value=""Kilogram per cubic meter"" />
              <xs:enumeration value=""Kilogram/Kilogram"" />
              <xs:enumeration value=""Kilogram/square meter"" />
              <xs:enumeration value=""Kilogramm pro Sekunde"" />
              <xs:enumeration value=""Kilohertz"" />
              <xs:enumeration value=""Kilojoule"" />
              <xs:enumeration value=""Kilometer"" />
              <xs:enumeration value=""Kilometer/hour"" />
              <xs:enumeration value=""Kiloohm"" />
              <xs:enumeration value=""Kilovolt"" />
              <xs:enumeration value=""Kilowatt"" />
              <xs:enumeration value=""Kilowatt-hour"" />
              <xs:enumeration value=""Kit"" />
              <xs:enumeration value=""Kubikdezimeter"" />
              <xs:enumeration value=""Kubikmeter pro Sekunde"" />
              <xs:enumeration value=""Lifts"" />
              <xs:enumeration value=""Link"" />
              <xs:enumeration value=""Liquid Pounds"" />
              <xs:enumeration value=""Liter"" />
              <xs:enumeration value=""Load"" />
              <xs:enumeration value=""Lot"" />
              <xs:enumeration value=""Lug"" />
              <xs:enumeration value=""Mat"" />
              <xs:enumeration value=""Megagram"" />
              <xs:enumeration value=""Megagrams Per Hour"" />
              <xs:enumeration value=""Megahertz"" />
              <xs:enumeration value=""Megapascal"" />
              <xs:enumeration value=""Megawatt"" />
              <xs:enumeration value=""Meter"" />
              <xs:enumeration value=""Meter pro Quadratsekunde"" />
              <xs:enumeration value=""Meters per second"" />
              <xs:enumeration value=""Micrograms Per Cubic Meter"" />
              <xs:enumeration value=""Micrometer"" />
              <xs:enumeration value=""Microsecond"" />
              <xs:enumeration value=""Mikrogram/cubic meter"" />
              <xs:enumeration value=""Mile"" />
              <xs:enumeration value=""Milliampere"" />
              <xs:enumeration value=""Millibar"" />
              <xs:enumeration value=""Milligram/cubic meter"" />
              <xs:enumeration value=""Milligram/kilogram"" />
              <xs:enumeration value=""Milligram/Liter"" />
              <xs:enumeration value=""Milligrams Per Cubic Meter"" />
              <xs:enumeration value=""Milligrams Per Square Meter"" />
              <xs:enumeration value=""Millijoule"" />
              <xs:enumeration value=""Milliliter"" />
              <xs:enumeration value=""Millimeter"" />
              <xs:enumeration value=""Millimeter H20"" />
              <xs:enumeration value=""Millimol"" />
              <xs:enumeration value=""Millimol/kilogram"" />
              <xs:enumeration value=""Million BTU's"" />
              <xs:enumeration value=""Millipascal seconds"" />
              <xs:enumeration value=""Millisecond"" />
              <xs:enumeration value=""Millitesla"" />
              <xs:enumeration value=""Millivolt"" />
              <xs:enumeration value=""Milliwatt"" />
              <xs:enumeration value=""Minute"" />
              <xs:enumeration value=""Miter"" />
              <xs:enumeration value=""Mol"" />
              <xs:enumeration value=""Mol/kilogram"" />
              <xs:enumeration value=""Month"" />
              <xs:enumeration value=""Multichip When 2 or more dies (chips) are merged into one package."" />
              <xs:enumeration value=""Nanometer"" />
              <xs:enumeration value=""Nanosecond"" />
              <xs:enumeration value=""Net Barrels"" />
              <xs:enumeration value=""Net Gallons"" />
              <xs:enumeration value=""Net Imperial Gallons"" />
              <xs:enumeration value=""Net Liters"" />
              <xs:enumeration value=""Newton"" />
              <xs:enumeration value=""Ohm"" />
              <xs:enumeration value=""One"" />
              <xs:enumeration value=""One Thousand Pieces"" />
              <xs:enumeration value=""Ounce"" />
              <xs:enumeration value=""Ounce"" />
              <xs:enumeration value=""Pack (PAK)"" />
              <xs:enumeration value=""Package"" />
              <xs:enumeration value=""Packet"" />
              <xs:enumeration value=""Pad"" />
              <xs:enumeration value=""Pail"" />
              <xs:enumeration value=""Pair"" />
              <xs:enumeration value=""Pallet"" />
              <xs:enumeration value=""Pallet (Lift)"" />
              <xs:enumeration value=""Pallet/Unit Load"" />
              <xs:enumeration value=""Pallete"" />
              <xs:enumeration value=""Panel"" />
              <xs:enumeration value=""Parcel"" />
              <xs:enumeration value=""Parts per billion (US)"" />
              <xs:enumeration value=""Parts per million"" />
              <xs:enumeration value=""Pascal"" />
              <xs:enumeration value=""Pascal second"" />
              <xs:enumeration value=""Pennyweight"" />
              <xs:enumeration value=""Per Hundred Pieces"" />
              <xs:enumeration value=""Percent"" />
              <xs:enumeration value=""Percent Per 1000 Hours"" />
              <xs:enumeration value=""Percent Weight"" />
              <xs:enumeration value=""Percentage"" />
              <xs:enumeration value=""Piece"" />
              <xs:enumeration value=""Pint - US liquid"" />
              <xs:enumeration value=""Pint U.S. Dry"" />
              <xs:enumeration value=""Plate"" />
              <xs:enumeration value=""Pound"" />
              <xs:enumeration value=""Pounds Per 1000 Square Feet"" />
              <xs:enumeration value=""Pounds Per Foot"" />
              <xs:enumeration value=""Pounds Per Gallon"" />
              <xs:enumeration value=""Pounds Per Piece of Product"" />
              <xs:enumeration value=""Pounds Per Pound of Product"" />
              <xs:enumeration value=""Pounds Per Thousand"" />
              <xs:enumeration value=""Quart - US liquid"" />
              <xs:enumeration value=""Rack"" />
              <xs:enumeration value=""Ream of 500 Sheets"" />
              <xs:enumeration value=""Reel"" />
              <xs:enumeration value=""Ring"" />
              <xs:enumeration value=""Rod"" />
              <xs:enumeration value=""Roll"" />
              <xs:enumeration value=""Sack"" />
              <xs:enumeration value=""Second"" />
              <xs:enumeration value=""Set"" />
              <xs:enumeration value=""SET Mask Set (SET)"" />
              <xs:enumeration value=""Sheet"" />
              <xs:enumeration value=""Sheet-Metric measure"" />
              <xs:enumeration value=""Shipment"" />
              <xs:enumeration value=""Shot"" />
              <xs:enumeration value=""Skein"" />
              <xs:enumeration value=""Skid"" />
              <xs:enumeration value=""Sleeve"" />
              <xs:enumeration value=""Slip Sheet"" />
              <xs:enumeration value=""Spool"" />
              <xs:enumeration value=""Square"" />
              <xs:enumeration value=""Square foot"" />
              <xs:enumeration value=""Square inch"" />
              <xs:enumeration value=""Square kilometer"" />
              <xs:enumeration value=""Square meter"" />
              <xs:enumeration value=""Square meter/second"" />
              <xs:enumeration value=""Square mile"" />
              <xs:enumeration value=""Square millimeter"" />
              <xs:enumeration value=""Square Yard"" />
              <xs:enumeration value=""Statute Mile"" />
              <xs:enumeration value=""Stick"" />
              <xs:enumeration value=""Strip"" />
              <xs:enumeration value=""Super Bulk Bag"" />
              <xs:enumeration value=""Tablet"" />
              <xs:enumeration value=""Tank"" />
              <xs:enumeration value=""Tank Truck"" />
              <xs:enumeration value=""Tesla"" />
              <xs:enumeration value=""Thousand"" />
              <xs:enumeration value=""Ton"" />
              <xs:enumeration value=""Tonne"" />
              <xs:enumeration value=""Torr"" />
              <xs:enumeration value=""Tote"" />
              <xs:enumeration value=""Track Foot"" />
              <xs:enumeration value=""Trailer"" />
              <xs:enumeration value=""Train"" />
              <xs:enumeration value=""Tray"" />
              <xs:enumeration value=""Troy"" />
              <xs:enumeration value=""Troy OZ"" />
              <xs:enumeration value=""Truckload"" />
              <xs:enumeration value=""Tube"" />
              <xs:enumeration value=""Unitless Unit of Measure"" />
              <xs:enumeration value=""US gallon"" />
              <xs:enumeration value=""US pound"" />
              <xs:enumeration value=""US ton"" />
              <xs:enumeration value=""Vial"" />
              <xs:enumeration value=""Volt"" />
              <xs:enumeration value=""Wafer"" />
              <xs:enumeration value=""Watt"" />
              <xs:enumeration value=""Week"" />
              <xs:enumeration value=""WF Wafer (WF)"" />
              <xs:enumeration value=""Wrap"" />
              <xs:enumeration value=""Yard"" />
              <xs:enumeration value=""Year"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:PartnerContact"" />
        <xs:element ref=""ns0:ProductAttributeInformation"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:ProductDistributionInformation"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:ProductLifecycleInformation"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:ProductProcurementInformation"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalLeadTimeClassificationCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""End of life"" />
        <xs:enumeration value=""Production"" />
        <xs:enumeration value=""Start up"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""toRole"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:PartnerRoleDescription"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""revisionIdentifier"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalProductLifeCycleStatusCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Active"" />
        <xs:enumeration value=""EOL: End Of Life"" />
        <xs:enumeration value=""Obsolete"" />
        <xs:enumeration value=""On Hold"" />
        <xs:enumeration value=""Unavailable through program"" />
        <xs:enumeration value=""Unreleased"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""GlobalPartnerClassificationCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Broker"" />
        <xs:enumeration value=""Carrier"" />
        <xs:enumeration value=""Contract Manufacturer"" />
        <xs:enumeration value=""Customs Broker"" />
        <xs:enumeration value=""Distribution Center"" />
        <xs:enumeration value=""Distributor"" />
        <xs:enumeration value=""End User"" />
        <xs:enumeration value=""End User Government"" />
        <xs:enumeration value=""Financier"" />
        <xs:enumeration value=""Freight Forwarder"" />
        <xs:enumeration value=""Manufacturer"" />
        <xs:enumeration value=""Original Equipment Manufacturer"" />
        <xs:enumeration value=""Reseller"" />
        <xs:enumeration value=""Retailer"" />
        <xs:enumeration value=""Shopper"" />
        <xs:enumeration value=""Warehouser"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
</xs:schema>";
        
        public _2A12_MS_V01_03_ProductMasterNotification() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Pip2A12ProductMasterNotification";
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
