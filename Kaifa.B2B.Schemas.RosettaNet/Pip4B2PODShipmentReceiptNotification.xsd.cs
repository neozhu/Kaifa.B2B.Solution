namespace Kaifa.B2B.Schemas.RosettaNet {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://kaifa.b2b.schemas/Pip4B2PODShipmentReceiptNotification",@"Pip4B2ShipmentReceiptNotification")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "thisDocumentIdentifier.ProprietaryDocumentIdentifier", XPath = @"/*[local-name()='Pip4B2ShipmentReceiptNotification' and namespace-uri()='http://kaifa.b2b.schemas/Pip4B2PODShipmentReceiptNotification']/*[local-name()='thisDocumentIdentifier' and namespace-uri()='http://kaifa.b2b.schemas/Pip4B2PODShipmentReceiptNotification']/*[local-name()='ProprietaryDocumentIdentifier' and namespace-uri()='http://kaifa.b2b.schemas/Pip4B2PODShipmentReceiptNotification']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Pip4B2ShipmentReceiptNotification"})]
    public sealed class Pip4B2PODShipmentReceiptNotification : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://kaifa.b2b.schemas/Pip4B2PODShipmentReceiptNotification"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://kaifa.b2b.schemas/Pip4B2PODShipmentReceiptNotification"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Pip4B2ShipmentReceiptNotification"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Pip4B2ShipmentReceiptNotification' and namespace-uri()='http://kaifa.b2b.schemas/Pip4B2PODShipmentReceiptNotification']/*[local-name()='thisDocumentIdentifier' and namespace-uri()='http://kaifa.b2b.schemas/Pip4B2PODShipmentReceiptNotification']/*[local-name()='ProprietaryDocumentIdentifier' and namespace-uri()='http://kaifa.b2b.schemas/Pip4B2PODShipmentReceiptNotification']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""fromRole"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""PartnerRoleDescription"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ContactInformation"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""contactName"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""FreeFormText"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""EmailAddress"" type=""xs:string"" />
                          <xs:element name=""facsimileNumber"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""CommunicationsNumber"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""telephoneNumber"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""CommunicationsNumber"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""GlobalPartnerRoleClassificationCode"" type=""xs:string"" />
                    <xs:element name=""PartnerDescription"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""BusinessDescription"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""GlobalBusinessIdentifier"" type=""xs:string"" />
                                <xs:element name=""GlobalSupplyChainCode"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""GlobalPartnerClassificationCode"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""GlobalDocumentFunctionCode"" type=""xs:string"" />
        <xs:element maxOccurs=""unbounded"" name=""ShipmentReceiptInformationResource"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""shipmentIdentifier"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ProprietaryReferenceIdentifier"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""ShipmentReceiptNotificationLineItem"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""acceptedQuantity"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""ProductQuantity"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""DocumentSubLineReference"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""GlobalDocumentReferenceTypeCode"" type=""xs:string"" />
                          <xs:element name=""LineNumber"" type=""xs:unsignedByte"" />
                          <xs:element name=""ProprietaryDocumentIdentifier"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""GlobalProductUnitOfMeasureCode"" type=""xs:string"" />
                    <xs:element name=""ProductIdentification"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""PartnerProductIdentification"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""GlobalPartnerClassificationCode"" type=""xs:string"" />
                                <xs:element name=""ProprietaryProductIdentifier"" type=""xs:string"" />
                                <xs:element name=""SeagateProprietaryTransactionType"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""FreeFormText"" type=""xs:string"" />
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                                <xs:element name=""SeagateProprietaryRTVReason"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""FreeFormText"" type=""xs:string"" />
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                                <xs:element name=""SeagateProprietaryPOBalance"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""receivedBy"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""PartnerDescription"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""BusinessDescription"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""GlobalBusinessIdentifier"" type=""xs:string"" />
                                      <xs:element name=""businessName"">
                                        <xs:complexType>
                                          <xs:sequence>
                                            <xs:element name=""FreeFormText"" type=""xs:string"" />
                                          </xs:sequence>
                                        </xs:complexType>
                                      </xs:element>
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""receivedQuantity"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""ProductQuantity"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""shipmentReceiptReportDateTime"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""DateTimeStamp"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""TrackingReference"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""GlobalTrackingReferenceTypeCode"" type=""xs:string"" />
                    <xs:element name=""ProprietaryShipmentTrackingIdentifier"" type=""xs:string"" />
                    <xs:element name=""SeagateProprietaryDONumber"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""thisDocumentGenerationDateTime"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""DateTimeStamp"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""thisDocumentIdentifier"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ProprietaryDocumentIdentifier"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""toRole"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""PartnerRoleDescription"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""GlobalPartnerRoleClassificationCode"" type=""xs:string"" />
                    <xs:element name=""PartnerDescription"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""BusinessDescription"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""GlobalBusinessIdentifier"" type=""xs:string"" />
                                <xs:element name=""GlobalSupplyChainCode"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""GlobalPartnerClassificationCode"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Pip4B2PODShipmentReceiptNotification() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Pip4B2ShipmentReceiptNotification";
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
