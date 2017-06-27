


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.CustomerQucikQryBP
{
	/// <summary>
	/// CustomerQucikQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class CustomerQucikQryDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public CustomerQucikQryDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
		
		
		
					ActualAPMoney = 0m; 
					CreditMoney = 0m; 
					LastTransMoney = 0m; 
					LastRecMoney = 0m; 
		
		
		
		
		
		
		
					ID = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// CustomerQucikQryDTO.Misc.ID
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
		/// CustomerQucikQryDTO.Misc.编码
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
		/// 负责人 (该属性可为空,且无默认值)
		/// CustomerQucikQryDTO.Misc.负责人
		/// </summary>
		/// <value>System.String</value>
		public System.String EnterpriseLegalPerson
		{
			get	
			{	
				return (System.String)base.GetValue("EnterpriseLegalPerson",typeof(System.String));
			}

			 set	
			{
				base.SetValue("EnterpriseLegalPerson",value);
			}
		}
				/// <summary>
		/// 手机 (该属性可为空,且无默认值)
		/// CustomerQucikQryDTO.Misc.手机
		/// </summary>
		/// <value>System.String</value>
		public System.String MobileNo
		{
			get	
			{	
				return (System.String)base.GetValue("MobileNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("MobileNo",value);
			}
		}
				/// <summary>
		/// 电话 (该属性可为空,且无默认值)
		/// CustomerQucikQryDTO.Misc.电话
		/// </summary>
		/// <value>System.String</value>
		public System.String PhoneNo
		{
			get	
			{	
				return (System.String)base.GetValue("PhoneNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("PhoneNo",value);
			}
		}
				/// <summary>
		/// 客户_分类 (该属性可为空,且无默认值)
		/// CustomerQucikQryDTO.Misc.客户_分类
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
		/// 传真 (该属性可为空,且无默认值)
		/// CustomerQucikQryDTO.Misc.传真
		/// </summary>
		/// <value>System.String</value>
		public System.String Fax
		{
			get	
			{	
				return (System.String)base.GetValue("Fax",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Fax",value);
			}
		}
				/// <summary>
		/// 实际应收 (该属性可为空,但有默认值)
		/// CustomerQucikQryDTO.Misc.实际应收
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ActualAPMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ActualAPMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ActualAPMoney",value);
			}
		}
				/// <summary>
		/// 信用额度 (该属性可为空,但有默认值)
		/// CustomerQucikQryDTO.Misc.信用额度
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal CreditMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("CreditMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("CreditMoney",value);
			}
		}
				/// <summary>
		/// 最后交易额 (该属性可为空,但有默认值)
		/// CustomerQucikQryDTO.Misc.最后交易额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal LastTransMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("LastTransMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("LastTransMoney",value);
			}
		}
				/// <summary>
		/// 最后收款金额 (该属性可为空,但有默认值)
		/// CustomerQucikQryDTO.Misc.最后收款金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal LastRecMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("LastRecMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("LastRecMoney",value);
			}
		}
				/// <summary>
		/// 税号 (该属性可为空,且无默认值)
		/// CustomerQucikQryDTO.Misc.税号
		/// </summary>
		/// <value>System.String</value>
		public System.String TaxNo
		{
			get	
			{	
				return (System.String)base.GetValue("TaxNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("TaxNo",value);
			}
		}
				/// <summary>
		/// 开户银行 (该属性可为空,且无默认值)
		/// CustomerQucikQryDTO.Misc.开户银行
		/// </summary>
		/// <value>System.String</value>
		public System.String BankName
		{
			get	
			{	
				return (System.String)base.GetValue("BankName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("BankName",value);
			}
		}
				/// <summary>
		/// 说明 (该属性可为空,且无默认值)
		/// CustomerQucikQryDTO.Misc.说明
		/// </summary>
		/// <value>System.String</value>
		public System.String Memo
		{
			get	
			{	
				return (System.String)base.GetValue("Memo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Memo",value);
			}
		}
				/// <summary>
		/// 地址 (该属性可为空,且无默认值)
		/// CustomerQucikQryDTO.Misc.地址
		/// </summary>
		/// <value>System.String</value>
		public System.String Address
		{
			get	
			{	
				return (System.String)base.GetValue("Address",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Address",value);
			}
		}
				/// <summary>
		/// 客户_业务员 (该属性可为空,且无默认值)
		/// CustomerQucikQryDTO.Misc.客户_业务员
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
		/// 客户分类 (该属性可为空,且无默认值)
		/// CustomerQucikQryDTO.Misc.客户分类
		/// </summary>
		/// <value>System.String</value>
		public System.String CustomerCategoryName
		{
			get	
			{	
				return (System.String)base.GetValue("CustomerCategoryName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CustomerCategoryName",value);
			}
		}
				/// <summary>
		/// 业务员 (该属性可为空,且无默认值)
		/// CustomerQucikQryDTO.Misc.业务员
		/// </summary>
		/// <value>System.String</value>
		public System.String SaleserName
		{
			get	
			{	
				return (System.String)base.GetValue("SaleserName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SaleserName",value);
			}
		}
				/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// CustomerQucikQryDTO.Misc.ID
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
		
		#endregion	
		#region Multi_Fields
			 
		/// <summary>
		/// 名称
		/// CustomerQucikQryDTO.Misc.名称
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
		/// CustomerQucikQryDTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
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
		/// 负责人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_EnterpriseLegalPerson　{ get { return "";　}　}
		/// <summary>
		/// 手机的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_MobileNo　{ get { return "";　}　}
		/// <summary>
		/// 电话的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PhoneNo　{ get { return "";　}　}
		/// <summary>
		/// 客户_分类的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_CustomerCategory　{ get { return "";　}　}
		/// <summary>
		/// 传真的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Fax　{ get { return "";　}　}
		/// <summary>
		/// 实际应收的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ActualAPMoney　{ get { return "";　}　}
		/// <summary>
		/// 信用额度的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CreditMoney　{ get { return "";　}　}
		/// <summary>
		/// 最后交易额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_LastTransMoney　{ get { return "";　}　}
		/// <summary>
		/// 最后收款金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_LastRecMoney　{ get { return "";　}　}
		/// <summary>
		/// 税号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TaxNo　{ get { return "";　}　}
		/// <summary>
		/// 开户银行的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BankName　{ get { return "";　}　}
		/// <summary>
		/// 说明的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Memo　{ get { return "";　}　}
		/// <summary>
		/// 地址的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Address　{ get { return "";　}　}
		/// <summary>
		/// 客户_业务员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_Saleser　{ get { return "";　}　}
		/// <summary>
		/// 客户分类的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerCategoryName　{ get { return "";　}　}
		/// <summary>
		/// 业务员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SaleserName　{ get { return "";　}　}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(CustomerQucikQryDTOData data)
		{
		






			if (data.Customer_CustomerCategory == -1 && data.Customer_CustomerCategory_SKey!=null)
				data.Customer_CustomerCategory = data.Customer_CustomerCategory_SKey.GetEntity().ID ;










			if (data.Customer_Saleser == -1 && data.Customer_Saleser_SKey!=null)
				data.Customer_Saleser = data.Customer_Saleser_SKey.GetEntity().ID ;




		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(CustomerQucikQryDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CustomerQucikQryDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
			this.RecordCount = data.RecordCount ;
		
			this.Customer_ID = data.Customer_ID;

			this.Customer_Code = data.Customer_Code;

			this.Customer_Name = data.Customer_Name;
			this.Multi_Customer_Name = data.Multi_Customer_Name ;

			this.EnterpriseLegalPerson = data.EnterpriseLegalPerson;

			this.MobileNo = data.MobileNo;

			this.PhoneNo = data.PhoneNo;

			{
				if (data.Customer_CustomerCategory <= 0)
					this.Customer_CustomerCategory = null ;
				else
					this.Customer_CustomerCategory = new UFIDA.U9.CBO.SCM.Customer.CustomerCategory.EntityKey(data.Customer_CustomerCategory);
			}

			this.Fax = data.Fax;

			this.ActualAPMoney = data.ActualAPMoney;

			this.CreditMoney = data.CreditMoney;

			this.LastTransMoney = data.LastTransMoney;

			this.LastRecMoney = data.LastRecMoney;

			this.TaxNo = data.TaxNo;

			this.BankName = data.BankName;

			this.Memo = data.Memo;

			this.Address = data.Address;

			{
				if (data.Customer_Saleser <= 0)
					this.Customer_Saleser = null ;
				else
					this.Customer_Saleser = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(data.Customer_Saleser);
			}

			this.CustomerCategoryName = data.CustomerCategoryName;

			this.SaleserName = data.SaleserName;

			this.ID = data.ID;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CustomerQucikQryDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CustomerQucikQryDTOData ToEntityData(CustomerQucikQryDTOData data, IDictionary dict){
			if (data == null)
				data = new CustomerQucikQryDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (CustomerQucikQryDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			data.Customer_ID = this.Customer_ID;

			data.Customer_Code = this.Customer_Code;

			data.Customer_Name  = this.Customer_Name;
			data.Multi_Customer_Name  = this.Multi_Customer_Name;

			data.EnterpriseLegalPerson = this.EnterpriseLegalPerson;

			data.MobileNo = this.MobileNo;

			data.PhoneNo = this.PhoneNo;

			if (this.Customer_CustomerCategory!=null)
			{
				data.Customer_CustomerCategory = this.Customer_CustomerCategory.ID;

			}

			data.Fax = this.Fax;

			data.ActualAPMoney = this.ActualAPMoney;

			data.CreditMoney = this.CreditMoney;

			data.LastTransMoney = this.LastTransMoney;

			data.LastRecMoney = this.LastRecMoney;

			data.TaxNo = this.TaxNo;

			data.BankName = this.BankName;

			data.Memo = this.Memo;

			data.Address = this.Address;

			if (this.Customer_Saleser!=null)
			{
				data.Customer_Saleser = this.Customer_Saleser.ID;

			}

			data.CustomerCategoryName = this.CustomerCategoryName;

			data.SaleserName = this.SaleserName;

			data.ID = this.ID;

			return data ;
		}

		#endregion	
	}	
	
}