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
		private AdvCarrierListView viewAdvCarrierList;			
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
		public AdvCarrierListView AdvCarrierList
		{
			get { return (AdvCarrierListView)this["AdvCarrierList"]; }
		}
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
			this.viewAdvCarrierList = new AdvCarrierListView(this);
			this.viewAdvCarrierList.SetResourceInfo("29ce6b80-71e9-4ad3-8d14-5407ae22234b");
			this.Views.Add(this.viewAdvCarrierList);			
			this.viewAdvApplyBE = new AdvApplyBEView(this);
			this.viewAdvApplyBE.SetResourceInfo("2fb13fc0-3477-4b5a-b965-f8b3c9784fe3");
			this.Views.Add(this.viewAdvApplyBE);			
			this.viewAdvApplyBE_AdvAboutBE = new AdvApplyBE_AdvAboutBEView(this);
			this.viewAdvApplyBE_AdvAboutBE.SetResourceInfo("770a1c27-6b18-4713-9b89-12525341fe74");
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
	public partial class AdvCarrierListView : UIView
	{
		#region Constructor
		public AdvCarrierListView(IUIModel model) : base(model,"AdvCarrierList","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private AdvCarrierListView():base(null,"AdvCarrierList","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new AdvCarrierListView();
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


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public AdvCarrierListDefaultFilterFilter DefaultFilter
		{
			get { return (AdvCarrierListDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","55a5e707-4f40-4ca6-a5c0-f42feb0e3f93");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","d6983489-1854-4fe6-b127-78e98c97e535");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e47881ac-8a38-4a1b-8641-a92698ad8939");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","4fa21ddd-86ea-4ccc-ad3c-ed164f4118f4");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fdce3b61-0729-4da1-9592-210d0755da15");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","a455ff08-a34f-437c-8f88-c6f7387f152f");
			UIModelRuntimeFactory.AddNewUIField(this,"Code", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d9dbcbae-7f0f-4ae9-838c-9c87116f4a08");
			UIModelRuntimeFactory.AddNewUIField(this,"Name", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","708d9a03-9b22-4446-b217-8f94a441a9d8");
			UIModelRuntimeFactory.AddNewUIField(this,"IsSelected", typeof(Boolean), true,"false","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9798c1d3-c13c-400f-941d-0636a1be7266");
			UIModelRuntimeFactory.AddNewUIField(this,"Description", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d6c8effe-41f3-413c-b060-c053334ade7f");


			this.CurrentFilter = new AdvCarrierListDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new AdvCarrierListRecord(builder);
		}
		#endregion

		#region new method
		public new AdvCarrierListRecord FocusedRecord
		{
			get { return (AdvCarrierListRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new AdvCarrierListRecord AddNewUIRecord()
		{	
			return (AdvCarrierListRecord)base.AddNewUIRecord();
		}
		public new AdvCarrierListRecord NewUIRecord()
		{	
			return (AdvCarrierListRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class AdvCarrierListRecord : UIRecord
	{
		#region Constructor
		public AdvCarrierListRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private AdvCarrierListView uiviewAdvCarrierList
		{
			get { return (AdvCarrierListView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new AdvCarrierListRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewAdvCarrierList.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAdvCarrierList.FieldID);
			}
			set{
				this[this.uiviewAdvCarrierList.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewAdvCarrierList.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewAdvCarrierList.FieldCreatedOn);
			}
			set{
				this[this.uiviewAdvCarrierList.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewAdvCarrierList.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvCarrierList.FieldCreatedBy);
			}
			set{
				this[this.uiviewAdvCarrierList.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewAdvCarrierList.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewAdvCarrierList.FieldModifiedOn);
			}
			set{
				this[this.uiviewAdvCarrierList.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewAdvCarrierList.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvCarrierList.FieldModifiedBy);
			}
			set{
				this[this.uiviewAdvCarrierList.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewAdvCarrierList.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAdvCarrierList.FieldSysVersion);
			}
			set{
				this[this.uiviewAdvCarrierList.FieldSysVersion] = value;
			}
		}
		
		
		public  String Code
		{
			get{
				//object value = this[this.uiviewAdvCarrierList.FieldCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvCarrierList.FieldCode);
			}
			set{
				this[this.uiviewAdvCarrierList.FieldCode] = value;
			}
		}
		
		
		public new String Name
		{
			get{
				//object value = this[this.uiviewAdvCarrierList.FieldName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvCarrierList.FieldName);
			}
			set{
				this[this.uiviewAdvCarrierList.FieldName] = value;
			}
		}
		
		
		public  Boolean? IsSelected
		{
			get{
				//object value = this[this.uiviewAdvCarrierList.FieldIsSelected] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewAdvCarrierList.FieldIsSelected);
			}
			set{
				this[this.uiviewAdvCarrierList.FieldIsSelected] = value;
			}
		}
		
		
		public  String Description
		{
			get{
				//object value = this[this.uiviewAdvCarrierList.FieldDescription] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvCarrierList.FieldDescription);
			}
			set{
				this[this.uiviewAdvCarrierList.FieldDescription] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class AdvCarrierListDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public AdvCarrierListDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private AdvCarrierListDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new AdvCarrierListDefaultFilterFilter();
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","63182282-485a-4366-ab2e-7e38cf2b96a8");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","957cb4eb-dac6-4eb8-9b8f-08a038b5f9a5");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cfc91cec-2161-4d59-8223-3c91b10cee42");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","159a992d-4591-48ea-95b5-02a76034d0ad");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","84c88026-2f57-4b20-a4da-59a4cfc595c3");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","a8bbead4-85da-452c-953f-d6220e65b177");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), false,"","UFIDA.U9.Base.Organization.Organization", "Org", true,true, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","f6c4e5c5-4125-4f3e-b062-42439d650e24");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), false,"","System.String", "Org.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","11643d4b-b323-49ba-a87e-246eb438b16c");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "Org.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cfba5011-3880-4114-b121-92eeb157c57e");
			UIModelRuntimeFactory.AddNewUIField(this,"DocNo", typeof(String), false,"","System.String", "DocNo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","db75316c-74a6-4bef-9e80-9bd28f1e9d05");
			UIModelRuntimeFactory.AddNewUIField(this,"BusinessDate", typeof(DateTime), false,"","System.Date", "BusinessDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","c8470b24-9335-4074-9087-90fbb8f572a4");
			UIModelRuntimeFactory.AddNewUIField(this,"Version", typeof(Int32), true,"0","System.Int32", "Version", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","28fe1231-4eb4-4ed5-beea-8d2fe434a5df");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintAmount", typeof(Int32), true,"0","System.Int32", "PrintAmount", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","01877297-097e-4aa8-b81a-30db4baf6626");
			UIModelRuntimeFactory.AddNewUIField(this,"LatestPrintedDate", typeof(DateTime), true,"","System.DateTime", "LatestPrintedDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","a16e558b-b4b1-4fe5-b67e-76c2d634eb80");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_Canceled", typeof(Boolean), true,"false","System.Boolean", "Cancel.Canceled", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","f65fcc96-1a65-4317-a418-9a96a6d2f261");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelDate", typeof(DateTime), true,"","System.DateTime", "Cancel.CancelDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","bb719ebc-cbc4-4875-b1cc-14eb9ef06079");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelReason", typeof(String), true,"","System.String", "Cancel.CancelReason", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b923e826-2db2-4901-ac59-a8d3b7e52845");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelUser", typeof(String), true,"","System.String", "Cancel.CancelUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f43e8059-c856-48c9-a6d1-4b5231ed453e");
			UIModelRuntimeFactory.AddNewUIField(this,"WorkFlowID", typeof(Guid), true,"","System.Guid", "WorkFlowID", true,true, false, "",false,(UIFieldType)1,"2b057235-c58e-441e-9477-5e52fcb7f95b","5543a5c7-2fa6-488a-ac6a-f8513351235e");
			UIModelRuntimeFactory.AddNewUIField(this,"StateMachineID", typeof(Guid), true,"","System.Guid", "StateMachineID", true,true, false, "",false,(UIFieldType)1,"2b057235-c58e-441e-9477-5e52fcb7f95b","8e0e09e2-0a7b-4b96-bd92-9c01ef3a9c4f");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason", typeof(Int64), true,"","UFIDA.U9.Base.HoldRelease.HoldReason", "HoldReason", true,true, false, "",false,(UIFieldType)4,"aca6401c-cd2c-460c-9883-a704f9ea93a6","33c1b9fa-bb1f-40a2-8d14-150dea56e2a1");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason_Code", typeof(String), false,"","System.String", "HoldReason.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","981e80c0-3838-4c24-8fae-b541df6e9b14");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason_Name", typeof(String), true,"","System.String", "HoldReason.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ae4fab1e-f074-4281-8081-740102814c15");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldUser", typeof(String), true,"","System.String", "HoldUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b14fb496-5c1a-43b5-bc58-277ffdf674ab");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldDate", typeof(DateTime), true,"","System.DateTime", "HoldDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","2a74e117-8c1e-48fc-9549-8fd04bb3b215");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason", typeof(Int64), true,"","UFIDA.U9.Base.HoldRelease.ReleaseReason", "ReleaseReason", true,true, false, "",false,(UIFieldType)4,"8f4c20a0-ea48-4e30-a76a-1f8d38bcc7cc","815a681c-a93f-4d21-907c-c42ba659db59");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason_Code", typeof(String), false,"","System.String", "ReleaseReason.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","768b3078-2c89-4db4-8105-9fff948f06d9");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason_Name", typeof(String), true,"","System.String", "ReleaseReason.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","020e0231-2c2e-4340-81cd-5d59bf1cfdd5");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseUser", typeof(String), true,"","System.String", "ReleaseUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1fb2b7de-e2e6-4419-b226-c72c06822718");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseDate", typeof(DateTime), true,"","System.DateTime", "ReleaseDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","3109f94e-65cf-4b06-9398-a781ccc6bad2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a2ccc209-418c-4094-84ed-0eaeba95fc37");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","06c21877-ffc1-4a20-b1e8-38301f204dc5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","62f08791-cf55-4705-a62c-7ec3e99888a7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","58aed52b-9ffe-470b-96ad-cc7c453e12dd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","46b532f8-9c6b-4f04-b00a-a48dcaa6ebbe");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fa2c33c1-dfb8-4a70-bbd0-236ed216fa01");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","75bf9c04-4875-47ab-ab0d-2f0eb169ad5f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9e344309-b058-4c44-88b3-1c71fb8a62d1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e9971014-4b8f-4fc3-a369-651a15f45a18");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f14017ff-ec85-4769-afa7-d98d7e4aed6b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9ef88183-d4f1-436a-98aa-a05b2bf859f0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","76fc712a-334e-438f-9799-423671f11c7c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","40abc790-d8f0-4117-83fd-8178d71cc611");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e6e0dcdc-4578-4278-a872-feba86c450d2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","daa96cb4-3ad1-4d8f-87d7-6de6d5e6ca91");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4b87fb3d-0e15-429d-b542-785873ecb377");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","839e1286-ceda-4028-9ff2-82bc6349eea5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","91a043a9-acb7-4c0c-8639-b2561a98f11f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8a299566-7bee-4bcc-b081-7493f2c52624");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","861d32dd-d25f-4a55-b27c-cc98217c2b85");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d8a2108e-7f5b-4d7f-b56a-d421fa43f8b6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","30129a57-ac76-44bd-bb1d-e128b189e311");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8beac94c-f831-4494-b7f1-1c2f2b51b365");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","500aa666-3270-45f7-8964-fa008667081c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9a6e2cd0-6b1c-494e-80c9-0c53f0ed18f5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","123bd73a-39ff-4267-9559-2d528e8b0b66");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ca76d46e-48cc-48a2-9506-0c51b9c6210e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","de8aab8a-d781-4ca9-ab0b-77077410da43");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8272d4ea-1b88-44e2-ad50-3ced43517c96");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2f74b26d-da6b-450b-ae3d-c3fb086fb4ea");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg31", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","35ab3eb2-ac77-46c0-a508-e914916bdfba");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg32", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d13aa087-3c7d-419d-959b-3fa7c037cfe1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg33", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bd579f46-e75d-4d7b-8140-4eb95fa4cb97");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg34", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c68e9a66-286d-49d6-b7dd-a8e0c93e084d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg35", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f88aa923-4469-4561-a12c-de688e183434");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg36", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f553c14e-64f5-45f9-ae2f-1f9cf5bfe997");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg37", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","815ca48e-6283-4c2c-8395-e43fad4cb67a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg38", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","392e45ac-6731-4667-a59b-3a27cab5409e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg39", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e36ced40-da48-4a9d-a8a9-b932dae57c71");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg40", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7b776ba7-c716-4795-a4de-6e4c2e17079a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg41", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1efc4eef-bef2-42ba-8adc-67da5ce93c07");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg42", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","739a7e93-a09c-45a1-8c38-f45b6fae296e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg43", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a4507647-e92a-4e79-a41d-b1a4a498f3ed");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg44", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e98e2ee9-341f-4a4f-a97a-c37c4702776e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg45", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fe317539-a9fb-4b7a-8dd2-b0ce1064d264");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg46", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c9a834e2-db4c-4b8e-a385-e4688c8fba6d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg47", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3cd3a83d-0873-40e6-b656-df73795f764e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg48", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","323c89e1-e11e-4c90-90c3-46db0b33de45");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg49", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dfd711c4-f789-41ce-b669-32bcc981da9e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg50", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0585d999-3826-4862-a2d7-6675a6a08525");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_ContextValue", typeof(String), true,"","System.String", "DescFlexField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0b4c426f-7488-418f-b7d3-a4d329e7daa2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5cba0d9b-fa49-4ce5-aa14-e1158d646292");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","92637d41-0628-4f87-ac59-f764bcb0758e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9ea0271e-0eb6-41b1-bf2a-b811457366cc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","40914d7f-3bad-4c53-92f1-d5adf44bdb10");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","373429d4-1d65-45e6-b921-3aaca4e1bfd0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","df31718a-0edc-4a5a-85fe-797924a4f61c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bd976675-b700-41d5-87eb-645803fa921a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7ef518e6-87d3-4fdf-84d1-ec9825f25c1d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","de9dae20-844f-476c-9a9f-54e76db58e25");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0fc23b01-99b3-4052-9715-45a88d0cef69");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","67de5e7e-a71e-449e-ad4a-99a3f2982ea3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2837a9a5-f301-4dbb-987f-af1b42137e26");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","04ec395f-2a0f-4ea6-869b-298190c29f31");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e9bfe7cb-b56c-45fa-9a91-38bdc595c5cc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0c0c4785-af9d-41c4-95e8-687ac0768f6d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2be91b37-fe22-49fa-bc76-35b1467c99d3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6da36614-6dfe-48c3-88bd-70c19c2103c2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","867d753a-614f-4e67-907f-b4127e7e88bc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8e1db422-eecb-44c5-a75b-b3ff1a9d218e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b2ca3ddd-6166-4df4-8604-7f903dddbed2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bcf850e4-2b56-4669-b8f0-b261f676c457");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7716b1b3-0e00-4ba3-bd84-c25cd08dcd7b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b9e0c893-8852-40be-a6d5-d2e0c6e45abf");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c95bf485-eab5-4916-b2e9-45b0cea5e61f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c8552cf3-bc8a-4c3a-8e61-349156299c9b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f8260b53-2abe-4036-95a0-a06c2edf8df6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","12881179-8301-42f7-aab3-b5864a56df30");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0e268932-97b9-45e3-8bad-6db0988f0bfc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2512fc5a-be5e-4c56-9b8d-b62d3056066f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c4194d30-0581-4500-8b4e-ad3f56c847c1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_CombineName", typeof(String), true,"","System.String", "DescFlexField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","68a6773a-1e16-4d5d-88f9-7660dd3aba9a");
			UIModelRuntimeFactory.AddNewUIField(this,"FlowInstance", typeof(Int64), true,"","UFIDA.U9.CS.Workflow.WorkflowInstanceBE.FlowInstance", "FlowInstance", true,true, false, "",false,(UIFieldType)4,"d87a7006-6643-42f4-98f4-168847a71955","ef83fa13-f6bd-4d0e-b386-f358b219caec");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvCode", typeof(String), true,"","System.String", "AdvCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a5994f4f-99b6-42c9-9506-1579b4ef175d");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept", typeof(Int64), false,"","UFIDA.U9.CBO.SCM.Customer.Customer", "ApplyDept", true,true, false, "",false,(UIFieldType)4,"8508f308-9d66-4b1d-abf4-e28dab8e926d","4173579c-5182-48af-9c2b-1906636a232e");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept_Code", typeof(String), false,"","System.String", "ApplyDept.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","05a1e21b-a74d-421e-89b5-da603d2bfafa");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept_Name", typeof(String), true,"","System.String", "ApplyDept.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9b76f3a7-9ee2-4aea-aa2b-e8f0ae40d1e2");
			UIModelRuntimeFactory.AddNewUIField(this,"Applier", typeof(String), false,"","System.String", "Applier", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","88898774-77ed-4647-ae73-04a6260fccc1");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDate", typeof(DateTime), true,"","System.Date", "ApplyDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","96090f17-fc32-4518-8b32-016e9765756e");
			UIModelRuntimeFactory.AddNewUIField(this,"Phone", typeof(String), false,"","System.String", "Phone", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0c16ae75-6ab0-448d-b39f-62a72b9a6d2f");
			UIModelRuntimeFactory.AddNewUIField(this,"QQ", typeof(String), false,"","System.String", "QQ", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","47f73963-a3c5-4539-a893-ee1668984fe5");
			UIModelRuntimeFactory.AddNewUIField(this,"CustConterName", typeof(String), false,"","System.String", "CustConterName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4938bf60-3a01-47a4-b66f-21f37db88257");
			UIModelRuntimeFactory.AddNewUIField(this,"LocationQY", typeof(String), true,"","System.String", "LocationQY", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","04d4fd5d-66a1-451d-b463-ff637490a75f");
			UIModelRuntimeFactory.AddNewUIField(this,"LocationXZ", typeof(String), true,"","System.String", "LocationXZ", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b33a26a8-4d8f-45f9-b27d-7486bf736102");
			UIModelRuntimeFactory.AddNewUIField(this,"RelPeople", typeof(String), false,"","System.String", "RelPeople", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3f02ff6d-6292-4915-a6b3-5ca541a13620");
			UIModelRuntimeFactory.AddNewUIField(this,"CustPhone", typeof(String), false,"","System.String", "CustPhone", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","01d9cd92-bb77-4862-820d-a86179f2c939");
			UIModelRuntimeFactory.AddNewUIField(this,"CustAddress", typeof(String), false,"","System.String", "CustAddress", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ed7d9987-fd4f-4ce3-9c07-f2e9aa9d4587");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvCarrier", typeof(Int64), false,"","UFIDA.U9.CBO.SCM.Item.ItemMaster", "AdvCarrier", true,true, false, "",false,(UIFieldType)4,"636d3e47-48aa-47fc-aca4-e6322bce775b","96260a2b-42a8-4ec6-baf8-a0dfd338337a");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvCarrier_Code", typeof(String), false,"","System.String", "AdvCarrier.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","21bd5e3b-d602-4f05-b334-c2379ca88293");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvCarrier_Name", typeof(String), false,"","System.String", "AdvCarrier.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","13eb2e1b-486c-479e-8939-eaecf82db035");
			UIModelRuntimeFactory.AddNewUIField(this,"TotalArea", typeof(Decimal), true,"0","System.Decimal", "TotalArea", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","7c6e9240-1a1b-46c2-93a7-bfd1059217ff");
			UIModelRuntimeFactory.AddNewUIField(this,"Qty", typeof(Decimal), true,"0","System.Decimal", "Qty", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","578b9158-ca19-4eef-9085-976fb441113e");
			UIModelRuntimeFactory.AddNewUIField(this,"BMWidth", typeof(Decimal), true,"0","System.Decimal", "BMWidth", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","5fdfce09-6cc4-4694-ac3d-208013aec390");
			UIModelRuntimeFactory.AddNewUIField(this,"BMHight", typeof(Decimal), true,"0","System.Decimal", "BMHight", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","ae7c9dde-fa4b-4f1d-a47b-f234a67413e0");
			UIModelRuntimeFactory.AddNewUIField(this,"BMThick", typeof(Decimal), true,"0","System.Decimal", "BMThick", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","5b842a90-21bc-45c7-b35d-7f451724faf0");
			UIModelRuntimeFactory.AddNewUIField(this,"BMArea", typeof(Decimal), true,"0","System.Decimal", "BMArea", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","342a27d0-ab2e-4417-bd8f-6b099b6dffe5");
			UIModelRuntimeFactory.AddNewUIField(this,"DZWidth", typeof(Decimal), true,"0","System.Decimal", "DZWidth", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","6dd7fd92-325c-4888-9831-078e1a6b5847");
			UIModelRuntimeFactory.AddNewUIField(this,"DZThick", typeof(Decimal), true,"0","System.Decimal", "DZThick", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","546bb334-2cc7-4c33-a847-eece4b6dd000");
			UIModelRuntimeFactory.AddNewUIField(this,"DZArea", typeof(Decimal), true,"0","System.Decimal", "DZArea", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","43d1faad-c6ad-4c2f-8eeb-d52b9391c241");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvDisplayType", typeof(Int32), false,"-1","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvDisplayTypeEnum", "AdvDisplayType", true,true, false, "",false,(UIFieldType)2,"0baa04a7-e868-40b1-b5a0-6cfacca13640","97af5541-bb31-42ec-a2f4-280c2d363eea");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvDispInfo1", typeof(Int32), false,"-1","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvPageReq1Enum", "AdvDispInfo1", true,true, false, "",false,(UIFieldType)2,"6fb34584-eb7b-4f6a-ba52-24c597b35239","ea8b6132-04a8-480f-8ff4-17cc69d47b4c");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvDispInfo2", typeof(Int32), false,"-1","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvPageReq2Enum", "AdvDispInfo2", true,true, false, "",false,(UIFieldType)2,"550b275c-3802-46fc-9584-c3dc308fcf17","1a326bea-0f00-49bc-b8dc-5f97a9a7de2d");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvMemo", typeof(String), true,"","System.String", "AdvMemo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","175057c2-2a35-48d7-9e30-403d5b451375");
			UIModelRuntimeFactory.AddNewUIField(this,"ApproveQty", typeof(Decimal), true,"0","System.Decimal", "ApproveQty", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","da401035-2bf5-4342-86c3-246e759aa7fc");
			UIModelRuntimeFactory.AddNewUIField(this,"IsClose", typeof(Boolean), true,"false","System.Boolean", "IsClose", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","0da59d4f-1919-44a9-aaf5-4fd56fde43df");
			UIModelRuntimeFactory.AddNewUIField(this,"Flow4Bit", typeof(Int32), true,"0","System.Int32", "Flow4Bit", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","82e7e5af-4f7a-4db6-bdc5-db9232117477");
			UIModelRuntimeFactory.AddNewUIField(this,"WFCurrentState", typeof(Int32), false,"-1","System.Int32", "WFCurrentState", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","00646ff8-13ab-4bd7-85cf-1dc6cdf6929f");
			UIModelRuntimeFactory.AddNewUIField(this,"WFOriginalState", typeof(Int32), false,"-1","System.Int32", "WFOriginalState", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","4aaf7daa-063d-4846-b399-5db3cf477359");
			UIModelRuntimeFactory.AddNewUIField(this,"DocStatus", typeof(Int32), true,"0","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyStatusEnum", "DocStatus", true,true, false, "",false,(UIFieldType)2,"20babf0c-275e-4cb2-a9b5-a751bb8152bf","27264278-a7f6-4c14-9baa-5f9a4012a0dd");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyDocType", typeof(Int64), false,"","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType", "AdvApplyDocType", true,true, false, "",false,(UIFieldType)4,"0ab4dca1-e716-4d53-8bb2-0ef1483d9f4a","a3a90268-cecf-429a-ba35-1cb4c309cb2d");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyDocType_Code", typeof(String), false,"","System.String", "AdvApplyDocType.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0cbfb334-a513-4e1b-9581-12ca6b9cd385");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyDocType_Name", typeof(String), true,"","System.String", "AdvApplyDocType.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b2325f25-4127-4ac8-8b54-a2a85a4676b6");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyDocType_ConfirmType", typeof(Int32), false,"0","UFIDA.U9.Base.Doc.ConfirmTypeEnum", "AdvApplyDocType.ConfirmType", false,true, false, "",false,(UIFieldType)2,"d232b8fb-1938-4ebe-a90c-41c911c0bc10","a3c563d4-337a-4ee9-9269-62bc777ba442");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyDocType_ApproveType", typeof(Int32), true,"-1","UFIDA.U9.Base.Doc.ApproveTypeEnum", "AdvApplyDocType.ApproveType", false,true, false, "",false,(UIFieldType)2,"d4b6e1a9-d80d-4516-8316-4b1d436cd449","be38d181-4a6b-4767-9188-5f75a7f0920c");


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
		
		
		public  Int64 ApplyDept
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldApplyDept] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAdvApplyBE.FieldApplyDept);
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
		
		
		public  Int64 AdvCarrier
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvCarrier] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAdvApplyBE.FieldAdvCarrier);
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
		
		
		public  Int32 AdvDisplayType
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvDisplayType] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewAdvApplyBE.FieldAdvDisplayType);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvDisplayType] = value;
			}
		}
		
		
		public  Int32 AdvDispInfo1
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvDispInfo1] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewAdvApplyBE.FieldAdvDispInfo1);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvDispInfo1] = value;
			}
		}
		
		
		public  Int32 AdvDispInfo2
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvDispInfo2] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewAdvApplyBE.FieldAdvDispInfo2);
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
		
		
		public  Int64 AdvApplyDocType
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvApplyDocType] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAdvApplyBE.FieldAdvApplyDocType);
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


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public AdvApplyBE_AdvAboutBEDefaultFilterFilter DefaultFilter
		{
			get { return (AdvApplyBE_AdvAboutBEDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","ac474948-5d1b-41ed-b5c9-86405db85e0e");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","02d37b1c-36f5-4348-ab0e-cda3d5bb6dbd");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7a12dde6-7c18-43ee-9aff-46b642c779b5");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","3a2cd505-fdd4-4886-84ae-1b86f886338f");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e4ce4fec-a441-4467-aed1-05415ec4800b");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","36e624b3-73f4-4fba-9b6c-80fc8f245da9");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyBE", typeof(Int64), true,"","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE", "AdvApplyBE", true,true, false, "",false,(UIFieldType)4,"34b34c55-0b84-4313-8595-ec236b56752e","70c24d36-e6b7-4236-8838-61baa20d3b77");
			UIModelRuntimeFactory.AddNewUIField(this,"Code", typeof(String), true,"","System.String", "Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4836036e-f3aa-42e1-a489-47ef4ac041f5");
			UIModelRuntimeFactory.AddNewUIField(this,"Name", typeof(String), true,"","System.String", "Name", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","514c723f-f5df-4c4d-b456-9ca4dcd7e884");
			UIModelRuntimeFactory.AddNewUIField(this,"IsSelected", typeof(Boolean), true,"false","System.Boolean", "IsSelected", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","714ec1ce-64a7-4636-b14e-f0103ecd0882");
			UIModelRuntimeFactory.AddNewUIField(this,"Description", typeof(String), true,"","System.String", "Description", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","834830bb-16f5-4b24-af54-aa7a06b4cdbd");


			this.CurrentFilter = new AdvApplyBE_AdvAboutBEDefaultFilterFilter(this);
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
	
	[Serializable]
	public class AdvApplyBE_AdvAboutBEDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public AdvApplyBE_AdvAboutBEDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private AdvApplyBE_AdvAboutBEDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new AdvApplyBE_AdvAboutBEDefaultFilterFilter();
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