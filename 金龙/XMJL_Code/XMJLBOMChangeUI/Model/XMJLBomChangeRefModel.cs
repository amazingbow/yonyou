#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace XMJLBomChangeRef
{
	[Serializable]
	public partial class XMJLBomChangeRefModel : UIModel
	{
		#region Constructor
		public XMJLBomChangeRefModel() : base("XMJLBomChangeRef")
		{
			InitClass();
			this.SetResourceInfo("5793f6a2-1489-4b7e-bae0-81634a59f09a");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private XMJLBomChangeRefModel(bool isInit) : base("XMJLBomChangeRef")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new XMJLBomChangeRefModel(false);
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
			this.viewcRef.SetResourceInfo("fe5e6ffe-2394-40d0-bc52-61891f1c4dd8");
			this.Views.Add(this.viewcRef);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.XMJL.XMJLBOMChangeUI"; }
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
		public cRefView(IUIModel model) : base(model,"cRef","UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private cRefView():base(null,"cRef","UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChange", true)
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
		public IUIField FieldChangeReason
		{
			get { return this.Fields["ChangeReason"]; }
		}
		public IUIField FieldChangeDateTime
		{
			get { return this.Fields["ChangeDateTime"]; }
		}
		public IUIField FieldChangeStat
		{
			get { return this.Fields["ChangeStat"]; }
		}
		public IUIField FieldChangePerson_Name
		{
			get { return this.Fields["ChangePerson_Name"]; }
		}
		public IUIField FieldCreatedOn
		{
			get { return this.Fields["CreatedOn"]; }
		}
		public IUIField FieldCreatedBy
		{
			get { return this.Fields["CreatedBy"]; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","86c4949c-2f9f-4320-ad3c-ba13a71465a5");
			UIModelRuntimeFactory.AddNewUIField(this,"DocNo", typeof(String), false,"","System.String", "DocNo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dc119c14-1467-4483-a533-5201f44ccef5");
			UIModelRuntimeFactory.AddNewUIField(this,"ChangeReason", typeof(String), true,"","System.String", "ChangeReason", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8475e446-98f6-41f0-bc7f-932670dbd1bc");
			UIModelRuntimeFactory.AddNewUIField(this,"ChangeDateTime", typeof(DateTime), true,"","System.DateTime", "ChangeDateTime", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","5aa23e7a-6150-45cb-879e-eda13a26a38f");
			UIModelRuntimeFactory.AddNewUIField(this,"ChangeStat", typeof(Boolean), true,"","System.Boolean", "ChangeStat", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","1fc6a5bb-7991-4d98-b5af-03182d25cafc");
			UIModelRuntimeFactory.AddNewUIField(this,"ChangePerson_Name", typeof(String), false,"","System.String", "ChangePerson.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","63e7f89f-13c4-4e1b-bf11-e18c37093465");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","22eb9b6d-e0a0-48ff-a809-cb575cac7a3c");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fd72be5a-26b1-4d16-bfc5-1926ccce7580");


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
		
		
		public  String ChangeReason
		{
			get{
				//object value = this[this.uiviewcRef.FieldChangeReason] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldChangeReason);
			}
			set{
				this[this.uiviewcRef.FieldChangeReason] = value;
			}
		}
		
		
		public  DateTime? ChangeDateTime
		{
			get{
				//object value = this[this.uiviewcRef.FieldChangeDateTime] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewcRef.FieldChangeDateTime);
			}
			set{
				this[this.uiviewcRef.FieldChangeDateTime] = value;
			}
		}
		
		
		public  Boolean? ChangeStat
		{
			get{
				//object value = this[this.uiviewcRef.FieldChangeStat] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewcRef.FieldChangeStat);
			}
			set{
				this[this.uiviewcRef.FieldChangeStat] = value;
			}
		}
		
		
		public  String ChangePerson_Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldChangePerson_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldChangePerson_Name);
			}
			set{
				this[this.uiviewcRef.FieldChangePerson_Name] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewcRef.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewcRef.FieldCreatedOn);
			}
			set{
				this[this.uiviewcRef.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewcRef.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldCreatedBy);
			}
			set{
				this[this.uiviewcRef.FieldCreatedBy] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class cRefDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public cRefDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@" order by ChangeDateTime asc")
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