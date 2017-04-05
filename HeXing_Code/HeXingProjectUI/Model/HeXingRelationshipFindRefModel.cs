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
		public IUIField FieldCustomerCode
		{
			get { return this.Fields["CustomerCode"]; }
		}
		public IUIField FieldCustomerName
		{
			get { return this.Fields["CustomerName"]; }
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
		public IUIField FieldMemo
		{
			get { return this.Fields["Memo"]; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","2abff610-d21c-409e-8ce9-44bae92b88a2");
			UIModelRuntimeFactory.AddNewUIField(this,"RefType", typeof(Int32), true,"","UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum", "RefType", true,true, false, "",false,(UIFieldType)2,"55ff3b7f-5e3f-4ce9-ba25-42baf7bb7e0d","56abb7ba-b8ba-48b2-b202-cc1e99650eef");
			UIModelRuntimeFactory.AddNewUIField(this,"SapCode", typeof(String), true,"","System.String", "SapCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c504b793-da72-4c3f-b96a-a6a2bc2fff5f");
			UIModelRuntimeFactory.AddNewUIField(this,"SapName", typeof(String), true,"","System.String", "SapName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6ae0cebd-c03e-4100-9f50-ce9e2e092531");
			UIModelRuntimeFactory.AddNewUIField(this,"SapCompCode", typeof(String), true,"","System.String", "SapCompCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","44c5b583-e5d8-479a-b0e6-ac489a63a8e8");
			UIModelRuntimeFactory.AddNewUIField(this,"SapCompName", typeof(String), true,"","System.String", "SapCompName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","21dcfee6-6e77-499a-a4b6-d37d209dd789");
			UIModelRuntimeFactory.AddNewUIField(this,"CustomerCode", typeof(String), true,"","System.String", "CustomerCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","576feac1-2d7f-4d3d-a5ba-8fe4f5bf7d3e");
			UIModelRuntimeFactory.AddNewUIField(this,"CustomerName", typeof(String), true,"","System.String", "CustomerName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2ac59e74-676a-4bc9-b711-afce8fddd57d");
			UIModelRuntimeFactory.AddNewUIField(this,"SapMasterCode", typeof(String), true,"","System.String", "SapMasterCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a3989eb4-be96-4afb-8683-f2cf8229e6c1");
			UIModelRuntimeFactory.AddNewUIField(this,"SapMasterName", typeof(String), true,"","System.String", "SapMasterName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6dd9286f-3ff7-4faf-a438-a2e46da9d13b");
			UIModelRuntimeFactory.AddNewUIField(this,"SapAssetsCode", typeof(String), true,"","System.String", "SapAssetsCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7dedb7c3-796d-4a2d-a9bc-5a26cb4c5e6a");
			UIModelRuntimeFactory.AddNewUIField(this,"SapAssetsName", typeof(String), true,"","System.String", "SapAssetsName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ee7e92d9-07cd-4ef4-83b5-6388ed3902c3");
			UIModelRuntimeFactory.AddNewUIField(this,"SapFeeCode", typeof(String), true,"","System.String", "SapFeeCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","94542de0-291a-44d9-89f1-364987103093");
			UIModelRuntimeFactory.AddNewUIField(this,"SapFeeName", typeof(String), true,"","System.String", "SapFeeName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c1f50ca6-ec18-4e74-bf3f-1727b9eb4763");
			UIModelRuntimeFactory.AddNewUIField(this,"U9Code", typeof(String), true,"","System.String", "U9Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c0642ed4-3884-485a-9c98-0ca8da8d3553");
			UIModelRuntimeFactory.AddNewUIField(this,"U9Name", typeof(String), true,"","System.String", "U9Name", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d160a23c-c265-4a0b-8b44-dfd05c5fca08");
			UIModelRuntimeFactory.AddNewUIField(this,"Memo", typeof(String), true,"","System.String", "Memo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","47bce74f-a7fe-497f-a381-df2a88d69876");
			UIModelRuntimeFactory.AddNewUIField(this,"RefStatus", typeof(Int32), true,"","UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RefStatusEnum", "RefStatus", true,true, false, "",false,(UIFieldType)2,"69d1e287-de63-4ed1-a7f7-bffc57c93de9","02840168-4759-4c5c-b24a-a1e1844f47eb");


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
		
		
		public  String CustomerCode
		{
			get{
				//object value = this[this.uiviewcRef.FieldCustomerCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldCustomerCode);
			}
			set{
				this[this.uiviewcRef.FieldCustomerCode] = value;
			}
		}
		
		
		public  String CustomerName
		{
			get{
				//object value = this[this.uiviewcRef.FieldCustomerName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldCustomerName);
			}
			set{
				this[this.uiviewcRef.FieldCustomerName] = value;
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
			: base("DefaultFilter",view,@"",@" order by ID asc,RefType asc,SapCode asc")
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