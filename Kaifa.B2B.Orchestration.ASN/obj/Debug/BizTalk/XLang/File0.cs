
#pragma warning disable 162

namespace Kaifa.B2B.Orchestration.ASN
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Kaifa.B2B.Orchestration.ASN.__messagetype_Kaifa_B2B_Schemas_Wms_OrderShipment)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_ReceiveOrderShipmentMessage : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_ReceiveOrderShipmentMessage(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_ReceiveOrderShipmentMessage(PortType_ReceiveOrderShipmentMessage p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_ReceiveOrderShipmentMessage p = new PortType_ReceiveOrderShipmentMessage(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_ReceiveOrderShipmentMessage),
            typeof(__messagetype_Kaifa_B2B_Schemas_Wms_OrderShipment),
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
            typeof(Kaifa.B2B.Orchestration.ASN.__messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip3B2AdvanceShipmentNotification)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_SendPip3B2Message : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_SendPip3B2Message(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_SendPip3B2Message(PortType_SendPip3B2Message p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_SendPip3B2Message p = new PortType_SendPip3B2Message(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_SendPip3B2Message),
            typeof(__messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip3B2AdvanceShipmentNotification),
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
    //#line 393 "D:\长城开发项目\SourceCode\Kaifa.B2B.Solution\Kaifa.B2B.Orchestration.ASN\ASN.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "ReceiveOrderShipmentMessage", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Kaifa.B2B.Orchestration.ASN.PortType_ReceiveOrderShipmentMessage),
            typeof(Kaifa.B2B.Orchestration.ASN.PortType_SendPip3B2Message)
        },
        new System.String[] {
            "ReceiveOrderShipmentMessage",
            "SendPip3B2Message"
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
    sealed internal class ASN_Orchestration : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(ASN_Orchestration));
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

        static ASN_Orchestration()
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
            _rootContext = new __ASN_Orchestration_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public ASN_Orchestration(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "ASN_Orchestration", tracker)
        {
            ConstructorHelper();
        }

        public ASN_Orchestration(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "ASN_Orchestration")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>18cd775c-78e2-4dd4-95ce-3e359355f3e7</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>a804b5d6-7a43-45f9-8028-b9e754308a5e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ReceiveOrderShipmentMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>254a1071-3dc7-4c3b-bdfe-3cc0b2eb38dc</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>HasASICMessages</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>21bcb9df-1f56-44b9-8267-8d044638b8f5</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Decide_ASIC</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>8f83c3d1-a7de-4dfb-b72a-a2570550afdf</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Has ASIC</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>9bfc8034-ee26-43e6-bb5c-45a0e4ade0d9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_Pip3B2_STX</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>dde8bb98-5b07-4c0e-ae1a-edda9bf94735</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>f8ff329d-8a0e-4dd4-b316-06b29b673640</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_to_STX</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>5cb2cf2a-1141-42f2-8af3-4a5f2bd5204e</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>0cd4d646-d456-4a2e-afec-e7eb9ac9cdc3</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>5c2d5c70-fb45-4dce-895b-03950e2861e2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>1cc8eb7b-e23b-4782-bf22-2c235fab2d65</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_Pip3B2Message</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>d1453bcf-f0d5-4eb8-b09d-e67c38afb6e8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>InvokeSubmitRNIFAPI</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>afce82e0-a35d-43d9-8c4d-d6f72d871766</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>09543bd5-8221-43ce-9f21-648582ff2300</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>GetCount</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>WhileShape</shapeType>      <ShapeID>4893a3f7-0cac-4491-856b-53d8ef2e53ed</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Loop_SplitOrderShipmentMessage</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>25c3a17b-f5e6-46e7-b217-e4ba9648469f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_VendorShipmentMessage</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>4f476deb-6bfb-4917-9d12-db95bdd28f3a</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>fef09f37-a621-423d-b6cf-a087def3c129</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>5e341544-225f-4604-a396-645ee3631bb5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_Pip3B2_e2open</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>64dafa56-0b96-4122-aa75-7d265acea232</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>536d7e93-96e8-476d-890b-031e0d8dbf52</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_to_e2open</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>4a9da621-6c64-4260-a847-3be821383167</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>01c26271-b3ec-491d-a6b8-874c7556a2fd</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>545e151f-dbb2-430b-aa94-5a5a69daf9c2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>e497b078-67c6-4dd2-b065-b42b4650bd94</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_Pip3B2Message</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>9dddb456-6ac4-49ce-b66b-e968de7b59f4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>InvokeSubmitRNIFAPI</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>95adbe76-d01c-4a72-9e75-3803800001fd</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Increasing</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'ASN_Orchestration'</ActionName><IsAtomic>0</IsAtomic><Line>393</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>417</Line><Position>22</Position><ShapeID>'a804b5d6-7a43-45f9-8028-b9e754308a5e'</ShapeID>
<Messages>
	<MsgInfo><name>OrderShipmentMessage</name><part>part</part><schema>Kaifa.B2B.Schemas.Wms.OrderShipment</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>427</Line><Position>18</Position><ShapeID>'254a1071-3dc7-4c3b-bdfe-3cc0b2eb38dc'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>429</Line><Position>13</Position><ShapeID>'21bcb9df-1f56-44b9-8267-8d044638b8f5'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>432</Line><Position>17</Position><ShapeID>'9bfc8034-ee26-43e6-bb5c-45a0e4ade0d9'</ShapeID>
<Messages>
	<MsgInfo><name>Pip3B2MessageForSTX</name><part>part</part><schema>Kaifa.B2B.Schemas.RosettaNet.Pip3B2AdvanceShipmentNotification</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>OrderShipmentMessage</name><part>part</part><schema>Kaifa.B2B.Schemas.Wms.OrderShipment</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>442</Line><Position>17</Position><ShapeID>'1cc8eb7b-e23b-4782-bf22-2c235fab2d65'</ShapeID>
<Messages>
	<MsgInfo><name>Pip3B2MessageForSTX</name><part>part</part><schema>Kaifa.B2B.Schemas.RosettaNet.Pip3B2AdvanceShipmentNotification</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>445</Line><Position>44</Position><ShapeID>'d1453bcf-f0d5-4eb8-b09d-e67c38afb6e8'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>460</Line><Position>19</Position><ShapeID>'09543bd5-8221-43ce-9f21-648582ff2300'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>464</Line><Position>13</Position><ShapeID>'4893a3f7-0cac-4491-856b-53d8ef2e53ed'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>467</Line><Position>17</Position><ShapeID>'25c3a17b-f5e6-46e7-b217-e4ba9648469f'</ShapeID>
<Messages>
	<MsgInfo><name>VendorShipmentReportMessage</name><part>part</part><schema>Kaifa.B2B.Schemas.Wms.VendorShipmentReport</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>474</Line><Position>17</Position><ShapeID>'5e341544-225f-4604-a396-645ee3631bb5'</ShapeID>
<Messages>
	<MsgInfo><name>Pip3B2MessageForE2open</name><part>part</part><schema>Kaifa.B2B.Schemas.RosettaNet.Pip3B2AdvanceShipmentNotification</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>VendorShipmentReportMessage</name><part>part</part><schema>Kaifa.B2B.Schemas.Wms.VendorShipmentReport</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>484</Line><Position>17</Position><ShapeID>'e497b078-67c6-4dd2-b065-b42b4650bd94'</ShapeID>
<Messages>
	<MsgInfo><name>Pip3B2MessageForE2open</name><part>part</part><schema>Kaifa.B2B.Schemas.RosettaNet.Pip3B2AdvanceShipmentNotification</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>487</Line><Position>47</Position><ShapeID>'9dddb456-6ac4-49ce-b66b-e968de7b59f4'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>500</Line><Position>26</Position><ShapeID>'95adbe76-d01c-4a72-9e75-3803800001fd'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='922ec423-f9f0-46f7-8c3b-118ff1153329' LowerBound='1.1' HigherBound='131.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Kaifa.B2B.Orchestration.ASN' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='6a49eabd-ed2d-465c-8620-1cd4f628827c' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_ReceiveOrderShipmentMessage' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='b35c0352-7529-4e91-8171-b3c4cd0326cc' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='cbfacd17-5ebd-40e6-bf98-6e812fc48088' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.48'>
                    <om:Property Name='Ref' Value='Kaifa.B2B.Schemas.Wms.OrderShipment' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='fc5977a9-d73d-4528-9b6c-16e29d5ec5be' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_SendPip3B2Message' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='5a001dea-a152-490e-8965-4edcdbc08c28' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='14828ea6-a297-47a0-9694-4bec19af56cf' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.75'>
                    <om:Property Name='Ref' Value='Kaifa.B2B.Schemas.RosettaNet.Pip3B2AdvanceShipmentNotification' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='2baa63b8-dd0d-4312-bce4-6644f193e3dd' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='130.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ASN_Orchestration' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='69a657da-94ca-473f-ad05-fa08b81bcd4b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='Microsoft.Solutions.BTARN.Shared.SubmitRNIF' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SubmitRNIF' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='898e9363-81f1-4525-ac3a-07beaecff826' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strPipMessageForSTX' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='dd958a78-4e5d-4f6b-9ae9-34739c4ebfc9' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='31.1' HigherBound='32.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strPipMessageFore2open' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='601e90b6-bb27-4ec4-a66d-c3337e4b605b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='32.1' HigherBound='33.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='pipInstanceMessageIdForSTX' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='81de8073-d9de-494b-bb07-765e1b28df66' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='33.1' HigherBound='34.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='pipInstanceMessageIdFore2open' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='0468bc00-40b0-444f-9ce2-e442431bb12f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='pipInstanceIdentifierForSTX' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='9ced1986-9037-4b8a-8151-df4f6bb1c25b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='35.1' HigherBound='36.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='pipInstanceIdentifierFore2open' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8d50434d-4339-48ff-9d21-4cdbce0dec7d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='36.1' HigherBound='37.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Increase' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='e8a82767-7568-4139-bed3-f13aa6b4f493' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='37.1' HigherBound='38.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CountStr' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='95623643-1b42-464e-b13f-88ad28a653c0' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='38.1' HigherBound='39.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Count' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='2f62cdf1-b193-41ec-9ff1-09a07eb19123' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='39.1' HigherBound='40.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ASIC' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='55636797-b128-4f4e-ba8f-4108d36bd591' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas.Wms.OrderShipment' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OrderShipmentMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='9e70b3bd-1715-408d-bc6f-b57bc1746bb7' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas.Wms.VendorShipmentReport' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='VendorShipmentReportMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='3be69d25-37b3-4873-97a6-2a9caeb4e248' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas.RosettaNet.Pip3B2AdvanceShipmentNotification' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Pip3B2MessageForSTX' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='558d625f-c642-463e-bd61-df43a542bb9e' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas.RosettaNet.Pip3B2AdvanceShipmentNotification' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Pip3B2MessageForE2open' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='18cd775c-78e2-4dd4-95ce-3e359355f3e7' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='a804b5d6-7a43-45f9-8028-b9e754308a5e' ParentLink='ServiceBody_Statement' LowerBound='42.1' HigherBound='52.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='ReceiveOrderShipmentMessage' />
                    <om:Property Name='MessageName' Value='OrderShipmentMessage' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ReceiveOrderShipmentMessage' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='254a1071-3dc7-4c3b-bdfe-3cc0b2eb38dc' ParentLink='ServiceBody_Statement' LowerBound='52.1' HigherBound='54.1'>
                    <om:Property Name='Expression' Value='ASIC = xpath(OrderShipmentMessage, &quot;count(/*[local-name()=&apos;OrderShipment&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/OrderShipment&apos;]/*[local-name()=&apos;ASIC&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/OrderShipment&apos;])&quot;); ' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='HasASICMessages' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Decision' OID='21bcb9df-1f56-44b9-8267-8d044638b8f5' ParentLink='ServiceBody_Statement' LowerBound='54.1' HigherBound='85.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Decide_ASIC' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DecisionBranch' OID='8f83c3d1-a7de-4dfb-b72a-a2570550afdf' ParentLink='ReallyComplexStatement_Branch' LowerBound='55.13' HigherBound='85.1'>
                        <om:Property Name='Expression' Value='ASIC&gt;0' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Has ASIC' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Construct' OID='9bfc8034-ee26-43e6-bb5c-45a0e4ade0d9' ParentLink='ComplexStatement_Statement' LowerBound='57.1' HigherBound='67.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_Pip3B2_STX' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageRef' OID='dde8bb98-5b07-4c0e-ae1a-edda9bf94735' ParentLink='Construct_MessageRef' LowerBound='58.27' HigherBound='58.46'>
                                <om:Property Name='Ref' Value='Pip3B2MessageForSTX' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Transform' OID='f8ff329d-8a0e-4dd4-b316-06b29b673640' ParentLink='ComplexStatement_Statement' LowerBound='60.1' HigherBound='62.1'>
                                <om:Property Name='ClassName' Value='Kaifa.B2B.Mapping.Order_To_3B2_STX_ASIC' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Transform_to_STX' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessagePartRef' OID='5cb2cf2a-1141-42f2-8af3-4a5f2bd5204e' ParentLink='Transform_OutputMessagePartRef' LowerBound='61.32' HigherBound='61.51'>
                                    <om:Property Name='MessageRef' Value='Pip3B2MessageForSTX' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_4' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='0cd4d646-d456-4a2e-afec-e7eb9ac9cdc3' ParentLink='Transform_InputMessagePartRef' LowerBound='61.96' HigherBound='61.116'>
                                    <om:Property Name='MessageRef' Value='OrderShipmentMessage' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_3' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageAssignment' OID='5c2d5c70-fb45-4dce-895b-03950e2861e2' ParentLink='ComplexStatement_Statement' LowerBound='62.1' HigherBound='66.1'>
                                <om:Property Name='Expression' Value='pipInstanceIdentifierForSTX =  Pip3B2MessageForSTX.thisDocumentIdentifier.ProprietaryDocumentIdentifier;&#xD;&#xA;Pip3B2MessageForSTX(FILE.ReceivedFileName) = &quot;ASN_To_STX＿&quot;  + pipInstanceIdentifierForSTX + &quot;.xml&quot;;&#xD;&#xA;//pipInstanceMessageIdFore2open = Pip4B2MessageForE2Open(BTS.MessageID);' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='MessageAssignment_3' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='1cc8eb7b-e23b-4782-bf22-2c235fab2d65' ParentLink='ComplexStatement_Statement' LowerBound='67.1' HigherBound='69.1'>
                            <om:Property Name='PortName' Value='SendPip3B2Message' />
                            <om:Property Name='MessageName' Value='Pip3B2MessageForSTX' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_Pip3B2Message' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='d1453bcf-f0d5-4eb8-b09d-e67c38afb6e8' ParentLink='ComplexStatement_Statement' LowerBound='69.1' HigherBound='84.1'>
                            <om:Property Name='Expression' Value='//&#xD;&#xA;pipInstanceMessageIdForSTX = Pip3B2MessageForSTX(BTS.MessageID);&#xD;&#xA;strPipMessageForSTX  =  Kaifa.B2B.Utility.HeaderHelper.ReturnSCWithDocType(Pip3B2MessageForSTX,&quot;3B2SG0100&quot;);&#xD;&#xA;System.Diagnostics.Trace.WriteLine(&quot;SubmitRNIF.SubmitMessage To STX &quot; + pipInstanceMessageIdForSTX + &quot; - &quot; + pipInstanceIdentifierForSTX,&quot;kaifa.b2b&quot;);&#xD;&#xA; SubmitRNIF.SubmitMessage(Microsoft.Solutions.BTARN.Shared.MessageCategory.AsyncAction,&#xD;&#xA; &quot;KAIFA&quot;,&#xD;&#xA; &quot;SEAGATE-US&quot;,&#xD;&#xA; &quot;3B2&quot;,&#xD;&#xA; pipInstanceIdentifierForSTX,&#xD;&#xA; &quot;V01.00&quot;,&#xD;&#xA;  strPipMessageForSTX&#xD;&#xA;);&#xD;&#xA;&#xD;&#xA; ' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='InvokeSubmitRNIFAPI' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='afce82e0-a35d-43d9-8c4d-d6f72d871766' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='VariableAssignment' OID='09543bd5-8221-43ce-9f21-648582ff2300' ParentLink='ServiceBody_Statement' LowerBound='85.1' HigherBound='89.1'>
                    <om:Property Name='Expression' Value='Count = xpath(OrderShipmentMessage, &quot;count(/*[local-name()=&apos;OrderShipment&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/OrderShipment&apos;]/*[local-name()=&apos;VendorShipmentReport&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/OrderShipment&apos;])&quot;); &#xD;&#xA;CountStr = Count.ToString();&#xD;&#xA;Increase = 1;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='GetCount' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='While' OID='4893a3f7-0cac-4491-856b-53d8ef2e53ed' ParentLink='ServiceBody_Statement' LowerBound='89.1' HigherBound='128.1'>
                    <om:Property Name='Expression' Value='Increase&lt;=Count ' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Loop_SplitOrderShipmentMessage' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Construct' OID='25c3a17b-f5e6-46e7-b217-e4ba9648469f' ParentLink='ComplexStatement_Statement' LowerBound='92.1' HigherBound='99.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructMessage_VendorShipmentMessage' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageRef' OID='4f476deb-6bfb-4917-9d12-db95bdd28f3a' ParentLink='Construct_MessageRef' LowerBound='93.27' HigherBound='93.54'>
                            <om:Property Name='Ref' Value='VendorShipmentReportMessage' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageAssignment' OID='fef09f37-a621-423d-b6cf-a087def3c129' ParentLink='ComplexStatement_Statement' LowerBound='95.1' HigherBound='98.1'>
                            <om:Property Name='Expression' Value='CountStr = Increase.ToString();&#xD;&#xA;VendorShipmentReportMessage =  xpath(OrderShipmentMessage, &quot;/*[local-name()=&apos;OrderShipment&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/OrderShipment&apos;]/*[local-name()=&apos;VendorShipmentReport&apos; and namespace-uri()=&apos;http://kaifa.b2b.schemas/OrderShipment&apos;][&quot; + CountStr + &quot;]&quot;);' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='MessageAssignment_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Construct' OID='5e341544-225f-4604-a396-645ee3631bb5' ParentLink='ComplexStatement_Statement' LowerBound='99.1' HigherBound='109.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructMessage_Pip3B2_e2open' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageRef' OID='64dafa56-0b96-4122-aa75-7d265acea232' ParentLink='Construct_MessageRef' LowerBound='100.27' HigherBound='100.49'>
                            <om:Property Name='Ref' Value='Pip3B2MessageForE2open' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Transform' OID='536d7e93-96e8-476d-890b-031e0d8dbf52' ParentLink='ComplexStatement_Statement' LowerBound='102.1' HigherBound='104.1'>
                            <om:Property Name='ClassName' Value='Kaifa.B2B.Mapping.Order_To_3B2_e2open' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Transform_to_e2open' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='MessagePartRef' OID='4a9da621-6c64-4260-a847-3be821383167' ParentLink='Transform_InputMessagePartRef' LowerBound='103.97' HigherBound='103.124'>
                                <om:Property Name='MessageRef' Value='VendorShipmentReportMessage' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_1' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='01c26271-b3ec-491d-a6b8-874c7556a2fd' ParentLink='Transform_OutputMessagePartRef' LowerBound='103.32' HigherBound='103.54'>
                                <om:Property Name='MessageRef' Value='Pip3B2MessageForE2open' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_2' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='MessageAssignment' OID='545e151f-dbb2-430b-aa94-5a5a69daf9c2' ParentLink='ComplexStatement_Statement' LowerBound='104.1' HigherBound='108.1'>
                            <om:Property Name='Expression' Value='pipInstanceIdentifierFore2open =  Pip3B2MessageForE2open.thisDocumentIdentifier.ProprietaryDocumentIdentifier;&#xD;&#xA;Pip3B2MessageForE2open(FILE.ReceivedFileName) = &quot;ASN_To_e2open＿&quot;  + pipInstanceIdentifierFore2open + &quot;.xml&quot;;&#xD;&#xA;//pipInstanceMessageIdFore2open = Pip4B2MessageForE2Open(BTS.MessageID);' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='MessageAssignment_3' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Send' OID='e497b078-67c6-4dd2-b065-b42b4650bd94' ParentLink='ComplexStatement_Statement' LowerBound='109.1' HigherBound='111.1'>
                        <om:Property Name='PortName' Value='SendPip3B2Message' />
                        <om:Property Name='MessageName' Value='Pip3B2MessageForE2open' />
                        <om:Property Name='OperationName' Value='Operation_1' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Send_Pip3B2Message' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='9dddb456-6ac4-49ce-b66b-e968de7b59f4' ParentLink='ComplexStatement_Statement' LowerBound='111.1' HigherBound='125.1'>
                        <om:Property Name='Expression' Value='//&#xD;&#xA;pipInstanceMessageIdFore2open = Pip3B2MessageForE2open(BTS.MessageID);&#xD;&#xA;strPipMessageFore2open  =  Kaifa.B2B.Utility.HeaderHelper.ReturnSCWithDocType(Pip3B2MessageForE2open,&quot;3B2SG0100&quot;);&#xD;&#xA;&#xD;&#xA;System.Diagnostics.Trace.WriteLine(&quot;SubmitRNIF.SubmitMessage To e2open &quot; + pipInstanceMessageIdFore2open + &quot; - &quot; + pipInstanceIdentifierFore2open,&quot;kaifa.b2b&quot;);&#xD;&#xA; SubmitRNIF.SubmitMessage(Microsoft.Solutions.BTARN.Shared.MessageCategory.AsyncAction,&#xD;&#xA; &quot;KAIFA&quot;,&#xD;&#xA; &quot;E2OPEN&quot;,&#xD;&#xA; &quot;3B2&quot;,&#xD;&#xA; pipInstanceIdentifierFore2open,&#xD;&#xA; &quot;V01.00&quot;,&#xD;&#xA;  strPipMessageFore2open&#xD;&#xA;);&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='InvokeSubmitRNIFAPI' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='95adbe76-d01c-4a72-9e75-3803800001fd' ParentLink='ComplexStatement_Statement' LowerBound='125.1' HigherBound='127.1'>
                        <om:Property Name='Expression' Value='Increase = Increase + 1;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Increasing' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='70bbc23e-4820-4f47-8a32-45c7243237a3' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Kaifa.B2B.Orchestration.ASN.PortType_ReceiveOrderShipmentMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceiveOrderShipmentMessage' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='549c0714-1949-4a97-8a79-704d2f1abb77' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='444397f4-e69c-4141-aacd-ce735f5ba6ef' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Kaifa.B2B.Orchestration.ASN.PortType_SendPip3B2Message' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendPip3B2Message' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='9e28215e-0d40-42cc-842f-7bdde6e2f269' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __ASN_Orchestration_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __ASN_Orchestration_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ASN_Orchestration")
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
                ASN_Orchestration __svc__ = (ASN_Orchestration)_service;
                __ASN_Orchestration_root_0 __ctx0__ = (__ASN_Orchestration_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.ReceiveOrderShipmentMessage != null)
                {
                    __svc__.ReceiveOrderShipmentMessage.Close(this, null);
                    __svc__.ReceiveOrderShipmentMessage = null;
                }
                if (__svc__.SendPip3B2Message != null)
                {
                    __svc__.SendPip3B2Message.Close(this, null);
                    __svc__.SendPip3B2Message = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __ASN_Orchestration_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __ASN_Orchestration_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ASN_Orchestration")
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
                ASN_Orchestration __svc__ = (ASN_Orchestration)_service;
                __ASN_Orchestration_1 __ctx1__ = (__ASN_Orchestration_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__strPipMessageForSTX = null;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceMessageIdFore2open = null;
                if (__ctx1__ != null)
                    __ctx1__.__strPipMessageFore2open = null;
                if (__ctx1__ != null)
                    __ctx1__.__CountStr = null;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceIdentifierForSTX = null;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceIdentifierFore2open = null;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceMessageIdForSTX = null;
                if (__ctx1__ != null && __ctx1__.__Pip3B2MessageForSTX != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Pip3B2MessageForSTX);
                    __ctx1__.__Pip3B2MessageForSTX = null;
                }
                if (__ctx1__ != null && __ctx1__.__VendorShipmentReportMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__VendorShipmentReportMessage);
                    __ctx1__.__VendorShipmentReportMessage = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__SubmitRNIF = null;
                if (__ctx1__ != null && __ctx1__.__OrderShipmentMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OrderShipmentMessage);
                    __ctx1__.__OrderShipmentMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__Pip3B2MessageForE2open != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Pip3B2MessageForE2open);
                    __ctx1__.__Pip3B2MessageForE2open = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("OrderShipmentMessage")]
            public __messagetype_Kaifa_B2B_Schemas_Wms_OrderShipment __OrderShipmentMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("VendorShipmentReportMessage")]
            public __messagetype_Kaifa_B2B_Schemas_Wms_VendorShipmentReport __VendorShipmentReportMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Pip3B2MessageForSTX")]
            public __messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip3B2AdvanceShipmentNotification __Pip3B2MessageForSTX;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Pip3B2MessageForE2open")]
            public __messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip3B2AdvanceShipmentNotification __Pip3B2MessageForE2open;
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
            [Microsoft.XLANGs.Core.UserVariableAttribute("ASIC")]
            internal System.Int32 __ASIC;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("ReceiveOrderShipmentMessage")]
        internal PortType_ReceiveOrderShipmentMessage ReceiveOrderShipmentMessage;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendPip3B2Message")]
        internal PortType_SendPip3B2Message SendPip3B2Message;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_ReceiveOrderShipmentMessage.Operation_1},
                                               typeof(ASN_Orchestration).GetField("ReceiveOrderShipmentMessage", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ASN_Orchestration), "ReceiveOrderShipmentMessage"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_SendPip3B2Message.Operation_1},
                                               typeof(ASN_Orchestration).GetField("SendPip3B2Message", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ASN_Orchestration), "SendPip3B2Message"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "a804b5d6-7a43-45f9-8028-b9e754308a5e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "a804b5d6-7a43-45f9-8028-b9e754308a5e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "254a1071-3dc7-4c3b-bdfe-3cc0b2eb38dc", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "254a1071-3dc7-4c3b-bdfe-3cc0b2eb38dc", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "21bcb9df-1f56-44b9-8267-8d044638b8f5", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "9bfc8034-ee26-43e6-bb5c-45a0e4ade0d9", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "9bfc8034-ee26-43e6-bb5c-45a0e4ade0d9", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "1cc8eb7b-e23b-4782-bf22-2c235fab2d65", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "1cc8eb7b-e23b-4782-bf22-2c235fab2d65", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "d1453bcf-f0d5-4eb8-b09d-e67c38afb6e8", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "d1453bcf-f0d5-4eb8-b09d-e67c38afb6e8", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "21bcb9df-1f56-44b9-8267-8d044638b8f5", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "09543bd5-8221-43ce-9f21-648582ff2300", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "09543bd5-8221-43ce-9f21-648582ff2300", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "4893a3f7-0cac-4491-856b-53d8ef2e53ed", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "25c3a17b-f5e6-46e7-b217-e4ba9648469f", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "25c3a17b-f5e6-46e7-b217-e4ba9648469f", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "5e341544-225f-4604-a396-645ee3631bb5", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "5e341544-225f-4604-a396-645ee3631bb5", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "e497b078-67c6-4dd2-b065-b42b4650bd94", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "e497b078-67c6-4dd2-b065-b42b4650bd94", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "9dddb456-6ac4-49ce-b66b-e968de7b59f4", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "9dddb456-6ac4-49ce-b66b-e968de7b59f4", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "95adbe76-d01c-4a72-9e75-3803800001fd", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "95adbe76-d01c-4a72-9e75-3803800001fd", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "4893a3f7-0cac-4491-856b-53d8ef2e53ed", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,2,2,2,4,4,5,6,6,7,7,8,9,9,9,10,11,11,12,12,12,12,13,14,14,15,15,15,16,16,16,17,17,18,19,19,20,21,21,21,22,23,23,24,24,24,24,25,25,26,27,27,27,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __ASN_Orchestration_root_0 __ctx0__ = (__ASN_Orchestration_root_0)_stateMgrs[0];
            __ASN_Orchestration_1 __ctx1__ = (__ASN_Orchestration_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                ReceiveOrderShipmentMessage = new PortType_ReceiveOrderShipmentMessage(0, this);
                SendPip3B2Message = new PortType_SendPip3B2Message(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], ReceiveOrderShipmentMessage, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __ASN_Orchestration_1(this);
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
            __ASN_Orchestration_root_0 __ctx0__ = (__ASN_Orchestration_root_0)_stateMgrs[0];
            __ASN_Orchestration_1 __ctx1__ = (__ASN_Orchestration_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
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
                __ctx1__.__ASIC = default(System.Int32);
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
                if (!ReceiveOrderShipmentMessage.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__OrderShipmentMessage != null)
                    __ctx1__.UnrefMessage(__ctx1__.__OrderShipmentMessage);
                __ctx1__.__OrderShipmentMessage = new __messagetype_Kaifa_B2B_Schemas_Wms_OrderShipment("OrderShipmentMessage", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__OrderShipmentMessage);
                ReceiveOrderShipmentMessage.ReceiveMessage(0, __msgEnv__, __ctx1__.__OrderShipmentMessage, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (ReceiveOrderShipmentMessage != null)
                {
                    ReceiveOrderShipmentMessage.Close(__ctx1__, __seg__);
                    ReceiveOrderShipmentMessage = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__OrderShipmentMessage);
                    __edata.PortName = @"ReceiveOrderShipmentMessage";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__SubmitRNIF = new Microsoft.Solutions.BTARN.Shared.SubmitRNIF();
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
                __ctx1__.__pipInstanceMessageIdForSTX = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__pipInstanceMessageIdFore2open = "";
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__pipInstanceIdentifierForSTX = "";
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__pipInstanceIdentifierFore2open = "";
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__CountStr = "";
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                __ctx1__.__ASIC = (System.Int32)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__OrderShipmentMessage.part, "count(/*[local-name()='OrderShipment' and namespace-uri()='http://kaifa.b2b.schemas/OrderShipment']/*[local-name()='ASIC' and namespace-uri()='http://kaifa.b2b.schemas/OrderShipment'])", typeof(System.Int32));
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                __condition__ = __ctx1__.__ASIC > 0;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 31;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                {
                    __messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip3B2AdvanceShipmentNotification __Pip3B2MessageForSTX = new __messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip3B2AdvanceShipmentNotification("Pip3B2MessageForSTX", __ctx1__);

                    ApplyTransform(typeof(Kaifa.B2B.Mapping.Order_To_3B2_STX_ASIC), new object[] {__Pip3B2MessageForSTX.part}, new object[] {__ctx1__.__OrderShipmentMessage.part});
                    __ctx1__.__pipInstanceIdentifierForSTX = (System.String)__Pip3B2MessageForSTX.part.GetDistinguishedField("thisDocumentIdentifier.ProprietaryDocumentIdentifier");
                    __Pip3B2MessageForSTX.SetPropertyValue(typeof(FILE.ReceivedFileName), "ASN_To_STX＿" + __ctx1__.__pipInstanceIdentifierForSTX + ".xml");

                    if (__ctx1__.__Pip3B2MessageForSTX != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Pip3B2MessageForSTX);
                    __ctx1__.__Pip3B2MessageForSTX = __Pip3B2MessageForSTX;
                    __ctx1__.RefMessage(__ctx1__.__Pip3B2MessageForSTX);
                }
                __ctx1__.__Pip3B2MessageForSTX.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Pip3B2MessageForSTX);
                    __edata.Messages.Add(__ctx1__.__OrderShipmentMessage);
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendPip3B2Message.SendMessage(0, __ctx1__.__Pip3B2MessageForSTX, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Pip3B2MessageForSTX);
                    __edata.PortName = @"SendPip3B2Message";
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                __ctx1__.__pipInstanceMessageIdForSTX = (System.String)__ctx1__.__Pip3B2MessageForSTX.GetPropertyValueThrows(typeof(BTS.MessageID));
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                __ctx1__.__strPipMessageForSTX = Kaifa.B2B.Utility.HeaderHelper.ReturnSCWithDocType(__ctx1__.__Pip3B2MessageForSTX.part.TypedValue, "3B2SG0100");
                if (__ctx1__ != null && __ctx1__.__Pip3B2MessageForSTX != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Pip3B2MessageForSTX);
                    __ctx1__.__Pip3B2MessageForSTX = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                System.Diagnostics.Trace.WriteLine("SubmitRNIF.SubmitMessage To STX " + __ctx1__.__pipInstanceMessageIdForSTX + " - " + __ctx1__.__pipInstanceIdentifierForSTX, "kaifa.b2b");
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                __ctx1__.__SubmitRNIF.SubmitMessage(Microsoft.Solutions.BTARN.Shared.MessageCategory.AsyncAction, "KAIFA", "SEAGATE-US", "3B2", __ctx1__.__pipInstanceIdentifierForSTX, "V01.00", __ctx1__.__strPipMessageForSTX);
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceIdentifierForSTX = null;
                if (__ctx1__ != null)
                    __ctx1__.__pipInstanceMessageIdForSTX = null;
                if (__ctx1__ != null)
                    __ctx1__.__strPipMessageForSTX = null;
                Tracker.FireEvent(__eventLocations[13],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 33;
            case 33:
                __ctx1__.__Count = (System.Int32)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__OrderShipmentMessage.part, "count(/*[local-name()='OrderShipment' and namespace-uri()='http://kaifa.b2b.schemas/OrderShipment']/*[local-name()='VendorShipmentReport' and namespace-uri()='http://kaifa.b2b.schemas/OrderShipment'])", typeof(System.Int32));
                if ( !PostProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                __ctx1__.__CountStr = __ctx1__.__Count.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 36:
                __ctx1__.__Increase = 1;
                if ( !PostProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 37;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 38;
            case 38:
                __condition__ = __ctx1__.__Increase <= __ctx1__.__Count;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 61 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 61;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 40;
            case 40:
                if ( !PreProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 41;
            case 41:
                {
                    __messagetype_Kaifa_B2B_Schemas_Wms_VendorShipmentReport __VendorShipmentReportMessage = new __messagetype_Kaifa_B2B_Schemas_Wms_VendorShipmentReport("VendorShipmentReportMessage", __ctx1__);

                    __ctx1__.__CountStr = __ctx1__.__Increase.ToString();
                    __VendorShipmentReportMessage.part.XPathAssign(__ctx1__.__OrderShipmentMessage.part, "/*[local-name()='OrderShipment' and namespace-uri()='http://kaifa.b2b.schemas/OrderShipment']/*[local-name()='VendorShipmentReport' and namespace-uri()='http://kaifa.b2b.schemas/OrderShipment'][" + __ctx1__.__CountStr + "]");

                    if (__ctx1__.__VendorShipmentReportMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__VendorShipmentReportMessage);
                    __ctx1__.__VendorShipmentReportMessage = __VendorShipmentReportMessage;
                    __ctx1__.RefMessage(__ctx1__.__VendorShipmentReportMessage);
                }
                __ctx1__.__VendorShipmentReportMessage.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 42;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__VendorShipmentReportMessage);
                    Tracker.FireEvent(__eventLocations[18],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 43;
            case 43:
                if ( !PreProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 44;
            case 44:
                {
                    __messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip3B2AdvanceShipmentNotification __Pip3B2MessageForE2open = new __messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip3B2AdvanceShipmentNotification("Pip3B2MessageForE2open", __ctx1__);

                    ApplyTransform(typeof(Kaifa.B2B.Mapping.Order_To_3B2_e2open), new object[] {__Pip3B2MessageForE2open.part}, new object[] {__ctx1__.__VendorShipmentReportMessage.part});
                    __ctx1__.__pipInstanceIdentifierFore2open = (System.String)__Pip3B2MessageForE2open.part.GetDistinguishedField("thisDocumentIdentifier.ProprietaryDocumentIdentifier");
                    __Pip3B2MessageForE2open.SetPropertyValue(typeof(FILE.ReceivedFileName), "ASN_To_e2open＿" + __ctx1__.__pipInstanceIdentifierFore2open + ".xml");

                    if (__ctx1__.__Pip3B2MessageForE2open != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Pip3B2MessageForE2open);
                    __ctx1__.__Pip3B2MessageForE2open = __Pip3B2MessageForE2open;
                    __ctx1__.RefMessage(__ctx1__.__Pip3B2MessageForE2open);
                }
                __ctx1__.__Pip3B2MessageForE2open.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 45;
            case 45:
                if ( !PreProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Pip3B2MessageForE2open);
                    __edata.Messages.Add(__ctx1__.__VendorShipmentReportMessage);
                    Tracker.FireEvent(__eventLocations[20],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__VendorShipmentReportMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__VendorShipmentReportMessage);
                    __ctx1__.__VendorShipmentReportMessage = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 46;
            case 46:
                if ( !PreProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 47;
            case 47:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 48;
            case 48:
                if ( !PreProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendPip3B2Message.SendMessage(0, __ctx1__.__Pip3B2MessageForE2open, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 49;
            case 49:
                if ( !PreProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Pip3B2MessageForE2open);
                    __edata.PortName = @"SendPip3B2Message";
                    Tracker.FireEvent(__eventLocations[22],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 50;
            case 50:
                if ( !PreProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[23],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 51;
            case 51:
                __ctx1__.__pipInstanceMessageIdFore2open = (System.String)__ctx1__.__Pip3B2MessageForE2open.GetPropertyValueThrows(typeof(BTS.MessageID));
                if ( !PostProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 52;
            case 52:
                if ( !PreProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 53;
            case 53:
                __ctx1__.__strPipMessageFore2open = Kaifa.B2B.Utility.HeaderHelper.ReturnSCWithDocType(__ctx1__.__Pip3B2MessageForE2open.part.TypedValue, "3B2SG0100");
                if (__ctx1__ != null && __ctx1__.__Pip3B2MessageForE2open != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Pip3B2MessageForE2open);
                    __ctx1__.__Pip3B2MessageForE2open = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 54 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 54;
            case 54:
                System.Diagnostics.Trace.WriteLine("SubmitRNIF.SubmitMessage To e2open " + __ctx1__.__pipInstanceMessageIdFore2open + " - " + __ctx1__.__pipInstanceIdentifierFore2open, "kaifa.b2b");
                if ( !PostProgressInc( __seg__, __ctx__, 55 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 55;
            case 55:
                __ctx1__.__SubmitRNIF.SubmitMessage(Microsoft.Solutions.BTARN.Shared.MessageCategory.AsyncAction, "KAIFA", "E2OPEN", "3B2", __ctx1__.__pipInstanceIdentifierFore2open, "V01.00", __ctx1__.__strPipMessageFore2open);
                if ( !PostProgressInc( __seg__, __ctx__, 56 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 56;
            case 56:
                if ( !PreProgressInc( __seg__, __ctx__, 57 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[25],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 57;
            case 57:
                __ctx1__.__Increase = __ctx1__.__Increase + 1;
                if ( !PostProgressInc( __seg__, __ctx__, 58 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 58;
            case 58:
                if ( !PreProgressInc( __seg__, __ctx__, 59 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[26],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 59;
            case 59:
                if ( !PreProgressInc( __seg__, __ctx__, 60 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[27],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 60;
            case 60:
                if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 38;
            case 61:
                if ( !PreProgressInc( __seg__, __ctx__, 62 ) )
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
                    __ctx1__.__SubmitRNIF = null;
                if (__ctx1__ != null && __ctx1__.__OrderShipmentMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OrderShipmentMessage);
                    __ctx1__.__OrderShipmentMessage = null;
                }
                if (SendPip3B2Message != null)
                {
                    SendPip3B2Message.Close(__ctx1__, __seg__);
                    SendPip3B2Message = null;
                }
                Tracker.FireEvent(__eventLocations[27],__eventData[11],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 62;
            case 62:
                if ( !PreProgressInc( __seg__, __ctx__, 63 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[12],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 63;
            case 63:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 64 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 64;
            case 64:
                if ( !PreProgressInc( __seg__, __ctx__, 65 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 65;
            case 65:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __Kaifa_B2B_Schemas_Wms_OrderShipment__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.Schemas.Wms.OrderShipment _schema = new Kaifa.B2B.Schemas.Wms.OrderShipment();

        public __Kaifa_B2B_Schemas_Wms_OrderShipment__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Kaifa.B2B.Schemas.Wms.OrderShipment",
        new System.Type[]{
            typeof(Kaifa.B2B.Schemas.Wms.OrderShipment)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_Schemas_Wms_OrderShipment__)
        },
        0,
        @"http://kaifa.b2b.schemas/OrderShipment#OrderShipment"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Kaifa_B2B_Schemas_Wms_OrderShipment : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_Schemas_Wms_OrderShipment__ part;

        private void __CreatePartWrappers()
        {
            part = new __Kaifa_B2B_Schemas_Wms_OrderShipment__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Kaifa_B2B_Schemas_Wms_OrderShipment(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Kaifa_B2B_Schemas_RosettaNet_Pip3B2AdvanceShipmentNotification__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.Schemas.RosettaNet.Pip3B2AdvanceShipmentNotification _schema = new Kaifa.B2B.Schemas.RosettaNet.Pip3B2AdvanceShipmentNotification();

        public __Kaifa_B2B_Schemas_RosettaNet_Pip3B2AdvanceShipmentNotification__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Kaifa.B2B.Schemas.RosettaNet.Pip3B2AdvanceShipmentNotification",
        new System.Type[]{
            typeof(Kaifa.B2B.Schemas.RosettaNet.Pip3B2AdvanceShipmentNotification)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_Schemas_RosettaNet_Pip3B2AdvanceShipmentNotification__)
        },
        0,
        @"http://kaifa.b2b.schemas/Pip3B2AdvanceShipmentNotification#Pip3B2AdvanceShipmentNotification"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip3B2AdvanceShipmentNotification : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_Schemas_RosettaNet_Pip3B2AdvanceShipmentNotification__ part;

        private void __CreatePartWrappers()
        {
            part = new __Kaifa_B2B_Schemas_RosettaNet_Pip3B2AdvanceShipmentNotification__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Kaifa_B2B_Schemas_RosettaNet_Pip3B2AdvanceShipmentNotification(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Kaifa_B2B_Schemas_Wms_VendorShipmentReport__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.Schemas.Wms.VendorShipmentReport _schema = new Kaifa.B2B.Schemas.Wms.VendorShipmentReport();

        public __Kaifa_B2B_Schemas_Wms_VendorShipmentReport__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Kaifa.B2B.Schemas.Wms.VendorShipmentReport",
        new System.Type[]{
            typeof(Kaifa.B2B.Schemas.Wms.VendorShipmentReport)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_Schemas_Wms_VendorShipmentReport__)
        },
        0,
        @"http://kaifa.b2b.schemas/OrderShipment#VendorShipmentReport"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Kaifa_B2B_Schemas_Wms_VendorShipmentReport : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_Schemas_Wms_VendorShipmentReport__ part;

        private void __CreatePartWrappers()
        {
            part = new __Kaifa_B2B_Schemas_Wms_VendorShipmentReport__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Kaifa_B2B_Schemas_Wms_VendorShipmentReport(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
