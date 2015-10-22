namespace RosettaNet.Schemas.Universal {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Contact", @"Duns", @"DunsPlus4", @"PercentAmount", @"ReceiverIdentifier", @"SenderIdentifier"})]
    public sealed class DataType : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""urn:rosettanet:specification:universal:DataType:xsd:schema:1.0"" xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""urn:rosettanet:specification:universal:DataType:xsd:schema:1.0"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:documentation>
      <urss:Copyright xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">© 2004 RosettaNet. All rights reserved. No part of this publication may be reproduced, stored in a retrieval system, or transmitted, in any form or by any means, electronic, mechanical, photocopying, recording, or otherwise, without the inclusion of this copyright notice. Any derivative works must cite the copyright notice. Any public redistribution or sale of this publication or derivative works requires prior written permission of the publisher.</urss:Copyright>
      <urss:Disclaimer xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet makes no representation about the suitability of this work for any purpose or regarding any claims made by products which use it.  It is provided as is without expressed or implied warranty.</urss:Disclaimer>
      <urss:Program xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Domain Model Foundational Program</urss:Program>
      <urss:Purpose xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Collection of basic elements.</urss:Purpose>
    </xs:documentation>
    <xs:appinfo>
      <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
      <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Contact"" type=""tns:ContactType"" />
  <xs:element name=""Duns"" type=""tns:DunsType"" />
  <xs:element name=""DunsPlus4"" type=""tns:DunsPlus4Type"" />
  <xs:element name=""PercentAmount"" type=""tns:PercentAmountType"" />
  <xs:element name=""ReceiverIdentifier"" type=""tns:ReceiverIdentifierType"" />
  <xs:element name=""SenderIdentifier"" type=""tns:SenderIdentifierType"" />
  <xs:simpleType name=""ContactType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The name of the department, service or individual to be contacted within the organization.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""DunsType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A number assigned by Dun and Bradstreet to identify a business location.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""[0-9]{9}"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">[0-9]{9}</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:pattern>
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""DunsPlus4Type"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A identifier to specify a specific location within a business location.
</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""[0-9]{9}[.]{1,4}"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">[0-9]{9}[.]{1,4}</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:pattern>
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""PercentAmountType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A number representing a percentage value, e.g. 75.125 represents 75 1/8 percent.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:restriction base=""xs:decimal"">
      <xs:totalDigits value=""6"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">6</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:totalDigits>
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""ReceiverIdentifierType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A receiver assigned identifier.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""SenderIdentifierType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A sender assigned identifier.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
</xs:schema>";
        
        public DataType() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [6];
                _RootElements[0] = "Contact";
                _RootElements[1] = "Duns";
                _RootElements[2] = "DunsPlus4";
                _RootElements[3] = "PercentAmount";
                _RootElements[4] = "ReceiverIdentifier";
                _RootElements[5] = "SenderIdentifier";
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
        
        [Schema(@"urn:rosettanet:specification:universal:DataType:xsd:schema:1.0",@"Contact")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Contact"})]
        public sealed class Contact : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Contact() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Contact";
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
        
        [Schema(@"urn:rosettanet:specification:universal:DataType:xsd:schema:1.0",@"Duns")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Duns"})]
        public sealed class Duns : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Duns() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Duns";
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
        
        [Schema(@"urn:rosettanet:specification:universal:DataType:xsd:schema:1.0",@"DunsPlus4")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DunsPlus4"})]
        public sealed class DunsPlus4 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DunsPlus4() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DunsPlus4";
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
        
        [Schema(@"urn:rosettanet:specification:universal:DataType:xsd:schema:1.0",@"PercentAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PercentAmount"})]
        public sealed class PercentAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PercentAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PercentAmount";
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
        
        [Schema(@"urn:rosettanet:specification:universal:DataType:xsd:schema:1.0",@"ReceiverIdentifier")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ReceiverIdentifier"})]
        public sealed class ReceiverIdentifier : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ReceiverIdentifier() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ReceiverIdentifier";
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
        
        [Schema(@"urn:rosettanet:specification:universal:DataType:xsd:schema:1.0",@"SenderIdentifier")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SenderIdentifier"})]
        public sealed class SenderIdentifier : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SenderIdentifier() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SenderIdentifier";
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
