#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UIFIA.U9.Cust.FJGX.RcvLineDQryUIModel
{
	[Serializable]
	public partial class RcvLineDQryUIModelModel : UIModel
	{
		#region Constructor
		public RcvLineDQryUIModelModel() : base("RcvLineDQryUIModel")
		{
			InitClass();
			this.SetResourceInfo("9f27a851-808b-4171-8ff9-bf20811ba9d1");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private RcvLineDQryUIModelModel(bool isInit) : base("RcvLineDQryUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new RcvLineDQryUIModelModel(false);
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
			this.viewQueryView.SetResourceInfo("07c10fe0-8bd9-43d8-8e3d-ebbcbf00e1ce");
			this.Views.Add(this.viewQueryView);			

			
		}

		public override string AssemblyName
		{
			get { return "UIFIA.U9.Cust.FJGX.RcvInfoQueryUI"; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","e488f608-9dcf-4d0e-b33d-0f9941614376");


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
			: base("DefaultFilter",view,@"Rcv.ID = @RcvID",@"")
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
		private IUIParameter @RcvID;
		#endregion
		
		#region function
		private void InitClass()
		{
			this.@RcvID = new UIParameter("@RcvID",System.Data.DbType.Int64);
			this.Parameters.Add(this.@RcvID);
		}
		#endregion

	}



}