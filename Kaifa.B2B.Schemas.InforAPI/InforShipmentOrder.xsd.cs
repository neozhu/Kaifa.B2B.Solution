namespace Kaifa.B2B.Schemas.InforAPI {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Kaifa.B2B.Schemas.InforAPI/InforShipmentOrder",@"Message")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Message"})]
    public sealed class InforShipmentOrder : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://Kaifa.B2B.Schemas.InforAPI/InforShipmentOrder"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://Kaifa.B2B.Schemas.InforAPI/InforShipmentOrder"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Message"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Head"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""MessageType"" type=""xs:string"" />
              <xs:element name=""Sender"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""SystemID"" type=""xs:string"" />
                    <xs:element name=""User"" type=""xs:string"" />
                    <xs:element name=""Password"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""Recipient"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""SystemID"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Body"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ShipmentOrder"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ShipmentOrderHeader"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""StorerKey"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""OrderKey"" type=""xs:string"" />
                          <xs:element name=""ExternOrderKey"" type=""xs:string"" />
                          <xs:element name=""ExternalOrderKey2"" type=""xs:string"" />
                          <xs:element name=""ConsigneeKey"" type=""xs:string"" />
                          <xs:element name=""RequestedShipDate"" type=""xs:string"" />
                          <xs:element name=""Type"" type=""xs:string"" />
                          <xs:element maxOccurs=""unbounded"" name=""ShipmentOrderDetail"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" name=""OrderKey"" type=""xs:string"" />
                                <xs:element name=""ExternLineNo"" type=""xs:string"" />
                                <xs:element minOccurs=""0"" name=""StorerKey"" type=""xs:string"" />
                                <xs:element name=""PriSku"" type=""xs:string"" />
                                <xs:element name=""Sku"" type=""xs:string"" />
                                <xs:element name=""Remark"" type=""xs:string"" />
                                <xs:element name=""ReqLoc"" type=""xs:string"" />
                                <xs:element name=""OpenQty"" type=""xs:string"" />
                                <xs:element minOccurs=""0"" name=""Lottable01"" type=""xs:string"" />
                                <xs:element name=""PrimeOnly"" type=""xs:string"" />
                                <xs:element minOccurs=""0"" name=""SUsr1"" type=""xs:string"" />
                                <xs:element minOccurs=""0"" name=""SUsr2"" type=""xs:string"" />
                                <xs:element minOccurs=""0"" name=""SUsr3"" type=""xs:string"" />
                                <xs:element minOccurs=""0"" name=""SUsr4"" type=""xs:string"" />
                                <xs:element minOccurs=""0"" name=""SUsr5"" type=""xs:string"" />
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
</xs:schema>";
        
        public InforShipmentOrder() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Message";
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
