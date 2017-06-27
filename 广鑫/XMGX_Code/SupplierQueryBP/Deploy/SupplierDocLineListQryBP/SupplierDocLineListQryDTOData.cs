



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.SupplierDocLineListQryBP
{
	/// <summary>
	/// SupplierDocLineListQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.FJGX.SupplierDocLineListQryBP.SupplierDocLineListQryDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class SupplierDocLineListQryDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public SupplierDocLineListQryDTOData()
		{
			initData();
		}
		private void initData()
		{
					ID= 0; 
				
		
		
		
		
					PackageNum=0m; 
					QtyTU=0m; 
		
					PieceOrMeterQty=0m; 
		
					FinallyPriceTC=0m; 
					ArriveTotalMnyTC=0m; 
		
					DocLineNo= 0; 
				
					RcvLine_TradeUOM_Round_Precision= 0; 
							RcvLine_TradeUOM_Round_RoundType= 0; 
							RcvLine_TradeUOM_Round_RoundValue= 0; 
		
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
		public SupplierDocLineListQryDTOData(  System.Int64 iD  , System.String docNo  , System.DateTime businessDate  , System.String itemCode  , System.String itemName  , System.String sPECS  , System.Decimal packageNum  , System.Decimal qtyTU  , System.String tradeUOMName  , System.Decimal pieceOrMeterQty  , System.String assistUOMName  , System.Decimal finallyPriceTC  , System.Decimal arriveTotalMnyTC  , System.String createdBy  , System.Int32 docLineNo  , System.String memo  , System.Int32 rcvLine_TradeUOM_Round_Precision  , System.Int32 rcvLine_TradeUOM_Round_RoundType  , System.Int32 rcvLine_TradeUOM_Round_RoundValue  )
		{
			initData();
			this.ID = iD;
			this.DocNo = docNo;
			this.BusinessDate = businessDate;
			this.ItemCode = itemCode;
			this.ItemName = itemName;
			this.SPECS = sPECS;
			this.PackageNum = packageNum;
			this.QtyTU = qtyTU;
			this.TradeUOMName = tradeUOMName;
			this.PieceOrMeterQty = pieceOrMeterQty;
			this.AssistUOMName = assistUOMName;
			this.FinallyPriceTC = finallyPriceTC;
			this.ArriveTotalMnyTC = arriveTotalMnyTC;
			this.CreatedBy = createdBy;
			this.DocLineNo = docLineNo;
			this.Memo = memo;
			this.RcvLine_TradeUOM_Round_Precision = rcvLine_TradeUOM_Round_Precision;
			this.RcvLine_TradeUOM_Round_RoundType = rcvLine_TradeUOM_Round_RoundType;
			this.RcvLine_TradeUOM_Round_RoundValue = rcvLine_TradeUOM_Round_RoundValue;
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
		/// SupplierDocLineListQryDTO.Misc.ID
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
		/// 单号
		/// SupplierDocLineListQryDTO.Misc.单号
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
		/// 单据日期
		/// SupplierDocLineListQryDTO.Misc.单据日期
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
		/// 存货编码
		/// SupplierDocLineListQryDTO.Misc.存货编码
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
		/// SupplierDocLineListQryDTO.Misc.存货名称
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
		/// 规格型号
		/// SupplierDocLineListQryDTO.Misc.规格型号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sPECS ;
		public System.String SPECS
		{
			get	
			{	
				return m_sPECS ;
			}
			set	
			{	
				m_sPECS = value ;	
			}
		}
			
		

		/// <summary>
		/// 包装数
		/// SupplierDocLineListQryDTO.Misc.包装数
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_packageNum ;
		public System.Decimal PackageNum
		{
			get	
			{	
				return m_packageNum ;
			}
			set	
			{	
				m_packageNum = value ;	
			}
		}
			
		

		/// <summary>
		/// 数量
		/// SupplierDocLineListQryDTO.Misc.数量
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
		/// SupplierDocLineListQryDTO.Misc.采购单位
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
		/// 件数/米数
		/// SupplierDocLineListQryDTO.Misc.件数/米数
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_pieceOrMeterQty ;
		public System.Decimal PieceOrMeterQty
		{
			get	
			{	
				return m_pieceOrMeterQty ;
			}
			set	
			{	
				m_pieceOrMeterQty = value ;	
			}
		}
			
		

		/// <summary>
		/// 辅助计量单位
		/// SupplierDocLineListQryDTO.Misc.辅助计量单位
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_assistUOMName ;
		public System.String AssistUOMName
		{
			get	
			{	
				return m_assistUOMName ;
			}
			set	
			{	
				m_assistUOMName = value ;	
			}
		}
			
		

		/// <summary>
		/// 单价
		/// SupplierDocLineListQryDTO.Misc.单价
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
		/// SupplierDocLineListQryDTO.Misc.金额
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
		/// 制单人
		/// SupplierDocLineListQryDTO.Misc.制单人
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
		/// 行号
		/// SupplierDocLineListQryDTO.Misc.行号
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
		/// 备注
		/// SupplierDocLineListQryDTO.Misc.备注
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
		/// 收货行_采购单位_精度_精度
		/// SupplierDocLineListQryDTO.Misc.收货行_采购单位_精度_精度
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_rcvLine_TradeUOM_Round_Precision ;
		public System.Int32 RcvLine_TradeUOM_Round_Precision
		{
			get	
			{	
				return m_rcvLine_TradeUOM_Round_Precision ;
			}
			set	
			{	
				m_rcvLine_TradeUOM_Round_Precision = value ;	
			}
		}
			
		

		/// <summary>
		/// 收货行_采购单位_精度_舍入类型
		/// SupplierDocLineListQryDTO.Misc.收货行_采购单位_精度_舍入类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_rcvLine_TradeUOM_Round_RoundType ;
		public System.Int32 RcvLine_TradeUOM_Round_RoundType
		{
			get	
			{	
				return m_rcvLine_TradeUOM_Round_RoundType ;
			}
			set	
			{	
				m_rcvLine_TradeUOM_Round_RoundType = value ;	
			}
		}
			
		

		/// <summary>
		/// 收货行_采购单位_精度_舍入值
		/// SupplierDocLineListQryDTO.Misc.收货行_采购单位_精度_舍入值
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_rcvLine_TradeUOM_Round_RoundValue ;
		public System.Int32 RcvLine_TradeUOM_Round_RoundValue
		{
			get	
			{	
				return m_rcvLine_TradeUOM_Round_RoundValue ;
			}
			set	
			{	
				m_rcvLine_TradeUOM_Round_RoundValue = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																																						
		#endregion 
	} 	
}

	
