#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.SpecialApplyUI.SpecialApplyUIModel
{
	[Serializable]
	public partial class SpecialApplyUIModelModel : UIModel
	{
		#region Constructor
		public SpecialApplyUIModelModel() : base("SpecialApplyUIModel")
		{
			InitClass();
			this.SetResourceInfo("b65b1c63-3f70-479c-a185-275aa849150c");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private SpecialApplyUIModelModel(bool isInit) : base("SpecialApplyUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new SpecialApplyUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private SpecialApplyBEView viewSpecialApplyBE;			
		private SpecialApplyBE_SpecialSizeBEView viewSpecialApplyBE_SpecialSizeBE;			
		#endregion
		
		#region links
		//private IUILink linkSpecialApplyBE__SpecialApplyBE_SpecialSizeBE;			
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public SpecialApplyBEView SpecialApplyBE
		{
			get { return (SpecialApplyBEView)this["SpecialApplyBE"]; }
		}
		public SpecialApplyBE_SpecialSizeBEView SpecialApplyBE_SpecialSizeBE
		{
			get { return (SpecialApplyBE_SpecialSizeBEView)this["SpecialApplyBE_SpecialSizeBE"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewSpecialApplyBE = new SpecialApplyBEView(this);
			this.viewSpecialApplyBE.SetResourceInfo("003ffa76-12eb-4250-9f17-a402377f7e9d");
			this.Views.Add(this.viewSpecialApplyBE);			
			this.viewSpecialApplyBE_SpecialSizeBE = new SpecialApplyBE_SpecialSizeBEView(this);
			this.viewSpecialApplyBE_SpecialSizeBE.SetResourceInfo("6b12305d-4302-4e1d-baa2-fbcc80eb6542");
			this.Views.Add(this.viewSpecialApplyBE_SpecialSizeBE);			

			//this.linkSpecialApplyBE__SpecialApplyBE_SpecialSizeBE
			{
			IUILink link = new UILink("SpecialApplyBE__SpecialApplyBE_SpecialSizeBE",this,this.viewSpecialApplyBE.FieldID,this.viewSpecialApplyBE_SpecialSizeBE.FieldSpecialApplyBE,EnumAssociationKind.COMPOSITION,EnumAssociationDirection.Double,EnumCardinality.ONE,EnumCardinality.MORE,"SpecialSizeBE");
			this.Links.Add(link);
			}
			//this.linkSpecialApplyBE__SpecialApplyBE_SpecialSizeBE.ChildKeyConstraint.UpdateRule = Rule.None;
			//this.linkSpecialApplyBE__SpecialApplyBE_SpecialSizeBE.ChildKeyConstraint.DeleteRule = Rule.None;
			//this.linkSpecialApplyBE__SpecialApplyBE_SpecialSizeBE.ChildKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
			
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
	public partial class SpecialApplyBEView : UIView
	{
		#region Constructor
		public SpecialApplyBEView(IUIModel model) : base(model,"SpecialApplyBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private SpecialApplyBEView():base(null,"SpecialApplyBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new SpecialApplyBEView();
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
		public IUIField FieldDocNo
		{
			get { return this.Fields["DocNo"]; }
		}
		public IUIField FieldBusinessDate
		{
			get { return this.Fields["BusinessDate"]; }
		}
		public IUIField FieldVersion
		{
			get { return this.Fields["Version"]; }
		}
		public IUIField FieldPrintAmount
		{
			get { return this.Fields["PrintAmount"]; }
		}
		public IUIField FieldLatestPrintedDate
		{
			get { return this.Fields["LatestPrintedDate"]; }
		}
		public IUIField FieldCancel_Canceled
		{
			get { return this.Fields["Cancel_Canceled"]; }
		}
		public IUIField FieldCancel_CancelDate
		{
			get { return this.Fields["Cancel_CancelDate"]; }
		}
		public IUIField FieldCancel_CancelReason
		{
			get { return this.Fields["Cancel_CancelReason"]; }
		}
		public IUIField FieldCancel_CancelUser
		{
			get { return this.Fields["Cancel_CancelUser"]; }
		}
		public IUIField FieldWorkFlowID
		{
			get { return this.Fields["WorkFlowID"]; }
		}
		public IUIField FieldStateMachineID
		{
			get { return this.Fields["StateMachineID"]; }
		}
		public IUIField FieldHoldReason
		{
			get { return this.Fields["HoldReason"]; }
		}
		public IUIField FieldHoldReason_Code
		{
			get { return this.Fields["HoldReason_Code"]; }
		}
		public IUIField FieldHoldReason_Name
		{
			get { return this.Fields["HoldReason_Name"]; }
		}
		public IUIField FieldHoldUser
		{
			get { return this.Fields["HoldUser"]; }
		}
		public IUIField FieldHoldDate
		{
			get { return this.Fields["HoldDate"]; }
		}
		public IUIField FieldReleaseReason
		{
			get { return this.Fields["ReleaseReason"]; }
		}
		public IUIField FieldReleaseReason_Code
		{
			get { return this.Fields["ReleaseReason_Code"]; }
		}
		public IUIField FieldReleaseReason_Name
		{
			get { return this.Fields["ReleaseReason_Name"]; }
		}
		public IUIField FieldReleaseUser
		{
			get { return this.Fields["ReleaseUser"]; }
		}
		public IUIField FieldReleaseDate
		{
			get { return this.Fields["ReleaseDate"]; }
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
		public IUIField FieldFlowInstance
		{
			get { return this.Fields["FlowInstance"]; }
		}
		public IUIField FieldAdvCode
		{
			get { return this.Fields["AdvCode"]; }
		}
		public IUIField FieldApplyDept
		{
			get { return this.Fields["ApplyDept"]; }
		}
		public IUIField FieldApplyDept_Code
		{
			get { return this.Fields["ApplyDept_Code"]; }
		}
		public IUIField FieldApplyDept_Name
		{
			get { return this.Fields["ApplyDept_Name"]; }
		}
		public IUIField FieldApplier
		{
			get { return this.Fields["Applier"]; }
		}
		public IUIField FieldApplyDate
		{
			get { return this.Fields["ApplyDate"]; }
		}
		public IUIField FieldPhone
		{
			get { return this.Fields["Phone"]; }
		}
		public IUIField FieldQQ
		{
			get { return this.Fields["QQ"]; }
		}
		public IUIField FieldCustConterName
		{
			get { return this.Fields["CustConterName"]; }
		}
		public IUIField FieldCustName
		{
			get { return this.Fields["CustName"]; }
		}
		public IUIField FieldCustPhone
		{
			get { return this.Fields["CustPhone"]; }
		}
		public IUIField FieldCustAddress
		{
			get { return this.Fields["CustAddress"]; }
		}
		public IUIField FieldSpecialDesignStyle
		{
			get { return this.Fields["SpecialDesignStyle"]; }
		}
		public IUIField FieldSpecialApplyDocType
		{
			get { return this.Fields["SpecialApplyDocType"]; }
		}
		public IUIField FieldSpecialApplyDocType_Code
		{
			get { return this.Fields["SpecialApplyDocType_Code"]; }
		}
		public IUIField FieldSpecialApplyDocType_Name
		{
			get { return this.Fields["SpecialApplyDocType_Name"]; }
		}
		public IUIField FieldStatus
		{
			get { return this.Fields["Status"]; }
		}
		public IUIField FieldSpecialApplyDocType_ConfirmType
		{
			get { return this.Fields["SpecialApplyDocType_ConfirmType"]; }
		}
		public IUIField FieldSpecialApplyDocType_ApproveType
		{
			get { return this.Fields["SpecialApplyDocType_ApproveType"]; }
		}
		public IUIField FieldIsClose
		{
			get { return this.Fields["IsClose"]; }
		}
		public IUIField FieldLocationQY
		{
			get { return this.Fields["LocationQY"]; }
		}
		public IUIField FieldLocationXZ
		{
			get { return this.Fields["LocationXZ"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public SpecialApplyBEDefaultFilterFilter DefaultFilter
		{
			get { return (SpecialApplyBEDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","43926a76-79a3-442f-a913-fd5057c8611b");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","24e7df97-238a-475c-8a35-25afc0f152b9");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bedf9854-5822-44d4-96e2-f2e6572ff0bb");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","061e2398-dcd0-4e95-b81d-4901bdcc3fc2");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ec4622e2-5995-415c-afa0-45fb2c52d758");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","a7ce340a-93a1-4f6a-96d0-1b34d0f22889");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), false,"","UFIDA.U9.Base.Organization.Organization", "Org", true,true, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","f0cc4331-d080-4a56-a1e5-038e38101fe1");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), false,"","System.String", "Org.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","efa1dd95-b879-4fc1-bed9-63aee5afa952");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "Org.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","34cebfb9-d02e-4171-8ac4-43e41babc263");
			UIModelRuntimeFactory.AddNewUIField(this,"DocNo", typeof(String), false,"","System.String", "DocNo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dea4d40c-eab1-442c-aad7-d09817db16bd");
			UIModelRuntimeFactory.AddNewUIField(this,"BusinessDate", typeof(DateTime), false,"","System.Date", "BusinessDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","e8fc24f8-1bd1-4b14-8dd2-1cdfe5ecc8cc");
			UIModelRuntimeFactory.AddNewUIField(this,"Version", typeof(Int32), true,"0","System.Int32", "Version", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","14751490-5181-4b3b-9ea6-8ba54f0a0ed2");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintAmount", typeof(Int32), true,"0","System.Int32", "PrintAmount", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","a54806f0-15a3-405f-8b98-2895f94fb786");
			UIModelRuntimeFactory.AddNewUIField(this,"LatestPrintedDate", typeof(DateTime), true,"","System.DateTime", "LatestPrintedDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","02551ba6-9e45-4e36-944f-9544e11c4541");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_Canceled", typeof(Boolean), true,"false","System.Boolean", "Cancel.Canceled", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","839f033c-d284-460b-9f5f-9be37f80d0e7");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelDate", typeof(DateTime), true,"","System.DateTime", "Cancel.CancelDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","6425727b-07ec-4d63-9819-eafca63d55a3");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelReason", typeof(String), true,"","System.String", "Cancel.CancelReason", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3876c5d6-b752-406a-9d34-1a7a7dae1c3d");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelUser", typeof(String), true,"","System.String", "Cancel.CancelUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","99d77671-34d4-4b72-bc13-de95c5634970");
			UIModelRuntimeFactory.AddNewUIField(this,"WorkFlowID", typeof(Guid), true,"","System.Guid", "WorkFlowID", true,true, false, "",false,(UIFieldType)1,"2b057235-c58e-441e-9477-5e52fcb7f95b","79bf9cbb-6048-4dc9-869a-d44111995d0f");
			UIModelRuntimeFactory.AddNewUIField(this,"StateMachineID", typeof(Guid), true,"","System.Guid", "StateMachineID", true,true, false, "",false,(UIFieldType)1,"2b057235-c58e-441e-9477-5e52fcb7f95b","209c7e04-7dc9-4fe6-b7f8-d3480a8043a3");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason", typeof(Int64), true,"","UFIDA.U9.Base.HoldRelease.HoldReason", "HoldReason", true,true, false, "",false,(UIFieldType)4,"aca6401c-cd2c-460c-9883-a704f9ea93a6","9a221856-0008-47e3-afa1-6bfc816a1c87");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason_Code", typeof(String), false,"","System.String", "HoldReason.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c8f116de-bb83-49fd-82a8-81b0a8821f1e");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason_Name", typeof(String), true,"","System.String", "HoldReason.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e2133020-21df-4432-ac5e-1621c7520b88");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldUser", typeof(String), true,"","System.String", "HoldUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b6553fe5-d013-47e3-9dff-9156110bcb23");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldDate", typeof(DateTime), true,"","System.DateTime", "HoldDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","b1f81a2f-7572-47f6-b41e-4f4236de20ca");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason", typeof(Int64), true,"","UFIDA.U9.Base.HoldRelease.ReleaseReason", "ReleaseReason", true,true, false, "",false,(UIFieldType)4,"8f4c20a0-ea48-4e30-a76a-1f8d38bcc7cc","efeff814-61f1-47ae-9acc-b71b9c4ba25c");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason_Code", typeof(String), false,"","System.String", "ReleaseReason.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cca25055-bde3-4c45-93a6-0e79ee63cb0f");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason_Name", typeof(String), true,"","System.String", "ReleaseReason.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9620563b-6c9a-42b6-afc4-90aaf983fb53");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseUser", typeof(String), true,"","System.String", "ReleaseUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2b6cb4fc-708d-4e5c-86e4-18aeac010029");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseDate", typeof(DateTime), true,"","System.DateTime", "ReleaseDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","042b1a81-ff23-4602-a41c-6023345fd917");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c008e375-6a4e-4b62-8f08-77a37095731e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","abef95e2-b4fc-49ed-af3d-7f1ba50703a7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a6790745-45d0-4a05-8310-1bcf10625d92");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","80599d1b-933d-4a0a-b343-205217c326f7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","17a6af37-aaf4-4362-882a-a1874e71f213");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0e67f0df-86f7-42fc-becb-034a153a3ec3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8d31e8e5-9339-4384-bc68-6ff564b19fcd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9be6a8a7-e260-4c2d-b8b9-8b7e839fa3f9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e8c1746c-6d95-44f9-8d25-159ef3c3771b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ec1989e6-3fde-419d-8a76-1a476ccc55fd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e52c981c-96f3-451c-97ac-1436987d6c03");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1aafd98f-49a8-48f7-a48b-c44ddef99e7f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c391b71d-5b26-4436-9e0b-20aeef52877f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","76a2c65d-defc-4315-b8f4-f935171c23ef");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","eb306d6d-6108-45a1-87e6-49f5e03bc351");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b90e985b-9a7d-45e0-9e48-f94f5de06980");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6158dc6d-4092-4523-a0aa-42a9b0b9a1a5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ac324492-2db7-4f1c-b07c-5c5bb4602708");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bd0bc38d-4e01-45f8-b9d7-25b0557317f6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","550a0455-bac9-4ae2-ba6d-2577dfcadd38");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ebfccb06-6f59-43fa-a540-a8d1ac51b1f4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ae70987e-474c-4a36-a031-aeeceac968aa");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6cc0734c-2069-4e7d-93fe-f3f4605354a1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ccf648d5-6688-4183-859c-bb44278949d7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","be695ef5-e48b-4d91-ad38-ea5fd5af3def");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7a7f653c-38fa-4811-8fef-6bbdfcedd898");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","47362e57-b7ca-4fbf-ae04-b15a89def002");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","05af0b30-4b92-458c-aea1-19e41bb85028");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","82216451-3c41-42b3-b974-ffdadd9e6089");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","270c166c-5a5a-4c6c-9b51-62a9db784004");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg31", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","64d50ada-1d6d-403a-ae12-1f9de0acb172");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg32", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8b127251-3284-408a-b7dd-83b9bcdf6e3c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg33", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","af0f8762-43e7-47e1-be18-b260884b1997");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg34", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","12fd7161-a6de-4c1a-9da8-14f1343563b4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg35", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6bfd47bb-3b4b-47e7-bf76-02daccf5e35c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg36", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2fed8f39-e9e6-4dae-b8b7-76d639e9efff");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg37", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","18faec11-633b-4a98-b4b7-aef093be6a57");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg38", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1fcd7014-36c7-4142-89d8-1cc56b5adaa8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg39", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","51f8a497-b0fa-4a35-9420-0dd21eed7c2a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg40", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","241e4584-4112-4b18-a12f-406e244a59e5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg41", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","518107c4-b0ff-4562-b2f5-87abfd347784");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg42", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3bb94bb0-f594-471b-9476-1ac28ae555a1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg43", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8bed2dc6-899f-4bae-ac98-d0a22a2982e8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg44", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","43e87747-5e4e-46b6-87d7-208081396b3a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg45", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8c55ad4d-64aa-4560-be1c-696af864bbd9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg46", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","290a65a8-3acd-4589-af60-471c0e524888");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg47", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a8b71f4c-49fb-4115-8c3f-35e3443b0445");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg48", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e7b1e4d9-54b4-4715-845e-d8cd52127a66");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg49", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","21801398-c243-454d-8795-61a2126c6b5a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg50", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e42586ea-f82c-434b-a71c-25be67a38d6a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_ContextValue", typeof(String), true,"","System.String", "DescFlexField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1edc0112-0588-4bd8-8f90-cdffdbd12967");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","88869d6f-fd67-467a-b221-e163e1313002");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6d86f302-21ee-470c-a09a-cc110722efb3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","20c3ae0f-215e-4df3-8055-e59e905a6659");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cce60303-1b93-4b9f-af91-05eff6375bf7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","495edae5-73e2-4b8b-866a-263c46253456");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bcfecc0f-48f9-4550-b573-663888ab64f2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","74bd9f5f-85be-4090-8a84-3da46a49ee9c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c8e013ef-fd7c-4304-917b-14f18a024a4e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3ea604e7-e66a-4310-862d-093b237f1f8f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5ade10d4-84c0-46a3-aa02-dfa260164b6a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ec398cd9-7217-463c-aeb5-cfb38e0ea3e6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","23f8f5c0-08f6-4f20-aa11-e89cf2b57373");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0fc14c26-846e-4b9c-9892-e0b1b4b47abe");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","39c1d65b-b878-4793-82dd-6b293d36552e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1cb211de-a92c-4b32-a7ef-1f74052d39f9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7eef4603-9754-43c5-96b9-bd383d6db28c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e0846571-2c6d-4e29-925d-413b10d24b08");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fdd28a7a-a8df-4f44-83e0-90bee08ac2db");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7d63e9ba-8921-4c10-956f-5f5bddc47bab");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","75d7c445-fbca-401e-b634-d9deab6f1f57");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cdc6b25f-1fde-411c-ad19-b63479f02748");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c5c123c9-34d2-48b2-af6c-8426711fa238");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3b74ba04-3829-4cc2-8993-fc3cd14f120a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7ff021ad-86ae-4bb5-aac8-753357f11e11");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5ea4c0a2-8332-4141-8636-f4a11964d47e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a1500970-e26f-429d-81d7-3a08a98b1bc0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c87b38e7-19e2-4a7c-954b-0f53b6f691bf");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3870bade-a194-44d8-8a5d-cea143cb6d2e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","772ee7ca-a12b-4c7a-a497-a15df0d11fe8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3c6464d8-ade0-4d97-90b5-095f86b8c222");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_CombineName", typeof(String), true,"","System.String", "DescFlexField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f5799fe5-74f3-40c1-9b60-582c36101616");
			UIModelRuntimeFactory.AddNewUIField(this,"FlowInstance", typeof(Int64), true,"","UFIDA.U9.CS.Workflow.WorkflowInstanceBE.FlowInstance", "FlowInstance", true,true, false, "",false,(UIFieldType)4,"d87a7006-6643-42f4-98f4-168847a71955","a0512995-c703-4a0b-8c61-30350f114b88");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvCode", typeof(String), true,"","System.String", "AdvCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","effe8553-8301-4475-bc58-6563f3ba5074");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept", typeof(Int64), false,"","UFIDA.U9.CBO.SCM.Customer.Customer", "ApplyDept", true,true, false, "",false,(UIFieldType)4,"8508f308-9d66-4b1d-abf4-e28dab8e926d","47ba4445-3a49-4325-bb22-6d9535a8b5c1");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept_Code", typeof(String), false,"","System.String", "ApplyDept.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8815311e-4cb7-42b0-b173-9624b926dc44");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept_Name", typeof(String), true,"","System.String", "ApplyDept.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","15598cd1-04e4-453c-84fb-ef79fd6486f7");
			UIModelRuntimeFactory.AddNewUIField(this,"Applier", typeof(String), false,"","System.String", "Applier", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","86805d91-9115-44a7-a690-ffa7807d2966");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDate", typeof(DateTime), true,"","System.Date", "ApplyDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","e2c2c8ab-558d-40b2-8eeb-499d6ae816ec");
			UIModelRuntimeFactory.AddNewUIField(this,"Phone", typeof(String), false,"","System.String", "Phone", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","96253916-1787-4f20-a11e-e5fb4a332ef7");
			UIModelRuntimeFactory.AddNewUIField(this,"QQ", typeof(String), false,"","System.String", "QQ", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dc39c36e-8866-4711-bfc8-a3f655efb523");
			UIModelRuntimeFactory.AddNewUIField(this,"CustConterName", typeof(String), false,"","System.String", "CustConterName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","07451c37-bef9-41b5-9f6a-05e7cb872c70");
			UIModelRuntimeFactory.AddNewUIField(this,"CustName", typeof(String), false,"","System.String", "CustName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0074206b-e493-44b2-bf21-784ac2b62b11");
			UIModelRuntimeFactory.AddNewUIField(this,"CustPhone", typeof(String), false,"","System.String", "CustPhone", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bb269534-1699-4559-99d4-a6a836be05ba");
			UIModelRuntimeFactory.AddNewUIField(this,"CustAddress", typeof(String), false,"","System.String", "CustAddress", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","272d005b-3401-44ca-93b5-3cb4dd4ac8f6");
			UIModelRuntimeFactory.AddNewUIField(this,"SpecialDesignStyle", typeof(Int32), false,"0","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialDesignStyleEnum", "SpecialDesignStyle", true,true, false, "",false,(UIFieldType)2,"a96d15c8-0b6e-48d4-9bd3-ec2d4f4c0db9","04205a3f-bdcf-4e85-bebd-d1cbee8fe60b");
			UIModelRuntimeFactory.AddNewUIField(this,"SpecialApplyDocType", typeof(Int64), false,"","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType", "SpecialApplyDocType", true,true, false, "",false,(UIFieldType)4,"0ab4dca1-e716-4d53-8bb2-0ef1483d9f4a","aa348215-bed5-44e6-a81f-8f5629648e17");
			UIModelRuntimeFactory.AddNewUIField(this,"SpecialApplyDocType_Code", typeof(String), false,"","System.String", "SpecialApplyDocType.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5edf8ab4-af9e-4d6f-979d-7af5daa89495");
			UIModelRuntimeFactory.AddNewUIField(this,"SpecialApplyDocType_Name", typeof(String), true,"","System.String", "SpecialApplyDocType.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f689ed4b-d9c5-45aa-af37-883f67266647");
			UIModelRuntimeFactory.AddNewUIField(this,"Status", typeof(Int32), true,"0","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyStatusEnum", "Status", true,true, false, "",false,(UIFieldType)2,"8afc5e31-561f-4522-9d38-9deb778a04ba","5894fb42-f027-47d9-aa26-3a82c3d91655");
			UIModelRuntimeFactory.AddNewUIField(this,"SpecialApplyDocType_ConfirmType", typeof(Int32), false,"0","UFIDA.U9.Base.Doc.ConfirmTypeEnum", "SpecialApplyDocType.ConfirmType", false,true, false, "",false,(UIFieldType)2,"d232b8fb-1938-4ebe-a90c-41c911c0bc10","3249c7d7-a33c-471a-bd77-c404c4a71faf");
			UIModelRuntimeFactory.AddNewUIField(this,"SpecialApplyDocType_ApproveType", typeof(Int32), true,"-1","UFIDA.U9.Base.Doc.ApproveTypeEnum", "SpecialApplyDocType.ApproveType", false,true, false, "",false,(UIFieldType)2,"d4b6e1a9-d80d-4516-8316-4b1d436cd449","aa7ca7e5-7e7c-4834-a9c9-cdf4ef1f3d74");
			UIModelRuntimeFactory.AddNewUIField(this,"IsClose", typeof(Boolean), true,"false","System.Boolean", "IsClose", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","50af7b5b-4545-407a-a711-b3af60762ec5");
			UIModelRuntimeFactory.AddNewUIField(this,"LocationQY", typeof(String), true,"","System.String", "LocationQY", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5463bdc5-da7b-4fe6-ba6d-aeb8bfcbadee");
			UIModelRuntimeFactory.AddNewUIField(this,"LocationXZ", typeof(String), true,"","System.String", "LocationXZ", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","df5d4c5b-cf93-454c-89db-31325f004683");


			this.CurrentFilter = new SpecialApplyBEDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new SpecialApplyBERecord(builder);
		}
		#endregion

		#region new method
		public new SpecialApplyBERecord FocusedRecord
		{
			get { return (SpecialApplyBERecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new SpecialApplyBERecord AddNewUIRecord()
		{	
			return (SpecialApplyBERecord)base.AddNewUIRecord();
		}
		public new SpecialApplyBERecord NewUIRecord()
		{	
			return (SpecialApplyBERecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class SpecialApplyBERecord : UIRecord
	{
		#region Constructor
		public SpecialApplyBERecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private SpecialApplyBEView uiviewSpecialApplyBE
		{
			get { return (SpecialApplyBEView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new SpecialApplyBERecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewSpecialApplyBE.FieldID);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSpecialApplyBE.FieldCreatedOn);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldCreatedBy);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSpecialApplyBE.FieldModifiedOn);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldModifiedBy);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewSpecialApplyBE.FieldSysVersion);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64 Org
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldOrg] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewSpecialApplyBE.FieldOrg);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldOrg] = value;
			}
		}
		
		
		public  String Org_Code
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldOrg_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldOrg_Code);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldOrg_Code] = value;
			}
		}
		
		
		public  String Org_Name
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldOrg_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldOrg_Name);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldOrg_Name] = value;
			}
		}
		
		
		public  String DocNo
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDocNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDocNo);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDocNo] = value;
			}
		}
		
		
		public  DateTime BusinessDate
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldBusinessDate] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewSpecialApplyBE.FieldBusinessDate);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldBusinessDate] = value;
			}
		}
		
		
		public  Int32? Version
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldVersion] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewSpecialApplyBE.FieldVersion);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldVersion] = value;
			}
		}
		
		
		public  Int32? PrintAmount
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldPrintAmount] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewSpecialApplyBE.FieldPrintAmount);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldPrintAmount] = value;
			}
		}
		
		
		public  DateTime? LatestPrintedDate
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldLatestPrintedDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSpecialApplyBE.FieldLatestPrintedDate);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldLatestPrintedDate] = value;
			}
		}
		
		
		public  Boolean? Cancel_Canceled
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldCancel_Canceled] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewSpecialApplyBE.FieldCancel_Canceled);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldCancel_Canceled] = value;
			}
		}
		
		
		public  DateTime? Cancel_CancelDate
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldCancel_CancelDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSpecialApplyBE.FieldCancel_CancelDate);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldCancel_CancelDate] = value;
			}
		}
		
		
		public  String Cancel_CancelReason
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldCancel_CancelReason] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldCancel_CancelReason);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldCancel_CancelReason] = value;
			}
		}
		
		
		public  String Cancel_CancelUser
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldCancel_CancelUser] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldCancel_CancelUser);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldCancel_CancelUser] = value;
			}
		}
		
		
		public  Guid WorkFlowID
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldWorkFlowID] ;
				//return (Guid)value;
				return GetValue<Guid>(this.uiviewSpecialApplyBE.FieldWorkFlowID);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldWorkFlowID] = value;
			}
		}
		
		
		public  Guid StateMachineID
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldStateMachineID] ;
				//return (Guid)value;
				return GetValue<Guid>(this.uiviewSpecialApplyBE.FieldStateMachineID);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldStateMachineID] = value;
			}
		}
		
		
		public  Int64? HoldReason
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldHoldReason] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewSpecialApplyBE.FieldHoldReason);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldHoldReason] = value;
			}
		}
		
		
		public  String HoldReason_Code
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldHoldReason_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldHoldReason_Code);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldHoldReason_Code] = value;
			}
		}
		
		
		public  String HoldReason_Name
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldHoldReason_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldHoldReason_Name);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldHoldReason_Name] = value;
			}
		}
		
		
		public  String HoldUser
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldHoldUser] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldHoldUser);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldHoldUser] = value;
			}
		}
		
		
		public  DateTime? HoldDate
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldHoldDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSpecialApplyBE.FieldHoldDate);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldHoldDate] = value;
			}
		}
		
		
		public  Int64? ReleaseReason
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldReleaseReason] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewSpecialApplyBE.FieldReleaseReason);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldReleaseReason] = value;
			}
		}
		
		
		public  String ReleaseReason_Code
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldReleaseReason_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldReleaseReason_Code);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldReleaseReason_Code] = value;
			}
		}
		
		
		public  String ReleaseReason_Name
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldReleaseReason_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldReleaseReason_Name);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldReleaseReason_Name] = value;
			}
		}
		
		
		public  String ReleaseUser
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldReleaseUser] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldReleaseUser);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldReleaseUser] = value;
			}
		}
		
		
		public  DateTime? ReleaseDate
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldReleaseDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSpecialApplyBE.FieldReleaseDate);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldReleaseDate] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg1
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg1);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg2
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg2);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg3
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg3);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg4
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg4);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg5
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg5);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg6
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg6);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg7
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg7);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg8
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg8);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg9
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg9);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg10
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg10);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg11
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg11);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg12
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg12);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg13
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg13);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg14
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg14);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg15
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg15);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg16
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg16);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg17
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg17);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg18
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg18);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg19
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg19);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg20
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg20);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg21
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg21);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg22
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg22);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg23
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg23);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg24
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg24);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg25
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg25);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg26
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg26);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg27
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg27);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg28
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg28);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg29
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg29);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg30
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg30);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg31
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg31] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg31);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg31] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg32
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg32] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg32);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg32] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg33
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg33] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg33);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg33] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg34
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg34] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg34);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg34] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg35
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg35] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg35);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg35] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg36
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg36] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg36);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg36] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg37
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg37] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg37);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg37] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg38
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg38] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg38);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg38] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg39
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg39] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg39);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg39] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg40
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg40] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg40);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg40] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg41
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg41] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg41);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg41] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg42
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg42] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg42);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg42] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg43
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg43] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg43);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg43] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg44
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg44] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg44);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg44] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg45
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg45] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg45);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg45] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg46
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg46] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg46);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg46] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg47
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg47] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg47);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg47] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg48
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg48] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg48);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg48] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg49
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg49] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg49);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg49] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg50
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg50] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg50);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg50] = value;
			}
		}
		
		
		public  String DescFlexField_ContextValue
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_ContextValue] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_ContextValue);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_ContextValue] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg1);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg2
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg2);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg3
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg3);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg4
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg4);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg5
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg5);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg6
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg6);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg7
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg7);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg8
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg8);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg9
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg9);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg10
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg10);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg11
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg11);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg12
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg12);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg13
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg13);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg14
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg14);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg15
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg15);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg16
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg16);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg17
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg17);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg18
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg18);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg19
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg19);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg20
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg20);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg21
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg21);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg22
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg22);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg23
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg23);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg24
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg24);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg25
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg25);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg26
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg26);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg27
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg27);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg28
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg28);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg29
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg29);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg30);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_CombineName
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_CombineName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_CombineName);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_CombineName] = value;
			}
		}
		
		
		public  Int64? FlowInstance
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldFlowInstance] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewSpecialApplyBE.FieldFlowInstance);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldFlowInstance] = value;
			}
		}
		
		
		public  String AdvCode
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldAdvCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldAdvCode);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldAdvCode] = value;
			}
		}
		
		
		public  Int64 ApplyDept
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldApplyDept] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewSpecialApplyBE.FieldApplyDept);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldApplyDept] = value;
			}
		}
		
		
		public  String ApplyDept_Code
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldApplyDept_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldApplyDept_Code);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldApplyDept_Code] = value;
			}
		}
		
		
		public  String ApplyDept_Name
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldApplyDept_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldApplyDept_Name);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldApplyDept_Name] = value;
			}
		}
		
		
		public  String Applier
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldApplier] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldApplier);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldApplier] = value;
			}
		}
		
		
		public  DateTime? ApplyDate
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldApplyDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSpecialApplyBE.FieldApplyDate);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldApplyDate] = value;
			}
		}
		
		
		public  String Phone
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldPhone] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldPhone);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldPhone] = value;
			}
		}
		
		
		public  String QQ
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldQQ] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldQQ);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldQQ] = value;
			}
		}
		
		
		public  String CustConterName
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldCustConterName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldCustConterName);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldCustConterName] = value;
			}
		}
		
		
		public  String CustName
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldCustName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldCustName);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldCustName] = value;
			}
		}
		
		
		public  String CustPhone
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldCustPhone] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldCustPhone);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldCustPhone] = value;
			}
		}
		
		
		public  String CustAddress
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldCustAddress] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldCustAddress);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldCustAddress] = value;
			}
		}
		
		
		public  Int32 SpecialDesignStyle
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldSpecialDesignStyle] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewSpecialApplyBE.FieldSpecialDesignStyle);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldSpecialDesignStyle] = value;
			}
		}
		
		
		public  Int64 SpecialApplyDocType
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldSpecialApplyDocType] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewSpecialApplyBE.FieldSpecialApplyDocType);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldSpecialApplyDocType] = value;
			}
		}
		
		
		public  String SpecialApplyDocType_Code
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldSpecialApplyDocType_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldSpecialApplyDocType_Code);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldSpecialApplyDocType_Code] = value;
			}
		}
		
		
		public  String SpecialApplyDocType_Name
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldSpecialApplyDocType_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldSpecialApplyDocType_Name);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldSpecialApplyDocType_Name] = value;
			}
		}
		
		
		public  Int32? Status
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldStatus] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewSpecialApplyBE.FieldStatus);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldStatus] = value;
			}
		}
		
		
		public  Int32 SpecialApplyDocType_ConfirmType
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldSpecialApplyDocType_ConfirmType] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewSpecialApplyBE.FieldSpecialApplyDocType_ConfirmType);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldSpecialApplyDocType_ConfirmType] = value;
			}
		}
		
		
		public  Int32? SpecialApplyDocType_ApproveType
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldSpecialApplyDocType_ApproveType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewSpecialApplyBE.FieldSpecialApplyDocType_ApproveType);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldSpecialApplyDocType_ApproveType] = value;
			}
		}
		
		
		public  Boolean? IsClose
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldIsClose] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewSpecialApplyBE.FieldIsClose);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldIsClose] = value;
			}
		}
		
		
		public  String LocationQY
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldLocationQY] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldLocationQY);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldLocationQY] = value;
			}
		}
		
		
		public  String LocationXZ
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldLocationXZ] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldLocationXZ);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldLocationXZ] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class SpecialApplyBEDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public SpecialApplyBEDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"UFIDA::U9::Cust::SeeBestAdvertisementBE::SpecialApplyBE::SpecialApplyBE.Org.ID=#Context.OrgID#",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private SpecialApplyBEDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new SpecialApplyBEDefaultFilterFilter();
		}
		#endregion

		#region property
		#endregion
		
		#region function
		private void InitClass()
		{
		}
		#endregion

	}



	[Serializable]
	public partial class SpecialApplyBE_SpecialSizeBEView : UIView
	{
		#region Constructor
		public SpecialApplyBE_SpecialSizeBEView(IUIModel model) : base(model,"SpecialApplyBE_SpecialSizeBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBE", false)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private SpecialApplyBE_SpecialSizeBEView():base(null,"SpecialApplyBE_SpecialSizeBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBE", false)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new SpecialApplyBE_SpecialSizeBEView();
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
		public IUIField FieldSpecialApplyBE
		{
			get { return this.Fields["SpecialApplyBE"]; }
		}
		public IUIField FieldDisplayProductType
		{
			get { return this.Fields["DisplayProductType"]; }
		}
		public IUIField FieldDisplayProductType_Code
		{
			get { return this.Fields["DisplayProductType_Code"]; }
		}
		public IUIField FieldDisplayProductType_Name
		{
			get { return this.Fields["DisplayProductType_Name"]; }
		}
		public IUIField FieldWidth
		{
			get { return this.Fields["Width"]; }
		}
		public IUIField FieldHight
		{
			get { return this.Fields["Hight"]; }
		}
		public IUIField FieldThick
		{
			get { return this.Fields["Thick"]; }
		}
		public IUIField FieldQty
		{
			get { return this.Fields["Qty"]; }
		}
		public IUIField FieldArea
		{
			get { return this.Fields["Area"]; }
		}
		public IUIField FieldMemo
		{
			get { return this.Fields["Memo"]; }
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
		public IUIField FieldAdvCarrier
		{
			get { return this.Fields["AdvCarrier"]; }
		}
		public IUIField FieldAdvCarrier_Code
		{
			get { return this.Fields["AdvCarrier_Code"]; }
		}
		public IUIField FieldAdvCarrier_Name
		{
			get { return this.Fields["AdvCarrier_Name"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public SpecialApplyBE_SpecialSizeBEDefaultFilterFilter DefaultFilter
		{
			get { return (SpecialApplyBE_SpecialSizeBEDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","97cd5994-f893-41ca-aece-c7637a8d16d7");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","ab9ced53-e4db-4c2a-80b2-bee1b9290479");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fd7ed919-1060-4db2-8cbe-3625f920a79d");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","8173e4c3-130b-4f39-978f-0bf79ece2954");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a99242c1-a2fc-4dbb-941c-4676a6bc22ac");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","f07ccda6-5b4c-4d02-8310-328b563cbf58");
			UIModelRuntimeFactory.AddNewUIField(this,"SpecialApplyBE", typeof(Int64), true,"","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE", "SpecialApplyBE", true,true, false, "",false,(UIFieldType)4,"363e7e53-0181-4a45-95b9-2980fa1a68cf","923bce92-45da-4593-833f-9d5509a8d938");
			UIModelRuntimeFactory.AddNewUIField(this,"DisplayProductType", typeof(Int64), false,"","UFIDA.U9.Base.FlexField.ValueSet.DefineValue", "DisplayProductType", true,true, false, "",false,(UIFieldType)4,"f52b36dc-e642-4513-a0e6-8bddd4f9e7fc","206a39b2-c85c-4ca0-aa5f-fa2763e25ca4");
			UIModelRuntimeFactory.AddNewUIField(this,"DisplayProductType_Code", typeof(String), false,"","System.String", "DisplayProductType.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","483bb13c-6556-423f-b083-d39d0a1fbd0d");
			UIModelRuntimeFactory.AddNewUIField(this,"DisplayProductType_Name", typeof(String), true,"","System.String", "DisplayProductType.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f6fb85e6-ff76-4cf1-b75c-b9ee1e85e45f");
			UIModelRuntimeFactory.AddNewUIField(this,"Width", typeof(Decimal), true,"0","System.Decimal", "Width", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","6c76eb1d-8586-46b8-b5d7-c0ca46a812c5");
			UIModelRuntimeFactory.AddNewUIField(this,"Hight", typeof(Decimal), true,"0","System.Decimal", "Hight", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","e5c9c41c-38e4-4f92-bccd-4a64256b868b");
			UIModelRuntimeFactory.AddNewUIField(this,"Thick", typeof(Decimal), true,"0","System.Decimal", "Thick", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","24d90726-c97e-49c1-9367-8fab9037e7dd");
			UIModelRuntimeFactory.AddNewUIField(this,"Qty", typeof(Decimal), true,"0","System.Decimal", "Qty", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","5a2668f2-f610-4fc4-9ede-84f8a34fece2");
			UIModelRuntimeFactory.AddNewUIField(this,"Area", typeof(Decimal), true,"0","System.Decimal", "Area", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","e35814aa-875f-45de-9e1b-7fa3f076b0e4");
			UIModelRuntimeFactory.AddNewUIField(this,"Memo", typeof(String), true,"","System.String", "Memo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","65fc421e-9fb2-48e4-a776-61ff59badfc8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f7dc772f-47cd-415e-b4e6-43a8977b90c1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","af83a2b1-55cc-4139-86b5-2163fc4d1e46");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4f6b6e94-5690-4ff5-bb3f-7d4f4f9c5759");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","06951b16-957a-4ef5-afd7-54acfb2d9e1f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3d06ba88-d28a-420f-939f-9bd9a3af3762");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f583c329-d108-4a40-8d1e-d0bbc1fdd023");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8b428cec-c956-4b99-bd36-327fbc698944");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","98755bd4-2414-4274-8076-a665212b1c2f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d02d4f0b-ad28-4ccf-a226-bb1a80c1d20a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","243bf367-658e-4185-a861-ad0d736fbf46");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c3be32db-b3da-425c-ad2a-f7c9abe0b0dc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2ab37564-53ba-49e3-9dee-32ed672e5dda");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8ec5a819-aa7e-470c-941c-f06c7a596075");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","349d5a82-7ea6-4180-9fba-48aa95691672");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","88d157b3-4591-4a90-957c-5f220bd2bf4d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dc85754a-0aed-4f46-85ae-6cec9ea79c1d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d3080501-7ced-436e-a359-13858ddc7f4d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8f495400-0bdf-4c6f-a6f0-9a6ede99c772");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9180402f-07dd-4d41-84ea-170024871561");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","043a79f9-6a4b-4de4-a1bf-776de21ff812");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","16062636-e73f-4e5d-ad47-d0567a9ef107");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a770c675-56d6-4def-b750-3a168075b607");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c657c0cf-e011-4bff-aebe-0c0c2a935ad6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d043afde-750d-4e3c-bc3c-f4c4bdb57c8b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6da21e31-ccad-4627-8117-c28a701d828c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f46e3716-85a7-4db0-93c8-b7a6025ef4e1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0e318e75-1eae-42a2-ab03-6778521c269c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2fd81659-bdf1-4ff0-9f39-4d17dd8a27f9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","73403efe-242d-490b-a4f3-e45883680a99");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","aa3b0bdf-976f-4d36-b2c2-00780b0f9158");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg31", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3acd9708-205a-4981-b6c1-d2a9d832dc3b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg32", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9adcb191-6234-484c-bf42-552544d0c67b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg33", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","40e201b2-c2ba-487f-9e72-0fbaa8a44403");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg34", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d9dbe8c9-292f-4971-bc4a-a9a813ce9788");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg35", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","62d4f4ae-b493-4f91-9f60-6a9fc991d029");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg36", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c20e7700-441f-42d7-b398-0b161dbbf8b3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg37", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8f2d9ea0-22d2-4069-ab95-bc0e18bcbdc2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg38", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ee66cccf-3af9-440e-9496-ad1aa5a2d782");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg39", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3ae940ff-43ac-4800-9b2e-ffdbdce4faf4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg40", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c75cc3a9-b030-4f5f-a35d-19c7e7b999bb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg41", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c8f27781-f1c1-40ac-bf9e-611cb33bab2b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg42", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","732554b2-bb64-494c-b585-7e4b9fbb26c5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg43", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","748cdc8b-7e26-4a80-a6d8-5e8c52a204e1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg44", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f2a74d29-7b9b-4a15-911e-304eb532adc3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg45", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2d0294b9-f1d5-4f3c-9c09-d568dcd5ab1c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg46", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","149714e3-a4e4-403c-97d3-80592d2cf5c0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg47", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c524301a-930f-400f-a32d-2c4e646bf45b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg48", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a5b0e1ab-8b17-4195-9d9a-26f772fc73ab");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg49", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0b8c8834-b660-430b-9f6b-d47908ec15ea");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg50", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d5bcc6a1-fcfe-4fac-93c3-b81e7be7b106");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_ContextValue", typeof(String), true,"","System.String", "DescFlexField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","036c951f-7b05-4070-af57-35b816a7e004");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6254aa1b-4d5f-4704-b3e6-d3de78b24087");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","51430500-5e97-422b-92f5-6bd2dfe16949");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","70908ef4-37d4-411f-a776-bf3f1fa415db");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9e88e663-04e9-4e5b-8414-73968dc771d9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","21cea46e-ca12-4780-b34f-d731eb9f3cb8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ea521506-1b5f-4573-9eb2-09fac42ed1e2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8b27f529-1be4-4e5a-83e2-1bd09281c73c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","182fb0be-cdd1-4856-8829-9af059c9d084");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d97d59b6-90f7-4de7-87b0-ad0d69d7b603");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e321c95e-1a62-4807-8236-e0cc1883e616");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d8619259-54e5-4e52-a776-c07ad3b3327b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","85c99974-8dae-4ebb-9657-eed5e6cb1084");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5e10221b-cd96-48b9-826e-686d72134858");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a641c47a-a6a5-469f-8538-e7d83b3b6287");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3bb44e75-6f07-4c7c-8c90-10fc1f9f708f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","aef1de90-0cda-45f8-9ff2-7e4d588e7817");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","243c9662-3dba-4e49-bddd-0eff8cb081f8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","714e06b5-a2a2-4f4e-be78-27f46a4f23f4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cf9c3790-2ccf-4aef-a44d-c5cc89e9fcf9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","27960fb8-8e0c-4168-a5e1-d1eb7aba62c9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","48495ee2-3181-4ae1-a999-caff6b0d17ca");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","29df99ff-e5fb-44f1-a8df-abdbfa51aa3c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d6ff9d76-105d-4853-a6e9-351e2db2efd8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2593e56e-81df-4444-bb73-4ba8948d8a34");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","54d6f9b8-c74b-49d4-9c25-62581c394985");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a379a3b9-cab1-414b-a7e8-afeaa4c6c839");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6bf99d68-d6ba-4383-9e50-88b8095068f0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e3f2e498-865c-44c7-8d5c-dbbd8b63e157");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fb1a3a8c-36c6-4ae2-b4a7-61048c0adf0e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a69444fa-97f5-46d8-984b-fa5e276598bb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_CombineName", typeof(String), true,"","System.String", "DescFlexField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","03f78fcd-c338-4a25-bb8e-b381ea25daa0");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvCarrier", typeof(Int64), false,"","UFIDA.U9.CBO.SCM.Item.ItemMaster", "AdvCarrier", true,true, false, "",false,(UIFieldType)4,"636d3e47-48aa-47fc-aca4-e6322bce775b","b0e2ead3-2d88-461a-bd0b-c63a0b749efb");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvCarrier_Code", typeof(String), false,"","System.String", "AdvCarrier.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6c7dfacc-7c59-4e42-a817-b2ee862dceb0");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvCarrier_Name", typeof(String), false,"","System.String", "AdvCarrier.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2fde7e09-e4c7-4c7d-8224-155c16f47cbb");


			this.CurrentFilter = new SpecialApplyBE_SpecialSizeBEDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new SpecialApplyBE_SpecialSizeBERecord(builder);
		}
		#endregion

		#region new method
		public new SpecialApplyBE_SpecialSizeBERecord FocusedRecord
		{
			get { return (SpecialApplyBE_SpecialSizeBERecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new SpecialApplyBE_SpecialSizeBERecord AddNewUIRecord()
		{	
			return (SpecialApplyBE_SpecialSizeBERecord)base.AddNewUIRecord();
		}
		public new SpecialApplyBE_SpecialSizeBERecord NewUIRecord()
		{	
			return (SpecialApplyBE_SpecialSizeBERecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class SpecialApplyBE_SpecialSizeBERecord : UIRecord
	{
		#region Constructor
		public SpecialApplyBE_SpecialSizeBERecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private SpecialApplyBE_SpecialSizeBEView uiviewSpecialApplyBE_SpecialSizeBE
		{
			get { return (SpecialApplyBE_SpecialSizeBEView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new SpecialApplyBE_SpecialSizeBERecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldID);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldCreatedOn);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldCreatedBy);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldModifiedOn);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldModifiedBy);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldSysVersion);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? SpecialApplyBE
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldSpecialApplyBE] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldSpecialApplyBE);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldSpecialApplyBE] = value;
			}
		}
		
		
		public  Int64 DisplayProductType
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDisplayProductType] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDisplayProductType);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDisplayProductType] = value;
			}
		}
		
		
		public  String DisplayProductType_Code
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDisplayProductType_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDisplayProductType_Code);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDisplayProductType_Code] = value;
			}
		}
		
		
		public  String DisplayProductType_Name
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDisplayProductType_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDisplayProductType_Name);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDisplayProductType_Name] = value;
			}
		}
		
		
		public  Decimal? Width
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldWidth] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldWidth);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldWidth] = value;
			}
		}
		
		
		public  Decimal? Hight
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldHight] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldHight);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldHight] = value;
			}
		}
		
		
		public  Decimal? Thick
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldThick] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldThick);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldThick] = value;
			}
		}
		
		
		public  Decimal? Qty
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldQty);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldQty] = value;
			}
		}
		
		
		public  Decimal? Area
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldArea] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldArea);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldArea] = value;
			}
		}
		
		
		public  String Memo
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldMemo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldMemo);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldMemo] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg1
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg1);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg2
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg2);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg3
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg3);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg4
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg4);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg5
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg5);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg6
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg6);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg7
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg7);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg8
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg8);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg9
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg9);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg10
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg10);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg11
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg11);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg12
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg12);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg13
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg13);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg14
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg14);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg15
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg15);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg16
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg16);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg17
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg17);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg18
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg18);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg19
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg19);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg20
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg20);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg21
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg21);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg22
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg22);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg23
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg23);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg24
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg24);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg25
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg25);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg26
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg26);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg27
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg27);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg28
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg28);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg29
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg29);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg30
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg30);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg31
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg31] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg31);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg31] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg32
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg32] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg32);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg32] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg33
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg33] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg33);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg33] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg34
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg34] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg34);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg34] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg35
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg35] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg35);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg35] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg36
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg36] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg36);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg36] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg37
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg37] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg37);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg37] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg38
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg38] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg38);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg38] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg39
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg39] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg39);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg39] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg40
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg40] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg40);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg40] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg41
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg41] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg41);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg41] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg42
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg42] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg42);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg42] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg43
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg43] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg43);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg43] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg44
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg44] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg44);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg44] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg45
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg45] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg45);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg45] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg46
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg46] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg46);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg46] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg47
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg47] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg47);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg47] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg48
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg48] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg48);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg48] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg49
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg49] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg49);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg49] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg50
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg50] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg50);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg50] = value;
			}
		}
		
		
		public  String DescFlexField_ContextValue
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_ContextValue] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_ContextValue);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_ContextValue] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg1);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg2
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg2);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg3
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg3);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg4
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg4);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg5
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg5);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg6
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg6);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg7
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg7);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg8
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg8);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg9
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg9);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg10
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg10);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg11
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg11);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg12
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg12);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg13
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg13);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg14
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg14);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg15
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg15);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg16
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg16);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg17
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg17);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg18
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg18);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg19
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg19);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg20
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg20);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg21
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg21);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg22
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg22);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg23
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg23);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg24
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg24);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg25
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg25);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg26
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg26);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg27
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg27);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg28
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg28);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg29
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg29);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg30);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_CombineName
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_CombineName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_CombineName);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_CombineName] = value;
			}
		}
		
		
		public  Int64 AdvCarrier
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldAdvCarrier] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldAdvCarrier);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldAdvCarrier] = value;
			}
		}
		
		
		public  String AdvCarrier_Code
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldAdvCarrier_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldAdvCarrier_Code);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldAdvCarrier_Code] = value;
			}
		}
		
		
		public  String AdvCarrier_Name
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldAdvCarrier_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldAdvCarrier_Name);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldAdvCarrier_Name] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class SpecialApplyBE_SpecialSizeBEDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public SpecialApplyBE_SpecialSizeBEDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private SpecialApplyBE_SpecialSizeBEDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new SpecialApplyBE_SpecialSizeBEDefaultFilterFilter();
		}
		#endregion

		#region property
		#endregion
		
		#region function
		private void InitClass()
		{
		}
		#endregion

	}



}