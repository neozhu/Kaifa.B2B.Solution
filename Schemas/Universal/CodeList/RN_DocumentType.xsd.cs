namespace RosettaNet.Schemas.Universal.CodeList {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"DocumentTypeA", @"DocumentType"})]
    public sealed class RN_DocumentType : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""urn:rosettanet:specification:universal:DocumentType:xsd:codelist:1.0"" xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""urn:rosettanet:specification:universal:DocumentType:xsd:codelist:1.0"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:documentation>
      <urss:Copyright xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">© 2004 RosettaNet. All rights reserved. No part of this publication may be reproduced, stored in a retrieval system, or transmitted, in any form or by any means, electronic, mechanical, photocopying, recording, or otherwise, without the inclusion of this copyright notice. Any derivative works must cite the copyright notice. Any public redistribution or sale of this publication or derivative works requires prior written permission of the publisher.</urss:Copyright>
      <urss:Disclaimer xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet makes no representation about the suitability of this work for any purpose or regarding any claims made by products which use it.  It is provided as is without expressed or implied warranty.</urss:Disclaimer>
      <urss:Program xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Domain Model Foundational Program</urss:Program>
      <urss:Purpose xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Provides the RosettaNet business Document Type codes.</urss:Purpose>
    </xs:documentation>
    <xs:appinfo>
      <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
      <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
    </xs:appinfo>
  </xs:annotation>
  <xs:element abstract=""true"" name=""DocumentTypeA"" type=""xs:anyType"" />
  <xs:element name=""DocumentType"" substitutionGroup=""tns:DocumentTypeA"" type=""tns:DocumentTypeType"" />
  <xs:simpleType name=""DocumentTypeContentType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A code identifying the business context of a document.</urss:Definition>
        <urss:Identifier xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">urdmt:DocumentTypeType</urss:Identifier>
        <urss:RegisteredBy xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet</urss:RegisteredBy>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:restriction base=""xs:token"">
      <xs:enumeration value=""CBN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Product batch number of customer.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CCN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Customs clearance number.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CFA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Failure Analysis request document that will accompany the product providing characteristics of the component failure.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CIN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Commercial Invoice</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CNM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Traditional credit note or memo.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CON"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">In a virtual sourcing relationship, a third party trading partner is supplying a part to a customer on behalf of another company that has taken the order for the customer. In this case a Customer Order Number is associated to the request for material that is sent to the virtual trading partners.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""COT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Contract</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CRN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Unique consumption reference number identifying the product consumption issue i.e. one-to-one relationship with physical flow.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""DEM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Traditional debit note or memo.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""DEN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Delivery Note</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""DIN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Discontinuation Notice.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""DRN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Drawing Number</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""FUO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Sales order or transfer order fulfilling demand out of a facility (outbound shipment).</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""INV"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Invoice</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MEN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Master Event Number</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MON"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Model Number</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""OCL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The unique identifier assigned by the OEM for a warranty claim.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""OPO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The unique identifier assigned by the OEM for a part order.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""OPR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The unique identifier assigned by the OEM for a part return.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PFA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Failure Analysis request document that will accompany the product providing characteristics of the product failure.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PII"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Refers to previously issued invoice.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PLS"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Unique number that identifies packing form prior to shipment.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""POI"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Purchase Order IN</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PON"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Production order number for material release.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""POO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Purchase Order OUT</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PRC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Product Catalog.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PSI"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Refers to previously issued self-billing invoice.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PUO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Purchase Order</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""QUO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Quote</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""REC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Document identifying the receipt of materials or products into a facility against a purchase order or transfer order (inbound shipment).</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""REO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Purchase order or transfer order replenishing inventory into a facility (inbound shipment).</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""REQ"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Requisition</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""RMA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Returned Material Authorization</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""RPO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Purchase order for materials or product returned to and reworked by a supplier.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SAO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Sales Order</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SBC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Credit Memo used in self-billing scenario.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SBD"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Debit Memo used in self-billing scenario.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SBI"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Invoice in self billing scenario.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SBN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Product batch number of supplier.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SCA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Similar to contracts. Contains the quantity of an article that is to be ordered from a vendor and the price for article or service that is to be procured.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SEN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Serial Number</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SEO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A document that gives a repair provider the necessary authorization to repair or upgrade a product either at the customer site or at the repair provider’s site.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SNC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Shipset Number on Code List</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SPC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The unique identifier assigned by the ASP for a warranty claim.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SPN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Spec Number</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SPO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The unique identifier assigned by the ASP for a part order.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SPR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The unique identifier assigned by the ASP for a part return.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SPW"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The unique identifier assigned by the ASP to reference a work order.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SRI"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A document that contains the shipping reference number which allows the product to be tracked within the outsourced logistic providers network.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""TRO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Order which results in materials or products being moved from one facility to another (outbound shipment and inbound shipment).</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""WAB"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Waybill</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""WAC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Denotes a warranty claim.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""WOO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Work Order</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""DocumentTypeType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Identifier xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">DocumentTypeType</urss:Identifier>
        <urss:RegisteredBy xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet</urss:RegisteredBy>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:simpleContent>
      <xs:extension base=""tns:DocumentTypeContentType"">
        <xs:attribute fixed=""DocumentType"" name=""identifier"" type=""xs:token"" />
        <xs:attribute fixed=""1.0"" name=""codeListVersion"" type=""xs:token"" />
        <xs:attribute fixed=""RosettaNet"" name=""agency"" type=""xs:token"" />
        <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
</xs:schema>";
        
        public RN_DocumentType() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "DocumentTypeA";
                _RootElements[1] = "DocumentType";
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
        
        [Schema(@"urn:rosettanet:specification:universal:DocumentType:xsd:codelist:1.0",@"DocumentTypeA")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DocumentTypeA"})]
        public sealed class DocumentTypeA : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DocumentTypeA() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DocumentTypeA";
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
        
        [Schema(@"urn:rosettanet:specification:universal:DocumentType:xsd:codelist:1.0",@"DocumentType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DocumentType"})]
        public sealed class DocumentType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DocumentType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DocumentType";
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
