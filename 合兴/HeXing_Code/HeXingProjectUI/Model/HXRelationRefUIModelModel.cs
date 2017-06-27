#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.HeXingProjectUI.HXRelationRefUIModel
{
	[Serializable]
	public partial class HXRelationRefUIModelModel : UIModel
	{
		#region Constructor
		public HXRelationRefUIModelModel() : base("HXRelationRefUIModel")
		{
			InitClass();
			this.SetResourceInfo("0a0d41fe-f90d-4466-b8dc-252f08265c7d");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private HXRelationRefUIModelModel(bool isInit) : base("HXRelationRefUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new HXRelationRefUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private HXRelationRefFindViewView viewHXRelationRefFindView;			
		private HXRelationRefShowViewView viewHXRelationRefShowView;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public HXRelationRefFindViewView HXRelationRefFindView
		{
			get { return (HXRelationRefFindViewView)this["HXRelationRefFindView"]; }
		}
		public HXRelationRefShowViewView HXRelationRefShowView
		{
			get { return (HXRelationRefShowViewView)this["HXRelationRefShowView"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewHXRelationRefFindView = new HXRelationRefFindViewView(this);
			this.viewHXRelationRefFindView.SetResourceInfo("113b69d9-e45d-4474-95fb-3c1dd7d40064");
			this.Views.Add(this.viewHXRelationRefFindView);			
			this.viewHXRelationRefShowView = new HXRelationRefShowViewView(this);
			this.viewHXRelationRefShowView.SetResourceInfo("2861d8f7-9229-44c4-ac94-1fd25f53f2bc");
			this.Views.Add(this.viewHXRelationRefShowView);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.HeXingProjectUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class HXRelationRefFindViewView : UIView
	{
		#region Constructor
		public HXRelationRefFindViewView(IUIModel model) : base(model,"HXRelationRefFindView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private HXRelationRefFindViewView():base(null,"HXRelationRefFindView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new HXRelationRefFindViewView();
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
		public IUIField FieldOrg
		{
			get { return this.Fields["Org"]; }
		}
		public IUIField FieldRelType
		{
			get { return this.Fields["RelType"]; }
		}
		public IUIField FieldRelColumn
		{
			get { return this.Fields["RelColumn"]; }
		}
		public IUIField FieldOrg_Code
		{
			get { return this.Fields["Org_Code"]; }
		}
		public IUIField FieldOrg_Name
		{
			get { return this.Fields["Org_Name"]; }
		}
		public IUIField FieldRelText
		{
			get { return this.Fields["RelText"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public HXRelationRefFindViewDefaultFilterFilter DefaultFilter
		{
			get { return (HXRelationRefFindViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","5ae7bb4e-b5d4-41f7-a19b-0f1f9b277ee6");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","fa8a4ba4-c30c-43bb-9c51-6e77dccb8522");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ae4fd1e8-c968-4cb6-96d3-2f315d72ee9d");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","eede3f13-8ae4-4781-9e19-ba9c07a85944");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e8e9d95b-7653-4f25-8345-d5c21d4deada");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","472df927-6c01-4b2f-bf73-b367bb6d8b1a");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), true,"","UFIDA.U9.Base.Organization.Organization", "", false,false, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","9e3add61-7c7f-430a-9345-cb03b1c8a99d");
			UIModelRuntimeFactory.AddNewUIField(this,"RelType", typeof(Int32), true,"1","UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum", "", false,false, false, "",false,(UIFieldType)2,"55ff3b7f-5e3f-4ce9-ba25-42baf7bb7e0d","77608aa2-3049-46f8-8b44-c923c66aee6d");
			UIModelRuntimeFactory.AddNewUIField(this,"RelColumn", typeof(Int32), true,"0","UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.ColumnEmun", "", false,false, false, "",false,(UIFieldType)2,"bc0f2aaf-7175-45df-a1f9-87fcf42f2bfd","3ed12cd2-090a-4caa-b5e1-fb0e72cd695d");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f2af3c66-29f1-42cc-b7ee-60fc5c55bdf8");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ff2a511c-72d2-4c89-b07c-cefb0d54b942");
			UIModelRuntimeFactory.AddNewUIField(this,"RelText", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1bd6c4f9-a315-4fc3-90b7-c65d581f8718");


			this.CurrentFilter = new HXRelationRefFindViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new HXRelationRefFindViewRecord(builder);
		}
		#endregion

		#region new method
		public new HXRelationRefFindViewRecord FocusedRecord
		{
			get { return (HXRelationRefFindViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new HXRelationRefFindViewRecord AddNewUIRecord()
		{	
			return (HXRelationRefFindViewRecord)base.AddNewUIRecord();
		}
		public new HXRelationRefFindViewRecord NewUIRecord()
		{	
			return (HXRelationRefFindViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class HXRelationRefFindViewRecord : UIRecord
	{
		#region Constructor
		public HXRelationRefFindViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private HXRelationRefFindViewView uiviewHXRelationRefFindView
		{
			get { return (HXRelationRefFindViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new HXRelationRefFindViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewHXRelationRefFindView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewHXRelationRefFindView.FieldID);
			}
			set{
				this[this.uiviewHXRelationRefFindView.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewHXRelationRefFindView.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewHXRelationRefFindView.FieldCreatedOn);
			}
			set{
				this[this.uiviewHXRelationRefFindView.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewHXRelationRefFindView.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHXRelationRefFindView.FieldCreatedBy);
			}
			set{
				this[this.uiviewHXRelationRefFindView.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewHXRelationRefFindView.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewHXRelationRefFindView.FieldModifiedOn);
			}
			set{
				this[this.uiviewHXRelationRefFindView.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewHXRelationRefFindView.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHXRelationRefFindView.FieldModifiedBy);
			}
			set{
				this[this.uiviewHXRelationRefFindView.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewHXRelationRefFindView.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewHXRelationRefFindView.FieldSysVersion);
			}
			set{
				this[this.uiviewHXRelationRefFindView.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? Org
		{
			get{
				//object value = this[this.uiviewHXRelationRefFindView.FieldOrg] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewHXRelationRefFindView.FieldOrg);
			}
			set{
				this[this.uiviewHXRelationRefFindView.FieldOrg] = value;
			}
		}
		
		
		public  Int32? RelType
		{
			get{
				//object value = this[this.uiviewHXRelationRefFindView.FieldRelType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewHXRelationRefFindView.FieldRelType);
			}
			set{
				this[this.uiviewHXRelationRefFindView.FieldRelType] = value;
			}
		}
		
		
		public  Int32? RelColumn
		{
			get{
				//object value = this[this.uiviewHXRelationRefFindView.FieldRelColumn] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewHXRelationRefFindView.FieldRelColumn);
			}
			set{
				this[this.uiviewHXRelationRefFindView.FieldRelColumn] = value;
			}
		}
		
		
		public  String Org_Code
		{
			get{
				//object value = this[this.uiviewHXRelationRefFindView.FieldOrg_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHXRelationRefFindView.FieldOrg_Code);
			}
			set{
				this[this.uiviewHXRelationRefFindView.FieldOrg_Code] = value;
			}
		}
		
		
		public  String Org_Name
		{
			get{
				//object value = this[this.uiviewHXRelationRefFindView.FieldOrg_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHXRelationRefFindView.FieldOrg_Name);
			}
			set{
				this[this.uiviewHXRelationRefFindView.FieldOrg_Name] = value;
			}
		}
		
		
		public  String RelText
		{
			get{
				//object value = this[this.uiviewHXRelationRefFindView.FieldRelText] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHXRelationRefFindView.FieldRelText);
			}
			set{
				this[this.uiviewHXRelationRefFindView.FieldRelText] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class HXRelationRefFindViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public HXRelationRefFindViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private HXRelationRefFindViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new HXRelationRefFindViewDefaultFilterFilter();
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
	public partial class HXRelationRefShowViewView : UIView
	{
		#region Constructor
		public HXRelationRefShowViewView(IUIModel model) : base(model,"HXRelationRefShowView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private HXRelationRefShowViewView():base(null,"HXRelationRefShowView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new HXRelationRefShowViewView();
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
		public IUIField FieldRefCode
		{
			get { return this.Fields["RefCode"]; }
		}
		public IUIField FieldRefName
		{
			get { return this.Fields["RefName"]; }
		}
		public IUIField FieldRefID
		{
			get { return this.Fields["RefID"]; }
		}
		public IUIField FieldAccountProperty
		{
			get { return this.Fields["AccountProperty"]; }
		}
		public IUIField FieldBalanceDirection
		{
			get { return this.Fields["BalanceDirection"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public HXRelationRefShowViewDefaultFilterFilter DefaultFilter
		{
			get { return (HXRelationRefShowViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","951078fe-480a-4533-ab30-92f3901e42a0");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","ba703f35-c834-4a34-9e04-aae0eba2bdb3");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7212ed2c-7a4b-446e-8847-e8e01adc96bb");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","acbde82a-4de5-4b2c-854f-569add0e38fb");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","85843a5e-bbf4-49dd-9d0c-b355efaa0dfe");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","1378b0b0-1fc8-45be-a3ce-fd250b148b80");
			UIModelRuntimeFactory.AddNewUIField(this,"RefCode", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","672ec275-b9dd-495e-a5a7-57c258977cbf");
			UIModelRuntimeFactory.AddNewUIField(this,"RefName", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","35332702-30aa-4a7c-9f06-c2c5afd06282");
			UIModelRuntimeFactory.AddNewUIField(this,"RefID", typeof(Int64), true,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","f558de5a-12f3-46c7-a894-99ee018253d3");
			UIModelRuntimeFactory.AddNewUIField(this,"AccountProperty", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1da1d862-674d-442f-8a00-eb35956e4aad");
			UIModelRuntimeFactory.AddNewUIField(this,"BalanceDirection", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ea691431-4834-4111-8820-df5483022521");


			this.CurrentFilter = new HXRelationRefShowViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new HXRelationRefShowViewRecord(builder);
		}
		#endregion

		#region new method
		public new HXRelationRefShowViewRecord FocusedRecord
		{
			get { return (HXRelationRefShowViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new HXRelationRefShowViewRecord AddNewUIRecord()
		{	
			return (HXRelationRefShowViewRecord)base.AddNewUIRecord();
		}
		public new HXRelationRefShowViewRecord NewUIRecord()
		{	
			return (HXRelationRefShowViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class HXRelationRefShowViewRecord : UIRecord
	{
		#region Constructor
		public HXRelationRefShowViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private HXRelationRefShowViewView uiviewHXRelationRefShowView
		{
			get { return (HXRelationRefShowViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new HXRelationRefShowViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewHXRelationRefShowView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewHXRelationRefShowView.FieldID);
			}
			set{
				this[this.uiviewHXRelationRefShowView.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewHXRelationRefShowView.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewHXRelationRefShowView.FieldCreatedOn);
			}
			set{
				this[this.uiviewHXRelationRefShowView.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewHXRelationRefShowView.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHXRelationRefShowView.FieldCreatedBy);
			}
			set{
				this[this.uiviewHXRelationRefShowView.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewHXRelationRefShowView.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewHXRelationRefShowView.FieldModifiedOn);
			}
			set{
				this[this.uiviewHXRelationRefShowView.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewHXRelationRefShowView.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHXRelationRefShowView.FieldModifiedBy);
			}
			set{
				this[this.uiviewHXRelationRefShowView.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewHXRelationRefShowView.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewHXRelationRefShowView.FieldSysVersion);
			}
			set{
				this[this.uiviewHXRelationRefShowView.FieldSysVersion] = value;
			}
		}
		
		
		public  String RefCode
		{
			get{
				//object value = this[this.uiviewHXRelationRefShowView.FieldRefCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHXRelationRefShowView.FieldRefCode);
			}
			set{
				this[this.uiviewHXRelationRefShowView.FieldRefCode] = value;
			}
		}
		
		
		public  String RefName
		{
			get{
				//object value = this[this.uiviewHXRelationRefShowView.FieldRefName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHXRelationRefShowView.FieldRefName);
			}
			set{
				this[this.uiviewHXRelationRefShowView.FieldRefName] = value;
			}
		}
		
		
		public  Int64? RefID
		{
			get{
				//object value = this[this.uiviewHXRelationRefShowView.FieldRefID] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewHXRelationRefShowView.FieldRefID);
			}
			set{
				this[this.uiviewHXRelationRefShowView.FieldRefID] = value;
			}
		}
		
		
		public  String AccountProperty
		{
			get{
				//object value = this[this.uiviewHXRelationRefShowView.FieldAccountProperty] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHXRelationRefShowView.FieldAccountProperty);
			}
			set{
				this[this.uiviewHXRelationRefShowView.FieldAccountProperty] = value;
			}
		}
		
		
		public  String BalanceDirection
		{
			get{
				//object value = this[this.uiviewHXRelationRefShowView.FieldBalanceDirection] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHXRelationRefShowView.FieldBalanceDirection);
			}
			set{
				this[this.uiviewHXRelationRefShowView.FieldBalanceDirection] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class HXRelationRefShowViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public HXRelationRefShowViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private HXRelationRefShowViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new HXRelationRefShowViewDefaultFilterFilter();
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