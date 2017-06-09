#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.SpecialApplyUI.SpecialApplyUIModel
{
	[Serializable]
	public partial class SpecialApplyUIModelModel : UIModel
	{
		#region Constructor
		public SpecialApplyUIModelModel() : base("SpecialApplyUIModel")
		{
			InitClass();
			this.SetResourceInfo("b65b1c63-3f70-479c-a185-275aa849150c");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private SpecialApplyUIModelModel(bool isInit) : base("SpecialApplyUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new SpecialApplyUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private SpecialApplyBEView viewSpecialApplyBE;			
		private SpecialApplyBE_SpecialSizeBEView viewSpecialApplyBE_SpecialSizeBE;			
		#endregion
		
		#region links
		//private IUILink linkSpecialApplyBE__SpecialApplyBE_SpecialSizeBE;			
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public SpecialApplyBEView SpecialApplyBE
		{
			get { return (SpecialApplyBEView)this["SpecialApplyBE"]; }
		}
		public SpecialApplyBE_SpecialSizeBEView SpecialApplyBE_SpecialSizeBE
		{
			get { return (SpecialApplyBE_SpecialSizeBEView)this["SpecialApplyBE_SpecialSizeBE"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewSpecialApplyBE = new SpecialApplyBEView(this);
			this.viewSpecialApplyBE.SetResourceInfo("98f59678-956f-4d9b-8cc1-7e532448b08e");
			this.Views.Add(this.viewSpecialApplyBE);			
			this.viewSpecialApplyBE_SpecialSizeBE = new SpecialApplyBE_SpecialSizeBEView(this);
			this.viewSpecialApplyBE_SpecialSizeBE.SetResourceInfo("9d6e25db-d257-432f-8a50-8b38e44d8547");
			this.Views.Add(this.viewSpecialApplyBE_SpecialSizeBE);			

			//this.linkSpecialApplyBE__SpecialApplyBE_SpecialSizeBE
			{
			IUILink link = new UILink("SpecialApplyBE__SpecialApplyBE_SpecialSizeBE",this,this.viewSpecialApplyBE.FieldID,this.viewSpecialApplyBE_SpecialSizeBE.FieldSpecialApplyBE,EnumAssociationKind.COMPOSITION,EnumAssociationDirection.Double,EnumCardinality.ONE,EnumCardinality.MORE,"");
			this.Links.Add(link);
			}
			//this.linkSpecialApplyBE__SpecialApplyBE_SpecialSizeBE.ChildKeyConstraint.UpdateRule = Rule.None;
			//this.linkSpecialApplyBE__SpecialApplyBE_SpecialSizeBE.ChildKeyConstraint.DeleteRule = Rule.None;
			//this.linkSpecialApplyBE__SpecialApplyBE_SpecialSizeBE.ChildKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.SpecialApplyUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class SpecialApplyBEView : UIView
	{
		#region Constructor
		public SpecialApplyBEView(IUIModel model) : base(model,"SpecialApplyBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private SpecialApplyBEView():base(null,"SpecialApplyBE","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new SpecialApplyBEView();
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
		public IUIField FieldCustName
		{
			get { return this.Fields["CustName"]; }
		}
		public IUIField FieldCustPhone
		{
			get { return this.Fields["CustPhone"]; }
		}
		public IUIField FieldCustAddress
		{
			get { return this.Fields["CustAddress"]; }
		}
		public IUIField FieldSpecialDesignStyle
		{
			get { return this.Fields["SpecialDesignStyle"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg1
		{
			get { return this.Fields["DescFlexField_PubDescSeg1"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg2
		{
			get { return this.Fields["DescFlexField_PubDescSeg2"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg3
		{
			get { return this.Fields["DescFlexField_PubDescSeg3"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg4
		{
			get { return this.Fields["DescFlexField_PubDescSeg4"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg5
		{
			get { return this.Fields["DescFlexField_PubDescSeg5"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg6
		{
			get { return this.Fields["DescFlexField_PubDescSeg6"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg7
		{
			get { return this.Fields["DescFlexField_PubDescSeg7"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg8
		{
			get { return this.Fields["DescFlexField_PubDescSeg8"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg9
		{
			get { return this.Fields["DescFlexField_PubDescSeg9"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg10
		{
			get { return this.Fields["DescFlexField_PubDescSeg10"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg11
		{
			get { return this.Fields["DescFlexField_PubDescSeg11"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg12
		{
			get { return this.Fields["DescFlexField_PubDescSeg12"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg13
		{
			get { return this.Fields["DescFlexField_PubDescSeg13"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg14
		{
			get { return this.Fields["DescFlexField_PubDescSeg14"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg15
		{
			get { return this.Fields["DescFlexField_PubDescSeg15"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg16
		{
			get { return this.Fields["DescFlexField_PubDescSeg16"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg17
		{
			get { return this.Fields["DescFlexField_PubDescSeg17"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg18
		{
			get { return this.Fields["DescFlexField_PubDescSeg18"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg19
		{
			get { return this.Fields["DescFlexField_PubDescSeg19"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg20
		{
			get { return this.Fields["DescFlexField_PubDescSeg20"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg21
		{
			get { return this.Fields["DescFlexField_PubDescSeg21"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg22
		{
			get { return this.Fields["DescFlexField_PubDescSeg22"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg23
		{
			get { return this.Fields["DescFlexField_PubDescSeg23"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg24
		{
			get { return this.Fields["DescFlexField_PubDescSeg24"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg25
		{
			get { return this.Fields["DescFlexField_PubDescSeg25"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg26
		{
			get { return this.Fields["DescFlexField_PubDescSeg26"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg27
		{
			get { return this.Fields["DescFlexField_PubDescSeg27"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg28
		{
			get { return this.Fields["DescFlexField_PubDescSeg28"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg29
		{
			get { return this.Fields["DescFlexField_PubDescSeg29"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg30
		{
			get { return this.Fields["DescFlexField_PubDescSeg30"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg31
		{
			get { return this.Fields["DescFlexField_PubDescSeg31"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg32
		{
			get { return this.Fields["DescFlexField_PubDescSeg32"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg33
		{
			get { return this.Fields["DescFlexField_PubDescSeg33"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg34
		{
			get { return this.Fields["DescFlexField_PubDescSeg34"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg35
		{
			get { return this.Fields["DescFlexField_PubDescSeg35"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg36
		{
			get { return this.Fields["DescFlexField_PubDescSeg36"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg37
		{
			get { return this.Fields["DescFlexField_PubDescSeg37"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg38
		{
			get { return this.Fields["DescFlexField_PubDescSeg38"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg39
		{
			get { return this.Fields["DescFlexField_PubDescSeg39"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg40
		{
			get { return this.Fields["DescFlexField_PubDescSeg40"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg41
		{
			get { return this.Fields["DescFlexField_PubDescSeg41"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg42
		{
			get { return this.Fields["DescFlexField_PubDescSeg42"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg43
		{
			get { return this.Fields["DescFlexField_PubDescSeg43"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg44
		{
			get { return this.Fields["DescFlexField_PubDescSeg44"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg45
		{
			get { return this.Fields["DescFlexField_PubDescSeg45"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg46
		{
			get { return this.Fields["DescFlexField_PubDescSeg46"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg47
		{
			get { return this.Fields["DescFlexField_PubDescSeg47"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg48
		{
			get { return this.Fields["DescFlexField_PubDescSeg48"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg49
		{
			get { return this.Fields["DescFlexField_PubDescSeg49"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg50
		{
			get { return this.Fields["DescFlexField_PubDescSeg50"]; }
		}
		public IUIField FieldDescFlexField_ContextValue
		{
			get { return this.Fields["DescFlexField_ContextValue"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg1
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg1"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg2
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg2"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg3
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg3"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg4
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg4"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg5
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg5"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg6
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg6"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg7
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg7"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg8
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg8"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg9
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg9"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg10
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg10"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg11
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg11"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg12
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg12"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg13
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg13"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg14
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg14"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg15
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg15"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg16
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg16"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg17
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg17"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg18
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg18"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg19
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg19"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg20
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg20"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg21
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg21"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg22
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg22"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg23
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg23"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg24
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg24"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg25
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg25"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg26
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg26"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg27
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg27"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg28
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg28"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg29
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg29"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg30
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg30"]; }
		}
		public IUIField FieldDescFlexField_CombineName
		{
			get { return this.Fields["DescFlexField_CombineName"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public SpecialApplyBEDefaultFilterFilter DefaultFilter
		{
			get { return (SpecialApplyBEDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","06368069-4511-4f9d-bd40-8f222da3586f");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","e569b7f7-c9f2-4c48-8b1f-2ed3f42baa83");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","02a72197-1f86-4ee0-b6be-d936316eb01b");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","15f9cdf4-e077-43ae-b3be-f54f939c9eec");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9101cb28-38f2-4b3c-b08b-ccf14d423436");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","c53373e9-6c60-4cf8-9766-ea8d302cf10b");
			UIModelRuntimeFactory.AddNewUIField(this,"AdvCode", typeof(String), true,"","System.String", "AdvCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","66114ed7-b79b-4834-86e9-455f5bacc91b");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Customer.Customer", "ApplyDept", true,true, false, "",false,(UIFieldType)4,"8508f308-9d66-4b1d-abf4-e28dab8e926d","5cf29749-aacc-456e-8ea0-6d0a4b87ed55");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept_Code", typeof(String), false,"","System.String", "ApplyDept.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e06dd9da-3c4c-4a8b-976e-c17ce74c543c");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDept_Name", typeof(String), true,"","System.String", "ApplyDept.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","122296a9-7492-4553-8e5e-b8933a01286f");
			UIModelRuntimeFactory.AddNewUIField(this,"Applier", typeof(String), true,"","System.String", "Applier", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5efaa630-1e81-4af4-971c-d629e1ca4e56");
			UIModelRuntimeFactory.AddNewUIField(this,"ApplyDate", typeof(DateTime), true,"","System.Date", "ApplyDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","49c1650a-603e-49eb-bcba-bfa153d185e7");
			UIModelRuntimeFactory.AddNewUIField(this,"Phone", typeof(String), true,"","System.String", "Phone", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8bd8d5c2-ce03-45b4-9b5f-f904c2b9c5ef");
			UIModelRuntimeFactory.AddNewUIField(this,"QQ", typeof(String), true,"","System.String", "QQ", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f0ba3c1d-9c5b-459d-adca-a882cf16c827");
			UIModelRuntimeFactory.AddNewUIField(this,"CustConterName", typeof(String), true,"","System.String", "CustConterName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","595c37ff-5e89-49bd-9872-59b63279bdcf");
			UIModelRuntimeFactory.AddNewUIField(this,"CustName", typeof(String), true,"","System.String", "CustName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f5d3e494-a29c-4a2c-aa2e-3e3cda78bdbd");
			UIModelRuntimeFactory.AddNewUIField(this,"CustPhone", typeof(String), true,"","System.String", "CustPhone", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","af55c1e1-e153-4c38-91e4-249a1b6b9e2d");
			UIModelRuntimeFactory.AddNewUIField(this,"CustAddress", typeof(String), true,"","System.String", "CustAddress", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fa2bcdbb-bfde-47c7-9a5b-f97d5a28c8a6");
			UIModelRuntimeFactory.AddNewUIField(this,"SpecialDesignStyle", typeof(Int32), true,"0","System.String", "SpecialDesignStyle", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c675c8f7-9c56-40e8-8797-224776233f3e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e01efbae-e85e-4a4f-bcba-418bc0a719f3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c11a9093-51e4-46a6-a233-015aa189273c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3c6d1fc3-2ff1-4dd4-a611-45bb899e87b7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","09527355-ebfc-4846-95b7-e0ca177b3cc4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c52579fb-3d28-42a2-ab78-feac7be2aaed");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","514baf4a-9b9a-4b56-af74-e0c8aac77fdb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4d1ee722-206d-4443-867e-391204d8ab99");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fad18523-e907-4ac0-9ac1-047da0547ddf");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","40477226-1b8d-40ad-bcd3-cfc686652b72");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","316ed585-9415-4f78-ac22-fdb01d829143");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6116af93-f913-44ce-9faa-77ab2afbf9f1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","58b1740e-839c-4f09-abf2-b0236ec8b7f9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","59bf652b-1c4a-46c0-b209-e2cbf80149e4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","670b1569-c9b4-4cf8-aa6e-a6da0003547e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","eb793b73-c10b-45ef-9deb-e59df31ae415");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3fe906ac-2186-46ae-94e4-807740328415");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","22e8703f-3030-4e04-9bbf-b61de99699e8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a303bc71-28e1-410c-89e0-bbba701993f0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","53527d69-cc89-4ed0-ac47-d15bc061ef6d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b7987aec-396e-4a00-a5ad-1e5d8730f494");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","01036df5-90a8-478d-9879-9f0b51da2d70");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ffee4817-428e-4163-be72-83ba00154062");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d7f1cfe7-f4d7-47f9-9b17-7b41761442d1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","96e9d2a9-3e90-4bcc-8819-13e76b50529f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","31fcc611-68f3-4875-a461-f03e99de67d8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6bef21ba-6678-4269-a003-380b172cc22e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fa8c72fd-1a84-4715-ad13-fafd54def82f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3a1c4638-ea32-4211-8ced-c337e4e74c21");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ca084246-af3e-42ee-af25-813a875de4f3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","619c95fa-7914-4566-bfaf-5a6c4390573d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg31", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","74f62204-2259-4c97-9c3a-30f7744e123b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg32", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2263ebdc-7494-477d-8485-10fb66462d87");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg33", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","84b2a75e-b0be-463c-b37c-5be0cf90450a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg34", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fbaee58c-c530-4b3a-b3ae-9fd4dea3dffb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg35", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bf86bb82-d28c-443d-a8e3-5a71e720237f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg36", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","99001f50-a197-4e84-a53d-195ba6057525");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg37", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8d0c86be-3968-42f2-8256-a3536d55a210");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg38", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","614dee43-03f6-4c11-82db-cd48632ae335");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg39", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b830a82d-7383-4395-929e-14c741bfde87");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg40", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fb260996-cdfb-46ce-8134-98f118336568");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg41", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","277d69cf-94e8-41ff-b2b9-022c17e72325");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg42", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fa33cf3d-60c3-4cc0-8fff-7e7d5f4a70d1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg43", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","024fdd5d-3730-4e97-af45-3dddd25a258e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg44", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4ce922e6-40ac-4067-a8cb-26c74e8b3649");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg45", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fe415c0f-5f0c-4864-b41a-f8acbd91544b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg46", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ce8c8f99-3b18-483c-a51b-edf2c7a217dc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg47", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0e4e0079-8b20-4420-8b6f-aa259d7036fa");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg48", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1df79b81-2ec7-4eab-9670-a71c5a661a6a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg49", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9b7a6bfc-8977-4288-ad67-2854e123c07a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg50", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e5b26d8d-e7ad-48e6-a03b-88961d146083");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_ContextValue", typeof(String), true,"","System.String", "DescFlexField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6ea80e13-e8b8-4b80-bac3-6d72f6d9b225");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","641baee4-d6e6-4381-9150-ec19973c1a56");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c91d28b6-dd23-4895-96b6-ebb23771cad9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6cc0f844-e8a6-4223-8eea-740d8999cc2f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","26313781-1a08-4b0a-b280-d2ef0acf8eb8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7dc94d1e-c22e-4976-bb51-ff20635f69a2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","466011c0-bb2b-4886-a13c-a72792b85f38");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9fc9b087-3867-447d-8901-7a96e61c2dfd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","31fead91-5940-4533-8411-c842abd89382");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","aa1a7c5f-fa2c-4f9a-820f-d8a2fcd1a9b6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e9db2ae0-320c-45f9-a2c6-a173cfa5b53e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a6b3cdb7-df02-4054-bef4-7502fcf78286");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bab4f1bc-88a9-484d-8bba-c0af6fd94057");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e2585731-feca-42d8-becd-50b83f83cfda");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a50908ed-f104-4747-a278-254b6795f034");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f694248d-96a6-46fb-9fb4-839dae86e73f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","41aa9257-c86d-41e0-ad3d-fa1b42080444");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","52059dd7-6ccf-4e26-97a8-992d968b1a22");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5f666259-4cd2-477c-b953-50637c191ae8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","15806283-7058-45f7-96e7-e87aad19d573");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0ff7ff81-8130-48b0-8f78-7154421d4828");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7bddb9a4-8341-4bb8-83ba-4a5fd678e63d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8875aecd-7a04-47bf-800b-c53fd0db98a2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c50c9bb5-94b4-4429-95aa-c032bbd2b60b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","28e1ef88-b5f9-496a-a6dc-bd2584b9eab4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bdbd0956-394f-44ce-89d4-4f17ada54fda");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ca0965d7-0a18-41ad-8754-f29517b3cdea");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7a681317-ec48-40e9-ab1a-3ecf6178ca9c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4af60cf3-1031-484a-a122-d2f7836631d5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","763668cc-80c4-45bb-b212-5f90b9e9b456");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6c2fe77d-76f9-4c68-bdbc-f45ad9b6e25a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_CombineName", typeof(String), true,"","System.String", "DescFlexField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0591b881-47fe-4ed7-a76d-c7c0386ed574");


			this.CurrentFilter = new SpecialApplyBEDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new SpecialApplyBERecord(builder);
		}
		#endregion

		#region new method
		public new SpecialApplyBERecord FocusedRecord
		{
			get { return (SpecialApplyBERecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new SpecialApplyBERecord AddNewUIRecord()
		{	
			return (SpecialApplyBERecord)base.AddNewUIRecord();
		}
		public new SpecialApplyBERecord NewUIRecord()
		{	
			return (SpecialApplyBERecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class SpecialApplyBERecord : UIRecord
	{
		#region Constructor
		public SpecialApplyBERecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private SpecialApplyBEView uiviewSpecialApplyBE
		{
			get { return (SpecialApplyBEView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new SpecialApplyBERecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewSpecialApplyBE.FieldID);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSpecialApplyBE.FieldCreatedOn);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldCreatedBy);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSpecialApplyBE.FieldModifiedOn);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldModifiedBy);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewSpecialApplyBE.FieldSysVersion);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldSysVersion] = value;
			}
		}
		
		
		public  String AdvCode
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldAdvCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldAdvCode);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldAdvCode] = value;
			}
		}
		
		
		public  Int64? ApplyDept
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldApplyDept] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewSpecialApplyBE.FieldApplyDept);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldApplyDept] = value;
			}
		}
		
		
		public  String ApplyDept_Code
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldApplyDept_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldApplyDept_Code);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldApplyDept_Code] = value;
			}
		}
		
		
		public  String ApplyDept_Name
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldApplyDept_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldApplyDept_Name);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldApplyDept_Name] = value;
			}
		}
		
		
		public  String Applier
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldApplier] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldApplier);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldApplier] = value;
			}
		}
		
		
		public  DateTime? ApplyDate
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldApplyDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSpecialApplyBE.FieldApplyDate);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldApplyDate] = value;
			}
		}
		
		
		public  String Phone
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldPhone] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldPhone);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldPhone] = value;
			}
		}
		
		
		public  String QQ
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldQQ] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldQQ);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldQQ] = value;
			}
		}
		
		
		public  String CustConterName
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldCustConterName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldCustConterName);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldCustConterName] = value;
			}
		}
		
		
		public  String CustName
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldCustName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldCustName);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldCustName] = value;
			}
		}
		
		
		public  String CustPhone
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldCustPhone] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldCustPhone);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldCustPhone] = value;
			}
		}
		
		
		public  String CustAddress
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldCustAddress] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldCustAddress);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldCustAddress] = value;
			}
		}
		
		
		public  Int32? SpecialDesignStyle
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldSpecialDesignStyle] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewSpecialApplyBE.FieldSpecialDesignStyle);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldSpecialDesignStyle] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg1
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg1);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg2
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg2);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg3
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg3);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg4
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg4);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg5
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg5);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg6
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg6);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg7
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg7);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg8
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg8);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg9
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg9);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg10
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg10);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg11
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg11);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg12
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg12);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg13
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg13);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg14
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg14);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg15
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg15);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg16
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg16);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg17
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg17);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg18
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg18);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg19
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg19);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg20
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg20);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg21
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg21);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg22
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg22);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg23
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg23);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg24
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg24);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg25
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg25);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg26
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg26);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg27
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg27);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg28
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg28);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg29
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg29);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg30
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg30);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg31
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg31] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg31);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg31] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg32
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg32] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg32);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg32] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg33
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg33] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg33);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg33] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg34
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg34] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg34);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg34] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg35
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg35] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg35);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg35] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg36
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg36] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg36);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg36] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg37
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg37] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg37);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg37] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg38
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg38] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg38);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg38] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg39
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg39] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg39);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg39] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg40
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg40] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg40);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg40] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg41
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg41] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg41);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg41] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg42
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg42] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg42);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg42] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg43
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg43] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg43);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg43] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg44
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg44] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg44);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg44] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg45
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg45] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg45);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg45] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg46
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg46] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg46);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg46] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg47
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg47] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg47);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg47] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg48
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg48] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg48);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg48] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg49
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg49] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg49);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg49] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg50
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg50] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg50);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PubDescSeg50] = value;
			}
		}
		
		
		public  String DescFlexField_ContextValue
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_ContextValue] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_ContextValue);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_ContextValue] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg1);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg2
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg2);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg3
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg3);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg4
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg4);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg5
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg5);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg6
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg6);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg7
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg7);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg8
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg8);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg9
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg9);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg10
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg10);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg11
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg11);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg12
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg12);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg13
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg13);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg14
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg14);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg15
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg15);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg16
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg16);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg17
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg17);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg18
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg18);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg19
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg19);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg20
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg20);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg21
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg21);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg22
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg22);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg23
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg23);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg24
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg24);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg25
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg25);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg26
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg26);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg27
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg27);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg28
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg28);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg29
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg29);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg30);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_PrivateDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_CombineName
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE.FieldDescFlexField_CombineName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE.FieldDescFlexField_CombineName);
			}
			set{
				this[this.uiviewSpecialApplyBE.FieldDescFlexField_CombineName] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class SpecialApplyBEDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public SpecialApplyBEDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private SpecialApplyBEDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new SpecialApplyBEDefaultFilterFilter();
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
	public partial class SpecialApplyBE_SpecialSizeBEView : UIView
	{
		#region Constructor
		public SpecialApplyBE_SpecialSizeBEView(IUIModel model) : base(model,"SpecialApplyBE_SpecialSizeBE","System.String", false)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private SpecialApplyBE_SpecialSizeBEView():base(null,"SpecialApplyBE_SpecialSizeBE","System.String", false)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new SpecialApplyBE_SpecialSizeBEView();
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
		public IUIField FieldSpecialApplyBE
		{
			get { return this.Fields["SpecialApplyBE"]; }
		}
		public IUIField FieldDisplayProductType
		{
			get { return this.Fields["DisplayProductType"]; }
		}
		public IUIField FieldWidth
		{
			get { return this.Fields["Width"]; }
		}
		public IUIField FieldHight
		{
			get { return this.Fields["Hight"]; }
		}
		public IUIField FieldThick
		{
			get { return this.Fields["Thick"]; }
		}
		public IUIField FieldQty
		{
			get { return this.Fields["Qty"]; }
		}
		public IUIField FieldArea
		{
			get { return this.Fields["Area"]; }
		}
		public IUIField FieldMemo
		{
			get { return this.Fields["Memo"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg1
		{
			get { return this.Fields["DescFlexField_PubDescSeg1"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg2
		{
			get { return this.Fields["DescFlexField_PubDescSeg2"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg3
		{
			get { return this.Fields["DescFlexField_PubDescSeg3"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg4
		{
			get { return this.Fields["DescFlexField_PubDescSeg4"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg5
		{
			get { return this.Fields["DescFlexField_PubDescSeg5"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg6
		{
			get { return this.Fields["DescFlexField_PubDescSeg6"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg7
		{
			get { return this.Fields["DescFlexField_PubDescSeg7"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg8
		{
			get { return this.Fields["DescFlexField_PubDescSeg8"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg9
		{
			get { return this.Fields["DescFlexField_PubDescSeg9"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg10
		{
			get { return this.Fields["DescFlexField_PubDescSeg10"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg11
		{
			get { return this.Fields["DescFlexField_PubDescSeg11"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg12
		{
			get { return this.Fields["DescFlexField_PubDescSeg12"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg13
		{
			get { return this.Fields["DescFlexField_PubDescSeg13"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg14
		{
			get { return this.Fields["DescFlexField_PubDescSeg14"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg15
		{
			get { return this.Fields["DescFlexField_PubDescSeg15"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg16
		{
			get { return this.Fields["DescFlexField_PubDescSeg16"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg17
		{
			get { return this.Fields["DescFlexField_PubDescSeg17"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg18
		{
			get { return this.Fields["DescFlexField_PubDescSeg18"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg19
		{
			get { return this.Fields["DescFlexField_PubDescSeg19"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg20
		{
			get { return this.Fields["DescFlexField_PubDescSeg20"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg21
		{
			get { return this.Fields["DescFlexField_PubDescSeg21"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg22
		{
			get { return this.Fields["DescFlexField_PubDescSeg22"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg23
		{
			get { return this.Fields["DescFlexField_PubDescSeg23"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg24
		{
			get { return this.Fields["DescFlexField_PubDescSeg24"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg25
		{
			get { return this.Fields["DescFlexField_PubDescSeg25"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg26
		{
			get { return this.Fields["DescFlexField_PubDescSeg26"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg27
		{
			get { return this.Fields["DescFlexField_PubDescSeg27"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg28
		{
			get { return this.Fields["DescFlexField_PubDescSeg28"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg29
		{
			get { return this.Fields["DescFlexField_PubDescSeg29"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg30
		{
			get { return this.Fields["DescFlexField_PubDescSeg30"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg31
		{
			get { return this.Fields["DescFlexField_PubDescSeg31"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg32
		{
			get { return this.Fields["DescFlexField_PubDescSeg32"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg33
		{
			get { return this.Fields["DescFlexField_PubDescSeg33"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg34
		{
			get { return this.Fields["DescFlexField_PubDescSeg34"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg35
		{
			get { return this.Fields["DescFlexField_PubDescSeg35"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg36
		{
			get { return this.Fields["DescFlexField_PubDescSeg36"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg37
		{
			get { return this.Fields["DescFlexField_PubDescSeg37"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg38
		{
			get { return this.Fields["DescFlexField_PubDescSeg38"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg39
		{
			get { return this.Fields["DescFlexField_PubDescSeg39"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg40
		{
			get { return this.Fields["DescFlexField_PubDescSeg40"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg41
		{
			get { return this.Fields["DescFlexField_PubDescSeg41"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg42
		{
			get { return this.Fields["DescFlexField_PubDescSeg42"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg43
		{
			get { return this.Fields["DescFlexField_PubDescSeg43"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg44
		{
			get { return this.Fields["DescFlexField_PubDescSeg44"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg45
		{
			get { return this.Fields["DescFlexField_PubDescSeg45"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg46
		{
			get { return this.Fields["DescFlexField_PubDescSeg46"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg47
		{
			get { return this.Fields["DescFlexField_PubDescSeg47"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg48
		{
			get { return this.Fields["DescFlexField_PubDescSeg48"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg49
		{
			get { return this.Fields["DescFlexField_PubDescSeg49"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg50
		{
			get { return this.Fields["DescFlexField_PubDescSeg50"]; }
		}
		public IUIField FieldDescFlexField_ContextValue
		{
			get { return this.Fields["DescFlexField_ContextValue"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg1
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg1"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg2
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg2"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg3
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg3"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg4
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg4"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg5
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg5"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg6
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg6"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg7
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg7"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg8
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg8"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg9
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg9"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg10
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg10"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg11
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg11"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg12
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg12"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg13
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg13"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg14
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg14"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg15
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg15"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg16
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg16"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg17
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg17"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg18
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg18"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg19
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg19"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg20
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg20"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg21
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg21"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg22
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg22"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg23
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg23"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg24
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg24"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg25
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg25"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg26
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg26"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg27
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg27"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg28
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg28"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg29
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg29"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg30
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg30"]; }
		}
		public IUIField FieldDescFlexField_CombineName
		{
			get { return this.Fields["DescFlexField_CombineName"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public SpecialApplyBE_SpecialSizeBEDefaultFilterFilter DefaultFilter
		{
			get { return (SpecialApplyBE_SpecialSizeBEDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.String", "ID", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5d43dab0-d67e-42a6-980c-d8cbcf65fcab");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.String", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c3fe70a2-c6de-4139-bf0a-db6c313c3763");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0ecb6e1b-3b7f-478b-91ad-7d49f04bc669");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.String", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8f3f8778-f47d-4938-b8f8-26ba8101444b");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","941b9dd8-4a95-4908-b562-728a6f5c9f86");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.String", "SysVersion", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","655a9e25-fa07-4b51-bc62-97917a0a4e1f");
			UIModelRuntimeFactory.AddNewUIField(this,"SpecialApplyBE", typeof(Int64), true,"","System.String", "SpecialApplyBE", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d38569a7-3f98-41c2-a133-204dfaef8f98");
			UIModelRuntimeFactory.AddNewUIField(this,"DisplayProductType", typeof(String), true,"","System.String", "DisplayProductType", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","741bc932-1bb4-477a-8759-2c7e5d175c13");
			UIModelRuntimeFactory.AddNewUIField(this,"Width", typeof(Decimal), true,"0","System.String", "Width", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3ce03126-0912-4492-9fbf-0701d4ba5f31");
			UIModelRuntimeFactory.AddNewUIField(this,"Hight", typeof(Decimal), true,"0","System.String", "Hight", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","14fe6f02-0761-4213-a3f1-0a40a576bfcf");
			UIModelRuntimeFactory.AddNewUIField(this,"Thick", typeof(Decimal), true,"0","System.String", "Thick", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","918ec36d-4d3e-472c-8c0d-169b1ebf1970");
			UIModelRuntimeFactory.AddNewUIField(this,"Qty", typeof(Decimal), true,"0","System.String", "Qty", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5019383f-1764-4204-8ce1-dd62722a127a");
			UIModelRuntimeFactory.AddNewUIField(this,"Area", typeof(Decimal), true,"0","System.String", "Area", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3d84e584-9b4f-4ba3-913a-eab83e8666a7");
			UIModelRuntimeFactory.AddNewUIField(this,"Memo", typeof(String), true,"","System.String", "Memo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","631cfbc8-e966-4e11-bd48-3aa8fdf20b7d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d82c5704-da36-453e-875b-8ce9a5a72193");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cfbdeb60-e4e1-48b3-ba3c-b8a97a35c5e5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d830e6f0-f9e2-4ba1-a155-c6880c014919");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a2bd8a36-16ed-45fd-b292-51423669a2ef");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","58502d96-dcb4-40d1-b913-ad846c52562d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2a9a061b-d6a9-44d5-b126-c6d5f230687e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c15fddf3-41ab-4744-8cd3-2920dbf86fb8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","86659199-40dc-4cfa-a008-d2a76da88e47");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","04eac0d4-28cd-4e8e-a48c-28c59c5036a8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","86144089-1fff-4682-9843-9f89c8344c34");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6d03c7c0-aab9-48e1-ab9e-ab5a308a583a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2379acc2-96d3-4796-beb2-986dac1ae6d5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a2910279-7b41-4cfd-a156-b9d68369d64f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","16e55285-0126-4071-b529-5ec061842742");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","18f3746c-653a-4f07-931f-21f80c8f18d8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b4850cb7-b366-45e0-854b-1050d91a30f2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","83b8281a-6623-4995-b42d-d119a13d98b4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d73e85c9-4ba6-4404-9f5b-9bdd03328cf0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ab52748e-772d-40f3-a6e8-b016e7628c2b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ca1f2421-2b07-403e-bc6a-c7a771506b0a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fd9a6f90-f18c-4336-bb67-2c2105ce47ee");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a9d7a7fd-7fdb-4f94-8b1f-81cea1f79eca");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","52048312-be07-45d1-9401-77718d2db012");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","09ccb10b-ff8f-4e8f-9cbe-c396c070dacd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e57464e8-2bac-4ba0-9703-dc0bb648ed5a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","404d0dab-5b2c-4127-8d41-38167e9d0203");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7fa84aa9-0588-45a5-bf47-763023efa8d2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","de06f22e-951f-4102-85a2-9cc0b6e347b9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","800313e1-2d76-4afc-9c44-c17e08134312");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","85b2e139-4c9c-4160-bd89-c1823d0c3f57");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg31", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2d1b3e74-b570-4efc-952d-9c0c7caf48af");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg32", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ad7d3af8-d71d-46fb-956b-9c66d7d27b09");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg33", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","34783b2e-e0be-4228-a119-158d6c222675");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg34", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","16a0f447-a618-46f4-aa0f-7c16642c8fcc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg35", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bfdf299c-34df-4366-bdd0-e791cd31fb18");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg36", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b9555fac-6bd1-4230-825b-4fa33c22d226");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg37", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","58051d13-53cd-40dd-8b72-a37c0d4eb375");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg38", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","baad91b6-a066-4cc1-a79f-49a341880582");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg39", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7a3acf1b-0889-4e5d-9fb3-8e642029bd25");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg40", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ae783d61-82ed-429c-9e25-01a6bfab47c3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg41", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","61a64af7-d4fa-4bb8-851f-8135647ed8dd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg42", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","91905edf-43ff-4c03-9d2d-75824e17e797");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg43", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f6ed923b-76f4-42d0-b924-706f2db2a176");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg44", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","44283133-443c-4965-b0f2-2d2cbf247d51");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg45", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e4a47527-1da2-4970-ae25-d6024c1f85be");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg46", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3c466e71-3d16-4a8b-ac29-05c1cc9194de");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg47", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d0b81aeb-6cb7-4303-80d3-f6799f2bcda0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg48", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e060dc6e-f236-4453-9ca8-40b7fa89315a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg49", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4632cf97-c3f5-4621-9603-b1169977ae54");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg50", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ce5686db-0bdc-44f7-8318-4851e9967318");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_ContextValue", typeof(String), true,"","System.String", "DescFlexField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3b9862ba-9248-4530-a2bd-9f1e96c0e218");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","08821fb3-167b-4d5d-9516-2580344eb787");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","165441c9-9461-49d3-9315-f398262c8714");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a2609835-8c5a-4809-a3a8-cb816e04a458");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0bd7cbeb-4d50-4c0e-8cd6-dbcbec3b80fb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","61513d9d-23a3-434e-87a8-9bcd3de42cee");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1343e81c-858c-4ddb-b70e-c65742b1bd9c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cf74fbe7-8e65-4e87-a73a-2a1f57313d32");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9ea3111e-0c8d-47aa-8755-1df46ece0535");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ea07ba5f-9f89-4b6a-91f1-a625d0927557");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","960b269a-f884-4c80-8f91-36c64640e62c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","172dfbad-450c-4607-9a48-cc31bf9eb0e8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5526ecf2-c4d6-40c9-94bf-ce85a7763a15");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7ac75c72-ece4-4f54-abc3-806eeeb24eb0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7e19ac2a-fb7e-49e5-8a09-04737a6fcdf9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5a44b6d1-0cc3-4887-8e0c-b24045323573");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2f8a2dcd-677d-4ee4-9fbb-dfc14f9042cf");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4f9e5c75-f738-4139-bd2b-9e7eb65f2d37");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e4125a00-a83c-4460-82b6-fd1cde28f911");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d4a183b1-57ea-46ea-8d80-97a9536992b1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b22325a8-8024-4653-a780-2d77ba04fd98");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cc7ab943-cac7-4c55-8019-13f06150c698");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9a718854-4881-4bff-b820-92162746b591");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a381fc65-849b-4828-a740-e130dec9a762");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d44ced8a-dc75-49f9-981b-a7ecba4baea5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0b9b9b73-656f-4f89-a1ab-2d78b5cb58c7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","24692ae4-f7c2-428f-9dd9-cdc49d08dc33");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2cc6011e-9d27-4b9e-be11-80904a29bdcb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","21cd05f3-dd23-4937-b3d8-bc861f007fa4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8223829d-49f4-4600-b13c-36db630c13b6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a6efef93-4fdd-410d-b238-7dda09c4d8de");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_CombineName", typeof(String), true,"","System.String", "DescFlexField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5e4c2ed3-831c-4751-8083-f90face3be2b");


			this.CurrentFilter = new SpecialApplyBE_SpecialSizeBEDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new SpecialApplyBE_SpecialSizeBERecord(builder);
		}
		#endregion

		#region new method
		public new SpecialApplyBE_SpecialSizeBERecord FocusedRecord
		{
			get { return (SpecialApplyBE_SpecialSizeBERecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new SpecialApplyBE_SpecialSizeBERecord AddNewUIRecord()
		{	
			return (SpecialApplyBE_SpecialSizeBERecord)base.AddNewUIRecord();
		}
		public new SpecialApplyBE_SpecialSizeBERecord NewUIRecord()
		{	
			return (SpecialApplyBE_SpecialSizeBERecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class SpecialApplyBE_SpecialSizeBERecord : UIRecord
	{
		#region Constructor
		public SpecialApplyBE_SpecialSizeBERecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private SpecialApplyBE_SpecialSizeBEView uiviewSpecialApplyBE_SpecialSizeBE
		{
			get { return (SpecialApplyBE_SpecialSizeBEView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new SpecialApplyBE_SpecialSizeBERecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldID);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldCreatedOn);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldCreatedBy);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldModifiedOn);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldModifiedBy);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldSysVersion);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? SpecialApplyBE
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldSpecialApplyBE] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldSpecialApplyBE);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldSpecialApplyBE] = value;
			}
		}
		
		
		public  String DisplayProductType
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDisplayProductType] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDisplayProductType);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDisplayProductType] = value;
			}
		}
		
		
		public  Decimal? Width
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldWidth] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldWidth);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldWidth] = value;
			}
		}
		
		
		public  Decimal? Hight
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldHight] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldHight);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldHight] = value;
			}
		}
		
		
		public  Decimal? Thick
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldThick] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldThick);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldThick] = value;
			}
		}
		
		
		public  Decimal? Qty
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldQty);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldQty] = value;
			}
		}
		
		
		public  Decimal? Area
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldArea] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldArea);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldArea] = value;
			}
		}
		
		
		public  String Memo
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldMemo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldMemo);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldMemo] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg1
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg1);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg2
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg2);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg3
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg3);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg4
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg4);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg5
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg5);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg6
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg6);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg7
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg7);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg8
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg8);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg9
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg9);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg10
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg10);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg11
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg11);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg12
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg12);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg13
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg13);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg14
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg14);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg15
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg15);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg16
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg16);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg17
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg17);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg18
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg18);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg19
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg19);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg20
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg20);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg21
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg21);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg22
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg22);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg23
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg23);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg24
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg24);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg25
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg25);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg26
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg26);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg27
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg27);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg28
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg28);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg29
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg29);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg30
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg30);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg31
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg31] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg31);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg31] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg32
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg32] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg32);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg32] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg33
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg33] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg33);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg33] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg34
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg34] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg34);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg34] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg35
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg35] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg35);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg35] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg36
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg36] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg36);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg36] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg37
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg37] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg37);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg37] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg38
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg38] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg38);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg38] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg39
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg39] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg39);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg39] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg40
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg40] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg40);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg40] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg41
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg41] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg41);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg41] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg42
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg42] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg42);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg42] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg43
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg43] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg43);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg43] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg44
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg44] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg44);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg44] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg45
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg45] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg45);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg45] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg46
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg46] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg46);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg46] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg47
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg47] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg47);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg47] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg48
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg48] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg48);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg48] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg49
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg49] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg49);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg49] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg50
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg50] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg50);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PubDescSeg50] = value;
			}
		}
		
		
		public  String DescFlexField_ContextValue
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_ContextValue] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_ContextValue);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_ContextValue] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg1);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg2
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg2);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg3
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg3);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg4
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg4);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg5
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg5);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg6
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg6);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg7
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg7);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg8
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg8);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg9
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg9);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg10
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg10);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg11
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg11);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg12
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg12);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg13
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg13);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg14
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg14);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg15
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg15);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg16
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg16);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg17
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg17);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg18
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg18);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg19
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg19);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg20
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg20);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg21
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg21);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg22
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg22);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg23
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg23);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg24
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg24);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg25
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg25);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg26
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg26);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg27
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg27);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg28
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg28);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg29
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg29);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg30);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_PrivateDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_CombineName
		{
			get{
				//object value = this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_CombineName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_CombineName);
			}
			set{
				this[this.uiviewSpecialApplyBE_SpecialSizeBE.FieldDescFlexField_CombineName] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class SpecialApplyBE_SpecialSizeBEDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public SpecialApplyBE_SpecialSizeBEDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private SpecialApplyBE_SpecialSizeBEDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new SpecialApplyBE_SpecialSizeBEDefaultFilterFilter();
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