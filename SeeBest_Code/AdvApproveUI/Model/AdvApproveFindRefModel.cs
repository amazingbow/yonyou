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
			this.SetResourceInfo("78407942-ea91-4f9f-b0a1-88f35f666f02");
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
			this.viewcRef.SetResourceInfo("07076fa9-e42e-445c-b39c-b3701184ffde");
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
		public IUIField FieldAdvApplyCust_Code
		{
			get { return this.Fields["AdvApplyCust_Code"]; }
		}
		public IUIField FieldAdvApplyCust_Name
		{
			get { return this.Fields["AdvApplyCust_Name"]; }
		}
		public IUIField FieldMonth
		{
			get { return this.Fields["Month"]; }
		}
		public IUIField FieldDocStatus
		{
			get { return this.Fields["DocStatus"]; }
		}
		public IUIField FieldAdvApproveDocType_Code
		{
			get { return this.Fields["AdvApproveDocType_Code"]; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","c59ed6dd-6482-4cbd-803d-d7674611ee49");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyCust_Code", typeof(String), false,"","System.String", "AdvApplyCust.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5569c7d8-267a-4e62-9455-2366345ccaa3");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyCust_Name", typeof(String), true,"","System.String", "AdvApplyCust.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ec97753c-13b9-468b-ad70-8c16851cefed");
			UIModelRuntimeFactory.AddNewUIField(this,"Month", typeof(DateTime), true,"","System.Date", "Month", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","e5b71c5b-7ce0-4c82-8927-5e32ca5ceb96");
			UIModelRuntimeFactory.AddNewUIField(this,"DocStatus", typeof(Int32), true,"","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvAppStatusEnum", "DocStatus", true,true, false, "",false,(UIFieldType)2,"c597484c-846b-48f0-8c05-49caf9820a86","b8f6ae0b-9ed6-4f7b-8a38-2d72c09feea3");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApproveDocType_Code", typeof(String), false,"","System.String", "AdvApproveDocType.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","45ad10b1-23b8-4b92-bb1a-cbdc1794ecc9");


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
		
		
		public  String AdvApplyCust_Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldAdvApplyCust_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldAdvApplyCust_Name);
			}
			set{
				this[this.uiviewcRef.FieldAdvApplyCust_Name] = value;
			}
		}
		
		
		public  DateTime? Month
		{
			get{
				//object value = this[this.uiviewcRef.FieldMonth] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewcRef.FieldMonth);
			}
			set{
				this[this.uiviewcRef.FieldMonth] = value;
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
		
		
		public  String AdvApproveDocType_Code
		{
			get{
				//object value = this[this.uiviewcRef.FieldAdvApproveDocType_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldAdvApproveDocType_Code);
			}
			set{
				this[this.uiviewcRef.FieldAdvApproveDocType_Code] = value;
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