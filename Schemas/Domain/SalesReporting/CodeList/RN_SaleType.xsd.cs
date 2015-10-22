namespace RosettaNet.Schemas.Domain.SalesReporting.CodeList {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SaleTypeA", @"SaleType"})]
    public sealed class RN_SaleType : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""urn:rosettanet:specification:domain:SaleType:xsd:codelist:1.0"" xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""urn:rosettanet:specification:domain:SaleType:xsd:codelist:1.0"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:documentation>
      <urss:Copyright xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">© 2004 RosettaNet. All rights reserved. No part of this publication may be reproduced, stored in a retrieval system, or transmitted, in any form or by any means, electronic, mechanical, photocopying, recording, or otherwise, without the inclusion of this copyright notice. Any derivative works must cite the copyright notice. Any public redistribution or sale of this publication or derivative works requires prior written permission of the publisher.</urss:Copyright>
      <urss:Disclaimer xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet makes no representation about the suitability of this work for any purpose or regarding any claims made by products which use it.  It is provided as is without expressed or implied warranty.</urss:Disclaimer>
      <urss:Program xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Sales Reporting Milestone Program</urss:Program>
      <urss:Purpose xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Provides the Sales Reporting Sales Type codes.</urss:Purpose>
    </xs:documentation>
    <xs:appinfo>
      <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
      <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
    </xs:appinfo>
  </xs:annotation>
  <xs:element abstract=""true"" name=""SaleTypeA"" type=""xs:anyType"" />
  <xs:element name=""SaleType"" substitutionGroup=""tns:SaleTypeA"" type=""tns:SaleTypeType"" />
  <xs:simpleType name=""SaleTypeContentType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Code identifying the type of sale terms the trading partner bought from the seller.</urss:Definition>
        <urss:Identifier xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">drnsl:SaleTypeType</urss:Identifier>
        <urss:RegisteredBy xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet</urss:RegisteredBy>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:restriction base=""xs:token"">
      <xs:enumeration value=""PUR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Product has been purchased or bought</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""LSE"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Product has been leased</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""RMK"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Product has been repackaged, refurbished, etc. and has been sold</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CSG"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Product has been re-sold</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""SaleTypeType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Identifier xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">SaleTypeType</urss:Identifier>
        <urss:RegisteredBy xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet</urss:RegisteredBy>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:simpleContent>
      <xs:extension base=""tns:SaleTypeContentType"">
        <xs:attribute fixed=""SaleType"" name=""identifier"" type=""xs:token"" />
        <xs:attribute fixed=""1.0"" name=""codeListVersion"" type=""xs:token"" />
        <xs:attribute fixed=""RosettaNet"" name=""agency"" type=""xs:token"" />
        <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
</xs:schema>";
        
        public RN_SaleType() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "SaleTypeA";
                _RootElements[1] = "SaleType";
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
        
        [Schema(@"urn:rosettanet:specification:domain:SaleType:xsd:codelist:1.0",@"SaleTypeA")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SaleTypeA"})]
        public sealed class SaleTypeA : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SaleTypeA() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SaleTypeA";
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
        
        [Schema(@"urn:rosettanet:specification:domain:SaleType:xsd:codelist:1.0",@"SaleType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SaleType"})]
        public sealed class SaleType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SaleType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SaleType";
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
