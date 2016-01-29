
#pragma warning disable 162

namespace Kaifa.B2B.Orchestration.CM940
{

    [System.SerializableAttribute]
    sealed public class __Kaifa_B2B_Schemas_InforAPI_WmsWebService_com_ssaglobal_com_callBackEnd__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.Schemas.InforAPI.WmsWebService_com_ssaglobal_com.callBackEnd _schema = new Kaifa.B2B.Schemas.InforAPI.WmsWebService_com_ssaglobal_com.callBackEnd();

        public __Kaifa_B2B_Schemas_InforAPI_WmsWebService_com_ssaglobal_com_callBackEnd__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(Kaifa.B2B.Schemas.InforAPI.WmsWebService_com_ssaglobal_com.callBackEnd)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_Schemas_InforAPI_WmsWebService_com_ssaglobal_com_callBackEnd__)
        },
        0,
        @"http://com.ssaglobal.com#callBackEnd"
    )]
    [System.SerializableAttribute]
    sealed internal class callBackEndRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_Schemas_InforAPI_WmsWebService_com_ssaglobal_com_callBackEnd__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __Kaifa_B2B_Schemas_InforAPI_WmsWebService_com_ssaglobal_com_callBackEnd__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public callBackEndRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Kaifa_B2B_Schemas_InforAPI_WmsWebService_com_ssaglobal_com_callBackEndResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.Schemas.InforAPI.WmsWebService_com_ssaglobal_com.callBackEndResponse _schema = new Kaifa.B2B.Schemas.InforAPI.WmsWebService_com_ssaglobal_com.callBackEndResponse();

        public __Kaifa_B2B_Schemas_InforAPI_WmsWebService_com_ssaglobal_com_callBackEndResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(Kaifa.B2B.Schemas.InforAPI.WmsWebService_com_ssaglobal_com.callBackEndResponse)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_Schemas_InforAPI_WmsWebService_com_ssaglobal_com_callBackEndResponse__)
        },
        0,
        @"http://com.ssaglobal.com#callBackEndResponse"
    )]
    [System.SerializableAttribute]
    sealed internal class callBackEndResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_Schemas_InforAPI_WmsWebService_com_ssaglobal_com_callBackEndResponse__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __Kaifa_B2B_Schemas_InforAPI_WmsWebService_com_ssaglobal_com_callBackEndResponse__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public callBackEndResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "callBackEnd",
        new System.Type[]{
            typeof(Kaifa.B2B.Orchestration.CM940.callBackEndRequest), 
            typeof(Kaifa.B2B.Orchestration.CM940.callBackEndResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class WmsWebServicePortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public WmsWebServicePortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public WmsWebServicePortType(WmsWebServicePortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            WmsWebServicePortType p = new WmsWebServicePortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo callBackEnd = new Microsoft.XLANGs.Core.OperationInfo
        (
            "callBackEnd",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(WmsWebServicePortType),
            typeof(callBackEndRequest),
            typeof(callBackEndResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "callBackEnd" ] = callBackEnd;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [System.SerializableAttribute]
    sealed public class __Kaifa_B2B_Schemas__940_CM_940_Inbound__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.Schemas._940.CM_940_Inbound _schema = new Kaifa.B2B.Schemas._940.CM_940_Inbound();

        public __Kaifa_B2B_Schemas__940_CM_940_Inbound__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Kaifa.B2B.Schemas._940.CM_940_Inbound",
        new System.Type[]{
            typeof(Kaifa.B2B.Schemas._940.CM_940_Inbound)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_Schemas__940_CM_940_Inbound__)
        },
        0,
        @"http://Kaifa.B2B.Schemas.940.CM_940_Inbound#CMInbound"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Kaifa_B2B_Schemas__940_CM_940_Inbound : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_Schemas__940_CM_940_Inbound__ part;

        private void __CreatePartWrappers()
        {
            part = new __Kaifa_B2B_Schemas__940_CM_940_Inbound__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Kaifa_B2B_Schemas__940_CM_940_Inbound(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Kaifa.B2B.Orchestration.CM940.__messagetype_Kaifa_B2B_Schemas__940_CM_940_Inbound)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_Receive940FlatFile : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Receive940FlatFile(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Receive940FlatFile(PortType_Receive940FlatFile p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Receive940FlatFile p = new PortType_Receive940FlatFile(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_Receive940FlatFile),
            typeof(__messagetype_Kaifa_B2B_Schemas__940_CM_940_Inbound),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 326 "D:\长城开发项目\SourceCode\Kaifa.B2B.Solution\Kaifa.B2B.Orchestration._940\WmsWebService.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Receive940FlatFile", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Kaifa.B2B.Orchestration.CM940.PortType_Receive940FlatFile),
            typeof(Kaifa.B2B.Orchestration.CM940.WmsWebServicePortType)
        },
        new System.String[] {
            "Receive940FlatFile",
            "InvokeInforWebService"
        },
        new System.Type[] {
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class WmsWebServiceClient : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(WmsWebServiceClient));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static WmsWebServiceClient()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __WmsWebServiceClient_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public WmsWebServiceClient(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "WmsWebServiceClient", tracker)
        {
            ConstructorHelper();
        }

        public WmsWebServiceClient(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "WmsWebServiceClient")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>db933755-af48-4729-86d6-4bc1f4ad231e</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>b87b1964-7141-4dad-ab91-241ed1139688</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_CM940Message</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>983570aa-762e-423a-bc1c-051837d85bfa</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_ShipmentOrder</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>3672b064-1a9e-48cd-9335-ace7588ec298</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>d72bb0a2-ce17-4ca2-ba98-4c8f1d0fbec4</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>b1c282c2-c197-4036-9b8a-0404a406cab5</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>924f53aa-2711-4c7b-a677-00ffb492fd25</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>27ac5291-767d-4f77-b5c9-18fb95802903</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_Request</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>fd21e5c3-6658-418c-bb11-42ce103de014</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>217a19a7-ff03-464a-a6f0-e67562c72eb9</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>e55b192f-f505-45c6-bf5a-c18ef0a88651</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>14a0e229-9770-4ff3-b2e3-05fe505ede55</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>67c2415a-72f6-477f-aeae-5a5aa52831f8</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>9743f4b5-a3ea-4fdc-ac4b-81b50cc09368</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>CallRequest</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>1b4a1fac-db8b-49d2-8a32-f206be9ea571</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>CallReponse</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>6827bc79-288e-43e5-8b26-07ad41a1bb65</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'WmsWebServiceClient'</ActionName><IsAtomic>0</IsAtomic><Line>326</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>344</Line><Position>22</Position><ShapeID>'b87b1964-7141-4dad-ab91-241ed1139688'</ShapeID>
<Messages>
	<MsgInfo><name>CM940Message</name><part>part</part><schema>Kaifa.B2B.Schemas._940.CM_940_Inbound</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>351</Line><Position>13</Position><ShapeID>'983570aa-762e-423a-bc1c-051837d85bfa'</ShapeID>
<Messages>
	<MsgInfo><name>ShipmentOrder</name><part>part</part><schema>Kaifa.B2B.Schemas.InforAPI.InforShipmentOrder</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>CM940Message</name><part>part</part><schema>Kaifa.B2B.Schemas._940.CM_940_Inbound</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>357</Line><Position>13</Position><ShapeID>'27ac5291-767d-4f77-b5c9-18fb95802903'</ShapeID>
<Messages>
	<MsgInfo><name>CallServiceRequest</name><part>parameters</part><schema>Kaifa.B2B.Schemas.InforAPI.WmsWebService_com_ssaglobal_com+callBackEnd</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>ShipmentOrder</name><part>part</part><schema>Kaifa.B2B.Schemas.InforAPI.InforShipmentOrder</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>370</Line><Position>13</Position><ShapeID>'9743f4b5-a3ea-4fdc-ac4b-81b50cc09368'</ShapeID>
<Messages>
	<MsgInfo><name>CallServiceRequest</name><part>parameters</part><schema>Kaifa.B2B.Schemas.InforAPI.WmsWebService_com_ssaglobal_com+callBackEnd</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>372</Line><Position>13</Position><ShapeID>'1b4a1fac-db8b-49d2-8a32-f206be9ea571'</ShapeID>
<Messages>
	<MsgInfo><name>CallServiceReponse</name><part>parameters</part><schema>Kaifa.B2B.Schemas.InforAPI.WmsWebService_com_ssaglobal_com+callBackEndResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>374</Line><Position>24</Position><ShapeID>'6827bc79-288e-43e5-8b26-07ad41a1bb65'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='ed6f4cd7-d11d-446d-af4b-69a9f5ba836b' LowerBound='1.1' HigherBound='83.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Kaifa.B2B.Orchestration.CM940' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='6b866216-d3c7-4586-9fe7-74cfa09c4db2' ParentLink='Module_PortType' LowerBound='12.1' HigherBound='19.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:portType name=&quot;WmsWebServicePortType&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='WmsWebServicePortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='158e0281-4d10-4609-bda0-a92753668496' ParentLink='PortType_OperationDeclaration' LowerBound='14.1' HigherBound='18.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:operation name=&quot;callBackEnd&quot;/&gt;&#xD;&#xA;' />
                <om:Property Name='Name' Value='callBackEnd' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='e959d6e0-b833-49c6-bafa-bdbc273c101c' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='16.13' HigherBound='16.31'>
                    <om:Property Name='Ref' Value='Kaifa.B2B.Orchestration.CM940.callBackEndRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='&lt;wsdl:input message=&quot;http://com.ssaglobal.com:callBackEndRequest&quot;/&gt;&#xD;&#xA;' />
                    <om:Property Name='Name' Value='callBackEndRequest' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='779c9dee-60d3-4216-b34c-b7f3fb2ec673' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='16.33' HigherBound='16.52'>
                    <om:Property Name='Ref' Value='Kaifa.B2B.Orchestration.CM940.callBackEndResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='&lt;wsdl:output message=&quot;http://com.ssaglobal.com:callBackEndResponse&quot;/&gt;&#xD;&#xA;' />
                    <om:Property Name='Name' Value='callBackEndResponse' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='d6fe7725-5181-48da-8de4-2a8cd9682f30' ParentLink='Module_PortType' LowerBound='19.1' HigherBound='26.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Receive940FlatFile' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='bba3e742-f098-43a2-8df2-bc08d94ca9b2' ParentLink='PortType_OperationDeclaration' LowerBound='21.1' HigherBound='25.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='65be2e81-8c15-4d67-8c0a-57158b7a09ea' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='23.13' HigherBound='23.50'>
                    <om:Property Name='Ref' Value='Kaifa.B2B.Schemas._940.CM_940_Inbound' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='1fef6622-f28d-4474-adb3-11d57ca19bd4' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:message name=&quot;callBackEndRequest&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='callBackEndRequest' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='58d4ab5f-b929-4403-8c6a-15b57ffb03ac' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='Kaifa.B2B.Schemas.InforAPI.WmsWebService_com_ssaglobal_com.callBackEnd' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:part name=&quot;parameters&quot;/&gt;&#xD;&#xA;' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='9247937f-2134-43c5-aeb5-1116111be762' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:message name=&quot;callBackEndResponse&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='callBackEndResponse' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='45461ed4-41e2-44d3-a467-268a4f783699' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='Kaifa.B2B.Schemas.InforAPI.WmsWebService_com_ssaglobal_com.callBackEndResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:part name=&quot;parameters&quot;/&gt;&#xD;&#xA;' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='b8cad8af-376f-49b1-becf-2af6f6b00a62' ParentLink='Module_ServiceDeclaration' LowerBound='26.1' HigherBound='82.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:service name=&quot;WmsWebService&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='WmsWebServiceClient' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='317cde9c-a2c7-4915-98ca-ba0962ecaec5' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='37.1' HigherBound='38.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strContent' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3c37cc48-fcb1-430d-9241-cdb247e52d4d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='38.1' HigherBound='39.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='pulllistNo' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='167a64e9-205c-40f7-9e1f-4cfe4e9bde34' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='39.1' HigherBound='40.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='siteCode' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='16d28241-4935-42f5-9180-c09e2ac273e9' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='40.1' HigherBound='41.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Reqdate' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='fddf9dec-ae0b-4748-a24a-ced64672851c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='41.1' HigherBound='42.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strType' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='4bd0a46f-a79a-4722-8eaa-495d8b3ece6c' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='33.1' HigherBound='34.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas._940.CM_940_Inbound' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CM940Message' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='178f41f6-097a-4bca-88cf-999ea36791b9' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas.InforAPI.InforShipmentOrder' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ShipmentOrder' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='85100f6c-75f8-4961-8b37-b171cc150e2c' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='35.1' HigherBound='36.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Orchestration.CM940.callBackEndRequest' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CallServiceRequest' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='4c030b82-54e8-4830-8ba9-9eba9abc8595' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='36.1' HigherBound='37.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Orchestration.CM940.callBackEndResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CallServiceReponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='db933755-af48-4729-86d6-4bc1f4ad231e' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='b87b1964-7141-4dad-ab91-241ed1139688' ParentLink='ServiceBody_Statement' LowerBound='44.1' HigherBound='51.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Receive940FlatFile' />
                    <om:Property Name='MessageName' Value='CM940Message' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_CM940Message' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='983570aa-762e-423a-bc1c-051837d85bfa' ParentLink='ServiceBody_Statement' LowerBound='51.1' HigherBound='57.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_ShipmentOrder' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='3672b064-1a9e-48cd-9335-ace7588ec298' ParentLink='ComplexStatement_Statement' LowerBound='54.1' HigherBound='56.1'>
                        <om:Property Name='ClassName' Value='Kaifa.B2B.Orchestration._940.Mapping.Cm_940_To_ShipmentOrder' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='d72bb0a2-ce17-4ca2-ba98-4c8f1d0fbec4' ParentLink='Transform_InputMessagePartRef' LowerBound='55.107' HigherBound='55.119'>
                            <om:Property Name='MessageRef' Value='CM940Message' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='b1c282c2-c197-4036-9b8a-0404a406cab5' ParentLink='Transform_OutputMessagePartRef' LowerBound='55.28' HigherBound='55.41'>
                            <om:Property Name='MessageRef' Value='ShipmentOrder' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='924f53aa-2711-4c7b-a677-00ffb492fd25' ParentLink='Construct_MessageRef' LowerBound='52.23' HigherBound='52.36'>
                        <om:Property Name='Ref' Value='ShipmentOrder' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Construct' OID='27ac5291-767d-4f77-b5c9-18fb95802903' ParentLink='ServiceBody_Statement' LowerBound='57.1' HigherBound='70.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_Request' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='fd21e5c3-6658-418c-bb11-42ce103de014' ParentLink='ComplexStatement_Statement' LowerBound='60.1' HigherBound='62.1'>
                        <om:Property Name='ClassName' Value='Kaifa.B2B.Orchestration._940.Mapping.initMap' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_2' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='MessagePartRef' OID='217a19a7-ff03-464a-a6f0-e67562c72eb9' ParentLink='Transform_InputMessagePartRef' LowerBound='61.107' HigherBound='61.120'>
                            <om:Property Name='MessageRef' Value='ShipmentOrder' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_3' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='e55b192f-f505-45c6-bf5a-c18ef0a88651' ParentLink='Transform_OutputMessagePartRef' LowerBound='61.28' HigherBound='61.57'>
                            <om:Property Name='MessageRef' Value='CallServiceRequest' />
                            <om:Property Name='PartRef' Value='parameters' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_4' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageAssignment' OID='14a0e229-9770-4ff3-b2e3-05fe505ede55' ParentLink='ComplexStatement_Statement' LowerBound='62.1' HigherBound='69.1'>
                        <om:Property Name='Expression' Value='// &#xD;&#xA;strContent = Kaifa.B2B.Utility.HeaderHelper.ReturnStringRemoveNamespace(ShipmentOrder);&#xD;&#xA;//requestMessage.RequestType.ToString(), requestMessage.MessageType.ToString(), requestMessage.RequestMethod.ToString(), requestMessage.XmlString&#xD;&#xA; Kaifa.B2B.Utility.HeaderHelper.AssignmentInforRequest(CallServiceRequest.parameters,&quot;MessageProcessor&quot;,&quot;ShipmentOrder&quot;,&quot;storeByQuote&quot;,strContent);&#xD;&#xA;&#xD;&#xA; ' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='MessageAssignment_1' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='67c2415a-72f6-477f-aeae-5a5aa52831f8' ParentLink='Construct_MessageRef' LowerBound='58.23' HigherBound='58.41'>
                        <om:Property Name='Ref' Value='CallServiceRequest' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='9743f4b5-a3ea-4fdc-ac4b-81b50cc09368' ParentLink='ServiceBody_Statement' LowerBound='70.1' HigherBound='72.1'>
                    <om:Property Name='PortName' Value='InvokeInforWebService' />
                    <om:Property Name='MessageName' Value='CallServiceRequest' />
                    <om:Property Name='OperationName' Value='callBackEnd' />
                    <om:Property Name='OperationMessageName' Value='callBackEndRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='CallRequest' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Receive' OID='1b4a1fac-db8b-49d2-8a32-f206be9ea571' ParentLink='ServiceBody_Statement' LowerBound='72.1' HigherBound='74.1'>
                    <om:Property Name='Activate' Value='False' />
                    <om:Property Name='PortName' Value='InvokeInforWebService' />
                    <om:Property Name='MessageName' Value='CallServiceReponse' />
                    <om:Property Name='OperationName' Value='callBackEnd' />
                    <om:Property Name='OperationMessageName' Value='callBackEndResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='CallReponse' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='6827bc79-288e-43e5-8b26-07ad41a1bb65' ParentLink='ServiceBody_Statement' LowerBound='74.1' HigherBound='80.1'>
                    <om:Property Name='Expression' Value='pulllistNo = System.Convert.ToString(xpath(CM940Message,&quot;string(/*[local-name()=&apos;CMInbound&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.940.CM_940_Inbound&apos;]/*[local-name()=&apos;Row&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.940.CM_940_Inbound&apos;][1]/*[local-name()=&apos;PullNo&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.940.CM_940_Inbound&apos;])&quot;));&#xD;&#xA;siteCode =  System.Convert.ToString(xpath(CM940Message,&quot;string(/*[local-name()=&apos;CMInbound&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.940.CM_940_Inbound&apos;]/*[local-name()=&apos;Row&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.940.CM_940_Inbound&apos;][1]/*[local-name()=&apos;Site&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.940.CM_940_Inbound&apos;])&quot;));&#xD;&#xA;strType =  System.Convert.ToString(xpath(CM940Message,&quot;string(/*[local-name()=&apos;CMInbound&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.940.CM_940_Inbound&apos;]/*[local-name()=&apos;Row&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.940.CM_940_Inbound&apos;][1]/*[local-name()=&apos;PrimeOnly&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.940.CM_940_Inbound&apos;])&quot;));&#xD;&#xA;Reqdate =  System.Convert.ToString(xpath(CM940Message,&quot;string(/*[local-name()=&apos;CMInbound&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.940.CM_940_Inbound&apos;]/*[local-name()=&apos;Row&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.940.CM_940_Inbound&apos;][1]/*[local-name()=&apos;RequestDate&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.940.CM_940_Inbound&apos;])&quot;));&#xD;&#xA;Kaifa.B2B.Utility.MailClient.Send940NotificationMail(CallServiceReponse.parameters,pulllistNo,siteCode,Reqdate,strType);' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Expression_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='008a8d29-5312-43f1-8228-c22764b8630a' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='29.1' HigherBound='31.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Kaifa.B2B.Orchestration.CM940.PortType_Receive940FlatFile' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Receive940FlatFile' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='1a8a67e6-5ec9-41f3-8d7f-d057300e9b1b' ParentLink='PortDeclaration_CLRAttribute' LowerBound='29.1' HigherBound='30.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='4c5ee119-7252-4fe1-a60a-e82f8856323b' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='31.1' HigherBound='33.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Kaifa.B2B.Orchestration.CM940.WmsWebServicePortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='InvokeInforWebService' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='14d5108f-3acf-4e62-b6d8-71fd8c2b3e0f' ParentLink='PortDeclaration_CLRAttribute' LowerBound='31.1' HigherBound='32.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __WmsWebServiceClient_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __WmsWebServiceClient_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "WmsWebServiceClient")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                WmsWebServiceClient __svc__ = (WmsWebServiceClient)_service;
                __WmsWebServiceClient_root_0 __ctx0__ = (__WmsWebServiceClient_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.InvokeInforWebService != null)
                {
                    __svc__.InvokeInforWebService.Close(this, null);
                    __svc__.InvokeInforWebService = null;
                }
                if (__svc__.Receive940FlatFile != null)
                {
                    __svc__.Receive940FlatFile.Close(this, null);
                    __svc__.Receive940FlatFile = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __WmsWebServiceClient_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __WmsWebServiceClient_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "WmsWebServiceClient")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                WmsWebServiceClient __svc__ = (WmsWebServiceClient)_service;
                __WmsWebServiceClient_1 __ctx1__ = (__WmsWebServiceClient_1)(__svc__._stateMgrs[1]);
                __WmsWebServiceClient_root_0 __ctx0__ = (__WmsWebServiceClient_root_0)(__svc__._stateMgrs[0]);

                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__siteCode = null;
                if (__ctx1__ != null && __ctx1__.__CM940Message != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CM940Message);
                    __ctx1__.__CM940Message = null;
                }
                if (__ctx1__ != null && __ctx1__.__CallServiceReponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CallServiceReponse);
                    __ctx1__.__CallServiceReponse = null;
                }
                if (__ctx1__ != null && __ctx1__.__ShipmentOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ShipmentOrder);
                    __ctx1__.__ShipmentOrder = null;
                }
                if (__ctx1__ != null && __ctx1__.__CallServiceRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CallServiceRequest);
                    __ctx1__.__CallServiceRequest = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__pulllistNo = null;
                if (__ctx1__ != null)
                    __ctx1__.__Reqdate = null;
                if (__ctx1__ != null)
                    __ctx1__.__strType = null;
                if (__ctx1__ != null)
                    __ctx1__.__strContent = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("CM940Message")]
            public __messagetype_Kaifa_B2B_Schemas__940_CM_940_Inbound __CM940Message;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ShipmentOrder")]
            public __messagetype_Kaifa_B2B_Schemas_InforAPI_InforShipmentOrder __ShipmentOrder;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CallServiceRequest")]
            internal callBackEndRequest __CallServiceRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CallServiceReponse")]
            internal callBackEndResponse __CallServiceReponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strContent")]
            internal System.String __strContent;
            [Microsoft.XLANGs.Core.UserVariableAttribute("pulllistNo")]
            internal System.String __pulllistNo;
            [Microsoft.XLANGs.Core.UserVariableAttribute("siteCode")]
            internal System.String __siteCode;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Reqdate")]
            internal System.String __Reqdate;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strType")]
            internal System.String __strType;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Receive940FlatFile")]
        internal PortType_Receive940FlatFile Receive940FlatFile;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("InvokeInforWebService")]
        internal WmsWebServicePortType InvokeInforWebService;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Receive940FlatFile.Operation_1},
                                               typeof(WmsWebServiceClient).GetField("Receive940FlatFile", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(WmsWebServiceClient), "Receive940FlatFile"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {WmsWebServicePortType.callBackEnd},
                                               typeof(WmsWebServiceClient).GetField("InvokeInforWebService", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(WmsWebServiceClient), "InvokeInforWebService"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "b87b1964-7141-4dad-ab91-241ed1139688", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "b87b1964-7141-4dad-ab91-241ed1139688", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "983570aa-762e-423a-bc1c-051837d85bfa", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "983570aa-762e-423a-bc1c-051837d85bfa", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "27ac5291-767d-4f77-b5c9-18fb95802903", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "27ac5291-767d-4f77-b5c9-18fb95802903", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "9743f4b5-a3ea-4fdc-ac4b-81b50cc09368", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "9743f4b5-a3ea-4fdc-ac4b-81b50cc09368", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "1b4a1fac-db8b-49d2-8a32-f206be9ea571", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "1b4a1fac-db8b-49d2-8a32-f206be9ea571", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "6827bc79-288e-43e5-8b26-07ad41a1bb65", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "6827bc79-288e-43e5-8b26-07ad41a1bb65", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,4,4,5,6,6,7,8,8,8,9,10,10,11,12,12,13,13,13,13,13,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __WmsWebServiceClient_1 __ctx1__ = (__WmsWebServiceClient_1)_stateMgrs[1];
            __WmsWebServiceClient_root_0 __ctx0__ = (__WmsWebServiceClient_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                Receive940FlatFile = new PortType_Receive940FlatFile(0, this);
                InvokeInforWebService = new WmsWebServicePortType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Receive940FlatFile, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __WmsWebServiceClient_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __WmsWebServiceClient_1 __ctx1__ = (__WmsWebServiceClient_1)_stateMgrs[1];
            __WmsWebServiceClient_root_0 __ctx0__ = (__WmsWebServiceClient_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__strContent = default(System.String);
                __ctx1__.__pulllistNo = default(System.String);
                __ctx1__.__siteCode = default(System.String);
                __ctx1__.__Reqdate = default(System.String);
                __ctx1__.__strType = default(System.String);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!Receive940FlatFile.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__CM940Message != null)
                    __ctx1__.UnrefMessage(__ctx1__.__CM940Message);
                __ctx1__.__CM940Message = new __messagetype_Kaifa_B2B_Schemas__940_CM_940_Inbound("CM940Message", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__CM940Message);
                Receive940FlatFile.ReceiveMessage(0, __msgEnv__, __ctx1__.__CM940Message, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (Receive940FlatFile != null)
                {
                    Receive940FlatFile.Close(__ctx1__, __seg__);
                    Receive940FlatFile = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__CM940Message);
                    __edata.PortName = @"Receive940FlatFile";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__strContent = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__pulllistNo = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__siteCode = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__Reqdate = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__strType = "";
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                {
                    __messagetype_Kaifa_B2B_Schemas_InforAPI_InforShipmentOrder __ShipmentOrder = new __messagetype_Kaifa_B2B_Schemas_InforAPI_InforShipmentOrder("ShipmentOrder", __ctx1__);

                    ApplyTransform(typeof(Kaifa.B2B.Orchestration._940.Mapping.Cm_940_To_ShipmentOrder), new object[] {__ShipmentOrder.part}, new object[] {__ctx1__.__CM940Message.part});

                    if (__ctx1__.__ShipmentOrder != null)
                        __ctx1__.UnrefMessage(__ctx1__.__ShipmentOrder);
                    __ctx1__.__ShipmentOrder = __ShipmentOrder;
                    __ctx1__.RefMessage(__ctx1__.__ShipmentOrder);
                }
                __ctx1__.__ShipmentOrder.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__ShipmentOrder);
                    __edata.Messages.Add(__ctx1__.__CM940Message);
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                {
                    callBackEndRequest __CallServiceRequest = new callBackEndRequest("CallServiceRequest", __ctx1__);

                    ApplyTransform(typeof(Kaifa.B2B.Orchestration._940.Mapping.initMap), new object[] {__CallServiceRequest.parameters}, new object[] {__ctx1__.__ShipmentOrder.part});
                    __ctx1__.__strContent = Kaifa.B2B.Utility.HeaderHelper.ReturnStringRemoveNamespace(__ctx1__.__ShipmentOrder.part.TypedValue);
                    Kaifa.B2B.Utility.HeaderHelper.AssignmentInforRequest(__CallServiceRequest.parameters.TypedValue, "MessageProcessor", "ShipmentOrder", "storeByQuote", __ctx1__.__strContent);
                    if (__ctx1__ != null)
                        __ctx1__.__strContent = null;

                    if (__ctx1__.__CallServiceRequest != null)
                        __ctx1__.UnrefMessage(__ctx1__.__CallServiceRequest);
                    __ctx1__.__CallServiceRequest = __CallServiceRequest;
                    __ctx1__.RefMessage(__ctx1__.__CallServiceRequest);
                }
                __ctx1__.__CallServiceRequest.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__CallServiceRequest);
                    __edata.Messages.Add(__ctx1__.__ShipmentOrder);
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__ShipmentOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ShipmentOrder);
                    __ctx1__.__ShipmentOrder = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                InvokeInforWebService.SendMessage(0, __ctx1__.__CallServiceRequest, null, null, out __ctx0__.__subWrapper1, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__CallServiceRequest);
                    __edata.PortName = @"InvokeInforWebService";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__CallServiceRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CallServiceRequest);
                    __ctx1__.__CallServiceRequest = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if (!InvokeInforWebService.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__CallServiceReponse != null)
                    __ctx1__.UnrefMessage(__ctx1__.__CallServiceReponse);
                __ctx1__.__CallServiceReponse = new callBackEndResponse("CallServiceReponse", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__CallServiceReponse);
                InvokeInforWebService.ReceiveMessage(0, __msgEnv__, __ctx1__.__CallServiceReponse, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (InvokeInforWebService != null)
                {
                    InvokeInforWebService.Close(__ctx1__, __seg__);
                    InvokeInforWebService = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__CallServiceReponse);
                    __edata.PortName = @"InvokeInforWebService";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                __ctx1__.__pulllistNo = System.Convert.ToString(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__CM940Message.part, "string(/*[local-name()='CMInbound' and namespace-uri()='http://Kaifa.B2B.Schemas.940.CM_940_Inbound']/*[local-name()='Row' and namespace-uri()='http://Kaifa.B2B.Schemas.940.CM_940_Inbound'][1]/*[local-name()='PullNo' and namespace-uri()='http://Kaifa.B2B.Schemas.940.CM_940_Inbound'])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                __ctx1__.__siteCode = System.Convert.ToString(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__CM940Message.part, "string(/*[local-name()='CMInbound' and namespace-uri()='http://Kaifa.B2B.Schemas.940.CM_940_Inbound']/*[local-name()='Row' and namespace-uri()='http://Kaifa.B2B.Schemas.940.CM_940_Inbound'][1]/*[local-name()='Site' and namespace-uri()='http://Kaifa.B2B.Schemas.940.CM_940_Inbound'])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                __ctx1__.__strType = System.Convert.ToString(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__CM940Message.part, "string(/*[local-name()='CMInbound' and namespace-uri()='http://Kaifa.B2B.Schemas.940.CM_940_Inbound']/*[local-name()='Row' and namespace-uri()='http://Kaifa.B2B.Schemas.940.CM_940_Inbound'][1]/*[local-name()='PrimeOnly' and namespace-uri()='http://Kaifa.B2B.Schemas.940.CM_940_Inbound'])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                __ctx1__.__Reqdate = System.Convert.ToString(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__CM940Message.part, "string(/*[local-name()='CMInbound' and namespace-uri()='http://Kaifa.B2B.Schemas.940.CM_940_Inbound']/*[local-name()='Row' and namespace-uri()='http://Kaifa.B2B.Schemas.940.CM_940_Inbound'][1]/*[local-name()='RequestDate' and namespace-uri()='http://Kaifa.B2B.Schemas.940.CM_940_Inbound'])", typeof(System.Object)));
                if (__ctx1__ != null && __ctx1__.__CM940Message != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CM940Message);
                    __ctx1__.__CM940Message = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                Kaifa.B2B.Utility.MailClient.Send940NotificationMail(__ctx1__.__CallServiceReponse.parameters.TypedValue, __ctx1__.__pulllistNo, __ctx1__.__siteCode, __ctx1__.__Reqdate, __ctx1__.__strType);
                if (__ctx1__ != null)
                    __ctx1__.__strType = null;
                if (__ctx1__ != null)
                    __ctx1__.__Reqdate = null;
                if (__ctx1__ != null)
                    __ctx1__.__siteCode = null;
                if (__ctx1__ != null)
                    __ctx1__.__pulllistNo = null;
                if (__ctx1__ != null && __ctx1__.__CallServiceReponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CallServiceReponse);
                    __ctx1__.__CallServiceReponse = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 33;
            case 33:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{BA0DFFCC-8379-41E1-9858-39B28000B187}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __Kaifa_B2B_Schemas_InforAPI_InforShipmentOrder__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.Schemas.InforAPI.InforShipmentOrder _schema = new Kaifa.B2B.Schemas.InforAPI.InforShipmentOrder();

        public __Kaifa_B2B_Schemas_InforAPI_InforShipmentOrder__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Kaifa.B2B.Schemas.InforAPI.InforShipmentOrder",
        new System.Type[]{
            typeof(Kaifa.B2B.Schemas.InforAPI.InforShipmentOrder)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_Schemas_InforAPI_InforShipmentOrder__)
        },
        0,
        @"http://Kaifa.B2B.Schemas.InforAPI/InforShipmentOrder#Message"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Kaifa_B2B_Schemas_InforAPI_InforShipmentOrder : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_Schemas_InforAPI_InforShipmentOrder__ part;

        private void __CreatePartWrappers()
        {
            part = new __Kaifa_B2B_Schemas_InforAPI_InforShipmentOrder__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Kaifa_B2B_Schemas_InforAPI_InforShipmentOrder(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
