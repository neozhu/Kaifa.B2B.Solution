
#pragma warning disable 162

namespace Kaifa.B2B.SAP.AR
{

    [System.SerializableAttribute]
    sealed public class __Kaifa_B2B_SAP_AR_ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style_ZfiCreateArForWms__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.SAP.AR.ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style.ZfiCreateArForWms _schema = new Kaifa.B2B.SAP.AR.ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style.ZfiCreateArForWms();

        public __Kaifa_B2B_SAP_AR_ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style_ZfiCreateArForWms__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(Kaifa.B2B.SAP.AR.ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style.ZfiCreateArForWms)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_SAP_AR_ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style_ZfiCreateArForWms__)
        },
        0,
        @"urn:sap-com:document:sap:soap:functions:mc-style#ZfiCreateArForWms"
    )]
    [System.SerializableAttribute]
    sealed internal class ZfiCreateArForWms : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_SAP_AR_ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style_ZfiCreateArForWms__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __Kaifa_B2B_SAP_AR_ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style_ZfiCreateArForWms__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public ZfiCreateArForWms(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Kaifa_B2B_SAP_AR_ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style_ZfiCreateArForWmsResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.SAP.AR.ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style.ZfiCreateArForWmsResponse _schema = new Kaifa.B2B.SAP.AR.ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style.ZfiCreateArForWmsResponse();

        public __Kaifa_B2B_SAP_AR_ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style_ZfiCreateArForWmsResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(Kaifa.B2B.SAP.AR.ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style.ZfiCreateArForWmsResponse)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_SAP_AR_ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style_ZfiCreateArForWmsResponse__)
        },
        0,
        @"urn:sap-com:document:sap:soap:functions:mc-style#ZfiCreateArForWmsResponse"
    )]
    [System.SerializableAttribute]
    sealed internal class ZfiCreateArForWmsResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_SAP_AR_ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style_ZfiCreateArForWmsResponse__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __Kaifa_B2B_SAP_AR_ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style_ZfiCreateArForWmsResponse__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public ZfiCreateArForWmsResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "ZfiCreateArForWms",
        new System.Type[]{
            typeof(Kaifa.B2B.SAP.AR.ZfiCreateArForWms), 
            typeof(Kaifa.B2B.SAP.AR.ZfiCreateArForWmsResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class ZFI_CREATE_AR_FOR_WMS : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public ZFI_CREATE_AR_FOR_WMS(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public ZFI_CREATE_AR_FOR_WMS(ZFI_CREATE_AR_FOR_WMS p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            ZFI_CREATE_AR_FOR_WMS p = new ZFI_CREATE_AR_FOR_WMS(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo ZfiCreateArForWms = new Microsoft.XLANGs.Core.OperationInfo
        (
            "ZfiCreateArForWms",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(ZFI_CREATE_AR_FOR_WMS),
            typeof(ZfiCreateArForWms),
            typeof(ZfiCreateArForWmsResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "ZfiCreateArForWms" ] = ZfiCreateArForWms;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [System.SerializableAttribute]
    sealed public class __Kaifa_B2B_Schemas_Wms_ARReport__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.Schemas.Wms.ARReport _schema = new Kaifa.B2B.Schemas.Wms.ARReport();

        public __Kaifa_B2B_Schemas_Wms_ARReport__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Kaifa.B2B.Schemas.Wms.ARReport",
        new System.Type[]{
            typeof(Kaifa.B2B.Schemas.Wms.ARReport)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_Schemas_Wms_ARReport__)
        },
        0,
        @"http://Kaifa.B2B.Schemas.WMSAR#ARReport"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Kaifa_B2B_Schemas_Wms_ARReport : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_Schemas_Wms_ARReport__ part;

        private void __CreatePartWrappers()
        {
            part = new __Kaifa_B2B_Schemas_Wms_ARReport__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Kaifa_B2B_Schemas_Wms_ARReport(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Kaifa.B2B.SAP.AR.__messagetype_Kaifa_B2B_Schemas_Wms_ARReport)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_ReceiveWMSARReport : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_ReceiveWMSARReport(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_ReceiveWMSARReport(PortType_ReceiveWMSARReport p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_ReceiveWMSARReport p = new PortType_ReceiveWMSARReport(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_ReceiveWMSARReport),
            typeof(__messagetype_Kaifa_B2B_Schemas_Wms_ARReport),
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
            typeof(Kaifa.B2B.SAP.AR.ZfiCreateArForWmsResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_SaveInvokeResult : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_SaveInvokeResult(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_SaveInvokeResult(PortType_SaveInvokeResult p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_SaveInvokeResult p = new PortType_SaveInvokeResult(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_SaveInvokeResult),
            typeof(ZfiCreateArForWmsResponse),
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
    //#line 380 "D:\长城开发项目\SourceCode\Kaifa.B2B.Solution\Kaifa.B2B.SAP.AR\ZFI_CREATE_AR_FOR_WMS.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "ReceiveWMSARReport", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Kaifa.B2B.SAP.AR.PortType_ReceiveWMSARReport),
            typeof(Kaifa.B2B.SAP.AR.ZFI_CREATE_AR_FOR_WMS),
            typeof(Kaifa.B2B.SAP.AR.PortType_SaveInvokeResult)
        },
        new System.String[] {
            "ReceiveWMSARReport",
            "InvokeSAPWebService",
            "SaveInvokeResult"
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
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class ZFI_CREATE_AR_FOR_WMSClient : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(ZFI_CREATE_AR_FOR_WMSClient));
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

        static ZFI_CREATE_AR_FOR_WMSClient()
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
            _rootContext = new __ZFI_CREATE_AR_FOR_WMSClient_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public ZFI_CREATE_AR_FOR_WMSClient(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "ZFI_CREATE_AR_FOR_WMSClient", tracker)
        {
            ConstructorHelper();
        }

        public ZFI_CREATE_AR_FOR_WMSClient(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "ZFI_CREATE_AR_FOR_WMSClient")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>6bd3f43d-0cd3-44cd-b843-c1af72336550</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>46d1596e-a6e0-41f4-918a-7ad3730a871f</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_ARReport</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>e0fe0755-4aeb-4697-b164-b494e459d22a</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>GetCount</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>WhileShape</shapeType>      <ShapeID>28769816-be18-4ac7-80ed-98353a1873e4</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Loop_Customer</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>dfa9bb57-4280-420d-ad33-ed7b635225fc</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_CustMessage</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>8bceaa59-f40f-4608-8540-acf90a6b5750</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>8fc6dd26-e240-4f21-a710-143a36424938</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>617851e7-06b9-472a-9848-47c9287a2bd3</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>9100f701-6412-4955-b37e-8820b21d6c30</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>69b00f05-7c5d-4e66-bd59-231c96b0dfaf</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>75194391-4ef7-43ae-90ed-9aa4fa2c2f17</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>97ae6139-2828-4424-936f-2d409907df05</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>e602c420-0a06-470f-be5c-6a2d62dfb5cb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive_Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>8c41589c-04d8-48e2-8234-3d6fd7ab0de3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>UpdateWMSBKId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>52a27cfd-647e-458c-bf7d-4a460ec36da9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_Result</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>76cf1d90-af9a-4e19-a44f-a017984e2eea</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_++</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'ZFI_CREATE_AR_FOR_WMSClient'</ActionName><IsAtomic>0</IsAtomic><Line>380</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>401</Line><Position>22</Position><ShapeID>'46d1596e-a6e0-41f4-918a-7ad3730a871f'</ShapeID>
<Messages>
	<MsgInfo><name>ARReport_Message</name><part>part</part><schema>Kaifa.B2B.Schemas.Wms.ARReport</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>407</Line><Position>19</Position><ShapeID>'e0fe0755-4aeb-4697-b164-b494e459d22a'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>411</Line><Position>13</Position><ShapeID>'28769816-be18-4ac7-80ed-98353a1873e4'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>414</Line><Position>17</Position><ShapeID>'dfa9bb57-4280-420d-ad33-ed7b635225fc'</ShapeID>
<Messages>
	<MsgInfo><name>CustARReport_Message</name><part>part</part><schema>Kaifa.B2B.Schemas.Wms.CustARReport</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>ARRequest</name><part>parameters</part><schema>Kaifa.B2B.SAP.AR.ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style+ZfiCreateArForWms</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>CustARReport_Message</name><part>part</part><schema>Kaifa.B2B.Schemas.Wms.CustARReport</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>423</Line><Position>17</Position><ShapeID>'97ae6139-2828-4424-936f-2d409907df05'</ShapeID>
<Messages>
	<MsgInfo><name>ARRequest</name><part>parameters</part><schema>Kaifa.B2B.SAP.AR.ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style+ZfiCreateArForWms</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>425</Line><Position>17</Position><ShapeID>'e602c420-0a06-470f-be5c-6a2d62dfb5cb'</ShapeID>
<Messages>
	<MsgInfo><name>ARResponse</name><part>parameters</part><schema>Kaifa.B2B.SAP.AR.ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style+ZfiCreateArForWmsResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>427</Line><Position>25</Position><ShapeID>'8c41589c-04d8-48e2-8234-3d6fd7ab0de3'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>433</Line><Position>17</Position><ShapeID>'52a27cfd-647e-458c-bf7d-4a460ec36da9'</ShapeID>
<Messages>
	<MsgInfo><name>ARResponse</name><part>parameters</part><schema>Kaifa.B2B.SAP.AR.ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style+ZfiCreateArForWmsResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>435</Line><Position>26</Position><ShapeID>'76cf1d90-af9a-4e19-a44f-a017984e2eea'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='2048192e-5868-4a7a-b03d-0d11ec19b8a2' LowerBound='1.1' HigherBound='94.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Kaifa.B2B.SAP.AR' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='52db4126-0184-43ab-a15e-8d61d30e3e77' ParentLink='Module_PortType' LowerBound='12.1' HigherBound='19.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:portType name=&quot;ZFI_CREATE_AR_FOR_WMS&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='ZFI_CREATE_AR_FOR_WMS' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='1c4a3bdf-4edc-4a71-acd1-cf6e77802577' ParentLink='PortType_OperationDeclaration' LowerBound='14.1' HigherBound='18.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:operation name=&quot;ZfiCreateArForWms&quot;/&gt;&#xD;&#xA;' />
                <om:Property Name='Name' Value='ZfiCreateArForWms' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='3709fc30-8822-4f66-89d2-11469b8ae1cc' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='16.13' HigherBound='16.30'>
                    <om:Property Name='Ref' Value='Kaifa.B2B.SAP.AR.ZfiCreateArForWms' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='&lt;wsdl:input message=&quot;urn:sap-com:document:sap:soap:functions:mc-style:ZfiCreateArForWms&quot;/&gt;&#xD;&#xA;' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='351ea129-c5ca-4617-a9c0-5f8bb69976db' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='16.32' HigherBound='16.57'>
                    <om:Property Name='Ref' Value='Kaifa.B2B.SAP.AR.ZfiCreateArForWmsResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='&lt;wsdl:output message=&quot;urn:sap-com:document:sap:soap:functions:mc-style:ZfiCreateArForWmsResponse&quot;/&gt;&#xD;&#xA;' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='87eba6be-c589-4589-98fc-2928b91fb074' ParentLink='Module_PortType' LowerBound='19.1' HigherBound='26.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_ReceiveWMSARReport' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='387cf316-89f5-4e15-8431-25eb256fb7df' ParentLink='PortType_OperationDeclaration' LowerBound='21.1' HigherBound='25.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='37bc002d-d757-44a9-8db7-5af4c688739a' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='23.13' HigherBound='23.43'>
                    <om:Property Name='Ref' Value='Kaifa.B2B.Schemas.Wms.ARReport' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='ed2f92b8-89ae-4d9c-a5ec-f85820b11c77' ParentLink='Module_PortType' LowerBound='26.1' HigherBound='33.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_SaveInvokeResult' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='08303e3a-576d-470d-a826-140949a2e946' ParentLink='PortType_OperationDeclaration' LowerBound='28.1' HigherBound='32.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='c21aa25b-2dd1-462c-a6f5-49633a10fd23' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='30.13' HigherBound='30.38'>
                    <om:Property Name='Ref' Value='Kaifa.B2B.SAP.AR.ZfiCreateArForWmsResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='2e355c1b-db37-421e-b688-2624370da446' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:message name=&quot;ZfiCreateArForWms&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='ZfiCreateArForWms' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='120fbe45-40c6-4165-929d-d8356722de19' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='Kaifa.B2B.SAP.AR.ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style.ZfiCreateArForWms' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:part name=&quot;parameters&quot;/&gt;&#xD;&#xA;' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='6f9aa8e7-b17a-4670-8d0e-0b854e7c3bcf' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:message name=&quot;ZfiCreateArForWmsResponse&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='ZfiCreateArForWmsResponse' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='d5df1211-0ccc-4233-a3de-ef575d5f3b9e' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='Kaifa.B2B.SAP.AR.ZFI_CREATE_AR_FOR_WMS_sap_com_document_sap_soap_functions_mc_style.ZfiCreateArForWmsResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:part name=&quot;parameters&quot;/&gt;&#xD;&#xA;' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='6c776d32-f0b8-4de1-a55e-c6991b44130e' ParentLink='Module_ServiceDeclaration' LowerBound='33.1' HigherBound='93.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:service name=&quot;ZFI_CREATE_AR_FOR_WMS&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='ZFI_CREATE_AR_FOR_WMSClient' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='b316ead6-e60a-41fe-a527-7a6850a1510f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='46.1' HigherBound='47.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Count' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='715911ba-ea86-4a59-89d5-0c78ff970e31' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='47.1' HigherBound='48.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CountStr' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='dacae407-ca54-4d0b-a815-20fa54c43969' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='48.1' HigherBound='49.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Increase' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='213ab1a0-b155-4152-80f7-87cd7a1e3347' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='49.1' HigherBound='50.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='batchid' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='f0916a7d-dcf6-47d5-91cd-4e9c9cd67afd' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='50.1' HigherBound='51.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sapbkid' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='61e1cd07-8f79-4eb5-98dc-09f128daed39' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='51.1' HigherBound='52.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sapmsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='efcca641-d942-41c1-a982-51758a806384' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='42.1' HigherBound='43.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.SAP.AR.ZfiCreateArForWms' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ARRequest' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='4ddc2817-7d67-4320-a78b-b8f315093767' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='43.1' HigherBound='44.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.SAP.AR.ZfiCreateArForWmsResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ARResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='67711e3a-b781-4814-803e-9f89d3351255' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='44.1' HigherBound='45.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas.Wms.ARReport' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ARReport_Message' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='128aebbf-8876-4074-8b1e-10ab8a463be4' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='45.1' HigherBound='46.1'>
                <om:Property Name='Type' Value='Kaifa.B2B.Schemas.Wms.CustARReport' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CustARReport_Message' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='6bd3f43d-0cd3-44cd-b843-c1af72336550' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='46d1596e-a6e0-41f4-918a-7ad3730a871f' ParentLink='ServiceBody_Statement' LowerBound='54.1' HigherBound='60.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='ReceiveWMSARReport' />
                    <om:Property Name='MessageName' Value='ARReport_Message' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_ARReport' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='e0fe0755-4aeb-4697-b164-b494e459d22a' ParentLink='ServiceBody_Statement' LowerBound='60.1' HigherBound='64.1'>
                    <om:Property Name='Expression' Value='Count = xpath(ARReport_Message, &quot;count(/*[local-name()=&apos;ARReport&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.WMSAR&apos;]/*[local-name()=&apos;CustARReport&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.WMSAR&apos;])&quot;); &#xD;&#xA;CountStr = Count.ToString();&#xD;&#xA;Increase = 1;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='GetCount' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='While' OID='28769816-be18-4ac7-80ed-98353a1873e4' ParentLink='ServiceBody_Statement' LowerBound='64.1' HigherBound='91.1'>
                    <om:Property Name='Expression' Value='Increase&lt;=Count ' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Loop_Customer' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Construct' OID='dfa9bb57-4280-420d-ad33-ed7b635225fc' ParentLink='ComplexStatement_Statement' LowerBound='67.1' HigherBound='76.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructMessage_CustMessage' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageAssignment' OID='8bceaa59-f40f-4608-8540-acf90a6b5750' ParentLink='ComplexStatement_Statement' LowerBound='70.1' HigherBound='73.1'>
                            <om:Property Name='Expression' Value='CountStr = Increase.ToString();&#xD;&#xA;CustARReport_Message =  xpath(ARReport_Message, &quot;/*[local-name()=&apos;ARReport&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.WMSAR&apos;]/*[local-name()=&apos;CustARReport&apos; and namespace-uri()=&apos;http://Kaifa.B2B.Schemas.WMSAR&apos;][&quot; + CountStr + &quot;]&quot;);' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='MessageAssignment_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Transform' OID='8fc6dd26-e240-4f21-a710-143a36424938' ParentLink='ComplexStatement_Statement' LowerBound='73.1' HigherBound='75.1'>
                            <om:Property Name='ClassName' Value='Kaifa.B2B.SAP.AR.Map_To_SAPAR' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Transform_1' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessagePartRef' OID='617851e7-06b9-472a-9848-47c9287a2bd3' ParentLink='Transform_InputMessagePartRef' LowerBound='74.87' HigherBound='74.107'>
                                <om:Property Name='MessageRef' Value='CustARReport_Message' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_1' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='9100f701-6412-4955-b37e-8820b21d6c30' ParentLink='Transform_OutputMessagePartRef' LowerBound='74.32' HigherBound='74.52'>
                                <om:Property Name='MessageRef' Value='ARRequest' />
                                <om:Property Name='PartRef' Value='parameters' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_2' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='MessageRef' OID='69b00f05-7c5d-4e66-bd59-231c96b0dfaf' ParentLink='Construct_MessageRef' LowerBound='68.27' HigherBound='68.47'>
                            <om:Property Name='Ref' Value='CustARReport_Message' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageRef' OID='75194391-4ef7-43ae-90ed-9aa4fa2c2f17' ParentLink='Construct_MessageRef' LowerBound='68.49' HigherBound='68.58'>
                            <om:Property Name='Ref' Value='ARRequest' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Send' OID='97ae6139-2828-4424-936f-2d409907df05' ParentLink='ComplexStatement_Statement' LowerBound='76.1' HigherBound='78.1'>
                        <om:Property Name='PortName' Value='InvokeSAPWebService' />
                        <om:Property Name='MessageName' Value='ARRequest' />
                        <om:Property Name='OperationName' Value='ZfiCreateArForWms' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Send_Request' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Receive' OID='e602c420-0a06-470f-be5c-6a2d62dfb5cb' ParentLink='ComplexStatement_Statement' LowerBound='78.1' HigherBound='80.1'>
                        <om:Property Name='Activate' Value='False' />
                        <om:Property Name='PortName' Value='InvokeSAPWebService' />
                        <om:Property Name='MessageName' Value='ARResponse' />
                        <om:Property Name='OperationName' Value='ZfiCreateArForWms' />
                        <om:Property Name='OperationMessageName' Value='Response' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Receive_Response' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='8c41589c-04d8-48e2-8234-3d6fd7ab0de3' ParentLink='ComplexStatement_Statement' LowerBound='80.1' HigherBound='86.1'>
                        <om:Property Name='Expression' Value='sapbkid = System.Convert.ToString(xpath(ARResponse.parameters,&quot;string(/*[local-name()=&apos;ZfiCreateArForWmsResponse&apos; and namespace-uri()=&apos;urn:sap-com:document:sap:soap:functions:mc-style&apos;]/*[local-name()=&apos;DocumentNumber&apos; and namespace-uri()=&apos;&apos;])&quot;));&#xD;&#xA;batchid=  System.Convert.ToString(xpath(ARResponse.parameters,&quot;string(/*[local-name()=&apos;ZfiCreateArForWmsResponse&apos; and namespace-uri()=&apos;urn:sap-com:document:sap:soap:functions:mc-style&apos;]/*[local-name()=&apos;WmsBatchidOut&apos; and namespace-uri()=&apos;&apos;])&quot;));&#xD;&#xA;sapmsg =  System.Convert.ToString(xpath(ARResponse.parameters,&quot;string(/*[local-name()=&apos;ZfiCreateArForWmsResponse&apos; and namespace-uri()=&apos;urn:sap-com:document:sap:soap:functions:mc-style&apos;]/*[local-name()=&apos;MsgTab&apos; and namespace-uri()=&apos;&apos;]/*[local-name()=&apos;item&apos; and namespace-uri()=&apos;&apos;]/*[local-name()=&apos;Message&apos; and namespace-uri()=&apos;&apos;])&quot;));&#xD;&#xA;&#xD;&#xA;Kaifa.B2B.Utility.SAPARReturnHelper.Update(batchid,sapbkid,sapmsg);' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='UpdateWMSBKId' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Send' OID='52a27cfd-647e-458c-bf7d-4a460ec36da9' ParentLink='ComplexStatement_Statement' LowerBound='86.1' HigherBound='88.1'>
                        <om:Property Name='PortName' Value='SaveInvokeResult' />
                        <om:Property Name='MessageName' Value='ARResponse' />
                        <om:Property Name='OperationName' Value='Operation_1' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Send_Result' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='76cf1d90-af9a-4e19-a44f-a017984e2eea' ParentLink='ComplexStatement_Statement' LowerBound='88.1' HigherBound='90.1'>
                        <om:Property Name='Expression' Value='Increase = Increase + 1;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Expression_++' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='a0382297-c612-4a8f-acdb-7d85ee68767c' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='36.1' HigherBound='38.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Kaifa.B2B.SAP.AR.PortType_ReceiveWMSARReport' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceiveWMSARReport' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='3f3e39c3-11f2-43bb-bd91-e4c36de2b743' ParentLink='PortDeclaration_CLRAttribute' LowerBound='36.1' HigherBound='37.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='a7418322-d779-488c-8582-28f46495d5c9' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='38.1' HigherBound='40.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Kaifa.B2B.SAP.AR.ZFI_CREATE_AR_FOR_WMS' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='InvokeSAPWebService' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='5e05cfc2-ddc9-48da-aa1c-150d720133ee' ParentLink='PortDeclaration_CLRAttribute' LowerBound='38.1' HigherBound='39.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='a5dd7f89-03a7-459d-b826-c79dded3d0ae' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='40.1' HigherBound='42.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Kaifa.B2B.SAP.AR.PortType_SaveInvokeResult' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SaveInvokeResult' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='a532ddd1-87db-4d61-9f74-761f48af5627' ParentLink='PortDeclaration_CLRAttribute' LowerBound='40.1' HigherBound='41.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __ZFI_CREATE_AR_FOR_WMSClient_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __ZFI_CREATE_AR_FOR_WMSClient_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ZFI_CREATE_AR_FOR_WMSClient")
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
                ZFI_CREATE_AR_FOR_WMSClient __svc__ = (ZFI_CREATE_AR_FOR_WMSClient)_service;
                __ZFI_CREATE_AR_FOR_WMSClient_root_0 __ctx0__ = (__ZFI_CREATE_AR_FOR_WMSClient_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.ReceiveWMSARReport != null)
                {
                    __svc__.ReceiveWMSARReport.Close(this, null);
                    __svc__.ReceiveWMSARReport = null;
                }
                if (__svc__.SaveInvokeResult != null)
                {
                    __svc__.SaveInvokeResult.Close(this, null);
                    __svc__.SaveInvokeResult = null;
                }
                if (__svc__.InvokeSAPWebService != null)
                {
                    __svc__.InvokeSAPWebService.Close(this, null);
                    __svc__.InvokeSAPWebService = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __ZFI_CREATE_AR_FOR_WMSClient_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __ZFI_CREATE_AR_FOR_WMSClient_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ZFI_CREATE_AR_FOR_WMSClient")
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
                ZFI_CREATE_AR_FOR_WMSClient __svc__ = (ZFI_CREATE_AR_FOR_WMSClient)_service;
                __ZFI_CREATE_AR_FOR_WMSClient_root_0 __ctx0__ = (__ZFI_CREATE_AR_FOR_WMSClient_root_0)(__svc__._stateMgrs[0]);
                __ZFI_CREATE_AR_FOR_WMSClient_1 __ctx1__ = (__ZFI_CREATE_AR_FOR_WMSClient_1)(__svc__._stateMgrs[1]);

                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__sapbkid = null;
                if (__ctx1__ != null)
                    __ctx1__.__sapmsg = null;
                if (__ctx1__ != null)
                    __ctx1__.__CountStr = null;
                if (__ctx1__ != null)
                    __ctx1__.__batchid = null;
                if (__ctx1__ != null && __ctx1__.__CustARReport_Message != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CustARReport_Message);
                    __ctx1__.__CustARReport_Message = null;
                }
                if (__ctx1__ != null && __ctx1__.__ARReport_Message != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ARReport_Message);
                    __ctx1__.__ARReport_Message = null;
                }
                if (__ctx1__ != null && __ctx1__.__ARRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ARRequest);
                    __ctx1__.__ARRequest = null;
                }
                if (__ctx1__ != null && __ctx1__.__ARResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ARResponse);
                    __ctx1__.__ARResponse = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("ARRequest")]
            internal ZfiCreateArForWms __ARRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ARResponse")]
            internal ZfiCreateArForWmsResponse __ARResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ARReport_Message")]
            public __messagetype_Kaifa_B2B_Schemas_Wms_ARReport __ARReport_Message;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CustARReport_Message")]
            public __messagetype_Kaifa_B2B_Schemas_Wms_CustARReport __CustARReport_Message;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Count")]
            internal System.Int32 __Count;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CountStr")]
            internal System.String __CountStr;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Increase")]
            internal System.Int32 __Increase;
            [Microsoft.XLANGs.Core.UserVariableAttribute("batchid")]
            internal System.String __batchid;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sapbkid")]
            internal System.String __sapbkid;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sapmsg")]
            internal System.String __sapmsg;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("ReceiveWMSARReport")]
        internal PortType_ReceiveWMSARReport ReceiveWMSARReport;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("InvokeSAPWebService")]
        internal ZFI_CREATE_AR_FOR_WMS InvokeSAPWebService;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SaveInvokeResult")]
        internal PortType_SaveInvokeResult SaveInvokeResult;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_ReceiveWMSARReport.Operation_1},
                                               typeof(ZFI_CREATE_AR_FOR_WMSClient).GetField("ReceiveWMSARReport", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ZFI_CREATE_AR_FOR_WMSClient), "ReceiveWMSARReport"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ZFI_CREATE_AR_FOR_WMS.ZfiCreateArForWms},
                                               typeof(ZFI_CREATE_AR_FOR_WMSClient).GetField("InvokeSAPWebService", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ZFI_CREATE_AR_FOR_WMSClient), "InvokeSAPWebService"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_SaveInvokeResult.Operation_1},
                                               typeof(ZFI_CREATE_AR_FOR_WMSClient).GetField("SaveInvokeResult", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ZFI_CREATE_AR_FOR_WMSClient), "SaveInvokeResult"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "46d1596e-a6e0-41f4-918a-7ad3730a871f", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "46d1596e-a6e0-41f4-918a-7ad3730a871f", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "e0fe0755-4aeb-4697-b164-b494e459d22a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "e0fe0755-4aeb-4697-b164-b494e459d22a", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "28769816-be18-4ac7-80ed-98353a1873e4", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "dfa9bb57-4280-420d-ad33-ed7b635225fc", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "dfa9bb57-4280-420d-ad33-ed7b635225fc", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "97ae6139-2828-4424-936f-2d409907df05", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "97ae6139-2828-4424-936f-2d409907df05", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "e602c420-0a06-470f-be5c-6a2d62dfb5cb", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "e602c420-0a06-470f-be5c-6a2d62dfb5cb", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "8c41589c-04d8-48e2-8234-3d6fd7ab0de3", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "8c41589c-04d8-48e2-8234-3d6fd7ab0de3", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "52a27cfd-647e-458c-bf7d-4a460ec36da9", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "52a27cfd-647e-458c-bf7d-4a460ec36da9", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "76cf1d90-af9a-4e19-a44f-a017984e2eea", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "76cf1d90-af9a-4e19-a44f-a017984e2eea", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "28769816-be18-4ac7-80ed-98353a1873e4", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,4,4,5,5,5,6,6,6,7,7,8,9,9,9,10,11,11,12,13,13,14,14,14,14,15,15,15,16,17,17,18,19,19,19,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __ZFI_CREATE_AR_FOR_WMSClient_root_0 __ctx0__ = (__ZFI_CREATE_AR_FOR_WMSClient_root_0)_stateMgrs[0];
            __ZFI_CREATE_AR_FOR_WMSClient_1 __ctx1__ = (__ZFI_CREATE_AR_FOR_WMSClient_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                ReceiveWMSARReport = new PortType_ReceiveWMSARReport(0, this);
                InvokeSAPWebService = new ZFI_CREATE_AR_FOR_WMS(1, this);
                SaveInvokeResult = new PortType_SaveInvokeResult(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], ReceiveWMSARReport, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __ZFI_CREATE_AR_FOR_WMSClient_1(this);
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
            __ZFI_CREATE_AR_FOR_WMSClient_root_0 __ctx0__ = (__ZFI_CREATE_AR_FOR_WMSClient_root_0)_stateMgrs[0];
            __ZFI_CREATE_AR_FOR_WMSClient_1 __ctx1__ = (__ZFI_CREATE_AR_FOR_WMSClient_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__Count = default(System.Int32);
                __ctx1__.__CountStr = default(System.String);
                __ctx1__.__Increase = default(System.Int32);
                __ctx1__.__batchid = default(System.String);
                __ctx1__.__sapbkid = default(System.String);
                __ctx1__.__sapmsg = default(System.String);
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
                if (!ReceiveWMSARReport.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__ARReport_Message != null)
                    __ctx1__.UnrefMessage(__ctx1__.__ARReport_Message);
                __ctx1__.__ARReport_Message = new __messagetype_Kaifa_B2B_Schemas_Wms_ARReport("ARReport_Message", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__ARReport_Message);
                ReceiveWMSARReport.ReceiveMessage(0, __msgEnv__, __ctx1__.__ARReport_Message, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (ReceiveWMSARReport != null)
                {
                    ReceiveWMSARReport.Close(__ctx1__, __seg__);
                    ReceiveWMSARReport = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__ARReport_Message);
                    __edata.PortName = @"ReceiveWMSARReport";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__CountStr = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__batchid = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__sapbkid = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__sapmsg = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __ctx1__.__Count = (System.Int32)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__ARReport_Message.part, "count(/*[local-name()='ARReport' and namespace-uri()='http://Kaifa.B2B.Schemas.WMSAR']/*[local-name()='CustARReport' and namespace-uri()='http://Kaifa.B2B.Schemas.WMSAR'])", typeof(System.Int32));
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                __ctx1__.__CountStr = __ctx1__.__Count.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __ctx1__.__Increase = 1;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                __condition__ = __ctx1__.__Increase <= __ctx1__.__Count;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 42 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 42;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                {
                    __messagetype_Kaifa_B2B_Schemas_Wms_CustARReport __CustARReport_Message = new __messagetype_Kaifa_B2B_Schemas_Wms_CustARReport("CustARReport_Message", __ctx1__);
                    ZfiCreateArForWms __ARRequest = new ZfiCreateArForWms("ARRequest", __ctx1__);

                    __ctx1__.__CountStr = __ctx1__.__Increase.ToString();
                    __CustARReport_Message.part.XPathAssign(__ctx1__.__ARReport_Message.part, "/*[local-name()='ARReport' and namespace-uri()='http://Kaifa.B2B.Schemas.WMSAR']/*[local-name()='CustARReport' and namespace-uri()='http://Kaifa.B2B.Schemas.WMSAR'][" + __ctx1__.__CountStr + "]");
                    ApplyTransform(typeof(Kaifa.B2B.SAP.AR.Map_To_SAPAR), new object[] {__ARRequest.parameters}, new object[] {__CustARReport_Message.part});

                    if (__ctx1__.__CustARReport_Message != null)
                        __ctx1__.UnrefMessage(__ctx1__.__CustARReport_Message);
                    __ctx1__.__CustARReport_Message = __CustARReport_Message;
                    __ctx1__.RefMessage(__ctx1__.__CustARReport_Message);
                    if (__ctx1__.__ARRequest != null)
                        __ctx1__.UnrefMessage(__ctx1__.__ARRequest);
                    __ctx1__.__ARRequest = __ARRequest;
                    __ctx1__.RefMessage(__ctx1__.__ARRequest);
                }
                __ctx1__.__CustARReport_Message.ConstructionCompleteEvent(true);
                __ctx1__.__ARRequest.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__CustARReport_Message);
                    __edata.Messages.Add(__ctx1__.__ARRequest);
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__CustARReport_Message != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CustARReport_Message);
                    __ctx1__.__CustARReport_Message = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                InvokeSAPWebService.SendMessage(0, __ctx1__.__ARRequest, null, null, out __ctx0__.__subWrapper1, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__ARRequest);
                    __edata.PortName = @"InvokeSAPWebService";
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__ARRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ARRequest);
                    __ctx1__.__ARRequest = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if (!InvokeSAPWebService.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__ARResponse != null)
                    __ctx1__.UnrefMessage(__ctx1__.__ARResponse);
                __ctx1__.__ARResponse = new ZfiCreateArForWmsResponse("ARResponse", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__ARResponse);
                InvokeSAPWebService.ReceiveMessage(0, __msgEnv__, __ctx1__.__ARResponse, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__ARResponse);
                    __edata.PortName = @"InvokeSAPWebService";
                    Tracker.FireEvent(__eventLocations[12],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                __ctx1__.__sapbkid = System.Convert.ToString(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__ARResponse.parameters, "string(/*[local-name()='ZfiCreateArForWmsResponse' and namespace-uri()='urn:sap-com:document:sap:soap:functions:mc-style']/*[local-name()='DocumentNumber' and namespace-uri()=''])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                __ctx1__.__batchid = System.Convert.ToString(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__ARResponse.parameters, "string(/*[local-name()='ZfiCreateArForWmsResponse' and namespace-uri()='urn:sap-com:document:sap:soap:functions:mc-style']/*[local-name()='WmsBatchidOut' and namespace-uri()=''])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                __ctx1__.__sapmsg = System.Convert.ToString(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__ARResponse.parameters, "string(/*[local-name()='ZfiCreateArForWmsResponse' and namespace-uri()='urn:sap-com:document:sap:soap:functions:mc-style']/*[local-name()='MsgTab' and namespace-uri()='']/*[local-name()='item' and namespace-uri()='']/*[local-name()='Message' and namespace-uri()=''])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                Kaifa.B2B.Utility.SAPARReturnHelper.Update(__ctx1__.__batchid, __ctx1__.__sapbkid, __ctx1__.__sapmsg);
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 35;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SaveInvokeResult.SendMessage(0, __ctx1__.__ARResponse, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__ARResponse);
                    __edata.PortName = @"SaveInvokeResult";
                    Tracker.FireEvent(__eventLocations[16],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__ARResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ARResponse);
                    __ctx1__.__ARResponse = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 38;
            case 38:
                __ctx1__.__Increase = __ctx1__.__Increase + 1;
                if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 40;
            case 40:
                if ( !PreProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 41;
            case 41:
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__sapmsg = null;
                if (__ctx1__ != null)
                    __ctx1__.__sapbkid = null;
                if (__ctx1__ != null)
                    __ctx1__.__batchid = null;
                if (__ctx1__ != null)
                    __ctx1__.__CountStr = null;
                if (__ctx1__ != null && __ctx1__.__ARReport_Message != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ARReport_Message);
                    __ctx1__.__ARReport_Message = null;
                }
                if (SaveInvokeResult != null)
                {
                    SaveInvokeResult.Close(__ctx1__, __seg__);
                    SaveInvokeResult = null;
                }
                if (InvokeSAPWebService != null)
                {
                    InvokeSAPWebService.Close(__ctx1__, __seg__);
                    InvokeSAPWebService = null;
                }
                Tracker.FireEvent(__eventLocations[19],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 43;
            case 43:
                if ( !PreProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 44;
            case 44:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 45;
            case 45:
                if ( !PreProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 46;
            case 46:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{5BC5F9F3-9105-4685-9C00-8CB3588B6ADF}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __Kaifa_B2B_Schemas_Wms_CustARReport__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Kaifa.B2B.Schemas.Wms.CustARReport _schema = new Kaifa.B2B.Schemas.Wms.CustARReport();

        public __Kaifa_B2B_Schemas_Wms_CustARReport__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Kaifa.B2B.Schemas.Wms.CustARReport",
        new System.Type[]{
            typeof(Kaifa.B2B.Schemas.Wms.CustARReport)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Kaifa_B2B_Schemas_Wms_CustARReport__)
        },
        0,
        @"http://Kaifa.B2B.Schemas.WMSAR#CustARReport"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Kaifa_B2B_Schemas_Wms_CustARReport : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Kaifa_B2B_Schemas_Wms_CustARReport__ part;

        private void __CreatePartWrappers()
        {
            part = new __Kaifa_B2B_Schemas_Wms_CustARReport__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Kaifa_B2B_Schemas_Wms_CustARReport(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
