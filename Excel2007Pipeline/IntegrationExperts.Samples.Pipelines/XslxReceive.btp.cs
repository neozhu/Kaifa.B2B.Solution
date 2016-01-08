namespace IntegrationExperts.Samples.Pipelines
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class XslxReceive : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s>        <Component>          <Name>IntegrationExperts.Samples.PipelineComponents.Excel2007Decoder,"+
"IntegrationExperts.Samples.PipelineComponents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b4b4"+
"fd79102b4431</Name>          <ComponentName>IntegrationExperts - Excel 2007 Decoder</ComponentName> "+
"         <Description />          <Version>1.0</Version>          <Properties>            <Property "+
"Name=\"NamespaceBase\">              <Value xsi:type=\"xsd:string\">http://IntegrationExperts_v1.0</Valu"+
"e>            </Property>            <Property Name=\"NamespacePrefix\">              <Value xsi:type="+
"\"xsd:string\">ns0</Value>            </Property>            <Property Name=\"RootNodeName\">           "+
"   <Value xsi:type=\"xsd:string\">Root</Value>            </Property>            <Property Name=\"IsFir"+
"stRowHeader\">              <Value xsi:type=\"xsd:boolean\">true</Value>            </Property>        "+
"    <Property Name=\"TempFolder\">              <Value xsi:type=\"xsd:string\">c:\\temp</Value>          "+
"  </Property>          </Properties>          <CachedDisplayName>IntegrationExperts - Excel 2007 Dec"+
"oder</CachedDisplayName>          <CachedIsManaged>true</CachedIsManaged>        </Component>      <"+
"/Components>    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Disas"+
"semble\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"FirstMatch\" stageId=\"9d0e4105-4cce-4536-83fa-4a5040"+
"674ad6\" />      <Components>        <Component>          <Name>Microsoft.BizTalk.Component.XmlDasmCo"+
"mp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856a"+
"d364e35</Name>          <ComponentName>XML disassembler</ComponentName>          <Description>Stream"+
"ing XML disassembler</Description>          <Version>1.0</Version>          <Properties>            "+
"<Property Name=\"EnvelopeSpecNames\">              <Value xsi:type=\"xsd:string\">IntegrationExperts.Sam"+
"ples.Schemas.Envelope_v1_0, IntegrationExperts.Samples.Schemas, Version=1.0.0.0, Culture=neutral, Pu"+
"blicKeyToken=b4b4fd79102b4431</Value>            </Property>            <Property Name=\"EnvelopeSpec"+
"TargetNamespaces\">              <Value xsi:type=\"xsd:string\">http://IntegrationExperts_v1.0</Value> "+
"           </Property>            <Property Name=\"DocumentSpecNames\">              <Value xsi:type=\""+
"xsd:string\" />            </Property>            <Property Name=\"DocumentSpecTargetNamespaces\">     "+
"         <Value xsi:type=\"xsd:string\" />            </Property>            <Property Name=\"AllowUnre"+
"cognizedMessage\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>   "+
"         <Property Name=\"ValidateDocument\">              <Value xsi:type=\"xsd:boolean\">false</Value>"+
"            </Property>            <Property Name=\"RecoverableInterchangeProcessing\">              <"+
"Value xsi:type=\"xsd:boolean\">false</Value>            </Property>            <Property Name=\"HiddenP"+
"roperties\">              <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,DocumentSpecTarge"+
"tNamespaces</Value>            </Property>          </Properties>          <CachedDisplayName>XML di"+
"sassembler</CachedDisplayName>          <CachedIsManaged>true</CachedIsManaged>        </Component> "+
"     </Components>    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"3\" Name="+
"\"Validate\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410d-4cce-4536-83fa-4a5040674a"+
"d6\" />      <Components />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\""+
"4\" Name=\"ResolveParty\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410e-4cce-4536-83f"+
"a-4a5040674ad6\" />      <Components />    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "1ed61306-9bcf-4ca4-8f3f-695b0c4352f6";
        
        public XslxReceive()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4103-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("IntegrationExperts.Samples.PipelineComponents.Excel2007Decoder,IntegrationExperts.Samples.PipelineComponents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b4b4fd79102b4431");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"NamespaceBase\">"+
"      <Value xsi:type=\"xsd:string\">http://IntegrationExperts_v1.0</Value>    </Property>    <Propert"+
"y Name=\"NamespacePrefix\">      <Value xsi:type=\"xsd:string\">ns0</Value>    </Property>    <Property "+
"Name=\"RootNodeName\">      <Value xsi:type=\"xsd:string\">Root</Value>    </Property>    <Property Name"+
"=\"IsFirstRowHeader\">      <Value xsi:type=\"xsd:boolean\">true</Value>    </Property>    <Property Nam"+
"e=\"TempFolder\">      <Value xsi:type=\"xsd:string\">c:\\temp</Value>    </Property>  </Properties></Pro"+
"pertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
            stage = this.AddStage(new System.Guid("9d0e4105-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.firstRecognized);
            IBaseComponent comp1 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlDasmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp1 is IPersistPropertyBag)
            {
                string comp1XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"EnvelopeSpecNam"+
"es\">      <Value xsi:type=\"xsd:string\">IntegrationExperts.Samples.Schemas.Envelope_v1_0, Integration"+
"Experts.Samples.Schemas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b4b4fd79102b4431</Value>  "+
"  </Property>    <Property Name=\"EnvelopeSpecTargetNamespaces\">      <Value xsi:type=\"xsd:string\">ht"+
"tp://IntegrationExperts_v1.0</Value>    </Property>    <Property Name=\"DocumentSpecNames\">      <Val"+
"ue xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecTargetNamespaces\">      <V"+
"alue xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"AllowUnrecognizedMessage\">      <Val"+
"ue xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"ValidateDocument\">      <V"+
"alue xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"RecoverableInterchangePr"+
"ocessing\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"Hidden"+
"Properties\">      <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,DocumentSpecTargetNamesp"+
"aces</Value>    </Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp1XmlProperties);;
                ((IPersistPropertyBag)(comp1)).Load(pb, 0);
            }
            this.AddComponent(stage, comp1);
        }
        
        public override string XmlContent
        {
            get
            {
                return _strPipeline;
            }
        }
        
        public override System.Guid VersionDependentGuid
        {
            get
            {
                return new System.Guid(_versionDependentGuid);
            }
        }
    }
}
