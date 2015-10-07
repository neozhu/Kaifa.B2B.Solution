namespace Kaifa.B2B.PipSchema.Extendtion {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://schemas.microsoft.com/biztalk/btarn/2004/SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification.dtd",@"Pip4B2ShipmentReceiptNotification")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Pip4B2ShipmentReceiptNotification"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes", typeof(Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.PipSchema.Extendtion.xml", typeof(Kaifa.B2B.PipSchema.Extendtion.xml))]
    public sealed class SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns0=""http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://schemas.microsoft.com/biztalk/btarn/2004/SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification.dtd"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/biztalk/btarn/2004/SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification.dtd"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" namespace=""http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" />
  <xs:import schemaLocation=""Kaifa.B2B.PipSchema.Extendtion.xml"" namespace=""http://www.w3.org/XML/1998/namespace"" />
  <xs:annotation>
    <xs:appinfo>
      <schemaInfo document_type=""SG4B2"" version=""SG01.00"" root_reference=""Pip4B2ShipmentReceiptNotification"" displayroot_reference=""Pip4B2ShipmentReceiptNotification"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
      <b:references>
        <b:reference targetNamespace=""http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" />
        <b:reference targetNamespace=""http://www.w3.org/XML/1998/namespace"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Pip4B2ShipmentReceiptNotification"">
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
              <xs:element maxOccurs=""unbounded"" name=""ShipmentReceiptNotificationLineItem"">
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
                          <xs:element name=""LineNumber"" type=""xs:string"" />
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
                                <xs:element name=""SeagateProprietaryLocator"">
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
        
        private static Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes  __DummyVar0;
        
        public SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification() {
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
