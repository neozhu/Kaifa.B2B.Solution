namespace Kaifa.B2B.PipSchema.Extendtion {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd",@"Pip0A1FailureNotification")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Pip0A1FailureNotification"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Kaifa.B2B.PipSchema.Extendtion.xml", typeof(Kaifa.B2B.PipSchema.Extendtion.xml))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes", typeof(Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes))]
    public sealed class Pip0A1FailureNotification : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns0=""http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd"" xmlns:ns1=""http://www.w3.org/XML/1998/namespace"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/biztalk/btarn/2004/0A1_MS_V02_00_FailureNotification.dtd"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Kaifa.B2B.PipSchema.Extendtion.xml"" namespace=""http://www.w3.org/XML/1998/namespace"" />
  <xs:import schemaLocation=""Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" namespace=""http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" />
  <xs:annotation>
    <xs:appinfo>
      <schemaInfo document_type=""0A1"" version=""V02_00"" root_reference=""Pip0A1FailureNotification"" displayroot_reference=""Pip0A1FailureNotification"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
      <b:references>
        <b:reference targetNamespace=""http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" />
        <b:reference targetNamespace=""http://www.w3.org/XML/1998/namespace"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Pip0A1FailureNotification"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""ActionControl"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ActionIdentity"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""GlobalBusinessActionCode"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""messageTrackingID"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""InstanceIdentifier"" type=""xs:unsignedByte"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""failedInitiatingDocumentDateTime"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""DateTimeStamp"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""failedInitiatingDocumentIdentifier"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ProprietaryDocumentIdentifier"" type=""xs:string"" />
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
                          <xs:element name=""telephoneNumber"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""CommunicationsNumber"" type=""xs:unsignedLong"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""EmailAddress"" type=""xs:string"" />
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
                                <xs:element name=""GlobalBusinessIdentifier"" type=""xs:unsignedInt"" />
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
        <xs:element name=""ProcessIdentity"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""GlobalProcessIndicatorCode"" type=""xs:string"" />
              <xs:element name=""InstanceIdentifier"" type=""xs:unsignedByte"" />
              <xs:element name=""VersionIdentifier"" type=""xs:decimal"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""reason"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""FreeFormText"" type=""xs:string"" />
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
                                <xs:element name=""GlobalBusinessIdentifier"" type=""xs:unsignedInt"" />
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
        
        public Pip0A1FailureNotification() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Pip0A1FailureNotification";
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
