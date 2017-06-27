



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.CustomerVoucherQryBP
{
	/// <summary>
	/// CustomerVoucherQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.FJGX.CustomerVoucherQryBP.CustomerVoucherQryDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class CustomerVoucherQryDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public CustomerVoucherQryDTOData()
		{
			initData();
		}
		private void initData()
		{
					ID= 0; 
				
		
		
		
		
		
					DebitMoney=0m; 
		
					SumDebitMoney=0m; 
		
					SumMoney=0m; 
		
					BalanceMoney=0m; 

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
		public CustomerVoucherQryDTOData(  System.Int64 iD  , Int64 customer  , System.String customer_Name  , System.String docNo  , System.String docTypeName  , System.String createdBy  , System.String memo  , System.Decimal debitMoney  , System.Decimal creditMoney  , System.Decimal sumDebitMoney  , System.Decimal sumCreditMoney  , System.Decimal sumMoney  , System.DateTime businessDate  , System.Decimal balanceMoney  )
		{
			initData();
			this.ID = iD;
			this.Customer = customer;
			this.Customer_Name = customer_Name;
			this.DocNo = docNo;
			this.DocTypeName = docTypeName;
			this.CreatedBy = createdBy;
			this.Memo = memo;
			this.DebitMoney = debitMoney;
			this.CreditMoney = creditMoney;
			this.SumDebitMoney = sumDebitMoney;
			this.SumCreditMoney = sumCreditMoney;
			this.SumMoney = sumMoney;
			this.BusinessDate = businessDate;
			this.BalanceMoney = balanceMoney;
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
		/// CustomerVoucherQryDTO.Misc.ID
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
			
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_customer_SKey ;
		/// <summary>
		/// 客户 序列化Key属性。（传递跨组织序列列字段）
		/// CustomerVoucherQryDTO.Misc.客户
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Customer_SKey
		{
			get 
			{
				return m_customer_SKey ;					
			}
			set
			{
				m_customer_SKey =value;	
			}
		}


		/// <summary>
		/// 客户
		/// CustomerVoucherQryDTO.Misc.客户
		/// </summary>
		[DataMember(IsRequired=false)]
		public Int64 Customer
		{
			get	
			{	
				if (Customer_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Customer_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Customer_SKey = null ;
				else
				{
					if (Customer_SKey == null )
						Customer_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.SCM.Customer.Customer") ;
					else
						Customer_SKey.ID = value ;
				}
			}
		}
			 	
		

		/// <summary>
		/// 应收单据
		/// CustomerVoucherQryDTO.Misc.应收单据
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
		/// 单据类型
		/// CustomerVoucherQryDTO.Misc.单据类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_docTypeName ;
		public System.String DocTypeName
		{
			get	
			{	
				return m_docTypeName ;
			}
			set	
			{	
				m_docTypeName = value ;	
			}
		}
			
		

		/// <summary>
		/// 制单人
		/// CustomerVoucherQryDTO.Misc.制单人
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
		/// 摘要
		/// CustomerVoucherQryDTO.Misc.摘要
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
		/// 借方金额
		/// CustomerVoucherQryDTO.Misc.借方金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_debitMoney ;
		public System.Decimal DebitMoney
		{
			get	
			{	
				return m_debitMoney ;
			}
			set	
			{	
				m_debitMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 贷方金额
		/// CustomerVoucherQryDTO.Misc.贷方金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_creditMoney ;
		public System.Decimal CreditMoney
		{
			get	
			{	
				return m_creditMoney ;
			}
			set	
			{	
				m_creditMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 合计借方金额
		/// CustomerVoucherQryDTO.Misc.合计借方金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_sumDebitMoney ;
		public System.Decimal SumDebitMoney
		{
			get	
			{	
				return m_sumDebitMoney ;
			}
			set	
			{	
				m_sumDebitMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 合计贷方金额
		/// CustomerVoucherQryDTO.Misc.合计贷方金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_sumCreditMoney ;
		public System.Decimal SumCreditMoney
		{
			get	
			{	
				return m_sumCreditMoney ;
			}
			set	
			{	
				m_sumCreditMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 合计金额
		/// CustomerVoucherQryDTO.Misc.合计金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_sumMoney ;
		public System.Decimal SumMoney
		{
			get	
			{	
				return m_sumMoney ;
			}
			set	
			{	
				m_sumMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 业务日期
		/// CustomerVoucherQryDTO.Misc.业务日期
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
		/// 结存
		/// CustomerVoucherQryDTO.Misc.结存
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_balanceMoney ;
		public System.Decimal BalanceMoney
		{
			get	
			{	
				return m_balanceMoney ;
			}
			set	
			{	
				m_balanceMoney = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
						 
		/// <summary>
		/// 名称
		/// CustomerVoucherQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public string Customer_Name
		{
			get
			{
				if (m_Multi_customer_Name == null)
					return String.Empty ;
				else
					return m_Multi_customer_Name.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_customer_Name == null)
					m_Multi_customer_Name = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_customer_Name.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_customer_Name ;
		/// <summary>
		/// 多语属性: 名称
		/// CustomerVoucherQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Customer_Name
		{
			get
			{
				return m_Multi_customer_Name;
			}
			set
			{
				m_Multi_customer_Name = value ;	
			}
		}
																								
		#endregion 
	} 	
}

	
