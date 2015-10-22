namespace RosettaNet.Schemas.Domain.SalesReporting {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"BookPrice", @"ContractDetails", @"DatePeriodAndDuration", @"InstallLocation", @"LotIdentification", @"ParticipatingPartner", @"ProductInformation", @"ProductSummary", @"ProductUnitTotal", @"SalesOut", @"SalesOutAndTransaction", @"SpecialPrice"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Domain.SalesReporting.CodeList.RN_TotalQualifier", typeof(RosettaNet.Schemas.Domain.SalesReporting.CodeList.RN_TotalQualifier))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.ProductIdentification", typeof(RosettaNet.Schemas.Universal.ProductIdentification))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.Dates", typeof(RosettaNet.Schemas.Universal.Dates))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.Locations", typeof(RosettaNet.Schemas.Universal.Locations))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.ContactInformation", typeof(RosettaNet.Schemas.Universal.ContactInformation))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.MonetaryExpression", typeof(RosettaNet.Schemas.Universal.MonetaryExpression))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Domain.SalesReporting.CodeList.RN_BookPriceQualifier", typeof(RosettaNet.Schemas.Domain.SalesReporting.CodeList.RN_BookPriceQualifier))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Domain.SalesReporting.CodeList.RN_SaleType", typeof(RosettaNet.Schemas.Domain.SalesReporting.CodeList.RN_SaleType))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Domain.SalesReporting.CodeList.RN_PaymentMethod", typeof(RosettaNet.Schemas.Domain.SalesReporting.CodeList.RN_PaymentMethod))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Domain.SalesReporting.CodeList.RN_PurchaseMethod", typeof(RosettaNet.Schemas.Domain.SalesReporting.CodeList.RN_PurchaseMethod))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Domain.SalesReporting.CodeList.RN_TransactionType", typeof(RosettaNet.Schemas.Domain.SalesReporting.CodeList.RN_TransactionType))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.PartnerIdentification1", typeof(RosettaNet.Schemas.Universal.PartnerIdentification1))]
    public sealed class SalesReporting : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:drbpc=""urn:rosettanet:specification:domain:BookPriceQualifier:xsd:codelist:1.0"" xmlns:drpcs=""urn:rosettanet:specification:domain:PurchaseMethod:xsd:codelist:1.0"" xmlns:drpmt=""urn:rosettanet:specification:domain:PaymentMethod:xsd:codelist:1.0"" xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"" xmlns:uptrn=""urn:rosettanet:specification:universal:PartnerIdentification:xsd:schema:1.0"" xmlns:umtyp=""urn:rosettanet:specification:universal:MonetaryExpression:xsd:schema:1.0"" xmlns:drtnc=""urn:rosettanet:specification:domain:TransactionType:xsd:codelist:1.0"" xmlns:ucttf=""urn:rosettanet:specification:universal:ContactInformation:xsd:schema:1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""urn:rosettanet:specification:domain:SalesReporting:xsd:schema:1.0"" xmlns:drtqf=""urn:rosettanet:specification:domain:TotalQualifier:xsd:codelist:1.0"" xmlns:updtn=""urn:rosettanet:specification:universal:ProductIdentification:xsd:schema:1.0"" xmlns:drnsl=""urn:rosettanet:specification:domain:SaleType:xsd:codelist:1.0"" xmlns:udts=""urn:rosettanet:specification:universal:Dates:xsd:schema:1.0"" xmlns:ulctn=""urn:rosettanet:specification:universal:Locations:xsd:schema:1.0"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""urn:rosettanet:specification:domain:SalesReporting:xsd:schema:1.0"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""RosettaNet.Schemas.Domain.SalesReporting.CodeList.RN_TotalQualifier"" namespace=""urn:rosettanet:specification:domain:TotalQualifier:xsd:codelist:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.ProductIdentification"" namespace=""urn:rosettanet:specification:universal:ProductIdentification:xsd:schema:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.Dates"" namespace=""urn:rosettanet:specification:universal:Dates:xsd:schema:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.Locations"" namespace=""urn:rosettanet:specification:universal:Locations:xsd:schema:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.ContactInformation"" namespace=""urn:rosettanet:specification:universal:ContactInformation:xsd:schema:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.MonetaryExpression"" namespace=""urn:rosettanet:specification:universal:MonetaryExpression:xsd:schema:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Domain.SalesReporting.CodeList.RN_BookPriceQualifier"" namespace=""urn:rosettanet:specification:domain:BookPriceQualifier:xsd:codelist:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Domain.SalesReporting.CodeList.RN_SaleType"" namespace=""urn:rosettanet:specification:domain:SaleType:xsd:codelist:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Domain.SalesReporting.CodeList.RN_PaymentMethod"" namespace=""urn:rosettanet:specification:domain:PaymentMethod:xsd:codelist:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Domain.SalesReporting.CodeList.RN_PurchaseMethod"" namespace=""urn:rosettanet:specification:domain:PurchaseMethod:xsd:codelist:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Domain.SalesReporting.CodeList.RN_TransactionType"" namespace=""urn:rosettanet:specification:domain:TransactionType:xsd:codelist:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.PartnerIdentification1"" namespace=""urn:rosettanet:specification:universal:PartnerIdentification:xsd:schema:1.0"" />
  <xs:annotation>
    <xs:documentation>
      <urss:Copyright xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">© 2004 RosettaNet. All rights reserved. No part of this publication may be reproduced, stored in a retrieval system, or transmitted, in any form or by any means, electronic, mechanical, photocopying, recording, or otherwise, without the inclusion of this copyright notice. Any derivative works must cite the copyright notice. Any public redistribution or sale of this publication or derivative works requires prior written permission of the publisher.</urss:Copyright>
      <urss:Disclaimer xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet makes no representation about the suitability of this work for any purpose or regarding any claims made by products which use it.  It is provided as is without expressed or implied warranty.</urss:Disclaimer>
      <urss:Program xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Sales Reporting Milestone Program</urss:Program>
      <urss:Purpose xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Provides the Sales Reporting domain structures.</urss:Purpose>
    </xs:documentation>
    <xs:appinfo>
      <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
      <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""urn:rosettanet:specification:universal:ProductIdentification:xsd:schema:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:CountrySubdivision:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:DataType:xsd:schema:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:domain:TransactionType:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:domain:BookPriceQualifier:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:UnitOfMeasure:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:MonetaryExpression:xsd:schema:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:domain:PurchaseMethod:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:Country:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:PartnerIdentification:xsd:schema:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:ContactInformation:xsd:schema:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:domain:SaleType:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:ProcessRoleIdentifier:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:Dates:xsd:schema:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:Currency:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:AbstractType:xsd:schema:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:domain:TotalQualifier:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:domain:PaymentMethod:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:Locations:xsd:schema:1.0"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""BookPrice"" type=""tns:BookPriceType"" />
  <xs:element name=""ContractDetails"" type=""tns:ContractDetailsType"" />
  <xs:element name=""DatePeriodAndDuration"" type=""tns:DatePeriodAndDurationType"" />
  <xs:element name=""InstallLocation"" type=""tns:InstallLocationType"" />
  <xs:element name=""LotIdentification"" type=""tns:LotIdentificationType"" />
  <xs:element name=""ParticipatingPartner"" type=""tns:ParticipatingPartnerType"" />
  <xs:element name=""ProductInformation"" type=""tns:ProductInformationType"" />
  <xs:element name=""ProductSummary"" type=""tns:ProductSummaryType"" />
  <xs:element name=""ProductUnitTotal"" type=""tns:ProductUnitTotalType"" />
  <xs:element name=""SalesOut"" type=""tns:SalesOutType"" />
  <xs:element name=""SalesOutAndTransaction"" type=""tns:SalesOutAndTransactionType"" />
  <xs:element name=""SpecialPrice"" type=""tns:SpecialPriceType"" />
  <xs:complexType name=""BookPriceType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">This object represents a booking price. It describes the price the trading partner was charged by the seller.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element ref=""umtyp:FinancialAmount"" />
      <xs:element name=""Qualifier"" type=""drbpc:BookPriceQualifierType"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Code identifying the price the trading partner was charged by the seller.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""ContractDetailsType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">This object represents a business arrangement for the supply of goods or services. Group of attributes pertaining to the specific type of contract.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element name=""ContractPeriod"" type=""tns:DatePeriodAndDurationType"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">This object allows representation of a date period by a duration or begin and an end dates.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element name=""Identifier"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A unique proprietary number to identify a ""solution"" which is usually a combination of parts and services or software</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element name=""Type"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A textual description of a contract. Additional description pertaining to the type of contract.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""DatePeriodAndDurationType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">This object allows representation of a date period by a duration or begin and an end dates.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:choice>
        <xs:element ref=""udts:DatePeriod"" />
        <xs:element name=""Duration"" type=""xs:duration"" />
      </xs:choice>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""InstallLocationType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">This object describes a customer's install location of a product. The physical address for the final destination of the product.  This location may be different from the customer location.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" ref=""ucttf:ContactInformation"" />
      <xs:choice>
        <xs:element ref=""ulctn:Location"" />
        <xs:element ref=""ulctn:PhysicalAddress"" />
      </xs:choice>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""LotIdentificationType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">This object identifies a lot which associates the product with a specific group of products with some similar attributes.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element name=""Primary"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The primary lot identifier</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Secondary"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The secondary lot identifier</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""ParticipatingPartnerType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">This object describes a partner that participates in a point of sale transaction which can either be a reseller, distributor, manufacturer or end-user.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" ref=""umtyp:TaxJurisdiction"" />
      <xs:choice>
        <xs:element ref=""uptrn:IntermittentPartner"" />
        <xs:element ref=""uptrn:KnownPartner"" />
      </xs:choice>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""ProductInformationType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">This object describes the information pertaining to products sold.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ContractIdentifier"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The contract number. Unique identifier that pertains specifically to the contract.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" ref=""tns:LotIdentification"" />
      <xs:element ref=""updtn:ProductIdentification"" />
      <xs:element minOccurs=""0"" name=""ProvisionPeriod"" type=""tns:DatePeriodAndDurationType"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">This object allows representation of a date period by a duration or begin and an end dates.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SerialIdentifier"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The serial number. There could be multiple serial numbers for a single product sold.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""ProductSummaryType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">This object describes the summary of information (products and products sold). Information in this object is not derivable from the line items.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" ref=""updtn:ProductIdentification"" />
      <xs:element maxOccurs=""unbounded"" ref=""tns:ProductUnitTotal"" />
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""ProductUnitTotalType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">This object describes total units of a product. Total number of products sold by the trading partner.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element name=""Qualifier"" type=""drtqf:TotalQualifierType"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A code that qualifies a total.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element name=""Value"" type=""xs:nonNegativeInteger"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Value of total units of a product</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""SalesOutType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">This object describes the sales out of products.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Date"" type=""xs:date"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Shipment date. This date is trading partner-specific (i.e could be when product left the port, when product left factory, etc.)</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element name=""Quantity"" type=""xs:nonNegativeInteger"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Quantity of products shipped in this shipment.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""SaleType"" type=""drnsl:SaleTypeType"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Code identifying the type of sale terms the trading partner bought from the seller.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""SalesOutAndTransactionType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">This object describes the sales out of a sale and those pertaining to a sale transaction.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""BookDate"" type=""xs:date"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Original book date of this shipment</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""BookUnitPrice"" type=""tns:BookPriceType"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">This object represents a booking price. It describes the price the trading partner was charged by the seller.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""LeaseDescription"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A textual description for a lease of product of this shipment</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PaymentMethod"" type=""drpmt:PaymentMethodType"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Code identifying how the trading partner paid the seller for the product.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PriceListIdentifier"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">An identifier of a price list that is related to this shipment.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PurchaseMethod"" type=""drpcs:PurchaseMethodType"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Code identifying the method by which the trading partner procured the product from the seller.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ResaleUnitPrice"" type=""umtyp:FinancialAmountType"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The business document must express financial amounts. 

</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element ref=""tns:SalesOut"" />
      <xs:element minOccurs=""0"" name=""TransactionType"" type=""drtnc:TransactionTypeType"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Code identifying the type of transaction pertaining to the line item in the sales report.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""SpecialPriceType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">This object represents a special price based on number of unit of products and an eligible period.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""EligiblePeriod"" type=""tns:DatePeriodAndDurationType"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">This object allows representation of a date period by a duration or begin and an end dates.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""EligibleUnits"" type=""xs:nonNegativeInteger"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The number of units that has to be ordered to be eligible for a special price.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element ref=""umtyp:ProductPricing"" />
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
</xs:schema>";
        
        public SalesReporting() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [12];
                _RootElements[0] = "BookPrice";
                _RootElements[1] = "ContractDetails";
                _RootElements[2] = "DatePeriodAndDuration";
                _RootElements[3] = "InstallLocation";
                _RootElements[4] = "LotIdentification";
                _RootElements[5] = "ParticipatingPartner";
                _RootElements[6] = "ProductInformation";
                _RootElements[7] = "ProductSummary";
                _RootElements[8] = "ProductUnitTotal";
                _RootElements[9] = "SalesOut";
                _RootElements[10] = "SalesOutAndTransaction";
                _RootElements[11] = "SpecialPrice";
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
        
        [Schema(@"urn:rosettanet:specification:domain:SalesReporting:xsd:schema:1.0",@"BookPrice")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BookPrice"})]
        public sealed class BookPrice : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BookPrice() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BookPrice";
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
        
        [Schema(@"urn:rosettanet:specification:domain:SalesReporting:xsd:schema:1.0",@"ContractDetails")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ContractDetails"})]
        public sealed class ContractDetails : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ContractDetails() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ContractDetails";
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
        
        [Schema(@"urn:rosettanet:specification:domain:SalesReporting:xsd:schema:1.0",@"DatePeriodAndDuration")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DatePeriodAndDuration"})]
        public sealed class DatePeriodAndDuration : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DatePeriodAndDuration() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DatePeriodAndDuration";
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
        
        [Schema(@"urn:rosettanet:specification:domain:SalesReporting:xsd:schema:1.0",@"InstallLocation")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InstallLocation"})]
        public sealed class InstallLocation : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InstallLocation() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InstallLocation";
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
        
        [Schema(@"urn:rosettanet:specification:domain:SalesReporting:xsd:schema:1.0",@"LotIdentification")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"LotIdentification"})]
        public sealed class LotIdentification : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public LotIdentification() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "LotIdentification";
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
        
        [Schema(@"urn:rosettanet:specification:domain:SalesReporting:xsd:schema:1.0",@"ParticipatingPartner")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ParticipatingPartner"})]
        public sealed class ParticipatingPartner : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ParticipatingPartner() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ParticipatingPartner";
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
        
        [Schema(@"urn:rosettanet:specification:domain:SalesReporting:xsd:schema:1.0",@"ProductInformation")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ProductInformation"})]
        public sealed class ProductInformation : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ProductInformation() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ProductInformation";
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
        
        [Schema(@"urn:rosettanet:specification:domain:SalesReporting:xsd:schema:1.0",@"ProductSummary")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ProductSummary"})]
        public sealed class ProductSummary : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ProductSummary() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ProductSummary";
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
        
        [Schema(@"urn:rosettanet:specification:domain:SalesReporting:xsd:schema:1.0",@"ProductUnitTotal")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ProductUnitTotal"})]
        public sealed class ProductUnitTotal : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ProductUnitTotal() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ProductUnitTotal";
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
        
        [Schema(@"urn:rosettanet:specification:domain:SalesReporting:xsd:schema:1.0",@"SalesOut")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SalesOut"})]
        public sealed class SalesOut : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SalesOut() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SalesOut";
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
        
        [Schema(@"urn:rosettanet:specification:domain:SalesReporting:xsd:schema:1.0",@"SalesOutAndTransaction")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SalesOutAndTransaction"})]
        public sealed class SalesOutAndTransaction : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SalesOutAndTransaction() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SalesOutAndTransaction";
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
        
        [Schema(@"urn:rosettanet:specification:domain:SalesReporting:xsd:schema:1.0",@"SpecialPrice")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SpecialPrice"})]
        public sealed class SpecialPrice : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SpecialPrice() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SpecialPrice";
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
