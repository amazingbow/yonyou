#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.AdvApproveUI.AdvApproveUIModel
{
	[Serializable]
	public partial class AdvApproveUIModelModel : UIModel
	{
		#region Constructor
		public AdvApproveUIModelModel() : base("AdvApproveUIModel")
		{
			InitClass();
			this.SetResourceInfo("a199cae1-0e41-473e-a8d2-3d3fc3ec5bc1");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private AdvApproveUIModelModel(bool isInit) : base("AdvApproveUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new AdvApproveUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private AdvApproveBEView viewAdvApproveBE;			
		private AdvApproveBE_AdvApproveLineView viewAdvApproveBE_AdvApproveLine;			
		private AdvApproveLinesView viewAdvApproveLines;			
		#endregion
		
		#region links
		//private IUILink linkAdvApproveBE__AdvApproveBE_AdvApproveLine;			
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public AdvApproveBEView AdvApproveBE
		{
			get { return (AdvApproveBEView)this["AdvApproveBE"]; }
		}
		public AdvApproveBE_AdvApproveLineView AdvApproveBE_AdvApproveLine
		{
			get { return (AdvApproveBE_AdvApproveLineView)this["AdvApproveBE_AdvApproveLine"]; }
		}
		public AdvApproveLinesView AdvApproveLines
		{
			get { return (AdvApproveLinesView)this["AdvApproveLines"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewAdvApproveBE = new AdvApproveBEView(this);
			this.viewAdvApproveBE.SetResourceInfo("0bacab0c-0ef2-4670-87be-868ff356a314");
			this.Views.Add(this.viewAdvApproveBE);			
			this.viewAdvApproveBE_AdvApproveLine = new AdvApproveBE_AdvApproveLineView(this);
			this.viewAdvApproveBE_AdvApproveLine.SetResourceInfo("e9f2f37f-9c28-4be5-950a-5036e6e17e4e");
			this.Views.Add(this.viewAdvApproveBE_AdvApproveLine);			
			this.viewAdvApproveLines = new AdvApproveLinesView(this);
			this.viewAdvApproveLines.SetResourceInfo("8a99f4d2-8dda-42c9-864c-df3802be3743");
			this.Views.Add(this.viewAdvApproveLines);			

			//this.linkAdvApproveBE__AdvApproveBE_AdvApproveLine
			{
			IUILink link = new UILink("AdvApproveBE__AdvApproveBE_AdvApproveLine",this,this.viewAdvApproveBE.FieldID,this.viewAdvApproveBE_AdvApproveLine.FieldAdvApproveBE,EnumAssociationKind.COMPOSITION,EnumAssociationDirection.Double,EnumCardinality.ONE,EnumCardinality.MORE,"AdvApproveLine");
			this.Links.Add(link);
			}
			//this.linkAdvApproveBE__AdvApproveBE_AdvApproveLine.ChildKeyConstraint.UpdateRule = Rule.None;
			//this.linkAdvApproveBE__AdvApproveBE_AdvApproveLine.ChildKeyConstraint.DeleteRule = Rule.None;
			//this.linkAdvApproveBE__AdvApproveBE_AdvApproveLine.ChildKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.AdvApproveUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class AdvApproveBEView : UIView
	{
		#region Constructor
		public AdvApproveBEView(IUIModel model) : base(model,"AdvApproveBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private AdvApproveBEView():base(null,"AdvApproveBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new AdvApproveBEView();
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
		public IUIField FieldAdvApplyCust
		{
			get { return this.Fields["AdvApplyCust"]; }
		}
		public IUIField FieldAdvApplyCust_Code
		{
			get { return this.Fields["AdvApplyCust_Code"]; }
		}
		public IUIField FieldAdvApplyCust_Name
		{
			get { return this.Fields["AdvApplyCust_Name"]; }
		}
		public IUIField FieldMonth
		{
			get { return this.Fields["Month"]; }
		}
		public IUIField FieldAdvApproveDocType
		{
			get { return this.Fields["AdvApproveDocType"]; }
		}
		public IUIField FieldAdvApproveDocType_Code
		{
			get { return this.Fields["AdvApproveDocType_Code"]; }
		}
		public IUIField FieldAdvApproveDocType_Name
		{
			get { return this.Fields["AdvApproveDocType_Name"]; }
		}
		public IUIField FieldWFCurrentState
		{
			get { return this.Fields["WFCurrentState"]; }
		}
		public IUIField FieldWFOriginalState
		{
			get { return this.Fields["WFOriginalState"]; }
		}
		public IUIField FieldDocStatus
		{
			get { return this.Fields["DocStatus"]; }
		}
		public IUIField FieldAdvApproveDocType_ConfirmType
		{
			get { return this.Fields["AdvApproveDocType_ConfirmType"]; }
		}
		public IUIField FieldAdvApproveDocType_ApproveType
		{
			get { return this.Fields["AdvApproveDocType_ApproveType"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public AdvApproveBEDefaultFilterFilter DefaultFilter
		{
			get { return (AdvApproveBEDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","bd58dc7c-7d1f-4435-a621-f51286dd0d29");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","5c0df759-c029-4ca0-ba69-330ee9d5a1c4");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a1b13027-5ce0-4dbd-b62a-fac2ddf37c71");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","1c107e0f-7264-4ca9-ae2f-2f7761a9e900");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","aae78bb4-58e5-4908-9196-bc8a18452c99");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","82ef21d4-8a05-4451-9232-50dca8de07be");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), false,"","UFIDA.U9.Base.Organization.Organization", "Org", true,true, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","5d356ebb-9553-4944-9b08-d36f89ae431a");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), false,"","System.String", "Org.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1a235393-4ae4-44b2-8ed7-8154d65303ef");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "Org.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3135d254-916f-4f0e-974f-6e1b8069557a");
			UIModelRuntimeFactory.AddNewUIField(this,"DocNo", typeof(String), false,"","System.String", "DocNo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9b1075ec-542f-4433-b089-f665a61319d0");
			UIModelRuntimeFactory.AddNewUIField(this,"BusinessDate", typeof(DateTime), false,"","System.Date", "BusinessDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","8d0828e9-0a64-4c9e-a615-92404ef7b884");
			UIModelRuntimeFactory.AddNewUIField(this,"Version", typeof(Int32), true,"0","System.Int32", "Version", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","6d7acae4-f294-4938-b5a1-264b4d84c549");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintAmount", typeof(Int32), true,"0","System.Int32", "PrintAmount", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","b4601fb0-c4cb-412e-b6a0-5acea921e9e4");
			UIModelRuntimeFactory.AddNewUIField(this,"LatestPrintedDate", typeof(DateTime), true,"","System.DateTime", "LatestPrintedDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","4b5c4baf-1c52-483c-872c-842dcb24314e");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_Canceled", typeof(Boolean), true,"false","System.Boolean", "Cancel.Canceled", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","98d23049-3034-4361-8976-4ae6a28b7bef");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelDate", typeof(DateTime), true,"","System.DateTime", "Cancel.CancelDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","608ef7c1-96d5-4645-88b1-b988f4f6ef0d");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelReason", typeof(String), true,"","System.String", "Cancel.CancelReason", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2c024d41-88b0-4898-95c2-2cc65a7f88a2");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelUser", typeof(String), true,"","System.String", "Cancel.CancelUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4fc4223d-a627-4ec9-8c07-c8220d78be7b");
			UIModelRuntimeFactory.AddNewUIField(this,"WorkFlowID", typeof(Guid), true,"","System.Guid", "WorkFlowID", true,true, false, "",false,(UIFieldType)1,"2b057235-c58e-441e-9477-5e52fcb7f95b","5ca8239c-ed60-4fe1-8d7f-fcfd51d4f182");
			UIModelRuntimeFactory.AddNewUIField(this,"StateMachineID", typeof(Guid), true,"","System.Guid", "StateMachineID", true,true, false, "",false,(UIFieldType)1,"2b057235-c58e-441e-9477-5e52fcb7f95b","c915329d-9a63-4798-8eb2-650208fe1793");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason", typeof(Int64), true,"","UFIDA.U9.Base.HoldRelease.HoldReason", "HoldReason", true,true, false, "",false,(UIFieldType)4,"aca6401c-cd2c-460c-9883-a704f9ea93a6","edd954f6-fae4-44bc-985f-b8d1e8628696");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason_Code", typeof(String), false,"","System.String", "HoldReason.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","22e7013f-8969-49c4-b634-8f988ade198e");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason_Name", typeof(String), true,"","System.String", "HoldReason.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6f2e8ef5-8eaa-4ac1-b7be-76df15232ca5");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldUser", typeof(String), true,"","System.String", "HoldUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5e173d38-3a9c-41ac-8bda-2967166bd351");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldDate", typeof(DateTime), true,"","System.DateTime", "HoldDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","15d513d8-8af3-4105-aae5-80caae74014a");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason", typeof(Int64), true,"","UFIDA.U9.Base.HoldRelease.ReleaseReason", "ReleaseReason", true,true, false, "",false,(UIFieldType)4,"8f4c20a0-ea48-4e30-a76a-1f8d38bcc7cc","999452af-f4fc-4753-bc58-ea2a6445f140");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason_Code", typeof(String), false,"","System.String", "ReleaseReason.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","917ac1b1-0837-451c-abac-ccf35d79a760");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason_Name", typeof(String), true,"","System.String", "ReleaseReason.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e3020c3e-6087-4d4d-bb8e-45256d67d0f7");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseUser", typeof(String), true,"","System.String", "ReleaseUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8290e6ac-c278-482b-af4f-b5ea9e31b8aa");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseDate", typeof(DateTime), true,"","System.DateTime", "ReleaseDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","b0d1c38c-d996-4da4-9473-2a59d750a059");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7861c101-0be7-42e2-bc49-4859ee89963c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4d6c8eb8-d455-49d8-85a2-4f272abacd63");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6d076f89-0404-4339-8daa-3f5d6f619275");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","41374c35-4c69-4802-a1e2-7cd98e8aa9b5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c5441c62-4065-4457-92ba-dd434a645e9d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","42d46817-3f40-4ef8-b402-874da0b6044f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4254c3d2-a9b4-454d-a918-e48f6cdb20b2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6ccc9f40-d1ba-44e2-91eb-8e2f5ba40fc8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a823525a-77c3-437d-b71e-2cc1a2554b52");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9528f9c4-2beb-4b1e-8465-b899524f998b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0102a022-a21e-4c2d-b78e-a9810b0299fb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0dda19c7-6093-4ae3-951c-f22ba92647a9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","99dc1600-8389-4358-8123-44d980e71659");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","aa7aa423-e593-43d1-bf03-166fe21f8754");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f543dc52-0f13-4e16-a4b1-3540b742d7eb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4969c99b-136f-459d-a0ac-0ad5f6868bc1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1274dbee-f374-4523-bd1d-f9bfed10b84d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","054c484c-4e0b-4b35-a98c-679f26fb9408");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","431d4f8e-9f84-4410-b647-8488af060c5d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","02ea8b78-02aa-4545-a5ca-a48fdc8086f1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9723e114-6d33-4617-ba84-4b50ffaaa89d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d41a808e-ce58-4f53-a3e7-ad24179e0fce");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5fb4ffd5-a1b0-48c0-ac4b-a099b37df91a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fb6828a7-c7d1-4335-ba34-2aac65f5fc3f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","80c73ece-8cad-41a0-8e91-f4f3a984160a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f586000d-25ef-4249-8c6b-2025bdac3d2a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","da79f7cc-f89f-495f-bb7b-acad785ebeff");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ef360dc9-a33d-494f-a956-ad2ba85ca8c1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","02a0f9b1-d701-4809-a7f5-6132c80032aa");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","de3316f1-e75b-43fa-a411-b8174c11321f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg31", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","07d27c3e-d729-4fb4-8a52-fa24844a71ab");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg32", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bb7d9156-6946-4d63-b9a3-8fe7e0fc2477");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg33", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f6453bb6-33c3-4eee-8f15-a6765c2ef954");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg34", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7672e1f5-bf0a-499a-a994-21d72ea788ef");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg35", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fe710df4-57a7-4ca6-971b-dc18e81de8a8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg36", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e7bf53e1-e71b-4206-88d9-f858a68c0981");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg37", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f10086aa-5506-4642-869a-597d0bfda666");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg38", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2c7f44a9-3b54-4976-bdd2-e2a67cec5c6e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg39", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fac91b82-3875-4ff4-99c6-db1ce0fc1d66");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg40", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9f7d8484-601e-4e29-a819-4b357572d7e9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg41", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e3f1291b-ff30-4d39-95ef-fd3f179eebaf");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg42", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","db4c6141-0d1c-4dd2-ab8f-5430d607aa52");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg43", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e75457c2-a768-4c80-a351-cfdeabeadadb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg44", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","be64365d-62cd-4218-963e-4c22088a271a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg45", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","de32d9fd-c2d1-44cc-9359-19ae9459b326");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg46", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","391ce8d3-0cd7-4ee5-89e8-0a2bef0e0ace");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg47", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8db1ee55-1b25-4036-8ee3-45fe8d17b07f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg48", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0600035e-7562-48f3-84db-e2ce0a4e852d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg49", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d0fc9be8-1773-40ee-ac09-37dda5f73f86");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg50", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","172ca22b-6ce4-40e3-aed7-421fffdfac0d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_ContextValue", typeof(String), true,"","System.String", "DescFlexField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b86c880d-2889-41a7-badc-e6e2167ad300");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c4cf7548-9f9f-4e32-94d8-fd285cb26247");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3eacb510-36c0-4a38-8350-61e751f27c66");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","34de641d-4ff1-4813-8818-024df8141d28");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","83b0731e-6953-4e44-aea6-3505d7a482b8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3c49f14c-8715-412d-96d9-828d61990104");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dc212ce6-6733-4481-b553-d4da18a3f76f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0fb7653e-2185-403f-bab9-0de8aae832d8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f38bf097-b3f2-45b3-9e58-d58565a7f54e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5e35d854-7afe-4a4c-ae14-6898597c2b02");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7d7a13a4-743e-42bb-8798-b747c13b6b04");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","18c7d8b6-29d0-426d-bcf1-125a6b4650b2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","412c3e22-77e9-474d-bcba-9aa2f3f5961b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2abf88a8-de8c-4fdc-88c9-1aea29385b05");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b75614d4-5aae-4792-80a7-4e1fc05f64e1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8aac3df5-887e-44c7-8924-e7fb0cfc52f5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","970624e6-6942-40bd-99fc-7e68df523d2c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2bb02a70-ce1f-4eab-8393-a50525e04a50");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","60ea232b-fd7e-41ba-8341-3926fadf74ac");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","756e6b8b-7464-4231-a19f-93979ddc1706");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","97e3ec60-aa46-47c3-a061-1dae8a6f6fe6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2bfffd3f-d10f-4629-b73e-64189914d6cd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d01c01f0-8439-41bc-93bb-65a46dc7f2c5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","01858cef-f04c-4fcd-b96c-38af25a19605");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","62f57c9d-e8aa-4e4d-bd38-e6ce9f7fc45f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","422ec854-b8e5-45c5-bb19-7d4c5254c239");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","44074cc6-a1b8-4f07-8468-c0c58b3a4536");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","006ce8ed-2ccd-4a09-baa6-712ee5f2cdb8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e98f711f-5332-4627-b86d-54c237b52959");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cf7229db-b8dd-4400-8ab7-39aaefea23b5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7b50ba40-d64d-438e-a659-2227043dbccf");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_CombineName", typeof(String), true,"","System.String", "DescFlexField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3d8e7ef5-234a-43e2-bfa0-5ecaded7ea48");
			UIModelRuntimeFactory.AddNewUIField(this,"FlowInstance", typeof(Int64), true,"","UFIDA.U9.CS.Workflow.WorkflowInstanceBE.FlowInstance", "FlowInstance", true,true, false, "",false,(UIFieldType)4,"d87a7006-6643-42f4-98f4-168847a71955","b892572c-e0b1-452f-bf2c-eadf4368db88");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyCust", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Customer.Customer", "AdvApplyCust", true,true, false, "",false,(UIFieldType)4,"8508f308-9d66-4b1d-abf4-e28dab8e926d","54043f33-6248-4fda-9b0f-be0e8c952b0b");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyCust_Code", typeof(String), false,"","System.String", "AdvApplyCust.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","87458380-ad30-4b0f-bdbd-ec61521d3606");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyCust_Name", typeof(String), true,"","System.String", "AdvApplyCust.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f11c2809-6327-456b-8287-79c0d8cdc83d");
			UIModelRuntimeFactory.AddNewUIField(this,"Month", typeof(DateTime), true,"","System.Date", "Month", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","75e91312-415e-4e70-9688-3281c52722f5");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApproveDocType", typeof(Int64), true,"","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType", "AdvApproveDocType", true,true, false, "",false,(UIFieldType)4,"0ab4dca1-e716-4d53-8bb2-0ef1483d9f4a","752fe996-c5b0-4f32-ad7c-448cd4edde2e");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApproveDocType_Code", typeof(String), false,"","System.String", "AdvApproveDocType.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3cb163a4-b559-4847-a7f3-09770c054044");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApproveDocType_Name", typeof(String), true,"","System.String", "AdvApproveDocType.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","536dc124-3662-4d65-8953-382e2b2abd20");
			UIModelRuntimeFactory.AddNewUIField(this,"WFCurrentState", typeof(Int32), false,"-1","System.Int32", "WFCurrentState", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","74bbd383-c38f-46b3-8d73-75230490a7b4");
			UIModelRuntimeFactory.AddNewUIField(this,"WFOriginalState", typeof(Int32), false,"-1","System.Int32", "WFOriginalState", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","a5cb6f3a-7ce4-40a8-a13b-c867186aff8b");
			UIModelRuntimeFactory.AddNewUIField(this,"DocStatus", typeof(Int32), true,"0","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvAppStatusEnum", "DocStatus", true,true, false, "",false,(UIFieldType)2,"c597484c-846b-48f0-8c05-49caf9820a86","e4e595ff-3cfc-4af7-9acc-31c85fc245fe");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApproveDocType_ConfirmType", typeof(Int32), false,"0","UFIDA.U9.Base.Doc.ConfirmTypeEnum", "AdvApproveDocType.ConfirmType", false,true, false, "",false,(UIFieldType)2,"d232b8fb-1938-4ebe-a90c-41c911c0bc10","547c8d10-2426-4f02-a3a3-3689b8535530");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApproveDocType_ApproveType", typeof(Int32), true,"-1","UFIDA.U9.Base.Doc.ApproveTypeEnum", "AdvApproveDocType.ApproveType", false,true, false, "",false,(UIFieldType)2,"d4b6e1a9-d80d-4516-8316-4b1d436cd449","a86c50ca-11fb-4a2b-8fc7-fd50245883fc");


			this.CurrentFilter = new AdvApproveBEDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new AdvApproveBERecord(builder);
		}
		#endregion

		#region new method
		public new AdvApproveBERecord FocusedRecord
		{
			get { return (AdvApproveBERecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new AdvApproveBERecord AddNewUIRecord()
		{	
			return (AdvApproveBERecord)base.AddNewUIRecord();
		}
		public new AdvApproveBERecord NewUIRecord()
		{	
			return (AdvApproveBERecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class AdvApproveBERecord : UIRecord
	{
		#region Constructor
		public AdvApproveBERecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private AdvApproveBEView uiviewAdvApproveBE
		{
			get { return (AdvApproveBEView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new AdvApproveBERecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAdvApproveBE.FieldID);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApproveBE.FieldCreatedOn);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldCreatedBy);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApproveBE.FieldModifiedOn);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldModifiedBy);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApproveBE.FieldSysVersion);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64 Org
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldOrg] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAdvApproveBE.FieldOrg);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldOrg] = value;
			}
		}
		
		
		public  String Org_Code
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldOrg_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldOrg_Code);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldOrg_Code] = value;
			}
		}
		
		
		public  String Org_Name
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldOrg_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldOrg_Name);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldOrg_Name] = value;
			}
		}
		
		
		public  String DocNo
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDocNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDocNo);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDocNo] = value;
			}
		}
		
		
		public  DateTime BusinessDate
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldBusinessDate] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewAdvApproveBE.FieldBusinessDate);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldBusinessDate] = value;
			}
		}
		
		
		public  Int32? Version
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldVersion] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewAdvApproveBE.FieldVersion);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldVersion] = value;
			}
		}
		
		
		public  Int32? PrintAmount
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldPrintAmount] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewAdvApproveBE.FieldPrintAmount);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldPrintAmount] = value;
			}
		}
		
		
		public  DateTime? LatestPrintedDate
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldLatestPrintedDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApproveBE.FieldLatestPrintedDate);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldLatestPrintedDate] = value;
			}
		}
		
		
		public  Boolean? Cancel_Canceled
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldCancel_Canceled] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewAdvApproveBE.FieldCancel_Canceled);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldCancel_Canceled] = value;
			}
		}
		
		
		public  DateTime? Cancel_CancelDate
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldCancel_CancelDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApproveBE.FieldCancel_CancelDate);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldCancel_CancelDate] = value;
			}
		}
		
		
		public  String Cancel_CancelReason
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldCancel_CancelReason] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldCancel_CancelReason);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldCancel_CancelReason] = value;
			}
		}
		
		
		public  String Cancel_CancelUser
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldCancel_CancelUser] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldCancel_CancelUser);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldCancel_CancelUser] = value;
			}
		}
		
		
		public  Guid WorkFlowID
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldWorkFlowID] ;
				//return (Guid)value;
				return GetValue<Guid>(this.uiviewAdvApproveBE.FieldWorkFlowID);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldWorkFlowID] = value;
			}
		}
		
		
		public  Guid StateMachineID
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldStateMachineID] ;
				//return (Guid)value;
				return GetValue<Guid>(this.uiviewAdvApproveBE.FieldStateMachineID);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldStateMachineID] = value;
			}
		}
		
		
		public  Int64? HoldReason
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldHoldReason] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApproveBE.FieldHoldReason);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldHoldReason] = value;
			}
		}
		
		
		public  String HoldReason_Code
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldHoldReason_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldHoldReason_Code);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldHoldReason_Code] = value;
			}
		}
		
		
		public  String HoldReason_Name
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldHoldReason_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldHoldReason_Name);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldHoldReason_Name] = value;
			}
		}
		
		
		public  String HoldUser
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldHoldUser] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldHoldUser);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldHoldUser] = value;
			}
		}
		
		
		public  DateTime? HoldDate
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldHoldDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApproveBE.FieldHoldDate);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldHoldDate] = value;
			}
		}
		
		
		public  Int64? ReleaseReason
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldReleaseReason] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApproveBE.FieldReleaseReason);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldReleaseReason] = value;
			}
		}
		
		
		public  String ReleaseReason_Code
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldReleaseReason_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldReleaseReason_Code);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldReleaseReason_Code] = value;
			}
		}
		
		
		public  String ReleaseReason_Name
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldReleaseReason_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldReleaseReason_Name);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldReleaseReason_Name] = value;
			}
		}
		
		
		public  String ReleaseUser
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldReleaseUser] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldReleaseUser);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldReleaseUser] = value;
			}
		}
		
		
		public  DateTime? ReleaseDate
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldReleaseDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApproveBE.FieldReleaseDate);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldReleaseDate] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg1
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg1);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg2
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg2);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg3
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg3);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg4
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg4);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg5
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg5);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg6
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg6);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg7
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg7);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg8
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg8);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg9
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg9);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg10
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg10);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg11
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg11);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg12
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg12);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg13
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg13);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg14
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg14);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg15
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg15);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg16
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg16);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg17
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg17);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg18
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg18);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg19
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg19);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg20
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg20);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg21
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg21);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg22
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg22);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg23
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg23);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg24
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg24);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg25
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg25);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg26
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg26);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg27
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg27);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg28
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg28);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg29
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg29);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg30
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg30);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg31
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg31] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg31);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg31] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg32
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg32] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg32);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg32] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg33
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg33] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg33);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg33] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg34
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg34] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg34);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg34] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg35
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg35] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg35);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg35] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg36
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg36] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg36);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg36] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg37
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg37] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg37);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg37] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg38
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg38] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg38);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg38] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg39
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg39] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg39);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg39] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg40
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg40] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg40);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg40] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg41
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg41] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg41);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg41] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg42
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg42] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg42);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg42] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg43
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg43] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg43);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg43] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg44
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg44] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg44);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg44] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg45
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg45] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg45);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg45] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg46
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg46] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg46);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg46] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg47
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg47] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg47);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg47] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg48
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg48] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg48);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg48] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg49
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg49] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg49);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg49] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg50
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg50] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg50);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PubDescSeg50] = value;
			}
		}
		
		
		public  String DescFlexField_ContextValue
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_ContextValue] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_ContextValue);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_ContextValue] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg1);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg2
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg2);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg3
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg3);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg4
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg4);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg5
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg5);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg6
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg6);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg7
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg7);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg8
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg8);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg9
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg9);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg10
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg10);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg11
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg11);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg12
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg12);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg13
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg13);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg14
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg14);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg15
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg15);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg16
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg16);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg17
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg17);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg18
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg18);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg19
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg19);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg20
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg20);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg21
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg21);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg22
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg22);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg23
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg23);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg24
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg24);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg25
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg25);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg26
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg26);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg27
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg27);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg28
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg28);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg29
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg29);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg30);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_PrivateDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_CombineName
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDescFlexField_CombineName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldDescFlexField_CombineName);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDescFlexField_CombineName] = value;
			}
		}
		
		
		public  Int64? FlowInstance
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldFlowInstance] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApproveBE.FieldFlowInstance);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldFlowInstance] = value;
			}
		}
		
		
		public  Int64? AdvApplyCust
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldAdvApplyCust] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApproveBE.FieldAdvApplyCust);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldAdvApplyCust] = value;
			}
		}
		
		
		public  String AdvApplyCust_Code
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldAdvApplyCust_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldAdvApplyCust_Code);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldAdvApplyCust_Code] = value;
			}
		}
		
		
		public  String AdvApplyCust_Name
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldAdvApplyCust_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldAdvApplyCust_Name);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldAdvApplyCust_Name] = value;
			}
		}
		
		
		public  DateTime? Month
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldMonth] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApproveBE.FieldMonth);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldMonth] = value;
			}
		}
		
		
		public  Int64? AdvApproveDocType
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldAdvApproveDocType] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApproveBE.FieldAdvApproveDocType);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldAdvApproveDocType] = value;
			}
		}
		
		
		public  String AdvApproveDocType_Code
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldAdvApproveDocType_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldAdvApproveDocType_Code);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldAdvApproveDocType_Code] = value;
			}
		}
		
		
		public  String AdvApproveDocType_Name
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldAdvApproveDocType_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE.FieldAdvApproveDocType_Name);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldAdvApproveDocType_Name] = value;
			}
		}
		
		
		public  Int32 WFCurrentState
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldWFCurrentState] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewAdvApproveBE.FieldWFCurrentState);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldWFCurrentState] = value;
			}
		}
		
		
		public  Int32 WFOriginalState
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldWFOriginalState] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewAdvApproveBE.FieldWFOriginalState);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldWFOriginalState] = value;
			}
		}
		
		
		public  Int32? DocStatus
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldDocStatus] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewAdvApproveBE.FieldDocStatus);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldDocStatus] = value;
			}
		}
		
		
		public  Int32 AdvApproveDocType_ConfirmType
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldAdvApproveDocType_ConfirmType] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewAdvApproveBE.FieldAdvApproveDocType_ConfirmType);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldAdvApproveDocType_ConfirmType] = value;
			}
		}
		
		
		public  Int32? AdvApproveDocType_ApproveType
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldAdvApproveDocType_ApproveType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewAdvApproveBE.FieldAdvApproveDocType_ApproveType);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldAdvApproveDocType_ApproveType] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class AdvApproveBEDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public AdvApproveBEDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private AdvApproveBEDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new AdvApproveBEDefaultFilterFilter();
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
	public partial class AdvApproveBE_AdvApproveLineView : UIView
	{
		#region Constructor
		public AdvApproveBE_AdvApproveLineView(IUIModel model) : base(model,"AdvApproveBE_AdvApproveLine","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveLine", false)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private AdvApproveBE_AdvApproveLineView():base(null,"AdvApproveBE_AdvApproveLine","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveLine", false)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new AdvApproveBE_AdvApproveLineView();
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
		public IUIField FieldAdvApproveBE
		{
			get { return this.Fields["AdvApproveBE"]; }
		}
		public IUIField FieldLocation
		{
			get { return this.Fields["Location"]; }
		}
		public IUIField FieldAdvAppCustName
		{
			get { return this.Fields["AdvAppCustName"]; }
		}
		public IUIField FieldCountry
		{
			get { return this.Fields["Country"]; }
		}
		public IUIField FieldCustCounterName
		{
			get { return this.Fields["CustCounterName"]; }
		}
		public IUIField FieldRelPeople
		{
			get { return this.Fields["RelPeople"]; }
		}
		public IUIField FieldRelPhone
		{
			get { return this.Fields["RelPhone"]; }
		}
		public IUIField FieldCustAddress
		{
			get { return this.Fields["CustAddress"]; }
		}
		public IUIField FieldWidth
		{
			get { return this.Fields["Width"]; }
		}
		public IUIField FieldThick
		{
			get { return this.Fields["Thick"]; }
		}
		public IUIField FieldHeight
		{
			get { return this.Fields["Height"]; }
		}
		public IUIField FieldArea
		{
			get { return this.Fields["Area"]; }
		}
		public IUIField FieldApplyAdvCode
		{
			get { return this.Fields["ApplyAdvCode"]; }
		}
		public IUIField FieldAdvCarrier
		{
			get { return this.Fields["AdvCarrier"]; }
		}
		public IUIField FieldApplyQty
		{
			get { return this.Fields["ApplyQty"]; }
		}
		public IUIField FieldPrice
		{
			get { return this.Fields["Price"]; }
		}
		public IUIField FieldTotalMoney
		{
			get { return this.Fields["TotalMoney"]; }
		}
		public IUIField FieldReceiptNum
		{
			get { return this.Fields["ReceiptNum"]; }
		}
		public IUIField FieldMomo
		{
			get { return this.Fields["Momo"]; }
		}
		public IUIField FieldActualApproveQty
		{
			get { return this.Fields["ActualApproveQty"]; }
		}
		public IUIField FieldActualPrice
		{
			get { return this.Fields["ActualPrice"]; }
		}
		public IUIField FieldDiscount
		{
			get { return this.Fields["Discount"]; }
		}
		public IUIField FieldApproveMoney
		{
			get { return this.Fields["ApproveMoney"]; }
		}
		public IUIField FieldAdvItem
		{
			get { return this.Fields["AdvItem"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public AdvApproveBE_AdvApproveLineDefaultFilterFilter DefaultFilter
		{
			get { return (AdvApproveBE_AdvApproveLineDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","cd4f706b-cf8a-4f08-91e7-040297e1d4d8");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","d3bbf6e4-29d9-485e-a958-b4d774c19853");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","475be6cc-d080-4abf-b77a-aa768ab6ce53");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","c933d4e5-3192-4382-b2e8-63e58730de31");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3cea3780-133d-4d7c-a1cd-78c365a99f4e");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","326949eb-5fde-471b-b198-06b6b9a0272e");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApproveBE", typeof(Int64), true,"","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE", "AdvApproveBE", true,true, false, "",false,(UIFieldType)4,"f1d91c11-fb12-49af-b6a4-c52297a1fd77","f7fb3fa7-c525-4d9f-8565-a2eb82eff849");
			UIModelRuntimeFactory.AddNewUIField(this,"Location", typeof(String), true,"","System.String", "Location", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d0270885-cd3c-43f8-a3c1-12542e5bf66a");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvAppCustName", typeof(String), true,"","System.String", "AdvAppCustName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","983c42d1-3efe-457b-b921-22e7d7bf0fcb");
			UIModelRuntimeFactory.AddNewUIField(this,"Country", typeof(String), true,"","System.String", "Country", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8c0e33ca-10bc-4d6f-adaf-8dbc4037f3f1");
			UIModelRuntimeFactory.AddNewUIField(this,"CustCounterName", typeof(String), true,"","System.String", "CustCounterName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","56beb045-b2fa-4356-9c6d-6b78c80318b6");
			UIModelRuntimeFactory.AddNewUIField(this,"RelPeople", typeof(String), true,"","System.String", "RelPeople", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1a3e001b-e629-4f73-88b9-1a3eb58aaf4f");
			UIModelRuntimeFactory.AddNewUIField(this,"RelPhone", typeof(String), true,"","System.String", "RelPhone", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","45baf65d-d4c2-4a87-9877-cee830c95473");
			UIModelRuntimeFactory.AddNewUIField(this,"CustAddress", typeof(String), true,"","System.String", "CustAddress", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a45f2c53-bd89-427c-9702-43db83290d1f");
			UIModelRuntimeFactory.AddNewUIField(this,"Width", typeof(Decimal), true,"0","System.Decimal", "Width", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","87ba5af0-8208-4aa7-b2cd-71b1bd7857aa");
			UIModelRuntimeFactory.AddNewUIField(this,"Thick", typeof(Decimal), true,"0","System.Decimal", "Thick", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","b62ba3cd-9cb8-4f3e-8d49-6b5807b6c655");
			UIModelRuntimeFactory.AddNewUIField(this,"Height", typeof(Decimal), true,"0","System.Decimal", "Height", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","555af42c-6726-45e4-b51c-e051f66f3cd9");
			UIModelRuntimeFactory.AddNewUIField(this,"Area", typeof(Decimal), true,"0","System.Decimal", "Area", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","448b2763-2815-4bfd-9790-67152e6ea0b4");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyAdvCode", typeof(String), true,"","System.String", "ApplyAdvCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","49c26963-1dc0-4523-ae55-00c31dd23c1d");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvCarrier", typeof(String), true,"","System.String", "AdvCarrier", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","43420188-bde0-46d6-8af5-09ccb88795e5");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyQty", typeof(Decimal), true,"0","System.Decimal", "ApplyQty", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","60f8ef23-90e6-489a-a012-86505d20e16f");
			UIModelRuntimeFactory.AddNewUIField(this,"Price", typeof(Decimal), true,"0","System.Decimal", "Price", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","a3a6757c-8e63-4689-a019-90203792dd83");
			UIModelRuntimeFactory.AddNewUIField(this,"TotalMoney", typeof(Decimal), true,"0","System.Decimal", "TotalMoney", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","807437d0-7571-4016-a9a2-05e9c8287f59");
			UIModelRuntimeFactory.AddNewUIField(this,"ReceiptNum", typeof(String), true,"","System.String", "ReceiptNum", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","26fbeeef-ad95-4126-b4c6-f3258015ae96");
			UIModelRuntimeFactory.AddNewUIField(this,"Momo", typeof(String), true,"","System.String", "Momo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f7e69934-31db-447b-93a7-36a6c8373909");
			UIModelRuntimeFactory.AddNewUIField(this,"ActualApproveQty", typeof(Decimal), true,"0","System.Decimal", "ActualApproveQty", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","b5a1ea31-b248-4d16-adf9-079b1476c6a7");
			UIModelRuntimeFactory.AddNewUIField(this,"ActualPrice", typeof(Decimal), true,"0","System.Decimal", "ActualPrice", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","ca824933-4ae0-43af-ba86-d60dddeaa4d0");
			UIModelRuntimeFactory.AddNewUIField(this,"Discount", typeof(Decimal), true,"0","System.Decimal", "Discount", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","d57cac96-8aec-496c-9db9-a194b96c778a");
			UIModelRuntimeFactory.AddNewUIField(this,"ApproveMoney", typeof(Decimal), true,"0","System.Decimal", "ApproveMoney", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","b46a26a9-0c4c-4a2f-ad3b-5d3bdf261601");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvItem", typeof(String), true,"","System.String", "AdvItem", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","195843a5-0a6a-4207-9749-749470b7ae99");


			this.CurrentFilter = new AdvApproveBE_AdvApproveLineDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new AdvApproveBE_AdvApproveLineRecord(builder);
		}
		#endregion

		#region new method
		public new AdvApproveBE_AdvApproveLineRecord FocusedRecord
		{
			get { return (AdvApproveBE_AdvApproveLineRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new AdvApproveBE_AdvApproveLineRecord AddNewUIRecord()
		{	
			return (AdvApproveBE_AdvApproveLineRecord)base.AddNewUIRecord();
		}
		public new AdvApproveBE_AdvApproveLineRecord NewUIRecord()
		{	
			return (AdvApproveBE_AdvApproveLineRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class AdvApproveBE_AdvApproveLineRecord : UIRecord
	{
		#region Constructor
		public AdvApproveBE_AdvApproveLineRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private AdvApproveBE_AdvApproveLineView uiviewAdvApproveBE_AdvApproveLine
		{
			get { return (AdvApproveBE_AdvApproveLineView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new AdvApproveBE_AdvApproveLineRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAdvApproveBE_AdvApproveLine.FieldID);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApproveBE_AdvApproveLine.FieldCreatedOn);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE_AdvApproveLine.FieldCreatedBy);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApproveBE_AdvApproveLine.FieldModifiedOn);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE_AdvApproveLine.FieldModifiedBy);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApproveBE_AdvApproveLine.FieldSysVersion);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? AdvApproveBE
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldAdvApproveBE] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApproveBE_AdvApproveLine.FieldAdvApproveBE);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldAdvApproveBE] = value;
			}
		}
		
		
		public  String Location
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldLocation] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE_AdvApproveLine.FieldLocation);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldLocation] = value;
			}
		}
		
		
		public  String AdvAppCustName
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldAdvAppCustName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE_AdvApproveLine.FieldAdvAppCustName);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldAdvAppCustName] = value;
			}
		}
		
		
		public  String Country
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldCountry] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE_AdvApproveLine.FieldCountry);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldCountry] = value;
			}
		}
		
		
		public  String CustCounterName
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldCustCounterName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE_AdvApproveLine.FieldCustCounterName);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldCustCounterName] = value;
			}
		}
		
		
		public  String RelPeople
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldRelPeople] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE_AdvApproveLine.FieldRelPeople);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldRelPeople] = value;
			}
		}
		
		
		public  String RelPhone
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldRelPhone] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE_AdvApproveLine.FieldRelPhone);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldRelPhone] = value;
			}
		}
		
		
		public  String CustAddress
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldCustAddress] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE_AdvApproveLine.FieldCustAddress);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldCustAddress] = value;
			}
		}
		
		
		public  Decimal? Width
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldWidth] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApproveBE_AdvApproveLine.FieldWidth);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldWidth] = value;
			}
		}
		
		
		public  Decimal? Thick
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldThick] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApproveBE_AdvApproveLine.FieldThick);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldThick] = value;
			}
		}
		
		
		public  Decimal? Height
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldHeight] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApproveBE_AdvApproveLine.FieldHeight);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldHeight] = value;
			}
		}
		
		
		public  Decimal? Area
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldArea] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApproveBE_AdvApproveLine.FieldArea);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldArea] = value;
			}
		}
		
		
		public  String ApplyAdvCode
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldApplyAdvCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE_AdvApproveLine.FieldApplyAdvCode);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldApplyAdvCode] = value;
			}
		}
		
		
		public  String AdvCarrier
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldAdvCarrier] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE_AdvApproveLine.FieldAdvCarrier);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldAdvCarrier] = value;
			}
		}
		
		
		public  Decimal? ApplyQty
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldApplyQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApproveBE_AdvApproveLine.FieldApplyQty);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldApplyQty] = value;
			}
		}
		
		
		public  Decimal? Price
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldPrice] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApproveBE_AdvApproveLine.FieldPrice);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldPrice] = value;
			}
		}
		
		
		public  Decimal? TotalMoney
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldTotalMoney] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApproveBE_AdvApproveLine.FieldTotalMoney);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldTotalMoney] = value;
			}
		}
		
		
		public  String ReceiptNum
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldReceiptNum] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE_AdvApproveLine.FieldReceiptNum);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldReceiptNum] = value;
			}
		}
		
		
		public  String Momo
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldMomo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE_AdvApproveLine.FieldMomo);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldMomo] = value;
			}
		}
		
		
		public  Decimal? ActualApproveQty
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldActualApproveQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApproveBE_AdvApproveLine.FieldActualApproveQty);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldActualApproveQty] = value;
			}
		}
		
		
		public  Decimal? ActualPrice
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldActualPrice] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApproveBE_AdvApproveLine.FieldActualPrice);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldActualPrice] = value;
			}
		}
		
		
		public  Decimal? Discount
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldDiscount] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApproveBE_AdvApproveLine.FieldDiscount);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldDiscount] = value;
			}
		}
		
		
		public  Decimal? ApproveMoney
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldApproveMoney] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApproveBE_AdvApproveLine.FieldApproveMoney);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldApproveMoney] = value;
			}
		}
		
		
		public  String AdvItem
		{
			get{
				//object value = this[this.uiviewAdvApproveBE_AdvApproveLine.FieldAdvItem] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveBE_AdvApproveLine.FieldAdvItem);
			}
			set{
				this[this.uiviewAdvApproveBE_AdvApproveLine.FieldAdvItem] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class AdvApproveBE_AdvApproveLineDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public AdvApproveBE_AdvApproveLineDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private AdvApproveBE_AdvApproveLineDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new AdvApproveBE_AdvApproveLineDefaultFilterFilter();
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
	public partial class AdvApproveLinesView : UIView
	{
		#region Constructor
		public AdvApproveLinesView(IUIModel model) : base(model,"AdvApproveLines","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private AdvApproveLinesView():base(null,"AdvApproveLines","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new AdvApproveLinesView();
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


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public AdvApproveLinesDefaultFilterFilter DefaultFilter
		{
			get { return (AdvApproveLinesDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","c6d6389d-d036-4075-b378-e9a1d4226777");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","0bc2e1c3-5c22-4c5e-85f3-1bed796b841f");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7dc6f92e-079b-4e78-a296-e86e83427d3b");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","3a2d6153-9666-4423-acfc-6b4262fbbc1c");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9cf5266e-383e-44df-a0de-e1728f19bd2a");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","07168452-4a2f-4b4f-9203-5ff8627998de");


			this.CurrentFilter = new AdvApproveLinesDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new AdvApproveLinesRecord(builder);
		}
		#endregion

		#region new method
		public new AdvApproveLinesRecord FocusedRecord
		{
			get { return (AdvApproveLinesRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new AdvApproveLinesRecord AddNewUIRecord()
		{	
			return (AdvApproveLinesRecord)base.AddNewUIRecord();
		}
		public new AdvApproveLinesRecord NewUIRecord()
		{	
			return (AdvApproveLinesRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class AdvApproveLinesRecord : UIRecord
	{
		#region Constructor
		public AdvApproveLinesRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private AdvApproveLinesView uiviewAdvApproveLines
		{
			get { return (AdvApproveLinesView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new AdvApproveLinesRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewAdvApproveLines.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAdvApproveLines.FieldID);
			}
			set{
				this[this.uiviewAdvApproveLines.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewAdvApproveLines.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewAdvApproveLines.FieldCreatedOn);
			}
			set{
				this[this.uiviewAdvApproveLines.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewAdvApproveLines.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveLines.FieldCreatedBy);
			}
			set{
				this[this.uiviewAdvApproveLines.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewAdvApproveLines.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewAdvApproveLines.FieldModifiedOn);
			}
			set{
				this[this.uiviewAdvApproveLines.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewAdvApproveLines.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApproveLines.FieldModifiedBy);
			}
			set{
				this[this.uiviewAdvApproveLines.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewAdvApproveLines.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAdvApproveLines.FieldSysVersion);
			}
			set{
				this[this.uiviewAdvApproveLines.FieldSysVersion] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class AdvApproveLinesDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public AdvApproveLinesDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private AdvApproveLinesDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new AdvApproveLinesDefaultFilterFilter();
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