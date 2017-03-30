#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.HeXingRelationshipListUI.HxRelationshipBListUIModel
{
	[Serializable]
	public partial class HxRelationshipBListUIModelModel : UIModel
	{
		#region Constructor
		public HxRelationshipBListUIModelModel() : base("HxRelationshipBListUIModel")
		{
			InitClass();
			this.SetResourceInfo("0fed66f6-adcf-4b10-a402-7607c08e1c3d");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private HxRelationshipBListUIModelModel(bool isInit) : base("HxRelationshipBListUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new HxRelationshipBListUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private HxRelationshipBEView viewHxRelationshipBE;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public HxRelationshipBEView HxRelationshipBE
		{
			get { return (HxRelationshipBEView)this["HxRelationshipBE"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewHxRelationshipBE = new HxRelationshipBEView(this);
			this.viewHxRelationshipBE.SetResourceInfo("ed16f31a-5507-4aad-a141-29135828c126");
			this.Views.Add(this.viewHxRelationshipBE);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.HeXingRelationshipListUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class HxRelationshipBEView : UIView
	{
		#region Constructor
		public HxRelationshipBEView(IUIModel model) : base(model,"HxRelationshipBE","UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private HxRelationshipBEView():base(null,"HxRelationshipBE","UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.HxRelationshipBE", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new HxRelationshipBEView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public HxRelationshipBEDefaultFilterFilter DefaultFilter
		{
			get { return (HxRelationshipBEDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","56b86d8b-b4f9-482d-a4f5-73754e3a532f");


			this.CurrentFilter = new HxRelationshipBEDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new HxRelationshipBERecord(builder);
		}
		#endregion

		#region new method
		public new HxRelationshipBERecord FocusedRecord
		{
			get { return (HxRelationshipBERecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new HxRelationshipBERecord AddNewUIRecord()
		{	
			return (HxRelationshipBERecord)base.AddNewUIRecord();
		}
		public new HxRelationshipBERecord NewUIRecord()
		{	
			return (HxRelationshipBERecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class HxRelationshipBERecord : UIRecord
	{
		#region Constructor
		public HxRelationshipBERecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private HxRelationshipBEView uiviewHxRelationshipBE
		{
			get { return (HxRelationshipBEView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new HxRelationshipBERecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewHxRelationshipBE.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewHxRelationshipBE.FieldID);
			}
			set{
				this[this.uiviewHxRelationshipBE.FieldID] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class HxRelationshipBEDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public HxRelationshipBEDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private HxRelationshipBEDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new HxRelationshipBEDefaultFilterFilter();
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