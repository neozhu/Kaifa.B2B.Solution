namespace RosettaNet.Schemas.Interchange {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"urn:rosettanet:specification:interchange:SalesReportNotification:xsd:schema:1.0",@"SalesReportNotification")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "DocumentHeader.Sender.PartnerIdentification.Duns", XPath = @"/*[local-name()='SalesReportNotification' and namespace-uri()='urn:rosettanet:specification:interchange:SalesReportNotification:xsd:schema:1.0']/*[local-name()='DocumentHeader' and namespace-uri()='urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0']/*[local-name()='Sender' and namespace-uri()='urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0']/*[local-name()='PartnerIdentification' and namespace-uri()='urn:rosettanet:specification:universal:PartnerIdentification:xsd:schema:1.0']/*[local-name()='Duns' and namespace-uri()='urn:rosettanet:specification:universal:DataType:xsd:schema:1.0']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "DocumentHeader.Receiver.PartnerIdentification.Duns", XPath = @"/*[local-name()='SalesReportNotification' and namespace-uri()='urn:rosettanet:specification:interchange:SalesReportNotification:xsd:schema:1.0']/*[local-name()='DocumentHeader' and namespace-uri()='urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0']/*[local-name()='Receiver' and namespace-uri()='urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0']/*[local-name()='PartnerIdentification' and namespace-uri()='urn:rosettanet:specification:universal:PartnerIdentification:xsd:schema:1.0']/*[local-name()='Duns' and namespace-uri()='urn:rosettanet:specification:universal:DataType:xsd:schema:1.0']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SalesReportNotification"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Domain.SalesReporting.SalesReporting", typeof(RosettaNet.Schemas.Domain.SalesReporting.SalesReporting))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.Document", typeof(RosettaNet.Schemas.Universal.Document))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Domain.SalesReporting.CodeList.RN_ReportType", typeof(RosettaNet.Schemas.Domain.SalesReporting.CodeList.RN_ReportType))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.StandardDocumentHeader", typeof(RosettaNet.Schemas.StandardDocumentHeader))]
    public sealed class SalesReportNotification : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:dsspt=""urn:rosettanet:specification:domain:SalesReporting:xsd:schema:1.0"" xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"" xmlns:sdctr=""urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0"" xmlns:tns=""urn:rosettanet:specification:interchange:SalesReportNotification:xsd:schema:1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:drrry=""urn:rosettanet:specification:domain:ReportType:xsd:codelist:1.0"" xmlns:udcmn=""urn:rosettanet:specification:universal:Document:xsd:schema:1.0"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""urn:rosettanet:specification:interchange:SalesReportNotification:xsd:schema:1.0"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""RosettaNet.Schemas.Domain.SalesReporting.SalesReporting"" namespace=""urn:rosettanet:specification:domain:SalesReporting:xsd:schema:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.Document"" namespace=""urn:rosettanet:specification:universal:Document:xsd:schema:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Domain.SalesReporting.CodeList.RN_ReportType"" namespace=""urn:rosettanet:specification:domain:ReportType:xsd:codelist:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.StandardDocumentHeader"" namespace=""urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0"" />
  <xs:annotation>
    <xs:documentation>
      <urss:Copyright xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">© 2004 RosettaNet. All rights reserved. No part of this publication may be reproduced, stored in a retrieval system, or transmitted, in any form or by any means, electronic, mechanical, photocopying, recording, or otherwise, without the inclusion of this copyright notice. Any derivative works must cite the copyright notice. Any public redistribution or sale of this publication or derivative works requires prior written permission of the publisher.</urss:Copyright>
      <urss:Disclaimer xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet makes no representation about the suitability of this work for any purpose or regarding any claims made by products which use it.  It is provided as is without expressed or implied warranty.</urss:Disclaimer>
      <urss:Program xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Sales Reporting Milestone Program</urss:Program>
      <urss:Purpose xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Contains sale-out information and claims for special pricing.</urss:Purpose>
    </xs:documentation>
    <xs:appinfo>
      <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
      <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
      <b:references>
        <b:reference targetNamespace=""urn:rosettanet:specification:universal:ProductIdentification:xsd:schema:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:universal:CountrySubdivision:xsd:codelist:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:universal:DataType:xsd:schema:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:domain:SalesReporting:xsd:schema:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:universal:Document:xsd:schema:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:domain:TransactionType:xsd:codelist:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:domain:BookPriceQualifier:xsd:codelist:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:universal:DocumentType:xsd:codelist:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:universal:Currency:xsd:codelist:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:universal:UnitOfMeasure:xsd:codelist:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:universal:MonetaryExpression:xsd:schema:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:domain:PurchaseMethod:xsd:codelist:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:universal:Country:xsd:codelist:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:universal:PartnerIdentification:xsd:schema:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:universal:ContactInformation:xsd:schema:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:domain:ReportType:xsd:codelist:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:domain:SaleType:xsd:codelist:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:universal:ProcessRoleIdentifier:xsd:codelist:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:universal:Dates:xsd:schema:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:domain:PaymentMethod:xsd:codelist:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:universal:AbstractType:xsd:schema:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:domain:TotalQualifier:xsd:codelist:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:universal:MimeTypeQualifier:xsd:codelist:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:universal:Language:xsd:codelist:1.0"" />
        <b:reference targetNamespace=""urn:rosettanet:specification:universal:Locations:xsd:schema:1.0"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""SalesReportNotification"" type=""tns:SalesReportNotificationType"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='SalesReportNotification' and namespace-uri()='urn:rosettanet:specification:interchange:SalesReportNotification:xsd:schema:1.0']/*[local-name()='DocumentHeader' and namespace-uri()='urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0']/*[local-name()='Sender' and namespace-uri()='urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0']/*[local-name()='PartnerIdentification' and namespace-uri()='urn:rosettanet:specification:universal:PartnerIdentification:xsd:schema:1.0']/*[local-name()='Duns' and namespace-uri()='urn:rosettanet:specification:universal:DataType:xsd:schema:1.0']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SalesReportNotification' and namespace-uri()='urn:rosettanet:specification:interchange:SalesReportNotification:xsd:schema:1.0']/*[local-name()='DocumentHeader' and namespace-uri()='urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0']/*[local-name()='Receiver' and namespace-uri()='urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0']/*[local-name()='PartnerIdentification' and namespace-uri()='urn:rosettanet:specification:universal:PartnerIdentification:xsd:schema:1.0']/*[local-name()='Duns' and namespace-uri()='urn:rosettanet:specification:universal:DataType:xsd:schema:1.0']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:complexType name=""ProductTransferType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">This object describes a POS (point of sale) information for known/unknown end user(s).</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""dsspt:ParticipatingPartner"" />
      <xs:element maxOccurs=""unbounded"" name=""SalesReportLineItem"" type=""tns:SalesReportLineItemType"" />
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""SalesReportType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The sales report document.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""AccountManagerCode"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A code that identifies the account manager</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Comment"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A textual description of information relating to a product sale</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" ref=""dsspt:ContractDetails"" />
      <xs:element minOccurs=""0"" name=""ExportReferenceNumber"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A number for export reference</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""MarketType"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Type of market</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element maxOccurs=""unbounded"" ref=""dsspt:ParticipatingPartner"" />
      <xs:element minOccurs=""0"" ref=""dsspt:ProductSummary"" />
      <xs:element maxOccurs=""unbounded"" name=""ProductTransfer"" type=""tns:ProductTransferType"" />
      <xs:element name=""ReportType"" type=""drrry:ReportTypeType"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Code identifying the specific type of report.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SalesTerritoryNumber"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Sales territory number</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""SalesReportLineItemType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">This object describes an entry in a sales report. Group of attributes pertaining to the individual item in the report.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""udcmn:BusinessDocumentReference"" />
      <xs:element minOccurs=""0"" name=""Comment"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A textual description of information relating to a product sale</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" ref=""dsspt:InstallLocation"" />
      <xs:element name=""LineNumber"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Number of the line in the document.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element ref=""dsspt:ProductInformation"" />
      <xs:element name=""Quantity"" type=""xs:float"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Quantity of product.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""dsspt:SalesOutAndTransaction"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SpecialPriceClaim"" type=""tns:SpecialPriceClaimType"" />
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""SalesReportNotificationType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Top level object for a Sales Report business document.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element ref=""sdctr:DocumentHeader"" />
      <xs:element name=""SalesReport"" type=""tns:SalesReportType"" />
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""SpecialPriceClaimType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">This object describes a claim for a special pricing/deal whereby a special price could be offered if number of units and period conditions are met.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""AuthorizationNumber"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">An identifier that uniquely references a special price</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Comments"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A textual description of a special price claim</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""DebitMemoNumber"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Debit memo number</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Identifier"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">An identifier of a special price claim</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ReferenceQuallifier"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Special price claim reference qualifier</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ReferenceValue"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Special price claim reference value. This value depends on the reference type.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element ref=""dsspt:SpecialPrice"" />
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
</xs:schema>";
        
        public SalesReportNotification() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "SalesReportNotification";
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
