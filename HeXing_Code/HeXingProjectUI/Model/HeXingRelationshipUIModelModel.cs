#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.HeXingProjectUI.HeXingRelationshipUIModel
{
	[Serializable]
	public partial class HeXingRelationshipUIModelModel : UIModel
	{
		#region Constructor
		public HeXingRelationshipUIModelModel() : base("HeXingRelationshipUIModel")
		{
			InitClass();
			this.SetResourceInfo("cbf51f9e-46be-4aee-8739-b45f85256aaf");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private HeXingRelationshipUIModelModel(bool isInit) : base("HeXingRelationshipUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new HeXingRelationshipUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private HxRelationshipBEView viewHxRelationshipBE;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public HxRelationshipBEView HxRelationshipBE
		{
			get { return (HxRelationshipBEView)this["HxRelationshipBE"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewHxRelationshipBE = new HxRelationshipBEView(this);
			this.viewHxRelationshipBE.SetResourceInfo("fa59da79-ba68-49ef-8e9b-249374cd7f98");
			this.Views.Add(this.viewHxRelationshipBE);			

			
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
	public partial class HxRelationshipBEView : UIView
	{
		#region Constructor
		public HxRelationshipBEView(IUIModel model) : base(model,"HxRelationshipBE","UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private HxRelationshipBEView():base(null,"HxRelationshipBE","UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new HxRelationshipBEView();
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
		public IUIField FieldRefType
		{
			get { return this.Fields["RefType"]; }
		}
		public IUIField FieldSapCode
		{
			get { return this.Fields["SapCode"]; }
		}
		public IUIField FieldSapName
		{
			get { return this.Fields["SapName"]; }
		}
		public IUIField FieldSapCompCode
		{
			get { return this.Fields["SapCompCode"]; }
		}
		public IUIField FieldSapCompName
		{
			get { return this.Fields["SapCompName"]; }
		}
		public IUIField FieldSapMasterCode
		{
			get { return this.Fields["SapMasterCode"]; }
		}
		public IUIField FieldSapMasterName
		{
			get { return this.Fields["SapMasterName"]; }
		}
		public IUIField FieldSapAssetsCode
		{
			get { return this.Fields["SapAssetsCode"]; }
		}
		public IUIField FieldSapAssetsName
		{
			get { return this.Fields["SapAssetsName"]; }
		}
		public IUIField FieldSapFeeCode
		{
			get { return this.Fields["SapFeeCode"]; }
		}
		public IUIField FieldSapFeeName
		{
			get { return this.Fields["SapFeeName"]; }
		}
		public IUIField FieldU9Code
		{
			get { return this.Fields["U9Code"]; }
		}
		public IUIField FieldU9Name
		{
			get { return this.Fields["U9Name"]; }
		}
		public IUIField FieldU9EntityId
		{
			get { return this.Fields["U9EntityId"]; }
		}
		public IUIField FieldU9EntityId_Code
		{
			get { return this.Fields["U9EntityId_Code"]; }
		}
		public IUIField FieldU9EntityId_Name
		{
			get { return this.Fields["U9EntityId_Name"]; }
		}
		public IUIField FieldMemo
		{
			get { return this.Fields["Memo"]; }
		}
		public IUIField FieldRefStatus
		{
			get { return this.Fields["RefStatus"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public HxRelationshipBEDefaultFilterFilter DefaultFilter
		{
			get { return (HxRelationshipBEDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","ecaf13aa-2c77-4b87-9024-7704e1f5a4d8");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","4ee8c152-70a7-4bd2-9598-cd189c218f11");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a1330393-37ce-42dc-b8f0-889c17616b75");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","4e26b732-d656-4f68-a4d3-2ac9cb2fc049");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","12ac9c8e-fb11-4b5b-84ad-3c41199163d8");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","f1829c97-c313-4e62-89be-5dd7d786c95f");
			UIModelRuntimeFactory.AddNewUIField(this,"RefType", typeof(Int32), true,"0","UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum", "RefType", true,true, false, "",false,(UIFieldType)2,"55ff3b7f-5e3f-4ce9-ba25-42baf7bb7e0d","bb87125b-7d19-479a-8563-e7b7fbee89c1");
			UIModelRuntimeFactory.AddNewUIField(this,"SapCode", typeof(String), true,"","System.String", "SapCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","137176ee-9aa4-4f3d-ba3b-8b95de86a4e4");
			UIModelRuntimeFactory.AddNewUIField(this,"SapName", typeof(String), true,"","System.String", "SapName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8a2be990-b525-4a19-bcab-9a642baa2cf0");
			UIModelRuntimeFactory.AddNewUIField(this,"SapCompCode", typeof(String), true,"","System.String", "SapCompCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7299f575-d3a4-48c3-94cb-97fb30c995fe");
			UIModelRuntimeFactory.AddNewUIField(this,"SapCompName", typeof(String), true,"","System.String", "SapCompName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a327770a-b819-4d9c-9749-753db06f40bd");
			UIModelRuntimeFactory.AddNewUIField(this,"SapMasterCode", typeof(String), true,"","System.String", "SapMasterCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d6162569-7196-4605-9c02-099ed5dbd1c3");
			UIModelRuntimeFactory.AddNewUIField(this,"SapMasterName", typeof(String), true,"","System.String", "SapMasterName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c361151e-0c86-4cd1-8792-1c8e23fe11ac");
			UIModelRuntimeFactory.AddNewUIField(this,"SapAssetsCode", typeof(String), true,"","System.String", "SapAssetsCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9d492307-7203-4d53-a680-f033380c7dcb");
			UIModelRuntimeFactory.AddNewUIField(this,"SapAssetsName", typeof(String), true,"","System.String", "SapAssetsName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2da922e8-ccd2-4f77-b723-cb64c2343e84");
			UIModelRuntimeFactory.AddNewUIField(this,"SapFeeCode", typeof(String), true,"","System.String", "SapFeeCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","caced0ab-b24a-45fd-983e-15f67f841ef1");
			UIModelRuntimeFactory.AddNewUIField(this,"SapFeeName", typeof(String), true,"","System.String", "SapFeeName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6972045c-86a3-48f0-a9d5-4d19560b4c44");
			UIModelRuntimeFactory.AddNewUIField(this,"U9Code", typeof(String), true,"","System.String", "U9Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cb604ff2-c28f-4f2d-86ef-6ac9b7bdae25");
			UIModelRuntimeFactory.AddNewUIField(this,"U9Name", typeof(String), true,"","System.String", "U9Name", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b2aa358f-0865-4abe-be43-5340ccc67be1");
			UIModelRuntimeFactory.AddNewUIField(this,"U9EntityId", typeof(Int64), true,"0","UFIDA.U9.Base.Currency.Currency", "U9EntityId", true,true, false, "",false,(UIFieldType)4,"73536b96-4dce-4512-b5ef-97e90dc01cbb","174540d5-3df7-4d36-8a83-04c33fbecddb");
			UIModelRuntimeFactory.AddNewUIField(this,"U9EntityId_Code", typeof(String), false,"","System.String", "U9EntityId.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","121b8572-6764-4b49-99c3-d24aa59d06bb");
			UIModelRuntimeFactory.AddNewUIField(this,"U9EntityId_Name", typeof(String), true,"","System.String", "U9EntityId.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d8802bd2-9380-4bc5-b73d-10733e20182b");
			UIModelRuntimeFactory.AddNewUIField(this,"Memo", typeof(String), true,"","System.String", "Memo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3a709931-9052-459b-b87e-b3c6eaa692ef");
			UIModelRuntimeFactory.AddNewUIField(this,"RefStatus", typeof(Int32), true,"0","UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RefStatusEnum", "RefStatus", true,true, false, "",false,(UIFieldType)2,"69d1e287-de63-4ed1-a7f7-bffc57c93de9","7d50d23e-ee31-4bc6-9438-5e5391f65b5f");


			this.CurrentFilter = new HxRelationshipBEDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new HxRelationshipBERecord(builder);
		}
		#endregion

		#region new method
		public new HxRelationshipBERecord FocusedRecord
		{
			get { return (HxRelationshipBERecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new HxRelationshipBERecord AddNewUIRecord()
		{	
			return (HxRelationshipBERecord)base.AddNewUIRecord();
		}
		public new HxRelationshipBERecord NewUIRecord()
		{	
			return (HxRelationshipBERecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class HxRelationshipBERecord : UIRecord
	{
		#region Constructor
		public HxRelationshipBERecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private HxRelationshipBEView uiviewHxRelationshipBE
		{
			get { return (HxRelationshipBEView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new HxRelationshipBERecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewHxRelationshipBE.FieldID);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewHxRelationshipBE.FieldCreatedOn);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHxRelationshipBE.FieldCreatedBy);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewHxRelationshipBE.FieldModifiedOn);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHxRelationshipBE.FieldModifiedBy);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewHxRelationshipBE.FieldSysVersion);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldSysVersion] = value;
			}
		}
		
		
		public  Int32? RefType
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldRefType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewHxRelationshipBE.FieldRefType);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldRefType] = value;
			}
		}
		
		
		public  String SapCode
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldSapCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHxRelationshipBE.FieldSapCode);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldSapCode] = value;
			}
		}
		
		
		public  String SapName
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldSapName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHxRelationshipBE.FieldSapName);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldSapName] = value;
			}
		}
		
		
		public  String SapCompCode
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldSapCompCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHxRelationshipBE.FieldSapCompCode);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldSapCompCode] = value;
			}
		}
		
		
		public  String SapCompName
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldSapCompName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHxRelationshipBE.FieldSapCompName);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldSapCompName] = value;
			}
		}
		
		
		public  String SapMasterCode
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldSapMasterCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHxRelationshipBE.FieldSapMasterCode);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldSapMasterCode] = value;
			}
		}
		
		
		public  String SapMasterName
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldSapMasterName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHxRelationshipBE.FieldSapMasterName);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldSapMasterName] = value;
			}
		}
		
		
		public  String SapAssetsCode
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldSapAssetsCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHxRelationshipBE.FieldSapAssetsCode);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldSapAssetsCode] = value;
			}
		}
		
		
		public  String SapAssetsName
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldSapAssetsName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHxRelationshipBE.FieldSapAssetsName);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldSapAssetsName] = value;
			}
		}
		
		
		public  String SapFeeCode
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldSapFeeCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHxRelationshipBE.FieldSapFeeCode);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldSapFeeCode] = value;
			}
		}
		
		
		public  String SapFeeName
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldSapFeeName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHxRelationshipBE.FieldSapFeeName);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldSapFeeName] = value;
			}
		}
		
		
		public  String U9Code
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldU9Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHxRelationshipBE.FieldU9Code);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldU9Code] = value;
			}
		}
		
		
		public  String U9Name
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldU9Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHxRelationshipBE.FieldU9Name);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldU9Name] = value;
			}
		}
		
		
		public  Int64? U9EntityId
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldU9EntityId] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewHxRelationshipBE.FieldU9EntityId);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldU9EntityId] = value;
			}
		}
		
		
		public  String U9EntityId_Code
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldU9EntityId_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHxRelationshipBE.FieldU9EntityId_Code);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldU9EntityId_Code] = value;
			}
		}
		
		
		public  String U9EntityId_Name
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldU9EntityId_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHxRelationshipBE.FieldU9EntityId_Name);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldU9EntityId_Name] = value;
			}
		}
		
		
		public  String Memo
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldMemo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewHxRelationshipBE.FieldMemo);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldMemo] = value;
			}
		}
		
		
		public  Int32? RefStatus
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldRefStatus] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewHxRelationshipBE.FieldRefStatus);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldRefStatus] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class HxRelationshipBEDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public HxRelationshipBEDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private HxRelationshipBEDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new HxRelationshipBEDefaultFilterFilter();
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