namespace Kaifa.B2B.Schemas.RosettaNet {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://kaifa.b2b.schemas/Pip3B2AdvanceShipmentNotification",@"Pip3B2AdvanceShipmentNotification")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "thisDocumentIdentifier.ProprietaryDocumentIdentifier", XPath = @"/*[local-name()='Pip3B2AdvanceShipmentNotification' and namespace-uri()='http://kaifa.b2b.schemas/Pip3B2AdvanceShipmentNotification']/*[local-name()='thisDocumentIdentifier' and namespace-uri()='http://kaifa.b2b.schemas/Pip3B2AdvanceShipmentNotification']/*[local-name()='ProprietaryDocumentIdentifier' and namespace-uri()='http://kaifa.b2b.schemas/Pip3B2AdvanceShipmentNotification']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Pip3B2AdvanceShipmentNotification"})]
    public sealed class Pip3B2AdvanceShipmentNotification : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://kaifa.b2b.schemas/Pip3B2AdvanceShipmentNotification"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://kaifa.b2b.schemas/Pip3B2AdvanceShipmentNotification"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Pip3B2AdvanceShipmentNotification"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Pip3B2AdvanceShipmentNotification' and namespace-uri()='http://kaifa.b2b.schemas/Pip3B2AdvanceShipmentNotification']/*[local-name()='thisDocumentIdentifier' and namespace-uri()='http://kaifa.b2b.schemas/Pip3B2AdvanceShipmentNotification']/*[local-name()='ProprietaryDocumentIdentifier' and namespace-uri()='http://kaifa.b2b.schemas/Pip3B2AdvanceShipmentNotification']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""AdvancedShipmentNotification"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""BuyingPartner"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""purchasedBy"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""PartnerDescription"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""BusinessDescription"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""GlobalBusinessIdentifier"" type=""xs:string"" />
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
              <xs:element name=""OriginatingPartner"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""shipFrom"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""PartnerDescription"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""BusinessDescription"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""GlobalBusinessIdentifier"" type=""xs:string"" />
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
              <xs:element name=""SellingPartner"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""soldBy"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""PartnerDescription"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""BusinessDescription"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""GlobalBusinessIdentifier"" type=""xs:string"" />
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
              <xs:element name=""Shipment"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""GlobalCarrierCode"" type=""xs:string"" />
                    <xs:element name=""GlobalShippingServiceLevelCode"" type=""xs:string"" />
                    <xs:element name=""numberOfShippingContainers"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""CountableAmount"" type=""xs:unsignedByte"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""ReceivingPartner"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""shipto"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""PartnerDescription"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""BusinessDescription"">
                                        <xs:complexType>
                                          <xs:sequence>
                                            <xs:element name=""GlobalBusinessIdentifier"" type=""xs:string"" />
                                          </xs:sequence>
                                        </xs:complexType>
                                      </xs:element>
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
                                            <xs:element name=""PhysicalAddress"">
                                              <xs:complexType>
                                                <xs:sequence>
                                                  <xs:element name=""GlobalCountryCode"" type=""xs:string"" />
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
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""shipmentIdentifier"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""ProprietaryReferenceIdentifier"" type=""xs:unsignedByte"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""ShippingContainer"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""shippingContainerIdentifier"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""ProprietarySerialIdentifier"" type=""xs:unsignedByte"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element maxOccurs=""unbounded"" name=""ShippingContainerItem"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element maxOccurs=""unbounded"" name=""DocumentSubLineLotShipReference"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""GlobalDocumentReferenceTypeCode"" type=""xs:string"" />
                                      <xs:element name=""ProprietaryDocumentIdentifier"" type=""xs:string"" />
                                      <xs:element minOccurs=""0"" name=""SeagateProprietarySite"" type=""xs:string"" />
                                      <xs:element name=""SeagateProprietaryComCode"" type=""xs:string"" />
                                      <xs:element maxOccurs=""unbounded"" name=""SeagateProprietaryItems"">
                                        <xs:complexType>
                                          <xs:sequence>
                                            <xs:element name=""SeagateProprietaryPart"" type=""xs:string"" />
                                            <xs:element name=""SeagateProprietaryKitQty"" type=""xs:string"" />
                                            <xs:element name=""SeagateProprietaryPartStatus"" type=""xs:string"" />
                                            <xs:element name=""SeagateProprietaryRemarks"" type=""xs:string"" />
                                            <xs:element name=""SeagateProprietaryDONumber"" type=""xs:string"" />
                                            <xs:element minOccurs=""0"" name=""SeagateProprietaryVendorCode"" type=""xs:string"" />
                                            <xs:element name=""SeagateProprietaryPONumber"" type=""xs:string"" />
                                            <xs:element name=""SeagateProprietaryTransactionDate"" type=""xs:string"" />
                                            <xs:element name=""SeagateProprietaryTransactionType"" type=""xs:string"" />
                                            <xs:element name=""SeagateProprietaryTradingPartnerDONumber"" type=""xs:string"" />
                                          </xs:sequence>
                                        </xs:complexType>
                                      </xs:element>
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                                <xs:element name=""GlobalProductUnitOfMeasureCode"" type=""xs:string"" />
                                <xs:element name=""isContainsHazardousMaterial"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""AffirmationIndicator"" type=""xs:string"" />
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                                <xs:element name=""ProductIdentification"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""PartnerProductIdentification"">
                                        <xs:complexType>
                                          <xs:sequence>
                                            <xs:element name=""GlobalPartnerClassificationCode"" type=""xs:string"" />
                                            <xs:element name=""ProprietaryProductIdentifier"" type=""xs:unsignedByte"" />
                                          </xs:sequence>
                                        </xs:complexType>
                                      </xs:element>
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                                <xs:element name=""shippedQuantity"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""ProductQuantity"" type=""xs:unsignedByte"" />
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""transportedBy"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""PartnerDescription"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""BusinessDescription"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""GlobalBusinessIdentifier"" type=""xs:string"" />
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
            </xs:sequence>
          </xs:complexType>
        </xs:element>
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
        
        public Pip3B2AdvanceShipmentNotification() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Pip3B2AdvanceShipmentNotification";
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
