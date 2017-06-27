


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UIFIA.U9.Cust.FJGX.RcvLineQryBP
{
	/// <summary>
	/// RcvLineQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class RcvLineQryDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public RcvLineQryDTO(){
			initData();
		}
		private void initData()
		{
					ID = 0; 
					DocLineNo = 0; 
		
		
		
		
		
					QtyTU = 0m; 
		
					QtySU = 0m; 
		
					QtyCU = 0m; 
		
		
					FinallyPriceTC = 0m; 
					ArriveTotalMnyTC = 0m; 
					Ratio = 0m; 
					PieceQty = 0m; 
		
		
					TradeUOM_Round_Precision = 0; 
					TradeUOM_Round_RoundType = 0; 
					TradeUOM_Round_RoundValue = 0; 
					StoreUOM_Round_Precision = 0; 
					StoreUOM_Round_RoundType = 0; 
					StoreUOM_Round_RoundValue = 0; 
					CostUOM_Round_Precision = 0; 
					CostUOM_Round_RoundType = 0; 
					CostUOM_Round_RoundValue = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// RcvLineQryDTO.Misc.ID
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
		/// 行号 (该属性可为空,但有默认值)
		/// RcvLineQryDTO.Misc.行号
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
		/// 存货编码 (该属性可为空,且无默认值)
		/// RcvLineQryDTO.Misc.存货编码
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
		/// RcvLineQryDTO.Misc.存货名称
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
		/// 单据日期 (该属性可为空,且无默认值)
		/// RcvLineQryDTO.Misc.单据日期
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
		/// RcvLineQryDTO.Misc.单据号
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
		/// 规格 (该属性可为空,且无默认值)
		/// RcvLineQryDTO.Misc.规格
		/// </summary>
		/// <value>System.String</value>
		public System.String SPEC
		{
			get	
			{	
				return (System.String)base.GetValue("SPEC",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SPEC",value);
			}
		}
				/// <summary>
		/// 采购数量 (该属性可为空,但有默认值)
		/// RcvLineQryDTO.Misc.采购数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal QtyTU
		{
			get	
			{	
				return (System.Decimal)base.GetValue("QtyTU",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("QtyTU",value);
			}
		}
				/// <summary>
		/// 采购单位 (该属性可为空,且无默认值)
		/// RcvLineQryDTO.Misc.采购单位
		/// </summary>
		/// <value>System.String</value>
		public System.String TradeUOMName
		{
			get	
			{	
				return (System.String)base.GetValue("TradeUOMName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("TradeUOMName",value);
			}
		}
				/// <summary>
		/// 库存数量 (该属性可为空,但有默认值)
		/// RcvLineQryDTO.Misc.库存数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal QtySU
		{
			get	
			{	
				return (System.Decimal)base.GetValue("QtySU",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("QtySU",value);
			}
		}
				/// <summary>
		/// 库存单位 (该属性可为空,且无默认值)
		/// RcvLineQryDTO.Misc.库存单位
		/// </summary>
		/// <value>System.String</value>
		public System.String StoreUOMName
		{
			get	
			{	
				return (System.String)base.GetValue("StoreUOMName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("StoreUOMName",value);
			}
		}
				/// <summary>
		/// 成本数量 (该属性可为空,但有默认值)
		/// RcvLineQryDTO.Misc.成本数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal QtyCU
		{
			get	
			{	
				return (System.Decimal)base.GetValue("QtyCU",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("QtyCU",value);
			}
		}
				/// <summary>
		/// 成本单位 (该属性可为空,且无默认值)
		/// RcvLineQryDTO.Misc.成本单位
		/// </summary>
		/// <value>System.String</value>
		public System.String CostUOMName
		{
			get	
			{	
				return (System.String)base.GetValue("CostUOMName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CostUOMName",value);
			}
		}
				/// <summary>
		/// 批号 (该属性可为空,且无默认值)
		/// RcvLineQryDTO.Misc.批号
		/// </summary>
		/// <value>System.String</value>
		public System.String LotCode
		{
			get	
			{	
				return (System.String)base.GetValue("LotCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("LotCode",value);
			}
		}
				/// <summary>
		/// 单价 (该属性可为空,但有默认值)
		/// RcvLineQryDTO.Misc.单价
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal FinallyPriceTC
		{
			get	
			{	
				return (System.Decimal)base.GetValue("FinallyPriceTC",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("FinallyPriceTC",value);
			}
		}
				/// <summary>
		/// 金额 (该属性可为空,但有默认值)
		/// RcvLineQryDTO.Misc.金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ArriveTotalMnyTC
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ArriveTotalMnyTC",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ArriveTotalMnyTC",value);
			}
		}
				/// <summary>
		/// 换算率 (该属性可为空,但有默认值)
		/// RcvLineQryDTO.Misc.换算率
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Ratio
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Ratio",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Ratio",value);
			}
		}
				/// <summary>
		/// 件数 (该属性可为空,但有默认值)
		/// RcvLineQryDTO.Misc.件数
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal PieceQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("PieceQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("PieceQty",value);
			}
		}
				/// <summary>
		/// 制单人 (该属性可为空,且无默认值)
		/// RcvLineQryDTO.Misc.制单人
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
		/// 备注 (该属性可为空,且无默认值)
		/// RcvLineQryDTO.Misc.备注
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
		/// 采购单位_精度_精度 (该属性可为空,但有默认值)
		/// RcvLineQryDTO.Misc.采购单位_精度_精度
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 TradeUOM_Round_Precision
		{
			get	
			{	
				return (System.Int32)base.GetValue("TradeUOM_Round_Precision",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("TradeUOM_Round_Precision",value);
			}
		}
				/// <summary>
		/// 采购单位_精度_舍入类型 (该属性可为空,但有默认值)
		/// RcvLineQryDTO.Misc.采购单位_精度_舍入类型
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 TradeUOM_Round_RoundType
		{
			get	
			{	
				return (System.Int32)base.GetValue("TradeUOM_Round_RoundType",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("TradeUOM_Round_RoundType",value);
			}
		}
				/// <summary>
		/// 采购单位_精度_舍入值 (该属性可为空,但有默认值)
		/// RcvLineQryDTO.Misc.采购单位_精度_舍入值
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 TradeUOM_Round_RoundValue
		{
			get	
			{	
				return (System.Int32)base.GetValue("TradeUOM_Round_RoundValue",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("TradeUOM_Round_RoundValue",value);
			}
		}
				/// <summary>
		/// 库存单位_精度_精度 (该属性可为空,但有默认值)
		/// RcvLineQryDTO.Misc.库存单位_精度_精度
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 StoreUOM_Round_Precision
		{
			get	
			{	
				return (System.Int32)base.GetValue("StoreUOM_Round_Precision",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("StoreUOM_Round_Precision",value);
			}
		}
				/// <summary>
		/// 库存单位_精度_舍入类型 (该属性可为空,但有默认值)
		/// RcvLineQryDTO.Misc.库存单位_精度_舍入类型
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 StoreUOM_Round_RoundType
		{
			get	
			{	
				return (System.Int32)base.GetValue("StoreUOM_Round_RoundType",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("StoreUOM_Round_RoundType",value);
			}
		}
				/// <summary>
		/// 库存单位_精度_舍入值 (该属性可为空,但有默认值)
		/// RcvLineQryDTO.Misc.库存单位_精度_舍入值
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 StoreUOM_Round_RoundValue
		{
			get	
			{	
				return (System.Int32)base.GetValue("StoreUOM_Round_RoundValue",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("StoreUOM_Round_RoundValue",value);
			}
		}
				/// <summary>
		/// 成本单位_精度_精度 (该属性可为空,但有默认值)
		/// RcvLineQryDTO.Misc.成本单位_精度_精度
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 CostUOM_Round_Precision
		{
			get	
			{	
				return (System.Int32)base.GetValue("CostUOM_Round_Precision",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("CostUOM_Round_Precision",value);
			}
		}
				/// <summary>
		/// 成本单位_精度_舍入类型 (该属性可为空,但有默认值)
		/// RcvLineQryDTO.Misc.成本单位_精度_舍入类型
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 CostUOM_Round_RoundType
		{
			get	
			{	
				return (System.Int32)base.GetValue("CostUOM_Round_RoundType",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("CostUOM_Round_RoundType",value);
			}
		}
				/// <summary>
		/// 成本单位_精度_舍入值 (该属性可为空,但有默认值)
		/// RcvLineQryDTO.Misc.成本单位_精度_舍入值
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 CostUOM_Round_RoundValue
		{
			get	
			{	
				return (System.Int32)base.GetValue("CostUOM_Round_RoundValue",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("CostUOM_Round_RoundValue",value);
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
		/// RcvLineQryDTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 行号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocLineNo　{ get { return "";　}　}
		/// <summary>
		/// 存货编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemCode　{ get { return "";　}　}
		/// <summary>
		/// 存货名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemName　{ get { return "";　}　}
		/// <summary>
		/// 单据日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BusinessDate　{ get { return "";　}　}
		/// <summary>
		/// 单据号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocNo　{ get { return "";　}　}
		/// <summary>
		/// 规格的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SPEC　{ get { return "";　}　}
		/// <summary>
		/// 采购数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_QtyTU　{ get { return "";　}　}
		/// <summary>
		/// 采购单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TradeUOMName　{ get { return "";　}　}
		/// <summary>
		/// 库存数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_QtySU　{ get { return "";　}　}
		/// <summary>
		/// 库存单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_StoreUOMName　{ get { return "";　}　}
		/// <summary>
		/// 成本数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_QtyCU　{ get { return "";　}　}
		/// <summary>
		/// 成本单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CostUOMName　{ get { return "";　}　}
		/// <summary>
		/// 批号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_LotCode　{ get { return "";　}　}
		/// <summary>
		/// 单价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_FinallyPriceTC　{ get { return "";　}　}
		/// <summary>
		/// 金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ArriveTotalMnyTC　{ get { return "";　}　}
		/// <summary>
		/// 换算率的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Ratio　{ get { return "";　}　}
		/// <summary>
		/// 件数的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PieceQty　{ get { return "";　}　}
		/// <summary>
		/// 制单人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CreatedBy　{ get { return "";　}　}
		/// <summary>
		/// 备注的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Memo　{ get { return "";　}　}
		/// <summary>
		/// 采购单位_精度_精度的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TradeUOM_Round_Precision　{ get { return "";　}　}
		/// <summary>
		/// 采购单位_精度_舍入类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TradeUOM_Round_RoundType　{ get { return "";　}　}
		/// <summary>
		/// 采购单位_精度_舍入值的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TradeUOM_Round_RoundValue　{ get { return "";　}　}
		/// <summary>
		/// 库存单位_精度_精度的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_StoreUOM_Round_Precision　{ get { return "";　}　}
		/// <summary>
		/// 库存单位_精度_舍入类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_StoreUOM_Round_RoundType　{ get { return "";　}　}
		/// <summary>
		/// 库存单位_精度_舍入值的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_StoreUOM_Round_RoundValue　{ get { return "";　}　}
		/// <summary>
		/// 成本单位_精度_精度的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CostUOM_Round_Precision　{ get { return "";　}　}
		/// <summary>
		/// 成本单位_精度_舍入类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CostUOM_Round_RoundType　{ get { return "";　}　}
		/// <summary>
		/// 成本单位_精度_舍入值的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CostUOM_Round_RoundValue　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(RcvLineQryDTOData data)
		{
		





























		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(RcvLineQryDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(RcvLineQryDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
			this.RecordCount = data.RecordCount ;
		
			this.ID = data.ID;

			this.DocLineNo = data.DocLineNo;

			this.ItemCode = data.ItemCode;

			this.ItemName = data.ItemName;

			this.BusinessDate = data.BusinessDate;

			this.DocNo = data.DocNo;

			this.SPEC = data.SPEC;

			this.QtyTU = data.QtyTU;

			this.TradeUOMName = data.TradeUOMName;

			this.QtySU = data.QtySU;

			this.StoreUOMName = data.StoreUOMName;

			this.QtyCU = data.QtyCU;

			this.CostUOMName = data.CostUOMName;

			this.LotCode = data.LotCode;

			this.FinallyPriceTC = data.FinallyPriceTC;

			this.ArriveTotalMnyTC = data.ArriveTotalMnyTC;

			this.Ratio = data.Ratio;

			this.PieceQty = data.PieceQty;

			this.CreatedBy = data.CreatedBy;

			this.Memo = data.Memo;

			this.TradeUOM_Round_Precision = data.TradeUOM_Round_Precision;

			this.TradeUOM_Round_RoundType = data.TradeUOM_Round_RoundType;

			this.TradeUOM_Round_RoundValue = data.TradeUOM_Round_RoundValue;

			this.StoreUOM_Round_Precision = data.StoreUOM_Round_Precision;

			this.StoreUOM_Round_RoundType = data.StoreUOM_Round_RoundType;

			this.StoreUOM_Round_RoundValue = data.StoreUOM_Round_RoundValue;

			this.CostUOM_Round_Precision = data.CostUOM_Round_Precision;

			this.CostUOM_Round_RoundType = data.CostUOM_Round_RoundType;

			this.CostUOM_Round_RoundValue = data.CostUOM_Round_RoundValue;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public RcvLineQryDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public RcvLineQryDTOData ToEntityData(RcvLineQryDTOData data, IDictionary dict){
			if (data == null)
				data = new RcvLineQryDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (RcvLineQryDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			data.ID = this.ID;

			data.DocLineNo = this.DocLineNo;

			data.ItemCode = this.ItemCode;

			data.ItemName = this.ItemName;

			data.BusinessDate = this.BusinessDate;

			data.DocNo = this.DocNo;

			data.SPEC = this.SPEC;

			data.QtyTU = this.QtyTU;

			data.TradeUOMName = this.TradeUOMName;

			data.QtySU = this.QtySU;

			data.StoreUOMName = this.StoreUOMName;

			data.QtyCU = this.QtyCU;

			data.CostUOMName = this.CostUOMName;

			data.LotCode = this.LotCode;

			data.FinallyPriceTC = this.FinallyPriceTC;

			data.ArriveTotalMnyTC = this.ArriveTotalMnyTC;

			data.Ratio = this.Ratio;

			data.PieceQty = this.PieceQty;

			data.CreatedBy = this.CreatedBy;

			data.Memo = this.Memo;

			data.TradeUOM_Round_Precision = this.TradeUOM_Round_Precision;

			data.TradeUOM_Round_RoundType = this.TradeUOM_Round_RoundType;

			data.TradeUOM_Round_RoundValue = this.TradeUOM_Round_RoundValue;

			data.StoreUOM_Round_Precision = this.StoreUOM_Round_Precision;

			data.StoreUOM_Round_RoundType = this.StoreUOM_Round_RoundType;

			data.StoreUOM_Round_RoundValue = this.StoreUOM_Round_RoundValue;

			data.CostUOM_Round_Precision = this.CostUOM_Round_Precision;

			data.CostUOM_Round_RoundType = this.CostUOM_Round_RoundType;

			data.CostUOM_Round_RoundValue = this.CostUOM_Round_RoundValue;

			return data ;
		}

		#endregion	
	}	
	
}