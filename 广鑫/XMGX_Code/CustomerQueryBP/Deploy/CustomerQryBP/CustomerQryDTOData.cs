



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.CustomerQryBP
{
	/// <summary>
	/// CustomerQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.FJGX.CustomerQryBP.CustomerQryDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class CustomerQryDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public CustomerQryDTOData()
		{
			initData();
		}
		private void initData()
		{
					ID= 0; 
							Customer_ID= 0; 
				
		
		
		
		
		
		
		
					AROCMoneyBalance_TotalMoney=0m; 
					LastSOTotalMoneyTC=0m; 
					LastRecBillTotalMoney=0m; 
		
		
		
					Customer_TradeCurrency_MoneyRound_RoundType= 0; 
							Customer_TradeCurrency_MoneyRound_RoundValue= 0; 
				
		
		
		
					Customer_TradeCurrency_MoneyRound_Precision= 0; 
							ObjectCreditLevelApproval_CreditLimit=0m; 
					SumBalanceTotalMoney=0m; 

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
		public CustomerQryDTOData(  System.Int64 iD  , System.Int64 customer_ID  , System.String customer_Code  , System.String customer_Name  , Int64 customerContact_Contact  , System.String customerContact_Contact_DefaultMobilNum  , System.String customerContact_Contact_DefaultPhoneNum  , Int64 customer_CustomerCategory  , Int64 customer_Saleser  , System.String customerContact_Contact_DefaultFaxNum  , System.Decimal aROCMoneyBalance_TotalMoney  , System.Decimal lastSOTotalMoneyTC  , System.Decimal lastRecBillTotalMoney  , System.String customer_StateTaxNo  , System.String customerBankAccount_Code  , System.String customer_Description  , System.Int32 customer_TradeCurrency_MoneyRound_RoundType  , System.Int32 customer_TradeCurrency_MoneyRound_RoundValue  , System.String customer_Saleser_Name  , System.String customerContact_Contact_Name  , System.String customer_CustomerCategory_Name  , System.String customer_OfficialLocation_Name  , System.Int32 customer_TradeCurrency_MoneyRound_Precision  , System.Decimal objectCreditLevelApproval_CreditLimit  , System.Decimal sumBalanceTotalMoney  )
		{
			initData();
			this.ID = iD;
			this.Customer_ID = customer_ID;
			this.Customer_Code = customer_Code;
			this.Customer_Name = customer_Name;
			this.CustomerContact_Contact = customerContact_Contact;
			this.CustomerContact_Contact_DefaultMobilNum = customerContact_Contact_DefaultMobilNum;
			this.CustomerContact_Contact_DefaultPhoneNum = customerContact_Contact_DefaultPhoneNum;
			this.Customer_CustomerCategory = customer_CustomerCategory;
			this.Customer_Saleser = customer_Saleser;
			this.CustomerContact_Contact_DefaultFaxNum = customerContact_Contact_DefaultFaxNum;
			this.AROCMoneyBalance_TotalMoney = aROCMoneyBalance_TotalMoney;
			this.LastSOTotalMoneyTC = lastSOTotalMoneyTC;
			this.LastRecBillTotalMoney = lastRecBillTotalMoney;
			this.Customer_StateTaxNo = customer_StateTaxNo;
			this.CustomerBankAccount_Code = customerBankAccount_Code;
			this.Customer_Description = customer_Description;
			this.Customer_TradeCurrency_MoneyRound_RoundType = customer_TradeCurrency_MoneyRound_RoundType;
			this.Customer_TradeCurrency_MoneyRound_RoundValue = customer_TradeCurrency_MoneyRound_RoundValue;
			this.Customer_Saleser_Name = customer_Saleser_Name;
			this.CustomerContact_Contact_Name = customerContact_Contact_Name;
			this.Customer_CustomerCategory_Name = customer_CustomerCategory_Name;
			this.Customer_OfficialLocation_Name = customer_OfficialLocation_Name;
			this.Customer_TradeCurrency_MoneyRound_Precision = customer_TradeCurrency_MoneyRound_Precision;
			this.ObjectCreditLevelApproval_CreditLimit = objectCreditLevelApproval_CreditLimit;
			this.SumBalanceTotalMoney = sumBalanceTotalMoney;
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
		/// CustomerQryDTO.Misc.ID
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
		/// CustomerQryDTO.Misc.ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_customer_ID ;
		public System.Int64 Customer_ID
		{
			get	
			{	
				return m_customer_ID ;
			}
			set	
			{	
				m_customer_ID = value ;	
			}
		}
			
		

		/// <summary>
		/// 编码
		/// CustomerQryDTO.Misc.编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_customer_Code ;
		public System.String Customer_Code
		{
			get	
			{	
				return m_customer_Code ;
			}
			set	
			{	
				m_customer_Code = value ;	
			}
		}
			 	
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_customerContact_Contact_SKey ;
		/// <summary>
		/// 联系人 序列化Key属性。（传递跨组织序列列字段）
		/// CustomerQryDTO.Misc.联系人
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey CustomerContact_Contact_SKey
		{
			get 
			{
				return m_customerContact_Contact_SKey ;					
			}
			set
			{
				m_customerContact_Contact_SKey =value;	
			}
		}


		/// <summary>
		/// 联系人
		/// CustomerQryDTO.Misc.联系人
		/// </summary>
		[DataMember(IsRequired=false)]
		public Int64 CustomerContact_Contact
		{
			get	
			{	
				if (CustomerContact_Contact_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return CustomerContact_Contact_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					CustomerContact_Contact_SKey = null ;
				else
				{
					if (CustomerContact_Contact_SKey == null )
						CustomerContact_Contact_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.Contact.Contact") ;
					else
						CustomerContact_Contact_SKey.ID = value ;
				}
			}
		}
			
		

		/// <summary>
		/// 手机
		/// CustomerQryDTO.Misc.手机
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_customerContact_Contact_DefaultMobilNum ;
		public System.String CustomerContact_Contact_DefaultMobilNum
		{
			get	
			{	
				return m_customerContact_Contact_DefaultMobilNum ;
			}
			set	
			{	
				m_customerContact_Contact_DefaultMobilNum = value ;	
			}
		}
			
		

		/// <summary>
		/// 电话
		/// CustomerQryDTO.Misc.电话
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_customerContact_Contact_DefaultPhoneNum ;
		public System.String CustomerContact_Contact_DefaultPhoneNum
		{
			get	
			{	
				return m_customerContact_Contact_DefaultPhoneNum ;
			}
			set	
			{	
				m_customerContact_Contact_DefaultPhoneNum = value ;	
			}
		}
			
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_customer_CustomerCategory_SKey ;
		/// <summary>
		/// 客户分类 序列化Key属性。（传递跨组织序列列字段）
		/// CustomerQryDTO.Misc.客户分类
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Customer_CustomerCategory_SKey
		{
			get 
			{
				return m_customer_CustomerCategory_SKey ;					
			}
			set
			{
				m_customer_CustomerCategory_SKey =value;	
			}
		}


		/// <summary>
		/// 客户分类
		/// CustomerQryDTO.Misc.客户分类
		/// </summary>
		[DataMember(IsRequired=false)]
		public Int64 Customer_CustomerCategory
		{
			get	
			{	
				if (Customer_CustomerCategory_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Customer_CustomerCategory_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Customer_CustomerCategory_SKey = null ;
				else
				{
					if (Customer_CustomerCategory_SKey == null )
						Customer_CustomerCategory_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.SCM.Customer.CustomerCategory") ;
					else
						Customer_CustomerCategory_SKey.ID = value ;
				}
			}
		}
			
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_customer_Saleser_SKey ;
		/// <summary>
		/// 业务员 序列化Key属性。（传递跨组织序列列字段）
		/// CustomerQryDTO.Misc.业务员
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Customer_Saleser_SKey
		{
			get 
			{
				return m_customer_Saleser_SKey ;					
			}
			set
			{
				m_customer_Saleser_SKey =value;	
			}
		}


		/// <summary>
		/// 业务员
		/// CustomerQryDTO.Misc.业务员
		/// </summary>
		[DataMember(IsRequired=false)]
		public Int64 Customer_Saleser
		{
			get	
			{	
				if (Customer_Saleser_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Customer_Saleser_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Customer_Saleser_SKey = null ;
				else
				{
					if (Customer_Saleser_SKey == null )
						Customer_Saleser_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.HR.Operator.Operators") ;
					else
						Customer_Saleser_SKey.ID = value ;
				}
			}
		}
			
		

		/// <summary>
		/// 传真
		/// CustomerQryDTO.Misc.传真
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_customerContact_Contact_DefaultFaxNum ;
		public System.String CustomerContact_Contact_DefaultFaxNum
		{
			get	
			{	
				return m_customerContact_Contact_DefaultFaxNum ;
			}
			set	
			{	
				m_customerContact_Contact_DefaultFaxNum = value ;	
			}
		}
			
		

		/// <summary>
		/// 实际应收
		/// CustomerQryDTO.Misc.实际应收
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_aROCMoneyBalance_TotalMoney ;
		public System.Decimal AROCMoneyBalance_TotalMoney
		{
			get	
			{	
				return m_aROCMoneyBalance_TotalMoney ;
			}
			set	
			{	
				m_aROCMoneyBalance_TotalMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 最后交易额
		/// CustomerQryDTO.Misc.最后交易额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_lastSOTotalMoneyTC ;
		public System.Decimal LastSOTotalMoneyTC
		{
			get	
			{	
				return m_lastSOTotalMoneyTC ;
			}
			set	
			{	
				m_lastSOTotalMoneyTC = value ;	
			}
		}
			
		

		/// <summary>
		/// 最近一笔收款金额
		/// CustomerQryDTO.Misc.最近一笔收款金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_lastRecBillTotalMoney ;
		public System.Decimal LastRecBillTotalMoney
		{
			get	
			{	
				return m_lastRecBillTotalMoney ;
			}
			set	
			{	
				m_lastRecBillTotalMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 国税号
		/// CustomerQryDTO.Misc.国税号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_customer_StateTaxNo ;
		public System.String Customer_StateTaxNo
		{
			get	
			{	
				return m_customer_StateTaxNo ;
			}
			set	
			{	
				m_customer_StateTaxNo = value ;	
			}
		}
			
		

		/// <summary>
		/// 开户银行
		/// CustomerQryDTO.Misc.开户银行
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_customerBankAccount_Code ;
		public System.String CustomerBankAccount_Code
		{
			get	
			{	
				return m_customerBankAccount_Code ;
			}
			set	
			{	
				m_customerBankAccount_Code = value ;	
			}
		}
			 	
		

		/// <summary>
		/// 客户_交易币种_金额精度_舍入类型
		/// CustomerQryDTO.Misc.客户_交易币种_金额精度_舍入类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_customer_TradeCurrency_MoneyRound_RoundType ;
		public System.Int32 Customer_TradeCurrency_MoneyRound_RoundType
		{
			get	
			{	
				return m_customer_TradeCurrency_MoneyRound_RoundType ;
			}
			set	
			{	
				m_customer_TradeCurrency_MoneyRound_RoundType = value ;	
			}
		}
			
		

		/// <summary>
		/// 客户_交易币种_金额精度_舍入值
		/// CustomerQryDTO.Misc.客户_交易币种_金额精度_舍入值
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_customer_TradeCurrency_MoneyRound_RoundValue ;
		public System.Int32 Customer_TradeCurrency_MoneyRound_RoundValue
		{
			get	
			{	
				return m_customer_TradeCurrency_MoneyRound_RoundValue ;
			}
			set	
			{	
				m_customer_TradeCurrency_MoneyRound_RoundValue = value ;	
			}
		}
			 	 	 	 	
		

		/// <summary>
		/// 客户_交易币种_金额精度_精度
		/// CustomerQryDTO.Misc.客户_交易币种_金额精度_精度
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_customer_TradeCurrency_MoneyRound_Precision ;
		public System.Int32 Customer_TradeCurrency_MoneyRound_Precision
		{
			get	
			{	
				return m_customer_TradeCurrency_MoneyRound_Precision ;
			}
			set	
			{	
				m_customer_TradeCurrency_MoneyRound_Precision = value ;	
			}
		}
			
		

		/// <summary>
		/// 信用额度
		/// CustomerQryDTO.Misc.信用额度
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_objectCreditLevelApproval_CreditLimit ;
		public System.Decimal ObjectCreditLevelApproval_CreditLimit
		{
			get	
			{	
				return m_objectCreditLevelApproval_CreditLimit ;
			}
			set	
			{	
				m_objectCreditLevelApproval_CreditLimit = value ;	
			}
		}
			
		

		/// <summary>
		/// 合计实际应收金额
		/// CustomerQryDTO.Misc.合计实际应收金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_sumBalanceTotalMoney ;
		public System.Decimal SumBalanceTotalMoney
		{
			get	
			{	
				return m_sumBalanceTotalMoney ;
			}
			set	
			{	
				m_sumBalanceTotalMoney = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
								 
		/// <summary>
		/// 名称
		/// CustomerQryDTO.Misc.名称
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
		/// CustomerQryDTO.Misc.名称
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
																										 
		/// <summary>
		/// 描述
		/// CustomerQryDTO.Misc.描述
		/// </summary>
		[DataMember(IsRequired=false)]
		public string Customer_Description
		{
			get
			{
				if (m_Multi_customer_Description == null)
					return String.Empty ;
				else
					return m_Multi_customer_Description.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_customer_Description == null)
					m_Multi_customer_Description = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_customer_Description.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_customer_Description ;
		/// <summary>
		/// 多语属性: 描述
		/// CustomerQryDTO.Misc.描述
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Customer_Description
		{
			get
			{
				return m_Multi_customer_Description;
			}
			set
			{
				m_Multi_customer_Description = value ;	
			}
		}
								 
		/// <summary>
		/// 名称
		/// CustomerQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public string Customer_Saleser_Name
		{
			get
			{
				if (m_Multi_customer_Saleser_Name == null)
					return String.Empty ;
				else
					return m_Multi_customer_Saleser_Name.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_customer_Saleser_Name == null)
					m_Multi_customer_Saleser_Name = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_customer_Saleser_Name.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_customer_Saleser_Name ;
		/// <summary>
		/// 多语属性: 名称
		/// CustomerQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Customer_Saleser_Name
		{
			get
			{
				return m_Multi_customer_Saleser_Name;
			}
			set
			{
				m_Multi_customer_Saleser_Name = value ;	
			}
		}
				 
		/// <summary>
		/// 名称
		/// CustomerQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public string CustomerContact_Contact_Name
		{
			get
			{
				if (m_Multi_customerContact_Contact_Name == null)
					return String.Empty ;
				else
					return m_Multi_customerContact_Contact_Name.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_customerContact_Contact_Name == null)
					m_Multi_customerContact_Contact_Name = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_customerContact_Contact_Name.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_customerContact_Contact_Name ;
		/// <summary>
		/// 多语属性: 名称
		/// CustomerQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_CustomerContact_Contact_Name
		{
			get
			{
				return m_Multi_customerContact_Contact_Name;
			}
			set
			{
				m_Multi_customerContact_Contact_Name = value ;	
			}
		}
				 
		/// <summary>
		/// 名称
		/// CustomerQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public string Customer_CustomerCategory_Name
		{
			get
			{
				if (m_Multi_customer_CustomerCategory_Name == null)
					return String.Empty ;
				else
					return m_Multi_customer_CustomerCategory_Name.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_customer_CustomerCategory_Name == null)
					m_Multi_customer_CustomerCategory_Name = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_customer_CustomerCategory_Name.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_customer_CustomerCategory_Name ;
		/// <summary>
		/// 多语属性: 名称
		/// CustomerQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Customer_CustomerCategory_Name
		{
			get
			{
				return m_Multi_customer_CustomerCategory_Name;
			}
			set
			{
				m_Multi_customer_CustomerCategory_Name = value ;	
			}
		}
				 
		/// <summary>
		/// 名称
		/// CustomerQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public string Customer_OfficialLocation_Name
		{
			get
			{
				if (m_Multi_customer_OfficialLocation_Name == null)
					return String.Empty ;
				else
					return m_Multi_customer_OfficialLocation_Name.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_customer_OfficialLocation_Name == null)
					m_Multi_customer_OfficialLocation_Name = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_customer_OfficialLocation_Name.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_customer_OfficialLocation_Name ;
		/// <summary>
		/// 多语属性: 名称
		/// CustomerQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Customer_OfficialLocation_Name
		{
			get
			{
				return m_Multi_customer_OfficialLocation_Name;
			}
			set
			{
				m_Multi_customer_OfficialLocation_Name = value ;	
			}
		}
								
		#endregion 
	} 	
}

	
