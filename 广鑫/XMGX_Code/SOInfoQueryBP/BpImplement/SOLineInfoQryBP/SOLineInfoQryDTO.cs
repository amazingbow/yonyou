


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.SOLineInfoQryBP
{
	/// <summary>
	/// SOLineInfoQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SOLineInfoQryDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SOLineInfoQryDTO(){
			initData();
		}
		private void initData()
		{
					ID = 0; 
		
		
		
		
		
		
					SOLine_FinallyPriceTC = 0m; 
		
					SOLine_OrderByQtyTU = 0m; 
					SOLine_DocLineNo = 0; 
					SOLine_TotalMoneyTC = 0m; 
		
					SOLine_TU_Round_Precision = 0; 
					SOLine_TU_Round_RoundType =UFIDA.U9.Base.PropertyTypes.RoundTypeEnum.GetFromValue(0); 
					SOLine_TU_Round_RoundValue = 0; 
					TotalShipQty = 0m; 
					TotalShipMoney = 0m; 
					AfterAdjustedMoney = 0m; 
					AfterAdjustedPrice = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// SOLineInfoQryDTO.Misc.ID
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
		/// ID (该属性不可为空,且无默认值)
		/// SOLineInfoQryDTO.Misc.ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SOLine_ID
		{
			get	
			{	
				return (System.Int64)base.GetValue("SOLine_ID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SOLine_ID",value);
			}
		}
				/// <summary>
		/// 料号 (该属性可为空,且无默认值)
		/// SOLineInfoQryDTO.Misc.料号
		/// </summary>
		/// <value>System.String</value>
		public System.String SOLine_ItemInfo_ItemCode
		{
			get	
			{	
				return (System.String)base.GetValue("SOLine_ItemInfo_ItemCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SOLine_ItemInfo_ItemCode",value);
			}
		}
				/// <summary>
		/// 品名 (该属性可为空,且无默认值)
		/// SOLineInfoQryDTO.Misc.品名
		/// </summary>
		/// <value>System.String</value>
		public System.String SOLine_ItemInfo_ItemName
		{
			get	
			{	
				return (System.String)base.GetValue("SOLine_ItemInfo_ItemName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SOLine_ItemInfo_ItemName",value);
			}
		}
				/// <summary>
		/// 型号 (该属性可为空,且无默认值)
		/// SOLineInfoQryDTO.Misc.型号
		/// </summary>
		/// <value>System.String</value>
		public System.String SOLine_ItemInfo_ItemID_SPECS
		{
			get	
			{	
				return (System.String)base.GetValue("SOLine_ItemInfo_ItemID_SPECS",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SOLine_ItemInfo_ItemID_SPECS",value);
			}
		}
		 
		 
				/// <summary>
		/// 单价 (该属性不可为空,但有默认值)
		/// SOLineInfoQryDTO.Misc.单价
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal SOLine_FinallyPriceTC
		{
			get	
			{	
				return (System.Decimal)base.GetValue("SOLine_FinallyPriceTC",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("SOLine_FinallyPriceTC",value);
			}
		}
		 
				/// <summary>
		/// 数量 (该属性不可为空,但有默认值)
		/// SOLineInfoQryDTO.Misc.数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal SOLine_OrderByQtyTU
		{
			get	
			{	
				return (System.Decimal)base.GetValue("SOLine_OrderByQtyTU",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("SOLine_OrderByQtyTU",value);
			}
		}
				/// <summary>
		/// 行号 (该属性不可为空,但有默认值)
		/// SOLineInfoQryDTO.Misc.行号
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 SOLine_DocLineNo
		{
			get	
			{	
				return (System.Int32)base.GetValue("SOLine_DocLineNo",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("SOLine_DocLineNo",value);
			}
		}
				/// <summary>
		/// 金额 (该属性不可为空,但有默认值)
		/// SOLineInfoQryDTO.Misc.金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal SOLine_TotalMoneyTC
		{
			get	
			{	
				return (System.Decimal)base.GetValue("SOLine_TotalMoneyTC",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("SOLine_TotalMoneyTC",value);
			}
		}
				/// <summary>
		/// 包装数 (该属性可为空,且无默认值)
		/// SOLineInfoQryDTO.Misc.包装数
		/// </summary>
		/// <value>System.String</value>
		public System.String SOLine_ItemInfo_ItemID_DescFlexField_PrivateDescSeg5
		{
			get	
			{	
				return (System.String)base.GetValue("SOLine_ItemInfo_ItemID_DescFlexField_PrivateDescSeg5",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SOLine_ItemInfo_ItemID_DescFlexField_PrivateDescSeg5",value);
			}
		}
				/// <summary>
		/// 销售单位_精度_精度 (该属性不可为空,但有默认值)
		/// SOLineInfoQryDTO.Misc.销售单位_精度_精度
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 SOLine_TU_Round_Precision
		{
			get	
			{	
				return (System.Int32)base.GetValue("SOLine_TU_Round_Precision",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("SOLine_TU_Round_Precision",value);
			}
		}
				/// <summary>
		/// 销售单位_精度_舍入类型 (该属性不可为空,但有默认值)
		/// SOLineInfoQryDTO.Misc.销售单位_精度_舍入类型
		/// </summary>
		/// <value>UFIDA.U9.Base.PropertyTypes.RoundTypeEnum</value>
		public UFIDA.U9.Base.PropertyTypes.RoundTypeEnum SOLine_TU_Round_RoundType
		{
			get	
			{	
				return (UFIDA.U9.Base.PropertyTypes.RoundTypeEnum)base.GetValue("SOLine_TU_Round_RoundType",typeof(UFIDA.U9.Base.PropertyTypes.RoundTypeEnum));
			}

			 set	
			{
				base.SetValue("SOLine_TU_Round_RoundType",value);
			}
		}
				/// <summary>
		/// 销售单位_精度_舍入值 (该属性可为空,但有默认值)
		/// SOLineInfoQryDTO.Misc.销售单位_精度_舍入值
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 SOLine_TU_Round_RoundValue
		{
			get	
			{	
				return (System.Int32)base.GetValue("SOLine_TU_Round_RoundValue",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("SOLine_TU_Round_RoundValue",value);
			}
		}
				/// <summary>
		/// 累计出货数量 (该属性可为空,但有默认值)
		/// SOLineInfoQryDTO.Misc.累计出货数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal TotalShipQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("TotalShipQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("TotalShipQty",value);
			}
		}
				/// <summary>
		/// 累计出货金额 (该属性可为空,但有默认值)
		/// SOLineInfoQryDTO.Misc.累计出货金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal TotalShipMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("TotalShipMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("TotalShipMoney",value);
			}
		}
				/// <summary>
		/// 调整后金额 (该属性可为空,但有默认值)
		/// SOLineInfoQryDTO.Misc.调整后金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal AfterAdjustedMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("AfterAdjustedMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("AfterAdjustedMoney",value);
			}
		}
				/// <summary>
		/// 调整后单价 (该属性可为空,但有默认值)
		/// SOLineInfoQryDTO.Misc.调整后单价
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal AfterAdjustedPrice
		{
			get	
			{	
				return (System.Decimal)base.GetValue("AfterAdjustedPrice",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("AfterAdjustedPrice",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
						 
		/// <summary>
		/// 名称
		/// SOLineInfoQryDTO.Misc.名称
		/// </summary>
		public string SOLine_PU_Name
		{
			get
			{
				return base.GetMultiLangProp("SOLine_PU_Name");
			}
			set
			{
				base.SetMultiLangProp("SOLine_PU_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_SOLine_PU_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_SOLine_PU_Name
		{
			get
			{
				return base.GetMultiLangPropDict("SOLine_PU_Name");
			}
			set
			{
				base.SetMultiLangPropDict("SOLine_PU_Name",value);	
			}
		}
	 
		/// <summary>
		/// 名称
		/// SOLineInfoQryDTO.Misc.名称
		/// </summary>
		public string SOLine_CU_Name
		{
			get
			{
				return base.GetMultiLangProp("SOLine_CU_Name");
			}
			set
			{
				base.SetMultiLangProp("SOLine_CU_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_SOLine_CU_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_SOLine_CU_Name
		{
			get
			{
				return base.GetMultiLangPropDict("SOLine_CU_Name");
			}
			set
			{
				base.SetMultiLangPropDict("SOLine_CU_Name",value);	
			}
		}
		 
		/// <summary>
		/// 备注
		/// SOLineInfoQryDTO.Misc.备注
		/// </summary>
		public string SOLine_Memo
		{
			get
			{
				return base.GetMultiLangProp("SOLine_Memo");
			}
			set
			{
				base.SetMultiLangProp("SOLine_Memo",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_SOLine_Memo ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_SOLine_Memo
		{
			get
			{
				return base.GetMultiLangPropDict("SOLine_Memo");
			}
			set
			{
				base.SetMultiLangPropDict("SOLine_Memo",value);	
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
		/// SOLineInfoQryDTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SOLine_ID　{ get { return "";　}　}
		/// <summary>
		/// 料号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SOLine_ItemInfo_ItemCode　{ get { return "";　}　}
		/// <summary>
		/// 品名的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SOLine_ItemInfo_ItemName　{ get { return "";　}　}
		/// <summary>
		/// 型号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SOLine_ItemInfo_ItemID_SPECS　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SOLine_PU_Name　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SOLine_CU_Name　{ get { return "";　}　}
		/// <summary>
		/// 单价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SOLine_FinallyPriceTC　{ get { return "";　}　}
		/// <summary>
		/// 备注的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SOLine_Memo　{ get { return "";　}　}
		/// <summary>
		/// 数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SOLine_OrderByQtyTU　{ get { return "";　}　}
		/// <summary>
		/// 行号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SOLine_DocLineNo　{ get { return "";　}　}
		/// <summary>
		/// 金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SOLine_TotalMoneyTC　{ get { return "";　}　}
		/// <summary>
		/// 包装数的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SOLine_ItemInfo_ItemID_DescFlexField_PrivateDescSeg5　{ get { return "";　}　}
		/// <summary>
		/// 销售单位_精度_精度的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SOLine_TU_Round_Precision　{ get { return "";　}　}
		/// <summary>
		/// 销售单位_精度_舍入类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SOLine_TU_Round_RoundType　{ get { return "";　}　}
		/// <summary>
		/// 销售单位_精度_舍入值的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SOLine_TU_Round_RoundValue　{ get { return "";　}　}
		/// <summary>
		/// 累计出货数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TotalShipQty　{ get { return "";　}　}
		/// <summary>
		/// 累计出货金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TotalShipMoney　{ get { return "";　}　}
		/// <summary>
		/// 调整后金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AfterAdjustedMoney　{ get { return "";　}　}
		/// <summary>
		/// 调整后单价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AfterAdjustedPrice　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SOLineInfoQryDTOData data)
		{
		




















		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SOLineInfoQryDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SOLineInfoQryDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
			this.RecordCount = data.RecordCount ;
		
			this.ID = data.ID;

			this.SOLine_ID = data.SOLine_ID;

			this.SOLine_ItemInfo_ItemCode = data.SOLine_ItemInfo_ItemCode;

			this.SOLine_ItemInfo_ItemName = data.SOLine_ItemInfo_ItemName;

			this.SOLine_ItemInfo_ItemID_SPECS = data.SOLine_ItemInfo_ItemID_SPECS;

			this.SOLine_PU_Name = data.SOLine_PU_Name;
			this.Multi_SOLine_PU_Name = data.Multi_SOLine_PU_Name ;

			this.SOLine_CU_Name = data.SOLine_CU_Name;
			this.Multi_SOLine_CU_Name = data.Multi_SOLine_CU_Name ;

			this.SOLine_FinallyPriceTC = data.SOLine_FinallyPriceTC;

			this.SOLine_Memo = data.SOLine_Memo;
			this.Multi_SOLine_Memo = data.Multi_SOLine_Memo ;

			this.SOLine_OrderByQtyTU = data.SOLine_OrderByQtyTU;

			this.SOLine_DocLineNo = data.SOLine_DocLineNo;

			this.SOLine_TotalMoneyTC = data.SOLine_TotalMoneyTC;

			this.SOLine_ItemInfo_ItemID_DescFlexField_PrivateDescSeg5 = data.SOLine_ItemInfo_ItemID_DescFlexField_PrivateDescSeg5;

			this.SOLine_TU_Round_Precision = data.SOLine_TU_Round_Precision;

			this.SOLine_TU_Round_RoundType = UFIDA.U9.Base.PropertyTypes.RoundTypeEnum.GetFromValue(data.SOLine_TU_Round_RoundType);

			this.SOLine_TU_Round_RoundValue = data.SOLine_TU_Round_RoundValue;

			this.TotalShipQty = data.TotalShipQty;

			this.TotalShipMoney = data.TotalShipMoney;

			this.AfterAdjustedMoney = data.AfterAdjustedMoney;

			this.AfterAdjustedPrice = data.AfterAdjustedPrice;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SOLineInfoQryDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SOLineInfoQryDTOData ToEntityData(SOLineInfoQryDTOData data, IDictionary dict){
			if (data == null)
				data = new SOLineInfoQryDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SOLineInfoQryDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			data.ID = this.ID;

			data.SOLine_ID = this.SOLine_ID;

			data.SOLine_ItemInfo_ItemCode = this.SOLine_ItemInfo_ItemCode;

			data.SOLine_ItemInfo_ItemName = this.SOLine_ItemInfo_ItemName;

			data.SOLine_ItemInfo_ItemID_SPECS = this.SOLine_ItemInfo_ItemID_SPECS;

			data.SOLine_PU_Name  = this.SOLine_PU_Name;
			data.Multi_SOLine_PU_Name  = this.Multi_SOLine_PU_Name;

			data.SOLine_CU_Name  = this.SOLine_CU_Name;
			data.Multi_SOLine_CU_Name  = this.Multi_SOLine_CU_Name;

			data.SOLine_FinallyPriceTC = this.SOLine_FinallyPriceTC;

			data.SOLine_Memo  = this.SOLine_Memo;
			data.Multi_SOLine_Memo  = this.Multi_SOLine_Memo;

			data.SOLine_OrderByQtyTU = this.SOLine_OrderByQtyTU;

			data.SOLine_DocLineNo = this.SOLine_DocLineNo;

			data.SOLine_TotalMoneyTC = this.SOLine_TotalMoneyTC;

			data.SOLine_ItemInfo_ItemID_DescFlexField_PrivateDescSeg5 = this.SOLine_ItemInfo_ItemID_DescFlexField_PrivateDescSeg5;

			data.SOLine_TU_Round_Precision = this.SOLine_TU_Round_Precision;

			if (this.SOLine_TU_Round_RoundType!=null)
			{
				data.SOLine_TU_Round_RoundType = this.SOLine_TU_Round_RoundType.Value;
			}

			data.SOLine_TU_Round_RoundValue = this.SOLine_TU_Round_RoundValue;

			data.TotalShipQty = this.TotalShipQty;

			data.TotalShipMoney = this.TotalShipMoney;

			data.AfterAdjustedMoney = this.AfterAdjustedMoney;

			data.AfterAdjustedPrice = this.AfterAdjustedPrice;

			return data ;
		}

		#endregion	
	}	
	
}