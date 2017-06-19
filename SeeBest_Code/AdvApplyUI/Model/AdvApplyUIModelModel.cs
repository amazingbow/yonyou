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
			this.viewAdvApplyBE.SetResourceInfo("c3356000-b6b7-4a82-ba69-f521101d3e71");
			this.Views.Add(this.viewAdvApplyBE);			
			this.viewAdvApplyBE_AdvAboutBE = new AdvApplyBE_AdvAboutBEView(this);
			this.viewAdvApplyBE_AdvAboutBE.SetResourceInfo("a36b84ac-301b-439a-b8e8-d358b58e63bb");
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
		public IUIField FieldAdvItem
		{
			get { return this.Fields["AdvItem"]; }
		}
		public IUIField FieldAdvItem_Code
		{
			get { return this.Fields["AdvItem_Code"]; }
		}
		public IUIField FieldAdvItem_Name
		{
			get { return this.Fields["AdvItem_Name"]; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","72fdee40-f5fa-42b9-92ba-953f744350de");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","4a2a955d-0034-4ce3-80c7-7e911ec8815c");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2e25c444-cc9e-43a7-8bdc-508bc071be2a");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","73f05079-e469-43d8-94de-8ef0305654b5");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","63eefd3d-52d8-489d-ac8c-f13e2c99a1a4");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","57effc9a-25cd-4878-8a2b-d5538263885f");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), false,"","UFIDA.U9.Base.Organization.Organization", "Org", true,true, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","c11b96e9-618b-41bb-ad61-eb2a083ba3f7");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), false,"","System.String", "Org.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f95add27-50fd-4bea-8876-ff84dbf5c12b");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "Org.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","14ed5069-a6fd-4402-9764-ab414a6f2f0f");
			UIModelRuntimeFactory.AddNewUIField(this,"DocNo", typeof(String), false,"","System.String", "DocNo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","01ba0727-99d4-4a7d-8f6a-47f70c66a20e");
			UIModelRuntimeFactory.AddNewUIField(this,"BusinessDate", typeof(DateTime), false,"","System.Date", "BusinessDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","f8646cac-7e0a-4ec9-b503-3a0dadbbd1ae");
			UIModelRuntimeFactory.AddNewUIField(this,"Version", typeof(Int32), true,"0","System.Int32", "Version", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","bd05c7b2-222b-4d58-8274-346208aa1c39");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintAmount", typeof(Int32), true,"0","System.Int32", "PrintAmount", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","cf3bf328-5498-44f1-8e4b-bc121544dc8b");
			UIModelRuntimeFactory.AddNewUIField(this,"LatestPrintedDate", typeof(DateTime), true,"","System.DateTime", "LatestPrintedDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","626dd5d6-b7be-4955-942a-41b4ca5d675e");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_Canceled", typeof(Boolean), true,"false","System.Boolean", "Cancel.Canceled", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","94961457-9a08-420c-8f9c-994cf61eef83");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelDate", typeof(DateTime), true,"","System.DateTime", "Cancel.CancelDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","d49e751e-4fae-4ae3-9ef6-d6152dfc9a7c");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelReason", typeof(String), true,"","System.String", "Cancel.CancelReason", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d3c8b946-7bcc-4146-b1a4-bd3998e942f5");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelUser", typeof(String), true,"","System.String", "Cancel.CancelUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a3a44330-2fa8-40ad-bab7-3e9ecaddb44e");
			UIModelRuntimeFactory.AddNewUIField(this,"WorkFlowID", typeof(Guid), true,"","System.Guid", "WorkFlowID", true,true, false, "",false,(UIFieldType)1,"2b057235-c58e-441e-9477-5e52fcb7f95b","efd3e0ea-0844-4b0c-b55f-427e7e1b322a");
			UIModelRuntimeFactory.AddNewUIField(this,"StateMachineID", typeof(Guid), true,"","System.Guid", "StateMachineID", true,true, false, "",false,(UIFieldType)1,"2b057235-c58e-441e-9477-5e52fcb7f95b","8a7f6c60-c977-4a09-ac95-77b69434b1ea");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason", typeof(Int64), true,"","UFIDA.U9.Base.HoldRelease.HoldReason", "HoldReason", true,true, false, "",false,(UIFieldType)4,"aca6401c-cd2c-460c-9883-a704f9ea93a6","6afb05c5-f596-454e-ac99-4de1fa2f1d7a");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason_Code", typeof(String), false,"","System.String", "HoldReason.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f2d399ab-cb04-47e8-9330-ce7aacdae64c");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason_Name", typeof(String), true,"","System.String", "HoldReason.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7fdbef1d-5b4f-46fa-a55f-23f6b79bec17");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldUser", typeof(String), true,"","System.String", "HoldUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6771d3ef-e773-4f27-89d5-92b813b9e472");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldDate", typeof(DateTime), true,"","System.DateTime", "HoldDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","9f66e2f9-613b-4c90-94bc-1f894fb671b8");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason", typeof(Int64), true,"","UFIDA.U9.Base.HoldRelease.ReleaseReason", "ReleaseReason", true,true, false, "",false,(UIFieldType)4,"8f4c20a0-ea48-4e30-a76a-1f8d38bcc7cc","1efe0c08-4ce7-43ab-9119-33826f14c674");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason_Code", typeof(String), false,"","System.String", "ReleaseReason.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f3b45141-5c41-4327-b86b-867f5905ed00");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason_Name", typeof(String), true,"","System.String", "ReleaseReason.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","df468c8f-fae6-485b-8da4-1ceabd0386f0");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseUser", typeof(String), true,"","System.String", "ReleaseUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8544f04c-47a0-45a9-a597-4fac9e297f22");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseDate", typeof(DateTime), true,"","System.DateTime", "ReleaseDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","6924e3fd-c6fd-468f-a612-311301cc4bc7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","83ff42a0-edad-422e-b2c3-4d00a23ff007");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fb79b40f-608a-455e-8d37-4f1bc2be5093");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d813f9c1-96c0-4f43-bcef-7620f5d1e25a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a3da0548-6f12-4e21-8e7d-1c4ba743f288");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b5bd7331-83f4-43dc-99c8-00d611cd4d9e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1ec299f1-1f86-4029-9d79-48873402741d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3fd1e554-fc75-46a0-ad63-02334506fdc0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4500c503-6285-4afa-8987-bdb9407ec042");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e3b7b6dd-46c7-491c-8100-e00c78fb488a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a56adde3-e3f2-4f78-8aa1-a7e16f53faae");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c56b8e3f-b854-4137-a705-aa18c13c436f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f0a3a11a-aa0d-4fa7-8b4d-dfee1b60111b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","009deb3b-8d63-4fc1-bb6f-8fa05d3b45c9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b5fcca6f-9cd3-4bb7-b9aa-a721046b33cc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","347dab77-dfe0-4eb2-9830-c8c53fab3e52");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","acd104da-56b3-4b01-a991-064426c92d17");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9cc58d96-aabc-4a73-aab9-d01ad6b56263");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1df450e3-8fd7-4c6b-9a2a-142b0a3aa903");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c2ee0e7c-2b84-4a6f-b285-349ec0f805c9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","eb6b6113-e7fb-41ed-9d37-916fbf2c9b9a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","119ecae4-73e2-47fa-8145-4b2c90e6b011");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6c56c7e3-d75a-4513-8788-424f719b2d67");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","63806528-b9c1-4336-83d6-27b8d79902c8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","25aebbc3-8395-4cc3-83c4-3cee356de253");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8bf0174b-c4ef-41fc-b72c-bd949a907350");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b14afd51-c682-43ef-a3d7-ba634bf3333f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c30ec7ee-9e7d-4659-ad87-cbc0296869e6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","30edc4df-a2ff-4fde-9486-e10353ce0188");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f79dc511-233e-424f-92b8-738d950647af");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d9761f31-eaca-4cd9-96d5-ad683af2109c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg31", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7b3ec23b-c836-41a0-aa1d-2725e3529c5e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg32", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ff66e55b-22a3-4f3c-bdff-8f65bca74ef9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg33", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e218b496-4174-4f54-b09b-a97fbec82ed6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg34", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","800ae92d-2f7c-4aea-9742-65506114b137");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg35", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ed882ed6-944e-4e40-b204-8b8939d1e3da");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg36", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","530e2095-c5e7-42a0-a798-d0578dbdad70");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg37", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","46eb684b-c516-457f-94bf-77f31d865532");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg38", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","944c5350-c00f-4148-b2a3-ba0ea3193796");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg39", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3aed1037-52f1-44ca-bbde-62e64fddd585");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg40", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","71bd8ffa-82f7-4985-acaf-338d60e10546");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg41", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a7985d1a-2f51-402b-aba7-b5d3a0f47c07");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg42", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","015fb7b4-b6c6-42d3-8700-38524120589f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg43", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0b4c00d7-7762-4c75-924b-c2bf4a8a98ee");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg44", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","db28491b-d9e4-4954-9891-8c5485f7debb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg45", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e3baf12e-5a6f-46e3-a9e1-65f5a44cac21");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg46", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","da8e2351-03fd-412c-bdd5-38ed13ebb16c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg47", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d1aec1a5-dfbd-4d36-b79f-28e134163b2c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg48", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","87bbd1c6-9767-4b2b-aed4-e58b4a178338");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg49", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e1c1ec96-91a7-4ef0-8246-ea99416d351c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg50", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3a8654c6-e990-486c-a31e-f8ce6c7688c2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_ContextValue", typeof(String), true,"","System.String", "DescFlexField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","477a562b-e044-439a-8cd7-b040f72c1cc3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","649eae52-cac5-4543-814b-fbcc4cff792f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1442df29-3bcc-4e20-a6aa-2667877cd329");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c4402028-2141-4fe5-b798-13ec8e3aedf8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2e551261-10f7-47e3-b28c-12b639f067dd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","98ab1870-6fb5-442e-8a66-bd7ca74561ce");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","89f28066-fb15-4838-82f3-9343fc5f0a2b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","94f289a0-c64c-4d09-a23d-31f6f5a3e21d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ae09e723-1893-44e0-82bf-fe22ba8d24fc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","53ebfc63-5f21-4748-a2b6-a2d6b3966c46");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a4f8bf0d-6e23-466f-a571-9cb766632619");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","baeef44b-f17d-46b9-be65-26c69a7b565f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cab0d76f-afe6-4a75-893c-904f6c7f03c0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","90d6c32b-71f0-4cb8-b7d1-712a6f0f893b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3b72c9ab-b9c4-4eb5-a64f-ce3d0de98671");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dab8d2c3-4bf9-4999-8936-e708607574bc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b8f448ce-d529-40b6-bab6-71c89d3c99de");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1adfd142-bed0-4579-bbdf-8822fad30007");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e8e83b72-03d1-4bf5-85c2-a7e625981841");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6aadba15-e1b1-4a59-ae6b-e5ec38109331");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2c0e0769-609a-4c0d-b560-4d6710ddd094");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","97e189ea-026b-4546-b77f-2c14eeb42751");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8d99c757-ae6e-4ac1-a27e-ac30b793ffb3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1a6dfdea-009e-4fda-a00a-86e192deecf9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b4491d62-1738-4ecc-b5f3-515ddee32a03");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ceaceb8b-ffaf-49d4-92a3-60340e76e3f8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6a6bd8f1-5b92-43eb-8007-a7a2b733908a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","20e4eeb9-2dcf-410d-bbea-5ae4abe2e3e8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b5a94759-f191-46de-8b86-ca2b53cd5730");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","66ac4164-1197-4aad-a5c0-311e4445426c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0a5e037a-73d3-485d-834a-3defbaf1aa6e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_CombineName", typeof(String), true,"","System.String", "DescFlexField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f423c0d5-282d-4d93-9a06-f82ce65ff696");
			UIModelRuntimeFactory.AddNewUIField(this,"FlowInstance", typeof(Int64), true,"","UFIDA.U9.CS.Workflow.WorkflowInstanceBE.FlowInstance", "FlowInstance", true,true, false, "",false,(UIFieldType)4,"d87a7006-6643-42f4-98f4-168847a71955","10c1b908-ff6e-443c-97f7-e5704d810da9");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvCode", typeof(String), true,"","System.String", "AdvCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9efe1286-cfa7-488b-9d5a-77911aa8156f");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Customer.Customer", "ApplyDept", true,true, false, "",false,(UIFieldType)4,"8508f308-9d66-4b1d-abf4-e28dab8e926d","65818716-fbcf-484a-9bc5-5cfbd6bb7821");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept_Code", typeof(String), false,"","System.String", "ApplyDept.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7fd3c6c3-e54a-4905-ba1f-569677662d22");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept_Name", typeof(String), true,"","System.String", "ApplyDept.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bef6f5b6-ac8c-46b7-a2b2-633aa7ef972d");
			UIModelRuntimeFactory.AddNewUIField(this,"Applier", typeof(String), true,"","System.String", "Applier", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","647ea1f8-f929-43aa-9705-a1b58bd9f35c");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDate", typeof(DateTime), true,"","System.Date", "ApplyDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","bd9552ea-3799-4823-9c8b-3ed2bf31100c");
			UIModelRuntimeFactory.AddNewUIField(this,"Phone", typeof(String), true,"","System.String", "Phone", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ea084683-694e-4959-83ff-4f26ebb2e78c");
			UIModelRuntimeFactory.AddNewUIField(this,"QQ", typeof(String), true,"","System.String", "QQ", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","19164f2a-b2ae-4b99-aea3-8a21a8d2c048");
			UIModelRuntimeFactory.AddNewUIField(this,"CustConterName", typeof(String), true,"","System.String", "CustConterName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","19c7cf66-c25f-4086-958d-549e54d4bd97");
			UIModelRuntimeFactory.AddNewUIField(this,"LocationQY", typeof(String), true,"","System.String", "LocationQY", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","da721220-fdd5-4405-b566-4f797b244ee4");
			UIModelRuntimeFactory.AddNewUIField(this,"LocationXZ", typeof(String), true,"","System.String", "LocationXZ", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","66b26b2a-d95d-44aa-ae91-58e37d579b68");
			UIModelRuntimeFactory.AddNewUIField(this,"RelPeople", typeof(String), true,"","System.String", "RelPeople", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a09042c2-4fdf-4749-8888-1f13d053456d");
			UIModelRuntimeFactory.AddNewUIField(this,"CustPhone", typeof(String), true,"","System.String", "CustPhone", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","40624bf8-9f24-4f6b-99aa-34507bc4fcf6");
			UIModelRuntimeFactory.AddNewUIField(this,"CustAddress", typeof(String), true,"","System.String", "CustAddress", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6c47a749-b6a4-4466-a91b-2eeb0883b3bd");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvItem", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Item.ItemMaster", "AdvItem", true,true, false, "",false,(UIFieldType)4,"636d3e47-48aa-47fc-aca4-e6322bce775b","901e2a84-5234-4ab0-890d-a95c9c106f7d");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvItem_Code", typeof(String), false,"","System.String", "AdvItem.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0b8bf42e-03ce-44ba-a12b-b9032a694673");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvItem_Name", typeof(String), false,"","System.String", "AdvItem.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6bc5063c-018d-456f-9d83-f732201cc45a");
			UIModelRuntimeFactory.AddNewUIField(this,"TotalArea", typeof(Decimal), true,"0","System.Decimal", "TotalArea", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","fd7a5268-7208-4e3b-b353-7952f3d844a1");
			UIModelRuntimeFactory.AddNewUIField(this,"Qty", typeof(Decimal), true,"0","System.Decimal", "Qty", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","fe616fff-5f5d-4ecc-b797-cc2665afa02d");
			UIModelRuntimeFactory.AddNewUIField(this,"BMWidth", typeof(Decimal), true,"0","System.Decimal", "BMWidth", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","c157153c-f0ab-4560-8dd7-c63d4311d7d6");
			UIModelRuntimeFactory.AddNewUIField(this,"BMHight", typeof(Decimal), true,"0","System.Decimal", "BMHight", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","c4174781-27b3-4550-93d8-bcbb315f0f1e");
			UIModelRuntimeFactory.AddNewUIField(this,"BMThick", typeof(Decimal), true,"0","System.Decimal", "BMThick", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","190efdb0-ca8f-4b7f-aa94-5bff1aa4d7df");
			UIModelRuntimeFactory.AddNewUIField(this,"BMArea", typeof(Decimal), true,"0","System.Decimal", "BMArea", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","0c929e18-07c8-4bea-8c4b-e18a91cd1d27");
			UIModelRuntimeFactory.AddNewUIField(this,"DZWidth", typeof(Decimal), true,"0","System.Decimal", "DZWidth", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","d1cdabfd-7894-4558-8ae6-f4cab330416c");
			UIModelRuntimeFactory.AddNewUIField(this,"DZThick", typeof(Decimal), true,"0","System.Decimal", "DZThick", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","6e9bd647-2d7d-4d6b-bb6c-4cfeac2fe57f");
			UIModelRuntimeFactory.AddNewUIField(this,"DZArea", typeof(Decimal), true,"0","System.Decimal", "DZArea", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","7911fc0c-02c9-4e5c-b723-946afb22a0cd");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvDisplayType", typeof(Int32), true,"0","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvDisplayTypeEnum", "AdvDisplayType", true,true, false, "",false,(UIFieldType)2,"0baa04a7-e868-40b1-b5a0-6cfacca13640","0ef9904b-0490-47f0-bae9-5767a72cd66f");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvDispInfo1", typeof(String), true,"","System.String", "AdvDispInfo1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4884b7b0-49a4-4562-b969-1a3fd18f6c8a");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvDispInfo2", typeof(String), true,"","System.String", "AdvDispInfo2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ea29691a-ffa9-4910-b216-23e3e5810a45");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvMemo", typeof(String), true,"","System.String", "AdvMemo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","489aa80e-96ab-4ca7-bfe0-aa8fb3d571f5");
			UIModelRuntimeFactory.AddNewUIField(this,"ApproveQty", typeof(Decimal), true,"0","System.Decimal", "ApproveQty", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","92e29c42-9cab-46c1-b410-dbcd4e2d5948");
			UIModelRuntimeFactory.AddNewUIField(this,"IsClose", typeof(Boolean), true,"false","System.Boolean", "IsClose", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","c26db0f8-557e-4ee2-abb8-aee09d2509b0");
			UIModelRuntimeFactory.AddNewUIField(this,"Flow4Bit", typeof(Int32), true,"0","System.Int32", "Flow4Bit", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","a33dce1a-fbaf-43eb-ab9d-b34d0cf62193");
			UIModelRuntimeFactory.AddNewUIField(this,"WFCurrentState", typeof(Int32), false,"-1","System.Int32", "WFCurrentState", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","18925ab0-28a8-406c-817d-0e254bd4255c");
			UIModelRuntimeFactory.AddNewUIField(this,"WFOriginalState", typeof(Int32), false,"-1","System.Int32", "WFOriginalState", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","280a2b0c-82eb-4157-91e9-acf585ca47cd");
			UIModelRuntimeFactory.AddNewUIField(this,"DocStatus", typeof(Int32), true,"0","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyStatusEnum", "DocStatus", true,true, false, "",false,(UIFieldType)2,"20babf0c-275e-4cb2-a9b5-a751bb8152bf","d95efa8a-e2e4-4a4f-a841-687a333c88f7");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyDocType", typeof(Int64), true,"","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType", "AdvApplyDocType", true,true, false, "",false,(UIFieldType)4,"0ab4dca1-e716-4d53-8bb2-0ef1483d9f4a","91db78af-fa14-4811-826b-75b24fb66801");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyDocType_Code", typeof(String), false,"","System.String", "AdvApplyDocType.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1c7bf2a0-e111-44b6-a782-9e9d848affb7");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyDocType_Name", typeof(String), true,"","System.String", "AdvApplyDocType.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","83038c66-0089-4d0d-87a5-21a053fbdbd9");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyDocType_ConfirmType", typeof(Int32), false,"0","UFIDA.U9.Base.Doc.ConfirmTypeEnum", "AdvApplyDocType.ConfirmType", false,true, false, "",false,(UIFieldType)2,"d232b8fb-1938-4ebe-a90c-41c911c0bc10","8b012d4f-38e6-4f3d-ab31-a91b8443f72d");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyDocType_ApproveType", typeof(Int32), true,"-1","UFIDA.U9.Base.Doc.ApproveTypeEnum", "AdvApplyDocType.ApproveType", false,true, false, "",false,(UIFieldType)2,"d4b6e1a9-d80d-4516-8316-4b1d436cd449","cd3cc408-578a-4917-a616-7f15955284c6");


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
		
		
		public  Int64? AdvItem
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvItem] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApplyBE.FieldAdvItem);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvItem] = value;
			}
		}
		
		
		public  String AdvItem_Code
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvItem_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldAdvItem_Code);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvItem_Code] = value;
			}
		}
		
		
		public  String AdvItem_Name
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvItem_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldAdvItem_Name);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvItem_Name] = value;
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
		
		
		public  String AdvDispInfo1
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvDispInfo1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldAdvDispInfo1);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvDispInfo1] = value;
			}
		}
		
		
		public  String AdvDispInfo2
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvDispInfo2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldAdvDispInfo2);
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","093af09b-b6be-4c44-87c5-50b1384c18a8");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","57e1d33d-d3f6-4d53-81a3-300fcb9290ed");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","442b6273-6882-4a7b-a715-fc0304fbb292");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","962a8c84-7f2c-4240-ba08-39ec44f80216");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","891e15b3-87de-46b4-9125-5712c04684ec");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","95a9b626-f27a-4b2f-839b-757ce83a0da8");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyBE", typeof(Int64), true,"","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE", "AdvApplyBE", true,true, false, "",false,(UIFieldType)4,"34b34c55-0b84-4313-8595-ec236b56752e","65ad25e3-b946-42ab-b30a-6682dd4fe96c");
			UIModelRuntimeFactory.AddNewUIField(this,"Code", typeof(String), true,"","System.String", "Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","48791f83-db67-475e-91eb-1bc9626ff6fb");
			UIModelRuntimeFactory.AddNewUIField(this,"Name", typeof(String), true,"","System.String", "Name", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","62ea88aa-d4ce-4b55-8922-903e63eb80cf");
			UIModelRuntimeFactory.AddNewUIField(this,"IsSelected", typeof(Boolean), true,"false","System.Boolean", "IsSelected", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","db5b7591-1f72-4e32-b1dd-f91f764c563b");
			UIModelRuntimeFactory.AddNewUIField(this,"Description", typeof(String), true,"","System.String", "Description", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8f99f623-90c0-4f55-9799-0a38de9c0662");


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