namespace RosettaNet.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"BusinessServiceInformation", @"ContractInformation", @"CorrelationInformation", @"DocumentHeader", @"DocumentIdentification", @"DocumentInformation", @"DocumentManifest", @"DocumentSecurity", @"ManifestItem", @"Receiver", @"RequestingDocumentInformation", @"Sender"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.PartnerIdentification1", typeof(RosettaNet.Schemas.Universal.PartnerIdentification1))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.ContactInformation", typeof(RosettaNet.Schemas.Universal.ContactInformation))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.CodeList.RN_MimeTypeQualifier", typeof(RosettaNet.Schemas.Universal.CodeList.RN_MimeTypeQualifier))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RosettaNet.Schemas.Universal.CodeList.ISO_Language", typeof(RosettaNet.Schemas.Universal.CodeList.ISO_Language))]
    public sealed class StandardDocumentHeader : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:uptrn=""urn:rosettanet:specification:universal:PartnerIdentification:xsd:schema:1.0"" xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"" xmlns:tns=""urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:urmyq=""urn:rosettanet:specification:universal:MimeTypeQualifier:xsd:codelist:1.0"" xmlns:uslng=""urn:rosettanet:specification:universal:Language:xsd:codelist:1.0"" xmlns:ucttf=""urn:rosettanet:specification:universal:ContactInformation:xsd:schema:1.0"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.PartnerIdentification1"" namespace=""urn:rosettanet:specification:universal:PartnerIdentification:xsd:schema:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.ContactInformation"" namespace=""urn:rosettanet:specification:universal:ContactInformation:xsd:schema:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.CodeList.RN_MimeTypeQualifier"" namespace=""urn:rosettanet:specification:universal:MimeTypeQualifier:xsd:codelist:1.0"" />
  <xs:import schemaLocation=""RosettaNet.Schemas.Universal.CodeList.ISO_Language"" namespace=""urn:rosettanet:specification:universal:Language:xsd:codelist:1.0"" />
  <xs:annotation>
    <xs:documentation>
      <urss:Copyright xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">© 2004 RosettaNet. All rights reserved. No part of this publication may be reproduced, stored in a retrieval system, or transmitted, in any form or by any means, electronic, mechanical, photocopying, recording, or otherwise, without the inclusion of this copyright notice. Any derivative works must cite the copyright notice. Any public redistribution or sale of this publication or derivative works requires prior written permission of the publisher.</urss:Copyright>
      <urss:Disclaimer xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">RosettaNet makes no representation about the suitability of this work for any purpose or regarding any claims made by products which use it.  It is provided as is without expressed or implied warranty.</urss:Disclaimer>
      <urss:Program xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">PIP Specification Format Foundational Program</urss:Program>
      <urss:Purpose xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Collection of structures that describes the UN/CEFACT Standard Business Document Header Technical Specification.</urss:Purpose>
    </xs:documentation>
    <xs:appinfo>
      <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
      <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""urn:rosettanet:specification:universal:DataType:xsd:schema:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:CountrySubdivision:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:MimeTypeQualifier:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:ContactInformation:xsd:schema:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:ProcessRoleIdentifier:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:Language:xsd:codelist:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:AbstractType:xsd:schema:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:PartnerIdentification:xsd:schema:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:Locations:xsd:schema:1.0"" />
        <reference targetNamespace=""urn:rosettanet:specification:universal:Country:xsd:codelist:1.0"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""BusinessServiceInformation"" type=""tns:BusinessServiceInformationType"" />
  <xs:element name=""ContractInformation"" type=""tns:ContractInformationType"" />
  <xs:element name=""CorrelationInformation"" type=""tns:CorrelationInformationType"" />
  <xs:element name=""DocumentHeader"" type=""tns:DocumentHeaderType"" />
  <xs:element name=""DocumentIdentification"" type=""tns:DocumentIdentificationType"" />
  <xs:element name=""DocumentInformation"" type=""tns:DocumentInformationType"" />
  <xs:element name=""DocumentManifest"" type=""tns:DocumentManifestType"" />
  <xs:element name=""DocumentSecurity"" type=""tns:DocumentSecurityType"" />
  <xs:element name=""ManifestItem"" type=""tns:ManifestItemType"" />
  <xs:element name=""Receiver"" type=""tns:ReceiverType"" />
  <xs:element name=""RequestingDocumentInformation"" type=""tns:RequestingDocumentInformationType"" />
  <xs:element name=""Sender"" type=""tns:SenderType"" />
  <xs:complexType name=""BusinessServiceInformationType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The object allows the specification of the business service utilized within the partner company.  This may or may not be the same as the information sent by the RNIF. </urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element name=""ActionName"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The name of Action. For RosettaNet usually any of Request/Confirm/Notify/Query/Response.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element name=""ProcessIdentifier"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The name of the PIP e.g. Notify of Forecast Reply.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ProcessReference"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The URN for the PIP that includes Cluster/Segment/Process pattern used to identify the interface process (such as PIP3A4) </urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ProcessState"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The business process (or service) state of the sender of a document. When a service receives this document, the receiver may use the state as a precondition.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element name=""ServiceName"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The name of the Business Activity with the ""Request/Confirm"" part removed. E.g.,  for the Activity ""Request Purchase Order""==&gt; ""Purchase Order"".</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""ContractInformationType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A block of information used to correlate a contract in an executing choreography.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ContractIdentifier"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Unique identification of a contract between the Sender and the Receiver</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ContractType"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The type of the contract: an attribute describing the type of the ContractIndentification. Valid values are URI, URN,ebXMLCPA, or other values defined by partners.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""CorrelationInformationType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A block of information used to correlate a requesting document to a responding document and to the contract in an executing choreography.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" ref=""tns:ContractInformation"" />
      <xs:element minOccurs=""0"" ref=""tns:RequestingDocumentInformation"" />
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""DocumentHeaderType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The object allows for the identification of the sender and receiver of the business document. </urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" ref=""tns:CorrelationInformation"" />
      <xs:element ref=""tns:DocumentInformation"" />
      <xs:element minOccurs=""0"" name=""HeaderVersion"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The UN/CEFACT version of the document header.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element ref=""tns:Receiver"" />
      <xs:element ref=""tns:Sender"" />
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""DocumentIdentificationType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The object specifies all information necessary to identify the business document.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element name=""Identifier"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The unique identifier for the document being sent.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Standard"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Identifies the standard used to submit the business document. (e.g. RosettaNet).</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Type"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Name of the Action Message.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Version"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">PIP3A4v01.00</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""DocumentInformationType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The object specifies information to identify the business document, a summary of attachments, and information about the business document security.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element name=""Creation"" type=""xs:dateTime"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The creation date and time of the specified Business Document (i.e. the Purchase Order date).</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element ref=""tns:DocumentIdentification"" />
      <xs:element minOccurs=""0"" ref=""tns:DocumentManifest"" />
      <xs:element minOccurs=""0"" ref=""tns:DocumentSecurity"" />
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""DocumentManifestType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The block provides a brief summary of attachments and Service Content.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" ref=""tns:ManifestItem"" />
      <xs:element minOccurs=""0"" name=""MultipleType"" type=""xs:boolean"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Indicates whether the manifest contains documents of multiple types. True if yes, and False if no.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element name=""NumberOfItems"" type=""xs:positiveInteger"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">Total number of documents in the message. The physical count of the attachments in the payload plus the RosettaNet Business Message (for Service Content). The value of this field will be at least 1.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""DocumentSecurityType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The object provides additional granularity in specifying business document security (this is in addition to the specified PIP security).</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element name=""NonRepudiableReceipt"" type=""xs:boolean"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The value ""true"" will indicate that a signed acknowledgement for the business document is necessary.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element name=""PersistentEncryption"" type=""xs:boolean"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The value ""true"" will indicate that the Business Document (including the header) needs to be encrypted when stored or transported.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element name=""PersistentSignature"" type=""xs:boolean"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The value ""true"" will indicate that a signature is required to be stored with the document while stored or transported.
</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""ManifestItemType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The object provides details about the specific attachment(s).</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Description"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A description of the attachment.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Language"" type=""uslng:LanguageType"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">For representation of Language name RosettaNet has adopted  ISO 639-2; 1998. Refer to the following web page to get the latest version of the standard:

http://www.loc.gov/standards/iso639-2/iso639jac.html

If you need more information about the ISO standard please contact ISO for more details.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""Length"" type=""xs:positiveInteger"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The size of the attachment in bytes (i.e. 1 000 000 bytes)</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element name=""MimeTypeQualifier"" type=""urmyq:MimeTypeQualifierType"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The MIME type as defined by IANA. 

Please refer to http://www.iana.org/assignments/media-types/ for a list of types.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element name=""UniversalResourceIdentifier"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The generic set of all names/addresses that are short strings that refer to resources. </urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""ReceiverType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The object allows the identification of the receiving party of the business message.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" ref=""tns:BusinessServiceInformation"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ucttf:ContactInformation"" />
      <xs:element ref=""uptrn:PartnerIdentification"" />
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""RequestingDocumentInformationType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">A block of information used to correlate a requesting document to a responding document in an executing choreography.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""BusinessProcessInstanceIdentifier"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The identifier for the public business process instance being sent that both the sender and receiver can identify.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""RequestingDocumentCreationDateTime"" type=""xs:dateTime"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The date-time of the requesting business document.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element name=""RequestingDocumentInstanceIdentifier"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The Business Document identification number that identifies the requesting Business Document.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ResponseDateTime"" type=""xs:dateTime"">
        <xs:annotation>
          <xs:appinfo>
            <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The expected time to receive the response. This can not be greater than the PIP TimeToPerform.</urss:Definition>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
  <xs:complexType name=""SenderType"">
    <xs:annotation>
      <xs:appinfo>
        <urss:Definition xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">The object allows the identification of the initiating party of the business message.</urss:Definition>
        <urss:CreationDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:CreationDate>
        <urss:LastUpdatedDate xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">08/03/2004</urss:LastUpdatedDate>
        <urss:TypeVersion xmlns:urss=""urn:rosettanet:specification:system:xml:1.0"">1.0</urss:TypeVersion>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" ref=""tns:BusinessServiceInformation"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ucttf:ContactInformation"" />
      <xs:element ref=""uptrn:PartnerIdentification"" />
    </xs:sequence>
    <xs:attribute fixed=""1.0"" name=""schemaVersion"" type=""xs:token"" />
  </xs:complexType>
</xs:schema>";
        
        public StandardDocumentHeader() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [12];
                _RootElements[0] = "BusinessServiceInformation";
                _RootElements[1] = "ContractInformation";
                _RootElements[2] = "CorrelationInformation";
                _RootElements[3] = "DocumentHeader";
                _RootElements[4] = "DocumentIdentification";
                _RootElements[5] = "DocumentInformation";
                _RootElements[6] = "DocumentManifest";
                _RootElements[7] = "DocumentSecurity";
                _RootElements[8] = "ManifestItem";
                _RootElements[9] = "Receiver";
                _RootElements[10] = "RequestingDocumentInformation";
                _RootElements[11] = "Sender";
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
        
        [Schema(@"urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0",@"BusinessServiceInformation")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BusinessServiceInformation"})]
        public sealed class BusinessServiceInformation : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BusinessServiceInformation() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BusinessServiceInformation";
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
        
        [Schema(@"urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0",@"ContractInformation")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ContractInformation"})]
        public sealed class ContractInformation : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ContractInformation() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ContractInformation";
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
        
        [Schema(@"urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0",@"CorrelationInformation")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CorrelationInformation"})]
        public sealed class CorrelationInformation : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CorrelationInformation() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CorrelationInformation";
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
        
        [Schema(@"urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0",@"DocumentHeader")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DocumentHeader"})]
        public sealed class DocumentHeader : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DocumentHeader() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DocumentHeader";
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
        
        [Schema(@"urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0",@"DocumentIdentification")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DocumentIdentification"})]
        public sealed class DocumentIdentification : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DocumentIdentification() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DocumentIdentification";
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
        
        [Schema(@"urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0",@"DocumentInformation")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DocumentInformation"})]
        public sealed class DocumentInformation : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DocumentInformation() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DocumentInformation";
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
        
        [Schema(@"urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0",@"DocumentManifest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DocumentManifest"})]
        public sealed class DocumentManifest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DocumentManifest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DocumentManifest";
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
        
        [Schema(@"urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0",@"DocumentSecurity")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DocumentSecurity"})]
        public sealed class DocumentSecurity : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DocumentSecurity() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DocumentSecurity";
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
        
        [Schema(@"urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0",@"ManifestItem")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ManifestItem"})]
        public sealed class ManifestItem : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ManifestItem() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ManifestItem";
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
        
        [Schema(@"urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0",@"Receiver")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Receiver"})]
        public sealed class Receiver : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Receiver() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Receiver";
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
        
        [Schema(@"urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0",@"RequestingDocumentInformation")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"RequestingDocumentInformation"})]
        public sealed class RequestingDocumentInformation : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public RequestingDocumentInformation() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "RequestingDocumentInformation";
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
        
        [Schema(@"urn:rosettanet:specification:system:StandardDocumentHeader:xsd:schema:1.0",@"Sender")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Sender"})]
        public sealed class Sender : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Sender() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Sender";
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
