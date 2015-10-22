namespace RosettaNet.Schemas.Domain.SalesReporting.CodeList {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"TotalQualifierA", @"TotalQualifier"})]
    public sealed class RN_TotalQualifier : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""urn:rosettanet:specification:domain:TotalQualifier:xsd:codelist:1.0"" xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""urn:rosettanet:specification:domain:TotalQualifier:xsd:codelist:1.0"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:documentation>
      <urss:Copyright xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">© 2004 RosettaNet. All rights reserved. No part of this publication may be reproduced, stored in a retrieval system, or transmitted, in any form or by any means, electronic, mechanical, photocopying, recording, or otherwise, without the inclusion of this copyright notice. Any derivative works must cite the copyright notice. Any public redistribution or sale of this publication or derivative works requires prior written permission of the publisher.</urss:Copyright>
      <urss:Disclaimer xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet makes no representation about the suitability of this work for any purpose or regarding any claims made by products which use it.  It is provided as is without expressed or implied warranty.</urss:Disclaimer>
      <urss:Program xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Sales Reporting Milestone Program</urss:Program>
      <urss:Purpose xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Provides the Sales reporting Total Qualifier codes.</urss:Purpose>
    </xs:documentation>
    <xs:appinfo>
      <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
      <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
    </xs:appinfo>
  </xs:annotation>
  <xs:element abstract=""true"" name=""TotalQualifierA"" type=""xs:anyType"" />
  <xs:element name=""TotalQualifier"" substitutionGroup=""tns:TotalQualifierA"" type=""tns:TotalQualifierType"" />
  <xs:simpleType name=""TotalQualifierContentType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A code that qualifies a total.</urss:Definition>
        <urss:Identifier xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">drtqf:TotalQualifierType</urss:Identifier>
        <urss:RegisteredBy xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet</urss:RegisteredBy>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:restriction base=""xs:token"">
      <xs:enumeration value=""SLU"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Total units sold</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SLE"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Total units sold to end users</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SIU"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Total sell-in</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SIM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Total sell-in from manufacturer</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""TotalQualifierType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Identifier xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">TotalQualifierType</urss:Identifier>
        <urss:RegisteredBy xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet</urss:RegisteredBy>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:simpleContent>
      <xs:extension base=""tns:TotalQualifierContentType"">
        <xs:attribute fixed=""TotalQualifier"" name=""identifier"" type=""xs:token"" />
        <xs:attribute fixed=""1.0"" name=""codeListVersion"" type=""xs:token"" />
        <xs:attribute fixed=""RosettaNet"" name=""agency"" type=""xs:token"" />
        <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
</xs:schema>";
        
        public RN_TotalQualifier() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "TotalQualifierA";
                _RootElements[1] = "TotalQualifier";
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
        
        [Schema(@"urn:rosettanet:specification:domain:TotalQualifier:xsd:codelist:1.0",@"TotalQualifierA")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TotalQualifierA"})]
        public sealed class TotalQualifierA : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TotalQualifierA() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TotalQualifierA";
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
        
        [Schema(@"urn:rosettanet:specification:domain:TotalQualifier:xsd:codelist:1.0",@"TotalQualifier")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TotalQualifier"})]
        public sealed class TotalQualifier : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TotalQualifier() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TotalQualifier";
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
