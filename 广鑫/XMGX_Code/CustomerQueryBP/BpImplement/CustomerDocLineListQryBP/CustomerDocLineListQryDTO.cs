


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.CustomerDocLineListQryBP
{
	/// <summary>
	/// CustomerDocLineListQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class CustomerDocLineListQryDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public CustomerDocLineListQryDTO(){
			initData();
		}
		private void initData()
		{
					ID = 0; 
		
		
		
		
		
					MainSOQty = 0m; 
		
					FinallyPrice = 0m; 
					InvSOQty = 0m; 
		
		
					ConversionRates = 0m; 
		
					DocLineNo = 0; 
		
					MainUOM_Round_RoundType =UFIDA.U9.Base.PropertyTypes.RoundTypeEnum.GetFromValue(0); 
					MainUOM_Round_RoundValue = 0; 
					MainUOM_Round_Precision = 0; 
					InvUOM_Round_Precision = 0; 
					InvUOM_Round_RoundType =UFIDA.U9.Base.PropertyTypes.RoundTypeEnum.GetFromValue(0); 
					InvUOM_Round_RoundValue = 0; 
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// CustomerDocLineListQryDTO.Misc.ID
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
		/// 单据日期 (该属性可为空,且无默认值)
		/// CustomerDocLineListQryDTO.Misc.单据日期
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
		/// 单据号 (该属性可为空,且无默认值)
		/// CustomerDocLineListQryDTO.Misc.单据号
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
		/// 存货编码 (该属性可为空,且无默认值)
		/// CustomerDocLineListQryDTO.Misc.存货编码
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
		/// 存货名称 (该属性可为空,且无默认值)
		/// CustomerDocLineListQryDTO.Misc.存货名称
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemName
		{
			get	
			{	
				return (System.String)base.GetValue("ItemName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemName",value);
			}
		}
				/// <summary>
		/// 规格型号 (该属性可为空,且无默认值)
		/// CustomerDocLineListQryDTO.Misc.规格型号
		/// </summary>
		/// <value>System.String</value>
		public System.String SPECS
		{
			get	
			{	
				return (System.String)base.GetValue("SPECS",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SPECS",value);
			}
		}
				/// <summary>
		/// 主销售数量 (该属性可为空,但有默认值)
		/// CustomerDocLineListQryDTO.Misc.主销售数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal MainSOQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("MainSOQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("MainSOQty",value);
			}
		}
				/// <summary>
		/// 主单位 (该属性可为空,且无默认值)
		/// CustomerDocLineListQryDTO.Misc.主单位
		/// </summary>
		/// <value>System.String</value>
		public System.String MainUOM_Name
		{
			get	
			{	
				return (System.String)base.GetValue("MainUOM_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("MainUOM_Name",value);
			}
		}
				/// <summary>
		/// 主报价 (该属性可为空,但有默认值)
		/// CustomerDocLineListQryDTO.Misc.主报价
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal FinallyPrice
		{
			get	
			{	
				return (System.Decimal)base.GetValue("FinallyPrice",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("FinallyPrice",value);
			}
		}
				/// <summary>
		/// 辅销售数量 (该属性可为空,但有默认值)
		/// CustomerDocLineListQryDTO.Misc.辅销售数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal InvSOQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("InvSOQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("InvSOQty",value);
			}
		}
				/// <summary>
		/// 辅单位 (该属性可为空,且无默认值)
		/// CustomerDocLineListQryDTO.Misc.辅单位
		/// </summary>
		/// <value>System.String</value>
		public System.String InvUOM_Name
		{
			get	
			{	
				return (System.String)base.GetValue("InvUOM_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("InvUOM_Name",value);
			}
		}
				/// <summary>
		/// 金额 (该属性可为空,且无默认值)
		/// CustomerDocLineListQryDTO.Misc.金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal TotalMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("TotalMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("TotalMoney",value);
			}
		}
				/// <summary>
		/// 换算率 (该属性可为空,但有默认值)
		/// CustomerDocLineListQryDTO.Misc.换算率
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ConversionRates
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ConversionRates",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ConversionRates",value);
			}
		}
				/// <summary>
		/// 公司名称 (该属性可为空,且无默认值)
		/// CustomerDocLineListQryDTO.Misc.公司名称
		/// </summary>
		/// <value>System.String</value>
		public System.String Customer_Name
		{
			get	
			{	
				return (System.String)base.GetValue("Customer_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Customer_Name",value);
			}
		}
				/// <summary>
		/// 行号 (该属性可为空,但有默认值)
		/// CustomerDocLineListQryDTO.Misc.行号
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 DocLineNo
		{
			get	
			{	
				return (System.Int32)base.GetValue("DocLineNo",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("DocLineNo",value);
			}
		}
				/// <summary>
		/// 业务员 (该属性可为空,且无默认值)
		/// CustomerDocLineListQryDTO.Misc.业务员
		/// </summary>
		/// <value>System.String</value>
		public System.String Operators_Name
		{
			get	
			{	
				return (System.String)base.GetValue("Operators_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Operators_Name",value);
			}
		}
				/// <summary>
		/// 主单位_精度_舍入类型 (该属性不可为空,但有默认值)
		/// CustomerDocLineListQryDTO.Misc.主单位_精度_舍入类型
		/// </summary>
		/// <value>UFIDA.U9.Base.PropertyTypes.RoundTypeEnum</value>
		public UFIDA.U9.Base.PropertyTypes.RoundTypeEnum MainUOM_Round_RoundType
		{
			get	
			{	
				return (UFIDA.U9.Base.PropertyTypes.RoundTypeEnum)base.GetValue("MainUOM_Round_RoundType",typeof(UFIDA.U9.Base.PropertyTypes.RoundTypeEnum));
			}

			 set	
			{
				base.SetValue("MainUOM_Round_RoundType",value);
			}
		}
				/// <summary>
		/// 主单位_精度_舍入值 (该属性可为空,但有默认值)
		/// CustomerDocLineListQryDTO.Misc.主单位_精度_舍入值
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 MainUOM_Round_RoundValue
		{
			get	
			{	
				return (System.Int32)base.GetValue("MainUOM_Round_RoundValue",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("MainUOM_Round_RoundValue",value);
			}
		}
				/// <summary>
		/// 主单位_精度_精度 (该属性不可为空,但有默认值)
		/// CustomerDocLineListQryDTO.Misc.主单位_精度_精度
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 MainUOM_Round_Precision
		{
			get	
			{	
				return (System.Int32)base.GetValue("MainUOM_Round_Precision",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("MainUOM_Round_Precision",value);
			}
		}
				/// <summary>
		/// 辅单位_精度_精度 (该属性不可为空,但有默认值)
		/// CustomerDocLineListQryDTO.Misc.辅单位_精度_精度
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 InvUOM_Round_Precision
		{
			get	
			{	
				return (System.Int32)base.GetValue("InvUOM_Round_Precision",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("InvUOM_Round_Precision",value);
			}
		}
				/// <summary>
		/// 辅单位_精度_舍入类型 (该属性不可为空,但有默认值)
		/// CustomerDocLineListQryDTO.Misc.辅单位_精度_舍入类型
		/// </summary>
		/// <value>UFIDA.U9.Base.PropertyTypes.RoundTypeEnum</value>
		public UFIDA.U9.Base.PropertyTypes.RoundTypeEnum InvUOM_Round_RoundType
		{
			get	
			{	
				return (UFIDA.U9.Base.PropertyTypes.RoundTypeEnum)base.GetValue("InvUOM_Round_RoundType",typeof(UFIDA.U9.Base.PropertyTypes.RoundTypeEnum));
			}

			 set	
			{
				base.SetValue("InvUOM_Round_RoundType",value);
			}
		}
				/// <summary>
		/// 辅单位_精度_舍入值 (该属性可为空,但有默认值)
		/// CustomerDocLineListQryDTO.Misc.辅单位_精度_舍入值
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 InvUOM_Round_RoundValue
		{
			get	
			{	
				return (System.Int32)base.GetValue("InvUOM_Round_RoundValue",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("InvUOM_Round_RoundValue",value);
			}
		}
				/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// CustomerDocLineListQryDTO.Misc.备注
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
		/// CustomerDocLineListQryDTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 单据日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BusinessDate　{ get { return "";　}　}
		/// <summary>
		/// 单据号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocNo　{ get { return "";　}　}
		/// <summary>
		/// 存货编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemCode　{ get { return "";　}　}
		/// <summary>
		/// 存货名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemName　{ get { return "";　}　}
		/// <summary>
		/// 规格型号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SPECS　{ get { return "";　}　}
		/// <summary>
		/// 主销售数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_MainSOQty　{ get { return "";　}　}
		/// <summary>
		/// 主单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_MainUOM_Name　{ get { return "";　}　}
		/// <summary>
		/// 主报价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_FinallyPrice　{ get { return "";　}　}
		/// <summary>
		/// 辅销售数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_InvSOQty　{ get { return "";　}　}
		/// <summary>
		/// 辅单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_InvUOM_Name　{ get { return "";　}　}
		/// <summary>
		/// 金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TotalMoney　{ get { return "";　}　}
		/// <summary>
		/// 换算率的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ConversionRates　{ get { return "";　}　}
		/// <summary>
		/// 公司名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_Name　{ get { return "";　}　}
		/// <summary>
		/// 行号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocLineNo　{ get { return "";　}　}
		/// <summary>
		/// 业务员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Operators_Name　{ get { return "";　}　}
		/// <summary>
		/// 主单位_精度_舍入类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_MainUOM_Round_RoundType　{ get { return "";　}　}
		/// <summary>
		/// 主单位_精度_舍入值的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_MainUOM_Round_RoundValue　{ get { return "";　}　}
		/// <summary>
		/// 主单位_精度_精度的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_MainUOM_Round_Precision　{ get { return "";　}　}
		/// <summary>
		/// 辅单位_精度_精度的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_InvUOM_Round_Precision　{ get { return "";　}　}
		/// <summary>
		/// 辅单位_精度_舍入类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_InvUOM_Round_RoundType　{ get { return "";　}　}
		/// <summary>
		/// 辅单位_精度_舍入值的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_InvUOM_Round_RoundValue　{ get { return "";　}　}
		/// <summary>
		/// 备注的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Memo　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(CustomerDocLineListQryDTOData data)
		{
		























		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(CustomerDocLineListQryDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CustomerDocLineListQryDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
			this.RecordCount = data.RecordCount ;
		
			this.ID = data.ID;

			this.BusinessDate = data.BusinessDate;

			this.DocNo = data.DocNo;

			this.ItemCode = data.ItemCode;

			this.ItemName = data.ItemName;

			this.SPECS = data.SPECS;

			this.MainSOQty = data.MainSOQty;

			this.MainUOM_Name = data.MainUOM_Name;

			this.FinallyPrice = data.FinallyPrice;

			this.InvSOQty = data.InvSOQty;

			this.InvUOM_Name = data.InvUOM_Name;

			this.TotalMoney = data.TotalMoney;

			this.ConversionRates = data.ConversionRates;

			this.Customer_Name = data.Customer_Name;

			this.DocLineNo = data.DocLineNo;

			this.Operators_Name = data.Operators_Name;

			this.MainUOM_Round_RoundType = UFIDA.U9.Base.PropertyTypes.RoundTypeEnum.GetFromValue(data.MainUOM_Round_RoundType);

			this.MainUOM_Round_RoundValue = data.MainUOM_Round_RoundValue;

			this.MainUOM_Round_Precision = data.MainUOM_Round_Precision;

			this.InvUOM_Round_Precision = data.InvUOM_Round_Precision;

			this.InvUOM_Round_RoundType = UFIDA.U9.Base.PropertyTypes.RoundTypeEnum.GetFromValue(data.InvUOM_Round_RoundType);

			this.InvUOM_Round_RoundValue = data.InvUOM_Round_RoundValue;

			this.Memo = data.Memo;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CustomerDocLineListQryDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CustomerDocLineListQryDTOData ToEntityData(CustomerDocLineListQryDTOData data, IDictionary dict){
			if (data == null)
				data = new CustomerDocLineListQryDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (CustomerDocLineListQryDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			data.ID = this.ID;

			data.BusinessDate = this.BusinessDate;

			data.DocNo = this.DocNo;

			data.ItemCode = this.ItemCode;

			data.ItemName = this.ItemName;

			data.SPECS = this.SPECS;

			data.MainSOQty = this.MainSOQty;

			data.MainUOM_Name = this.MainUOM_Name;

			data.FinallyPrice = this.FinallyPrice;

			data.InvSOQty = this.InvSOQty;

			data.InvUOM_Name = this.InvUOM_Name;

			data.TotalMoney = this.TotalMoney;

			data.ConversionRates = this.ConversionRates;

			data.Customer_Name = this.Customer_Name;

			data.DocLineNo = this.DocLineNo;

			data.Operators_Name = this.Operators_Name;

			if (this.MainUOM_Round_RoundType!=null)
			{
				data.MainUOM_Round_RoundType = this.MainUOM_Round_RoundType.Value;
			}

			data.MainUOM_Round_RoundValue = this.MainUOM_Round_RoundValue;

			data.MainUOM_Round_Precision = this.MainUOM_Round_Precision;

			data.InvUOM_Round_Precision = this.InvUOM_Round_Precision;

			if (this.InvUOM_Round_RoundType!=null)
			{
				data.InvUOM_Round_RoundType = this.InvUOM_Round_RoundType.Value;
			}

			data.InvUOM_Round_RoundValue = this.InvUOM_Round_RoundValue;

			data.Memo = this.Memo;

			return data ;
		}

		#endregion	
	}	
	
}