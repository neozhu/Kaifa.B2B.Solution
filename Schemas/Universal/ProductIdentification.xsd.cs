namespace RosettaNet.Schemas.Universal {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"urn:rosettanet:specification:universal:ProductIdentification:xsd:schema:1.0",@"ProductIdentification")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ProductIdentification"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.AbstractType", typeof(RosettaNet.Schemas.Universal.AbstractType))]
    public sealed class ProductIdentification : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""urn:rosettanet:specification:universal:ProductIdentification:xsd:schema:1.0"" xmlns:ubtcy=""urn:rosettanet:specification:universal:AbstractType:xsd:schema:1.0"" xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""urn:rosettanet:specification:universal:ProductIdentification:xsd:schema:1.0"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.AbstractType"" namespace=""urn:rosettanet:specification:universal:AbstractType:xsd:schema:1.0"" />
  <xs:annotation>
    <xs:documentation>
      <urss:Copyright xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">© 2004 RosettaNet. All rights reserved. No part of this publication may be reproduced, stored in a retrieval system, or transmitted, in any form or by any means, electronic, mechanical, photocopying, recording, or otherwise, without the inclusion of this copyright notice. Any derivative works must cite the copyright notice. Any public redistribution or sale of this publication or derivative works requires prior written permission of the publisher.</urss:Copyright>
      <urss:Disclaimer xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet makes no representation about the suitability of this work for any purpose or regarding any claims made by products which use it.  It is provided as is without expressed or implied warranty.</urss:Disclaimer>
      <urss:Program xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Domain Model Foundational Program</urss:Program>
      <urss:Purpose xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Collection of all Product Identifiaction structures.</urss:Purpose>
    </xs:documentation>
    <xs:appinfo>
      <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
      <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""urn:rosettanet:specification:universal:AbstractType:xsd:schema:1.0"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""ProductIdentification"" type=""tns:ProductIdentificationType"" />
  <xs:complexType name=""ProductIdentificationType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The object provides the identifier(s) of a product.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexContent mixed=""false"">
      <xs:extension base=""ubtcy:IdentifierType"">
        <xs:sequence>
          <xs:element name=""Identifier"" type=""xs:string"">
            <xs:annotation>
              <xs:appinfo>
                <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Identifies the product.</urss:Definition>
              </xs:appinfo>
            </xs:annotation>
          </xs:element>
          <xs:element name=""IdentifierAuthority"" type=""xs:string"">
            <xs:annotation>
              <xs:appinfo>
                <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The controlling agency which manages the product identifier.</urss:Definition>
              </xs:appinfo>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" name=""Revision"" type=""xs:string"">
            <xs:annotation>
              <xs:appinfo>
                <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Referenced the specified product revision.</urss:Definition>
              </xs:appinfo>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
</xs:schema>";
        
        public ProductIdentification() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ProductIdentification";
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
