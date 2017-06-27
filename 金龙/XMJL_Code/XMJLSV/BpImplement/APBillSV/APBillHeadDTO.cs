


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.APBillSV
{
	/// <summary>
	/// 汇总立账生单表头DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class APBillHeadDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public APBillHeadDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
		
		
					BusinessType = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 单据类型 (该属性可为空,且无默认值)
		/// 汇总立账生单表头DTO.Misc.单据类型
		/// </summary>
		/// <value>System.String</value>
		public System.String DocTypeCode
		{
			get	
			{	
				return (System.String)base.GetValue("DocTypeCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DocTypeCode",value);
			}
		}
				/// <summary>
		/// 供应商代码 (该属性可为空,且无默认值)
		/// 汇总立账生单表头DTO.Misc.供应商代码
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
		/// 立账日期 (该属性可为空,且无默认值)
		/// 汇总立账生单表头DTO.Misc.立账日期
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
		/// 发票日期 (该属性可为空,且无默认值)
		/// 汇总立账生单表头DTO.Misc.发票日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime InvoiceDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("InvoiceDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("InvoiceDate",value);
			}
		}
				/// <summary>
		/// 发票号 (该属性可为空,且无默认值)
		/// 汇总立账生单表头DTO.Misc.发票号
		/// </summary>
		/// <value>System.String</value>
		public System.String InvoiceCode
		{
			get	
			{	
				return (System.String)base.GetValue("InvoiceCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("InvoiceCode",value);
			}
		}
				/// <summary>
		/// 币种 (该属性可为空,且无默认值)
		/// 汇总立账生单表头DTO.Misc.币种
		/// </summary>
		/// <value>System.String</value>
		public System.String CurrencyCode
		{
			get	
			{	
				return (System.String)base.GetValue("CurrencyCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CurrencyCode",value);
			}
		}
				/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 汇总立账生单表头DTO.Misc.备注
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
		/// 来源业务类型 (该属性可为空,但有默认值)
		/// 汇总立账生单表头DTO.Misc.来源业务类型
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 BusinessType
		{
			get	
			{	
				return (System.Int32)base.GetValue("BusinessType",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("BusinessType",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
								
		#endregion 

		#region ModelResource
		/// <summary>
		/// 汇总立账生单表头DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 单据类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocTypeCode　{ get { return "";　}　}
		/// <summary>
		/// 供应商代码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_VendorCode　{ get { return "";　}　}
		/// <summary>
		/// 立账日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AccrueDate　{ get { return "";　}　}
		/// <summary>
		/// 发票日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_InvoiceDate　{ get { return "";　}　}
		/// <summary>
		/// 发票号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_InvoiceCode　{ get { return "";　}　}
		/// <summary>
		/// 币种的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CurrencyCode　{ get { return "";　}　}
		/// <summary>
		/// 备注的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Memo　{ get { return "";　}　}
		/// <summary>
		/// 来源业务类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BusinessType　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(APBillHeadDTOData data)
		{
		








		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(APBillHeadDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(APBillHeadDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.DocTypeCode = data.DocTypeCode;

			this.VendorCode = data.VendorCode;

			this.AccrueDate = data.AccrueDate;

			this.InvoiceDate = data.InvoiceDate;

			this.InvoiceCode = data.InvoiceCode;

			this.CurrencyCode = data.CurrencyCode;

			this.Memo = data.Memo;

			this.BusinessType = data.BusinessType;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public APBillHeadDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public APBillHeadDTOData ToEntityData(APBillHeadDTOData data, IDictionary dict){
			if (data == null)
				data = new APBillHeadDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (APBillHeadDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.DocTypeCode = this.DocTypeCode;

			data.VendorCode = this.VendorCode;

			data.AccrueDate = this.AccrueDate;

			data.InvoiceDate = this.InvoiceDate;

			data.InvoiceCode = this.InvoiceCode;

			data.CurrencyCode = this.CurrencyCode;

			data.Memo = this.Memo;

			data.BusinessType = this.BusinessType;

			return data ;
		}

		#endregion	
	}	
	
}