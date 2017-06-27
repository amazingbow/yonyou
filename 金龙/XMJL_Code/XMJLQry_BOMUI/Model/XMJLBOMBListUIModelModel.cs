#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.XMJL.Qry.XMJLBOMBListUIModel
{
	[Serializable]
	public partial class XMJLBOMBListUIModelModel : UIModel
	{
		#region Constructor
		public XMJLBOMBListUIModelModel() : base("XMJLBOMBListUIModel")
		{
			InitClass();
			this.SetResourceInfo("4b1854ef-3d73-49a1-b8dd-be1b1d8ed9b2");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private XMJLBOMBListUIModelModel(bool isInit) : base("XMJLBOMBListUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new XMJLBOMBListUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private Cust_Xmjl_MO_BomMainView viewCust_Xmjl_MO_BomMain;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public Cust_Xmjl_MO_BomMainView Cust_Xmjl_MO_BomMain
		{
			get { return (Cust_Xmjl_MO_BomMainView)this["Cust_Xmjl_MO_BomMain"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewCust_Xmjl_MO_BomMain = new Cust_Xmjl_MO_BomMainView(this);
			this.viewCust_Xmjl_MO_BomMain.SetResourceInfo("05998128-9ce4-4436-a8b4-e24a95d15cd9");
			this.Views.Add(this.viewCust_Xmjl_MO_BomMain);			

			
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
	public partial class Cust_Xmjl_MO_BomMainView : UIView
	{
		#region Constructor
		public Cust_Xmjl_MO_BomMainView(IUIModel model) : base(model,"Cust_Xmjl_MO_BomMain","UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomMain", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private Cust_Xmjl_MO_BomMainView():base(null,"Cust_Xmjl_MO_BomMain","UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomMain", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new Cust_Xmjl_MO_BomMainView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldWareHouse
		{
			get { return this.Fields["WareHouse"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public Cust_Xmjl_MO_BomMainDefaultFilterFilter DefaultFilter
		{
			get { return (Cust_Xmjl_MO_BomMainDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","f0e66423-61b2-48f9-b56d-8fc98dee5cbf");
			UIModelRuntimeFactory.AddNewUIField(this,"WareHouse", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0991b2dc-45f8-478b-9518-63df2191f8d8");


			this.CurrentFilter = new Cust_Xmjl_MO_BomMainDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new Cust_Xmjl_MO_BomMainRecord(builder);
		}
		#endregion

		#region new method
		public new Cust_Xmjl_MO_BomMainRecord FocusedRecord
		{
			get { return (Cust_Xmjl_MO_BomMainRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new Cust_Xmjl_MO_BomMainRecord AddNewUIRecord()
		{	
			return (Cust_Xmjl_MO_BomMainRecord)base.AddNewUIRecord();
		}
		public new Cust_Xmjl_MO_BomMainRecord NewUIRecord()
		{	
			return (Cust_Xmjl_MO_BomMainRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class Cust_Xmjl_MO_BomMainRecord : UIRecord
	{
		#region Constructor
		public Cust_Xmjl_MO_BomMainRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private Cust_Xmjl_MO_BomMainView uiviewCust_Xmjl_MO_BomMain
		{
			get { return (Cust_Xmjl_MO_BomMainView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new Cust_Xmjl_MO_BomMainRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCust_Xmjl_MO_BomMain.FieldID);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldID] = value;
			}
		}
		
		
		public  String WareHouse
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomMain.FieldWareHouse] ;
				//return (String)value;
				return GetValue<String>(this.uiviewCust_Xmjl_MO_BomMain.FieldWareHouse);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomMain.FieldWareHouse] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class Cust_Xmjl_MO_BomMainDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public Cust_Xmjl_MO_BomMainDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private Cust_Xmjl_MO_BomMainDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new Cust_Xmjl_MO_BomMainDefaultFilterFilter();
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