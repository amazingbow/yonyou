#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace LaserLabDataProcessUIModel
{
	[Serializable]
	public partial class LaserLabDataProcessUIModelModel : UIModel
	{
		#region Constructor
		public LaserLabDataProcessUIModelModel() : base("LaserLabDataProcessUIModel")
		{
			InitClass();
			this.SetResourceInfo("0be095e0-34d0-447e-9f14-d2b46448f427");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private LaserLabDataProcessUIModelModel(bool isInit) : base("LaserLabDataProcessUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new LaserLabDataProcessUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private LaserLabDataProcessViewView viewLaserLabDataProcessView;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public LaserLabDataProcessViewView LaserLabDataProcessView
		{
			get { return (LaserLabDataProcessViewView)this["LaserLabDataProcessView"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewLaserLabDataProcessView = new LaserLabDataProcessViewView(this);
			this.viewLaserLabDataProcessView.SetResourceInfo("3fab4c17-1974-46ad-a0cb-f636e4390145");
			this.Views.Add(this.viewLaserLabDataProcessView);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.XMQX.LaserLabDataProcessUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class LaserLabDataProcessViewView : UIView
	{
		#region Constructor
		public LaserLabDataProcessViewView(IUIModel model) : base(model,"LaserLabDataProcessView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private LaserLabDataProcessViewView():base(null,"LaserLabDataProcessView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new LaserLabDataProcessViewView();
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
		public IUIField FieldLaserLabCode
		{
			get { return this.Fields["LaserLabCode"]; }
		}
		public IUIField FieldBatchNo
		{
			get { return this.Fields["BatchNo"]; }
		}
		public IUIField FieldType
		{
			get { return this.Fields["Type"]; }
		}
		public IUIField FieldFlowNumStart
		{
			get { return this.Fields["FlowNumStart"]; }
		}
		public IUIField FieldFlowNumEnd
		{
			get { return this.Fields["FlowNumEnd"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public LaserLabDataProcessViewDefaultFilterFilter DefaultFilter
		{
			get { return (LaserLabDataProcessViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","8bd6749a-53ab-4a89-a2d5-f7959af04ad3");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","d2d27e85-ed84-4a93-b847-df73950cfee9");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b1b00cfa-f2a3-47d3-9129-3cc47d45458e");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","f9a6e0c3-cc05-4be9-97d5-358df3bd6553");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c8495c8d-8b71-4f9b-9427-c64961cb8678");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","2431a83b-ae0b-4319-9ff4-b0b2c3ed0ec2");
			UIModelRuntimeFactory.AddNewUIField(this,"LaserLabCode", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7ee1fcbc-2665-44d6-9297-321ce22c7992");
			UIModelRuntimeFactory.AddNewUIField(this,"BatchNo", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e701dbd4-2f99-4f61-9551-3196e52a81c7");
			UIModelRuntimeFactory.AddNewUIField(this,"Type", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6120c860-1760-4d74-867b-2541d6ce54ac");
			UIModelRuntimeFactory.AddNewUIField(this,"FlowNumStart", typeof(Int32), true,"0","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e199c6c0-a2a1-4f03-916c-b707772fc7c8");
			UIModelRuntimeFactory.AddNewUIField(this,"FlowNumEnd", typeof(Int32), true,"0","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7bebb355-dd80-4f99-8a5a-97dd061e38d3");


			this.CurrentFilter = new LaserLabDataProcessViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new LaserLabDataProcessViewRecord(builder);
		}
		#endregion

		#region new method
		public new LaserLabDataProcessViewRecord FocusedRecord
		{
			get { return (LaserLabDataProcessViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new LaserLabDataProcessViewRecord AddNewUIRecord()
		{	
			return (LaserLabDataProcessViewRecord)base.AddNewUIRecord();
		}
		public new LaserLabDataProcessViewRecord NewUIRecord()
		{	
			return (LaserLabDataProcessViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class LaserLabDataProcessViewRecord : UIRecord
	{
		#region Constructor
		public LaserLabDataProcessViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private LaserLabDataProcessViewView uiviewLaserLabDataProcessView
		{
			get { return (LaserLabDataProcessViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new LaserLabDataProcessViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewLaserLabDataProcessView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewLaserLabDataProcessView.FieldID);
			}
			set{
				this[this.uiviewLaserLabDataProcessView.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewLaserLabDataProcessView.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewLaserLabDataProcessView.FieldCreatedOn);
			}
			set{
				this[this.uiviewLaserLabDataProcessView.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewLaserLabDataProcessView.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLaserLabDataProcessView.FieldCreatedBy);
			}
			set{
				this[this.uiviewLaserLabDataProcessView.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewLaserLabDataProcessView.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewLaserLabDataProcessView.FieldModifiedOn);
			}
			set{
				this[this.uiviewLaserLabDataProcessView.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewLaserLabDataProcessView.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLaserLabDataProcessView.FieldModifiedBy);
			}
			set{
				this[this.uiviewLaserLabDataProcessView.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewLaserLabDataProcessView.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewLaserLabDataProcessView.FieldSysVersion);
			}
			set{
				this[this.uiviewLaserLabDataProcessView.FieldSysVersion] = value;
			}
		}
		
		
		public  String LaserLabCode
		{
			get{
				//object value = this[this.uiviewLaserLabDataProcessView.FieldLaserLabCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLaserLabDataProcessView.FieldLaserLabCode);
			}
			set{
				this[this.uiviewLaserLabDataProcessView.FieldLaserLabCode] = value;
			}
		}
		
		
		public  String BatchNo
		{
			get{
				//object value = this[this.uiviewLaserLabDataProcessView.FieldBatchNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLaserLabDataProcessView.FieldBatchNo);
			}
			set{
				this[this.uiviewLaserLabDataProcessView.FieldBatchNo] = value;
			}
		}
		
		
		public  String Type
		{
			get{
				//object value = this[this.uiviewLaserLabDataProcessView.FieldType] ;
				//return (String)value;
				return GetValue<String>(this.uiviewLaserLabDataProcessView.FieldType);
			}
			set{
				this[this.uiviewLaserLabDataProcessView.FieldType] = value;
			}
		}
		
		
		public  Int32? FlowNumStart
		{
			get{
				//object value = this[this.uiviewLaserLabDataProcessView.FieldFlowNumStart] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewLaserLabDataProcessView.FieldFlowNumStart);
			}
			set{
				this[this.uiviewLaserLabDataProcessView.FieldFlowNumStart] = value;
			}
		}
		
		
		public  Int32? FlowNumEnd
		{
			get{
				//object value = this[this.uiviewLaserLabDataProcessView.FieldFlowNumEnd] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewLaserLabDataProcessView.FieldFlowNumEnd);
			}
			set{
				this[this.uiviewLaserLabDataProcessView.FieldFlowNumEnd] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class LaserLabDataProcessViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public LaserLabDataProcessViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private LaserLabDataProcessViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new LaserLabDataProcessViewDefaultFilterFilter();
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