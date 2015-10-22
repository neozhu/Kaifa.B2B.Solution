namespace RosettaNet.Schemas.Universal.CodeList {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ProcessRoleIdentifierA", @"ProcessRoleIdentifier"})]
    public sealed class RN_ProcessRoleIdentifier : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""urn:rosettanet:specification:universal:ProcessRoleIdentifier:xsd:codelist:1.0"" xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""urn:rosettanet:specification:universal:ProcessRoleIdentifier:xsd:codelist:1.0"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:documentation>
      <urss:Copyright xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">© 2004 RosettaNet. All rights reserved. No part of this publication may be reproduced, stored in a retrieval system, or transmitted, in any form or by any means, electronic, mechanical, photocopying, recording, or otherwise, without the inclusion of this copyright notice. Any derivative works must cite the copyright notice. Any public redistribution or sale of this publication or derivative works requires prior written permission of the publisher.</urss:Copyright>
      <urss:Disclaimer xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet makes no representation about the suitability of this work for any purpose or regarding any claims made by products which use it.  It is provided as is without expressed or implied warranty.</urss:Disclaimer>
      <urss:Program xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Domain Model Foundational Program</urss:Program>
      <urss:Purpose xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Provides the RosettaNet business Process Role Identifier codes.</urss:Purpose>
    </xs:documentation>
    <xs:appinfo>
      <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
      <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
    </xs:appinfo>
  </xs:annotation>
  <xs:element abstract=""true"" name=""ProcessRoleIdentifierA"" type=""xs:anyType"" />
  <xs:element name=""ProcessRoleIdentifier"" substitutionGroup=""tns:ProcessRoleIdentifierA"" type=""tns:ProcessRoleIdentifierType"" />
  <xs:simpleType name=""ProcessRoleIdentifierContentType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Describes the role of the partner in the business process. A partner will fulfill at least one or more roles during the business process.</urss:Definition>
        <urss:Identifier xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">urrrn:ProcessRoleIdentifierType</urss:Identifier>
        <urss:RegisteredBy xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet</urss:RegisteredBy>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:restriction base=""xs:token"">
      <xs:enumeration value=""ADM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Administered by, the party who is the administrative authority of an account.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""ALT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Alternate approval by, the party who has approved a request in the event the approver is not able to respond.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""APP"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Approval by, the party who has approved a request.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BIF"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Bill from, the party that will issue the invoice.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BIT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Bill to, the party that will pay the invoice.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CNC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Cancellation party, the party who is cancelling the shipping order.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""COR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Change originated by, the party who originates a proposed change.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""COW"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Change owned by, the party who owns or who is assigned responsibility for a proposed change.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CRE"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Created by, the party responsible for creating a process or task.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CRA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Credit applicant, the party who is applying for credit.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""DIS"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Distributed by, the party who supplies products to retailers.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""FIN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Financed by, the party who is the financier.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""FOR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Forwarded to, the party to whom a business document has been forwarded.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""ITF"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">In transit from, the party sending the product quantity in a product location transfer.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""ITT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">In transit to, the party receiving the product quantity in a product location transfer.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""INL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Inventory location, the party where the inventory product entry is located.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""INO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Inventory owner, the party that owns the inventory product entry.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MFG"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Manufactured by, the party who creates, processes or produces goods especially in large quantities and by means of industrial machines.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""OWN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Owned by, the party who owns a process.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PUR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Purchased by, the party who is a purchaser of a product.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""REA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Requested approval by, the party who has been selected to approve a request.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""REC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Received by, the party who has received a product shipment.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""REQ"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Requested by, the party who has initiated a request.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""RES"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Respond to, the party to whom a responding business document must be sent when it is not equal to the partner specified in the document header.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""RET"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Return by, the party responsible for either carrying or forwarding the returned product.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""REV"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Reviewed by, the party responsible for reviewing a business document.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SBF"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Self-billing from, the party who initiates the billing in self-billing scenario.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SBT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Self-billing to, the party whom the invoice is addressed to.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SCP"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Shipping charges paid by, the party responsible for administering payment of the shipping charges.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SLD"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Sold to, the party to whom a product has been sold.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SRT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Submit returns to, the party to whom product returns are to be submitted.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SPL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Supplied by, the party who supplies an item, part or assembly.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""TRA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Transported by, the party responsible for either carrying or forwarding the product.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""USE"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Used by, the party who is the end user of the product.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""ULR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Ultimate recipient, the party who ultimately receives the shipment, when an intermediate party takes responsibility for payment and final delivery.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""ProcessRoleIdentifierType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Identifier xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">ProcessRoleIdentifierType</urss:Identifier>
        <urss:RegisteredBy xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet</urss:RegisteredBy>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:simpleContent>
      <xs:extension base=""tns:ProcessRoleIdentifierContentType"">
        <xs:attribute fixed=""ProcessRoleIdentifier"" name=""identifier"" type=""xs:token"" />
        <xs:attribute fixed=""1.0"" name=""codeListVersion"" type=""xs:token"" />
        <xs:attribute fixed=""RosettaNet"" name=""agency"" type=""xs:token"" />
        <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
</xs:schema>";
        
        public RN_ProcessRoleIdentifier() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "ProcessRoleIdentifierA";
                _RootElements[1] = "ProcessRoleIdentifier";
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
        
        [Schema(@"urn:rosettanet:specification:universal:ProcessRoleIdentifier:xsd:codelist:1.0",@"ProcessRoleIdentifierA")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ProcessRoleIdentifierA"})]
        public sealed class ProcessRoleIdentifierA : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ProcessRoleIdentifierA() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ProcessRoleIdentifierA";
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
        
        [Schema(@"urn:rosettanet:specification:universal:ProcessRoleIdentifier:xsd:codelist:1.0",@"ProcessRoleIdentifier")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ProcessRoleIdentifier"})]
        public sealed class ProcessRoleIdentifier : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ProcessRoleIdentifier() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ProcessRoleIdentifier";
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
