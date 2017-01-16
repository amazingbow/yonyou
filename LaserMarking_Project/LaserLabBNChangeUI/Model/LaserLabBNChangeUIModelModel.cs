#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.XMJL.LaserLabBNChangeUI.LaserLabBNChangeUIModel
{
	[Serializable]
	public partial class LaserLabBNChangeUIModelModel : UIModel
	{
		#region Constructor
		public LaserLabBNChangeUIModelModel() : base("LaserLabBNChangeUIModel")
		{
			InitClass();
			this.SetResourceInfo("602181bd-6f79-4eb9-9bbe-f8b0818f2427");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private LaserLabBNChangeUIModelModel(bool isInit) : base("LaserLabBNChangeUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new LaserLabBNChangeUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private BatchLaserLabBNChangeViewView viewBatchLaserLabBNChangeView;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public BatchLaserLabBNChangeViewView BatchLaserLabBNChangeView
		{
			get { return (BatchLaserLabBNChangeViewView)this["BatchLaserLabBNChangeView"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewBatchLaserLabBNChangeView = new BatchLaserLabBNChangeViewView(this);
			this.viewBatchLaserLabBNChangeView.SetResourceInfo("81068a80-3955-4d26-b9ac-58131aec977a");
			this.Views.Add(this.viewBatchLaserLabBNChangeView);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.XMQX.LaserLabBNChangeUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class BatchLaserLabBNChangeViewView : UIView
	{
		#region Constructor
		public BatchLaserLabBNChangeViewView(IUIModel model) : base(model,"BatchLaserLabBNChangeView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private BatchLaserLabBNChangeViewView():base(null,"BatchLaserLabBNChangeView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new BatchLaserLabBNChangeViewView();
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
		public IUIField FieldMasterDT
		{
			get { return this.Fields["MasterDT"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public BatchLaserLabBNChangeViewDefaultFilterFilter DefaultFilter
		{
			get { return (BatchLaserLabBNChangeViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","6552e376-2909-48c7-9c7a-39309ba330dd");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","9a96ea9f-3b43-4211-930c-e2d3bad2d37d");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","21e4f217-c285-4d8c-b6f2-09f1d27af87d");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","7911b72b-a72d-4275-832b-c59c0c63def6");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7722e48d-3c8b-48ee-9a48-f25a6a16e555");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","f625ac8e-63ef-4f31-b2e0-0e0ef2946b2c");
			UIModelRuntimeFactory.AddNewUIField(this,"LB", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3e074974-316f-4a18-bde4-79097174fdc1");
			UIModelRuntimeFactory.AddNewUIField(this,"BN", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9ff0ef42-d343-4ad8-af55-90fccb4841bb");
			UIModelRuntimeFactory.AddNewUIField(this,"CP", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b92fca79-cc54-4c1f-9d21-19388a9fbee9");
			UIModelRuntimeFactory.AddNewUIField(this,"MasterDT", typeof(DateTime), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bbf85650-3874-4566-b132-b1b8c45f9cf3");


			this.CurrentFilter = new BatchLaserLabBNChangeViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new BatchLaserLabBNChangeViewRecord(builder);
		}
		#endregion

		#region new method
		public new BatchLaserLabBNChangeViewRecord FocusedRecord
		{
			get { return (BatchLaserLabBNChangeViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new BatchLaserLabBNChangeViewRecord AddNewUIRecord()
		{	
			return (BatchLaserLabBNChangeViewRecord)base.AddNewUIRecord();
		}
		public new BatchLaserLabBNChangeViewRecord NewUIRecord()
		{	
			return (BatchLaserLabBNChangeViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class BatchLaserLabBNChangeViewRecord : UIRecord
	{
		#region Constructor
		public BatchLaserLabBNChangeViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private BatchLaserLabBNChangeViewView uiviewBatchLaserLabBNChangeView
		{
			get { return (BatchLaserLabBNChangeViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new BatchLaserLabBNChangeViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewBatchLaserLabBNChangeView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBatchLaserLabBNChangeView.FieldID);
			}
			set{
				this[this.uiviewBatchLaserLabBNChangeView.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewBatchLaserLabBNChangeView.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewBatchLaserLabBNChangeView.FieldCreatedOn);
			}
			set{
				this[this.uiviewBatchLaserLabBNChangeView.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewBatchLaserLabBNChangeView.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBatchLaserLabBNChangeView.FieldCreatedBy);
			}
			set{
				this[this.uiviewBatchLaserLabBNChangeView.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewBatchLaserLabBNChangeView.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewBatchLaserLabBNChangeView.FieldModifiedOn);
			}
			set{
				this[this.uiviewBatchLaserLabBNChangeView.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewBatchLaserLabBNChangeView.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBatchLaserLabBNChangeView.FieldModifiedBy);
			}
			set{
				this[this.uiviewBatchLaserLabBNChangeView.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewBatchLaserLabBNChangeView.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBatchLaserLabBNChangeView.FieldSysVersion);
			}
			set{
				this[this.uiviewBatchLaserLabBNChangeView.FieldSysVersion] = value;
			}
		}
		
		
		public  String LB
		{
			get{
				//object value = this[this.uiviewBatchLaserLabBNChangeView.FieldLB] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBatchLaserLabBNChangeView.FieldLB);
			}
			set{
				this[this.uiviewBatchLaserLabBNChangeView.FieldLB] = value;
			}
		}
		
		
		public  String BN
		{
			get{
				//object value = this[this.uiviewBatchLaserLabBNChangeView.FieldBN] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBatchLaserLabBNChangeView.FieldBN);
			}
			set{
				this[this.uiviewBatchLaserLabBNChangeView.FieldBN] = value;
			}
		}
		
		
		public  String CP
		{
			get{
				//object value = this[this.uiviewBatchLaserLabBNChangeView.FieldCP] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBatchLaserLabBNChangeView.FieldCP);
			}
			set{
				this[this.uiviewBatchLaserLabBNChangeView.FieldCP] = value;
			}
		}
		
		
		public  DateTime? MasterDT
		{
			get{
				//object value = this[this.uiviewBatchLaserLabBNChangeView.FieldMasterDT] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewBatchLaserLabBNChangeView.FieldMasterDT);
			}
			set{
				this[this.uiviewBatchLaserLabBNChangeView.FieldMasterDT] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class BatchLaserLabBNChangeViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public BatchLaserLabBNChangeViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private BatchLaserLabBNChangeViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new BatchLaserLabBNChangeViewDefaultFilterFilter();
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