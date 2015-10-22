namespace RosettaNet.Schemas.Universal {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Location", @"PhysicalAddress"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.CodeList.ISO_Country", typeof(RosettaNet.Schemas.Universal.CodeList.ISO_Country))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.CodeList.ISO_CountrySubdivision", typeof(RosettaNet.Schemas.Universal.CodeList.ISO_CountrySubdivision))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.DataType", typeof(RosettaNet.Schemas.Universal.DataType))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.AbstractType", typeof(RosettaNet.Schemas.Universal.AbstractType))]
    public sealed class Locations : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ubtcy=""urn:rosettanet:specification:universal:AbstractType:xsd:schema:1.0"" xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"" xmlns:usnrs=""urn:rosettanet:specification:universal:CountrySubdivision:xsd:codelist:1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:udtyp=""urn:rosettanet:specification:universal:DataType:xsd:schema:1.0"" xmlns:tns=""urn:rosettanet:specification:universal:Locations:xsd:schema:1.0"" xmlns:uscnt=""urn:rosettanet:specification:universal:Country:xsd:codelist:1.0"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""urn:rosettanet:specification:universal:Locations:xsd:schema:1.0"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.CodeList.ISO_Country"" namespace=""urn:rosettanet:specification:universal:Country:xsd:codelist:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.CodeList.ISO_CountrySubdivision"" namespace=""urn:rosettanet:specification:universal:CountrySubdivision:xsd:codelist:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.DataType"" namespace=""urn:rosettanet:specification:universal:DataType:xsd:schema:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.AbstractType"" namespace=""urn:rosettanet:specification:universal:AbstractType:xsd:schema:1.0"" />
  <xs:annotation>
    <xs:documentation>
      <urss:Copyright xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">© 2004 RosettaNet. All rights reserved. No part of this publication may be reproduced, stored in a retrieval system, or transmitted, in any form or by any means, electronic, mechanical, photocopying, recording, or otherwise, without the inclusion of this copyright notice. Any derivative works must cite the copyright notice. Any public redistribution or sale of this publication or derivative works requires prior written permission of the publisher.</urss:Copyright>
      <urss:Disclaimer xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet makes no representation about the suitability of this work for any purpose or regarding any claims made by products which use it.  It is provided as is without expressed or implied warranty.</urss:Disclaimer>
      <urss:Program xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Domain Model Foundational Program</urss:Program>
      <urss:Purpose xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Collection of Location identification structures.</urss:Purpose>
    </xs:documentation>
    <xs:appinfo>
      <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
      <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""urn:rosettanet:specification:universal:DataType:xsd:schema:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:Country:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:CountrySubdivision:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:AbstractType:xsd:schema:1.0"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Location"" type=""tns:LocationType"" />
  <xs:element name=""PhysicalAddress"" type=""tns:PhysicalAddressType"" />
  <xs:complexType name=""LocationType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The business document must specify a location.</urss:Definition>
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
  <xs:complexType name=""PhysicalAddressType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The business document must provide a physical address for a party to the business transaction.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element name=""AddressLine1"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The first line of a physical address.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AddressLine2"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The second line of a physical address.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AddressLine3"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The third line of a physical address.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AddressLine4"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The fourth line of a physical address.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""AddressLine5"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The fifth line of a physical address.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element name=""CityName"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The name of a city.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element name=""Country"" type=""uscnt:CountryType"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">For representation of Country name RosettaNet has adopted ISO 3166-3; 1999. Refer to the following web page to get the latest version of the standard:
 http://www.iso.ch/iso/en/prods-services/iso3166ma/02iso-3166-code-lists/index.html

If you need more information about the ISO standard please contact ISO for more details.
</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""CountrySubdivision"" type=""usnrs:CountrySubdivisionType"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">For representation of a Countries subdivisions RosettaNet has adopted ISO 3166-3; 1999. Refer to the following web page to get the latest version of the standard:
 http://www.iso.ch/iso/en/prods-services/iso3166ma/02iso-3166-code-lists/index.html

If you need more information about the ISO standard please contact ISO for more details.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PostalCode"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Identifying geographic location as specified by a national postal code.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""PostOfficeBox"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The Post Office Box identifier used to identify a party's post office box.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
</xs:schema>";
        
        public Locations() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "Location";
                _RootElements[1] = "PhysicalAddress";
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
        
        [Schema(@"urn:rosettanet:specification:universal:Locations:xsd:schema:1.0",@"Location")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Location"})]
        public sealed class Location : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Location() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Location";
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
        
        [Schema(@"urn:rosettanet:specification:universal:Locations:xsd:schema:1.0",@"PhysicalAddress")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PhysicalAddress"})]
        public sealed class PhysicalAddress : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PhysicalAddress() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PhysicalAddress";
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
