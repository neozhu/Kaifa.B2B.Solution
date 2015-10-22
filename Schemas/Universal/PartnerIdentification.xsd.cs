namespace RosettaNet.Schemas.Universal {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"IntermittentPartner", @"KnownPartner", @"PartnerIdentification", @"SpecifiedIntermittentPartner", @"SpecifiedKnownPartner"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.CodeList.RN_ProcessRoleIdentifier", typeof(RosettaNet.Schemas.Universal.CodeList.RN_ProcessRoleIdentifier))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.DataType", typeof(RosettaNet.Schemas.Universal.DataType))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.AbstractType", typeof(RosettaNet.Schemas.Universal.AbstractType))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.ContactInformation", typeof(RosettaNet.Schemas.Universal.ContactInformation))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.Locations", typeof(RosettaNet.Schemas.Universal.Locations))]
    public sealed class PartnerIdentification1 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:urrrn=""urn:rosettanet:specification:universal:ProcessRoleIdentifier:xsd:codelist:1.0"" xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"" xmlns:tns=""urn:rosettanet:specification:universal:PartnerIdentification:xsd:schema:1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ubtcy=""urn:rosettanet:specification:universal:AbstractType:xsd:schema:1.0"" xmlns:udtyp=""urn:rosettanet:specification:universal:DataType:xsd:schema:1.0"" xmlns:ucttf=""urn:rosettanet:specification:universal:ContactInformation:xsd:schema:1.0"" xmlns:ulctn=""urn:rosettanet:specification:universal:Locations:xsd:schema:1.0"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""urn:rosettanet:specification:universal:PartnerIdentification:xsd:schema:1.0"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.CodeList.RN_ProcessRoleIdentifier"" namespace=""urn:rosettanet:specification:universal:ProcessRoleIdentifier:xsd:codelist:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.DataType"" namespace=""urn:rosettanet:specification:universal:DataType:xsd:schema:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.AbstractType"" namespace=""urn:rosettanet:specification:universal:AbstractType:xsd:schema:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.ContactInformation"" namespace=""urn:rosettanet:specification:universal:ContactInformation:xsd:schema:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.Locations"" namespace=""urn:rosettanet:specification:universal:Locations:xsd:schema:1.0"" />
  <xs:annotation>
    <xs:documentation>
      <urss:Copyright xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">© 2004 RosettaNet. All rights reserved. No part of this publication may be reproduced, stored in a retrieval system, or transmitted, in any form or by any means, electronic, mechanical, photocopying, recording, or otherwise, without the inclusion of this copyright notice. Any derivative works must cite the copyright notice. Any public redistribution or sale of this publication or derivative works requires prior written permission of the publisher.</urss:Copyright>
      <urss:Disclaimer xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet makes no representation about the suitability of this work for any purpose or regarding any claims made by products which use it.  It is provided as is without expressed or implied warranty.</urss:Disclaimer>
      <urss:Program xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Domain Model Foundational Program</urss:Program>
      <urss:Purpose xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Collection of all Partner Identifiaction structures.</urss:Purpose>
    </xs:documentation>
    <xs:appinfo>
      <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
      <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""urn:rosettanet:specification:universal:DataType:xsd:schema:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:Country:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:Locations:xsd:schema:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:CountrySubdivision:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:ContactInformation:xsd:schema:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:ProcessRoleIdentifier:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:AbstractType:xsd:schema:1.0"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""IntermittentPartner"" type=""tns:IntermittentPartnerType"" />
  <xs:element name=""KnownPartner"" type=""tns:KnownPartnerType"" />
  <xs:element name=""PartnerIdentification"" type=""tns:PartnerIdentificationType"" />
  <xs:element name=""SpecifiedIntermittentPartner"" type=""tns:SpecifiedIntermittentPartnerType"" />
  <xs:element name=""SpecifiedKnownPartner"" type=""tns:SpecifiedKnownPartnerType"" />
  <xs:complexType name=""IntermittentPartnerType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The business document must describe a physical address for a delivery. </urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:SpecifiedIntermittentPartnerType"">
        <xs:sequence>
          <xs:element ref=""urrrn:ProcessRoleIdentifier"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""KnownPartnerType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The business document must describe the trading partners in the business transaction.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:SpecifiedKnownPartnerType"">
        <xs:sequence>
          <xs:element ref=""urrrn:ProcessRoleIdentifier"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""PartnerIdentificationType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The business document must allow for the identity of one or more parties to the transaction.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""ubtcy:IdentifierType"">
        <xs:sequence>
          <xs:choice>
            <xs:element ref=""udtyp:Duns"" />
            <xs:element ref=""udtyp:DunsPlus4"" />
            <xs:element ref=""udtyp:ReceiverIdentifier"" />
            <xs:element ref=""udtyp:SenderIdentifier"" />
          </xs:choice>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""SpecifiedIntermittentPartnerType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">
        </urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element ref=""ucttf:ContactInformation"" />
      <xs:element name=""PartnerName"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The name of the partner’s company/business.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element ref=""ulctn:PhysicalAddress"" />
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""SpecifiedKnownPartnerType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">
        </urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element ref=""tns:PartnerIdentification"" />
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
</xs:schema>";
        
        public PartnerIdentification1() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [5];
                _RootElements[0] = "IntermittentPartner";
                _RootElements[1] = "KnownPartner";
                _RootElements[2] = "PartnerIdentification";
                _RootElements[3] = "SpecifiedIntermittentPartner";
                _RootElements[4] = "SpecifiedKnownPartner";
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
        
        [Schema(@"urn:rosettanet:specification:universal:PartnerIdentification:xsd:schema:1.0",@"IntermittentPartner")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"IntermittentPartner"})]
        public sealed class IntermittentPartner : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public IntermittentPartner() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "IntermittentPartner";
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
        
        [Schema(@"urn:rosettanet:specification:universal:PartnerIdentification:xsd:schema:1.0",@"KnownPartner")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"KnownPartner"})]
        public sealed class KnownPartner : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public KnownPartner() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "KnownPartner";
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
        
        [Schema(@"urn:rosettanet:specification:universal:PartnerIdentification:xsd:schema:1.0",@"PartnerIdentification")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PartnerIdentification"})]
        public sealed class PartnerIdentification : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PartnerIdentification() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PartnerIdentification";
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
        
        [Schema(@"urn:rosettanet:specification:universal:PartnerIdentification:xsd:schema:1.0",@"SpecifiedIntermittentPartner")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SpecifiedIntermittentPartner"})]
        public sealed class SpecifiedIntermittentPartner : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SpecifiedIntermittentPartner() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SpecifiedIntermittentPartner";
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
        
        [Schema(@"urn:rosettanet:specification:universal:PartnerIdentification:xsd:schema:1.0",@"SpecifiedKnownPartner")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SpecifiedKnownPartner"})]
        public sealed class SpecifiedKnownPartner : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SpecifiedKnownPartner() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SpecifiedKnownPartner";
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
