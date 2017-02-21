#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.XMQX.LaserLabScrapUI.LaserLabScrapUIModel
{
	[Serializable]
	public partial class LaserLabScrapUIModelModel : UIModel
	{
		#region Constructor
		public LaserLabScrapUIModelModel() : base("LaserLabScrapUIModel")
		{
			InitClass();
			this.SetResourceInfo("f41a9c02-4608-43da-ad13-b8228cde4e88");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private LaserLabScrapUIModelModel(bool isInit) : base("LaserLabScrapUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new LaserLabScrapUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private LaserLabSoloScrapViewView viewLaserLabSoloScrapView;			
		private LaserLabScrapInfoViewView viewLaserLabScrapInfoView;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public LaserLabSoloScrapViewView LaserLabSoloScrapView
		{
			get { return (LaserLabSoloScrapViewView)this["LaserLabSoloScrapView"]; }
		}
		public LaserLabScrapInfoViewView LaserLabScrapInfoView
		{
			get { return (LaserLabScrapInfoViewView)this["LaserLabScrapInfoView"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewLaserLabSoloScrapView = new LaserLabSoloScrapViewView(this);
			this.viewLaserLabSoloScrapView.SetResourceInfo("304558da-4cf9-414b-9388-1b0bc818e752");
			this.Views.Add(this.viewLaserLabSoloScrapView);			
			this.viewLaserLabScrapInfoView = new LaserLabScrapInfoViewView(this);
			this.viewLaserLabScrapInfoView.SetResourceInfo("a0ab6632-c54e-4ef3-a799-893278e93a5f");
			this.Views.Add(this.viewLaserLabScrapInfoView);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.XMQX.LaserLabScrapUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class LaserLabSoloScrapViewView : UIView
	{
		#region Constructor
		public LaserLabSoloScrapViewView(IUIModel model) : base(model,"LaserLabSoloScrapView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private LaserLabSoloScrapViewView():base(null,"LaserLabSoloScrapView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new LaserLabSoloScrapViewView();
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
		public IUIField FieldType
		{
			get { return this.Fields["Type"]; }
		}
		public IUIField FieldDate
		{
			get { return this.Fields["Date"]; }
		}
		public IUIField FieldTime
		{
			get { return this.Fields["Time"]; }
		}
		public IUIField FieldCP
		{
			get { return this.Fields["CP"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public LaserLabSoloScrapViewDefaultFilterFilter DefaultFilter
		{
			get { return (LaserLabSoloScrapViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","167287ec-7050-47ef-8b3f-71a7919ae453");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","f79f079f-65f0-4dbe-8bb6-d55bb03b7519");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","25390d94-5b66-49f4-ae30-3d462de2557a");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","fb08b2ff-f9b6-4ff1-8869-c4e495828a33");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","235383e0-438f-439a-8fd1-6bcb9065f3b9");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","4a020647-89a8-42bf-96cc-a53843d56be4");
			UIModelRuntimeFactory.AddNewUIField(this,"BN", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4c975f61-f4ee-4caf-9876-9b4359d7b26b");
			UIModelRuntimeFactory.AddNewUIField(this,"Type", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1376e7c4-a051-4ef9-94ac-d83c5c695bff");
			UIModelRuntimeFactory.AddNewUIField(this,"Date", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f5c895a7-a541-45fa-903c-d19e4cd80716");
			UIModelRuntimeFactory.AddNewUIField(this,"Time", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6e0ea9cb-85bd-490b-8fb6-b5bb626ca104");
			UIModelRuntimeFactory.AddNewUIField(this,"CP", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fe731b05-c454-4322-b510-1193e7616022");


			this.CurrentFilter = new LaserLabSoloScrapViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new LaserLabSoloScrapViewRecord(builder);
		}
		#endregion

		#region new method
		public new LaserLabSoloScrapViewRecord FocusedRecord
		{
			get { return (LaserLabSoloScrapViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new LaserLabSoloScrapViewRecord AddNewUIRecord()
		{	
			return (LaserLabSoloScrapViewRecord)base.AddNewUIRecord();
		}
		public new LaserLabSoloScrapViewRecord NewUIRecord()
		{	
			return (LaserLabSoloScrapViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class LaserLabSoloScrapViewRecord : UIRecord
	{
		#region Constructor
		public LaserLabSoloScrapViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private LaserLabSoloScrapViewView uiviewLaserLabSoloScrapView
		{
			get { return (LaserLabSoloScrapViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new LaserLabSoloScrapViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewLaserLabSoloScrapView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewLaserLabSoloScrapView.FieldID);
			}
			set{
				this[this.uiviewLaserLabSoloScrapView.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewLaserLabSoloScrapView.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewLaserLabSoloScrapView.FieldCreatedOn);
			}
			set{
				this[this.uiviewLaserLabSoloScrapView.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewLaserLabSoloScrapView.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLaserLabSoloScrapView.FieldCreatedBy);
			}
			set{
				this[this.uiviewLaserLabSoloScrapView.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewLaserLabSoloScrapView.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewLaserLabSoloScrapView.FieldModifiedOn);
			}
			set{
				this[this.uiviewLaserLabSoloScrapView.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewLaserLabSoloScrapView.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLaserLabSoloScrapView.FieldModifiedBy);
			}
			set{
				this[this.uiviewLaserLabSoloScrapView.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewLaserLabSoloScrapView.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewLaserLabSoloScrapView.FieldSysVersion);
			}
			set{
				this[this.uiviewLaserLabSoloScrapView.FieldSysVersion] = value;
			}
		}
		
		
		public  String BN
		{
			get{
				//object value = this[this.uiviewLaserLabSoloScrapView.FieldBN] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLaserLabSoloScrapView.FieldBN);
			}
			set{
				this[this.uiviewLaserLabSoloScrapView.FieldBN] = value;
			}
		}
		
		
		public  String Type
		{
			get{
				//object value = this[this.uiviewLaserLabSoloScrapView.FieldType] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLaserLabSoloScrapView.FieldType);
			}
			set{
				this[this.uiviewLaserLabSoloScrapView.FieldType] = value;
			}
		}
		
		
		public  String Date
		{
			get{
				//object value = this[this.uiviewLaserLabSoloScrapView.FieldDate] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLaserLabSoloScrapView.FieldDate);
			}
			set{
				this[this.uiviewLaserLabSoloScrapView.FieldDate] = value;
			}
		}
		
		
		public  String Time
		{
			get{
				//object value = this[this.uiviewLaserLabSoloScrapView.FieldTime] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLaserLabSoloScrapView.FieldTime);
			}
			set{
				this[this.uiviewLaserLabSoloScrapView.FieldTime] = value;
			}
		}
		
		
		public  String CP
		{
			get{
				//object value = this[this.uiviewLaserLabSoloScrapView.FieldCP] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLaserLabSoloScrapView.FieldCP);
			}
			set{
				this[this.uiviewLaserLabSoloScrapView.FieldCP] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class LaserLabSoloScrapViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public LaserLabSoloScrapViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private LaserLabSoloScrapViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new LaserLabSoloScrapViewDefaultFilterFilter();
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
	public partial class LaserLabScrapInfoViewView : UIView
	{
		#region Constructor
		public LaserLabScrapInfoViewView(IUIModel model) : base(model,"LaserLabScrapInfoView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private LaserLabScrapInfoViewView():base(null,"LaserLabScrapInfoView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new LaserLabScrapInfoViewView();
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
		public IUIField FieldLB
		{
			get { return this.Fields["LB"]; }
		}
		public IUIField FieldBN
		{
			get { return this.Fields["BN"]; }
		}
		public IUIField FieldCP
		{
			get { return this.Fields["CP"]; }
		}
		public IUIField FieldScrapDT
		{
			get { return this.Fields["ScrapDT"]; }
		}
		public IUIField FieldType
		{
			get { return this.Fields["Type"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public LaserLabScrapInfoViewDefaultFilterFilter DefaultFilter
		{
			get { return (LaserLabScrapInfoViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","8548cd32-26d1-4359-8efa-ae950d215a10");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","615824c2-6c61-4451-aaf9-6127d0351296");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a6d388f8-f5af-49cd-abc3-b5075c53d404");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","c0dc839f-cb82-45b6-9aec-dc7aed421955");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b5f7d81d-9a43-44f1-b408-b65d15ff4de7");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","a7f6bf95-d5c2-45f2-aafe-12c7931f69a5");
			UIModelRuntimeFactory.AddNewUIField(this,"LB", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dadd17c4-d517-4716-b806-f7aef366b8d1");
			UIModelRuntimeFactory.AddNewUIField(this,"BN", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b1de1ad6-2603-40e0-8834-4ff18c78cfd0");
			UIModelRuntimeFactory.AddNewUIField(this,"CP", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","112836bf-23d7-4e2e-9098-6f687fcdfcae");
			UIModelRuntimeFactory.AddNewUIField(this,"ScrapDT", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8d9c8226-47c6-4031-b36a-a7555fc76c8b");
			UIModelRuntimeFactory.AddNewUIField(this,"Type", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b88c43d8-e119-4aec-9983-cdaced0d29af");


			this.CurrentFilter = new LaserLabScrapInfoViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new LaserLabScrapInfoViewRecord(builder);
		}
		#endregion

		#region new method
		public new LaserLabScrapInfoViewRecord FocusedRecord
		{
			get { return (LaserLabScrapInfoViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new LaserLabScrapInfoViewRecord AddNewUIRecord()
		{	
			return (LaserLabScrapInfoViewRecord)base.AddNewUIRecord();
		}
		public new LaserLabScrapInfoViewRecord NewUIRecord()
		{	
			return (LaserLabScrapInfoViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class LaserLabScrapInfoViewRecord : UIRecord
	{
		#region Constructor
		public LaserLabScrapInfoViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private LaserLabScrapInfoViewView uiviewLaserLabScrapInfoView
		{
			get { return (LaserLabScrapInfoViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new LaserLabScrapInfoViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewLaserLabScrapInfoView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewLaserLabScrapInfoView.FieldID);
			}
			set{
				this[this.uiviewLaserLabScrapInfoView.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewLaserLabScrapInfoView.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewLaserLabScrapInfoView.FieldCreatedOn);
			}
			set{
				this[this.uiviewLaserLabScrapInfoView.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewLaserLabScrapInfoView.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLaserLabScrapInfoView.FieldCreatedBy);
			}
			set{
				this[this.uiviewLaserLabScrapInfoView.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewLaserLabScrapInfoView.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewLaserLabScrapInfoView.FieldModifiedOn);
			}
			set{
				this[this.uiviewLaserLabScrapInfoView.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewLaserLabScrapInfoView.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLaserLabScrapInfoView.FieldModifiedBy);
			}
			set{
				this[this.uiviewLaserLabScrapInfoView.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewLaserLabScrapInfoView.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewLaserLabScrapInfoView.FieldSysVersion);
			}
			set{
				this[this.uiviewLaserLabScrapInfoView.FieldSysVersion] = value;
			}
		}
		
		
		public  String LB
		{
			get{
				//object value = this[this.uiviewLaserLabScrapInfoView.FieldLB] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLaserLabScrapInfoView.FieldLB);
			}
			set{
				this[this.uiviewLaserLabScrapInfoView.FieldLB] = value;
			}
		}
		
		
		public  String BN
		{
			get{
				//object value = this[this.uiviewLaserLabScrapInfoView.FieldBN] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLaserLabScrapInfoView.FieldBN);
			}
			set{
				this[this.uiviewLaserLabScrapInfoView.FieldBN] = value;
			}
		}
		
		
		public  String CP
		{
			get{
				//object value = this[this.uiviewLaserLabScrapInfoView.FieldCP] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLaserLabScrapInfoView.FieldCP);
			}
			set{
				this[this.uiviewLaserLabScrapInfoView.FieldCP] = value;
			}
		}
		
		
		public  String ScrapDT
		{
			get{
				//object value = this[this.uiviewLaserLabScrapInfoView.FieldScrapDT] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLaserLabScrapInfoView.FieldScrapDT);
			}
			set{
				this[this.uiviewLaserLabScrapInfoView.FieldScrapDT] = value;
			}
		}
		
		
		public  String Type
		{
			get{
				//object value = this[this.uiviewLaserLabScrapInfoView.FieldType] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLaserLabScrapInfoView.FieldType);
			}
			set{
				this[this.uiviewLaserLabScrapInfoView.FieldType] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class LaserLabScrapInfoViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public LaserLabScrapInfoViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private LaserLabScrapInfoViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new LaserLabScrapInfoViewDefaultFilterFilter();
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