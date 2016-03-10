
#pragma warning disable 162

namespace Kaifa.B2B.Orchestration.SZDHUB
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Kaifa.B2B.Orchestration.SZDHUB.__messagetype_Kaifa_B2B_Schemas_Wms_AdvancedShipNotice)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_ReceiveReceiptMessage : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_ReceiveReceiptMessage(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_ReceiveReceiptMessage(PortType_ReceiveReceiptMessage p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_ReceiveReceiptMessage p = new PortType_ReceiveReceiptMessage(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_ReceiveReceiptMessage),
            typeof(__messagetype_Kaifa_B2B_Schemas_Wms_AdvancedShipNotice),
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
            typeof(Kaifa.B2B.Orchestration.SZDHUB.__messagetype_Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_SendPip4B2Message : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_SendPip4B2Message(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_SendPip4B2Message(PortType_SendPip4B2Message p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_SendPip4B2Message p = new PortType_SendPip4B2Message(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_SendPip4B2Message),
            typeof(__messagetype_Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification),
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
    //#line 399 "D:\长城开发项目\SourceCode\Kaifa.B2B.Solution\Kaifa.B2B.Orchestration.SZDHUB\HUB.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "ReceiveReceiptMessage", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Kaifa.B2B.Orchestration.SZDHUB.PortType_ReceiveReceiptMessage),
            typeof(Kaifa.B2B.Orchestration.SZDHUB.PortType_SendPip4B2Message)
        },
        new System.String[] {
            "ReceiveReceiptMessage",
            "SendPip4B2Message"
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
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone|Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eLongRunning
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class SZDHUB_Orchestration : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(SZDHUB_Orchestration));
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

        static SZDHUB_Orchestration()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 1, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 1, 3)
            };

            _Locks = 0;
            _rootContext = new __SZDHUB_Orchestration_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public SZDHUB_Orchestration(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "SZDHUB_Orchestration", tracker)
        {
            ConstructorHelper();
        }

        public SZDHUB_Orchestration(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "SZDHUB_Orchestration")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>8f24dd97-8282-4b81-b848-6750524a0fc1</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>e0849b52-4ea6-446e-bcd5-4763c086dc9c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_Asn</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>6f911b84-fd30-432a-85cb-548a5af86ffc</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>GetCount</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>WhileShape</shapeType>      <ShapeID>d7377d02-7445-4ecb-8841-ed57d5f2dd33</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Loop_SplitAsnMessage</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>5615b1a6-0f1b-45db-a768-599dcec1e6ce</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_VendorRecriptMessage_STX</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>8a264a3a-ad7e-48c2-bd8a-6343ec0e9ccb</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>1fab0dde-b75c-4976-a1a6-fe75bea5c0c8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParallelShape</shapeType>      <ShapeID>f2aec304-75f2-441e-97a7-814658aaa5b1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ParallelActions_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>3efb9ea6-e394-48a5-a2d4-0a3ecebd7035</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>a352ba7b-165d-4b4a-a445-968c5992d4f1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_Pip4B2_STX</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>48f450f9-154a-4390-82ec-e6b3660b8ca1</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>ea19a370-4062-479f-9b83-d2c0a32bc609</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>707ebd4e-14d5-4172-bdfe-cf67fd1fe899</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>f04c1f5e-1c02-40b0-867a-2a17ed07bedd</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>366d40c4-baa8-49e1-b0d1-704deed48b0e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>1c339882-adbb-4b42-8eb3-ce6d93a03d27</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_Pip4B2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>23b5ba95-6fe6-4a50-966b-81c2abb81472</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>InvokeSubmitRNIFAPI</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>c031ba37-5989-47ae-aee5-1dde82174815</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>1b6f4d5b-2e8c-4dec-b63f-0933e49d1bfa</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_Pip4B2_e2Open</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>500ee410-56f0-4748-91a6-b96f4db68c2f</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>315c34c4-3f42-4977-9605-d95283fd96eb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>88cf9547-88ca-4a70-840c-2f89d38f8586</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>608e84f4-9fd6-403a-8092-dd1d539fd33c</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>85ea6851-a74c-41b6-bf8a-d7591664eb5d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>0f5ef346-64e7-42e1-8008-dc3c3bb24b51</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_Pip4B2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>cb78cbbf-276b-491f-9e2a-ffb7bd5e7875</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>InvokeSubmitRNIFAPI</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>5838c814-0d11-4e41-bee3-80d9522076eb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Increasing</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'SZDHUB_Orchestration'</ActionName><IsAtomic>0</IsAtomic><Line>399</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>424</Line><Position>22</Position><ShapeID>'e0849b52-4ea6-446e-bcd5-4763c086dc9c'</ShapeID>
<Messages>
	<MsgInfo><name>AdvancedShipNoticeMessage</name><part>part</part><schema>Kaifa.B2B.Schemas.Wms.AdvancedShipNotice</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>436</Line><Position>19</Position><ShapeID>'6f911b84-fd30-432a-85cb-548a5af86ffc'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>440</Line><Position>13</Position><ShapeID>'d7377d02-7445-4ecb-8841-ed57d5f2dd33'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>443</Line><Position>17</Position><ShapeID>'5615b1a6-0f1b-45db-a768-599dcec1e6ce'</ShapeID>
<Messages>
	<MsgInfo><name>VendorReciptReportMessage</name><part>part</part><schema>Kaifa.B2B.Schemas.Wms.VendorReceiptReport</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>450</Line><Position>17</Position><ShapeID>'f2aec304-75f2-441e-97a7-814658aaa5b1'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>455</Line><Position>25</Position><ShapeID>'a352ba7b-165d-4b4a-a445-968c5992d4f1'</ShapeID>
<Messages>
	<MsgInfo><name>Pip4B2MessageForSTX</name><part>part</part><schema>Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>VendorReciptReportMessage</name><part>part</part><schema>Kaifa.B2B.Schemas.Wms.VendorReceiptReport</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>465</Line><Position>25</Position><ShapeID>'1c339882-adbb-4b42-8eb3-ce6d93a03d27'</ShapeID>
<Messages>
	<MsgInfo><name>Pip4B2MessageForSTX</name><part>part</part><schema>Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>468</Line><Position>52</Position><ShapeID>'23b5ba95-6fe6-4a50-966b-81c2abb81472'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>487</Line><Position>25</Position><ShapeID>'1b6f4d5b-2e8c-4dec-b63f-0933e49d1bfa'</ShapeID>
<Messages>
	<MsgInfo><name>Pip4B2MessageForE2Open</name><part>part</part><schema>Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>VendorReciptReportMessage</name><part>part</part><schema>Kaifa.B2B.Schemas.Wms.VendorReceiptReport</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>497</Line><Position>25</Position><ShapeID>'0f5ef346-64e7-42e1-8008-dc3c3bb24b51'</ShapeID>
<Messages>
	<MsgInfo><name>Pip4B2MessageForE2Open</name><part>part</part><schema>Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>500</Line><Position>55</Position><ShapeID>'cb78cbbf-276b-491f-9e2a-ffb7bd5e7875'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>517</Line><Position>26</Position><ShapeID>'5838c814-0d11-4e41-bee3-80d9522076eb'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='3ab5fd50-538e-4924-9398-6a79c947cbbd' LowerBound='1.1' HigherBound='142.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Kaifa.B2B.Orchestration.SZDHUB' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='c0de52dc-0851-415b-a36a-227e96284fc1' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='141.1'>
            <om:Property Name='InitializedTransactionType' Value='True' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SZDHUB_Orchestration' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='08c48088-ea72-4ad5-84ea-ca1b681ea6c1' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='Microsoft.Solutions.BTARN.Shared.SubmitRNIF' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SubmitRNIF1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='4c8defd5-a3c0-497d-8354-bb0ca614a932' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strPipMessageForSTX' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='d247b7e0-9f08-4775-8641-4ade5b3a060b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='31.1' HigherBound='32.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strPipMessageFore2open' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='b87a4df3-ad4a-4332-af5e-e8cb0d67b94d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='32.1' HigherBound='33.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='pipInstanceMessageIdFore2open' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='330795eb-ed24-4a5f-81a4-fdf27b5e4e2e' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='33.1' HigherBound='34.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='pipInstanceIdentifierForSTX' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='0422784c-246b-460f-a151-904677339bc7' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='pipInstanceIdentifierFore2open' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='0c8137b8-9bd3-45b6-9ff7-4fb4364bea91' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='35.1' HigherBound='36.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='Microsoft.Solutions.BTARN.Shared.SubmitRNIF' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SubmitRNIF' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='08aaa78b-f141-47f6-8815-c37e2f470831' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='36.1' HigherBound='37.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Increase' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='4e0095d3-f705-461a-a305-d1c138fd1beb' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='37.1' HigherBound='38.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CountStr' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='161d4e3b-5d32-4a54-b3ea-0d4ff1ad0f64' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='38.1' HigherBound='39.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Count' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8e996d79-b2e4-40c8-802c-6d30ca218f3b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='39.1' HigherBound='40.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='pipInstanceMessageIdForSTX' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8d3d95ae-df96-438f-a6b0-5fb489334cfc' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='40.1' HigherBound='41.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SCHEDULELocation' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='LongRunningTransaction' OID='6b86803a-8cc3-421d-8968-404a53f7e3fa' ParentLink='ServiceDeclaration_Transaction' LowerBound='19.21' HigherBound='19.66'>
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Transaction_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='7f9eeb67-2bbe-4b41-986b-35d734b1f415' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas.Wms.VendorReceiptReport' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='VendorReciptReportMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='0918e418-3179-4582-bdf2-8317e233e53f' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Pip4B2MessageForSTX' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='029db664-ece6-472b-ab7a-edfa935aa9f4' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Pip4B2MessageForE2Open' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='85a87561-8f9c-4195-9846-d86ed4c2760a' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas.Wms.AdvancedShipNotice' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='AdvancedShipNoticeMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='8f24dd97-8282-4b81-b848-6750524a0fc1' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='e0849b52-4ea6-446e-bcd5-4763c086dc9c' ParentLink='ServiceBody_Statement' LowerBound='43.1' HigherBound='55.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='ReceiveReceiptMessage' />
                    <om:Property Name='MessageName' Value='AdvancedShipNoticeMessage' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_Asn' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='6f911b84-fd30-432a-85cb-548a5af86ffc' ParentLink='ServiceBody_Statement' LowerBound='55.1' HigherBound='59.1'>
                    <om:Property Name='Expression' Value='Count = xpath(AdvancedShipNoticeMessage, &quot;count(/*[local-name()=&apos;AdvancedShipNotice&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/AdvancedShipNotice&apos;]/*[local-name()=&apos;VendorReceiptReport&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/AdvancedShipNotice&apos;])&quot;); &#xD;&#xA;CountStr = Count.ToString();&#xD;&#xA;Increase = 1;&#xD;&#xA;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='GetCount' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='While' OID='d7377d02-7445-4ecb-8841-ed57d5f2dd33' ParentLink='ServiceBody_Statement' LowerBound='59.1' HigherBound='139.1'>
                    <om:Property Name='Expression' Value='Increase&lt;=Count ' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Loop_SplitAsnMessage' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Construct' OID='5615b1a6-0f1b-45db-a768-599dcec1e6ce' ParentLink='ComplexStatement_Statement' LowerBound='62.1' HigherBound='69.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructMessage_VendorRecriptMessage_STX' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageRef' OID='8a264a3a-ad7e-48c2-bd8a-6343ec0e9ccb' ParentLink='Construct_MessageRef' LowerBound='63.27' HigherBound='63.52'>
                            <om:Property Name='Ref' Value='VendorReciptReportMessage' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageAssignment' OID='1fab0dde-b75c-4976-a1a6-fe75bea5c0c8' ParentLink='ComplexStatement_Statement' LowerBound='65.1' HigherBound='68.1'>
                            <om:Property Name='Expression' Value='CountStr = Increase.ToString();&#xD;&#xA;VendorReciptReportMessage =  xpath(AdvancedShipNoticeMessage, &quot;/*[local-name()=&apos;AdvancedShipNotice&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/AdvancedShipNotice&apos;]/*[local-name()=&apos;VendorReceiptReport&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/AdvancedShipNotice&apos;][&quot; + CountStr + &quot;]&quot;);' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='MessageAssignment_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Parallel' OID='f2aec304-75f2-441e-97a7-814658aaa5b1' ParentLink='ComplexStatement_Statement' LowerBound='69.1' HigherBound='136.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ParallelActions_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='ParallelBranch' OID='3efb9ea6-e394-48a5-a2d4-0a3ecebd7035' ParentLink='ReallyComplexStatement_Branch' LowerBound='74.1' HigherBound='103.1'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ParallelBranch_1' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Construct' OID='a352ba7b-165d-4b4a-a445-968c5992d4f1' ParentLink='ComplexStatement_Statement' LowerBound='74.1' HigherBound='84.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ConstructMessage_Pip4B2_STX' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageRef' OID='48f450f9-154a-4390-82ec-e6b3660b8ca1' ParentLink='Construct_MessageRef' LowerBound='75.35' HigherBound='75.54'>
                                    <om:Property Name='Ref' Value='Pip4B2MessageForSTX' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Transform' OID='ea19a370-4062-479f-9b83-d2c0a32bc609' ParentLink='ComplexStatement_Statement' LowerBound='77.1' HigherBound='79.1'>
                                    <om:Property Name='ClassName' Value='Kaifa.B2B.SZD.Mapping.ASN_To_4B2_STX' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Transform_1' />
                                    <om:Property Name='Signal' Value='False' />
                                    <om:Element Type='MessagePartRef' OID='707ebd4e-14d5-4172-bdfe-cf67fd1fe899' ParentLink='Transform_InputMessagePartRef' LowerBound='78.101' HigherBound='78.126'>
                                        <om:Property Name='MessageRef' Value='VendorReciptReportMessage' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_1' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessagePartRef' OID='f04c1f5e-1c02-40b0-867a-2a17ed07bedd' ParentLink='Transform_OutputMessagePartRef' LowerBound='78.40' HigherBound='78.59'>
                                        <om:Property Name='MessageRef' Value='Pip4B2MessageForSTX' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_2' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='MessageAssignment' OID='366d40c4-baa8-49e1-b0d1-704deed48b0e' ParentLink='ComplexStatement_Statement' LowerBound='79.1' HigherBound='83.1'>
                                    <om:Property Name='Expression' Value='pipInstanceIdentifierForSTX =  Pip4B2MessageForSTX.thisDocumentIdentifier.ProprietaryDocumentIdentifier;&#xD;&#xA;Pip4B2MessageForSTX(FILE.ReceivedFileName) = &quot;HUB_To_STX＿&quot;  + pipInstanceIdentifierForSTX + &quot;.xml&quot;;&#xD;&#xA;//pipInstanceMessageIdForSTX = Pip4B2MessageForSTX(BTS.MessageID);' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='MessageAssignment_3' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Send' OID='1c339882-adbb-4b42-8eb3-ce6d93a03d27' ParentLink='ComplexStatement_Statement' LowerBound='84.1' HigherBound='86.1'>
                                <om:Property Name='PortName' Value='SendPip4B2Message' />
                                <om:Property Name='MessageName' Value='Pip4B2MessageForSTX' />
                                <om:Property Name='OperationName' Value='Operation_1' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send_Pip4B2' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='23b5ba95-6fe6-4a50-966b-81c2abb81472' ParentLink='ComplexStatement_Statement' LowerBound='86.1' HigherBound='103.1'>
                                <om:Property Name='Expression' Value='//&#xD;&#xA;pipInstanceMessageIdForSTX = Pip4B2MessageForSTX(BTS.MessageID);&#xD;&#xA;strPipMessageForSTX  =  Kaifa.B2B.Utility.HeaderHelper.ReturnSCWithDocType(Pip4B2MessageForSTX,&quot;4B2SG0100&quot;);&#xD;&#xA;System.Diagnostics.Trace.WriteLine(&quot;SubmitRNIF.SubmitMessage To STX &quot; + pipInstanceMessageIdForSTX + &quot; - &quot; + pipInstanceIdentifierForSTX,&quot;kaifa.b2b&quot;);&#xD;&#xA;//System.Diagnostics.Trace.WriteLine(&quot;SubmitRNIF.SubmitMessage To STX &quot; + pipInstanceMessageIdForSTX + &quot; - &quot; + pipInstanceIdentifierForSTX,&quot;kaifa.b2b&quot;);&#xD;&#xA; SubmitRNIF.SubmitMessage(Microsoft.Solutions.BTARN.Shared.MessageCategory.AsyncAction,&#xD;&#xA; &quot;KAIFA&quot;,&#xD;&#xA; &quot;SEAGATE-US&quot;,&#xD;&#xA; &quot;4B2&quot;,&#xD;&#xA; pipInstanceIdentifierForSTX,&#xD;&#xA; &quot;1.0&quot;,&#xD;&#xA; strPipMessageForSTX&#xD;&#xA; );&#xD;&#xA;&#xD;&#xA;&#xD;&#xA; ' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='InvokeSubmitRNIFAPI' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='ParallelBranch' OID='c031ba37-5989-47ae-aee5-1dde82174815' ParentLink='ReallyComplexStatement_Branch' LowerBound='106.1' HigherBound='134.1'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ParallelBranch_2' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Construct' OID='1b6f4d5b-2e8c-4dec-b63f-0933e49d1bfa' ParentLink='ComplexStatement_Statement' LowerBound='106.1' HigherBound='116.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ConstructMessage_Pip4B2_e2Open' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageRef' OID='500ee410-56f0-4748-91a6-b96f4db68c2f' ParentLink='Construct_MessageRef' LowerBound='107.35' HigherBound='107.57'>
                                    <om:Property Name='Ref' Value='Pip4B2MessageForE2Open' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Transform' OID='315c34c4-3f42-4977-9605-d95283fd96eb' ParentLink='ComplexStatement_Statement' LowerBound='109.1' HigherBound='111.1'>
                                    <om:Property Name='ClassName' Value='Kaifa.B2B.SZD.Mapping.ASN_To_4B2_e2open' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Transform_2' />
                                    <om:Property Name='Signal' Value='False' />
                                    <om:Element Type='MessagePartRef' OID='88cf9547-88ca-4a70-840c-2f89d38f8586' ParentLink='Transform_OutputMessagePartRef' LowerBound='110.40' HigherBound='110.62'>
                                        <om:Property Name='MessageRef' Value='Pip4B2MessageForE2Open' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_4' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessagePartRef' OID='608e84f4-9fd6-403a-8092-dd1d539fd33c' ParentLink='Transform_InputMessagePartRef' LowerBound='110.107' HigherBound='110.132'>
                                        <om:Property Name='MessageRef' Value='VendorReciptReportMessage' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_3' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='MessageAssignment' OID='85ea6851-a74c-41b6-bf8a-d7591664eb5d' ParentLink='ComplexStatement_Statement' LowerBound='111.1' HigherBound='115.1'>
                                    <om:Property Name='Expression' Value='pipInstanceIdentifierFore2open =  Pip4B2MessageForE2Open.thisDocumentIdentifier.ProprietaryDocumentIdentifier;&#xD;&#xA;Pip4B2MessageForE2Open(FILE.ReceivedFileName) = &quot;HUB_To_e2open＿&quot;  + pipInstanceIdentifierFore2open + &quot;.xml&quot;;&#xD;&#xA;//pipInstanceMessageIdFore2open = Pip4B2MessageForE2Open(BTS.MessageID);' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='MessageAssignment_3' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Send' OID='0f5ef346-64e7-42e1-8008-dc3c3bb24b51' ParentLink='ComplexStatement_Statement' LowerBound='116.1' HigherBound='118.1'>
                                <om:Property Name='PortName' Value='SendPip4B2Message' />
                                <om:Property Name='MessageName' Value='Pip4B2MessageForE2Open' />
                                <om:Property Name='OperationName' Value='Operation_1' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send_Pip4B2' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='cb78cbbf-276b-491f-9e2a-ffb7bd5e7875' ParentLink='ComplexStatement_Statement' LowerBound='118.1' HigherBound='134.1'>
                                <om:Property Name='Expression' Value='//&#xD;&#xA;pipInstanceMessageIdFore2open = Pip4B2MessageForE2Open(BTS.MessageID);&#xD;&#xA;strPipMessageFore2open  =  Kaifa.B2B.Utility.HeaderHelper.ReturnSCWithDocType(Pip4B2MessageForE2Open,&quot;4B2SG0100&quot;);&#xD;&#xA;&#xD;&#xA;System.Diagnostics.Trace.WriteLine(&quot;SubmitRNIF.SubmitMessage To e2open &quot; + pipInstanceMessageIdFore2open + &quot; - &quot; + pipInstanceIdentifierFore2open,&quot;kaifa.b2b&quot;);&#xD;&#xA; SubmitRNIF1.SubmitMessage(Microsoft.Solutions.BTARN.Shared.MessageCategory.AsyncAction,&#xD;&#xA; &quot;KAIFA&quot;,&#xD;&#xA; &quot;E2OPEN&quot;,&#xD;&#xA; &quot;4B2&quot;,&#xD;&#xA; pipInstanceIdentifierFore2open,&#xD;&#xA; &quot;1.0&quot;,&#xD;&#xA; strPipMessageFore2open&#xD;&#xA; );&#xD;&#xA;&#xD;&#xA; ' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='InvokeSubmitRNIFAPI' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='5838c814-0d11-4e41-bee3-80d9522076eb' ParentLink='ComplexStatement_Statement' LowerBound='136.1' HigherBound='138.1'>
                        <om:Property Name='Expression' Value='Increase = Increase + 1;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Increasing' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='d665d026-3f26-4550-9390-64180d69b392' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Kaifa.B2B.Orchestration.SZDHUB.PortType_ReceiveReceiptMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceiveReceiptMessage' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='a3b9c8a9-cfb4-468c-9fef-ce327ecfa8a6' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='f51838b5-8c56-4ca7-becd-33c8d1297ee8' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Kaifa.B2B.Orchestration.SZDHUB.PortType_SendPip4B2Message' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendPip4B2Message' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='a05f6785-9600-42f6-a4ed-837c45c4c1af' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='d4951976-74ec-4b50-9480-7f303ca8c525' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_ReceiveReceiptMessage' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='d4f880b8-882f-44df-b092-aa37d3d2e8b8' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='b14b6e17-7245-4edb-be85-6cce88a6d689' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.53'>
                    <om:Property Name='Ref' Value='Kaifa.B2B.Schemas.Wms.AdvancedShipNotice' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='45310eb0-0a32-4aca-a9d5-2714a1d2a40c' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_SendPip4B2Message' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='7736377a-9e5b-4369-a1ca-2184564479ec' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='ab67e3be-835a-48ba-82f5-af65af9ff823' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.87'>
                    <om:Property Name='Ref' Value='Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __SZDHUB_Orchestration_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __SZDHUB_Orchestration_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "SZDHUB_Orchestration")
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
                SZDHUB_Orchestration __svc__ = (SZDHUB_Orchestration)_service;
                __SZDHUB_Orchestration_root_0 __ctx0__ = (__SZDHUB_Orchestration_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.ReceiveReceiptMessage != null)
                {
                    __svc__.ReceiveReceiptMessage.Close(this, null);
                    __svc__.ReceiveReceiptMessage = null;
                }
                if (__svc__.SendPip4B2Message != null)
                {
                    __svc__.SendPip4B2Message.Close(this, null);
                    __svc__.SendPip4B2Message = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __SZDHUB_Orchestration_1 : Microsoft.XLANGs.Core.LongRunningTransaction
        {
            public __SZDHUB_Orchestration_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "SZDHUB_Orchestration")
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
                SZDHUB_Orchestration __svc__ = (SZDHUB_Orchestration)_service;
                __SZDHUB_Orchestration_1 __ctx1__ = (__SZDHUB_Orchestration_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__SubmitRNIF1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceMessageIdFore2open = null;
                if (__ctx1__ != null && __ctx1__.__AdvancedShipNoticeMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__AdvancedShipNoticeMessage);
                    __ctx1__.__AdvancedShipNoticeMessage = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__SubmitRNIF = null;
                if (__ctx1__ != null && __ctx1__.__VendorReciptReportMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__VendorReciptReportMessage);
                    __ctx1__.__VendorReciptReportMessage = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__SCHEDULELocation = null;
                if (__ctx1__ != null)
                    __ctx1__.__CountStr = null;
                if (__ctx1__ != null && __ctx1__.__Pip4B2MessageForSTX != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Pip4B2MessageForSTX);
                    __ctx1__.__Pip4B2MessageForSTX = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceIdentifierFore2open = null;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceMessageIdForSTX = null;
                if (__ctx1__ != null && __ctx1__.__Pip4B2MessageForE2Open != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Pip4B2MessageForE2Open);
                    __ctx1__.__Pip4B2MessageForE2Open = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceIdentifierForSTX = null;
                if (__ctx1__ != null)
                    __ctx1__.__strPipMessageForSTX = null;
                if (__ctx1__ != null)
                    __ctx1__.__strPipMessageFore2open = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("VendorReciptReportMessage")]
            public __messagetype_Kaifa_B2B_Schemas_Wms_VendorReceiptReport __VendorReciptReportMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Pip4B2MessageForSTX")]
            public __messagetype_Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification __Pip4B2MessageForSTX;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Pip4B2MessageForE2Open")]
            public __messagetype_Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification __Pip4B2MessageForE2Open;
            [Microsoft.XLANGs.Core.UserVariableAttribute("AdvancedShipNoticeMessage")]
            public __messagetype_Kaifa_B2B_Schemas_Wms_AdvancedShipNotice __AdvancedShipNoticeMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SubmitRNIF1")]
            internal Microsoft.Solutions.BTARN.Shared.SubmitRNIF __SubmitRNIF1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strPipMessageForSTX")]
            internal System.String __strPipMessageForSTX;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strPipMessageFore2open")]
            internal System.String __strPipMessageFore2open;
            [Microsoft.XLANGs.Core.UserVariableAttribute("pipInstanceMessageIdFore2open")]
            internal System.String __pipInstanceMessageIdFore2open;
            [Microsoft.XLANGs.Core.UserVariableAttribute("pipInstanceIdentifierForSTX")]
            internal System.String __pipInstanceIdentifierForSTX;
            [Microsoft.XLANGs.Core.UserVariableAttribute("pipInstanceIdentifierFore2open")]
            internal System.String __pipInstanceIdentifierFore2open;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SubmitRNIF")]
            internal Microsoft.Solutions.BTARN.Shared.SubmitRNIF __SubmitRNIF;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Increase")]
            internal System.Int32 __Increase;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CountStr")]
            internal System.String __CountStr;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Count")]
            internal System.Int32 __Count;
            [Microsoft.XLANGs.Core.UserVariableAttribute("pipInstanceMessageIdForSTX")]
            internal System.String __pipInstanceMessageIdForSTX;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SCHEDULELocation")]
            internal System.String __SCHEDULELocation;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("ReceiveReceiptMessage")]
        internal PortType_ReceiveReceiptMessage ReceiveReceiptMessage;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendPip4B2Message")]
        internal PortType_SendPip4B2Message SendPip4B2Message;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_ReceiveReceiptMessage.Operation_1},
                                               typeof(SZDHUB_Orchestration).GetField("ReceiveReceiptMessage", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(SZDHUB_Orchestration), "ReceiveReceiptMessage"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_SendPip4B2Message.Operation_1},
                                               typeof(SZDHUB_Orchestration).GetField("SendPip4B2Message", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(SZDHUB_Orchestration), "SendPip4B2Message"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "e0849b52-4ea6-446e-bcd5-4763c086dc9c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "e0849b52-4ea6-446e-bcd5-4763c086dc9c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "6f911b84-fd30-432a-85cb-548a5af86ffc", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "6f911b84-fd30-432a-85cb-548a5af86ffc", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "d7377d02-7445-4ecb-8841-ed57d5f2dd33", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "5615b1a6-0f1b-45db-a768-599dcec1e6ce", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "5615b1a6-0f1b-45db-a768-599dcec1e6ce", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "f2aec304-75f2-441e-97a7-814658aaa5b1", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "f2aec304-75f2-441e-97a7-814658aaa5b1", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "a352ba7b-165d-4b4a-a445-968c5992d4f1", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "a352ba7b-165d-4b4a-a445-968c5992d4f1", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "1c339882-adbb-4b42-8eb3-ce6d93a03d27", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "1c339882-adbb-4b42-8eb3-ce6d93a03d27", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "23b5ba95-6fe6-4a50-966b-81c2abb81472", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "23b5ba95-6fe6-4a50-966b-81c2abb81472", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "1b6f4d5b-2e8c-4dec-b63f-0933e49d1bfa", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "1b6f4d5b-2e8c-4dec-b63f-0933e49d1bfa", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "0f5ef346-64e7-42e1-8008-dc3c3bb24b51", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "0f5ef346-64e7-42e1-8008-dc3c3bb24b51", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "cb78cbbf-276b-491f-9e2a-ffb7bd5e7875", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "cb78cbbf-276b-491f-9e2a-ffb7bd5e7875", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "5838c814-0d11-4e41-bee3-80d9522076eb", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "5838c814-0d11-4e41-bee3-80d9522076eb", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "d7377d02-7445-4ecb-8841-ed57d5f2dd33", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Parallel),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Parallel),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,2,2,2,2,2,4,4,5,5,5,6,6,6,7,7,8,9,10,10,27,27,28,29,29,29,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 11,11,12,13,13,13,14,15,15,16,16,16,16,10,};
        public static int[] __progressLocation3 = new int[] { 19,19,20,21,21,21,22,23,23,24,24,24,24,10,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __SZDHUB_Orchestration_root_0 __ctx0__ = (__SZDHUB_Orchestration_root_0)_stateMgrs[0];
            __SZDHUB_Orchestration_1 __ctx1__ = (__SZDHUB_Orchestration_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                ReceiveReceiptMessage = new PortType_ReceiveReceiptMessage(0, this);
                SendPip4B2Message = new PortType_SendPip4B2Message(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], ReceiveReceiptMessage, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __SZDHUB_Orchestration_1(this);
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
            __SZDHUB_Orchestration_root_0 __ctx0__ = (__SZDHUB_Orchestration_root_0)_stateMgrs[0];
            __SZDHUB_Orchestration_1 __ctx1__ = (__SZDHUB_Orchestration_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__SubmitRNIF1 = default(Microsoft.Solutions.BTARN.Shared.SubmitRNIF);
                __ctx1__.__strPipMessageForSTX = default(System.String);
                __ctx1__.__strPipMessageFore2open = default(System.String);
                __ctx1__.__pipInstanceMessageIdFore2open = default(System.String);
                __ctx1__.__pipInstanceIdentifierForSTX = default(System.String);
                __ctx1__.__pipInstanceIdentifierFore2open = default(System.String);
                __ctx1__.__SubmitRNIF = default(Microsoft.Solutions.BTARN.Shared.SubmitRNIF);
                __ctx1__.__Increase = default(System.Int32);
                __ctx1__.__CountStr = default(System.String);
                __ctx1__.__Count = default(System.Int32);
                __ctx1__.__pipInstanceMessageIdForSTX = default(System.String);
                __ctx1__.__SCHEDULELocation = default(System.String);
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
                if (!ReceiveReceiptMessage.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__AdvancedShipNoticeMessage != null)
                    __ctx1__.UnrefMessage(__ctx1__.__AdvancedShipNoticeMessage);
                __ctx1__.__AdvancedShipNoticeMessage = new __messagetype_Kaifa_B2B_Schemas_Wms_AdvancedShipNotice("AdvancedShipNoticeMessage", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__AdvancedShipNoticeMessage);
                ReceiveReceiptMessage.ReceiveMessage(0, __msgEnv__, __ctx1__.__AdvancedShipNoticeMessage, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (ReceiveReceiptMessage != null)
                {
                    ReceiveReceiptMessage.Close(__ctx1__, __seg__);
                    ReceiveReceiptMessage = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__AdvancedShipNoticeMessage);
                    __edata.PortName = @"ReceiveReceiptMessage";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__SubmitRNIF1 = new Microsoft.Solutions.BTARN.Shared.SubmitRNIF();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__strPipMessageForSTX = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__strPipMessageFore2open = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__pipInstanceMessageIdFore2open = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__pipInstanceIdentifierForSTX = "";
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__pipInstanceIdentifierFore2open = "";
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__SubmitRNIF = new Microsoft.Solutions.BTARN.Shared.SubmitRNIF();
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__CountStr = "";
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __ctx1__.__pipInstanceMessageIdForSTX = "";
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.__SCHEDULELocation = "";
                if (__ctx1__ != null)
                    __ctx1__.__SCHEDULELocation = null;
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                __ctx1__.__Count = (System.Int32)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__AdvancedShipNoticeMessage.part, "count(/*[local-name()='AdvancedShipNotice' and namespace-uri()='http://kaifa.b2b.schemas/AdvancedShipNotice']/*[local-name()='VendorReceiptReport' and namespace-uri()='http://kaifa.b2b.schemas/AdvancedShipNotice'])", typeof(System.Int32));
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                __ctx1__.__CountStr = __ctx1__.__Count.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                __ctx1__.__Increase = 1;
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                __condition__ = __ctx1__.__Increase <= __ctx1__.__Count;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 34 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 34;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                {
                    __messagetype_Kaifa_B2B_Schemas_Wms_VendorReceiptReport __VendorReciptReportMessage = new __messagetype_Kaifa_B2B_Schemas_Wms_VendorReceiptReport("VendorReciptReportMessage", __ctx1__);

                    __ctx1__.__CountStr = __ctx1__.__Increase.ToString();
                    __VendorReciptReportMessage.part.XPathAssign(__ctx1__.__AdvancedShipNoticeMessage.part, "/*[local-name()='AdvancedShipNotice' and namespace-uri()='http://kaifa.b2b.schemas/AdvancedShipNotice']/*[local-name()='VendorReceiptReport' and namespace-uri()='http://kaifa.b2b.schemas/AdvancedShipNotice'][" + __ctx1__.__CountStr + "]");

                    if (__ctx1__.__VendorReciptReportMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__VendorReciptReportMessage);
                    __ctx1__.__VendorReciptReportMessage = __VendorReciptReportMessage;
                    __ctx1__.RefMessage(__ctx1__.__VendorReciptReportMessage);
                }
                __ctx1__.__VendorReciptReportMessage.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__VendorReciptReportMessage);
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                __seg__.RunSegments(new Microsoft.XLANGs.Core.Segment[] {_segments[2], _segments[3]}, this);
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__VendorReciptReportMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__VendorReciptReportMessage);
                    __ctx1__.__VendorReciptReportMessage = null;
                }
                Tracker.FireEvent(__eventLocations[10],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[27],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                __ctx1__.__Increase = __ctx1__.__Increase + 1;
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[28],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[29],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 33;
            case 33:
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceMessageIdForSTX = null;
                if (__ctx1__ != null)
                    __ctx1__.__CountStr = null;
                if (__ctx1__ != null)
                    __ctx1__.__SubmitRNIF = null;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceIdentifierFore2open = null;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceIdentifierForSTX = null;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceMessageIdFore2open = null;
                if (__ctx1__ != null)
                    __ctx1__.__strPipMessageFore2open = null;
                if (__ctx1__ != null)
                    __ctx1__.__strPipMessageForSTX = null;
                if (__ctx1__ != null)
                    __ctx1__.__SubmitRNIF1 = null;
                if (__ctx1__ != null && __ctx1__.__AdvancedShipNoticeMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__AdvancedShipNoticeMessage);
                    __ctx1__.__AdvancedShipNoticeMessage = null;
                }
                if (SendPip4B2Message != null)
                {
                    SendPip4B2Message.Close(__ctx1__, __seg__);
                    SendPip4B2Message = null;
                }
                Tracker.FireEvent(__eventLocations[29],__eventData[11],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[12],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 36;
            case 36:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 37;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 38;
            case 38:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __SZDHUB_Orchestration_root_0 __ctx0__ = (__SZDHUB_Orchestration_root_0)_stateMgrs[0];
            __SZDHUB_Orchestration_1 __ctx1__ = (__SZDHUB_Orchestration_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                if ( !PreProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 1;
            case 1:
                {
                    __messagetype_Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification __Pip4B2MessageForSTX = new __messagetype_Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification("Pip4B2MessageForSTX", __ctx1__);

                    ApplyTransform(typeof(Kaifa.B2B.SZD.Mapping.ASN_To_4B2_STX), new object[] {__Pip4B2MessageForSTX.part}, new object[] {__ctx1__.__VendorReciptReportMessage.part});
                    __ctx1__.__pipInstanceIdentifierForSTX = (System.String)__Pip4B2MessageForSTX.part.GetDistinguishedField("thisDocumentIdentifier.ProprietaryDocumentIdentifier");
                    __Pip4B2MessageForSTX.SetPropertyValue(typeof(FILE.ReceivedFileName), "HUB_To_STX＿" + __ctx1__.__pipInstanceIdentifierForSTX + ".xml");

                    if (__ctx1__.__Pip4B2MessageForSTX != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Pip4B2MessageForSTX);
                    __ctx1__.__Pip4B2MessageForSTX = __Pip4B2MessageForSTX;
                    __ctx1__.RefMessage(__ctx1__.__Pip4B2MessageForSTX);
                }
                __ctx1__.__Pip4B2MessageForSTX.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Pip4B2MessageForSTX);
                    __edata.Messages.Add(__ctx1__.__VendorReciptReportMessage);
                    Tracker.FireEvent(__eventLocations[12],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendPip4B2Message.SendMessage(0, __ctx1__.__Pip4B2MessageForSTX, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Pip4B2MessageForSTX);
                    __edata.PortName = @"SendPip4B2Message";
                    Tracker.FireEvent(__eventLocations[14],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                __ctx1__.__pipInstanceMessageIdForSTX = (System.String)__ctx1__.__Pip4B2MessageForSTX.GetPropertyValueThrows(typeof(BTS.MessageID));
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __ctx1__.__strPipMessageForSTX = Kaifa.B2B.Utility.HeaderHelper.ReturnSCWithDocType(__ctx1__.__Pip4B2MessageForSTX.part.TypedValue, "4B2SG0100");
                if (__ctx1__ != null && __ctx1__.__Pip4B2MessageForSTX != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Pip4B2MessageForSTX);
                    __ctx1__.__Pip4B2MessageForSTX = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                System.Diagnostics.Trace.WriteLine("SubmitRNIF.SubmitMessage To STX " + __ctx1__.__pipInstanceMessageIdForSTX + " - " + __ctx1__.__pipInstanceIdentifierForSTX, "kaifa.b2b");
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__SubmitRNIF.SubmitMessage(Microsoft.Solutions.BTARN.Shared.MessageCategory.AsyncAction, "KAIFA", "SEAGATE-US", "4B2", __ctx1__.__pipInstanceIdentifierForSTX, "1.0", __ctx1__.__strPipMessageForSTX);
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __SZDHUB_Orchestration_root_0 __ctx0__ = (__SZDHUB_Orchestration_root_0)_stateMgrs[0];
            __SZDHUB_Orchestration_1 __ctx1__ = (__SZDHUB_Orchestration_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                if ( !PreProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 1;
            case 1:
                {
                    __messagetype_Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification __Pip4B2MessageForE2Open = new __messagetype_Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification("Pip4B2MessageForE2Open", __ctx1__);

                    ApplyTransform(typeof(Kaifa.B2B.SZD.Mapping.ASN_To_4B2_e2open), new object[] {__Pip4B2MessageForE2Open.part}, new object[] {__ctx1__.__VendorReciptReportMessage.part});
                    __ctx1__.__pipInstanceIdentifierFore2open = (System.String)__Pip4B2MessageForE2Open.part.GetDistinguishedField("thisDocumentIdentifier.ProprietaryDocumentIdentifier");
                    __Pip4B2MessageForE2Open.SetPropertyValue(typeof(FILE.ReceivedFileName), "HUB_To_e2open＿" + __ctx1__.__pipInstanceIdentifierFore2open + ".xml");

                    if (__ctx1__.__Pip4B2MessageForE2Open != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Pip4B2MessageForE2Open);
                    __ctx1__.__Pip4B2MessageForE2Open = __Pip4B2MessageForE2Open;
                    __ctx1__.RefMessage(__ctx1__.__Pip4B2MessageForE2Open);
                }
                __ctx1__.__Pip4B2MessageForE2Open.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Pip4B2MessageForE2Open);
                    __edata.Messages.Add(__ctx1__.__VendorReciptReportMessage);
                    Tracker.FireEvent(__eventLocations[20],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendPip4B2Message.SendMessage(0, __ctx1__.__Pip4B2MessageForE2Open, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Pip4B2MessageForE2Open);
                    __edata.PortName = @"SendPip4B2Message";
                    Tracker.FireEvent(__eventLocations[22],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[23],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                __ctx1__.__pipInstanceMessageIdFore2open = (System.String)__ctx1__.__Pip4B2MessageForE2Open.GetPropertyValueThrows(typeof(BTS.MessageID));
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __ctx1__.__strPipMessageFore2open = Kaifa.B2B.Utility.HeaderHelper.ReturnSCWithDocType(__ctx1__.__Pip4B2MessageForE2Open.part.TypedValue, "4B2SG0100");
                if (__ctx1__ != null && __ctx1__.__Pip4B2MessageForE2Open != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Pip4B2MessageForE2Open);
                    __ctx1__.__Pip4B2MessageForE2Open = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                System.Diagnostics.Trace.WriteLine("SubmitRNIF.SubmitMessage To e2open " + __ctx1__.__pipInstanceMessageIdFore2open + " - " + __ctx1__.__pipInstanceIdentifierFore2open, "kaifa.b2b");
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__SubmitRNIF1.SubmitMessage(Microsoft.Solutions.BTARN.Shared.MessageCategory.AsyncAction, "KAIFA", "E2OPEN", "4B2", __ctx1__.__pipInstanceIdentifierFore2open, "1.0", __ctx1__.__strPipMessageFore2open);
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __Kaifa_B2B_Schemas_Wms_AdvancedShipNotice__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.Schemas.Wms.AdvancedShipNotice _schema = new Kaifa.B2B.Schemas.Wms.AdvancedShipNotice();

        public __Kaifa_B2B_Schemas_Wms_AdvancedShipNotice__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Kaifa.B2B.Schemas.Wms.AdvancedShipNotice",
        new System.Type[]{
            typeof(Kaifa.B2B.Schemas.Wms.AdvancedShipNotice)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_Schemas_Wms_AdvancedShipNotice__)
        },
        0,
        @"http://kaifa.b2b.schemas/AdvancedShipNotice#AdvancedShipNotice"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Kaifa_B2B_Schemas_Wms_AdvancedShipNotice : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_Schemas_Wms_AdvancedShipNotice__ part;

        private void __CreatePartWrappers()
        {
            part = new __Kaifa_B2B_Schemas_Wms_AdvancedShipNotice__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Kaifa_B2B_Schemas_Wms_AdvancedShipNotice(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification _schema = new Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification();

        public __Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification",
        new System.Type[]{
            typeof(Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification__)
        },
        0,
        @"http://kaifa.b2b.schemas/SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification#Pip4B2ShipmentReceiptNotification"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification__ part;

        private void __CreatePartWrappers()
        {
            part = new __Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4B2_MS_1_0_ShipmentReceiptNotification(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Kaifa_B2B_Schemas_Wms_VendorReceiptReport__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.Schemas.Wms.VendorReceiptReport _schema = new Kaifa.B2B.Schemas.Wms.VendorReceiptReport();

        public __Kaifa_B2B_Schemas_Wms_VendorReceiptReport__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Kaifa.B2B.Schemas.Wms.VendorReceiptReport",
        new System.Type[]{
            typeof(Kaifa.B2B.Schemas.Wms.VendorReceiptReport)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_Schemas_Wms_VendorReceiptReport__)
        },
        0,
        @"http://kaifa.b2b.schemas/AdvancedShipNotice#VendorReceiptReport"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Kaifa_B2B_Schemas_Wms_VendorReceiptReport : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_Schemas_Wms_VendorReceiptReport__ part;

        private void __CreatePartWrappers()
        {
            part = new __Kaifa_B2B_Schemas_Wms_VendorReceiptReport__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Kaifa_B2B_Schemas_Wms_VendorReceiptReport(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
