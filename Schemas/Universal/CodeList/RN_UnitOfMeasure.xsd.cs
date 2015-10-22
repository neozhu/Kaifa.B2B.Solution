namespace RosettaNet.Schemas.Universal.CodeList {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"UnitOfMeasureA", @"UnitOfMeasure"})]
    public sealed class RN_UnitOfMeasure : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""urn:rosettanet:specification:universal:UnitOfMeasure:xsd:codelist:1.0"" xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""urn:rosettanet:specification:universal:UnitOfMeasure:xsd:codelist:1.0"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:documentation>
      <urss:Copyright xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">© 2004 RosettaNet. All rights reserved. No part of this publication may be reproduced, stored in a retrieval system, or transmitted, in any form or by any means, electronic, mechanical, photocopying, recording, or otherwise, without the inclusion of this copyright notice. Any derivative works must cite the copyright notice. Any public redistribution or sale of this publication or derivative works requires prior written permission of the publisher.</urss:Copyright>
      <urss:Disclaimer xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet makes no representation about the suitability of this work for any purpose or regarding any claims made by products which use it.  It is provided as is without expressed or implied warranty.</urss:Disclaimer>
      <urss:Program xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Domain Model Foundational Program</urss:Program>
      <urss:Purpose xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Provides the RosettaNet Unit of Measure codes.</urss:Purpose>
    </xs:documentation>
    <xs:appinfo>
      <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
      <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
    </xs:appinfo>
  </xs:annotation>
  <xs:element abstract=""true"" name=""UnitOfMeasureA"" type=""xs:anyType"" />
  <xs:element name=""UnitOfMeasure"" substitutionGroup=""tns:UnitOfMeasureA"" type=""tns:UnitOfMeasureType"" />
  <xs:simpleType name=""UnitOfMeasureContentType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Code identifying a product unit of measure.</urss:Definition>
        <urss:Identifier xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">urntf:UnitOfMeasureType</urss:Identifier>
        <urss:RegisteredBy xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet</urss:RegisteredBy>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:restriction base=""xs:token"">
      <xs:enumeration value=""1BF"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">100 Board Feet</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""1FC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">20 Foot Container</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""1GR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Gram/Cubic Centimeter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""1GT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">10,000 Gallon Tankcar</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""1KB"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">25 Kilogram Bulk Bag</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""1KD"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">10 Kilogram Drum</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""1PA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">20-Pack</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""1PB"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">50 Pound Bag</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""1PD"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">100 Pound Drum</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""2FC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">40 Foot Container</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""2GR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Gram/square meter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""2GT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">20,000 Gallon Tankcar</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""2KB"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">300 Kilogram Bulk Bag</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""2KD"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">15 Kilogram Drum</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""2PA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">100-Pack</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""3GR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Grams Per 100 Centimeters</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""3KB"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">500 Kilogram Bulk Bag</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""3KD"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">55 Gallon Drum</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""4GR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Grams Per 100 Grams</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""4KD"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">115 Kilogram Drum</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""5GR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Grams Per Cubic Centimeter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""6GR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Grams Per Square Centimeter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""7GR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Grams Per Square Meter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""ACR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Acre</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""ACT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Actual Pounds</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""ALU"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Aluminum Pounds Only</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""AMP"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Ampere</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BAB"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Base Box</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BAC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Batch</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BAE"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Bale</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BAG"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Bag</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BAL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Ball</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BAN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Band</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BAP"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Batting Pound</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BAR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Bar</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BAS"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Basket</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BAT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Batt</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BAW"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Base Weight</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BEA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Beam</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BEC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Becquerel/kilogram</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BEL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Belt</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BIL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Billet</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BIN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Bin</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BKC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Bulk Car Load</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BLO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Block</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BOA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Board</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BOF"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Board Feet</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BOL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Bolt</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BOT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Bottle</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BOX"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Box</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BRD"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Barrels Per Day</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BRE"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Barrel</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BRI"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Barrel (Imperial)</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BRM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Barrels Per Minute</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BTF"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">British Thermal Units (BTUs) Per Cubic Foot</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BTP"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">British Thermal Units (BTUs) Per Pound</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BTU"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">British Thermal Unit (BTU)</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BUC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Bucket</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BUD"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Bushel, Dry Imperial</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BUK"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Bunks</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BUL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Bulk</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BUN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Bundle</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BUP"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Bulk Pack</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""BUS"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Bushel</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CAA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Carat</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CAB"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Carboy</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CAC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Card</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CAD"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Candela</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CAG"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Cartridge</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CAK"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Cask</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CAL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Calorie</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CAN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Can</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CAO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Carload</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CAR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Car</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CAS"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Case</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CAT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Canister</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CAW"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Catchweight</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CEL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Cell</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CEM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Centimeter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CEP"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Centipoise (CPS)</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CET"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Centiliter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CHA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Chains (Land Survey)</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CHE"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Chest</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CNN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Connector</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""COG"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Coil Group</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""COI"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Coil</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""COM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Composite Product Pounds (Total Weight)</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CON"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Cone</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""COT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Container</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""COV"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Cover</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CRA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Crate</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CRT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Carton</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CSE"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Cassette</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CUB"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Cubic centimeter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CUC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Cubic centimeter/second</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CUF"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Cubic Foot</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CUI"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Cubic inch</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CUM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Cubicmeter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CUP"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Cup</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CUY"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Cubic yard</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CYC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Cycles</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""CYL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Cylinder</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""DAY"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Day</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""DEA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Deal</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""DEC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Decimeter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""DEF"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Degree Fahrenheit</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""DEG"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Degree Celsius</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""DEP"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Dep. Factor</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""DIE"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Die</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""DIL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Display</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""DIP"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Dispenser</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""DOZ"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Dozen</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""DRA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Dram</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""DRU"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Drum</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""DRY"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Dry Pounds</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""EAC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Each</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""ELE"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Electrical Capacitance</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""FLO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Fluid Ounce</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""FOI"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Fluid Ounce (Imperial)</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""FOO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Foot</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""FOU"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Fluid Ounce US</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""FUU"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Fuel Usage (Gallons)</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""GAL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Gallon</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""GAS"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Gage Systems</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""GIJ"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Gigajoules</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""GIL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Gill (Imperial)</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""GOB"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Gross Barrels</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""GOG"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Gross Gallons</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""GOK"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Gross Kilogram</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""GOT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Gross Ton</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""GOY"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Gross Yard</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""GRA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Gram</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""GRG"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Great Gross (Dozen Gross)</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""GRK"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Grams Per Kilogram</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""GRL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Grams Per Liter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""GRM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Grams Per Milliliter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""GRN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Grain</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""GRO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Gross</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""GRP"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Group</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""HAG"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Half Gallon</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""HAH"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Half Hour</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""HAL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Half Liter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""HAN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Hank</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""HEA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Heat lots</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""HEC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Hectare</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""HEL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Hectoliter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""HEP"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Hectopascal</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""HER"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Hertz</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""HOS"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Hours</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""HOU"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Hour</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""HUA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Hundredth of a Carat</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""HUB"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Hundred Boxes</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""HUC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Hundred Count</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""HUS"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Hundred Sheets</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""IMG"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Imperial Gallons</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""INC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Inch</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""JAR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Jar</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""JOI"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Joint</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""JOU"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Joule</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""KEG"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Keg</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""KEL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Kelvin</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""KHO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Kilometer/hour</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""KIC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Kilogram per cubic meter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""KIE"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Kilometer</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""KIG"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Kilogram</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""KIH"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Kilohertz</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""KIK"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Kilobecquerel/Kilogram</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""KIL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Kiloampere</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""KIM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Kilogram/square meter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""KIO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Kiloohm</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""KIS"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Kilogramm pro Sekunde</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""KIT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Kit</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""KIV"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Kilovolt</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""KIW"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Kilowatt</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""KKG"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Kilogram/Kilogram</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""KUD"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Kubikdezimeter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""KUM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Kubikmeter pro Sekunde</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""KWH"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Kilowatt-hour</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""LIF"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Lifts</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""LIM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Link</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""LIQ"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Liquid Pounds</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""LIT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Liter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""LOA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Load</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""LOT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Lot</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""LUG"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Lug</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MAT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Mat</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MCM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Milligrams Per Cubic Meter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MEG"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Megagram</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MEH"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Megahertz</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MEP"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Megapascal</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MET"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Meter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MEW"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Megawatt</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MIB"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Million BTU's</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MIC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Mikrogram/cubic meter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MIG"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Micrograms Per Cubic Meter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MIL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Mile</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MIM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Micrometer</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MIN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Minute</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MIP"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Millipascal seconds</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MIS"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Microsecond</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MIT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Miter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MIV"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Millivolt</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MIW"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Milliwatt</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MJO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Millijoule</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MLA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Milliampere</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MLB"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Millibar</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MLC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Milligram/cubic meter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MLI"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Milliliter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MLK"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Milligram/kilogram</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MLL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Milligram/Liter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MME"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Millimeter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MMH"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Millimeter H20</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MMK"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Millimol/kilogram</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MMO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Millimol</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MOK"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Mol/kilogram</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MOL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Mol</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MON"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Month</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MPH"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Megagrams Per Hour</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MSC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Millisecond</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MSM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Milligrams Per Square Meter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MTA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Millitesla</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MTQ"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Meter pro Quadratsekunde</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MTS"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Meters per second</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""MUL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Multichip - When 2 or more dies (chips) are merged into one package.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""NAM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Nanometer</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""NAS"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Nanosecond</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""NEB"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Net Barrels</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""NEG"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Net Gallons</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""NEI"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Net Imperial Gallons</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""NEL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Net Liters</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""NEW"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Newton</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""OHM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Ohm</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""ONE"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">One</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""OTP"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">One Thousand Pieces</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""OUN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Ounce</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PAC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Parcel</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PAD"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Pad</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PAG"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Package</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PAI"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Pail</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PAK"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Pack (PAK)</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PAL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Pallet</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PAN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Panel</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PAR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Pair</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PAS"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Pascal</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PAT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Packet</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PEC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Percent</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PEG"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Percentage</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PEH"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Percent Per 1000 Hours</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PEN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Pennyweight</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PER"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Per Hundred Pieces</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PEW"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Percent Weight</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PID"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Pint U.S. Dry</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PIE"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Piece</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PIL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Pint - US liquid</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PLA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Plate</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PLL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Pallet (Lift)</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PLT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Pallete</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PLU"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Pallet/Unit Load</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""POF"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Pounds Per Foot</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""POG"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Pounds Per Gallon</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PON"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Pound</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""POP"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Pounds Per Piece of Product</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""POS"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Pounds Per 1000 Square Feet</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""POT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Pounds Per Thousand</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PPB"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Parts per billion (US)</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PPM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Parts per million</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PPP"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Pounds Per Pound of Product</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""PSS"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Pascal second</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""QUA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Quart - US liquid</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""RAC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Rack</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""REA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Ream of 500 Sheets</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""REE"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Reel</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""RIN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Ring</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""ROD"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Rod</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""ROL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Roll</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SAC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Sack</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SBB"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Super Bulk Bag</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SEC"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Second</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SET"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Set</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SHE"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Sheet</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SHI"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Shipment</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SHM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Sheet-Metric measure</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SHO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Shot</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SID"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Disk (Disc)</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SKE"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Skein</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SKI"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Skid</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SLE"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Sleeve</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SLI"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Slip Sheet</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SMI"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Square mile</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SMM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Square millimeter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SPO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Spool</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SQF"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Square foot</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SQI"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Square inch</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SQK"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Square kilometer</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SQM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Square meter</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SQS"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Square meter/second</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SQU"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Square</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""SQY"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Square Yard</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""STI"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Stick</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""STM"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Statute Mile</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""STR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Strip</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""TAB"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Tablet</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""TAN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Tank</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""TAT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Tank Truck</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""TES"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Tesla</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""THO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Thousand</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""TNN"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Tonne</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""TON"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Ton</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""TOR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Torr</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""TOT"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Tote</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""TRA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Train</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""TRF"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Track Foot</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""TRL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Trailer</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""TRO"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Troy</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""TRU"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Truckload</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""TRY"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Tray</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""TRZ"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Troy OZ</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""TUB"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Tube</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""ULU"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Unitless Unit of Measure</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""USG"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">US gallon</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""USP"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">US pound</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""UST"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">US ton</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""VIA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Vial</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""VOL"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Volt</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""WAF"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Wafer</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""WAR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Watt</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""WEE"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Week</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""WRA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Wrap</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""YAR"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Yard</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
      <xs:enumeration value=""YEA"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Year</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:enumeration>
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""UnitOfMeasureType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Identifier xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">UnitOfMeasureType</urss:Identifier>
        <urss:RegisteredBy xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet</urss:RegisteredBy>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:simpleContent>
      <xs:extension base=""tns:UnitOfMeasureContentType"">
        <xs:attribute fixed=""UnitOfMeasure"" name=""identifier"" type=""xs:token"" />
        <xs:attribute fixed=""1.0"" name=""codeListVersion"" type=""xs:token"" />
        <xs:attribute fixed=""RosettaNet"" name=""agency"" type=""xs:token"" />
        <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
</xs:schema>";
        
        public RN_UnitOfMeasure() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "UnitOfMeasureA";
                _RootElements[1] = "UnitOfMeasure";
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
        
        [Schema(@"urn:rosettanet:specification:universal:UnitOfMeasure:xsd:codelist:1.0",@"UnitOfMeasureA")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"UnitOfMeasureA"})]
        public sealed class UnitOfMeasureA : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public UnitOfMeasureA() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "UnitOfMeasureA";
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
        
        [Schema(@"urn:rosettanet:specification:universal:UnitOfMeasure:xsd:codelist:1.0",@"UnitOfMeasure")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"UnitOfMeasure"})]
        public sealed class UnitOfMeasure : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public UnitOfMeasure() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "UnitOfMeasure";
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
