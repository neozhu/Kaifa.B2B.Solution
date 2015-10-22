namespace Microsoft.Solutions.BTARN.Schemas.RNPIPs {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"GlobalMimeTypeQualifierCode", @"GlobalAttachmentDescriptionCode", @"GlobalPartnerRoleClassificationCode", @"GlobalSupplyChainCode", @"GlobalPartnerClassificationCode", @"GlobalDocumentFunctionCode", @"AffirmationIndicator", @"GlobalProductUnitOfMeasureCode", @"GlobalAssemblyLevelCode", @"GlobalProductLifeCycleStatusCode", @"GlobalABCCode", @"GlobalProductProcurementTypeCode", @"GlobalIntervalCode", @"GlobalLeadTimeClassificationCode", @"GlobalTaxExemptionCode", @"InvoiceChargeTypeCode", 
@"GlobalMonetaryAmountTypeCode", @"GlobalCurrencyCode", @"GlobalTransportEventCode", @"GlobalCustomerTypeCode", @"GlobalSpecialHandlingCode", @"GlobalSpecialFulfillmentRequestCode", @"GlobalShippingServiceLevelCode", @"GlobalShipmentTermsCode", @"GlobalFreeOnBoardCode", @"GlobalCarrierCode", @"GlobalPurchaseOrderTypeCode", @"GlobalPurchaseOrderFillPriorityCode", @"GlobalGovernmentPriorityRatingCode", @"GlobalPaymentConditionCode", @"GlobalFinanceTermsCode", @"GlobalDocumentReferenceTypeCode", 
@"GlobalAccountClassificationCode", @"GlobalCreditCardClassificationCode", @"GlobalCountryCode", @"GlobalProductSubstitutionReasonCode", @"GlobalPurchaseOrderStatusCode", @"GlobalPurchaseOrderAcknowledgmentReasonCode", @"GlobalConfirmationTypeCode"})]
    public sealed class BaseDataTypes : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" targetNamespace=""http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""GlobalMimeTypeQualifierCode"" type=""globalmimetypequalifierCodeType"" />
  <xs:simpleType name=""globalmimetypequalifierCodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""application/activemessage"" />
      <xs:enumeration value=""application/andrew-inset"" />
      <xs:enumeration value=""application/applefile"" />
      <xs:enumeration value=""application/atomicmail"" />
      <xs:enumeration value=""application/batch-SMTP"" />
      <xs:enumeration value=""application/cals-1840"" />
      <xs:enumeration value=""application/commonground"" />
      <xs:enumeration value=""application/cybercash"" />
      <xs:enumeration value=""application/dca-rft"" />
      <xs:enumeration value=""application/dec-dx"" />
      <xs:enumeration value=""application/EDI-Consent"" />
      <xs:enumeration value=""application/EDIFACT"" />
      <xs:enumeration value=""application/EDI-X12"" />
      <xs:enumeration value=""application/eshop"" />
      <xs:enumeration value=""application/http"" />
      <xs:enumeration value=""application/hyperstudio"" />
      <xs:enumeration value=""application/iges"" />
      <xs:enumeration value=""application/index"" />
      <xs:enumeration value=""application/index.cmd"" />
      <xs:enumeration value=""application/index.obj"" />
      <xs:enumeration value=""application/index.response"" />
      <xs:enumeration value=""application/index.vnd"" />
      <xs:enumeration value=""application/ipp"" />
      <xs:enumeration value=""application/mac-binhex40"" />
      <xs:enumeration value=""application/macwriteii"" />
      <xs:enumeration value=""application/marc"" />
      <xs:enumeration value=""application/mathematica"" />
      <xs:enumeration value=""application/msword"" />
      <xs:enumeration value=""application/news-message-id"" />
      <xs:enumeration value=""application/news-transmission"" />
      <xs:enumeration value=""application/ocsp-request"" />
      <xs:enumeration value=""application/ocsp-response"" />
      <xs:enumeration value=""application/octet-stream"" />
      <xs:enumeration value=""application/oda"" />
      <xs:enumeration value=""application/pdf"" />
      <xs:enumeration value=""application/pgp-encrypted"" />
      <xs:enumeration value=""application/pgp-keys"" />
      <xs:enumeration value=""application/pgp-signature"" />
      <xs:enumeration value=""application/pkcs10"" />
      <xs:enumeration value=""application/pkcs7-mime"" />
      <xs:enumeration value=""application/pkcs7-signature"" />
      <xs:enumeration value=""application/pkix-cert"" />
      <xs:enumeration value=""application/pkixcmp"" />
      <xs:enumeration value=""application/pkix-crl"" />
      <xs:enumeration value=""application/postscript"" />
      <xs:enumeration value=""application/prs.alvestrand.titrax-sheet"" />
      <xs:enumeration value=""application/prs.cww"" />
      <xs:enumeration value=""application/prs.nprend"" />
      <xs:enumeration value=""application/remote-printing"" />
      <xs:enumeration value=""application/riscos"" />
      <xs:enumeration value=""application/rtf"" />
      <xs:enumeration value=""application/sdp"" />
      <xs:enumeration value=""application/set-payment"" />
      <xs:enumeration value=""application/set-payment-initiation"" />
      <xs:enumeration value=""application/set-registration"" />
      <xs:enumeration value=""application/set-registration-initiation"" />
      <xs:enumeration value=""application/sgml"" />
      <xs:enumeration value=""application/sgml-open-catalog"" />
      <xs:enumeration value=""application/slate"" />
      <xs:enumeration value=""application/vemmi"" />
      <xs:enumeration value=""application/vnd.$commerce_battelle"" />
      <xs:enumeration value=""application/vnd.3M.Post-it-Notes"" />
      <xs:enumeration value=""application/vnd.accpac.simply.aso"" />
      <xs:enumeration value=""application/vnd.accpac.simply.imp"" />
      <xs:enumeration value=""application/vnd.acucobol"" />
      <xs:enumeration value=""application/vnd.anser-web-certificate-issue-initiation"" />
      <xs:enumeration value=""application/vnd.anser-web-funds-transfer-initiation"" />
      <xs:enumeration value=""application/vnd.audiograph"" />
      <xs:enumeration value=""application/vnd.businessobjects"" />
      <xs:enumeration value=""application/vnd.claymore"" />
      <xs:enumeration value=""application/vnd.commonspace"" />
      <xs:enumeration value=""application/vnd.comsocaller"" />
      <xs:enumeration value=""application/vnd.cups-postscript"" />
      <xs:enumeration value=""application/vnd.cups-raster"" />
      <xs:enumeration value=""application/vnd.cups-raw"" />
      <xs:enumeration value=""application/vnd.cybank"" />
      <xs:enumeration value=""application/vnd.dna"" />
      <xs:enumeration value=""application/vnd.dpgraph"" />
      <xs:enumeration value=""application/vnd.dxr"" />
      <xs:enumeration value=""application/vnd.ecdis-update"" />
      <xs:enumeration value=""application/vnd.ecowin.chart"" />
      <xs:enumeration value=""application/vnd.ecowin.filerequest"" />
      <xs:enumeration value=""application/vnd.ecowin.fileupdate"" />
      <xs:enumeration value=""application/vnd.ecowin.series"" />
      <xs:enumeration value=""application/vnd.ecowin.seriesrequest"" />
      <xs:enumeration value=""application/vnd.ecowin.seriesupdate"" />
      <xs:enumeration value=""application/vnd.enliven"" />
      <xs:enumeration value=""application/vnd.epson.msf"" />
      <xs:enumeration value=""application/vnd.epson.quickanime"" />
      <xs:enumeration value=""application/vnd.epson.salt"" />
      <xs:enumeration value=""application/vnd.epson.ssf"" />
      <xs:enumeration value=""application/vnd.fdf"" />
      <xs:enumeration value=""application/vnd.ffsns"" />
      <xs:enumeration value=""application/vnd.FloGraphIt"" />
      <xs:enumeration value=""application/vnd.framemaker"" />
      <xs:enumeration value=""application/vnd.fujitsu.oasys"" />
      <xs:enumeration value=""application/vnd.fujitsu.oasys2"" />
      <xs:enumeration value=""application/vnd.fujitsu.oasys3"" />
      <xs:enumeration value=""application/vnd.fujitsu.oasysgp"" />
      <xs:enumeration value=""application/vnd.fujitsu.oasysprs"" />
      <xs:enumeration value=""application/vnd.fujixerox.docuworks"" />
      <xs:enumeration value=""application/vnd.fut-misnet"" />
      <xs:enumeration value=""application/vnd.hp-HPGL"" />
      <xs:enumeration value=""application/vnd.hp-hpid"" />
      <xs:enumeration value=""application/vnd.hp-hps"" />
      <xs:enumeration value=""application/vnd.hp-PCL"" />
      <xs:enumeration value=""application/vnd.hp-PCLXL"" />
      <xs:enumeration value=""application/vnd.ibm.MiniPay"" />
      <xs:enumeration value=""application/vnd.ibm.modcap"" />
      <xs:enumeration value=""application/vnd.intercon.formnet"" />
      <xs:enumeration value=""application/vnd.intertrust.digibox"" />
      <xs:enumeration value=""application/vnd.intertrust.nncp"" />
      <xs:enumeration value=""application/vnd.intu.qbo"" />
      <xs:enumeration value=""application/vnd.intu.qfx"" />
      <xs:enumeration value=""application/vnd.is-xpr"" />
      <xs:enumeration value=""application/vnd.japannet-directory-service"" />
      <xs:enumeration value=""application/vnd.japannet-jpnstore-wakeup"" />
      <xs:enumeration value=""application/vnd.japannet-payment-wakeup"" />
      <xs:enumeration value=""application/vnd.japannet-registration"" />
      <xs:enumeration value=""application/vnd.japannet-registration-wakeup"" />
      <xs:enumeration value=""application/vnd.japannet-setstore-wakeup"" />
      <xs:enumeration value=""application/vnd.japannet-verification"" />
      <xs:enumeration value=""application/vnd.japannet-verification-wakeup"" />
      <xs:enumeration value=""application/vnd.koan"" />
      <xs:enumeration value=""application/vnd.lotus-1-2-3"" />
      <xs:enumeration value=""application/vnd.lotus-approach"" />
      <xs:enumeration value=""application/vnd.lotus-freelance"" />
      <xs:enumeration value=""application/vnd.lotus-notes"" />
      <xs:enumeration value=""application/vnd.lotus-organizer"" />
      <xs:enumeration value=""application/vnd.lotus-screencam"" />
      <xs:enumeration value=""application/vnd.lotus-wordpro"" />
      <xs:enumeration value=""application/vnd.mediastation.cdkey"" />
      <xs:enumeration value=""application/vnd.meridian-slingshot"" />
      <xs:enumeration value=""application/vnd.mif"" />
      <xs:enumeration value=""application/vnd.minisoft-hp3000-save"" />
      <xs:enumeration value=""application/vnd.mitsubishi.misty-guard.trustweb"" />
      <xs:enumeration value=""application/vnd.Mobius.DAF"" />
      <xs:enumeration value=""application/vnd.Mobius.DIS"" />
      <xs:enumeration value=""application/vnd.Mobius.MSL"" />
      <xs:enumeration value=""application/vnd.Mobius.PLC"" />
      <xs:enumeration value=""application/vnd.Mobius.TXF"" />
      <xs:enumeration value=""application/vnd.motorola.flexsuite"" />
      <xs:enumeration value=""application/vnd.motorola.flexsuite.adsi"" />
      <xs:enumeration value=""application/vnd.motorola.flexsuite.fis"" />
      <xs:enumeration value=""application/vnd.motorola.flexsuite.gotap"" />
      <xs:enumeration value=""application/vnd.motorola.flexsuite.kmr"" />
      <xs:enumeration value=""application/vnd.motorola.flexsuite.ttc"" />
      <xs:enumeration value=""application/vnd.motorola.flexsuite.wem"" />
      <xs:enumeration value=""application/vnd.ms-artgalry"" />
      <xs:enumeration value=""application/vnd.ms-asf"" />
      <xs:enumeration value=""application/vnd.ms-excel"" />
      <xs:enumeration value=""application/vnd.ms-powerpoint"" />
      <xs:enumeration value=""application/vnd.ms-project"" />
      <xs:enumeration value=""application/vnd.ms-tnef"" />
      <xs:enumeration value=""application/vnd.ms-works"" />
      <xs:enumeration value=""application/vnd.musician"" />
      <xs:enumeration value=""application/vnd.music-niff"" />
      <xs:enumeration value=""application/vnd.netfpx"" />
      <xs:enumeration value=""application/vnd.noblenet-directory"" />
      <xs:enumeration value=""application/vnd.noblenet-sealer"" />
      <xs:enumeration value=""application/vnd.noblenet-web"" />
      <xs:enumeration value=""application/vnd.novadigm.EDM"" />
      <xs:enumeration value=""application/vnd.novadigm.EDX"" />
      <xs:enumeration value=""application/vnd.novadigm.EXT"" />
      <xs:enumeration value=""application/vnd.osa.netdeploy"" />
      <xs:enumeration value=""application/vnd.pg.format"" />
      <xs:enumeration value=""application/vnd.pg.osasli"" />
      <xs:enumeration value=""application/vnd.powerbuilder6"" />
      <xs:enumeration value=""application/vnd.powerbuilder6-s"" />
      <xs:enumeration value=""application/vnd.powerbuilder7"" />
      <xs:enumeration value=""application/vnd.powerbuilder75"" />
      <xs:enumeration value=""application/vnd.powerbuilder75-s"" />
      <xs:enumeration value=""application/vnd.powerbuilder7-s"" />
      <xs:enumeration value=""application/vnd.previewsystems.box"" />
      <xs:enumeration value=""application/vnd.publishare-delta-tree"" />
      <xs:enumeration value=""application/vnd.rapid"" />
      <xs:enumeration value=""application/vnd.seemail"" />
      <xs:enumeration value=""application/vnd.shana.informed.formdata"" />
      <xs:enumeration value=""application/vnd.shana.informed.formtemplate"" />
      <xs:enumeration value=""application/vnd.shana.informed.interchange"" />
      <xs:enumeration value=""application/vnd.shana.informed.package"" />
      <xs:enumeration value=""application/vnd.street-stream"" />
      <xs:enumeration value=""application/vnd.svd"" />
      <xs:enumeration value=""application/vnd.swiftview-ics"" />
      <xs:enumeration value=""application/vnd.triscape.mxs"" />
      <xs:enumeration value=""application/vnd.truedoc"" />
      <xs:enumeration value=""application/vnd.ufdl"" />
      <xs:enumeration value=""application/vnd.uplanet.alert"" />
      <xs:enumeration value=""application/vnd.uplanet.alert-wbxml"" />
      <xs:enumeration value=""application/vnd.uplanet.bearer-choice"" />
      <xs:enumeration value=""application/vnd.uplanet.bearer-choice-wbxml"" />
      <xs:enumeration value=""application/vnd.uplanet.cacheop"" />
      <xs:enumeration value=""application/vnd.uplanet.cacheop-wbmxl"" />
      <xs:enumeration value=""application/vnd.uplanet.channel"" />
      <xs:enumeration value=""application/vnd.uplanet.channel-wbxml"" />
      <xs:enumeration value=""application/vnd.uplanet.list"" />
      <xs:enumeration value=""application/vnd.uplanet.listcmd"" />
      <xs:enumeration value=""application/vnd.uplanet.listcmd-wbxml"" />
      <xs:enumeration value=""application/vnd.uplanet.list-wbxml"" />
      <xs:enumeration value=""application/vnd.uplanet.signal"" />
      <xs:enumeration value=""application/vnd.vcx"" />
      <xs:enumeration value=""application/vnd.visio"" />
      <xs:enumeration value=""application/vnd.wap.wbxml"" />
      <xs:enumeration value=""application/vnd.wap.wmlc"" />
      <xs:enumeration value=""application/vnd.wap.wmlscriptc"" />
      <xs:enumeration value=""application/vnd.webturbo"" />
      <xs:enumeration value=""application/vnd.wrq-hp3000-labelled"" />
      <xs:enumeration value=""application/vnd.wt.stf"" />
      <xs:enumeration value=""application/vnd.xara"" />
      <xs:enumeration value=""application/vnd.xfdl"" />
      <xs:enumeration value=""application/vnd.yellowriver-custom-menu+A91"" />
      <xs:enumeration value=""application/wita"" />
      <xs:enumeration value=""application/wordperfect5.1"" />
      <xs:enumeration value=""application/x400-bp"" />
      <xs:enumeration value=""application/xml"" />
      <xs:enumeration value=""application/zip"" />
      <xs:enumeration value=""audio/32kadpcm"" />
      <xs:enumeration value=""audio/basic"" />
      <xs:enumeration value=""audio/L16"" />
      <xs:enumeration value=""audio/vnd.cns.anp1"" />
      <xs:enumeration value=""audio/vnd.cns.inf1"" />
      <xs:enumeration value=""audio/vnd.digital-winds"" />
      <xs:enumeration value=""audio/vnd.lucent.voice"" />
      <xs:enumeration value=""audio/vnd.nortel.vbk"" />
      <xs:enumeration value=""audio/vnd.octel.sbc"" />
      <xs:enumeration value=""audio/vnd.qcelp"" />
      <xs:enumeration value=""audio/vnd.rhetorex.32kadpcm"" />
      <xs:enumeration value=""audio/vnd.vmx.cvsd"" />
      <xs:enumeration value=""image/cgm"" />
      <xs:enumeration value=""image/g3fax"" />
      <xs:enumeration value=""image/gif"" />
      <xs:enumeration value=""image/ief"" />
      <xs:enumeration value=""image/jpeg"" />
      <xs:enumeration value=""image/naplps"" />
      <xs:enumeration value=""image/png"" />
      <xs:enumeration value=""image/prs.btif"" />
      <xs:enumeration value=""image/prs.pti"" />
      <xs:enumeration value=""image/tiff"" />
      <xs:enumeration value=""image/vnd.cns.inf2"" />
      <xs:enumeration value=""image/vnd.dwg"" />
      <xs:enumeration value=""image/vnd.dxf"" />
      <xs:enumeration value=""image/vnd.fastbidsheet"" />
      <xs:enumeration value=""image/vnd.fpx"" />
      <xs:enumeration value=""image/vnd.mix"" />
      <xs:enumeration value=""image/vnd.net-fpx"" />
      <xs:enumeration value=""image/vnd.svf"" />
      <xs:enumeration value=""image/vnd.wap.wbmp"" />
      <xs:enumeration value=""image/vnd.xiff"" />
      <xs:enumeration value=""message/delivery-status"" />
      <xs:enumeration value=""message/disposition-notification"" />
      <xs:enumeration value=""message/external-body"" />
      <xs:enumeration value=""message/http"" />
      <xs:enumeration value=""message/news"" />
      <xs:enumeration value=""message/partial"" />
      <xs:enumeration value=""message/rfc822"" />
      <xs:enumeration value=""message/s-http"" />
      <xs:enumeration value=""model/iges"" />
      <xs:enumeration value=""model/mesh"" />
      <xs:enumeration value=""model/vnd.dwf"" />
      <xs:enumeration value=""model/vnd.flatland.3dml"" />
      <xs:enumeration value=""model/vnd.gtw"" />
      <xs:enumeration value=""model/vrml"" />
      <xs:enumeration value=""multipart/alternative"" />
      <xs:enumeration value=""multipart/appledouble"" />
      <xs:enumeration value=""multipart/byteranges"" />
      <xs:enumeration value=""multipart/digest"" />
      <xs:enumeration value=""multipart/encrypted"" />
      <xs:enumeration value=""multipart/form-data"" />
      <xs:enumeration value=""multipart/header-set"" />
      <xs:enumeration value=""multipart/mixed"" />
      <xs:enumeration value=""multipart/parallel"" />
      <xs:enumeration value=""multipart/related"" />
      <xs:enumeration value=""multipart/report"" />
      <xs:enumeration value=""multipart/signed"" />
      <xs:enumeration value=""multipart/voice-message"" />
      <xs:enumeration value=""text/calendar"" />
      <xs:enumeration value=""text/css"" />
      <xs:enumeration value=""text/directory"" />
      <xs:enumeration value=""text/enriched"" />
      <xs:enumeration value=""text/html"" />
      <xs:enumeration value=""text/plain"" />
      <xs:enumeration value=""text/prs.lines.tag"" />
      <xs:enumeration value=""text/rfc822-headers"" />
      <xs:enumeration value=""text/richtext"" />
      <xs:enumeration value=""text/rtf"" />
      <xs:enumeration value=""text/sgml"" />
      <xs:enumeration value=""text/tab-separated-values"" />
      <xs:enumeration value=""text/uri-list"" />
      <xs:enumeration value=""text/vnd.abc"" />
      <xs:enumeration value=""text/vnd.fly"" />
      <xs:enumeration value=""text/vnd.fmi.flexstor"" />
      <xs:enumeration value=""text/vnd.in3d.3dml"" />
      <xs:enumeration value=""text/vnd.in3d.spot"" />
      <xs:enumeration value=""text/vnd.latex-z"" />
      <xs:enumeration value=""text/vnd.motorola.reflex"" />
      <xs:enumeration value=""text/vnd.wap.wml"" />
      <xs:enumeration value=""text/vnd.wap.wmlscript"" />
      <xs:enumeration value=""text/xml"" />
      <xs:enumeration value=""video/mpeg"" />
      <xs:enumeration value=""video/quicktime"" />
      <xs:enumeration value=""video/vnd.motorola.video"" />
      <xs:enumeration value=""video/vnd.motorola.videop"" />
      <xs:enumeration value=""video/vnd.vivo"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalAttachmentDescriptionCode"" type=""globalattachmentdescriptioncodeType"" />
  <xs:simpleType name=""globalattachmentdescriptioncodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Assembly drawings"" />
      <xs:enumeration value=""Assembly/fabrication instructions"" />
      <xs:enumeration value=""Block diagrams"" />
      <xs:enumeration value=""Blueprints"" />
      <xs:enumeration value=""BOM"" />
      <xs:enumeration value=""CAD information"" />
      <xs:enumeration value=""Logistics"" />
      <xs:enumeration value=""Quality data"" />
      <xs:enumeration value=""Sample plan"" />
      <xs:enumeration value=""Schematics"" />
      <xs:enumeration value=""Test instructions"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalPartnerRoleClassificationCode"" type=""globalpartnerroleclassificationcodeType"" />
  <xs:simpleType name=""globalpartnerroleclassificationcodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Account Supplier"" />
      <xs:enumeration value=""Account User"" />
      <xs:enumeration value=""Anonymous Buyer"" />
      <xs:enumeration value=""Appointment Provider"" />
      <xs:enumeration value=""Authorizer"" />
      <xs:enumeration value=""Buyer"" />
      <xs:enumeration value=""Catalog Distributor"" />
      <xs:enumeration value=""Catalog Producer"" />
      <xs:enumeration value=""Change Requester"" />
      <xs:enumeration value=""Change Review Forum"" />
      <xs:enumeration value=""Claim Requester"" />
      <xs:enumeration value=""Consignee"" />
      <xs:enumeration value=""Credit Provider"" />
      <xs:enumeration value=""Credit Reference Requester"" />
      <xs:enumeration value=""Customer"" />
      <xs:enumeration value=""Customer Manager"" />
      <xs:enumeration value=""Decision Stakeholder"" />
      <xs:enumeration value=""Delivery Appointment Provider"" />
      <xs:enumeration value=""Delivery Appointment Requester"" />
      <xs:enumeration value=""Demand Creator"" />
      <xs:enumeration value=""Failure Report Administrator"" />
      <xs:enumeration value=""Financing Processor"" />
      <xs:enumeration value=""Forecast Owner"" />
      <xs:enumeration value=""Forecast Recipient"" />
      <xs:enumeration value=""Forecast Reply Recipient"" />
      <xs:enumeration value=""Implementation Plan Creator"" />
      <xs:enumeration value=""Initiator"" />
      <xs:enumeration value=""In-transit Information User"" />
      <xs:enumeration value=""Invoice Provider"" />
      <xs:enumeration value=""Invoice Receiver"" />
      <xs:enumeration value=""Invoice Reject Provider"" />
      <xs:enumeration value=""Invoice Reject Receiver"" />
      <xs:enumeration value=""Marketing Activity Information User"" />
      <xs:enumeration value=""Marketing Activity Initiator"" />
      <xs:enumeration value=""Payee"" />
      <xs:enumeration value=""Payer"" />
      <xs:enumeration value=""PIP Failure Notifier"" />
      <xs:enumeration value=""Product Distributor"" />
      <xs:enumeration value=""Product Information Distributor"" />
      <xs:enumeration value=""Product Information Subscriber"" />
      <xs:enumeration value=""Product Information User"" />
      <xs:enumeration value=""Product Provider"" />
      <xs:enumeration value=""Product Supplier"" />
      <xs:enumeration value=""Receiver"" />
      <xs:enumeration value=""Responder"" />
      <xs:enumeration value=""Return Provider"" />
      <xs:enumeration value=""Return Receiver"" />
      <xs:enumeration value=""Return Requester"" />
      <xs:enumeration value=""Sales Facilitator"" />
      <xs:enumeration value=""Sales Lead Originator"" />
      <xs:enumeration value=""Sales Lead Processor"" />
      <xs:enumeration value=""Sales Marketing Claim Processor"" />
      <xs:enumeration value=""Sales Marketing Claimant"" />
      <xs:enumeration value=""Sales Marketing Program Reimbursement Recipient"" />
      <xs:enumeration value=""Sales Marketing Program Reimburser"" />
      <xs:enumeration value=""Seller"" />
      <xs:enumeration value=""Shipment Information User"" />
      <xs:enumeration value=""Shipment Requester"" />
      <xs:enumeration value=""ShipmentController"" />
      <xs:enumeration value=""Shipper"" />
      <xs:enumeration value=""Solution Provider"" />
      <xs:enumeration value=""Solution Requester"" />
      <xs:enumeration value=""Specification Provider"" />
      <xs:enumeration value=""Specification User"" />
      <xs:enumeration value=""Stakeholder"" />
      <xs:enumeration value=""Status Requester"" />
      <xs:enumeration value=""Status Responder"" />
      <xs:enumeration value=""Supplier"" />
      <xs:enumeration value=""Tender Information User"" />
      <xs:enumeration value=""Transport Service Provider"" />
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalSupplyChainCode"" type=""globalsupplychaincodeType"" />
  <xs:simpleType name=""globalsupplychaincodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Electronic Components"" />
      <xs:enumeration value=""Information Technology"" />
      <xs:enumeration value=""Semiconductor Manufacturing"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalPartnerClassificationCode"" type=""globalpartnerclassificationcodeType"" />
  <xs:simpleType name=""globalpartnerclassificationcodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Authorized Service Provider"" />
      <xs:enumeration value=""Broker"" />
      <xs:enumeration value=""Carrier"" />
      <xs:enumeration value=""Contract Manufacturer"" />
      <xs:enumeration value=""Customs Broker"" />
      <xs:enumeration value=""Distribution Center"" />
      <xs:enumeration value=""Distributor"" />
      <xs:enumeration value=""End User"" />
      <xs:enumeration value=""End User Government"" />
      <xs:enumeration value=""Financier"" />
      <xs:enumeration value=""Freight Forwarder"" />
      <xs:enumeration value=""Manufacturer"" />
      <xs:enumeration value=""Original Equipment Manufacturer"" />
      <xs:enumeration value=""Quality Data Provider"" />
      <xs:enumeration value=""Quality Data User"" />
      <xs:enumeration value=""Reseller"" />
      <xs:enumeration value=""Retailer"" />
      <xs:enumeration value=""Shopper"" />
      <xs:enumeration value=""Warehouser"" />
      <xs:enumeration value=""Warranty Provider"" />
      <xs:enumeration value=""Forecast Reply Recipient"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalDocumentFunctionCode"" type=""globaldocumentfunctioncodeType"" />
  <xs:simpleType name=""globaldocumentfunctioncodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Request"" />
      <xs:enumeration value=""Response"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""AffirmationIndicator"" type=""affirmationindicatorType"" />
  <xs:simpleType name=""affirmationindicatorType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Yes"" />
      <xs:enumeration value=""No"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalProductUnitOfMeasureCode"" type=""globalproductunitofmeasurecodeType"" />
  <xs:simpleType name=""globalproductunitofmeasurecodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""10 Kilogram Drum"" />
      <xs:enumeration value=""10,000 Gallon Tankcar"" />
      <xs:enumeration value=""100 Board Feet"" />
      <xs:enumeration value=""100 Pound Drum"" />
      <xs:enumeration value=""1000-pack"" />
      <xs:enumeration value=""100-Pack"" />
      <xs:enumeration value=""10-pack"" />
      <xs:enumeration value=""115 Kilogram Drum"" />
      <xs:enumeration value=""15 Kilogram Drum"" />
      <xs:enumeration value=""20 Foot Container"" />
      <xs:enumeration value=""20,000 Gallon Tankcar"" />
      <xs:enumeration value=""20-Pack"" />
      <xs:enumeration value=""25 Kilogram Bulk Bag"" />
      <xs:enumeration value=""300 Kilogram Bulk Bag"" />
      <xs:enumeration value=""40 Foot Container"" />
      <xs:enumeration value=""50 Pound Bag"" />
      <xs:enumeration value=""500 Kilogram Bulk Bag"" />
      <xs:enumeration value=""50-pack"" />
      <xs:enumeration value=""55 Gallon Drum"" />
      <xs:enumeration value=""Acre"" />
      <xs:enumeration value=""Actual Pounds"" />
      <xs:enumeration value=""Aluminum Pounds Only"" />
      <xs:enumeration value=""Ampere"" />
      <xs:enumeration value=""Bag"" />
      <xs:enumeration value=""Bale"" />
      <xs:enumeration value=""Ball"" />
      <xs:enumeration value=""Band"" />
      <xs:enumeration value=""Bar"" />
      <xs:enumeration value=""Barrel"" />
      <xs:enumeration value=""Barrel, Imperial"" />
      <xs:enumeration value=""Barrels Per Day"" />
      <xs:enumeration value=""Barrels Per Minute"" />
      <xs:enumeration value=""Base Box"" />
      <xs:enumeration value=""Base Weight"" />
      <xs:enumeration value=""Basket"" />
      <xs:enumeration value=""Batch"" />
      <xs:enumeration value=""Batt"" />
      <xs:enumeration value=""Batting Pound"" />
      <xs:enumeration value=""Beam"" />
      <xs:enumeration value=""Becquerel/kilogram"" />
      <xs:enumeration value=""Belt"" />
      <xs:enumeration value=""Billet"" />
      <xs:enumeration value=""Bin"" />
      <xs:enumeration value=""Block"" />
      <xs:enumeration value=""Board"" />
      <xs:enumeration value=""Board Feet"" />
      <xs:enumeration value=""Bolt"" />
      <xs:enumeration value=""Bottle"" />
      <xs:enumeration value=""Box"" />
      <xs:enumeration value=""British Thermal Unit (BTU)"" />
      <xs:enumeration value=""British Thermal Units (BTUs) Per Cubic Foot"" />
      <xs:enumeration value=""British Thermal Units (BTUs) Per Pound"" />
      <xs:enumeration value=""Bucket"" />
      <xs:enumeration value=""Bulk"" />
      <xs:enumeration value=""Bulk Car Load"" />
      <xs:enumeration value=""Bulk Pack"" />
      <xs:enumeration value=""Bundle"" />
      <xs:enumeration value=""Bunks"" />
      <xs:enumeration value=""Bushel"" />
      <xs:enumeration value=""Bushel, Dry Imperial"" />
      <xs:enumeration value=""Calorie"" />
      <xs:enumeration value=""Can"" />
      <xs:enumeration value=""Candela"" />
      <xs:enumeration value=""Canister"" />
      <xs:enumeration value=""Car"" />
      <xs:enumeration value=""Carat"" />
      <xs:enumeration value=""Carboy"" />
      <xs:enumeration value=""Card"" />
      <xs:enumeration value=""Carload"" />
      <xs:enumeration value=""Carton"" />
      <xs:enumeration value=""Cartridge"" />
      <xs:enumeration value=""Case"" />
      <xs:enumeration value=""Cask"" />
      <xs:enumeration value=""Cassette"" />
      <xs:enumeration value=""Catchweight"" />
      <xs:enumeration value=""Cell"" />
      <xs:enumeration value=""Centiliter"" />
      <xs:enumeration value=""Centimeter"" />
      <xs:enumeration value=""Centipoise (CPS)"" />
      <xs:enumeration value=""Chains (Land Survey)"" />
      <xs:enumeration value=""Chest"" />
      <xs:enumeration value=""Coil"" />
      <xs:enumeration value=""Coil Group"" />
      <xs:enumeration value=""Composite Product Pounds (Total Weight)"" />
      <xs:enumeration value=""Cone"" />
      <xs:enumeration value=""Connector"" />
      <xs:enumeration value=""Container"" />
      <xs:enumeration value=""Cover"" />
      <xs:enumeration value=""Crate"" />
      <xs:enumeration value=""Cubic centimeter"" />
      <xs:enumeration value=""Cubic centimeter/second"" />
      <xs:enumeration value=""Cubic Foot"" />
      <xs:enumeration value=""Cubic inch"" />
      <xs:enumeration value=""Cubic yard"" />
      <xs:enumeration value=""Cubicmeter"" />
      <xs:enumeration value=""Cup"" />
      <xs:enumeration value=""Cycles"" />
      <xs:enumeration value=""Cylinder"" />
      <xs:enumeration value=""Day"" />
      <xs:enumeration value=""Deal"" />
      <xs:enumeration value=""Decimeter"" />
      <xs:enumeration value=""Degree Celsius"" />
      <xs:enumeration value=""Degree Fahrenheit"" />
      <xs:enumeration value=""Dep. Factor"" />
      <xs:enumeration value=""Die"" />
      <xs:enumeration value=""Disk (Disc)"" />
      <xs:enumeration value=""Dispenser"" />
      <xs:enumeration value=""Display"" />
      <xs:enumeration value=""Dozen"" />
      <xs:enumeration value=""Dram"" />
      <xs:enumeration value=""Drum"" />
      <xs:enumeration value=""Dry Pounds"" />
      <xs:enumeration value=""Each"" />
      <xs:enumeration value=""Electrical Capacitance"" />
      <xs:enumeration value=""Fluid Ounce"" />
      <xs:enumeration value=""Fluid Ounce (Imperial)"" />
      <xs:enumeration value=""Fluid Ounce US"" />
      <xs:enumeration value=""Foot"" />
      <xs:enumeration value=""Fuel Usage (Gallons)"" />
      <xs:enumeration value=""Gage Systems"" />
      <xs:enumeration value=""Gallon"" />
      <xs:enumeration value=""Gigajoules"" />
      <xs:enumeration value=""Gill (Imperial)"" />
      <xs:enumeration value=""Grain"" />
      <xs:enumeration value=""Gram"" />
      <xs:enumeration value=""Gram/Cubic Centimeter"" />
      <xs:enumeration value=""Gram/square meter"" />
      <xs:enumeration value=""Grams Per 100 Centimeters"" />
      <xs:enumeration value=""Grams Per 100 Grams"" />
      <xs:enumeration value=""Grams Per Cubic Centimeter"" />
      <xs:enumeration value=""Grams Per Kilogram"" />
      <xs:enumeration value=""Grams Per Liter"" />
      <xs:enumeration value=""Grams Per Milliliter"" />
      <xs:enumeration value=""Grams Per Square Centimeter"" />
      <xs:enumeration value=""Grams Per Square Meter"" />
      <xs:enumeration value=""Great Gross (Dozen Gross)"" />
      <xs:enumeration value=""Gross"" />
      <xs:enumeration value=""Gross Barrels"" />
      <xs:enumeration value=""Gross Gallons"" />
      <xs:enumeration value=""Gross Kilogram"" />
      <xs:enumeration value=""Gross Ton"" />
      <xs:enumeration value=""Gross Yard"" />
      <xs:enumeration value=""Group"" />
      <xs:enumeration value=""Half Gallon"" />
      <xs:enumeration value=""Half Hour"" />
      <xs:enumeration value=""Half Liter"" />
      <xs:enumeration value=""Hank"" />
      <xs:enumeration value=""Heat lots"" />
      <xs:enumeration value=""Hectare"" />
      <xs:enumeration value=""Hectoliter"" />
      <xs:enumeration value=""Hectopascal"" />
      <xs:enumeration value=""Hertz"" />
      <xs:enumeration value=""Hour"" />
      <xs:enumeration value=""Hours"" />
      <xs:enumeration value=""Hundred Boxes"" />
      <xs:enumeration value=""Hundred Count"" />
      <xs:enumeration value=""Hundred Sheets"" />
      <xs:enumeration value=""Hundredth of a Carat"" />
      <xs:enumeration value=""Imperial Gallons"" />
      <xs:enumeration value=""Inch"" />
      <xs:enumeration value=""Jar"" />
      <xs:enumeration value=""Joint"" />
      <xs:enumeration value=""Joule"" />
      <xs:enumeration value=""Keg"" />
      <xs:enumeration value=""Kelvin"" />
      <xs:enumeration value=""Kiloampere"" />
      <xs:enumeration value=""Kilobecquerel/Kilogram"" />
      <xs:enumeration value=""Kilogram"" />
      <xs:enumeration value=""Kilogram per cubic meter"" />
      <xs:enumeration value=""Kilogram/Kilogram"" />
      <xs:enumeration value=""Kilogram/square meter"" />
      <xs:enumeration value=""Kilogramm pro Sekunde"" />
      <xs:enumeration value=""Kilohertz"" />
      <xs:enumeration value=""Kilojoule"" />
      <xs:enumeration value=""Kilometer"" />
      <xs:enumeration value=""Kilometer/hour"" />
      <xs:enumeration value=""Kiloohm"" />
      <xs:enumeration value=""Kilovolt"" />
      <xs:enumeration value=""Kilowatt"" />
      <xs:enumeration value=""Kilowatt-hour"" />
      <xs:enumeration value=""Kit"" />
      <xs:enumeration value=""Kubikdezimeter"" />
      <xs:enumeration value=""Kubikmeter pro Sekunde"" />
      <xs:enumeration value=""Lifts"" />
      <xs:enumeration value=""Link"" />
      <xs:enumeration value=""Liquid Pounds"" />
      <xs:enumeration value=""Liter"" />
      <xs:enumeration value=""Load"" />
      <xs:enumeration value=""Lot"" />
      <xs:enumeration value=""Lug"" />
      <xs:enumeration value=""Mat"" />
      <xs:enumeration value=""Megagram"" />
      <xs:enumeration value=""Megagrams Per Hour"" />
      <xs:enumeration value=""Megahertz"" />
      <xs:enumeration value=""Megapascal"" />
      <xs:enumeration value=""Megawatt"" />
      <xs:enumeration value=""Meter"" />
      <xs:enumeration value=""Meter pro Quadratsekunde"" />
      <xs:enumeration value=""Meters per second"" />
      <xs:enumeration value=""Micrograms Per Cubic Meter"" />
      <xs:enumeration value=""Micrometer"" />
      <xs:enumeration value=""Microsecond"" />
      <xs:enumeration value=""Mikrogram/cubic meter"" />
      <xs:enumeration value=""Mile"" />
      <xs:enumeration value=""Milliampere"" />
      <xs:enumeration value=""Millibar"" />
      <xs:enumeration value=""Milligram/cubic meter"" />
      <xs:enumeration value=""Milligram/kilogram"" />
      <xs:enumeration value=""Milligram/Liter"" />
      <xs:enumeration value=""Milligrams Per Cubic Meter"" />
      <xs:enumeration value=""Milligrams Per Square Meter"" />
      <xs:enumeration value=""Millijoule"" />
      <xs:enumeration value=""Milliliter"" />
      <xs:enumeration value=""Millimeter"" />
      <xs:enumeration value=""Millimeter H20"" />
      <xs:enumeration value=""Millimol"" />
      <xs:enumeration value=""Millimol/kilogram"" />
      <xs:enumeration value=""Million BTU's"" />
      <xs:enumeration value=""Millipascal seconds"" />
      <xs:enumeration value=""Millisecond"" />
      <xs:enumeration value=""Millitesla"" />
      <xs:enumeration value=""Millivolt"" />
      <xs:enumeration value=""Milliwatt"" />
      <xs:enumeration value=""Minute"" />
      <xs:enumeration value=""Miter"" />
      <xs:enumeration value=""Mol"" />
      <xs:enumeration value=""Mol/kilogram"" />
      <xs:enumeration value=""Month"" />
      <xs:enumeration value=""Multichip"" />
      <xs:enumeration value=""Nanometer"" />
      <xs:enumeration value=""Nanosecond"" />
      <xs:enumeration value=""Net Barrels"" />
      <xs:enumeration value=""Net Gallons"" />
      <xs:enumeration value=""Net Imperial Gallons"" />
      <xs:enumeration value=""Net Liters"" />
      <xs:enumeration value=""Newton"" />
      <xs:enumeration value=""Ohm"" />
      <xs:enumeration value=""One"" />
      <xs:enumeration value=""One Thousand Pieces"" />
      <xs:enumeration value=""Ounce"" />
      <xs:enumeration value=""Ounce"" />
      <xs:enumeration value=""Pack (PAK)"" />
      <xs:enumeration value=""Package"" />
      <xs:enumeration value=""Packet"" />
      <xs:enumeration value=""Pad"" />
      <xs:enumeration value=""Pail"" />
      <xs:enumeration value=""Pair"" />
      <xs:enumeration value=""Pallet"" />
      <xs:enumeration value=""Pallet (Lift)"" />
      <xs:enumeration value=""Pallet/Unit Load"" />
      <xs:enumeration value=""Pallete"" />
      <xs:enumeration value=""Panel"" />
      <xs:enumeration value=""Parcel"" />
      <xs:enumeration value=""Parts per billion (US)"" />
      <xs:enumeration value=""Parts per million"" />
      <xs:enumeration value=""Pascal"" />
      <xs:enumeration value=""Pascal second"" />
      <xs:enumeration value=""Pennyweight"" />
      <xs:enumeration value=""Per Hundred Pieces"" />
      <xs:enumeration value=""Percent"" />
      <xs:enumeration value=""Percent Per 1000 Hours"" />
      <xs:enumeration value=""Percent Weight"" />
      <xs:enumeration value=""Percentage"" />
      <xs:enumeration value=""Piece"" />
      <xs:enumeration value=""Pint - US liquid"" />
      <xs:enumeration value=""Pint U.S. Dry"" />
      <xs:enumeration value=""Plate"" />
      <xs:enumeration value=""Pound"" />
      <xs:enumeration value=""Pounds Per 1000 Square Feet"" />
      <xs:enumeration value=""Pounds Per Foot"" />
      <xs:enumeration value=""Pounds Per Gallon"" />
      <xs:enumeration value=""Pounds Per Piece of Product"" />
      <xs:enumeration value=""Pounds Per Pound of Product"" />
      <xs:enumeration value=""Pounds Per Thousand"" />
      <xs:enumeration value=""Quart - US liquid"" />
      <xs:enumeration value=""Rack"" />
      <xs:enumeration value=""Ream of 500 Sheets"" />
      <xs:enumeration value=""Reel"" />
      <xs:enumeration value=""Ring"" />
      <xs:enumeration value=""Rod"" />
      <xs:enumeration value=""Roll"" />
      <xs:enumeration value=""Sack"" />
      <xs:enumeration value=""Second"" />
      <xs:enumeration value=""Set"" />
      <xs:enumeration value=""SET"" />
      <xs:enumeration value=""Sheet"" />
      <xs:enumeration value=""Sheet-Metric measure"" />
      <xs:enumeration value=""Shipment"" />
      <xs:enumeration value=""Shot"" />
      <xs:enumeration value=""Skein"" />
      <xs:enumeration value=""Skid"" />
      <xs:enumeration value=""Sleeve"" />
      <xs:enumeration value=""Slip Sheet"" />
      <xs:enumeration value=""Spool"" />
      <xs:enumeration value=""Square"" />
      <xs:enumeration value=""Square foot"" />
      <xs:enumeration value=""Square inch"" />
      <xs:enumeration value=""Square kilometer"" />
      <xs:enumeration value=""Square meter"" />
      <xs:enumeration value=""Square meter/second"" />
      <xs:enumeration value=""Square mile"" />
      <xs:enumeration value=""Square millimeter"" />
      <xs:enumeration value=""Square Yard"" />
      <xs:enumeration value=""Statute Mile"" />
      <xs:enumeration value=""Stick"" />
      <xs:enumeration value=""Strip"" />
      <xs:enumeration value=""Super Bulk Bag"" />
      <xs:enumeration value=""Tablet"" />
      <xs:enumeration value=""Tank"" />
      <xs:enumeration value=""Tank Truck"" />
      <xs:enumeration value=""Tesla"" />
      <xs:enumeration value=""Thousand"" />
      <xs:enumeration value=""Ton"" />
      <xs:enumeration value=""Tonne"" />
      <xs:enumeration value=""Torr"" />
      <xs:enumeration value=""Tote"" />
      <xs:enumeration value=""Track Foot"" />
      <xs:enumeration value=""Trailer"" />
      <xs:enumeration value=""Train"" />
      <xs:enumeration value=""Tray"" />
      <xs:enumeration value=""Troy"" />
      <xs:enumeration value=""Troy OZ"" />
      <xs:enumeration value=""Truckload"" />
      <xs:enumeration value=""Tube"" />
      <xs:enumeration value=""Unitless Unit of Measure"" />
      <xs:enumeration value=""US gallon"" />
      <xs:enumeration value=""US pound"" />
      <xs:enumeration value=""US ton"" />
      <xs:enumeration value=""Vial"" />
      <xs:enumeration value=""Volt"" />
      <xs:enumeration value=""Wafer"" />
      <xs:enumeration value=""Watt"" />
      <xs:enumeration value=""Week"" />
      <xs:enumeration value=""WF"" />
      <xs:enumeration value=""Wrap"" />
      <xs:enumeration value=""Yard"" />
      <xs:enumeration value=""Year"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalAssemblyLevelCode"" type=""globalassemblylevelcodeType"" />
  <xs:simpleType name=""globalassemblylevelcodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Component"" />
      <xs:enumeration value=""Phantom"" />
      <xs:enumeration value=""Sub Assembly"" />
      <xs:enumeration value=""Top Level Assembly"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalProductLifeCycleStatusCode"" type=""globalproductlifecyclestatuscodeType"" />
  <xs:simpleType name=""globalproductlifecyclestatuscodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Active"" />
      <xs:enumeration value=""EOL: End Of Life"" />
      <xs:enumeration value=""Obsolete"" />
      <xs:enumeration value=""On Hold"" />
      <xs:enumeration value=""Unavailable through program"" />
      <xs:enumeration value=""Unreleased"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalABCCode"" type=""globalABCcodeType"" />
  <xs:simpleType name=""globalABCcodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A: Highest Importance"" />
      <xs:enumeration value=""B: Medium Importance"" />
      <xs:enumeration value=""C: Lowest Importance"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalProductProcurementTypeCode"" type=""globalproductprocurementtypecodeType"" />
  <xs:simpleType name=""globalproductprocurementtypecodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Allocation"" />
      <xs:enumeration value=""Bulk"" />
      <xs:enumeration value=""JIT: just in Time"" />
      <xs:enumeration value=""NCNR"" />
      <xs:enumeration value=""Not Applicable"" />
      <xs:enumeration value=""Sub Contract"" />
      <xs:enumeration value=""Supply Split"" />
      <xs:enumeration value=""VMI"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalIntervalCode"" type=""globalintervalcodeType"" />
  <xs:simpleType name=""globalintervalcodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1st week of the month"" />
      <xs:enumeration value=""2nd week of the month"" />
      <xs:enumeration value=""3rd week of the month"" />
      <xs:enumeration value=""4th week of the month"" />
      <xs:enumeration value=""5 day work week"" />
      <xs:enumeration value=""5th week of the month"" />
      <xs:enumeration value=""Calendar day"" />
      <xs:enumeration value=""Calendar week"" />
      <xs:enumeration value=""Day"" />
      <xs:enumeration value=""Four month period"" />
      <xs:enumeration value=""Friday"" />
      <xs:enumeration value=""Half month"" />
      <xs:enumeration value=""Half week"" />
      <xs:enumeration value=""Half year"" />
      <xs:enumeration value=""Hour"" />
      <xs:enumeration value=""Indefinite"" />
      <xs:enumeration value=""Minute"" />
      <xs:enumeration value=""Monday"" />
      <xs:enumeration value=""Monday through Friday"" />
      <xs:enumeration value=""Monday through Saturday"" />
      <xs:enumeration value=""Monday through Sunday"" />
      <xs:enumeration value=""Month"" />
      <xs:enumeration value=""Quarter"" />
      <xs:enumeration value=""Saturday"" />
      <xs:enumeration value=""Sunday"" />
      <xs:enumeration value=""Ten days period"" />
      <xs:enumeration value=""Thursday"" />
      <xs:enumeration value=""Tuesday"" />
      <xs:enumeration value=""Two month period"" />
      <xs:enumeration value=""Two week period"" />
      <xs:enumeration value=""Wednesday"" />
      <xs:enumeration value=""Week"" />
      <xs:enumeration value=""Work day"" />
      <xs:enumeration value=""Working days"" />
      <xs:enumeration value=""Year"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalLeadTimeClassificationCode"" type=""globalleadtimeclassificationcodeType"" />
  <xs:simpleType name=""globalleadtimeclassificationcodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""End of life"" />
      <xs:enumeration value=""Production"" />
      <xs:enumeration value=""Start up"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalTaxExemptionCode"" type=""globaltaxexemptioncodeType"" />
  <xs:simpleType name=""globaltaxexemptioncodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Agriculture"" />
      <xs:enumeration value=""Direct pay ID"" />
      <xs:enumeration value=""Disabled"" />
      <xs:enumeration value=""Disabled veteran"" />
      <xs:enumeration value=""Exempt - for export"" />
      <xs:enumeration value=""Exempt - for resale"" />
      <xs:enumeration value=""Exempt - from county property tax"" />
      <xs:enumeration value=""Exempt - from local property tax"" />
      <xs:enumeration value=""Exempt - from school property tax"" />
      <xs:enumeration value=""Exempt - from state property tax"" />
      <xs:enumeration value=""Exempt - goods and services tax"" />
      <xs:enumeration value=""Exempt - letter on file"" />
      <xs:enumeration value=""Exempt - local service"" />
      <xs:enumeration value=""Exempt - not for resale"" />
      <xs:enumeration value=""Exempt - per State law"" />
      <xs:enumeration value=""Exempt - Provincial sales tax"" />
      <xs:enumeration value=""Exempt - sale to U.S. government"" />
      <xs:enumeration value=""Exempt - toll service"" />
      <xs:enumeration value=""Homestead"" />
      <xs:enumeration value=""Labor taxable - material exempt"" />
      <xs:enumeration value=""Material taxable - labor exempt"" />
      <xs:enumeration value=""Non-homestead"" />
      <xs:enumeration value=""Not exempt - for resale"" />
      <xs:enumeration value=""Not exempt - not for resale"" />
      <xs:enumeration value=""Not taxable"" />
      <xs:enumeration value=""Open space"" />
      <xs:enumeration value=""Other property tax exemption"" />
      <xs:enumeration value=""Over 65"" />
      <xs:enumeration value=""Recurring exempt"" />
      <xs:enumeration value=""Totally exempt"" />
      <xs:enumeration value=""Usage exempt"" />
      <xs:enumeration value=""Working farm"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""InvoiceChargeTypeCode"" type=""invoicechargetypecodeType"" />
  <xs:simpleType name=""invoicechargetypecodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Allowances and Charges"" />
      <xs:enumeration value=""Custom Charges"" />
      <xs:enumeration value=""Deposit Amount"" />
      <xs:enumeration value=""Freight Charges"" />
      <xs:enumeration value=""Handling Charges"" />
      <xs:enumeration value=""Quantity Discount"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalMonetaryAmountTypeCode"" type=""globalmonetaryamounttypecodeType"" />
  <xs:simpleType name=""globalmonetaryamounttypecodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Credit"" />
      <xs:enumeration value=""Debit"" />
      <xs:enumeration value=""Zero Remit"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalCurrencyCode"" type=""globalcurrencycodeType"" />
  <xs:simpleType name=""globalcurrencycodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ADP"" />
      <xs:enumeration value=""AED"" />
      <xs:enumeration value=""AFA"" />
      <xs:enumeration value=""ALL"" />
      <xs:enumeration value=""AMD"" />
      <xs:enumeration value=""ANG"" />
      <xs:enumeration value=""AON"" />
      <xs:enumeration value=""AOR"" />
      <xs:enumeration value=""ARS"" />
      <xs:enumeration value=""ATS"" />
      <xs:enumeration value=""AUD"" />
      <xs:enumeration value=""AWG"" />
      <xs:enumeration value=""AZM"" />
      <xs:enumeration value=""BAM"" />
      <xs:enumeration value=""BBD"" />
      <xs:enumeration value=""BDT"" />
      <xs:enumeration value=""BEF"" />
      <xs:enumeration value=""BGL"" />
      <xs:enumeration value=""BHD"" />
      <xs:enumeration value=""BIF"" />
      <xs:enumeration value=""BMD"" />
      <xs:enumeration value=""BND"" />
      <xs:enumeration value=""BOB"" />
      <xs:enumeration value=""BOV"" />
      <xs:enumeration value=""BRL"" />
      <xs:enumeration value=""BSD"" />
      <xs:enumeration value=""BTN"" />
      <xs:enumeration value=""BWP"" />
      <xs:enumeration value=""BYB"" />
      <xs:enumeration value=""BZD"" />
      <xs:enumeration value=""CAD"" />
      <xs:enumeration value=""CHF"" />
      <xs:enumeration value=""CLP"" />
      <xs:enumeration value=""CNY"" />
      <xs:enumeration value=""COP"" />
      <xs:enumeration value=""CRC"" />
      <xs:enumeration value=""CUP"" />
      <xs:enumeration value=""CVE"" />
      <xs:enumeration value=""CYP"" />
      <xs:enumeration value=""CZK"" />
      <xs:enumeration value=""DEM"" />
      <xs:enumeration value=""DJF"" />
      <xs:enumeration value=""DKK"" />
      <xs:enumeration value=""DOP"" />
      <xs:enumeration value=""DZD"" />
      <xs:enumeration value=""ECS"" />
      <xs:enumeration value=""EEK"" />
      <xs:enumeration value=""EGP"" />
      <xs:enumeration value=""ERN"" />
      <xs:enumeration value=""ESP"" />
      <xs:enumeration value=""ETB"" />
      <xs:enumeration value=""EUR"" />
      <xs:enumeration value=""FIM"" />
      <xs:enumeration value=""FJD"" />
      <xs:enumeration value=""FKP"" />
      <xs:enumeration value=""FRF"" />
      <xs:enumeration value=""GBP"" />
      <xs:enumeration value=""GEL"" />
      <xs:enumeration value=""GHC"" />
      <xs:enumeration value=""GIP"" />
      <xs:enumeration value=""GMD"" />
      <xs:enumeration value=""GNF"" />
      <xs:enumeration value=""GRD"" />
      <xs:enumeration value=""GTQ"" />
      <xs:enumeration value=""GWP"" />
      <xs:enumeration value=""GYD"" />
      <xs:enumeration value=""HKD"" />
      <xs:enumeration value=""HNL"" />
      <xs:enumeration value=""HRK"" />
      <xs:enumeration value=""HTG"" />
      <xs:enumeration value=""HUF"" />
      <xs:enumeration value=""IDR"" />
      <xs:enumeration value=""IEP"" />
      <xs:enumeration value=""ILS"" />
      <xs:enumeration value=""INR"" />
      <xs:enumeration value=""IQD"" />
      <xs:enumeration value=""IRR"" />
      <xs:enumeration value=""ISK"" />
      <xs:enumeration value=""ITL"" />
      <xs:enumeration value=""JMD"" />
      <xs:enumeration value=""JOD"" />
      <xs:enumeration value=""JPY"" />
      <xs:enumeration value=""KES"" />
      <xs:enumeration value=""KGS"" />
      <xs:enumeration value=""KHR"" />
      <xs:enumeration value=""KMF"" />
      <xs:enumeration value=""KPW"" />
      <xs:enumeration value=""KRW"" />
      <xs:enumeration value=""KWD"" />
      <xs:enumeration value=""KYD"" />
      <xs:enumeration value=""KZT"" />
      <xs:enumeration value=""LAK"" />
      <xs:enumeration value=""LBP"" />
      <xs:enumeration value=""LKR"" />
      <xs:enumeration value=""LRD"" />
      <xs:enumeration value=""LTL"" />
      <xs:enumeration value=""LUF"" />
      <xs:enumeration value=""LVL"" />
      <xs:enumeration value=""LYD"" />
      <xs:enumeration value=""MAD"" />
      <xs:enumeration value=""MDL"" />
      <xs:enumeration value=""MGF"" />
      <xs:enumeration value=""MKD"" />
      <xs:enumeration value=""MMK"" />
      <xs:enumeration value=""MNT"" />
      <xs:enumeration value=""MOP"" />
      <xs:enumeration value=""MRO"" />
      <xs:enumeration value=""MTL"" />
      <xs:enumeration value=""MUR"" />
      <xs:enumeration value=""MVR"" />
      <xs:enumeration value=""MWK"" />
      <xs:enumeration value=""MXN"" />
      <xs:enumeration value=""MYR"" />
      <xs:enumeration value=""MZM"" />
      <xs:enumeration value=""NGN"" />
      <xs:enumeration value=""NIO"" />
      <xs:enumeration value=""NLG"" />
      <xs:enumeration value=""NOK"" />
      <xs:enumeration value=""NPR"" />
      <xs:enumeration value=""NZD"" />
      <xs:enumeration value=""OMR"" />
      <xs:enumeration value=""PAB"" />
      <xs:enumeration value=""PEN"" />
      <xs:enumeration value=""PGK"" />
      <xs:enumeration value=""PHP"" />
      <xs:enumeration value=""PKR"" />
      <xs:enumeration value=""PLN"" />
      <xs:enumeration value=""PTE"" />
      <xs:enumeration value=""PYG"" />
      <xs:enumeration value=""QAR"" />
      <xs:enumeration value=""ROL"" />
      <xs:enumeration value=""RUR"" />
      <xs:enumeration value=""RWF"" />
      <xs:enumeration value=""SAR"" />
      <xs:enumeration value=""SBD"" />
      <xs:enumeration value=""SCR"" />
      <xs:enumeration value=""SDD"" />
      <xs:enumeration value=""SEK"" />
      <xs:enumeration value=""SGD"" />
      <xs:enumeration value=""SHP"" />
      <xs:enumeration value=""SIT"" />
      <xs:enumeration value=""SKK"" />
      <xs:enumeration value=""SLL"" />
      <xs:enumeration value=""SOS"" />
      <xs:enumeration value=""SRG"" />
      <xs:enumeration value=""STD"" />
      <xs:enumeration value=""SVC"" />
      <xs:enumeration value=""SYP"" />
      <xs:enumeration value=""SZL"" />
      <xs:enumeration value=""THB"" />
      <xs:enumeration value=""TJR"" />
      <xs:enumeration value=""TMM"" />
      <xs:enumeration value=""TND"" />
      <xs:enumeration value=""TOP"" />
      <xs:enumeration value=""TPE"" />
      <xs:enumeration value=""TRL"" />
      <xs:enumeration value=""TTD"" />
      <xs:enumeration value=""TWD"" />
      <xs:enumeration value=""TZS"" />
      <xs:enumeration value=""UAH"" />
      <xs:enumeration value=""UGX"" />
      <xs:enumeration value=""USD"" />
      <xs:enumeration value=""UYU"" />
      <xs:enumeration value=""UZS"" />
      <xs:enumeration value=""VEB"" />
      <xs:enumeration value=""VND"" />
      <xs:enumeration value=""VUV"" />
      <xs:enumeration value=""WST"" />
      <xs:enumeration value=""XAF"" />
      <xs:enumeration value=""XCD"" />
      <xs:enumeration value=""XDR"" />
      <xs:enumeration value=""XOF"" />
      <xs:enumeration value=""XPF"" />
      <xs:enumeration value=""XPR"" />
      <xs:enumeration value=""YER"" />
      <xs:enumeration value=""YUM"" />
      <xs:enumeration value=""ZAR"" />
      <xs:enumeration value=""ZMK"" />
      <xs:enumeration value=""ZRN"" />
      <xs:enumeration value=""ZWD"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalTransportEventCode"" type=""globaltransporteventcodeType"" />
  <xs:simpleType name=""globaltransporteventcodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Dock"" />
      <xs:enumeration value=""Pickup"" />
      <xs:enumeration value=""Ship"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalCustomerTypeCode"" type=""globalcustomertypecodeType"" />
  <xs:simpleType name=""globalcustomertypecodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""End Customer"" />
      <xs:enumeration value=""Ultimate Customer"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalSpecialHandlingCode"" type=""globalspecialhandlingcodeType"" />
  <xs:simpleType name=""globalspecialhandlingcodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""15 Minute Window"" />
      <xs:enumeration value=""24 Hour Availability"" />
      <xs:enumeration value=""A.M. Delivery Requirement"" />
      <xs:enumeration value=""Accepted by Carrier at Owner's Risk of Freezing"" />
      <xs:enumeration value=""Accessible Hazardous Material"" />
      <xs:enumeration value=""Additional Copy of Shipping Papers for Proof of Delivery"" />
      <xs:enumeration value=""Advance Loading"" />
      <xs:enumeration value=""Advanced Fee"" />
      <xs:enumeration value=""Aggregate Tender Discount"" />
      <xs:enumeration value=""Air Conditioning Disconnect and Connect"" />
      <xs:enumeration value=""Air Ride Tractor Service"" />
      <xs:enumeration value=""Air Ride Truck Service"" />
      <xs:enumeration value=""Anchoring and Unanchoring"" />
      <xs:enumeration value=""Annual Volume"" />
      <xs:enumeration value=""Apply a Uniform Code Council/International Article Numbering Association (UCC/EAN) Serial Shipping Container Label to the Shipping Containers"" />
      <xs:enumeration value=""Armed Guard Service"" />
      <xs:enumeration value=""Assembly Service Requested"" />
      <xs:enumeration value=""Attachment - Customer's Document"" />
      <xs:enumeration value=""Attachment - Prepaid Waybill"" />
      <xs:enumeration value=""Attachment - Shipper's Export Document"" />
      <xs:enumeration value=""Attachment - Shipper's Manifest"" />
      <xs:enumeration value=""Attachment - Shipper's Packing Instructions"" />
      <xs:enumeration value=""Attachments - Advance Only Waybill"" />
      <xs:enumeration value=""Auxiliary Service"" />
      <xs:enumeration value=""Barge Freight All Kinds Service"" />
      <xs:enumeration value=""Bill Consignee for Weigh Charges"" />
      <xs:enumeration value=""Bill Shipper for Weigh Charge"" />
      <xs:enumeration value=""Blind Shipment"" />
      <xs:enumeration value=""Block Stowage"" />
      <xs:enumeration value=""Blocking and Bracing"" />
      <xs:enumeration value=""Bolster Load, Do Not Switch"" />
      <xs:enumeration value=""Bulky Article"" />
      <xs:enumeration value=""Bunker Adjustment"" />
      <xs:enumeration value=""Bunker Adjustment - 20 Foot Container"" />
      <xs:enumeration value=""Bunker Adjustment - 40 Foot Container"" />
      <xs:enumeration value=""Bunker Surcharge Authorized"" />
      <xs:enumeration value=""Bypass Consolidation Point"" />
      <xs:enumeration value=""Cargo Aboard"" />
      <xs:enumeration value=""Cargo on Board Certification Required"" />
      <xs:enumeration value=""Cargo Taxes"" />
      <xs:enumeration value=""Carrier"" />
      <xs:enumeration value=""Carrier Caboose"" />
      <xs:enumeration value=""Carrier Guard Car Service"" />
      <xs:enumeration value=""Carrier Load and Carrier Unload"" />
      <xs:enumeration value=""Carrier Load and Consignee Unload"" />
      <xs:enumeration value=""Certificate of Origin"" />
      <xs:enumeration value=""Certification"" />
      <xs:enumeration value=""Certification that the Containers Being Returned Empty Were Received Filled by Rail Freight Service"" />
      <xs:enumeration value=""Certification That the Newsprint Winding Cores Being Returned Empty Were Received Filled by Rail Freight Service"" />
      <xs:enumeration value=""Certification that this Shipment is for Recycling as Defined in Applicable Tariffs Containing Such Provisions"" />
      <xs:enumeration value=""Chain and Binders"" />
      <xs:enumeration value=""Circuitous Routing"" />
      <xs:enumeration value=""Class Rates Applied"" />
      <xs:enumeration value=""Cleaning"" />
      <xs:enumeration value=""Cleared for Border Crossing"" />
      <xs:enumeration value=""Cleared for Export"" />
      <xs:enumeration value=""Clearinghouse Balance"" />
      <xs:enumeration value=""Comb. Rates over Detroit"" />
      <xs:enumeration value=""Commercial Invoice Preparation"" />
      <xs:enumeration value=""Commodity Loaded Less Than or Equal To the Car Ordered"" />
      <xs:enumeration value=""Completing Shipment"" />
      <xs:enumeration value=""Conductivity/Anti-static Additive"" />
      <xs:enumeration value=""Consignee Unload"" />
      <xs:enumeration value=""Consolidation"" />
      <xs:enumeration value=""Consolidation and Line Haul"" />
      <xs:enumeration value=""Constant Surveillance"" />
      <xs:enumeration value=""Container Diversion"" />
      <xs:enumeration value=""Container Lease"" />
      <xs:enumeration value=""Container Mounting"" />
      <xs:enumeration value=""Container, Consolidator Load"" />
      <xs:enumeration value=""Container, Factory Load"" />
      <xs:enumeration value=""Contract Rates Apply"" />
      <xs:enumeration value=""Controlled Atmosphere"" />
      <xs:enumeration value=""Convert Commercial Bill of Lading (BOL) to Government BOL"" />
      <xs:enumeration value=""Courier, Overnight"" />
      <xs:enumeration value=""Courier, Same Day"" />
      <xs:enumeration value=""Cross Town"" />
      <xs:enumeration value=""Currency Adjustment - 20 Foot Container"" />
      <xs:enumeration value=""Currency Adjustment - 40 Foot Container"" />
      <xs:enumeration value=""Customer Required Appointment Number"" />
      <xs:enumeration value=""Customer Required Packing List"" />
      <xs:enumeration value=""Customer Required PRO Number"" />
      <xs:enumeration value=""Customs Fees - Container Level"" />
      <xs:enumeration value=""Customs Fees - Lift Level"" />
      <xs:enumeration value=""Customs Inspection"" />
      <xs:enumeration value=""Customs Papers Mailed"" />
      <xs:enumeration value=""Dangerous"" />
      <xs:enumeration value=""Delivery Only on Surrender of Written Order"" />
      <xs:enumeration value=""Delivery Service"" />
      <xs:enumeration value=""Delivery Verification Not Required"" />
      <xs:enumeration value=""Demurrage"" />
      <xs:enumeration value=""Destination Weights Apply"" />
      <xs:enumeration value=""Detention (Vehicle)"" />
      <xs:enumeration value=""Detention of Conveying Equipment and the Power Unit"" />
      <xs:enumeration value=""Detention of Conveying Equipment Excluding the Power Unit"" />
      <xs:enumeration value=""Detention With Power Units (30 minute periods)"" />
      <xs:enumeration value=""Detention With Power Units (60 minute periods)"" />
      <xs:enumeration value=""Direct Delivery"" />
      <xs:enumeration value=""Distribution Service Requested"" />
      <xs:enumeration value=""Do Not Couple to Double Shelf Couples"" />
      <xs:enumeration value=""Do Not Divert"" />
      <xs:enumeration value=""Do Not Freeze"" />
      <xs:enumeration value=""Do Not Hump"" />
      <xs:enumeration value=""Do not Hump or Hump into"" />
      <xs:enumeration value=""Do Not Pool"" />
      <xs:enumeration value=""Do Not Transfer Contents"" />
      <xs:enumeration value=""Do Not Uncouple"" />
      <xs:enumeration value=""Documentation - Special"" />
      <xs:enumeration value=""DOD Constant Surveillance Service"" />
      <xs:enumeration value=""Domestic"" />
      <xs:enumeration value=""Drayage at Port of Debarkation (Rate Zone)"" />
      <xs:enumeration value=""Drayage at Port of Embarkation (Rate Zone)"" />
      <xs:enumeration value=""Drop and Run"" />
      <xs:enumeration value=""Drop-Off Delivery"" />
      <xs:enumeration value=""Electronic Equipment Transfer"" />
      <xs:enumeration value=""Emergency Service"" />
      <xs:enumeration value=""Empty Movement"" />
      <xs:enumeration value=""Empty Return"" />
      <xs:enumeration value=""Endorsed as Hazardous Material"" />
      <xs:enumeration value=""Endorsement"" />
      <xs:enumeration value=""Equipment"" />
      <xs:enumeration value=""Escort"" />
      <xs:enumeration value=""Escort Service with Overnight Subsistence"" />
      <xs:enumeration value=""Escort Services (Telephone)"" />
      <xs:enumeration value=""Escort/Courier Service"" />
      <xs:enumeration value=""Excessive Valuation Authorized"" />
      <xs:enumeration value=""Excessive Weight"" />
      <xs:enumeration value=""Exclusive Use"" />
      <xs:enumeration value=""Exclusive Use of Vehicle"" />
      <xs:enumeration value=""Exempt Commodity"" />
      <xs:enumeration value=""Expand Remove and Install"" />
      <xs:enumeration value=""Expedite"" />
      <xs:enumeration value=""Expedited Rates Applied"" />
      <xs:enumeration value=""Expedited Service"" />
      <xs:enumeration value=""Export"" />
      <xs:enumeration value=""Export Preparation"" />
      <xs:enumeration value=""Extra Driver"" />
      <xs:enumeration value=""Extra Labor"" />
      <xs:enumeration value=""Extra Lights"" />
      <xs:enumeration value=""Filtration Service"" />
      <xs:enumeration value=""Flatrack Surcharge"" />
      <xs:enumeration value=""FOD"" />
      <xs:enumeration value=""For Processing in Transit"" />
      <xs:enumeration value=""For Storage in Transit"" />
      <xs:enumeration value=""FOS"" />
      <xs:enumeration value=""Fragile - Handle with Care"" />
      <xs:enumeration value=""Full Service"" />
      <xs:enumeration value=""Government Caboose"" />
      <xs:enumeration value=""Government Guard Car"" />
      <xs:enumeration value=""Government-Owned Containers"" />
      <xs:enumeration value=""Greater Security Service"" />
      <xs:enumeration value=""Handling"" />
      <xs:enumeration value=""Harmless"" />
      <xs:enumeration value=""Hazardous Cargo On Deck"" />
      <xs:enumeration value=""Hazardous Materials Surcharge"" />
      <xs:enumeration value=""Heat"" />
      <xs:enumeration value=""Heat - Special"" />
      <xs:enumeration value=""Heat in Transit"" />
      <xs:enumeration value=""Heater or Refrigeration"" />
      <xs:enumeration value=""High Cube Trailer Rates"" />
      <xs:enumeration value=""High Value Load"" />
      <xs:enumeration value=""Hold at Location"" />
      <xs:enumeration value=""Hold for Orders"" />
      <xs:enumeration value=""Home for Repair"" />
      <xs:enumeration value=""If Bad Ordered Notify Shipper"" />
      <xs:enumeration value=""Impactographs"" />
      <xs:enumeration value=""Import Shipment"" />
      <xs:enumeration value=""In Case of Fire Do Not Use Water"" />
      <xs:enumeration value=""Inaccessible Hazardous Material"" />
      <xs:enumeration value=""In-bond"" />
      <xs:enumeration value=""Inside Delivery"" />
      <xs:enumeration value=""Inside Pickup"" />
      <xs:enumeration value=""Inspect Hourly if Car Stopped"" />
      <xs:enumeration value=""Insulated"" />
      <xs:enumeration value=""Interline Transfer Service"" />
      <xs:enumeration value=""Intermodal Shipment Service"" />
      <xs:enumeration value=""Intra-Plant Move"" />
      <xs:enumeration value=""Joint Line Exception"" />
      <xs:enumeration value=""Just-In-Time (JIT)"" />
      <xs:enumeration value=""Keep From Freezing Percent Differential"" />
      <xs:enumeration value=""Keep Material Dry"" />
      <xs:enumeration value=""Labor Associated with Detention of Conveying Equipment"" />
      <xs:enumeration value=""Labor Disturbance"" />
      <xs:enumeration value=""Land Bridge (Import/Export)"" />
      <xs:enumeration value=""Land Currency Adjustment - 40 Foot Container"" />
      <xs:enumeration value=""Land Currency Adjustment Factor - 20 Foot Container"" />
      <xs:enumeration value=""Layover"" />
      <xs:enumeration value=""Layover Service"" />
      <xs:enumeration value=""Less Than Container"" />
      <xs:enumeration value=""Less Than Container, Consolidator Load"" />
      <xs:enumeration value=""Less Than Container, Factory Load"" />
      <xs:enumeration value=""Less Than Full Carload"" />
      <xs:enumeration value=""Less Than Truckload"" />
      <xs:enumeration value=""Liability of Carrier"" />
      <xs:enumeration value=""Light Bar Service"" />
      <xs:enumeration value=""Linehaul from Port of Debarkation"" />
      <xs:enumeration value=""Linehaul Percent Differential"" />
      <xs:enumeration value=""Linehaul Service"" />
      <xs:enumeration value=""Linehaul To Port of Embarkation"" />
      <xs:enumeration value=""Liner Terms at Port of Debarkation"" />
      <xs:enumeration value=""Liner Terms at Port of Embarkation"" />
      <xs:enumeration value=""Live Unload"" />
      <xs:enumeration value=""Loaded to Full Visible Capacity"" />
      <xs:enumeration value=""Loading Devices"" />
      <xs:enumeration value=""Local Service Only"" />
      <xs:enumeration value=""Low Boy Trailer/Flat Bed"" />
      <xs:enumeration value=""Manifest Must Accompany Waybill"" />
      <xs:enumeration value=""Mechanical Refrigeration"" />
      <xs:enumeration value=""Modified Atmosphere"" />
      <xs:enumeration value=""Motor Surveillance Service"" />
      <xs:enumeration value=""Moving Under &quot;For Furtherance Instructions&quot; and May Be Delivered"" />
      <xs:enumeration value=""Multiple Pickup"" />
      <xs:enumeration value=""Multi-Tank Surveillance Service"" />
      <xs:enumeration value=""New Equipment First Transborder Movement"" />
      <xs:enumeration value=""No Marshalling Required for Hazardous Materials"" />
      <xs:enumeration value=""No Placards Required"" />
      <xs:enumeration value=""No Special Entrainment Required"" />
      <xs:enumeration value=""Nontransit Flat Shipment"" />
      <xs:enumeration value=""Not for Export"" />
      <xs:enumeration value=""Not Restricted Cargo"" />
      <xs:enumeration value=""Notify Consignee Before Delivery"" />
      <xs:enumeration value=""Notify Shipper Before Reconsignment"" />
      <xs:enumeration value=""Notify Shipper Immediately if Shipment is Delayed en Route"" />
      <xs:enumeration value=""Offshore - Alaska/Hawaii Service"" />
      <xs:enumeration value=""On Deck Stowage"" />
      <xs:enumeration value=""One Way Rates Applied"" />
      <xs:enumeration value=""Other"" />
      <xs:enumeration value=""Over Height Container"" />
      <xs:enumeration value=""Overflow"" />
      <xs:enumeration value=""Oversized Premium"" />
      <xs:enumeration value=""Overweight"" />
      <xs:enumeration value=""P.M. Delivery Requirement"" />
      <xs:enumeration value=""Pack and Unpack"" />
      <xs:enumeration value=""Pallets/Skids/Platforms"" />
      <xs:enumeration value=""Partial Shipment"" />
      <xs:enumeration value=""Per Hour Rates Applied"" />
      <xs:enumeration value=""Per Mile Rates Apply"" />
      <xs:enumeration value=""Percent Differential - Less Than Container"" />
      <xs:enumeration value=""Pickup"" />
      <xs:enumeration value=""Pickup and Delivery"" />
      <xs:enumeration value=""Pickup and Delivery Beyond Service Area"" />
      <xs:enumeration value=""Pickup and Delivery From Storage in Transit"" />
      <xs:enumeration value=""Pickup of Shipments on Saturday, Sunday, and/or Holidays Requiring Absolute Next Day Delivery"" />
      <xs:enumeration value=""Pickup of Shipments Requiring Same Day Delivery Service"" />
      <xs:enumeration value=""Pickup of Shipments Requiring Same Day Delivery Service and/or Delivery at a Specified Time"" />
      <xs:enumeration value=""Pier Time"" />
      <xs:enumeration value=""Port Changes"" />
      <xs:enumeration value=""PPC"" />
      <xs:enumeration value=""PPD"" />
      <xs:enumeration value=""Preparation of Air Waybill - Origin"" />
      <xs:enumeration value=""Preparation of Canadian Customs Invoice"" />
      <xs:enumeration value=""Preparation of Export Entry"" />
      <xs:enumeration value=""Preparation of Insurance Certificate"" />
      <xs:enumeration value=""Preparation of U.S. Export Documentation"" />
      <xs:enumeration value=""Priority Service"" />
      <xs:enumeration value=""Product Protection Service"" />
      <xs:enumeration value=""Protect From Heat"" />
      <xs:enumeration value=""Protect Lowest Through Rate"" />
      <xs:enumeration value=""Protective Security Service"" />
      <xs:enumeration value=""PUP Trailer Rates Apply"" />
      <xs:enumeration value=""Radioactive Material"" />
      <xs:enumeration value=""Railhead Handling"" />
      <xs:enumeration value=""Railroad Controlled Private Equipment Subject to Demurrage"" />
      <xs:enumeration value=""Reconsignment"" />
      <xs:enumeration value=""Record for Transit"" />
      <xs:enumeration value=""Redelivery"" />
      <xs:enumeration value=""Reefer Cargo Percent Differential"" />
      <xs:enumeration value=""Reefer Maintenance"" />
      <xs:enumeration value=""Refrigerated"" />
      <xs:enumeration value=""Released Value Charge in Excess of Carrier Maximum Liability"" />
      <xs:enumeration value=""Render Bill for Charges"" />
      <xs:enumeration value=""Requires Shelf Couplers"" />
      <xs:enumeration value=""Reservations"" />
      <xs:enumeration value=""Reshipment"" />
      <xs:enumeration value=""Residential Delivery"" />
      <xs:enumeration value=""Respotting"" />
      <xs:enumeration value=""Return Authorization"" />
      <xs:enumeration value=""Return Carrier Guard Car Service"" />
      <xs:enumeration value=""Return Movement of Pallet"" />
      <xs:enumeration value=""Return of Empty Container"" />
      <xs:enumeration value=""Reweight Requested"" />
      <xs:enumeration value=""Roadrailer Service"" />
      <xs:enumeration value=""Roadway Easy Rates Applied"" />
      <xs:enumeration value=""ROEE Van Type Truck"" />
      <xs:enumeration value=""Round Trip Service"" />
      <xs:enumeration value=""Rush Order"" />
      <xs:enumeration value=""Satellite Surveillance Service"" />
      <xs:enumeration value=""Satisfactory Service Standards"" />
      <xs:enumeration value=""Saturday Delivery"" />
      <xs:enumeration value=""Saturday Pick-Up"" />
      <xs:enumeration value=""Saturday Pickup or Delivery"" />
      <xs:enumeration value=""Security Signature Service"" />
      <xs:enumeration value=""Service Charge Applies"" />
      <xs:enumeration value=""Shiftable Load"" />
      <xs:enumeration value=""Shipment from Non-Temp Storage"" />
      <xs:enumeration value=""Shipment Holdover for Holidays"" />
      <xs:enumeration value=""Shipment Holdover for Weekends"" />
      <xs:enumeration value=""Shipment Holdover on Holidays"" />
      <xs:enumeration value=""Shipment Holdover on Weekdays"" />
      <xs:enumeration value=""Shipment Holdover on Weekends"" />
      <xs:enumeration value=""Shipment to be Inspected at Destination and Disposition Instructions will be Furnished"" />
      <xs:enumeration value=""Shipper Authorization Required for Diversion or Consignment"" />
      <xs:enumeration value=""Shipper Certifies Gross Weight under 240,000 pounds"" />
      <xs:enumeration value=""Shipper Export Declaration Required"" />
      <xs:enumeration value=""Shipper Load"" />
      <xs:enumeration value=""Shipper Load and Carrier Unload"" />
      <xs:enumeration value=""Shipper Load and Consignee Unload"" />
      <xs:enumeration value=""Shipper Load and Count"" />
      <xs:enumeration value=""Shipper Load/Carrier Count"" />
      <xs:enumeration value=""Shove to Rest and Cover"" />
      <xs:enumeration value=""Signature and Tally Record"" />
      <xs:enumeration value=""Signature Required"" />
      <xs:enumeration value=""Single Driver"" />
      <xs:enumeration value=""Single Factor Origination/Destination"" />
      <xs:enumeration value=""Single Factor Origination/Port of Debarkation"" />
      <xs:enumeration value=""Single Factor Port of Embarkation/Destination"" />
      <xs:enumeration value=""Single Shipment"" />
      <xs:enumeration value=""Small Package"" />
      <xs:enumeration value=""Special Containers"" />
      <xs:enumeration value=""Special Dromedary Service"" />
      <xs:enumeration value=""Special Equipment Charge"" />
      <xs:enumeration value=""Special Motor Surveillance"" />
      <xs:enumeration value=""Special Permit"" />
      <xs:enumeration value=""Special Permits"" />
      <xs:enumeration value=""Special Train Movement"" />
      <xs:enumeration value=""Speed Restricted"" />
      <xs:enumeration value=""Speed Restricted to 15 Miles per Hour"" />
      <xs:enumeration value=""Speed Restricted to 25 Miles per Hour"" />
      <xs:enumeration value=""Speed Restricted to 35 Miles per Hour"" />
      <xs:enumeration value=""Speed Restricted to 45 Miles per Hour"" />
      <xs:enumeration value=""Split Delivery"" />
      <xs:enumeration value=""Split Pickup"" />
      <xs:enumeration value=""Spot for Storage - No Shipment"" />
      <xs:enumeration value=""Stack Train"" />
      <xs:enumeration value=""Stairs, Elevator, Excess Carry"" />
      <xs:enumeration value=""Stop-off"" />
      <xs:enumeration value=""Stop-off at Destination"" />
      <xs:enumeration value=""Stop-off at Origination"" />
      <xs:enumeration value=""Storage"" />
      <xs:enumeration value=""Stow Away from Heat"" />
      <xs:enumeration value=""Stowage"" />
      <xs:enumeration value=""Stretch Wrap"" />
      <xs:enumeration value=""Stripping, Sorting and Consolidation"" />
      <xs:enumeration value=""Subject to Special Detention Rules/Charges"" />
      <xs:enumeration value=""Substitute Service Not to be Used"" />
      <xs:enumeration value=""Sunday or Holiday Pickup or Delivery"" />
      <xs:enumeration value=""Supervisor Requested"" />
      <xs:enumeration value=""Surveying Routes"" />
      <xs:enumeration value=""Team Track Delivery"" />
      <xs:enumeration value=""Temperature Control"" />
      <xs:enumeration value=""Tendered as Truckload (Truckload Service Requested)"" />
      <xs:enumeration value=""Tendering of Multiple Vehicles"" />
      <xs:enumeration value=""Terminal Handling Charges"" />
      <xs:enumeration value=""Termination"" />
      <xs:enumeration value=""Third Party Service"" />
      <xs:enumeration value=""Time of Delivery and Signature Required"" />
      <xs:enumeration value=""Time Volume Rates Only"" />
      <xs:enumeration value=""Top Load Only"" />
      <xs:enumeration value=""Total Shipment"" />
      <xs:enumeration value=""Trade Show"" />
      <xs:enumeration value=""Trailer Preparation - Special"" />
      <xs:enumeration value=""Trailer, Consolidator Load"" />
      <xs:enumeration value=""Trailer, Factory Load"" />
      <xs:enumeration value=""Transfer Product"" />
      <xs:enumeration value=""Transit Shipment"" />
      <xs:enumeration value=""Transmit a Ship Notice/Manifest Transaction Set"" />
      <xs:enumeration value=""Truck Rates Applicable"" />
      <xs:enumeration value=""Truckload-Double Operator-Common Carrier"" />
      <xs:enumeration value=""Truckload-Double Operator-Padded Van"" />
      <xs:enumeration value=""Unitized"" />
      <xs:enumeration value=""Unload as Placarded"" />
      <xs:enumeration value=""Unload from Left Side of Car"" />
      <xs:enumeration value=""Unload from Right Side of Car"" />
      <xs:enumeration value=""Unloading or Reloading"" />
      <xs:enumeration value=""Unpacking"" />
      <xs:enumeration value=""Unprotected Perishable"" />
      <xs:enumeration value=""Use No Hooks"" />
      <xs:enumeration value=""Use of Alternate Terminal"" />
      <xs:enumeration value=""Ventilation Instructions"" />
      <xs:enumeration value=""Verification Weigh"" />
      <xs:enumeration value=""Waiting Time Authorized"" />
      <xs:enumeration value=""Waive Inspection"" />
      <xs:enumeration value=""Waived Inspection - Set Direct"" />
      <xs:enumeration value=""Weigh Empty"" />
      <xs:enumeration value=""Weigh to Check for Overload"" />
      <xs:enumeration value=""Weight Verification"" />
      <xs:enumeration value=""Written Proof of Delivery"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalSpecialFulfillmentRequestCode"" type=""globalspecialfulfillmentrequestcodeType"" />
  <xs:simpleType name=""globalspecialfulfillmentrequestcodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Add quantity to make minimum weight requirement"" />
      <xs:enumeration value=""Back order if items are out of stock or not yet published"" />
      <xs:enumeration value=""Back order if out of stock"" />
      <xs:enumeration value=""Back order only if new item"" />
      <xs:enumeration value=""Bid guarantee"" />
      <xs:enumeration value=""Combined small disadvantaged business and labor surplus area set-aside"" />
      <xs:enumeration value=""Consignment"" />
      <xs:enumeration value=""Consolidate delivery"" />
      <xs:enumeration value=""Do not preship"" />
      <xs:enumeration value=""Do not ship/invoice only"" />
      <xs:enumeration value=""Equal product allowed"" />
      <xs:enumeration value=""Exclude Import Quota in First Cost"" />
      <xs:enumeration value=""Factory ship"" />
      <xs:enumeration value=""Fill or kill"" />
      <xs:enumeration value=""Guaranteed sale"" />
      <xs:enumeration value=""Include Import Quota in First Cost"" />
      <xs:enumeration value=""Labor surplus area set-Aside"" />
      <xs:enumeration value=""Large purchase set-aside for small business"" />
      <xs:enumeration value=""May preship"" />
      <xs:enumeration value=""Multi-year award"" />
      <xs:enumeration value=""Mutually defined"" />
      <xs:enumeration value=""No back order"" />
      <xs:enumeration value=""No substitutes"" />
      <xs:enumeration value=""Notify prior to shipment if quantity specified is not available"" />
      <xs:enumeration value=""On Qualified Bidders List"" />
      <xs:enumeration value=""On Qualified Manufacturers List"" />
      <xs:enumeration value=""Other Unlisted Sales Condition"" />
      <xs:enumeration value=""Partial labor surplus area set aside"" />
      <xs:enumeration value=""Restricted to approved sources"" />
      <xs:enumeration value=""Restricted to educational institutions"" />
      <xs:enumeration value=""Restricted to historically black college or university or minority institution"" />
      <xs:enumeration value=""Restricted to industrial preparedness program participants"" />
      <xs:enumeration value=""Restricted to Qualified Products List (QPL) Products"" />
      <xs:enumeration value=""Restricted to U.S. and Canadian Sources"" />
      <xs:enumeration value=""Restricted to Young Investigator Program"" />
      <xs:enumeration value=""Section (8a) set-aside"" />
      <xs:enumeration value=""Set-aside for american indian-owned business"" />
      <xs:enumeration value=""Ship as soon as possible"" />
      <xs:enumeration value=""Ship Complete"" />
      <xs:enumeration value=""Ship full truck only"" />
      <xs:enumeration value=""Ship In-Place"" />
      <xs:enumeration value=""Ship partial - balance back order"" />
      <xs:enumeration value=""Ship Partial - Balance Cancel"" />
      <xs:enumeration value=""Ship Partial - Balance Substitute"" />
      <xs:enumeration value=""Ship Partial - Carload Lots Only"" />
      <xs:enumeration value=""Ship Partial - Item Qty Proportional To Total Order"" />
      <xs:enumeration value=""Ship Partial - Truckload Lots Only"" />
      <xs:enumeration value=""Ship Per Release"" />
      <xs:enumeration value=""Ship Per Release or Buyer Authorization"" />
      <xs:enumeration value=""Ship Per Schedule"" />
      <xs:enumeration value=""Small business with small disadvantaged business consideration set-aside"" />
      <xs:enumeration value=""Small disadvantaged business set-aside"" />
      <xs:enumeration value=""Small purchase set aside for small businesses"" />
      <xs:enumeration value=""Small Remaining Balance Cancellation Allowed"" />
      <xs:enumeration value=""Small Remaining Balance Cancellation Not Allowed"" />
      <xs:enumeration value=""Substitute item allowed"" />
      <xs:enumeration value=""Unrestricted procurement"" />
      <xs:enumeration value=""Warehouse ship"" />
      <xs:enumeration value=""Warranty"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalShippingServiceLevelCode"" type=""globalshippingservicelevelcodeType"" />
  <xs:simpleType name=""globalshippingservicelevelcodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1BD"" />
      <xs:enumeration value=""5BD"" />
      <xs:enumeration value=""9 A.M."" />
      <xs:enumeration value=""A.M."" />
      <xs:enumeration value=""Air Cargo"" />
      <xs:enumeration value=""Air Charter"" />
      <xs:enumeration value=""Air Economy"" />
      <xs:enumeration value=""Authorized Return Service"" />
      <xs:enumeration value=""Bulk Commodity Train"" />
      <xs:enumeration value=""Business Class"" />
      <xs:enumeration value=""Consignee Billing Service"" />
      <xs:enumeration value=""Courier Express"" />
      <xs:enumeration value=""Deferred Service"" />
      <xs:enumeration value=""Delivery Confirmation"" />
      <xs:enumeration value=""Delivery Confirmation Return"" />
      <xs:enumeration value=""Delivery Notification Only"" />
      <xs:enumeration value=""Delivery scheduled next day by cartage agent"" />
      <xs:enumeration value=""Delivery scheduled second day by cartage agent"" />
      <xs:enumeration value=""Delivery scheduled third day by cartage agent"" />
      <xs:enumeration value=""Door Service"" />
      <xs:enumeration value=""Expedited Service"" />
      <xs:enumeration value=""Expedited Service - Worldwide"" />
      <xs:enumeration value=""Express Service"" />
      <xs:enumeration value=""Express Service - Worldwide"" />
      <xs:enumeration value=""Express Service Plus"" />
      <xs:enumeration value=""First Class"" />
      <xs:enumeration value=""Ground"" />
      <xs:enumeration value=""Manifest Freight"" />
      <xs:enumeration value=""Metro"" />
      <xs:enumeration value=""Multiweight"" />
      <xs:enumeration value=""NBD"" />
      <xs:enumeration value=""Next Day Air"" />
      <xs:enumeration value=""Next Day Hundred Weight"" />
      <xs:enumeration value=""Next Flight Out"" />
      <xs:enumeration value=""Next Morning"" />
      <xs:enumeration value=""NORMAL"" />
      <xs:enumeration value=""Not Served"" />
      <xs:enumeration value=""Other Intermodal and Stack Service"" />
      <xs:enumeration value=""Overnight"" />
      <xs:enumeration value=""P.O. Box/Zip Code"" />
      <xs:enumeration value=""Passenger Service"" />
      <xs:enumeration value=""Pickup"" />
      <xs:enumeration value=""PM"" />
      <xs:enumeration value=""Premium Surface"" />
      <xs:enumeration value=""Primary Service Area - Next Day by 10:30 A.M."" />
      <xs:enumeration value=""Primary Service Area - Next Day by 5:00 P.M."" />
      <xs:enumeration value=""Primary Service Area - Next Day By 9:30 AM"" />
      <xs:enumeration value=""Primary Service Area - Next Day by Noon"" />
      <xs:enumeration value=""Primary Service Area - Second Day by Noon"" />
      <xs:enumeration value=""Priority Mail"" />
      <xs:enumeration value=""Priority Mail Insured"" />
      <xs:enumeration value=""Proof of Delivery (POD) with Signature"" />
      <xs:enumeration value=""Regular"" />
      <xs:enumeration value=""Same Day"" />
      <xs:enumeration value=""Saturday"" />
      <xs:enumeration value=""Saturday Pickup"" />
      <xs:enumeration value=""SBD"" />
      <xs:enumeration value=""Scheduled"" />
      <xs:enumeration value=""Second Day"" />
      <xs:enumeration value=""Second Day Air"" />
      <xs:enumeration value=""Second Day Hundred Weight"" />
      <xs:enumeration value=""Second Morning"" />
      <xs:enumeration value=""Standard Class"" />
      <xs:enumeration value=""Standard Ground"" />
      <xs:enumeration value=""Standard Ground Hundred Weight"" />
      <xs:enumeration value=""Standard Ocean"" />
      <xs:enumeration value=""Standard Service"" />
      <xs:enumeration value=""Sunday and Holidays"" />
      <xs:enumeration value=""Three Day Service"" />
      <xs:enumeration value=""Time Critical"" />
      <xs:enumeration value=""Tracking - Ground"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalShipmentTermsCode"" type=""globalshipmenttermscodeType"" />
  <xs:simpleType name=""globalshipmenttermscodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Advance collect"" />
      <xs:enumeration value=""Advance prepaid"" />
      <xs:enumeration value=""Cash in advance"" />
      <xs:enumeration value=""Cash on delivery"" />
      <xs:enumeration value=""CFR"" />
      <xs:enumeration value=""CIF"" />
      <xs:enumeration value=""CIP"" />
      <xs:enumeration value=""Collect"" />
      <xs:enumeration value=""Collect, freight credited to payment customer"" />
      <xs:enumeration value=""CPT"" />
      <xs:enumeration value=""Credit card"" />
      <xs:enumeration value=""Customer pick-up/backhaul"" />
      <xs:enumeration value=""DAF"" />
      <xs:enumeration value=""DDP"" />
      <xs:enumeration value=""DDU"" />
      <xs:enumeration value=""DEQ"" />
      <xs:enumeration value=""DES"" />
      <xs:enumeration value=""EXW"" />
      <xs:enumeration value=""FAS"" />
      <xs:enumeration value=""FCA"" />
      <xs:enumeration value=""FOB"" />
      <xs:enumeration value=""Letter of credit"" />
      <xs:enumeration value=""Not specified"" />
      <xs:enumeration value=""Payable elsewhere"" />
      <xs:enumeration value=""Pickup"" />
      <xs:enumeration value=""Prepaid (by seller)"" />
      <xs:enumeration value=""Prepaid but charged to customer"" />
      <xs:enumeration value=""Prepaid only"" />
      <xs:enumeration value=""Return container freight free"" />
      <xs:enumeration value=""Return container freight paid by customer"" />
      <xs:enumeration value=""Return container freight paid by supplier"" />
      <xs:enumeration value=""Third party pay"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalFreeOnBoardCode"" type=""globalfreeonboardcodeType"" />
  <xs:simpleType name=""globalfreeonboardcodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Destination"" />
      <xs:enumeration value=""Origin"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalCarrierCode"" type=""globalcarriercodeType"" />
  <xs:simpleType name=""globalcarriercodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""SCAC codes to be used."" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalPurchaseOrderTypeCode"" type=""globalpurchaseordertypecodeType"" />
  <xs:simpleType name=""globalpurchaseordertypecodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Blanket"" />
      <xs:enumeration value=""Consigned order"" />
      <xs:enumeration value=""Do not ship/invoice only"" />
      <xs:enumeration value=""ERS"" />
      <xs:enumeration value=""ESD"" />
      <xs:enumeration value=""Evaluation"" />
      <xs:enumeration value=""Exchange Order"" />
      <xs:enumeration value=""Fulfillment"" />
      <xs:enumeration value=""Government"" />
      <xs:enumeration value=""Non-cancelable/non-returnable"" />
      <xs:enumeration value=""Packaged product"" />
      <xs:enumeration value=""Production"" />
      <xs:enumeration value=""Quote to order"" />
      <xs:enumeration value=""Repair"" />
      <xs:enumeration value=""Replenishment"" />
      <xs:enumeration value=""Rework"" />
      <xs:enumeration value=""Risk Production"" />
      <xs:enumeration value=""Sample"" />
      <xs:enumeration value=""Service"" />
      <xs:enumeration value=""Site"" />
      <xs:enumeration value=""Standard"" />
      <xs:enumeration value=""Warranty repair"" />
      <xs:enumeration value=""Warranty replacement"" />
      <xs:enumeration value=""Worldwide"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalPurchaseOrderFillPriorityCode"" type=""globalpurchaseorderfillprioritycodeType"" />
  <xs:simpleType name=""globalpurchaseorderfillprioritycodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""High"" />
      <xs:enumeration value=""Low"" />
      <xs:enumeration value=""Medium"" />
      <xs:enumeration value=""Priority 1"" />
      <xs:enumeration value=""Priority 2"" />
      <xs:enumeration value=""Priority 3"" />
      <xs:enumeration value=""Priority 4"" />
      <xs:enumeration value=""Priority 5"" />
      <xs:enumeration value=""Priority 6"" />
      <xs:enumeration value=""Priority 7"" />
      <xs:enumeration value=""Priority 8"" />
      <xs:enumeration value=""Priority 9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalGovernmentPriorityRatingCode"" type=""globalgovernmentpriorityratingcodeType"" />
  <xs:simpleType name=""globalgovernmentpriorityratingcodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Atomic energy"" />
      <xs:enumeration value=""Defense"" />
      <xs:enumeration value=""Domestic energy"" />
      <xs:enumeration value=""Energy and related programs"" />
      <xs:enumeration value=""Other defense"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalPaymentConditionCode"" type=""globalpaymentconditioncodeType"" />
  <xs:simpleType name=""globalpaymentconditioncodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Acceptance"" />
      <xs:enumeration value=""Consumption"" />
      <xs:enumeration value=""Receipt of goods"" />
      <xs:enumeration value=""Receipt of Invoice"" />
      <xs:enumeration value=""Shipment"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalFinanceTermsCode"" type=""globalfinancetermscodeType"" />
  <xs:simpleType name=""globalfinancetermscodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Bank transfer"" />
      <xs:enumeration value=""Basic discount offered"" />
      <xs:enumeration value=""Consignment"" />
      <xs:enumeration value=""Credit card"" />
      <xs:enumeration value=""Electronic payment system"" />
      <xs:enumeration value=""In kind payment"" />
      <xs:enumeration value=""Lease agreement"" />
      <xs:enumeration value=""Letter of credit"" />
      <xs:enumeration value=""Mutually defined/determined by TPA"" />
      <xs:enumeration value=""Net month following invoice"" />
      <xs:enumeration value=""Pay by check"" />
      <xs:enumeration value=""Prepay check"" />
      <xs:enumeration value=""Prepay credit card"" />
      <xs:enumeration value=""Prepay wire"" />
      <xs:enumeration value=""Previously charged"" />
      <xs:enumeration value=""Private netting"" />
      <xs:enumeration value=""Terms established/determined by TPA"" />
      <xs:enumeration value=""Waived"" />
      <xs:enumeration value=""Wire transfer"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalDocumentReferenceTypeCode"" type=""globaldocumentreferencetypecodeType"" />
  <xs:simpleType name=""globaldocumentreferencetypecodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ASP Claim"" />
      <xs:enumeration value=""ASP Part Return"" />
      <xs:enumeration value=""ASP PartOrder"" />
      <xs:enumeration value=""ASP Requisition"" />
      <xs:enumeration value=""Commercial Invoice"" />
      <xs:enumeration value=""Contract"" />
      <xs:enumeration value=""Delivery Note"" />
      <xs:enumeration value=""Drawing #"" />
      <xs:enumeration value=""Invoice"" />
      <xs:enumeration value=""Master Event Number"" />
      <xs:enumeration value=""Model Number"" />
      <xs:enumeration value=""OEM Claim"" />
      <xs:enumeration value=""OEM Part Order"" />
      <xs:enumeration value=""OEM Part Return"" />
      <xs:enumeration value=""Purchase Order"" />
      <xs:enumeration value=""Purchase Order IN"" />
      <xs:enumeration value=""Purchase Order OUT"" />
      <xs:enumeration value=""Quote"" />
      <xs:enumeration value=""Requisition"" />
      <xs:enumeration value=""RMA - Returned Material Authorization"" />
      <xs:enumeration value=""Sales Order"" />
      <xs:enumeration value=""Serial Number"" />
      <xs:enumeration value=""SNCL"" />
      <xs:enumeration value=""Spec #"" />
      <xs:enumeration value=""Warranty Claim"" />
      <xs:enumeration value=""Waybill"" />
      <xs:enumeration value=""Work Order"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalAccountClassificationCode"" type=""globalaccountclassificationcodeType"" />
  <xs:simpleType name=""globalaccountclassificationcodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Checking"" />
      <xs:enumeration value=""Credit card"" />
      <xs:enumeration value=""Savings"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalCreditCardClassificationCode"" type=""globalcreditcardclassificationcodeType"" />
  <xs:simpleType name=""globalcreditcardclassificationcodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""American Express"" />
      <xs:enumeration value=""Discover"" />
      <xs:enumeration value=""EuroCard"" />
      <xs:enumeration value=""Japanese Credit Union"" />
      <xs:enumeration value=""Master Card"" />
      <xs:enumeration value=""Procurement"" />
      <xs:enumeration value=""Visa"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalCountryCode"" type=""globalcountrycodeType"" />
  <xs:simpleType name=""globalcountrycodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""AG"" />
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""AM"" />
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""AO"" />
      <xs:enumeration value=""AQ"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""AU"" />
      <xs:enumeration value=""AW"" />
      <xs:enumeration value=""AZ"" />
      <xs:enumeration value=""BA"" />
      <xs:enumeration value=""BB"" />
      <xs:enumeration value=""BD"" />
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""BF"" />
      <xs:enumeration value=""BG"" />
      <xs:enumeration value=""BH"" />
      <xs:enumeration value=""BI"" />
      <xs:enumeration value=""BJ"" />
      <xs:enumeration value=""BM"" />
      <xs:enumeration value=""BN"" />
      <xs:enumeration value=""BO"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""BS"" />
      <xs:enumeration value=""BT"" />
      <xs:enumeration value=""BV"" />
      <xs:enumeration value=""BW"" />
      <xs:enumeration value=""BY"" />
      <xs:enumeration value=""BZ"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""CG"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CI"" />
      <xs:enumeration value=""CK"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""CU"" />
      <xs:enumeration value=""CV"" />
      <xs:enumeration value=""CX"" />
      <xs:enumeration value=""CY"" />
      <xs:enumeration value=""CZ"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DJ"" />
      <xs:enumeration value=""DK"" />
      <xs:enumeration value=""DM"" />
      <xs:enumeration value=""DO"" />
      <xs:enumeration value=""DZ"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""EE"" />
      <xs:enumeration value=""EG"" />
      <xs:enumeration value=""EH"" />
      <xs:enumeration value=""ER"" />
      <xs:enumeration value=""ES"" />
      <xs:enumeration value=""ET"" />
      <xs:enumeration value=""FI"" />
      <xs:enumeration value=""FJ"" />
      <xs:enumeration value=""FK"" />
      <xs:enumeration value=""FM"" />
      <xs:enumeration value=""FO"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""GA"" />
      <xs:enumeration value=""GB"" />
      <xs:enumeration value=""GD"" />
      <xs:enumeration value=""GE"" />
      <xs:enumeration value=""GF"" />
      <xs:enumeration value=""GH"" />
      <xs:enumeration value=""GI"" />
      <xs:enumeration value=""GL"" />
      <xs:enumeration value=""GM"" />
      <xs:enumeration value=""GN"" />
      <xs:enumeration value=""GP"" />
      <xs:enumeration value=""GQ"" />
      <xs:enumeration value=""GR"" />
      <xs:enumeration value=""GS"" />
      <xs:enumeration value=""GT"" />
      <xs:enumeration value=""GU"" />
      <xs:enumeration value=""GW"" />
      <xs:enumeration value=""GY"" />
      <xs:enumeration value=""HK"" />
      <xs:enumeration value=""HM"" />
      <xs:enumeration value=""HN"" />
      <xs:enumeration value=""HR"" />
      <xs:enumeration value=""HT"" />
      <xs:enumeration value=""HU"" />
      <xs:enumeration value=""ID"" />
      <xs:enumeration value=""IE"" />
      <xs:enumeration value=""IL"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""IO"" />
      <xs:enumeration value=""IQ"" />
      <xs:enumeration value=""IR"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""IT"" />
      <xs:enumeration value=""JM"" />
      <xs:enumeration value=""JO"" />
      <xs:enumeration value=""JP"" />
      <xs:enumeration value=""KE"" />
      <xs:enumeration value=""KG"" />
      <xs:enumeration value=""KH"" />
      <xs:enumeration value=""KI"" />
      <xs:enumeration value=""KM"" />
      <xs:enumeration value=""KN"" />
      <xs:enumeration value=""KP"" />
      <xs:enumeration value=""KR"" />
      <xs:enumeration value=""KW"" />
      <xs:enumeration value=""KY"" />
      <xs:enumeration value=""KZ"" />
      <xs:enumeration value=""LA"" />
      <xs:enumeration value=""LB"" />
      <xs:enumeration value=""LC"" />
      <xs:enumeration value=""LI"" />
      <xs:enumeration value=""LK"" />
      <xs:enumeration value=""LR"" />
      <xs:enumeration value=""LS"" />
      <xs:enumeration value=""LT"" />
      <xs:enumeration value=""LU"" />
      <xs:enumeration value=""LV"" />
      <xs:enumeration value=""LY"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""MD"" />
      <xs:enumeration value=""MG"" />
      <xs:enumeration value=""MH"" />
      <xs:enumeration value=""MK"" />
      <xs:enumeration value=""ML"" />
      <xs:enumeration value=""MM"" />
      <xs:enumeration value=""MN"" />
      <xs:enumeration value=""MO"" />
      <xs:enumeration value=""MP"" />
      <xs:enumeration value=""MQ"" />
      <xs:enumeration value=""MR"" />
      <xs:enumeration value=""MS"" />
      <xs:enumeration value=""MT"" />
      <xs:enumeration value=""MU"" />
      <xs:enumeration value=""MV"" />
      <xs:enumeration value=""MW"" />
      <xs:enumeration value=""MX"" />
      <xs:enumeration value=""MY"" />
      <xs:enumeration value=""MZ"" />
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""NC"" />
      <xs:enumeration value=""NE"" />
      <xs:enumeration value=""NF"" />
      <xs:enumeration value=""NG"" />
      <xs:enumeration value=""NI"" />
      <xs:enumeration value=""NL"" />
      <xs:enumeration value=""NO"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""NR"" />
      <xs:enumeration value=""NT"" />
      <xs:enumeration value=""NU"" />
      <xs:enumeration value=""NZ"" />
      <xs:enumeration value=""OM"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PE"" />
      <xs:enumeration value=""PF"" />
      <xs:enumeration value=""PG"" />
      <xs:enumeration value=""PH"" />
      <xs:enumeration value=""PK"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PM"" />
      <xs:enumeration value=""PN"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""PW"" />
      <xs:enumeration value=""PY"" />
      <xs:enumeration value=""QA"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""RO"" />
      <xs:enumeration value=""RU"" />
      <xs:enumeration value=""RW"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SG"" />
      <xs:enumeration value=""SH"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""SJ"" />
      <xs:enumeration value=""SK"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SM"" />
      <xs:enumeration value=""SN"" />
      <xs:enumeration value=""SO"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""SV"" />
      <xs:enumeration value=""SY"" />
      <xs:enumeration value=""SZ"" />
      <xs:enumeration value=""TC"" />
      <xs:enumeration value=""TD"" />
      <xs:enumeration value=""TF"" />
      <xs:enumeration value=""TG"" />
      <xs:enumeration value=""TH"" />
      <xs:enumeration value=""TJ"" />
      <xs:enumeration value=""TK"" />
      <xs:enumeration value=""TM"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""TO"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""TT"" />
      <xs:enumeration value=""TV"" />
      <xs:enumeration value=""TW"" />
      <xs:enumeration value=""TZ"" />
      <xs:enumeration value=""UA"" />
      <xs:enumeration value=""UG"" />
      <xs:enumeration value=""UM"" />
      <xs:enumeration value=""US"" />
      <xs:enumeration value=""UY"" />
      <xs:enumeration value=""UZ"" />
      <xs:enumeration value=""VA"" />
      <xs:enumeration value=""VC"" />
      <xs:enumeration value=""VE"" />
      <xs:enumeration value=""VG"" />
      <xs:enumeration value=""VI"" />
      <xs:enumeration value=""VN"" />
      <xs:enumeration value=""VU"" />
      <xs:enumeration value=""WF"" />
      <xs:enumeration value=""WS"" />
      <xs:enumeration value=""YE"" />
      <xs:enumeration value=""YT"" />
      <xs:enumeration value=""YU"" />
      <xs:enumeration value=""ZA"" />
      <xs:enumeration value=""ZM"" />
      <xs:enumeration value=""ZR"" />
      <xs:enumeration value=""ZW"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalProductSubstitutionReasonCode"" type=""globalproductsubstitutionreasoncodeType"" />
  <xs:simpleType name=""globalproductsubstitutionreasoncodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Better product"" />
      <xs:enumeration value=""Invalid part number"" />
      <xs:enumeration value=""Quality / reliability hold"" />
      <xs:enumeration value=""Retired product"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalPurchaseOrderStatusCode"" type=""globalpurchaseorderstatuscodeType"" />
  <xs:simpleType name=""globalpurchaseorderstatuscodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Accept"" />
      <xs:enumeration value=""Pending"" />
      <xs:enumeration value=""Reject"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalPurchaseOrderAcknowledgmentReasonCode"" type=""globalpurchaseorderacknowledgmentreasoncodeType"" />
  <xs:simpleType name=""globalpurchaseorderacknowledgmentreasoncodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Accept with changes"" />
      <xs:enumeration value=""Already acknowledged"" />
      <xs:enumeration value=""Credit hold"" />
      <xs:enumeration value=""Export Restricted"" />
      <xs:enumeration value=""Insufficient inventory"" />
      <xs:enumeration value=""Invalid Bill To"" />
      <xs:enumeration value=""Invalid billing"" />
      <xs:enumeration value=""Invalid buyer ID"" />
      <xs:enumeration value=""Invalid configuration"" />
      <xs:enumeration value=""Invalid Fulfillment Code"" />
      <xs:enumeration value=""Invalid GTIN"" />
      <xs:enumeration value=""Invalid ID"" />
      <xs:enumeration value=""Invalid price list"" />
      <xs:enumeration value=""Invalid product"" />
      <xs:enumeration value=""Invalid quote reference"" />
      <xs:enumeration value=""Invalid Ship To"" />
      <xs:enumeration value=""Not authorized to sell"" />
      <xs:enumeration value=""Obsolete GTIN"" />
      <xs:enumeration value=""Packaged product only - no licenses"" />
      <xs:enumeration value=""Part replacement"" />
      <xs:enumeration value=""Part substitution"" />
      <xs:enumeration value=""Pending"" />
      <xs:enumeration value=""Pricing"" />
      <xs:enumeration value=""Product already shipped"" />
      <xs:enumeration value=""Reject - non-cancel/non-returnable"" />
      <xs:enumeration value=""Reject - not within cancellation window"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""GlobalConfirmationTypeCode"" type=""globalconfirmationtypecodeType"" />
  <xs:simpleType name=""globalconfirmationtypecodeType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""accept with delivery schedule change"" />
      <xs:enumeration value=""accept with multiple changes"" />
      <xs:enumeration value=""accept with no change"" />
      <xs:enumeration value=""accept with price change"" />
      <xs:enumeration value=""accept with product substitution"" />
    </xs:restriction>
  </xs:simpleType>
</xs:schema>";
        
        public BaseDataTypes() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [39];
                _RootElements[0] = "GlobalMimeTypeQualifierCode";
                _RootElements[1] = "GlobalAttachmentDescriptionCode";
                _RootElements[2] = "GlobalPartnerRoleClassificationCode";
                _RootElements[3] = "GlobalSupplyChainCode";
                _RootElements[4] = "GlobalPartnerClassificationCode";
                _RootElements[5] = "GlobalDocumentFunctionCode";
                _RootElements[6] = "AffirmationIndicator";
                _RootElements[7] = "GlobalProductUnitOfMeasureCode";
                _RootElements[8] = "GlobalAssemblyLevelCode";
                _RootElements[9] = "GlobalProductLifeCycleStatusCode";
                _RootElements[10] = "GlobalABCCode";
                _RootElements[11] = "GlobalProductProcurementTypeCode";
                _RootElements[12] = "GlobalIntervalCode";
                _RootElements[13] = "GlobalLeadTimeClassificationCode";
                _RootElements[14] = "GlobalTaxExemptionCode";
                _RootElements[15] = "InvoiceChargeTypeCode";
                _RootElements[16] = "GlobalMonetaryAmountTypeCode";
                _RootElements[17] = "GlobalCurrencyCode";
                _RootElements[18] = "GlobalTransportEventCode";
                _RootElements[19] = "GlobalCustomerTypeCode";
                _RootElements[20] = "GlobalSpecialHandlingCode";
                _RootElements[21] = "GlobalSpecialFulfillmentRequestCode";
                _RootElements[22] = "GlobalShippingServiceLevelCode";
                _RootElements[23] = "GlobalShipmentTermsCode";
                _RootElements[24] = "GlobalFreeOnBoardCode";
                _RootElements[25] = "GlobalCarrierCode";
                _RootElements[26] = "GlobalPurchaseOrderTypeCode";
                _RootElements[27] = "GlobalPurchaseOrderFillPriorityCode";
                _RootElements[28] = "GlobalGovernmentPriorityRatingCode";
                _RootElements[29] = "GlobalPaymentConditionCode";
                _RootElements[30] = "GlobalFinanceTermsCode";
                _RootElements[31] = "GlobalDocumentReferenceTypeCode";
                _RootElements[32] = "GlobalAccountClassificationCode";
                _RootElements[33] = "GlobalCreditCardClassificationCode";
                _RootElements[34] = "GlobalCountryCode";
                _RootElements[35] = "GlobalProductSubstitutionReasonCode";
                _RootElements[36] = "GlobalPurchaseOrderStatusCode";
                _RootElements[37] = "GlobalPurchaseOrderAcknowledgmentReasonCode";
                _RootElements[38] = "GlobalConfirmationTypeCode";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalMimeTypeQualifierCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalMimeTypeQualifierCode"})]
        public sealed class GlobalMimeTypeQualifierCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalMimeTypeQualifierCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalMimeTypeQualifierCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalAttachmentDescriptionCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalAttachmentDescriptionCode"})]
        public sealed class GlobalAttachmentDescriptionCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalAttachmentDescriptionCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalAttachmentDescriptionCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalPartnerRoleClassificationCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalPartnerRoleClassificationCode"})]
        public sealed class GlobalPartnerRoleClassificationCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalPartnerRoleClassificationCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalPartnerRoleClassificationCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalSupplyChainCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalSupplyChainCode"})]
        public sealed class GlobalSupplyChainCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalSupplyChainCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalSupplyChainCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalPartnerClassificationCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalPartnerClassificationCode"})]
        public sealed class GlobalPartnerClassificationCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalPartnerClassificationCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalPartnerClassificationCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalDocumentFunctionCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalDocumentFunctionCode"})]
        public sealed class GlobalDocumentFunctionCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalDocumentFunctionCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalDocumentFunctionCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"AffirmationIndicator")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AffirmationIndicator"})]
        public sealed class AffirmationIndicator : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AffirmationIndicator() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AffirmationIndicator";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalProductUnitOfMeasureCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalProductUnitOfMeasureCode"})]
        public sealed class GlobalProductUnitOfMeasureCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalProductUnitOfMeasureCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalProductUnitOfMeasureCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalAssemblyLevelCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalAssemblyLevelCode"})]
        public sealed class GlobalAssemblyLevelCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalAssemblyLevelCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalAssemblyLevelCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalProductLifeCycleStatusCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalProductLifeCycleStatusCode"})]
        public sealed class GlobalProductLifeCycleStatusCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalProductLifeCycleStatusCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalProductLifeCycleStatusCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalABCCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalABCCode"})]
        public sealed class GlobalABCCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalABCCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalABCCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalProductProcurementTypeCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalProductProcurementTypeCode"})]
        public sealed class GlobalProductProcurementTypeCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalProductProcurementTypeCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalProductProcurementTypeCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalIntervalCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalIntervalCode"})]
        public sealed class GlobalIntervalCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalIntervalCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalIntervalCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalLeadTimeClassificationCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalLeadTimeClassificationCode"})]
        public sealed class GlobalLeadTimeClassificationCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalLeadTimeClassificationCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalLeadTimeClassificationCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalTaxExemptionCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalTaxExemptionCode"})]
        public sealed class GlobalTaxExemptionCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalTaxExemptionCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalTaxExemptionCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"InvoiceChargeTypeCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InvoiceChargeTypeCode"})]
        public sealed class InvoiceChargeTypeCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InvoiceChargeTypeCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InvoiceChargeTypeCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalMonetaryAmountTypeCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalMonetaryAmountTypeCode"})]
        public sealed class GlobalMonetaryAmountTypeCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalMonetaryAmountTypeCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalMonetaryAmountTypeCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalCurrencyCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalCurrencyCode"})]
        public sealed class GlobalCurrencyCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalCurrencyCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalCurrencyCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalTransportEventCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalTransportEventCode"})]
        public sealed class GlobalTransportEventCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalTransportEventCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalTransportEventCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalCustomerTypeCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalCustomerTypeCode"})]
        public sealed class GlobalCustomerTypeCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalCustomerTypeCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalCustomerTypeCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalSpecialHandlingCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalSpecialHandlingCode"})]
        public sealed class GlobalSpecialHandlingCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalSpecialHandlingCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalSpecialHandlingCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalSpecialFulfillmentRequestCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalSpecialFulfillmentRequestCode"})]
        public sealed class GlobalSpecialFulfillmentRequestCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalSpecialFulfillmentRequestCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalSpecialFulfillmentRequestCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalShippingServiceLevelCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalShippingServiceLevelCode"})]
        public sealed class GlobalShippingServiceLevelCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalShippingServiceLevelCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalShippingServiceLevelCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalShipmentTermsCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalShipmentTermsCode"})]
        public sealed class GlobalShipmentTermsCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalShipmentTermsCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalShipmentTermsCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalFreeOnBoardCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalFreeOnBoardCode"})]
        public sealed class GlobalFreeOnBoardCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalFreeOnBoardCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalFreeOnBoardCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalCarrierCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalCarrierCode"})]
        public sealed class GlobalCarrierCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalCarrierCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalCarrierCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalPurchaseOrderTypeCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalPurchaseOrderTypeCode"})]
        public sealed class GlobalPurchaseOrderTypeCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalPurchaseOrderTypeCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalPurchaseOrderTypeCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalPurchaseOrderFillPriorityCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalPurchaseOrderFillPriorityCode"})]
        public sealed class GlobalPurchaseOrderFillPriorityCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalPurchaseOrderFillPriorityCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalPurchaseOrderFillPriorityCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalGovernmentPriorityRatingCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalGovernmentPriorityRatingCode"})]
        public sealed class GlobalGovernmentPriorityRatingCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalGovernmentPriorityRatingCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalGovernmentPriorityRatingCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalPaymentConditionCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalPaymentConditionCode"})]
        public sealed class GlobalPaymentConditionCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalPaymentConditionCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalPaymentConditionCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalFinanceTermsCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalFinanceTermsCode"})]
        public sealed class GlobalFinanceTermsCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalFinanceTermsCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalFinanceTermsCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalDocumentReferenceTypeCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalDocumentReferenceTypeCode"})]
        public sealed class GlobalDocumentReferenceTypeCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalDocumentReferenceTypeCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalDocumentReferenceTypeCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalAccountClassificationCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalAccountClassificationCode"})]
        public sealed class GlobalAccountClassificationCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalAccountClassificationCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalAccountClassificationCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalCreditCardClassificationCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalCreditCardClassificationCode"})]
        public sealed class GlobalCreditCardClassificationCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalCreditCardClassificationCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalCreditCardClassificationCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalCountryCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalCountryCode"})]
        public sealed class GlobalCountryCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalCountryCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalCountryCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalProductSubstitutionReasonCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalProductSubstitutionReasonCode"})]
        public sealed class GlobalProductSubstitutionReasonCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalProductSubstitutionReasonCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalProductSubstitutionReasonCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalPurchaseOrderStatusCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalPurchaseOrderStatusCode"})]
        public sealed class GlobalPurchaseOrderStatusCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalPurchaseOrderStatusCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalPurchaseOrderStatusCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalPurchaseOrderAcknowledgmentReasonCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalPurchaseOrderAcknowledgmentReasonCode"})]
        public sealed class GlobalPurchaseOrderAcknowledgmentReasonCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalPurchaseOrderAcknowledgmentReasonCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalPurchaseOrderAcknowledgmentReasonCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://Microsoft.Solutions.BTARN.Schemas.RNPIPs.BaseDataTypes",@"GlobalConfirmationTypeCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"GlobalConfirmationTypeCode"})]
        public sealed class GlobalConfirmationTypeCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public GlobalConfirmationTypeCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "GlobalConfirmationTypeCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
    }
}
