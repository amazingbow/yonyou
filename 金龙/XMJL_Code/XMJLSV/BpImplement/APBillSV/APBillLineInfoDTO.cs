


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.APBillSV
{
	/// <summary>
	/// 应付单行信息DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class APBillLineInfoDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public APBillLineInfoDTO(){
			initData();
		}
		private void initData()
		{
		
					MoneyWithOutTax = 0m; 
					Tax = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 料号 (该属性可为空,且无默认值)
		/// 应付单行信息DTO.Misc.料号
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemCode
		{
			get	
			{	
				return (System.String)base.GetValue("ItemCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemCode",value);
			}
		}
				/// <summary>
		/// 未税金额 (该属性可为空,但有默认值)
		/// 应付单行信息DTO.Misc.未税金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal MoneyWithOutTax
		{
			get	
			{	
				return (System.Decimal)base.GetValue("MoneyWithOutTax",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("MoneyWithOutTax",value);
			}
		}
				/// <summary>
		/// 税额 (该属性可为空,但有默认值)
		/// 应付单行信息DTO.Misc.税额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Tax
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Tax",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Tax",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
			
		#endregion 

		#region ModelResource
		/// <summary>
		/// 应付单行信息DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 料号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemCode　{ get { return "";　}　}
		/// <summary>
		/// 未税金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_MoneyWithOutTax　{ get { return "";　}　}
		/// <summary>
		/// 税额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Tax　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(APBillLineInfoDTOData data)
		{
		



		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(APBillLineInfoDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(APBillLineInfoDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.ItemCode = data.ItemCode;

			this.MoneyWithOutTax = data.MoneyWithOutTax;

			this.Tax = data.Tax;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public APBillLineInfoDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public APBillLineInfoDTOData ToEntityData(APBillLineInfoDTOData data, IDictionary dict){
			if (data == null)
				data = new APBillLineInfoDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (APBillLineInfoDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ItemCode = this.ItemCode;

			data.MoneyWithOutTax = this.MoneyWithOutTax;

			data.Tax = this.Tax;

			return data ;
		}

		#endregion	
	}	
	
}