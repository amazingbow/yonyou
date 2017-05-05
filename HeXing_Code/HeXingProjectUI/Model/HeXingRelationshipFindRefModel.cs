#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace HeXingRelationshipFindRef
{
	[Serializable]
	public partial class HeXingRelationshipFindRefModel : UIModel
	{
		#region Constructor
		public HeXingRelationshipFindRefModel() : base("HeXingRelationshipFindRef")
		{
			InitClass();
			this.SetResourceInfo("1fcb4da9-d87f-43e8-baf3-ce8a6da7577f");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private HeXingRelationshipFindRefModel(bool isInit) : base("HeXingRelationshipFindRef")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new HeXingRelationshipFindRefModel(false);
		}
		#endregion
		#region member
		#region views
		private cRefView viewcRef;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public cRefView cRef
		{
			get { return (cRefView)this["cRef"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewcRef = new cRefView(this);
			this.viewcRef.SetResourceInfo("0653b835-369c-4446-b52d-67e48ddc7f59");
			this.Views.Add(this.viewcRef);			

			
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
	public partial class cRefView : UIView
	{
		#region Constructor
		public cRefView(IUIModel model) : base(model,"cRef","UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private cRefView():base(null,"cRef","UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new cRefView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
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
		public IUIField FieldSupplierCode
		{
			get { return this.Fields["SupplierCode"]; }
		}
		public IUIField FieldSupplierName
		{
			get { return this.Fields["SupplierName"]; }
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
		public IUIField FieldRefStatus
		{
			get { return this.Fields["RefStatus"]; }
		}
		public IUIField FieldMemo
		{
			get { return this.Fields["Memo"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public cRefDefaultFilterFilter DefaultFilter
		{
			get { return (cRefDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","75e48d90-aef3-49b2-bff0-2573deefcd4c");
			UIModelRuntimeFactory.AddNewUIField(this,"RefType", typeof(Int32), true,"","UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum", "RefType", true,true, false, "",false,(UIFieldType)2,"55ff3b7f-5e3f-4ce9-ba25-42baf7bb7e0d","518ace3d-1b79-4b34-b079-440d03bdd270");
			UIModelRuntimeFactory.AddNewUIField(this,"SapCode", typeof(String), true,"","System.String", "SapCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","89343fe6-bea5-463c-818d-4ca683353fca");
			UIModelRuntimeFactory.AddNewUIField(this,"SapName", typeof(String), true,"","System.String", "SapName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cbcfdf4c-8ef6-4a07-aca8-4bff5406b699");
			UIModelRuntimeFactory.AddNewUIField(this,"SapCompCode", typeof(String), true,"","System.String", "SapCompCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e10f2cb8-a404-4112-9e2e-882c9a0c9630");
			UIModelRuntimeFactory.AddNewUIField(this,"SapCompName", typeof(String), true,"","System.String", "SapCompName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0b041899-a394-4f7d-8caf-e1a128942281");
			UIModelRuntimeFactory.AddNewUIField(this,"SupplierCode", typeof(String), true,"","System.String", "SupplierCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d8f621dc-3faf-42ac-a44a-5859130bca57");
			UIModelRuntimeFactory.AddNewUIField(this,"SupplierName", typeof(String), true,"","System.String", "SupplierName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9af6985f-f74b-4a4a-a9a1-900f481ae543");
			UIModelRuntimeFactory.AddNewUIField(this,"SapMasterCode", typeof(String), true,"","System.String", "SapMasterCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","20786810-bdfb-4d4c-8405-58384b3f37b2");
			UIModelRuntimeFactory.AddNewUIField(this,"SapMasterName", typeof(String), true,"","System.String", "SapMasterName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","26aa2d14-dda8-4f70-811a-8adb1da54cd6");
			UIModelRuntimeFactory.AddNewUIField(this,"SapAssetsCode", typeof(String), true,"","System.String", "SapAssetsCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2fa225ee-2cae-4b87-9b86-0774bf376240");
			UIModelRuntimeFactory.AddNewUIField(this,"SapAssetsName", typeof(String), true,"","System.String", "SapAssetsName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","216dc6cf-fdff-4718-a3c3-17a05a2f3b91");
			UIModelRuntimeFactory.AddNewUIField(this,"SapFeeCode", typeof(String), true,"","System.String", "SapFeeCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f6622fe3-8422-4a1c-b3df-ef036ef6129a");
			UIModelRuntimeFactory.AddNewUIField(this,"SapFeeName", typeof(String), true,"","System.String", "SapFeeName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2d4c44a3-ab9f-4183-900e-2ff207cab02a");
			UIModelRuntimeFactory.AddNewUIField(this,"U9Code", typeof(String), true,"","System.String", "U9Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9c6c641a-7fe4-4034-8eaf-ce359397b236");
			UIModelRuntimeFactory.AddNewUIField(this,"U9Name", typeof(String), true,"","System.String", "U9Name", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8f8afd37-4082-4d4f-ac16-199af494fdb0");
			UIModelRuntimeFactory.AddNewUIField(this,"RefStatus", typeof(Int32), true,"","UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RefStatusEnum", "RefStatus", true,true, false, "",false,(UIFieldType)2,"69d1e287-de63-4ed1-a7f7-bffc57c93de9","be869a9e-36d6-457c-af7a-bf876a0614a2");
			UIModelRuntimeFactory.AddNewUIField(this,"Memo", typeof(String), true,"","System.String", "Memo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","da921d49-8010-40e8-bf19-7e06b68f4e94");


			this.CurrentFilter = new cRefDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new cRefRecord(builder);
		}
		#endregion

		#region new method
		public new cRefRecord FocusedRecord
		{
			get { return (cRefRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new cRefRecord AddNewUIRecord()
		{	
			return (cRefRecord)base.AddNewUIRecord();
		}
		public new cRefRecord NewUIRecord()
		{	
			return (cRefRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class cRefRecord : UIRecord
	{
		#region Constructor
		public cRefRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private cRefView uiviewcRef
		{
			get { return (cRefView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new cRefRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewcRef.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewcRef.FieldID);
			}
			set{
				this[this.uiviewcRef.FieldID] = value;
			}
		}
		
		
		public  Int32? RefType
		{
			get{
				//object value = this[this.uiviewcRef.FieldRefType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewcRef.FieldRefType);
			}
			set{
				this[this.uiviewcRef.FieldRefType] = value;
			}
		}
		
		
		public  String SapCode
		{
			get{
				//object value = this[this.uiviewcRef.FieldSapCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldSapCode);
			}
			set{
				this[this.uiviewcRef.FieldSapCode] = value;
			}
		}
		
		
		public  String SapName
		{
			get{
				//object value = this[this.uiviewcRef.FieldSapName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldSapName);
			}
			set{
				this[this.uiviewcRef.FieldSapName] = value;
			}
		}
		
		
		public  String SapCompCode
		{
			get{
				//object value = this[this.uiviewcRef.FieldSapCompCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldSapCompCode);
			}
			set{
				this[this.uiviewcRef.FieldSapCompCode] = value;
			}
		}
		
		
		public  String SapCompName
		{
			get{
				//object value = this[this.uiviewcRef.FieldSapCompName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldSapCompName);
			}
			set{
				this[this.uiviewcRef.FieldSapCompName] = value;
			}
		}
		
		
		public  String SupplierCode
		{
			get{
				//object value = this[this.uiviewcRef.FieldSupplierCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldSupplierCode);
			}
			set{
				this[this.uiviewcRef.FieldSupplierCode] = value;
			}
		}
		
		
		public  String SupplierName
		{
			get{
				//object value = this[this.uiviewcRef.FieldSupplierName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldSupplierName);
			}
			set{
				this[this.uiviewcRef.FieldSupplierName] = value;
			}
		}
		
		
		public  String SapMasterCode
		{
			get{
				//object value = this[this.uiviewcRef.FieldSapMasterCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldSapMasterCode);
			}
			set{
				this[this.uiviewcRef.FieldSapMasterCode] = value;
			}
		}
		
		
		public  String SapMasterName
		{
			get{
				//object value = this[this.uiviewcRef.FieldSapMasterName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldSapMasterName);
			}
			set{
				this[this.uiviewcRef.FieldSapMasterName] = value;
			}
		}
		
		
		public  String SapAssetsCode
		{
			get{
				//object value = this[this.uiviewcRef.FieldSapAssetsCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldSapAssetsCode);
			}
			set{
				this[this.uiviewcRef.FieldSapAssetsCode] = value;
			}
		}
		
		
		public  String SapAssetsName
		{
			get{
				//object value = this[this.uiviewcRef.FieldSapAssetsName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldSapAssetsName);
			}
			set{
				this[this.uiviewcRef.FieldSapAssetsName] = value;
			}
		}
		
		
		public  String SapFeeCode
		{
			get{
				//object value = this[this.uiviewcRef.FieldSapFeeCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldSapFeeCode);
			}
			set{
				this[this.uiviewcRef.FieldSapFeeCode] = value;
			}
		}
		
		
		public  String SapFeeName
		{
			get{
				//object value = this[this.uiviewcRef.FieldSapFeeName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldSapFeeName);
			}
			set{
				this[this.uiviewcRef.FieldSapFeeName] = value;
			}
		}
		
		
		public  String U9Code
		{
			get{
				//object value = this[this.uiviewcRef.FieldU9Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldU9Code);
			}
			set{
				this[this.uiviewcRef.FieldU9Code] = value;
			}
		}
		
		
		public  String U9Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldU9Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldU9Name);
			}
			set{
				this[this.uiviewcRef.FieldU9Name] = value;
			}
		}
		
		
		public  Int32? RefStatus
		{
			get{
				//object value = this[this.uiviewcRef.FieldRefStatus] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewcRef.FieldRefStatus);
			}
			set{
				this[this.uiviewcRef.FieldRefStatus] = value;
			}
		}
		
		
		public  String Memo
		{
			get{
				//object value = this[this.uiviewcRef.FieldMemo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldMemo);
			}
			set{
				this[this.uiviewcRef.FieldMemo] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class cRefDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public cRefDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private cRefDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new cRefDefaultFilterFilter();
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