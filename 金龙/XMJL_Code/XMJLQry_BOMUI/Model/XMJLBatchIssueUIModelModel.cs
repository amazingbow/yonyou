#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.XMJL.Qry.XMJLBatchIssueUIModel
{
	[Serializable]
	public partial class XMJLBatchIssueUIModelModel : UIModel
	{
		#region Constructor
		public XMJLBatchIssueUIModelModel() : base("XMJLBatchIssueUIModel")
		{
			InitClass();
			this.SetResourceInfo("83b09aff-244e-42b6-a98f-2cad8966dc32");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private XMJLBatchIssueUIModelModel(bool isInit) : base("XMJLBatchIssueUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new XMJLBatchIssueUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private FindBOMMainWhereViewView viewFindBOMMainWhereView;			
		private BOMMainInfoViewView viewBOMMainInfoView;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public FindBOMMainWhereViewView FindBOMMainWhereView
		{
			get { return (FindBOMMainWhereViewView)this["FindBOMMainWhereView"]; }
		}
		public BOMMainInfoViewView BOMMainInfoView
		{
			get { return (BOMMainInfoViewView)this["BOMMainInfoView"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewFindBOMMainWhereView = new FindBOMMainWhereViewView(this);
			this.viewFindBOMMainWhereView.SetResourceInfo("8d82a201-a82e-4873-b77c-be383029b068");
			this.Views.Add(this.viewFindBOMMainWhereView);			
			this.viewBOMMainInfoView = new BOMMainInfoViewView(this);
			this.viewBOMMainInfoView.SetResourceInfo("4ead2777-39a5-40a5-8e41-c29a8d0516cc");
			this.Views.Add(this.viewBOMMainInfoView);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.XMJL.Qry.BOMUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class FindBOMMainWhereViewView : UIView
	{
		#region Constructor
		public FindBOMMainWhereViewView(IUIModel model) : base(model,"FindBOMMainWhereView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private FindBOMMainWhereViewView():base(null,"FindBOMMainWhereView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new FindBOMMainWhereViewView();
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
		public IUIField FieldContractNo
		{
			get { return this.Fields["ContractNo"]; }
		}
		public IUIField FieldCarType
		{
			get { return this.Fields["CarType"]; }
		}
		public IUIField FieldManufactureNo_Code
		{
			get { return this.Fields["ManufactureNo_Code"]; }
		}
		public IUIField FieldManufactureNo_Name
		{
			get { return this.Fields["ManufactureNo_Name"]; }
		}
		public IUIField FieldDisburseType
		{
			get { return this.Fields["DisburseType"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public FindBOMMainWhereViewDefaultFilterFilter DefaultFilter
		{
			get { return (FindBOMMainWhereViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","c5a4b508-b389-4f2e-8dc8-d820d9039bfa");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","97c15a7c-b39f-44ca-8ced-2f1caf212b3c");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","202f1bc0-1330-4c6f-a645-b65fc3cc7965");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","cea0d5ca-cefb-4ecd-ba34-3d065dc7b3bd");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f717e50e-4699-4981-b28d-1bed48b3d4da");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","642886ed-b518-48b6-913f-4f88a4b27fc2");
			UIModelRuntimeFactory.AddNewUIField(this,"ManufactureNo", typeof(String), true,"","UFIDA.U9.CBO.SCM.ProjectTask.Project", "", false,false, false, "",false,(UIFieldType)4,"7bc6294b-1a35-4e37-acfe-5abc5602f12f","a4dddf2f-c2cd-4bd7-8a2a-da8f5615b22f");
			UIModelRuntimeFactory.AddNewUIField(this,"ContractNo", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c268ee64-83ad-48ff-9b75-dfb08c7af55f");
			UIModelRuntimeFactory.AddNewUIField(this,"CarType", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c0dfb6bc-af43-4d16-ba93-ea49c1dbfd20");
			UIModelRuntimeFactory.AddNewUIField(this,"ManufactureNo_Code", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","89b811f0-53bc-4232-b639-d7774d2f68d4");
			UIModelRuntimeFactory.AddNewUIField(this,"ManufactureNo_Name", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a9aa55d2-cb8c-493a-a572-2eea16156cb1");
			UIModelRuntimeFactory.AddNewUIField(this,"DisburseType", typeof(Int32), true,"1","UFIDA.U9.Cust.XMJL.BommBE.BomMainType", "", false,false, false, "",false,(UIFieldType)2,"5e551e18-569c-4e57-a0d0-81757fb7a7a0","c83cb788-c183-4357-9132-e99fa9ee48dc");


			this.CurrentFilter = new FindBOMMainWhereViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new FindBOMMainWhereViewRecord(builder);
		}
		#endregion

		#region new method
		public new FindBOMMainWhereViewRecord FocusedRecord
		{
			get { return (FindBOMMainWhereViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new FindBOMMainWhereViewRecord AddNewUIRecord()
		{	
			return (FindBOMMainWhereViewRecord)base.AddNewUIRecord();
		}
		public new FindBOMMainWhereViewRecord NewUIRecord()
		{	
			return (FindBOMMainWhereViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class FindBOMMainWhereViewRecord : UIRecord
	{
		#region Constructor
		public FindBOMMainWhereViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private FindBOMMainWhereViewView uiviewFindBOMMainWhereView
		{
			get { return (FindBOMMainWhereViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new FindBOMMainWhereViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewFindBOMMainWhereView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewFindBOMMainWhereView.FieldID);
			}
			set{
				this[this.uiviewFindBOMMainWhereView.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewFindBOMMainWhereView.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewFindBOMMainWhereView.FieldCreatedOn);
			}
			set{
				this[this.uiviewFindBOMMainWhereView.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewFindBOMMainWhereView.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFindBOMMainWhereView.FieldCreatedBy);
			}
			set{
				this[this.uiviewFindBOMMainWhereView.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewFindBOMMainWhereView.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewFindBOMMainWhereView.FieldModifiedOn);
			}
			set{
				this[this.uiviewFindBOMMainWhereView.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewFindBOMMainWhereView.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFindBOMMainWhereView.FieldModifiedBy);
			}
			set{
				this[this.uiviewFindBOMMainWhereView.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewFindBOMMainWhereView.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewFindBOMMainWhereView.FieldSysVersion);
			}
			set{
				this[this.uiviewFindBOMMainWhereView.FieldSysVersion] = value;
			}
		}
		
		
		public  String ManufactureNo
		{
			get{
				//object value = this[this.uiviewFindBOMMainWhereView.FieldManufactureNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFindBOMMainWhereView.FieldManufactureNo);
			}
			set{
				this[this.uiviewFindBOMMainWhereView.FieldManufactureNo] = value;
			}
		}
		
		
		public  String ContractNo
		{
			get{
				//object value = this[this.uiviewFindBOMMainWhereView.FieldContractNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFindBOMMainWhereView.FieldContractNo);
			}
			set{
				this[this.uiviewFindBOMMainWhereView.FieldContractNo] = value;
			}
		}
		
		
		public  String CarType
		{
			get{
				//object value = this[this.uiviewFindBOMMainWhereView.FieldCarType] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFindBOMMainWhereView.FieldCarType);
			}
			set{
				this[this.uiviewFindBOMMainWhereView.FieldCarType] = value;
			}
		}
		
		
		public  String ManufactureNo_Code
		{
			get{
				//object value = this[this.uiviewFindBOMMainWhereView.FieldManufactureNo_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFindBOMMainWhereView.FieldManufactureNo_Code);
			}
			set{
				this[this.uiviewFindBOMMainWhereView.FieldManufactureNo_Code] = value;
			}
		}
		
		
		public  String ManufactureNo_Name
		{
			get{
				//object value = this[this.uiviewFindBOMMainWhereView.FieldManufactureNo_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewFindBOMMainWhereView.FieldManufactureNo_Name);
			}
			set{
				this[this.uiviewFindBOMMainWhereView.FieldManufactureNo_Name] = value;
			}
		}
		
		
		public  Int32? DisburseType
		{
			get{
				//object value = this[this.uiviewFindBOMMainWhereView.FieldDisburseType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewFindBOMMainWhereView.FieldDisburseType);
			}
			set{
				this[this.uiviewFindBOMMainWhereView.FieldDisburseType] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class FindBOMMainWhereViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public FindBOMMainWhereViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private FindBOMMainWhereViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new FindBOMMainWhereViewDefaultFilterFilter();
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
	public partial class BOMMainInfoViewView : UIView
	{
		#region Constructor
		public BOMMainInfoViewView(IUIModel model) : base(model,"BOMMainInfoView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private BOMMainInfoViewView():base(null,"BOMMainInfoView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new BOMMainInfoViewView();
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
		public IUIField FieldContractNo
		{
			get { return this.Fields["ContractNo"]; }
		}
		public IUIField FieldCarType
		{
			get { return this.Fields["CarType"]; }
		}
		public IUIField FieldManufactureNo_Code
		{
			get { return this.Fields["ManufactureNo_Code"]; }
		}
		public IUIField FieldManufactureNo_Name
		{
			get { return this.Fields["ManufactureNo_Name"]; }
		}
		public IUIField FieldNo
		{
			get { return this.Fields["No"]; }
		}
		public IUIField FieldDisburseType
		{
			get { return this.Fields["DisburseType"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public BOMMainInfoViewDefaultFilterFilter DefaultFilter
		{
			get { return (BOMMainInfoViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","40440cd0-d717-401f-9217-ad78a9bf3f15");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","66cf76cf-cb94-456e-8d95-bccf14c0a2df");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f44ceae4-b502-463a-86bf-c5cc5c2bdf81");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","9b35d256-8238-4d4f-8d16-00216e3912c9");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c1910b67-44df-4738-9df0-19d9dc6ab989");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","a3cbf07e-74c2-44ef-b20f-a14e0fb35842");
			UIModelRuntimeFactory.AddNewUIField(this,"ManufactureNo", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.ProjectTask.Project", "", false,false, false, "",false,(UIFieldType)4,"7bc6294b-1a35-4e37-acfe-5abc5602f12f","958c52bb-2b58-411c-9808-3bcf53e986eb");
			UIModelRuntimeFactory.AddNewUIField(this,"ContractNo", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9a86bd1f-8eba-433f-b7ff-3f7b10ddcccc");
			UIModelRuntimeFactory.AddNewUIField(this,"CarType", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a0b9ff4a-158c-497f-8107-d5d3a2cd3874");
			UIModelRuntimeFactory.AddNewUIField(this,"ManufactureNo_Code", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fe9d0a59-3b63-4b29-9f39-88543f90b75a");
			UIModelRuntimeFactory.AddNewUIField(this,"ManufactureNo_Name", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1657db2b-9c44-4d71-9b62-8d7f54dd75aa");
			UIModelRuntimeFactory.AddNewUIField(this,"No", typeof(Int32), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a9380a33-ad81-45f0-aed3-46e28643a2d8");
			UIModelRuntimeFactory.AddNewUIField(this,"DisburseType", typeof(Int32), true,"","UFIDA.U9.Cust.XMJL.BommBE.BomMainType", "", false,false, false, "",false,(UIFieldType)2,"5e551e18-569c-4e57-a0d0-81757fb7a7a0","e454a3f9-46aa-456b-9111-4c0951b5c55e");


			this.CurrentFilter = new BOMMainInfoViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new BOMMainInfoViewRecord(builder);
		}
		#endregion

		#region new method
		public new BOMMainInfoViewRecord FocusedRecord
		{
			get { return (BOMMainInfoViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new BOMMainInfoViewRecord AddNewUIRecord()
		{	
			return (BOMMainInfoViewRecord)base.AddNewUIRecord();
		}
		public new BOMMainInfoViewRecord NewUIRecord()
		{	
			return (BOMMainInfoViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class BOMMainInfoViewRecord : UIRecord
	{
		#region Constructor
		public BOMMainInfoViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private BOMMainInfoViewView uiviewBOMMainInfoView
		{
			get { return (BOMMainInfoViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new BOMMainInfoViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewBOMMainInfoView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBOMMainInfoView.FieldID);
			}
			set{
				this[this.uiviewBOMMainInfoView.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewBOMMainInfoView.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewBOMMainInfoView.FieldCreatedOn);
			}
			set{
				this[this.uiviewBOMMainInfoView.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewBOMMainInfoView.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBOMMainInfoView.FieldCreatedBy);
			}
			set{
				this[this.uiviewBOMMainInfoView.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewBOMMainInfoView.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewBOMMainInfoView.FieldModifiedOn);
			}
			set{
				this[this.uiviewBOMMainInfoView.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewBOMMainInfoView.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBOMMainInfoView.FieldModifiedBy);
			}
			set{
				this[this.uiviewBOMMainInfoView.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewBOMMainInfoView.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBOMMainInfoView.FieldSysVersion);
			}
			set{
				this[this.uiviewBOMMainInfoView.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? ManufactureNo
		{
			get{
				//object value = this[this.uiviewBOMMainInfoView.FieldManufactureNo] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewBOMMainInfoView.FieldManufactureNo);
			}
			set{
				this[this.uiviewBOMMainInfoView.FieldManufactureNo] = value;
			}
		}
		
		
		public  String ContractNo
		{
			get{
				//object value = this[this.uiviewBOMMainInfoView.FieldContractNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBOMMainInfoView.FieldContractNo);
			}
			set{
				this[this.uiviewBOMMainInfoView.FieldContractNo] = value;
			}
		}
		
		
		public  String CarType
		{
			get{
				//object value = this[this.uiviewBOMMainInfoView.FieldCarType] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBOMMainInfoView.FieldCarType);
			}
			set{
				this[this.uiviewBOMMainInfoView.FieldCarType] = value;
			}
		}
		
		
		public  String ManufactureNo_Code
		{
			get{
				//object value = this[this.uiviewBOMMainInfoView.FieldManufactureNo_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBOMMainInfoView.FieldManufactureNo_Code);
			}
			set{
				this[this.uiviewBOMMainInfoView.FieldManufactureNo_Code] = value;
			}
		}
		
		
		public  String ManufactureNo_Name
		{
			get{
				//object value = this[this.uiviewBOMMainInfoView.FieldManufactureNo_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBOMMainInfoView.FieldManufactureNo_Name);
			}
			set{
				this[this.uiviewBOMMainInfoView.FieldManufactureNo_Name] = value;
			}
		}
		
		
		public  Int32? No
		{
			get{
				//object value = this[this.uiviewBOMMainInfoView.FieldNo] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewBOMMainInfoView.FieldNo);
			}
			set{
				this[this.uiviewBOMMainInfoView.FieldNo] = value;
			}
		}
		
		
		public  Int32? DisburseType
		{
			get{
				//object value = this[this.uiviewBOMMainInfoView.FieldDisburseType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewBOMMainInfoView.FieldDisburseType);
			}
			set{
				this[this.uiviewBOMMainInfoView.FieldDisburseType] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class BOMMainInfoViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public BOMMainInfoViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private BOMMainInfoViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new BOMMainInfoViewDefaultFilterFilter();
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