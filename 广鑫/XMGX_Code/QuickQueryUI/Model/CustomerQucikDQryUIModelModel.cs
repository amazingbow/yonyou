#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.FJGX.CustomerQucikDQryUIModel
{
	[Serializable]
	public partial class CustomerQucikDQryUIModelModel : UIModel
	{
		#region Constructor
		public CustomerQucikDQryUIModelModel() : base("CustomerQucikDQryUIModel")
		{
			InitClass();
			this.SetResourceInfo("94d73e8a-a05c-4b81-8151-e87335df57cc");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private CustomerQucikDQryUIModelModel(bool isInit) : base("CustomerQucikDQryUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new CustomerQucikDQryUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private QueryViewView viewQueryView;			
		private CustomerDetailViewView viewCustomerDetailView;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public QueryViewView QueryView
		{
			get { return (QueryViewView)this["QueryView"]; }
		}
		public CustomerDetailViewView CustomerDetailView
		{
			get { return (CustomerDetailViewView)this["CustomerDetailView"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewQueryView = new QueryViewView(this);
			this.viewQueryView.SetResourceInfo("e972e5f1-8979-4b52-9d5e-0cad65347350");
			this.Views.Add(this.viewQueryView);			
			this.viewCustomerDetailView = new CustomerDetailViewView(this);
			this.viewCustomerDetailView.SetResourceInfo("479241df-0646-44a1-8127-d37b15659e7b");
			this.Views.Add(this.viewCustomerDetailView);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.FJGX.QuickQueryUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class QueryViewView : UIView
	{
		#region Constructor
		public QueryViewView(IUIModel model) : base(model,"QueryView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private QueryViewView():base(null,"QueryView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new QueryViewView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public QueryViewDefaultFilterFilter DefaultFilter
		{
			get { return (QueryViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","53c60c80-a736-4058-8404-86904ee900bd");


			this.CurrentFilter = new QueryViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new QueryViewRecord(builder);
		}
		#endregion

		#region new method
		public new QueryViewRecord FocusedRecord
		{
			get { return (QueryViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new QueryViewRecord AddNewUIRecord()
		{	
			return (QueryViewRecord)base.AddNewUIRecord();
		}
		public new QueryViewRecord NewUIRecord()
		{	
			return (QueryViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class QueryViewRecord : UIRecord
	{
		#region Constructor
		public QueryViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private QueryViewView uiviewQueryView
		{
			get { return (QueryViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new QueryViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewQueryView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewQueryView.FieldID);
			}
			set{
				this[this.uiviewQueryView.FieldID] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class QueryViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public QueryViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private QueryViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new QueryViewDefaultFilterFilter();
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
	public partial class CustomerDetailViewView : UIView
	{
		#region Constructor
		public CustomerDetailViewView(IUIModel model) : base(model,"CustomerDetailView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private CustomerDetailViewView():base(null,"CustomerDetailView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new CustomerDetailViewView();
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
		public IUIField FieldName
		{
			get { return this.Fields["Name"]; }
		}
		public IUIField FieldEnterpriseLegalPerson
		{
			get { return this.Fields["EnterpriseLegalPerson"]; }
		}
		public IUIField FieldCreditMoney
		{
			get { return this.Fields["CreditMoney"]; }
		}
		public IUIField FieldActualAPMoney
		{
			get { return this.Fields["ActualAPMoney"]; }
		}
		public IUIField FieldMobileNo
		{
			get { return this.Fields["MobileNo"]; }
		}
		public IUIField FieldPhoneNo
		{
			get { return this.Fields["PhoneNo"]; }
		}
		public IUIField FieldFax
		{
			get { return this.Fields["Fax"]; }
		}
		public IUIField FieldSaleserNote
		{
			get { return this.Fields["SaleserNote"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public CustomerDetailViewDefaultFilterFilter DefaultFilter
		{
			get { return (CustomerDetailViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","c8f3b60d-1b36-48c2-8c5c-f1fb7fb68eb4");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","a687be22-7c54-4985-9a42-3aa2902eab54");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","989eebcf-afb8-440d-b719-c5f0a381ffb3");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","c235e587-5fdb-4220-a677-7eb4c368ac62");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6412135a-88a5-4b9b-9081-8360becf2f52");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","ef641693-4379-48c8-87f1-7072f7ddde6d");
			UIModelRuntimeFactory.AddNewUIField(this,"Name", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d3d651bb-92c2-47b4-a6a1-db64b688da80");
			UIModelRuntimeFactory.AddNewUIField(this,"EnterpriseLegalPerson", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f63c72f7-dc10-495f-a7f2-c527efdc5609");
			UIModelRuntimeFactory.AddNewUIField(this,"CreditMoney", typeof(Decimal), true,"","System.Decimal", "", false,false, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","ddfae648-f151-418a-bd27-b67fc5973c45");
			UIModelRuntimeFactory.AddNewUIField(this,"ActualAPMoney", typeof(Decimal), true,"","System.Decimal", "", false,false, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","5d1d5417-bee3-4943-aae2-de93076e82e9");
			UIModelRuntimeFactory.AddNewUIField(this,"MobileNo", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","328319f2-3270-4e08-8b6b-d7ba0deaf5e7");
			UIModelRuntimeFactory.AddNewUIField(this,"PhoneNo", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","38ca0732-77aa-40df-85bd-9f09f0a19da5");
			UIModelRuntimeFactory.AddNewUIField(this,"Fax", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a8ceb210-65c8-4c89-84e2-820b5a477892");
			UIModelRuntimeFactory.AddNewUIField(this,"SaleserNote", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5ef7c5a6-32d0-46bb-8f6a-8ad5537b12f6");


			this.CurrentFilter = new CustomerDetailViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new CustomerDetailViewRecord(builder);
		}
		#endregion

		#region new method
		public new CustomerDetailViewRecord FocusedRecord
		{
			get { return (CustomerDetailViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new CustomerDetailViewRecord AddNewUIRecord()
		{	
			return (CustomerDetailViewRecord)base.AddNewUIRecord();
		}
		public new CustomerDetailViewRecord NewUIRecord()
		{	
			return (CustomerDetailViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class CustomerDetailViewRecord : UIRecord
	{
		#region Constructor
		public CustomerDetailViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private CustomerDetailViewView uiviewCustomerDetailView
		{
			get { return (CustomerDetailViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new CustomerDetailViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewCustomerDetailView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCustomerDetailView.FieldID);
			}
			set{
				this[this.uiviewCustomerDetailView.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewCustomerDetailView.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewCustomerDetailView.FieldCreatedOn);
			}
			set{
				this[this.uiviewCustomerDetailView.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewCustomerDetailView.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCustomerDetailView.FieldCreatedBy);
			}
			set{
				this[this.uiviewCustomerDetailView.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewCustomerDetailView.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewCustomerDetailView.FieldModifiedOn);
			}
			set{
				this[this.uiviewCustomerDetailView.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewCustomerDetailView.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCustomerDetailView.FieldModifiedBy);
			}
			set{
				this[this.uiviewCustomerDetailView.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewCustomerDetailView.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCustomerDetailView.FieldSysVersion);
			}
			set{
				this[this.uiviewCustomerDetailView.FieldSysVersion] = value;
			}
		}
		
		
		public new String Name
		{
			get{
				//object value = this[this.uiviewCustomerDetailView.FieldName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCustomerDetailView.FieldName);
			}
			set{
				this[this.uiviewCustomerDetailView.FieldName] = value;
			}
		}
		
		
		public  String EnterpriseLegalPerson
		{
			get{
				//object value = this[this.uiviewCustomerDetailView.FieldEnterpriseLegalPerson] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCustomerDetailView.FieldEnterpriseLegalPerson);
			}
			set{
				this[this.uiviewCustomerDetailView.FieldEnterpriseLegalPerson] = value;
			}
		}
		
		
		public  Decimal? CreditMoney
		{
			get{
				//object value = this[this.uiviewCustomerDetailView.FieldCreditMoney] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewCustomerDetailView.FieldCreditMoney);
			}
			set{
				this[this.uiviewCustomerDetailView.FieldCreditMoney] = value;
			}
		}
		
		
		public  Decimal? ActualAPMoney
		{
			get{
				//object value = this[this.uiviewCustomerDetailView.FieldActualAPMoney] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewCustomerDetailView.FieldActualAPMoney);
			}
			set{
				this[this.uiviewCustomerDetailView.FieldActualAPMoney] = value;
			}
		}
		
		
		public  String MobileNo
		{
			get{
				//object value = this[this.uiviewCustomerDetailView.FieldMobileNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCustomerDetailView.FieldMobileNo);
			}
			set{
				this[this.uiviewCustomerDetailView.FieldMobileNo] = value;
			}
		}
		
		
		public  String PhoneNo
		{
			get{
				//object value = this[this.uiviewCustomerDetailView.FieldPhoneNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCustomerDetailView.FieldPhoneNo);
			}
			set{
				this[this.uiviewCustomerDetailView.FieldPhoneNo] = value;
			}
		}
		
		
		public  String Fax
		{
			get{
				//object value = this[this.uiviewCustomerDetailView.FieldFax] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCustomerDetailView.FieldFax);
			}
			set{
				this[this.uiviewCustomerDetailView.FieldFax] = value;
			}
		}
		
		
		public  String SaleserNote
		{
			get{
				//object value = this[this.uiviewCustomerDetailView.FieldSaleserNote] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCustomerDetailView.FieldSaleserNote);
			}
			set{
				this[this.uiviewCustomerDetailView.FieldSaleserNote] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class CustomerDetailViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public CustomerDetailViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private CustomerDetailViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new CustomerDetailViewDefaultFilterFilter();
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