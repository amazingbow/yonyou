#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.XMQX.LaserQryUI.LaserLabQryBListUIModel
{
	[Serializable]
	public partial class LaserLabQryBListUIModelModel : UIModel
	{
		#region Constructor
		public LaserLabQryBListUIModelModel() : base("LaserLabQryBListUIModel")
		{
			InitClass();
			this.SetResourceInfo("a29fe7a4-dc72-4d1c-a749-09c77c7937a7");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private LaserLabQryBListUIModelModel(bool isInit) : base("LaserLabQryBListUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new LaserLabQryBListUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private LaserLabView viewLaserLab;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public LaserLabView LaserLab
		{
			get { return (LaserLabView)this["LaserLab"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewLaserLab = new LaserLabView(this);
			this.viewLaserLab.SetResourceInfo("6aa7027c-d22a-462d-b584-7bf2c40c10d1");
			this.Views.Add(this.viewLaserLab);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.XMQX.LaserQryUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class LaserLabView : UIView
	{
		#region Constructor
		public LaserLabView(IUIModel model) : base(model,"LaserLab","UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private LaserLabView():base(null,"LaserLab","UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new LaserLabView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public LaserLabDefaultFilterFilter DefaultFilter
		{
			get { return (LaserLabDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","4561dac8-40a5-4576-9217-1bef1f7cb0b4");


			this.CurrentFilter = new LaserLabDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new LaserLabRecord(builder);
		}
		#endregion

		#region new method
		public new LaserLabRecord FocusedRecord
		{
			get { return (LaserLabRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new LaserLabRecord AddNewUIRecord()
		{	
			return (LaserLabRecord)base.AddNewUIRecord();
		}
		public new LaserLabRecord NewUIRecord()
		{	
			return (LaserLabRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class LaserLabRecord : UIRecord
	{
		#region Constructor
		public LaserLabRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private LaserLabView uiviewLaserLab
		{
			get { return (LaserLabView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new LaserLabRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewLaserLab.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewLaserLab.FieldID);
			}
			set{
				this[this.uiviewLaserLab.FieldID] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class LaserLabDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public LaserLabDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private LaserLabDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new LaserLabDefaultFilterFilter();
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