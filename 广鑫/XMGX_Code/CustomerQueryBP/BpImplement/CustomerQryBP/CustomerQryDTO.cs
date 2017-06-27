


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.CustomerQryBP
{
	/// <summary>
	/// CustomerQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class CustomerQryDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public CustomerQryDTO(){
			initData();
		}
		private void initData()
		{
					ID = 0; 
					Customer_ID = 0; 
		
		
		
		
		
		
		
		
					AROCMoneyBalance_TotalMoney = 0m; 
					LastSOTotalMoneyTC = 0m; 
					LastRecBillTotalMoney = 0m; 
		
		
		
					Customer_TradeCurrency_MoneyRound_RoundType =UFIDA.U9.Base.PropertyTypes.RoundTypeEnum.GetFromValue(0); 
					Customer_TradeCurrency_MoneyRound_RoundValue = 0; 
		
		
		
		
					Customer_TradeCurrency_MoneyRound_Precision = 0; 
					ObjectCreditLevelApproval_CreditLimit = 0m; 
					SumBalanceTotalMoney = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// CustomerQryDTO.Misc.ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 ID
		{
			get	
			{	
				return (System.Int64)base.GetValue("ID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("ID",value);
			}
		}
				/// <summary>
		/// ID (该属性不可为空,但有默认值)
		/// CustomerQryDTO.Misc.ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 Customer_ID
		{
			get	
			{	
				return (System.Int64)base.GetValue("Customer_ID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("Customer_ID",value);
			}
		}
				/// <summary>
		/// 编码 (该属性不可为空,且无默认值)
		/// CustomerQryDTO.Misc.编码
		/// </summary>
		/// <value>System.String</value>
		public System.String Customer_Code
		{
			get	
			{	
				return (System.String)base.GetValue("Customer_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Customer_Code",value);
			}
		}
		 
				/// <summary>
		/// 联系人 (该属性不可为空,且无默认值)
		/// CustomerQryDTO.Misc.联系人
		/// </summary>
		/// <value>UFIDA.U9.Base.Contact.Contact</value>
		public UFIDA.U9.Base.Contact.Contact.EntityKey CustomerContact_Contact
		{
			get	
			{	
				return (UFIDA.U9.Base.Contact.Contact.EntityKey)base.GetValue("CustomerContact_Contact",typeof(UFIDA.U9.Base.Contact.Contact.EntityKey));
			}

			 set	
			{
				base.SetValue("CustomerContact_Contact",value);
			}
		}
				/// <summary>
		/// 手机 (该属性可为空,且无默认值)
		/// CustomerQryDTO.Misc.手机
		/// </summary>
		/// <value>System.String</value>
		public System.String CustomerContact_Contact_DefaultMobilNum
		{
			get	
			{	
				return (System.String)base.GetValue("CustomerContact_Contact_DefaultMobilNum",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CustomerContact_Contact_DefaultMobilNum",value);
			}
		}
				/// <summary>
		/// 电话 (该属性可为空,且无默认值)
		/// CustomerQryDTO.Misc.电话
		/// </summary>
		/// <value>System.String</value>
		public System.String CustomerContact_Contact_DefaultPhoneNum
		{
			get	
			{	
				return (System.String)base.GetValue("CustomerContact_Contact_DefaultPhoneNum",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CustomerContact_Contact_DefaultPhoneNum",value);
			}
		}
				/// <summary>
		/// 客户分类 (该属性可为空,且无默认值)
		/// CustomerQryDTO.Misc.客户分类
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Customer.CustomerCategory</value>
		public UFIDA.U9.CBO.SCM.Customer.CustomerCategory.EntityKey Customer_CustomerCategory
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Customer.CustomerCategory.EntityKey)base.GetValue("Customer_CustomerCategory",typeof(UFIDA.U9.CBO.SCM.Customer.CustomerCategory.EntityKey));
			}

			 set	
			{
				base.SetValue("Customer_CustomerCategory",value);
			}
		}
				/// <summary>
		/// 业务员 (该属性可为空,且无默认值)
		/// CustomerQryDTO.Misc.业务员
		/// </summary>
		/// <value>UFIDA.U9.CBO.HR.Operator.Operators</value>
		public UFIDA.U9.CBO.HR.Operator.Operators.EntityKey Customer_Saleser
		{
			get	
			{	
				return (UFIDA.U9.CBO.HR.Operator.Operators.EntityKey)base.GetValue("Customer_Saleser",typeof(UFIDA.U9.CBO.HR.Operator.Operators.EntityKey));
			}

			 set	
			{
				base.SetValue("Customer_Saleser",value);
			}
		}
				/// <summary>
		/// 传真 (该属性可为空,且无默认值)
		/// CustomerQryDTO.Misc.传真
		/// </summary>
		/// <value>System.String</value>
		public System.String CustomerContact_Contact_DefaultFaxNum
		{
			get	
			{	
				return (System.String)base.GetValue("CustomerContact_Contact_DefaultFaxNum",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CustomerContact_Contact_DefaultFaxNum",value);
			}
		}
				/// <summary>
		/// 实际应收 (该属性可为空,但有默认值)
		/// CustomerQryDTO.Misc.实际应收
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal AROCMoneyBalance_TotalMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("AROCMoneyBalance_TotalMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("AROCMoneyBalance_TotalMoney",value);
			}
		}
				/// <summary>
		/// 最后交易额 (该属性可为空,但有默认值)
		/// CustomerQryDTO.Misc.最后交易额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal LastSOTotalMoneyTC
		{
			get	
			{	
				return (System.Decimal)base.GetValue("LastSOTotalMoneyTC",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("LastSOTotalMoneyTC",value);
			}
		}
				/// <summary>
		/// 最近一笔收款金额 (该属性可为空,但有默认值)
		/// CustomerQryDTO.Misc.最近一笔收款金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal LastRecBillTotalMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("LastRecBillTotalMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("LastRecBillTotalMoney",value);
			}
		}
				/// <summary>
		/// 国税号 (该属性可为空,且无默认值)
		/// CustomerQryDTO.Misc.国税号
		/// </summary>
		/// <value>System.String</value>
		public System.String Customer_StateTaxNo
		{
			get	
			{	
				return (System.String)base.GetValue("Customer_StateTaxNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Customer_StateTaxNo",value);
			}
		}
				/// <summary>
		/// 开户银行 (该属性不可为空,且无默认值)
		/// CustomerQryDTO.Misc.开户银行
		/// </summary>
		/// <value>System.String</value>
		public System.String CustomerBankAccount_Code
		{
			get	
			{	
				return (System.String)base.GetValue("CustomerBankAccount_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CustomerBankAccount_Code",value);
			}
		}
		 
				/// <summary>
		/// 客户_交易币种_金额精度_舍入类型 (该属性不可为空,但有默认值)
		/// CustomerQryDTO.Misc.客户_交易币种_金额精度_舍入类型
		/// </summary>
		/// <value>UFIDA.U9.Base.PropertyTypes.RoundTypeEnum</value>
		public UFIDA.U9.Base.PropertyTypes.RoundTypeEnum Customer_TradeCurrency_MoneyRound_RoundType
		{
			get	
			{	
				return (UFIDA.U9.Base.PropertyTypes.RoundTypeEnum)base.GetValue("Customer_TradeCurrency_MoneyRound_RoundType",typeof(UFIDA.U9.Base.PropertyTypes.RoundTypeEnum));
			}

			 set	
			{
				base.SetValue("Customer_TradeCurrency_MoneyRound_RoundType",value);
			}
		}
				/// <summary>
		/// 客户_交易币种_金额精度_舍入值 (该属性可为空,但有默认值)
		/// CustomerQryDTO.Misc.客户_交易币种_金额精度_舍入值
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 Customer_TradeCurrency_MoneyRound_RoundValue
		{
			get	
			{	
				return (System.Int32)base.GetValue("Customer_TradeCurrency_MoneyRound_RoundValue",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("Customer_TradeCurrency_MoneyRound_RoundValue",value);
			}
		}
		 
		 
		 
		 
				/// <summary>
		/// 客户_交易币种_金额精度_精度 (该属性不可为空,但有默认值)
		/// CustomerQryDTO.Misc.客户_交易币种_金额精度_精度
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 Customer_TradeCurrency_MoneyRound_Precision
		{
			get	
			{	
				return (System.Int32)base.GetValue("Customer_TradeCurrency_MoneyRound_Precision",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("Customer_TradeCurrency_MoneyRound_Precision",value);
			}
		}
				/// <summary>
		/// 信用额度 (该属性可为空,但有默认值)
		/// CustomerQryDTO.Misc.信用额度
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ObjectCreditLevelApproval_CreditLimit
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ObjectCreditLevelApproval_CreditLimit",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ObjectCreditLevelApproval_CreditLimit",value);
			}
		}
				/// <summary>
		/// 合计实际应收金额 (该属性可为空,但有默认值)
		/// CustomerQryDTO.Misc.合计实际应收金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal SumBalanceTotalMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("SumBalanceTotalMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("SumBalanceTotalMoney",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
				 
		/// <summary>
		/// 名称
		/// CustomerQryDTO.Misc.名称
		/// </summary>
		public string Customer_Name
		{
			get
			{
				return base.GetMultiLangProp("Customer_Name");
			}
			set
			{
				base.SetMultiLangProp("Customer_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_Customer_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Customer_Name
		{
			get
			{
				return base.GetMultiLangPropDict("Customer_Name");
			}
			set
			{
				base.SetMultiLangPropDict("Customer_Name",value);	
			}
		}
												 
		/// <summary>
		/// 描述
		/// CustomerQryDTO.Misc.描述
		/// </summary>
		public string Customer_Description
		{
			get
			{
				return base.GetMultiLangProp("Customer_Description");
			}
			set
			{
				base.SetMultiLangProp("Customer_Description",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_Customer_Description ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Customer_Description
		{
			get
			{
				return base.GetMultiLangPropDict("Customer_Description");
			}
			set
			{
				base.SetMultiLangPropDict("Customer_Description",value);	
			}
		}
			 
		/// <summary>
		/// 名称
		/// CustomerQryDTO.Misc.名称
		/// </summary>
		public string Customer_Saleser_Name
		{
			get
			{
				return base.GetMultiLangProp("Customer_Saleser_Name");
			}
			set
			{
				base.SetMultiLangProp("Customer_Saleser_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_Customer_Saleser_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Customer_Saleser_Name
		{
			get
			{
				return base.GetMultiLangPropDict("Customer_Saleser_Name");
			}
			set
			{
				base.SetMultiLangPropDict("Customer_Saleser_Name",value);	
			}
		}
	 
		/// <summary>
		/// 名称
		/// CustomerQryDTO.Misc.名称
		/// </summary>
		public string CustomerContact_Contact_Name
		{
			get
			{
				return base.GetMultiLangProp("CustomerContact_Contact_Name");
			}
			set
			{
				base.SetMultiLangProp("CustomerContact_Contact_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_CustomerContact_Contact_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_CustomerContact_Contact_Name
		{
			get
			{
				return base.GetMultiLangPropDict("CustomerContact_Contact_Name");
			}
			set
			{
				base.SetMultiLangPropDict("CustomerContact_Contact_Name",value);	
			}
		}
	 
		/// <summary>
		/// 名称
		/// CustomerQryDTO.Misc.名称
		/// </summary>
		public string Customer_CustomerCategory_Name
		{
			get
			{
				return base.GetMultiLangProp("Customer_CustomerCategory_Name");
			}
			set
			{
				base.SetMultiLangProp("Customer_CustomerCategory_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_Customer_CustomerCategory_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Customer_CustomerCategory_Name
		{
			get
			{
				return base.GetMultiLangPropDict("Customer_CustomerCategory_Name");
			}
			set
			{
				base.SetMultiLangPropDict("Customer_CustomerCategory_Name",value);	
			}
		}
	 
		/// <summary>
		/// 名称
		/// CustomerQryDTO.Misc.名称
		/// </summary>
		public string Customer_OfficialLocation_Name
		{
			get
			{
				return base.GetMultiLangProp("Customer_OfficialLocation_Name");
			}
			set
			{
				base.SetMultiLangProp("Customer_OfficialLocation_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_Customer_OfficialLocation_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Customer_OfficialLocation_Name
		{
			get
			{
				return base.GetMultiLangPropDict("Customer_OfficialLocation_Name");
			}
			set
			{
				base.SetMultiLangPropDict("Customer_OfficialLocation_Name",value);	
			}
		}
			
		#endregion 
		#region  QuaryDTO Add Prop
		private int m_recordCount ;
		public int  RecordCount 
		{
			get {return m_recordCount ;}
			set { m_recordCount = value ;}
		}
		#endregion 

		#region ModelResource
		/// <summary>
		/// CustomerQryDTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_ID　{ get { return "";　}　}
		/// <summary>
		/// 编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_Code　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_Name　{ get { return "";　}　}
		/// <summary>
		/// 联系人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerContact_Contact　{ get { return "";　}　}
		/// <summary>
		/// 手机的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerContact_Contact_DefaultMobilNum　{ get { return "";　}　}
		/// <summary>
		/// 电话的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerContact_Contact_DefaultPhoneNum　{ get { return "";　}　}
		/// <summary>
		/// 客户分类的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_CustomerCategory　{ get { return "";　}　}
		/// <summary>
		/// 业务员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_Saleser　{ get { return "";　}　}
		/// <summary>
		/// 传真的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerContact_Contact_DefaultFaxNum　{ get { return "";　}　}
		/// <summary>
		/// 实际应收的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AROCMoneyBalance_TotalMoney　{ get { return "";　}　}
		/// <summary>
		/// 最后交易额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_LastSOTotalMoneyTC　{ get { return "";　}　}
		/// <summary>
		/// 最近一笔收款金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_LastRecBillTotalMoney　{ get { return "";　}　}
		/// <summary>
		/// 国税号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_StateTaxNo　{ get { return "";　}　}
		/// <summary>
		/// 开户银行的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerBankAccount_Code　{ get { return "";　}　}
		/// <summary>
		/// 描述的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_Description　{ get { return "";　}　}
		/// <summary>
		/// 客户_交易币种_金额精度_舍入类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_TradeCurrency_MoneyRound_RoundType　{ get { return "";　}　}
		/// <summary>
		/// 客户_交易币种_金额精度_舍入值的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_TradeCurrency_MoneyRound_RoundValue　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_Saleser_Name　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerContact_Contact_Name　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_CustomerCategory_Name　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_OfficialLocation_Name　{ get { return "";　}　}
		/// <summary>
		/// 客户_交易币种_金额精度_精度的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_TradeCurrency_MoneyRound_Precision　{ get { return "";　}　}
		/// <summary>
		/// 信用额度的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ObjectCreditLevelApproval_CreditLimit　{ get { return "";　}　}
		/// <summary>
		/// 合计实际应收金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SumBalanceTotalMoney　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(CustomerQryDTOData data)
		{
		




			if (data.CustomerContact_Contact == -1 && data.CustomerContact_Contact_SKey!=null)
				data.CustomerContact_Contact = data.CustomerContact_Contact_SKey.GetEntity().ID ;



			if (data.Customer_CustomerCategory == -1 && data.Customer_CustomerCategory_SKey!=null)
				data.Customer_CustomerCategory = data.Customer_CustomerCategory_SKey.GetEntity().ID ;

			if (data.Customer_Saleser == -1 && data.Customer_Saleser_SKey!=null)
				data.Customer_Saleser = data.Customer_Saleser_SKey.GetEntity().ID ;

















		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(CustomerQryDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CustomerQryDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
			this.RecordCount = data.RecordCount ;
		
			this.ID = data.ID;

			this.Customer_ID = data.Customer_ID;

			this.Customer_Code = data.Customer_Code;

			this.Customer_Name = data.Customer_Name;
			this.Multi_Customer_Name = data.Multi_Customer_Name ;

			{
				if (data.CustomerContact_Contact <= 0)
					this.CustomerContact_Contact = null ;
				else
					this.CustomerContact_Contact = new UFIDA.U9.Base.Contact.Contact.EntityKey(data.CustomerContact_Contact);
			}

			this.CustomerContact_Contact_DefaultMobilNum = data.CustomerContact_Contact_DefaultMobilNum;

			this.CustomerContact_Contact_DefaultPhoneNum = data.CustomerContact_Contact_DefaultPhoneNum;

			{
				if (data.Customer_CustomerCategory <= 0)
					this.Customer_CustomerCategory = null ;
				else
					this.Customer_CustomerCategory = new UFIDA.U9.CBO.SCM.Customer.CustomerCategory.EntityKey(data.Customer_CustomerCategory);
			}

			{
				if (data.Customer_Saleser <= 0)
					this.Customer_Saleser = null ;
				else
					this.Customer_Saleser = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(data.Customer_Saleser);
			}

			this.CustomerContact_Contact_DefaultFaxNum = data.CustomerContact_Contact_DefaultFaxNum;

			this.AROCMoneyBalance_TotalMoney = data.AROCMoneyBalance_TotalMoney;

			this.LastSOTotalMoneyTC = data.LastSOTotalMoneyTC;

			this.LastRecBillTotalMoney = data.LastRecBillTotalMoney;

			this.Customer_StateTaxNo = data.Customer_StateTaxNo;

			this.CustomerBankAccount_Code = data.CustomerBankAccount_Code;

			this.Customer_Description = data.Customer_Description;
			this.Multi_Customer_Description = data.Multi_Customer_Description ;

			this.Customer_TradeCurrency_MoneyRound_RoundType = UFIDA.U9.Base.PropertyTypes.RoundTypeEnum.GetFromValue(data.Customer_TradeCurrency_MoneyRound_RoundType);

			this.Customer_TradeCurrency_MoneyRound_RoundValue = data.Customer_TradeCurrency_MoneyRound_RoundValue;

			this.Customer_Saleser_Name = data.Customer_Saleser_Name;
			this.Multi_Customer_Saleser_Name = data.Multi_Customer_Saleser_Name ;

			this.CustomerContact_Contact_Name = data.CustomerContact_Contact_Name;
			this.Multi_CustomerContact_Contact_Name = data.Multi_CustomerContact_Contact_Name ;

			this.Customer_CustomerCategory_Name = data.Customer_CustomerCategory_Name;
			this.Multi_Customer_CustomerCategory_Name = data.Multi_Customer_CustomerCategory_Name ;

			this.Customer_OfficialLocation_Name = data.Customer_OfficialLocation_Name;
			this.Multi_Customer_OfficialLocation_Name = data.Multi_Customer_OfficialLocation_Name ;

			this.Customer_TradeCurrency_MoneyRound_Precision = data.Customer_TradeCurrency_MoneyRound_Precision;

			this.ObjectCreditLevelApproval_CreditLimit = data.ObjectCreditLevelApproval_CreditLimit;

			this.SumBalanceTotalMoney = data.SumBalanceTotalMoney;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CustomerQryDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CustomerQryDTOData ToEntityData(CustomerQryDTOData data, IDictionary dict){
			if (data == null)
				data = new CustomerQryDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (CustomerQryDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			data.ID = this.ID;

			data.Customer_ID = this.Customer_ID;

			data.Customer_Code = this.Customer_Code;

			data.Customer_Name  = this.Customer_Name;
			data.Multi_Customer_Name  = this.Multi_Customer_Name;

			if (this.CustomerContact_Contact!=null)
			{
				data.CustomerContact_Contact = this.CustomerContact_Contact.ID;

			}

			data.CustomerContact_Contact_DefaultMobilNum = this.CustomerContact_Contact_DefaultMobilNum;

			data.CustomerContact_Contact_DefaultPhoneNum = this.CustomerContact_Contact_DefaultPhoneNum;

			if (this.Customer_CustomerCategory!=null)
			{
				data.Customer_CustomerCategory = this.Customer_CustomerCategory.ID;

			}

			if (this.Customer_Saleser!=null)
			{
				data.Customer_Saleser = this.Customer_Saleser.ID;

			}

			data.CustomerContact_Contact_DefaultFaxNum = this.CustomerContact_Contact_DefaultFaxNum;

			data.AROCMoneyBalance_TotalMoney = this.AROCMoneyBalance_TotalMoney;

			data.LastSOTotalMoneyTC = this.LastSOTotalMoneyTC;

			data.LastRecBillTotalMoney = this.LastRecBillTotalMoney;

			data.Customer_StateTaxNo = this.Customer_StateTaxNo;

			data.CustomerBankAccount_Code = this.CustomerBankAccount_Code;

			data.Customer_Description  = this.Customer_Description;
			data.Multi_Customer_Description  = this.Multi_Customer_Description;

			if (this.Customer_TradeCurrency_MoneyRound_RoundType!=null)
			{
				data.Customer_TradeCurrency_MoneyRound_RoundType = this.Customer_TradeCurrency_MoneyRound_RoundType.Value;
			}

			data.Customer_TradeCurrency_MoneyRound_RoundValue = this.Customer_TradeCurrency_MoneyRound_RoundValue;

			data.Customer_Saleser_Name  = this.Customer_Saleser_Name;
			data.Multi_Customer_Saleser_Name  = this.Multi_Customer_Saleser_Name;

			data.CustomerContact_Contact_Name  = this.CustomerContact_Contact_Name;
			data.Multi_CustomerContact_Contact_Name  = this.Multi_CustomerContact_Contact_Name;

			data.Customer_CustomerCategory_Name  = this.Customer_CustomerCategory_Name;
			data.Multi_Customer_CustomerCategory_Name  = this.Multi_Customer_CustomerCategory_Name;

			data.Customer_OfficialLocation_Name  = this.Customer_OfficialLocation_Name;
			data.Multi_Customer_OfficialLocation_Name  = this.Multi_Customer_OfficialLocation_Name;

			data.Customer_TradeCurrency_MoneyRound_Precision = this.Customer_TradeCurrency_MoneyRound_Precision;

			data.ObjectCreditLevelApproval_CreditLimit = this.ObjectCreditLevelApproval_CreditLimit;

			data.SumBalanceTotalMoney = this.SumBalanceTotalMoney;

			return data ;
		}

		#endregion	
	}	
	
}