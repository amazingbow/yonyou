#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace DocumentTypeModel
{
	[Serializable]
	public partial class DocumentTypeModelModel : UIModel
	{
		#region Constructor
		public DocumentTypeModelModel() : base("DocumentTypeModel")
		{
			InitClass();
			this.SetResourceInfo("06e9d8a5-1b8e-4b79-9abd-427fe8afab56");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private DocumentTypeModelModel(bool isInit) : base("DocumentTypeModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new DocumentTypeModelModel(false);
		}
		#endregion
		#region member
		#region views
		private Cust_Xmjl_DocumentTypeView viewCust_Xmjl_DocumentType;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public Cust_Xmjl_DocumentTypeView Cust_Xmjl_DocumentType
		{
			get { return (Cust_Xmjl_DocumentTypeView)this["Cust_Xmjl_DocumentType"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewCust_Xmjl_DocumentType = new Cust_Xmjl_DocumentTypeView(this);
			this.viewCust_Xmjl_DocumentType.SetResourceInfo("1973aa08-1228-4f0a-ba62-161dce10c09b");
			this.Views.Add(this.viewCust_Xmjl_DocumentType);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.XMJL.UI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class Cust_Xmjl_DocumentTypeView : UIView
	{
		#region Constructor
		public Cust_Xmjl_DocumentTypeView(IUIModel model) : base(model,"Cust_Xmjl_DocumentType","UFIDA.U9.Cust.XMJL.DocumentTypeBE.Cust_Xmjl_DocumentType", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private Cust_Xmjl_DocumentTypeView():base(null,"Cust_Xmjl_DocumentType","UFIDA.U9.Cust.XMJL.DocumentTypeBE.Cust_Xmjl_DocumentType", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new Cust_Xmjl_DocumentTypeView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldCreatedOn
		{
			get { return this.Fields["CreatedOn"]; }
		}
		public IUIField FieldCreatedBy
		{
			get { return this.Fields["CreatedBy"]; }
		}
		public IUIField FieldModifiedOn
		{
			get { return this.Fields["ModifiedOn"]; }
		}
		public IUIField FieldModifiedBy
		{
			get { return this.Fields["ModifiedBy"]; }
		}
		public IUIField FieldSysVersion
		{
			get { return this.Fields["SysVersion"]; }
		}
		public IUIField FieldConfirmType
		{
			get { return this.Fields["ConfirmType"]; }
		}
		public IUIField FieldWorkFlowCode
		{
			get { return this.Fields["WorkFlowCode"]; }
		}
		public IUIField FieldIsRAMADoc
		{
			get { return this.Fields["IsRAMADoc"]; }
		}
		public IUIField FieldIsAMADoc
		{
			get { return this.Fields["IsAMADoc"]; }
		}
		public IUIField FieldIsRMADoc
		{
			get { return this.Fields["IsRMADoc"]; }
		}
		public IUIField FieldDocHeaderSequenceStyle
		{
			get { return this.Fields["DocHeaderSequenceStyle"]; }
		}
		public IUIField FieldDocHeaderSequence
		{
			get { return this.Fields["DocHeaderSequence"]; }
		}
		public IUIField FieldDocHeaderSequence_Code
		{
			get { return this.Fields["DocHeaderSequence_Code"]; }
		}
		public IUIField FieldDocHeaderSequence_Name
		{
			get { return this.Fields["DocHeaderSequence_Name"]; }
		}
		public IUIField FieldPrintStyle
		{
			get { return this.Fields["PrintStyle"]; }
		}
		public IUIField FieldMaxAmountOfPrint
		{
			get { return this.Fields["MaxAmountOfPrint"]; }
		}
		public IUIField FieldIsCopyPrinted
		{
			get { return this.Fields["IsCopyPrinted"]; }
		}
		public IUIField FieldPrintTemplate
		{
			get { return this.Fields["PrintTemplate"]; }
		}
		public IUIField FieldBusinessType
		{
			get { return this.Fields["BusinessType"]; }
		}
		public IUIField FieldCode
		{
			get { return this.Fields["Code"]; }
		}
		public IUIField FieldName
		{
			get { return this.Fields["Name"]; }
		}
		public IUIField FieldShortName
		{
			get { return this.Fields["ShortName"]; }
		}
		public IUIField FieldDescription
		{
			get { return this.Fields["Description"]; }
		}
		public IUIField FieldEffective_IsEffective
		{
			get { return this.Fields["Effective_IsEffective"]; }
		}
		public IUIField FieldEffective_EffectiveDate
		{
			get { return this.Fields["Effective_EffectiveDate"]; }
		}
		public IUIField FieldEffective_DisableDate
		{
			get { return this.Fields["Effective_DisableDate"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg1
		{
			get { return this.Fields["DescFlexField_PubDescSeg1"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg2
		{
			get { return this.Fields["DescFlexField_PubDescSeg2"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg3
		{
			get { return this.Fields["DescFlexField_PubDescSeg3"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg4
		{
			get { return this.Fields["DescFlexField_PubDescSeg4"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg5
		{
			get { return this.Fields["DescFlexField_PubDescSeg5"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg6
		{
			get { return this.Fields["DescFlexField_PubDescSeg6"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg7
		{
			get { return this.Fields["DescFlexField_PubDescSeg7"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg8
		{
			get { return this.Fields["DescFlexField_PubDescSeg8"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg9
		{
			get { return this.Fields["DescFlexField_PubDescSeg9"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg10
		{
			get { return this.Fields["DescFlexField_PubDescSeg10"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg11
		{
			get { return this.Fields["DescFlexField_PubDescSeg11"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg12
		{
			get { return this.Fields["DescFlexField_PubDescSeg12"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg13
		{
			get { return this.Fields["DescFlexField_PubDescSeg13"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg14
		{
			get { return this.Fields["DescFlexField_PubDescSeg14"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg15
		{
			get { return this.Fields["DescFlexField_PubDescSeg15"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg16
		{
			get { return this.Fields["DescFlexField_PubDescSeg16"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg17
		{
			get { return this.Fields["DescFlexField_PubDescSeg17"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg18
		{
			get { return this.Fields["DescFlexField_PubDescSeg18"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg19
		{
			get { return this.Fields["DescFlexField_PubDescSeg19"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg20
		{
			get { return this.Fields["DescFlexField_PubDescSeg20"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg21
		{
			get { return this.Fields["DescFlexField_PubDescSeg21"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg22
		{
			get { return this.Fields["DescFlexField_PubDescSeg22"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg23
		{
			get { return this.Fields["DescFlexField_PubDescSeg23"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg24
		{
			get { return this.Fields["DescFlexField_PubDescSeg24"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg25
		{
			get { return this.Fields["DescFlexField_PubDescSeg25"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg26
		{
			get { return this.Fields["DescFlexField_PubDescSeg26"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg27
		{
			get { return this.Fields["DescFlexField_PubDescSeg27"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg28
		{
			get { return this.Fields["DescFlexField_PubDescSeg28"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg29
		{
			get { return this.Fields["DescFlexField_PubDescSeg29"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg30
		{
			get { return this.Fields["DescFlexField_PubDescSeg30"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg31
		{
			get { return this.Fields["DescFlexField_PubDescSeg31"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg32
		{
			get { return this.Fields["DescFlexField_PubDescSeg32"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg33
		{
			get { return this.Fields["DescFlexField_PubDescSeg33"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg34
		{
			get { return this.Fields["DescFlexField_PubDescSeg34"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg35
		{
			get { return this.Fields["DescFlexField_PubDescSeg35"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg36
		{
			get { return this.Fields["DescFlexField_PubDescSeg36"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg37
		{
			get { return this.Fields["DescFlexField_PubDescSeg37"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg38
		{
			get { return this.Fields["DescFlexField_PubDescSeg38"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg39
		{
			get { return this.Fields["DescFlexField_PubDescSeg39"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg40
		{
			get { return this.Fields["DescFlexField_PubDescSeg40"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg41
		{
			get { return this.Fields["DescFlexField_PubDescSeg41"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg42
		{
			get { return this.Fields["DescFlexField_PubDescSeg42"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg43
		{
			get { return this.Fields["DescFlexField_PubDescSeg43"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg44
		{
			get { return this.Fields["DescFlexField_PubDescSeg44"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg45
		{
			get { return this.Fields["DescFlexField_PubDescSeg45"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg46
		{
			get { return this.Fields["DescFlexField_PubDescSeg46"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg47
		{
			get { return this.Fields["DescFlexField_PubDescSeg47"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg48
		{
			get { return this.Fields["DescFlexField_PubDescSeg48"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg49
		{
			get { return this.Fields["DescFlexField_PubDescSeg49"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg50
		{
			get { return this.Fields["DescFlexField_PubDescSeg50"]; }
		}
		public IUIField FieldDescFlexField_ContextValue
		{
			get { return this.Fields["DescFlexField_ContextValue"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg1
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg1"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg2
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg2"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg3
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg3"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg4
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg4"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg5
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg5"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg6
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg6"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg7
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg7"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg8
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg8"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg9
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg9"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg10
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg10"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg11
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg11"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg12
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg12"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg13
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg13"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg14
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg14"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg15
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg15"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg16
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg16"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg17
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg17"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg18
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg18"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg19
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg19"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg20
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg20"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg21
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg21"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg22
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg22"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg23
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg23"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg24
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg24"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg25
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg25"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg26
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg26"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg27
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg27"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg28
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg28"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg29
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg29"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg30
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg30"]; }
		}
		public IUIField FieldDescFlexField_CombineName
		{
			get { return this.Fields["DescFlexField_CombineName"]; }
		}
		public IUIField FieldOrg
		{
			get { return this.Fields["Org"]; }
		}
		public IUIField FieldOrg_Code
		{
			get { return this.Fields["Org_Code"]; }
		}
		public IUIField FieldOrg_Name
		{
			get { return this.Fields["Org_Name"]; }
		}
		public IUIField FieldIsCreatedByPush
		{
			get { return this.Fields["IsCreatedByPush"]; }
		}
		public IUIField FieldIsDocNoEditable
		{
			get { return this.Fields["IsDocNoEditable"]; }
		}
		public IUIField FieldIsSaveSubmit
		{
			get { return this.Fields["IsSaveSubmit"]; }
		}
		public IUIField FieldPrintMode
		{
			get { return this.Fields["PrintMode"]; }
		}
		public IUIField FieldNetPrinterCode
		{
			get { return this.Fields["NetPrinterCode"]; }
		}
		public IUIField FieldNetPrinterName
		{
			get { return this.Fields["NetPrinterName"]; }
		}
		public IUIField FieldMasterSite
		{
			get { return this.Fields["MasterSite"]; }
		}
		public IUIField FieldApproveType
		{
			get { return this.Fields["ApproveType"]; }
		}
		public IUIField FieldIsApprovingCanModify
		{
			get { return this.Fields["IsApprovingCanModify"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public Cust_Xmjl_DocumentTypeDefaultFilterFilter DefaultFilter
		{
			get { return (Cust_Xmjl_DocumentTypeDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","498a90f0-6b40-47c6-9b49-ea8594df53ba");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","d5bb15e3-4e2d-48fa-9264-22f0441c8c69");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","966b5df8-4bb7-47e6-9592-b4742ae16b14");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","c9141857-89b8-4667-a2bb-6e396246d801");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8a3ca040-2b74-4b47-9d2a-07cf82563448");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","d92f4537-1eef-45f5-ae6c-8ca29779eaa5");
			UIModelRuntimeFactory.AddNewUIField(this,"ConfirmType", typeof(Int32), false,"0","UFIDA.U9.Base.Doc.ConfirmTypeEnum", "ConfirmType", true,true, false, "",false,(UIFieldType)2,"d232b8fb-1938-4ebe-a90c-41c911c0bc10","e79f94ce-750e-4c9e-a70b-20442f47599e");
			UIModelRuntimeFactory.AddNewUIField(this,"WorkFlowCode", typeof(Guid), true,"","System.Guid", "WorkFlowCode", true,true, false, "",false,(UIFieldType)1,"2b057235-c58e-441e-9477-5e52fcb7f95b","9491b46a-b3ed-48dc-aaf7-40cab0d37aef");
			UIModelRuntimeFactory.AddNewUIField(this,"IsRAMADoc", typeof(Boolean), true,"true","System.Boolean", "IsRAMADoc", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","7066a334-5824-4eef-ba8c-991efb83db45");
			UIModelRuntimeFactory.AddNewUIField(this,"IsAMADoc", typeof(Boolean), true,"false","System.Boolean", "IsAMADoc", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","bef9bd38-9368-48aa-9498-6d6d231677a8");
			UIModelRuntimeFactory.AddNewUIField(this,"IsRMADoc", typeof(Boolean), true,"false","System.Boolean", "IsRMADoc", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","27ee9fb3-da0f-4969-8bb3-f07c4380517b");
			UIModelRuntimeFactory.AddNewUIField(this,"DocHeaderSequenceStyle", typeof(Int32), false,"0","UFIDA.U9.Base.Doc.DocHeaderSequenceStyleEnum", "DocHeaderSequenceStyle", true,true, false, "",false,(UIFieldType)2,"dcf65e0a-1554-447b-b4c6-b3ec2951d965","c41c7129-1f59-4012-acfd-e472e6297398");
			UIModelRuntimeFactory.AddNewUIField(this,"DocHeaderSequence", typeof(Int64), true,"","UFIDA.U9.Base.Sequence.SequenceDef", "DocHeaderSequence", true,true, false, "",false,(UIFieldType)4,"b2c49db4-e8ac-4ff3-955c-aae5a203ecef","34d2c4c9-209b-4f28-a2e8-eeb495387302");
			UIModelRuntimeFactory.AddNewUIField(this,"DocHeaderSequence_Code", typeof(String), false,"","System.String", "DocHeaderSequence.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","514b8629-f429-4ffb-9334-4f4afd0c023e");
			UIModelRuntimeFactory.AddNewUIField(this,"DocHeaderSequence_Name", typeof(String), true,"","System.String", "DocHeaderSequence.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7b96952b-fb36-437a-96b4-6c8a68dd2435");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintStyle", typeof(Int32), false,"0","UFIDA.U9.Base.Doc.PrintStyleEnum", "PrintStyle", true,true, false, "",false,(UIFieldType)2,"25989155-e5ec-47c2-9347-2d789440602f","ee0baca0-9807-44a7-a134-1216824dcb73");
			UIModelRuntimeFactory.AddNewUIField(this,"MaxAmountOfPrint", typeof(Int32), false,"0","System.Int32", "MaxAmountOfPrint", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","5a441231-6ed8-483f-80db-c1b6265ff4c3");
			UIModelRuntimeFactory.AddNewUIField(this,"IsCopyPrinted", typeof(Boolean), false,"false","System.Boolean", "IsCopyPrinted", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","d48719b2-891f-4b8f-84ba-2b41fd33e88a");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintTemplate", typeof(Int64), true,"","UFSoft.UBF.ExportService.PrintReferenceBE.PrintTemplate", "PrintTemplate", true,true, false, "",false,(UIFieldType)4,"dd17d05e-e2c0-48c5-802a-f1be67ee311e","2b488689-3806-44f4-8805-2df3209ef4df");
			UIModelRuntimeFactory.AddNewUIField(this,"BusinessType", typeof(Int32), true,"-1","UFIDA.U9.Base.Doc.BusinessTypeEnum", "BusinessType", true,true, false, "",false,(UIFieldType)2,"fc998dce-aa68-4d34-8557-a0afdf601afe","05ac4d63-1718-4fd7-83a0-806e1b115300");
			UIModelRuntimeFactory.AddNewUIField(this,"Code", typeof(String), false,"","System.String", "Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","996b1752-b596-4953-b803-7aa1bb9bd756");
			UIModelRuntimeFactory.AddNewUIField(this,"Name", typeof(String), true,"","System.String", "Name", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","88772d7f-bdfe-45a8-80f6-4775a049b28e");
			UIModelRuntimeFactory.AddNewUIField(this,"ShortName", typeof(String), true,"","System.String", "ShortName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","68813a40-0f78-44f2-a69c-00fa2a8d74ed");
			UIModelRuntimeFactory.AddNewUIField(this,"Description", typeof(String), true,"","System.String", "Description", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f8eb1d57-9427-471a-9be2-4dc89d08da6a");
			UIModelRuntimeFactory.AddNewUIField(this,"Effective_IsEffective", typeof(Boolean), true,"true","System.Boolean", "Effective.IsEffective", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","dd270cbf-f125-45b2-a3b7-545990a73513");
			UIModelRuntimeFactory.AddNewUIField(this,"Effective_EffectiveDate", typeof(DateTime), true,"2000-01-01","System.Date", "Effective.EffectiveDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","115c6cd0-fb4a-4961-af87-ad5c57523524");
			UIModelRuntimeFactory.AddNewUIField(this,"Effective_DisableDate", typeof(DateTime), true,"9999-12-31","System.Date", "Effective.DisableDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","a8a2cf54-ccae-4bde-9eab-3d5fe5b8430a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","629898b7-ffc2-48cc-bdc6-e5adef1dc49e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b2e28f05-c265-4b7f-bfbc-2578bc2cd4b8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f5d16ce7-7901-4aab-b4a2-ca5ce79a86be");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2b958114-5ab6-409e-96b9-d35126dcb883");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a500b5f1-fd07-4e55-baed-ce80f1b476a5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d7e7ae81-49e6-4113-a29f-982c7d060098");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","866040b1-e4e7-4b82-a7f2-3e83415e73cd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2ff2db4b-0037-4e04-bbbc-0c4c2129ecb3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","684bf3ab-bbc5-48ee-88a8-c6e6864035cc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","94f590db-3ea3-4155-9b5b-7b3b0691efe9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8a31db6c-4b76-4edd-9f12-ab664862e802");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7c9030e4-dcce-461b-9494-7cb808512a5d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","91f4f243-3b6c-4bfe-8380-f2e6993a8e13");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","59ecf318-e0b9-4ef2-b0f9-e75206a1ab04");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","28d25933-0402-491f-86d8-785d84eb22f3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d9d2ea29-b97a-441a-8314-e78bd0e6ecd3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f0237dd6-0461-4377-9190-a9a4cf5f183d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","075d05ab-12a9-4820-8399-29d67a9861bd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6c0f9318-0cc2-4441-a11e-06aa488e2766");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","97f477f0-aaaa-4e24-ae76-e35ef721dcab");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2c54c08e-3cf8-4b75-aafe-22971d61b4f1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e06a5e49-c46b-4a0c-81b4-a67d7dadd436");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5e2dcf0a-107b-4dee-9cc2-d92404f8e414");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d789cb33-1094-44b5-8179-ee85bc0024d3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8512c87d-926f-42f7-953e-c99567a7225c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b514a539-8e40-4b9c-9e5b-4732e9dae922");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","44dcffe2-4281-4c30-a25d-12f409bbbedd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f1e7dc32-5234-4399-a522-8b027886b3f5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","37ce2f4d-bfb2-4709-8050-aa4c218558d5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f9173cd2-ce20-4227-98ea-a73435bde7f3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg31", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c0e23fa3-5fa5-43c5-86f6-accae830d4f8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg32", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","771e4950-af65-4c3c-9e30-0acbfef2644f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg33", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c72ff809-38b8-4e40-b53a-b8b943c82dc5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg34", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bd084501-e574-45a2-a31d-858ac9413513");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg35", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","36ede1c4-e833-40c7-b9a6-7a7384e587e8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg36", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6f42bfa0-0ceb-466b-9afe-9f33311aacc4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg37", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a06303f3-a8ec-47b6-aba9-9d6fe1de1626");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg38", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","44e41ac8-b168-4a6e-97e1-a9c8777959f0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg39", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6cd3aaa2-191d-4a03-a63e-cb96c7c0bf20");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg40", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","83618fa4-6df6-452c-a1a3-b013ea482f43");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg41", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","625fa413-dc99-4a4d-8811-038d9d61d827");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg42", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","44623584-b612-4d39-be80-5cdb0cfd51e8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg43", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bed9cc6e-2e69-48f0-ab1f-fd86704cda0d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg44", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b1581b6a-60a6-4014-87b2-6fe5e4da2718");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg45", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4b8c153b-42f2-4ca8-849f-14626f56e01a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg46", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e4b8d603-215a-4f59-89ca-0deedcfd8f0f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg47", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","25c528ed-e7f3-45d8-ac3b-04427711116b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg48", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e7ed358e-9827-40cd-94c3-177cc184a9b8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg49", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6c5e59f4-14f3-4b6e-a2c7-05ba6e9ce2f1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg50", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","44c88344-572a-47ab-87a9-3cfb24365efd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_ContextValue", typeof(String), true,"","System.String", "DescFlexField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8972a21d-221f-42ea-89b2-cf98722d8bb9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","111330f8-af21-42aa-9562-57d82bca6780");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e8a6e3de-b201-4843-9665-2b6db227bb8c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c1ac05f9-463d-4fc3-8436-cb3c33888943");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1ad262bb-939c-43f9-8bc4-0c5f50657d5b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","26f2cfef-a7ce-4900-9188-528c66c4e41e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","efdb7c67-92ec-4cf5-abdb-ac00ea151438");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1839b71b-5de3-4380-ae51-ad80fb3c8d45");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b13d4244-0be8-4674-b7ad-5126f20220a7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","22630a8f-f32f-4485-beef-45ff073c23bb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0dc33029-de84-47a6-8cbe-36ae7b696b30");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","aa633cc8-0deb-49f2-9f07-f433822babcf");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","33e99220-cb6a-47c4-a142-67579adb5e4d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","57406a69-21ff-4e2d-9358-83c2a18c761d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6e377cf8-6cfb-441e-832d-980f64ce709d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","55b3ef34-a4af-4353-8c2c-aaaaf7f02c0b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","20b697ed-1279-49a0-be49-0b691af7cf31");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","801f6cd2-a100-4916-9208-ffc406cac14d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","364a271f-c265-42a9-ac82-bdb53a0cfbca");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b2c6ad76-0b30-4662-9eba-68ae3db8815d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c80cdf49-fa19-42b6-8874-525ed65f8d96");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","214c14d1-b62e-4d8e-a1af-9eb702cb0e07");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bf3d2477-4c4e-4c1d-92fe-957317d66c8b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","af30b4dd-9801-479e-8511-2591fe30b5d5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0ef307c5-6043-4299-b7c5-19f285a2c2db");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8f89288c-b023-44b0-bc6f-cc9d16ba0baa");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","72c23813-bc41-4e34-982f-67f6452b4f71");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","68a793eb-e2e1-4bef-9a68-89ecccbfafc9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9566c978-6cfd-4c75-a371-a7af52b2d0e0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ba3f8b73-c9c5-4a04-8efe-62207dfb0d07");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a5cd8923-3ee5-4303-b589-33f7ff298422");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_CombineName", typeof(String), true,"","System.String", "DescFlexField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ebec7bea-818d-441d-b820-f0304d311cb4");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), false,"","UFIDA.U9.Base.Organization.Organization", "Org", true,true, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","303437e6-75cf-4641-9acc-47889c975687");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), false,"","System.String", "Org.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8aedfde7-2b01-4cac-81c2-6efcfd3e9772");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "Org.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f3886527-2fca-4b15-bb3e-9a62991b7f5c");
			UIModelRuntimeFactory.AddNewUIField(this,"IsCreatedByPush", typeof(Boolean), true,"false","System.Boolean", "IsCreatedByPush", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","3aafd538-c41a-4b3e-845c-e004d1c37b65");
			UIModelRuntimeFactory.AddNewUIField(this,"IsDocNoEditable", typeof(Boolean), true,"false","System.Boolean", "IsDocNoEditable", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","70236bcb-4806-41b5-9fe2-ffaeb9becf27");
			UIModelRuntimeFactory.AddNewUIField(this,"IsSaveSubmit", typeof(Boolean), true,"false","System.Boolean", "IsSaveSubmit", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","df37bc06-6f8b-4650-9ac0-1b2517466d62");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintMode", typeof(Int32), false,"0","UFIDA.U9.Base.Doc.PrintModeEnum", "PrintMode", true,true, false, "",false,(UIFieldType)2,"6862b23e-62fb-4453-9eed-4a2fad986a9f","3cab71e9-cb48-4a1e-a3ef-d68dc4158cdd");
			UIModelRuntimeFactory.AddNewUIField(this,"NetPrinterCode", typeof(String), true,"","System.String", "NetPrinterCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","78f0858e-dd96-4890-bd5e-a4d891b9d894");
			UIModelRuntimeFactory.AddNewUIField(this,"NetPrinterName", typeof(String), true,"","System.String", "NetPrinterName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2d69b36e-45ca-47d7-abf1-d13952e5c419");
			UIModelRuntimeFactory.AddNewUIField(this,"MasterSite", typeof(String), true,"","System.String", "MasterSite", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0eaccc4e-dd0b-4dfd-8d16-e9cc01ded9b7");
			UIModelRuntimeFactory.AddNewUIField(this,"ApproveType", typeof(Int32), true,"-1","UFIDA.U9.Base.Doc.ApproveTypeEnum", "ApproveType", true,true, false, "",false,(UIFieldType)2,"d4b6e1a9-d80d-4516-8316-4b1d436cd449","65c6024a-9bdd-4442-89d6-92189b485237");
			UIModelRuntimeFactory.AddNewUIField(this,"IsApprovingCanModify", typeof(Boolean), false,"true","System.Boolean", "IsApprovingCanModify", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","64e42d1e-ff13-4e96-b970-8da16c61e027");


			this.CurrentFilter = new Cust_Xmjl_DocumentTypeDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new Cust_Xmjl_DocumentTypeRecord(builder);
		}
		#endregion

		#region new method
		public new Cust_Xmjl_DocumentTypeRecord FocusedRecord
		{
			get { return (Cust_Xmjl_DocumentTypeRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new Cust_Xmjl_DocumentTypeRecord AddNewUIRecord()
		{	
			return (Cust_Xmjl_DocumentTypeRecord)base.AddNewUIRecord();
		}
		public new Cust_Xmjl_DocumentTypeRecord NewUIRecord()
		{	
			return (Cust_Xmjl_DocumentTypeRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class Cust_Xmjl_DocumentTypeRecord : UIRecord
	{
		#region Constructor
		public Cust_Xmjl_DocumentTypeRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private Cust_Xmjl_DocumentTypeView uiviewCust_Xmjl_DocumentType
		{
			get { return (Cust_Xmjl_DocumentTypeView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new Cust_Xmjl_DocumentTypeRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCust_Xmjl_DocumentType.FieldID);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_DocumentType.FieldCreatedOn);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldCreatedBy);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_DocumentType.FieldModifiedOn);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldModifiedBy);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_DocumentType.FieldSysVersion);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldSysVersion] = value;
			}
		}
		
		
		public  Int32 ConfirmType
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldConfirmType] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewCust_Xmjl_DocumentType.FieldConfirmType);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldConfirmType] = value;
			}
		}
		
		
		public  Guid WorkFlowCode
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldWorkFlowCode] ;
				//return (Guid)value;
				return GetValue<Guid>(this.uiviewCust_Xmjl_DocumentType.FieldWorkFlowCode);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldWorkFlowCode] = value;
			}
		}
		
		
		public  Boolean? IsRAMADoc
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldIsRAMADoc] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewCust_Xmjl_DocumentType.FieldIsRAMADoc);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldIsRAMADoc] = value;
			}
		}
		
		
		public  Boolean? IsAMADoc
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldIsAMADoc] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewCust_Xmjl_DocumentType.FieldIsAMADoc);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldIsAMADoc] = value;
			}
		}
		
		
		public  Boolean? IsRMADoc
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldIsRMADoc] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewCust_Xmjl_DocumentType.FieldIsRMADoc);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldIsRMADoc] = value;
			}
		}
		
		
		public  Int32 DocHeaderSequenceStyle
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDocHeaderSequenceStyle] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewCust_Xmjl_DocumentType.FieldDocHeaderSequenceStyle);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDocHeaderSequenceStyle] = value;
			}
		}
		
		
		public  Int64? DocHeaderSequence
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDocHeaderSequence] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_DocumentType.FieldDocHeaderSequence);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDocHeaderSequence] = value;
			}
		}
		
		
		public  String DocHeaderSequence_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDocHeaderSequence_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDocHeaderSequence_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDocHeaderSequence_Code] = value;
			}
		}
		
		
		public  String DocHeaderSequence_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDocHeaderSequence_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDocHeaderSequence_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDocHeaderSequence_Name] = value;
			}
		}
		
		
		public  Int32 PrintStyle
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldPrintStyle] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewCust_Xmjl_DocumentType.FieldPrintStyle);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldPrintStyle] = value;
			}
		}
		
		
		public  Int32 MaxAmountOfPrint
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldMaxAmountOfPrint] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewCust_Xmjl_DocumentType.FieldMaxAmountOfPrint);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldMaxAmountOfPrint] = value;
			}
		}
		
		
		public  Boolean IsCopyPrinted
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldIsCopyPrinted] ;
				//return (Boolean)value;
				return GetValue<Boolean>(this.uiviewCust_Xmjl_DocumentType.FieldIsCopyPrinted);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldIsCopyPrinted] = value;
			}
		}
		
		
		public  Int64? PrintTemplate
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldPrintTemplate] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_DocumentType.FieldPrintTemplate);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldPrintTemplate] = value;
			}
		}
		
		
		public  Int32? BusinessType
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldBusinessType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCust_Xmjl_DocumentType.FieldBusinessType);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldBusinessType] = value;
			}
		}
		
		
		public  String Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldCode);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldCode] = value;
			}
		}
		
		
		public new String Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldName);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldName] = value;
			}
		}
		
		
		public  String ShortName
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldShortName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldShortName);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldShortName] = value;
			}
		}
		
		
		public  String Description
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescription] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescription);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescription] = value;
			}
		}
		
		
		public  Boolean? Effective_IsEffective
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldEffective_IsEffective] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewCust_Xmjl_DocumentType.FieldEffective_IsEffective);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldEffective_IsEffective] = value;
			}
		}
		
		
		public  DateTime? Effective_EffectiveDate
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldEffective_EffectiveDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_DocumentType.FieldEffective_EffectiveDate);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldEffective_EffectiveDate] = value;
			}
		}
		
		
		public  DateTime? Effective_DisableDate
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldEffective_DisableDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_DocumentType.FieldEffective_DisableDate);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldEffective_DisableDate] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg1
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg1);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg2
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg2);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg3
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg3);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg4
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg4);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg5
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg5);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg6
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg6);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg7
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg7);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg8
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg8);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg9
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg9);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg10
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg10);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg11
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg11);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg12
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg12);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg13
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg13);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg14
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg14);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg15
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg15);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg16
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg16);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg17
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg17);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg18
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg18);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg19
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg19);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg20
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg20);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg21
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg21);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg22
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg22);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg23
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg23);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg24
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg24);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg25
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg25);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg26
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg26);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg27
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg27);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg28
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg28);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg29
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg29);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg30
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg30);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg31
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg31] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg31);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg31] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg32
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg32] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg32);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg32] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg33
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg33] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg33);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg33] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg34
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg34] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg34);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg34] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg35
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg35] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg35);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg35] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg36
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg36] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg36);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg36] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg37
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg37] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg37);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg37] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg38
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg38] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg38);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg38] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg39
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg39] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg39);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg39] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg40
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg40] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg40);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg40] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg41
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg41] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg41);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg41] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg42
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg42] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg42);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg42] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg43
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg43] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg43);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg43] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg44
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg44] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg44);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg44] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg45
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg45] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg45);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg45] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg46
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg46] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg46);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg46] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg47
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg47] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg47);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg47] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg48
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg48] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg48);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg48] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg49
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg49] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg49);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg49] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg50
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg50] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg50);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PubDescSeg50] = value;
			}
		}
		
		
		public  String DescFlexField_ContextValue
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_ContextValue] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_ContextValue);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_ContextValue] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg1);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg2
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg2);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg3
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg3);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg4
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg4);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg5
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg5);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg6
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg6);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg7
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg7);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg8
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg8);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg9
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg9);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg10
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg10);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg11
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg11);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg12
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg12);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg13
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg13);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg14
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg14);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg15
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg15);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg16
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg16);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg17
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg17);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg18
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg18);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg19
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg19);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg20
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg20);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg21
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg21);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg22
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg22);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg23
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg23);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg24
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg24);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg25
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg25);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg26
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg26);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg27
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg27);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg28
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg28);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg29
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg29);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg30);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_PrivateDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_CombineName
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_CombineName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_CombineName);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldDescFlexField_CombineName] = value;
			}
		}
		
		
		public  Int64 Org
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldOrg] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCust_Xmjl_DocumentType.FieldOrg);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldOrg] = value;
			}
		}
		
		
		public  String Org_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldOrg_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldOrg_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldOrg_Code] = value;
			}
		}
		
		
		public  String Org_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldOrg_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldOrg_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldOrg_Name] = value;
			}
		}
		
		
		public  Boolean? IsCreatedByPush
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldIsCreatedByPush] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewCust_Xmjl_DocumentType.FieldIsCreatedByPush);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldIsCreatedByPush] = value;
			}
		}
		
		
		public  Boolean? IsDocNoEditable
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldIsDocNoEditable] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewCust_Xmjl_DocumentType.FieldIsDocNoEditable);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldIsDocNoEditable] = value;
			}
		}
		
		
		public  Boolean? IsSaveSubmit
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldIsSaveSubmit] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewCust_Xmjl_DocumentType.FieldIsSaveSubmit);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldIsSaveSubmit] = value;
			}
		}
		
		
		public  Int32 PrintMode
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldPrintMode] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewCust_Xmjl_DocumentType.FieldPrintMode);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldPrintMode] = value;
			}
		}
		
		
		public  String NetPrinterCode
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldNetPrinterCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldNetPrinterCode);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldNetPrinterCode] = value;
			}
		}
		
		
		public  String NetPrinterName
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldNetPrinterName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldNetPrinterName);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldNetPrinterName] = value;
			}
		}
		
		
		public  String MasterSite
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldMasterSite] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_DocumentType.FieldMasterSite);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldMasterSite] = value;
			}
		}
		
		
		public  Int32? ApproveType
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldApproveType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCust_Xmjl_DocumentType.FieldApproveType);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldApproveType] = value;
			}
		}
		
		
		public  Boolean IsApprovingCanModify
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_DocumentType.FieldIsApprovingCanModify] ;
				//return (Boolean)value;
				return GetValue<Boolean>(this.uiviewCust_Xmjl_DocumentType.FieldIsApprovingCanModify);
			}
			set{
				this[this.uiviewCust_Xmjl_DocumentType.FieldIsApprovingCanModify] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class Cust_Xmjl_DocumentTypeDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public Cust_Xmjl_DocumentTypeDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"#Context.OrgID#=UFIDA::U9::Cust::XMJL::DocumentTypeBE::Cust_Xmjl_DocumentType.Org.ID",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private Cust_Xmjl_DocumentTypeDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new Cust_Xmjl_DocumentTypeDefaultFilterFilter();
		}
		#endregion

		#region property
		private IUIParameter @ID;
		#endregion
		
		#region function
		private void InitClass()
		{
			this.@ID = new UIParameter("@ID",System.Data.DbType.Int64);
			this.Parameters.Add(this.@ID);
		}
		#endregion

	}



}