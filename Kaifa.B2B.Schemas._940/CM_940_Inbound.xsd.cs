namespace Kaifa.B2B.Schemas._940 {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Kaifa.B2B.Schemas.940.CM_940_Inbound",@"CMInbound")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CMInbound"})]
    public sealed class CM_940_Inbound : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://Kaifa.B2B.Schemas.940.CM_940_Inbound"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://Kaifa.B2B.Schemas.940.CM_940_Inbound"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <schemaEditorExtension:schemaInfo namespaceAlias=""b"" extensionClass=""Microsoft.BizTalk.FlatFileExtension.FlatFileExtension"" standardName=""Flat File"" xmlns:schemaEditorExtension=""http://schemas.microsoft.com/BizTalk/2003/SchemaEditorExtensions"" />
      <b:schemaInfo standard=""Flat File"" codepage=""65001"" default_pad_char="" "" pad_char_type=""char"" count_positions_by_byte=""false"" parser_optimization=""speed"" lookahead_depth=""3"" suppress_empty_nodes=""false"" generate_empty_nodes=""true"" allow_early_termination=""false"" early_terminate_optional_fields=""false"" allow_message_breakup_of_infix_root=""false"" compile_parse_tables=""false"" root_reference=""CMInbound"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""CMInbound"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" child_delimiter_type=""hex"" child_delimiter=""0xD 0xA"" child_order=""postfix"" sequence_number=""1"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:annotation>
          <xs:appinfo>
            <groupInfo sequence_number=""0"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
          </xs:appinfo>
        </xs:annotation>
        <xs:element maxOccurs=""unbounded"" name=""Row"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""positional"" sequence_number=""1"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:complexType>
            <xs:sequence>
              <xs:annotation>
                <xs:appinfo>
                  <groupInfo sequence_number=""0"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
                </xs:appinfo>
              </xs:annotation>
              <xs:element name=""PullNo"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" pos_offset=""0"" pos_length=""8"" sequence_number=""1"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""LineNo"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" pos_offset=""0"" pos_length=""10"" sequence_number=""2"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""RequestLocation"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" pos_offset=""0"" pos_length=""6"" sequence_number=""3"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""SKU"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" pos_offset=""0"" pos_length=""18"" sequence_number=""4"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Remarks"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" pos_offset=""0"" pos_length=""100"" sequence_number=""5"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""RequestDate"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" pos_offset=""0"" pos_length=""12"" sequence_number=""6"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""RequestTime"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" pos_offset=""0"" pos_length=""5"" sequence_number=""7"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Qty"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" pos_offset=""0"" pos_length=""10"" sequence_number=""8"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""PO"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" pos_offset=""0"" pos_length=""15"" sequence_number=""9"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""NOofFeeder"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" pos_offset=""0"" pos_length=""3"" sequence_number=""10"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Site"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" pos_offset=""0"" pos_length=""8"" sequence_number=""11"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""PrimeOnly"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" pos_offset=""0"" pos_length=""1"" sequence_number=""12"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CM_940_Inbound() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CMInbound";
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
