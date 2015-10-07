
#pragma warning disable 162

namespace Kaifa.B2B.Orchestration.SOI
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Kaifa.B2B.Orchestration.SOI.__messagetype_Kaifa_B2B_Schemas_Wms_InventoryReport)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_ReceiveInventoryMessage : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_ReceiveInventoryMessage(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_ReceiveInventoryMessage(PortType_ReceiveInventoryMessage p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_ReceiveInventoryMessage p = new PortType_ReceiveInventoryMessage(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_ReceiveInventoryMessage),
            typeof(__messagetype_Kaifa_B2B_Schemas_Wms_InventoryReport),
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
            typeof(Kaifa.B2B.Orchestration.SOI.__messagetype_Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4C1_MS_1_0_SupplierOwnInventory)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_SendPip4C1Message : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_SendPip4C1Message(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_SendPip4C1Message(PortType_SendPip4C1Message p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_SendPip4C1Message p = new PortType_SendPip4C1Message(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_SendPip4C1Message),
            typeof(__messagetype_Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4C1_MS_1_0_SupplierOwnInventory),
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
    //#line 398 "D:\长城开发项目\SourceCode\Kaifa.B2B.Solution\Kaifa.B2B.Orchestration.SOI\SOI.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "ReceiveInventoryMessage", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Kaifa.B2B.Orchestration.SOI.PortType_ReceiveInventoryMessage),
            typeof(Kaifa.B2B.Orchestration.SOI.PortType_SendPip4C1Message)
        },
        new System.String[] {
            "ReceiveInventoryMessage",
            "SendPip4C1Message"
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
    sealed internal class SOI_Orchestration : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(SOI_Orchestration));
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

        static SOI_Orchestration()
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
            _rootContext = new __SOI_Orchestration_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public SOI_Orchestration(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "SOI_Orchestration", tracker)
        {
            ConstructorHelper();
        }

        public SOI_Orchestration(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "SOI_Orchestration")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>b54a3d44-ffb1-4f3c-9a5e-73d0569703fa</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>ae849826-f625-4fd0-9b28-ea8fed3d7017</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_InventoryReportMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>0621ed13-18f1-4a3c-8d63-d5d79c4481c8</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>GetCount</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>WhileShape</shapeType>      <ShapeID>58c173ad-0872-4da3-af51-cab3da9924e6</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Loop_CreateVendorReport</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>cca7a5ec-fc3e-4d81-a0de-1643380405a3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>4aabf50e-face-4246-a567-a74004ed2019</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>e3fbbe5e-209e-4909-b6a5-cb4ad49f9649</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParallelShape</shapeType>      <ShapeID>2f9cf345-854d-416c-9f50-b4b0f250d6e8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ParallelActions_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>51ea39a0-856c-45fe-8d5d-2880490a97eb</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>a939cdd4-aa3b-498a-994b-2415d028980a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_to_STX</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>cdcccf0b-5bee-4754-b7c7-48906159b76e</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>bf6fb5b5-8431-4d54-b4cb-b86b65614dc7</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_Rosettanet4C1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>6f44d294-a77c-4e1f-b4bf-2e85dd95e33d</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>62df183a-ddd2-43f5-8ee4-55ed5648be68</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>12af543c-6a87-4b49-874a-5e3347cc4975</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>7dcfda03-6db8-4411-adc7-ecc4f9cf922c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_STX_PIP4C1Message</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>44938471-b0f1-4df7-a5ca-0e7a47e603ae</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>InvokeSubmitRNIFAPI</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>eb4e8a5f-c41f-4faa-8c65-fd806369a759</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>8ebbc165-d282-4301-be59-214cc4388c8f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_to_e2open</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>81cdef7b-5b90-47d5-a6f5-ce636c68a311</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_Rosettanet4C1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>d094a0e4-0dd1-4152-b968-e635e3b41d1a</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>4a878901-3bcd-4551-85ce-07560a8ba60b</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>3f1dfb81-d396-4ad6-92af-e3c7b4ed57b9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>ea962acc-5fd5-499b-800c-007bc6a9f94e</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>472fe5fe-6179-476d-b2d7-69f077deb8d1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_e2open_PIP4C1Message</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>fc4b62e9-acab-4484-be0b-0ac9c08cf89f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>InvokeSubmitRNIFAPI</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>8bc4b0ba-742c-42f1-9e34-855baddc3e65</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Increasing</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'SOI_Orchestration'</ActionName><IsAtomic>0</IsAtomic><Line>398</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>423</Line><Position>22</Position><ShapeID>'ae849826-f625-4fd0-9b28-ea8fed3d7017'</ShapeID>
<Messages>
	<MsgInfo><name>InventoryReportMessage</name><part>part</part><schema>Kaifa.B2B.Schemas.Wms.InventoryReport</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>434</Line><Position>19</Position><ShapeID>'0621ed13-18f1-4a3c-8d63-d5d79c4481c8'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>438</Line><Position>13</Position><ShapeID>'58c173ad-0872-4da3-af51-cab3da9924e6'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>441</Line><Position>17</Position><ShapeID>'cca7a5ec-fc3e-4d81-a0de-1643380405a3'</ShapeID>
<Messages>
	<MsgInfo><name>VendorReportMessage</name><part>part</part><schema>Kaifa.B2B.Schemas.Wms.VendorInventoryReport</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>449</Line><Position>17</Position><ShapeID>'2f9cf345-854d-416c-9f50-b4b0f250d6e8'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>454</Line><Position>25</Position><ShapeID>'a939cdd4-aa3b-498a-994b-2415d028980a'</ShapeID>
<Messages>
	<MsgInfo><name>Pip4C1ForSTXMessage</name><part>part</part><schema>Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4C1_MS_1_0_SupplierOwnInventory</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>VendorReportMessage</name><part>part</part><schema>Kaifa.B2B.Schemas.Wms.VendorInventoryReport</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>464</Line><Position>25</Position><ShapeID>'7dcfda03-6db8-4411-adc7-ecc4f9cf922c'</ShapeID>
<Messages>
	<MsgInfo><name>Pip4C1ForSTXMessage</name><part>part</part><schema>Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4C1_MS_1_0_SupplierOwnInventory</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>466</Line><Position>52</Position><ShapeID>'44938471-b0f1-4df7-a5ca-0e7a47e603ae'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>484</Line><Position>25</Position><ShapeID>'8ebbc165-d282-4301-be59-214cc4388c8f'</ShapeID>
<Messages>
	<MsgInfo><name>Pip4C1ForE2OpenMessage</name><part>part</part><schema>Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4C1_MS_1_0_SupplierOwnInventory</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>VendorReportMessage</name><part>part</part><schema>Kaifa.B2B.Schemas.Wms.VendorInventoryReport</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>494</Line><Position>25</Position><ShapeID>'472fe5fe-6179-476d-b2d7-69f077deb8d1'</ShapeID>
<Messages>
	<MsgInfo><name>Pip4C1ForE2OpenMessage</name><part>part</part><schema>Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4C1_MS_1_0_SupplierOwnInventory</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>496</Line><Position>55</Position><ShapeID>'fc4b62e9-acab-4484-be0b-0ac9c08cf89f'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>514</Line><Position>26</Position><ShapeID>'8bc4b0ba-742c-42f1-9e34-855baddc3e65'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='5b997ce5-53f9-47e2-b2f9-498257574989' LowerBound='1.1' HigherBound='140.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Kaifa.B2B.Orchestration.SOI' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='48b2fa93-9b03-4391-8812-1c80802b2a6c' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_ReceiveInventoryMessage' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='d2fb511f-2ef7-43f7-9c62-113456a56cd9' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='a36fd9d9-5583-480e-b719-d6c5cb3ad9d7' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.50'>
                    <om:Property Name='Ref' Value='Kaifa.B2B.Schemas.Wms.InventoryReport' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='44a143ab-bf67-42a8-b758-6308a3b628d8' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_SendPip4C1Message' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='dfbc4d52-3297-4082-b3df-cb811f39cb63' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='4cc4d784-e4f2-40d8-a74b-766fed058158' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.80'>
                    <om:Property Name='Ref' Value='Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4C1_MS_1_0_SupplierOwnInventory' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='22498fac-4db4-4714-8d0c-aaa440051fde' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='139.1'>
            <om:Property Name='InitializedTransactionType' Value='True' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SOI_Orchestration' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='2e98ebdb-bb96-4797-a5b7-240e7e822eaa' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='Microsoft.Solutions.BTARN.Shared.SubmitRNIF' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SubmitRNIF1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='10743e72-ece6-4e43-8d2e-c2692b11d534' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='31.1' HigherBound='32.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strPipMessageFore2open' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='af981903-7c1a-4f5a-a1ba-76dba079574a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='32.1' HigherBound='33.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='pipInstanceMessageIdFore2open' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='5f30bae3-6589-4e57-9487-8f9815c0c24c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='33.1' HigherBound='34.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='pipInstanceMessageIdForSTX' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='85a6ae57-a766-41df-a365-f012f9564939' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='pipInstanceIdentifierFore2open' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='d2a8cf87-c742-4333-91ae-123c9816c73a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='35.1' HigherBound='36.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='Microsoft.Solutions.BTARN.Shared.SubmitRNIF' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SubmitRNIF' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='630b935d-e22b-43e0-b313-fb721b887b30' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='36.1' HigherBound='37.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Increase' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8097f31a-f1c9-436f-a5b2-acb5cb171933' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='37.1' HigherBound='38.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CountStr' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ea249aa5-3af1-4f97-a92c-f09198e8b6ff' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='38.1' HigherBound='39.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Count' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='20547acc-a330-4d7d-b84c-b51c49555a37' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='39.1' HigherBound='40.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='pipInstanceIdentifierForSTX' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='dbe4db64-39a4-4773-b16f-0940956a5701' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='40.1' HigherBound='41.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strPipMessageForSTX' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='LongRunningTransaction' OID='e7fcebc3-eaf9-488d-b2c8-2f4bd5334f49' ParentLink='ServiceDeclaration_Transaction' LowerBound='19.21' HigherBound='19.63'>
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Transaction_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ab8f7ce3-6fe3-4db3-aaf3-a26a97f54e77' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas.Wms.VendorInventoryReport' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='VendorReportMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='0cdb5f05-5455-4f2a-a4c4-91cb558e3c42' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RawMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='8b7f33a2-daa5-4be5-981c-088f7b98d0e3' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4C1_MS_1_0_SupplierOwnInventory' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Pip4C1ForSTXMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='3dad5051-b7ec-4673-b8f9-10242c3c7b4d' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4C1_MS_1_0_SupplierOwnInventory' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Pip4C1ForE2OpenMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='914455f3-d5c3-44a2-a1e5-7f195a4dc992' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas.Wms.InventoryReport' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='InventoryReportMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='b54a3d44-ffb1-4f3c-9a5e-73d0569703fa' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='ae849826-f625-4fd0-9b28-ea8fed3d7017' ParentLink='ServiceBody_Statement' LowerBound='43.1' HigherBound='54.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='ReceiveInventoryMessage' />
                    <om:Property Name='MessageName' Value='InventoryReportMessage' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_InventoryReportMessage' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='0621ed13-18f1-4a3c-8d63-d5d79c4481c8' ParentLink='ServiceBody_Statement' LowerBound='54.1' HigherBound='58.1'>
                    <om:Property Name='Expression' Value='Count = xpath(InventoryReportMessage, &quot;count(/*[local-name()=&apos;InventoryReport&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/InventoryReport&apos;]/*[local-name()=&apos;VendorInventoryReport&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/InventoryReport&apos;])&quot;); &#xD;&#xA;CountStr = Count.ToString();&#xD;&#xA;Increase = 1;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='GetCount' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='While' OID='58c173ad-0872-4da3-af51-cab3da9924e6' ParentLink='ServiceBody_Statement' LowerBound='58.1' HigherBound='137.1'>
                    <om:Property Name='Expression' Value='Increase&lt;=Count' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Loop_CreateVendorReport' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='Construct' OID='cca7a5ec-fc3e-4d81-a0de-1643380405a3' ParentLink='ComplexStatement_Statement' LowerBound='61.1' HigherBound='69.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructMessage_2' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageRef' OID='4aabf50e-face-4246-a567-a74004ed2019' ParentLink='Construct_MessageRef' LowerBound='62.27' HigherBound='62.46'>
                            <om:Property Name='Ref' Value='VendorReportMessage' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageAssignment' OID='e3fbbe5e-209e-4909-b6a5-cb4ad49f9649' ParentLink='ComplexStatement_Statement' LowerBound='64.1' HigherBound='68.1'>
                            <om:Property Name='Expression' Value='CountStr = Increase.ToString();&#xD;&#xA;&#xD;&#xA;VendorReportMessage =  xpath(InventoryReportMessage, &quot;/*[local-name()=&apos;InventoryReport&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/InventoryReport&apos;]/*[local-name()=&apos;VendorInventoryReport&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/InventoryReport&apos;][&quot; + CountStr + &quot;]&quot;);' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='MessageAssignment_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Parallel' OID='2f9cf345-854d-416c-9f50-b4b0f250d6e8' ParentLink='ComplexStatement_Statement' LowerBound='69.1' HigherBound='134.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ParallelActions_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='ParallelBranch' OID='51ea39a0-856c-45fe-8d5d-2880490a97eb' ParentLink='ReallyComplexStatement_Branch' LowerBound='74.1' HigherBound='101.1'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ParallelBranch_1' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Construct' OID='a939cdd4-aa3b-498a-994b-2415d028980a' ParentLink='ComplexStatement_Statement' LowerBound='74.1' HigherBound='84.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ConstructMessage_to_STX' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageRef' OID='cdcccf0b-5bee-4754-b7c7-48906159b76e' ParentLink='Construct_MessageRef' LowerBound='75.35' HigherBound='75.54'>
                                    <om:Property Name='Ref' Value='Pip4C1ForSTXMessage' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Transform' OID='bf6fb5b5-8431-4d54-b4cb-b86b65614dc7' ParentLink='ComplexStatement_Statement' LowerBound='77.1' HigherBound='79.1'>
                                    <om:Property Name='ClassName' Value='Kaifa.B2B.Mapping.Inventory_To_4C1_STX' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Transform_Rosettanet4C1' />
                                    <om:Property Name='Signal' Value='False' />
                                    <om:Element Type='MessagePartRef' OID='6f44d294-a77c-4e1f-b4bf-2e85dd95e33d' ParentLink='Transform_OutputMessagePartRef' LowerBound='78.40' HigherBound='78.59'>
                                        <om:Property Name='MessageRef' Value='Pip4C1ForSTXMessage' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_2' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessagePartRef' OID='62df183a-ddd2-43f5-8ee4-55ed5648be68' ParentLink='Transform_InputMessagePartRef' LowerBound='78.103' HigherBound='78.122'>
                                        <om:Property Name='MessageRef' Value='VendorReportMessage' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_1' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='MessageAssignment' OID='12af543c-6a87-4b49-874a-5e3347cc4975' ParentLink='ComplexStatement_Statement' LowerBound='79.1' HigherBound='83.1'>
                                    <om:Property Name='Expression' Value='pipInstanceIdentifierForSTX =  Pip4C1ForSTXMessage.thisDocumentIdentifier.ProprietaryDocumentIdentifier;&#xD;&#xA;Pip4C1ForSTXMessage(FILE.ReceivedFileName) = &quot;SOI_To_STX＿&quot;  + pipInstanceIdentifierForSTX + &quot;.xml&quot;;&#xD;&#xA;//pipInstanceMessageIdForSTX = Pip4C1ForSTXMessage(BTS.MessageID);' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='MessageAssignment_3' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Send' OID='7dcfda03-6db8-4411-adc7-ecc4f9cf922c' ParentLink='ComplexStatement_Statement' LowerBound='84.1' HigherBound='86.1'>
                                <om:Property Name='PortName' Value='SendPip4C1Message' />
                                <om:Property Name='MessageName' Value='Pip4C1ForSTXMessage' />
                                <om:Property Name='OperationName' Value='Operation_1' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send_STX_PIP4C1Message' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='44938471-b0f1-4df7-a5ca-0e7a47e603ae' ParentLink='ComplexStatement_Statement' LowerBound='86.1' HigherBound='101.1'>
                                <om:Property Name='Expression' Value='pipInstanceMessageIdForSTX = Pip4C1ForSTXMessage(BTS.MessageID);&#xD;&#xA;strPipMessageForSTX  =  Kaifa.B2B.Utility.HeaderHelper.ReturnSCWithDocType(Pip4C1ForSTXMessage,&quot;4C1V0200&quot;);&#xD;&#xA;&#xD;&#xA;System.Diagnostics.Trace.WriteLine(&quot;SubmitRNIF.SubmitMessage To STX &quot; + pipInstanceMessageIdForSTX + &quot; - &quot; + pipInstanceIdentifierForSTX,&quot;kaifa.b2b&quot;);&#xD;&#xA; SubmitRNIF.SubmitMessage(Microsoft.Solutions.BTARN.Shared.MessageCategory.AsyncAction,&#xD;&#xA; &quot;KAIFA&quot;,&#xD;&#xA; &quot;SEAGATE-US&quot;,&#xD;&#xA; &quot;4C1&quot;,&#xD;&#xA; pipInstanceMessageIdForSTX,&#xD;&#xA; &quot;R02.00&quot;,&#xD;&#xA; strPipMessageForSTX&#xD;&#xA;);&#xD;&#xA;&#xD;&#xA; ' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='InvokeSubmitRNIFAPI' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='ParallelBranch' OID='eb4e8a5f-c41f-4faa-8c65-fd806369a759' ParentLink='ReallyComplexStatement_Branch' LowerBound='104.1' HigherBound='132.1'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ParallelBranch_2' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Construct' OID='8ebbc165-d282-4301-be59-214cc4388c8f' ParentLink='ComplexStatement_Statement' LowerBound='104.1' HigherBound='114.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ConstructMessage_to_e2open' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Transform' OID='81cdef7b-5b90-47d5-a6f5-ce636c68a311' ParentLink='ComplexStatement_Statement' LowerBound='107.1' HigherBound='109.1'>
                                    <om:Property Name='ClassName' Value='Kaifa.B2B.Mapping.Inventory_To_4C1_e2open' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Transform_Rosettanet4C1' />
                                    <om:Property Name='Signal' Value='False' />
                                    <om:Element Type='MessagePartRef' OID='d094a0e4-0dd1-4152-b968-e635e3b41d1a' ParentLink='Transform_OutputMessagePartRef' LowerBound='108.40' HigherBound='108.62'>
                                        <om:Property Name='MessageRef' Value='Pip4C1ForE2OpenMessage' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_4' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessagePartRef' OID='4a878901-3bcd-4551-85ce-07560a8ba60b' ParentLink='Transform_InputMessagePartRef' LowerBound='108.109' HigherBound='108.128'>
                                        <om:Property Name='MessageRef' Value='VendorReportMessage' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_3' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='MessageAssignment' OID='3f1dfb81-d396-4ad6-92af-e3c7b4ed57b9' ParentLink='ComplexStatement_Statement' LowerBound='109.1' HigherBound='113.1'>
                                    <om:Property Name='Expression' Value='pipInstanceIdentifierFore2open =Pip4C1ForE2OpenMessage.thisDocumentIdentifier.ProprietaryDocumentIdentifier ;&#xD;&#xA;Pip4C1ForE2OpenMessage(FILE.ReceivedFileName) = &quot;SOI_To_e2open＿&quot; + pipInstanceIdentifierFore2open + &quot;.xml&quot; ;&#xD;&#xA;//pipInstanceMessageIdFore2open = Pip4C1ForE2OpenMessage(BTS.MessageID);&#xD;&#xA;' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='MessageAssignment_2' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='ea962acc-5fd5-499b-800c-007bc6a9f94e' ParentLink='Construct_MessageRef' LowerBound='105.35' HigherBound='105.57'>
                                    <om:Property Name='Ref' Value='Pip4C1ForE2OpenMessage' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Send' OID='472fe5fe-6179-476d-b2d7-69f077deb8d1' ParentLink='ComplexStatement_Statement' LowerBound='114.1' HigherBound='116.1'>
                                <om:Property Name='PortName' Value='SendPip4C1Message' />
                                <om:Property Name='MessageName' Value='Pip4C1ForE2OpenMessage' />
                                <om:Property Name='OperationName' Value='Operation_1' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send_e2open_PIP4C1Message' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='fc4b62e9-acab-4484-be0b-0ac9c08cf89f' ParentLink='ComplexStatement_Statement' LowerBound='116.1' HigherBound='132.1'>
                                <om:Property Name='Expression' Value='pipInstanceMessageIdFore2open = Pip4C1ForE2OpenMessage(BTS.MessageID);&#xD;&#xA;&#xD;&#xA;strPipMessageFore2open  =  Kaifa.B2B.Utility.HeaderHelper.ReturnSCWithDocType(Pip4C1ForE2OpenMessage,&quot;4C1V0200&quot;);&#xD;&#xA;&#xD;&#xA;System.Diagnostics.Trace.WriteLine(&quot;SubmitRNIF.SubmitMessage To e2open &quot; + pipInstanceMessageIdFore2open + &quot; - &quot; + pipInstanceIdentifierFore2open,&quot;kaifa.b2b&quot;);&#xD;&#xA; SubmitRNIF1.SubmitMessage(Microsoft.Solutions.BTARN.Shared.MessageCategory.AsyncAction,&#xD;&#xA; &quot;KAIFA&quot;,&#xD;&#xA; &quot;E2OPEN&quot;,&#xD;&#xA; &quot;4C1&quot;,&#xD;&#xA; pipInstanceMessageIdFore2open,&#xD;&#xA; &quot;R02.00&quot;,&#xD;&#xA; strPipMessageFore2open&#xD;&#xA;);&#xD;&#xA;&#xD;&#xA; ' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='InvokeSubmitRNIFAPI' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='8bc4b0ba-742c-42f1-9e34-855baddc3e65' ParentLink='ComplexStatement_Statement' LowerBound='134.1' HigherBound='136.1'>
                        <om:Property Name='Expression' Value='Increase = Increase + 1;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Increasing' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='bea0a0f5-6787-40d3-b427-2e9f70b15336' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Kaifa.B2B.Orchestration.SOI.PortType_ReceiveInventoryMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceiveInventoryMessage' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='7105e064-d586-40d1-bf58-628d6e5dbd47' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='6c5da904-6653-44ec-bbf1-85bb2412ad54' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Kaifa.B2B.Orchestration.SOI.PortType_SendPip4C1Message' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendPip4C1Message' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='4e678f6f-cb36-4012-b19b-47f3eb4509c2' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __SOI_Orchestration_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __SOI_Orchestration_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "SOI_Orchestration")
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
                SOI_Orchestration __svc__ = (SOI_Orchestration)_service;
                __SOI_Orchestration_root_0 __ctx0__ = (__SOI_Orchestration_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.ReceiveInventoryMessage != null)
                {
                    __svc__.ReceiveInventoryMessage.Close(this, null);
                    __svc__.ReceiveInventoryMessage = null;
                }
                if (__svc__.SendPip4C1Message != null)
                {
                    __svc__.SendPip4C1Message.Close(this, null);
                    __svc__.SendPip4C1Message = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __SOI_Orchestration_1 : Microsoft.XLANGs.Core.LongRunningTransaction
        {
            public __SOI_Orchestration_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "SOI_Orchestration")
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
                SOI_Orchestration __svc__ = (SOI_Orchestration)_service;
                __SOI_Orchestration_1 __ctx1__ = (__SOI_Orchestration_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__SubmitRNIF1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceMessageIdFore2open = null;
                if (__ctx1__ != null && __ctx1__.__Pip4C1ForSTXMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Pip4C1ForSTXMessage);
                    __ctx1__.__Pip4C1ForSTXMessage = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceIdentifierFore2open = null;
                if (__ctx1__ != null)
                    __ctx1__.__strPipMessageFore2open = null;
                if (__ctx1__ != null)
                    __ctx1__.__SubmitRNIF = null;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceIdentifierForSTX = null;
                if (__ctx1__ != null)
                    __ctx1__.__CountStr = null;
                if (__ctx1__ != null)
                    __ctx1__.__strPipMessageForSTX = null;
                if (__ctx1__ != null && __ctx1__.__Pip4C1ForE2OpenMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Pip4C1ForE2OpenMessage);
                    __ctx1__.__Pip4C1ForE2OpenMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__InventoryReportMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__InventoryReportMessage);
                    __ctx1__.__InventoryReportMessage = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceMessageIdForSTX = null;
                if (__ctx1__ != null && __ctx1__.__VendorReportMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__VendorReportMessage);
                    __ctx1__.__VendorReportMessage = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("VendorReportMessage")]
            public __messagetype_Kaifa_B2B_Schemas_Wms_VendorInventoryReport __VendorReportMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Pip4C1ForSTXMessage")]
            public __messagetype_Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4C1_MS_1_0_SupplierOwnInventory __Pip4C1ForSTXMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Pip4C1ForE2OpenMessage")]
            public __messagetype_Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4C1_MS_1_0_SupplierOwnInventory __Pip4C1ForE2OpenMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("InventoryReportMessage")]
            public __messagetype_Kaifa_B2B_Schemas_Wms_InventoryReport __InventoryReportMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SubmitRNIF1")]
            internal Microsoft.Solutions.BTARN.Shared.SubmitRNIF __SubmitRNIF1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strPipMessageFore2open")]
            internal System.String __strPipMessageFore2open;
            [Microsoft.XLANGs.Core.UserVariableAttribute("pipInstanceMessageIdFore2open")]
            internal System.String __pipInstanceMessageIdFore2open;
            [Microsoft.XLANGs.Core.UserVariableAttribute("pipInstanceMessageIdForSTX")]
            internal System.String __pipInstanceMessageIdForSTX;
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
            [Microsoft.XLANGs.Core.UserVariableAttribute("pipInstanceIdentifierForSTX")]
            internal System.String __pipInstanceIdentifierForSTX;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strPipMessageForSTX")]
            internal System.String __strPipMessageForSTX;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("ReceiveInventoryMessage")]
        internal PortType_ReceiveInventoryMessage ReceiveInventoryMessage;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendPip4C1Message")]
        internal PortType_SendPip4C1Message SendPip4C1Message;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_ReceiveInventoryMessage.Operation_1},
                                               typeof(SOI_Orchestration).GetField("ReceiveInventoryMessage", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(SOI_Orchestration), "ReceiveInventoryMessage"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_SendPip4C1Message.Operation_1},
                                               typeof(SOI_Orchestration).GetField("SendPip4C1Message", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(SOI_Orchestration), "SendPip4C1Message"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "ae849826-f625-4fd0-9b28-ea8fed3d7017", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "ae849826-f625-4fd0-9b28-ea8fed3d7017", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "0621ed13-18f1-4a3c-8d63-d5d79c4481c8", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "0621ed13-18f1-4a3c-8d63-d5d79c4481c8", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "58c173ad-0872-4da3-af51-cab3da9924e6", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "cca7a5ec-fc3e-4d81-a0de-1643380405a3", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "cca7a5ec-fc3e-4d81-a0de-1643380405a3", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "2f9cf345-854d-416c-9f50-b4b0f250d6e8", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "2f9cf345-854d-416c-9f50-b4b0f250d6e8", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "a939cdd4-aa3b-498a-994b-2415d028980a", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "a939cdd4-aa3b-498a-994b-2415d028980a", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "7dcfda03-6db8-4411-adc7-ecc4f9cf922c", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "7dcfda03-6db8-4411-adc7-ecc4f9cf922c", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "44938471-b0f1-4df7-a5ca-0e7a47e603ae", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "44938471-b0f1-4df7-a5ca-0e7a47e603ae", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "8ebbc165-d282-4301-be59-214cc4388c8f", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "8ebbc165-d282-4301-be59-214cc4388c8f", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "472fe5fe-6179-476d-b2d7-69f077deb8d1", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "472fe5fe-6179-476d-b2d7-69f077deb8d1", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "fc4b62e9-acab-4484-be0b-0ac9c08cf89f", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "fc4b62e9-acab-4484-be0b-0ac9c08cf89f", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "8bc4b0ba-742c-42f1-9e34-855baddc3e65", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "8bc4b0ba-742c-42f1-9e34-855baddc3e65", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "58c173ad-0872-4da3-af51-cab3da9924e6", 1, false)
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
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,2,2,2,2,4,4,5,5,5,6,6,6,7,7,8,9,10,10,27,27,28,29,29,29,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 11,11,12,13,13,13,14,15,15,16,16,16,16,10,};
        public static int[] __progressLocation3 = new int[] { 19,19,20,21,21,21,22,23,23,24,24,24,24,10,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __SOI_Orchestration_root_0 __ctx0__ = (__SOI_Orchestration_root_0)_stateMgrs[0];
            __SOI_Orchestration_1 __ctx1__ = (__SOI_Orchestration_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                ReceiveInventoryMessage = new PortType_ReceiveInventoryMessage(0, this);
                SendPip4C1Message = new PortType_SendPip4C1Message(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], ReceiveInventoryMessage, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __SOI_Orchestration_1(this);
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
            __SOI_Orchestration_root_0 __ctx0__ = (__SOI_Orchestration_root_0)_stateMgrs[0];
            __SOI_Orchestration_1 __ctx1__ = (__SOI_Orchestration_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__SubmitRNIF1 = default(Microsoft.Solutions.BTARN.Shared.SubmitRNIF);
                __ctx1__.__strPipMessageFore2open = default(System.String);
                __ctx1__.__pipInstanceMessageIdFore2open = default(System.String);
                __ctx1__.__pipInstanceMessageIdForSTX = default(System.String);
                __ctx1__.__pipInstanceIdentifierFore2open = default(System.String);
                __ctx1__.__SubmitRNIF = default(Microsoft.Solutions.BTARN.Shared.SubmitRNIF);
                __ctx1__.__Increase = default(System.Int32);
                __ctx1__.__CountStr = default(System.String);
                __ctx1__.__Count = default(System.Int32);
                __ctx1__.__pipInstanceIdentifierForSTX = default(System.String);
                __ctx1__.__strPipMessageForSTX = default(System.String);
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
                if (!ReceiveInventoryMessage.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__InventoryReportMessage != null)
                    __ctx1__.UnrefMessage(__ctx1__.__InventoryReportMessage);
                __ctx1__.__InventoryReportMessage = new __messagetype_Kaifa_B2B_Schemas_Wms_InventoryReport("InventoryReportMessage", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__InventoryReportMessage);
                ReceiveInventoryMessage.ReceiveMessage(0, __msgEnv__, __ctx1__.__InventoryReportMessage, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (ReceiveInventoryMessage != null)
                {
                    ReceiveInventoryMessage.Close(__ctx1__, __seg__);
                    ReceiveInventoryMessage = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__InventoryReportMessage);
                    __edata.PortName = @"ReceiveInventoryMessage";
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
                __ctx1__.__strPipMessageFore2open = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__pipInstanceMessageIdFore2open = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__pipInstanceMessageIdForSTX = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__pipInstanceIdentifierFore2open = "";
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__SubmitRNIF = new Microsoft.Solutions.BTARN.Shared.SubmitRNIF();
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__CountStr = "";
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__pipInstanceIdentifierForSTX = "";
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __ctx1__.__strPipMessageForSTX = "";
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                __ctx1__.__Count = (System.Int32)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__InventoryReportMessage.part, "count(/*[local-name()='InventoryReport' and namespace-uri()='http://kaifa.b2b.schemas/InventoryReport']/*[local-name()='VendorInventoryReport' and namespace-uri()='http://kaifa.b2b.schemas/InventoryReport'])", typeof(System.Int32));
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                __ctx1__.__CountStr = __ctx1__.__Count.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                __ctx1__.__Increase = 1;
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                __condition__ = __ctx1__.__Increase <= __ctx1__.__Count;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 33;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                {
                    __messagetype_Kaifa_B2B_Schemas_Wms_VendorInventoryReport __VendorReportMessage = new __messagetype_Kaifa_B2B_Schemas_Wms_VendorInventoryReport("VendorReportMessage", __ctx1__);

                    __ctx1__.__CountStr = __ctx1__.__Increase.ToString();
                    __VendorReportMessage.part.XPathAssign(__ctx1__.__InventoryReportMessage.part, "/*[local-name()='InventoryReport' and namespace-uri()='http://kaifa.b2b.schemas/InventoryReport']/*[local-name()='VendorInventoryReport' and namespace-uri()='http://kaifa.b2b.schemas/InventoryReport'][" + __ctx1__.__CountStr + "]");

                    if (__ctx1__.__VendorReportMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__VendorReportMessage);
                    __ctx1__.__VendorReportMessage = __VendorReportMessage;
                    __ctx1__.RefMessage(__ctx1__.__VendorReportMessage);
                }
                __ctx1__.__VendorReportMessage.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__VendorReportMessage);
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                __seg__.RunSegments(new Microsoft.XLANGs.Core.Segment[] {_segments[2], _segments[3]}, this);
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__VendorReportMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__VendorReportMessage);
                    __ctx1__.__VendorReportMessage = null;
                }
                Tracker.FireEvent(__eventLocations[10],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[27],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                __ctx1__.__Increase = __ctx1__.__Increase + 1;
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[28],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[29],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__strPipMessageForSTX = null;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceIdentifierForSTX = null;
                if (__ctx1__ != null)
                    __ctx1__.__CountStr = null;
                if (__ctx1__ != null)
                    __ctx1__.__SubmitRNIF = null;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceIdentifierFore2open = null;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceMessageIdForSTX = null;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceMessageIdFore2open = null;
                if (__ctx1__ != null)
                    __ctx1__.__strPipMessageFore2open = null;
                if (__ctx1__ != null)
                    __ctx1__.__SubmitRNIF1 = null;
                if (__ctx1__ != null && __ctx1__.__InventoryReportMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__InventoryReportMessage);
                    __ctx1__.__InventoryReportMessage = null;
                }
                if (SendPip4C1Message != null)
                {
                    SendPip4C1Message.Close(__ctx1__, __seg__);
                    SendPip4C1Message = null;
                }
                Tracker.FireEvent(__eventLocations[29],__eventData[11],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[12],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 37;
            case 37:
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
            __SOI_Orchestration_root_0 __ctx0__ = (__SOI_Orchestration_root_0)_stateMgrs[0];
            __SOI_Orchestration_1 __ctx1__ = (__SOI_Orchestration_1)_stateMgrs[1];

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
                    __messagetype_Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4C1_MS_1_0_SupplierOwnInventory __Pip4C1ForSTXMessage = new __messagetype_Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4C1_MS_1_0_SupplierOwnInventory("Pip4C1ForSTXMessage", __ctx1__);

                    ApplyTransform(typeof(Kaifa.B2B.Mapping.Inventory_To_4C1_STX), new object[] {__Pip4C1ForSTXMessage.part}, new object[] {__ctx1__.__VendorReportMessage.part});
                    __ctx1__.__pipInstanceIdentifierForSTX = (System.String)__Pip4C1ForSTXMessage.part.GetDistinguishedField("thisDocumentIdentifier.ProprietaryDocumentIdentifier");
                    __Pip4C1ForSTXMessage.SetPropertyValue(typeof(FILE.ReceivedFileName), "SOI_To_STX＿" + __ctx1__.__pipInstanceIdentifierForSTX + ".xml");

                    if (__ctx1__.__Pip4C1ForSTXMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Pip4C1ForSTXMessage);
                    __ctx1__.__Pip4C1ForSTXMessage = __Pip4C1ForSTXMessage;
                    __ctx1__.RefMessage(__ctx1__.__Pip4C1ForSTXMessage);
                }
                __ctx1__.__Pip4C1ForSTXMessage.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Pip4C1ForSTXMessage);
                    __edata.Messages.Add(__ctx1__.__VendorReportMessage);
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
                SendPip4C1Message.SendMessage(0, __ctx1__.__Pip4C1ForSTXMessage, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Pip4C1ForSTXMessage);
                    __edata.PortName = @"SendPip4C1Message";
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
                __ctx1__.__pipInstanceMessageIdForSTX = (System.String)__ctx1__.__Pip4C1ForSTXMessage.GetPropertyValueThrows(typeof(BTS.MessageID));
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
                __ctx1__.__strPipMessageForSTX = Kaifa.B2B.Utility.HeaderHelper.ReturnSCWithDocType(__ctx1__.__Pip4C1ForSTXMessage.part.TypedValue, "4C1V0200");
                if (__ctx1__ != null && __ctx1__.__Pip4C1ForSTXMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Pip4C1ForSTXMessage);
                    __ctx1__.__Pip4C1ForSTXMessage = null;
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
                __ctx1__.__SubmitRNIF.SubmitMessage(Microsoft.Solutions.BTARN.Shared.MessageCategory.AsyncAction, "KAIFA", "SEAGATE-US", "4C1", __ctx1__.__pipInstanceMessageIdForSTX, "R02.00", __ctx1__.__strPipMessageForSTX);
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
            __SOI_Orchestration_root_0 __ctx0__ = (__SOI_Orchestration_root_0)_stateMgrs[0];
            __SOI_Orchestration_1 __ctx1__ = (__SOI_Orchestration_1)_stateMgrs[1];

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
                    __messagetype_Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4C1_MS_1_0_SupplierOwnInventory __Pip4C1ForE2OpenMessage = new __messagetype_Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4C1_MS_1_0_SupplierOwnInventory("Pip4C1ForE2OpenMessage", __ctx1__);

                    ApplyTransform(typeof(Kaifa.B2B.Mapping.Inventory_To_4C1_e2open), new object[] {__Pip4C1ForE2OpenMessage.part}, new object[] {__ctx1__.__VendorReportMessage.part});
                    __ctx1__.__pipInstanceIdentifierFore2open = (System.String)__Pip4C1ForE2OpenMessage.part.GetDistinguishedField("thisDocumentIdentifier.ProprietaryDocumentIdentifier");
                    __Pip4C1ForE2OpenMessage.SetPropertyValue(typeof(FILE.ReceivedFileName), "SOI_To_e2open＿" + __ctx1__.__pipInstanceIdentifierFore2open + ".xml");

                    if (__ctx1__.__Pip4C1ForE2OpenMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Pip4C1ForE2OpenMessage);
                    __ctx1__.__Pip4C1ForE2OpenMessage = __Pip4C1ForE2OpenMessage;
                    __ctx1__.RefMessage(__ctx1__.__Pip4C1ForE2OpenMessage);
                }
                __ctx1__.__Pip4C1ForE2OpenMessage.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Pip4C1ForE2OpenMessage);
                    __edata.Messages.Add(__ctx1__.__VendorReportMessage);
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
                SendPip4C1Message.SendMessage(0, __ctx1__.__Pip4C1ForE2OpenMessage, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Pip4C1ForE2OpenMessage);
                    __edata.PortName = @"SendPip4C1Message";
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
                __ctx1__.__pipInstanceMessageIdFore2open = (System.String)__ctx1__.__Pip4C1ForE2OpenMessage.GetPropertyValueThrows(typeof(BTS.MessageID));
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
                __ctx1__.__strPipMessageFore2open = Kaifa.B2B.Utility.HeaderHelper.ReturnSCWithDocType(__ctx1__.__Pip4C1ForE2OpenMessage.part.TypedValue, "4C1V0200");
                if (__ctx1__ != null && __ctx1__.__Pip4C1ForE2OpenMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Pip4C1ForE2OpenMessage);
                    __ctx1__.__Pip4C1ForE2OpenMessage = null;
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
                __ctx1__.__SubmitRNIF1.SubmitMessage(Microsoft.Solutions.BTARN.Shared.MessageCategory.AsyncAction, "KAIFA", "E2OPEN", "4C1", __ctx1__.__pipInstanceMessageIdFore2open, "R02.00", __ctx1__.__strPipMessageFore2open);
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
    sealed public class __Kaifa_B2B_Schemas_Wms_InventoryReport__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.Schemas.Wms.InventoryReport _schema = new Kaifa.B2B.Schemas.Wms.InventoryReport();

        public __Kaifa_B2B_Schemas_Wms_InventoryReport__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Kaifa.B2B.Schemas.Wms.InventoryReport",
        new System.Type[]{
            typeof(Kaifa.B2B.Schemas.Wms.InventoryReport)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_Schemas_Wms_InventoryReport__)
        },
        0,
        @"http://kaifa.b2b.schemas/InventoryReport#InventoryReport"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Kaifa_B2B_Schemas_Wms_InventoryReport : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_Schemas_Wms_InventoryReport__ part;

        private void __CreatePartWrappers()
        {
            part = new __Kaifa_B2B_Schemas_Wms_InventoryReport__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Kaifa_B2B_Schemas_Wms_InventoryReport(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4C1_MS_1_0_SupplierOwnInventory__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4C1_MS_1_0_SupplierOwnInventory _schema = new Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4C1_MS_1_0_SupplierOwnInventory();

        public __Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4C1_MS_1_0_SupplierOwnInventory__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4C1_MS_1_0_SupplierOwnInventory",
        new System.Type[]{
            typeof(Kaifa.B2B.Schemas.RosettaNet.SGRTHUB4C1_MS_1_0_SupplierOwnInventory)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4C1_MS_1_0_SupplierOwnInventory__)
        },
        0,
        @"http://kaifa.b2b.schemas/SGRTHUB4C1_MS_1_0_SupplierOwnInventory#Pip4C1InventoryReportNotification"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4C1_MS_1_0_SupplierOwnInventory : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4C1_MS_1_0_SupplierOwnInventory__ part;

        private void __CreatePartWrappers()
        {
            part = new __Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4C1_MS_1_0_SupplierOwnInventory__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Kaifa_B2B_Schemas_RosettaNet_SGRTHUB4C1_MS_1_0_SupplierOwnInventory(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Kaifa_B2B_Schemas_Wms_VendorInventoryReport__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.Schemas.Wms.VendorInventoryReport _schema = new Kaifa.B2B.Schemas.Wms.VendorInventoryReport();

        public __Kaifa_B2B_Schemas_Wms_VendorInventoryReport__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Kaifa.B2B.Schemas.Wms.VendorInventoryReport",
        new System.Type[]{
            typeof(Kaifa.B2B.Schemas.Wms.VendorInventoryReport)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_Schemas_Wms_VendorInventoryReport__)
        },
        0,
        @"http://kaifa.b2b.schemas/InventoryReport#VendorInventoryReport"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Kaifa_B2B_Schemas_Wms_VendorInventoryReport : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_Schemas_Wms_VendorInventoryReport__ part;

        private void __CreatePartWrappers()
        {
            part = new __Kaifa_B2B_Schemas_Wms_VendorInventoryReport__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Kaifa_B2B_Schemas_Wms_VendorInventoryReport(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Microsoft_XLANGs_BaseTypes_Any__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Microsoft.XLANGs.BaseTypes.Any _schema = new Microsoft.XLANGs.BaseTypes.Any();

        public __Microsoft_XLANGs_BaseTypes_Any__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "System.Xml.XmlDocument",
        new System.Type[]{
            typeof(Microsoft.XLANGs.BaseTypes.Any)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Microsoft_XLANGs_BaseTypes_Any__)
        },
        0,
        Microsoft.XLANGs.Core.XMessage.AnyMessageTypeName
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_System_Xml_XmlDocument : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Microsoft_XLANGs_BaseTypes_Any__ part;

        private void __CreatePartWrappers()
        {
            part = new __Microsoft_XLANGs_BaseTypes_Any__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_System_Xml_XmlDocument(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
