#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace AdvApproveFindRef
{
	[Serializable]
	public partial class AdvApproveFindRefModel : UIModel
	{
		#region Constructor
		public AdvApproveFindRefModel() : base("AdvApproveFindRef")
		{
			InitClass();
			this.SetResourceInfo("038f82f5-97ce-4aab-a61f-01b02bffc951");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private AdvApproveFindRefModel(bool isInit) : base("AdvApproveFindRef")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new AdvApproveFindRefModel(false);
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
			this.viewcRef.SetResourceInfo("63008f0c-8431-41c4-9eee-9b55aa46da97");
			this.Views.Add(this.viewcRef);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.AdvApproveUI"; }
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
		public cRefView(IUIModel model) : base(model,"cRef","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private cRefView():base(null,"cRef","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE", true)
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
		public IUIField FieldDocNo
		{
			get { return this.Fields["DocNo"]; }
		}
		public IUIField FieldDocStatus
		{
			get { return this.Fields["DocStatus"]; }
		}
		public IUIField FieldStartDate
		{
			get { return this.Fields["StartDate"]; }
		}
		public IUIField FieldAdvApplyCust_Code
		{
			get { return this.Fields["AdvApplyCust_Code"]; }
		}
		public IUIField FieldEndDate
		{
			get { return this.Fields["EndDate"]; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","0ed180eb-5663-4bcf-9f13-0a6580bf67a7");
			UIModelRuntimeFactory.AddNewUIField(this,"DocNo", typeof(String), false,"","System.String", "DocNo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fe8e9fb4-e4b9-40ab-9076-a11bac35dbb5");
			UIModelRuntimeFactory.AddNewUIField(this,"DocStatus", typeof(Int32), true,"","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvAppStatusEnum", "DocStatus", true,true, false, "",false,(UIFieldType)2,"c597484c-846b-48f0-8c05-49caf9820a86","40913b1f-105f-4058-926f-97901aff7e30");
			UIModelRuntimeFactory.AddNewUIField(this,"StartDate", typeof(DateTime), true,"","System.Date", "StartDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","9c9d4280-0eba-4230-8437-c51e034151cc");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyCust_Code", typeof(String), false,"","System.String", "AdvApplyCust.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c14a6b3f-7a46-466c-96f8-93ba927bcf7c");
			UIModelRuntimeFactory.AddNewUIField(this,"EndDate", typeof(DateTime), true,"","System.Date", "EndDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","0aa4126e-107d-4231-b617-3e4d8095cd0b");


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
		
		
		public  String DocNo
		{
			get{
				//object value = this[this.uiviewcRef.FieldDocNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldDocNo);
			}
			set{
				this[this.uiviewcRef.FieldDocNo] = value;
			}
		}
		
		
		public  Int32? DocStatus
		{
			get{
				//object value = this[this.uiviewcRef.FieldDocStatus] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewcRef.FieldDocStatus);
			}
			set{
				this[this.uiviewcRef.FieldDocStatus] = value;
			}
		}
		
		
		public  DateTime? StartDate
		{
			get{
				//object value = this[this.uiviewcRef.FieldStartDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewcRef.FieldStartDate);
			}
			set{
				this[this.uiviewcRef.FieldStartDate] = value;
			}
		}
		
		
		public  String AdvApplyCust_Code
		{
			get{
				//object value = this[this.uiviewcRef.FieldAdvApplyCust_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldAdvApplyCust_Code);
			}
			set{
				this[this.uiviewcRef.FieldAdvApplyCust_Code] = value;
			}
		}
		
		
		public  DateTime? EndDate
		{
			get{
				//object value = this[this.uiviewcRef.FieldEndDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewcRef.FieldEndDate);
			}
			set{
				this[this.uiviewcRef.FieldEndDate] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class cRefDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public cRefDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
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