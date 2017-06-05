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
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public AdvApplyBEView AdvApplyBE
		{
			get { return (AdvApplyBEView)this["AdvApplyBE"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewAdvApplyBE = new AdvApplyBEView(this);
			this.viewAdvApplyBE.SetResourceInfo("9aad459a-fbc0-4284-8a59-5299d0621671");
			this.Views.Add(this.viewAdvApplyBE);			

			
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
		public AdvApplyBEView(IUIModel model) : base(model,"AdvApplyBE","AdvertisementApplyBE.AdvApplyBE", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private AdvApplyBEView():base(null,"AdvApplyBE","AdvertisementApplyBE.AdvApplyBE", true)
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
		public IUIField FieldAdvAbout
		{
			get { return this.Fields["AdvAbout"]; }
		}
		public IUIField FieldAdvMemo
		{
			get { return this.Fields["AdvMemo"]; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","6b14e9bd-f57c-4780-a03b-68375cc269e7");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","4b737267-271a-433e-b6be-07ce450ae1e4");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2da23383-4cbd-4217-89af-6b2cdc71db5c");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","1d18c83a-6c58-4f1a-8121-202a37436aaa");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","904a96ab-11a0-4c59-954c-3a347cb840f5");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","ddcb4a6a-7466-48ba-9c46-ca00ee6a1f76");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvCode", typeof(String), true,"","System.String", "AdvCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","da8e1120-73fc-4f0b-8b79-c1d3566e1fc0");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Customer.Customer", "ApplyDept", true,true, false, "",false,(UIFieldType)4,"8508f308-9d66-4b1d-abf4-e28dab8e926d","7962b0c7-ec45-4ecb-b48d-ae20dd012125");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept_Code", typeof(String), false,"","System.String", "ApplyDept.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3bea086d-9e27-46c6-a62f-04082f2a9bc2");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept_Name", typeof(String), true,"","System.String", "ApplyDept.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","33177dce-e3a6-4e44-b7a0-3ce6067270a8");
			UIModelRuntimeFactory.AddNewUIField(this,"Applier", typeof(String), true,"","System.String", "Applier", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cec18246-7fa3-4750-aa18-6ad253140daf");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDate", typeof(DateTime), true,"","System.Date", "ApplyDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","ce780ddb-401c-48b8-a2ab-bd3e6c71fc4d");
			UIModelRuntimeFactory.AddNewUIField(this,"Phone", typeof(String), true,"","System.String", "Phone", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b1e83279-4727-41b9-88d9-c041c68920f6");
			UIModelRuntimeFactory.AddNewUIField(this,"QQ", typeof(String), true,"","System.String", "QQ", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ea83b850-9812-42fd-88ba-8efa2e50984f");
			UIModelRuntimeFactory.AddNewUIField(this,"CustConterName", typeof(String), true,"","System.String", "CustConterName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7bc62c47-d740-410b-bfba-ca645e3cdbc4");
			UIModelRuntimeFactory.AddNewUIField(this,"LocationQY", typeof(String), true,"","System.String", "LocationQY", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","055df3fa-8970-4465-b64e-ebd1861467f2");
			UIModelRuntimeFactory.AddNewUIField(this,"LocationXZ", typeof(String), true,"","System.String", "LocationXZ", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ccc918d7-9ef5-4367-a072-34ff0c6a79b7");
			UIModelRuntimeFactory.AddNewUIField(this,"RelPeople", typeof(String), true,"","System.String", "RelPeople", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","966578bc-bb15-4c1d-afb7-49c687ebbb41");
			UIModelRuntimeFactory.AddNewUIField(this,"CustPhone", typeof(String), true,"","System.String", "CustPhone", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","60fa3532-eebb-485f-9aa8-bf9701341992");
			UIModelRuntimeFactory.AddNewUIField(this,"CustAddress", typeof(String), true,"","System.String", "CustAddress", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0b6c32a4-7cd3-4598-be00-61f1dff84d85");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvItem", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Item.ItemMaster", "AdvItem", true,true, false, "",false,(UIFieldType)4,"636d3e47-48aa-47fc-aca4-e6322bce775b","4b2ad640-727b-4a3a-8d24-061c0ebca1e5");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvItem_Code", typeof(String), false,"","System.String", "AdvItem.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4ede686d-921e-4a25-ad45-9f40a8876b0d");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvItem_Name", typeof(String), false,"","System.String", "AdvItem.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a69227ce-7e2a-4412-8f2f-0868987dbc5e");
			UIModelRuntimeFactory.AddNewUIField(this,"TotalArea", typeof(Decimal), true,"0","System.Decimal", "TotalArea", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","11ca841a-3858-48c1-806c-b030b0b515ce");
			UIModelRuntimeFactory.AddNewUIField(this,"Qty", typeof(Decimal), true,"0","System.Decimal", "Qty", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","6e784142-471f-4761-bc2e-22ad32f4c405");
			UIModelRuntimeFactory.AddNewUIField(this,"BMWidth", typeof(Decimal), true,"0","System.Decimal", "BMWidth", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","3e3a4ae3-8c50-4953-9438-1fc09df11b07");
			UIModelRuntimeFactory.AddNewUIField(this,"BMHight", typeof(Decimal), true,"0","System.Decimal", "BMHight", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","ea559a74-b5a4-4e99-83f7-87e6298f3482");
			UIModelRuntimeFactory.AddNewUIField(this,"BMThick", typeof(Decimal), true,"0","System.Decimal", "BMThick", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","b1461951-fcba-4a02-b6ed-2b93ce00977d");
			UIModelRuntimeFactory.AddNewUIField(this,"BMArea", typeof(Decimal), true,"0","System.Decimal", "BMArea", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","b5bcf3e9-479b-434c-b34c-f7331edaf2f1");
			UIModelRuntimeFactory.AddNewUIField(this,"DZWidth", typeof(Decimal), true,"0","System.Decimal", "DZWidth", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","79405777-8bae-4b6e-9643-58cf3557296f");
			UIModelRuntimeFactory.AddNewUIField(this,"DZThick", typeof(Decimal), true,"0","System.Decimal", "DZThick", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","17192fdb-799d-4a8b-ab0a-84877e625f7f");
			UIModelRuntimeFactory.AddNewUIField(this,"DZArea", typeof(Decimal), true,"0","System.Decimal", "DZArea", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","b58c623c-1c5b-4f9d-8683-e5362622177f");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvDisplayType", typeof(Int32), true,"0","AdvertisementApplyBE.AdvDisplayTypeEnum", "AdvDisplayType", true,true, false, "",false,(UIFieldType)2,"0baa04a7-e868-40b1-b5a0-6cfacca13640","b6411d15-78e6-400d-b816-8bf917b9f17f");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvDispInfo1", typeof(String), true,"","System.String", "AdvDispInfo1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","24c208f5-cd9f-45f0-9112-bd84be1bc7ec");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvDispInfo2", typeof(String), true,"","System.String", "AdvDispInfo2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8d01db86-e4ed-4a85-9b17-2ec3a6f06830");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvAbout", typeof(String), true,"","System.String", "AdvAbout", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9c3704c2-bf45-41b0-98fd-4b3bdd1cb761");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvMemo", typeof(String), true,"","System.String", "AdvMemo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0b3fcf89-0723-49e0-bd5b-1d2af55ae3fc");


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
		
		
		public  Int64? ApplyDept
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldApplyDept] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAdvApplyBE.FieldApplyDept);
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
		
		
		public  Decimal? Qty
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewAdvApplyBE.FieldQty);
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
		
		
		public  String AdvAbout
		{
			get{
				//object value = this[this.uiviewAdvApplyBE.FieldAdvAbout] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAdvApplyBE.FieldAdvAbout);
			}
			set{
				this[this.uiviewAdvApplyBE.FieldAdvAbout] = value;
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



}