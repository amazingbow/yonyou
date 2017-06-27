#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.FJGX.SupplierDQryUIModel
{
	[Serializable]
	public partial class SupplierDQryUIModelModel : UIModel
	{
		#region Constructor
		public SupplierDQryUIModelModel() : base("SupplierDQryUIModel")
		{
			InitClass();
			this.SetResourceInfo("941c294a-5486-42ee-8959-670439660c42");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private SupplierDQryUIModelModel(bool isInit) : base("SupplierDQryUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new SupplierDQryUIModelModel(false);
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
			this.viewQueryView.SetResourceInfo("f3e888ee-23dc-4350-ab7f-64c6c1b546d6");
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


		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","e0eb0a1e-3045-4e42-9b73-8939dc4011fd");


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
	



}