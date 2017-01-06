#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.XMQX.LaserLabAddUIModel
{
	[Serializable]
	public partial class LaserLabAddUIModelModel : UIModel
	{
		#region Constructor
		public LaserLabAddUIModelModel() : base("LaserLabAddUIModel")
		{
			InitClass();
			this.SetResourceInfo("bb3eb32a-7426-4b61-8a5e-948b4c2fd6c8");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private LaserLabAddUIModelModel(bool isInit) : base("LaserLabAddUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new LaserLabAddUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private SoloLaserLabAddViewView viewSoloLaserLabAddView;			
		private AllLaserLabCreateViewView viewAllLaserLabCreateView;			
		private AllLaserLabAddViewView viewAllLaserLabAddView;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public SoloLaserLabAddViewView SoloLaserLabAddView
		{
			get { return (SoloLaserLabAddViewView)this["SoloLaserLabAddView"]; }
		}
		public AllLaserLabCreateViewView AllLaserLabCreateView
		{
			get { return (AllLaserLabCreateViewView)this["AllLaserLabCreateView"]; }
		}
		public AllLaserLabAddViewView AllLaserLabAddView
		{
			get { return (AllLaserLabAddViewView)this["AllLaserLabAddView"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewSoloLaserLabAddView = new SoloLaserLabAddViewView(this);
			this.viewSoloLaserLabAddView.SetResourceInfo("03f478b7-af8c-474d-a297-8a95335cfdbf");
			this.Views.Add(this.viewSoloLaserLabAddView);			
			this.viewAllLaserLabCreateView = new AllLaserLabCreateViewView(this);
			this.viewAllLaserLabCreateView.SetResourceInfo("340cf4bc-330f-4048-9982-1f63f60de156");
			this.Views.Add(this.viewAllLaserLabCreateView);			
			this.viewAllLaserLabAddView = new AllLaserLabAddViewView(this);
			this.viewAllLaserLabAddView.SetResourceInfo("1b279abb-cafa-4862-b2ac-037b72bcda52");
			this.Views.Add(this.viewAllLaserLabAddView);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.XMQX.LaserLabAddUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class SoloLaserLabAddViewView : UIView
	{
		#region Constructor
		public SoloLaserLabAddViewView(IUIModel model) : base(model,"SoloLaserLabAddView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private SoloLaserLabAddViewView():base(null,"SoloLaserLabAddView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new SoloLaserLabAddViewView();
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
		public IUIField FieldBN
		{
			get { return this.Fields["BN"]; }
		}
		public IUIField FieldLB
		{
			get { return this.Fields["LB"]; }
		}
		public IUIField FieldType
		{
			get { return this.Fields["Type"]; }
		}
		public IUIField FieldCustomer
		{
			get { return this.Fields["Customer"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public SoloLaserLabAddViewDefaultFilterFilter DefaultFilter
		{
			get { return (SoloLaserLabAddViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","41177e8d-dd77-46b3-aa6b-b7b4348b29b6");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","397629ff-07ff-428b-8cb5-cb4e0e993f1d");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5a03e35b-1a1a-44a5-8bbf-324ea667738a");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","1dab7101-aa38-49ee-be37-bf29c817b6f5");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5e56271e-1ba2-42e1-a533-3383b34c2096");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","0ef7756b-6344-4e92-bd56-059d4556ea0a");
			UIModelRuntimeFactory.AddNewUIField(this,"BN", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","603140db-6b79-4ad4-9e46-0f8003d41d3c");
			UIModelRuntimeFactory.AddNewUIField(this,"LB", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9c8384d8-8321-4fb3-b76a-7784f711595f");
			UIModelRuntimeFactory.AddNewUIField(this,"Type", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9ed42a1b-05ac-478d-9fd5-d34c8fb4a08a");
			UIModelRuntimeFactory.AddNewUIField(this,"Customer", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5c88c4cb-db70-4abd-84d9-5fcfcf3d7d6b");


			this.CurrentFilter = new SoloLaserLabAddViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new SoloLaserLabAddViewRecord(builder);
		}
		#endregion

		#region new method
		public new SoloLaserLabAddViewRecord FocusedRecord
		{
			get { return (SoloLaserLabAddViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new SoloLaserLabAddViewRecord AddNewUIRecord()
		{	
			return (SoloLaserLabAddViewRecord)base.AddNewUIRecord();
		}
		public new SoloLaserLabAddViewRecord NewUIRecord()
		{	
			return (SoloLaserLabAddViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class SoloLaserLabAddViewRecord : UIRecord
	{
		#region Constructor
		public SoloLaserLabAddViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private SoloLaserLabAddViewView uiviewSoloLaserLabAddView
		{
			get { return (SoloLaserLabAddViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new SoloLaserLabAddViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewSoloLaserLabAddView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewSoloLaserLabAddView.FieldID);
			}
			set{
				this[this.uiviewSoloLaserLabAddView.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewSoloLaserLabAddView.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewSoloLaserLabAddView.FieldCreatedOn);
			}
			set{
				this[this.uiviewSoloLaserLabAddView.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewSoloLaserLabAddView.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSoloLaserLabAddView.FieldCreatedBy);
			}
			set{
				this[this.uiviewSoloLaserLabAddView.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewSoloLaserLabAddView.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewSoloLaserLabAddView.FieldModifiedOn);
			}
			set{
				this[this.uiviewSoloLaserLabAddView.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewSoloLaserLabAddView.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSoloLaserLabAddView.FieldModifiedBy);
			}
			set{
				this[this.uiviewSoloLaserLabAddView.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewSoloLaserLabAddView.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewSoloLaserLabAddView.FieldSysVersion);
			}
			set{
				this[this.uiviewSoloLaserLabAddView.FieldSysVersion] = value;
			}
		}
		
		
		public  String BN
		{
			get{
				//object value = this[this.uiviewSoloLaserLabAddView.FieldBN] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSoloLaserLabAddView.FieldBN);
			}
			set{
				this[this.uiviewSoloLaserLabAddView.FieldBN] = value;
			}
		}
		
		
		public  String LB
		{
			get{
				//object value = this[this.uiviewSoloLaserLabAddView.FieldLB] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSoloLaserLabAddView.FieldLB);
			}
			set{
				this[this.uiviewSoloLaserLabAddView.FieldLB] = value;
			}
		}
		
		
		public  String Type
		{
			get{
				//object value = this[this.uiviewSoloLaserLabAddView.FieldType] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSoloLaserLabAddView.FieldType);
			}
			set{
				this[this.uiviewSoloLaserLabAddView.FieldType] = value;
			}
		}
		
		
		public  String Customer
		{
			get{
				//object value = this[this.uiviewSoloLaserLabAddView.FieldCustomer] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSoloLaserLabAddView.FieldCustomer);
			}
			set{
				this[this.uiviewSoloLaserLabAddView.FieldCustomer] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class SoloLaserLabAddViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public SoloLaserLabAddViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private SoloLaserLabAddViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new SoloLaserLabAddViewDefaultFilterFilter();
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
	public partial class AllLaserLabCreateViewView : UIView
	{
		#region Constructor
		public AllLaserLabCreateViewView(IUIModel model) : base(model,"AllLaserLabCreateView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private AllLaserLabCreateViewView():base(null,"AllLaserLabCreateView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new AllLaserLabCreateViewView();
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
		public IUIField FieldBN
		{
			get { return this.Fields["BN"]; }
		}
		public IUIField FieldLB
		{
			get { return this.Fields["LB"]; }
		}
		public IUIField FieldType
		{
			get { return this.Fields["Type"]; }
		}
		public IUIField FieldCustomer
		{
			get { return this.Fields["Customer"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public AllLaserLabCreateViewDefaultFilterFilter DefaultFilter
		{
			get { return (AllLaserLabCreateViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","8452cfc7-b42c-4b03-a63a-44326be74eff");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","9f8e7527-f870-417e-b848-dd65e49d090a");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","eb71acc2-d5fb-40e9-990d-8ed10bb45e1d");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","7c85f919-0ded-4093-afaa-29e2b8315ad6");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fbf86a68-cec8-4c97-b688-c8318efd1c06");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","87b46493-5a96-4b1e-848a-44a3d2e5c4cb");
			UIModelRuntimeFactory.AddNewUIField(this,"BN", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f3151ab6-9a0b-4729-bd56-f4e5261e786c");
			UIModelRuntimeFactory.AddNewUIField(this,"LB", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a4102ca5-2063-4393-a8bd-022591d9b748");
			UIModelRuntimeFactory.AddNewUIField(this,"Type", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8c26deb4-94ad-474e-a3df-df5888b0f79f");
			UIModelRuntimeFactory.AddNewUIField(this,"Customer", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7ad4741b-64e9-4130-b141-59d34ce0ea75");


			this.CurrentFilter = new AllLaserLabCreateViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new AllLaserLabCreateViewRecord(builder);
		}
		#endregion

		#region new method
		public new AllLaserLabCreateViewRecord FocusedRecord
		{
			get { return (AllLaserLabCreateViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new AllLaserLabCreateViewRecord AddNewUIRecord()
		{	
			return (AllLaserLabCreateViewRecord)base.AddNewUIRecord();
		}
		public new AllLaserLabCreateViewRecord NewUIRecord()
		{	
			return (AllLaserLabCreateViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class AllLaserLabCreateViewRecord : UIRecord
	{
		#region Constructor
		public AllLaserLabCreateViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private AllLaserLabCreateViewView uiviewAllLaserLabCreateView
		{
			get { return (AllLaserLabCreateViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new AllLaserLabCreateViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewAllLaserLabCreateView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAllLaserLabCreateView.FieldID);
			}
			set{
				this[this.uiviewAllLaserLabCreateView.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewAllLaserLabCreateView.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewAllLaserLabCreateView.FieldCreatedOn);
			}
			set{
				this[this.uiviewAllLaserLabCreateView.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewAllLaserLabCreateView.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllLaserLabCreateView.FieldCreatedBy);
			}
			set{
				this[this.uiviewAllLaserLabCreateView.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewAllLaserLabCreateView.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewAllLaserLabCreateView.FieldModifiedOn);
			}
			set{
				this[this.uiviewAllLaserLabCreateView.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewAllLaserLabCreateView.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllLaserLabCreateView.FieldModifiedBy);
			}
			set{
				this[this.uiviewAllLaserLabCreateView.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewAllLaserLabCreateView.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAllLaserLabCreateView.FieldSysVersion);
			}
			set{
				this[this.uiviewAllLaserLabCreateView.FieldSysVersion] = value;
			}
		}
		
		
		public  String BN
		{
			get{
				//object value = this[this.uiviewAllLaserLabCreateView.FieldBN] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllLaserLabCreateView.FieldBN);
			}
			set{
				this[this.uiviewAllLaserLabCreateView.FieldBN] = value;
			}
		}
		
		
		public  String LB
		{
			get{
				//object value = this[this.uiviewAllLaserLabCreateView.FieldLB] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllLaserLabCreateView.FieldLB);
			}
			set{
				this[this.uiviewAllLaserLabCreateView.FieldLB] = value;
			}
		}
		
		
		public  String Type
		{
			get{
				//object value = this[this.uiviewAllLaserLabCreateView.FieldType] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllLaserLabCreateView.FieldType);
			}
			set{
				this[this.uiviewAllLaserLabCreateView.FieldType] = value;
			}
		}
		
		
		public  String Customer
		{
			get{
				//object value = this[this.uiviewAllLaserLabCreateView.FieldCustomer] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllLaserLabCreateView.FieldCustomer);
			}
			set{
				this[this.uiviewAllLaserLabCreateView.FieldCustomer] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class AllLaserLabCreateViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public AllLaserLabCreateViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private AllLaserLabCreateViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new AllLaserLabCreateViewDefaultFilterFilter();
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
	public partial class AllLaserLabAddViewView : UIView
	{
		#region Constructor
		public AllLaserLabAddViewView(IUIModel model) : base(model,"AllLaserLabAddView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private AllLaserLabAddViewView():base(null,"AllLaserLabAddView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new AllLaserLabAddViewView();
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
		public IUIField FieldBN
		{
			get { return this.Fields["BN"]; }
		}
		public IUIField FieldLB
		{
			get { return this.Fields["LB"]; }
		}
		public IUIField FieldType
		{
			get { return this.Fields["Type"]; }
		}
		public IUIField FieldCustomer
		{
			get { return this.Fields["Customer"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public AllLaserLabAddViewDefaultFilterFilter DefaultFilter
		{
			get { return (AllLaserLabAddViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","710693a4-45d0-439a-a800-b54e46b17350");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","be80cd8f-4b8f-49df-9284-200af2cc5e63");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ac0edeb3-8599-442a-99c9-4ab22e387fe1");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","217fc6a4-8d18-4574-9f84-f71d262be525");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","91f014e2-9b75-4246-a832-ed842f20952f");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","77b58339-aa3c-4cc7-9965-88379ec705c4");
			UIModelRuntimeFactory.AddNewUIField(this,"BN", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7192ad66-2e3c-43f0-adb9-f28192d8bc41");
			UIModelRuntimeFactory.AddNewUIField(this,"LB", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","143e7173-ba55-463f-aee5-ee2906635336");
			UIModelRuntimeFactory.AddNewUIField(this,"Type", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","92fd6749-f5be-400d-9893-f95dd171cfc3");
			UIModelRuntimeFactory.AddNewUIField(this,"Customer", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","675ca4cb-eab2-462e-8d71-81fd5ca6dcc7");


			this.CurrentFilter = new AllLaserLabAddViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new AllLaserLabAddViewRecord(builder);
		}
		#endregion

		#region new method
		public new AllLaserLabAddViewRecord FocusedRecord
		{
			get { return (AllLaserLabAddViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new AllLaserLabAddViewRecord AddNewUIRecord()
		{	
			return (AllLaserLabAddViewRecord)base.AddNewUIRecord();
		}
		public new AllLaserLabAddViewRecord NewUIRecord()
		{	
			return (AllLaserLabAddViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class AllLaserLabAddViewRecord : UIRecord
	{
		#region Constructor
		public AllLaserLabAddViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private AllLaserLabAddViewView uiviewAllLaserLabAddView
		{
			get { return (AllLaserLabAddViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new AllLaserLabAddViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewAllLaserLabAddView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAllLaserLabAddView.FieldID);
			}
			set{
				this[this.uiviewAllLaserLabAddView.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewAllLaserLabAddView.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewAllLaserLabAddView.FieldCreatedOn);
			}
			set{
				this[this.uiviewAllLaserLabAddView.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewAllLaserLabAddView.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllLaserLabAddView.FieldCreatedBy);
			}
			set{
				this[this.uiviewAllLaserLabAddView.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewAllLaserLabAddView.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewAllLaserLabAddView.FieldModifiedOn);
			}
			set{
				this[this.uiviewAllLaserLabAddView.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewAllLaserLabAddView.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllLaserLabAddView.FieldModifiedBy);
			}
			set{
				this[this.uiviewAllLaserLabAddView.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewAllLaserLabAddView.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAllLaserLabAddView.FieldSysVersion);
			}
			set{
				this[this.uiviewAllLaserLabAddView.FieldSysVersion] = value;
			}
		}
		
		
		public  String BN
		{
			get{
				//object value = this[this.uiviewAllLaserLabAddView.FieldBN] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllLaserLabAddView.FieldBN);
			}
			set{
				this[this.uiviewAllLaserLabAddView.FieldBN] = value;
			}
		}
		
		
		public  String LB
		{
			get{
				//object value = this[this.uiviewAllLaserLabAddView.FieldLB] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllLaserLabAddView.FieldLB);
			}
			set{
				this[this.uiviewAllLaserLabAddView.FieldLB] = value;
			}
		}
		
		
		public  String Type
		{
			get{
				//object value = this[this.uiviewAllLaserLabAddView.FieldType] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllLaserLabAddView.FieldType);
			}
			set{
				this[this.uiviewAllLaserLabAddView.FieldType] = value;
			}
		}
		
		
		public  String Customer
		{
			get{
				//object value = this[this.uiviewAllLaserLabAddView.FieldCustomer] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllLaserLabAddView.FieldCustomer);
			}
			set{
				this[this.uiviewAllLaserLabAddView.FieldCustomer] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class AllLaserLabAddViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public AllLaserLabAddViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private AllLaserLabAddViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new AllLaserLabAddViewDefaultFilterFilter();
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