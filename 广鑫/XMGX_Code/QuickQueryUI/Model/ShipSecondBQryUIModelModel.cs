#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.FJGX.ShipSecondBQryUIModel
{
	[Serializable]
	public partial class ShipSecondBQryUIModelModel : UIModel
	{
		#region Constructor
		public ShipSecondBQryUIModelModel() : base("ShipSecondBQryUIModel")
		{
			InitClass();
			this.SetResourceInfo("50a7e2e3-55b3-4bf3-8337-d0a3e89781ea");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private ShipSecondBQryUIModelModel(bool isInit) : base("ShipSecondBQryUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new ShipSecondBQryUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private ShipLineView viewShipLine;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		private IUIModelProperty propertyNeedRefresh;			
		#endregion
		#endregion

		#region property
		public ShipLineView ShipLine
		{
			get { return (ShipLineView)this["ShipLine"]; }
		}
		
		#region RealViews
		#endregion
		
		public IUIModelProperty PropertyNeedRefresh
		{
			get { return this.Properties["NeedRefresh"]; }
		}
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewShipLine = new ShipLineView(this);
			this.viewShipLine.SetResourceInfo("a20f4c29-c31b-4fa8-a42d-213feda22259");
			this.Views.Add(this.viewShipLine);			

			
			this.propertyNeedRefresh = new UIModelProperty("NeedRefresh", typeof(Boolean), true,"","");
			this.propertyNeedRefresh.SetResourceInfo("fc7413f2-65b8-46b0-a13a-1f4a4ef0fa46");
			this.Properties.Add(this.propertyNeedRefresh);
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.FJGX.QuickQueryUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class ShipLineView : UIView
	{
		#region Constructor
		public ShipLineView(IUIModel model) : base(model,"ShipLine","UFIDA.U9.SM.Ship.ShipLine", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private ShipLineView():base(null,"ShipLine","UFIDA.U9.SM.Ship.ShipLine", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new ShipLineView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public ShipLineDefaultFilterFilter DefaultFilter
		{
			get { return (ShipLineDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"0","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","c9be00c7-320c-4f40-95f3-06d6c2bd9eaa");


			this.CurrentFilter = new ShipLineDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new ShipLineRecord(builder);
		}
		#endregion

		#region new method
		public new ShipLineRecord FocusedRecord
		{
			get { return (ShipLineRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new ShipLineRecord AddNewUIRecord()
		{	
			return (ShipLineRecord)base.AddNewUIRecord();
		}
		public new ShipLineRecord NewUIRecord()
		{	
			return (ShipLineRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class ShipLineRecord : UIRecord
	{
		#region Constructor
		public ShipLineRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private ShipLineView uiviewShipLine
		{
			get { return (ShipLineView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new ShipLineRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewShipLine.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewShipLine.FieldID);
			}
			set{
				this[this.uiviewShipLine.FieldID] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class ShipLineDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public ShipLineDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"UFIDA::U9::SM::Ship::ShipLine.Ship.OrderBy.Customer.ID=@CustomerID",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private ShipLineDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new ShipLineDefaultFilterFilter();
		}
		#endregion

		#region property
		private IUIParameter @CustomerID;
		#endregion
		
		#region function
		private void InitClass()
		{
			this.@CustomerID = new UIParameter("@CustomerID",System.Data.DbType.Int64);
			this.Parameters.Add(this.@CustomerID);
		}
		#endregion

	}



}