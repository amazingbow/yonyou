#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeListUI.XMJLBomChangeBListUIModel
{
	[Serializable]
	public partial class XMJLBomChangeBListUIModelModel : UIModel
	{
		#region Constructor
		public XMJLBomChangeBListUIModelModel() : base("XMJLBomChangeBListUIModel")
		{
			InitClass();
			this.SetResourceInfo("b356ea41-b100-43e4-a819-20c66efc2391");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private XMJLBomChangeBListUIModelModel(bool isInit) : base("XMJLBomChangeBListUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new XMJLBomChangeBListUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private Cust_Xmjl_MO_BomChangeView viewCust_Xmjl_MO_BomChange;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public Cust_Xmjl_MO_BomChangeView Cust_Xmjl_MO_BomChange
		{
			get { return (Cust_Xmjl_MO_BomChangeView)this["Cust_Xmjl_MO_BomChange"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewCust_Xmjl_MO_BomChange = new Cust_Xmjl_MO_BomChangeView(this);
			this.viewCust_Xmjl_MO_BomChange.SetResourceInfo("aa6e8571-89f0-411a-bde1-4937c14cf642");
			this.Views.Add(this.viewCust_Xmjl_MO_BomChange);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.XMJL.XMJLBomChangeListUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class Cust_Xmjl_MO_BomChangeView : UIView
	{
		#region Constructor
		public Cust_Xmjl_MO_BomChangeView(IUIModel model) : base(model,"Cust_Xmjl_MO_BomChange","UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private Cust_Xmjl_MO_BomChangeView():base(null,"Cust_Xmjl_MO_BomChange","UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new Cust_Xmjl_MO_BomChangeView();
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","c3c89499-3d49-4f51-b951-8edf6a6d2ac6");


		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new Cust_Xmjl_MO_BomChangeRecord(builder);
		}
		#endregion

		#region new method
		public new Cust_Xmjl_MO_BomChangeRecord FocusedRecord
		{
			get { return (Cust_Xmjl_MO_BomChangeRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new Cust_Xmjl_MO_BomChangeRecord AddNewUIRecord()
		{	
			return (Cust_Xmjl_MO_BomChangeRecord)base.AddNewUIRecord();
		}
		public new Cust_Xmjl_MO_BomChangeRecord NewUIRecord()
		{	
			return (Cust_Xmjl_MO_BomChangeRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class Cust_Xmjl_MO_BomChangeRecord : UIRecord
	{
		#region Constructor
		public Cust_Xmjl_MO_BomChangeRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private Cust_Xmjl_MO_BomChangeView uiviewCust_Xmjl_MO_BomChange
		{
			get { return (Cust_Xmjl_MO_BomChangeView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new Cust_Xmjl_MO_BomChangeRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewCust_Xmjl_MO_BomChange.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewCust_Xmjl_MO_BomChange.FieldID);
			}
			set{
				this[this.uiviewCust_Xmjl_MO_BomChange.FieldID] = value;
			}
		}
		#endregion
	}
	



}