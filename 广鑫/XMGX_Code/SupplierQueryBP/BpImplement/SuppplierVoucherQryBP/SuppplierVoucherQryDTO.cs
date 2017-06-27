


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.SuppplierVoucherQryBP
{
	/// <summary>
	/// SuppplierVoucherQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SuppplierVoucherQryDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SuppplierVoucherQryDTO(){
			initData();
		}
		private void initData()
		{
					ID = 0; 
		
		
		
		
		
					DebitMoney = 0m; 
		
		
		
					SumMoney = 0m; 
					BalanceMoney = 0m; 
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// SuppplierVoucherQryDTO.Misc.ID
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
		/// 单据号 (该属性可为空,且无默认值)
		/// SuppplierVoucherQryDTO.Misc.单据号
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
		/// SuppplierVoucherQryDTO.Misc.单据类型
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
		/// 公司名称 (该属性可为空,且无默认值)
		/// SuppplierVoucherQryDTO.Misc.公司名称
		/// </summary>
		/// <value>System.String</value>
		public System.String SupplierName
		{
			get	
			{	
				return (System.String)base.GetValue("SupplierName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SupplierName",value);
			}
		}
				/// <summary>
		/// 制单日期 (该属性可为空,且无默认值)
		/// SuppplierVoucherQryDTO.Misc.制单日期
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
		/// 制单人 (该属性可为空,且无默认值)
		/// SuppplierVoucherQryDTO.Misc.制单人
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
		/// 借方金额 (该属性可为空,但有默认值)
		/// SuppplierVoucherQryDTO.Misc.借方金额
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
		/// SuppplierVoucherQryDTO.Misc.贷方金额
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
		/// 合计借方金额 (该属性可为空,且无默认值)
		/// SuppplierVoucherQryDTO.Misc.合计借方金额
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
		/// SuppplierVoucherQryDTO.Misc.合计贷方金额
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
		/// SuppplierVoucherQryDTO.Misc.合计金额
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
		/// 小计 (该属性可为空,但有默认值)
		/// SuppplierVoucherQryDTO.Misc.小计
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
				/// <summary>
		/// 摘要 (该属性可为空,且无默认值)
		/// SuppplierVoucherQryDTO.Misc.摘要
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
		
		#endregion	
		#region Multi_Fields
													
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
		/// SuppplierVoucherQryDTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 单据号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocNo　{ get { return "";　}　}
		/// <summary>
		/// 单据类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocTypeName　{ get { return "";　}　}
		/// <summary>
		/// 公司名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SupplierName　{ get { return "";　}　}
		/// <summary>
		/// 制单日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BusinessDate　{ get { return "";　}　}
		/// <summary>
		/// 制单人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CreatedBy　{ get { return "";　}　}
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
		/// 小计的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BalanceMoney　{ get { return "";　}　}
		/// <summary>
		/// 摘要的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Memo　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SuppplierVoucherQryDTOData data)
		{
		













		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SuppplierVoucherQryDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SuppplierVoucherQryDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
			this.RecordCount = data.RecordCount ;
		
			this.ID = data.ID;

			this.DocNo = data.DocNo;

			this.DocTypeName = data.DocTypeName;

			this.SupplierName = data.SupplierName;

			this.BusinessDate = data.BusinessDate;

			this.CreatedBy = data.CreatedBy;

			this.DebitMoney = data.DebitMoney;

			this.CreditMoney = data.CreditMoney;

			this.SumDebitMoney = data.SumDebitMoney;

			this.SumCreditMoney = data.SumCreditMoney;

			this.SumMoney = data.SumMoney;

			this.BalanceMoney = data.BalanceMoney;

			this.Memo = data.Memo;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SuppplierVoucherQryDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SuppplierVoucherQryDTOData ToEntityData(SuppplierVoucherQryDTOData data, IDictionary dict){
			if (data == null)
				data = new SuppplierVoucherQryDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SuppplierVoucherQryDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			data.ID = this.ID;

			data.DocNo = this.DocNo;

			data.DocTypeName = this.DocTypeName;

			data.SupplierName = this.SupplierName;

			data.BusinessDate = this.BusinessDate;

			data.CreatedBy = this.CreatedBy;

			data.DebitMoney = this.DebitMoney;

			data.CreditMoney = this.CreditMoney;

			data.SumDebitMoney = this.SumDebitMoney;

			data.SumCreditMoney = this.SumCreditMoney;

			data.SumMoney = this.SumMoney;

			data.BalanceMoney = this.BalanceMoney;

			data.Memo = this.Memo;

			return data ;
		}

		#endregion	
	}	
	
}