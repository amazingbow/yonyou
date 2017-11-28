#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.AdvApproveBListUIModel
{
	[Serializable]
	public partial class AdvApproveBListUIModelModel : UIModel
	{
		#region Constructor
		public AdvApproveBListUIModelModel() : base("AdvApproveBListUIModel")
		{
			InitClass();
			this.SetResourceInfo("16a3bb2b-c3df-45b5-8780-0b79a8f87aee");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private AdvApproveBListUIModelModel(bool isInit) : base("AdvApproveBListUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new AdvApproveBListUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private AdvApproveBEView viewAdvApproveBE;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public AdvApproveBEView AdvApproveBE
		{
			get { return (AdvApproveBEView)this["AdvApproveBE"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewAdvApproveBE = new AdvApproveBEView(this);
			this.viewAdvApproveBE.SetResourceInfo("33f73e7a-31c1-4494-bdcd-97778f08efb9");
			this.Views.Add(this.viewAdvApproveBE);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.AdvApproveListUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class AdvApproveBEView : UIView
	{
		#region Constructor
		public AdvApproveBEView(IUIModel model) : base(model,"AdvApproveBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private AdvApproveBEView():base(null,"AdvApproveBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new AdvApproveBEView();
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","4bfd7d29-6099-4b4a-8f3a-84b023d9ae2f");


		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new AdvApproveBERecord(builder);
		}
		#endregion

		#region new method
		public new AdvApproveBERecord FocusedRecord
		{
			get { return (AdvApproveBERecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new AdvApproveBERecord AddNewUIRecord()
		{	
			return (AdvApproveBERecord)base.AddNewUIRecord();
		}
		public new AdvApproveBERecord NewUIRecord()
		{	
			return (AdvApproveBERecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class AdvApproveBERecord : UIRecord
	{
		#region Constructor
		public AdvApproveBERecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private AdvApproveBEView uiviewAdvApproveBE
		{
			get { return (AdvApproveBEView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new AdvApproveBERecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewAdvApproveBE.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAdvApproveBE.FieldID);
			}
			set{
				this[this.uiviewAdvApproveBE.FieldID] = value;
			}
		}
		#endregion
	}
	



}