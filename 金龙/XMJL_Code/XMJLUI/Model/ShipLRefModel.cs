#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace ShipLRef
{
	[Serializable]
	public partial class ShipLRefModel : UIModel
	{
		#region Constructor
		public ShipLRefModel() : base("ShipLRef")
		{
			InitClass();
			this.SetResourceInfo("88e9cadc-b354-4a43-8f8d-c0aa76f81c95");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private ShipLRefModel(bool isInit) : base("ShipLRef")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new ShipLRefModel(false);
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
			this.viewcRef.SetResourceInfo("792bf4ab-b61e-49c9-b5bf-a01c2eb61128");
			this.Views.Add(this.viewcRef);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.XMJL.UI"; }
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
		public cRefView(IUIModel model) : base(model,"cRef","UFIDA.U9.InvDoc.MiscShip.MiscShipmentL", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private cRefView():base(null,"cRef","UFIDA.U9.InvDoc.MiscShip.MiscShipmentL", true)
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
		public IUIField FieldDocLineNo
		{
			get { return this.Fields["DocLineNo"]; }
		}
		public IUIField FieldItemInfo_ItemName
		{
			get { return this.Fields["ItemInfo_ItemName"]; }
		}
		public IUIField FieldItemInfo_ItemCode
		{
			get { return this.Fields["ItemInfo_ItemCode"]; }
		}
		public IUIField FieldMiscShip_DocNo
		{
			get { return this.Fields["MiscShip_DocNo"]; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","1d598e14-df4f-47d4-bbd9-b0db2789c7a0");
			UIModelRuntimeFactory.AddNewUIField(this,"DocLineNo", typeof(Int32), false,"","System.Int32", "DocLineNo", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","608f9799-2964-47bc-be21-29135bee19b7");
			UIModelRuntimeFactory.AddNewUIField(this,"ItemInfo_ItemName", typeof(String), true,"","System.String", "ItemInfo.ItemName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ccb5d8db-0a09-47d3-b8f1-ea2eabef939c");
			UIModelRuntimeFactory.AddNewUIField(this,"ItemInfo_ItemCode", typeof(String), true,"","System.String", "ItemInfo.ItemCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9513b9f7-9df4-4e5f-849b-b566c80f2037");
			UIModelRuntimeFactory.AddNewUIField(this,"MiscShip_DocNo", typeof(String), false,"","System.String", "MiscShip.DocNo", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5a52e222-fc24-4281-bca1-424a37f5b18f");


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
		
		
		public  Int32 DocLineNo
		{
			get{
				//object value = this[this.uiviewcRef.FieldDocLineNo] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewcRef.FieldDocLineNo);
			}
			set{
				this[this.uiviewcRef.FieldDocLineNo] = value;
			}
		}
		
		
		public  String ItemInfo_ItemName
		{
			get{
				//object value = this[this.uiviewcRef.FieldItemInfo_ItemName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldItemInfo_ItemName);
			}
			set{
				this[this.uiviewcRef.FieldItemInfo_ItemName] = value;
			}
		}
		
		
		public  String ItemInfo_ItemCode
		{
			get{
				//object value = this[this.uiviewcRef.FieldItemInfo_ItemCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldItemInfo_ItemCode);
			}
			set{
				this[this.uiviewcRef.FieldItemInfo_ItemCode] = value;
			}
		}
		
		
		public  String MiscShip_DocNo
		{
			get{
				//object value = this[this.uiviewcRef.FieldMiscShip_DocNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldMiscShip_DocNo);
			}
			set{
				this[this.uiviewcRef.FieldMiscShip_DocNo] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class cRefDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public cRefDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"Org.ID=#Context.OrgID#",@" order by MiscShip.DocNo asc")
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