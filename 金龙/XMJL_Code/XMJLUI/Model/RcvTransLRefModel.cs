#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace RcvTransLRef
{
	[Serializable]
	public partial class RcvTransLRefModel : UIModel
	{
		#region Constructor
		public RcvTransLRefModel() : base("RcvTransLRef")
		{
			InitClass();
			this.SetResourceInfo("ee4c9f0e-064a-492e-ac15-ec1e7e0ac87e");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private RcvTransLRefModel(bool isInit) : base("RcvTransLRef")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new RcvTransLRefModel(false);
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
			this.viewcRef.SetResourceInfo("2e8339ab-45c1-4853-947c-4a92f995b68d");
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
		public cRefView(IUIModel model) : base(model,"cRef","UFIDA.U9.InvDoc.MiscRcv.MiscRcvTransL", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private cRefView():base(null,"cRef","UFIDA.U9.InvDoc.MiscRcv.MiscRcvTransL", true)
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
		public IUIField FieldItemInfo_ItemCode
		{
			get { return this.Fields["ItemInfo_ItemCode"]; }
		}
		public IUIField FieldItemInfo_ItemName
		{
			get { return this.Fields["ItemInfo_ItemName"]; }
		}
		public IUIField FieldMiscRcvTrans_DocNo
		{
			get { return this.Fields["MiscRcvTrans_DocNo"]; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","506875e6-b38e-4c1a-879a-c40f6bb0a29c");
			UIModelRuntimeFactory.AddNewUIField(this,"DocLineNo", typeof(Int32), false,"","System.Int32", "DocLineNo", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","e69d826a-75d9-436b-822a-14540b057842");
			UIModelRuntimeFactory.AddNewUIField(this,"ItemInfo_ItemCode", typeof(String), true,"","System.String", "ItemInfo.ItemCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3766d274-8608-4730-b182-4a3e4e120264");
			UIModelRuntimeFactory.AddNewUIField(this,"ItemInfo_ItemName", typeof(String), true,"","System.String", "ItemInfo.ItemName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c13987cb-3f3e-4b91-90da-0db460c63052");
			UIModelRuntimeFactory.AddNewUIField(this,"MiscRcvTrans_DocNo", typeof(String), false,"","System.String", "MiscRcvTrans.DocNo", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","195fb109-6bd5-4207-badf-044abda613e2");


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
		
		
		public  String MiscRcvTrans_DocNo
		{
			get{
				//object value = this[this.uiviewcRef.FieldMiscRcvTrans_DocNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldMiscRcvTrans_DocNo);
			}
			set{
				this[this.uiviewcRef.FieldMiscRcvTrans_DocNo] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class cRefDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public cRefDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"Org.ID=#Context.OrgID#",@" order by MiscRcvTrans.DocNo asc")
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