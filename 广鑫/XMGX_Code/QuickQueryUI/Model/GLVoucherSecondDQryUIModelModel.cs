#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.FJGX.GLVoucherSecondDQryUIModel
{
	[Serializable]
	public partial class GLVoucherSecondDQryUIModelModel : UIModel
	{
		#region Constructor
		public GLVoucherSecondDQryUIModelModel() : base("GLVoucherSecondDQryUIModel")
		{
			InitClass();
			this.SetResourceInfo("643a0527-ffa8-4185-871b-94f87d629bc5");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private GLVoucherSecondDQryUIModelModel(bool isInit) : base("GLVoucherSecondDQryUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new GLVoucherSecondDQryUIModelModel(false);
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
			this.viewQueryView.SetResourceInfo("177f8ed6-3d2f-45f7-8f3c-8c244d69d2f7");
			this.Views.Add(this.viewQueryView);			

			
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","0e986f15-2934-4ff0-bd53-835280f06fe4");


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