


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.SupplierDocLineListQryBP
{
	/// <summary>
	/// SupplierDocLineListQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SupplierDocLineListQryDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SupplierDocLineListQryDTO(){
			initData();
		}
		private void initData()
		{
					ID = 0; 
		
		
		
		
		
					PackageNum = 0m; 
					QtyTU = 0m; 
		
					PieceOrMeterQty = 0m; 
		
					FinallyPriceTC = 0m; 
					ArriveTotalMnyTC = 0m; 
		
					DocLineNo = 0; 
		
					RcvLine_TradeUOM_Round_Precision = 0; 
					RcvLine_TradeUOM_Round_RoundType =UFIDA.U9.Base.PropertyTypes.RoundTypeEnum.GetFromValue(0); 
					RcvLine_TradeUOM_Round_RoundValue = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// SupplierDocLineListQryDTO.Misc.ID
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
		/// 单号 (该属性可为空,且无默认值)
		/// SupplierDocLineListQryDTO.Misc.单号
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
		/// 单据日期 (该属性可为空,且无默认值)
		/// SupplierDocLineListQryDTO.Misc.单据日期
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
		/// 存货编码 (该属性可为空,且无默认值)
		/// SupplierDocLineListQryDTO.Misc.存货编码
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
		/// SupplierDocLineListQryDTO.Misc.存货名称
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
		/// SupplierDocLineListQryDTO.Misc.规格型号
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
		/// 包装数 (该属性可为空,但有默认值)
		/// SupplierDocLineListQryDTO.Misc.包装数
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal PackageNum
		{
			get	
			{	
				return (System.Decimal)base.GetValue("PackageNum",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("PackageNum",value);
			}
		}
				/// <summary>
		/// 数量 (该属性可为空,但有默认值)
		/// SupplierDocLineListQryDTO.Misc.数量
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
		/// SupplierDocLineListQryDTO.Misc.采购单位
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
		/// 件数/米数 (该属性可为空,但有默认值)
		/// SupplierDocLineListQryDTO.Misc.件数/米数
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal PieceOrMeterQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("PieceOrMeterQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("PieceOrMeterQty",value);
			}
		}
				/// <summary>
		/// 辅助计量单位 (该属性可为空,且无默认值)
		/// SupplierDocLineListQryDTO.Misc.辅助计量单位
		/// </summary>
		/// <value>System.String</value>
		public System.String AssistUOMName
		{
			get	
			{	
				return (System.String)base.GetValue("AssistUOMName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("AssistUOMName",value);
			}
		}
				/// <summary>
		/// 单价 (该属性可为空,但有默认值)
		/// SupplierDocLineListQryDTO.Misc.单价
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
		/// SupplierDocLineListQryDTO.Misc.金额
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
		/// 制单人 (该属性可为空,且无默认值)
		/// SupplierDocLineListQryDTO.Misc.制单人
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
		/// 行号 (该属性可为空,但有默认值)
		/// SupplierDocLineListQryDTO.Misc.行号
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
		/// 备注 (该属性可为空,且无默认值)
		/// SupplierDocLineListQryDTO.Misc.备注
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
		/// 收货行_采购单位_精度_精度 (该属性不可为空,但有默认值)
		/// SupplierDocLineListQryDTO.Misc.收货行_采购单位_精度_精度
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 RcvLine_TradeUOM_Round_Precision
		{
			get	
			{	
				return (System.Int32)base.GetValue("RcvLine_TradeUOM_Round_Precision",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("RcvLine_TradeUOM_Round_Precision",value);
			}
		}
				/// <summary>
		/// 收货行_采购单位_精度_舍入类型 (该属性不可为空,但有默认值)
		/// SupplierDocLineListQryDTO.Misc.收货行_采购单位_精度_舍入类型
		/// </summary>
		/// <value>UFIDA.U9.Base.PropertyTypes.RoundTypeEnum</value>
		public UFIDA.U9.Base.PropertyTypes.RoundTypeEnum RcvLine_TradeUOM_Round_RoundType
		{
			get	
			{	
				return (UFIDA.U9.Base.PropertyTypes.RoundTypeEnum)base.GetValue("RcvLine_TradeUOM_Round_RoundType",typeof(UFIDA.U9.Base.PropertyTypes.RoundTypeEnum));
			}

			 set	
			{
				base.SetValue("RcvLine_TradeUOM_Round_RoundType",value);
			}
		}
				/// <summary>
		/// 收货行_采购单位_精度_舍入值 (该属性可为空,但有默认值)
		/// SupplierDocLineListQryDTO.Misc.收货行_采购单位_精度_舍入值
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 RcvLine_TradeUOM_Round_RoundValue
		{
			get	
			{	
				return (System.Int32)base.GetValue("RcvLine_TradeUOM_Round_RoundValue",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("RcvLine_TradeUOM_Round_RoundValue",value);
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
		/// SupplierDocLineListQryDTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocNo　{ get { return "";　}　}
		/// <summary>
		/// 单据日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BusinessDate　{ get { return "";　}　}
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
		/// 包装数的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PackageNum　{ get { return "";　}　}
		/// <summary>
		/// 数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_QtyTU　{ get { return "";　}　}
		/// <summary>
		/// 采购单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TradeUOMName　{ get { return "";　}　}
		/// <summary>
		/// 件数/米数的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PieceOrMeterQty　{ get { return "";　}　}
		/// <summary>
		/// 辅助计量单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AssistUOMName　{ get { return "";　}　}
		/// <summary>
		/// 单价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_FinallyPriceTC　{ get { return "";　}　}
		/// <summary>
		/// 金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ArriveTotalMnyTC　{ get { return "";　}　}
		/// <summary>
		/// 制单人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CreatedBy　{ get { return "";　}　}
		/// <summary>
		/// 行号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocLineNo　{ get { return "";　}　}
		/// <summary>
		/// 备注的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Memo　{ get { return "";　}　}
		/// <summary>
		/// 收货行_采购单位_精度_精度的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RcvLine_TradeUOM_Round_Precision　{ get { return "";　}　}
		/// <summary>
		/// 收货行_采购单位_精度_舍入类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RcvLine_TradeUOM_Round_RoundType　{ get { return "";　}　}
		/// <summary>
		/// 收货行_采购单位_精度_舍入值的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RcvLine_TradeUOM_Round_RoundValue　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SupplierDocLineListQryDTOData data)
		{
		



















		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SupplierDocLineListQryDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SupplierDocLineListQryDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
			this.RecordCount = data.RecordCount ;
		
			this.ID = data.ID;

			this.DocNo = data.DocNo;

			this.BusinessDate = data.BusinessDate;

			this.ItemCode = data.ItemCode;

			this.ItemName = data.ItemName;

			this.SPECS = data.SPECS;

			this.PackageNum = data.PackageNum;

			this.QtyTU = data.QtyTU;

			this.TradeUOMName = data.TradeUOMName;

			this.PieceOrMeterQty = data.PieceOrMeterQty;

			this.AssistUOMName = data.AssistUOMName;

			this.FinallyPriceTC = data.FinallyPriceTC;

			this.ArriveTotalMnyTC = data.ArriveTotalMnyTC;

			this.CreatedBy = data.CreatedBy;

			this.DocLineNo = data.DocLineNo;

			this.Memo = data.Memo;

			this.RcvLine_TradeUOM_Round_Precision = data.RcvLine_TradeUOM_Round_Precision;

			this.RcvLine_TradeUOM_Round_RoundType = UFIDA.U9.Base.PropertyTypes.RoundTypeEnum.GetFromValue(data.RcvLine_TradeUOM_Round_RoundType);

			this.RcvLine_TradeUOM_Round_RoundValue = data.RcvLine_TradeUOM_Round_RoundValue;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SupplierDocLineListQryDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SupplierDocLineListQryDTOData ToEntityData(SupplierDocLineListQryDTOData data, IDictionary dict){
			if (data == null)
				data = new SupplierDocLineListQryDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SupplierDocLineListQryDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			data.ID = this.ID;

			data.DocNo = this.DocNo;

			data.BusinessDate = this.BusinessDate;

			data.ItemCode = this.ItemCode;

			data.ItemName = this.ItemName;

			data.SPECS = this.SPECS;

			data.PackageNum = this.PackageNum;

			data.QtyTU = this.QtyTU;

			data.TradeUOMName = this.TradeUOMName;

			data.PieceOrMeterQty = this.PieceOrMeterQty;

			data.AssistUOMName = this.AssistUOMName;

			data.FinallyPriceTC = this.FinallyPriceTC;

			data.ArriveTotalMnyTC = this.ArriveTotalMnyTC;

			data.CreatedBy = this.CreatedBy;

			data.DocLineNo = this.DocLineNo;

			data.Memo = this.Memo;

			data.RcvLine_TradeUOM_Round_Precision = this.RcvLine_TradeUOM_Round_Precision;

			if (this.RcvLine_TradeUOM_Round_RoundType!=null)
			{
				data.RcvLine_TradeUOM_Round_RoundType = this.RcvLine_TradeUOM_Round_RoundType.Value;
			}

			data.RcvLine_TradeUOM_Round_RoundValue = this.RcvLine_TradeUOM_Round_RoundValue;

			return data ;
		}

		#endregion	
	}	
	
}