


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.BillBalanceSV
{
	/// <summary>
	/// 应付明细账查询条件DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class BillBalanceQueryDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public BillBalanceQueryDTO(){
			initData();
		}
		private void initData()
		{
		
		
					Year = 0; 
					Month = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 供应商代码 (该属性可为空,且无默认值)
		/// 应付明细账查询条件DTO.Misc.供应商代码
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
		/// 应付明细账查询条件DTO.Misc.业务员
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
				/// <summary>
		/// 用友年度 (该属性可为空,但有默认值)
		/// 应付明细账查询条件DTO.Misc.用友年度
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 Year
		{
			get	
			{	
				return (System.Int32)base.GetValue("Year",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("Year",value);
			}
		}
				/// <summary>
		/// 截止月份 (该属性可为空,但有默认值)
		/// 应付明细账查询条件DTO.Misc.截止月份
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 Month
		{
			get	
			{	
				return (System.Int32)base.GetValue("Month",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("Month",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
				
		#endregion 

		#region ModelResource
		/// <summary>
		/// 应付明细账查询条件DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 供应商代码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_VendorCode　{ get { return "";　}　}
		/// <summary>
		/// 业务员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CPersonCode　{ get { return "";　}　}
		/// <summary>
		/// 用友年度的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Year　{ get { return "";　}　}
		/// <summary>
		/// 截止月份的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Month　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(BillBalanceQueryDTOData data)
		{
		




		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(BillBalanceQueryDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(BillBalanceQueryDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.VendorCode = data.VendorCode;

			this.CPersonCode = data.CPersonCode;

			this.Year = data.Year;

			this.Month = data.Month;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public BillBalanceQueryDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public BillBalanceQueryDTOData ToEntityData(BillBalanceQueryDTOData data, IDictionary dict){
			if (data == null)
				data = new BillBalanceQueryDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (BillBalanceQueryDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.VendorCode = this.VendorCode;

			data.CPersonCode = this.CPersonCode;

			data.Year = this.Year;

			data.Month = this.Month;

			return data ;
		}

		#endregion	
	}	
	
}