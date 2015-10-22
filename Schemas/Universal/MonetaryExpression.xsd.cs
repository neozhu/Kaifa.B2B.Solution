namespace RosettaNet.Schemas.Universal {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"FinancialAmount", @"ProductPricing", @"TaxJurisdiction"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.CodeList.RN_UnitOfMeasure", typeof(RosettaNet.Schemas.Universal.CodeList.RN_UnitOfMeasure))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.DataType", typeof(RosettaNet.Schemas.Universal.DataType))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.CodeList.ISO_Country", typeof(RosettaNet.Schemas.Universal.CodeList.ISO_Country))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.CodeList.ISO_Currency", typeof(RosettaNet.Schemas.Universal.CodeList.ISO_Currency))]
    public sealed class MonetaryExpression : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:uscrn=""urn:rosettanet:specification:universal:Currency:xsd:codelist:1.0"" xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"" xmlns:uscnt=""urn:rosettanet:specification:universal:Country:xsd:codelist:1.0"" xmlns:tns=""urn:rosettanet:specification:universal:MonetaryExpression:xsd:schema:1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:udtyp=""urn:rosettanet:specification:universal:DataType:xsd:schema:1.0"" xmlns:urntf=""urn:rosettanet:specification:universal:UnitOfMeasure:xsd:codelist:1.0"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""urn:rosettanet:specification:universal:MonetaryExpression:xsd:schema:1.0"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.CodeList.RN_UnitOfMeasure"" namespace=""urn:rosettanet:specification:universal:UnitOfMeasure:xsd:codelist:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.DataType"" namespace=""urn:rosettanet:specification:universal:DataType:xsd:schema:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.CodeList.ISO_Country"" namespace=""urn:rosettanet:specification:universal:Country:xsd:codelist:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.CodeList.ISO_Currency"" namespace=""urn:rosettanet:specification:universal:Currency:xsd:codelist:1.0"" />
  <xs:annotation>
    <xs:documentation>
      <urss:Copyright xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">© 2004 RosettaNet. All rights reserved. No part of this publication may be reproduced, stored in a retrieval system, or transmitted, in any form or by any means, electronic, mechanical, photocopying, recording, or otherwise, without the inclusion of this copyright notice. Any derivative works must cite the copyright notice. Any public redistribution or sale of this publication or derivative works requires prior written permission of the publisher.</urss:Copyright>
      <urss:Disclaimer xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet makes no representation about the suitability of this work for any purpose or regarding any claims made by products which use it.  It is provided as is without expressed or implied warranty.</urss:Disclaimer>
      <urss:Program xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Domain Model Foundational Program</urss:Program>
      <urss:Purpose xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Collection of financial and tax structures.</urss:Purpose>
    </xs:documentation>
    <xs:appinfo>
      <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
      <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""urn:rosettanet:specification:universal:DataType:xsd:schema:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:Country:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:Currency:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:UnitOfMeasure:xsd:codelist:1.0"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""FinancialAmount"" type=""tns:FinancialAmountType"" />
  <xs:element name=""ProductPricing"" type=""tns:ProductPricingType"" />
  <xs:element name=""TaxJurisdiction"" type=""tns:TaxJurisdictionType"" />
  <xs:complexType name=""FinancialAmountType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The business document must express financial amounts. 

</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element name=""Amount"" type=""xs:float"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Specifies the monetary amount.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element name=""Currency"" type=""uscrn:CurrencyType"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">For representation of Currency codes RosettaNet has adopted ISO 4217; 1995. The British Standards Institution (BSI) is the ISO 4217 Maintenance Agency. Refer to the following web page to get the latest version of the standard:
 http://www.bsi-global.com/Technical+Information/Publications/_Publications/tig90.xalter

If you need more information about the ISO standard please contact ISO for more details.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""ProductPricingType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The business document must contain the price of the product.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element ref=""tns:FinancialAmount"" />
      <xs:element name=""PriceUnit"" type=""urntf:UnitOfMeasureType"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Is the unit of measure for the specified price.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""TaxJurisdictionType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The business document must identify the specific tax collection authority.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
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
      <xs:element minOccurs=""0"" name=""Identifier"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Unique identification for a taxing authority.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Location"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Identification of the tax collection authority location.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Rate"" type=""udtyp:PercentAmountType"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A number representing a percentage value, e.g. 75.125 represents 75 1/8 percent.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
</xs:schema>";
        
        public MonetaryExpression() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [3];
                _RootElements[0] = "FinancialAmount";
                _RootElements[1] = "ProductPricing";
                _RootElements[2] = "TaxJurisdiction";
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
        
        [Schema(@"urn:rosettanet:specification:universal:MonetaryExpression:xsd:schema:1.0",@"FinancialAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"FinancialAmount"})]
        public sealed class FinancialAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public FinancialAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "FinancialAmount";
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
        
        [Schema(@"urn:rosettanet:specification:universal:MonetaryExpression:xsd:schema:1.0",@"ProductPricing")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ProductPricing"})]
        public sealed class ProductPricing : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ProductPricing() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ProductPricing";
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
        
        [Schema(@"urn:rosettanet:specification:universal:MonetaryExpression:xsd:schema:1.0",@"TaxJurisdiction")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaxJurisdiction"})]
        public sealed class TaxJurisdiction : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaxJurisdiction() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaxJurisdiction";
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
