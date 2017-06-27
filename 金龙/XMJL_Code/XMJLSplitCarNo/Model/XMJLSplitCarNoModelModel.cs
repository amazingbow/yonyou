#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.XMJL.XMJLSplitCarNoModel
{
	[Serializable]
	public partial class XMJLSplitCarNoModelModel : UIModel
	{
		#region Constructor
		public XMJLSplitCarNoModelModel() : base("XMJLSplitCarNoModel")
		{
			InitClass();
			this.SetResourceInfo("ddb94a0d-e262-46a9-8d68-88051b50c11c");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private XMJLSplitCarNoModelModel(bool isInit) : base("XMJLSplitCarNoModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new XMJLSplitCarNoModelModel(false);
		}
		#endregion
		#region member
		#region views
		private SplitViewView viewSplitView;			
		private SplitPlanViewView viewSplitPlanView;			
		private ProjectViewView viewProjectView;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public SplitViewView SplitView
		{
			get { return (SplitViewView)this["SplitView"]; }
		}
		public SplitPlanViewView SplitPlanView
		{
			get { return (SplitPlanViewView)this["SplitPlanView"]; }
		}
		public ProjectViewView ProjectView
		{
			get { return (ProjectViewView)this["ProjectView"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewSplitView = new SplitViewView(this);
			this.viewSplitView.SetResourceInfo("3e45ce5a-11fe-40de-b3a8-e7b6f206e14b");
			this.Views.Add(this.viewSplitView);			
			this.viewSplitPlanView = new SplitPlanViewView(this);
			this.viewSplitPlanView.SetResourceInfo("1fef857d-b281-4247-845c-f5f98eb4e6a7");
			this.Views.Add(this.viewSplitPlanView);			
			this.viewProjectView = new ProjectViewView(this);
			this.viewProjectView.SetResourceInfo("616236e5-38ac-4b80-a4e5-5165f5807e25");
			this.Views.Add(this.viewProjectView);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.XMJL.XMJLSplitCarNo"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class SplitViewView : UIView
	{
		#region Constructor
		public SplitViewView(IUIModel model) : base(model,"SplitView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private SplitViewView():base(null,"SplitView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new SplitViewView();
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
		public IUIField FieldPlsID
		{
			get { return this.Fields["PlsID"]; }
		}
		public IUIField FieldRowNo
		{
			get { return this.Fields["RowNo"]; }
		}
		public IUIField FieldManufactureNo
		{
			get { return this.Fields["ManufactureNo"]; }
		}
		public IUIField FieldReqCategory
		{
			get { return this.Fields["ReqCategory"]; }
		}
		public IUIField FieldCompanyContact
		{
			get { return this.Fields["CompanyContact"]; }
		}
		public IUIField FieldProdLine
		{
			get { return this.Fields["ProdLine"]; }
		}
		public IUIField FieldProdDate
		{
			get { return this.Fields["ProdDate"]; }
		}
		public IUIField FieldSequence
		{
			get { return this.Fields["Sequence"]; }
		}
		public IUIField FieldProductQty
		{
			get { return this.Fields["ProductQty"]; }
		}
		public IUIField FieldContractNum
		{
			get { return this.Fields["ContractNum"]; }
		}
		public IUIField FieldCarType
		{
			get { return this.Fields["CarType"]; }
		}
		public IUIField FieldStationName
		{
			get { return this.Fields["StationName"]; }
		}
		public IUIField FieldCustName
		{
			get { return this.Fields["CustName"]; }
		}
		public IUIField FieldContractDelivery
		{
			get { return this.Fields["ContractDelivery"]; }
		}
		public IUIField FieldSeibanCode
		{
			get { return this.Fields["SeibanCode"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public SplitViewDefaultFilterFilter DefaultFilter
		{
			get { return (SplitViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","9be201f2-8556-46ce-889a-83d1d76f1798");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","888302a9-8ca7-4016-844f-fa134a64736c");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","267fcd44-a331-4f23-aedf-aa236b31936b");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","1b3218cb-8de9-4d59-8da1-440dc6d1c47e");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7a888aea-7cc8-4a08-8408-46cc0f120f6d");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","d3103e7b-add8-44e4-9110-e2ace491a514");
			UIModelRuntimeFactory.AddNewUIField(this,"PlsID", typeof(Int64), true,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","625f6384-a47d-4704-8c38-1743090a2fbf");
			UIModelRuntimeFactory.AddNewUIField(this,"RowNo", typeof(Int32), true,"","System.Int32", "", false,false, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","02617996-2e3c-4377-8299-146221143a54");
			UIModelRuntimeFactory.AddNewUIField(this,"ManufactureNo", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1ae8190f-df46-4cbe-991b-3e7aac4099c5");
			UIModelRuntimeFactory.AddNewUIField(this,"ReqCategory", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","07477819-553f-4c61-8cce-c6d3ddbbd177");
			UIModelRuntimeFactory.AddNewUIField(this,"CompanyContact", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","25e55379-5f57-45bf-9e47-1fffe47bcbc0");
			UIModelRuntimeFactory.AddNewUIField(this,"ProdLine", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8bf2922e-558b-4c95-af3c-8dc047fd6df1");
			UIModelRuntimeFactory.AddNewUIField(this,"ProdDate", typeof(DateTime), true,"","System.Date", "", false,false, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","c54826b3-abd8-4b68-9b29-5c2e90c6d59a");
			UIModelRuntimeFactory.AddNewUIField(this,"Sequence", typeof(Int32), true,"","System.Int32", "", false,false, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","3ed311ed-dfa3-4ec5-9d7d-492a52c3c102");
			UIModelRuntimeFactory.AddNewUIField(this,"ProductQty", typeof(Decimal), true,"","System.Double", "", false,false, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","c56818dd-bf86-4bb3-9d56-23dc38ab0b4f");
			UIModelRuntimeFactory.AddNewUIField(this,"ContractNum", typeof(Decimal), true,"","System.Double", "", false,false, false, "",false,(UIFieldType)1,"a5242caa-f9ee-4159-b8c9-d0952a79175a","687e02a1-221a-4027-b88c-14604dbd7298");
			UIModelRuntimeFactory.AddNewUIField(this,"CarType", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fa135085-4e00-4c8a-a649-f9bc34450c81");
			UIModelRuntimeFactory.AddNewUIField(this,"StationName", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2b9c02a7-e407-474b-b699-06e5c7fcfddb");
			UIModelRuntimeFactory.AddNewUIField(this,"CustName", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4a73096f-9f62-4721-9bf3-81fa0b8ec868");
			UIModelRuntimeFactory.AddNewUIField(this,"ContractDelivery", typeof(DateTime), true,"","System.Date", "", false,false, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","e5e454cd-ec6e-4a68-bf34-d84098000a1c");
			UIModelRuntimeFactory.AddNewUIField(this,"SeibanCode", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ca5751bd-4a05-427b-b1ba-5aca54888117");


			this.CurrentFilter = new SplitViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new SplitViewRecord(builder);
		}
		#endregion

		#region new method
		public new SplitViewRecord FocusedRecord
		{
			get { return (SplitViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new SplitViewRecord AddNewUIRecord()
		{	
			return (SplitViewRecord)base.AddNewUIRecord();
		}
		public new SplitViewRecord NewUIRecord()
		{	
			return (SplitViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class SplitViewRecord : UIRecord
	{
		#region Constructor
		public SplitViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private SplitViewView uiviewSplitView
		{
			get { return (SplitViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new SplitViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewSplitView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewSplitView.FieldID);
			}
			set{
				this[this.uiviewSplitView.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewSplitView.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewSplitView.FieldCreatedOn);
			}
			set{
				this[this.uiviewSplitView.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewSplitView.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSplitView.FieldCreatedBy);
			}
			set{
				this[this.uiviewSplitView.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewSplitView.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewSplitView.FieldModifiedOn);
			}
			set{
				this[this.uiviewSplitView.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewSplitView.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSplitView.FieldModifiedBy);
			}
			set{
				this[this.uiviewSplitView.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewSplitView.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewSplitView.FieldSysVersion);
			}
			set{
				this[this.uiviewSplitView.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? PlsID
		{
			get{
				//object value = this[this.uiviewSplitView.FieldPlsID] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewSplitView.FieldPlsID);
			}
			set{
				this[this.uiviewSplitView.FieldPlsID] = value;
			}
		}
		
		
		public  Int32? RowNo
		{
			get{
				//object value = this[this.uiviewSplitView.FieldRowNo] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewSplitView.FieldRowNo);
			}
			set{
				this[this.uiviewSplitView.FieldRowNo] = value;
			}
		}
		
		
		public  String ManufactureNo
		{
			get{
				//object value = this[this.uiviewSplitView.FieldManufactureNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSplitView.FieldManufactureNo);
			}
			set{
				this[this.uiviewSplitView.FieldManufactureNo] = value;
			}
		}
		
		
		public  String ReqCategory
		{
			get{
				//object value = this[this.uiviewSplitView.FieldReqCategory] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSplitView.FieldReqCategory);
			}
			set{
				this[this.uiviewSplitView.FieldReqCategory] = value;
			}
		}
		
		
		public  String CompanyContact
		{
			get{
				//object value = this[this.uiviewSplitView.FieldCompanyContact] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSplitView.FieldCompanyContact);
			}
			set{
				this[this.uiviewSplitView.FieldCompanyContact] = value;
			}
		}
		
		
		public  String ProdLine
		{
			get{
				//object value = this[this.uiviewSplitView.FieldProdLine] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSplitView.FieldProdLine);
			}
			set{
				this[this.uiviewSplitView.FieldProdLine] = value;
			}
		}
		
		
		public  DateTime? ProdDate
		{
			get{
				//object value = this[this.uiviewSplitView.FieldProdDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSplitView.FieldProdDate);
			}
			set{
				this[this.uiviewSplitView.FieldProdDate] = value;
			}
		}
		
		
		public  Int32? Sequence
		{
			get{
				//object value = this[this.uiviewSplitView.FieldSequence] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewSplitView.FieldSequence);
			}
			set{
				this[this.uiviewSplitView.FieldSequence] = value;
			}
		}
		
		
		public  Decimal? ProductQty
		{
			get{
				//object value = this[this.uiviewSplitView.FieldProductQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewSplitView.FieldProductQty);
			}
			set{
				this[this.uiviewSplitView.FieldProductQty] = value;
			}
		}
		
		
		public  Decimal? ContractNum
		{
			get{
				//object value = this[this.uiviewSplitView.FieldContractNum] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewSplitView.FieldContractNum);
			}
			set{
				this[this.uiviewSplitView.FieldContractNum] = value;
			}
		}
		
		
		public  String CarType
		{
			get{
				//object value = this[this.uiviewSplitView.FieldCarType] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSplitView.FieldCarType);
			}
			set{
				this[this.uiviewSplitView.FieldCarType] = value;
			}
		}
		
		
		public  String StationName
		{
			get{
				//object value = this[this.uiviewSplitView.FieldStationName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSplitView.FieldStationName);
			}
			set{
				this[this.uiviewSplitView.FieldStationName] = value;
			}
		}
		
		
		public  String CustName
		{
			get{
				//object value = this[this.uiviewSplitView.FieldCustName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSplitView.FieldCustName);
			}
			set{
				this[this.uiviewSplitView.FieldCustName] = value;
			}
		}
		
		
		public  DateTime? ContractDelivery
		{
			get{
				//object value = this[this.uiviewSplitView.FieldContractDelivery] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSplitView.FieldContractDelivery);
			}
			set{
				this[this.uiviewSplitView.FieldContractDelivery] = value;
			}
		}
		
		
		public  String SeibanCode
		{
			get{
				//object value = this[this.uiviewSplitView.FieldSeibanCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSplitView.FieldSeibanCode);
			}
			set{
				this[this.uiviewSplitView.FieldSeibanCode] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class SplitViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public SplitViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private SplitViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new SplitViewDefaultFilterFilter();
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
	public partial class SplitPlanViewView : UIView
	{
		#region Constructor
		public SplitPlanViewView(IUIModel model) : base(model,"SplitPlanView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private SplitPlanViewView():base(null,"SplitPlanView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new SplitPlanViewView();
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
		public IUIField FieldScheduling
		{
			get { return this.Fields["Scheduling"]; }
		}
		public IUIField FieldReqCategory
		{
			get { return this.Fields["ReqCategory"]; }
		}
		public IUIField FieldCompanyContract
		{
			get { return this.Fields["CompanyContract"]; }
		}
		public IUIField FieldProdLine
		{
			get { return this.Fields["ProdLine"]; }
		}
		public IUIField FieldProdDate
		{
			get { return this.Fields["ProdDate"]; }
		}
		public IUIField FieldSequence
		{
			get { return this.Fields["Sequence"]; }
		}
		public IUIField FieldProductQty
		{
			get { return this.Fields["ProductQty"]; }
		}
		public IUIField FieldContractNum
		{
			get { return this.Fields["ContractNum"]; }
		}
		public IUIField FieldCarType
		{
			get { return this.Fields["CarType"]; }
		}
		public IUIField FieldStagnationContract
		{
			get { return this.Fields["StagnationContract"]; }
		}
		public IUIField FieldStationName
		{
			get { return this.Fields["StationName"]; }
		}
		public IUIField FieldCustName
		{
			get { return this.Fields["CustName"]; }
		}
		public IUIField FieldContractDelivery
		{
			get { return this.Fields["ContractDelivery"]; }
		}
		public IUIField FieldPlsID
		{
			get { return this.Fields["PlsID"]; }
		}
		public IUIField FieldSeibanCode
		{
			get { return this.Fields["SeibanCode"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public SplitPlanViewDefaultFilterFilter DefaultFilter
		{
			get { return (SplitPlanViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","2d9d8f49-af5c-457b-9f87-6fd40a895c26");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","46b43a89-f3a4-4df2-aa13-e1121faf6186");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c6be8a63-f77c-4a5a-9fac-3046f0018b59");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","ba513e35-35b3-417f-81df-879022ef9ec4");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c7487f2e-82e3-4799-b9e7-2b7078d4bc5a");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","182fbca0-e4ac-4e9e-8406-46e69bf4f5c9");
			UIModelRuntimeFactory.AddNewUIField(this,"Scheduling", typeof(Int32), true,"","System.Int32", "", false,false, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","c2ac6c15-3924-4c4f-bb6c-5eef1b4e41ad");
			UIModelRuntimeFactory.AddNewUIField(this,"ReqCategory", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bd671333-878c-4b8a-9f01-39ff5025669a");
			UIModelRuntimeFactory.AddNewUIField(this,"CompanyContract", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9735182a-3765-4b74-91b0-64550e93897c");
			UIModelRuntimeFactory.AddNewUIField(this,"ProdLine", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2cf9774f-928d-4f9c-94cf-b575c2536685");
			UIModelRuntimeFactory.AddNewUIField(this,"ProdDate", typeof(DateTime), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fb686af3-6b04-4383-92cf-e5bc376e0e19");
			UIModelRuntimeFactory.AddNewUIField(this,"Sequence", typeof(Decimal), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b57fa3fe-4e95-4c2d-96b7-7fe5a23b02b9");
			UIModelRuntimeFactory.AddNewUIField(this,"ProductQty", typeof(Decimal), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","495c54d9-70e0-41c2-ac93-3df800023f0f");
			UIModelRuntimeFactory.AddNewUIField(this,"ContractNum", typeof(Decimal), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9158e607-2389-4af1-b0c4-74430b383dae");
			UIModelRuntimeFactory.AddNewUIField(this,"CarType", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0dfd0200-ed86-47a9-8258-fcc2d91fdcc6");
			UIModelRuntimeFactory.AddNewUIField(this,"StagnationContract", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7286eaac-8ae6-49b5-927f-748144415c35");
			UIModelRuntimeFactory.AddNewUIField(this,"StationName", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9820b7e3-c43f-4b09-ac45-c5dac5b52bee");
			UIModelRuntimeFactory.AddNewUIField(this,"CustName", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5e659718-3335-4210-9d11-e8e4c193699e");
			UIModelRuntimeFactory.AddNewUIField(this,"ContractDelivery", typeof(DateTime), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","68509e13-db1d-4868-880c-81088b5fc176");
			UIModelRuntimeFactory.AddNewUIField(this,"PlsID", typeof(Int64), true,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","45911a8d-fcb8-4a30-a0a4-b5b91d42cc2f");
			UIModelRuntimeFactory.AddNewUIField(this,"SeibanCode", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5d438961-ffea-444c-91b4-7c270389f530");


			this.CurrentFilter = new SplitPlanViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new SplitPlanViewRecord(builder);
		}
		#endregion

		#region new method
		public new SplitPlanViewRecord FocusedRecord
		{
			get { return (SplitPlanViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new SplitPlanViewRecord AddNewUIRecord()
		{	
			return (SplitPlanViewRecord)base.AddNewUIRecord();
		}
		public new SplitPlanViewRecord NewUIRecord()
		{	
			return (SplitPlanViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class SplitPlanViewRecord : UIRecord
	{
		#region Constructor
		public SplitPlanViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private SplitPlanViewView uiviewSplitPlanView
		{
			get { return (SplitPlanViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new SplitPlanViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewSplitPlanView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewSplitPlanView.FieldID);
			}
			set{
				this[this.uiviewSplitPlanView.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewSplitPlanView.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewSplitPlanView.FieldCreatedOn);
			}
			set{
				this[this.uiviewSplitPlanView.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewSplitPlanView.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSplitPlanView.FieldCreatedBy);
			}
			set{
				this[this.uiviewSplitPlanView.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewSplitPlanView.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewSplitPlanView.FieldModifiedOn);
			}
			set{
				this[this.uiviewSplitPlanView.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewSplitPlanView.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSplitPlanView.FieldModifiedBy);
			}
			set{
				this[this.uiviewSplitPlanView.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewSplitPlanView.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewSplitPlanView.FieldSysVersion);
			}
			set{
				this[this.uiviewSplitPlanView.FieldSysVersion] = value;
			}
		}
		
		
		public  Int32? Scheduling
		{
			get{
				//object value = this[this.uiviewSplitPlanView.FieldScheduling] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewSplitPlanView.FieldScheduling);
			}
			set{
				this[this.uiviewSplitPlanView.FieldScheduling] = value;
			}
		}
		
		
		public  String ReqCategory
		{
			get{
				//object value = this[this.uiviewSplitPlanView.FieldReqCategory] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSplitPlanView.FieldReqCategory);
			}
			set{
				this[this.uiviewSplitPlanView.FieldReqCategory] = value;
			}
		}
		
		
		public  String CompanyContract
		{
			get{
				//object value = this[this.uiviewSplitPlanView.FieldCompanyContract] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSplitPlanView.FieldCompanyContract);
			}
			set{
				this[this.uiviewSplitPlanView.FieldCompanyContract] = value;
			}
		}
		
		
		public  String ProdLine
		{
			get{
				//object value = this[this.uiviewSplitPlanView.FieldProdLine] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSplitPlanView.FieldProdLine);
			}
			set{
				this[this.uiviewSplitPlanView.FieldProdLine] = value;
			}
		}
		
		
		public  DateTime? ProdDate
		{
			get{
				//object value = this[this.uiviewSplitPlanView.FieldProdDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSplitPlanView.FieldProdDate);
			}
			set{
				this[this.uiviewSplitPlanView.FieldProdDate] = value;
			}
		}
		
		
		public  Decimal? Sequence
		{
			get{
				//object value = this[this.uiviewSplitPlanView.FieldSequence] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewSplitPlanView.FieldSequence);
			}
			set{
				this[this.uiviewSplitPlanView.FieldSequence] = value;
			}
		}
		
		
		public  Decimal? ProductQty
		{
			get{
				//object value = this[this.uiviewSplitPlanView.FieldProductQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewSplitPlanView.FieldProductQty);
			}
			set{
				this[this.uiviewSplitPlanView.FieldProductQty] = value;
			}
		}
		
		
		public  Decimal? ContractNum
		{
			get{
				//object value = this[this.uiviewSplitPlanView.FieldContractNum] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewSplitPlanView.FieldContractNum);
			}
			set{
				this[this.uiviewSplitPlanView.FieldContractNum] = value;
			}
		}
		
		
		public  String CarType
		{
			get{
				//object value = this[this.uiviewSplitPlanView.FieldCarType] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSplitPlanView.FieldCarType);
			}
			set{
				this[this.uiviewSplitPlanView.FieldCarType] = value;
			}
		}
		
		
		public  String StagnationContract
		{
			get{
				//object value = this[this.uiviewSplitPlanView.FieldStagnationContract] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSplitPlanView.FieldStagnationContract);
			}
			set{
				this[this.uiviewSplitPlanView.FieldStagnationContract] = value;
			}
		}
		
		
		public  String StationName
		{
			get{
				//object value = this[this.uiviewSplitPlanView.FieldStationName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSplitPlanView.FieldStationName);
			}
			set{
				this[this.uiviewSplitPlanView.FieldStationName] = value;
			}
		}
		
		
		public  String CustName
		{
			get{
				//object value = this[this.uiviewSplitPlanView.FieldCustName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSplitPlanView.FieldCustName);
			}
			set{
				this[this.uiviewSplitPlanView.FieldCustName] = value;
			}
		}
		
		
		public  DateTime? ContractDelivery
		{
			get{
				//object value = this[this.uiviewSplitPlanView.FieldContractDelivery] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSplitPlanView.FieldContractDelivery);
			}
			set{
				this[this.uiviewSplitPlanView.FieldContractDelivery] = value;
			}
		}
		
		
		public  Int64? PlsID
		{
			get{
				//object value = this[this.uiviewSplitPlanView.FieldPlsID] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewSplitPlanView.FieldPlsID);
			}
			set{
				this[this.uiviewSplitPlanView.FieldPlsID] = value;
			}
		}
		
		
		public  String SeibanCode
		{
			get{
				//object value = this[this.uiviewSplitPlanView.FieldSeibanCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSplitPlanView.FieldSeibanCode);
			}
			set{
				this[this.uiviewSplitPlanView.FieldSeibanCode] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class SplitPlanViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public SplitPlanViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private SplitPlanViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new SplitPlanViewDefaultFilterFilter();
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
	public partial class ProjectViewView : UIView
	{
		#region Constructor
		public ProjectViewView(IUIModel model) : base(model,"ProjectView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private ProjectViewView():base(null,"ProjectView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new ProjectViewView();
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
		public IUIField FieldManufactureID
		{
			get { return this.Fields["ManufactureID"]; }
		}
		public IUIField FieldManufactureNo
		{
			get { return this.Fields["ManufactureNo"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public ProjectViewDefaultFilterFilter DefaultFilter
		{
			get { return (ProjectViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","11105a26-829a-48ff-81d5-69e970bba977");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","9e0e9f13-40ed-43a5-8770-39affafd30b9");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b7ebd7b1-f6a3-40e8-9421-de4b38c65a29");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","f09ce567-df1e-4a64-b1b7-ca361b450ac6");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","28f5204e-0da9-441e-aee8-51f57bd5f4dc");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","f607377f-8212-441b-a10a-e2d4075cea52");
			UIModelRuntimeFactory.AddNewUIField(this,"ManufactureID", typeof(Int64), true,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","26e1a8f8-8187-40c7-a237-c7130f015d87");
			UIModelRuntimeFactory.AddNewUIField(this,"ManufactureNo", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","77cf3d3c-6976-4d42-b9a0-f6527873227f");


			this.CurrentFilter = new ProjectViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new ProjectViewRecord(builder);
		}
		#endregion

		#region new method
		public new ProjectViewRecord FocusedRecord
		{
			get { return (ProjectViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new ProjectViewRecord AddNewUIRecord()
		{	
			return (ProjectViewRecord)base.AddNewUIRecord();
		}
		public new ProjectViewRecord NewUIRecord()
		{	
			return (ProjectViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class ProjectViewRecord : UIRecord
	{
		#region Constructor
		public ProjectViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private ProjectViewView uiviewProjectView
		{
			get { return (ProjectViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new ProjectViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewProjectView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewProjectView.FieldID);
			}
			set{
				this[this.uiviewProjectView.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewProjectView.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewProjectView.FieldCreatedOn);
			}
			set{
				this[this.uiviewProjectView.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewProjectView.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewProjectView.FieldCreatedBy);
			}
			set{
				this[this.uiviewProjectView.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewProjectView.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewProjectView.FieldModifiedOn);
			}
			set{
				this[this.uiviewProjectView.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewProjectView.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewProjectView.FieldModifiedBy);
			}
			set{
				this[this.uiviewProjectView.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewProjectView.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewProjectView.FieldSysVersion);
			}
			set{
				this[this.uiviewProjectView.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? ManufactureID
		{
			get{
				//object value = this[this.uiviewProjectView.FieldManufactureID] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewProjectView.FieldManufactureID);
			}
			set{
				this[this.uiviewProjectView.FieldManufactureID] = value;
			}
		}
		
		
		public  String ManufactureNo
		{
			get{
				//object value = this[this.uiviewProjectView.FieldManufactureNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewProjectView.FieldManufactureNo);
			}
			set{
				this[this.uiviewProjectView.FieldManufactureNo] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class ProjectViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public ProjectViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private ProjectViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new ProjectViewDefaultFilterFilter();
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