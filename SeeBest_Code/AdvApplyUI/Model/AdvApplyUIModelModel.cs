#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.AdvApplyUI.AdvApplyUIModel
{
	[Serializable]
	public partial class AdvApplyUIModelModel : UIModel
	{
		#region Constructor
		public AdvApplyUIModelModel() : base("AdvApplyUIModel")
		{
			InitClass();
			this.SetResourceInfo("ae8c587c-5655-44f8-afad-1376a8ba10ac");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private AdvApplyUIModelModel(bool isInit) : base("AdvApplyUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new AdvApplyUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private AdvApplyBEView viewAdvApplyBE;			
		private AdvApplyBE_AdvAboutBEView viewAdvApplyBE_AdvAboutBE;			
		#endregion
		
		#region links
		//private IUILink linkAdvApplyBE__AdvApplyBE_AdvAboutBE;			
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public AdvApplyBEView AdvApplyBE
		{
			get { return (AdvApplyBEView)this["AdvApplyBE"]; }
		}
		public AdvApplyBE_AdvAboutBEView AdvApplyBE_AdvAboutBE
		{
			get { return (AdvApplyBE_AdvAboutBEView)this["AdvApplyBE_AdvAboutBE"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewAdvApplyBE = new AdvApplyBEView(this);
			this.viewAdvApplyBE.SetResourceInfo("0493bda5-8a13-46c5-9112-4f8f533a42d8");
			this.Views.Add(this.viewAdvApplyBE);			
			this.viewAdvApplyBE_AdvAboutBE = new AdvApplyBE_AdvAboutBEView(this);
			this.viewAdvApplyBE_AdvAboutBE.SetResourceInfo("30bcaf79-e180-4a6f-9101-06a6f6ac6f85");
			this.Views.Add(this.viewAdvApplyBE_AdvAboutBE);			

			//this.linkAdvApplyBE__AdvApplyBE_AdvAboutBE
			{
			IUILink link = new UILink("AdvApplyBE__AdvApplyBE_AdvAboutBE",this,this.viewAdvApplyBE.FieldID,this.viewAdvApplyBE_AdvAboutBE.FieldAdvApplyBE,EnumAssociationKind.COMPOSITION,EnumAssociationDirection.Double,EnumCardinality.ONE,EnumCardinality.MORE,"AdvAboutBE");
			this.Links.Add(link);
			}
			//this.linkAdvApplyBE__AdvApplyBE_AdvAboutBE.ChildKeyConstraint.UpdateRule = Rule.None;
			//this.linkAdvApplyBE__AdvApplyBE_AdvAboutBE.ChildKeyConstraint.DeleteRule = Rule.None;
			//this.linkAdvApplyBE__AdvApplyBE_AdvAboutBE.ChildKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
			
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
	public partial class AdvApplyBEView : UIView
	{
		#region Constructor
		public AdvApplyBEView(IUIModel model) : base(model,"AdvApplyBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private AdvApplyBEView():base(null,"AdvApplyBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new AdvApplyBEView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldCreatedOn
		{
			get { return this.Fields["CreatedOn"]; }
		}
		public IUIField FieldCreatedBy
		{
			get { return this.Fields["CreatedBy"]; }
		}
		public IUIField FieldModifiedOn
		{
			get { return this.Fields["ModifiedOn"]; }
		}
		public IUIField FieldModifiedBy
		{
			get { return this.Fields["ModifiedBy"]; }
		}
		public IUIField FieldSysVersion
		{
			get { return this.Fields["SysVersion"]; }
		}
		public IUIField FieldAdvCode
		{
			get { return this.Fields["AdvCode"]; }
		}
		public IUIField FieldApplyDept
		{
			get { return this.Fields["ApplyDept"]; }
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
		public IUIField FieldPhone
		{
			get { return this.Fields["Phone"]; }
		}
		public IUIField FieldQQ
		{
			get { return this.Fields["QQ"]; }
		}
		public IUIField FieldCustConterName
		{
			get { return this.Fields["CustConterName"]; }
		}
		public IUIField FieldLocationQY
		{
			get { return this.Fields["LocationQY"]; }
		}
		public IUIField FieldLocationXZ
		{
			get { return this.Fields["LocationXZ"]; }
		}
		public IUIField FieldRelPeople
		{
			get { return this.Fields["RelPeople"]; }
		}
		public IUIField FieldCustPhone
		{
			get { return this.Fields["CustPhone"]; }
		}
		public IUIField FieldCustAddress
		{
			get { return this.Fields["CustAddress"]; }
		}
		public IUIField FieldAdvItem
		{
			get { return this.Fields["AdvItem"]; }
		}
		public IUIField FieldAdvItem_Code
		{
			get { return this.Fields["AdvItem_Code"]; }
		}
		public IUIField FieldAdvItem_Name
		{
			get { return this.Fields["AdvItem_Name"]; }
		}
		public IUIField FieldTotalArea
		{
			get { return this.Fields["TotalArea"]; }
		}
		public IUIField FieldQty
		{
			get { return this.Fields["Qty"]; }
		}
		public IUIField FieldBMWidth
		{
			get { return this.Fields["BMWidth"]; }
		}
		public IUIField FieldBMHight
		{
			get { return this.Fields["BMHight"]; }
		}
		public IUIField FieldBMThick
		{
			get { return this.Fields["BMThick"]; }
		}
		public IUIField FieldBMArea
		{
			get { return this.Fields["BMArea"]; }
		}
		public IUIField FieldDZWidth
		{
			get { return this.Fields["DZWidth"]; }
		}
		public IUIField FieldDZThick
		{
			get { return this.Fields["DZThick"]; }
		}
		public IUIField FieldDZArea
		{
			get { return this.Fields["DZArea"]; }
		}
		public IUIField FieldAdvDisplayType
		{
			get { return this.Fields["AdvDisplayType"]; }
		}
		public IUIField FieldAdvDispInfo1
		{
			get { return this.Fields["AdvDispInfo1"]; }
		}
		public IUIField FieldAdvDispInfo2
		{
			get { return this.Fields["AdvDispInfo2"]; }
		}
		public IUIField FieldAdvMemo
		{
			get { return this.Fields["AdvMemo"]; }
		}
		public IUIField FieldApproveQty
		{
			get { return this.Fields["ApproveQty"]; }
		}
		public IUIField FieldIsClose
		{
			get { return this.Fields["IsClose"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public AdvApplyBEDefaultFilterFilter DefaultFilter
		{
			get { return (AdvApplyBEDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","4b540298-8ec9-4bb7-9d73-1d559748a3fb");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","5484d5dc-eb78-453c-8c9a-36172fa17f38");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f8df4e32-7bce-44c2-9dba-78be1b23a216");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","9de504ca-0410-4ae3-9808-f5d8cf01c42a");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","576f2402-7ba2-4271-b606-2f1685cf1d9d");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","c2d83914-4a9e-4579-b8fa-cac295366d29");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvCode", typeof(String), false,"","System.String", "AdvCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8213ba8f-ca68-4ea5-bd1b-bbf863b4fc66");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept", typeof(Int64), false,"","UFIDA.U9.CBO.SCM.Customer.Customer", "ApplyDept", true,true, false, "",false,(UIFieldType)4,"8508f308-9d66-4b1d-abf4-e28dab8e926d","46233598-0adf-4b99-a9a1-d094c9f4b27b");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept_Code", typeof(String), false,"","System.String", "ApplyDept.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","da7b2fc7-c965-48b5-a998-2376b97b93f1");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept_Name", typeof(String), true,"","System.String", "ApplyDept.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8986e883-db2c-44dd-8f13-356165055c80");
			UIModelRuntimeFactory.AddNewUIField(this,"Applier", typeof(String), true,"","System.String", "Applier", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","89a1b019-bda6-4692-8aeb-e2e9922aea89");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDate", typeof(DateTime), true,"","System.Date", "ApplyDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","05998768-75de-46a7-b436-aff66dba0f0d");
			UIModelRuntimeFactory.AddNewUIField(this,"Phone", typeof(String), true,"","System.String", "Phone", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4d454b63-1781-454d-826c-d58ec781720a");
			UIModelRuntimeFactory.AddNewUIField(this,"QQ", typeof(String), true,"","System.String", "QQ", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7168f0ce-3f4e-48e7-8071-60d87afe18e9");
			UIModelRuntimeFactory.AddNewUIField(this,"CustConterName", typeof(String), true,"","System.String", "CustConterName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ae85b77c-c085-4d96-bf38-106c496e5dc5");
			UIModelRuntimeFactory.AddNewUIField(this,"LocationQY", typeof(String), true,"","System.String", "LocationQY", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0172a360-63ea-45dd-8617-87ff5deb4026");
			UIModelRuntimeFactory.AddNewUIField(this,"LocationXZ", typeof(String), true,"","System.String", "LocationXZ", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a13bcf08-d80c-4b45-bbcd-ba95747e3dd9");
			UIModelRuntimeFactory.AddNewUIField(this,"RelPeople", typeof(String), true,"","System.String", "RelPeople", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c8bba1de-2f50-4de7-ad85-af59d2bb93e9");
			UIModelRuntimeFactory.AddNewUIField(this,"CustPhone", typeof(String), true,"","System.String", "CustPhone", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bdfbf75e-50e1-41ca-ab69-f24fbd961cdb");
			UIModelRuntimeFactory.AddNewUIField(this,"CustAddress", typeof(String), true,"","System.String", "CustAddress", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c00450f6-6060-4c03-b7f8-a637000180e5");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvItem", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Item.ItemMaster", "AdvItem", true,true, false, "",false,(UIFieldType)4,"636d3e47-48aa-47fc-aca4-e6322bce775b","6633b8b3-cd02-4fea-810a-0b6fdb967f6f");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvItem_Code", typeof(String), false,"","System.String", "AdvItem.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","913b376e-2dde-45b1-8d23-c1ce66836154");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvItem_Name", typeof(String), false,"","System.String", "AdvItem.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ab123b2c-7608-44a6-8d84-949f84a16560");
			UIModelRuntimeFactory.AddNewUIField(this,"TotalArea", typeof(Decimal), true,"0","System.Decimal", "TotalArea", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","4ff04588-9d8b-4546-80fb-c8f99bb019ff");
			UIModelRuntimeFactory.AddNewUIField(this,"Qty", typeof(Decimal), false,"0","System.Decimal", "Qty", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","b14f5c0c-f36d-4d5c-9d48-55f110ff2762");
			UIModelRuntimeFactory.AddNewUIField(this,"BMWidth", typeof(Decimal), true,"0","System.Decimal", "BMWidth", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","41edbf9b-c814-4134-b364-667bf02e205f");
			UIModelRuntimeFactory.AddNewUIField(this,"BMHight", typeof(Decimal), true,"0","System.Decimal", "BMHight", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","1cb5d983-1d08-4e79-a7e7-e7ca455730ae");
			UIModelRuntimeFactory.AddNewUIField(this,"BMThick", typeof(Decimal), true,"0","System.Decimal", "BMThick", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","7427cd7f-9f86-4721-a570-1ecde5b31241");
			UIModelRuntimeFactory.AddNewUIField(this,"BMArea", typeof(Decimal), true,"0","System.Decimal", "BMArea", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","82879f14-665b-4d3b-ab1b-d05a5a0bddcb");
			UIModelRuntimeFactory.AddNewUIField(this,"DZWidth", typeof(Decimal), true,"0","System.Decimal", "DZWidth", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","64415460-7e3e-4716-920c-cc943b995b44");
			UIModelRuntimeFactory.AddNewUIField(this,"DZThick", typeof(Decimal), true,"0","System.Decimal", "DZThick", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","0c649632-746f-4593-a7b4-eba2d263a36c");
			UIModelRuntimeFactory.AddNewUIField(this,"DZArea", typeof(Decimal), true,"0","System.Decimal", "DZArea", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","a1a33a6e-1480-4679-98b3-57e731855baf");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvDisplayType", typeof(Int32), true,"0","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvDisplayTypeEnum", "AdvDisplayType", true,true, false, "",false,(UIFieldType)2,"0baa04a7-e868-40b1-b5a0-6cfacca13640","054233a2-1e6b-4490-bdf4-1f5c44d86bb5");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvDispInfo1", typeof(String), true,"","System.String", "AdvDispInfo1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fb962ca2-6af1-44c0-9750-c01bcc00a6c3");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvDispInfo2", typeof(String), true,"","System.String", "AdvDispInfo2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d33d4b81-d95b-4897-9e95-241915618803");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvMemo", typeof(String), true,"","System.String", "AdvMemo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f551913f-b03c-48c6-b9bc-6cf829c7e3d2");
			UIModelRuntimeFactory.AddNewUIField(this,"ApproveQty", typeof(Decimal), true,"0","System.Decimal", "ApproveQty", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","4115871f-d415-48ec-a2d9-880db606ac29");
			UIModelRuntimeFactory.AddNewUIField(this,"IsClose", typeof(Boolean), true,"false","System.Boolean", "IsClose", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","57fbd115-c41b-4869-a391-9e7805ad070b");


			this.CurrentFilter = new AdvApplyBEDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new AdvApplyBERecord(builder);
		}
		#endregion

		#region new method
		public new AdvApplyBERecord FocusedRecord
		{
			get { return (AdvApplyBERecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new AdvApplyBERecord AddNewUIRecord()
		{	
			return (AdvApplyBERecord)base.AddNewUIRecord();
		}
		public new AdvApplyBERecord NewUIRecord()
		{	
			return (AdvApplyBERecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class AdvApplyBERecord : UIRecord
	{
		#region Constructor
		public AdvApplyBERecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private AdvApplyBEView uiviewAdvApplyBE
		{
			get { return (AdvApplyBEView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new AdvApplyBERecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAdvApplyBE.FieldID);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApplyBE.FieldCreatedOn);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldCreatedBy);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApplyBE.FieldModifiedOn);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldModifiedBy);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApplyBE.FieldSysVersion);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldSysVersion] = value;
			}
		}
		
		
		public  String AdvCode
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldAdvCode);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvCode] = value;
			}
		}
		
		
		public  Int64 ApplyDept
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldApplyDept] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAdvApplyBE.FieldApplyDept);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldApplyDept] = value;
			}
		}
		
		
		public  String ApplyDept_Code
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldApplyDept_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldApplyDept_Code);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldApplyDept_Code] = value;
			}
		}
		
		
		public  String ApplyDept_Name
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldApplyDept_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldApplyDept_Name);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldApplyDept_Name] = value;
			}
		}
		
		
		public  String Applier
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldApplier] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldApplier);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldApplier] = value;
			}
		}
		
		
		public  DateTime? ApplyDate
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldApplyDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApplyBE.FieldApplyDate);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldApplyDate] = value;
			}
		}
		
		
		public  String Phone
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldPhone] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldPhone);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldPhone] = value;
			}
		}
		
		
		public  String QQ
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldQQ] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldQQ);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldQQ] = value;
			}
		}
		
		
		public  String CustConterName
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldCustConterName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldCustConterName);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldCustConterName] = value;
			}
		}
		
		
		public  String LocationQY
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldLocationQY] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldLocationQY);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldLocationQY] = value;
			}
		}
		
		
		public  String LocationXZ
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldLocationXZ] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldLocationXZ);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldLocationXZ] = value;
			}
		}
		
		
		public  String RelPeople
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldRelPeople] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldRelPeople);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldRelPeople] = value;
			}
		}
		
		
		public  String CustPhone
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldCustPhone] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldCustPhone);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldCustPhone] = value;
			}
		}
		
		
		public  String CustAddress
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldCustAddress] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldCustAddress);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldCustAddress] = value;
			}
		}
		
		
		public  Int64? AdvItem
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvItem] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApplyBE.FieldAdvItem);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvItem] = value;
			}
		}
		
		
		public  String AdvItem_Code
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvItem_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldAdvItem_Code);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvItem_Code] = value;
			}
		}
		
		
		public  String AdvItem_Name
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvItem_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldAdvItem_Name);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvItem_Name] = value;
			}
		}
		
		
		public  Decimal? TotalArea
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldTotalArea] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApplyBE.FieldTotalArea);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldTotalArea] = value;
			}
		}
		
		
		public  Decimal Qty
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldQty] ;
				//return (Decimal)value;
				return GetValue<Decimal>(this.uiviewAdvApplyBE.FieldQty);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldQty] = value;
			}
		}
		
		
		public  Decimal? BMWidth
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldBMWidth] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApplyBE.FieldBMWidth);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldBMWidth] = value;
			}
		}
		
		
		public  Decimal? BMHight
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldBMHight] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApplyBE.FieldBMHight);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldBMHight] = value;
			}
		}
		
		
		public  Decimal? BMThick
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldBMThick] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApplyBE.FieldBMThick);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldBMThick] = value;
			}
		}
		
		
		public  Decimal? BMArea
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldBMArea] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApplyBE.FieldBMArea);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldBMArea] = value;
			}
		}
		
		
		public  Decimal? DZWidth
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDZWidth] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApplyBE.FieldDZWidth);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDZWidth] = value;
			}
		}
		
		
		public  Decimal? DZThick
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDZThick] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApplyBE.FieldDZThick);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDZThick] = value;
			}
		}
		
		
		public  Decimal? DZArea
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldDZArea] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApplyBE.FieldDZArea);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldDZArea] = value;
			}
		}
		
		
		public  Int32? AdvDisplayType
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvDisplayType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewAdvApplyBE.FieldAdvDisplayType);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvDisplayType] = value;
			}
		}
		
		
		public  String AdvDispInfo1
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvDispInfo1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldAdvDispInfo1);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvDispInfo1] = value;
			}
		}
		
		
		public  String AdvDispInfo2
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvDispInfo2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldAdvDispInfo2);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvDispInfo2] = value;
			}
		}
		
		
		public  String AdvMemo
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvMemo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldAdvMemo);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvMemo] = value;
			}
		}
		
		
		public  Decimal? ApproveQty
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldApproveQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApplyBE.FieldApproveQty);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldApproveQty] = value;
			}
		}
		
		
		public  Boolean? IsClose
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldIsClose] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewAdvApplyBE.FieldIsClose);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldIsClose] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class AdvApplyBEDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public AdvApplyBEDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private AdvApplyBEDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new AdvApplyBEDefaultFilterFilter();
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



	[Serializable]
	public partial class AdvApplyBE_AdvAboutBEView : UIView
	{
		#region Constructor
		public AdvApplyBE_AdvAboutBEView(IUIModel model) : base(model,"AdvApplyBE_AdvAboutBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBE", false)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private AdvApplyBE_AdvAboutBEView():base(null,"AdvApplyBE_AdvAboutBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBE", false)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new AdvApplyBE_AdvAboutBEView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldCreatedOn
		{
			get { return this.Fields["CreatedOn"]; }
		}
		public IUIField FieldCreatedBy
		{
			get { return this.Fields["CreatedBy"]; }
		}
		public IUIField FieldModifiedOn
		{
			get { return this.Fields["ModifiedOn"]; }
		}
		public IUIField FieldModifiedBy
		{
			get { return this.Fields["ModifiedBy"]; }
		}
		public IUIField FieldSysVersion
		{
			get { return this.Fields["SysVersion"]; }
		}
		public IUIField FieldAdvApplyBE
		{
			get { return this.Fields["AdvApplyBE"]; }
		}
		public IUIField FieldCode
		{
			get { return this.Fields["Code"]; }
		}
		public IUIField FieldName
		{
			get { return this.Fields["Name"]; }
		}
		public IUIField FieldIsSelected
		{
			get { return this.Fields["IsSelected"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public AdvApplyBE_AdvAboutBEDefaultFilterFilter DefaultFilter
		{
			get { return (AdvApplyBE_AdvAboutBEDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","fbf95c69-0e74-4cc6-a7d3-591aa20a8675");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","404fdf97-87e3-4160-94e0-1f0559419732");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ab1e0d9a-b50f-4f03-adc6-c6d27b6eb8bd");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","02e11d74-ad81-43f7-a5b0-7ab04dd695b1");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","270dd6eb-35bb-4de2-a0ca-3c246ecf5877");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","ef2412e6-730f-4d5b-b1d3-4fa32c573261");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvApplyBE", typeof(Int64), true,"","UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE", "AdvApplyBE", true,true, false, "",false,(UIFieldType)4,"34b34c55-0b84-4313-8595-ec236b56752e","c352fd3d-65ec-4c70-acb5-5c0a0024f94c");
			UIModelRuntimeFactory.AddNewUIField(this,"Code", typeof(String), true,"","System.String", "Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e0605e22-9d69-42b8-90f9-ffd65a705e34");
			UIModelRuntimeFactory.AddNewUIField(this,"Name", typeof(String), true,"","System.String", "Name", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7ea67510-329d-4872-86fc-66be477ea2c5");
			UIModelRuntimeFactory.AddNewUIField(this,"IsSelected", typeof(Boolean), true,"false","System.Boolean", "IsSelected", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","88da77a8-c726-4783-b16c-a82c8880c9f7");


			this.CurrentFilter = new AdvApplyBE_AdvAboutBEDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new AdvApplyBE_AdvAboutBERecord(builder);
		}
		#endregion

		#region new method
		public new AdvApplyBE_AdvAboutBERecord FocusedRecord
		{
			get { return (AdvApplyBE_AdvAboutBERecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new AdvApplyBE_AdvAboutBERecord AddNewUIRecord()
		{	
			return (AdvApplyBE_AdvAboutBERecord)base.AddNewUIRecord();
		}
		public new AdvApplyBE_AdvAboutBERecord NewUIRecord()
		{	
			return (AdvApplyBE_AdvAboutBERecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class AdvApplyBE_AdvAboutBERecord : UIRecord
	{
		#region Constructor
		public AdvApplyBE_AdvAboutBERecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private AdvApplyBE_AdvAboutBEView uiviewAdvApplyBE_AdvAboutBE
		{
			get { return (AdvApplyBE_AdvAboutBEView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new AdvApplyBE_AdvAboutBERecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewAdvApplyBE_AdvAboutBE.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAdvApplyBE_AdvAboutBE.FieldID);
			}
			set{
				this[this.uiviewAdvApplyBE_AdvAboutBE.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewAdvApplyBE_AdvAboutBE.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApplyBE_AdvAboutBE.FieldCreatedOn);
			}
			set{
				this[this.uiviewAdvApplyBE_AdvAboutBE.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewAdvApplyBE_AdvAboutBE.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE_AdvAboutBE.FieldCreatedBy);
			}
			set{
				this[this.uiviewAdvApplyBE_AdvAboutBE.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewAdvApplyBE_AdvAboutBE.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAdvApplyBE_AdvAboutBE.FieldModifiedOn);
			}
			set{
				this[this.uiviewAdvApplyBE_AdvAboutBE.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewAdvApplyBE_AdvAboutBE.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE_AdvAboutBE.FieldModifiedBy);
			}
			set{
				this[this.uiviewAdvApplyBE_AdvAboutBE.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewAdvApplyBE_AdvAboutBE.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApplyBE_AdvAboutBE.FieldSysVersion);
			}
			set{
				this[this.uiviewAdvApplyBE_AdvAboutBE.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? AdvApplyBE
		{
			get{
				//object value = this[this.uiviewAdvApplyBE_AdvAboutBE.FieldAdvApplyBE] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApplyBE_AdvAboutBE.FieldAdvApplyBE);
			}
			set{
				this[this.uiviewAdvApplyBE_AdvAboutBE.FieldAdvApplyBE] = value;
			}
		}
		
		
		public  String Code
		{
			get{
				//object value = this[this.uiviewAdvApplyBE_AdvAboutBE.FieldCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE_AdvAboutBE.FieldCode);
			}
			set{
				this[this.uiviewAdvApplyBE_AdvAboutBE.FieldCode] = value;
			}
		}
		
		
		public new String Name
		{
			get{
				//object value = this[this.uiviewAdvApplyBE_AdvAboutBE.FieldName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE_AdvAboutBE.FieldName);
			}
			set{
				this[this.uiviewAdvApplyBE_AdvAboutBE.FieldName] = value;
			}
		}
		
		
		public  Boolean? IsSelected
		{
			get{
				//object value = this[this.uiviewAdvApplyBE_AdvAboutBE.FieldIsSelected] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewAdvApplyBE_AdvAboutBE.FieldIsSelected);
			}
			set{
				this[this.uiviewAdvApplyBE_AdvAboutBE.FieldIsSelected] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class AdvApplyBE_AdvAboutBEDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public AdvApplyBE_AdvAboutBEDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private AdvApplyBE_AdvAboutBEDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new AdvApplyBE_AdvAboutBEDefaultFilterFilter();
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