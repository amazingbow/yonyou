#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace XMJLDisburseNoRef
{
	[Serializable]
	public partial class XMJLDisburseNoRefModel : UIModel
	{
		#region Constructor
		public XMJLDisburseNoRefModel() : base("XMJLDisburseNoRef")
		{
			InitClass();
			this.SetResourceInfo("0e3bce97-f8bf-458f-a536-c89d20f3f9d7");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private XMJLDisburseNoRefModel(bool isInit) : base("XMJLDisburseNoRef")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new XMJLDisburseNoRefModel(false);
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
			this.viewcRef.SetResourceInfo("12c7171d-de93-4002-911b-f0f627603c68");
			this.Views.Add(this.viewcRef);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.XMJL.Qry.BOMUI"; }
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
		public cRefView(IUIModel model) : base(model,"cRef","UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomMain", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private cRefView():base(null,"cRef","UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomMain", true)
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
		public IUIField FieldDescFlexField_PrivateDescSeg1
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg1"]; }
		}
		public IUIField FieldDepartment_Name
		{
			get { return this.Fields["Department_Name"]; }
		}
		public IUIField FieldDisburseBY_Name
		{
			get { return this.Fields["DisburseBY_Name"]; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","c1807baf-a761-4845-a9cc-b30996a287a7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","45c85fbd-d9bd-4fa7-a15e-299daf5404f6");
			UIModelRuntimeFactory.AddNewUIField(this,"Department_Name", typeof(String), true,"","System.String", "Department.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5a3deee5-520c-4418-82c3-8cfcbbf9cf19");
			UIModelRuntimeFactory.AddNewUIField(this,"DisburseBY_Name", typeof(String), true,"","System.String", "DisburseBY.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1495017b-9b79-4e93-9b49-bfbccb799c4d");


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
		
		
		public  String DescFlexField_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewcRef.FieldDescFlexField_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldDescFlexField_PrivateDescSeg1);
			}
			set{
				this[this.uiviewcRef.FieldDescFlexField_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String Department_Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldDepartment_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldDepartment_Name);
			}
			set{
				this[this.uiviewcRef.FieldDepartment_Name] = value;
			}
		}
		
		
		public  String DisburseBY_Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldDisburseBY_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldDisburseBY_Name);
			}
			set{
				this[this.uiviewcRef.FieldDisburseBY_Name] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class cRefDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public cRefDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"ID  in (select max(ID) from UFIDA::U9::Cust::XMJL::BommBE::Cust_Xmjl_MO_BomMain where Org.ID=#Context.OrgID#
 and DescFlexField.PrivateDescSeg1!=''
group by DescFlexField.PrivateDescSeg1, DisburseBY.Name,
DisburseBY.Dept.Name)",@" order by DescFlexField.PrivateDescSeg1 desc")
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