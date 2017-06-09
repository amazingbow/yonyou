#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace AdvApplyUIRef
{
	[Serializable]
	public partial class AdvApplyUIRefModel : UIModel
	{
		#region Constructor
		public AdvApplyUIRefModel() : base("AdvApplyUIRef")
		{
			InitClass();
			this.SetResourceInfo("b8bfae89-9037-45da-b7a9-3de49c5fe31d");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private AdvApplyUIRefModel(bool isInit) : base("AdvApplyUIRef")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new AdvApplyUIRefModel(false);
		}
		#endregion
		#region member
		#region views
		private cRefView viewcRef;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public cRefView cRef
		{
			get { return (cRefView)this["cRef"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewcRef = new cRefView(this);
			this.viewcRef.SetResourceInfo("c78a078e-bc99-48d7-8bd8-fef9985cf745");
			this.Views.Add(this.viewcRef);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.AdvApplyUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class cRefView : UIView
	{
		#region Constructor
		public cRefView(IUIModel model) : base(model,"cRef","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private cRefView():base(null,"cRef","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new cRefView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldAdvCode
		{
			get { return this.Fields["AdvCode"]; }
		}
		public IUIField FieldApplyDept_Code
		{
			get { return this.Fields["ApplyDept_Code"]; }
		}
		public IUIField FieldApplyDept_Name
		{
			get { return this.Fields["ApplyDept_Name"]; }
		}
		public IUIField FieldApplier
		{
			get { return this.Fields["Applier"]; }
		}
		public IUIField FieldApplyDate
		{
			get { return this.Fields["ApplyDate"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public cRefDefaultFilterFilter DefaultFilter
		{
			get { return (cRefDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","05d7a155-55e6-485b-9fd8-acea945c7cbf");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvCode", typeof(String), false,"","System.String", "AdvCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","92f6fb70-3f82-42d2-8b1c-88061f7828c3");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept_Code", typeof(String), false,"","System.String", "ApplyDept.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9074e3bd-c62b-4126-b977-b20c1e43a525");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept_Name", typeof(String), true,"","System.String", "ApplyDept.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","22f56b22-487d-4abe-8ec7-ccae00f4d6c5");
			UIModelRuntimeFactory.AddNewUIField(this,"Applier", typeof(String), true,"","System.String", "Applier", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","05ee25df-50bf-4335-a579-f54f08d82995");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDate", typeof(DateTime), true,"","System.Date", "ApplyDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","f883cb58-0a3a-4caa-b81d-8984d6e71760");


			this.CurrentFilter = new cRefDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new cRefRecord(builder);
		}
		#endregion

		#region new method
		public new cRefRecord FocusedRecord
		{
			get { return (cRefRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new cRefRecord AddNewUIRecord()
		{	
			return (cRefRecord)base.AddNewUIRecord();
		}
		public new cRefRecord NewUIRecord()
		{	
			return (cRefRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class cRefRecord : UIRecord
	{
		#region Constructor
		public cRefRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private cRefView uiviewcRef
		{
			get { return (cRefView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new cRefRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewcRef.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewcRef.FieldID);
			}
			set{
				this[this.uiviewcRef.FieldID] = value;
			}
		}
		
		
		public  String AdvCode
		{
			get{
				//object value = this[this.uiviewcRef.FieldAdvCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldAdvCode);
			}
			set{
				this[this.uiviewcRef.FieldAdvCode] = value;
			}
		}
		
		
		public  String ApplyDept_Code
		{
			get{
				//object value = this[this.uiviewcRef.FieldApplyDept_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldApplyDept_Code);
			}
			set{
				this[this.uiviewcRef.FieldApplyDept_Code] = value;
			}
		}
		
		
		public  String ApplyDept_Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldApplyDept_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldApplyDept_Name);
			}
			set{
				this[this.uiviewcRef.FieldApplyDept_Name] = value;
			}
		}
		
		
		public  String Applier
		{
			get{
				//object value = this[this.uiviewcRef.FieldApplier] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldApplier);
			}
			set{
				this[this.uiviewcRef.FieldApplier] = value;
			}
		}
		
		
		public  DateTime? ApplyDate
		{
			get{
				//object value = this[this.uiviewcRef.FieldApplyDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewcRef.FieldApplyDate);
			}
			set{
				this[this.uiviewcRef.FieldApplyDate] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class cRefDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public cRefDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"ApplyDept.DescFlexField.PrivateDescSeg14=='#Context.UserCode#' ",@" order by AdvCode asc")
		{
			InitClass();
		}
		//for Clone Constructor
		private cRefDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new cRefDefaultFilterFilter();
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