#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.AdvApplyUI.AdvApplyUIModel
{
	[Serializable]
	public partial class AdvApplyUIModelModel : UIModel
	{
		#region Constructor
		public AdvApplyUIModelModel() : base("AdvApplyUIModel")
		{
			InitClass();
			this.SetResourceInfo("ae8c587c-5655-44f8-afad-1376a8ba10ac");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private AdvApplyUIModelModel(bool isInit) : base("AdvApplyUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new AdvApplyUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private AdvApplyBEView viewAdvApplyBE;			
		private AdvApplyBE_AdvAboutBEView viewAdvApplyBE_AdvAboutBE;			
		#endregion
		
		#region links
		//private IUILink linkAdvApplyBE__AdvApplyBE_AdvAboutBE;			
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public AdvApplyBEView AdvApplyBE
		{
			get { return (AdvApplyBEView)this["AdvApplyBE"]; }
		}
		public AdvApplyBE_AdvAboutBEView AdvApplyBE_AdvAboutBE
		{
			get { return (AdvApplyBE_AdvAboutBEView)this["AdvApplyBE_AdvAboutBE"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewAdvApplyBE = new AdvApplyBEView(this);
			this.viewAdvApplyBE.SetResourceInfo("96d964c6-3b5e-4303-82bc-2b8546865d93");
			this.Views.Add(this.viewAdvApplyBE);			
			this.viewAdvApplyBE_AdvAboutBE = new AdvApplyBE_AdvAboutBEView(this);
			this.viewAdvApplyBE_AdvAboutBE.SetResourceInfo("cebb4a1c-7407-4498-b575-8e1305babc1b");
			this.Views.Add(this.viewAdvApplyBE_AdvAboutBE);			

			//this.linkAdvApplyBE__AdvApplyBE_AdvAboutBE
			{
			IUILink link = new UILink("AdvApplyBE__AdvApplyBE_AdvAboutBE",this,this.viewAdvApplyBE.FieldID,this.viewAdvApplyBE_AdvAboutBE.FieldAdvApplyBE,EnumAssociationKind.COMPOSITION,EnumAssociationDirection.Double,EnumCardinality.ONE,EnumCardinality.MORE,"AdvAboutBE");
			this.Links.Add(link);
			}
			//this.linkAdvApplyBE__AdvApplyBE_AdvAboutBE.ChildKeyConstraint.UpdateRule = Rule.None;
			//this.linkAdvApplyBE__AdvApplyBE_AdvAboutBE.ChildKeyConstraint.DeleteRule = Rule.None;
			//this.linkAdvApplyBE__AdvApplyBE_AdvAboutBE.ChildKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.AdvApplyUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class AdvApplyBEView : UIView
	{
		#region Constructor
		public AdvApplyBEView(IUIModel model) : base(model,"AdvApplyBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private AdvApplyBEView():base(null,"AdvApplyBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new AdvApplyBEView();
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
		public IUIField FieldLocationQY
		{
			get { return this.Fields["LocationQY"]; }
		}
		public IUIField FieldLocationXZ
		{
			get { return this.Fields["LocationXZ"]; }
		}
		public IUIField FieldRelPeople
		{
			get { return this.Fields["RelPeople"]; }
		}
		public IUIField FieldCustPhone
		{
			get { return this.Fields["CustPhone"]; }
		}
		public IUIField FieldCustAddress
		{
			get { return this.Fields["CustAddress"]; }
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
		public IUIField FieldTotalArea
		{
			get { return this.Fields["TotalArea"]; }
		}
		public IUIField FieldQty
		{
			get { return this.Fields["Qty"]; }
		}
		public IUIField FieldBMWidth
		{
			get { return this.Fields["BMWidth"]; }
		}
		public IUIField FieldBMHight
		{
			get { return this.Fields["BMHight"]; }
		}
		public IUIField FieldBMThick
		{
			get { return this.Fields["BMThick"]; }
		}
		public IUIField FieldBMArea
		{
			get { return this.Fields["BMArea"]; }
		}
		public IUIField FieldDZWidth
		{
			get { return this.Fields["DZWidth"]; }
		}
		public IUIField FieldDZThick
		{
			get { return this.Fields["DZThick"]; }
		}
		public IUIField FieldDZArea
		{
			get { return this.Fields["DZArea"]; }
		}
		public IUIField FieldAdvDisplayType
		{
			get { return this.Fields["AdvDisplayType"]; }
		}
		public IUIField FieldAdvDispInfo1
		{
			get { return this.Fields["AdvDispInfo1"]; }
		}
		public IUIField FieldAdvDispInfo2
		{
			get { return this.Fields["AdvDispInfo2"]; }
		}
		public IUIField FieldAdvMemo
		{
			get { return this.Fields["AdvMemo"]; }
		}
		public IUIField FieldApproveQty
		{
			get { return this.Fields["ApproveQty"]; }
		}
		public IUIField FieldIsClose
		{
			get { return this.Fields["IsClose"]; }
		}
		public IUIField FieldFlow4Bit
		{
			get { return this.Fields["Flow4Bit"]; }
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
		public IUIField FieldAdvApplyDocType
		{
			get { return this.Fields["AdvApplyDocType"]; }
		}
		public IUIField FieldAdvApplyDocType_Code
		{
			get { return this.Fields["AdvApplyDocType_Code"]; }
		}
		public IUIField FieldAdvApplyDocType_Name
		{
			get { return this.Fields["AdvApplyDocType_Name"]; }
		}
		public IUIField FieldAdvApplyDocType_ConfirmType
		{
			get { return this.Fields["AdvApplyDocType_ConfirmType"]; }
		}
		public IUIField FieldAdvApplyDocType_ApproveType
		{
			get { return this.Fields["AdvApplyDocType_ApproveType"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public AdvApplyBEDefaultFilterFilter DefaultFilter
		{
			get { return (AdvApplyBEDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","3e44d420-d7e0-4faa-839c-3406f1b8f49e");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","aedc3eb7-eea3-4107-a274-8f904e68a20f");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a0b94777-3450-470d-a0a3-ab1ec3fbc02b");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","160d5580-2c99-4111-9487-31f3b39295d7");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e9d14f76-37b1-4f6b-a977-e8f93483e848");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","7dd45816-789a-4881-b70f-9299f50dee43");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), false,"","UFIDA.U9.Base.Organization.Organization", "Org", true,true, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","7729c4a3-b32a-4baf-960f-154483af6de1");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), false,"","System.String", "Org.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","46fe8a2b-c371-4d88-9d9f-c546067d87bc");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "Org.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e4a89644-c24f-41a6-a328-622bed01d44c");
			UIModelRuntimeFactory.AddNewUIField(this,"DocNo", typeof(String), false,"","System.String", "DocNo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","042a1bd7-e948-4348-a60c-9a1cad8ab015");
			UIModelRuntimeFactory.AddNewUIField(this,"BusinessDate", typeof(DateTime), false,"","System.Date", "BusinessDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","36096b4b-ac01-46f8-b555-f63abd2efc03");
			UIModelRuntimeFactory.AddNewUIField(this,"Version", typeof(Int32), true,"0","System.Int32", "Version", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","66069fce-1b39-4526-a763-37681bee706a");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintAmount", typeof(Int32), true,"0","System.Int32", "PrintAmount", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","498c49f8-fce6-4636-bf9b-1d46a1be8782");
			UIModelRuntimeFactory.AddNewUIField(this,"LatestPrintedDate", typeof(DateTime), true,"","System.DateTime", "LatestPrintedDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","1bbe03f9-9b53-4531-9c0e-73a01e3af64b");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_Canceled", typeof(Boolean), true,"false","System.Boolean", "Cancel.Canceled", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","8903e0cb-3c94-4fa8-8ca5-939b5c65faba");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelDate", typeof(DateTime), true,"","System.DateTime", "Cancel.CancelDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","3772139e-6bab-4c0f-bf1c-d5b72076511c");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelReason", typeof(String), true,"","System.String", "Cancel.CancelReason", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4a30ceea-8efa-43b9-a86b-0efb7e298968");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelUser", typeof(String), true,"","System.String", "Cancel.CancelUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f2e3f4f6-3b44-4fb6-bef4-a6660373f220");
			UIModelRuntimeFactory.AddNewUIField(this,"WorkFlowID", typeof(Guid), true,"","System.Guid", "WorkFlowID", true,true, false, "",false,(UIFieldType)1,"2b057235-c58e-441e-9477-5e52fcb7f95b","cd243acc-ad5c-40c6-8963-18ab789ec1c9");
			UIModelRuntimeFactory.AddNewUIField(this,"StateMachineID", typeof(Guid), true,"","System.Guid", "StateMachineID", true,true, false, "",false,(UIFieldType)1,"2b057235-c58e-441e-9477-5e52fcb7f95b","010db69c-b26c-4f7c-b97b-1d6ffad6a427");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason", typeof(Int64), true,"","UFIDA.U9.Base.HoldRelease.HoldReason", "HoldReason", true,true, false, "",false,(UIFieldType)4,"aca6401c-cd2c-460c-9883-a704f9ea93a6","c86b8caf-9973-47a6-8f44-49d79c79348c");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason_Code", typeof(String), false,"","System.String", "HoldReason.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","90786f06-88a2-4a03-8448-587d37fc8910");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason_Name", typeof(String), true,"","System.String", "HoldReason.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0781a2db-8d2e-46c4-b9ca-36bb0da9b9ee");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldUser", typeof(String), true,"","System.String", "HoldUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0e23bd29-babc-4994-855a-a3b4a7d79a5a");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldDate", typeof(DateTime), true,"","System.DateTime", "HoldDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","f1f58476-e5dc-42de-84a4-bba4134d3581");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason", typeof(Int64), true,"","UFIDA.U9.Base.HoldRelease.ReleaseReason", "ReleaseReason", true,true, false, "",false,(UIFieldType)4,"8f4c20a0-ea48-4e30-a76a-1f8d38bcc7cc","5ae9bcff-ac14-4dab-a40a-60ed9702e56e");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason_Code", typeof(String), false,"","System.String", "ReleaseReason.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e268695c-5067-4c37-8580-412923db683b");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason_Name", typeof(String), true,"","System.String", "ReleaseReason.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c8e4b988-80b0-4dc6-9757-f88834152b61");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseUser", typeof(String), true,"","System.String", "ReleaseUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","df3a47be-3778-490e-9e38-a946579a6f09");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseDate", typeof(DateTime), true,"","System.DateTime", "ReleaseDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","e4e8debe-a121-4b71-978a-a0f8c0af8e34");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","02211abe-5c29-4a2a-833b-1d19c98da015");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","eee97eed-e2e0-41a6-97ab-228416334fe6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1e4e82e5-7955-403e-b2f9-912834936fe0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dc3c8f9e-9657-4037-8182-c74fead95ca4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5e84750f-9ded-4a5e-a579-7207eb8a1064");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ea51b0b3-5775-4568-bdd0-9350cf3fbc4f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","88f74837-4ac5-4bb2-8106-402c735463de");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ca909fc8-d438-40f8-acc9-e90bfceb5dcc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f4c4b9a3-7413-4e17-905e-72a3ae09368a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9ba6ba35-6bbe-45a0-b907-c9e5f14919b1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","123bea03-bbd0-4ba7-91be-bc022dd7f42c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ea195a75-b6cb-4a02-94e2-e9cba1613c08");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c56dfd6b-050f-4cf7-b5aa-14404b5828e2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","59208182-96cf-43eb-9e9a-5d49726955a2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","76b219d4-aaa0-4a9e-bee3-7839ec8451a9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","65ad539a-1320-495e-b444-8dfec1f9af6f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","657b7792-7468-40ed-9f84-e3a76be9d6c4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1288bd5b-0a30-454a-84cc-6fa493d5bf8a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8ef355f9-f6fb-411a-acb5-29e5cec0b6e1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3606af51-eb44-4d6f-9de0-29623cfc4d82");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","96f96104-e768-422a-865c-bf0f0524a300");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e1163dfe-42eb-4480-9c14-b9f138c0ae1e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6048e7d9-7810-47c8-bfb8-e536ef06246f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","15a4d47b-ec08-4635-997c-3151843af6f5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","27936faf-2940-41fd-b8b8-308a5cc3072e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7d512753-80e0-4903-95b5-0229edfe8765");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bdaeb58e-8b2e-4ced-b9d9-0cfc7a30c495");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","18f67c59-b4cc-41b8-bfe2-a1496e8ca507");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","11eff7c5-f0dc-4649-ab78-9d43907af3ea");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0835d860-c046-480c-b2b6-b45bc9352057");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg31", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","97ef86cd-958e-46f4-bd3f-e1d3d130533e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg32", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f99d9163-6156-4d5b-bd58-5bf8043c49a3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg33", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fa09b422-9b60-40b9-9108-97613920c9ec");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg34", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","88ef53ef-5583-4d54-bf53-46444ac999ca");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg35", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","70d06d27-b45c-4730-8375-ab427003ad2f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg36", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","053149fb-49b3-4773-913e-a2d91039eaff");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg37", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","135bcae1-05ff-4222-9417-a448500c0e7a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg38", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","98c609eb-611e-4b61-be9e-6df2eb1c3bd5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg39", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2d38145b-a402-486d-97c4-c74a39276a77");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg40", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","44f27617-1046-4698-8ba0-394f6124af83");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg41", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","48b4a9b6-e8ff-4f45-9e22-c7e3c30a36f8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg42", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6cb02f5e-d572-489d-b3cc-6563283a3170");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg43", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","23bd6d8e-5948-46a5-9048-dcb3397a7745");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg44", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0f6aa7b3-e5ee-49bb-a37e-88bbc68d166f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg45", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","684d12a5-cd8d-45ff-afd4-60f44bc8c23e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg46", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2bb0777d-dca0-4af7-af79-429ec557d735");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg47", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","92a684d2-6ba6-4931-9500-67a52a063fea");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg48", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2c72b676-a69f-4379-a55a-882284b01a2a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg49", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c5113b56-38f7-49e6-a7dc-03542457345c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg50", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","06687403-8355-41e7-bcde-69ca140a1009");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_ContextValue", typeof(String), true,"","System.String", "DescFlexField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9a15c7a6-31aa-48ee-8f26-8c0807d71d5b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","986611bb-095e-43ea-b5de-a298f65d12a8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b276287f-34f8-4600-b4c3-99efdf0eb76d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7f262fba-a1eb-437c-aadf-8208bcc4e1de");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2f5d5071-6de3-4154-856e-55a97854addb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8dbb462c-272e-43c1-b2a4-a66cd54c1721");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","48b541ef-6f7d-4d1f-8657-32a7ed4ebb63");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","43c5722f-4231-46d3-89fd-885c2af40bd0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4769d6c9-8c9a-4c2d-89f0-3f701772d17c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6ae144b5-08a5-4fe6-bcb2-b9b3bf1bc881");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","59a2ae07-19da-4667-800f-6f5426c99030");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a89177a3-3097-45a8-96fe-15fe5b35a6f1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a0a2d7dd-42d8-468a-8376-cdd931ca94ec");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9f0adbaf-112a-43a7-b2d8-6bb7144980ad");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a8656b9a-ea3c-4001-b428-83f7afc5dd40");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6dfee085-6210-4d2f-8d67-d4d1a20d15ef");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6ecfe463-9fa7-408b-a4c8-3b0ab5349bad");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","067f79d5-4add-4040-96eb-41dc56cb2ce6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8bd48b58-26b9-4004-b383-f8ae78bb5c1c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","781dd627-737d-4b47-982a-607dc593119a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c0b238dc-98fe-4554-9412-b7c9b81d8cec");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","67fdfa50-f706-4c5a-bc39-a6f3802a771f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","879680cd-688e-4086-a240-a3b34f57a5bc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","565cc61c-bc19-42ba-94fb-4df3c62bea89");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","372b124f-a76b-4fb2-8e47-998646b48e4c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","31b66533-0f33-475a-953b-7cd93aa68490");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","aeb04a8a-39f8-4614-ac18-f0bc40bd9c5d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0bcb87c8-7a65-40cb-8ec8-abdb07d06a7a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a543936f-cf50-49d5-b85f-1de82dfc6e18");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e8bb1a81-d735-4893-b1cf-485e8b3191bf");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f77b8cda-ea7c-48e0-8d1a-425a88f92c08");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_CombineName", typeof(String), true,"","System.String", "DescFlexField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","51e045ec-1156-44f6-a00b-bd01f2713f46");
			UIModelRuntimeFactory.AddNewUIField(this,"FlowInstance", typeof(Int64), true,"","UFIDA.U9.CS.Workflow.WorkflowInstanceBE.FlowInstance", "FlowInstance", true,true, false, "",false,(UIFieldType)4,"d87a7006-6643-42f4-98f4-168847a71955","8fffa1e6-9147-42d0-acbe-19c035795865");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvCode", typeof(String), true,"","System.String", "AdvCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","63179861-e7a9-4746-8db0-2146aca98f78");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Customer.Customer", "ApplyDept", true,true, false, "",false,(UIFieldType)4,"8508f308-9d66-4b1d-abf4-e28dab8e926d","4b117863-684c-4bdf-ac3c-505f92fc013e");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept_Code", typeof(String), false,"","System.String", "ApplyDept.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3cb257a7-f795-4621-bc4e-cebe2f40e15b");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept_Name", typeof(String), true,"","System.String", "ApplyDept.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d7f7c6df-dcb9-4b9f-aa1d-5c30d8326c41");
			UIModelRuntimeFactory.AddNewUIField(this,"Applier", typeof(String), true,"","System.String", "Applier", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7b31cfd5-c387-4124-9004-35e77599b52d");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDate", typeof(DateTime), true,"","System.Date", "ApplyDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","7bcdf030-68d0-4669-bcb0-2da5753d501e");
			UIModelRuntimeFactory.AddNewUIField(this,"Phone", typeof(String), true,"","System.String", "Phone", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f52f4c32-2603-4b64-901c-73d8d19a54b0");
			UIModelRuntimeFactory.AddNewUIField(this,"QQ", typeof(String), true,"","System.String", "QQ", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e772b72d-d5db-4a73-9ff4-7366dd8322bd");
			UIModelRuntimeFactory.AddNewUIField(this,"CustConterName", typeof(String), true,"","System.String", "CustConterName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","56b4a06d-22ca-427a-8cd0-0d595cfa3ab7");
			UIModelRuntimeFactory.AddNewUIField(this,"LocationQY", typeof(String), true,"","System.String", "LocationQY", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a6471dd5-d7b4-40c6-8aea-1f1cfe28a0e0");
			UIModelRuntimeFactory.AddNewUIField(this,"LocationXZ", typeof(String), true,"","System.String", "LocationXZ", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5cd556b6-0595-4c62-bb6d-31098bf46e58");
			UIModelRuntimeFactory.AddNewUIField(this,"RelPeople", typeof(String), true,"","System.String", "RelPeople", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2a6d2278-01d6-4779-a7eb-ced67bbc6fa8");
			UIModelRuntimeFactory.AddNewUIField(this,"CustPhone", typeof(String), true,"","System.String", "CustPhone", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7bf9d4ca-6dc9-4413-82a2-41a2130416ec");
			UIModelRuntimeFactory.AddNewUIField(this,"CustAddress", typeof(String), true,"","System.String", "CustAddress", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1e617ceb-93c6-453f-a9a0-201786f3c1b9");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvCarrier", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Item.ItemMaster", "AdvCarrier", true,true, false, "",false,(UIFieldType)4,"636d3e47-48aa-47fc-aca4-e6322bce775b","bbf03025-18c7-44db-800e-8bcaaca8dcab");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvCarrier_Code", typeof(String), false,"","System.String", "AdvCarrier.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","48850cd6-3090-40d2-b720-1de34f16690b");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvCarrier_Name", typeof(String), false,"","System.String", "AdvCarrier.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3579a2b9-4813-4f4c-942a-33cd23ee20be");
			UIModelRuntimeFactory.AddNewUIField(this,"TotalArea", typeof(Decimal), true,"0","System.Decimal", "TotalArea", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","8ef448c2-1593-447a-8941-d4700d54e14d");
			UIModelRuntimeFactory.AddNewUIField(this,"Qty", typeof(Decimal), true,"0","System.Decimal", "Qty", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","b0c5adfb-a275-4a7d-92a5-90ec329e8066");
			UIModelRuntimeFactory.AddNewUIField(this,"BMWidth", typeof(Decimal), true,"0","System.Decimal", "BMWidth", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","3841a7c5-96a5-4501-b9c8-f73c478f297a");
			UIModelRuntimeFactory.AddNewUIField(this,"BMHight", typeof(Decimal), true,"0","System.Decimal", "BMHight", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","43bf6f15-a5fe-429c-b28a-626885a00878");
			UIModelRuntimeFactory.AddNewUIField(this,"BMThick", typeof(Decimal), true,"0","System.Decimal", "BMThick", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","98483eab-085a-44d9-acb6-01b04e385f7c");
			UIModelRuntimeFactory.AddNewUIField(this,"BMArea", typeof(Decimal), true,"0","System.Decimal", "BMArea", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","67751d05-6e0c-4dbc-a7f7-086b0d24f033");
			UIModelRuntimeFactory.AddNewUIField(this,"DZWidth", typeof(Decimal), true,"0","System.Decimal", "DZWidth", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","90dc5718-a8fe-49ba-8334-95213c7b39b7");
			UIModelRuntimeFactory.AddNewUIField(this,"DZThick", typeof(Decimal), true,"0","System.Decimal", "DZThick", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","8d3b2bca-b2e8-4161-b93d-ed996c1e5ac1");
			UIModelRuntimeFactory.AddNewUIField(this,"DZArea", typeof(Decimal), true,"0","System.Decimal", "DZArea", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","eb8a81f2-4eb5-4dda-bb69-d3081ecc62f2");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvDisplayType", typeof(Int32), true,"0","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvDisplayTypeEnum", "AdvDisplayType", true,true, false, "",false,(UIFieldType)2,"0baa04a7-e868-40b1-b5a0-6cfacca13640","7723bbc9-0138-4f5a-beda-18dcb8ffc95b");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvDispInfo1", typeof(Int32), true,"0","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvPageReq1Enum", "AdvDispInfo1", true,true, false, "",false,(UIFieldType)2,"6fb34584-eb7b-4f6a-ba52-24c597b35239","b7875eeb-c8e7-4d42-ad5b-8d99d23b5713");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvDispInfo2", typeof(Int32), true,"0","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvPageReq2Enum", "AdvDispInfo2", true,true, false, "",false,(UIFieldType)2,"550b275c-3802-46fc-9584-c3dc308fcf17","6df63c93-822a-422c-abb6-70cdf436ff9b");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvMemo", typeof(String), true,"","System.String", "AdvMemo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","610e9cc8-dbe3-43ec-a887-3cd3842164b8");
			UIModelRuntimeFactory.AddNewUIField(this,"ApproveQty", typeof(Decimal), true,"0","System.Decimal", "ApproveQty", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","726f2001-2c49-4fc1-9cc6-c7e889b220f0");
			UIModelRuntimeFactory.AddNewUIField(this,"IsClose", typeof(Boolean), true,"false","System.Boolean", "IsClose", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","0143cc1d-a309-417e-a82b-a243da185d8e");
			UIModelRuntimeFactory.AddNewUIField(this,"Flow4Bit", typeof(Int32), true,"0","System.Int32", "Flow4Bit", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","1a96e6b9-d689-44a0-9082-f396f59920e9");
			UIModelRuntimeFactory.AddNewUIField(this,"WFCurrentState", typeof(Int32), false,"-1","System.Int32", "WFCurrentState", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","0c324f4b-be5d-4082-a320-beeb5956cbed");
			UIModelRuntimeFactory.AddNewUIField(this,"WFOriginalState", typeof(Int32), false,"-1","System.Int32", "WFOriginalState", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","e4268fb1-5906-4b7e-9417-7af449ef5981");
			UIModelRuntimeFactory.AddNewUIField(this,"DocStatus", typeof(Int32), true,"0","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyStatusEnum", "DocStatus", true,true, false, "",false,(UIFieldType)2,"20babf0c-275e-4cb2-a9b5-a751bb8152bf","7cb9ff41-cffa-40f4-92b2-47060aa05020");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyDocType", typeof(Int64), true,"","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType", "AdvApplyDocType", true,true, false, "",false,(UIFieldType)4,"0ab4dca1-e716-4d53-8bb2-0ef1483d9f4a","693d3a76-4af8-46d6-84b2-416794fe3a29");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyDocType_Code", typeof(String), false,"","System.String", "AdvApplyDocType.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ab6e674d-a79f-4ed1-8e3e-d268e93e0f5b");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyDocType_Name", typeof(String), true,"","System.String", "AdvApplyDocType.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","63a4945c-30ff-4b43-8a51-7c845e05de79");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyDocType_ConfirmType", typeof(Int32), false,"0","UFIDA.U9.Base.Doc.ConfirmTypeEnum", "AdvApplyDocType.ConfirmType", false,true, false, "",false,(UIFieldType)2,"d232b8fb-1938-4ebe-a90c-41c911c0bc10","a8fc255f-4bdf-4689-accf-65867a8fdf76");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyDocType_ApproveType", typeof(Int32), true,"-1","UFIDA.U9.Base.Doc.ApproveTypeEnum", "AdvApplyDocType.ApproveType", false,true, false, "",false,(UIFieldType)2,"d4b6e1a9-d80d-4516-8316-4b1d436cd449","39d6eebc-1a34-44f7-bd8b-f2d2ecee676a");


			this.CurrentFilter = new AdvApplyBEDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new AdvApplyBERecord(builder);
		}
		#endregion

		#region new method
		public new AdvApplyBERecord FocusedRecord
		{
			get { return (AdvApplyBERecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new AdvApplyBERecord AddNewUIRecord()
		{	
			return (AdvApplyBERecord)base.AddNewUIRecord();
		}
		public new AdvApplyBERecord NewUIRecord()
		{	
			return (AdvApplyBERecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class AdvApplyBERecord : UIRecord
	{
		#region Constructor
		public AdvApplyBERecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private AdvApplyBEView uiviewAdvApplyBE
		{
			get { return (AdvApplyBEView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new AdvApplyBERecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAdvApplyBE.FieldID);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApplyBE.FieldCreatedOn);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldCreatedBy);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApplyBE.FieldModifiedOn);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldModifiedBy);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApplyBE.FieldSysVersion);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64 Org
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldOrg] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAdvApplyBE.FieldOrg);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldOrg] = value;
			}
		}
		
		
		public  String Org_Code
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldOrg_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldOrg_Code);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldOrg_Code] = value;
			}
		}
		
		
		public  String Org_Name
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldOrg_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldOrg_Name);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldOrg_Name] = value;
			}
		}
		
		
		public  String DocNo
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDocNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDocNo);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDocNo] = value;
			}
		}
		
		
		public  DateTime BusinessDate
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldBusinessDate] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewAdvApplyBE.FieldBusinessDate);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldBusinessDate] = value;
			}
		}
		
		
		public  Int32? Version
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldVersion] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewAdvApplyBE.FieldVersion);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldVersion] = value;
			}
		}
		
		
		public  Int32? PrintAmount
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldPrintAmount] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewAdvApplyBE.FieldPrintAmount);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldPrintAmount] = value;
			}
		}
		
		
		public  DateTime? LatestPrintedDate
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldLatestPrintedDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApplyBE.FieldLatestPrintedDate);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldLatestPrintedDate] = value;
			}
		}
		
		
		public  Boolean? Cancel_Canceled
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldCancel_Canceled] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewAdvApplyBE.FieldCancel_Canceled);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldCancel_Canceled] = value;
			}
		}
		
		
		public  DateTime? Cancel_CancelDate
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldCancel_CancelDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApplyBE.FieldCancel_CancelDate);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldCancel_CancelDate] = value;
			}
		}
		
		
		public  String Cancel_CancelReason
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldCancel_CancelReason] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldCancel_CancelReason);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldCancel_CancelReason] = value;
			}
		}
		
		
		public  String Cancel_CancelUser
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldCancel_CancelUser] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldCancel_CancelUser);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldCancel_CancelUser] = value;
			}
		}
		
		
		public  Guid WorkFlowID
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldWorkFlowID] ;
				//return (Guid)value;
				return GetValue<Guid>(this.uiviewAdvApplyBE.FieldWorkFlowID);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldWorkFlowID] = value;
			}
		}
		
		
		public  Guid StateMachineID
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldStateMachineID] ;
				//return (Guid)value;
				return GetValue<Guid>(this.uiviewAdvApplyBE.FieldStateMachineID);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldStateMachineID] = value;
			}
		}
		
		
		public  Int64? HoldReason
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldHoldReason] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApplyBE.FieldHoldReason);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldHoldReason] = value;
			}
		}
		
		
		public  String HoldReason_Code
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldHoldReason_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldHoldReason_Code);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldHoldReason_Code] = value;
			}
		}
		
		
		public  String HoldReason_Name
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldHoldReason_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldHoldReason_Name);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldHoldReason_Name] = value;
			}
		}
		
		
		public  String HoldUser
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldHoldUser] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldHoldUser);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldHoldUser] = value;
			}
		}
		
		
		public  DateTime? HoldDate
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldHoldDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApplyBE.FieldHoldDate);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldHoldDate] = value;
			}
		}
		
		
		public  Int64? ReleaseReason
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldReleaseReason] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApplyBE.FieldReleaseReason);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldReleaseReason] = value;
			}
		}
		
		
		public  String ReleaseReason_Code
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldReleaseReason_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldReleaseReason_Code);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldReleaseReason_Code] = value;
			}
		}
		
		
		public  String ReleaseReason_Name
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldReleaseReason_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldReleaseReason_Name);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldReleaseReason_Name] = value;
			}
		}
		
		
		public  String ReleaseUser
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldReleaseUser] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldReleaseUser);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldReleaseUser] = value;
			}
		}
		
		
		public  DateTime? ReleaseDate
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldReleaseDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApplyBE.FieldReleaseDate);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldReleaseDate] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg1
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg1);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg2
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg2);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg3
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg3);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg4
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg4);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg5
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg5);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg6
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg6);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg7
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg7);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg8
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg8);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg9
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg9);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg10
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg10);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg11
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg11);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg12
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg12);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg13
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg13);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg14
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg14);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg15
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg15);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg16
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg16);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg17
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg17);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg18
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg18);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg19
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg19);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg20
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg20);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg21
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg21);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg22
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg22);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg23
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg23);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg24
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg24);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg25
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg25);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg26
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg26);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg27
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg27);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg28
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg28);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg29
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg29);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg30
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg30);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg31
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg31] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg31);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg31] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg32
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg32] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg32);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg32] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg33
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg33] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg33);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg33] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg34
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg34] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg34);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg34] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg35
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg35] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg35);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg35] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg36
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg36] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg36);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg36] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg37
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg37] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg37);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg37] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg38
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg38] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg38);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg38] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg39
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg39] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg39);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg39] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg40
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg40] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg40);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg40] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg41
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg41] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg41);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg41] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg42
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg42] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg42);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg42] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg43
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg43] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg43);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg43] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg44
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg44] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg44);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg44] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg45
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg45] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg45);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg45] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg46
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg46] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg46);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg46] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg47
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg47] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg47);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg47] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg48
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg48] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg48);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg48] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg49
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg49] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg49);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg49] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg50
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg50] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg50);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PubDescSeg50] = value;
			}
		}
		
		
		public  String DescFlexField_ContextValue
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_ContextValue] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_ContextValue);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_ContextValue] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg1);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg2
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg2);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg3
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg3);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg4
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg4);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg5
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg5);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg6
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg6);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg7
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg7);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg8
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg8);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg9
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg9);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg10
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg10);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg11
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg11);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg12
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg12);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg13
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg13);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg14
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg14);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg15
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg15);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg16
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg16);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg17
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg17);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg18
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg18);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg19
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg19);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg20
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg20);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg21
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg21);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg22
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg22);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg23
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg23);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg24
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg24);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg25
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg25);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg26
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg26);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg27
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg27);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg28
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg28);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg29
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg29);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg30);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_PrivateDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_CombineName
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDescFlexField_CombineName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldDescFlexField_CombineName);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDescFlexField_CombineName] = value;
			}
		}
		
		
		public  Int64? FlowInstance
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldFlowInstance] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApplyBE.FieldFlowInstance);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldFlowInstance] = value;
			}
		}
		
		
		public  String AdvCode
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldAdvCode);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvCode] = value;
			}
		}
		
		
		public  Int64? ApplyDept
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldApplyDept] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApplyBE.FieldApplyDept);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldApplyDept] = value;
			}
		}
		
		
		public  String ApplyDept_Code
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldApplyDept_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldApplyDept_Code);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldApplyDept_Code] = value;
			}
		}
		
		
		public  String ApplyDept_Name
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldApplyDept_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldApplyDept_Name);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldApplyDept_Name] = value;
			}
		}
		
		
		public  String Applier
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldApplier] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldApplier);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldApplier] = value;
			}
		}
		
		
		public  DateTime? ApplyDate
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldApplyDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApplyBE.FieldApplyDate);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldApplyDate] = value;
			}
		}
		
		
		public  String Phone
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldPhone] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldPhone);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldPhone] = value;
			}
		}
		
		
		public  String QQ
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldQQ] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldQQ);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldQQ] = value;
			}
		}
		
		
		public  String CustConterName
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldCustConterName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldCustConterName);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldCustConterName] = value;
			}
		}
		
		
		public  String LocationQY
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldLocationQY] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldLocationQY);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldLocationQY] = value;
			}
		}
		
		
		public  String LocationXZ
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldLocationXZ] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldLocationXZ);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldLocationXZ] = value;
			}
		}
		
		
		public  String RelPeople
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldRelPeople] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldRelPeople);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldRelPeople] = value;
			}
		}
		
		
		public  String CustPhone
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldCustPhone] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldCustPhone);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldCustPhone] = value;
			}
		}
		
		
		public  String CustAddress
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldCustAddress] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldCustAddress);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldCustAddress] = value;
			}
		}
		
		
		public  Int64? AdvCarrier
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvCarrier] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApplyBE.FieldAdvCarrier);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvCarrier] = value;
			}
		}
		
		
		public  String AdvCarrier_Code
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvCarrier_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldAdvCarrier_Code);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvCarrier_Code] = value;
			}
		}
		
		
		public  String AdvCarrier_Name
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvCarrier_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldAdvCarrier_Name);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvCarrier_Name] = value;
			}
		}
		
		
		public  Decimal? TotalArea
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldTotalArea] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApplyBE.FieldTotalArea);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldTotalArea] = value;
			}
		}
		
		
		public  Decimal? Qty
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApplyBE.FieldQty);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldQty] = value;
			}
		}
		
		
		public  Decimal? BMWidth
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldBMWidth] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApplyBE.FieldBMWidth);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldBMWidth] = value;
			}
		}
		
		
		public  Decimal? BMHight
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldBMHight] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApplyBE.FieldBMHight);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldBMHight] = value;
			}
		}
		
		
		public  Decimal? BMThick
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldBMThick] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApplyBE.FieldBMThick);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldBMThick] = value;
			}
		}
		
		
		public  Decimal? BMArea
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldBMArea] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApplyBE.FieldBMArea);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldBMArea] = value;
			}
		}
		
		
		public  Decimal? DZWidth
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDZWidth] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApplyBE.FieldDZWidth);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDZWidth] = value;
			}
		}
		
		
		public  Decimal? DZThick
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDZThick] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApplyBE.FieldDZThick);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDZThick] = value;
			}
		}
		
		
		public  Decimal? DZArea
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDZArea] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApplyBE.FieldDZArea);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDZArea] = value;
			}
		}
		
		
		public  Int32? AdvDisplayType
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvDisplayType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewAdvApplyBE.FieldAdvDisplayType);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvDisplayType] = value;
			}
		}
		
		
		public  Int32? AdvDispInfo1
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvDispInfo1] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewAdvApplyBE.FieldAdvDispInfo1);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvDispInfo1] = value;
			}
		}
		
		
		public  Int32? AdvDispInfo2
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvDispInfo2] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewAdvApplyBE.FieldAdvDispInfo2);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvDispInfo2] = value;
			}
		}
		
		
		public  String AdvMemo
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvMemo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldAdvMemo);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvMemo] = value;
			}
		}
		
		
		public  Decimal? ApproveQty
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldApproveQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApplyBE.FieldApproveQty);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldApproveQty] = value;
			}
		}
		
		
		public  Boolean? IsClose
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldIsClose] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewAdvApplyBE.FieldIsClose);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldIsClose] = value;
			}
		}
		
		
		public  Int32? Flow4Bit
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldFlow4Bit] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewAdvApplyBE.FieldFlow4Bit);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldFlow4Bit] = value;
			}
		}
		
		
		public  Int32 WFCurrentState
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldWFCurrentState] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewAdvApplyBE.FieldWFCurrentState);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldWFCurrentState] = value;
			}
		}
		
		
		public  Int32 WFOriginalState
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldWFOriginalState] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewAdvApplyBE.FieldWFOriginalState);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldWFOriginalState] = value;
			}
		}
		
		
		public  Int32? DocStatus
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDocStatus] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewAdvApplyBE.FieldDocStatus);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDocStatus] = value;
			}
		}
		
		
		public  Int64? AdvApplyDocType
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvApplyDocType] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApplyBE.FieldAdvApplyDocType);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvApplyDocType] = value;
			}
		}
		
		
		public  String AdvApplyDocType_Code
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvApplyDocType_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldAdvApplyDocType_Code);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvApplyDocType_Code] = value;
			}
		}
		
		
		public  String AdvApplyDocType_Name
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvApplyDocType_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldAdvApplyDocType_Name);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvApplyDocType_Name] = value;
			}
		}
		
		
		public  Int32 AdvApplyDocType_ConfirmType
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvApplyDocType_ConfirmType] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewAdvApplyBE.FieldAdvApplyDocType_ConfirmType);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvApplyDocType_ConfirmType] = value;
			}
		}
		
		
		public  Int32? AdvApplyDocType_ApproveType
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvApplyDocType_ApproveType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewAdvApplyBE.FieldAdvApplyDocType_ApproveType);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvApplyDocType_ApproveType] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class AdvApplyBEDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public AdvApplyBEDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private AdvApplyBEDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new AdvApplyBEDefaultFilterFilter();
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
	public partial class AdvApplyBE_AdvAboutBEView : UIView
	{
		#region Constructor
		public AdvApplyBE_AdvAboutBEView(IUIModel model) : base(model,"AdvApplyBE_AdvAboutBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBE", false)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private AdvApplyBE_AdvAboutBEView():base(null,"AdvApplyBE_AdvAboutBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBE", false)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new AdvApplyBE_AdvAboutBEView();
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
		public IUIField FieldAdvApplyBE
		{
			get { return this.Fields["AdvApplyBE"]; }
		}
		public IUIField FieldCode
		{
			get { return this.Fields["Code"]; }
		}
		public IUIField FieldName
		{
			get { return this.Fields["Name"]; }
		}
		public IUIField FieldIsSelected
		{
			get { return this.Fields["IsSelected"]; }
		}
		public IUIField FieldDescription
		{
			get { return this.Fields["Description"]; }
		}


		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","b839527e-34e1-4131-978b-883fea200f99");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","05a737d6-a31b-4397-a6c0-9c4adcc584df");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d9bfee5f-14c0-4918-9e00-725500c6bc35");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","cb6255ec-afb6-4cfe-b28b-9756ee4805c9");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5a7ca4b7-dde7-4c9e-a03c-de2ecb4900a2");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","4efeadac-9adb-4f40-b546-5173ff32fb06");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyBE", typeof(Int64), true,"","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE", "AdvApplyBE", true,true, false, "",false,(UIFieldType)4,"34b34c55-0b84-4313-8595-ec236b56752e","878a4687-0392-4513-af27-8773f7174b5c");
			UIModelRuntimeFactory.AddNewUIField(this,"Code", typeof(String), true,"","System.String", "Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","08178445-6547-4048-aa49-b5cc158d9cfa");
			UIModelRuntimeFactory.AddNewUIField(this,"Name", typeof(String), true,"","System.String", "Name", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","979a5c30-6965-470e-8ca4-a4b39a7f5dbe");
			UIModelRuntimeFactory.AddNewUIField(this,"IsSelected", typeof(Boolean), true,"false","System.Boolean", "IsSelected", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","6e57af26-6b17-41f4-9a75-02430a19c2f7");
			UIModelRuntimeFactory.AddNewUIField(this,"Description", typeof(String), true,"","System.String", "Description", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8c2b6345-09c4-471e-b202-bbc0e9994bcc");


		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new AdvApplyBE_AdvAboutBERecord(builder);
		}
		#endregion

		#region new method
		public new AdvApplyBE_AdvAboutBERecord FocusedRecord
		{
			get { return (AdvApplyBE_AdvAboutBERecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new AdvApplyBE_AdvAboutBERecord AddNewUIRecord()
		{	
			return (AdvApplyBE_AdvAboutBERecord)base.AddNewUIRecord();
		}
		public new AdvApplyBE_AdvAboutBERecord NewUIRecord()
		{	
			return (AdvApplyBE_AdvAboutBERecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class AdvApplyBE_AdvAboutBERecord : UIRecord
	{
		#region Constructor
		public AdvApplyBE_AdvAboutBERecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private AdvApplyBE_AdvAboutBEView uiviewAdvApplyBE_AdvAboutBE
		{
			get { return (AdvApplyBE_AdvAboutBEView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new AdvApplyBE_AdvAboutBERecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewAdvApplyBE_AdvAboutBE.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAdvApplyBE_AdvAboutBE.FieldID);
			}
			set{
				this[this.uiviewAdvApplyBE_AdvAboutBE.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewAdvApplyBE_AdvAboutBE.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApplyBE_AdvAboutBE.FieldCreatedOn);
			}
			set{
				this[this.uiviewAdvApplyBE_AdvAboutBE.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewAdvApplyBE_AdvAboutBE.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE_AdvAboutBE.FieldCreatedBy);
			}
			set{
				this[this.uiviewAdvApplyBE_AdvAboutBE.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewAdvApplyBE_AdvAboutBE.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApplyBE_AdvAboutBE.FieldModifiedOn);
			}
			set{
				this[this.uiviewAdvApplyBE_AdvAboutBE.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewAdvApplyBE_AdvAboutBE.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE_AdvAboutBE.FieldModifiedBy);
			}
			set{
				this[this.uiviewAdvApplyBE_AdvAboutBE.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewAdvApplyBE_AdvAboutBE.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApplyBE_AdvAboutBE.FieldSysVersion);
			}
			set{
				this[this.uiviewAdvApplyBE_AdvAboutBE.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? AdvApplyBE
		{
			get{
				//object value = this[this.uiviewAdvApplyBE_AdvAboutBE.FieldAdvApplyBE] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApplyBE_AdvAboutBE.FieldAdvApplyBE);
			}
			set{
				this[this.uiviewAdvApplyBE_AdvAboutBE.FieldAdvApplyBE] = value;
			}
		}
		
		
		public  String Code
		{
			get{
				//object value = this[this.uiviewAdvApplyBE_AdvAboutBE.FieldCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE_AdvAboutBE.FieldCode);
			}
			set{
				this[this.uiviewAdvApplyBE_AdvAboutBE.FieldCode] = value;
			}
		}
		
		
		public new String Name
		{
			get{
				//object value = this[this.uiviewAdvApplyBE_AdvAboutBE.FieldName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE_AdvAboutBE.FieldName);
			}
			set{
				this[this.uiviewAdvApplyBE_AdvAboutBE.FieldName] = value;
			}
		}
		
		
		public  Boolean? IsSelected
		{
			get{
				//object value = this[this.uiviewAdvApplyBE_AdvAboutBE.FieldIsSelected] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewAdvApplyBE_AdvAboutBE.FieldIsSelected);
			}
			set{
				this[this.uiviewAdvApplyBE_AdvAboutBE.FieldIsSelected] = value;
			}
		}
		
		
		public  String Description
		{
			get{
				//object value = this[this.uiviewAdvApplyBE_AdvAboutBE.FieldDescription] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE_AdvAboutBE.FieldDescription);
			}
			set{
				this[this.uiviewAdvApplyBE_AdvAboutBE.FieldDescription] = value;
			}
		}
		#endregion
	}
	



}