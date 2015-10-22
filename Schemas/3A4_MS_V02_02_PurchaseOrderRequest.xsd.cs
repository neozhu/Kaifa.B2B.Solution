namespace Microsoft.Solutions.BTARN.Schemas.RNPIPs {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd",@"Pip3A4PurchaseOrderRequest")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "fromRole.PartnerRoleDescription.PartnerDescription.BusinessDescription.GlobalBusinessIdentifier", XPath = @"/*[local-name()='Pip3A4PurchaseOrderRequest' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']/*[local-name()='fromRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "toRole.PartnerRoleDescription.PartnerDescription.BusinessDescription.GlobalBusinessIdentifier", XPath = @"/*[local-name()='Pip3A4PurchaseOrderRequest' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']/*[local-name()='toRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Pip3A4PurchaseOrderRequest"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Microsoft.Solutions.BTARN.Schemas.RNPIPs.xml", typeof(Microsoft.Solutions.BTARN.Schemas.RNPIPs.xml))]
    public sealed class _3A4_MS_V02_02_PurchaseOrderRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns0=""http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Microsoft.Solutions.BTARN.Schemas.RNPIPs.xml"" namespace=""http://www.w3.org/XML/1998/namespace"" />
  <xs:annotation>
    <xs:appinfo>
      <schemaInfo displayroot_reference=""Pip3A4PurchaseOrderRequest"" root_reference=""Pip3A4PurchaseOrderRequest"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
      <b:references>
        <b:reference targetNamespace=""http://www.w3.org/XML/1998/namespace"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""DateTimeStamp"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""13"" />
        <xs:maxLength value=""20"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""GlobalPurchaseOrderTypeCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Blanket"" />
        <xs:enumeration value=""Consigned order"" />
        <xs:enumeration value=""Do not ship/invoice only"" />
        <xs:enumeration value=""ERS"" />
        <xs:enumeration value=""ESD"" />
        <xs:enumeration value=""Evaluation"" />
        <xs:enumeration value=""Exchange Order"" />
        <xs:enumeration value=""Fulfillment"" />
        <xs:enumeration value=""Government"" />
        <xs:enumeration value=""Non-cancelable/non-returnable"" />
        <xs:enumeration value=""Packaged product"" />
        <xs:enumeration value=""Production"" />
        <xs:enumeration value=""Quote to order"" />
        <xs:enumeration value=""Repair"" />
        <xs:enumeration value=""Replenishment"" />
        <xs:enumeration value=""Rework"" />
        <xs:enumeration value=""Risk Production"" />
        <xs:enumeration value=""Sample"" />
        <xs:enumeration value=""Service"" />
        <xs:enumeration value=""Site"" />
        <xs:enumeration value=""Standard"" />
        <xs:enumeration value=""Warranty repair"" />
        <xs:enumeration value=""Warranty replacement"" />
        <xs:enumeration value=""Worldwide"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""DocumentReference"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:DateTimeStamp"" />
        <xs:element ref=""ns0:GlobalDocumentReferenceTypeCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalPartnerRoleClassificationCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:LineNumber"" />
        <xs:element ref=""ns0:ProprietaryDocumentIdentifier"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:RevisionNumber"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalProductIdentifier"" type=""xs:string"" />
  <xs:element name=""contractIdentifier"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProprietaryDocumentIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""InvoiceChargeTypeCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Allowances and Charges"" />
        <xs:enumeration value=""Custom Charges"" />
        <xs:enumeration value=""Deposit Amount"" />
        <xs:enumeration value=""Freight Charges"" />
        <xs:enumeration value=""Handling Charges"" />
        <xs:enumeration value=""Quantity Discount"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""PartnerProductIdentification"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:GlobalPartnerClassificationCode"" />
        <xs:element ref=""ns0:ProprietaryProductIdentifier"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:revisionIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""requestedEvent"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:TransportationEvent"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element default=""0"" name=""MonetaryAmount"">
    <xs:simpleType>
      <xs:restriction base=""xs:decimal"">
        <xs:minInclusive value=""0"" />
        <xs:maxInclusive value=""9999999999999.9999999"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element default=""Request"" name=""GlobalDocumentFunctionCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Request"" />
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
  <xs:element name=""netTermsDay"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:DayOfMonth"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalTransportEventCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Dock"" />
        <xs:enumeration value=""Pickup"" />
        <xs:enumeration value=""Ship"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""ProprietaryIdentifierAuthority"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""GlobalSpecialHandlingCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""15 Minute Window"" />
        <xs:enumeration value=""24 Hour Availability"" />
        <xs:enumeration value=""A.M. Delivery Requirement"" />
        <xs:enumeration value=""Accepted by Carrier at Owner's Risk of Freezing"" />
        <xs:enumeration value=""Accessible Hazardous Material"" />
        <xs:enumeration value=""Additional Copy of Shipping Papers for Proof of Delivery"" />
        <xs:enumeration value=""Advance Loading"" />
        <xs:enumeration value=""Advanced Fee"" />
        <xs:enumeration value=""Aggregate Tender Discount"" />
        <xs:enumeration value=""Air Conditioning Disconnect and Connect"" />
        <xs:enumeration value=""Air Ride Tractor Service"" />
        <xs:enumeration value=""Air Ride Truck Service"" />
        <xs:enumeration value=""Anchoring and Unanchoring"" />
        <xs:enumeration value=""Annual Volume"" />
        <xs:enumeration value=""Apply a Uniform Code Council/International Article Numbering Association (UCC/EAN) Serial Shipping Container Label to the Shipping Containers"" />
        <xs:enumeration value=""Armed Guard Service"" />
        <xs:enumeration value=""Assembly Service Requested"" />
        <xs:enumeration value=""Attachment - Customer's Document"" />
        <xs:enumeration value=""Attachment - Prepaid Waybill"" />
        <xs:enumeration value=""Attachment - Shipper's Export Document"" />
        <xs:enumeration value=""Attachment - Shipper's Manifest"" />
        <xs:enumeration value=""Attachment - Shipper's Packing Instructions"" />
        <xs:enumeration value=""Attachments - Advance Only Waybill"" />
        <xs:enumeration value=""Auxiliary Service"" />
        <xs:enumeration value=""Barge Freight All Kinds Service"" />
        <xs:enumeration value=""Bill Consignee for Weigh Charges"" />
        <xs:enumeration value=""Bill Shipper for Weigh Charge"" />
        <xs:enumeration value=""Blind Shipment"" />
        <xs:enumeration value=""Block Stowage"" />
        <xs:enumeration value=""Blocking and Bracing"" />
        <xs:enumeration value=""Bolster Load, Do Not Switch"" />
        <xs:enumeration value=""Bulky Article"" />
        <xs:enumeration value=""Bunker Adjustment"" />
        <xs:enumeration value=""Bunker Adjustment - 20 Foot Container"" />
        <xs:enumeration value=""Bunker Adjustment - 40 Foot Container"" />
        <xs:enumeration value=""Bunker Surcharge Authorized"" />
        <xs:enumeration value=""Bypass Consolidation Point"" />
        <xs:enumeration value=""Cargo Aboard"" />
        <xs:enumeration value=""Cargo on Board Certification Required"" />
        <xs:enumeration value=""Cargo Taxes"" />
        <xs:enumeration value=""Carrier"" />
        <xs:enumeration value=""Carrier Caboose"" />
        <xs:enumeration value=""Carrier Guard Car Service"" />
        <xs:enumeration value=""Carrier Load and Carrier Unload"" />
        <xs:enumeration value=""Carrier Load and Consignee Unload"" />
        <xs:enumeration value=""Certificate of Origin"" />
        <xs:enumeration value=""Certification"" />
        <xs:enumeration value=""Certification that the Containers Being Returned Empty Were Received Filled by Rail Freight Service"" />
        <xs:enumeration value=""Certification That the Newsprint Winding Cores Being Returned Empty Were Received Filled by Rail Freight Service"" />
        <xs:enumeration value=""Certification that this Shipment is for Recycling as Defined in Applicable Tariffs Containing Such Provisions"" />
        <xs:enumeration value=""Chain and Binders"" />
        <xs:enumeration value=""Circuitous Routing"" />
        <xs:enumeration value=""Class Rates Applied"" />
        <xs:enumeration value=""Cleaning"" />
        <xs:enumeration value=""Cleared for Border Crossing"" />
        <xs:enumeration value=""Cleared for Export"" />
        <xs:enumeration value=""Clearinghouse Balance"" />
        <xs:enumeration value=""Comb. Rates over Detroit"" />
        <xs:enumeration value=""Commercial Invoice Preparation"" />
        <xs:enumeration value=""Commodity Loaded Less Than or Equal To the Car Ordered"" />
        <xs:enumeration value=""Completing Shipment"" />
        <xs:enumeration value=""Conductivity/Anti-static Additive"" />
        <xs:enumeration value=""Consignee Unload"" />
        <xs:enumeration value=""Consolidation"" />
        <xs:enumeration value=""Consolidation and Line Haul"" />
        <xs:enumeration value=""Constant Surveillance"" />
        <xs:enumeration value=""Container Diversion"" />
        <xs:enumeration value=""Container Lease"" />
        <xs:enumeration value=""Container Mounting"" />
        <xs:enumeration value=""Container, Consolidator Load"" />
        <xs:enumeration value=""Container, Factory Load"" />
        <xs:enumeration value=""Contract Rates Apply"" />
        <xs:enumeration value=""Controlled Atmosphere"" />
        <xs:enumeration value=""Convert Commercial Bill of Lading (BOL) to Government BOL"" />
        <xs:enumeration value=""Courier, Overnight"" />
        <xs:enumeration value=""Courier, Same Day"" />
        <xs:enumeration value=""Cross Town"" />
        <xs:enumeration value=""Currency Adjustment - 20 Foot Container"" />
        <xs:enumeration value=""Currency Adjustment - 40 Foot Container"" />
        <xs:enumeration value=""Customer Required Appointment Number"" />
        <xs:enumeration value=""Customer Required Packing List"" />
        <xs:enumeration value=""Customer Required PRO Number"" />
        <xs:enumeration value=""Customs Fees - Container Level"" />
        <xs:enumeration value=""Customs Fees - Lift Level"" />
        <xs:enumeration value=""Customs Inspection"" />
        <xs:enumeration value=""Customs Papers Mailed"" />
        <xs:enumeration value=""Dangerous"" />
        <xs:enumeration value=""Delivery Only on Surrender of Written Order"" />
        <xs:enumeration value=""Delivery Service"" />
        <xs:enumeration value=""Delivery Verification Not Required"" />
        <xs:enumeration value=""Demurrage"" />
        <xs:enumeration value=""Destination Weights Apply"" />
        <xs:enumeration value=""Detention (Vehicle)"" />
        <xs:enumeration value=""Detention of Conveying Equipment and the Power Unit"" />
        <xs:enumeration value=""Detention of Conveying Equipment Excluding the Power Unit"" />
        <xs:enumeration value=""Detention With Power Units (30 minute periods)"" />
        <xs:enumeration value=""Detention With Power Units (60 minute periods)"" />
        <xs:enumeration value=""Direct Delivery"" />
        <xs:enumeration value=""Distribution Service Requested"" />
        <xs:enumeration value=""Do Not Couple to Double Shelf Couples"" />
        <xs:enumeration value=""Do Not Divert"" />
        <xs:enumeration value=""Do Not Freeze"" />
        <xs:enumeration value=""Do Not Hump"" />
        <xs:enumeration value=""Do not Hump or Hump into"" />
        <xs:enumeration value=""Do Not Pool"" />
        <xs:enumeration value=""Do Not Transfer Contents"" />
        <xs:enumeration value=""Do Not Uncouple"" />
        <xs:enumeration value=""Documentation - Special"" />
        <xs:enumeration value=""DOD Constant Surveillance Service"" />
        <xs:enumeration value=""Domestic"" />
        <xs:enumeration value=""Drayage at Port of Debarkation (Rate Zone)"" />
        <xs:enumeration value=""Drayage at Port of Embarkation (Rate Zone)"" />
        <xs:enumeration value=""Drop and Run"" />
        <xs:enumeration value=""Drop-Off Delivery"" />
        <xs:enumeration value=""Electronic Equipment Transfer"" />
        <xs:enumeration value=""Emergency Service"" />
        <xs:enumeration value=""Empty Movement"" />
        <xs:enumeration value=""Empty Return"" />
        <xs:enumeration value=""Endorsed as Hazardous Material"" />
        <xs:enumeration value=""Endorsement"" />
        <xs:enumeration value=""Equipment"" />
        <xs:enumeration value=""Escort"" />
        <xs:enumeration value=""Escort Service with Overnight Subsistence"" />
        <xs:enumeration value=""Escort Services (Telephone)"" />
        <xs:enumeration value=""Escort/Courier Service"" />
        <xs:enumeration value=""Excessive Valuation Authorized"" />
        <xs:enumeration value=""Excessive Weight"" />
        <xs:enumeration value=""Exclusive Use"" />
        <xs:enumeration value=""Exclusive Use of Vehicle"" />
        <xs:enumeration value=""Exempt Commodity"" />
        <xs:enumeration value=""Expand Remove and Install"" />
        <xs:enumeration value=""Expedite"" />
        <xs:enumeration value=""Expedited Rates Applied"" />
        <xs:enumeration value=""Expedited Service"" />
        <xs:enumeration value=""Export"" />
        <xs:enumeration value=""Export Preparation"" />
        <xs:enumeration value=""Extra Driver"" />
        <xs:enumeration value=""Extra Labor"" />
        <xs:enumeration value=""Extra Lights"" />
        <xs:enumeration value=""Filtration Service"" />
        <xs:enumeration value=""Flatrack Surcharge"" />
        <xs:enumeration value=""FOD"" />
        <xs:enumeration value=""For Processing in Transit"" />
        <xs:enumeration value=""For Storage in Transit"" />
        <xs:enumeration value=""FOS"" />
        <xs:enumeration value=""Fragile - Handle with Care"" />
        <xs:enumeration value=""Full Service"" />
        <xs:enumeration value=""Government Caboose"" />
        <xs:enumeration value=""Government Guard Car"" />
        <xs:enumeration value=""Government-Owned Containers"" />
        <xs:enumeration value=""Greater Security Service"" />
        <xs:enumeration value=""Handling"" />
        <xs:enumeration value=""Harmless"" />
        <xs:enumeration value=""Hazardous Cargo On Deck"" />
        <xs:enumeration value=""Hazardous Materials Surcharge"" />
        <xs:enumeration value=""Heat"" />
        <xs:enumeration value=""Heat - Special"" />
        <xs:enumeration value=""Heat in Transit"" />
        <xs:enumeration value=""Heater or Refrigeration"" />
        <xs:enumeration value=""High Cube Trailer Rates"" />
        <xs:enumeration value=""High Value Load"" />
        <xs:enumeration value=""Hold at Location"" />
        <xs:enumeration value=""Hold for Orders"" />
        <xs:enumeration value=""Home for Repair"" />
        <xs:enumeration value=""If Bad Ordered Notify Shipper"" />
        <xs:enumeration value=""Impactographs"" />
        <xs:enumeration value=""Import Shipment"" />
        <xs:enumeration value=""In Case of Fire Do Not Use Water"" />
        <xs:enumeration value=""Inaccessible Hazardous Material"" />
        <xs:enumeration value=""In-bond"" />
        <xs:enumeration value=""Inside Delivery"" />
        <xs:enumeration value=""Inside Pickup"" />
        <xs:enumeration value=""Inspect Hourly if Car Stopped"" />
        <xs:enumeration value=""Insulated"" />
        <xs:enumeration value=""Interline Transfer Service"" />
        <xs:enumeration value=""Intermodal Shipment Service"" />
        <xs:enumeration value=""Intra-Plant Move"" />
        <xs:enumeration value=""Joint Line Exception"" />
        <xs:enumeration value=""Just-In-Time (JIT)"" />
        <xs:enumeration value=""Keep From Freezing Percent Differential"" />
        <xs:enumeration value=""Keep Material Dry"" />
        <xs:enumeration value=""Labor Associated with Detention of Conveying Equipment"" />
        <xs:enumeration value=""Labor Disturbance"" />
        <xs:enumeration value=""Land Bridge (Import/Export)"" />
        <xs:enumeration value=""Land Currency Adjustment - 40 Foot Container"" />
        <xs:enumeration value=""Land Currency Adjustment Factor - 20 Foot Container"" />
        <xs:enumeration value=""Layover"" />
        <xs:enumeration value=""Layover Service"" />
        <xs:enumeration value=""Less Than Container"" />
        <xs:enumeration value=""Less Than Container, Consolidator Load"" />
        <xs:enumeration value=""Less Than Container, Factory Load"" />
        <xs:enumeration value=""Less Than Full Carload"" />
        <xs:enumeration value=""Less Than Truckload"" />
        <xs:enumeration value=""Liability of Carrier"" />
        <xs:enumeration value=""Light Bar Service"" />
        <xs:enumeration value=""Linehaul from Port of Debarkation"" />
        <xs:enumeration value=""Linehaul Percent Differential"" />
        <xs:enumeration value=""Linehaul Service"" />
        <xs:enumeration value=""Linehaul To Port of Embarkation"" />
        <xs:enumeration value=""Liner Terms at Port of Debarkation"" />
        <xs:enumeration value=""Liner Terms at Port of Embarkation"" />
        <xs:enumeration value=""Live Unload"" />
        <xs:enumeration value=""Loaded to Full Visible Capacity"" />
        <xs:enumeration value=""Loading Devices"" />
        <xs:enumeration value=""Local Service Only"" />
        <xs:enumeration value=""Low Boy Trailer/Flat Bed"" />
        <xs:enumeration value=""Manifest Must Accompany Waybill"" />
        <xs:enumeration value=""Mechanical Refrigeration"" />
        <xs:enumeration value=""Modified Atmosphere"" />
        <xs:enumeration value=""Motor Surveillance Service"" />
        <xs:enumeration value=""Moving Under &quot;For Furtherance Instructions&quot; and May Be Delivered"" />
        <xs:enumeration value=""Multiple Pickup"" />
        <xs:enumeration value=""Multi-Tank Surveillance Service"" />
        <xs:enumeration value=""New Equipment First Transborder Movement"" />
        <xs:enumeration value=""No Marshalling Required for Hazardous Materials"" />
        <xs:enumeration value=""No Placards Required"" />
        <xs:enumeration value=""No Special Entrainment Required"" />
        <xs:enumeration value=""Nontransit Flat Shipment"" />
        <xs:enumeration value=""Not for Export"" />
        <xs:enumeration value=""Not Restricted Cargo"" />
        <xs:enumeration value=""Notify Consignee Before Delivery"" />
        <xs:enumeration value=""Notify Shipper Before Reconsignment"" />
        <xs:enumeration value=""Notify Shipper Immediately if Shipment is Delayed en Route"" />
        <xs:enumeration value=""Offshore - Alaska/Hawaii Service"" />
        <xs:enumeration value=""On Deck Stowage"" />
        <xs:enumeration value=""One Way Rates Applied"" />
        <xs:enumeration value=""Other"" />
        <xs:enumeration value=""Over Height Container"" />
        <xs:enumeration value=""Overflow"" />
        <xs:enumeration value=""Oversized Premium"" />
        <xs:enumeration value=""Overweight"" />
        <xs:enumeration value=""P.M. Delivery Requirement"" />
        <xs:enumeration value=""Pack and Unpack"" />
        <xs:enumeration value=""Pallets/Skids/Platforms"" />
        <xs:enumeration value=""Partial Shipment"" />
        <xs:enumeration value=""Per Hour Rates Applied"" />
        <xs:enumeration value=""Per Mile Rates Apply"" />
        <xs:enumeration value=""Percent Differential - Less Than Container"" />
        <xs:enumeration value=""Pickup"" />
        <xs:enumeration value=""Pickup and Delivery"" />
        <xs:enumeration value=""Pickup and Delivery Beyond Service Area"" />
        <xs:enumeration value=""Pickup and Delivery From Storage in Transit"" />
        <xs:enumeration value=""Pickup of Shipments on Saturday, Sunday, and/or Holidays Requiring Absolute Next Day Delivery"" />
        <xs:enumeration value=""Pickup of Shipments Requiring Same Day Delivery Service"" />
        <xs:enumeration value=""Pickup of Shipments Requiring Same Day Delivery Service and/or Delivery at a Specified Time"" />
        <xs:enumeration value=""Pier Time"" />
        <xs:enumeration value=""Port Changes"" />
        <xs:enumeration value=""PPC"" />
        <xs:enumeration value=""PPD"" />
        <xs:enumeration value=""Preparation of Air Waybill - Origin"" />
        <xs:enumeration value=""Preparation of Canadian Customs Invoice"" />
        <xs:enumeration value=""Preparation of Export Entry"" />
        <xs:enumeration value=""Preparation of Insurance Certificate"" />
        <xs:enumeration value=""Preparation of U.S. Export Documentation"" />
        <xs:enumeration value=""Priority Service"" />
        <xs:enumeration value=""Product Protection Service"" />
        <xs:enumeration value=""Protect From Heat"" />
        <xs:enumeration value=""Protect Lowest Through Rate"" />
        <xs:enumeration value=""Protective Security Service"" />
        <xs:enumeration value=""PUP Trailer Rates Apply"" />
        <xs:enumeration value=""Radioactive Material"" />
        <xs:enumeration value=""Railhead Handling"" />
        <xs:enumeration value=""Railroad Controlled Private Equipment Subject to Demurrage"" />
        <xs:enumeration value=""Reconsignment"" />
        <xs:enumeration value=""Record for Transit"" />
        <xs:enumeration value=""Redelivery"" />
        <xs:enumeration value=""Reefer Cargo Percent Differential"" />
        <xs:enumeration value=""Reefer Maintenance"" />
        <xs:enumeration value=""Refrigerated"" />
        <xs:enumeration value=""Released Value Charge in Excess of Carrier Maximum Liability"" />
        <xs:enumeration value=""Render Bill for Charges"" />
        <xs:enumeration value=""Requires Shelf Couplers"" />
        <xs:enumeration value=""Reservations"" />
        <xs:enumeration value=""Reshipment"" />
        <xs:enumeration value=""Residential Delivery"" />
        <xs:enumeration value=""Respotting"" />
        <xs:enumeration value=""Return Authorization"" />
        <xs:enumeration value=""Return Carrier Guard Car Service"" />
        <xs:enumeration value=""Return Movement of Pallet"" />
        <xs:enumeration value=""Return of Empty Container"" />
        <xs:enumeration value=""Reweight Requested"" />
        <xs:enumeration value=""Roadrailer Service"" />
        <xs:enumeration value=""Roadway Easy Rates Applied"" />
        <xs:enumeration value=""ROEE Van Type Truck"" />
        <xs:enumeration value=""Round Trip Service"" />
        <xs:enumeration value=""Rush Order"" />
        <xs:enumeration value=""Satellite Surveillance Service"" />
        <xs:enumeration value=""Satisfactory Service Standards"" />
        <xs:enumeration value=""Saturday Delivery"" />
        <xs:enumeration value=""Saturday Pick-Up"" />
        <xs:enumeration value=""Saturday Pickup or Delivery"" />
        <xs:enumeration value=""Security Signature Service"" />
        <xs:enumeration value=""Service Charge Applies"" />
        <xs:enumeration value=""Shiftable Load"" />
        <xs:enumeration value=""Shipment from Non-Temp Storage"" />
        <xs:enumeration value=""Shipment Holdover for Holidays"" />
        <xs:enumeration value=""Shipment Holdover for Weekends"" />
        <xs:enumeration value=""Shipment Holdover on Holidays"" />
        <xs:enumeration value=""Shipment Holdover on Weekdays"" />
        <xs:enumeration value=""Shipment Holdover on Weekends"" />
        <xs:enumeration value=""Shipment to be Inspected at Destination and Disposition Instructions will be Furnished"" />
        <xs:enumeration value=""Shipper Authorization Required for Diversion or Consignment"" />
        <xs:enumeration value=""Shipper Certifies Gross Weight under 240,000 pounds"" />
        <xs:enumeration value=""Shipper Export Declaration Required"" />
        <xs:enumeration value=""Shipper Load"" />
        <xs:enumeration value=""Shipper Load and Carrier Unload"" />
        <xs:enumeration value=""Shipper Load and Consignee Unload"" />
        <xs:enumeration value=""Shipper Load and Count"" />
        <xs:enumeration value=""Shipper Load/Carrier Count"" />
        <xs:enumeration value=""Shove to Rest and Cover"" />
        <xs:enumeration value=""Signature and Tally Record"" />
        <xs:enumeration value=""Signature Required"" />
        <xs:enumeration value=""Single Driver"" />
        <xs:enumeration value=""Single Factor Origination/Destination"" />
        <xs:enumeration value=""Single Factor Origination/Port of Debarkation"" />
        <xs:enumeration value=""Single Factor Port of Embarkation/Destination"" />
        <xs:enumeration value=""Single Shipment"" />
        <xs:enumeration value=""Small Package"" />
        <xs:enumeration value=""Special Containers"" />
        <xs:enumeration value=""Special Dromedary Service"" />
        <xs:enumeration value=""Special Equipment Charge"" />
        <xs:enumeration value=""Special Motor Surveillance"" />
        <xs:enumeration value=""Special Permit"" />
        <xs:enumeration value=""Special Permits"" />
        <xs:enumeration value=""Special Train Movement"" />
        <xs:enumeration value=""Speed Restricted"" />
        <xs:enumeration value=""Speed Restricted to 15 Miles per Hour"" />
        <xs:enumeration value=""Speed Restricted to 25 Miles per Hour"" />
        <xs:enumeration value=""Speed Restricted to 35 Miles per Hour"" />
        <xs:enumeration value=""Speed Restricted to 45 Miles per Hour"" />
        <xs:enumeration value=""Split Delivery"" />
        <xs:enumeration value=""Split Pickup"" />
        <xs:enumeration value=""Spot for Storage - No Shipment"" />
        <xs:enumeration value=""Stack Train"" />
        <xs:enumeration value=""Stairs, Elevator, Excess Carry"" />
        <xs:enumeration value=""Stop-off"" />
        <xs:enumeration value=""Stop-off at Destination"" />
        <xs:enumeration value=""Stop-off at Origination"" />
        <xs:enumeration value=""Storage"" />
        <xs:enumeration value=""Stow Away from Heat"" />
        <xs:enumeration value=""Stowage"" />
        <xs:enumeration value=""Stretch Wrap"" />
        <xs:enumeration value=""Stripping, Sorting and Consolidation"" />
        <xs:enumeration value=""Subject to Special Detention Rules/Charges"" />
        <xs:enumeration value=""Substitute Service Not to be Used"" />
        <xs:enumeration value=""Sunday or Holiday Pickup or Delivery"" />
        <xs:enumeration value=""Supervisor Requested"" />
        <xs:enumeration value=""Surveying Routes"" />
        <xs:enumeration value=""Team Track Delivery"" />
        <xs:enumeration value=""Temperature Control"" />
        <xs:enumeration value=""Tendered as Truckload (Truckload Service Requested)"" />
        <xs:enumeration value=""Tendering of Multiple Vehicles"" />
        <xs:enumeration value=""Terminal Handling Charges"" />
        <xs:enumeration value=""Termination"" />
        <xs:enumeration value=""Third Party Service"" />
        <xs:enumeration value=""Time of Delivery and Signature Required"" />
        <xs:enumeration value=""Time Volume Rates Only"" />
        <xs:enumeration value=""Top Load Only"" />
        <xs:enumeration value=""Total Shipment"" />
        <xs:enumeration value=""Trade Show"" />
        <xs:enumeration value=""Trailer Preparation - Special"" />
        <xs:enumeration value=""Trailer, Consolidator Load"" />
        <xs:enumeration value=""Trailer, Factory Load"" />
        <xs:enumeration value=""Transfer Product"" />
        <xs:enumeration value=""Transit Shipment"" />
        <xs:enumeration value=""Transmit a Ship Notice/Manifest Transaction Set"" />
        <xs:enumeration value=""Truck Rates Applicable"" />
        <xs:enumeration value=""Truckload-Double Operator-Common Carrier"" />
        <xs:enumeration value=""Truckload-Double Operator-Padded Van"" />
        <xs:enumeration value=""Unitized"" />
        <xs:enumeration value=""Unload as Placarded"" />
        <xs:enumeration value=""Unload from Left Side of Car"" />
        <xs:enumeration value=""Unload from Right Side of Car"" />
        <xs:enumeration value=""Unloading or Reloading"" />
        <xs:enumeration value=""Unpacking"" />
        <xs:enumeration value=""Unprotected Perishable"" />
        <xs:enumeration value=""Use No Hooks"" />
        <xs:enumeration value=""Use of Alternate Terminal"" />
        <xs:enumeration value=""Ventilation Instructions"" />
        <xs:enumeration value=""Verification Weigh"" />
        <xs:enumeration value=""Waiting Time Authorized"" />
        <xs:enumeration value=""Waive Inspection"" />
        <xs:enumeration value=""Waived Inspection - Set Direct"" />
        <xs:enumeration value=""Weigh Empty"" />
        <xs:enumeration value=""Weigh to Check for Overload"" />
        <xs:enumeration value=""Weight Verification"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""OrderQuantity"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:requestedQuantity"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element default=""1"" name=""CountableAmount"">
    <xs:simpleType>
      <xs:restriction base=""xs:positiveInteger"">
        <xs:minInclusive value=""1"" />
        <xs:maxInclusive value=""999999999999999"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""PartnerDescription"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:BusinessDescription"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalPartnerClassificationCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:ContactInformation"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:PhysicalLocation"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ProductSubLineItem"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:comments"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:ContractInformation"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:countryOfOrigin"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:CustomerInformation"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:expediteReferenceIdentifier"" />
        <xs:element ref=""ns0:GlobalProductUnitOfMeasureCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalPurchaseOrderFillPriorityCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:installAt"" />
        <xs:element ref=""ns0:isDropShip"" />
        <xs:element ref=""ns0:OrderQuantity"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:OrderShippingInformation"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:proprietaryInformation"" />
        <xs:element ref=""ns0:requestedEvent"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:requestedShipFrom"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:requestedUnitPrice"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:shipTo"" />
        <xs:element ref=""ns0:subLineItem"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalBusinessIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:pattern value=""^[0-9]{9}$"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""ContractInformation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:contractIdentifier"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:primaryContractWith"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:secondaryContractWith"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""EmailAddress"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""requestedQuantity"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProductQuantity"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""expediteReferenceIdentifier"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProprietaryReferenceIdentifier"" />
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
  <xs:element name=""ProprietaryLocationIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""GlobalAccountClassificationCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""SecondaryBuyer"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:PartnerDescription"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:secondaryBuyerPurchaseOrderIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DayOfMonth"">
    <xs:simpleType>
      <xs:restriction base=""xs:positiveInteger"">
        <xs:minInclusive value=""1"" />
        <xs:maxInclusive value=""31"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""cityName"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""generalServicesAdministrationNumber"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProprietaryDocumentIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CarrierInformation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:accountIdentifier"" />
        <xs:element ref=""ns0:GlobalCarrierCode"" />
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
  <xs:element name=""LineNumber"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:maxLength value=""6"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""CheckNumber"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""packListRequirements"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalSpecialFulfillmentRequestCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Add quantity to make minimum weight requirement"" />
        <xs:enumeration value=""Back order if items are out of stock or not yet published"" />
        <xs:enumeration value=""Back order if out of stock"" />
        <xs:enumeration value=""Back order only if new item"" />
        <xs:enumeration value=""Bid guarantee"" />
        <xs:enumeration value=""Combined small disadvantaged business and labor surplus area set-aside"" />
        <xs:enumeration value=""Consignment"" />
        <xs:enumeration value=""Consolidate delivery"" />
        <xs:enumeration value=""Do not preship"" />
        <xs:enumeration value=""Do not ship/invoice only"" />
        <xs:enumeration value=""Equal product allowed"" />
        <xs:enumeration value=""Exclude Import Quota in First Cost"" />
        <xs:enumeration value=""Factory ship"" />
        <xs:enumeration value=""Fill or kill"" />
        <xs:enumeration value=""Guaranteed sale"" />
        <xs:enumeration value=""Include Import Quota in First Cost"" />
        <xs:enumeration value=""Labor surplus area set-Aside"" />
        <xs:enumeration value=""Large purchase set-aside for small business"" />
        <xs:enumeration value=""May preship"" />
        <xs:enumeration value=""Multi-year award"" />
        <xs:enumeration value=""Mutually defined"" />
        <xs:enumeration value=""No back order"" />
        <xs:enumeration value=""No substitutes"" />
        <xs:enumeration value=""Notify prior to shipment if quantity specified is not available"" />
        <xs:enumeration value=""On Qualified Bidders List"" />
        <xs:enumeration value=""On Qualified Manufacturers List"" />
        <xs:enumeration value=""Other Unlisted Sales Condition"" />
        <xs:enumeration value=""Partial labor surplus area set aside"" />
        <xs:enumeration value=""Restricted to approved sources"" />
        <xs:enumeration value=""Restricted to educational institutions"" />
        <xs:enumeration value=""Restricted to historically black college or university or minority institution"" />
        <xs:enumeration value=""Restricted to industrial preparedness program participants"" />
        <xs:enumeration value=""Restricted to Qualified Products List (QPL) Products"" />
        <xs:enumeration value=""Restricted to U.S. and Canadian Sources"" />
        <xs:enumeration value=""Restricted to Young Investigator Program"" />
        <xs:enumeration value=""Section (8a) set-aside"" />
        <xs:enumeration value=""Set-aside for american indian-owned business"" />
        <xs:enumeration value=""Ship as soon as possible"" />
        <xs:enumeration value=""Ship Complete"" />
        <xs:enumeration value=""Ship full truck only"" />
        <xs:enumeration value=""Ship In-Place"" />
        <xs:enumeration value=""Ship partial - balance back order"" />
        <xs:enumeration value=""Ship Partial - Balance Cancel"" />
        <xs:enumeration value=""Ship Partial - Balance Substitute"" />
        <xs:enumeration value=""Ship Partial - Carload Lots Only"" />
        <xs:enumeration value=""Ship Partial - Item Qty Proportional To Total Order"" />
        <xs:enumeration value=""Ship Partial - Truckload Lots Only"" />
        <xs:enumeration value=""Ship Per Release"" />
        <xs:enumeration value=""Ship Per Release or Buyer Authorization"" />
        <xs:enumeration value=""Ship Per Schedule"" />
        <xs:enumeration value=""Small business with small disadvantaged business consideration set-aside"" />
        <xs:enumeration value=""Small disadvantaged business set-aside"" />
        <xs:enumeration value=""Small purchase set aside for small businesses"" />
        <xs:enumeration value=""Small Remaining Balance Cancellation Allowed"" />
        <xs:enumeration value=""Small Remaining Balance Cancellation Not Allowed"" />
        <xs:enumeration value=""Substitute item allowed"" />
        <xs:enumeration value=""Unrestricted procurement"" />
        <xs:enumeration value=""Warehouse ship"" />
        <xs:enumeration value=""Warranty"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""GlobalCustomerTypeCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""installAt"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:PartnerDescription"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""comments"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PurchaseOrder"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:AccountDescription"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:comments"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:ContractInformation"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:DocumentReference"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:FinancingTerms"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:generalServicesAdministrationNumber"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalGovernmentPriorityRatingCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalPurchaseOrderFillPriorityCode"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""ns0:GlobalPurchaseOrderTypeCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:governmentContractIdentifier"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:installAt"" />
        <xs:element ref=""ns0:isDropShip"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:OrderShippingInformation"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""ns0:ProductLineItem"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:proprietaryInformation"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:requestedEvent"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:requestedShipFrom"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:SecondaryBuyer"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:shipTo"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:TaxExemptStatus"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:totalAmount"" />
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
  <xs:element name=""CustomerInformation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:customerProjectIdentifier"" />
        <xs:element ref=""ns0:GlobalCustomerTypeCode"" />
        <xs:element ref=""ns0:PartnerDescription"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""netTermsDays"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:CountableAmount"" />
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
  <xs:element name=""countryOfOrigin"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:GlobalCountryCode"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""totalAmount"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FinancialAmount"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""NationalBusinessTaxIdentifier"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:BusinessTaxIdentifier"" />
        <xs:element ref=""ns0:GlobalCountryCode"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""specialHandlingText"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PhysicalLocation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalLocationIdentifier"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:PartnerLocationIdentification"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:PhysicalAddress"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalShipmentTermsCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Advance collect"" />
        <xs:enumeration value=""Advance prepaid"" />
        <xs:enumeration value=""Cash in advance"" />
        <xs:enumeration value=""Cash on delivery"" />
        <xs:enumeration value=""CFR"" />
        <xs:enumeration value=""CIF"" />
        <xs:enumeration value=""CIP"" />
        <xs:enumeration value=""Collect"" />
        <xs:enumeration value=""Collect, freight credited to payment customer"" />
        <xs:enumeration value=""CPT"" />
        <xs:enumeration value=""Credit card"" />
        <xs:enumeration value=""Customer pick-up/backhaul"" />
        <xs:enumeration value=""DAF"" />
        <xs:enumeration value=""DDP"" />
        <xs:enumeration value=""DDU"" />
        <xs:enumeration value=""DEQ"" />
        <xs:enumeration value=""DES"" />
        <xs:enumeration value=""EXW"" />
        <xs:enumeration value=""FAS"" />
        <xs:enumeration value=""FCA"" />
        <xs:enumeration value=""FOB"" />
        <xs:enumeration value=""Letter of credit"" />
        <xs:enumeration value=""Not specified"" />
        <xs:enumeration value=""Payable elsewhere"" />
        <xs:enumeration value=""Pickup"" />
        <xs:enumeration value=""Prepaid (by seller)"" />
        <xs:enumeration value=""Prepaid but charged to customer"" />
        <xs:enumeration value=""Prepaid only"" />
        <xs:enumeration value=""Return container freight free"" />
        <xs:enumeration value=""Return container freight paid by customer"" />
        <xs:enumeration value=""Return container freight paid by supplier"" />
        <xs:enumeration value=""Third party pay"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""PartnerBusinessIdentification"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProprietaryBusinessIdentifier"" />
        <xs:element ref=""ns0:ProprietaryDomainIdentifier"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:ProprietaryIdentifierAuthority"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""prePaymentCheckNumber"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:CheckNumber"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AffirmationIndicator"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""2"" />
        <xs:maxLength value=""3"" />
        <xs:enumeration value=""Yes"" />
        <xs:enumeration value=""yes"" />
        <xs:enumeration value=""YES"" />
        <xs:enumeration value=""Y"" />
        <xs:enumeration value=""No"" />
        <xs:enumeration value=""no"" />
        <xs:enumeration value=""NO"" />
        <xs:enumeration value=""N"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""NationalPostalCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""3"" />
        <xs:maxLength value=""15"" />
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
  <xs:element name=""secondaryContractWith"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:PartnerDescription"" />
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
  <xs:element name=""BusinessDescription"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalBusinessIdentifier"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalSupplyChainCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:businessName"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:PartnerBusinessIdentification"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:NationalBusinessTaxIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""discountDays"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:CountableAmount"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PartnerLocationIdentification"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProprietaryDomainIdentifier"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:ProprietaryIdentifierAuthority"" />
        <xs:element ref=""ns0:ProprietaryLocationIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""isTaxExempt"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:AffirmationIndicator"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TransportationEvent"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:DateStamp"" />
        <xs:element ref=""ns0:GlobalTransportEventCode"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""customerProjectIdentifier"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProprietaryReferenceIdentifier"" />
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
  <xs:element name=""CreditCard"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:cardHolderName"" />
        <xs:element ref=""ns0:creditCardIdentifier"" />
        <xs:element ref=""ns0:expiryDate"" />
        <xs:element ref=""ns0:GlobalCreditCardClassificationCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:ProprietaryCIDIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalLocationIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""10"" />
        <xs:maxLength value=""13"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""TaxExemptStatus"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:isTaxExempt"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:TaxExemption"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalFinanceTermsCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Bank transfer"" />
        <xs:enumeration value=""Basic discount offered"" />
        <xs:enumeration value=""Consignment"" />
        <xs:enumeration value=""Credit card"" />
        <xs:enumeration value=""Electronic payment system"" />
        <xs:enumeration value=""In kind payment"" />
        <xs:enumeration value=""Lease agreement"" />
        <xs:enumeration value=""Letter of credit"" />
        <xs:enumeration value=""Mutually defined/determined by TPA"" />
        <xs:enumeration value=""Net month following invoice"" />
        <xs:enumeration value=""Pay by check"" />
        <xs:enumeration value=""Prepay check"" />
        <xs:enumeration value=""Prepay credit card"" />
        <xs:enumeration value=""Prepay wire"" />
        <xs:enumeration value=""Previously charged"" />
        <xs:enumeration value=""Private netting"" />
        <xs:enumeration value=""Terms established/determined by TPA"" />
        <xs:enumeration value=""Waived"" />
        <xs:enumeration value=""Wire transfer"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""GlobalSupplyChainCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Electronic Components"" />
        <xs:enumeration value=""Information Technology"" />
        <xs:enumeration value=""Semiconductor Manufacturing"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""requestedShipFrom"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:PhysicalAddress"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""FinancialAmount"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:GlobalCurrencyCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalMonetaryAmountTypeCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:InvoiceChargeTypeCode"" />
        <xs:element ref=""ns0:MonetaryAmount"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalCreditCardClassificationCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""businessName"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""postOfficeBoxIdentifier"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Pip3A4PurchaseOrderRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Pip3A4PurchaseOrderRequest' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']/*[local-name()='fromRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Pip3A4PurchaseOrderRequest' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']/*[local-name()='toRole' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']/*[local-name()='PartnerRoleDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']/*[local-name()='PartnerDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']/*[local-name()='BusinessDescription' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']/*[local-name()='GlobalBusinessIdentifier' and namespace-uri()='http://schemas.microsoft.com/biztalk/btarn/2004/3A4_MS_V02_02_PurchaseOrderRequest.dtd']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:fromRole"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalDocumentFunctionCode"" />
        <xs:element ref=""ns0:PurchaseOrder"" />
        <xs:element ref=""ns0:thisDocumentGenerationDateTime"" />
        <xs:element ref=""ns0:thisDocumentIdentifier"" />
        <xs:element ref=""ns0:toRole"" />
      </xs:sequence>
    </xs:complexType>
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
  <xs:element name=""accountIdentifier"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProprietaryReferenceIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ProprietaryCIDIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""discountPercent"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:PercentAmount"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalFreeOnBoardCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Destination"" />
        <xs:enumeration value=""Origin"" />
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
  <xs:element name=""ProprietaryReferenceIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:maxLength value=""255"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""PaymentTerms"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:Discounts"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalPaymentConditionCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:netTermsDay"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:netTermsDays"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:percentDue"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""financedBy"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:PartnerDescription"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""discountDay"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:DayOfMonth"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""BusinessTaxIdentifier"" type=""xs:string"" />
  <xs:element name=""GlobalDocumentReferenceTypeCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""ASP Claim"" />
        <xs:enumeration value=""ASP Part Return"" />
        <xs:enumeration value=""ASP PartOrder"" />
        <xs:enumeration value=""ASP Requisition"" />
        <xs:enumeration value=""Commercial Invoice"" />
        <xs:enumeration value=""Contract"" />
        <xs:enumeration value=""Delivery Note"" />
        <xs:enumeration value=""Drawing #"" />
        <xs:enumeration value=""Invoice"" />
        <xs:enumeration value=""Master Event Number"" />
        <xs:enumeration value=""Model Number"" />
        <xs:enumeration value=""OEM Claim"" />
        <xs:enumeration value=""OEM Part Order"" />
        <xs:enumeration value=""OEM Part Return"" />
        <xs:enumeration value=""Purchase Order"" />
        <xs:enumeration value=""Purchase Order IN"" />
        <xs:enumeration value=""Purchase Order OUT"" />
        <xs:enumeration value=""Quote"" />
        <xs:enumeration value=""Requisition"" />
        <xs:enumeration value=""RMA"" />
        <xs:enumeration value=""Sales Order"" />
        <xs:enumeration value=""Serial Number"" />
        <xs:enumeration value=""SNCL"" />
        <xs:enumeration value=""Spec #"" />
        <xs:enumeration value=""Warranty Claim"" />
        <xs:enumeration value=""Waybill"" />
        <xs:enumeration value=""Work Order"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""governmentContractIdentifier"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProprietaryDocumentIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DateStamp"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""9"" />
        <xs:maxLength value=""9"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""Discounts"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:discountDay"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:discountDays"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:discountPercent"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalShippingServiceLevelCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""1BD"" />
        <xs:enumeration value=""5BD"" />
        <xs:enumeration value=""9 A.M."" />
        <xs:enumeration value=""A.M."" />
        <xs:enumeration value=""Air Cargo"" />
        <xs:enumeration value=""Air Charter"" />
        <xs:enumeration value=""Air Economy"" />
        <xs:enumeration value=""Authorized Return Service"" />
        <xs:enumeration value=""Bulk Commodity Train"" />
        <xs:enumeration value=""Business Class"" />
        <xs:enumeration value=""Consignee Billing Service"" />
        <xs:enumeration value=""Courier Express"" />
        <xs:enumeration value=""Deferred Service"" />
        <xs:enumeration value=""Delivery Confirmation"" />
        <xs:enumeration value=""Delivery Confirmation Return"" />
        <xs:enumeration value=""Delivery Notification Only"" />
        <xs:enumeration value=""Delivery scheduled next day by cartage agent"" />
        <xs:enumeration value=""Delivery scheduled second day by cartage agent"" />
        <xs:enumeration value=""Delivery scheduled third day by cartage agent"" />
        <xs:enumeration value=""Door Service"" />
        <xs:enumeration value=""Expedited Service"" />
        <xs:enumeration value=""Expedited Service - Worldwide"" />
        <xs:enumeration value=""Express Service"" />
        <xs:enumeration value=""Express Service - Worldwide"" />
        <xs:enumeration value=""Express Service Plus"" />
        <xs:enumeration value=""First Class"" />
        <xs:enumeration value=""Ground"" />
        <xs:enumeration value=""Manifest Freight"" />
        <xs:enumeration value=""Metro"" />
        <xs:enumeration value=""Multiweight"" />
        <xs:enumeration value=""NBD"" />
        <xs:enumeration value=""Next Day Air"" />
        <xs:enumeration value=""Next Day Hundred Weight"" />
        <xs:enumeration value=""Next Flight Out"" />
        <xs:enumeration value=""Next Morning"" />
        <xs:enumeration value=""NORMAL"" />
        <xs:enumeration value=""Not Served"" />
        <xs:enumeration value=""Other Intermodal and Stack Service"" />
        <xs:enumeration value=""Overnight"" />
        <xs:enumeration value=""P.O. Box/Zip Code"" />
        <xs:enumeration value=""Passenger Service"" />
        <xs:enumeration value=""Pickup"" />
        <xs:enumeration value=""PM"" />
        <xs:enumeration value=""Premium Surface"" />
        <xs:enumeration value=""Primary Service Area - Next Day by 10:30 A.M."" />
        <xs:enumeration value=""Primary Service Area - Next Day by 5:00 P.M."" />
        <xs:enumeration value=""Primary Service Area - Next Day By 9:30 AM"" />
        <xs:enumeration value=""Primary Service Area - Next Day by Noon"" />
        <xs:enumeration value=""Primary Service Area - Second Day by Noon"" />
        <xs:enumeration value=""Priority Mail"" />
        <xs:enumeration value=""Priority Mail Insured"" />
        <xs:enumeration value=""Proof of Delivery (POD) with Signature"" />
        <xs:enumeration value=""Regular"" />
        <xs:enumeration value=""Same Day"" />
        <xs:enumeration value=""Saturday"" />
        <xs:enumeration value=""Saturday Pickup"" />
        <xs:enumeration value=""SBD"" />
        <xs:enumeration value=""Scheduled"" />
        <xs:enumeration value=""Second Day"" />
        <xs:enumeration value=""Second Day Air"" />
        <xs:enumeration value=""Second Day Hundred Weight"" />
        <xs:enumeration value=""Second Morning"" />
        <xs:enumeration value=""Standard Class"" />
        <xs:enumeration value=""Standard Ground"" />
        <xs:enumeration value=""Standard Ground Hundred Weight"" />
        <xs:enumeration value=""Standard Ocean"" />
        <xs:enumeration value=""Standard Service"" />
        <xs:enumeration value=""Sunday and Holidays"" />
        <xs:enumeration value=""Three Day Service"" />
        <xs:enumeration value=""Time Critical"" />
        <xs:enumeration value=""Tracking - Ground"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""PartnerRoleDescription"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:ContactInformation"" />
        <xs:element ref=""ns0:GlobalPartnerRoleClassificationCode"" />
        <xs:element ref=""ns0:PartnerDescription"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""secondaryBuyerPurchaseOrderIdentifier"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProprietaryDocumentIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalProductUnitOfMeasureCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""10 Kilogram Drum"" />
        <xs:enumeration value=""10,000 Gallon Tankcar"" />
        <xs:enumeration value=""100 Board Feet"" />
        <xs:enumeration value=""100 Pound Drum"" />
        <xs:enumeration value=""1000-pack"" />
        <xs:enumeration value=""100-Pack"" />
        <xs:enumeration value=""10-pack"" />
        <xs:enumeration value=""115 Kilogram Drum"" />
        <xs:enumeration value=""15 Kilogram Drum"" />
        <xs:enumeration value=""20 Foot Container"" />
        <xs:enumeration value=""20,000 Gallon Tankcar"" />
        <xs:enumeration value=""20-Pack"" />
        <xs:enumeration value=""25 Kilogram Bulk Bag"" />
        <xs:enumeration value=""300 Kilogram Bulk Bag"" />
        <xs:enumeration value=""40 Foot Container"" />
        <xs:enumeration value=""50 Pound Bag"" />
        <xs:enumeration value=""500 Kilogram Bulk Bag"" />
        <xs:enumeration value=""50-pack"" />
        <xs:enumeration value=""55 Gallon Drum"" />
        <xs:enumeration value=""Acre"" />
        <xs:enumeration value=""Actual Pounds"" />
        <xs:enumeration value=""Aluminum Pounds Only"" />
        <xs:enumeration value=""Ampere"" />
        <xs:enumeration value=""Bag"" />
        <xs:enumeration value=""Bale"" />
        <xs:enumeration value=""Ball"" />
        <xs:enumeration value=""Band"" />
        <xs:enumeration value=""Bar"" />
        <xs:enumeration value=""Barrel"" />
        <xs:enumeration value=""Barrel, Imperial"" />
        <xs:enumeration value=""Barrels Per Day"" />
        <xs:enumeration value=""Barrels Per Minute"" />
        <xs:enumeration value=""Base Box"" />
        <xs:enumeration value=""Base Weight"" />
        <xs:enumeration value=""Basket"" />
        <xs:enumeration value=""Batch"" />
        <xs:enumeration value=""Batt"" />
        <xs:enumeration value=""Batting Pound"" />
        <xs:enumeration value=""Beam"" />
        <xs:enumeration value=""Becquerel/kilogram"" />
        <xs:enumeration value=""Belt"" />
        <xs:enumeration value=""Billet"" />
        <xs:enumeration value=""Bin"" />
        <xs:enumeration value=""Block"" />
        <xs:enumeration value=""Board"" />
        <xs:enumeration value=""Board Feet"" />
        <xs:enumeration value=""Bolt"" />
        <xs:enumeration value=""Bottle"" />
        <xs:enumeration value=""Box"" />
        <xs:enumeration value=""British Thermal Unit (BTU)"" />
        <xs:enumeration value=""British Thermal Units (BTUs) Per Cubic Foot"" />
        <xs:enumeration value=""British Thermal Units (BTUs) Per Pound"" />
        <xs:enumeration value=""Bucket"" />
        <xs:enumeration value=""Bulk"" />
        <xs:enumeration value=""Bulk Car Load"" />
        <xs:enumeration value=""Bulk Pack"" />
        <xs:enumeration value=""Bundle"" />
        <xs:enumeration value=""Bunks"" />
        <xs:enumeration value=""Bushel"" />
        <xs:enumeration value=""Bushel, Dry Imperial"" />
        <xs:enumeration value=""Calorie"" />
        <xs:enumeration value=""Can"" />
        <xs:enumeration value=""Candela"" />
        <xs:enumeration value=""Canister"" />
        <xs:enumeration value=""Car"" />
        <xs:enumeration value=""Carat"" />
        <xs:enumeration value=""Carboy"" />
        <xs:enumeration value=""Card"" />
        <xs:enumeration value=""Carload"" />
        <xs:enumeration value=""Carton"" />
        <xs:enumeration value=""Cartridge"" />
        <xs:enumeration value=""Case"" />
        <xs:enumeration value=""Cask"" />
        <xs:enumeration value=""Cassette"" />
        <xs:enumeration value=""Catchweight"" />
        <xs:enumeration value=""Cell"" />
        <xs:enumeration value=""Centiliter"" />
        <xs:enumeration value=""Centimeter"" />
        <xs:enumeration value=""Centipoise (CPS)"" />
        <xs:enumeration value=""Chains (Land Survey)"" />
        <xs:enumeration value=""Chest"" />
        <xs:enumeration value=""Coil"" />
        <xs:enumeration value=""Coil Group"" />
        <xs:enumeration value=""Composite Product Pounds (Total Weight)"" />
        <xs:enumeration value=""Cone"" />
        <xs:enumeration value=""Connector"" />
        <xs:enumeration value=""Container"" />
        <xs:enumeration value=""Cover"" />
        <xs:enumeration value=""Crate"" />
        <xs:enumeration value=""Cubic centimeter"" />
        <xs:enumeration value=""Cubic centimeter/second"" />
        <xs:enumeration value=""Cubic Foot"" />
        <xs:enumeration value=""Cubic inch"" />
        <xs:enumeration value=""Cubic yard"" />
        <xs:enumeration value=""Cubicmeter"" />
        <xs:enumeration value=""Cup"" />
        <xs:enumeration value=""Cycles"" />
        <xs:enumeration value=""Cylinder"" />
        <xs:enumeration value=""Day"" />
        <xs:enumeration value=""Deal"" />
        <xs:enumeration value=""Decimeter"" />
        <xs:enumeration value=""Degree Celsius"" />
        <xs:enumeration value=""Degree Fahrenheit"" />
        <xs:enumeration value=""Dep. Factor"" />
        <xs:enumeration value=""Die"" />
        <xs:enumeration value=""Disk (Disc)"" />
        <xs:enumeration value=""Dispenser"" />
        <xs:enumeration value=""Display"" />
        <xs:enumeration value=""Dozen"" />
        <xs:enumeration value=""Dram"" />
        <xs:enumeration value=""Drum"" />
        <xs:enumeration value=""Dry Pounds"" />
        <xs:enumeration value=""Each"" />
        <xs:enumeration value=""Electrical Capacitance"" />
        <xs:enumeration value=""Fluid Ounce"" />
        <xs:enumeration value=""Fluid Ounce (Imperial)"" />
        <xs:enumeration value=""Fluid Ounce US"" />
        <xs:enumeration value=""Foot"" />
        <xs:enumeration value=""Fuel Usage (Gallons)"" />
        <xs:enumeration value=""Gage Systems"" />
        <xs:enumeration value=""Gallon"" />
        <xs:enumeration value=""Gigajoules"" />
        <xs:enumeration value=""Gill (Imperial)"" />
        <xs:enumeration value=""Grain"" />
        <xs:enumeration value=""Gram"" />
        <xs:enumeration value=""Gram/Cubic Centimeter"" />
        <xs:enumeration value=""Gram/square meter"" />
        <xs:enumeration value=""Grams Per 100 Centimeters"" />
        <xs:enumeration value=""Grams Per 100 Grams"" />
        <xs:enumeration value=""Grams Per Cubic Centimeter"" />
        <xs:enumeration value=""Grams Per Kilogram"" />
        <xs:enumeration value=""Grams Per Liter"" />
        <xs:enumeration value=""Grams Per Milliliter"" />
        <xs:enumeration value=""Grams Per Square Centimeter"" />
        <xs:enumeration value=""Grams Per Square Meter"" />
        <xs:enumeration value=""Great Gross (Dozen Gross)"" />
        <xs:enumeration value=""Gross"" />
        <xs:enumeration value=""Gross Barrels"" />
        <xs:enumeration value=""Gross Gallons"" />
        <xs:enumeration value=""Gross Kilogram"" />
        <xs:enumeration value=""Gross Ton"" />
        <xs:enumeration value=""Gross Yard"" />
        <xs:enumeration value=""Group"" />
        <xs:enumeration value=""Half Gallon"" />
        <xs:enumeration value=""Half Hour"" />
        <xs:enumeration value=""Half Liter"" />
        <xs:enumeration value=""Hank"" />
        <xs:enumeration value=""Heat lots"" />
        <xs:enumeration value=""Hectare"" />
        <xs:enumeration value=""Hectoliter"" />
        <xs:enumeration value=""Hectopascal"" />
        <xs:enumeration value=""Hertz"" />
        <xs:enumeration value=""Hour"" />
        <xs:enumeration value=""Hours"" />
        <xs:enumeration value=""Hundred Boxes"" />
        <xs:enumeration value=""Hundred Count"" />
        <xs:enumeration value=""Hundred Sheets"" />
        <xs:enumeration value=""Hundredth of a Carat"" />
        <xs:enumeration value=""Imperial Gallons"" />
        <xs:enumeration value=""Inch"" />
        <xs:enumeration value=""Jar"" />
        <xs:enumeration value=""Joint"" />
        <xs:enumeration value=""Joule"" />
        <xs:enumeration value=""Keg"" />
        <xs:enumeration value=""Kelvin"" />
        <xs:enumeration value=""Kiloampere"" />
        <xs:enumeration value=""Kilobecquerel/Kilogram"" />
        <xs:enumeration value=""Kilogram"" />
        <xs:enumeration value=""Kilogram per cubic meter"" />
        <xs:enumeration value=""Kilogram/Kilogram"" />
        <xs:enumeration value=""Kilogram/square meter"" />
        <xs:enumeration value=""Kilogramm pro Sekunde"" />
        <xs:enumeration value=""Kilohertz"" />
        <xs:enumeration value=""Kilojoule"" />
        <xs:enumeration value=""Kilometer"" />
        <xs:enumeration value=""Kilometer/hour"" />
        <xs:enumeration value=""Kiloohm"" />
        <xs:enumeration value=""Kilovolt"" />
        <xs:enumeration value=""Kilowatt"" />
        <xs:enumeration value=""Kilowatt-hour"" />
        <xs:enumeration value=""Kit"" />
        <xs:enumeration value=""Kubikdezimeter"" />
        <xs:enumeration value=""Kubikmeter pro Sekunde"" />
        <xs:enumeration value=""Lifts"" />
        <xs:enumeration value=""Link"" />
        <xs:enumeration value=""Liquid Pounds"" />
        <xs:enumeration value=""Liter"" />
        <xs:enumeration value=""Load"" />
        <xs:enumeration value=""Lot"" />
        <xs:enumeration value=""Lug"" />
        <xs:enumeration value=""Mat"" />
        <xs:enumeration value=""Megagram"" />
        <xs:enumeration value=""Megagrams Per Hour"" />
        <xs:enumeration value=""Megahertz"" />
        <xs:enumeration value=""Megapascal"" />
        <xs:enumeration value=""Megawatt"" />
        <xs:enumeration value=""Meter"" />
        <xs:enumeration value=""Meter pro Quadratsekunde"" />
        <xs:enumeration value=""Meters per second"" />
        <xs:enumeration value=""Micrograms Per Cubic Meter"" />
        <xs:enumeration value=""Micrometer"" />
        <xs:enumeration value=""Microsecond"" />
        <xs:enumeration value=""Mikrogram/cubic meter"" />
        <xs:enumeration value=""Mile"" />
        <xs:enumeration value=""Milliampere"" />
        <xs:enumeration value=""Millibar"" />
        <xs:enumeration value=""Milligram/cubic meter"" />
        <xs:enumeration value=""Milligram/kilogram"" />
        <xs:enumeration value=""Milligram/Liter"" />
        <xs:enumeration value=""Milligrams Per Cubic Meter"" />
        <xs:enumeration value=""Milligrams Per Square Meter"" />
        <xs:enumeration value=""Millijoule"" />
        <xs:enumeration value=""Milliliter"" />
        <xs:enumeration value=""Millimeter"" />
        <xs:enumeration value=""Millimeter H20"" />
        <xs:enumeration value=""Millimol"" />
        <xs:enumeration value=""Millimol/kilogram"" />
        <xs:enumeration value=""Million BTU's"" />
        <xs:enumeration value=""Millipascal seconds"" />
        <xs:enumeration value=""Millisecond"" />
        <xs:enumeration value=""Millitesla"" />
        <xs:enumeration value=""Millivolt"" />
        <xs:enumeration value=""Milliwatt"" />
        <xs:enumeration value=""Minute"" />
        <xs:enumeration value=""Miter"" />
        <xs:enumeration value=""Mol"" />
        <xs:enumeration value=""Mol/kilogram"" />
        <xs:enumeration value=""Month"" />
        <xs:enumeration value=""Multichip"" />
        <xs:enumeration value=""Nanometer"" />
        <xs:enumeration value=""Nanosecond"" />
        <xs:enumeration value=""Net Barrels"" />
        <xs:enumeration value=""Net Gallons"" />
        <xs:enumeration value=""Net Imperial Gallons"" />
        <xs:enumeration value=""Net Liters"" />
        <xs:enumeration value=""Newton"" />
        <xs:enumeration value=""Ohm"" />
        <xs:enumeration value=""One"" />
        <xs:enumeration value=""One Thousand Pieces"" />
        <xs:enumeration value=""Ounce"" />
        <xs:enumeration value=""Pack (PAK)"" />
        <xs:enumeration value=""Package"" />
        <xs:enumeration value=""Packet"" />
        <xs:enumeration value=""Pad"" />
        <xs:enumeration value=""Pail"" />
        <xs:enumeration value=""Pair"" />
        <xs:enumeration value=""Pallet"" />
        <xs:enumeration value=""Pallet (Lift)"" />
        <xs:enumeration value=""Pallet/Unit Load"" />
        <xs:enumeration value=""Pallete"" />
        <xs:enumeration value=""Panel"" />
        <xs:enumeration value=""Parcel"" />
        <xs:enumeration value=""Parts per billion (US)"" />
        <xs:enumeration value=""Parts per million"" />
        <xs:enumeration value=""Pascal"" />
        <xs:enumeration value=""Pascal second"" />
        <xs:enumeration value=""Pennyweight"" />
        <xs:enumeration value=""Per Hundred Pieces"" />
        <xs:enumeration value=""Percent"" />
        <xs:enumeration value=""Percent Per 1000 Hours"" />
        <xs:enumeration value=""Percent Weight"" />
        <xs:enumeration value=""Percentage"" />
        <xs:enumeration value=""Piece"" />
        <xs:enumeration value=""Pint - US liquid"" />
        <xs:enumeration value=""Pint U.S. Dry"" />
        <xs:enumeration value=""Plate"" />
        <xs:enumeration value=""Pound"" />
        <xs:enumeration value=""Pounds Per 1000 Square Feet"" />
        <xs:enumeration value=""Pounds Per Foot"" />
        <xs:enumeration value=""Pounds Per Gallon"" />
        <xs:enumeration value=""Pounds Per Piece of Product"" />
        <xs:enumeration value=""Pounds Per Pound of Product"" />
        <xs:enumeration value=""Pounds Per Thousand"" />
        <xs:enumeration value=""Quart - US liquid"" />
        <xs:enumeration value=""Rack"" />
        <xs:enumeration value=""Ream of 500 Sheets"" />
        <xs:enumeration value=""Reel"" />
        <xs:enumeration value=""Ring"" />
        <xs:enumeration value=""Rod"" />
        <xs:enumeration value=""Roll"" />
        <xs:enumeration value=""Sack"" />
        <xs:enumeration value=""Second"" />
        <xs:enumeration value=""SET"" />
        <xs:enumeration value=""Sheet"" />
        <xs:enumeration value=""Sheet-Metric measure"" />
        <xs:enumeration value=""Shipment"" />
        <xs:enumeration value=""Shot"" />
        <xs:enumeration value=""Skein"" />
        <xs:enumeration value=""Skid"" />
        <xs:enumeration value=""Sleeve"" />
        <xs:enumeration value=""Slip Sheet"" />
        <xs:enumeration value=""Spool"" />
        <xs:enumeration value=""Square"" />
        <xs:enumeration value=""Square foot"" />
        <xs:enumeration value=""Square inch"" />
        <xs:enumeration value=""Square kilometer"" />
        <xs:enumeration value=""Square meter"" />
        <xs:enumeration value=""Square meter/second"" />
        <xs:enumeration value=""Square mile"" />
        <xs:enumeration value=""Square millimeter"" />
        <xs:enumeration value=""Square Yard"" />
        <xs:enumeration value=""Statute Mile"" />
        <xs:enumeration value=""Stick"" />
        <xs:enumeration value=""Strip"" />
        <xs:enumeration value=""Super Bulk Bag"" />
        <xs:enumeration value=""Tablet"" />
        <xs:enumeration value=""Tank"" />
        <xs:enumeration value=""Tank Truck"" />
        <xs:enumeration value=""Tesla"" />
        <xs:enumeration value=""Thousand"" />
        <xs:enumeration value=""Ton"" />
        <xs:enumeration value=""Tonne"" />
        <xs:enumeration value=""Torr"" />
        <xs:enumeration value=""Tote"" />
        <xs:enumeration value=""Track Foot"" />
        <xs:enumeration value=""Trailer"" />
        <xs:enumeration value=""Train"" />
        <xs:enumeration value=""Tray"" />
        <xs:enumeration value=""Troy"" />
        <xs:enumeration value=""Troy OZ"" />
        <xs:enumeration value=""Truckload"" />
        <xs:enumeration value=""Tube"" />
        <xs:enumeration value=""Unitless Unit of Measure"" />
        <xs:enumeration value=""US gallon"" />
        <xs:enumeration value=""US pound"" />
        <xs:enumeration value=""US ton"" />
        <xs:enumeration value=""Vial"" />
        <xs:enumeration value=""Volt"" />
        <xs:enumeration value=""Wafer"" />
        <xs:enumeration value=""Watt"" />
        <xs:enumeration value=""Week"" />
        <xs:enumeration value=""WF"" />
        <xs:enumeration value=""Wrap"" />
        <xs:enumeration value=""Yard"" />
        <xs:enumeration value=""Year"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""ProprietaryProductIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""GlobalPartnerRoleClassificationCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:enumeration value=""Account Supplier"" />
        <xs:enumeration value=""Account User"" />
        <xs:enumeration value=""Anonymous Buyer"" />
        <xs:enumeration value=""Appointment Provider"" />
        <xs:enumeration value=""Authorized Service Provider"" />
        <xs:enumeration value=""Authorizer"" />
        <xs:enumeration value=""Buyer"" />
        <xs:enumeration value=""Catalog Distributor"" />
        <xs:enumeration value=""Catalog Producer"" />
        <xs:enumeration value=""Change Requester"" />
        <xs:enumeration value=""Change Review Forum"" />
        <xs:enumeration value=""Claim Requester"" />
        <xs:enumeration value=""Consignee"" />
        <xs:enumeration value=""Credit Provider"" />
        <xs:enumeration value=""Credit Reference Requester"" />
        <xs:enumeration value=""Customer"" />
        <xs:enumeration value=""Customer Manager"" />
        <xs:enumeration value=""Decision Stakeholder"" />
        <xs:enumeration value=""Delivery Appointment Provider"" />
        <xs:enumeration value=""Delivery Appointment Requester"" />
        <xs:enumeration value=""Demand Creator"" />
        <xs:enumeration value=""Failure Report Administrator"" />
        <xs:enumeration value=""Financing Processor"" />
        <xs:enumeration value=""Forecast Owner"" />
        <xs:enumeration value=""Forecast Recipient"" />
        <xs:enumeration value=""Forecast Reply Recipient"" />
        <xs:enumeration value=""Implementation Plan Creator"" />
        <xs:enumeration value=""Integrator"" />
        <xs:enumeration value=""In-transit Information User"" />
        <xs:enumeration value=""Inventory Information Provider"" />
        <xs:enumeration value=""Inventory Information User"" />
        <xs:enumeration value=""Invoice Provider"" />
        <xs:enumeration value=""Invoice Receiver"" />
        <xs:enumeration value=""Invoice Reject Provider"" />
        <xs:enumeration value=""Invoice Reject Receiver"" />
        <xs:enumeration value=""Marketing Activity Information User"" />
        <xs:enumeration value=""Marketing Activity Initiator"" />
        <xs:enumeration value=""Payee"" />
        <xs:enumeration value=""Payer"" />
        <xs:enumeration value=""PIP Failure Notifier"" />
        <xs:enumeration value=""Product Distributor"" />
        <xs:enumeration value=""Product Information Distributor"" />
        <xs:enumeration value=""Product Information Subscriber"" />
        <xs:enumeration value=""Product Information User"" />
        <xs:enumeration value=""Product Provider"" />
        <xs:enumeration value=""Product Supplier"" />
        <xs:enumeration value=""Qualification Owner"" />
        <xs:enumeration value=""Quality Data Provider"" />
        <xs:enumeration value=""Quality Data User"" />
        <xs:enumeration value=""Receiver"" />
        <xs:enumeration value=""Return Provider"" />
        <xs:enumeration value=""Return Receiver"" />
        <xs:enumeration value=""Return Requester"" />
        <xs:enumeration value=""Sales Facilitator"" />
        <xs:enumeration value=""Sales Lead Originator"" />
        <xs:enumeration value=""Sales Lead Processor"" />
        <xs:enumeration value=""Sales Marketing Claim Processor"" />
        <xs:enumeration value=""Sales Marketing Claimant"" />
        <xs:enumeration value=""Sales Marketing Program Reimbursement Recipient"" />
        <xs:enumeration value=""Sales Marketing Program Reimburser"" />
        <xs:enumeration value=""Seller"" />
        <xs:enumeration value=""Service Provider"" />
        <xs:enumeration value=""Shipment Information User"" />
        <xs:enumeration value=""Shipment Requester"" />
        <xs:enumeration value=""ShipmentController"" />
        <xs:enumeration value=""Shipper"" />
        <xs:enumeration value=""Solution Provider"" />
        <xs:enumeration value=""Solution Requester"" />
        <xs:enumeration value=""Specification Provider"" />
        <xs:enumeration value=""Specification User"" />
        <xs:enumeration value=""Stakeholder"" />
        <xs:enumeration value=""Status Requester"" />
        <xs:enumeration value=""Status Responder"" />
        <xs:enumeration value=""Supplier"" />
        <xs:enumeration value=""Tender Information User"" />
        <xs:enumeration value=""Transport Service Provider"" />
        <xs:enumeration value=""Warranty Provider"" />
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""expiryDate"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:DateStamp"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""totalLineItemAmount"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FinancialAmount"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalGovernmentPriorityRatingCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Atomic energy"" />
        <xs:enumeration value=""Defense"" />
        <xs:enumeration value=""Domestic energy"" />
        <xs:enumeration value=""Energy and related programs"" />
        <xs:enumeration value=""Other defense"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""RevisionNumber"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""primaryContractWith"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:PartnerDescription"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PercentAmount"">
    <xs:simpleType>
      <xs:restriction base=""xs:decimal"">
        <xs:minInclusive value=""0"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""accountName"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PhysicalAddress"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:addressLine1"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:addressLine2"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:addressLine3"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:cityName"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalCountryCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:NationalPostalCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:postOfficeBoxIdentifier"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:regionName"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalLocationIdentifier"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:PartnerLocationIdentification"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""requestedUnitPrice"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FinancialAmount"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""thisDocumentIdentifier"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProprietaryDocumentIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""facsimileNumber"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:CommunicationsNumber"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AccountDescription"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:accountName"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:AccountNumber"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:billTo"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:CreditCard"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:financedBy"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalAccountClassificationCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:prePaymentCheckNumber"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:WireTransferIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""shipTo"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:PartnerDescription"" />
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
  <xs:element name=""subLineItem"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:LineNumber"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""proprietaryInformation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""taxExemptionCertificationIdentifier"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProprietaryReferenceIdentifier"" />
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
  <xs:element name=""billTo"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:PartnerDescription"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalCarrierCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""OrderShippingInformation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:CarrierInformation"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalFreeOnBoardCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalShipmentTermsCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalShippingServiceLevelCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:GlobalSpecialFulfillmentRequestCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:packListRequirements"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:SpecialHandlingInstruction"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalPurchaseOrderFillPriorityCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""High"" />
        <xs:enumeration value=""Low"" />
        <xs:enumeration value=""Medium"" />
        <xs:enumeration value=""Priority 1"" />
        <xs:enumeration value=""Priority 2"" />
        <xs:enumeration value=""Priority 3"" />
        <xs:enumeration value=""Priority 4"" />
        <xs:enumeration value=""Priority 5"" />
        <xs:enumeration value=""Priority 6"" />
        <xs:enumeration value=""Priority 7"" />
        <xs:enumeration value=""Priority 8"" />
        <xs:enumeration value=""Priority 9"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""FinancingTerms"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalFinanceTermsCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:PaymentTerms"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalTaxExemptionCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Agriculture"" />
        <xs:enumeration value=""Direct pay ID"" />
        <xs:enumeration value=""Disabled"" />
        <xs:enumeration value=""Disabled veteran"" />
        <xs:enumeration value=""Exempt - for export"" />
        <xs:enumeration value=""Exempt - for resale"" />
        <xs:enumeration value=""Exempt - from county property tax"" />
        <xs:enumeration value=""Exempt - from local property tax"" />
        <xs:enumeration value=""Exempt - from school property tax"" />
        <xs:enumeration value=""Exempt - from state property tax"" />
        <xs:enumeration value=""Exempt - goods and services tax"" />
        <xs:enumeration value=""Exempt - letter on file"" />
        <xs:enumeration value=""Exempt - local service"" />
        <xs:enumeration value=""Exempt - not for resale"" />
        <xs:enumeration value=""Exempt - per State law"" />
        <xs:enumeration value=""Exempt - Provincial sales tax"" />
        <xs:enumeration value=""Exempt - sale to U.S. government"" />
        <xs:enumeration value=""Exempt - toll service"" />
        <xs:enumeration value=""Homestead"" />
        <xs:enumeration value=""Labor taxable - material exempt"" />
        <xs:enumeration value=""Material taxable - labor exempt"" />
        <xs:enumeration value=""Non-homestead"" />
        <xs:enumeration value=""Not exempt - for resale"" />
        <xs:enumeration value=""Not exempt - not for resale"" />
        <xs:enumeration value=""Not taxable"" />
        <xs:enumeration value=""Open space"" />
        <xs:enumeration value=""Other property tax exemption"" />
        <xs:enumeration value=""Over 65"" />
        <xs:enumeration value=""Recurring exempt"" />
        <xs:enumeration value=""Totally exempt"" />
        <xs:enumeration value=""Usage exempt"" />
        <xs:enumeration value=""Working farm"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""ProprietaryDocumentIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""isDropShip"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:AffirmationIndicator"" />
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
  <xs:element name=""ProprietaryDomainIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""TaxExemption"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:GlobalTaxExemptionCode"" />
        <xs:element ref=""ns0:taxExemptionCertificationIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalPaymentConditionCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""thisDocumentGenerationDateTime"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:DateTimeStamp"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SpecialHandlingInstruction"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:GlobalSpecialHandlingCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:specialHandlingText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ProprietaryBusinessIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""ContactInformation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:contactName"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:EmailAddress"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:facsimileNumber"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:telephoneNumber"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:PhysicalLocation"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""percentDue"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:PercentAmount"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GlobalMonetaryAmountTypeCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Credit"" />
        <xs:enumeration value=""Debit"" />
        <xs:enumeration value=""Zero Remit"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""ProductLineItem"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:comments"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:ContractInformation"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:countryOfOrigin"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:CustomerInformation"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:DocumentReference"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:expediteReferenceIdentifier"" />
        <xs:element ref=""ns0:GlobalProductUnitOfMeasureCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:GlobalPurchaseOrderFillPriorityCode"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:installAt"" />
        <xs:element ref=""ns0:isDropShip"" />
        <xs:element ref=""ns0:LineNumber"" />
        <xs:element ref=""ns0:OrderQuantity"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:OrderShippingInformation"" />
        <xs:element ref=""ns0:ProductIdentification"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:ProductSubLineItem"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:proprietaryInformation"" />
        <xs:element ref=""ns0:requestedEvent"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ns0:requestedShipFrom"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:requestedUnitPrice"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:shipTo"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:TaxExemptStatus"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ns0:totalLineItemAmount"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""creditCardIdentifier"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:ProprietaryReferenceIdentifier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""WireTransferIdentifier"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""revisionIdentifier"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""cardHolderName"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:FreeFormText"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AccountNumber"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:maxLength value=""35"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
  <xs:element name=""GlobalPartnerClassificationCode"">
    <xs:simpleType>
      <xs:restriction base=""xs:string"">
        <xs:minLength value=""1"" />
        <xs:enumeration value=""Broker"" />
        <xs:enumeration value=""Carrier"" />
        <xs:enumeration value=""Contract Manufacturer"" />
        <xs:enumeration value=""Customs Broker"" />
        <xs:enumeration value=""Distribution Center"" />
        <xs:enumeration value=""Distributor"" />
        <xs:enumeration value=""End User"" />
        <xs:enumeration value=""End User Government"" />
        <xs:enumeration value=""Financier"" />
        <xs:enumeration value=""Freight Forwarder"" />
        <xs:enumeration value=""Manufacturer"" />
        <xs:enumeration value=""Original Equipment Manufacturer"" />
        <xs:enumeration value=""Reseller"" />
        <xs:enumeration value=""Retailer"" />
        <xs:enumeration value=""Shopper"" />
        <xs:enumeration value=""Warehouser"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:element>
</xs:schema>";
        
        public _3A4_MS_V02_02_PurchaseOrderRequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Pip3A4PurchaseOrderRequest";
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
