



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.SOLineInfoQryBP
{
	/// <summary>
	/// SOLineInfoQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.FJGX.SOLineInfoQryBP.SOLineInfoQryDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class SOLineInfoQryDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public SOLineInfoQryDTOData()
		{
			initData();
		}
		private void initData()
		{
					ID= 0; 
				
		
		
		
		
		
					SOLine_FinallyPriceTC=0m; 
		
					SOLine_OrderByQtyTU=0m; 
					SOLine_DocLineNo= 0; 
							SOLine_TotalMoneyTC=0m; 
		
					SOLine_TU_Round_Precision= 0; 
							SOLine_TU_Round_RoundType= 0; 
							SOLine_TU_Round_RoundValue= 0; 
							TotalShipQty=0m; 
					TotalShipMoney=0m; 
					AfterAdjustedMoney=0m; 
					AfterAdjustedPrice=0m; 

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
		public SOLineInfoQryDTOData(  System.Int64 iD  , System.Int64 sOLine_ID  , System.String sOLine_ItemInfo_ItemCode  , System.String sOLine_ItemInfo_ItemName  , System.String sOLine_ItemInfo_ItemID_SPECS  , System.String sOLine_PU_Name  , System.String sOLine_CU_Name  , System.Decimal sOLine_FinallyPriceTC  , System.String sOLine_Memo  , System.Decimal sOLine_OrderByQtyTU  , System.Int32 sOLine_DocLineNo  , System.Decimal sOLine_TotalMoneyTC  , System.String sOLine_ItemInfo_ItemID_DescFlexField_PrivateDescSeg5  , System.Int32 sOLine_TU_Round_Precision  , System.Int32 sOLine_TU_Round_RoundType  , System.Int32 sOLine_TU_Round_RoundValue  , System.Decimal totalShipQty  , System.Decimal totalShipMoney  , System.Decimal afterAdjustedMoney  , System.Decimal afterAdjustedPrice  )
		{
			initData();
			this.ID = iD;
			this.SOLine_ID = sOLine_ID;
			this.SOLine_ItemInfo_ItemCode = sOLine_ItemInfo_ItemCode;
			this.SOLine_ItemInfo_ItemName = sOLine_ItemInfo_ItemName;
			this.SOLine_ItemInfo_ItemID_SPECS = sOLine_ItemInfo_ItemID_SPECS;
			this.SOLine_PU_Name = sOLine_PU_Name;
			this.SOLine_CU_Name = sOLine_CU_Name;
			this.SOLine_FinallyPriceTC = sOLine_FinallyPriceTC;
			this.SOLine_Memo = sOLine_Memo;
			this.SOLine_OrderByQtyTU = sOLine_OrderByQtyTU;
			this.SOLine_DocLineNo = sOLine_DocLineNo;
			this.SOLine_TotalMoneyTC = sOLine_TotalMoneyTC;
			this.SOLine_ItemInfo_ItemID_DescFlexField_PrivateDescSeg5 = sOLine_ItemInfo_ItemID_DescFlexField_PrivateDescSeg5;
			this.SOLine_TU_Round_Precision = sOLine_TU_Round_Precision;
			this.SOLine_TU_Round_RoundType = sOLine_TU_Round_RoundType;
			this.SOLine_TU_Round_RoundValue = sOLine_TU_Round_RoundValue;
			this.TotalShipQty = totalShipQty;
			this.TotalShipMoney = totalShipMoney;
			this.AfterAdjustedMoney = afterAdjustedMoney;
			this.AfterAdjustedPrice = afterAdjustedPrice;
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
		/// SOLineInfoQryDTO.Misc.ID
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
		/// ID
		/// SOLineInfoQryDTO.Misc.ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_sOLine_ID ;
		public System.Int64 SOLine_ID
		{
			get	
			{	
				return m_sOLine_ID ;
			}
			set	
			{	
				m_sOLine_ID = value ;	
			}
		}
			
		

		/// <summary>
		/// 料号
		/// SOLineInfoQryDTO.Misc.料号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sOLine_ItemInfo_ItemCode ;
		public System.String SOLine_ItemInfo_ItemCode
		{
			get	
			{	
				return m_sOLine_ItemInfo_ItemCode ;
			}
			set	
			{	
				m_sOLine_ItemInfo_ItemCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 品名
		/// SOLineInfoQryDTO.Misc.品名
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sOLine_ItemInfo_ItemName ;
		public System.String SOLine_ItemInfo_ItemName
		{
			get	
			{	
				return m_sOLine_ItemInfo_ItemName ;
			}
			set	
			{	
				m_sOLine_ItemInfo_ItemName = value ;	
			}
		}
			
		

		/// <summary>
		/// 型号
		/// SOLineInfoQryDTO.Misc.型号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sOLine_ItemInfo_ItemID_SPECS ;
		public System.String SOLine_ItemInfo_ItemID_SPECS
		{
			get	
			{	
				return m_sOLine_ItemInfo_ItemID_SPECS ;
			}
			set	
			{	
				m_sOLine_ItemInfo_ItemID_SPECS = value ;	
			}
		}
			 	 	
		

		/// <summary>
		/// 单价
		/// SOLineInfoQryDTO.Misc.单价
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_sOLine_FinallyPriceTC ;
		public System.Decimal SOLine_FinallyPriceTC
		{
			get	
			{	
				return m_sOLine_FinallyPriceTC ;
			}
			set	
			{	
				m_sOLine_FinallyPriceTC = value ;	
			}
		}
			 	
		

		/// <summary>
		/// 数量
		/// SOLineInfoQryDTO.Misc.数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_sOLine_OrderByQtyTU ;
		public System.Decimal SOLine_OrderByQtyTU
		{
			get	
			{	
				return m_sOLine_OrderByQtyTU ;
			}
			set	
			{	
				m_sOLine_OrderByQtyTU = value ;	
			}
		}
			
		

		/// <summary>
		/// 行号
		/// SOLineInfoQryDTO.Misc.行号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_sOLine_DocLineNo ;
		public System.Int32 SOLine_DocLineNo
		{
			get	
			{	
				return m_sOLine_DocLineNo ;
			}
			set	
			{	
				m_sOLine_DocLineNo = value ;	
			}
		}
			
		

		/// <summary>
		/// 金额
		/// SOLineInfoQryDTO.Misc.金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_sOLine_TotalMoneyTC ;
		public System.Decimal SOLine_TotalMoneyTC
		{
			get	
			{	
				return m_sOLine_TotalMoneyTC ;
			}
			set	
			{	
				m_sOLine_TotalMoneyTC = value ;	
			}
		}
			
		

		/// <summary>
		/// 包装数
		/// SOLineInfoQryDTO.Misc.包装数
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sOLine_ItemInfo_ItemID_DescFlexField_PrivateDescSeg5 ;
		public System.String SOLine_ItemInfo_ItemID_DescFlexField_PrivateDescSeg5
		{
			get	
			{	
				return m_sOLine_ItemInfo_ItemID_DescFlexField_PrivateDescSeg5 ;
			}
			set	
			{	
				m_sOLine_ItemInfo_ItemID_DescFlexField_PrivateDescSeg5 = value ;	
			}
		}
			
		

		/// <summary>
		/// 销售单位_精度_精度
		/// SOLineInfoQryDTO.Misc.销售单位_精度_精度
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_sOLine_TU_Round_Precision ;
		public System.Int32 SOLine_TU_Round_Precision
		{
			get	
			{	
				return m_sOLine_TU_Round_Precision ;
			}
			set	
			{	
				m_sOLine_TU_Round_Precision = value ;	
			}
		}
			
		

		/// <summary>
		/// 销售单位_精度_舍入类型
		/// SOLineInfoQryDTO.Misc.销售单位_精度_舍入类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_sOLine_TU_Round_RoundType ;
		public System.Int32 SOLine_TU_Round_RoundType
		{
			get	
			{	
				return m_sOLine_TU_Round_RoundType ;
			}
			set	
			{	
				m_sOLine_TU_Round_RoundType = value ;	
			}
		}
			
		

		/// <summary>
		/// 销售单位_精度_舍入值
		/// SOLineInfoQryDTO.Misc.销售单位_精度_舍入值
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_sOLine_TU_Round_RoundValue ;
		public System.Int32 SOLine_TU_Round_RoundValue
		{
			get	
			{	
				return m_sOLine_TU_Round_RoundValue ;
			}
			set	
			{	
				m_sOLine_TU_Round_RoundValue = value ;	
			}
		}
			
		

		/// <summary>
		/// 累计出货数量
		/// SOLineInfoQryDTO.Misc.累计出货数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_totalShipQty ;
		public System.Decimal TotalShipQty
		{
			get	
			{	
				return m_totalShipQty ;
			}
			set	
			{	
				m_totalShipQty = value ;	
			}
		}
			
		

		/// <summary>
		/// 累计出货金额
		/// SOLineInfoQryDTO.Misc.累计出货金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_totalShipMoney ;
		public System.Decimal TotalShipMoney
		{
			get	
			{	
				return m_totalShipMoney ;
			}
			set	
			{	
				m_totalShipMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 调整后金额
		/// SOLineInfoQryDTO.Misc.调整后金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_afterAdjustedMoney ;
		public System.Decimal AfterAdjustedMoney
		{
			get	
			{	
				return m_afterAdjustedMoney ;
			}
			set	
			{	
				m_afterAdjustedMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 调整后单价
		/// SOLineInfoQryDTO.Misc.调整后单价
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_afterAdjustedPrice ;
		public System.Decimal AfterAdjustedPrice
		{
			get	
			{	
				return m_afterAdjustedPrice ;
			}
			set	
			{	
				m_afterAdjustedPrice = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
												 
		/// <summary>
		/// 名称
		/// SOLineInfoQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public string SOLine_PU_Name
		{
			get
			{
				if (m_Multi_sOLine_PU_Name == null)
					return String.Empty ;
				else
					return m_Multi_sOLine_PU_Name.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_sOLine_PU_Name == null)
					m_Multi_sOLine_PU_Name = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_sOLine_PU_Name.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_sOLine_PU_Name ;
		/// <summary>
		/// 多语属性: 名称
		/// SOLineInfoQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_SOLine_PU_Name
		{
			get
			{
				return m_Multi_sOLine_PU_Name;
			}
			set
			{
				m_Multi_sOLine_PU_Name = value ;	
			}
		}
				 
		/// <summary>
		/// 名称
		/// SOLineInfoQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public string SOLine_CU_Name
		{
			get
			{
				if (m_Multi_sOLine_CU_Name == null)
					return String.Empty ;
				else
					return m_Multi_sOLine_CU_Name.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_sOLine_CU_Name == null)
					m_Multi_sOLine_CU_Name = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_sOLine_CU_Name.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_sOLine_CU_Name ;
		/// <summary>
		/// 多语属性: 名称
		/// SOLineInfoQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_SOLine_CU_Name
		{
			get
			{
				return m_Multi_sOLine_CU_Name;
			}
			set
			{
				m_Multi_sOLine_CU_Name = value ;	
			}
		}
						 
		/// <summary>
		/// 备注
		/// SOLineInfoQryDTO.Misc.备注
		/// </summary>
		[DataMember(IsRequired=false)]
		public string SOLine_Memo
		{
			get
			{
				if (m_Multi_sOLine_Memo == null)
					return String.Empty ;
				else
					return m_Multi_sOLine_Memo.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_sOLine_Memo == null)
					m_Multi_sOLine_Memo = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_sOLine_Memo.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_sOLine_Memo ;
		/// <summary>
		/// 多语属性: 备注
		/// SOLineInfoQryDTO.Misc.备注
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_SOLine_Memo
		{
			get
			{
				return m_Multi_sOLine_Memo;
			}
			set
			{
				m_Multi_sOLine_Memo = value ;	
			}
		}
																								
		#endregion 
	} 	
}

	
