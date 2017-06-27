#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.SpecialApplyUI.SpecialApplyDocTypeUIModel
{
	[Serializable]
	public partial class SpecialApplyDocTypeUIModelModel : UIModel
	{
		#region Constructor
		public SpecialApplyDocTypeUIModelModel() : base("SpecialApplyDocTypeUIModel")
		{
			InitClass();
			this.SetResourceInfo("f473c2a0-f23c-4033-9648-86d3f12d9900");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private SpecialApplyDocTypeUIModelModel(bool isInit) : base("SpecialApplyDocTypeUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new SpecialApplyDocTypeUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private SpecialApplyDocTypeView viewSpecialApplyDocType;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public SpecialApplyDocTypeView SpecialApplyDocType
		{
			get { return (SpecialApplyDocTypeView)this["SpecialApplyDocType"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewSpecialApplyDocType = new SpecialApplyDocTypeView(this);
			this.viewSpecialApplyDocType.SetResourceInfo("e79892af-0b93-4f08-88b3-6d30c143b843");
			this.Views.Add(this.viewSpecialApplyDocType);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.SpecialApplyUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class SpecialApplyDocTypeView : UIView
	{
		#region Constructor
		public SpecialApplyDocTypeView(IUIModel model) : base(model,"SpecialApplyDocType","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private SpecialApplyDocTypeView():base(null,"SpecialApplyDocType","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new SpecialApplyDocTypeView();
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
		public IUIField FieldAdvDocEnum
		{
			get { return this.Fields["AdvDocEnum"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public SpecialApplyDocTypeDefaultFilterFilter DefaultFilter
		{
			get { return (SpecialApplyDocTypeDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","e4ab52a9-9a02-4a6a-87a4-07e8399dab83");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","6d5373b1-aa90-4219-b270-96f95109e4bc");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f2e2f467-7020-411f-90bc-11eece9644d1");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","6c2c165c-64c4-40e0-9ab7-b4ed26e792f6");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e8a22641-9c9b-499a-ac64-7559375141e1");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","c37a9fd9-65b7-4a22-9ac0-d54cab9f85bc");
			UIModelRuntimeFactory.AddNewUIField(this,"ConfirmType", typeof(Int32), false,"0","UFIDA.U9.Base.Doc.ConfirmTypeEnum", "ConfirmType", true,true, false, "",false,(UIFieldType)2,"d232b8fb-1938-4ebe-a90c-41c911c0bc10","acb9e620-03eb-4f30-ab1f-245f193b6325");
			UIModelRuntimeFactory.AddNewUIField(this,"WorkFlowCode", typeof(Guid), true,"","System.Guid", "WorkFlowCode", true,true, false, "",false,(UIFieldType)1,"2b057235-c58e-441e-9477-5e52fcb7f95b","7ec89fd3-95ea-494c-8f89-0a5a73c9705b");
			UIModelRuntimeFactory.AddNewUIField(this,"IsRAMADoc", typeof(Boolean), true,"true","System.Boolean", "IsRAMADoc", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","140448ff-70a3-4b1b-ad73-26fabd6772a2");
			UIModelRuntimeFactory.AddNewUIField(this,"IsAMADoc", typeof(Boolean), true,"false","System.Boolean", "IsAMADoc", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","2ab028cb-d04f-475a-9702-65c7e5348829");
			UIModelRuntimeFactory.AddNewUIField(this,"IsRMADoc", typeof(Boolean), true,"false","System.Boolean", "IsRMADoc", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","581fe212-c88b-4307-8583-97058615a47d");
			UIModelRuntimeFactory.AddNewUIField(this,"DocHeaderSequenceStyle", typeof(Int32), false,"0","UFIDA.U9.Base.Doc.DocHeaderSequenceStyleEnum", "DocHeaderSequenceStyle", true,true, false, "",false,(UIFieldType)2,"dcf65e0a-1554-447b-b4c6-b3ec2951d965","9ace455d-d30a-485b-82dd-9a3e266135a3");
			UIModelRuntimeFactory.AddNewUIField(this,"DocHeaderSequence", typeof(Int64), true,"","UFIDA.U9.Base.Sequence.SequenceDef", "DocHeaderSequence", true,true, false, "",false,(UIFieldType)4,"b2c49db4-e8ac-4ff3-955c-aae5a203ecef","f28405fb-07a6-4c53-93e2-60e506f65f61");
			UIModelRuntimeFactory.AddNewUIField(this,"DocHeaderSequence_Code", typeof(String), false,"","System.String", "DocHeaderSequence.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","11c2b0d1-31b5-4678-a93c-d9d57708f13c");
			UIModelRuntimeFactory.AddNewUIField(this,"DocHeaderSequence_Name", typeof(String), true,"","System.String", "DocHeaderSequence.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2aa0c321-6af7-4bea-8c88-224dab6571e0");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintStyle", typeof(Int32), false,"0","UFIDA.U9.Base.Doc.PrintStyleEnum", "PrintStyle", true,true, false, "",false,(UIFieldType)2,"25989155-e5ec-47c2-9347-2d789440602f","c489cc9e-d283-4f2b-bf21-6c2014fe8e73");
			UIModelRuntimeFactory.AddNewUIField(this,"MaxAmountOfPrint", typeof(Int32), false,"0","System.Int32", "MaxAmountOfPrint", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","cff244fe-8ef0-4a30-b317-068f8342bad5");
			UIModelRuntimeFactory.AddNewUIField(this,"IsCopyPrinted", typeof(Boolean), false,"false","System.Boolean", "IsCopyPrinted", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","3df34d42-3871-4cd2-a67d-8d2ca9996d9c");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintTemplate", typeof(Int64), true,"","UFSoft.UBF.ExportService.PrintReferenceBE.PrintTemplate", "PrintTemplate", true,true, false, "",false,(UIFieldType)4,"dd17d05e-e2c0-48c5-802a-f1be67ee311e","bce42b1a-26d2-402d-be3c-c0673910d3ed");
			UIModelRuntimeFactory.AddNewUIField(this,"BusinessType", typeof(Int32), true,"-1","UFIDA.U9.Base.Doc.BusinessTypeEnum", "BusinessType", true,true, false, "",false,(UIFieldType)2,"fc998dce-aa68-4d34-8557-a0afdf601afe","3a5293a2-3fec-481b-905d-ccc6bf1eaecd");
			UIModelRuntimeFactory.AddNewUIField(this,"Code", typeof(String), false,"","System.String", "Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c222ea85-f222-4d6b-8138-633973885eea");
			UIModelRuntimeFactory.AddNewUIField(this,"Name", typeof(String), true,"","System.String", "Name", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3884702f-4ec7-4d16-8f24-76e8f6e219ab");
			UIModelRuntimeFactory.AddNewUIField(this,"ShortName", typeof(String), true,"","System.String", "ShortName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","08549905-d51d-4747-8d1f-b9cd08649ac5");
			UIModelRuntimeFactory.AddNewUIField(this,"Description", typeof(String), true,"","System.String", "Description", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","12557d5f-8990-4f62-9f86-44b91cd759d0");
			UIModelRuntimeFactory.AddNewUIField(this,"Effective_IsEffective", typeof(Boolean), true,"true","System.Boolean", "Effective.IsEffective", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","3fe570d8-9a4e-4c27-bb99-9cf1337bbd39");
			UIModelRuntimeFactory.AddNewUIField(this,"Effective_EffectiveDate", typeof(DateTime), true,"2000-01-01","System.Date", "Effective.EffectiveDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","8289129f-34f4-4973-81a1-26632aafb9d6");
			UIModelRuntimeFactory.AddNewUIField(this,"Effective_DisableDate", typeof(DateTime), true,"9999-12-31","System.Date", "Effective.DisableDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","f9e6dcea-fafa-4950-a5fa-85d1e709cd96");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","897c217a-0c3f-4c4e-b36d-8a3f6dbd87a4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3875ae9b-62b5-4cf5-a233-ec690bee8727");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4ed0ff7c-c874-4f42-808e-da12825a5c16");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f38d785d-6629-447f-96f3-3076e6861bd4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d17d0c9e-bff6-4756-bfd1-f78ce2a42387");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f1b31337-d0fa-4c33-8131-f5b88e065754");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","484a1597-b913-4eba-9eaf-b75d55229a81");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f2a9634a-506d-4d35-9dd4-b6ee5e6bc382");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f412b628-e4d1-4292-97ea-67fd2f1100c8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","870a105c-d01a-4ad8-bb9c-ac0e054831fe");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3495c1ca-11e3-4e6d-83f9-709ebb59fe16");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7ed42ec0-be90-4cfe-a065-88ffd3dbdf52");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","486551e9-15c7-4038-bc39-c7a5d6f66422");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","28f6823c-4a55-47cd-81c0-56e0c69ae409");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9906dd8a-495b-49ec-a1cb-0f42fded8ea5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","deb25734-75a2-40b0-8d79-32b7fa8c008a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4789e581-7874-41a9-9d04-ea1e14803744");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0e340900-1db6-4d50-974c-ee1c24910924");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","aed7d229-92a3-4fc8-87af-6aa31088b20b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5f2aaf95-715a-49cd-b28e-0d116de979b4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9625a4d9-3cf4-45c9-a23d-f1f9b7d2b8b5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1cf21a86-d6e8-473f-a4d6-35d49b61fa4b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2f5b6437-f354-439e-b955-5386af8d3e16");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e8b47e21-8c27-4b41-95ee-a680bdbc7d6f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c40c9aee-65a1-4049-b4e1-6ca5835cd219");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3b8617a7-a175-4f15-b425-8ea14824e1fd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ec95bf2c-3b9f-4eb4-944b-b30c9a4b2503");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c64349c9-ec21-4c20-968a-832effb68e47");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f41f6442-5881-437a-aa50-ae84ee7c4a48");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","61155ffc-6b42-47ee-a3a2-d0da7b942177");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg31", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a4d12c5d-2a3d-481b-854b-fa5af7c9c291");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg32", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3dae79cc-966c-48e2-bc17-d96a4129bf8e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg33", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dfbb3a15-09eb-4847-868f-355617406e35");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg34", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1add5bfe-3013-4c40-98d4-efe673e47e1a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg35", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8574990a-b581-4363-a728-b321eb1daa9f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg36", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","60589ae9-3288-4669-9e83-65d1c0c0d016");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg37", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e0a79fe0-36b1-40ac-bbe3-a0d5424957b4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg38", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","57a38f40-249a-42c2-b037-35277f70be21");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg39", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fc23693e-ca65-4a44-b651-29346a02e4d9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg40", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f2f05bac-6b7e-450a-96f7-552ec27246c6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg41", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3214c07c-ba56-4e2f-a8b8-e2656a8fb601");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg42", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bb5d37dc-33e3-43a8-b490-0e1571bb48f8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg43", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","52d73073-d8c0-426a-957d-325c9dfabbd7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg44", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","05923950-e431-4fcf-b363-324a0662b125");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg45", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3bd107fb-a393-44e9-8d19-087d094dbbf7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg46", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d7ccc3c1-7539-4a02-8202-b003e930c20a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg47", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c7305a8f-80da-480e-8bf0-098cc8c0624a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg48", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ca872f84-ef0c-4359-81b4-4ad79452cc42");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg49", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d52dd732-ed6f-4193-9d5c-0ec63a5cde47");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg50", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4bc779ce-6956-45ef-9981-3d2623e6dd93");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_ContextValue", typeof(String), true,"","System.String", "DescFlexField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ff2302e9-475c-465b-8a03-a491e0fc3b91");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","551207db-56ea-4c13-aaf1-cd990235f097");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ded4a005-f8eb-41b4-830f-1ed1ce78ddf4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","83ca70ae-f4ba-4f48-bd72-dbbcf200fcf7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7ded72a4-fdb3-4db8-8158-efae84243069");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3f139a28-fecb-4acb-aa76-5d29223829d2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3b4b09cd-4a15-4859-bd08-15d5b2e8ee00");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4f75cd09-aaae-4d50-8b20-bf89378cfe2b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","be7b8ff8-7df2-45a7-838c-2dadaab31607");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","abe3681d-8e72-4913-9284-aec7688bad7c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","28e5abae-b80a-4e27-afd4-bd8ea05a480a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c3a298a9-719b-45eb-8b35-0fcfcf9de0b9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8d8e88f0-6aff-472a-8562-b6f2ef31626f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8338e849-63dc-4c5d-a128-788503288ca8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","df14616e-0e34-4c29-a578-faf6cf90d184");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1f47f430-b6de-438f-baeb-c6aacb8a8244");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8f46c14b-8ee9-44a1-b1fe-9fbd2afa38b4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","59fa92a8-c003-4207-83d8-9bde7a882d96");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","31a6757a-517c-48ec-8e32-6144f6f529e1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","24835a49-7a7b-4a6f-bd02-5c968deb4a94");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","072e492d-67bc-4fc4-9149-52ecaa527abe");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8f01283d-cbe1-4f07-a7e6-41458a781c3d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6255dac6-8219-4cda-8b3f-da6b72531200");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0b9b53c3-0309-4190-9254-2da5e8017e99");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cd251bae-062d-428a-9063-a1bf87474d35");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","753ecae3-3b49-4502-bac0-adb38eeb5098");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","964e0b1b-797a-4925-ba2f-679acf0f78e3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9744a46f-a2a5-436b-b2c6-dc4d04287e2d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b287a893-81d4-4cf8-b20c-95be7a5190cf");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","183ba3d9-3d5f-4602-b8af-fb420e8ddc83");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a983df56-ffca-4c56-9a4d-99085b4005d0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_CombineName", typeof(String), true,"","System.String", "DescFlexField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e74a37db-540e-4651-9bc7-d99286e827cb");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), false,"","UFIDA.U9.Base.Organization.Organization", "Org", true,true, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","737a5a26-0935-41fd-b3e4-a12863752a3e");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), false,"","System.String", "Org.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","77f8b5e6-5856-4d40-bb65-dcb699e8ecbe");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "Org.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","facebac3-cfa0-4292-a1cc-6c932253d7ed");
			UIModelRuntimeFactory.AddNewUIField(this,"IsCreatedByPush", typeof(Boolean), true,"false","System.Boolean", "IsCreatedByPush", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","b01707ad-45b6-4e4a-a4b3-9ce25eac3fd8");
			UIModelRuntimeFactory.AddNewUIField(this,"IsDocNoEditable", typeof(Boolean), true,"false","System.Boolean", "IsDocNoEditable", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","a538cd60-7920-4d5e-91ce-f2dd27f1f6f1");
			UIModelRuntimeFactory.AddNewUIField(this,"IsSaveSubmit", typeof(Boolean), true,"false","System.Boolean", "IsSaveSubmit", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","b8ef8aa0-575e-42e7-bc23-96e585f8a99d");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintMode", typeof(Int32), false,"0","UFIDA.U9.Base.Doc.PrintModeEnum", "PrintMode", true,true, false, "",false,(UIFieldType)2,"6862b23e-62fb-4453-9eed-4a2fad986a9f","2a9ec200-4be7-4de4-af55-1bbad09f21e2");
			UIModelRuntimeFactory.AddNewUIField(this,"NetPrinterCode", typeof(String), true,"","System.String", "NetPrinterCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8390c48a-cddd-4842-8786-87b644cc02a7");
			UIModelRuntimeFactory.AddNewUIField(this,"NetPrinterName", typeof(String), true,"","System.String", "NetPrinterName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3f4c3037-6f3b-4788-9d73-6f061c4daf7a");
			UIModelRuntimeFactory.AddNewUIField(this,"MasterSite", typeof(String), true,"","System.String", "MasterSite", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f3a79878-4427-4acf-853b-6ed6a835e8a5");
			UIModelRuntimeFactory.AddNewUIField(this,"ApproveType", typeof(Int32), true,"-1","UFIDA.U9.Base.Doc.ApproveTypeEnum", "ApproveType", true,true, false, "",false,(UIFieldType)2,"d4b6e1a9-d80d-4516-8316-4b1d436cd449","5010d348-7550-4f03-8a2a-3f2554be327a");
			UIModelRuntimeFactory.AddNewUIField(this,"IsApprovingCanModify", typeof(Boolean), false,"true","System.Boolean", "IsApprovingCanModify", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","39bfbf41-ce15-4561-8916-7ef3865e9acc");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvDocEnum", typeof(Int32), true,"0","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.AdvDocEnum", "AdvDocEnum", true,true, false, "",false,(UIFieldType)2,"5b384422-00ff-4599-9ae5-e1d3f50cfcbe","d69b24dd-6cbe-475e-938b-b32009a1e841");


			this.CurrentFilter = new SpecialApplyDocTypeDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new SpecialApplyDocTypeRecord(builder);
		}
		#endregion

		#region new method
		public new SpecialApplyDocTypeRecord FocusedRecord
		{
			get { return (SpecialApplyDocTypeRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new SpecialApplyDocTypeRecord AddNewUIRecord()
		{	
			return (SpecialApplyDocTypeRecord)base.AddNewUIRecord();
		}
		public new SpecialApplyDocTypeRecord NewUIRecord()
		{	
			return (SpecialApplyDocTypeRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class SpecialApplyDocTypeRecord : UIRecord
	{
		#region Constructor
		public SpecialApplyDocTypeRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private SpecialApplyDocTypeView uiviewSpecialApplyDocType
		{
			get { return (SpecialApplyDocTypeView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new SpecialApplyDocTypeRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewSpecialApplyDocType.FieldID);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSpecialApplyDocType.FieldCreatedOn);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldCreatedBy);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSpecialApplyDocType.FieldModifiedOn);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldModifiedBy);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewSpecialApplyDocType.FieldSysVersion);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldSysVersion] = value;
			}
		}
		
		
		public  Int32 ConfirmType
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldConfirmType] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewSpecialApplyDocType.FieldConfirmType);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldConfirmType] = value;
			}
		}
		
		
		public  Guid WorkFlowCode
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldWorkFlowCode] ;
				//return (Guid)value;
				return GetValue<Guid>(this.uiviewSpecialApplyDocType.FieldWorkFlowCode);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldWorkFlowCode] = value;
			}
		}
		
		
		public  Boolean? IsRAMADoc
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldIsRAMADoc] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewSpecialApplyDocType.FieldIsRAMADoc);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldIsRAMADoc] = value;
			}
		}
		
		
		public  Boolean? IsAMADoc
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldIsAMADoc] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewSpecialApplyDocType.FieldIsAMADoc);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldIsAMADoc] = value;
			}
		}
		
		
		public  Boolean? IsRMADoc
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldIsRMADoc] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewSpecialApplyDocType.FieldIsRMADoc);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldIsRMADoc] = value;
			}
		}
		
		
		public  Int32 DocHeaderSequenceStyle
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDocHeaderSequenceStyle] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewSpecialApplyDocType.FieldDocHeaderSequenceStyle);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDocHeaderSequenceStyle] = value;
			}
		}
		
		
		public  Int64? DocHeaderSequence
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDocHeaderSequence] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewSpecialApplyDocType.FieldDocHeaderSequence);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDocHeaderSequence] = value;
			}
		}
		
		
		public  String DocHeaderSequence_Code
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDocHeaderSequence_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDocHeaderSequence_Code);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDocHeaderSequence_Code] = value;
			}
		}
		
		
		public  String DocHeaderSequence_Name
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDocHeaderSequence_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDocHeaderSequence_Name);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDocHeaderSequence_Name] = value;
			}
		}
		
		
		public  Int32 PrintStyle
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldPrintStyle] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewSpecialApplyDocType.FieldPrintStyle);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldPrintStyle] = value;
			}
		}
		
		
		public  Int32 MaxAmountOfPrint
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldMaxAmountOfPrint] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewSpecialApplyDocType.FieldMaxAmountOfPrint);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldMaxAmountOfPrint] = value;
			}
		}
		
		
		public  Boolean IsCopyPrinted
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldIsCopyPrinted] ;
				//return (Boolean)value;
				return GetValue<Boolean>(this.uiviewSpecialApplyDocType.FieldIsCopyPrinted);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldIsCopyPrinted] = value;
			}
		}
		
		
		public  Int64? PrintTemplate
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldPrintTemplate] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewSpecialApplyDocType.FieldPrintTemplate);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldPrintTemplate] = value;
			}
		}
		
		
		public  Int32? BusinessType
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldBusinessType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewSpecialApplyDocType.FieldBusinessType);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldBusinessType] = value;
			}
		}
		
		
		public  String Code
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldCode);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldCode] = value;
			}
		}
		
		
		public new String Name
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldName);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldName] = value;
			}
		}
		
		
		public  String ShortName
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldShortName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldShortName);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldShortName] = value;
			}
		}
		
		
		public  String Description
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescription] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescription);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescription] = value;
			}
		}
		
		
		public  Boolean? Effective_IsEffective
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldEffective_IsEffective] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewSpecialApplyDocType.FieldEffective_IsEffective);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldEffective_IsEffective] = value;
			}
		}
		
		
		public  DateTime? Effective_EffectiveDate
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldEffective_EffectiveDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSpecialApplyDocType.FieldEffective_EffectiveDate);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldEffective_EffectiveDate] = value;
			}
		}
		
		
		public  DateTime? Effective_DisableDate
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldEffective_DisableDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSpecialApplyDocType.FieldEffective_DisableDate);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldEffective_DisableDate] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg1
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg1);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg2
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg2);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg3
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg3);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg4
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg4);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg5
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg5);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg6
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg6);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg7
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg7);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg8
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg8);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg9
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg9);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg10
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg10);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg11
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg11);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg12
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg12);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg13
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg13);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg14
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg14);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg15
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg15);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg16
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg16);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg17
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg17);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg18
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg18);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg19
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg19);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg20
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg20);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg21
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg21);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg22
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg22);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg23
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg23);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg24
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg24);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg25
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg25);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg26
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg26);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg27
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg27);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg28
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg28);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg29
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg29);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg30
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg30);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg31
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg31] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg31);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg31] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg32
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg32] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg32);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg32] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg33
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg33] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg33);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg33] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg34
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg34] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg34);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg34] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg35
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg35] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg35);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg35] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg36
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg36] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg36);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg36] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg37
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg37] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg37);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg37] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg38
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg38] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg38);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg38] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg39
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg39] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg39);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg39] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg40
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg40] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg40);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg40] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg41
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg41] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg41);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg41] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg42
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg42] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg42);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg42] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg43
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg43] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg43);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg43] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg44
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg44] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg44);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg44] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg45
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg45] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg45);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg45] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg46
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg46] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg46);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg46] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg47
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg47] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg47);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg47] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg48
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg48] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg48);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg48] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg49
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg49] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg49);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg49] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg50
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg50] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg50);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PubDescSeg50] = value;
			}
		}
		
		
		public  String DescFlexField_ContextValue
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_ContextValue] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_ContextValue);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_ContextValue] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg1);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg2
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg2);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg3
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg3);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg4
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg4);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg5
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg5);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg6
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg6);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg7
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg7);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg8
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg8);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg9
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg9);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg10
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg10);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg11
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg11);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg12
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg12);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg13
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg13);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg14
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg14);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg15
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg15);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg16
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg16);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg17
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg17);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg18
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg18);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg19
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg19);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg20
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg20);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg21
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg21);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg22
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg22);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg23
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg23);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg24
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg24);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg25
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg25);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg26
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg26);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg27
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg27);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg28
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg28);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg29
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg29);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg30);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_PrivateDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_CombineName
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldDescFlexField_CombineName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldDescFlexField_CombineName);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldDescFlexField_CombineName] = value;
			}
		}
		
		
		public  Int64 Org
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldOrg] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewSpecialApplyDocType.FieldOrg);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldOrg] = value;
			}
		}
		
		
		public  String Org_Code
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldOrg_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldOrg_Code);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldOrg_Code] = value;
			}
		}
		
		
		public  String Org_Name
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldOrg_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldOrg_Name);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldOrg_Name] = value;
			}
		}
		
		
		public  Boolean? IsCreatedByPush
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldIsCreatedByPush] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewSpecialApplyDocType.FieldIsCreatedByPush);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldIsCreatedByPush] = value;
			}
		}
		
		
		public  Boolean? IsDocNoEditable
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldIsDocNoEditable] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewSpecialApplyDocType.FieldIsDocNoEditable);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldIsDocNoEditable] = value;
			}
		}
		
		
		public  Boolean? IsSaveSubmit
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldIsSaveSubmit] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewSpecialApplyDocType.FieldIsSaveSubmit);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldIsSaveSubmit] = value;
			}
		}
		
		
		public  Int32 PrintMode
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldPrintMode] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewSpecialApplyDocType.FieldPrintMode);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldPrintMode] = value;
			}
		}
		
		
		public  String NetPrinterCode
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldNetPrinterCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldNetPrinterCode);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldNetPrinterCode] = value;
			}
		}
		
		
		public  String NetPrinterName
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldNetPrinterName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldNetPrinterName);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldNetPrinterName] = value;
			}
		}
		
		
		public  String MasterSite
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldMasterSite] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyDocType.FieldMasterSite);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldMasterSite] = value;
			}
		}
		
		
		public  Int32? ApproveType
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldApproveType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewSpecialApplyDocType.FieldApproveType);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldApproveType] = value;
			}
		}
		
		
		public  Boolean IsApprovingCanModify
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldIsApprovingCanModify] ;
				//return (Boolean)value;
				return GetValue<Boolean>(this.uiviewSpecialApplyDocType.FieldIsApprovingCanModify);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldIsApprovingCanModify] = value;
			}
		}
		
		
		public  Int32? AdvDocEnum
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldAdvDocEnum] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewSpecialApplyDocType.FieldAdvDocEnum);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldAdvDocEnum] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class SpecialApplyDocTypeDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public SpecialApplyDocTypeDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"UFIDA::U9::Cust::SeeBestAdvertisementBE::SpecialApplyDocTypeBE::SpecialApplyDocType.Org.ID=#Context.OrgID#",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private SpecialApplyDocTypeDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new SpecialApplyDocTypeDefaultFilterFilter();
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