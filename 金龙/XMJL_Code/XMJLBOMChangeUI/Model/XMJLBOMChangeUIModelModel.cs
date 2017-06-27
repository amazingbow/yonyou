#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.XMJL.XMJLBOMChangeUIModel
{
	[Serializable]
	public partial class XMJLBOMChangeUIModelModel : UIModel
	{
		#region Constructor
		public XMJLBOMChangeUIModelModel() : base("XMJLBOMChangeUIModel")
		{
			InitClass();
			this.SetResourceInfo("02a31493-74d4-4672-9fcc-b92e318fdbb5");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private XMJLBOMChangeUIModelModel(bool isInit) : base("XMJLBOMChangeUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new XMJLBOMChangeUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private Cust_Xmjl_MO_BomChangeView viewCust_Xmjl_MO_BomChange;			
		private Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemView viewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem;			
		private Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoView viewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo;			
		#endregion
		
		#region links
		//private IUILink linkCust_Xmjl_MO_BomChange__Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem;			
		//private IUILink linkCust_Xmjl_MO_BomChange__Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo;			
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public Cust_Xmjl_MO_BomChangeView Cust_Xmjl_MO_BomChange
		{
			get { return (Cust_Xmjl_MO_BomChangeView)this["Cust_Xmjl_MO_BomChange"]; }
		}
		public Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemView Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem
		{
			get { return (Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemView)this["Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem"]; }
		}
		public Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoView Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo
		{
			get { return (Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoView)this["Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewCust_Xmjl_MO_BomChange = new Cust_Xmjl_MO_BomChangeView(this);
			this.viewCust_Xmjl_MO_BomChange.SetResourceInfo("fc93e36b-ae0e-4320-b450-8c43f01a7c6c");
			this.Views.Add(this.viewCust_Xmjl_MO_BomChange);			
			this.viewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem = new Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemView(this);
			this.viewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.SetResourceInfo("9c1b4391-84a8-4f72-a742-15d66306961e");
			this.Views.Add(this.viewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem);			
			this.viewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo = new Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoView(this);
			this.viewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.SetResourceInfo("1e16cfe8-c216-4624-999b-73010d1dda1d");
			this.Views.Add(this.viewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo);			

			//this.linkCust_Xmjl_MO_BomChange__Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem
			{
			IUILink link = new UILink("Cust_Xmjl_MO_BomChange__Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem",this,this.viewCust_Xmjl_MO_BomChange.FieldID,this.viewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldCust_Xmjl_MO_BomChange,EnumAssociationKind.COMPOSITION,EnumAssociationDirection.Double,EnumCardinality.ONE,EnumCardinality.MORE,"Cust_Xmjl_MO_BomChangeItem");
			this.Links.Add(link);
			}
			//this.linkCust_Xmjl_MO_BomChange__Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.ChildKeyConstraint.UpdateRule = Rule.None;
			//this.linkCust_Xmjl_MO_BomChange__Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.ChildKeyConstraint.DeleteRule = Rule.None;
			//this.linkCust_Xmjl_MO_BomChange__Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.ChildKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
			//this.linkCust_Xmjl_MO_BomChange__Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo
			{
			IUILink link = new UILink("Cust_Xmjl_MO_BomChange__Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo",this,this.viewCust_Xmjl_MO_BomChange.FieldID,this.viewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldCust_Xmjl_MO_BomChange,EnumAssociationKind.COMPOSITION,EnumAssociationDirection.Double,EnumCardinality.ONE,EnumCardinality.MORE,"Cust_Xmjl_MO_BomChangeManufactureNo");
			this.Links.Add(link);
			}
			//this.linkCust_Xmjl_MO_BomChange__Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.ChildKeyConstraint.UpdateRule = Rule.None;
			//this.linkCust_Xmjl_MO_BomChange__Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.ChildKeyConstraint.DeleteRule = Rule.None;
			//this.linkCust_Xmjl_MO_BomChange__Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.ChildKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.XMJL.XMJLBOMChangeUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class Cust_Xmjl_MO_BomChangeView : UIView
	{
		#region Constructor
		public Cust_Xmjl_MO_BomChangeView(IUIModel model) : base(model,"Cust_Xmjl_MO_BomChange","UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private Cust_Xmjl_MO_BomChangeView():base(null,"Cust_Xmjl_MO_BomChange","UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new Cust_Xmjl_MO_BomChangeView();
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
		public IUIField FieldChangeReason
		{
			get { return this.Fields["ChangeReason"]; }
		}
		public IUIField FieldChangeStat
		{
			get { return this.Fields["ChangeStat"]; }
		}
		public IUIField FieldChangeDocType
		{
			get { return this.Fields["ChangeDocType"]; }
		}
		public IUIField FieldChangeDocType_Code
		{
			get { return this.Fields["ChangeDocType_Code"]; }
		}
		public IUIField FieldChangeDocType_Name
		{
			get { return this.Fields["ChangeDocType_Name"]; }
		}
		public IUIField FieldChangeDateTime
		{
			get { return this.Fields["ChangeDateTime"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public Cust_Xmjl_MO_BomChangeDefaultFilterFilter DefaultFilter
		{
			get { return (Cust_Xmjl_MO_BomChangeDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","275a6a00-8e03-4ee4-8e27-7a32d6d815d0");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","6362953a-3a26-4f83-a5ad-daf8fb0ada7b");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","34267d14-d01a-439a-843d-acc4486bd7bd");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","b0a797a9-9457-42fc-8330-3572afe1df17");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a45fb422-220a-4019-9010-d95abc901f83");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","1c79f00f-b57d-48ce-a102-bb134df5a5e8");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), false,"","UFIDA.U9.Base.Organization.Organization", "Org", true,true, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","dd56a5f2-5388-4dc0-876e-1ed395c1af4f");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), false,"","System.String", "Org.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","aff84131-d8ae-4ede-96c1-720ed06f10a2");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "Org.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ff0e58c6-1655-4b28-8426-5826657e324c");
			UIModelRuntimeFactory.AddNewUIField(this,"DocNo", typeof(String), false,"","System.String", "DocNo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e2b6eecb-855b-4fbf-b210-2739039dae9f");
			UIModelRuntimeFactory.AddNewUIField(this,"BusinessDate", typeof(DateTime), false,"","System.Date", "BusinessDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","240ead7d-f4b1-489a-acf0-af883a69a5ff");
			UIModelRuntimeFactory.AddNewUIField(this,"Version", typeof(Int32), true,"0","System.Int32", "Version", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","3f572549-926c-462d-95de-d042a33dc885");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintAmount", typeof(Int32), true,"0","System.Int32", "PrintAmount", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","9c0726c5-cde6-4cf4-8905-e8ce493b6495");
			UIModelRuntimeFactory.AddNewUIField(this,"LatestPrintedDate", typeof(DateTime), true,"","System.DateTime", "LatestPrintedDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","920e968b-c062-4261-bcaf-10a97c756f3a");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_Canceled", typeof(Boolean), true,"false","System.Boolean", "Cancel.Canceled", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","b87fd251-7ddd-4769-9be2-150f5a499e94");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelDate", typeof(DateTime), true,"","System.DateTime", "Cancel.CancelDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","23bddc11-3881-4477-8ca2-4041cb1a9f6e");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelReason", typeof(String), true,"","System.String", "Cancel.CancelReason", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b3bceeaf-8622-4206-a4b9-0ddb7419ce55");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelUser", typeof(String), true,"","System.String", "Cancel.CancelUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","27edd394-aa52-4d40-b2a6-df6e712c674d");
			UIModelRuntimeFactory.AddNewUIField(this,"WorkFlowID", typeof(Guid), true,"","System.Guid", "WorkFlowID", true,true, false, "",false,(UIFieldType)1,"2b057235-c58e-441e-9477-5e52fcb7f95b","8c3de6f8-4d40-4f18-9e4f-7590a4b01d0d");
			UIModelRuntimeFactory.AddNewUIField(this,"StateMachineID", typeof(Guid), true,"","System.Guid", "StateMachineID", true,true, false, "",false,(UIFieldType)1,"2b057235-c58e-441e-9477-5e52fcb7f95b","39c3b051-6d92-4b4c-847a-ad6879d6189f");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason", typeof(Int64), true,"","UFIDA.U9.Base.HoldRelease.HoldReason", "HoldReason", true,true, false, "",false,(UIFieldType)4,"aca6401c-cd2c-460c-9883-a704f9ea93a6","f5b90b6b-08a4-4d73-8e89-4f67b0f63afb");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason_Code", typeof(String), false,"","System.String", "HoldReason.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","904803c1-bae1-44b9-8c3b-98662efaf35a");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason_Name", typeof(String), true,"","System.String", "HoldReason.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bfb3f0c7-3177-40d6-8b6c-a16a43249b65");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldUser", typeof(String), true,"","System.String", "HoldUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4760c512-fe0d-4c99-9be7-57178ceec458");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldDate", typeof(DateTime), true,"","System.DateTime", "HoldDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","05b5c940-9ac2-432c-b9fd-5f408d06a833");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason", typeof(Int64), true,"","UFIDA.U9.Base.HoldRelease.ReleaseReason", "ReleaseReason", true,true, false, "",false,(UIFieldType)4,"8f4c20a0-ea48-4e30-a76a-1f8d38bcc7cc","b4e6bfd4-b317-49cb-9e9d-f39514aa86c3");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason_Code", typeof(String), false,"","System.String", "ReleaseReason.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","99c97caf-36fb-4aff-b65f-c1dbd76e17b0");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason_Name", typeof(String), true,"","System.String", "ReleaseReason.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5dfbc66a-e9db-4541-9467-904ef0762608");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseUser", typeof(String), true,"","System.String", "ReleaseUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0b69b061-dd12-4685-9537-bdaddebe0e6d");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseDate", typeof(DateTime), true,"","System.DateTime", "ReleaseDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","d15e647f-a669-4ef7-93b3-0b99dcd0b8d0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7b1bff52-f6a6-429c-9284-524c972f3c2a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f4cf2275-c9d1-4c0c-a904-09fc792cec4c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d9a1e7cf-d7e2-4629-a0b1-5e3adb62f51b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","aa8af109-54bf-4348-aa90-f56d4d390cbf");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ce819615-5645-44a5-abc4-fbf6a8459800");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","da577547-800c-494e-ae9c-3ed9d082479e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ee36eef4-632e-4201-b600-2ca4e7e1e81b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b0b2fe32-ef53-4cbf-80bf-48ec6431c484");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ad30ec30-2592-4474-8c5b-6ea08f368ec9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8291801e-7e17-456f-95af-cd6307cd3edb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b41969bb-5f0f-46d1-83fe-a8f8558b8ace");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2d1b374c-4167-4173-b58e-f59d16e7239a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e2f04b54-3f0c-4090-a5ee-9b838aa3b64d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2f04339c-8554-4e16-b722-4165e56c9b35");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","29321aa4-25a9-49aa-a602-3be14c400825");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2ef3e125-300e-4ab5-8eaf-4186d1c36ed4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fcabd519-9c06-486c-accd-740f8b653351");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","329ec94e-aa10-417e-9152-7dbd4a3f1307");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e1493362-676a-4671-814f-3c529d1cfcc6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2dbc0cf2-52aa-4811-9bf0-47584623d15c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4c761b22-cd39-42db-9ab5-871763293cab");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","53fb5537-4bdc-4de7-b7af-5d1a7c63a6bb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","71670684-ebd5-4836-a054-943c9fe4f646");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","13e15d87-cf38-44aa-9f93-6141b73669ee");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bbbaf62f-b30c-4577-937e-6b58dadf38a6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e77f17d9-d003-486b-b913-13a0f5709761");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","063048a4-7b4b-479d-8cdc-f8696df36db4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","91404281-d15c-41e8-9185-45024cf204f8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ba234ff7-05e8-4373-bd89-3ea3edfcac56");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","19148a09-04b8-40ea-833d-09a3079e90b4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg31", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3fa99b48-b6b0-4e25-b7e0-b7f7305e23c7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg32", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e7e973ab-a5ec-420c-914d-9f706074e66b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg33", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","43cccf8d-3774-487b-a086-7e078263fed1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg34", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6452922e-b35e-4fd8-b898-4a85b2fe3bac");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg35", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6812b75d-4426-4b5a-bc80-618fc9ce2a2e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg36", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d602cb74-93a8-4239-8e05-bea41bffc670");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg37", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4714c1f4-9e0d-41e4-8dd8-c3c29c359394");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg38", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2904432f-b8c0-4391-9c13-7e455ad1cf3b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg39", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e15c4fe5-a357-40cd-9786-bd8281f2c979");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg40", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f76c1da8-ebf6-4f05-ad78-6d2f4951f1d0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg41", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","99d1aea2-12f2-4f1f-a2b7-e21b937bffb8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg42", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","733560a8-bb8d-40cd-94ce-7831b725e272");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg43", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dc72ea98-1ce2-42de-a744-9c30f28eed5b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg44", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f187ee1b-77b5-417f-9162-38a88c03ca8c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg45", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a6050687-e887-4f05-a061-7effbda0ef60");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg46", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4d7de5da-de40-4fcd-a556-3b72d5620754");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg47", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5257ed02-994e-403a-a430-b0cd1a86c4ff");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg48", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a183d1ef-f8af-4506-a132-7bd2b629dd6f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg49", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","eff70f96-8a09-4ff6-a5a8-fafcdb567bda");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg50", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c3f18dcd-5ef4-4f8e-94c3-382d919695dc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_ContextValue", typeof(String), true,"","System.String", "DescFlexField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ef76495c-6b10-4599-a51d-aede905f1aad");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c278e864-aad1-49b1-9220-6ba3bf29d356");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7d147f75-07e6-4915-b814-68d87088cc27");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","852c0a32-f1c5-48e8-b357-e019ecb19927");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","734cb8ba-59a1-4fe8-a08e-698c52b15972");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f0e91660-5a7d-4b1b-9480-159219f24d10");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8b3cf934-016f-4a8c-82d3-5b7f4111b9bf");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","710e3fef-1d00-4100-a152-116d387f7ccd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d37de865-369d-416e-9e2d-d8787ca90fc9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7eb9043b-67c1-48b2-8d22-9b92c25890e4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a4a1fab1-87a4-4838-9315-5e92a61d71d6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ad3d2fab-5650-4571-8ff9-25b5a35c96ec");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","afec2f36-92e4-41ed-80dd-f9480e5845a6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","65ea4063-0061-41db-8241-c93e186655b7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dc114014-def7-4e56-93bd-f6f850c69002");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","04a12c8c-fd14-4683-a82e-45611e8a4c87");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a8428f5b-d8a3-4c7e-ae1b-b1c2868d632e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","005b7e5c-b5cb-4675-bb57-0f48922d93a2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e3cead37-e3a7-4603-ace2-349738af0e25");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cbc3beb4-2966-4b17-91a1-ad0532357952");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5e2c97ad-60af-4b32-a69f-f28abf42c401");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b5946f4e-303e-4ea5-a3b5-5ab6dc0bb338");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","671afcc2-6c9c-43e4-b02d-8e06c19bc659");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f3bfd8d1-cae6-4dbb-99bc-85e49241b843");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a84e6979-15ad-4344-b8f5-e8ab4d2d3805");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0217d6aa-2dcb-48c1-b141-40c0b73c26a4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","aac45b66-4f4d-498a-a521-7b7256ac6c40");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4470af5b-2d68-474e-b2d4-f4760ec33007");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dd748635-2f50-4770-b2d4-e46320caa637");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","05db1c36-8b9d-4063-8eb0-452222da6692");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","02e20f38-e0da-4aac-bf17-c009d5274deb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_CombineName", typeof(String), true,"","System.String", "DescFlexField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","196d9712-d9be-4585-8567-d0ec4547ed1c");
			UIModelRuntimeFactory.AddNewUIField(this,"FlowInstance", typeof(Int64), true,"","UFIDA.U9.CS.Workflow.WorkflowInstanceBE.FlowInstance", "FlowInstance", true,true, false, "",false,(UIFieldType)4,"d87a7006-6643-42f4-98f4-168847a71955","9724e78e-4ad3-46ed-b950-f0ce7fdedee7");
			UIModelRuntimeFactory.AddNewUIField(this,"ChangeReason", typeof(String), true,"","System.String", "ChangeReason", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","969a8dba-7941-4bc3-b9ba-a70635664526");
			UIModelRuntimeFactory.AddNewUIField(this,"ChangeStat", typeof(Boolean), true,"false","System.Boolean", "ChangeStat", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","af0c8284-6abb-4e49-aa84-432d49d0cabc");
			UIModelRuntimeFactory.AddNewUIField(this,"ChangeDocType", typeof(Int64), true,"","UFIDA.U9.Cust.XMJL.DocumentTypeBE.Cust_Xmjl_DocumentType", "ChangeDocType", true,true, false, "",false,(UIFieldType)4,"3ffb14f6-f9dd-4fb4-9e83-5cfab77cf9a1","9cfb99e2-40ea-4e73-bc60-20253b55fda1");
			UIModelRuntimeFactory.AddNewUIField(this,"ChangeDocType_Code", typeof(String), false,"","System.String", "ChangeDocType.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5dfdbde0-2482-426f-8181-1b2538063209");
			UIModelRuntimeFactory.AddNewUIField(this,"ChangeDocType_Name", typeof(String), true,"","System.String", "ChangeDocType.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e1720660-350a-4708-9b8c-48ffbbb3d9c8");
			UIModelRuntimeFactory.AddNewUIField(this,"ChangeDateTime", typeof(DateTime), true,"","System.DateTime", "ChangeDateTime", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","f2f5d828-8f64-4717-a3e0-fcf6efe905a6");


			this.CurrentFilter = new Cust_Xmjl_MO_BomChangeDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new Cust_Xmjl_MO_BomChangeRecord(builder);
		}
		#endregion

		#region new method
		public new Cust_Xmjl_MO_BomChangeRecord FocusedRecord
		{
			get { return (Cust_Xmjl_MO_BomChangeRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new Cust_Xmjl_MO_BomChangeRecord AddNewUIRecord()
		{	
			return (Cust_Xmjl_MO_BomChangeRecord)base.AddNewUIRecord();
		}
		public new Cust_Xmjl_MO_BomChangeRecord NewUIRecord()
		{	
			return (Cust_Xmjl_MO_BomChangeRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class Cust_Xmjl_MO_BomChangeRecord : UIRecord
	{
		#region Constructor
		public Cust_Xmjl_MO_BomChangeRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private Cust_Xmjl_MO_BomChangeView uiviewCust_Xmjl_MO_BomChange
		{
			get { return (Cust_Xmjl_MO_BomChangeView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new Cust_Xmjl_MO_BomChangeRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCust_Xmjl_MO_BomChange.FieldID);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomChange.FieldCreatedOn);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldCreatedBy);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomChange.FieldModifiedOn);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldModifiedBy);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomChange.FieldSysVersion);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64 Org
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldOrg] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCust_Xmjl_MO_BomChange.FieldOrg);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldOrg] = value;
			}
		}
		
		
		public  String Org_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldOrg_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldOrg_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldOrg_Code] = value;
			}
		}
		
		
		public  String Org_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldOrg_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldOrg_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldOrg_Name] = value;
			}
		}
		
		
		public  String DocNo
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDocNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDocNo);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDocNo] = value;
			}
		}
		
		
		public  DateTime BusinessDate
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldBusinessDate] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewCust_Xmjl_MO_BomChange.FieldBusinessDate);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldBusinessDate] = value;
			}
		}
		
		
		public  Int32? Version
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldVersion] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCust_Xmjl_MO_BomChange.FieldVersion);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldVersion] = value;
			}
		}
		
		
		public  Int32? PrintAmount
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldPrintAmount] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCust_Xmjl_MO_BomChange.FieldPrintAmount);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldPrintAmount] = value;
			}
		}
		
		
		public  DateTime? LatestPrintedDate
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldLatestPrintedDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomChange.FieldLatestPrintedDate);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldLatestPrintedDate] = value;
			}
		}
		
		
		public  Boolean? Cancel_Canceled
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldCancel_Canceled] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewCust_Xmjl_MO_BomChange.FieldCancel_Canceled);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldCancel_Canceled] = value;
			}
		}
		
		
		public  DateTime? Cancel_CancelDate
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldCancel_CancelDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomChange.FieldCancel_CancelDate);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldCancel_CancelDate] = value;
			}
		}
		
		
		public  String Cancel_CancelReason
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldCancel_CancelReason] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldCancel_CancelReason);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldCancel_CancelReason] = value;
			}
		}
		
		
		public  String Cancel_CancelUser
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldCancel_CancelUser] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldCancel_CancelUser);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldCancel_CancelUser] = value;
			}
		}
		
		
		public  Guid WorkFlowID
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldWorkFlowID] ;
				//return (Guid)value;
				return GetValue<Guid>(this.uiviewCust_Xmjl_MO_BomChange.FieldWorkFlowID);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldWorkFlowID] = value;
			}
		}
		
		
		public  Guid StateMachineID
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldStateMachineID] ;
				//return (Guid)value;
				return GetValue<Guid>(this.uiviewCust_Xmjl_MO_BomChange.FieldStateMachineID);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldStateMachineID] = value;
			}
		}
		
		
		public  Int64? HoldReason
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldHoldReason] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomChange.FieldHoldReason);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldHoldReason] = value;
			}
		}
		
		
		public  String HoldReason_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldHoldReason_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldHoldReason_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldHoldReason_Code] = value;
			}
		}
		
		
		public  String HoldReason_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldHoldReason_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldHoldReason_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldHoldReason_Name] = value;
			}
		}
		
		
		public  String HoldUser
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldHoldUser] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldHoldUser);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldHoldUser] = value;
			}
		}
		
		
		public  DateTime? HoldDate
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldHoldDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomChange.FieldHoldDate);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldHoldDate] = value;
			}
		}
		
		
		public  Int64? ReleaseReason
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldReleaseReason] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomChange.FieldReleaseReason);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldReleaseReason] = value;
			}
		}
		
		
		public  String ReleaseReason_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldReleaseReason_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldReleaseReason_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldReleaseReason_Code] = value;
			}
		}
		
		
		public  String ReleaseReason_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldReleaseReason_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldReleaseReason_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldReleaseReason_Name] = value;
			}
		}
		
		
		public  String ReleaseUser
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldReleaseUser] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldReleaseUser);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldReleaseUser] = value;
			}
		}
		
		
		public  DateTime? ReleaseDate
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldReleaseDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomChange.FieldReleaseDate);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldReleaseDate] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg1
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg1);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg2
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg2);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg3
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg3);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg4
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg4);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg5
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg5);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg6
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg6);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg7
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg7);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg8
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg8);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg9
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg9);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg10
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg10);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg11
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg11);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg12
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg12);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg13
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg13);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg14
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg14);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg15
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg15);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg16
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg16);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg17
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg17);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg18
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg18);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg19
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg19);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg20
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg20);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg21
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg21);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg22
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg22);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg23
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg23);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg24
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg24);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg25
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg25);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg26
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg26);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg27
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg27);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg28
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg28);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg29
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg29);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg30
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg30);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg31
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg31] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg31);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg31] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg32
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg32] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg32);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg32] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg33
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg33] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg33);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg33] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg34
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg34] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg34);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg34] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg35
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg35] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg35);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg35] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg36
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg36] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg36);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg36] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg37
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg37] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg37);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg37] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg38
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg38] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg38);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg38] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg39
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg39] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg39);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg39] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg40
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg40] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg40);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg40] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg41
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg41] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg41);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg41] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg42
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg42] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg42);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg42] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg43
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg43] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg43);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg43] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg44
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg44] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg44);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg44] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg45
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg45] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg45);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg45] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg46
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg46] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg46);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg46] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg47
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg47] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg47);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg47] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg48
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg48] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg48);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg48] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg49
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg49] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg49);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg49] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg50
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg50] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg50);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PubDescSeg50] = value;
			}
		}
		
		
		public  String DescFlexField_ContextValue
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_ContextValue] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_ContextValue);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_ContextValue] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg1);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg2
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg2);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg3
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg3);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg4
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg4);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg5
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg5);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg6
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg6);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg7
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg7);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg8
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg8);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg9
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg9);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg10
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg10);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg11
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg11);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg12
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg12);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg13
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg13);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg14
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg14);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg15
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg15);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg16
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg16);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg17
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg17);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg18
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg18);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg19
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg19);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg20
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg20);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg21
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg21);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg22
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg22);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg23
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg23);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg24
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg24);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg25
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg25);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg26
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg26);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg27
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg27);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg28
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg28);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg29
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg29);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg30);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_PrivateDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_CombineName
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_CombineName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_CombineName);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldDescFlexField_CombineName] = value;
			}
		}
		
		
		public  Int64? FlowInstance
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldFlowInstance] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomChange.FieldFlowInstance);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldFlowInstance] = value;
			}
		}
		
		
		public  String ChangeReason
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldChangeReason] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldChangeReason);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldChangeReason] = value;
			}
		}
		
		
		public  Boolean? ChangeStat
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldChangeStat] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewCust_Xmjl_MO_BomChange.FieldChangeStat);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldChangeStat] = value;
			}
		}
		
		
		public  Int64? ChangeDocType
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldChangeDocType] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomChange.FieldChangeDocType);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldChangeDocType] = value;
			}
		}
		
		
		public  String ChangeDocType_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldChangeDocType_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldChangeDocType_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldChangeDocType_Code] = value;
			}
		}
		
		
		public  String ChangeDocType_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldChangeDocType_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange.FieldChangeDocType_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldChangeDocType_Name] = value;
			}
		}
		
		
		public  DateTime? ChangeDateTime
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldChangeDateTime] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomChange.FieldChangeDateTime);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldChangeDateTime] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class Cust_Xmjl_MO_BomChangeDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public Cust_Xmjl_MO_BomChangeDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private Cust_Xmjl_MO_BomChangeDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new Cust_Xmjl_MO_BomChangeDefaultFilterFilter();
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
	public partial class Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemView : UIView
	{
		#region Constructor
		public Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemView(IUIModel model) : base(model,"Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem","UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItem", false)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemView():base(null,"Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem","UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItem", false)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemView();
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
		public IUIField FieldCust_Xmjl_MO_BomChange
		{
			get { return this.Fields["Cust_Xmjl_MO_BomChange"]; }
		}
		public IUIField FieldItem
		{
			get { return this.Fields["Item"]; }
		}
		public IUIField FieldItem_Code
		{
			get { return this.Fields["Item_Code"]; }
		}
		public IUIField FieldItem_Name
		{
			get { return this.Fields["Item_Name"]; }
		}
		public IUIField FieldSupplier
		{
			get { return this.Fields["Supplier"]; }
		}
		public IUIField FieldSupplier_Code
		{
			get { return this.Fields["Supplier_Code"]; }
		}
		public IUIField FieldSupplier_Name
		{
			get { return this.Fields["Supplier_Name"]; }
		}
		public IUIField FieldRowNo
		{
			get { return this.Fields["RowNo"]; }
		}
		public IUIField FieldWorkPlace
		{
			get { return this.Fields["WorkPlace"]; }
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
		public IUIField FieldDistQty
		{
			get { return this.Fields["DistQty"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemDefaultFilterFilter DefaultFilter
		{
			get { return (Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","b8313d09-55c1-4a23-880a-3b09fba8e384");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","22289e4b-c59a-47d0-bc76-726713bdbbb3");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","de1d934f-374c-498f-897a-4488872bc1b0");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","9610632b-8827-4f74-9b9a-6fbe772e9cd4");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bda59eae-b1e9-42cd-8aea-eb4b6962ef51");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","be673746-d419-4920-b90a-d966bd1c948d");
			UIModelRuntimeFactory.AddNewUIField(this,"Cust_Xmjl_MO_BomChange", typeof(Int64), true,"","UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange", "Cust_Xmjl_MO_BomChange", true,true, false, "",false,(UIFieldType)4,"0151a89d-9e77-45ad-b133-2aabca130cf5","7aa10c27-c07a-411f-935e-2fd198e9dc72");
			UIModelRuntimeFactory.AddNewUIField(this,"Item", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Item.ItemMaster", "Item", true,true, false, "",false,(UIFieldType)4,"636d3e47-48aa-47fc-aca4-e6322bce775b","ab49bb38-8d5f-41c8-8e4f-37ff076935d7");
			UIModelRuntimeFactory.AddNewUIField(this,"Item_Code", typeof(String), false,"","System.String", "Item.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a02014d6-e6ab-41de-b6ef-3296dc6eb267");
			UIModelRuntimeFactory.AddNewUIField(this,"Item_Name", typeof(String), false,"","System.String", "Item.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3312a94d-fcb8-467d-a3c7-0b85992c9570");
			UIModelRuntimeFactory.AddNewUIField(this,"Supplier", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Supplier.Supplier", "Supplier", true,true, false, "",false,(UIFieldType)4,"ac3510e5-3337-46d4-b41c-46ac40f343e1","0cc6c2d3-c688-4f47-aab7-82826c96f515");
			UIModelRuntimeFactory.AddNewUIField(this,"Supplier_Code", typeof(String), false,"","System.String", "Supplier.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a3e42084-a7ad-4395-8048-187470ed859d");
			UIModelRuntimeFactory.AddNewUIField(this,"Supplier_Name", typeof(String), true,"","System.String", "Supplier.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","83f560c4-6820-4798-a506-ac1cfb2ccc7a");
			UIModelRuntimeFactory.AddNewUIField(this,"RowNo", typeof(Int32), true,"0","System.Int32", "RowNo", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","b66ed4b3-776a-454d-87bd-c9bb9c7c0d28");
			UIModelRuntimeFactory.AddNewUIField(this,"WorkPlace", typeof(String), true,"","System.String", "WorkPlace", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4a7f1e97-b884-4d03-8462-f235f63dc9df");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6f2810a6-ecb0-45c7-bbb2-be0016ef80c2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1c47709c-d48b-43d7-857a-a21eccb717b3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1b4b967f-f26d-44b8-b3ea-72c25b3cbce1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","821474fe-b2bd-45fd-9262-a66774bfd640");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9eeba9ba-a442-4f76-a035-493cb31cf32f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c6ee2f35-62aa-4721-867b-6ec7d67d6b84");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","42237f09-9443-4749-862f-63640eff0241");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a6de4003-9290-44c3-917c-4208f06d4c13");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","12dd66fc-8339-4d66-ba64-236985dc047b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","34d84ebf-3c2a-4821-b924-73b9dcb7bdf5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","99fe5f41-dc47-4bcc-a231-a45ef9b03986");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a16f5619-4eab-46bc-af43-acde85f1491f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2cb0f2d9-9617-4668-b44c-36ae8663b5d3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6c2451ce-579d-4fa2-8fd8-2a33ea0c98c2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6d8afccf-9971-435f-8d6a-6203971a22bc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8427ca96-4588-4c22-a0bd-4aec7e9b463a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c09fda05-8759-4fcc-9e46-d2c743b373b4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","67bd1ef8-ec12-4c66-b865-f7b8433dbe3f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e0fe645c-5b9d-4287-8d34-6c3d55f9d17c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","aebe238b-f730-495d-9b17-3074c59cf6e1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7179acc1-a724-4738-ac30-9416a7af00da");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f2e0da3e-0958-4895-9ae8-6397457f64fb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","740f918f-1d7e-4fd1-9480-cd5da0ca03ff");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3c893ac1-c148-40cd-a39e-acba4e3ad59d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a46b7ba6-98a7-4821-bab4-eb5ec1e13825");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","28c2cafb-0399-4711-ad14-d68ec36194ac");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f66122c1-1ee8-44bd-a784-27944777ec51");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7a125991-c4a7-4742-87d7-b986d14730a4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2d048539-fd74-49ec-afd2-667645921128");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cd35e1a2-6f8b-45b2-9af5-8b18fb025880");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg31", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","59468364-d6a5-4d1a-a6da-4ae201fb7bee");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg32", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0773aba5-6a8c-4821-81a8-ec2da0218ab7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg33", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cf7cb92f-33f5-4afa-a74f-15a9ce07a9e7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg34", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b01a5f6e-be75-4a45-a928-c69dd8086403");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg35", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ef407555-e56e-414a-a83a-d9b400f16147");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg36", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a32b0d76-e2f6-4f1a-93e4-d06aff8756f0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg37", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","53050a1b-e30f-48b8-bea5-0be9c997e6a7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg38", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cbb75f8b-01c1-4e80-9375-0d4eb72b7692");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg39", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0e1bc5eb-ccfe-48b6-8eea-f68c8e156b23");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg40", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","256a827e-da4f-43ea-ae40-74f13f569076");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg41", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d14fa8e5-6d05-4c68-9803-e7c2c4dbc838");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg42", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2a76b028-5b0e-495c-ab79-27c54d8ed625");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg43", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","740a07fd-1567-43ee-b00b-7c14bae1dae6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg44", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9602df42-0996-4579-8001-1c7db5626d57");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg45", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0b690ba2-4605-4ec1-9de4-400363cab948");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg46", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6152f79a-5978-41af-8d3d-6724ec17930d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg47", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5154e217-610b-4218-a964-bd1bedca4776");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg48", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5bda5f37-dc1c-48f0-b92d-e0b7908aa31a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg49", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","52238ef1-7dfe-4333-b709-c7f3a67848f2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg50", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","41094758-cc0d-4cd7-8d44-5fe795605d49");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_ContextValue", typeof(String), true,"","System.String", "DescFlexField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","955e8053-666f-4b4b-b394-dd364379d4f0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e6f05f10-76e8-489a-b214-ef094ebe0047");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b2d9ea5d-86eb-4b74-b677-ebb0f67e07fb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c76141cb-81fb-4db2-a068-5ec60774eecb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4573e2e3-d254-4625-a14f-1622977d5016");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","31cb2328-5024-42f1-843b-e5070ae70d6c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f3bc952b-70da-4f19-bbdc-53d15a6fb598");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","431cf9a2-1008-4359-a0b9-533232e482c9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cc5c547f-b8fb-4c9c-b922-c041e5efaf87");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1f1f7d99-bd8e-4c3c-a94b-027987e40800");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d261698a-1ad8-4de3-a737-6e98cf751c45");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cba24ad7-f342-494d-8708-d261ef25fbb7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a72431ba-6bd8-401c-b9b6-bbb4e7309081");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4b22d21e-ac6c-4dbe-b3d4-f0233570416a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fb7f0dbd-6a52-416d-bbbd-fb8105665bcc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b88b650c-f1ca-4617-a5ef-c49974576688");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4940ed7e-9e91-4709-9c63-69cc499a6391");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ec26a9a5-4502-4c3e-8728-f28297538e35");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","429c14d2-e577-410c-9615-b9ac856481c9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","abe19538-393e-400b-a610-03dc139c1c9a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","18687027-7ebd-4f75-a609-06a8723fb36e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e2f39d68-d910-4552-87e8-4d0b34094d14");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bfc6011a-fe6e-4000-b71a-f0469755b0c4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","65ae8924-4993-44ac-97e0-14086166548b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b25d9426-5224-4591-9e76-66ac37fc0a46");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ec733464-4cb8-4755-8b65-f4c25cba437a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a7e84256-af64-43f0-8d2b-fe47eb7cf83d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","62680fbf-70b9-42fa-881a-279cd000f19b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5aafcd7f-e791-4f4a-99f8-c386d01fd7d8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e08c5936-f11b-4ae9-9067-d670d5b63d69");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0d568123-6b42-4b7d-813c-9c820e6ef7ce");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_CombineName", typeof(String), true,"","System.String", "DescFlexField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5dbe4467-a3bc-49d6-a882-e4d697ae2caf");
			UIModelRuntimeFactory.AddNewUIField(this,"DistQty", typeof(Decimal), true,"0","System.Decimal", "DistQty", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","33db4024-f660-451a-881b-d61f5b71caac");


			this.CurrentFilter = new Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemRecord(builder);
		}
		#endregion

		#region new method
		public new Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemRecord FocusedRecord
		{
			get { return (Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemRecord AddNewUIRecord()
		{	
			return (Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemRecord)base.AddNewUIRecord();
		}
		public new Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemRecord NewUIRecord()
		{	
			return (Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemRecord : UIRecord
	{
		#region Constructor
		public Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemView uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem
		{
			get { return (Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldID);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldCreatedOn);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldCreatedBy);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldModifiedOn);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldModifiedBy);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldSysVersion);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? Cust_Xmjl_MO_BomChange
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldCust_Xmjl_MO_BomChange] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldCust_Xmjl_MO_BomChange);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldCust_Xmjl_MO_BomChange] = value;
			}
		}
		
		
		public  Int64? Item
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldItem] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldItem);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldItem] = value;
			}
		}
		
		
		public  String Item_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldItem_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldItem_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldItem_Code] = value;
			}
		}
		
		
		public  String Item_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldItem_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldItem_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldItem_Name] = value;
			}
		}
		
		
		public  Int64? Supplier
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldSupplier] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldSupplier);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldSupplier] = value;
			}
		}
		
		
		public  String Supplier_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldSupplier_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldSupplier_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldSupplier_Code] = value;
			}
		}
		
		
		public  String Supplier_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldSupplier_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldSupplier_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldSupplier_Name] = value;
			}
		}
		
		
		public  Int32? RowNo
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldRowNo] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldRowNo);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldRowNo] = value;
			}
		}
		
		
		public  String WorkPlace
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldWorkPlace] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldWorkPlace);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldWorkPlace] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg1
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg1);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg2
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg2);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg3
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg3);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg4
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg4);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg5
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg5);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg6
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg6);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg7
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg7);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg8
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg8);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg9
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg9);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg10
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg10);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg11
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg11);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg12
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg12);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg13
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg13);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg14
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg14);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg15
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg15);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg16
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg16);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg17
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg17);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg18
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg18);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg19
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg19);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg20
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg20);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg21
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg21);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg22
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg22);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg23
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg23);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg24
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg24);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg25
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg25);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg26
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg26);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg27
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg27);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg28
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg28);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg29
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg29);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg30
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg30);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg31
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg31] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg31);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg31] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg32
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg32] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg32);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg32] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg33
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg33] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg33);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg33] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg34
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg34] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg34);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg34] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg35
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg35] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg35);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg35] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg36
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg36] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg36);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg36] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg37
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg37] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg37);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg37] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg38
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg38] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg38);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg38] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg39
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg39] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg39);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg39] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg40
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg40] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg40);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg40] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg41
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg41] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg41);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg41] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg42
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg42] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg42);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg42] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg43
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg43] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg43);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg43] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg44
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg44] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg44);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg44] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg45
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg45] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg45);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg45] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg46
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg46] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg46);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg46] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg47
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg47] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg47);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg47] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg48
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg48] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg48);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg48] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg49
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg49] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg49);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg49] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg50
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg50] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg50);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PubDescSeg50] = value;
			}
		}
		
		
		public  String DescFlexField_ContextValue
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_ContextValue] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_ContextValue);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_ContextValue] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg1);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg2
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg2);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg3
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg3);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg4
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg4);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg5
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg5);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg6
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg6);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg7
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg7);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg8
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg8);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg9
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg9);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg10
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg10);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg11
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg11);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg12
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg12);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg13
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg13);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg14
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg14);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg15
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg15);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg16
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg16);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg17
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg17);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg18
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg18);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg19
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg19);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg20
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg20);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg21
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg21);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg22
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg22);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg23
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg23);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg24
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg24);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg25
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg25);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg26
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg26);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg27
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg27);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg28
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg28);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg29
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg29);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg30);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_PrivateDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_CombineName
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_CombineName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_CombineName);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDescFlexField_CombineName] = value;
			}
		}
		
		
		public  Decimal? DistQty
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDistQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDistQty);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FieldDistQty] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemDefaultFilterFilter();
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
	public partial class Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoView : UIView
	{
		#region Constructor
		public Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoView(IUIModel model) : base(model,"Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo","UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNo", false)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoView():base(null,"Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo","UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNo", false)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoView();
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
		public IUIField FieldCust_Xmjl_MO_BomChange
		{
			get { return this.Fields["Cust_Xmjl_MO_BomChange"]; }
		}
		public IUIField FieldManufactureNO
		{
			get { return this.Fields["ManufactureNO"]; }
		}
		public IUIField FieldManufactureNO_Code
		{
			get { return this.Fields["ManufactureNO_Code"]; }
		}
		public IUIField FieldManufactureNO_Name
		{
			get { return this.Fields["ManufactureNO_Name"]; }
		}
		public IUIField FieldContractNo
		{
			get { return this.Fields["ContractNo"]; }
		}
		public IUIField FieldCarType
		{
			get { return this.Fields["CarType"]; }
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


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoDefaultFilterFilter DefaultFilter
		{
			get { return (Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","c0ca8e0a-85a4-49ba-b28c-a1eabc697dd9");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","7c08624f-65c2-4e54-873b-083ca78dfb1c");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","25b3b8fb-986a-4b81-a168-9d302dfb0913");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","c2c783b0-bf1f-45f3-926e-f71a4a6054ee");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","60e4f72e-636a-4092-8bc5-c9287f4c2003");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","a5f74d26-5484-4230-be8a-6198d2760d8b");
			UIModelRuntimeFactory.AddNewUIField(this,"Cust_Xmjl_MO_BomChange", typeof(Int64), true,"","UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange", "Cust_Xmjl_MO_BomChange", true,true, false, "",false,(UIFieldType)4,"0151a89d-9e77-45ad-b133-2aabca130cf5","d51a6447-1fde-42e5-bea9-ec744e2dc670");
			UIModelRuntimeFactory.AddNewUIField(this,"ManufactureNO", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.ProjectTask.Project", "ManufactureNO", true,true, false, "",false,(UIFieldType)4,"7bc6294b-1a35-4e37-acfe-5abc5602f12f","520a8465-f382-479b-95c7-534e084b7180");
			UIModelRuntimeFactory.AddNewUIField(this,"ManufactureNO_Code", typeof(String), false,"","System.String", "ManufactureNO.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","021cd7ba-435d-4350-9568-9c2ac5be125e");
			UIModelRuntimeFactory.AddNewUIField(this,"ManufactureNO_Name", typeof(String), true,"","System.String", "ManufactureNO.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fc690ff4-16c1-4c81-bfcd-ccbc3674299d");
			UIModelRuntimeFactory.AddNewUIField(this,"ContractNo", typeof(String), true,"","System.String", "ContractNo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c05e2afc-762c-4da8-8f17-77e75c06d0ec");
			UIModelRuntimeFactory.AddNewUIField(this,"CarType", typeof(String), true,"","System.String", "CarType", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","78071efa-5804-411a-b3da-bdc06773feac");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dccef6a9-cadf-4188-9960-f2a6934f5991");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d5d54055-0106-47b1-89ca-2d3711929257");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fb334e25-ce37-4024-bb71-db908c1707b5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","caa73fb0-388f-49ff-955b-e23a946defaa");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f16afb7a-c8a9-49ed-99da-b2dba0b03665");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9256891c-064b-4850-b98b-15336ad57af5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bd197ea6-8f45-4c1e-b334-a10c512a4d19");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1399ff33-7f44-4ab4-a5f1-2611a8a062dc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","95c6b767-db12-40b8-92ee-9424e5db7121");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","919202d5-9593-40ba-8b0a-6fd6f0742545");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","459a5523-a102-4f7c-a43d-242a6fd99883");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","57a1705f-1c15-47df-94ea-d6ba1431101a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","169338a7-a8b8-455f-83b9-a26d40fef46c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","373b9bf8-9858-4790-a7da-881024cc44ed");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","013c5f25-750d-4a9a-8cbf-735fe12146de");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","faf41601-21dd-4ae0-85b7-710e07fc6915");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","34c90cc1-6d9d-4901-8ac9-f201a1e14768");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ea801fd3-7bb8-4329-9255-70372fd30a14");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f531651f-6850-4b8c-b385-750e431836f6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2f962c81-5716-4a33-a7b3-ebb52ede5d37");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0e71e6fd-47d5-4db2-a356-9fd4353d1d84");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2efabe81-3f03-45b3-8db7-6b17f88569b3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3ad4edfc-b2e9-4324-9e8d-e505e1373fae");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","33dc4b4e-0d55-49d2-bbde-6b1ce56791e9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7eb5056d-5989-46bc-9e49-daeae0a35269");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7259738e-b4bd-47b4-a34a-db80f68b9a77");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6b1a101e-6105-4e1a-b2d8-5a0e2b94fd35");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8055fe73-5d15-4656-9751-85ee8348fd22");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9abf1c4a-8b5c-4573-b5ad-0edd2dc7aefb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3cde1b16-978e-45d6-aaf6-bc58a409db52");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg31", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f5e9c00b-0056-4a5b-a1d3-cacfafee3288");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg32", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","44f98460-2763-43de-8caa-513eb4d0e744");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg33", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2627bc7d-163d-4ef8-bdbb-f18dcd92b1c9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg34", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","62399c29-a16d-4e2f-ac6b-7a545a5ea2cc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg35", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","438de96e-bf97-48ce-b916-236e7e71fdfc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg36", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bca856b3-c5ec-4bd8-9dd4-d1f4360a2c0e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg37", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4a5581b5-b874-4361-8a12-5870a1b27e25");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg38", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d5c4cc48-1e63-42b4-814b-952871a59b3d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg39", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f1d7035a-bd60-4a2b-a124-0f07e74127dd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg40", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f39f8f37-9f1d-4cb2-805f-453dd1be60f1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg41", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","451d820f-6f6f-4ff4-80fc-ab576902d88e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg42", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c37c27ca-6bfb-4764-867a-710c03b5f62e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg43", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a1157178-be0e-423a-a6e8-1e74f431ca4d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg44", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","41a67cca-1d35-4080-9286-da33dc9cf5ee");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg45", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e91ade17-9977-45a8-bdfa-f477035e6064");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg46", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5cd42a43-6780-43c2-ad72-d217994f4042");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg47", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a1e48094-6d64-41b4-a9e2-821d7df1ed99");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg48", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ff28d870-3f2b-4f00-b778-394037578dfb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg49", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d08f8745-c5e4-4cf1-ab7e-a7ab2a522bdd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg50", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e13f91fe-9c20-4d28-9366-1259df346e0b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_ContextValue", typeof(String), true,"","System.String", "DescFlexField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9b719cd0-ea3e-4f9f-ba3b-0dec16b2b1b3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","424945b7-1084-4c2c-9df3-c965fdb6ea48");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","88ceb0e5-1def-428a-a369-2ce92782113a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","616b0bdf-c58b-45f3-b643-e159c13da832");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f207a1e5-6c71-4c1d-81b7-7e9974257488");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1a602ba9-01cd-49cd-8bc6-815bbf30a113");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4ad0d67d-4ac0-42f1-bf48-8a21bcf5ea6b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f6927427-ccf9-4277-be0f-ebe3f3ba9fe0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f5bf4064-ee86-4687-a162-c1fe3fea4eef");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3c13d2e0-ce6c-468b-8531-fc222183b76d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bc410483-7a0d-4903-b94b-5ff18f8fa26e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","58d9fa62-82d5-41a6-b81c-ee57f5e54975");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f0e7a5a2-c985-46d0-bd3f-f2da49736c87");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dea9bae4-e5e1-4888-a2e0-4bbc7710fbfd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","64d9e9cc-a36f-4a8c-b216-073e22e67b8d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","20c08f12-6965-4746-bac6-50f08645db31");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fa195e80-ea9a-4535-9a80-02322dd65b78");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fccde9d7-9ff9-4bac-a8a9-c01c7b4a7289");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c4dfdb93-7c06-4de9-939d-33c552c8fea9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5701bee1-1f83-4323-9d1c-e99014d4748f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","10105616-5c1a-46d2-a5e4-db0f0a5f7b7c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1ad35c11-6686-4848-8394-82ae299b70ab");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6bf599f0-6689-42ff-9b62-03fa018bb40d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","69546192-4144-4b50-bd0f-2ced9c28038a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f28c51bd-b92e-4548-bfba-35de705e59e6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a45bef7a-891a-4c51-bbc4-303e1073259f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7cdab601-a8a7-41b2-ba2c-f0d8c115ded1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0f07d16d-cfd2-4945-9861-cd23dbb675d9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7eaa071b-1768-40e7-a020-cd650e153c87");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6389b48e-b3f8-43c2-be0a-e7589c08f460");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8c868ae5-92ef-4356-a8db-8ee2542f4883");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_CombineName", typeof(String), true,"","System.String", "DescFlexField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c0b59e7b-1db9-4b4c-8c07-abaf5d14cac4");


			this.CurrentFilter = new Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoRecord(builder);
		}
		#endregion

		#region new method
		public new Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoRecord FocusedRecord
		{
			get { return (Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoRecord AddNewUIRecord()
		{	
			return (Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoRecord)base.AddNewUIRecord();
		}
		public new Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoRecord NewUIRecord()
		{	
			return (Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoRecord : UIRecord
	{
		#region Constructor
		public Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoView uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo
		{
			get { return (Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldID);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldCreatedOn);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldCreatedBy);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldModifiedOn);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldModifiedBy);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldSysVersion);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? Cust_Xmjl_MO_BomChange
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldCust_Xmjl_MO_BomChange] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldCust_Xmjl_MO_BomChange);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldCust_Xmjl_MO_BomChange] = value;
			}
		}
		
		
		public  Int64? ManufactureNO
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldManufactureNO] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldManufactureNO);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldManufactureNO] = value;
			}
		}
		
		
		public  String ManufactureNO_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldManufactureNO_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldManufactureNO_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldManufactureNO_Code] = value;
			}
		}
		
		
		public  String ManufactureNO_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldManufactureNO_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldManufactureNO_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldManufactureNO_Name] = value;
			}
		}
		
		
		public  String ContractNo
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldContractNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldContractNo);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldContractNo] = value;
			}
		}
		
		
		public  String CarType
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldCarType] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldCarType);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldCarType] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg1
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg1);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg2
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg2);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg3
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg3);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg4
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg4);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg5
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg5);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg6
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg6);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg7
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg7);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg8
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg8);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg9
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg9);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg10
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg10);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg11
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg11);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg12
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg12);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg13
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg13);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg14
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg14);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg15
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg15);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg16
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg16);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg17
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg17);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg18
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg18);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg19
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg19);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg20
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg20);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg21
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg21);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg22
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg22);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg23
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg23);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg24
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg24);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg25
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg25);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg26
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg26);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg27
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg27);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg28
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg28);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg29
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg29);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg30
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg30);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg31
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg31] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg31);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg31] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg32
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg32] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg32);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg32] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg33
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg33] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg33);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg33] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg34
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg34] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg34);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg34] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg35
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg35] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg35);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg35] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg36
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg36] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg36);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg36] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg37
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg37] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg37);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg37] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg38
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg38] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg38);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg38] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg39
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg39] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg39);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg39] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg40
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg40] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg40);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg40] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg41
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg41] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg41);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg41] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg42
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg42] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg42);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg42] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg43
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg43] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg43);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg43] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg44
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg44] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg44);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg44] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg45
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg45] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg45);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg45] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg46
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg46] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg46);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg46] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg47
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg47] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg47);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg47] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg48
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg48] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg48);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg48] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg49
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg49] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg49);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg49] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg50
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg50] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg50);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PubDescSeg50] = value;
			}
		}
		
		
		public  String DescFlexField_ContextValue
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_ContextValue] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_ContextValue);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_ContextValue] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg1);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg2
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg2);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg3
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg3);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg4
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg4);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg5
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg5);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg6
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg6);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg7
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg7);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg8
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg8);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg9
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg9);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg10
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg10);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg11
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg11);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg12
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg12);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg13
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg13);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg14
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg14);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg15
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg15);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg16
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg16);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg17
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg17);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg18
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg18);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg19
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg19);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg20
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg20);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg21
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg21);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg22
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg22);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg23
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg23);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg24
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg24);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg25
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg25);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg26
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg26);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg27
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg27);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg28
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg28);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg29
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg29);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg30);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_PrivateDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_CombineName
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_CombineName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_CombineName);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FieldDescFlexField_CombineName] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoDefaultFilterFilter();
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