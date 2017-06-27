#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.FJGX.SupplierDocListDQryUIModel
{
	[Serializable]
	public partial class SupplierDocListDQryUIModelModel : UIModel
	{
		#region Constructor
		public SupplierDocListDQryUIModelModel() : base("SupplierDocListDQryUIModel")
		{
			InitClass();
			this.SetResourceInfo("b82b47d3-0b86-4910-9728-26a0de1950a1");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private SupplierDocListDQryUIModelModel(bool isInit) : base("SupplierDocListDQryUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new SupplierDocListDQryUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private QueryViewView viewQueryView;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public QueryViewView QueryView
		{
			get { return (QueryViewView)this["QueryView"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewQueryView = new QueryViewView(this);
			this.viewQueryView.SetResourceInfo("5133e404-a716-4af1-8c6f-db04767b2190");
			this.Views.Add(this.viewQueryView);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.FJGX.SupplierQueryUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class QueryViewView : UIView
	{
		#region Constructor
		public QueryViewView(IUIModel model) : base(model,"QueryView","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private QueryViewView():base(null,"QueryView","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new QueryViewView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public QueryViewDefaultFilterFilter DefaultFilter
		{
			get { return (QueryViewDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","571db529-fce2-4fe3-8ba8-59933968905a");


			this.CurrentFilter = new QueryViewDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new QueryViewRecord(builder);
		}
		#endregion

		#region new method
		public new QueryViewRecord FocusedRecord
		{
			get { return (QueryViewRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new QueryViewRecord AddNewUIRecord()
		{	
			return (QueryViewRecord)base.AddNewUIRecord();
		}
		public new QueryViewRecord NewUIRecord()
		{	
			return (QueryViewRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class QueryViewRecord : UIRecord
	{
		#region Constructor
		public QueryViewRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private QueryViewView uiviewQueryView
		{
			get { return (QueryViewView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new QueryViewRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewQueryView.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewQueryView.FieldID);
			}
			set{
				this[this.uiviewQueryView.FieldID] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class QueryViewDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public QueryViewDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"Supplier.Code in ( select A.Code from  UFIDA::U9::CBO::SCM::Supplier::Supplier A where A.ID = @SupplierID)",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private QueryViewDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new QueryViewDefaultFilterFilter();
		}
		#endregion

		#region property
		private IUIParameter @SupplierID;
		#endregion
		
		#region function
		private void InitClass()
		{
			this.@SupplierID = new UIParameter("@SupplierID",System.Data.DbType.Int64);
			this.Parameters.Add(this.@SupplierID);
		}
		#endregion

	}



}