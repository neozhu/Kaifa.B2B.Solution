
#pragma warning disable 162

namespace Kaifa.B2B.Orchestration.TDN
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Kaifa.B2B.Orchestration.TDN.__messagetype_Kaifa_B2B_Schemas__940_OrderTND940)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_ReceiveTDN940 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_ReceiveTDN940(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_ReceiveTDN940(PortType_ReceiveTDN940 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_ReceiveTDN940 p = new PortType_ReceiveTDN940(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_ReceiveTDN940),
            typeof(__messagetype_Kaifa_B2B_Schemas__940_OrderTND940),
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

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Kaifa.B2B.Orchestration.TDN.__messagetype_Kaifa_B2B_Schemas__940_CM_TDN_940_Oubound)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_SendTDN940FTP : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_SendTDN940FTP(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_SendTDN940FTP(PortType_SendTDN940FTP p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_SendTDN940FTP p = new PortType_SendTDN940FTP(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_SendTDN940FTP),
            typeof(__messagetype_Kaifa_B2B_Schemas__940_CM_TDN_940_Oubound),
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

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Kaifa.B2B.Orchestration.TDN.__messagetype_Kaifa_B2B_Schemas__940_CM_TDN_940_Oubound)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_SendTDN940ToCCS : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_SendTDN940ToCCS(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_SendTDN940ToCCS(PortType_SendTDN940ToCCS p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_SendTDN940ToCCS p = new PortType_SendTDN940ToCCS(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_SendTDN940ToCCS),
            typeof(__messagetype_Kaifa_B2B_Schemas__940_CM_TDN_940_Oubound),
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
    //#line 263 "D:\长城开发项目\SourceCode\Kaifa.B2B.Solution\Kaifa.B2B.Orchestration.TDN\TDN_Orchestration.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "ReceiveTDN940", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Kaifa.B2B.Orchestration.TDN.PortType_ReceiveTDN940),
            typeof(Kaifa.B2B.Orchestration.TDN.PortType_SendTDN940ToCCS),
            typeof(Kaifa.B2B.Orchestration.TDN.PortType_SendTDN940FTP)
        },
        new System.String[] {
            "ReceiveTDN940",
            "SendTDN940ToCCS",
            "SendTDN940ToKFS"
        },
        new System.Type[] {
            null,
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
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class TDN_Orchestration : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(TDN_Orchestration));
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

        static TDN_Orchestration()
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
            _rootContext = new __TDN_Orchestration_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public TDN_Orchestration(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "TDN_Orchestration", tracker)
        {
            ConstructorHelper();
        }

        public TDN_Orchestration(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "TDN_Orchestration")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>cdbd7959-a3c9-405e-8062-f0abe0c64228</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>65c2ae18-58fd-447a-b233-e5be7bfc0b2a</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_OrderTND</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>ec8d8260-c74f-4e01-a9e6-2c5e8c036e6e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>2885551b-4666-4e39-bf54-2e4964e506fa</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>d8faf15d-9c35-4b0b-89b4-a33bdb0e4709</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>5f03b276-d5ba-4921-8d08-0d9d0a932dd5</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>7e5b3bec-95e7-4d7f-bdd9-b014de07a75b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>1851f3a4-fe95-41a4-b6bd-d131c42c2fee</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>ae1de3af-223f-4b84-a94f-05e90e03d139</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Decide_CMSITE</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>94ac5df5-8cee-4283-8cf6-4b538065950c</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_CCS</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>629d1916-2b93-4951-9aac-bc1dda64fedf</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_ToCCS</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>4f60530e-214c-4b9c-b76d-7f3b9826f750</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>abbf8641-96c4-4f54-b68b-dc9992fa39b2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_TDN940</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'TDN_Orchestration'</ActionName><IsAtomic>0</IsAtomic><Line>263</Line><Position>12</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>278</Line><Position>22</Position><ShapeID>'65c2ae18-58fd-447a-b233-e5be7bfc0b2a'</ShapeID>
<Messages>
	<MsgInfo><name>OrderTDNMessage</name><part>part</part><schema>Kaifa.B2B.Schemas._940.OrderTND940</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>282</Line><Position>13</Position><ShapeID>'ec8d8260-c74f-4e01-a9e6-2c5e8c036e6e'</ShapeID>
<Messages>
	<MsgInfo><name>TDN940Message</name><part>part</part><schema>Kaifa.B2B.Schemas._940.CM_TDN_940_Oubound</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>OrderTDNMessage</name><part>part</part><schema>Kaifa.B2B.Schemas._940.OrderTND940</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>292</Line><Position>13</Position><ShapeID>'ae1de3af-223f-4b84-a94f-05e90e03d139'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>295</Line><Position>17</Position><ShapeID>'629d1916-2b93-4951-9aac-bc1dda64fedf'</ShapeID>
<Messages>
	<MsgInfo><name>TDN940Message</name><part>part</part><schema>Kaifa.B2B.Schemas._940.CM_TDN_940_Oubound</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>300</Line><Position>17</Position><ShapeID>'abbf8641-96c4-4f54-b68b-dc9992fa39b2'</ShapeID>
<Messages>
	<MsgInfo><name>TDN940Message</name><part>part</part><schema>Kaifa.B2B.Schemas._940.CM_TDN_940_Oubound</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='1f96c98d-4b13-4a40-a4c5-1086eb14d5b7' LowerBound='1.1' HigherBound='68.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Kaifa.B2B.Orchestration.TDN' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='7be6c884-d78e-495b-affc-4280106a7da2' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_ReceiveTDN940' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='2b03ad3b-96da-4ca5-ab54-32e3ceaaa8ea' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='ff901f0b-47ee-4e6a-8e02-3b2057302cff' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.47'>
                    <om:Property Name='Ref' Value='Kaifa.B2B.Schemas._940.OrderTND940' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='90ddadbd-2bb4-4b62-bc4c-19b027cb418f' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_SendTDN940FTP' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='748cde7d-00fc-4140-a749-31d2528ffa88' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='dbb73f97-d751-42c2-aff9-903cacf96568' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.54'>
                    <om:Property Name='Ref' Value='Kaifa.B2B.Schemas._940.CM_TDN_940_Oubound' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='33bc5611-098a-4869-b021-9f4a825e8ce5' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_SendTDN940ToCCS' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='c161f970-26f7-4b01-9228-e87283a560f2' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='9d2d6579-045b-4e9b-bf87-05b3d05c0485' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.54'>
                    <om:Property Name='Ref' Value='Kaifa.B2B.Schemas._940.CM_TDN_940_Oubound' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='858e27df-cd07-4807-982b-999c975c55b0' ParentLink='Module_ServiceDeclaration' LowerBound='25.1' HigherBound='67.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='TDN_Orchestration' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='2055737b-1d36-451d-bc0e-33a2cb65bfc2' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='36.1' HigherBound='37.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FileName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='21a4868a-c321-4f67-90f2-884325aa01f1' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='37.1' HigherBound='38.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='cmsite' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='20237532-1deb-446b-98a6-f84fb9eaa598' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas._940.OrderTND940' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OrderTDNMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='cf0616a9-fe52-4309-b38e-15ee0d520be7' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='35.1' HigherBound='36.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas._940.CM_TDN_940_Oubound' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TDN940Message' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='cdbd7959-a3c9-405e-8062-f0abe0c64228' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='65c2ae18-58fd-447a-b233-e5be7bfc0b2a' ParentLink='ServiceBody_Statement' LowerBound='40.1' HigherBound='44.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='ReceiveTDN940' />
                    <om:Property Name='MessageName' Value='OrderTDNMessage' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_OrderTND' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='ec8d8260-c74f-4e01-a9e6-2c5e8c036e6e' ParentLink='ServiceBody_Statement' LowerBound='44.1' HigherBound='54.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='2885551b-4666-4e39-bf54-2e4964e506fa' ParentLink='ComplexStatement_Statement' LowerBound='47.1' HigherBound='49.1'>
                        <om:Property Name='ClassName' Value='Kaifa.B2B.Mapping.CM940_To_TDN' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='d8faf15d-9c35-4b0b-89b4-a33bdb0e4709' ParentLink='Transform_InputMessagePartRef' LowerBound='48.77' HigherBound='48.92'>
                            <om:Property Name='MessageRef' Value='OrderTDNMessage' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='5f03b276-d5ba-4921-8d08-0d9d0a932dd5' ParentLink='Transform_OutputMessagePartRef' LowerBound='48.28' HigherBound='48.41'>
                            <om:Property Name='MessageRef' Value='TDN940Message' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageAssignment' OID='7e5b3bec-95e7-4d7f-bdd9-b014de07a75b' ParentLink='ComplexStatement_Statement' LowerBound='49.1' HigherBound='53.1'>
                        <om:Property Name='Expression' Value='FileName =&quot;TDN_&quot; +  System.Convert.ToString(xpath(OrderTDNMessage,&quot;string(/*[local-name()=&apos;OrderTDN940&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.OrderTDN940&apos;]/*[local-name()=&apos;CM_TDN_940&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.OrderTDN940&apos;][1]/*[local-name()=&apos;ORDERKEY&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.OrderTDN940&apos;])&quot;));&#xD;&#xA;cmsite=System.Convert.ToString(xpath(OrderTDNMessage,&quot;string(/*[local-name()=&apos;OrderTDN940&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.OrderTDN940&apos;]/*[local-name()=&apos;CM_TDN_940&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.OrderTDN940&apos;][1]/*[local-name()=&apos;CMSITE&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.OrderTDN940&apos;])&quot;));&#xD;&#xA;TDN940Message(FILE.ReceivedFileName)=FileName;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='MessageAssignment_1' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='1851f3a4-fe95-41a4-b6bd-d131c42c2fee' ParentLink='Construct_MessageRef' LowerBound='45.23' HigherBound='45.36'>
                        <om:Property Name='Ref' Value='TDN940Message' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Decision' OID='ae1de3af-223f-4b84-a94f-05e90e03d139' ParentLink='ServiceBody_Statement' LowerBound='54.1' HigherBound='65.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Decide_CMSITE' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DecisionBranch' OID='94ac5df5-8cee-4283-8cf6-4b538065950c' ParentLink='ReallyComplexStatement_Branch' LowerBound='55.13' HigherBound='60.1'>
                        <om:Property Name='Expression' Value='cmsite.Trim() == &quot;CCS&quot;' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Rule_CCS' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Send' OID='629d1916-2b93-4951-9aac-bc1dda64fedf' ParentLink='ComplexStatement_Statement' LowerBound='57.1' HigherBound='59.1'>
                            <om:Property Name='PortName' Value='SendTDN940ToCCS' />
                            <om:Property Name='MessageName' Value='TDN940Message' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_ToCCS' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='4f60530e-214c-4b9c-b76d-7f3b9826f750' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Send' OID='abbf8641-96c4-4f54-b68b-dc9992fa39b2' ParentLink='ComplexStatement_Statement' LowerBound='62.1' HigherBound='64.1'>
                            <om:Property Name='PortName' Value='SendTDN940ToKFS' />
                            <om:Property Name='MessageName' Value='TDN940Message' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_TDN940' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='f81ed284-aed8-454c-a1dd-0e45cb644890' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='28.1' HigherBound='30.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Kaifa.B2B.Orchestration.TDN.PortType_ReceiveTDN940' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceiveTDN940' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='e2726c37-0110-4461-aede-712ee9a81296' ParentLink='PortDeclaration_CLRAttribute' LowerBound='28.1' HigherBound='29.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='75a62feb-393d-4847-8c90-be0a16e9725b' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='30.1' HigherBound='32.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Kaifa.B2B.Orchestration.TDN.PortType_SendTDN940FTP' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendTDN940ToKFS' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='6e66e088-af4f-4e21-9f57-4125f010dfec' ParentLink='PortDeclaration_CLRAttribute' LowerBound='30.1' HigherBound='31.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='3f52fd28-00e6-410b-9f7a-dd88d01d9592' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='32.1' HigherBound='34.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Kaifa.B2B.Orchestration.TDN.PortType_SendTDN940ToCCS' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendTDN940ToCCS' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='ce078237-72bf-4727-97e0-cddd6f9cc16c' ParentLink='PortDeclaration_CLRAttribute' LowerBound='32.1' HigherBound='33.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __TDN_Orchestration_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __TDN_Orchestration_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "TDN_Orchestration")
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
                TDN_Orchestration __svc__ = (TDN_Orchestration)_service;
                __TDN_Orchestration_root_0 __ctx0__ = (__TDN_Orchestration_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.SendTDN940ToCCS != null)
                {
                    __svc__.SendTDN940ToCCS.Close(this, null);
                    __svc__.SendTDN940ToCCS = null;
                }
                if (__svc__.ReceiveTDN940 != null)
                {
                    __svc__.ReceiveTDN940.Close(this, null);
                    __svc__.ReceiveTDN940 = null;
                }
                if (__svc__.SendTDN940ToKFS != null)
                {
                    __svc__.SendTDN940ToKFS.Close(this, null);
                    __svc__.SendTDN940ToKFS = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __TDN_Orchestration_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __TDN_Orchestration_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "TDN_Orchestration")
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
                TDN_Orchestration __svc__ = (TDN_Orchestration)_service;
                __TDN_Orchestration_1 __ctx1__ = (__TDN_Orchestration_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__cmsite = null;
                if (__ctx1__ != null && __ctx1__.__TDN940Message != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__TDN940Message);
                    __ctx1__.__TDN940Message = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__FileName = null;
                if (__ctx1__ != null && __ctx1__.__OrderTDNMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OrderTDNMessage);
                    __ctx1__.__OrderTDNMessage = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("OrderTDNMessage")]
            public __messagetype_Kaifa_B2B_Schemas__940_OrderTND940 __OrderTDNMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TDN940Message")]
            public __messagetype_Kaifa_B2B_Schemas__940_CM_TDN_940_Oubound __TDN940Message;
            [Microsoft.XLANGs.Core.UserVariableAttribute("FileName")]
            internal System.String __FileName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("cmsite")]
            internal System.String __cmsite;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("ReceiveTDN940")]
        internal PortType_ReceiveTDN940 ReceiveTDN940;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendTDN940ToCCS")]
        internal PortType_SendTDN940ToCCS SendTDN940ToCCS;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendTDN940ToKFS")]
        internal PortType_SendTDN940FTP SendTDN940ToKFS;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_ReceiveTDN940.Operation_1},
                                               typeof(TDN_Orchestration).GetField("ReceiveTDN940", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(TDN_Orchestration), "ReceiveTDN940"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_SendTDN940ToCCS.Operation_1},
                                               typeof(TDN_Orchestration).GetField("SendTDN940ToCCS", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(TDN_Orchestration), "SendTDN940ToCCS"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_SendTDN940FTP.Operation_1},
                                               typeof(TDN_Orchestration).GetField("SendTDN940ToKFS", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(TDN_Orchestration), "SendTDN940ToKFS"),
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
                h[_portInfo[2].Name] = _portInfo[2];
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "65c2ae18-58fd-447a-b233-e5be7bfc0b2a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "65c2ae18-58fd-447a-b233-e5be7bfc0b2a", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "ec8d8260-c74f-4e01-a9e6-2c5e8c036e6e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "ec8d8260-c74f-4e01-a9e6-2c5e8c036e6e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "ae1de3af-223f-4b84-a94f-05e90e03d139", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "629d1916-2b93-4951-9aac-bc1dda64fedf", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "629d1916-2b93-4951-9aac-bc1dda64fedf", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "abbf8641-96c4-4f54-b68b-dc9992fa39b2", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "abbf8641-96c4-4f54-b68b-dc9992fa39b2", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "ae1de3af-223f-4b84-a94f-05e90e03d139", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,4,4,5,6,6,7,7,7,8,6,9,9,9,10,11,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __TDN_Orchestration_1 __ctx1__ = (__TDN_Orchestration_1)_stateMgrs[1];
            __TDN_Orchestration_root_0 __ctx0__ = (__TDN_Orchestration_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                ReceiveTDN940 = new PortType_ReceiveTDN940(0, this);
                SendTDN940ToKFS = new PortType_SendTDN940FTP(2, this);
                SendTDN940ToCCS = new PortType_SendTDN940ToCCS(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], ReceiveTDN940, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __TDN_Orchestration_1(this);
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
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __TDN_Orchestration_1 __ctx1__ = (__TDN_Orchestration_1)_stateMgrs[1];
            __TDN_Orchestration_root_0 __ctx0__ = (__TDN_Orchestration_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__FileName = default(System.String);
                __ctx1__.__cmsite = default(System.String);
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
                if (!ReceiveTDN940.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__OrderTDNMessage != null)
                    __ctx1__.UnrefMessage(__ctx1__.__OrderTDNMessage);
                __ctx1__.__OrderTDNMessage = new __messagetype_Kaifa_B2B_Schemas__940_OrderTND940("OrderTDNMessage", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__OrderTDNMessage);
                ReceiveTDN940.ReceiveMessage(0, __msgEnv__, __ctx1__.__OrderTDNMessage, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (ReceiveTDN940 != null)
                {
                    ReceiveTDN940.Close(__ctx1__, __seg__);
                    ReceiveTDN940 = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__OrderTDNMessage);
                    __edata.PortName = @"ReceiveTDN940";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__FileName = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__cmsite = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                {
                    __messagetype_Kaifa_B2B_Schemas__940_CM_TDN_940_Oubound __TDN940Message = new __messagetype_Kaifa_B2B_Schemas__940_CM_TDN_940_Oubound("TDN940Message", __ctx1__);

                    ApplyTransform(typeof(Kaifa.B2B.Mapping.CM940_To_TDN), new object[] {__TDN940Message.part}, new object[] {__ctx1__.__OrderTDNMessage.part});
                    __ctx1__.__FileName = "TDN_" + System.Convert.ToString(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__OrderTDNMessage.part, "string(/*[local-name()='OrderTDN940' and namespace-uri()='http://Kaifa.B2B.Schemas.OrderTDN940']/*[local-name()='CM_TDN_940' and namespace-uri()='http://Kaifa.B2B.Schemas.OrderTDN940'][1]/*[local-name()='ORDERKEY' and namespace-uri()='http://Kaifa.B2B.Schemas.OrderTDN940'])", typeof(System.Object)));
                    __ctx1__.__cmsite = System.Convert.ToString(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__OrderTDNMessage.part, "string(/*[local-name()='OrderTDN940' and namespace-uri()='http://Kaifa.B2B.Schemas.OrderTDN940']/*[local-name()='CM_TDN_940' and namespace-uri()='http://Kaifa.B2B.Schemas.OrderTDN940'][1]/*[local-name()='CMSITE' and namespace-uri()='http://Kaifa.B2B.Schemas.OrderTDN940'])", typeof(System.Object)));
                    __TDN940Message.SetPropertyValue(typeof(FILE.ReceivedFileName), __ctx1__.__FileName);
                    if (__ctx1__ != null)
                        __ctx1__.__FileName = null;

                    if (__ctx1__.__TDN940Message != null)
                        __ctx1__.UnrefMessage(__ctx1__.__TDN940Message);
                    __ctx1__.__TDN940Message = __TDN940Message;
                    __ctx1__.RefMessage(__ctx1__.__TDN940Message);
                }
                __ctx1__.__TDN940Message.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__TDN940Message);
                    __edata.Messages.Add(__ctx1__.__OrderTDNMessage);
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__OrderTDNMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OrderTDNMessage);
                    __ctx1__.__OrderTDNMessage = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                __condition__ = __ctx1__.__cmsite.Trim() == "CCS";
                if (__ctx1__ != null)
                    __ctx1__.__cmsite = null;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 17;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendTDN940ToCCS.SendMessage(0, __ctx1__.__TDN940Message, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__TDN940Message);
                    __edata.PortName = @"SendTDN940ToCCS";
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendTDN940ToKFS.SendMessage(0, __ctx1__.__TDN940Message, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__TDN940Message);
                    __edata.PortName = @"SendTDN940ToKFS";
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__TDN940Message != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__TDN940Message);
                    __ctx1__.__TDN940Message = null;
                }
                if (SendTDN940ToCCS != null)
                {
                    SendTDN940ToCCS.Close(__ctx1__, __seg__);
                    SendTDN940ToCCS = null;
                }
                if (SendTDN940ToKFS != null)
                {
                    SendTDN940ToKFS.Close(__ctx1__, __seg__);
                    SendTDN940ToKFS = null;
                }
                Tracker.FireEvent(__eventLocations[11],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 25;
            case 25:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __Kaifa_B2B_Schemas__940_OrderTND940__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.Schemas._940.OrderTND940 _schema = new Kaifa.B2B.Schemas._940.OrderTND940();

        public __Kaifa_B2B_Schemas__940_OrderTND940__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Kaifa.B2B.Schemas._940.OrderTND940",
        new System.Type[]{
            typeof(Kaifa.B2B.Schemas._940.OrderTND940)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_Schemas__940_OrderTND940__)
        },
        0,
        @"http://Kaifa.B2B.Schemas.OrderTDN940#OrderTDN940"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Kaifa_B2B_Schemas__940_OrderTND940 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_Schemas__940_OrderTND940__ part;

        private void __CreatePartWrappers()
        {
            part = new __Kaifa_B2B_Schemas__940_OrderTND940__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Kaifa_B2B_Schemas__940_OrderTND940(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Kaifa_B2B_Schemas__940_CM_TDN_940_Oubound__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.Schemas._940.CM_TDN_940_Oubound _schema = new Kaifa.B2B.Schemas._940.CM_TDN_940_Oubound();

        public __Kaifa_B2B_Schemas__940_CM_TDN_940_Oubound__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Kaifa.B2B.Schemas._940.CM_TDN_940_Oubound",
        new System.Type[]{
            typeof(Kaifa.B2B.Schemas._940.CM_TDN_940_Oubound)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_Schemas__940_CM_TDN_940_Oubound__)
        },
        0,
        @"http://Kaifa.B2B.Schemas.940.CM_TDN_940_Oubound#CM_TDN_940_Oubound"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Kaifa_B2B_Schemas__940_CM_TDN_940_Oubound : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_Schemas__940_CM_TDN_940_Oubound__ part;

        private void __CreatePartWrappers()
        {
            part = new __Kaifa_B2B_Schemas__940_CM_TDN_940_Oubound__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Kaifa_B2B_Schemas__940_CM_TDN_940_Oubound(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
