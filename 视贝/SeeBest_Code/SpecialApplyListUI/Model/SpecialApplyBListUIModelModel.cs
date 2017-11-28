#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.SpecialApplyListUI.SpecialApplyBListUIModel
{
	[Serializable]
	public partial class SpecialApplyBListUIModelModel : UIModel
	{
		#region Constructor
		public SpecialApplyBListUIModelModel() : base("SpecialApplyBListUIModel")
		{
			InitClass();
			this.SetResourceInfo("cbda7724-1214-41c7-ae9a-519678742877");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private SpecialApplyBListUIModelModel(bool isInit) : base("SpecialApplyBListUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new SpecialApplyBListUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private SpecialApplyBEView viewSpecialApplyBE;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public SpecialApplyBEView SpecialApplyBE
		{
			get { return (SpecialApplyBEView)this["SpecialApplyBE"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewSpecialApplyBE = new SpecialApplyBEView(this);
			this.viewSpecialApplyBE.SetResourceInfo("f7a3789e-1cf5-4637-9092-effc0246e7c4");
			this.Views.Add(this.viewSpecialApplyBE);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.SpecialApplyListUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class SpecialApplyBEView : UIView
	{
		#region Constructor
		public SpecialApplyBEView(IUIModel model) : base(model,"SpecialApplyBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private SpecialApplyBEView():base(null,"SpecialApplyBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new SpecialApplyBEView();
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","f8a632a2-ffc1-47d9-9194-e8b36bc0e6b5");


		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new SpecialApplyBERecord(builder);
		}
		#endregion

		#region new method
		public new SpecialApplyBERecord FocusedRecord
		{
			get { return (SpecialApplyBERecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new SpecialApplyBERecord AddNewUIRecord()
		{	
			return (SpecialApplyBERecord)base.AddNewUIRecord();
		}
		public new SpecialApplyBERecord NewUIRecord()
		{	
			return (SpecialApplyBERecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class SpecialApplyBERecord : UIRecord
	{
		#region Constructor
		public SpecialApplyBERecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private SpecialApplyBEView uiviewSpecialApplyBE
		{
			get { return (SpecialApplyBEView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new SpecialApplyBERecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewSpecialApplyBE.FieldID);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldID] = value;
			}
		}
		#endregion
	}
	



}