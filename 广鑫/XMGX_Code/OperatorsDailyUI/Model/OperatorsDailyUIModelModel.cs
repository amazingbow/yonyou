#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.FJGX.OperatorsDailyUIModel
{
	[Serializable]
	public partial class OperatorsDailyUIModelModel : UIModel
	{
		#region Constructor
		public OperatorsDailyUIModelModel() : base("OperatorsDailyUIModel")
		{
			InitClass();
			this.SetResourceInfo("28c27081-7dff-4a39-8760-8dcd0b31373c");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private OperatorsDailyUIModelModel(bool isInit) : base("OperatorsDailyUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new OperatorsDailyUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private OperatorsDailyView viewOperatorsDaily;			
		private ListViewView viewListView;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public OperatorsDailyView OperatorsDaily
		{
			get { return (OperatorsDailyView)this["OperatorsDaily"]; }
		}
		public ListViewView ListView
		{
			get { return (ListViewView)this["ListView"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewOperatorsDaily = new OperatorsDailyView(this);
			this.viewOperatorsDaily.SetResourceInfo("cc89070d-920c-4ef0-b365-08b72614f8f6");
			this.Views.Add(this.viewOperatorsDaily);			
			this.viewListView = new ListViewView(this);
			this.viewListView.SetResourceInfo("5e81f797-7006-4cec-aafc-62b98bfea8b5");
			this.Views.Add(this.viewListView);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.FJGX.OperatorsDailyUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class OperatorsDailyView : UIView
	{
		#region Constructor
		public OperatorsDailyView(IUIModel model) : base(model,"OperatorsDaily","UFIDA.U9.Cust.FJGX.OperatorsDailyBE.OperatorsDaily", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private OperatorsDailyView():base(null,"OperatorsDaily","UFIDA.U9.Cust.FJGX.OperatorsDailyBE.OperatorsDaily", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new OperatorsDailyView();
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
		public IUIField FieldDailyDate
		{
			get { return this.Fields["DailyDate"]; }
		}
		public IUIField FieldDailyContent
		{
			get { return this.Fields["DailyContent"]; }
		}
		public IUIField FieldCustomer
		{
			get { return this.Fields["Customer"]; }
		}
		public IUIField FieldCustomer_Code
		{
			get { return this.Fields["Customer_Code"]; }
		}
		public IUIField FieldCustomer_Name
		{
			get { return this.Fields["Customer_Name"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public OperatorsDailyDefaultFilterFilter DefaultFilter
		{
			get { return (OperatorsDailyDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","30073064-f10f-492e-8885-57feb39bace0");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","03be3506-470b-4103-9f2b-00cb2cfb7053");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ef766d27-7ae8-471f-9367-1a95d284510f");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","ca3ea2f6-03c1-411d-91bc-881e1c37f083");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","66b7b223-13a5-4023-a55f-2300df4a809e");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","b2e38c4b-9abb-4b4b-aeb4-5957c86aa173");
			UIModelRuntimeFactory.AddNewUIField(this,"DailyDate", typeof(DateTime), false,"","System.DateTime", "DailyDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","cd8f98fb-d51a-4982-b7e1-cf71dae0b52c");
			UIModelRuntimeFactory.AddNewUIField(this,"DailyContent", typeof(String), false,"","System.String", "DailyContent", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","79508d21-4f6e-4650-9eef-61f1f6c0689e");
			UIModelRuntimeFactory.AddNewUIField(this,"Customer", typeof(Int64), false,"","UFIDA.U9.CBO.SCM.Customer.Customer", "Customer", true,true, false, "",false,(UIFieldType)4,"8508f308-9d66-4b1d-abf4-e28dab8e926d","02f6b920-e898-4142-8e18-4a43d81c7c61");
			UIModelRuntimeFactory.AddNewUIField(this,"Customer_Code", typeof(String), false,"","System.String", "Customer.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e06c3273-7b00-408c-b87f-5d51b77c6117");
			UIModelRuntimeFactory.AddNewUIField(this,"Customer_Name", typeof(String), true,"","System.String", "Customer.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","87aeca2a-990c-4f38-bbf0-4e189b1065ae");


			this.CurrentFilter = new OperatorsDailyDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new OperatorsDailyRecord(builder);
		}
		#endregion

		#region new method
		public new OperatorsDailyRecord FocusedRecord
		{
			get { return (OperatorsDailyRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new OperatorsDailyRecord AddNewUIRecord()
		{	
			return (OperatorsDailyRecord)base.AddNewUIRecord();
		}
		public new OperatorsDailyRecord NewUIRecord()
		{	
			return (OperatorsDailyRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class OperatorsDailyRecord : UIRecord
	{
		#region Constructor
		public OperatorsDailyRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private OperatorsDailyView uiviewOperatorsDaily
		{
			get { return (OperatorsDailyView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new OperatorsDailyRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewOperatorsDaily.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewOperatorsDaily.FieldID);
			}
			set{
				this[this.uiviewOperatorsDaily.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewOperatorsDaily.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewOperatorsDaily.FieldCreatedOn);
			}
			set{
				this[this.uiviewOperatorsDaily.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewOperatorsDaily.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewOperatorsDaily.FieldCreatedBy);
			}
			set{
				this[this.uiviewOperatorsDaily.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewOperatorsDaily.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewOperatorsDaily.FieldModifiedOn);
			}
			set{
				this[this.uiviewOperatorsDaily.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewOperatorsDaily.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewOperatorsDaily.FieldModifiedBy);
			}
			set{
				this[this.uiviewOperatorsDaily.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewOperatorsDaily.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewOperatorsDaily.FieldSysVersion);
			}
			set{
				this[this.uiviewOperatorsDaily.FieldSysVersion] = value;
			}
		}
		
		
		public  DateTime DailyDate
		{
			get{
				//object value = this[this.uiviewOperatorsDaily.FieldDailyDate] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewOperatorsDaily.FieldDailyDate);
			}
			set{
				this[this.uiviewOperatorsDaily.FieldDailyDate] = value;
			}
		}
		
		
		public  String DailyContent
		{
			get{
				//object value = this[this.uiviewOperatorsDaily.FieldDailyContent] ;
				//return (String)value;
				return GetValue<String>(this.uiviewOperatorsDaily.FieldDailyContent);
			}
			set{
				this[this.uiviewOperatorsDaily.FieldDailyContent] = value;
			}
		}
		
		
		public  Int64 Customer
		{
			get{
				//object value = this[this.uiviewOperatorsDaily.FieldCustomer] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewOperatorsDaily.FieldCustomer);
			}
			set{
				this[this.uiviewOperatorsDaily.FieldCustomer] = value;
			}
		}
		
		
		public  String Customer_Code
		{
			get{
				//object value = this[this.uiviewOperatorsDaily.FieldCustomer_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewOperatorsDaily.FieldCustomer_Code);
			}
			set{
				this[this.uiviewOperatorsDaily.FieldCustomer_Code] = value;
			}
		}
		
		
		public  String Customer_Name
		{
			get{
				//object value = this[this.uiviewOperatorsDaily.FieldCustomer_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewOperatorsDaily.FieldCustomer_Name);
			}
			set{
				this[this.uiviewOperatorsDaily.FieldCustomer_Name] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class OperatorsDailyDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public OperatorsDailyDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private OperatorsDailyDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new OperatorsDailyDefaultFilterFilter();
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
	public partial class ListViewView : UIView
	{
		#region Constructor
		public ListViewView(IUIModel model) : base(model,"ListView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private ListViewView():base(null,"ListView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new ListViewView();
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
		public IUIField FieldDailyDate
		{
			get { return this.Fields["DailyDate"]; }
		}
		public IUIField FieldDailyContent
		{
			get { return this.Fields["DailyContent"]; }
		}
		public IUIField FieldCustomer
		{
			get { return this.Fields["Customer"]; }
		}
		public IUIField FieldCustomer_Code
		{
			get { return this.Fields["Customer_Code"]; }
		}
		public IUIField FieldCustomer_Name
		{
			get { return this.Fields["Customer_Name"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public ListViewDefaultFilterFilter DefaultFilter
		{
			get { return (ListViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","5bbc6267-f2c0-4adf-b14c-ea4cc3a852c5");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","c639101b-1f7e-4ae4-b16a-9a0b12799785");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0dc6132c-aecb-4db5-8ccf-be2b70c63c19");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","8eedfddc-adea-422a-a2a7-add81a828f5d");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","26849188-eca9-4069-91de-bdd6ea986aa9");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","1fbef44c-6e4e-4735-8653-97fae356eb59");
			UIModelRuntimeFactory.AddNewUIField(this,"DailyDate", typeof(DateTime), true,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","b1fc1453-87ba-4650-8ddd-89906ba96e2d");
			UIModelRuntimeFactory.AddNewUIField(this,"DailyContent", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5f2c4324-245e-4cc7-aee7-c4201f503962");
			UIModelRuntimeFactory.AddNewUIField(this,"Customer", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","3a543b3a-9e42-4812-8df6-e3c7cf2b4086");
			UIModelRuntimeFactory.AddNewUIField(this,"Customer_Code", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2513b650-6439-4bae-a965-7023b8a436b8");
			UIModelRuntimeFactory.AddNewUIField(this,"Customer_Name", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c634f720-b20b-4029-8118-53af89ca03a6");


			this.CurrentFilter = new ListViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new ListViewRecord(builder);
		}
		#endregion

		#region new method
		public new ListViewRecord FocusedRecord
		{
			get { return (ListViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new ListViewRecord AddNewUIRecord()
		{	
			return (ListViewRecord)base.AddNewUIRecord();
		}
		public new ListViewRecord NewUIRecord()
		{	
			return (ListViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class ListViewRecord : UIRecord
	{
		#region Constructor
		public ListViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private ListViewView uiviewListView
		{
			get { return (ListViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new ListViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewListView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewListView.FieldID);
			}
			set{
				this[this.uiviewListView.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewListView.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewListView.FieldCreatedOn);
			}
			set{
				this[this.uiviewListView.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewListView.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewListView.FieldCreatedBy);
			}
			set{
				this[this.uiviewListView.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewListView.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewListView.FieldModifiedOn);
			}
			set{
				this[this.uiviewListView.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewListView.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewListView.FieldModifiedBy);
			}
			set{
				this[this.uiviewListView.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewListView.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewListView.FieldSysVersion);
			}
			set{
				this[this.uiviewListView.FieldSysVersion] = value;
			}
		}
		
		
		public  DateTime? DailyDate
		{
			get{
				//object value = this[this.uiviewListView.FieldDailyDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewListView.FieldDailyDate);
			}
			set{
				this[this.uiviewListView.FieldDailyDate] = value;
			}
		}
		
		
		public  String DailyContent
		{
			get{
				//object value = this[this.uiviewListView.FieldDailyContent] ;
				//return (String)value;
				return GetValue<String>(this.uiviewListView.FieldDailyContent);
			}
			set{
				this[this.uiviewListView.FieldDailyContent] = value;
			}
		}
		
		
		public  Int64 Customer
		{
			get{
				//object value = this[this.uiviewListView.FieldCustomer] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewListView.FieldCustomer);
			}
			set{
				this[this.uiviewListView.FieldCustomer] = value;
			}
		}
		
		
		public  String Customer_Code
		{
			get{
				//object value = this[this.uiviewListView.FieldCustomer_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewListView.FieldCustomer_Code);
			}
			set{
				this[this.uiviewListView.FieldCustomer_Code] = value;
			}
		}
		
		
		public  String Customer_Name
		{
			get{
				//object value = this[this.uiviewListView.FieldCustomer_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewListView.FieldCustomer_Name);
			}
			set{
				this[this.uiviewListView.FieldCustomer_Name] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class ListViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public ListViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private ListViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new ListViewDefaultFilterFilter();
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