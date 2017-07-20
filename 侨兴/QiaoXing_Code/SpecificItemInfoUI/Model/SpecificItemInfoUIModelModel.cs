#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.XMQX.SpecificItemInfoUI.SpecificItemInfoUIModel
{
	[Serializable]
	public partial class SpecificItemInfoUIModelModel : UIModel
	{
		#region Constructor
		public SpecificItemInfoUIModelModel() : base("SpecificItemInfoUIModel")
		{
			InitClass();
			this.SetResourceInfo("0cc26ff6-c82d-45f9-b802-2f67d35a63e9");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private SpecificItemInfoUIModelModel(bool isInit) : base("SpecificItemInfoUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new SpecificItemInfoUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private FindSpecificItemInfoMainViewView viewFindSpecificItemInfoMainView;			
		private ShowSpecificitemInfoMainViewView viewShowSpecificitemInfoMainView;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public FindSpecificItemInfoMainViewView FindSpecificItemInfoMainView
		{
			get { return (FindSpecificItemInfoMainViewView)this["FindSpecificItemInfoMainView"]; }
		}
		public ShowSpecificitemInfoMainViewView ShowSpecificitemInfoMainView
		{
			get { return (ShowSpecificitemInfoMainViewView)this["ShowSpecificitemInfoMainView"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewFindSpecificItemInfoMainView = new FindSpecificItemInfoMainViewView(this);
			this.viewFindSpecificItemInfoMainView.SetResourceInfo("9e25b1ef-2a7b-466a-b784-c610365b0a04");
			this.Views.Add(this.viewFindSpecificItemInfoMainView);			
			this.viewShowSpecificitemInfoMainView = new ShowSpecificitemInfoMainViewView(this);
			this.viewShowSpecificitemInfoMainView.SetResourceInfo("f5069791-fcf9-44c8-9419-546b78e1ea1c");
			this.Views.Add(this.viewShowSpecificitemInfoMainView);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.XMQX.SpecificItemInfoUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class FindSpecificItemInfoMainViewView : UIView
	{
		#region Constructor
		public FindSpecificItemInfoMainViewView(IUIModel model) : base(model,"FindSpecificItemInfoMainView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private FindSpecificItemInfoMainViewView():base(null,"FindSpecificItemInfoMainView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new FindSpecificItemInfoMainViewView();
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
		public IUIField FieldWh
		{
			get { return this.Fields["Wh"]; }
		}
		public IUIField FieldWh_Code
		{
			get { return this.Fields["Wh_Code"]; }
		}
		public IUIField FieldWh_Name
		{
			get { return this.Fields["Wh_Name"]; }
		}
		public IUIField FieldItemMaster
		{
			get { return this.Fields["ItemMaster"]; }
		}
		public IUIField FieldItemMaster_Code
		{
			get { return this.Fields["ItemMaster_Code"]; }
		}
		public IUIField FieldItemMaster_Name
		{
			get { return this.Fields["ItemMaster_Name"]; }
		}
		public IUIField FieldLikeName
		{
			get { return this.Fields["LikeName"]; }
		}
		public IUIField FieldOperators
		{
			get { return this.Fields["Operators"]; }
		}
		public IUIField FieldOperators_Code
		{
			get { return this.Fields["Operators_Code"]; }
		}
		public IUIField FieldOperators_Name
		{
			get { return this.Fields["Operators_Name"]; }
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


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public FindSpecificItemInfoMainViewDefaultFilterFilter DefaultFilter
		{
			get { return (FindSpecificItemInfoMainViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","f5143c21-9514-4aaa-9517-9ef5ce07059e");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","264e5e16-5045-4db0-892a-baff4d31f275");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e7dda19e-8c8d-4a37-869a-8df09593dafb");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","1cd7f1dd-6019-4c0f-bec2-f1c451d6b7f3");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1d0fc6db-6b71-4d79-84fb-3086f7443292");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","b7c9a403-59fb-433e-8e36-3d6c7b0d7e4c");
			UIModelRuntimeFactory.AddNewUIField(this,"Wh", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Warehouse.Warehouse", "", false,false, false, "",false,(UIFieldType)4,"0fac5c83-2ab0-428f-bf82-c363857b37be","10dc971e-6432-43e3-8e63-2625173897fd");
			UIModelRuntimeFactory.AddNewUIField(this,"Wh_Code", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","06399f30-cf82-4ee9-9b29-681a055cb9ba");
			UIModelRuntimeFactory.AddNewUIField(this,"Wh_Name", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","032bdcaf-94c3-438e-b075-59f82f1d35ec");
			UIModelRuntimeFactory.AddNewUIField(this,"ItemMaster", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Item.ItemMaster", "", false,false, false, "",false,(UIFieldType)4,"636d3e47-48aa-47fc-aca4-e6322bce775b","bac2f976-9b6b-4000-b1ae-1d842df87552");
			UIModelRuntimeFactory.AddNewUIField(this,"ItemMaster_Code", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","595a07da-4d5f-4170-af27-a74cf551258a");
			UIModelRuntimeFactory.AddNewUIField(this,"ItemMaster_Name", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2a1a3afa-2d12-4827-939f-633c42632139");
			UIModelRuntimeFactory.AddNewUIField(this,"LikeName", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","db74051f-188e-4396-9931-c9b47f43db78");
			UIModelRuntimeFactory.AddNewUIField(this,"Operators", typeof(Int64), true,"","UFIDA.U9.CBO.HR.Operator.Operators", "", false,false, false, "",false,(UIFieldType)4,"198b0f81-207e-4707-8a8c-e0475b7674bd","18a20080-2972-47fd-be29-1b678b8e1e61");
			UIModelRuntimeFactory.AddNewUIField(this,"Operators_Code", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8d347d98-cacb-4099-8172-63e35f2497d8");
			UIModelRuntimeFactory.AddNewUIField(this,"Operators_Name", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bbd26a72-7b55-424b-8f5b-8c742c11b034");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), true,"","UFIDA.U9.Base.Organization.Organization", "", false,false, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","c65956bc-3516-45c5-bc58-d11eda30b772");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8df43487-25c8-42d8-9e3b-8f56116ef071");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1e7f413a-346f-4845-8929-c6a291895b1b");


			this.CurrentFilter = new FindSpecificItemInfoMainViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new FindSpecificItemInfoMainViewRecord(builder);
		}
		#endregion

		#region new method
		public new FindSpecificItemInfoMainViewRecord FocusedRecord
		{
			get { return (FindSpecificItemInfoMainViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new FindSpecificItemInfoMainViewRecord AddNewUIRecord()
		{	
			return (FindSpecificItemInfoMainViewRecord)base.AddNewUIRecord();
		}
		public new FindSpecificItemInfoMainViewRecord NewUIRecord()
		{	
			return (FindSpecificItemInfoMainViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class FindSpecificItemInfoMainViewRecord : UIRecord
	{
		#region Constructor
		public FindSpecificItemInfoMainViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private FindSpecificItemInfoMainViewView uiviewFindSpecificItemInfoMainView
		{
			get { return (FindSpecificItemInfoMainViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new FindSpecificItemInfoMainViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewFindSpecificItemInfoMainView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewFindSpecificItemInfoMainView.FieldID);
			}
			set{
				this[this.uiviewFindSpecificItemInfoMainView.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewFindSpecificItemInfoMainView.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewFindSpecificItemInfoMainView.FieldCreatedOn);
			}
			set{
				this[this.uiviewFindSpecificItemInfoMainView.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewFindSpecificItemInfoMainView.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFindSpecificItemInfoMainView.FieldCreatedBy);
			}
			set{
				this[this.uiviewFindSpecificItemInfoMainView.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewFindSpecificItemInfoMainView.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewFindSpecificItemInfoMainView.FieldModifiedOn);
			}
			set{
				this[this.uiviewFindSpecificItemInfoMainView.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewFindSpecificItemInfoMainView.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFindSpecificItemInfoMainView.FieldModifiedBy);
			}
			set{
				this[this.uiviewFindSpecificItemInfoMainView.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewFindSpecificItemInfoMainView.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewFindSpecificItemInfoMainView.FieldSysVersion);
			}
			set{
				this[this.uiviewFindSpecificItemInfoMainView.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? Wh
		{
			get{
				//object value = this[this.uiviewFindSpecificItemInfoMainView.FieldWh] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewFindSpecificItemInfoMainView.FieldWh);
			}
			set{
				this[this.uiviewFindSpecificItemInfoMainView.FieldWh] = value;
			}
		}
		
		
		public  String Wh_Code
		{
			get{
				//object value = this[this.uiviewFindSpecificItemInfoMainView.FieldWh_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFindSpecificItemInfoMainView.FieldWh_Code);
			}
			set{
				this[this.uiviewFindSpecificItemInfoMainView.FieldWh_Code] = value;
			}
		}
		
		
		public  String Wh_Name
		{
			get{
				//object value = this[this.uiviewFindSpecificItemInfoMainView.FieldWh_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFindSpecificItemInfoMainView.FieldWh_Name);
			}
			set{
				this[this.uiviewFindSpecificItemInfoMainView.FieldWh_Name] = value;
			}
		}
		
		
		public  Int64? ItemMaster
		{
			get{
				//object value = this[this.uiviewFindSpecificItemInfoMainView.FieldItemMaster] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewFindSpecificItemInfoMainView.FieldItemMaster);
			}
			set{
				this[this.uiviewFindSpecificItemInfoMainView.FieldItemMaster] = value;
			}
		}
		
		
		public  String ItemMaster_Code
		{
			get{
				//object value = this[this.uiviewFindSpecificItemInfoMainView.FieldItemMaster_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFindSpecificItemInfoMainView.FieldItemMaster_Code);
			}
			set{
				this[this.uiviewFindSpecificItemInfoMainView.FieldItemMaster_Code] = value;
			}
		}
		
		
		public  String ItemMaster_Name
		{
			get{
				//object value = this[this.uiviewFindSpecificItemInfoMainView.FieldItemMaster_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFindSpecificItemInfoMainView.FieldItemMaster_Name);
			}
			set{
				this[this.uiviewFindSpecificItemInfoMainView.FieldItemMaster_Name] = value;
			}
		}
		
		
		public  String LikeName
		{
			get{
				//object value = this[this.uiviewFindSpecificItemInfoMainView.FieldLikeName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFindSpecificItemInfoMainView.FieldLikeName);
			}
			set{
				this[this.uiviewFindSpecificItemInfoMainView.FieldLikeName] = value;
			}
		}
		
		
		public  Int64? Operators
		{
			get{
				//object value = this[this.uiviewFindSpecificItemInfoMainView.FieldOperators] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewFindSpecificItemInfoMainView.FieldOperators);
			}
			set{
				this[this.uiviewFindSpecificItemInfoMainView.FieldOperators] = value;
			}
		}
		
		
		public  String Operators_Code
		{
			get{
				//object value = this[this.uiviewFindSpecificItemInfoMainView.FieldOperators_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFindSpecificItemInfoMainView.FieldOperators_Code);
			}
			set{
				this[this.uiviewFindSpecificItemInfoMainView.FieldOperators_Code] = value;
			}
		}
		
		
		public  String Operators_Name
		{
			get{
				//object value = this[this.uiviewFindSpecificItemInfoMainView.FieldOperators_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFindSpecificItemInfoMainView.FieldOperators_Name);
			}
			set{
				this[this.uiviewFindSpecificItemInfoMainView.FieldOperators_Name] = value;
			}
		}
		
		
		public  Int64? Org
		{
			get{
				//object value = this[this.uiviewFindSpecificItemInfoMainView.FieldOrg] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewFindSpecificItemInfoMainView.FieldOrg);
			}
			set{
				this[this.uiviewFindSpecificItemInfoMainView.FieldOrg] = value;
			}
		}
		
		
		public  String Org_Code
		{
			get{
				//object value = this[this.uiviewFindSpecificItemInfoMainView.FieldOrg_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFindSpecificItemInfoMainView.FieldOrg_Code);
			}
			set{
				this[this.uiviewFindSpecificItemInfoMainView.FieldOrg_Code] = value;
			}
		}
		
		
		public  String Org_Name
		{
			get{
				//object value = this[this.uiviewFindSpecificItemInfoMainView.FieldOrg_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFindSpecificItemInfoMainView.FieldOrg_Name);
			}
			set{
				this[this.uiviewFindSpecificItemInfoMainView.FieldOrg_Name] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class FindSpecificItemInfoMainViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public FindSpecificItemInfoMainViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"FindSpecificItemInfoMainView.Org=#Context.OrgID#",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private FindSpecificItemInfoMainViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new FindSpecificItemInfoMainViewDefaultFilterFilter();
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
	public partial class ShowSpecificitemInfoMainViewView : UIView
	{
		#region Constructor
		public ShowSpecificitemInfoMainViewView(IUIModel model) : base(model,"ShowSpecificitemInfoMainView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private ShowSpecificitemInfoMainViewView():base(null,"ShowSpecificitemInfoMainView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new ShowSpecificitemInfoMainViewView();
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
		public IUIField FieldIsReqPR
		{
			get { return this.Fields["IsReqPR"]; }
		}
		public IUIField FieldItemMaster
		{
			get { return this.Fields["ItemMaster"]; }
		}
		public IUIField FieldItemMaster_Code
		{
			get { return this.Fields["ItemMaster_Code"]; }
		}
		public IUIField FieldItemMaster_Name
		{
			get { return this.Fields["ItemMaster_Name"]; }
		}
		public IUIField FieldWh
		{
			get { return this.Fields["Wh"]; }
		}
		public IUIField FieldWh_Code
		{
			get { return this.Fields["Wh_Code"]; }
		}
		public IUIField FieldWh_Name
		{
			get { return this.Fields["Wh_Name"]; }
		}
		public IUIField FieldWhQty
		{
			get { return this.Fields["WhQty"]; }
		}
		public IUIField FieldDoingQty
		{
			get { return this.Fields["DoingQty"]; }
		}
		public IUIField FieldDoingPrQty
		{
			get { return this.Fields["DoingPrQty"]; }
		}
		public IUIField FieldRecQty
		{
			get { return this.Fields["RecQty"]; }
		}
		public IUIField FieldPrQty
		{
			get { return this.Fields["PrQty"]; }
		}
		public IUIField FieldReqData
		{
			get { return this.Fields["ReqData"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public ShowSpecificitemInfoMainViewDefaultFilterFilter DefaultFilter
		{
			get { return (ShowSpecificitemInfoMainViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","f92ec0a5-4214-4648-8226-f69695a42563");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","5c0ae121-918e-4e5e-9047-4600168de906");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","80418aa6-523d-4cc4-8e51-87a358092776");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","f1f90e77-7866-4767-90bd-f0cc9831d01f");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8841b577-861d-453e-858c-5aa980aca5d1");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","69fa041f-e6c7-4188-9625-c73706e0aa37");
			UIModelRuntimeFactory.AddNewUIField(this,"IsReqPR", typeof(Boolean), true,"0","System.Decimal", "", false,false, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","2896065f-29f0-45ff-870c-31ea738da144");
			UIModelRuntimeFactory.AddNewUIField(this,"ItemMaster", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Item.ItemMaster", "", false,false, false, "",false,(UIFieldType)4,"636d3e47-48aa-47fc-aca4-e6322bce775b","e7e20c0d-e285-4e2e-a995-b88b48873016");
			UIModelRuntimeFactory.AddNewUIField(this,"ItemMaster_Code", typeof(String), true,"0","System.Decimal", "", false,false, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","f6f70f58-96bc-4786-9c0f-3ea842a41e7d");
			UIModelRuntimeFactory.AddNewUIField(this,"ItemMaster_Name", typeof(String), true,"0","System.Decimal", "", false,false, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","38e99e91-fe81-49f2-9a39-5641e0631281");
			UIModelRuntimeFactory.AddNewUIField(this,"Wh", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Warehouse.Warehouse", "", false,false, false, "",false,(UIFieldType)4,"0fac5c83-2ab0-428f-bf82-c363857b37be","fce38c81-7b01-49df-96b3-229eb5436778");
			UIModelRuntimeFactory.AddNewUIField(this,"Wh_Code", typeof(String), true,"0","System.Decimal", "", false,false, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","bb8cbe7a-d908-497e-b91d-3c551e533881");
			UIModelRuntimeFactory.AddNewUIField(this,"Wh_Name", typeof(String), true,"0","System.Decimal", "", false,false, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","43044a8e-baeb-415e-9768-cd2d9ee94d4d");
			UIModelRuntimeFactory.AddNewUIField(this,"WhQty", typeof(Decimal), true,"0","System.Decimal", "", false,false, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","2e35f369-d086-4c5b-9d74-bf2f40a98c97");
			UIModelRuntimeFactory.AddNewUIField(this,"DoingQty", typeof(Decimal), true,"0","System.Decimal", "", false,false, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","b1338c95-3c30-476a-94d3-27728cc6e809");
			UIModelRuntimeFactory.AddNewUIField(this,"DoingPrQty", typeof(Decimal), true,"0","System.Decimal", "", false,false, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","4d7cf2b5-090e-4941-b29b-aed47572c756");
			UIModelRuntimeFactory.AddNewUIField(this,"RecQty", typeof(Decimal), true,"0","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","525c0076-8a59-4375-838e-7e01250b94a1");
			UIModelRuntimeFactory.AddNewUIField(this,"PrQty", typeof(Decimal), true,"0","System.Decimal", "", false,false, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","0388aa9b-b0e5-4ab1-b65a-5adc72deab0a");
			UIModelRuntimeFactory.AddNewUIField(this,"ReqData", typeof(DateTime), true,"","System.Date", "", false,false, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","0a1af256-1be5-40a2-a0f9-eaf8908ca6e1");


			this.CurrentFilter = new ShowSpecificitemInfoMainViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new ShowSpecificitemInfoMainViewRecord(builder);
		}
		#endregion

		#region new method
		public new ShowSpecificitemInfoMainViewRecord FocusedRecord
		{
			get { return (ShowSpecificitemInfoMainViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new ShowSpecificitemInfoMainViewRecord AddNewUIRecord()
		{	
			return (ShowSpecificitemInfoMainViewRecord)base.AddNewUIRecord();
		}
		public new ShowSpecificitemInfoMainViewRecord NewUIRecord()
		{	
			return (ShowSpecificitemInfoMainViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class ShowSpecificitemInfoMainViewRecord : UIRecord
	{
		#region Constructor
		public ShowSpecificitemInfoMainViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private ShowSpecificitemInfoMainViewView uiviewShowSpecificitemInfoMainView
		{
			get { return (ShowSpecificitemInfoMainViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new ShowSpecificitemInfoMainViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewShowSpecificitemInfoMainView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewShowSpecificitemInfoMainView.FieldID);
			}
			set{
				this[this.uiviewShowSpecificitemInfoMainView.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewShowSpecificitemInfoMainView.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewShowSpecificitemInfoMainView.FieldCreatedOn);
			}
			set{
				this[this.uiviewShowSpecificitemInfoMainView.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewShowSpecificitemInfoMainView.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewShowSpecificitemInfoMainView.FieldCreatedBy);
			}
			set{
				this[this.uiviewShowSpecificitemInfoMainView.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewShowSpecificitemInfoMainView.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewShowSpecificitemInfoMainView.FieldModifiedOn);
			}
			set{
				this[this.uiviewShowSpecificitemInfoMainView.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewShowSpecificitemInfoMainView.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewShowSpecificitemInfoMainView.FieldModifiedBy);
			}
			set{
				this[this.uiviewShowSpecificitemInfoMainView.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewShowSpecificitemInfoMainView.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewShowSpecificitemInfoMainView.FieldSysVersion);
			}
			set{
				this[this.uiviewShowSpecificitemInfoMainView.FieldSysVersion] = value;
			}
		}
		
		
		public  Boolean? IsReqPR
		{
			get{
				//object value = this[this.uiviewShowSpecificitemInfoMainView.FieldIsReqPR] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewShowSpecificitemInfoMainView.FieldIsReqPR);
			}
			set{
				this[this.uiviewShowSpecificitemInfoMainView.FieldIsReqPR] = value;
			}
		}
		
		
		public  Int64? ItemMaster
		{
			get{
				//object value = this[this.uiviewShowSpecificitemInfoMainView.FieldItemMaster] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewShowSpecificitemInfoMainView.FieldItemMaster);
			}
			set{
				this[this.uiviewShowSpecificitemInfoMainView.FieldItemMaster] = value;
			}
		}
		
		
		public  String ItemMaster_Code
		{
			get{
				//object value = this[this.uiviewShowSpecificitemInfoMainView.FieldItemMaster_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewShowSpecificitemInfoMainView.FieldItemMaster_Code);
			}
			set{
				this[this.uiviewShowSpecificitemInfoMainView.FieldItemMaster_Code] = value;
			}
		}
		
		
		public  String ItemMaster_Name
		{
			get{
				//object value = this[this.uiviewShowSpecificitemInfoMainView.FieldItemMaster_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewShowSpecificitemInfoMainView.FieldItemMaster_Name);
			}
			set{
				this[this.uiviewShowSpecificitemInfoMainView.FieldItemMaster_Name] = value;
			}
		}
		
		
		public  Int64? Wh
		{
			get{
				//object value = this[this.uiviewShowSpecificitemInfoMainView.FieldWh] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewShowSpecificitemInfoMainView.FieldWh);
			}
			set{
				this[this.uiviewShowSpecificitemInfoMainView.FieldWh] = value;
			}
		}
		
		
		public  String Wh_Code
		{
			get{
				//object value = this[this.uiviewShowSpecificitemInfoMainView.FieldWh_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewShowSpecificitemInfoMainView.FieldWh_Code);
			}
			set{
				this[this.uiviewShowSpecificitemInfoMainView.FieldWh_Code] = value;
			}
		}
		
		
		public  String Wh_Name
		{
			get{
				//object value = this[this.uiviewShowSpecificitemInfoMainView.FieldWh_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewShowSpecificitemInfoMainView.FieldWh_Name);
			}
			set{
				this[this.uiviewShowSpecificitemInfoMainView.FieldWh_Name] = value;
			}
		}
		
		
		public  Decimal? WhQty
		{
			get{
				//object value = this[this.uiviewShowSpecificitemInfoMainView.FieldWhQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewShowSpecificitemInfoMainView.FieldWhQty);
			}
			set{
				this[this.uiviewShowSpecificitemInfoMainView.FieldWhQty] = value;
			}
		}
		
		
		public  Decimal? DoingQty
		{
			get{
				//object value = this[this.uiviewShowSpecificitemInfoMainView.FieldDoingQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewShowSpecificitemInfoMainView.FieldDoingQty);
			}
			set{
				this[this.uiviewShowSpecificitemInfoMainView.FieldDoingQty] = value;
			}
		}
		
		
		public  Decimal? DoingPrQty
		{
			get{
				//object value = this[this.uiviewShowSpecificitemInfoMainView.FieldDoingPrQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewShowSpecificitemInfoMainView.FieldDoingPrQty);
			}
			set{
				this[this.uiviewShowSpecificitemInfoMainView.FieldDoingPrQty] = value;
			}
		}
		
		
		public  Decimal? RecQty
		{
			get{
				//object value = this[this.uiviewShowSpecificitemInfoMainView.FieldRecQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewShowSpecificitemInfoMainView.FieldRecQty);
			}
			set{
				this[this.uiviewShowSpecificitemInfoMainView.FieldRecQty] = value;
			}
		}
		
		
		public  Decimal? PrQty
		{
			get{
				//object value = this[this.uiviewShowSpecificitemInfoMainView.FieldPrQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewShowSpecificitemInfoMainView.FieldPrQty);
			}
			set{
				this[this.uiviewShowSpecificitemInfoMainView.FieldPrQty] = value;
			}
		}
		
		
		public  DateTime? ReqData
		{
			get{
				//object value = this[this.uiviewShowSpecificitemInfoMainView.FieldReqData] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewShowSpecificitemInfoMainView.FieldReqData);
			}
			set{
				this[this.uiviewShowSpecificitemInfoMainView.FieldReqData] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class ShowSpecificitemInfoMainViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public ShowSpecificitemInfoMainViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private ShowSpecificitemInfoMainViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new ShowSpecificitemInfoMainViewDefaultFilterFilter();
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