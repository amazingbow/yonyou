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
		public IUIField FieldCreatedOn
		{
			get { return this.Fields["CreatedOn"]; }
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
		public IUIField FieldRefStatus
		{
			get { return this.Fields["RefStatus"]; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","eda13f1f-690f-405d-8ea5-43acbcdabb0f");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","4fa4a25f-f9f7-4ac1-a30b-fadd03387143");
			UIModelRuntimeFactory.AddNewUIField(this,"RefType", typeof(Int32), true,"","UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum", "RefType", true,true, false, "",false,(UIFieldType)2,"55ff3b7f-5e3f-4ce9-ba25-42baf7bb7e0d","4f12f488-583a-44a3-816b-95cfddabfba3");
			UIModelRuntimeFactory.AddNewUIField(this,"SapCode", typeof(String), true,"","System.String", "SapCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","682bc6bb-aec3-4c5b-89fb-5c05b56c9204");
			UIModelRuntimeFactory.AddNewUIField(this,"SapName", typeof(String), true,"","System.String", "SapName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","46186b1e-0245-4f17-abc0-81499d52525d");
			UIModelRuntimeFactory.AddNewUIField(this,"SapCompCode", typeof(String), true,"","System.String", "SapCompCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","de48b916-2c0f-420f-aba5-65c521929ea3");
			UIModelRuntimeFactory.AddNewUIField(this,"SapCompName", typeof(String), true,"","System.String", "SapCompName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3e0c05e4-3d26-4568-916e-743b4dd57b2c");
			UIModelRuntimeFactory.AddNewUIField(this,"SapMasterCode", typeof(String), true,"","System.String", "SapMasterCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","af5a2caf-4a57-44dc-92fd-b174b0f893f4");
			UIModelRuntimeFactory.AddNewUIField(this,"SapMasterName", typeof(String), true,"","System.String", "SapMasterName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7282596a-266e-4b98-be1b-41e846d96dc7");
			UIModelRuntimeFactory.AddNewUIField(this,"SapAssetsCode", typeof(String), true,"","System.String", "SapAssetsCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5233a63f-d776-4f8a-8fba-9f40a98ad2a9");
			UIModelRuntimeFactory.AddNewUIField(this,"SapAssetsName", typeof(String), true,"","System.String", "SapAssetsName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","946c2772-b463-41b4-b233-be0cfb6ff7ea");
			UIModelRuntimeFactory.AddNewUIField(this,"SapFeeCode", typeof(String), true,"","System.String", "SapFeeCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b52a8d1d-d164-41dc-8284-0911159c6e29");
			UIModelRuntimeFactory.AddNewUIField(this,"SapFeeName", typeof(String), true,"","System.String", "SapFeeName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b944b6a6-7b07-450f-9b7f-545a42176b4a");
			UIModelRuntimeFactory.AddNewUIField(this,"U9Code", typeof(String), true,"","System.String", "U9Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","10d9196d-2d9d-4dc5-ac77-549d11c35e6b");
			UIModelRuntimeFactory.AddNewUIField(this,"U9Name", typeof(String), true,"","System.String", "U9Name", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c18d96d3-b490-4bf2-b0c1-c45d67ef9f1f");
			UIModelRuntimeFactory.AddNewUIField(this,"RefStatus", typeof(Int32), true,"","UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RefStatusEnum", "RefStatus", true,true, false, "",false,(UIFieldType)2,"69d1e287-de63-4ed1-a7f7-bffc57c93de9","994a7d4f-cc8b-44d6-9417-2759746fc3b2");


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
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewcRef.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewcRef.FieldCreatedOn);
			}
			set{
				this[this.uiviewcRef.FieldCreatedOn] = value;
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
		#endregion
	}
	
	[Serializable]
	public class cRefDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public cRefDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@" order by ID desc,RefType asc,SapCode asc")
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