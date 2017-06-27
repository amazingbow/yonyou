


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.CustomerVoucherQryBP
{
	/// <summary>
	/// CustomerVoucherQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class CustomerVoucherQryDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public CustomerVoucherQryDTO(){
			initData();
		}
		private void initData()
		{
					ID = 0; 
		
		
		
		
		
		
					DebitMoney = 0m; 
		
					SumDebitMoney = 0m; 
		
					SumMoney = 0m; 
		
					BalanceMoney = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// CustomerVoucherQryDTO.Misc.ID
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
		/// 客户 (该属性可为空,且无默认值)
		/// CustomerVoucherQryDTO.Misc.客户
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Customer.Customer</value>
		public UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey Customer
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey)base.GetValue("Customer",typeof(UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey));
			}

			 set	
			{
				base.SetValue("Customer",value);
			}
		}
		 
				/// <summary>
		/// 应收单据 (该属性可为空,且无默认值)
		/// CustomerVoucherQryDTO.Misc.应收单据
		/// </summary>
		/// <value>System.String</value>
		public System.String DocNo
		{
			get	
			{	
				return (System.String)base.GetValue("DocNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DocNo",value);
			}
		}
				/// <summary>
		/// 单据类型 (该属性可为空,且无默认值)
		/// CustomerVoucherQryDTO.Misc.单据类型
		/// </summary>
		/// <value>System.String</value>
		public System.String DocTypeName
		{
			get	
			{	
				return (System.String)base.GetValue("DocTypeName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DocTypeName",value);
			}
		}
				/// <summary>
		/// 制单人 (该属性可为空,且无默认值)
		/// CustomerVoucherQryDTO.Misc.制单人
		/// </summary>
		/// <value>System.String</value>
		public System.String CreatedBy
		{
			get	
			{	
				return (System.String)base.GetValue("CreatedBy",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CreatedBy",value);
			}
		}
				/// <summary>
		/// 摘要 (该属性可为空,且无默认值)
		/// CustomerVoucherQryDTO.Misc.摘要
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
		/// 借方金额 (该属性可为空,但有默认值)
		/// CustomerVoucherQryDTO.Misc.借方金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal DebitMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("DebitMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("DebitMoney",value);
			}
		}
				/// <summary>
		/// 贷方金额 (该属性可为空,且无默认值)
		/// CustomerVoucherQryDTO.Misc.贷方金额
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
		/// 合计借方金额 (该属性可为空,但有默认值)
		/// CustomerVoucherQryDTO.Misc.合计借方金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal SumDebitMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("SumDebitMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("SumDebitMoney",value);
			}
		}
				/// <summary>
		/// 合计贷方金额 (该属性可为空,且无默认值)
		/// CustomerVoucherQryDTO.Misc.合计贷方金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal SumCreditMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("SumCreditMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("SumCreditMoney",value);
			}
		}
				/// <summary>
		/// 合计金额 (该属性可为空,但有默认值)
		/// CustomerVoucherQryDTO.Misc.合计金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal SumMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("SumMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("SumMoney",value);
			}
		}
				/// <summary>
		/// 业务日期 (该属性可为空,且无默认值)
		/// CustomerVoucherQryDTO.Misc.业务日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime BusinessDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("BusinessDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("BusinessDate",value);
			}
		}
				/// <summary>
		/// 结存 (该属性可为空,但有默认值)
		/// CustomerVoucherQryDTO.Misc.结存
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal BalanceMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("BalanceMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("BalanceMoney",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
			 
		/// <summary>
		/// 名称
		/// CustomerVoucherQryDTO.Misc.名称
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
		/// CustomerVoucherQryDTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 客户的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_Name　{ get { return "";　}　}
		/// <summary>
		/// 应收单据的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocNo　{ get { return "";　}　}
		/// <summary>
		/// 单据类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocTypeName　{ get { return "";　}　}
		/// <summary>
		/// 制单人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CreatedBy　{ get { return "";　}　}
		/// <summary>
		/// 摘要的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Memo　{ get { return "";　}　}
		/// <summary>
		/// 借方金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DebitMoney　{ get { return "";　}　}
		/// <summary>
		/// 贷方金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CreditMoney　{ get { return "";　}　}
		/// <summary>
		/// 合计借方金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SumDebitMoney　{ get { return "";　}　}
		/// <summary>
		/// 合计贷方金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SumCreditMoney　{ get { return "";　}　}
		/// <summary>
		/// 合计金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SumMoney　{ get { return "";　}　}
		/// <summary>
		/// 业务日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BusinessDate　{ get { return "";　}　}
		/// <summary>
		/// 结存的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BalanceMoney　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(CustomerVoucherQryDTOData data)
		{
		

			if (data.Customer == -1 && data.Customer_SKey!=null)
				data.Customer = data.Customer_SKey.GetEntity().ID ;













		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(CustomerVoucherQryDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CustomerVoucherQryDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
			this.RecordCount = data.RecordCount ;
		
			this.ID = data.ID;

			{
				if (data.Customer <= 0)
					this.Customer = null ;
				else
					this.Customer = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(data.Customer);
			}

			this.Customer_Name = data.Customer_Name;
			this.Multi_Customer_Name = data.Multi_Customer_Name ;

			this.DocNo = data.DocNo;

			this.DocTypeName = data.DocTypeName;

			this.CreatedBy = data.CreatedBy;

			this.Memo = data.Memo;

			this.DebitMoney = data.DebitMoney;

			this.CreditMoney = data.CreditMoney;

			this.SumDebitMoney = data.SumDebitMoney;

			this.SumCreditMoney = data.SumCreditMoney;

			this.SumMoney = data.SumMoney;

			this.BusinessDate = data.BusinessDate;

			this.BalanceMoney = data.BalanceMoney;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CustomerVoucherQryDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CustomerVoucherQryDTOData ToEntityData(CustomerVoucherQryDTOData data, IDictionary dict){
			if (data == null)
				data = new CustomerVoucherQryDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (CustomerVoucherQryDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			data.ID = this.ID;

			if (this.Customer!=null)
			{
				data.Customer = this.Customer.ID;

			}

			data.Customer_Name  = this.Customer_Name;
			data.Multi_Customer_Name  = this.Multi_Customer_Name;

			data.DocNo = this.DocNo;

			data.DocTypeName = this.DocTypeName;

			data.CreatedBy = this.CreatedBy;

			data.Memo = this.Memo;

			data.DebitMoney = this.DebitMoney;

			data.CreditMoney = this.CreditMoney;

			data.SumDebitMoney = this.SumDebitMoney;

			data.SumCreditMoney = this.SumCreditMoney;

			data.SumMoney = this.SumMoney;

			data.BusinessDate = this.BusinessDate;

			data.BalanceMoney = this.BalanceMoney;

			return data ;
		}

		#endregion	
	}	
	
}