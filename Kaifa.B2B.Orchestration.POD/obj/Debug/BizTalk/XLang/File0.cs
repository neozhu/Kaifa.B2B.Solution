
#pragma warning disable 162

namespace Kaifa.B2B.Orchestration.POD
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Kaifa.B2B.Orchestration.POD.__messagetype_Kaifa_B2B_Schemas_Wms_OrderShipmentPOD)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_ReceiveOrderShipmentPODMessage : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_ReceiveOrderShipmentPODMessage(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_ReceiveOrderShipmentPODMessage(PortType_ReceiveOrderShipmentPODMessage p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_ReceiveOrderShipmentPODMessage p = new PortType_ReceiveOrderShipmentPODMessage(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_ReceiveOrderShipmentPODMessage),
            typeof(__messagetype_Kaifa_B2B_Schemas_Wms_OrderShipmentPOD),
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
            typeof(Kaifa.B2B.Orchestration.POD.__messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip4B2PODShipmentReceiptNotification)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_SendPIPs4B2PODMessage : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_SendPIPs4B2PODMessage(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_SendPIPs4B2PODMessage(PortType_SendPIPs4B2PODMessage p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_SendPIPs4B2PODMessage p = new PortType_SendPIPs4B2PODMessage(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_SendPIPs4B2PODMessage),
            typeof(__messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip4B2PODShipmentReceiptNotification),
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
    //#line 481 "D:\长城开发项目\SourceCode\Kaifa.B2B.Solution\Kaifa.B2B.Orchestration.POD\POD.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "ReceiveOrderShipmentPODMessage", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Kaifa.B2B.Orchestration.POD.PortType_ReceiveOrderShipmentPODMessage),
            typeof(Kaifa.B2B.Orchestration.POD.PortType_SendPIPs4B2PODMessage)
        },
        new System.String[] {
            "ReceiveOrderShipmentPODMessage",
            "SendPIPs4B2PODMessage"
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
    sealed internal class POD_Orchestration : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(POD_Orchestration));
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

        static POD_Orchestration()
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
            _rootContext = new __POD_Orchestration_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public POD_Orchestration(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "POD_Orchestration", tracker)
        {
            ConstructorHelper();
        }

        public POD_Orchestration(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "POD_Orchestration")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>6978530d-4e66-4110-9a81-db8c508813c0</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>c808c561-c197-4d5b-be8a-ba7b03d46f2d</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_ShipmentPod</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>7159d350-c0b7-4a8c-a672-5096a50f1022</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>GetCount</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>WhileShape</shapeType>      <ShapeID>df3a8c55-c591-4049-8b68-eb9dffa3d727</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Loop_SplitAsnMessage</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>ba0c8e18-4aa0-4777-b916-d8924162aba0</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_VendorShipmentPODMessage_STX</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>eb245aaf-aa0a-4666-919a-5cfedb43328a</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>29eab5bb-9c44-40a7-8719-521ff1630488</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParallelShape</shapeType>      <ShapeID>109f5c8d-2dbd-4682-a5d9-551915bd7a8b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ParallelActions_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>92c0d0e0-29e5-49f1-a62b-9a52a4ddfaa4</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>f402d79c-ec46-4a6c-936c-9700435024be</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_Pip4B2POD_STX</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>8c56a69a-a0c2-4bfb-a883-81192518ce13</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>405887dd-afd4-42f4-bd09-45a2eaa7d0e3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>693f441e-ee5e-4eac-89bc-f194e08d7abf</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>0f5e4260-e480-4625-9eca-b2ca7db3bb3a</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>94605719-1453-4c48-9835-fa4565864cfe</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>7086426e-0eb6-41e1-aff5-d154a333e016</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_PIPs4B2POD</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>4dfa0e36-091b-42c3-b2f1-0f71e6ec2d6f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>InvokeSubmitRNIFAPI</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>1263b6fe-35d6-416c-a740-42661a4c248c</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>a8c750b0-f4f2-4aba-93dc-f62c0af43a20</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_Pip4B2POD_e2Open</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>d1c4e7fd-5c09-47c7-b9e6-46655b4843f0</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>92fd8c4d-7d74-4044-a624-c9d602de7c82</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>b8224a4a-0c76-40cc-a7a7-dfe502780513</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>790aab8a-24e3-4487-a358-ebd5d9916f9a</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>76376b69-034e-40b4-8175-107df6dfb5b7</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>7f40e50c-9a74-439c-8736-560c0fb16803</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_PIPs4B2POD</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>f642c86a-053f-4b90-b40c-de7a094083e0</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>InvokeSubmitRNIFAPI</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>e07d29d3-c70b-4e24-95be-9a465c980174</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Increasing</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>f54876a9-438a-4eab-b1e2-6285179328b9</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>GetCount</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>WhileShape</shapeType>      <ShapeID>a82ba563-1491-4f15-9274-ccb910701e66</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Loop_SplitCMAsnMessage</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>fb051358-f561-40e9-882e-5aaaa10554b4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_CMShipmentPODMessage_STX</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>5520ef1c-3b87-46a5-836e-a6e80e3c092a</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>95c7842a-d0b2-41b6-b448-5d44bcfa9dce</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>b03c01ab-65c3-4d0e-a7a8-bed669ea291e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_Pip4B2POD_STX</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>4e5a2e40-6cb4-415d-95a4-d30608033e18</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>19ec79b5-d16a-4a65-90ed-8c8856100be2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>b0080ccc-7fa7-47ea-9d8c-498b97718e26</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_6</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>a20234fa-9c1c-4471-a8b5-bd3ab69fd334</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_5</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>93c70e39-06ec-4411-a4c2-7a874586537a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>40322437-d0c5-4620-875f-2f4b6d1eef45</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_PIPs4B2POD</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>896c23e6-4a25-4081-909d-2bc59cf4b367</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>InvokeSubmitRNIFAPI</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>011951d3-fb41-464e-b860-cfd5081b2122</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Increasing</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'POD_Orchestration'</ActionName><IsAtomic>0</IsAtomic><Line>481</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>506</Line><Position>22</Position><ShapeID>'c808c561-c197-4d5b-be8a-ba7b03d46f2d'</ShapeID>
<Messages>
	<MsgInfo><name>OrderShipmentPODMessage</name><part>part</part><schema>Kaifa.B2B.Schemas.Wms.OrderShipmentPOD</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>517</Line><Position>19</Position><ShapeID>'7159d350-c0b7-4a8c-a672-5096a50f1022'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>521</Line><Position>13</Position><ShapeID>'df3a8c55-c591-4049-8b68-eb9dffa3d727'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>524</Line><Position>17</Position><ShapeID>'ba0c8e18-4aa0-4777-b916-d8924162aba0'</ShapeID>
<Messages>
	<MsgInfo><name>VendorShipmentPODReport</name><part>part</part><schema>Kaifa.B2B.Schemas.Wms.VendorShipmentPODReport</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>531</Line><Position>17</Position><ShapeID>'109f5c8d-2dbd-4682-a5d9-551915bd7a8b'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>536</Line><Position>25</Position><ShapeID>'f402d79c-ec46-4a6c-936c-9700435024be'</ShapeID>
<Messages>
	<MsgInfo><name>PIPs4B2PODMessageForSTX</name><part>part</part><schema>Kaifa.B2B.Schemas.RosettaNet.Pip4B2PODShipmentReceiptNotification</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>VendorShipmentPODReport</name><part>part</part><schema>Kaifa.B2B.Schemas.Wms.VendorShipmentPODReport</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>546</Line><Position>25</Position><ShapeID>'7086426e-0eb6-41e1-aff5-d154a333e016'</ShapeID>
<Messages>
	<MsgInfo><name>PIPs4B2PODMessageForSTX</name><part>part</part><schema>Kaifa.B2B.Schemas.RosettaNet.Pip4B2PODShipmentReceiptNotification</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>549</Line><Position>52</Position><ShapeID>'4dfa0e36-091b-42c3-b2f1-0f71e6ec2d6f'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>568</Line><Position>25</Position><ShapeID>'a8c750b0-f4f2-4aba-93dc-f62c0af43a20'</ShapeID>
<Messages>
	<MsgInfo><name>PIPs4B2PODMessageForE2open</name><part>part</part><schema>Kaifa.B2B.Schemas.RosettaNet.Pip4B2PODShipmentReceiptNotification</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>VendorShipmentPODReport</name><part>part</part><schema>Kaifa.B2B.Schemas.Wms.VendorShipmentPODReport</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>578</Line><Position>25</Position><ShapeID>'7f40e50c-9a74-439c-8736-560c0fb16803'</ShapeID>
<Messages>
	<MsgInfo><name>PIPs4B2PODMessageForE2open</name><part>part</part><schema>Kaifa.B2B.Schemas.RosettaNet.Pip4B2PODShipmentReceiptNotification</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>581</Line><Position>55</Position><ShapeID>'f642c86a-053f-4b90-b40c-de7a094083e0'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>597</Line><Position>26</Position><ShapeID>'e07d29d3-c70b-4e24-95be-9a465c980174'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>600</Line><Position>19</Position><ShapeID>'f54876a9-438a-4eab-b1e2-6285179328b9'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>604</Line><Position>13</Position><ShapeID>'a82ba563-1491-4f15-9274-ccb910701e66'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>607</Line><Position>17</Position><ShapeID>'fb051358-f561-40e9-882e-5aaaa10554b4'</ShapeID>
<Messages>
	<MsgInfo><name>CMShipmentPODReport</name><part>part</part><schema>Kaifa.B2B.Schemas.Wms.CMShipmentPODReport</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>614</Line><Position>17</Position><ShapeID>'b03c01ab-65c3-4d0e-a7a8-bed669ea291e'</ShapeID>
<Messages>
	<MsgInfo><name>PIPs4B2PODMessageForE2open</name><part>part</part><schema>Kaifa.B2B.Schemas.RosettaNet.Pip4B2PODShipmentReceiptNotification</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>CMShipmentPODReport</name><part>part</part><schema>Kaifa.B2B.Schemas.Wms.CMShipmentPODReport</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>624</Line><Position>17</Position><ShapeID>'40322437-d0c5-4620-875f-2f4b6d1eef45'</ShapeID>
<Messages>
	<MsgInfo><name>PIPs4B2PODMessageForE2open</name><part>part</part><schema>Kaifa.B2B.Schemas.RosettaNet.Pip4B2PODShipmentReceiptNotification</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>627</Line><Position>47</Position><ShapeID>'896c23e6-4a25-4081-909d-2bc59cf4b367'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>641</Line><Position>26</Position><ShapeID>'011951d3-fb41-464e-b860-cfd5081b2122'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='59f17007-564e-4e47-865d-a9c54ff8f897' LowerBound='1.1' HigherBound='184.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Kaifa.B2B.Orchestration.POD' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='12ab99f1-99f5-4d4a-b3fa-8d3826f3784f' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='183.1'>
            <om:Property Name='InitializedTransactionType' Value='True' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='POD_Orchestration' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='06abc833-8b41-424d-93ee-62bdd78a3d07' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='Microsoft.Solutions.BTARN.Shared.SubmitRNIF' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SubmitRNIF1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='912868ee-5644-4b73-bacb-60cb3f23d3c9' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='31.1' HigherBound='32.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='Microsoft.Solutions.BTARN.Shared.SubmitRNIF' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SubmitRNIF' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='a58f4dc5-1116-420d-90ea-d401bc171327' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='32.1' HigherBound='33.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strPipMessageForSTX' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='cc963b7b-f811-449b-9d1b-9de8046745f3' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='33.1' HigherBound='34.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strPipMessageFore2open' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='c1c8b04d-4a71-4b00-8014-6bdc77f647e8' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='pipInstanceMessageIdForSTX' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='10fe5501-4613-43a9-b78b-47f16839560d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='35.1' HigherBound='36.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='pipInstanceMessageIdFore2open' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='f18d3076-46cd-4f5e-96a1-7c5fa57bbee6' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='36.1' HigherBound='37.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='pipInstanceIdentifierForSTX' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='6be3cd08-37d7-4a34-b746-a0538f699879' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='37.1' HigherBound='38.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='pipInstanceIdentifierFore2open' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='1f79a97e-3411-47f5-a334-ec78e36314d7' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='38.1' HigherBound='39.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Increase' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='baa0f6e6-de61-4fc5-be5f-e1058e6ae39c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='39.1' HigherBound='40.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CountStr' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='0d97cd5d-be4b-4bb3-92e9-5948dd0f0182' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='40.1' HigherBound='41.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Count' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='LongRunningTransaction' OID='bcffff5d-50e7-4616-afb1-8f2acf6796d5' ParentLink='ServiceDeclaration_Transaction' LowerBound='19.21' HigherBound='19.63'>
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Transaction_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='dba55ea0-8619-49fd-9a85-013f39844d78' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas.RosettaNet.Pip4B2PODShipmentReceiptNotification' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PIPs4B2PODMessageForE2open' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='30906841-db26-49a7-94ea-d559811184de' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas.Wms.OrderShipmentPOD' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OrderShipmentPODMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='e9ad5246-146b-4594-8d2f-53703baa641b' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas.Wms.VendorShipmentPODReport' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='VendorShipmentPODReport' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ce9045fb-94b0-402e-9172-92e5e1f2eeac' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas.RosettaNet.Pip4B2PODShipmentReceiptNotification' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PIPs4B2PODMessageForSTX' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='115bb924-9a16-4249-a44b-ada9ba376c71' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas.Wms.CMShipmentPODReport' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CMShipmentPODReport' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='6978530d-4e66-4110-9a81-db8c508813c0' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='c808c561-c197-4d5b-be8a-ba7b03d46f2d' ParentLink='ServiceBody_Statement' LowerBound='43.1' HigherBound='54.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='ReceiveOrderShipmentPODMessage' />
                    <om:Property Name='MessageName' Value='OrderShipmentPODMessage' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_ShipmentPod' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='7159d350-c0b7-4a8c-a672-5096a50f1022' ParentLink='ServiceBody_Statement' LowerBound='54.1' HigherBound='58.1'>
                    <om:Property Name='Expression' Value='Count = xpath(OrderShipmentPODMessage, &quot;count(/*[local-name()=&apos;OrderShipmentPOD&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/OrderShipmentPOD&apos;]/*[local-name()=&apos;VendorShipmentPODReport&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/OrderShipmentPOD&apos;])&quot;); &#xD;&#xA;CountStr = Count.ToString();&#xD;&#xA;Increase = 1;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='GetCount' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='While' OID='df3a8c55-c591-4049-8b68-eb9dffa3d727' ParentLink='ServiceBody_Statement' LowerBound='58.1' HigherBound='137.1'>
                    <om:Property Name='Expression' Value='Increase&lt;=Count ' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Loop_SplitAsnMessage' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='Construct' OID='ba0c8e18-4aa0-4777-b916-d8924162aba0' ParentLink='ComplexStatement_Statement' LowerBound='61.1' HigherBound='68.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructMessage_VendorShipmentPODMessage_STX' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageRef' OID='eb245aaf-aa0a-4666-919a-5cfedb43328a' ParentLink='Construct_MessageRef' LowerBound='62.27' HigherBound='62.50'>
                            <om:Property Name='Ref' Value='VendorShipmentPODReport' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageAssignment' OID='29eab5bb-9c44-40a7-8719-521ff1630488' ParentLink='ComplexStatement_Statement' LowerBound='64.1' HigherBound='67.1'>
                            <om:Property Name='Expression' Value='CountStr = Increase.ToString();&#xD;&#xA;VendorShipmentPODReport =  xpath(OrderShipmentPODMessage, &quot;/*[local-name()=&apos;OrderShipmentPOD&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/OrderShipmentPOD&apos;]/*[local-name()=&apos;VendorShipmentPODReport&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/OrderShipmentPOD&apos;][&quot; + CountStr + &quot;]&quot;);' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='MessageAssignment_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Parallel' OID='109f5c8d-2dbd-4682-a5d9-551915bd7a8b' ParentLink='ComplexStatement_Statement' LowerBound='68.1' HigherBound='134.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ParallelActions_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='ParallelBranch' OID='92c0d0e0-29e5-49f1-a62b-9a52a4ddfaa4' ParentLink='ReallyComplexStatement_Branch' LowerBound='73.1' HigherBound='102.1'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ParallelBranch_1' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Construct' OID='f402d79c-ec46-4a6c-936c-9700435024be' ParentLink='ComplexStatement_Statement' LowerBound='73.1' HigherBound='83.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ConstructMessage_Pip4B2POD_STX' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageRef' OID='8c56a69a-a0c2-4bfb-a883-81192518ce13' ParentLink='Construct_MessageRef' LowerBound='74.35' HigherBound='74.58'>
                                    <om:Property Name='Ref' Value='PIPs4B2PODMessageForSTX' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Transform' OID='405887dd-afd4-42f4-bd09-45a2eaa7d0e3' ParentLink='ComplexStatement_Statement' LowerBound='76.1' HigherBound='78.1'>
                                    <om:Property Name='ClassName' Value='Kaifa.B2B.Mapping.Order_To_4B2POD_STX' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Transform_1' />
                                    <om:Property Name='Signal' Value='False' />
                                    <om:Element Type='MessagePartRef' OID='693f441e-ee5e-4eac-89bc-f194e08d7abf' ParentLink='Transform_OutputMessagePartRef' LowerBound='77.40' HigherBound='77.63'>
                                        <om:Property Name='MessageRef' Value='PIPs4B2PODMessageForSTX' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_2' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessagePartRef' OID='0f5e4260-e480-4625-9eca-b2ca7db3bb3a' ParentLink='Transform_InputMessagePartRef' LowerBound='77.106' HigherBound='77.129'>
                                        <om:Property Name='MessageRef' Value='VendorShipmentPODReport' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_1' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='MessageAssignment' OID='94605719-1453-4c48-9835-fa4565864cfe' ParentLink='ComplexStatement_Statement' LowerBound='78.1' HigherBound='82.1'>
                                    <om:Property Name='Expression' Value='pipInstanceIdentifierForSTX =  PIPs4B2PODMessageForSTX.thisDocumentIdentifier.ProprietaryDocumentIdentifier;&#xD;&#xA;PIPs4B2PODMessageForSTX(FILE.ReceivedFileName) = &quot;POD_To_STX＿&quot;  + pipInstanceIdentifierForSTX + &quot;.xml&quot;;&#xD;&#xA;//pipInstanceMessageIdForSTX = Pip4B2MessageForSTX(BTS.MessageID);' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='MessageAssignment_3' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Send' OID='7086426e-0eb6-41e1-aff5-d154a333e016' ParentLink='ComplexStatement_Statement' LowerBound='83.1' HigherBound='85.1'>
                                <om:Property Name='PortName' Value='SendPIPs4B2PODMessage' />
                                <om:Property Name='MessageName' Value='PIPs4B2PODMessageForSTX' />
                                <om:Property Name='OperationName' Value='Operation_1' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send_PIPs4B2POD' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='4dfa0e36-091b-42c3-b2f1-0f71e6ec2d6f' ParentLink='ComplexStatement_Statement' LowerBound='85.1' HigherBound='102.1'>
                                <om:Property Name='Expression' Value='//&#xD;&#xA;pipInstanceMessageIdForSTX = PIPs4B2PODMessageForSTX(BTS.MessageID);&#xD;&#xA;strPipMessageForSTX  =  Kaifa.B2B.Utility.HeaderHelper.ReturnSCWithDocType(PIPs4B2PODMessageForSTX,&quot;4B2SG0100&quot;);&#xD;&#xA;System.Diagnostics.Trace.WriteLine(&quot;SubmitRNIF.SubmitMessage To STX &quot; + pipInstanceMessageIdForSTX + &quot; - &quot; + pipInstanceIdentifierForSTX,&quot;kaifa.b2b&quot;);&#xD;&#xA;//System.Diagnostics.Trace.WriteLine(&quot;SubmitRNIF.SubmitMessage To STX &quot; + pipInstanceMessageIdForSTX + &quot; - &quot; + pipInstanceIdentifierForSTX,&quot;kaifa.b2b&quot;);&#xD;&#xA; SubmitRNIF.SubmitMessage(Microsoft.Solutions.BTARN.Shared.MessageCategory.AsyncAction,&#xD;&#xA; &quot;KAIFA&quot;,&#xD;&#xA; &quot;SEAGATE-US&quot;,&#xD;&#xA; &quot;4B2&quot;,&#xD;&#xA; pipInstanceMessageIdForSTX,&#xD;&#xA; &quot;1.0&quot;,&#xD;&#xA; strPipMessageForSTX&#xD;&#xA; );&#xD;&#xA;&#xD;&#xA;&#xD;&#xA; ' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='InvokeSubmitRNIFAPI' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='ParallelBranch' OID='1263b6fe-35d6-416c-a740-42661a4c248c' ParentLink='ReallyComplexStatement_Branch' LowerBound='105.1' HigherBound='132.1'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ParallelBranch_2' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Construct' OID='a8c750b0-f4f2-4aba-93dc-f62c0af43a20' ParentLink='ComplexStatement_Statement' LowerBound='105.1' HigherBound='115.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ConstructMessage_Pip4B2POD_e2Open' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageRef' OID='d1c4e7fd-5c09-47c7-b9e6-46655b4843f0' ParentLink='Construct_MessageRef' LowerBound='106.35' HigherBound='106.61'>
                                    <om:Property Name='Ref' Value='PIPs4B2PODMessageForE2open' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Transform' OID='92fd8c4d-7d74-4044-a624-c9d602de7c82' ParentLink='ComplexStatement_Statement' LowerBound='108.1' HigherBound='110.1'>
                                    <om:Property Name='ClassName' Value='Kaifa.B2B.Mapping.Order_To_4B2POD_e2open' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Transform_2' />
                                    <om:Property Name='Signal' Value='False' />
                                    <om:Element Type='MessagePartRef' OID='b8224a4a-0c76-40cc-a7a7-dfe502780513' ParentLink='Transform_OutputMessagePartRef' LowerBound='109.40' HigherBound='109.66'>
                                        <om:Property Name='MessageRef' Value='PIPs4B2PODMessageForE2open' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_4' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessagePartRef' OID='790aab8a-24e3-4487-a358-ebd5d9916f9a' ParentLink='Transform_InputMessagePartRef' LowerBound='109.112' HigherBound='109.135'>
                                        <om:Property Name='MessageRef' Value='VendorShipmentPODReport' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_3' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='MessageAssignment' OID='76376b69-034e-40b4-8175-107df6dfb5b7' ParentLink='ComplexStatement_Statement' LowerBound='110.1' HigherBound='114.1'>
                                    <om:Property Name='Expression' Value='pipInstanceIdentifierFore2open =  PIPs4B2PODMessageForE2open.thisDocumentIdentifier.ProprietaryDocumentIdentifier;&#xD;&#xA;PIPs4B2PODMessageForE2open(FILE.ReceivedFileName) = &quot;POD_To_e2open＿&quot;  + pipInstanceIdentifierFore2open + &quot;.xml&quot;;&#xD;&#xA;//pipInstanceMessageIdFore2open = Pip4B2MessageForE2Open(BTS.MessageID);' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='MessageAssignment_3' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Send' OID='7f40e50c-9a74-439c-8736-560c0fb16803' ParentLink='ComplexStatement_Statement' LowerBound='115.1' HigherBound='117.1'>
                                <om:Property Name='PortName' Value='SendPIPs4B2PODMessage' />
                                <om:Property Name='MessageName' Value='PIPs4B2PODMessageForE2open' />
                                <om:Property Name='OperationName' Value='Operation_1' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send_PIPs4B2POD' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='f642c86a-053f-4b90-b40c-de7a094083e0' ParentLink='ComplexStatement_Statement' LowerBound='117.1' HigherBound='132.1'>
                                <om:Property Name='Expression' Value='//&#xD;&#xA;pipInstanceMessageIdFore2open = PIPs4B2PODMessageForE2open(BTS.MessageID);&#xD;&#xA;strPipMessageFore2open  =  Kaifa.B2B.Utility.HeaderHelper.ReturnSCWithDocType(PIPs4B2PODMessageForE2open,&quot;4B2SG0100&quot;);&#xD;&#xA;&#xD;&#xA;System.Diagnostics.Trace.WriteLine(&quot;SubmitRNIF.SubmitMessage To e2open &quot; + pipInstanceMessageIdFore2open + &quot; - &quot; + pipInstanceIdentifierFore2open,&quot;kaifa.b2b&quot;);&#xD;&#xA; SubmitRNIF1.SubmitMessage(Microsoft.Solutions.BTARN.Shared.MessageCategory.AsyncAction,&#xD;&#xA; &quot;KAIFA&quot;,&#xD;&#xA; &quot;E2OPEN&quot;,&#xD;&#xA; &quot;4B2&quot;,&#xD;&#xA; pipInstanceMessageIdFore2open,&#xD;&#xA; &quot;1.0&quot;,&#xD;&#xA; strPipMessageFore2open&#xD;&#xA; );&#xD;&#xA; ' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='InvokeSubmitRNIFAPI' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='e07d29d3-c70b-4e24-95be-9a465c980174' ParentLink='ComplexStatement_Statement' LowerBound='134.1' HigherBound='136.1'>
                        <om:Property Name='Expression' Value='Increase = Increase + 1;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Increasing' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='VariableAssignment' OID='f54876a9-438a-4eab-b1e2-6285179328b9' ParentLink='ServiceBody_Statement' LowerBound='137.1' HigherBound='141.1'>
                    <om:Property Name='Expression' Value='Count = xpath(OrderShipmentPODMessage, &quot;count(/*[local-name()=&apos;OrderShipmentPOD&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/OrderShipmentPOD&apos;]/*[local-name()=&apos;CMShipmentPODReport&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/OrderShipmentPOD&apos;])&quot;); &#xD;&#xA;CountStr = Count.ToString();&#xD;&#xA;Increase = 1;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='GetCount' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='While' OID='a82ba563-1491-4f15-9274-ccb910701e66' ParentLink='ServiceBody_Statement' LowerBound='141.1' HigherBound='181.1'>
                    <om:Property Name='Expression' Value='Increase&lt;=Count ' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Loop_SplitCMAsnMessage' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='Construct' OID='fb051358-f561-40e9-882e-5aaaa10554b4' ParentLink='ComplexStatement_Statement' LowerBound='144.1' HigherBound='151.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructMessage_CMShipmentPODMessage_STX' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageRef' OID='5520ef1c-3b87-46a5-836e-a6e80e3c092a' ParentLink='Construct_MessageRef' LowerBound='145.27' HigherBound='145.46'>
                            <om:Property Name='Ref' Value='CMShipmentPODReport' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageAssignment' OID='95c7842a-d0b2-41b6-b448-5d44bcfa9dce' ParentLink='ComplexStatement_Statement' LowerBound='147.1' HigherBound='150.1'>
                            <om:Property Name='Expression' Value='CountStr = Increase.ToString();&#xD;&#xA;CMShipmentPODReport =  xpath(OrderShipmentPODMessage, &quot;/*[local-name()=&apos;OrderShipmentPOD&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/OrderShipmentPOD&apos;]/*[local-name()=&apos;CMShipmentPODReport&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/OrderShipmentPOD&apos;][&quot; + CountStr + &quot;]&quot;);' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='MessageAssignment_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Construct' OID='b03c01ab-65c3-4d0e-a7a8-bed669ea291e' ParentLink='ComplexStatement_Statement' LowerBound='151.1' HigherBound='161.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructMessage_Pip4B2POD_STX' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageRef' OID='4e5a2e40-6cb4-415d-95a4-d30608033e18' ParentLink='Construct_MessageRef' LowerBound='152.27' HigherBound='152.53'>
                            <om:Property Name='Ref' Value='PIPs4B2PODMessageForE2open' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Transform' OID='19ec79b5-d16a-4a65-90ed-8c8856100be2' ParentLink='ComplexStatement_Statement' LowerBound='154.1' HigherBound='156.1'>
                            <om:Property Name='ClassName' Value='Kaifa.B2B.Mapping.Order_To_4B2POD_e2open_CM' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Transform_1' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessagePartRef' OID='b0080ccc-7fa7-47ea-9d8c-498b97718e26' ParentLink='Transform_OutputMessagePartRef' LowerBound='155.32' HigherBound='155.58'>
                                <om:Property Name='MessageRef' Value='PIPs4B2PODMessageForE2open' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_6' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='a20234fa-9c1c-4471-a8b5-bd3ab69fd334' ParentLink='Transform_InputMessagePartRef' LowerBound='155.107' HigherBound='155.126'>
                                <om:Property Name='MessageRef' Value='CMShipmentPODReport' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_5' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='MessageAssignment' OID='93c70e39-06ec-4411-a4c2-7a874586537a' ParentLink='ComplexStatement_Statement' LowerBound='156.1' HigherBound='160.1'>
                            <om:Property Name='Expression' Value='pipInstanceIdentifierFore2open =  PIPs4B2PODMessageForE2open.thisDocumentIdentifier.ProprietaryDocumentIdentifier;&#xD;&#xA;PIPs4B2PODMessageForE2open(FILE.ReceivedFileName) = &quot;PODCM_To_e2open＿&quot;  + pipInstanceIdentifierFore2open + &quot;.xml&quot;;&#xD;&#xA;//pipInstanceMessageIdFore2open = Pip4B2MessageForE2Open(BTS.MessageID);' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='MessageAssignment_3' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Send' OID='40322437-d0c5-4620-875f-2f4b6d1eef45' ParentLink='ComplexStatement_Statement' LowerBound='161.1' HigherBound='163.1'>
                        <om:Property Name='PortName' Value='SendPIPs4B2PODMessage' />
                        <om:Property Name='MessageName' Value='PIPs4B2PODMessageForE2open' />
                        <om:Property Name='OperationName' Value='Operation_1' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Send_PIPs4B2POD' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='896c23e6-4a25-4081-909d-2bc59cf4b367' ParentLink='ComplexStatement_Statement' LowerBound='163.1' HigherBound='178.1'>
                        <om:Property Name='Expression' Value='//&#xD;&#xA;pipInstanceMessageIdFore2open = PIPs4B2PODMessageForE2open(BTS.MessageID);&#xD;&#xA;strPipMessageFore2open  =  Kaifa.B2B.Utility.HeaderHelper.ReturnSCWithDocType(PIPs4B2PODMessageForE2open,&quot;4B2SG0100&quot;);&#xD;&#xA;&#xD;&#xA;System.Diagnostics.Trace.WriteLine(&quot;SubmitRNIF.SubmitMessage To e2open &quot; + pipInstanceMessageIdFore2open + &quot; - &quot; + pipInstanceIdentifierFore2open,&quot;kaifa.b2b&quot;);&#xD;&#xA; SubmitRNIF1.SubmitMessage(Microsoft.Solutions.BTARN.Shared.MessageCategory.AsyncAction,&#xD;&#xA; &quot;KAIFA&quot;,&#xD;&#xA; &quot;E2OPEN&quot;,&#xD;&#xA; &quot;4B2&quot;,&#xD;&#xA; pipInstanceMessageIdFore2open,&#xD;&#xA; &quot;1.0&quot;,&#xD;&#xA; strPipMessageFore2open&#xD;&#xA; );&#xD;&#xA; ' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='InvokeSubmitRNIFAPI' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='011951d3-fb41-464e-b860-cfd5081b2122' ParentLink='ComplexStatement_Statement' LowerBound='178.1' HigherBound='180.1'>
                        <om:Property Name='Expression' Value='Increase = Increase + 1;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Increasing' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='5aa7f74f-f0ac-4d5f-8e08-3af79acfd62f' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Kaifa.B2B.Orchestration.POD.PortType_ReceiveOrderShipmentPODMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceiveOrderShipmentPODMessage' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='75b63614-1a2d-489f-bbef-9b42162e5066' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='30c3d239-b3aa-469a-80be-2599f8f3d795' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Kaifa.B2B.Orchestration.POD.PortType_SendPIPs4B2PODMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendPIPs4B2PODMessage' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='232db51d-669a-4b0d-8216-c37dd59b7831' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='09b9be17-49e5-405b-8b49-18d627203cba' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_ReceiveOrderShipmentPODMessage' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='f5e55f3d-558a-469e-a4b6-cb5a67ca733a' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='857ff27c-a16c-4724-a50a-de832a4887ea' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.51'>
                    <om:Property Name='Ref' Value='Kaifa.B2B.Schemas.Wms.OrderShipmentPOD' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='fba529c7-0f24-436a-bd9c-53e8a9a1e39f' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_SendPIPs4B2PODMessage' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='aa990a97-5923-47a0-9f9a-2f4a9761ff5d' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='2a82375a-546b-4750-9fea-041168e67be5' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.78'>
                    <om:Property Name='Ref' Value='Kaifa.B2B.Schemas.RosettaNet.Pip4B2PODShipmentReceiptNotification' />
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
        public class __POD_Orchestration_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __POD_Orchestration_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "POD_Orchestration")
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
                POD_Orchestration __svc__ = (POD_Orchestration)_service;
                __POD_Orchestration_root_0 __ctx0__ = (__POD_Orchestration_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.SendPIPs4B2PODMessage != null)
                {
                    __svc__.SendPIPs4B2PODMessage.Close(this, null);
                    __svc__.SendPIPs4B2PODMessage = null;
                }
                if (__svc__.ReceiveOrderShipmentPODMessage != null)
                {
                    __svc__.ReceiveOrderShipmentPODMessage.Close(this, null);
                    __svc__.ReceiveOrderShipmentPODMessage = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __POD_Orchestration_1 : Microsoft.XLANGs.Core.LongRunningTransaction
        {
            public __POD_Orchestration_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "POD_Orchestration")
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
                POD_Orchestration __svc__ = (POD_Orchestration)_service;
                __POD_Orchestration_1 __ctx1__ = (__POD_Orchestration_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceMessageIdFore2open = null;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceIdentifierForSTX = null;
                if (__ctx1__ != null && __ctx1__.__CMShipmentPODReport != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CMShipmentPODReport);
                    __ctx1__.__CMShipmentPODReport = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceIdentifierFore2open = null;
                if (__ctx1__ != null)
                    __ctx1__.__strPipMessageFore2open = null;
                if (__ctx1__ != null && __ctx1__.__VendorShipmentPODReport != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__VendorShipmentPODReport);
                    __ctx1__.__VendorShipmentPODReport = null;
                }
                if (__ctx1__ != null && __ctx1__.__PIPs4B2PODMessageForE2open != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__PIPs4B2PODMessageForE2open);
                    __ctx1__.__PIPs4B2PODMessageForE2open = null;
                }
                if (__ctx1__ != null && __ctx1__.__PIPs4B2PODMessageForSTX != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__PIPs4B2PODMessageForSTX);
                    __ctx1__.__PIPs4B2PODMessageForSTX = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__SubmitRNIF1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__SubmitRNIF = null;
                if (__ctx1__ != null)
                    __ctx1__.__CountStr = null;
                if (__ctx1__ != null)
                    __ctx1__.__strPipMessageForSTX = null;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceMessageIdForSTX = null;
                if (__ctx1__ != null && __ctx1__.__OrderShipmentPODMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OrderShipmentPODMessage);
                    __ctx1__.__OrderShipmentPODMessage = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("PIPs4B2PODMessageForE2open")]
            public __messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip4B2PODShipmentReceiptNotification __PIPs4B2PODMessageForE2open;
            [Microsoft.XLANGs.Core.UserVariableAttribute("OrderShipmentPODMessage")]
            public __messagetype_Kaifa_B2B_Schemas_Wms_OrderShipmentPOD __OrderShipmentPODMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("VendorShipmentPODReport")]
            public __messagetype_Kaifa_B2B_Schemas_Wms_VendorShipmentPODReport __VendorShipmentPODReport;
            [Microsoft.XLANGs.Core.UserVariableAttribute("PIPs4B2PODMessageForSTX")]
            public __messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip4B2PODShipmentReceiptNotification __PIPs4B2PODMessageForSTX;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CMShipmentPODReport")]
            public __messagetype_Kaifa_B2B_Schemas_Wms_CMShipmentPODReport __CMShipmentPODReport;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SubmitRNIF1")]
            internal Microsoft.Solutions.BTARN.Shared.SubmitRNIF __SubmitRNIF1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SubmitRNIF")]
            internal Microsoft.Solutions.BTARN.Shared.SubmitRNIF __SubmitRNIF;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strPipMessageForSTX")]
            internal System.String __strPipMessageForSTX;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strPipMessageFore2open")]
            internal System.String __strPipMessageFore2open;
            [Microsoft.XLANGs.Core.UserVariableAttribute("pipInstanceMessageIdForSTX")]
            internal System.String __pipInstanceMessageIdForSTX;
            [Microsoft.XLANGs.Core.UserVariableAttribute("pipInstanceMessageIdFore2open")]
            internal System.String __pipInstanceMessageIdFore2open;
            [Microsoft.XLANGs.Core.UserVariableAttribute("pipInstanceIdentifierForSTX")]
            internal System.String __pipInstanceIdentifierForSTX;
            [Microsoft.XLANGs.Core.UserVariableAttribute("pipInstanceIdentifierFore2open")]
            internal System.String __pipInstanceIdentifierFore2open;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Increase")]
            internal System.Int32 __Increase;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CountStr")]
            internal System.String __CountStr;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Count")]
            internal System.Int32 __Count;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("ReceiveOrderShipmentPODMessage")]
        internal PortType_ReceiveOrderShipmentPODMessage ReceiveOrderShipmentPODMessage;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendPIPs4B2PODMessage")]
        internal PortType_SendPIPs4B2PODMessage SendPIPs4B2PODMessage;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_ReceiveOrderShipmentPODMessage.Operation_1},
                                               typeof(POD_Orchestration).GetField("ReceiveOrderShipmentPODMessage", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(POD_Orchestration), "ReceiveOrderShipmentPODMessage"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_SendPIPs4B2PODMessage.Operation_1},
                                               typeof(POD_Orchestration).GetField("SendPIPs4B2PODMessage", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(POD_Orchestration), "SendPIPs4B2PODMessage"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "c808c561-c197-4d5b-be8a-ba7b03d46f2d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "c808c561-c197-4d5b-be8a-ba7b03d46f2d", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "7159d350-c0b7-4a8c-a672-5096a50f1022", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "7159d350-c0b7-4a8c-a672-5096a50f1022", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "df3a8c55-c591-4049-8b68-eb9dffa3d727", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "ba0c8e18-4aa0-4777-b916-d8924162aba0", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "ba0c8e18-4aa0-4777-b916-d8924162aba0", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "109f5c8d-2dbd-4682-a5d9-551915bd7a8b", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "109f5c8d-2dbd-4682-a5d9-551915bd7a8b", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "f402d79c-ec46-4a6c-936c-9700435024be", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "f402d79c-ec46-4a6c-936c-9700435024be", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "7086426e-0eb6-41e1-aff5-d154a333e016", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "7086426e-0eb6-41e1-aff5-d154a333e016", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "4dfa0e36-091b-42c3-b2f1-0f71e6ec2d6f", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "4dfa0e36-091b-42c3-b2f1-0f71e6ec2d6f", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "a8c750b0-f4f2-4aba-93dc-f62c0af43a20", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "a8c750b0-f4f2-4aba-93dc-f62c0af43a20", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "7f40e50c-9a74-439c-8736-560c0fb16803", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "7f40e50c-9a74-439c-8736-560c0fb16803", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "f642c86a-053f-4b90-b40c-de7a094083e0", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "f642c86a-053f-4b90-b40c-de7a094083e0", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "e07d29d3-c70b-4e24-95be-9a465c980174", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "e07d29d3-c70b-4e24-95be-9a465c980174", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "df3a8c55-c591-4049-8b68-eb9dffa3d727", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(30, "f54876a9-438a-4eab-b1e2-6285179328b9", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(31, "f54876a9-438a-4eab-b1e2-6285179328b9", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(32, "a82ba563-1491-4f15-9274-ccb910701e66", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(33, "fb051358-f561-40e9-882e-5aaaa10554b4", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(34, "fb051358-f561-40e9-882e-5aaaa10554b4", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(35, "b03c01ab-65c3-4d0e-a7a8-bed669ea291e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(36, "b03c01ab-65c3-4d0e-a7a8-bed669ea291e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(37, "40322437-d0c5-4620-875f-2f4b6d1eef45", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(38, "40322437-d0c5-4620-875f-2f4b6d1eef45", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(39, "896c23e6-4a25-4081-909d-2bc59cf4b367", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(40, "896c23e6-4a25-4081-909d-2bc59cf4b367", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(41, "011951d3-fb41-464e-b860-cfd5081b2122", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(42, "011951d3-fb41-464e-b860-cfd5081b2122", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(43, "a82ba563-1491-4f15-9274-ccb910701e66", 1, false)
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
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,2,2,2,2,4,4,5,5,5,6,6,6,7,7,8,9,10,10,27,27,28,29,29,29,30,30,31,31,31,32,32,32,33,33,34,35,35,36,37,37,37,38,39,39,40,40,40,40,41,41,42,43,43,43,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 11,11,12,13,13,13,14,15,15,16,16,16,16,10,};
        public static int[] __progressLocation3 = new int[] { 19,19,20,21,21,21,22,23,23,24,24,24,24,10,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __POD_Orchestration_root_0 __ctx0__ = (__POD_Orchestration_root_0)_stateMgrs[0];
            __POD_Orchestration_1 __ctx1__ = (__POD_Orchestration_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                ReceiveOrderShipmentPODMessage = new PortType_ReceiveOrderShipmentPODMessage(0, this);
                SendPIPs4B2PODMessage = new PortType_SendPIPs4B2PODMessage(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], ReceiveOrderShipmentPODMessage, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __POD_Orchestration_1(this);
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
            __POD_Orchestration_root_0 __ctx0__ = (__POD_Orchestration_root_0)_stateMgrs[0];
            __POD_Orchestration_1 __ctx1__ = (__POD_Orchestration_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__SubmitRNIF1 = default(Microsoft.Solutions.BTARN.Shared.SubmitRNIF);
                __ctx1__.__SubmitRNIF = default(Microsoft.Solutions.BTARN.Shared.SubmitRNIF);
                __ctx1__.__strPipMessageForSTX = default(System.String);
                __ctx1__.__strPipMessageFore2open = default(System.String);
                __ctx1__.__pipInstanceMessageIdForSTX = default(System.String);
                __ctx1__.__pipInstanceMessageIdFore2open = default(System.String);
                __ctx1__.__pipInstanceIdentifierForSTX = default(System.String);
                __ctx1__.__pipInstanceIdentifierFore2open = default(System.String);
                __ctx1__.__Increase = default(System.Int32);
                __ctx1__.__CountStr = default(System.String);
                __ctx1__.__Count = default(System.Int32);
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
                if (!ReceiveOrderShipmentPODMessage.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__OrderShipmentPODMessage != null)
                    __ctx1__.UnrefMessage(__ctx1__.__OrderShipmentPODMessage);
                __ctx1__.__OrderShipmentPODMessage = new __messagetype_Kaifa_B2B_Schemas_Wms_OrderShipmentPOD("OrderShipmentPODMessage", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__OrderShipmentPODMessage);
                ReceiveOrderShipmentPODMessage.ReceiveMessage(0, __msgEnv__, __ctx1__.__OrderShipmentPODMessage, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (ReceiveOrderShipmentPODMessage != null)
                {
                    ReceiveOrderShipmentPODMessage.Close(__ctx1__, __seg__);
                    ReceiveOrderShipmentPODMessage = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__OrderShipmentPODMessage);
                    __edata.PortName = @"ReceiveOrderShipmentPODMessage";
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
                __ctx1__.__SubmitRNIF = new Microsoft.Solutions.BTARN.Shared.SubmitRNIF();
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__strPipMessageForSTX = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__strPipMessageFore2open = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__pipInstanceMessageIdForSTX = "";
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__pipInstanceMessageIdFore2open = "";
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__pipInstanceIdentifierForSTX = "";
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__pipInstanceIdentifierFore2open = "";
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __ctx1__.__CountStr = "";
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
                __ctx1__.__Count = (System.Int32)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__OrderShipmentPODMessage.part, "count(/*[local-name()='OrderShipmentPOD' and namespace-uri()='http://kaifa.b2b.schemas/OrderShipmentPOD']/*[local-name()='VendorShipmentPODReport' and namespace-uri()='http://kaifa.b2b.schemas/OrderShipmentPOD'])", typeof(System.Int32));
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
                    __messagetype_Kaifa_B2B_Schemas_Wms_VendorShipmentPODReport __VendorShipmentPODReport = new __messagetype_Kaifa_B2B_Schemas_Wms_VendorShipmentPODReport("VendorShipmentPODReport", __ctx1__);

                    __ctx1__.__CountStr = __ctx1__.__Increase.ToString();
                    __VendorShipmentPODReport.part.XPathAssign(__ctx1__.__OrderShipmentPODMessage.part, "/*[local-name()='OrderShipmentPOD' and namespace-uri()='http://kaifa.b2b.schemas/OrderShipmentPOD']/*[local-name()='VendorShipmentPODReport' and namespace-uri()='http://kaifa.b2b.schemas/OrderShipmentPOD'][" + __ctx1__.__CountStr + "]");

                    if (__ctx1__.__VendorShipmentPODReport != null)
                        __ctx1__.UnrefMessage(__ctx1__.__VendorShipmentPODReport);
                    __ctx1__.__VendorShipmentPODReport = __VendorShipmentPODReport;
                    __ctx1__.RefMessage(__ctx1__.__VendorShipmentPODReport);
                }
                __ctx1__.__VendorShipmentPODReport.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__VendorShipmentPODReport);
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
                if (__ctx1__ != null && __ctx1__.__VendorShipmentPODReport != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__VendorShipmentPODReport);
                    __ctx1__.__VendorShipmentPODReport = null;
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
                    __ctx1__.__pipInstanceIdentifierForSTX = null;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceMessageIdForSTX = null;
                if (__ctx1__ != null)
                    __ctx1__.__strPipMessageForSTX = null;
                if (__ctx1__ != null)
                    __ctx1__.__SubmitRNIF = null;
                Tracker.FireEvent(__eventLocations[29],__eventData[11],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[30],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                __ctx1__.__Count = (System.Int32)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__OrderShipmentPODMessage.part, "count(/*[local-name()='OrderShipmentPOD' and namespace-uri()='http://kaifa.b2b.schemas/OrderShipmentPOD']/*[local-name()='CMShipmentPODReport' and namespace-uri()='http://kaifa.b2b.schemas/OrderShipmentPOD'])", typeof(System.Int32));
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[31],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                __ctx1__.__CountStr = __ctx1__.__Count.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 38;
            case 38:
                __ctx1__.__Increase = 1;
                if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[32],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 40;
            case 40:
                __condition__ = __ctx1__.__Increase <= __ctx1__.__Count;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 63 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 63;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 41;
            case 41:
                if ( !PreProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[32],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 42;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[33],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 43;
            case 43:
                {
                    __messagetype_Kaifa_B2B_Schemas_Wms_CMShipmentPODReport __CMShipmentPODReport = new __messagetype_Kaifa_B2B_Schemas_Wms_CMShipmentPODReport("CMShipmentPODReport", __ctx1__);

                    __ctx1__.__CountStr = __ctx1__.__Increase.ToString();
                    __CMShipmentPODReport.part.XPathAssign(__ctx1__.__OrderShipmentPODMessage.part, "/*[local-name()='OrderShipmentPOD' and namespace-uri()='http://kaifa.b2b.schemas/OrderShipmentPOD']/*[local-name()='CMShipmentPODReport' and namespace-uri()='http://kaifa.b2b.schemas/OrderShipmentPOD'][" + __ctx1__.__CountStr + "]");

                    if (__ctx1__.__CMShipmentPODReport != null)
                        __ctx1__.UnrefMessage(__ctx1__.__CMShipmentPODReport);
                    __ctx1__.__CMShipmentPODReport = __CMShipmentPODReport;
                    __ctx1__.RefMessage(__ctx1__.__CMShipmentPODReport);
                }
                __ctx1__.__CMShipmentPODReport.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 44;
            case 44:
                if ( !PreProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__CMShipmentPODReport);
                    Tracker.FireEvent(__eventLocations[34],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 45;
            case 45:
                if ( !PreProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[35],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 46;
            case 46:
                {
                    __messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip4B2PODShipmentReceiptNotification __PIPs4B2PODMessageForE2open = new __messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip4B2PODShipmentReceiptNotification("PIPs4B2PODMessageForE2open", __ctx1__);

                    ApplyTransform(typeof(Kaifa.B2B.Mapping.Order_To_4B2POD_e2open_CM), new object[] {__PIPs4B2PODMessageForE2open.part}, new object[] {__ctx1__.__CMShipmentPODReport.part});
                    __ctx1__.__pipInstanceIdentifierFore2open = (System.String)__PIPs4B2PODMessageForE2open.part.GetDistinguishedField("thisDocumentIdentifier.ProprietaryDocumentIdentifier");
                    __PIPs4B2PODMessageForE2open.SetPropertyValue(typeof(FILE.ReceivedFileName), "PODCM_To_e2open＿" + __ctx1__.__pipInstanceIdentifierFore2open + ".xml");

                    if (__ctx1__.__PIPs4B2PODMessageForE2open != null)
                        __ctx1__.UnrefMessage(__ctx1__.__PIPs4B2PODMessageForE2open);
                    __ctx1__.__PIPs4B2PODMessageForE2open = __PIPs4B2PODMessageForE2open;
                    __ctx1__.RefMessage(__ctx1__.__PIPs4B2PODMessageForE2open);
                }
                __ctx1__.__PIPs4B2PODMessageForE2open.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 47;
            case 47:
                if ( !PreProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__PIPs4B2PODMessageForE2open);
                    __edata.Messages.Add(__ctx1__.__CMShipmentPODReport);
                    Tracker.FireEvent(__eventLocations[36],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__CMShipmentPODReport != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CMShipmentPODReport);
                    __ctx1__.__CMShipmentPODReport = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 48;
            case 48:
                if ( !PreProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[37],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 49;
            case 49:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 50;
            case 50:
                if ( !PreProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendPIPs4B2PODMessage.SendMessage(0, __ctx1__.__PIPs4B2PODMessageForE2open, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 51;
            case 51:
                if ( !PreProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__PIPs4B2PODMessageForE2open);
                    __edata.PortName = @"SendPIPs4B2PODMessage";
                    Tracker.FireEvent(__eventLocations[38],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 52;
            case 52:
                if ( !PreProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[39],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 53;
            case 53:
                __ctx1__.__pipInstanceMessageIdFore2open = (System.String)__ctx1__.__PIPs4B2PODMessageForE2open.GetPropertyValueThrows(typeof(BTS.MessageID));
                if ( !PostProgressInc( __seg__, __ctx__, 54 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 54;
            case 54:
                if ( !PreProgressInc( __seg__, __ctx__, 55 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[40],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 55;
            case 55:
                __ctx1__.__strPipMessageFore2open = Kaifa.B2B.Utility.HeaderHelper.ReturnSCWithDocType(__ctx1__.__PIPs4B2PODMessageForE2open.part.TypedValue, "4B2SG0100");
                if ( !PostProgressInc( __seg__, __ctx__, 56 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 56;
            case 56:
                System.Diagnostics.Trace.WriteLine("SubmitRNIF.SubmitMessage To e2open " + __ctx1__.__pipInstanceMessageIdFore2open + " - " + __ctx1__.__pipInstanceIdentifierFore2open, "kaifa.b2b");
                if ( !PostProgressInc( __seg__, __ctx__, 57 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 57;
            case 57:
                __ctx1__.__SubmitRNIF1.SubmitMessage(Microsoft.Solutions.BTARN.Shared.MessageCategory.AsyncAction, "KAIFA", "E2OPEN", "4B2", __ctx1__.__pipInstanceMessageIdFore2open, "1.0", __ctx1__.__strPipMessageFore2open);
                if ( !PostProgressInc( __seg__, __ctx__, 58 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 58;
            case 58:
                if ( !PreProgressInc( __seg__, __ctx__, 59 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[41],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 59;
            case 59:
                __ctx1__.__Increase = __ctx1__.__Increase + 1;
                if ( !PostProgressInc( __seg__, __ctx__, 60 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 60;
            case 60:
                if ( !PreProgressInc( __seg__, __ctx__, 61 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[42],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 61;
            case 61:
                if ( !PreProgressInc( __seg__, __ctx__, 62 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[43],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 62;
            case 62:
                if ( !PostProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 40;
            case 63:
                if ( !PreProgressInc( __seg__, __ctx__, 64 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__CountStr = null;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceIdentifierFore2open = null;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceMessageIdFore2open = null;
                if (__ctx1__ != null)
                    __ctx1__.__strPipMessageFore2open = null;
                if (__ctx1__ != null)
                    __ctx1__.__SubmitRNIF1 = null;
                if (__ctx1__ != null && __ctx1__.__OrderShipmentPODMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OrderShipmentPODMessage);
                    __ctx1__.__OrderShipmentPODMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__PIPs4B2PODMessageForE2open != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__PIPs4B2PODMessageForE2open);
                    __ctx1__.__PIPs4B2PODMessageForE2open = null;
                }
                if (SendPIPs4B2PODMessage != null)
                {
                    SendPIPs4B2PODMessage.Close(__ctx1__, __seg__);
                    SendPIPs4B2PODMessage = null;
                }
                Tracker.FireEvent(__eventLocations[43],__eventData[11],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 64;
            case 64:
                if ( !PreProgressInc( __seg__, __ctx__, 65 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[12],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 65;
            case 65:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 66 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 66;
            case 66:
                if ( !PreProgressInc( __seg__, __ctx__, 67 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 67;
            case 67:
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
            __POD_Orchestration_root_0 __ctx0__ = (__POD_Orchestration_root_0)_stateMgrs[0];
            __POD_Orchestration_1 __ctx1__ = (__POD_Orchestration_1)_stateMgrs[1];

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
                    __messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip4B2PODShipmentReceiptNotification __PIPs4B2PODMessageForSTX = new __messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip4B2PODShipmentReceiptNotification("PIPs4B2PODMessageForSTX", __ctx1__);

                    ApplyTransform(typeof(Kaifa.B2B.Mapping.Order_To_4B2POD_STX), new object[] {__PIPs4B2PODMessageForSTX.part}, new object[] {__ctx1__.__VendorShipmentPODReport.part});
                    __ctx1__.__pipInstanceIdentifierForSTX = (System.String)__PIPs4B2PODMessageForSTX.part.GetDistinguishedField("thisDocumentIdentifier.ProprietaryDocumentIdentifier");
                    __PIPs4B2PODMessageForSTX.SetPropertyValue(typeof(FILE.ReceivedFileName), "POD_To_STX＿" + __ctx1__.__pipInstanceIdentifierForSTX + ".xml");

                    if (__ctx1__.__PIPs4B2PODMessageForSTX != null)
                        __ctx1__.UnrefMessage(__ctx1__.__PIPs4B2PODMessageForSTX);
                    __ctx1__.__PIPs4B2PODMessageForSTX = __PIPs4B2PODMessageForSTX;
                    __ctx1__.RefMessage(__ctx1__.__PIPs4B2PODMessageForSTX);
                }
                __ctx1__.__PIPs4B2PODMessageForSTX.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__PIPs4B2PODMessageForSTX);
                    __edata.Messages.Add(__ctx1__.__VendorShipmentPODReport);
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
                SendPIPs4B2PODMessage.SendMessage(0, __ctx1__.__PIPs4B2PODMessageForSTX, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__PIPs4B2PODMessageForSTX);
                    __edata.PortName = @"SendPIPs4B2PODMessage";
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
                __ctx1__.__pipInstanceMessageIdForSTX = (System.String)__ctx1__.__PIPs4B2PODMessageForSTX.GetPropertyValueThrows(typeof(BTS.MessageID));
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
                __ctx1__.__strPipMessageForSTX = Kaifa.B2B.Utility.HeaderHelper.ReturnSCWithDocType(__ctx1__.__PIPs4B2PODMessageForSTX.part.TypedValue, "4B2SG0100");
                if (__ctx1__ != null && __ctx1__.__PIPs4B2PODMessageForSTX != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__PIPs4B2PODMessageForSTX);
                    __ctx1__.__PIPs4B2PODMessageForSTX = null;
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
                __ctx1__.__SubmitRNIF.SubmitMessage(Microsoft.Solutions.BTARN.Shared.MessageCategory.AsyncAction, "KAIFA", "SEAGATE-US", "4B2", __ctx1__.__pipInstanceMessageIdForSTX, "1.0", __ctx1__.__strPipMessageForSTX);
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
            __POD_Orchestration_root_0 __ctx0__ = (__POD_Orchestration_root_0)_stateMgrs[0];
            __POD_Orchestration_1 __ctx1__ = (__POD_Orchestration_1)_stateMgrs[1];

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
                    __messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip4B2PODShipmentReceiptNotification __PIPs4B2PODMessageForE2open = new __messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip4B2PODShipmentReceiptNotification("PIPs4B2PODMessageForE2open", __ctx1__);

                    ApplyTransform(typeof(Kaifa.B2B.Mapping.Order_To_4B2POD_e2open), new object[] {__PIPs4B2PODMessageForE2open.part}, new object[] {__ctx1__.__VendorShipmentPODReport.part});
                    __ctx1__.__pipInstanceIdentifierFore2open = (System.String)__PIPs4B2PODMessageForE2open.part.GetDistinguishedField("thisDocumentIdentifier.ProprietaryDocumentIdentifier");
                    __PIPs4B2PODMessageForE2open.SetPropertyValue(typeof(FILE.ReceivedFileName), "POD_To_e2open＿" + __ctx1__.__pipInstanceIdentifierFore2open + ".xml");

                    if (__ctx1__.__PIPs4B2PODMessageForE2open != null)
                        __ctx1__.UnrefMessage(__ctx1__.__PIPs4B2PODMessageForE2open);
                    __ctx1__.__PIPs4B2PODMessageForE2open = __PIPs4B2PODMessageForE2open;
                    __ctx1__.RefMessage(__ctx1__.__PIPs4B2PODMessageForE2open);
                }
                __ctx1__.__PIPs4B2PODMessageForE2open.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__PIPs4B2PODMessageForE2open);
                    __edata.Messages.Add(__ctx1__.__VendorShipmentPODReport);
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
                SendPIPs4B2PODMessage.SendMessage(0, __ctx1__.__PIPs4B2PODMessageForE2open, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__PIPs4B2PODMessageForE2open);
                    __edata.PortName = @"SendPIPs4B2PODMessage";
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
                __ctx1__.__pipInstanceMessageIdFore2open = (System.String)__ctx1__.__PIPs4B2PODMessageForE2open.GetPropertyValueThrows(typeof(BTS.MessageID));
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
                __ctx1__.__strPipMessageFore2open = Kaifa.B2B.Utility.HeaderHelper.ReturnSCWithDocType(__ctx1__.__PIPs4B2PODMessageForE2open.part.TypedValue, "4B2SG0100");
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                System.Diagnostics.Trace.WriteLine("SubmitRNIF.SubmitMessage To e2open " + __ctx1__.__pipInstanceMessageIdFore2open + " - " + __ctx1__.__pipInstanceIdentifierFore2open, "kaifa.b2b");
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__SubmitRNIF1.SubmitMessage(Microsoft.Solutions.BTARN.Shared.MessageCategory.AsyncAction, "KAIFA", "E2OPEN", "4B2", __ctx1__.__pipInstanceMessageIdFore2open, "1.0", __ctx1__.__strPipMessageFore2open);
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
    sealed public class __Kaifa_B2B_Schemas_Wms_OrderShipmentPOD__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.Schemas.Wms.OrderShipmentPOD _schema = new Kaifa.B2B.Schemas.Wms.OrderShipmentPOD();

        public __Kaifa_B2B_Schemas_Wms_OrderShipmentPOD__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Kaifa.B2B.Schemas.Wms.OrderShipmentPOD",
        new System.Type[]{
            typeof(Kaifa.B2B.Schemas.Wms.OrderShipmentPOD)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_Schemas_Wms_OrderShipmentPOD__)
        },
        0,
        @"http://kaifa.b2b.schemas/OrderShipmentPOD#OrderShipmentPOD"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Kaifa_B2B_Schemas_Wms_OrderShipmentPOD : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_Schemas_Wms_OrderShipmentPOD__ part;

        private void __CreatePartWrappers()
        {
            part = new __Kaifa_B2B_Schemas_Wms_OrderShipmentPOD__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Kaifa_B2B_Schemas_Wms_OrderShipmentPOD(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Kaifa_B2B_Schemas_RosettaNet_Pip4B2PODShipmentReceiptNotification__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.Schemas.RosettaNet.Pip4B2PODShipmentReceiptNotification _schema = new Kaifa.B2B.Schemas.RosettaNet.Pip4B2PODShipmentReceiptNotification();

        public __Kaifa_B2B_Schemas_RosettaNet_Pip4B2PODShipmentReceiptNotification__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Kaifa.B2B.Schemas.RosettaNet.Pip4B2PODShipmentReceiptNotification",
        new System.Type[]{
            typeof(Kaifa.B2B.Schemas.RosettaNet.Pip4B2PODShipmentReceiptNotification)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_Schemas_RosettaNet_Pip4B2PODShipmentReceiptNotification__)
        },
        0,
        @"http://kaifa.b2b.schemas/Pip4B2PODShipmentReceiptNotification#Pip4B2ShipmentReceiptNotification"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip4B2PODShipmentReceiptNotification : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_Schemas_RosettaNet_Pip4B2PODShipmentReceiptNotification__ part;

        private void __CreatePartWrappers()
        {
            part = new __Kaifa_B2B_Schemas_RosettaNet_Pip4B2PODShipmentReceiptNotification__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip4B2PODShipmentReceiptNotification(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Kaifa_B2B_Schemas_Wms_VendorShipmentPODReport__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.Schemas.Wms.VendorShipmentPODReport _schema = new Kaifa.B2B.Schemas.Wms.VendorShipmentPODReport();

        public __Kaifa_B2B_Schemas_Wms_VendorShipmentPODReport__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Kaifa.B2B.Schemas.Wms.VendorShipmentPODReport",
        new System.Type[]{
            typeof(Kaifa.B2B.Schemas.Wms.VendorShipmentPODReport)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_Schemas_Wms_VendorShipmentPODReport__)
        },
        0,
        @"http://kaifa.b2b.schemas/OrderShipmentPOD#VendorShipmentPODReport"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Kaifa_B2B_Schemas_Wms_VendorShipmentPODReport : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_Schemas_Wms_VendorShipmentPODReport__ part;

        private void __CreatePartWrappers()
        {
            part = new __Kaifa_B2B_Schemas_Wms_VendorShipmentPODReport__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Kaifa_B2B_Schemas_Wms_VendorShipmentPODReport(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Kaifa_B2B_Schemas_Wms_CMShipmentPODReport__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.Schemas.Wms.CMShipmentPODReport _schema = new Kaifa.B2B.Schemas.Wms.CMShipmentPODReport();

        public __Kaifa_B2B_Schemas_Wms_CMShipmentPODReport__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Kaifa.B2B.Schemas.Wms.CMShipmentPODReport",
        new System.Type[]{
            typeof(Kaifa.B2B.Schemas.Wms.CMShipmentPODReport)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_Schemas_Wms_CMShipmentPODReport__)
        },
        0,
        @"http://kaifa.b2b.schemas/OrderShipmentPOD#CMShipmentPODReport"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Kaifa_B2B_Schemas_Wms_CMShipmentPODReport : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_Schemas_Wms_CMShipmentPODReport__ part;

        private void __CreatePartWrappers()
        {
            part = new __Kaifa_B2B_Schemas_Wms_CMShipmentPODReport__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Kaifa_B2B_Schemas_Wms_CMShipmentPODReport(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
