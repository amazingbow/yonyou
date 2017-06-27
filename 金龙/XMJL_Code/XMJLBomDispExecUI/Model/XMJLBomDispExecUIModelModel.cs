#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.XMJL.XMJLBomDispExecUIModel
{
	[Serializable]
	public partial class XMJLBomDispExecUIModelModel : UIModel
	{
		#region Constructor
		public XMJLBomDispExecUIModelModel() : base("XMJLBomDispExecUIModel")
		{
			InitClass();
			this.SetResourceInfo("8d5da672-949f-4a8e-b655-6c9764fb2ec6");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private XMJLBomDispExecUIModelModel(bool isInit) : base("XMJLBomDispExecUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new XMJLBomDispExecUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private BOMDispExecViewView viewBOMDispExecView;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public BOMDispExecViewView BOMDispExecView
		{
			get { return (BOMDispExecViewView)this["BOMDispExecView"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewBOMDispExecView = new BOMDispExecViewView(this);
			this.viewBOMDispExecView.SetResourceInfo("db9b552a-a7c7-418f-b9ee-0ed13996de00");
			this.Views.Add(this.viewBOMDispExecView);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.XMJL.XMJLBomDispExecUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class BOMDispExecViewView : UIView
	{
		#region Constructor
		public BOMDispExecViewView(IUIModel model) : base(model,"BOMDispExecView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private BOMDispExecViewView():base(null,"BOMDispExecView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new BOMDispExecViewView();
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
		public IUIField FieldManufactureNo
		{
			get { return this.Fields["ManufactureNo"]; }
		}
		public IUIField FieldWareHouse
		{
			get { return this.Fields["WareHouse"]; }
		}
		public IUIField FieldWorkPlace
		{
			get { return this.Fields["WorkPlace"]; }
		}
		public IUIField FieldStartDate
		{
			get { return this.Fields["StartDate"]; }
		}
		public IUIField FieldEndTime
		{
			get { return this.Fields["EndTime"]; }
		}
		public IUIField FieldItem
		{
			get { return this.Fields["Item"]; }
		}
		public IUIField FieldDistributeStartDate
		{
			get { return this.Fields["DistributeStartDate"]; }
		}
		public IUIField FieldJustDisNegative
		{
			get { return this.Fields["JustDisNegative"]; }
		}
		public IUIField FieldDistributeEndDate
		{
			get { return this.Fields["DistributeEndDate"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public BOMDispExecViewDefaultFilterFilter DefaultFilter
		{
			get { return (BOMDispExecViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","f568122f-d4a1-4f34-be3a-aab83e4cb8d4");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","56252167-8bd1-4b0b-9f02-4fbedc0b555e");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","62acf291-5970-4f90-8394-0d35120d772f");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","6e77c30f-01f7-423a-9648-6dbf7239de26");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7870b625-95a4-42a7-8fb7-ee566523664c");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","950edf2c-12d3-43cf-a582-ea4b045b7269");
			UIModelRuntimeFactory.AddNewUIField(this,"ManufactureNo", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.ProjectTask.Project", "", false,false, false, "",false,(UIFieldType)4,"7bc6294b-1a35-4e37-acfe-5abc5602f12f","583469c5-d19a-4861-8c98-62d03cea6469");
			UIModelRuntimeFactory.AddNewUIField(this,"WareHouse", typeof(Int64), false,"","UFIDA.U9.CBO.SCM.Warehouse.Warehouse", "", false,false, false, "",false,(UIFieldType)4,"0fac5c83-2ab0-428f-bf82-c363857b37be","bce0a089-6059-4e99-80d6-cb73a0e818bd");
			UIModelRuntimeFactory.AddNewUIField(this,"WorkPlace", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","570890ae-0c5d-47f9-aba7-a2764dded7bc");
			UIModelRuntimeFactory.AddNewUIField(this,"StartDate", typeof(DateTime), true,"","System.Date", "", false,false, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","18e10bd0-a483-434d-8727-ca7ac92ef83b");
			UIModelRuntimeFactory.AddNewUIField(this,"EndTime", typeof(DateTime), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fef0cb27-ca53-49f9-ad79-700632e68504");
			UIModelRuntimeFactory.AddNewUIField(this,"Item", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Item.ItemMaster", "", false,false, false, "",false,(UIFieldType)4,"636d3e47-48aa-47fc-aca4-e6322bce775b","4ee6800b-2381-4327-b016-1552521d5c2e");
			UIModelRuntimeFactory.AddNewUIField(this,"DistributeStartDate", typeof(DateTime), true,"","System.Date", "", false,false, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","0fe3dc74-2786-434a-9122-73353560976a");
			UIModelRuntimeFactory.AddNewUIField(this,"JustDisNegative", typeof(Boolean), true,"0","System.Boolean", "", false,false, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","f9f9d2eb-9642-4cfb-9f31-7c5cb6a41e3a");
			UIModelRuntimeFactory.AddNewUIField(this,"DistributeEndDate", typeof(DateTime), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","37e68c36-dcba-46c7-8c38-b0fa631139fd");


			this.CurrentFilter = new BOMDispExecViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new BOMDispExecViewRecord(builder);
		}
		#endregion

		#region new method
		public new BOMDispExecViewRecord FocusedRecord
		{
			get { return (BOMDispExecViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new BOMDispExecViewRecord AddNewUIRecord()
		{	
			return (BOMDispExecViewRecord)base.AddNewUIRecord();
		}
		public new BOMDispExecViewRecord NewUIRecord()
		{	
			return (BOMDispExecViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class BOMDispExecViewRecord : UIRecord
	{
		#region Constructor
		public BOMDispExecViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private BOMDispExecViewView uiviewBOMDispExecView
		{
			get { return (BOMDispExecViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new BOMDispExecViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewBOMDispExecView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBOMDispExecView.FieldID);
			}
			set{
				this[this.uiviewBOMDispExecView.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewBOMDispExecView.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewBOMDispExecView.FieldCreatedOn);
			}
			set{
				this[this.uiviewBOMDispExecView.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewBOMDispExecView.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBOMDispExecView.FieldCreatedBy);
			}
			set{
				this[this.uiviewBOMDispExecView.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewBOMDispExecView.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewBOMDispExecView.FieldModifiedOn);
			}
			set{
				this[this.uiviewBOMDispExecView.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewBOMDispExecView.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBOMDispExecView.FieldModifiedBy);
			}
			set{
				this[this.uiviewBOMDispExecView.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewBOMDispExecView.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBOMDispExecView.FieldSysVersion);
			}
			set{
				this[this.uiviewBOMDispExecView.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? ManufactureNo
		{
			get{
				//object value = this[this.uiviewBOMDispExecView.FieldManufactureNo] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewBOMDispExecView.FieldManufactureNo);
			}
			set{
				this[this.uiviewBOMDispExecView.FieldManufactureNo] = value;
			}
		}
		
		
		public  Int64 WareHouse
		{
			get{
				//object value = this[this.uiviewBOMDispExecView.FieldWareHouse] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBOMDispExecView.FieldWareHouse);
			}
			set{
				this[this.uiviewBOMDispExecView.FieldWareHouse] = value;
			}
		}
		
		
		public  String WorkPlace
		{
			get{
				//object value = this[this.uiviewBOMDispExecView.FieldWorkPlace] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBOMDispExecView.FieldWorkPlace);
			}
			set{
				this[this.uiviewBOMDispExecView.FieldWorkPlace] = value;
			}
		}
		
		
		public  DateTime? StartDate
		{
			get{
				//object value = this[this.uiviewBOMDispExecView.FieldStartDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewBOMDispExecView.FieldStartDate);
			}
			set{
				this[this.uiviewBOMDispExecView.FieldStartDate] = value;
			}
		}
		
		
		public  DateTime? EndTime
		{
			get{
				//object value = this[this.uiviewBOMDispExecView.FieldEndTime] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewBOMDispExecView.FieldEndTime);
			}
			set{
				this[this.uiviewBOMDispExecView.FieldEndTime] = value;
			}
		}
		
		
		public  Int64? Item
		{
			get{
				//object value = this[this.uiviewBOMDispExecView.FieldItem] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewBOMDispExecView.FieldItem);
			}
			set{
				this[this.uiviewBOMDispExecView.FieldItem] = value;
			}
		}
		
		
		public  DateTime? DistributeStartDate
		{
			get{
				//object value = this[this.uiviewBOMDispExecView.FieldDistributeStartDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewBOMDispExecView.FieldDistributeStartDate);
			}
			set{
				this[this.uiviewBOMDispExecView.FieldDistributeStartDate] = value;
			}
		}
		
		
		public  Boolean? JustDisNegative
		{
			get{
				//object value = this[this.uiviewBOMDispExecView.FieldJustDisNegative] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewBOMDispExecView.FieldJustDisNegative);
			}
			set{
				this[this.uiviewBOMDispExecView.FieldJustDisNegative] = value;
			}
		}
		
		
		public  DateTime? DistributeEndDate
		{
			get{
				//object value = this[this.uiviewBOMDispExecView.FieldDistributeEndDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewBOMDispExecView.FieldDistributeEndDate);
			}
			set{
				this[this.uiviewBOMDispExecView.FieldDistributeEndDate] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class BOMDispExecViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public BOMDispExecViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private BOMDispExecViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new BOMDispExecViewDefaultFilterFilter();
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