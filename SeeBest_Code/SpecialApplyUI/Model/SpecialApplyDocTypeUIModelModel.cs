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
			this.viewSpecialApplyDocType.SetResourceInfo("8483f688-8c04-440a-91bf-04588cbe3246");
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


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public SpecialApplyDocTypeDefaultFilterFilter DefaultFilter
		{
			get { return (SpecialApplyDocTypeDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","548bbd34-7d83-4760-b32d-15ff133d5fe7");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","9c6a6578-f13d-4e6f-9b22-2b2d9084932e");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2736d0ed-ab36-408e-9be7-089f433fce29");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","9aa3541e-ec78-4aba-a7ae-5bc1094dbdc7");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dcf3df1c-7efe-4ee5-90b6-5739b4bd9eb0");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","ae67eb43-bd7d-4c06-a786-e077d2fab7f1");
			UIModelRuntimeFactory.AddNewUIField(this,"ConfirmType", typeof(Int32), false,"0","UFIDA.U9.Base.Doc.ConfirmTypeEnum", "ConfirmType", true,true, false, "",false,(UIFieldType)2,"d232b8fb-1938-4ebe-a90c-41c911c0bc10","c02b773a-c8d2-4a45-9e94-dca4901a794c");
			UIModelRuntimeFactory.AddNewUIField(this,"WorkFlowCode", typeof(Guid), true,"","System.Guid", "WorkFlowCode", true,true, false, "",false,(UIFieldType)1,"2b057235-c58e-441e-9477-5e52fcb7f95b","39d91f0d-2098-49b5-95d9-68035b1c0306");
			UIModelRuntimeFactory.AddNewUIField(this,"IsRAMADoc", typeof(Boolean), true,"true","System.Boolean", "IsRAMADoc", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","daa3082d-92ad-49bf-9953-5e377e82a62b");
			UIModelRuntimeFactory.AddNewUIField(this,"IsAMADoc", typeof(Boolean), true,"false","System.Boolean", "IsAMADoc", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","0e874864-130d-48af-ac57-34e27058412a");
			UIModelRuntimeFactory.AddNewUIField(this,"IsRMADoc", typeof(Boolean), true,"false","System.Boolean", "IsRMADoc", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","ebcfceb5-9b78-47cd-a45e-927b6d12fb50");
			UIModelRuntimeFactory.AddNewUIField(this,"DocHeaderSequenceStyle", typeof(Int32), false,"0","UFIDA.U9.Base.Doc.DocHeaderSequenceStyleEnum", "DocHeaderSequenceStyle", true,true, false, "",false,(UIFieldType)2,"dcf65e0a-1554-447b-b4c6-b3ec2951d965","707eadf6-4ec7-481f-9e38-64543e6bce35");
			UIModelRuntimeFactory.AddNewUIField(this,"DocHeaderSequence", typeof(Int64), true,"","UFIDA.U9.Base.Sequence.SequenceDef", "DocHeaderSequence", true,true, false, "",false,(UIFieldType)4,"b2c49db4-e8ac-4ff3-955c-aae5a203ecef","5118ffe7-5ac4-4afd-ac36-f701ca6d185d");
			UIModelRuntimeFactory.AddNewUIField(this,"DocHeaderSequence_Code", typeof(String), false,"","System.String", "DocHeaderSequence.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","85ce48c1-6b4c-4883-b5e4-98c6a206fed0");
			UIModelRuntimeFactory.AddNewUIField(this,"DocHeaderSequence_Name", typeof(String), true,"","System.String", "DocHeaderSequence.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f98d5a51-1388-40dc-9ffc-ff350ef8f140");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintStyle", typeof(Int32), false,"0","UFIDA.U9.Base.Doc.PrintStyleEnum", "PrintStyle", true,true, false, "",false,(UIFieldType)2,"25989155-e5ec-47c2-9347-2d789440602f","c8402616-441a-486d-bc99-484d31a22e80");
			UIModelRuntimeFactory.AddNewUIField(this,"MaxAmountOfPrint", typeof(Int32), false,"0","System.Int32", "MaxAmountOfPrint", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","f7242f50-7981-46cf-872a-15851dd0f655");
			UIModelRuntimeFactory.AddNewUIField(this,"IsCopyPrinted", typeof(Boolean), false,"false","System.Boolean", "IsCopyPrinted", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","a0ccb9e5-c581-41fc-8e8d-7db836609671");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintTemplate", typeof(Int64), true,"","UFSoft.UBF.ExportService.PrintReferenceBE.PrintTemplate", "PrintTemplate", true,true, false, "",false,(UIFieldType)4,"dd17d05e-e2c0-48c5-802a-f1be67ee311e","c642971c-b89c-4445-b388-fbdfce79d390");
			UIModelRuntimeFactory.AddNewUIField(this,"BusinessType", typeof(Int32), true,"-1","UFIDA.U9.Base.Doc.BusinessTypeEnum", "BusinessType", true,true, false, "",false,(UIFieldType)2,"fc998dce-aa68-4d34-8557-a0afdf601afe","7721c94c-0d50-42e7-82d8-cc90f9b89bba");
			UIModelRuntimeFactory.AddNewUIField(this,"Code", typeof(String), false,"","System.String", "Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f7d1a728-9323-4cfb-861b-525cc829eed1");
			UIModelRuntimeFactory.AddNewUIField(this,"Name", typeof(String), true,"","System.String", "Name", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","48251e97-c280-4ca9-8843-b7f13ae2048e");
			UIModelRuntimeFactory.AddNewUIField(this,"ShortName", typeof(String), true,"","System.String", "ShortName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cc554a52-937d-40ef-ba23-2de3bf7c6538");
			UIModelRuntimeFactory.AddNewUIField(this,"Description", typeof(String), true,"","System.String", "Description", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","aaab9d15-734f-463d-aa92-7c2cd2dabcaa");
			UIModelRuntimeFactory.AddNewUIField(this,"Effective_IsEffective", typeof(Boolean), true,"true","System.Boolean", "Effective.IsEffective", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","4963a259-59b7-4632-b9ee-b361f058b463");
			UIModelRuntimeFactory.AddNewUIField(this,"Effective_EffectiveDate", typeof(DateTime), true,"2000-01-01","System.Date", "Effective.EffectiveDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","63d9f8cd-7509-4169-a875-fc4dc26299e9");
			UIModelRuntimeFactory.AddNewUIField(this,"Effective_DisableDate", typeof(DateTime), true,"9999-12-31","System.Date", "Effective.DisableDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","6d42a34b-c494-450d-ae9d-b6d53dfba97f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b894b8a2-5e0c-4465-80d2-2483a39d05d6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8807672c-dbf3-4618-9d0b-e9eb2dbb4029");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","024310f1-a452-4ad1-a7ac-f0ce5e1d02e5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0be1f7b3-d381-4677-bd06-0a5ce52315cd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8e14c471-73d4-428d-9ae3-7016a911635f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3532264a-7887-410c-858c-d9e8e5e5b488");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fc8ccc1c-19a9-4b83-877c-5016623cf69e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2afc85c4-729a-4530-a46a-af17fdf49dda");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","24c6b191-04e0-4b99-9a60-b642ecaf7fca");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","274c12d4-2083-44b5-a294-690fa5ad0f17");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ba2f59e9-fd09-45fe-85d7-5db97ffb74fe");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d41fb607-2720-4fb7-987d-d443a64e3573");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","412b3f28-8c52-41ba-b2f5-0f9cc03d0af3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d9457a51-9bbf-4c1c-a81f-04b63fa4c864");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","48bf46ee-8eca-4a92-ba09-b3858408d998");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","433965bd-c245-4309-8c0b-84497ead389d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","12ee52bb-b638-4597-a9dc-cfc50a7e63e7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8d174e41-b4ea-4922-8a25-78ac89193b9e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2abab14f-ae88-4358-9ea4-ae262883bdf2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","02b894e1-142b-44fa-a03c-86b42da14cb7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4b117481-7177-4c4a-873e-0cb10e80c6c8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","683e1f7c-a231-4c40-b654-19e81a6e6c5f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","34eef997-b072-48f3-a4b6-d5857deafab3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e7ecc80b-9977-41c6-873f-98cd1fd60319");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b53f3a7f-503a-4e7e-81e0-cfc988e76124");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","96774566-46b8-4434-992b-d0e0e95d1cfc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","eaa89ae8-86aa-4722-9c36-4c0394062887");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c7eabcda-b61f-4e18-8398-24cee9fefe14");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3968cf88-be91-47bf-ba8b-6720bfae33fd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","30a633ea-32db-4eb1-860e-537826648cae");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg31", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","18980072-2161-47fb-b340-161ce57bcf5d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg32", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c0ac8dfc-9963-40f2-bfa5-d8dd29a33b1b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg33", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","13bb2338-6cfb-499b-ae8e-bc6c66866734");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg34", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","64ebc0cd-28b6-465f-ae50-1792b54f9610");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg35", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","670c78ae-659e-46ee-99a7-2df8ad9e82e0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg36", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","65ec8b07-1b98-463a-96ba-eed2d2966217");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg37", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","375e769c-8954-4032-8e3d-f8d868278dbd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg38", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cdc9a059-898a-499d-b490-2a218fc7f4d9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg39", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","05138564-91e9-4524-84b9-fb76d8f09ae8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg40", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0b3983aa-8d18-4785-b0af-82c42a31afda");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg41", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","87cfa0ec-9a38-4f5c-9d1d-aad1d98c20b5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg42", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6d568dc8-4737-487b-b443-e662dbf9bca5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg43", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7fe5bcc9-24d4-4d58-bc54-aae2b7621d83");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg44", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7c670dbc-d25a-40ab-898a-cd7d778931bf");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg45", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3e659488-8e51-418c-969a-88467ae7dd5d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg46", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","124572df-4d76-4aa7-b05a-5d293b6ccdb2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg47", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8d8175be-5dff-433f-8abf-933cc3994b75");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg48", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f80e023a-48cc-45a7-ab3c-7042e9c29c1d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg49", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1dd486ad-94c2-4ee5-b67f-1359e0ab81cf");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg50", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b003608b-016a-40c9-b61e-ba6fdbd64162");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_ContextValue", typeof(String), true,"","System.String", "DescFlexField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7c63387d-f829-4115-bc2a-1b466fdcbe3f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6944e502-0a27-4eea-bfe9-873842a3721e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","92419a95-d4a5-484c-a325-b49c1335f2f0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8c96a160-21b8-4470-8589-3bb8a2076c32");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","034a90d7-f891-4bb9-a322-11f3bc393b7e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","19e61f1a-49c2-40d5-8eaf-64d4ff5550dc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3865bc31-a631-4810-a253-a06c5e24d01c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","44aae696-0ddc-4926-992a-33228f82301a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c8f6d77a-2aa7-40e7-b9c0-d75f39c62a9b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7bdc9196-fa8d-4306-8a07-fd5e8f6dbd6c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","387cd20b-1bd9-4ded-8911-412d448e88d9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a5a48d1d-2557-43e1-bd3b-e9089d49de72");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","82f238fe-6377-4d05-836e-9dedbe106ff3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4929b655-c130-4b7c-ba40-acd8860fd4d3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1ab37adc-b7cb-467a-9548-c6a93240cd43");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3e1cdce6-c07e-44b5-81cc-0477271af5f0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bdea9f32-9bfa-4210-aa9b-c6e05e31ce1f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","614fadc7-2194-4b8a-9e8b-303c9808768b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","48d0fc58-10ae-4a21-acff-4ac39a450b25");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b2fd6f3d-5555-469a-ba7e-5c1310bcde2b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","78792a0b-a1d2-488d-afde-3126416eebee");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","afb972ed-51d5-4e0f-b3ef-023737078728");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fb6e16a5-8681-4f67-a46c-03cfa67752a1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6765f0b8-5df1-4ad6-bf94-932ad87c7c60");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5c684a71-9619-4479-b601-4bf8275eec9e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","579da555-20d7-442f-9d50-4e4b0ba13385");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","78f35359-ff66-423b-a294-b975daf1b886");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","060c7638-a929-423b-b486-e28a54a9d015");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","514f1150-840e-4956-b708-50032d359c06");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1a2fc99e-00f5-4265-bf09-9c06a3ebde0b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","16f18190-c4da-4fe2-8576-37645fb43066");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_CombineName", typeof(String), true,"","System.String", "DescFlexField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a015bc53-79cc-4f72-8591-9574c1a87817");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), false,"","UFIDA.U9.Base.Organization.Organization", "Org", true,true, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","f67e9e66-0017-4c0f-920c-8e516a95562f");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), false,"","System.String", "Org.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b2843cc3-f0f8-4a31-95b1-3388eaf1b5cb");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "Org.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6e168394-6543-484b-a14f-a2d4b0a8f432");
			UIModelRuntimeFactory.AddNewUIField(this,"IsCreatedByPush", typeof(Boolean), true,"false","System.Boolean", "IsCreatedByPush", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","e5176d81-a38d-437f-a0d9-04be91d9a3b5");
			UIModelRuntimeFactory.AddNewUIField(this,"IsDocNoEditable", typeof(Boolean), true,"false","System.Boolean", "IsDocNoEditable", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","6a5ff409-1fd3-4704-8ae5-5a1d87765cc7");
			UIModelRuntimeFactory.AddNewUIField(this,"IsSaveSubmit", typeof(Boolean), true,"false","System.Boolean", "IsSaveSubmit", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","4ffc0a92-69f4-4d2a-adae-2fb3c295f401");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintMode", typeof(Int32), false,"0","UFIDA.U9.Base.Doc.PrintModeEnum", "PrintMode", true,true, false, "",false,(UIFieldType)2,"6862b23e-62fb-4453-9eed-4a2fad986a9f","508467c6-6399-4375-a0d4-5436ea4002ae");
			UIModelRuntimeFactory.AddNewUIField(this,"NetPrinterCode", typeof(String), true,"","System.String", "NetPrinterCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9e704345-fd5f-4fd0-b076-a52da19de6b8");
			UIModelRuntimeFactory.AddNewUIField(this,"NetPrinterName", typeof(String), true,"","System.String", "NetPrinterName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1d144df7-849a-4e73-bf50-ff8a173cd8f9");
			UIModelRuntimeFactory.AddNewUIField(this,"MasterSite", typeof(String), true,"","System.String", "MasterSite", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ac6f63ff-5bc2-46de-a28c-c2aa7e52e031");
			UIModelRuntimeFactory.AddNewUIField(this,"ApproveType", typeof(Int32), true,"-1","UFIDA.U9.Base.Doc.ApproveTypeEnum", "ApproveType", true,true, false, "",false,(UIFieldType)2,"d4b6e1a9-d80d-4516-8316-4b1d436cd449","d42b82e1-9e19-4892-bd81-e700c20057d2");
			UIModelRuntimeFactory.AddNewUIField(this,"IsApprovingCanModify", typeof(Boolean), false,"true","System.Boolean", "IsApprovingCanModify", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","4bd0c303-ba0c-4d0b-92a8-515898362c46");


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