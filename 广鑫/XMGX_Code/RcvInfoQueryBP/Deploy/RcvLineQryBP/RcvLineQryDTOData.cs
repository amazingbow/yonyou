



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UIFIA.U9.Cust.FJGX.RcvLineQryBP
{
	/// <summary>
	/// RcvLineQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UIFIA.U9.Cust.FJGX.RcvLineQryBP.RcvLineQryDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class RcvLineQryDTOData : UFSoft.UBF.Business.DataTransObjectBase
	{
		public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
                                                                                                                                                                                                                                                                                                                                                                                         
            knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RcvLineQryDTOData()
		{
			initData();
		}
		private void initData()
		{
					ID= 0; 
							DocLineNo= 0; 
				
		
		
		
		
					QtyTU=0m; 
		
					QtySU=0m; 
		
					QtyCU=0m; 
		
		
					FinallyPriceTC=0m; 
					ArriveTotalMnyTC=0m; 
					Ratio=0m; 
					PieceQty=0m; 
		
		
					TradeUOM_Round_Precision= 0; 
							TradeUOM_Round_RoundType= 0; 
							TradeUOM_Round_RoundValue= 0; 
							StoreUOM_Round_Precision= 0; 
							StoreUOM_Round_RoundType= 0; 
							StoreUOM_Round_RoundValue= 0; 
							CostUOM_Round_Precision= 0; 
							CostUOM_Round_RoundType= 0; 
							CostUOM_Round_RoundValue= 0; 
		
			//调用默认值初始化服务进行配置方式初始化
			UFSoft.UBF.Service.DTOService.InitConfigDefault(this);
		}
		[System.Runtime.Serialization.OnDeserializing]
        internal void OnDeserializing(System.Runtime.Serialization.StreamingContext context)
        {
			 initData();
        }
		#region Do SerializeKey -ForDTODataType
		//只为处理集合型EntityKey。原因集合型EntityKey由于使用臫的集合对象，无法实现数据共享.-UBF专用.
		public void DoSerializeKeyList(IDictionary dict)
		{
			if (dict == null ) dict = new Hashtable() ;
			if (dict[this] != null)
				return ;
			dict[this] = this;
	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        	        
		}
		#endregion 
		/// <summary>
		/// Constructor Full Argument
		/// </summary>
		public RcvLineQryDTOData(  System.Int64 iD  , System.Int32 docLineNo  , System.String itemCode  , System.String itemName  , System.DateTime businessDate  , System.String docNo  , System.String sPEC  , System.Decimal qtyTU  , System.String tradeUOMName  , System.Decimal qtySU  , System.String storeUOMName  , System.Decimal qtyCU  , System.String costUOMName  , System.String lotCode  , System.Decimal finallyPriceTC  , System.Decimal arriveTotalMnyTC  , System.Decimal ratio  , System.Decimal pieceQty  , System.String createdBy  , System.String memo  , System.Int32 tradeUOM_Round_Precision  , System.Int32 tradeUOM_Round_RoundType  , System.Int32 tradeUOM_Round_RoundValue  , System.Int32 storeUOM_Round_Precision  , System.Int32 storeUOM_Round_RoundType  , System.Int32 storeUOM_Round_RoundValue  , System.Int32 costUOM_Round_Precision  , System.Int32 costUOM_Round_RoundType  , System.Int32 costUOM_Round_RoundValue  )
		{
			initData();
			this.ID = iD;
			this.DocLineNo = docLineNo;
			this.ItemCode = itemCode;
			this.ItemName = itemName;
			this.BusinessDate = businessDate;
			this.DocNo = docNo;
			this.SPEC = sPEC;
			this.QtyTU = qtyTU;
			this.TradeUOMName = tradeUOMName;
			this.QtySU = qtySU;
			this.StoreUOMName = storeUOMName;
			this.QtyCU = qtyCU;
			this.CostUOMName = costUOMName;
			this.LotCode = lotCode;
			this.FinallyPriceTC = finallyPriceTC;
			this.ArriveTotalMnyTC = arriveTotalMnyTC;
			this.Ratio = ratio;
			this.PieceQty = pieceQty;
			this.CreatedBy = createdBy;
			this.Memo = memo;
			this.TradeUOM_Round_Precision = tradeUOM_Round_Precision;
			this.TradeUOM_Round_RoundType = tradeUOM_Round_RoundType;
			this.TradeUOM_Round_RoundValue = tradeUOM_Round_RoundValue;
			this.StoreUOM_Round_Precision = storeUOM_Round_Precision;
			this.StoreUOM_Round_RoundType = storeUOM_Round_RoundType;
			this.StoreUOM_Round_RoundValue = storeUOM_Round_RoundValue;
			this.CostUOM_Round_Precision = costUOM_Round_Precision;
			this.CostUOM_Round_RoundType = costUOM_Round_RoundType;
			this.CostUOM_Round_RoundValue = costUOM_Round_RoundValue;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		#region  QuaryDTO Add Prop
		private int m_recordCount ;
		public int  RecordCount 
		{
			get {return m_recordCount ;}
			set { m_recordCount = value ;}
		}
		#endregion 
		
		#region DTO Properties 
	
		

		/// <summary>
		/// ID
		/// RcvLineQryDTO.Misc.ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_iD ;
		public System.Int64 ID
		{
			get	
			{	
				return m_iD ;
			}
			set	
			{	
				m_iD = value ;	
			}
		}
			
		

		/// <summary>
		/// 行号
		/// RcvLineQryDTO.Misc.行号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_docLineNo ;
		public System.Int32 DocLineNo
		{
			get	
			{	
				return m_docLineNo ;
			}
			set	
			{	
				m_docLineNo = value ;	
			}
		}
			
		

		/// <summary>
		/// 存货编码
		/// RcvLineQryDTO.Misc.存货编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_itemCode ;
		public System.String ItemCode
		{
			get	
			{	
				return m_itemCode ;
			}
			set	
			{	
				m_itemCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 存货名称
		/// RcvLineQryDTO.Misc.存货名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_itemName ;
		public System.String ItemName
		{
			get	
			{	
				return m_itemName ;
			}
			set	
			{	
				m_itemName = value ;	
			}
		}
			
		

		/// <summary>
		/// 单据日期
		/// RcvLineQryDTO.Misc.单据日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_businessDate ;
		public System.DateTime BusinessDate
		{
			get	
			{	
				return m_businessDate ;
			}
			set	
			{	
				m_businessDate = value ;	
			}
		}
			
		

		/// <summary>
		/// 单据号
		/// RcvLineQryDTO.Misc.单据号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_docNo ;
		public System.String DocNo
		{
			get	
			{	
				return m_docNo ;
			}
			set	
			{	
				m_docNo = value ;	
			}
		}
			
		

		/// <summary>
		/// 规格
		/// RcvLineQryDTO.Misc.规格
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sPEC ;
		public System.String SPEC
		{
			get	
			{	
				return m_sPEC ;
			}
			set	
			{	
				m_sPEC = value ;	
			}
		}
			
		

		/// <summary>
		/// 采购数量
		/// RcvLineQryDTO.Misc.采购数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_qtyTU ;
		public System.Decimal QtyTU
		{
			get	
			{	
				return m_qtyTU ;
			}
			set	
			{	
				m_qtyTU = value ;	
			}
		}
			
		

		/// <summary>
		/// 采购单位
		/// RcvLineQryDTO.Misc.采购单位
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_tradeUOMName ;
		public System.String TradeUOMName
		{
			get	
			{	
				return m_tradeUOMName ;
			}
			set	
			{	
				m_tradeUOMName = value ;	
			}
		}
			
		

		/// <summary>
		/// 库存数量
		/// RcvLineQryDTO.Misc.库存数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_qtySU ;
		public System.Decimal QtySU
		{
			get	
			{	
				return m_qtySU ;
			}
			set	
			{	
				m_qtySU = value ;	
			}
		}
			
		

		/// <summary>
		/// 库存单位
		/// RcvLineQryDTO.Misc.库存单位
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_storeUOMName ;
		public System.String StoreUOMName
		{
			get	
			{	
				return m_storeUOMName ;
			}
			set	
			{	
				m_storeUOMName = value ;	
			}
		}
			
		

		/// <summary>
		/// 成本数量
		/// RcvLineQryDTO.Misc.成本数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_qtyCU ;
		public System.Decimal QtyCU
		{
			get	
			{	
				return m_qtyCU ;
			}
			set	
			{	
				m_qtyCU = value ;	
			}
		}
			
		

		/// <summary>
		/// 成本单位
		/// RcvLineQryDTO.Misc.成本单位
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_costUOMName ;
		public System.String CostUOMName
		{
			get	
			{	
				return m_costUOMName ;
			}
			set	
			{	
				m_costUOMName = value ;	
			}
		}
			
		

		/// <summary>
		/// 批号
		/// RcvLineQryDTO.Misc.批号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_lotCode ;
		public System.String LotCode
		{
			get	
			{	
				return m_lotCode ;
			}
			set	
			{	
				m_lotCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 单价
		/// RcvLineQryDTO.Misc.单价
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_finallyPriceTC ;
		public System.Decimal FinallyPriceTC
		{
			get	
			{	
				return m_finallyPriceTC ;
			}
			set	
			{	
				m_finallyPriceTC = value ;	
			}
		}
			
		

		/// <summary>
		/// 金额
		/// RcvLineQryDTO.Misc.金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_arriveTotalMnyTC ;
		public System.Decimal ArriveTotalMnyTC
		{
			get	
			{	
				return m_arriveTotalMnyTC ;
			}
			set	
			{	
				m_arriveTotalMnyTC = value ;	
			}
		}
			
		

		/// <summary>
		/// 换算率
		/// RcvLineQryDTO.Misc.换算率
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_ratio ;
		public System.Decimal Ratio
		{
			get	
			{	
				return m_ratio ;
			}
			set	
			{	
				m_ratio = value ;	
			}
		}
			
		

		/// <summary>
		/// 件数
		/// RcvLineQryDTO.Misc.件数
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_pieceQty ;
		public System.Decimal PieceQty
		{
			get	
			{	
				return m_pieceQty ;
			}
			set	
			{	
				m_pieceQty = value ;	
			}
		}
			
		

		/// <summary>
		/// 制单人
		/// RcvLineQryDTO.Misc.制单人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_createdBy ;
		public System.String CreatedBy
		{
			get	
			{	
				return m_createdBy ;
			}
			set	
			{	
				m_createdBy = value ;	
			}
		}
			
		

		/// <summary>
		/// 备注
		/// RcvLineQryDTO.Misc.备注
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_memo ;
		public System.String Memo
		{
			get	
			{	
				return m_memo ;
			}
			set	
			{	
				m_memo = value ;	
			}
		}
			
		

		/// <summary>
		/// 采购单位_精度_精度
		/// RcvLineQryDTO.Misc.采购单位_精度_精度
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_tradeUOM_Round_Precision ;
		public System.Int32 TradeUOM_Round_Precision
		{
			get	
			{	
				return m_tradeUOM_Round_Precision ;
			}
			set	
			{	
				m_tradeUOM_Round_Precision = value ;	
			}
		}
			
		

		/// <summary>
		/// 采购单位_精度_舍入类型
		/// RcvLineQryDTO.Misc.采购单位_精度_舍入类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_tradeUOM_Round_RoundType ;
		public System.Int32 TradeUOM_Round_RoundType
		{
			get	
			{	
				return m_tradeUOM_Round_RoundType ;
			}
			set	
			{	
				m_tradeUOM_Round_RoundType = value ;	
			}
		}
			
		

		/// <summary>
		/// 采购单位_精度_舍入值
		/// RcvLineQryDTO.Misc.采购单位_精度_舍入值
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_tradeUOM_Round_RoundValue ;
		public System.Int32 TradeUOM_Round_RoundValue
		{
			get	
			{	
				return m_tradeUOM_Round_RoundValue ;
			}
			set	
			{	
				m_tradeUOM_Round_RoundValue = value ;	
			}
		}
			
		

		/// <summary>
		/// 库存单位_精度_精度
		/// RcvLineQryDTO.Misc.库存单位_精度_精度
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_storeUOM_Round_Precision ;
		public System.Int32 StoreUOM_Round_Precision
		{
			get	
			{	
				return m_storeUOM_Round_Precision ;
			}
			set	
			{	
				m_storeUOM_Round_Precision = value ;	
			}
		}
			
		

		/// <summary>
		/// 库存单位_精度_舍入类型
		/// RcvLineQryDTO.Misc.库存单位_精度_舍入类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_storeUOM_Round_RoundType ;
		public System.Int32 StoreUOM_Round_RoundType
		{
			get	
			{	
				return m_storeUOM_Round_RoundType ;
			}
			set	
			{	
				m_storeUOM_Round_RoundType = value ;	
			}
		}
			
		

		/// <summary>
		/// 库存单位_精度_舍入值
		/// RcvLineQryDTO.Misc.库存单位_精度_舍入值
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_storeUOM_Round_RoundValue ;
		public System.Int32 StoreUOM_Round_RoundValue
		{
			get	
			{	
				return m_storeUOM_Round_RoundValue ;
			}
			set	
			{	
				m_storeUOM_Round_RoundValue = value ;	
			}
		}
			
		

		/// <summary>
		/// 成本单位_精度_精度
		/// RcvLineQryDTO.Misc.成本单位_精度_精度
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_costUOM_Round_Precision ;
		public System.Int32 CostUOM_Round_Precision
		{
			get	
			{	
				return m_costUOM_Round_Precision ;
			}
			set	
			{	
				m_costUOM_Round_Precision = value ;	
			}
		}
			
		

		/// <summary>
		/// 成本单位_精度_舍入类型
		/// RcvLineQryDTO.Misc.成本单位_精度_舍入类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_costUOM_Round_RoundType ;
		public System.Int32 CostUOM_Round_RoundType
		{
			get	
			{	
				return m_costUOM_Round_RoundType ;
			}
			set	
			{	
				m_costUOM_Round_RoundType = value ;	
			}
		}
			
		

		/// <summary>
		/// 成本单位_精度_舍入值
		/// RcvLineQryDTO.Misc.成本单位_精度_舍入值
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_costUOM_Round_RoundValue ;
		public System.Int32 CostUOM_Round_RoundValue
		{
			get	
			{	
				return m_costUOM_Round_RoundValue ;
			}
			set	
			{	
				m_costUOM_Round_RoundValue = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																																																										
		#endregion 
	} 	
}

	
