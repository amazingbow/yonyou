#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace BOMUIModel
{
	[Serializable]
	public partial class BOMUIModelModel : UIModel
	{
		#region Constructor
		public BOMUIModelModel() : base("BOMUIModel")
		{
			InitClass();
			this.SetResourceInfo("7f6ff926-dcaf-4084-8be9-6210090f5e90");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private BOMUIModelModel(bool isInit) : base("BOMUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new BOMUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private Cust_Xmjl_MO_BomMainView viewCust_Xmjl_MO_BomMain;			
		private Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadView viewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead;			
		private Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineView viewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine;			
		#endregion
		
		#region links
		//private IUILink linkCust_Xmjl_MO_BomMain__Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead;			
		//private IUILink linkCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead__Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine;			
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public Cust_Xmjl_MO_BomMainView Cust_Xmjl_MO_BomMain
		{
			get { return (Cust_Xmjl_MO_BomMainView)this["Cust_Xmjl_MO_BomMain"]; }
		}
		public Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadView Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead
		{
			get { return (Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadView)this["Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead"]; }
		}
		public Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineView Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine
		{
			get { return (Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineView)this["Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewCust_Xmjl_MO_BomMain = new Cust_Xmjl_MO_BomMainView(this);
			this.viewCust_Xmjl_MO_BomMain.SetResourceInfo("c65067f1-168d-49d0-a09d-2a9c447d9ac7");
			this.Views.Add(this.viewCust_Xmjl_MO_BomMain);			
			this.viewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead = new Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadView(this);
			this.viewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.SetResourceInfo("52c88cde-f314-4b01-8b93-70cbc5d4e6ed");
			this.Views.Add(this.viewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead);			
			this.viewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine = new Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineView(this);
			this.viewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.SetResourceInfo("47f03aa0-a35a-4563-9bd0-7f5ba7de6d12");
			this.Views.Add(this.viewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine);			

			//this.linkCust_Xmjl_MO_BomMain__Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead
			{
			IUILink link = new UILink("Cust_Xmjl_MO_BomMain__Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead",this,this.viewCust_Xmjl_MO_BomMain.FieldID,this.viewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldCust_Xmjl_MO_BomMain,EnumAssociationKind.COMPOSITION,EnumAssociationDirection.Double,EnumCardinality.ONE,EnumCardinality.MORE,"Cust_Xmjl_MO_BomHead");
			this.Links.Add(link);
			}
			//this.linkCust_Xmjl_MO_BomMain__Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.ChildKeyConstraint.UpdateRule = Rule.None;
			//this.linkCust_Xmjl_MO_BomMain__Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.ChildKeyConstraint.DeleteRule = Rule.None;
			//this.linkCust_Xmjl_MO_BomMain__Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.ChildKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
			//this.linkCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead__Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine
			{
			IUILink link = new UILink("Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead__Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine",this,this.viewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldID,this.viewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldCust_Xmjl_MO_BomHead,EnumAssociationKind.COMPOSITION,EnumAssociationDirection.Double,EnumCardinality.ONE,EnumCardinality.MORE,"Cust_Xmjl_MO_BomLine");
			this.Links.Add(link);
			}
			//this.linkCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead__Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.ChildKeyConstraint.UpdateRule = Rule.None;
			//this.linkCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead__Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.ChildKeyConstraint.DeleteRule = Rule.None;
			//this.linkCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead__Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.ChildKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
			
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
	public partial class Cust_Xmjl_MO_BomMainView : UIView
	{
		#region Constructor
		public Cust_Xmjl_MO_BomMainView(IUIModel model) : base(model,"Cust_Xmjl_MO_BomMain","UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomMain", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private Cust_Xmjl_MO_BomMainView():base(null,"Cust_Xmjl_MO_BomMain","UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomMain", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new Cust_Xmjl_MO_BomMainView();
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
		public IUIField FieldDocumentType
		{
			get { return this.Fields["DocumentType"]; }
		}
		public IUIField FieldDocumentType_Code
		{
			get { return this.Fields["DocumentType_Code"]; }
		}
		public IUIField FieldDocumentType_Name
		{
			get { return this.Fields["DocumentType_Name"]; }
		}
		public IUIField FieldManufactureNo
		{
			get { return this.Fields["ManufactureNo"]; }
		}
		public IUIField FieldManufactureNo_Code
		{
			get { return this.Fields["ManufactureNo_Code"]; }
		}
		public IUIField FieldManufactureNo_Name
		{
			get { return this.Fields["ManufactureNo_Name"]; }
		}
		public IUIField FieldContractNo
		{
			get { return this.Fields["ContractNo"]; }
		}
		public IUIField FieldSequence
		{
			get { return this.Fields["Sequence"]; }
		}
		public IUIField FieldDisburseBY
		{
			get { return this.Fields["DisburseBY"]; }
		}
		public IUIField FieldDisburseBY_Code
		{
			get { return this.Fields["DisburseBY_Code"]; }
		}
		public IUIField FieldDisburseBY_Name
		{
			get { return this.Fields["DisburseBY_Name"]; }
		}
		public IUIField FieldDisburseOn
		{
			get { return this.Fields["DisburseOn"]; }
		}
		public IUIField FieldCarType
		{
			get { return this.Fields["CarType"]; }
		}
		public IUIField FieldMo
		{
			get { return this.Fields["Mo"]; }
		}
		public IUIField FieldDepartment
		{
			get { return this.Fields["Department"]; }
		}
		public IUIField FieldDepartment_Code
		{
			get { return this.Fields["Department_Code"]; }
		}
		public IUIField FieldDepartment_Name
		{
			get { return this.Fields["Department_Name"]; }
		}
		public IUIField FieldStatus
		{
			get { return this.Fields["Status"]; }
		}
		public IUIField FieldDisburseType
		{
			get { return this.Fields["DisburseType"]; }
		}
		public IUIField FieldMemo
		{
			get { return this.Fields["Memo"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public Cust_Xmjl_MO_BomMainDefaultFilterFilter DefaultFilter
		{
			get { return (Cust_Xmjl_MO_BomMainDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","a5f8fdd0-4d61-4d96-b7ff-72e0cf218cb3");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","5052b94c-1b4c-4acc-8185-0adcc74713c5");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6fcc4a3b-a3a1-4bd5-9505-5f0d91fd31c3");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","8dddf996-4143-494f-8a96-abbe13077467");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b02fb525-b2a9-46e4-b848-534894dca473");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","0d07c00e-4700-4822-b7c9-91fe58f11bc6");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), false,"","UFIDA.U9.Base.Organization.Organization", "Org", true,true, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","caaed978-d986-45ed-939d-37071ca99835");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), false,"","System.String", "Org.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","adc5cedf-6b11-4a7b-9346-b0067744531f");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "Org.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ee0f7ebc-3dab-4801-b22a-79f7a54ea86d");
			UIModelRuntimeFactory.AddNewUIField(this,"DocNo", typeof(String), false,"","System.String", "DocNo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","de99fac9-6f41-4ea0-ab19-c9eb0bf481b1");
			UIModelRuntimeFactory.AddNewUIField(this,"BusinessDate", typeof(DateTime), false,"","System.Date", "BusinessDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","922aa022-066f-4f39-a5a7-436ed4078565");
			UIModelRuntimeFactory.AddNewUIField(this,"Version", typeof(Int32), true,"0","System.Int32", "Version", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","d8b31f0e-c736-4e62-88e7-0c40599acaed");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintAmount", typeof(Int32), true,"0","System.Int32", "PrintAmount", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","f1801675-a648-4306-8aaf-0b6218d470e7");
			UIModelRuntimeFactory.AddNewUIField(this,"LatestPrintedDate", typeof(DateTime), true,"","System.DateTime", "LatestPrintedDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","06239cc2-4efe-4d2c-bd68-691e31643021");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_Canceled", typeof(Boolean), true,"false","System.Boolean", "Cancel.Canceled", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","1ad7dd8d-0300-462d-822b-34a7674e70a5");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelDate", typeof(DateTime), true,"","System.DateTime", "Cancel.CancelDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","ae1db6bc-f7ea-45df-ba65-de0adad8cbf5");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelReason", typeof(String), true,"","System.String", "Cancel.CancelReason", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bc8ccca4-fb31-4a9e-8c39-2fd7b497f8e4");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelUser", typeof(String), true,"","System.String", "Cancel.CancelUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4af8f8f5-8987-4496-a90b-c8f60f7f216b");
			UIModelRuntimeFactory.AddNewUIField(this,"WorkFlowID", typeof(Guid), true,"","System.Guid", "WorkFlowID", true,true, false, "",false,(UIFieldType)1,"2b057235-c58e-441e-9477-5e52fcb7f95b","0a8f810e-2d57-4ec6-9a88-d08b3783c5bc");
			UIModelRuntimeFactory.AddNewUIField(this,"StateMachineID", typeof(Guid), true,"","System.Guid", "StateMachineID", true,true, false, "",false,(UIFieldType)1,"2b057235-c58e-441e-9477-5e52fcb7f95b","f5650f86-d045-4a1b-80ab-75f33861fda7");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason", typeof(Int64), true,"","UFIDA.U9.Base.HoldRelease.HoldReason", "HoldReason", true,true, false, "",false,(UIFieldType)4,"aca6401c-cd2c-460c-9883-a704f9ea93a6","f8ed5e7e-a00c-4713-b89c-5629b65ab428");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason_Code", typeof(String), false,"","System.String", "HoldReason.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cb9c003a-3b15-4300-ba32-7fbb97d03a1b");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason_Name", typeof(String), true,"","System.String", "HoldReason.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b1435f1f-8a22-4ffa-8a8a-1fcb549661e9");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldUser", typeof(String), true,"","System.String", "HoldUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9ef58a74-dfae-4ac1-b9d4-6cf2ad0a6d11");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldDate", typeof(DateTime), true,"","System.DateTime", "HoldDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","7e0c7375-ddfa-4364-a237-a63f908cb810");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason", typeof(Int64), true,"","UFIDA.U9.Base.HoldRelease.ReleaseReason", "ReleaseReason", true,true, false, "",false,(UIFieldType)4,"8f4c20a0-ea48-4e30-a76a-1f8d38bcc7cc","91d174a6-570b-47f2-9b0d-4d05ac0e713d");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason_Code", typeof(String), false,"","System.String", "ReleaseReason.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4f67fdb3-8565-413e-a3e1-d0d34093a85c");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason_Name", typeof(String), true,"","System.String", "ReleaseReason.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a8a70a17-9669-4493-bf49-14b0108a63db");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseUser", typeof(String), true,"","System.String", "ReleaseUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8e2a3e4c-4d55-4c7c-b7b2-a4df9d0d46ed");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseDate", typeof(DateTime), true,"","System.DateTime", "ReleaseDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","a011c84f-b570-4d52-85c9-69008ca74f80");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","eed3c5c8-bd55-42e9-acec-0626d92c54fc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","752ca786-20ff-4977-a50a-7376c63b888d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0840ffa5-18cb-4b65-acc7-7e157eee78b2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e873e52b-d929-4f29-97f4-a2f61662768c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4df6cb6c-fc7d-46f3-acac-5273c1274e84");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","315a9d99-0f0d-41f2-a958-4c8757118f4f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","136ad6e5-b8a8-4c59-9cf0-89f9d9e27624");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","048cbab4-e08e-4e86-a4c9-727f92ec9858");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","642b52d6-b38a-42e7-999c-95db56d8af83");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a9a538ae-7712-4cba-916e-62a604398feb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d13e52a7-56e3-4e77-8371-04d4b1eb8649");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","edf65eb6-a0c7-4ec8-850f-8daee899c4a0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4f7262d4-b34c-488f-a3e4-37d7981666fe");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","65de17aa-cc7d-4295-9a3e-58d5e9ac76c0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","eb888d9c-d2b7-46ad-97cf-0c9b4724b116");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","320a9986-fe3c-490f-9245-cf8cc88e865e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9f7be748-15ec-425f-a762-0550847833d1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f91b07a9-7d47-4542-8714-62410aa200f7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","231b173c-1c4d-43ea-b57f-81de27e319fb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","27e5a07f-e6e9-44a5-a262-d67221e9e3be");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ca1299b0-0804-4721-be73-af4cbebeb3cd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5e8b8a73-52f6-4228-af09-974b6e857129");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","49925835-4af7-46f2-aab2-8d72b83bb307");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8c4abaed-3708-45f9-a3e4-4d6b9d0741d9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0cf643c5-fb30-4a17-88cd-1634b55b7c06");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e6d0059b-67ec-4a75-b1a8-f42f7dd12c2b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0357d81f-9e5c-4eec-877a-fa206bfe95a5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","97e728e9-4536-4195-baca-0f57024e2705");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","93f2a412-af32-46b3-8a63-810494565a9c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","22e69a8d-817b-4cb8-8da0-8304aa4b1679");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg31", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3ff0fcf0-6c7a-49a3-8e2e-4cc723aef440");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg32", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c5c122e6-aa03-4228-ad5c-8f7da228dd39");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg33", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","01eb950a-21e0-448e-8193-421af29dbbc6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg34", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e9ca7e3c-0b94-45d9-9f18-12efad433c0c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg35", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1464f3b9-138a-49c3-ba04-42beb92cec53");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg36", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ff9f40d8-ed39-49de-8f97-4c9954aae7bc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg37", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6be4278e-ae6a-402c-bf87-749c9a94743e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg38", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0bf6c202-58f3-49ff-a0d2-ffbcaa4da6b9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg39", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6b90ac8d-d008-4720-b551-2c3746a50976");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg40", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6ba45d6f-5382-448d-addd-2734d113ec36");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg41", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","182e873a-3ddf-4651-b86e-303baa5c8e41");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg42", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","734f2b52-8c57-499c-8c83-2e563a5e8027");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg43", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0ff02339-6d5e-455f-872f-63a0ac168dbd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg44", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","224dc339-e6d2-430f-9ddb-25560a417d20");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg45", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9ac149fb-9c24-4eb3-ba5b-39ec3607fc3e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg46", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d10625ce-cdfc-4f55-bd2c-9c0e01d4ccb3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg47", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c9b3de2f-d5c3-4831-a5f7-4937901bfe6b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg48", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a21faf77-b727-48f1-bcc4-5dac96bdfd4d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg49", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f5356096-551f-4446-8d20-a32e55bbd88a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg50", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","92134c28-12a9-48da-8cfc-4cbfc1cfd940");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_ContextValue", typeof(String), true,"","System.String", "DescFlexField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9a34f643-8ce1-4024-8d1b-7a7f09deafe7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","16fa87c5-9fcd-4580-980b-1c9877f935aa");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6ccd1a9e-7ef9-4683-91b6-e4772f38711d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f605d6e8-19ca-42ca-a4c9-6e77f79dd2ed");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","192ceeb1-b575-4955-a591-df6ec201a384");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d0db96d1-9aa9-4f37-bf03-8713008f57e2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a8b1e046-78ee-438b-ac5e-f56fa9595978");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d8fb50c9-9ba9-4ca1-8631-f98f7f706bee");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bce9008c-ab28-4daa-bda5-5fa97e58f961");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e7122d06-275f-4763-b458-bad5c33e8283");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2db8308e-cef4-4e0a-b5b7-e05daf7a63bb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2deb198e-21ae-4e76-a6d5-db2c706f7517");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1bc82240-12ae-43dc-8776-cd173b9f575f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ade5428f-7050-45ef-92eb-fa11028db15f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","266fc071-5070-4de8-8390-594b7dfb3c99");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3f3ebbb9-bc0f-461f-8672-f80f0a334b4b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d34e85ea-b024-4231-b65a-8ddbfede2571");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fb740e76-cf40-4fca-b222-c445cbafd6d0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","20362517-62e1-40bc-9eb9-afb90f1bb73f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b3320d14-9f4b-43f4-8367-96ed756a5e86");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f83c9cad-dc40-40fd-86b0-c92c1436f1cf");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8ba88e45-154e-41e8-8dbc-9b2143c867a1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0e23fcbd-ddd1-45a2-bc85-5f6e9a3056d8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5d9fe855-96bb-488b-bdce-7e5152f84f8a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","28d1f526-7ef0-4a6d-a0ff-91dd5d0440d5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1404b090-8e6e-475f-9591-d7dfdbaa8d72");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bb5cc746-11b0-482c-b11d-ded48e083a2f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2e35ccb7-357c-4c5e-9cfd-0ac423f9964f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","74a81b53-2818-4105-9b51-f800264927ed");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b651a1aa-c186-4ff9-93d7-01d662a4d32e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2557adb6-3a66-4c79-a7b6-b58dcd2409e2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_CombineName", typeof(String), true,"","System.String", "DescFlexField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ae2e3dc5-d6c5-48b0-9a89-38c250f83974");
			UIModelRuntimeFactory.AddNewUIField(this,"FlowInstance", typeof(Int64), true,"","UFIDA.U9.CS.Workflow.WorkflowInstanceBE.FlowInstance", "FlowInstance", true,true, false, "",false,(UIFieldType)4,"d87a7006-6643-42f4-98f4-168847a71955","e5b6bcf1-060b-41ab-bdd6-3c465c530bed");
			UIModelRuntimeFactory.AddNewUIField(this,"DocumentType", typeof(Int64), true,"","UFIDA.U9.Cust.XMJL.DocumentTypeBE.Cust_Xmjl_DocumentType", "DocumentType", true,true, false, "",false,(UIFieldType)4,"3ffb14f6-f9dd-4fb4-9e83-5cfab77cf9a1","df84027f-8ca7-4492-80c2-05c37a974fc0");
			UIModelRuntimeFactory.AddNewUIField(this,"DocumentType_Code", typeof(String), false,"","System.String", "DocumentType.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2f14fa51-e272-41ca-9bcc-aad008ea063e");
			UIModelRuntimeFactory.AddNewUIField(this,"DocumentType_Name", typeof(String), true,"","System.String", "DocumentType.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","eaadb2ff-f55f-4672-80ec-0f11b8015fee");
			UIModelRuntimeFactory.AddNewUIField(this,"ManufactureNo", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.ProjectTask.Project", "ManufactureNo", true,true, false, "",false,(UIFieldType)4,"7bc6294b-1a35-4e37-acfe-5abc5602f12f","78641555-2c30-442a-8435-d9946f46ad18");
			UIModelRuntimeFactory.AddNewUIField(this,"ManufactureNo_Code", typeof(String), false,"","System.String", "ManufactureNo.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","18a00419-bccd-43e5-b913-ebbe5c2bbbca");
			UIModelRuntimeFactory.AddNewUIField(this,"ManufactureNo_Name", typeof(String), true,"","System.String", "ManufactureNo.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8332cf44-9144-42d9-bb63-42586ee397a4");
			UIModelRuntimeFactory.AddNewUIField(this,"ContractNo", typeof(String), true,"","System.String", "ContractNo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c7baa697-77b0-42eb-b5e7-73220375cc19");
			UIModelRuntimeFactory.AddNewUIField(this,"Sequence", typeof(Int32), true,"0","System.Int32", "Sequence", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","3b6445d4-1772-455b-96fa-78883dcc394b");
			UIModelRuntimeFactory.AddNewUIField(this,"DisburseBY", typeof(Int64), true,"","UFIDA.U9.CBO.HR.Operator.Operators", "DisburseBY", true,true, false, "",false,(UIFieldType)4,"198b0f81-207e-4707-8a8c-e0475b7674bd","d654f202-953e-4bfb-adff-4e46c679f11a");
			UIModelRuntimeFactory.AddNewUIField(this,"DisburseBY_Code", typeof(String), false,"","System.String", "DisburseBY.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2158ae0d-5ab2-4fc7-96de-4a0a1d90e06a");
			UIModelRuntimeFactory.AddNewUIField(this,"DisburseBY_Name", typeof(String), false,"","System.String", "DisburseBY.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5d09f5cc-f3bd-4d7f-b1ae-954c524b8321");
			UIModelRuntimeFactory.AddNewUIField(this,"DisburseOn", typeof(DateTime), true,"","System.DateTime", "DisburseOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","393c3679-1e81-4000-b93c-b108054f6394");
			UIModelRuntimeFactory.AddNewUIField(this,"CarType", typeof(String), true,"","System.String", "CarType", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f54b2f5d-7c63-47bf-9dbd-61b7a25610af");
			UIModelRuntimeFactory.AddNewUIField(this,"Mo", typeof(Int64), true,"","UFIDA.U9.MO.MO.MO", "Mo", true,true, false, "",false,(UIFieldType)4,"d81bf969-9ba9-423c-9ff2-c88537164c41","c79f650e-c77e-473f-a3ea-0ff400bff15a");
			UIModelRuntimeFactory.AddNewUIField(this,"Department", typeof(Int64), true,"","UFIDA.U9.CBO.HR.Department.Department", "Department", true,true, false, "",false,(UIFieldType)4,"3410e657-4f0f-47a9-9cf1-d1c421c116a8","75e1ceeb-48ac-4c75-b8e9-be6a0996cdf9");
			UIModelRuntimeFactory.AddNewUIField(this,"Department_Code", typeof(String), false,"","System.String", "Department.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0f7635b8-d4de-49f6-a727-79ca53f98f23");
			UIModelRuntimeFactory.AddNewUIField(this,"Department_Name", typeof(String), true,"","System.String", "Department.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","470c2012-124c-4772-b6f3-a01031ef458e");
			UIModelRuntimeFactory.AddNewUIField(this,"Status", typeof(Int32), true,"1","UFIDA.U9.Cust.XMJL.BommBE.BomMainStatusEnum", "Status", true,true, false, "",false,(UIFieldType)2,"bb575162-b86b-45e5-9b94-fc59895e95e7","131db531-dbcc-40d2-9fd5-bc9cf41032a2");
			UIModelRuntimeFactory.AddNewUIField(this,"DisburseType", typeof(Int32), true,"1","UFIDA.U9.Cust.XMJL.BommBE.BomMainType", "DisburseType", true,true, false, "",false,(UIFieldType)2,"5e551e18-569c-4e57-a0d0-81757fb7a7a0","1513e231-510e-463a-9943-23077cc9b731");
			UIModelRuntimeFactory.AddNewUIField(this,"Memo", typeof(String), true,"","System.String", "Memo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a52f4343-7ff6-4bb9-8b40-115f0e2417a4");


			this.CurrentFilter = new Cust_Xmjl_MO_BomMainDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new Cust_Xmjl_MO_BomMainRecord(builder);
		}
		#endregion

		#region new method
		public new Cust_Xmjl_MO_BomMainRecord FocusedRecord
		{
			get { return (Cust_Xmjl_MO_BomMainRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new Cust_Xmjl_MO_BomMainRecord AddNewUIRecord()
		{	
			return (Cust_Xmjl_MO_BomMainRecord)base.AddNewUIRecord();
		}
		public new Cust_Xmjl_MO_BomMainRecord NewUIRecord()
		{	
			return (Cust_Xmjl_MO_BomMainRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class Cust_Xmjl_MO_BomMainRecord : UIRecord
	{
		#region Constructor
		public Cust_Xmjl_MO_BomMainRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private Cust_Xmjl_MO_BomMainView uiviewCust_Xmjl_MO_BomMain
		{
			get { return (Cust_Xmjl_MO_BomMainView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new Cust_Xmjl_MO_BomMainRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCust_Xmjl_MO_BomMain.FieldID);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomMain.FieldCreatedOn);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldCreatedBy);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomMain.FieldModifiedOn);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldModifiedBy);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomMain.FieldSysVersion);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64 Org
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldOrg] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCust_Xmjl_MO_BomMain.FieldOrg);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldOrg] = value;
			}
		}
		
		
		public  String Org_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldOrg_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldOrg_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldOrg_Code] = value;
			}
		}
		
		
		public  String Org_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldOrg_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldOrg_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldOrg_Name] = value;
			}
		}
		
		
		public  String DocNo
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDocNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDocNo);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDocNo] = value;
			}
		}
		
		
		public  DateTime BusinessDate
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldBusinessDate] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewCust_Xmjl_MO_BomMain.FieldBusinessDate);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldBusinessDate] = value;
			}
		}
		
		
		public  Int32? Version
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldVersion] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCust_Xmjl_MO_BomMain.FieldVersion);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldVersion] = value;
			}
		}
		
		
		public  Int32? PrintAmount
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldPrintAmount] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCust_Xmjl_MO_BomMain.FieldPrintAmount);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldPrintAmount] = value;
			}
		}
		
		
		public  DateTime? LatestPrintedDate
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldLatestPrintedDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomMain.FieldLatestPrintedDate);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldLatestPrintedDate] = value;
			}
		}
		
		
		public  Boolean? Cancel_Canceled
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldCancel_Canceled] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewCust_Xmjl_MO_BomMain.FieldCancel_Canceled);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldCancel_Canceled] = value;
			}
		}
		
		
		public  DateTime? Cancel_CancelDate
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldCancel_CancelDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomMain.FieldCancel_CancelDate);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldCancel_CancelDate] = value;
			}
		}
		
		
		public  String Cancel_CancelReason
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldCancel_CancelReason] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldCancel_CancelReason);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldCancel_CancelReason] = value;
			}
		}
		
		
		public  String Cancel_CancelUser
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldCancel_CancelUser] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldCancel_CancelUser);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldCancel_CancelUser] = value;
			}
		}
		
		
		public  Guid WorkFlowID
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldWorkFlowID] ;
				//return (Guid)value;
				return GetValue<Guid>(this.uiviewCust_Xmjl_MO_BomMain.FieldWorkFlowID);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldWorkFlowID] = value;
			}
		}
		
		
		public  Guid StateMachineID
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldStateMachineID] ;
				//return (Guid)value;
				return GetValue<Guid>(this.uiviewCust_Xmjl_MO_BomMain.FieldStateMachineID);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldStateMachineID] = value;
			}
		}
		
		
		public  Int64? HoldReason
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldHoldReason] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomMain.FieldHoldReason);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldHoldReason] = value;
			}
		}
		
		
		public  String HoldReason_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldHoldReason_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldHoldReason_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldHoldReason_Code] = value;
			}
		}
		
		
		public  String HoldReason_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldHoldReason_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldHoldReason_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldHoldReason_Name] = value;
			}
		}
		
		
		public  String HoldUser
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldHoldUser] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldHoldUser);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldHoldUser] = value;
			}
		}
		
		
		public  DateTime? HoldDate
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldHoldDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomMain.FieldHoldDate);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldHoldDate] = value;
			}
		}
		
		
		public  Int64? ReleaseReason
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldReleaseReason] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomMain.FieldReleaseReason);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldReleaseReason] = value;
			}
		}
		
		
		public  String ReleaseReason_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldReleaseReason_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldReleaseReason_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldReleaseReason_Code] = value;
			}
		}
		
		
		public  String ReleaseReason_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldReleaseReason_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldReleaseReason_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldReleaseReason_Name] = value;
			}
		}
		
		
		public  String ReleaseUser
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldReleaseUser] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldReleaseUser);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldReleaseUser] = value;
			}
		}
		
		
		public  DateTime? ReleaseDate
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldReleaseDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomMain.FieldReleaseDate);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldReleaseDate] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg1
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg1);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg2
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg2);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg3
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg3);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg4
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg4);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg5
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg5);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg6
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg6);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg7
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg7);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg8
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg8);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg9
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg9);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg10
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg10);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg11
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg11);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg12
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg12);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg13
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg13);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg14
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg14);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg15
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg15);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg16
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg16);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg17
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg17);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg18
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg18);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg19
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg19);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg20
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg20);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg21
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg21);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg22
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg22);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg23
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg23);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg24
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg24);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg25
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg25);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg26
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg26);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg27
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg27);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg28
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg28);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg29
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg29);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg30
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg30);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg31
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg31] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg31);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg31] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg32
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg32] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg32);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg32] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg33
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg33] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg33);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg33] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg34
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg34] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg34);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg34] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg35
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg35] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg35);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg35] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg36
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg36] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg36);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg36] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg37
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg37] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg37);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg37] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg38
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg38] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg38);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg38] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg39
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg39] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg39);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg39] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg40
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg40] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg40);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg40] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg41
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg41] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg41);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg41] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg42
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg42] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg42);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg42] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg43
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg43] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg43);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg43] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg44
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg44] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg44);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg44] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg45
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg45] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg45);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg45] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg46
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg46] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg46);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg46] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg47
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg47] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg47);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg47] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg48
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg48] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg48);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg48] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg49
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg49] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg49);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg49] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg50
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg50] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg50);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PubDescSeg50] = value;
			}
		}
		
		
		public  String DescFlexField_ContextValue
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_ContextValue] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_ContextValue);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_ContextValue] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg1);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg2
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg2);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg3
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg3);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg4
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg4);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg5
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg5);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg6
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg6);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg7
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg7);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg8
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg8);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg9
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg9);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg10
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg10);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg11
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg11);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg12
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg12);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg13
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg13);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg14
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg14);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg15
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg15);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg16
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg16);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg17
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg17);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg18
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg18);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg19
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg19);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg20
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg20);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg21
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg21);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg22
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg22);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg23
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg23);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg24
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg24);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg25
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg25);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg26
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg26);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg27
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg27);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg28
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg28);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg29
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg29);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg30);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_PrivateDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_CombineName
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_CombineName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_CombineName);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDescFlexField_CombineName] = value;
			}
		}
		
		
		public  Int64? FlowInstance
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldFlowInstance] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomMain.FieldFlowInstance);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldFlowInstance] = value;
			}
		}
		
		
		public  Int64? DocumentType
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDocumentType] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomMain.FieldDocumentType);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDocumentType] = value;
			}
		}
		
		
		public  String DocumentType_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDocumentType_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDocumentType_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDocumentType_Code] = value;
			}
		}
		
		
		public  String DocumentType_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDocumentType_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDocumentType_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDocumentType_Name] = value;
			}
		}
		
		
		public  Int64? ManufactureNo
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldManufactureNo] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomMain.FieldManufactureNo);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldManufactureNo] = value;
			}
		}
		
		
		public  String ManufactureNo_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldManufactureNo_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldManufactureNo_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldManufactureNo_Code] = value;
			}
		}
		
		
		public  String ManufactureNo_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldManufactureNo_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldManufactureNo_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldManufactureNo_Name] = value;
			}
		}
		
		
		public  String ContractNo
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldContractNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldContractNo);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldContractNo] = value;
			}
		}
		
		
		public  Int32? Sequence
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldSequence] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCust_Xmjl_MO_BomMain.FieldSequence);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldSequence] = value;
			}
		}
		
		
		public  Int64? DisburseBY
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDisburseBY] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomMain.FieldDisburseBY);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDisburseBY] = value;
			}
		}
		
		
		public  String DisburseBY_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDisburseBY_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDisburseBY_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDisburseBY_Code] = value;
			}
		}
		
		
		public  String DisburseBY_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDisburseBY_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDisburseBY_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDisburseBY_Name] = value;
			}
		}
		
		
		public  DateTime? DisburseOn
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDisburseOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomMain.FieldDisburseOn);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDisburseOn] = value;
			}
		}
		
		
		public  String CarType
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldCarType] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldCarType);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldCarType] = value;
			}
		}
		
		
		public  Int64? Mo
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldMo] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomMain.FieldMo);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldMo] = value;
			}
		}
		
		
		public  Int64? Department
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDepartment] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomMain.FieldDepartment);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDepartment] = value;
			}
		}
		
		
		public  String Department_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDepartment_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDepartment_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDepartment_Code] = value;
			}
		}
		
		
		public  String Department_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDepartment_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldDepartment_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDepartment_Name] = value;
			}
		}
		
		
		public  Int32? Status
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldStatus] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCust_Xmjl_MO_BomMain.FieldStatus);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldStatus] = value;
			}
		}
		
		
		public  Int32? DisburseType
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldDisburseType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCust_Xmjl_MO_BomMain.FieldDisburseType);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldDisburseType] = value;
			}
		}
		
		
		public  String Memo
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldMemo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldMemo);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldMemo] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class Cust_Xmjl_MO_BomMainDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public Cust_Xmjl_MO_BomMainDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"UFIDA::U9::Cust::XMJL::BommBE::Cust_Xmjl_MO_BomMain.Org.ID=#Context.OrgID#",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private Cust_Xmjl_MO_BomMainDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new Cust_Xmjl_MO_BomMainDefaultFilterFilter();
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



	[Serializable]
	public partial class Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadView : UIView
	{
		#region Constructor
		public Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadView(IUIModel model) : base(model,"Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead","UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomHead", false)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadView():base(null,"Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead","UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomHead", false)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadView();
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
		public IUIField FieldCust_Xmjl_MO_BomMain
		{
			get { return this.Fields["Cust_Xmjl_MO_BomMain"]; }
		}
		public IUIField FieldRowNo
		{
			get { return this.Fields["RowNo"]; }
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
		public IUIField FieldWareHouse
		{
			get { return this.Fields["WareHouse"]; }
		}
		public IUIField FieldWareHouse_Code
		{
			get { return this.Fields["WareHouse_Code"]; }
		}
		public IUIField FieldWareHouse_Name
		{
			get { return this.Fields["WareHouse_Name"]; }
		}
		public IUIField FieldWorkPlace
		{
			get { return this.Fields["WorkPlace"]; }
		}
		public IUIField FieldStatus
		{
			get { return this.Fields["Status"]; }
		}
		public IUIField FieldQty
		{
			get { return this.Fields["Qty"]; }
		}
		public IUIField FieldDisbursedQty
		{
			get { return this.Fields["DisbursedQty"]; }
		}
		public IUIField FieldRptBy
		{
			get { return this.Fields["RptBy"]; }
		}
		public IUIField FieldRptBy_Code
		{
			get { return this.Fields["RptBy_Code"]; }
		}
		public IUIField FieldRptBy_Name
		{
			get { return this.Fields["RptBy_Name"]; }
		}
		public IUIField FieldRptOn
		{
			get { return this.Fields["RptOn"]; }
		}
		public IUIField FieldMemo
		{
			get { return this.Fields["Memo"]; }
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
		public IUIField FieldFeeID
		{
			get { return this.Fields["FeeID"]; }
		}
		public IUIField FieldOutOn
		{
			get { return this.Fields["OutOn"]; }
		}
		public IUIField FieldFeeQty
		{
			get { return this.Fields["FeeQty"]; }
		}
		public IUIField FieldBackQty
		{
			get { return this.Fields["BackQty"]; }
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
		public Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadDefaultFilterFilter DefaultFilter
		{
			get { return (Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","60520024-2e3b-402f-b952-8477c5e53be2");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","a53b3634-4360-46ee-b5f7-756c4fd3b26c");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f0f211af-1663-4f62-8750-40309746a843");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","9ba6596b-dfee-496f-aa1e-8809a9f52bf3");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7057f6af-058b-4597-a18a-f647bb6dfe8c");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","83168639-16e0-417b-b32a-b24d8cb9314c");
			UIModelRuntimeFactory.AddNewUIField(this,"Cust_Xmjl_MO_BomMain", typeof(Int64), true,"","UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomMain", "Cust_Xmjl_MO_BomMain", true,true, false, "",false,(UIFieldType)4,"cce8c490-0ca5-4435-8cdd-10ea421c71e9","a7975800-6b90-48d1-b0d0-81529f953f61");
			UIModelRuntimeFactory.AddNewUIField(this,"RowNo", typeof(Int32), true,"0","System.Int32", "RowNo", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","ddf292e3-fc36-408a-8c23-aa85f5bc4db2");
			UIModelRuntimeFactory.AddNewUIField(this,"Item", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Item.ItemMaster", "Item", true,true, false, "",false,(UIFieldType)4,"636d3e47-48aa-47fc-aca4-e6322bce775b","0cb934ea-6b41-4c0f-b821-fde0248ce8b0");
			UIModelRuntimeFactory.AddNewUIField(this,"Item_Code", typeof(String), false,"","System.String", "Item.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1ec4b5db-ee25-4b14-af34-c375d2d322c5");
			UIModelRuntimeFactory.AddNewUIField(this,"Item_Name", typeof(String), false,"","System.String", "Item.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","062b8e36-7e17-44e2-9fda-f8b563db71d2");
			UIModelRuntimeFactory.AddNewUIField(this,"Supplier", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Supplier.Supplier", "Supplier", true,true, false, "",false,(UIFieldType)4,"ac3510e5-3337-46d4-b41c-46ac40f343e1","16c04fc5-ef1f-4134-9c42-7be44214df28");
			UIModelRuntimeFactory.AddNewUIField(this,"Supplier_Code", typeof(String), false,"","System.String", "Supplier.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7598728d-306e-4b02-af5f-a426ac122e0c");
			UIModelRuntimeFactory.AddNewUIField(this,"Supplier_Name", typeof(String), true,"","System.String", "Supplier.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e51d3fae-f52b-42bb-bf7d-0c3e0a2c1982");
			UIModelRuntimeFactory.AddNewUIField(this,"WareHouse", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Warehouse.Warehouse", "WareHouse", true,true, false, "",false,(UIFieldType)4,"0fac5c83-2ab0-428f-bf82-c363857b37be","e1c8365f-3379-4764-820b-400ff8001f13");
			UIModelRuntimeFactory.AddNewUIField(this,"WareHouse_Code", typeof(String), false,"","System.String", "WareHouse.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2a79d07c-5384-4522-aae7-62e4c2bd746f");
			UIModelRuntimeFactory.AddNewUIField(this,"WareHouse_Name", typeof(String), true,"","System.String", "WareHouse.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bd57144e-8064-4a7f-8695-18505a096b5e");
			UIModelRuntimeFactory.AddNewUIField(this,"WorkPlace", typeof(String), true,"","System.String", "WorkPlace", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e605f7e4-fd0a-4dae-86dd-704aa35e00dc");
			UIModelRuntimeFactory.AddNewUIField(this,"Status", typeof(Int32), true,"1","UFIDA.U9.Cust.XMJL.BommBE.BomHeadStatus", "Status", true,true, false, "",false,(UIFieldType)2,"26cd6c09-deb6-49f2-9646-9ebeb71c4ba0","778b7ca4-0c22-4126-8154-3a7aeaa7b3d6");
			UIModelRuntimeFactory.AddNewUIField(this,"Qty", typeof(Decimal), true,"0","System.Decimal", "Qty", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","88031f7b-9a94-45a8-bff0-21a083a40637");
			UIModelRuntimeFactory.AddNewUIField(this,"DisbursedQty", typeof(Decimal), true,"0","System.Decimal", "DisbursedQty", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","c2910efd-2f30-42e9-925c-0ec37caaa7dd");
			UIModelRuntimeFactory.AddNewUIField(this,"RptBy", typeof(Int64), true,"","UFIDA.U9.Base.UserRole.User", "RptBy", true,true, false, "",false,(UIFieldType)4,"8f8bc946-3bdb-42cc-a909-f3090b2ad7b0","3286a9f4-5955-4841-8556-f7041f94746e");
			UIModelRuntimeFactory.AddNewUIField(this,"RptBy_Code", typeof(String), false,"","System.String", "RptBy.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ad7cae01-e040-43f0-ac1d-af61bc458cde");
			UIModelRuntimeFactory.AddNewUIField(this,"RptBy_Name", typeof(String), false,"","System.String", "RptBy.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","75866ab5-13ca-4cb3-af31-0bf91e400f30");
			UIModelRuntimeFactory.AddNewUIField(this,"RptOn", typeof(DateTime), true,"","System.DateTime", "RptOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","11a34daa-7cc1-4fad-b48c-f56c1fecebc0");
			UIModelRuntimeFactory.AddNewUIField(this,"Memo", typeof(String), true,"","System.String", "Memo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","143ff7fb-fa2a-4cc5-9201-d93888d74832");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), true,"","UFIDA.U9.Base.Organization.Organization", "Org", true,true, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","f02a64a5-a595-45c4-9f1d-3760a22f12de");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), false,"","System.String", "Org.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7648c216-b7ef-489a-b128-fba3b3a28c4c");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "Org.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e5cc50ab-20b9-4df4-bdb6-ab5f5daa72c7");
			UIModelRuntimeFactory.AddNewUIField(this,"FeeID", typeof(String), true,"","System.String", "FeeID", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","da1b5bc0-74f4-4103-8db4-655a4aa51c66");
			UIModelRuntimeFactory.AddNewUIField(this,"OutOn", typeof(DateTime), true,"","System.DateTime", "OutOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","7ce65eae-ae24-4fca-88f9-71f4778af415");
			UIModelRuntimeFactory.AddNewUIField(this,"FeeQty", typeof(Decimal), true,"0","System.Decimal", "FeeQty", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","7fe86ee9-406f-428b-914a-557fb8526484");
			UIModelRuntimeFactory.AddNewUIField(this,"BackQty", typeof(Decimal), true,"0","System.Decimal", "BackQty", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","fc2a619b-ef9a-4284-ba57-08802cd82faf");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","333a16e7-3b97-4be9-8a81-498e6eb728bd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1438c3bf-d5b9-469a-919f-c2a78aa8450b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3343f5d4-ba4b-4e26-bcf7-e6f3c85db1dc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8bac8f92-ccc2-42e3-a510-92094fcbdf05");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3bbdeb8e-1fde-4b2f-a2fb-d0cd49024de0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","11840599-5245-42bb-a3f4-2a144a7c6aa0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3f11021e-6022-4b73-9862-1705e3084b48");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8b6ae86d-ebcf-4b95-9080-a29826c72952");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","84de3d05-588a-4664-b874-22e19afa0939");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e96e10e7-4d2a-42ef-a539-47095cc781f8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d5b02734-2a1b-430b-a151-bce8a52ffcf9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a5f40e9d-1b9f-4090-88e7-2fc409840a8d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","efd6a1c9-b107-4d19-a8d1-6f60f135dff1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","04c75328-e769-456a-9d74-87e1bcbfbfb8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8379a881-effb-49de-ae85-e2029cd855c7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","818d7da9-9d81-43ee-8c1c-50c3c1291064");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","19cfe73b-5cde-4806-a3a3-484e9f7ebe1d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","aa15fc96-337a-4a29-adf2-0d2460ef1a98");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","16c98e06-827a-4b3f-93bc-af86ae16cf21");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","71830c43-246e-4406-9494-d2b3c1b50161");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","455be0b1-b8b5-4764-92f6-af60eceba0a4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","41948853-467d-4b19-90ba-93390437ffba");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","aa85ebbf-47f7-473a-b441-8e25877e5ae4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1af4ab8b-7209-4207-83b4-05b61c56ffda");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e620341e-8755-4e35-89d6-9a1436a46d37");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","eda5b63c-9c08-4841-94cd-0ffb7c2f47d5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5ca3e271-5e5d-420a-9b72-ec2685575fd7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3186bb88-3ebb-4d93-9834-365df2c3aca7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","46da4d3c-7c8c-4300-a618-a1644620baed");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bd343530-f306-49e9-9e1c-5f2609123b15");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg31", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3f2d830b-68d4-4f88-805e-c213309c3489");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg32", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b408083c-b80a-4648-a5f1-9de0ae2e2524");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg33", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9b26fc68-7979-4c5d-a524-37db376047e9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg34", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d8b8a0f8-0026-4f87-a87b-8ae86188cd49");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg35", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","45d411c1-bca3-44d8-8941-82e50ae5ddb4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg36", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e7aa0aa9-fe5b-4107-b9f0-e8ceeb8dbf7f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg37", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e1f5aec4-0ddd-4f70-9264-d21db8ea9d09");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg38", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2858d229-7514-43e6-9ba2-9a3f00418d08");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg39", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","12a520d5-bbdd-4af2-9d96-a720673f367e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg40", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","473e26e4-ce34-44d6-827d-0867a88b250a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg41", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","68a7676a-1d5d-4b6e-a6a7-944b32559cd1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg42", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","599f7bc9-583b-4635-b25c-5151757d29b4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg43", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a2f11c03-616d-4f92-8be4-425e0b152579");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg44", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c6b8f4c3-4d25-4b50-9e0b-0ffb6a9d63a4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg45", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ad4ad95e-08ac-4f96-bdd8-134fdc55cecc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg46", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a7f25bd2-d9c4-431d-9bc7-2361b9e3e097");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg47", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a380be44-77d1-4c09-bbb1-dc8d435cec1c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg48", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f8fb2aab-e413-424b-864f-e8157de24155");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg49", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b0b0a884-6e29-423c-b11d-80341dc9b9b5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg50", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fd0c9a48-a71e-41db-a29c-e325322b29e6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_ContextValue", typeof(String), true,"","System.String", "DescFlexField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","83c0cbf4-d28f-473b-997c-d5529805a869");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","530360b3-605b-4124-b4dd-960ff7344b8f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","107efb04-5e52-4b5c-b474-7f31a5b72890");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c5aa5138-ff02-4fce-8048-d345f55b9978");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","52907a4e-8287-4333-9701-28b32335a0e8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6971bd33-5324-484c-bd2e-894f37e97f47");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","94f1037b-3a49-4166-948b-9cad4d3d91dc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1fdb1ed5-4fce-47e2-bb35-c53a2dc33692");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5b50045d-a6af-4660-ac5b-1dd8a869f619");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","909b1263-101a-44ca-bf44-fbc4bb6fa70b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","91375b61-64ac-4cc9-9586-04839a1eef9b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8956df30-129f-47bd-96ed-0d6dd56d74fa");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dd9bb7aa-e209-462c-b553-21b8b66f30fd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0466f1ce-18bd-4dbf-9697-e5e75f82f62e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5c95da87-8577-4d3f-9fd6-64c6b439846c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4ce67b23-402a-4bb7-a0b1-559b8a6ba9ba");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3a596a06-74cc-4cf9-b51e-1080aa294eff");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4e058592-7986-4564-8c09-5b6e5b2bf1ce");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5d55240a-2cbc-4065-b4bc-091272b7e1d3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c4bb4d6d-0110-4d59-9d56-2b9142c2e3a6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e61c172a-cf3a-4b3c-bddd-6d8f0a42dca2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0b265777-0116-433d-9e39-440baf9f3bbb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","eb8043dd-dfa4-4c01-9be7-344df3809ac7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","10bd44b5-8c94-4087-bd94-4f6eff35d0da");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","927d0071-18d7-4621-b0d9-be0b7351bbba");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2bf96c30-0d6a-482a-a13e-de6cb21b3598");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dc5f5c0b-a26f-4505-883a-cc6595c41446");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d538c4b7-995c-45bd-a0c6-e872f2dfe461");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f464f2c2-a3bd-4fd2-b91b-b9d747274168");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","742c6d82-d029-44e1-9d4e-586e501674f4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","62c1214d-a1ff-4eb1-8cce-e3bf29f36699");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_CombineName", typeof(String), true,"","System.String", "DescFlexField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","acdf4016-1929-41e5-8a5f-a70c39b1bce1");


			this.CurrentFilter = new Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadRecord(builder);
		}
		#endregion

		#region new method
		public new Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadRecord FocusedRecord
		{
			get { return (Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadRecord AddNewUIRecord()
		{	
			return (Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadRecord)base.AddNewUIRecord();
		}
		public new Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadRecord NewUIRecord()
		{	
			return (Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadRecord : UIRecord
	{
		#region Constructor
		public Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadView uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead
		{
			get { return (Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldID);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldCreatedOn);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldCreatedBy);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldModifiedOn);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldModifiedBy);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldSysVersion);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? Cust_Xmjl_MO_BomMain
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldCust_Xmjl_MO_BomMain] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldCust_Xmjl_MO_BomMain);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldCust_Xmjl_MO_BomMain] = value;
			}
		}
		
		
		public  Int32? RowNo
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldRowNo] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldRowNo);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldRowNo] = value;
			}
		}
		
		
		public  Int64? Item
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldItem] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldItem);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldItem] = value;
			}
		}
		
		
		public  String Item_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldItem_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldItem_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldItem_Code] = value;
			}
		}
		
		
		public  String Item_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldItem_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldItem_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldItem_Name] = value;
			}
		}
		
		
		public  Int64? Supplier
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldSupplier] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldSupplier);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldSupplier] = value;
			}
		}
		
		
		public  String Supplier_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldSupplier_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldSupplier_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldSupplier_Code] = value;
			}
		}
		
		
		public  String Supplier_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldSupplier_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldSupplier_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldSupplier_Name] = value;
			}
		}
		
		
		public  Int64? WareHouse
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldWareHouse] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldWareHouse);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldWareHouse] = value;
			}
		}
		
		
		public  String WareHouse_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldWareHouse_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldWareHouse_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldWareHouse_Code] = value;
			}
		}
		
		
		public  String WareHouse_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldWareHouse_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldWareHouse_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldWareHouse_Name] = value;
			}
		}
		
		
		public  String WorkPlace
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldWorkPlace] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldWorkPlace);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldWorkPlace] = value;
			}
		}
		
		
		public  Int32? Status
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldStatus] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldStatus);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldStatus] = value;
			}
		}
		
		
		public  Decimal? Qty
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldQty);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldQty] = value;
			}
		}
		
		
		public  Decimal? DisbursedQty
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDisbursedQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDisbursedQty);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDisbursedQty] = value;
			}
		}
		
		
		public  Int64? RptBy
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldRptBy] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldRptBy);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldRptBy] = value;
			}
		}
		
		
		public  String RptBy_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldRptBy_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldRptBy_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldRptBy_Code] = value;
			}
		}
		
		
		public  String RptBy_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldRptBy_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldRptBy_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldRptBy_Name] = value;
			}
		}
		
		
		public  DateTime? RptOn
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldRptOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldRptOn);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldRptOn] = value;
			}
		}
		
		
		public  String Memo
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldMemo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldMemo);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldMemo] = value;
			}
		}
		
		
		public  Int64? Org
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldOrg] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldOrg);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldOrg] = value;
			}
		}
		
		
		public  String Org_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldOrg_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldOrg_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldOrg_Code] = value;
			}
		}
		
		
		public  String Org_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldOrg_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldOrg_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldOrg_Name] = value;
			}
		}
		
		
		public  String FeeID
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldFeeID] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldFeeID);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldFeeID] = value;
			}
		}
		
		
		public  DateTime? OutOn
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldOutOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldOutOn);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldOutOn] = value;
			}
		}
		
		
		public  Decimal? FeeQty
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldFeeQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldFeeQty);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldFeeQty] = value;
			}
		}
		
		
		public  Decimal? BackQty
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldBackQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldBackQty);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldBackQty] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg1
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg1);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg2
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg2);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg3
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg3);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg4
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg4);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg5
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg5);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg6
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg6);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg7
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg7);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg8
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg8);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg9
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg9);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg10
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg10);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg11
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg11);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg12
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg12);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg13
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg13);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg14
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg14);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg15
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg15);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg16
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg16);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg17
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg17);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg18
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg18);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg19
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg19);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg20
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg20);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg21
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg21);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg22
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg22);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg23
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg23);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg24
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg24);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg25
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg25);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg26
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg26);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg27
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg27);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg28
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg28);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg29
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg29);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg30
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg30);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg31
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg31] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg31);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg31] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg32
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg32] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg32);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg32] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg33
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg33] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg33);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg33] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg34
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg34] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg34);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg34] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg35
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg35] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg35);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg35] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg36
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg36] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg36);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg36] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg37
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg37] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg37);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg37] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg38
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg38] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg38);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg38] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg39
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg39] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg39);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg39] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg40
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg40] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg40);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg40] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg41
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg41] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg41);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg41] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg42
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg42] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg42);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg42] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg43
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg43] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg43);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg43] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg44
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg44] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg44);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg44] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg45
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg45] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg45);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg45] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg46
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg46] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg46);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg46] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg47
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg47] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg47);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg47] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg48
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg48] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg48);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg48] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg49
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg49] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg49);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg49] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg50
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg50] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg50);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PubDescSeg50] = value;
			}
		}
		
		
		public  String DescFlexField_ContextValue
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_ContextValue] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_ContextValue);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_ContextValue] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg1);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg2
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg2);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg3
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg3);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg4
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg4);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg5
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg5);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg6
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg6);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg7
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg7);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg8
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg8);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg9
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg9);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg10
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg10);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg11
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg11);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg12
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg12);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg13
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg13);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg14
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg14);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg15
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg15);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg16
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg16);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg17
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg17);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg18
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg18);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg19
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg19);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg20
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg20);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg21
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg21);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg22
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg22);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg23
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg23);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg24
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg24);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg25
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg25);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg26
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg26);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg27
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg27);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg28
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg28);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg29
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg29);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg30);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_PrivateDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_CombineName
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_CombineName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_CombineName);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead.FieldDescFlexField_CombineName] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHeadDefaultFilterFilter();
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
	public partial class Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineView : UIView
	{
		#region Constructor
		public Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineView(IUIModel model) : base(model,"Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine","UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomLine", false)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineView():base(null,"Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine","UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomLine", false)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineView();
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
		public IUIField FieldCust_Xmjl_MO_BomHead
		{
			get { return this.Fields["Cust_Xmjl_MO_BomHead"]; }
		}
		public IUIField FieldRowNo
		{
			get { return this.Fields["RowNo"]; }
		}
		public IUIField FieldQty
		{
			get { return this.Fields["Qty"]; }
		}
		public IUIField FieldShipL
		{
			get { return this.Fields["ShipL"]; }
		}
		public IUIField FieldRcvTransL
		{
			get { return this.Fields["RcvTransL"]; }
		}
		public IUIField FieldMemo
		{
			get { return this.Fields["Memo"]; }
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
		public Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineDefaultFilterFilter DefaultFilter
		{
			get { return (Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","55357610-1d5d-4f62-8969-15b5fcf67fbd");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","7ac0c9e1-3cf7-4cb6-a9e1-8945e56703fa");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","98419878-1e51-4bf3-8b8d-f7dc5e835f76");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","18961be2-b078-4762-ba27-1ffbe67f05ba");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","23f8131c-5cc6-408b-bae7-1daa098aa79d");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","f26f49cd-2300-4fee-aa60-75af63a4fc4f");
			UIModelRuntimeFactory.AddNewUIField(this,"Cust_Xmjl_MO_BomHead", typeof(Int64), true,"","UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomHead", "Cust_Xmjl_MO_BomHead", true,true, false, "",false,(UIFieldType)4,"e1c6f1d4-f9c8-4ecd-96c4-c527cf4f59c0","ec1e2846-ef7c-40ee-b825-2b2eb5c3bfba");
			UIModelRuntimeFactory.AddNewUIField(this,"RowNo", typeof(Int32), true,"0","System.Int32", "RowNo", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","e6bb637c-d0b4-4016-b3f8-e0a3518d994b");
			UIModelRuntimeFactory.AddNewUIField(this,"Qty", typeof(Decimal), true,"0","System.Decimal", "Qty", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","12ac91ae-24b9-4025-95b6-e1c3ad67d509");
			UIModelRuntimeFactory.AddNewUIField(this,"ShipL", typeof(Int64), true,"","UFIDA.U9.InvDoc.MiscShip.MiscShipmentL", "ShipL", true,true, false, "",false,(UIFieldType)4,"0ae88b23-2028-482e-8411-40f532718167","890425e1-1253-413b-a4f6-bfeb47b40279");
			UIModelRuntimeFactory.AddNewUIField(this,"RcvTransL", typeof(Int64), true,"","UFIDA.U9.InvDoc.MiscRcv.MiscRcvTransL", "RcvTransL", true,true, false, "",false,(UIFieldType)4,"74f9f565-0c5d-4506-9bc1-b62b31f9d279","9d8f8fd4-2485-4766-a8a0-94af57b46bc0");
			UIModelRuntimeFactory.AddNewUIField(this,"Memo", typeof(String), true,"","System.String", "Memo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b84a8abe-40d9-41ae-ae76-6886c950c76c");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), true,"","UFIDA.U9.Base.Organization.Organization", "Org", true,true, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","358c7ef6-06db-4b3d-a763-9086da144a6d");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), false,"","System.String", "Org.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1542d156-368a-463c-9699-e0e807dbff8f");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "Org.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a901789e-c997-4c10-b92f-7b8918a876b7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d2352159-6356-49ec-8be1-6f07b569cff2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","037759e7-8b26-442a-a998-a85c6554fea6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7d61f425-70bb-4343-a4fb-d7710c95d1b5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","02e818f9-2cd5-4c46-a583-6209088bf75a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c7a62cd4-193f-494b-9f54-ab5cb9f21dde");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","246f7d50-296a-4a8a-93c3-e0c464a1db99");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","02a73bbe-008a-413b-ad2c-03a1ef1089bd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b1805e32-8bb5-4a20-8abb-48234627b720");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3f751b22-ab1c-4c5b-8728-3c26d5dd8ae4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7de3f96b-94e4-4be5-87b4-cca303455c89");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e9e9e97b-1b7d-4066-82fe-69e3a8c24f7a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","806d825e-8ab5-453b-8e7e-146d35111644");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","739397c2-5f33-4ddb-b9a9-83fbb79837cf");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","188660bc-4905-409f-8e54-93bc87297037");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5327ccc6-1957-4435-a69b-9ac386efb551");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6d994206-6936-41a3-8215-2614ce22c5ac");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","60cb8c7b-1219-470e-8013-fb5192598d11");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","875822bc-b47a-47f7-8101-2f4b7416623a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a2d52c7b-4042-4308-9380-39a79726ee5a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a79b482f-95ed-4d1b-9234-1420af8b7ccf");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","93eea446-3e20-426b-8a69-2d27c8499639");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fc16ccb0-567a-4450-a513-4db3f074decf");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a02c47d1-32e6-40c2-8691-19f2d11ca97f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8a543d77-d42b-4b0c-8c4a-b5361705a5f5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","18d499d2-3044-4309-af36-70ff27132ab0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bd7108f0-3dd4-4419-943f-e41236074024");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dd8ebd40-3b7b-4a94-93a6-13b33b985117");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5ce889ba-b201-46f3-8988-45c797340700");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5395af8a-bc3e-4bc1-b2cb-690f6baba1cc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","41a097da-5751-435f-be2f-76f0b5be4a47");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg31", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","edaa3b32-c6e6-4e89-ac53-787c463f7bc5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg32", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","105323a1-5cc3-4037-ad1e-f009c31cff99");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg33", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","af370a85-d0cc-473b-b2be-4e00663fd59c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg34", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2ed76bfb-7014-4328-992d-9a2c1eb6b189");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg35", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7fe5905c-a71d-430e-95e9-80df4e42a892");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg36", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1aa8e73a-57fd-4be9-a258-058af26ab242");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg37", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7ecea3bd-2014-4f45-ac59-e13527d36f75");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg38", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a0b84eed-7b97-4c2e-a50a-dd18df142b68");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg39", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8f6d3588-93ed-4aa9-a5e1-2a00aeae3df1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg40", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","02186add-16c1-4d0b-a15a-414b34acb050");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg41", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e5d2559f-5d68-4e8b-ba5e-14eb5c0f40a3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg42", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ffab9148-0d6c-4862-8e1c-85ab6cdc0289");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg43", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9de53299-4d7b-40c9-9707-ccb3dc359120");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg44", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6f3ac433-d54d-4073-af3c-e2c320ad8a60");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg45", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6664924e-6152-48cc-b7c1-c387da048778");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg46", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c7e60b5c-1865-48a6-a4ba-fd65a9ebc51b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg47", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6661a962-88e5-48dd-a51a-9ccafd67613e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg48", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dc3ef180-b6e9-477d-8533-fba2488ebf29");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg49", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","37f8c55f-8103-46ab-825e-17c0b7d4e681");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg50", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6a73ceab-acc0-4f17-b82b-c45af671f19c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_ContextValue", typeof(String), true,"","System.String", "DescFlexField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","783964e5-7460-487f-8ada-75cce5340e22");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6208b267-5c32-49f1-9ff6-eb1679e1338a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","38f27afa-d558-4ce1-a1c6-e368e2320c17");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d88c9db6-18c3-4e70-9681-e330d9ea0131");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2d8213b2-5b3f-4111-85cd-e290804a120f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1d0a8e1b-5e6a-4196-ae77-c162817b22aa");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6c7a4ad4-693e-4bf7-b9d4-c7648fdbd85d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4b32e2e7-7cfd-49d4-8581-7ded7df4415a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","68855176-fa2f-4b99-b538-2fb330182350");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ed5f2e78-f81e-4f3d-9ada-78eb806e5b09");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b028157f-9045-4bb9-951c-33995cd9f95b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a3990ff5-9654-4517-83c7-2d3e5265967a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e62dbd30-df16-41de-9ff5-467910b0bda2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","99ea7f0b-429f-4755-a5a5-fa38bc8fd603");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","033511da-f8e1-4b7e-9051-22d52dc05c5a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2cfcf4ba-f770-4738-97ee-a1c727301b3f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ae77f9ea-1d2c-42c0-b8ff-7b77c2064505");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d06ade40-1cf8-489a-9e74-253f4c1fdd8e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0179e6c7-fb44-4873-ae87-af6699395bad");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bc24712c-46ad-4fcc-95fa-5eecc389d3d1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fefc5db9-2910-46e3-be4c-313c257e57be");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fee7df27-5acd-4806-bcef-99f22256b121");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3c251a39-4b88-488b-9840-87911b87f4b2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b886c832-4cf4-478f-bc1f-5b8b5d4f273a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1e4fcad9-a85a-47fa-9fcd-f9cbbf89c079");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c34fa295-9921-49c0-ae83-ba10e65f3360");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5aceb895-51e6-4ec3-9689-dca44fb1cc78");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","82505f5e-cfd9-4ffb-8065-486e9bdc6732");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","878e29cd-2b6c-4bf2-bf50-b768e48b40c9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f074ecba-3e6a-4d2e-af6b-763c371142a5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7a36882d-5b18-4b73-9d03-fe6910771538");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_CombineName", typeof(String), true,"","System.String", "DescFlexField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","237a045d-5dab-455e-95ab-b1954357c73a");


			this.CurrentFilter = new Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineRecord(builder);
		}
		#endregion

		#region new method
		public new Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineRecord FocusedRecord
		{
			get { return (Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineRecord AddNewUIRecord()
		{	
			return (Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineRecord)base.AddNewUIRecord();
		}
		public new Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineRecord NewUIRecord()
		{	
			return (Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineRecord : UIRecord
	{
		#region Constructor
		public Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineView uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine
		{
			get { return (Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldID);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldCreatedOn);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldCreatedBy);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldModifiedOn);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldModifiedBy);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldSysVersion);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? Cust_Xmjl_MO_BomHead
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldCust_Xmjl_MO_BomHead] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldCust_Xmjl_MO_BomHead);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldCust_Xmjl_MO_BomHead] = value;
			}
		}
		
		
		public  Int32? RowNo
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldRowNo] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldRowNo);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldRowNo] = value;
			}
		}
		
		
		public  Decimal? Qty
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldQty);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldQty] = value;
			}
		}
		
		
		public  Int64? ShipL
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldShipL] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldShipL);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldShipL] = value;
			}
		}
		
		
		public  Int64? RcvTransL
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldRcvTransL] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldRcvTransL);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldRcvTransL] = value;
			}
		}
		
		
		public  String Memo
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldMemo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldMemo);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldMemo] = value;
			}
		}
		
		
		public  Int64? Org
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldOrg] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldOrg);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldOrg] = value;
			}
		}
		
		
		public  String Org_Code
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldOrg_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldOrg_Code);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldOrg_Code] = value;
			}
		}
		
		
		public  String Org_Name
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldOrg_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldOrg_Name);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldOrg_Name] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg1
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg1);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg2
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg2);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg3
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg3);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg4
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg4);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg5
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg5);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg6
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg6);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg7
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg7);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg8
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg8);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg9
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg9);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg10
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg10);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg11
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg11);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg12
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg12);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg13
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg13);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg14
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg14);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg15
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg15);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg16
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg16);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg17
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg17);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg18
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg18);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg19
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg19);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg20
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg20);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg21
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg21);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg22
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg22);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg23
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg23);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg24
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg24);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg25
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg25);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg26
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg26);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg27
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg27);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg28
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg28);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg29
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg29);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg30
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg30);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg31
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg31] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg31);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg31] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg32
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg32] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg32);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg32] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg33
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg33] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg33);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg33] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg34
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg34] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg34);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg34] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg35
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg35] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg35);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg35] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg36
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg36] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg36);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg36] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg37
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg37] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg37);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg37] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg38
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg38] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg38);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg38] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg39
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg39] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg39);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg39] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg40
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg40] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg40);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg40] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg41
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg41] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg41);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg41] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg42
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg42] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg42);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg42] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg43
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg43] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg43);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg43] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg44
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg44] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg44);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg44] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg45
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg45] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg45);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg45] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg46
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg46] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg46);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg46] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg47
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg47] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg47);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg47] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg48
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg48] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg48);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg48] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg49
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg49] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg49);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg49] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg50
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg50] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg50);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PubDescSeg50] = value;
			}
		}
		
		
		public  String DescFlexField_ContextValue
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_ContextValue] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_ContextValue);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_ContextValue] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg1);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg2
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg2);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg3
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg3);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg4
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg4);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg5
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg5);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg6
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg6);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg7
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg7);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg8
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg8);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg9
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg9);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg10
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg10);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg11
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg11);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg12
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg12);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg13
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg13);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg14
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg14);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg15
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg15);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg16
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg16);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg17
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg17);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg18
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg18);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg19
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg19);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg20
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg20);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg21
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg21);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg22
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg22);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg23
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg23);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg24
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg24);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg25
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg25);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg26
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg26);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg27
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg27);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg28
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg28);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg29
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg29);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg30);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_PrivateDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_CombineName
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_CombineName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_CombineName);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLine.FieldDescFlexField_CombineName] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new Cust_Xmjl_MO_BomMain_Cust_Xmjl_MO_BomHead_Cust_Xmjl_MO_BomLineDefaultFilterFilter();
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