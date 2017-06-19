#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.CostSharingRatioUIModel
{
	[Serializable]
	public partial class CostSharingRatioUIModelModel : UIModel
	{
		#region Constructor
		public CostSharingRatioUIModelModel() : base("CostSharingRatioUIModel")
		{
			InitClass();
			this.SetResourceInfo("cd95e86a-056d-408a-aa0c-6cd1af7a081a");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private CostSharingRatioUIModelModel(bool isInit) : base("CostSharingRatioUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new CostSharingRatioUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private CostSharingRatioBEView viewCostSharingRatioBE;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public CostSharingRatioBEView CostSharingRatioBE
		{
			get { return (CostSharingRatioBEView)this["CostSharingRatioBE"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewCostSharingRatioBE = new CostSharingRatioBEView(this);
			this.viewCostSharingRatioBE.SetResourceInfo("74f19acd-455c-47fe-acc6-0580fa102cc7");
			this.Views.Add(this.viewCostSharingRatioBE);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.CostSharingRatioUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class CostSharingRatioBEView : UIView
	{
		#region Constructor
		public CostSharingRatioBEView(IUIModel model) : base(model,"CostSharingRatioBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.CostSharingRatio.CostSharingRatioBE", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private CostSharingRatioBEView():base(null,"CostSharingRatioBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.CostSharingRatio.CostSharingRatioBE", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new CostSharingRatioBEView();
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
		public IUIField FieldRatio
		{
			get { return this.Fields["Ratio"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public CostSharingRatioBEDefaultFilterFilter DefaultFilter
		{
			get { return (CostSharingRatioBEDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","085365d7-e926-4d66-bb5d-9bacbf34036b");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","7284161f-7248-4ec9-a3c2-ac4f96a77373");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1ec34f0b-ee0c-4f6c-9562-35973823d642");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","5731bc3e-f0a9-4f53-9b93-ce740745f043");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","de9a0e37-29a5-4bfd-bdb1-c6a5d2f55387");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","24b2e0b7-89a9-48c4-a1e7-228c44f272ed");
			UIModelRuntimeFactory.AddNewUIField(this,"Ratio", typeof(Decimal), true,"0","System.Decimal", "Ratio", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","649433e1-65b7-45c2-bd8f-89aceed8080b");


			this.CurrentFilter = new CostSharingRatioBEDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new CostSharingRatioBERecord(builder);
		}
		#endregion

		#region new method
		public new CostSharingRatioBERecord FocusedRecord
		{
			get { return (CostSharingRatioBERecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new CostSharingRatioBERecord AddNewUIRecord()
		{	
			return (CostSharingRatioBERecord)base.AddNewUIRecord();
		}
		public new CostSharingRatioBERecord NewUIRecord()
		{	
			return (CostSharingRatioBERecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class CostSharingRatioBERecord : UIRecord
	{
		#region Constructor
		public CostSharingRatioBERecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private CostSharingRatioBEView uiviewCostSharingRatioBE
		{
			get { return (CostSharingRatioBEView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new CostSharingRatioBERecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewCostSharingRatioBE.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCostSharingRatioBE.FieldID);
			}
			set{
				this[this.uiviewCostSharingRatioBE.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewCostSharingRatioBE.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCostSharingRatioBE.FieldCreatedOn);
			}
			set{
				this[this.uiviewCostSharingRatioBE.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewCostSharingRatioBE.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCostSharingRatioBE.FieldCreatedBy);
			}
			set{
				this[this.uiviewCostSharingRatioBE.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewCostSharingRatioBE.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewCostSharingRatioBE.FieldModifiedOn);
			}
			set{
				this[this.uiviewCostSharingRatioBE.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewCostSharingRatioBE.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCostSharingRatioBE.FieldModifiedBy);
			}
			set{
				this[this.uiviewCostSharingRatioBE.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewCostSharingRatioBE.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewCostSharingRatioBE.FieldSysVersion);
			}
			set{
				this[this.uiviewCostSharingRatioBE.FieldSysVersion] = value;
			}
		}
		
		
		public  Decimal? Ratio
		{
			get{
				//object value = this[this.uiviewCostSharingRatioBE.FieldRatio] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewCostSharingRatioBE.FieldRatio);
			}
			set{
				this[this.uiviewCostSharingRatioBE.FieldRatio] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class CostSharingRatioBEDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public CostSharingRatioBEDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private CostSharingRatioBEDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new CostSharingRatioBEDefaultFilterFilter();
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