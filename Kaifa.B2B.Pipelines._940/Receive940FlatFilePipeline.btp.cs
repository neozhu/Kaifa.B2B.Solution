namespace Kaifa.B2B.Pipelines._940
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class Receive940FlatFilePipeline : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Disassemble\" "+
"minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"FirstMatch\" stageId=\"9d0e4105-4cce-4536-83fa-4a5040674ad6\" "+
"/>      <Components>        <Component>          <Name>Microsoft.BizTalk.Component.FFDasmComp,Micros"+
"oft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</"+
"Name>          <ComponentName>Flat file disassembler</ComponentName>          <Description>Streaming"+
" flat file disassembler component</Description>          <Version>1.0</Version>          <Properties"+
">            <Property Name=\"HeaderSpecName\" />            <Property Name=\"DocumentSpecName\">       "+
"       <Value xsi:type=\"xsd:string\">Kaifa.B2B.Schemas._940.CM_940_Inbound, Kaifa.B2B.Schemas._940, V"+
"ersion=1.0.0.0, Culture=neutral, PublicKeyToken=74d5deb66af72651</Value>            </Property>     "+
"       <Property Name=\"TrailerSpecName\" />            <Property Name=\"PreserveHeader\">              "+
"<Value xsi:type=\"xsd:boolean\">false</Value>            </Property>            <Property Name=\"Valida"+
"teDocumentStructure\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Property"+
">            <Property Name=\"RecoverableInterchangeProcessing\">              <Value xsi:type=\"xsd:bo"+
"olean\">false</Value>            </Property>          </Properties>          <CachedDisplayName>Flat "+
"file disassembler</CachedDisplayName>          <CachedIsManaged>true</CachedIsManaged>        </Comp"+
"onent>        <Component>          <Name>Microsoft.BizTalk.Component.XmlDasmComp,Microsoft.BizTalk.P"+
"ipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</Name>        "+
"  <ComponentName>XML disassembler</ComponentName>          <Description>Streaming XML disassembler</"+
"Description>          <Version>1.0</Version>          <Properties>            <Property Name=\"Envelo"+
"peSpecNames\">              <Value xsi:type=\"xsd:string\" />            </Property>            <Proper"+
"ty Name=\"EnvelopeSpecTargetNamespaces\">              <Value xsi:type=\"xsd:string\" />            </Pr"+
"operty>            <Property Name=\"DocumentSpecNames\">              <Value xsi:type=\"xsd:string\">Kai"+
"fa.B2B.Schemas._940.CM_940_Inbound, Kaifa.B2B.Schemas._940, Version=1.0.0.0, Culture=neutral, Public"+
"KeyToken=74d5deb66af72651</Value>            </Property>            <Property Name=\"DocumentSpecTarg"+
"etNamespaces\">              <Value xsi:type=\"xsd:string\">http://Kaifa.B2B.Schemas.940.CM_940_Inbound"+
"</Value>            </Property>            <Property Name=\"AllowUnrecognizedMessage\">              <"+
"Value xsi:type=\"xsd:boolean\">false</Value>            </Property>            <Property Name=\"Validat"+
"eDocument\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>         "+
"   <Property Name=\"RecoverableInterchangeProcessing\">              <Value xsi:type=\"xsd:boolean\">fal"+
"se</Value>            </Property>            <Property Name=\"HiddenProperties\">              <Value "+
"xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,DocumentSpecTargetNamespaces</Value>            <"+
"/Property>          </Properties>          <CachedDisplayName>XML disassembler</CachedDisplayName>  "+
"        <CachedIsManaged>true</CachedIsManaged>        </Component>      </Components>    </Stage>  "+
"  <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"3\" Name=\"Validate\" minOccurs=\"0\" maxOccu"+
"rs=\"-1\" execMethod=\"All\" stageId=\"9d0e410d-4cce-4536-83fa-4a5040674ad6\" />      <Components />    </"+
"Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"4\" Name=\"ResolveParty\" minOccurs"+
"=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410e-4cce-4536-83fa-4a5040674ad6\" />      <Compone"+
"nts />    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "3bfa720f-daef-444d-aaca-0d5bcc8446d6";
        
        public Receive940FlatFilePipeline()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4105-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.firstRecognized);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.FFDasmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"HeaderSpecName\""+
" />    <Property Name=\"DocumentSpecName\">      <Value xsi:type=\"xsd:string\">Kaifa.B2B.Schemas._940.C"+
"M_940_Inbound, Kaifa.B2B.Schemas._940, Version=1.0.0.0, Culture=neutral, PublicKeyToken=74d5deb66af7"+
"2651</Value>    </Property>    <Property Name=\"TrailerSpecName\" />    <Property Name=\"PreserveHeader"+
"\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"ValidateDocume"+
"ntStructure\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"Rec"+
"overableInterchangeProcessing\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>  </P"+
"roperties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
            IBaseComponent comp1 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlDasmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp1 is IPersistPropertyBag)
            {
                string comp1XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"EnvelopeSpecNam"+
"es\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"EnvelopeSpecTargetNamesp"+
"aces\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecNames\">   "+
"   <Value xsi:type=\"xsd:string\">Kaifa.B2B.Schemas._940.CM_940_Inbound, Kaifa.B2B.Schemas._940, Versi"+
"on=1.0.0.0, Culture=neutral, PublicKeyToken=74d5deb66af72651</Value>    </Property>    <Property Nam"+
"e=\"DocumentSpecTargetNamespaces\">      <Value xsi:type=\"xsd:string\">http://Kaifa.B2B.Schemas.940.CM_"+
"940_Inbound</Value>    </Property>    <Property Name=\"AllowUnrecognizedMessage\">      <Value xsi:typ"+
"e=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"ValidateDocument\">      <Value xsi:t"+
"ype=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"RecoverableInterchangeProcessing\">"+
"      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"HiddenProperties"+
"\">      <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,DocumentSpecTargetNamespaces</Valu"+
"e>    </Property>  </Properties></PropertyBag>";
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
