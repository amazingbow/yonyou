


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.BillBalanceSV
{
	/// <summary>
	/// 应付明细账DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class BillBalanceDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public BillBalanceDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
		
					APBillMoney = 0m; 
					PayBillMoney = 0m; 
					BalanceMoney = 0m; 
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 日期 (该属性可为空,且无默认值)
		/// 应付明细账DTO.Misc.日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime AccrueDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("AccrueDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("AccrueDate",value);
			}
		}
				/// <summary>
		/// 凭证号 (该属性可为空,且无默认值)
		/// 应付明细账DTO.Misc.凭证号
		/// </summary>
		/// <value>System.String</value>
		public System.String VoucherDisplayCode
		{
			get	
			{	
				return (System.String)base.GetValue("VoucherDisplayCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("VoucherDisplayCode",value);
			}
		}
				/// <summary>
		/// 摘要 (该属性可为空,且无默认值)
		/// 应付明细账DTO.Misc.摘要
		/// </summary>
		/// <value>System.String</value>
		public System.String Abstracts
		{
			get	
			{	
				return (System.String)base.GetValue("Abstracts",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Abstracts",value);
			}
		}
				/// <summary>
		/// 单据类型 (该属性可为空,且无默认值)
		/// 应付明细账DTO.Misc.单据类型
		/// </summary>
		/// <value>System.String</value>
		public System.String DocType
		{
			get	
			{	
				return (System.String)base.GetValue("DocType",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DocType",value);
			}
		}
				/// <summary>
		/// 单据号 (该属性可为空,且无默认值)
		/// 应付明细账DTO.Misc.单据号
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
		/// 币种 (该属性可为空,且无默认值)
		/// 应付明细账DTO.Misc.币种
		/// </summary>
		/// <value>System.String</value>
		public System.String ACName
		{
			get	
			{	
				return (System.String)base.GetValue("ACName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ACName",value);
			}
		}
				/// <summary>
		/// 本期应付金额 (该属性可为空,但有默认值)
		/// 应付明细账DTO.Misc.本期应付金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal APBillMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("APBillMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("APBillMoney",value);
			}
		}
				/// <summary>
		/// 本期付款金额 (该属性可为空,但有默认值)
		/// 应付明细账DTO.Misc.本期付款金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal PayBillMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("PayBillMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("PayBillMoney",value);
			}
		}
				/// <summary>
		/// 余额 (该属性可为空,但有默认值)
		/// 应付明细账DTO.Misc.余额
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
		/// 供应商 (该属性可为空,且无默认值)
		/// 应付明细账DTO.Misc.供应商
		/// </summary>
		/// <value>System.String</value>
		public System.String VendorCode
		{
			get	
			{	
				return (System.String)base.GetValue("VendorCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("VendorCode",value);
			}
		}
				/// <summary>
		/// 业务员 (该属性可为空,且无默认值)
		/// 应付明细账DTO.Misc.业务员
		/// </summary>
		/// <value>System.String</value>
		public System.String CPersonCode
		{
			get	
			{	
				return (System.String)base.GetValue("CPersonCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CPersonCode",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
											
		#endregion 

		#region ModelResource
		/// <summary>
		/// 应付明细账DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AccrueDate　{ get { return "";　}　}
		/// <summary>
		/// 凭证号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_VoucherDisplayCode　{ get { return "";　}　}
		/// <summary>
		/// 摘要的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Abstracts　{ get { return "";　}　}
		/// <summary>
		/// 单据类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocType　{ get { return "";　}　}
		/// <summary>
		/// 单据号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocNo　{ get { return "";　}　}
		/// <summary>
		/// 币种的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ACName　{ get { return "";　}　}
		/// <summary>
		/// 本期应付金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_APBillMoney　{ get { return "";　}　}
		/// <summary>
		/// 本期付款金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PayBillMoney　{ get { return "";　}　}
		/// <summary>
		/// 余额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BalanceMoney　{ get { return "";　}　}
		/// <summary>
		/// 供应商的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_VendorCode　{ get { return "";　}　}
		/// <summary>
		/// 业务员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CPersonCode　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(BillBalanceDTOData data)
		{
		











		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(BillBalanceDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(BillBalanceDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.AccrueDate = data.AccrueDate;

			this.VoucherDisplayCode = data.VoucherDisplayCode;

			this.Abstracts = data.Abstracts;

			this.DocType = data.DocType;

			this.DocNo = data.DocNo;

			this.ACName = data.ACName;

			this.APBillMoney = data.APBillMoney;

			this.PayBillMoney = data.PayBillMoney;

			this.BalanceMoney = data.BalanceMoney;

			this.VendorCode = data.VendorCode;

			this.CPersonCode = data.CPersonCode;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public BillBalanceDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public BillBalanceDTOData ToEntityData(BillBalanceDTOData data, IDictionary dict){
			if (data == null)
				data = new BillBalanceDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (BillBalanceDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.AccrueDate = this.AccrueDate;

			data.VoucherDisplayCode = this.VoucherDisplayCode;

			data.Abstracts = this.Abstracts;

			data.DocType = this.DocType;

			data.DocNo = this.DocNo;

			data.ACName = this.ACName;

			data.APBillMoney = this.APBillMoney;

			data.PayBillMoney = this.PayBillMoney;

			data.BalanceMoney = this.BalanceMoney;

			data.VendorCode = this.VendorCode;

			data.CPersonCode = this.CPersonCode;

			return data ;
		}

		#endregion	
	}	
	
}