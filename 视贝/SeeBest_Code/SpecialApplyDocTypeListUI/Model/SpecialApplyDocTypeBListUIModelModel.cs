#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.SpecialApplyDocTypeListUI.SpecialApplyDocTypeBListUIModel
{
	[Serializable]
	public partial class SpecialApplyDocTypeBListUIModelModel : UIModel
	{
		#region Constructor
		public SpecialApplyDocTypeBListUIModelModel() : base("SpecialApplyDocTypeBListUIModel")
		{
			InitClass();
			this.SetResourceInfo("da0c4f8d-c950-49e1-91c5-10e5cac555f6");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private SpecialApplyDocTypeBListUIModelModel(bool isInit) : base("SpecialApplyDocTypeBListUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new SpecialApplyDocTypeBListUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private SpecialApplyDocTypeView viewSpecialApplyDocType;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public SpecialApplyDocTypeView SpecialApplyDocType
		{
			get { return (SpecialApplyDocTypeView)this["SpecialApplyDocType"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewSpecialApplyDocType = new SpecialApplyDocTypeView(this);
			this.viewSpecialApplyDocType.SetResourceInfo("01ca5a5c-c2f6-4e56-93a6-2949bccf19b5");
			this.Views.Add(this.viewSpecialApplyDocType);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.SpecialApplyDocTypeListUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class SpecialApplyDocTypeView : UIView
	{
		#region Constructor
		public SpecialApplyDocTypeView(IUIModel model) : base(model,"SpecialApplyDocType","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private SpecialApplyDocTypeView():base(null,"SpecialApplyDocType","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new SpecialApplyDocTypeView();
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","0f0360a1-3632-4f60-909c-258919ec77e6");


		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new SpecialApplyDocTypeRecord(builder);
		}
		#endregion

		#region new method
		public new SpecialApplyDocTypeRecord FocusedRecord
		{
			get { return (SpecialApplyDocTypeRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new SpecialApplyDocTypeRecord AddNewUIRecord()
		{	
			return (SpecialApplyDocTypeRecord)base.AddNewUIRecord();
		}
		public new SpecialApplyDocTypeRecord NewUIRecord()
		{	
			return (SpecialApplyDocTypeRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class SpecialApplyDocTypeRecord : UIRecord
	{
		#region Constructor
		public SpecialApplyDocTypeRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private SpecialApplyDocTypeView uiviewSpecialApplyDocType
		{
			get { return (SpecialApplyDocTypeView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new SpecialApplyDocTypeRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewSpecialApplyDocType.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewSpecialApplyDocType.FieldID);
			}
			set{
				this[this.uiviewSpecialApplyDocType.FieldID] = value;
			}
		}
		#endregion
	}
	



}