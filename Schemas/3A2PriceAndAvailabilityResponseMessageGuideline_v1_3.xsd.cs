namespace Microsoft.Solutions.BTARN.Schemas.RNPIPs {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd",@"Pip3A2PriceAndAvailabilityResponse")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "fromRole.PartnerRoleDescription.PartnerDescription.BusinessDescription.GlobalBusinessIdentifier", XPath = @"/*[local-name()='Pip3A2PriceAndAvailabilityResponse' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']/*[local-name()='fromRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "toRole.PartnerRoleDescription.PartnerDescription.BusinessDescription.GlobalBusinessIdentifier", XPath = @"/*[local-name()='Pip3A2PriceAndAvailabilityResponse' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']/*[local-name()='toRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Pip3A2PriceAndAvailabilityResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Microsoft.Solutions.BTARN.Schemas.RNPIPs.xml", typeof(Microsoft.Solutions.BTARN.Schemas.RNPIPs.xml))]
    public sealed class _3A2PriceAndAvailabilityResponseMessageGuideline_v1_3 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns0=""http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Microsoft.Solutions.BTARN.Schemas.RNPIPs.xml"" namespace=""http://www.w3.org/XML/1998/namespace"" />
  <xs:annotation>
    <xs:appinfo>
      <schemaInfo displayroot_reference=""Pip3A2PriceAndAvailabilityResponse"" root_reference=""Pip3A2PriceAndAvailabilityResponse"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
      <b:references>
        <b:reference targetNamespace=""http://www.w3.org/XML/1998/namespace"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""ProductLineItem"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProductQuantity"" />
        <xs:element ref=""ns0:productUnit"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:LineNumber"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalProductIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""14"" />
        <xs:maxLength value=""14"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""CommunicationsNumber"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:maxLength value=""30"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""FreeFormText"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute ref=""xml:lang"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""thisDocumentGenerationDateTime"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:DateTimeStamp"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""regionName"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ProductPackageDescription"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalProductStatusCode"" />
        <xs:element ref=""ns0:unitPrice"" />
        <xs:element ref=""ns0:ProductIdentification"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""productUnit"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProductPackageDescription"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ProprietaryDocumentIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""GlobalPricingTypeCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""PartnerProductIdentification"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:GlobalPartnerClassificationCode"" />
        <xs:element ref=""ns0:ProprietaryProductIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element default=""0000000000000"" name=""GlobalLocationIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:integer"">
        <xs:minInclusive value=""0000000000000"" />
        <xs:maxInclusive value=""9999999999999"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""GlobalBusinessIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:pattern value=""^[0-9]{9}$"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""DateTimeStamp"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""13"" />
        <xs:maxLength value=""20"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""GlobalPartnerClassificationCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Carrier"" />
        <xs:enumeration value=""Distributor"" />
        <xs:enumeration value=""End User"" />
        <xs:enumeration value=""End User Government"" />
        <xs:enumeration value=""Financier"" />
        <xs:enumeration value=""Manufacturer"" />
        <xs:enumeration value=""Retailer"" />
        <xs:enumeration value=""Shopper"" />
        <xs:enumeration value=""Freight Forwarder"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""PhysicalAddress"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalLocationIdentifier"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:cityName"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:addressLine1"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:addressLine2"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:addressLine3"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalCountryCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:NationalPostalCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:regionName"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalCurrencyCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""3"" />
        <xs:maxLength value=""3"" />
        <xs:enumeration value=""XCD"" />
        <xs:enumeration value=""AFA"" />
        <xs:enumeration value=""ALL"" />
        <xs:enumeration value=""DZD"" />
        <xs:enumeration value=""USD"" />
        <xs:enumeration value=""ESP"" />
        <xs:enumeration value=""AON"" />
        <xs:enumeration value=""XCD"" />
        <xs:enumeration value=""ARS"" />
        <xs:enumeration value=""AMD"" />
        <xs:enumeration value=""AWG"" />
        <xs:enumeration value=""AUD"" />
        <xs:enumeration value=""ATS"" />
        <xs:enumeration value=""AZM"" />
        <xs:enumeration value=""BSD"" />
        <xs:enumeration value=""BHD"" />
        <xs:enumeration value=""BDT"" />
        <xs:enumeration value=""BBD"" />
        <xs:enumeration value=""BYB"" />
        <xs:enumeration value=""BEF"" />
        <xs:enumeration value=""BZD"" />
        <xs:enumeration value=""XOF"" />
        <xs:enumeration value=""BMD"" />
        <xs:enumeration value=""INR"" />
        <xs:enumeration value=""BOB"" />
        <xs:enumeration value=""BAM"" />
        <xs:enumeration value=""BWP"" />
        <xs:enumeration value=""NOK"" />
        <xs:enumeration value=""BRL"" />
        <xs:enumeration value=""USD"" />
        <xs:enumeration value=""BND"" />
        <xs:enumeration value=""BGL"" />
        <xs:enumeration value=""XOF"" />
        <xs:enumeration value=""BIF"" />
        <xs:enumeration value=""KHR"" />
        <xs:enumeration value=""XAF"" />
        <xs:enumeration value=""CAD"" />
        <xs:enumeration value=""CVE"" />
        <xs:enumeration value=""KYD"" />
        <xs:enumeration value=""XAF"" />
        <xs:enumeration value=""XAF"" />
        <xs:enumeration value=""CLP"" />
        <xs:enumeration value=""CNY"" />
        <xs:enumeration value=""AUD"" />
        <xs:enumeration value=""AUD"" />
        <xs:enumeration value=""COP"" />
        <xs:enumeration value=""KMF"" />
        <xs:enumeration value=""XAF"" />
        <xs:enumeration value=""NZD"" />
        <xs:enumeration value=""CRC"" />
        <xs:enumeration value=""XOF"" />
        <xs:enumeration value=""HRK"" />
        <xs:enumeration value=""CUP"" />
        <xs:enumeration value=""CYP"" />
        <xs:enumeration value=""CZK"" />
        <xs:enumeration value=""AOR"" />
        <xs:enumeration value=""FRF"" />
        <xs:enumeration value=""ADP"" />
        <xs:enumeration value=""BTN"" />
        <xs:enumeration value=""BOV"" />
        <xs:enumeration value=""ISK"" />
        <xs:enumeration value=""INR"" />
        <xs:enumeration value=""IDR"" />
        <xs:enumeration value=""XDR"" />
        <xs:enumeration value=""IRR"" />
        <xs:enumeration value=""IQD"" />
        <xs:enumeration value=""IEP"" />
        <xs:enumeration value=""ILS"" />
        <xs:enumeration value=""ITL"" />
        <xs:enumeration value=""JMD"" />
        <xs:enumeration value=""JPY"" />
        <xs:enumeration value=""JOD"" />
        <xs:enumeration value=""KZT"" />
        <xs:enumeration value=""KES"" />
        <xs:enumeration value=""AUD"" />
        <xs:enumeration value=""KPW"" />
        <xs:enumeration value=""KRW"" />
        <xs:enumeration value=""KWD"" />
        <xs:enumeration value=""KGS"" />
        <xs:enumeration value=""LAK"" />
        <xs:enumeration value=""LVL"" />
        <xs:enumeration value=""LBP"" />
        <xs:enumeration value=""ZAR"" />
        <xs:enumeration value=""LRD"" />
        <xs:enumeration value=""LYD"" />
        <xs:enumeration value=""CHF"" />
        <xs:enumeration value=""LTL"" />
        <xs:enumeration value=""LUF"" />
        <xs:enumeration value=""MOP"" />
        <xs:enumeration value=""MKD"" />
        <xs:enumeration value=""MGF"" />
        <xs:enumeration value=""MWK"" />
        <xs:enumeration value=""MYR"" />
        <xs:enumeration value=""MVR"" />
        <xs:enumeration value=""XOF"" />
        <xs:enumeration value=""MTL"" />
        <xs:enumeration value=""USD"" />
        <xs:enumeration value=""FRF"" />
        <xs:enumeration value=""MRO"" />
        <xs:enumeration value=""MUR"" />
        <xs:enumeration value=""MXN"" />
        <xs:enumeration value=""USD"" />
        <xs:enumeration value=""MDL"" />
        <xs:enumeration value=""FRF"" />
        <xs:enumeration value=""MNT"" />
        <xs:enumeration value=""XCD"" />
        <xs:enumeration value=""MAD"" />
        <xs:enumeration value=""MZM"" />
        <xs:enumeration value=""MMK"" />
        <xs:enumeration value=""ZAR"" />
        <xs:enumeration value=""AUD"" />
        <xs:enumeration value=""NPR"" />
        <xs:enumeration value=""NLG"" />
        <xs:enumeration value=""ANG"" />
        <xs:enumeration value=""XPF"" />
        <xs:enumeration value=""NZD"" />
        <xs:enumeration value=""NIO"" />
        <xs:enumeration value=""XOF"" />
        <xs:enumeration value=""NGN"" />
        <xs:enumeration value=""NZD"" />
        <xs:enumeration value=""AUD"" />
        <xs:enumeration value=""USD"" />
        <xs:enumeration value=""NOK"" />
        <xs:enumeration value=""OMR"" />
        <xs:enumeration value=""PKR"" />
        <xs:enumeration value=""USD"" />
        <xs:enumeration value=""PAB"" />
        <xs:enumeration value=""PGK"" />
        <xs:enumeration value=""PYG"" />
        <xs:enumeration value=""PEN"" />
        <xs:enumeration value=""PHP"" />
        <xs:enumeration value=""NZD"" />
        <xs:enumeration value=""PLN"" />
        <xs:enumeration value=""PTE"" />
        <xs:enumeration value=""USD"" />
        <xs:enumeration value=""QAR"" />
        <xs:enumeration value=""FRF"" />
        <xs:enumeration value=""ROL"" />
        <xs:enumeration value=""RUR"" />
        <xs:enumeration value=""RWF"" />
        <xs:enumeration value=""SHP"" />
        <xs:enumeration value=""XCD"" />
        <xs:enumeration value=""XCD"" />
        <xs:enumeration value=""FRF"" />
        <xs:enumeration value=""XCD"" />
        <xs:enumeration value=""WST"" />
        <xs:enumeration value=""ITL"" />
        <xs:enumeration value=""STD"" />
        <xs:enumeration value=""SAR"" />
        <xs:enumeration value=""XOF"" />
        <xs:enumeration value=""SCR"" />
        <xs:enumeration value=""SLL"" />
        <xs:enumeration value=""SGD"" />
        <xs:enumeration value=""SKK"" />
        <xs:enumeration value=""SIT"" />
        <xs:enumeration value=""SBD"" />
        <xs:enumeration value=""SOS"" />
        <xs:enumeration value=""ZAR"" />
        <xs:enumeration value=""ESP"" />
        <xs:enumeration value=""LKR"" />
        <xs:enumeration value=""SDD"" />
        <xs:enumeration value=""SRG"" />
        <xs:enumeration value=""NOK"" />
        <xs:enumeration value=""SZL"" />
        <xs:enumeration value=""SEK"" />
        <xs:enumeration value=""CHF"" />
        <xs:enumeration value=""SYP"" />
        <xs:enumeration value=""TWD"" />
        <xs:enumeration value=""TJR"" />
        <xs:enumeration value=""TZS"" />
        <xs:enumeration value=""THB"" />
        <xs:enumeration value=""XOF"" />
        <xs:enumeration value=""NZD"" />
        <xs:enumeration value=""TOP"" />
        <xs:enumeration value=""TTD"" />
        <xs:enumeration value=""TND"" />
        <xs:enumeration value=""TRL"" />
        <xs:enumeration value=""TMM"" />
        <xs:enumeration value=""USD"" />
        <xs:enumeration value=""AUD"" />
        <xs:enumeration value=""UGX"" />
        <xs:enumeration value=""UAH"" />
        <xs:enumeration value=""AED"" />
        <xs:enumeration value=""GBP"" />
        <xs:enumeration value=""USD"" />
        <xs:enumeration value=""USD"" />
        <xs:enumeration value=""UYU"" />
        <xs:enumeration value=""UZS"" />
        <xs:enumeration value=""VUV"" />
        <xs:enumeration value=""ITL"" />
        <xs:enumeration value=""VEB"" />
        <xs:enumeration value=""VND"" />
        <xs:enumeration value=""USD"" />
        <xs:enumeration value=""USD"" />
        <xs:enumeration value=""XPF"" />
        <xs:enumeration value=""MAD"" />
        <xs:enumeration value=""YER"" />
        <xs:enumeration value=""YUM"" />
        <xs:enumeration value=""ZRN"" />
        <xs:enumeration value=""ZMK"" />
        <xs:enumeration value=""ZWD"" />
        <xs:enumeration value=""DKK"" />
        <xs:enumeration value=""DJF"" />
        <xs:enumeration value=""XCD"" />
        <xs:enumeration value=""DOP"" />
        <xs:enumeration value=""TPE"" />
        <xs:enumeration value=""ECS"" />
        <xs:enumeration value=""EGP"" />
        <xs:enumeration value=""SVC"" />
        <xs:enumeration value=""XAF"" />
        <xs:enumeration value=""ERN"" />
        <xs:enumeration value=""EEK"" />
        <xs:enumeration value=""ETB"" />
        <xs:enumeration value=""XEU"" />
        <xs:enumeration value=""DKK"" />
        <xs:enumeration value=""FKP"" />
        <xs:enumeration value=""FJD"" />
        <xs:enumeration value=""FIM"" />
        <xs:enumeration value=""FRF"" />
        <xs:enumeration value=""FRF"" />
        <xs:enumeration value=""XPR"" />
        <xs:enumeration value=""FRF"" />
        <xs:enumeration value=""XAF"" />
        <xs:enumeration value=""GMD"" />
        <xs:enumeration value=""GEL"" />
        <xs:enumeration value=""DEM"" />
        <xs:enumeration value=""GHC"" />
        <xs:enumeration value=""GIP"" />
        <xs:enumeration value=""GRD"" />
        <xs:enumeration value=""DKK"" />
        <xs:enumeration value=""XCD"" />
        <xs:enumeration value=""FRF"" />
        <xs:enumeration value=""USD"" />
        <xs:enumeration value=""GTQ"" />
        <xs:enumeration value=""GNF"" />
        <xs:enumeration value=""GWP"" />
        <xs:enumeration value=""GYD"" />
        <xs:enumeration value=""HTG"" />
        <xs:enumeration value=""AUD"" />
        <xs:enumeration value=""HNL"" />
        <xs:enumeration value=""HKD"" />
        <xs:enumeration value=""HUF"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""GlobalDocumentFunctionCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Response"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""BusinessDescription"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:GlobalBusinessIdentifier"" />
        <xs:element ref=""ns0:GlobalSupplyChainCode"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalProductStatusCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Active"" />
        <xs:enumeration value=""Discontinued"" />
        <xs:enumeration value=""Invalid"" />
        <xs:enumeration value=""New product"" />
        <xs:enumeration value=""Not authorized for resale"" />
        <xs:enumeration value=""Not authorized to sell"" />
        <xs:enumeration value=""Not found"" />
        <xs:enumeration value=""Not intended for sale on-line"" />
        <xs:enumeration value=""Replaced"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""thisDocumentIdentifier"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProprietaryDocumentIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""warehouseQuantity"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProductQuantity"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ProductPriceAndAvailability"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProductLineItem"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:GlobalPricingTypeCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:WarehouseInformationResource"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element default=""0"" name=""MonetaryAmount"">
    <xs:simpleType>
      <xs:restriction base=""xs:decimal"">
        <xs:minInclusive value=""0"" />
        <xs:maxInclusive value=""999999999999999"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""PartnerDescription"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:GlobalPartnerClassificationCode"" />
        <xs:element ref=""ns0:BusinessDescription"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""toRole"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:PartnerRoleDescription"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalCountryCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""2"" />
        <xs:maxLength value=""2"" />
        <xs:enumeration value=""AF"" />
        <xs:enumeration value=""AL"" />
        <xs:enumeration value=""DZ"" />
        <xs:enumeration value=""AS"" />
        <xs:enumeration value=""AD"" />
        <xs:enumeration value=""AO"" />
        <xs:enumeration value=""AI"" />
        <xs:enumeration value=""AQ"" />
        <xs:enumeration value=""AG"" />
        <xs:enumeration value=""AR"" />
        <xs:enumeration value=""AM"" />
        <xs:enumeration value=""AW"" />
        <xs:enumeration value=""AU"" />
        <xs:enumeration value=""AT"" />
        <xs:enumeration value=""AZ"" />
        <xs:enumeration value=""BS"" />
        <xs:enumeration value=""BH"" />
        <xs:enumeration value=""BD"" />
        <xs:enumeration value=""BB"" />
        <xs:enumeration value=""BY"" />
        <xs:enumeration value=""BE"" />
        <xs:enumeration value=""BZ"" />
        <xs:enumeration value=""BJ"" />
        <xs:enumeration value=""BM"" />
        <xs:enumeration value=""BT"" />
        <xs:enumeration value=""BO"" />
        <xs:enumeration value=""BA"" />
        <xs:enumeration value=""BW"" />
        <xs:enumeration value=""BV"" />
        <xs:enumeration value=""BR"" />
        <xs:enumeration value=""IO"" />
        <xs:enumeration value=""BN"" />
        <xs:enumeration value=""BG"" />
        <xs:enumeration value=""BF"" />
        <xs:enumeration value=""BI"" />
        <xs:enumeration value=""KH"" />
        <xs:enumeration value=""CM"" />
        <xs:enumeration value=""CA"" />
        <xs:enumeration value=""CV"" />
        <xs:enumeration value=""KY"" />
        <xs:enumeration value=""CF"" />
        <xs:enumeration value=""TD"" />
        <xs:enumeration value=""CL"" />
        <xs:enumeration value=""CN"" />
        <xs:enumeration value=""CX"" />
        <xs:enumeration value=""CC"" />
        <xs:enumeration value=""CO"" />
        <xs:enumeration value=""KM"" />
        <xs:enumeration value=""CG"" />
        <xs:enumeration value=""CK"" />
        <xs:enumeration value=""CR"" />
        <xs:enumeration value=""CI"" />
        <xs:enumeration value=""HR"" />
        <xs:enumeration value=""CU"" />
        <xs:enumeration value=""CY"" />
        <xs:enumeration value=""CZ"" />
        <xs:enumeration value=""DK"" />
        <xs:enumeration value=""DJ"" />
        <xs:enumeration value=""DM"" />
        <xs:enumeration value=""DO"" />
        <xs:enumeration value=""TP"" />
        <xs:enumeration value=""EC"" />
        <xs:enumeration value=""EG"" />
        <xs:enumeration value=""SV"" />
        <xs:enumeration value=""GQ"" />
        <xs:enumeration value=""ER"" />
        <xs:enumeration value=""EE"" />
        <xs:enumeration value=""ET"" />
        <xs:enumeration value=""FK"" />
        <xs:enumeration value=""FO"" />
        <xs:enumeration value=""FJ"" />
        <xs:enumeration value=""FI"" />
        <xs:enumeration value=""FR"" />
        <xs:enumeration value=""GF"" />
        <xs:enumeration value=""PF"" />
        <xs:enumeration value=""TF"" />
        <xs:enumeration value=""GA"" />
        <xs:enumeration value=""GM"" />
        <xs:enumeration value=""GE"" />
        <xs:enumeration value=""DE"" />
        <xs:enumeration value=""GH"" />
        <xs:enumeration value=""GI"" />
        <xs:enumeration value=""GR"" />
        <xs:enumeration value=""GL"" />
        <xs:enumeration value=""GD"" />
        <xs:enumeration value=""GP"" />
        <xs:enumeration value=""GU"" />
        <xs:enumeration value=""GT"" />
        <xs:enumeration value=""GN"" />
        <xs:enumeration value=""GW"" />
        <xs:enumeration value=""GY"" />
        <xs:enumeration value=""HT"" />
        <xs:enumeration value=""HM"" />
        <xs:enumeration value=""VA"" />
        <xs:enumeration value=""HN"" />
        <xs:enumeration value=""HK"" />
        <xs:enumeration value=""HU"" />
        <xs:enumeration value=""IS"" />
        <xs:enumeration value=""IN"" />
        <xs:enumeration value=""ID"" />
        <xs:enumeration value=""IR"" />
        <xs:enumeration value=""IQ"" />
        <xs:enumeration value=""IE"" />
        <xs:enumeration value=""IL"" />
        <xs:enumeration value=""IT"" />
        <xs:enumeration value=""JM"" />
        <xs:enumeration value=""JP"" />
        <xs:enumeration value=""JO"" />
        <xs:enumeration value=""KZ"" />
        <xs:enumeration value=""KE"" />
        <xs:enumeration value=""KI"" />
        <xs:enumeration value=""KP"" />
        <xs:enumeration value=""KR"" />
        <xs:enumeration value=""KW"" />
        <xs:enumeration value=""KG"" />
        <xs:enumeration value=""LA"" />
        <xs:enumeration value=""LV"" />
        <xs:enumeration value=""LB"" />
        <xs:enumeration value=""LS"" />
        <xs:enumeration value=""LR"" />
        <xs:enumeration value=""LY"" />
        <xs:enumeration value=""LI"" />
        <xs:enumeration value=""LT"" />
        <xs:enumeration value=""LU"" />
        <xs:enumeration value=""MO"" />
        <xs:enumeration value=""MK"" />
        <xs:enumeration value=""MG"" />
        <xs:enumeration value=""MW"" />
        <xs:enumeration value=""MY"" />
        <xs:enumeration value=""MV"" />
        <xs:enumeration value=""ML"" />
        <xs:enumeration value=""MT"" />
        <xs:enumeration value=""MH"" />
        <xs:enumeration value=""MQ"" />
        <xs:enumeration value=""MR"" />
        <xs:enumeration value=""MU"" />
        <xs:enumeration value=""YT"" />
        <xs:enumeration value=""MX"" />
        <xs:enumeration value=""FM"" />
        <xs:enumeration value=""MD"" />
        <xs:enumeration value=""MC"" />
        <xs:enumeration value=""MN"" />
        <xs:enumeration value=""MS"" />
        <xs:enumeration value=""MA"" />
        <xs:enumeration value=""MZ"" />
        <xs:enumeration value=""MM"" />
        <xs:enumeration value=""NA"" />
        <xs:enumeration value=""NR"" />
        <xs:enumeration value=""NP"" />
        <xs:enumeration value=""NL"" />
        <xs:enumeration value=""AN"" />
        <xs:enumeration value=""NT"" />
        <xs:enumeration value=""NC"" />
        <xs:enumeration value=""NZ"" />
        <xs:enumeration value=""NI"" />
        <xs:enumeration value=""NE"" />
        <xs:enumeration value=""NG"" />
        <xs:enumeration value=""NU"" />
        <xs:enumeration value=""NF"" />
        <xs:enumeration value=""MP"" />
        <xs:enumeration value=""NO"" />
        <xs:enumeration value=""OM"" />
        <xs:enumeration value=""PK"" />
        <xs:enumeration value=""PW"" />
        <xs:enumeration value=""PA"" />
        <xs:enumeration value=""PG"" />
        <xs:enumeration value=""PY"" />
        <xs:enumeration value=""PE"" />
        <xs:enumeration value=""PH"" />
        <xs:enumeration value=""PN"" />
        <xs:enumeration value=""PL"" />
        <xs:enumeration value=""PT"" />
        <xs:enumeration value=""PR"" />
        <xs:enumeration value=""QA"" />
        <xs:enumeration value=""RE"" />
        <xs:enumeration value=""RO"" />
        <xs:enumeration value=""RU"" />
        <xs:enumeration value=""RW"" />
        <xs:enumeration value=""SH"" />
        <xs:enumeration value=""KN"" />
        <xs:enumeration value=""LC"" />
        <xs:enumeration value=""PM"" />
        <xs:enumeration value=""VC"" />
        <xs:enumeration value=""WS"" />
        <xs:enumeration value=""SM"" />
        <xs:enumeration value=""ST"" />
        <xs:enumeration value=""SA"" />
        <xs:enumeration value=""SN"" />
        <xs:enumeration value=""SC"" />
        <xs:enumeration value=""SL"" />
        <xs:enumeration value=""SG"" />
        <xs:enumeration value=""SK"" />
        <xs:enumeration value=""SI"" />
        <xs:enumeration value=""SB"" />
        <xs:enumeration value=""SO"" />
        <xs:enumeration value=""ZA"" />
        <xs:enumeration value=""GS"" />
        <xs:enumeration value=""ES"" />
        <xs:enumeration value=""LK"" />
        <xs:enumeration value=""SD"" />
        <xs:enumeration value=""SR"" />
        <xs:enumeration value=""SJ"" />
        <xs:enumeration value=""SZ"" />
        <xs:enumeration value=""SE"" />
        <xs:enumeration value=""CH"" />
        <xs:enumeration value=""SY"" />
        <xs:enumeration value=""TW"" />
        <xs:enumeration value=""TJ"" />
        <xs:enumeration value=""TZ"" />
        <xs:enumeration value=""TH"" />
        <xs:enumeration value=""TG"" />
        <xs:enumeration value=""TK"" />
        <xs:enumeration value=""TO"" />
        <xs:enumeration value=""TT"" />
        <xs:enumeration value=""TN"" />
        <xs:enumeration value=""TR"" />
        <xs:enumeration value=""TM"" />
        <xs:enumeration value=""TC"" />
        <xs:enumeration value=""TV"" />
        <xs:enumeration value=""UG"" />
        <xs:enumeration value=""UA"" />
        <xs:enumeration value=""AE"" />
        <xs:enumeration value=""GB"" />
        <xs:enumeration value=""US"" />
        <xs:enumeration value=""UM"" />
        <xs:enumeration value=""UY"" />
        <xs:enumeration value=""UZ"" />
        <xs:enumeration value=""VU"" />
        <xs:enumeration value=""VE"" />
        <xs:enumeration value=""VN"" />
        <xs:enumeration value=""VG"" />
        <xs:enumeration value=""VI"" />
        <xs:enumeration value=""WF"" />
        <xs:enumeration value=""EH"" />
        <xs:enumeration value=""YE"" />
        <xs:enumeration value=""YU"" />
        <xs:enumeration value=""ZR"" />
        <xs:enumeration value=""ZM"" />
        <xs:enumeration value=""ZW"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""ProductQuantity"">
    <xs:simpleType>
      <xs:restriction base=""xs:decimal"">
        <xs:minInclusive value=""0"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""NationalPostalCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:maxLength value=""9"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""requestingDocumentDateTime"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:DateTimeStamp"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ProductIdentification"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalProductIdentifier"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:PartnerProductIdentification"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""telephoneNumber"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:CommunicationsNumber"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""WarehouseInformationResource"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:warehouseAddress"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:warehouseQuantity"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ContactInformation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:contactName"" />
        <xs:element ref=""ns0:telephoneNumber"" />
        <xs:element ref=""ns0:EmailAddress"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""contactName"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""cityName"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""fromRole"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:PartnerRoleDescription"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalPartnerRoleClassificationCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Product Supplier"" />
        <xs:enumeration value=""Customer"" />
        <xs:enumeration value="""" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""FinancialAmount"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:GlobalCurrencyCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:MonetaryAmount"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""unitPrice"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FinancialAmount"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""warehouseAddress"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:PhysicalAddress"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PartnerRoleDescription"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:GlobalPartnerRoleClassificationCode"" />
        <xs:element ref=""ns0:PartnerDescription"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:ContactInformation"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ProprietaryProductIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""addressLine2"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""addressLine3"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Pip3A2PriceAndAvailabilityResponse"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Pip3A2PriceAndAvailabilityResponse' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']/*[local-name()='fromRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Pip3A2PriceAndAvailabilityResponse' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']/*[local-name()='toRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A2PriceAndAvailabilityResponseMessageGuideline_v1_3.dtd']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""ns0:ProductPriceAndAvailability"" />
        <xs:element ref=""ns0:fromRole"" />
        <xs:element ref=""ns0:toRole"" />
        <xs:element ref=""ns0:thisDocumentGenerationDateTime"" />
        <xs:element ref=""ns0:thisDocumentIdentifier"" />
        <xs:element ref=""ns0:requestingDocumentIdentifier"" />
        <xs:element ref=""ns0:GlobalDocumentFunctionCode"" />
        <xs:element ref=""ns0:requestingDocumentDateTime"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""addressLine1"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LineNumber"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:maxLength value=""6"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""EmailAddress"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""GlobalSupplyChainCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Information Technology"" />
        <xs:enumeration value=""Electronic Components"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""requestingDocumentIdentifier"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProprietaryDocumentIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public _3A2PriceAndAvailabilityResponseMessageGuideline_v1_3() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Pip3A2PriceAndAvailabilityResponse";
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
