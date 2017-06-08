namespace Eldert.Samples.ProcessLargeMessage.Pipelines
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class ReceiveLargeMessage : Microsoft.BizTalk.TestTools.Pipeline.TestableReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s>        <Component>          <Name>Eldert.Samples.ProcessLargeMessage.ReceiveLargeMessage,ReceiveL"+
"argeMessage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=040c5ec528a61998</Name>          <Comp"+
"onentName>ReceiveLargeMessage</ComponentName>          <Description>Strips the data from a large mes"+
"sage and stores it in a temporary location</Description>          <Version>1.0</Version>          <P"+
"roperties>            <Property Name=\"TempPath\" />            <Property Name=\"LargeDataNodeName\" /> "+
"         </Properties>          <CachedDisplayName>ReceiveLargeMessage</CachedDisplayName>          "+
"<CachedIsManaged>true</CachedIsManaged>        </Component>      </Components>    </Stage>    <Stage"+
">      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Disassemble\" minOccurs=\"0\" maxOccurs=\"-"+
"1\" execMethod=\"FirstMatch\" stageId=\"9d0e4105-4cce-4536-83fa-4a5040674ad6\" />      <Components>      "+
"  <Component>          <Name>Microsoft.BizTalk.Component.XmlDasmComp,Microsoft.BizTalk.Pipeline.Comp"+
"onents, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</Name>          <Component"+
"Name>XML disassembler</ComponentName>          <Description>Streaming XML disassembler</Description>"+
"          <Version>1.0</Version>          <Properties>            <Property Name=\"EnvelopeSpecNames\""+
">              <Value xsi:type=\"xsd:string\" />            </Property>            <Property Name=\"Env"+
"elopeSpecTargetNamespaces\">              <Value xsi:type=\"xsd:string\" />            </Property>     "+
"       <Property Name=\"DocumentSpecNames\">              <Value xsi:type=\"xsd:string\" />            <"+
"/Property>            <Property Name=\"DocumentSpecTargetNamespaces\">              <Value xsi:type=\"x"+
"sd:string\" />            </Property>            <Property Name=\"AllowUnrecognizedMessage\">          "+
"    <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>            <Property Name=\"Va"+
"lidateDocument\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>    "+
"        <Property Name=\"RecoverableInterchangeProcessing\">              <Value xsi:type=\"xsd:boolean"+
"\">false</Value>            </Property>            <Property Name=\"HiddenProperties\">              <V"+
"alue xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,DocumentSpecTargetNamespaces</Value>        "+
"    </Property>          </Properties>          <CachedDisplayName>XML disassembler</CachedDisplayNa"+
"me>          <CachedIsManaged>true</CachedIsManaged>        </Component>      </Components>    </Sta"+
"ge>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"3\" Name=\"Validate\" minOccurs=\"0\" ma"+
"xOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410d-4cce-4536-83fa-4a5040674ad6\" />      <Components>   "+
"     <Component>          <Name>Microsoft.BizTalk.Component.XmlValidator,Microsoft.BizTalk.Pipeline."+
"Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</Name>          <Compo"+
"nentName>XML validator</ComponentName>          <Description>XML validator component.</Description> "+
"         <Version>1.0</Version>          <Properties>            <Property Name=\"DocumentSpecName\"> "+
"             <Value xsi:type=\"xsd:string\" />            </Property>            <Property Name=\"Docum"+
"entSpecTargetNamespaces\">              <Value xsi:type=\"xsd:string\" />            </Property>       "+
"     <Property Name=\"HiddenProperties\">              <Value xsi:type=\"xsd:string\">DocumentSpecTarget"+
"Namespaces</Value>            </Property>            <Property Name=\"RecoverableInterchangeProcessin"+
"g\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>          </Prope"+
"rties>          <CachedDisplayName>XML validator</CachedDisplayName>          <CachedIsManaged>true<"+
"/CachedIsManaged>        </Component>      </Components>    </Stage>    <Stage>      <PolicyFileStag"+
"e _locAttrData=\"Name\" _locID=\"4\" Name=\"ResolveParty\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" s"+
"tageId=\"9d0e410e-4cce-4536-83fa-4a5040674ad6\" />      <Components />    </Stage>  </Stages></Documen"+
"t>";
        
        private const string _versionDependentGuid = "21d188c3-43a8-44ec-b806-72e378c0df87";
        
        public ReceiveLargeMessage()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4103-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Eldert.Samples.ProcessLargeMessage.ReceiveLargeMessage,ReceiveLargeMessage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=040c5ec528a61998");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"TempPath\" />   "+
" <Property Name=\"LargeDataNodeName\" />  </Properties></PropertyBag>";
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
"es\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"EnvelopeSpecTargetNamesp"+
"aces\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecNames\">   "+
"   <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecTargetNamespaces\"> "+
"     <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"AllowUnrecognizedMessage\">   "+
"   <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"ValidateDocument\"> "+
"     <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"RecoverableInterc"+
"hangeProcessing\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name="+
"\"HiddenProperties\">      <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,DocumentSpecTarge"+
"tNamespaces</Value>    </Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp1XmlProperties);;
                ((IPersistPropertyBag)(comp1)).Load(pb, 0);
            }
            this.AddComponent(stage, comp1);
            stage = this.AddStage(new System.Guid("9d0e410d-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp2 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlValidator,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp2 is IPersistPropertyBag)
            {
                string comp2XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"DocumentSpecNam"+
"e\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecTargetNamespa"+
"ces\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"HiddenProperties\">     "+
" <Value xsi:type=\"xsd:string\">DocumentSpecTargetNamespaces</Value>    </Property>    <Property Name="+
"\"RecoverableInterchangeProcessing\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property> "+
" </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp2XmlProperties);;
                ((IPersistPropertyBag)(comp2)).Load(pb, 0);
            }
            this.AddComponent(stage, comp2);
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
