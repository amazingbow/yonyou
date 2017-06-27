



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.CustomerDocLineListQryBP
{
	/// <summary>
	/// CustomerDocLineListQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.FJGX.CustomerDocLineListQryBP.CustomerDocLineListQryDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class CustomerDocLineListQryDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public CustomerDocLineListQryDTOData()
		{
			initData();
		}
		private void initData()
		{
					ID= 0; 
				
		
		
		
		
					MainSOQty=0m; 
		
					FinallyPrice=0m; 
					InvSOQty=0m; 
		
		
					ConversionRates=0m; 
		
					DocLineNo= 0; 
				
					MainUOM_Round_RoundType= 0; 
							MainUOM_Round_RoundValue= 0; 
							MainUOM_Round_Precision= 0; 
							InvUOM_Round_Precision= 0; 
							InvUOM_Round_RoundType= 0; 
							InvUOM_Round_RoundValue= 0; 
				

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
		public CustomerDocLineListQryDTOData(  System.Int64 iD  , System.DateTime businessDate  , System.String docNo  , System.String itemCode  , System.String itemName  , System.String sPECS  , System.Decimal mainSOQty  , System.String mainUOM_Name  , System.Decimal finallyPrice  , System.Decimal invSOQty  , System.String invUOM_Name  , System.Decimal totalMoney  , System.Decimal conversionRates  , System.String customer_Name  , System.Int32 docLineNo  , System.String operators_Name  , System.Int32 mainUOM_Round_RoundType  , System.Int32 mainUOM_Round_RoundValue  , System.Int32 mainUOM_Round_Precision  , System.Int32 invUOM_Round_Precision  , System.Int32 invUOM_Round_RoundType  , System.Int32 invUOM_Round_RoundValue  , System.String memo  )
		{
			initData();
			this.ID = iD;
			this.BusinessDate = businessDate;
			this.DocNo = docNo;
			this.ItemCode = itemCode;
			this.ItemName = itemName;
			this.SPECS = sPECS;
			this.MainSOQty = mainSOQty;
			this.MainUOM_Name = mainUOM_Name;
			this.FinallyPrice = finallyPrice;
			this.InvSOQty = invSOQty;
			this.InvUOM_Name = invUOM_Name;
			this.TotalMoney = totalMoney;
			this.ConversionRates = conversionRates;
			this.Customer_Name = customer_Name;
			this.DocLineNo = docLineNo;
			this.Operators_Name = operators_Name;
			this.MainUOM_Round_RoundType = mainUOM_Round_RoundType;
			this.MainUOM_Round_RoundValue = mainUOM_Round_RoundValue;
			this.MainUOM_Round_Precision = mainUOM_Round_Precision;
			this.InvUOM_Round_Precision = invUOM_Round_Precision;
			this.InvUOM_Round_RoundType = invUOM_Round_RoundType;
			this.InvUOM_Round_RoundValue = invUOM_Round_RoundValue;
			this.Memo = memo;
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
		/// CustomerDocLineListQryDTO.Misc.ID
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
		/// 单据日期
		/// CustomerDocLineListQryDTO.Misc.单据日期
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
		/// CustomerDocLineListQryDTO.Misc.单据号
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
		/// 存货编码
		/// CustomerDocLineListQryDTO.Misc.存货编码
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
		/// CustomerDocLineListQryDTO.Misc.存货名称
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
		/// CustomerDocLineListQryDTO.Misc.规格型号
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
		/// 主销售数量
		/// CustomerDocLineListQryDTO.Misc.主销售数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_mainSOQty ;
		public System.Decimal MainSOQty
		{
			get	
			{	
				return m_mainSOQty ;
			}
			set	
			{	
				m_mainSOQty = value ;	
			}
		}
			
		

		/// <summary>
		/// 主单位
		/// CustomerDocLineListQryDTO.Misc.主单位
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_mainUOM_Name ;
		public System.String MainUOM_Name
		{
			get	
			{	
				return m_mainUOM_Name ;
			}
			set	
			{	
				m_mainUOM_Name = value ;	
			}
		}
			
		

		/// <summary>
		/// 主报价
		/// CustomerDocLineListQryDTO.Misc.主报价
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_finallyPrice ;
		public System.Decimal FinallyPrice
		{
			get	
			{	
				return m_finallyPrice ;
			}
			set	
			{	
				m_finallyPrice = value ;	
			}
		}
			
		

		/// <summary>
		/// 辅销售数量
		/// CustomerDocLineListQryDTO.Misc.辅销售数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_invSOQty ;
		public System.Decimal InvSOQty
		{
			get	
			{	
				return m_invSOQty ;
			}
			set	
			{	
				m_invSOQty = value ;	
			}
		}
			
		

		/// <summary>
		/// 辅单位
		/// CustomerDocLineListQryDTO.Misc.辅单位
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_invUOM_Name ;
		public System.String InvUOM_Name
		{
			get	
			{	
				return m_invUOM_Name ;
			}
			set	
			{	
				m_invUOM_Name = value ;	
			}
		}
			
		

		/// <summary>
		/// 金额
		/// CustomerDocLineListQryDTO.Misc.金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_totalMoney ;
		public System.Decimal TotalMoney
		{
			get	
			{	
				return m_totalMoney ;
			}
			set	
			{	
				m_totalMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 换算率
		/// CustomerDocLineListQryDTO.Misc.换算率
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_conversionRates ;
		public System.Decimal ConversionRates
		{
			get	
			{	
				return m_conversionRates ;
			}
			set	
			{	
				m_conversionRates = value ;	
			}
		}
			
		

		/// <summary>
		/// 公司名称
		/// CustomerDocLineListQryDTO.Misc.公司名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_customer_Name ;
		public System.String Customer_Name
		{
			get	
			{	
				return m_customer_Name ;
			}
			set	
			{	
				m_customer_Name = value ;	
			}
		}
			
		

		/// <summary>
		/// 行号
		/// CustomerDocLineListQryDTO.Misc.行号
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
		/// 业务员
		/// CustomerDocLineListQryDTO.Misc.业务员
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_operators_Name ;
		public System.String Operators_Name
		{
			get	
			{	
				return m_operators_Name ;
			}
			set	
			{	
				m_operators_Name = value ;	
			}
		}
			
		

		/// <summary>
		/// 主单位_精度_舍入类型
		/// CustomerDocLineListQryDTO.Misc.主单位_精度_舍入类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_mainUOM_Round_RoundType ;
		public System.Int32 MainUOM_Round_RoundType
		{
			get	
			{	
				return m_mainUOM_Round_RoundType ;
			}
			set	
			{	
				m_mainUOM_Round_RoundType = value ;	
			}
		}
			
		

		/// <summary>
		/// 主单位_精度_舍入值
		/// CustomerDocLineListQryDTO.Misc.主单位_精度_舍入值
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_mainUOM_Round_RoundValue ;
		public System.Int32 MainUOM_Round_RoundValue
		{
			get	
			{	
				return m_mainUOM_Round_RoundValue ;
			}
			set	
			{	
				m_mainUOM_Round_RoundValue = value ;	
			}
		}
			
		

		/// <summary>
		/// 主单位_精度_精度
		/// CustomerDocLineListQryDTO.Misc.主单位_精度_精度
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_mainUOM_Round_Precision ;
		public System.Int32 MainUOM_Round_Precision
		{
			get	
			{	
				return m_mainUOM_Round_Precision ;
			}
			set	
			{	
				m_mainUOM_Round_Precision = value ;	
			}
		}
			
		

		/// <summary>
		/// 辅单位_精度_精度
		/// CustomerDocLineListQryDTO.Misc.辅单位_精度_精度
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_invUOM_Round_Precision ;
		public System.Int32 InvUOM_Round_Precision
		{
			get	
			{	
				return m_invUOM_Round_Precision ;
			}
			set	
			{	
				m_invUOM_Round_Precision = value ;	
			}
		}
			
		

		/// <summary>
		/// 辅单位_精度_舍入类型
		/// CustomerDocLineListQryDTO.Misc.辅单位_精度_舍入类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_invUOM_Round_RoundType ;
		public System.Int32 InvUOM_Round_RoundType
		{
			get	
			{	
				return m_invUOM_Round_RoundType ;
			}
			set	
			{	
				m_invUOM_Round_RoundType = value ;	
			}
		}
			
		

		/// <summary>
		/// 辅单位_精度_舍入值
		/// CustomerDocLineListQryDTO.Misc.辅单位_精度_舍入值
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_invUOM_Round_RoundValue ;
		public System.Int32 InvUOM_Round_RoundValue
		{
			get	
			{	
				return m_invUOM_Round_RoundValue ;
			}
			set	
			{	
				m_invUOM_Round_RoundValue = value ;	
			}
		}
			
		

		/// <summary>
		/// 备注
		/// CustomerDocLineListQryDTO.Misc.备注
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
			
		#endregion	

		#region Multi_Fields
																																														
		#endregion 
	} 	
}

	
