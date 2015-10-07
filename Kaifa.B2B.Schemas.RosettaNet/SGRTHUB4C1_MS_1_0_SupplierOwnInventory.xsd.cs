namespace Kaifa.B2B.Schemas.RosettaNet {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://kaifa.b2b.schemas/SGRTHUB4C1_MS_1_0_SupplierOwnInventory",@"Pip4C1InventoryReportNotification")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "thisDocumentIdentifier.ProprietaryDocumentIdentifier", XPath = @"/*[local-name()='Pip4C1InventoryReportNotification' and namespace-uri()='http://kaifa.b2b.schemas/SGRTHUB4C1_MS_1_0_SupplierOwnInventory']/*[local-name()='thisDocumentIdentifier' and namespace-uri()='http://kaifa.b2b.schemas/SGRTHUB4C1_MS_1_0_SupplierOwnInventory']/*[local-name()='ProprietaryDocumentIdentifier' and namespace-uri()='http://kaifa.b2b.schemas/SGRTHUB4C1_MS_1_0_SupplierOwnInventory']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Pip4C1InventoryReportNotification"})]
    public sealed class SGRTHUB4C1_MS_1_0_SupplierOwnInventory : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://kaifa.b2b.schemas/SGRTHUB4C1_MS_1_0_SupplierOwnInventory"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://kaifa.b2b.schemas/SGRTHUB4C1_MS_1_0_SupplierOwnInventory"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Pip4C1InventoryReportNotification"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Pip4C1InventoryReportNotification' and namespace-uri()='http://kaifa.b2b.schemas/SGRTHUB4C1_MS_1_0_SupplierOwnInventory']/*[local-name()='thisDocumentIdentifier' and namespace-uri()='http://kaifa.b2b.schemas/SGRTHUB4C1_MS_1_0_SupplierOwnInventory']/*[local-name()='ProprietaryDocumentIdentifier' and namespace-uri()='http://kaifa.b2b.schemas/SGRTHUB4C1_MS_1_0_SupplierOwnInventory']"" />
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
                                <xs:element name=""BusinessIdentification"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""GlobalBusinessIdentifier"" type=""xs:string"" />
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
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
        <xs:element name=""InventoryReport"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""inventoryReportDateTime"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""DateTimeStamp"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element maxOccurs=""unbounded"" name=""InventoryReportLineItem"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""GlobalProductUnitOfMeasureCode"" type=""xs:string"" />
                    <xs:element name=""inventoryLocation"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""PartnerDescription"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""BusinessDescription"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""BusinessIdentification"">
                                        <xs:complexType>
                                          <xs:sequence>
                                            <xs:element name=""GlobalBusinessIdentifier"" type=""xs:string"" />
                                          </xs:sequence>
                                        </xs:complexType>
                                      </xs:element>
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
                    <xs:element name=""InventoryProductQuantity"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""GlobalInventoryCode"" type=""xs:string"" />
                          <xs:element name=""InventoryItemIdentification"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""manufactureDate"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""DateTimeStamp"" type=""xs:string"" />
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                                <xs:element name=""ProprietaryLotIdentifier"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""ProductQuantity"" type=""xs:string"" />
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
                                <xs:element name=""ProprietaryProductIdentifier"" type=""xs:string"" />
                                <xs:element name=""revisionIdentifier"">
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
                                <xs:element name=""BusinessIdentification"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""GlobalBusinessIdentifier"" type=""xs:string"" />
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
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
        
        public SGRTHUB4C1_MS_1_0_SupplierOwnInventory() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Pip4C1InventoryReportNotification";
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
