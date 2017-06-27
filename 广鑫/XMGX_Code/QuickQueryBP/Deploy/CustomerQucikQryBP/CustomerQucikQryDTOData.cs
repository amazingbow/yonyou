



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.CustomerQucikQryBP
{
	/// <summary>
	/// CustomerQucikQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.FJGX.CustomerQucikQryBP.CustomerQucikQryDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class CustomerQucikQryDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public CustomerQucikQryDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		
		
		
		
		
		
		
					ActualAPMoney=0m; 
					CreditMoney=0m; 
					LastTransMoney=0m; 
					LastRecMoney=0m; 
		
		
		
		
		
		
		
					ID= 0; 
		
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
		public CustomerQucikQryDTOData(  System.Int64 customer_ID  , System.String customer_Code  , System.String customer_Name  , System.String enterpriseLegalPerson  , System.String mobileNo  , System.String phoneNo  , Int64 customer_CustomerCategory  , System.String fax  , System.Decimal actualAPMoney  , System.Decimal creditMoney  , System.Decimal lastTransMoney  , System.Decimal lastRecMoney  , System.String taxNo  , System.String bankName  , System.String memo  , System.String address  , Int64 customer_Saleser  , System.String customerCategoryName  , System.String saleserName  , System.Int64 iD  )
		{
			initData();
			this.Customer_ID = customer_ID;
			this.Customer_Code = customer_Code;
			this.Customer_Name = customer_Name;
			this.EnterpriseLegalPerson = enterpriseLegalPerson;
			this.MobileNo = mobileNo;
			this.PhoneNo = phoneNo;
			this.Customer_CustomerCategory = customer_CustomerCategory;
			this.Fax = fax;
			this.ActualAPMoney = actualAPMoney;
			this.CreditMoney = creditMoney;
			this.LastTransMoney = lastTransMoney;
			this.LastRecMoney = lastRecMoney;
			this.TaxNo = taxNo;
			this.BankName = bankName;
			this.Memo = memo;
			this.Address = address;
			this.Customer_Saleser = customer_Saleser;
			this.CustomerCategoryName = customerCategoryName;
			this.SaleserName = saleserName;
			this.ID = iD;
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
		/// CustomerQucikQryDTO.Misc.ID
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
		/// CustomerQucikQryDTO.Misc.编码
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
			 	
		

		/// <summary>
		/// 负责人
		/// CustomerQucikQryDTO.Misc.负责人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_enterpriseLegalPerson ;
		public System.String EnterpriseLegalPerson
		{
			get	
			{	
				return m_enterpriseLegalPerson ;
			}
			set	
			{	
				m_enterpriseLegalPerson = value ;	
			}
		}
			
		

		/// <summary>
		/// 手机
		/// CustomerQucikQryDTO.Misc.手机
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_mobileNo ;
		public System.String MobileNo
		{
			get	
			{	
				return m_mobileNo ;
			}
			set	
			{	
				m_mobileNo = value ;	
			}
		}
			
		

		/// <summary>
		/// 电话
		/// CustomerQucikQryDTO.Misc.电话
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_phoneNo ;
		public System.String PhoneNo
		{
			get	
			{	
				return m_phoneNo ;
			}
			set	
			{	
				m_phoneNo = value ;	
			}
		}
			
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_customer_CustomerCategory_SKey ;
		/// <summary>
		/// 客户_分类 序列化Key属性。（传递跨组织序列列字段）
		/// CustomerQucikQryDTO.Misc.客户_分类
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
		/// 客户_分类
		/// CustomerQucikQryDTO.Misc.客户_分类
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
			
		

		/// <summary>
		/// 传真
		/// CustomerQucikQryDTO.Misc.传真
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_fax ;
		public System.String Fax
		{
			get	
			{	
				return m_fax ;
			}
			set	
			{	
				m_fax = value ;	
			}
		}
			
		

		/// <summary>
		/// 实际应收
		/// CustomerQucikQryDTO.Misc.实际应收
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_actualAPMoney ;
		public System.Decimal ActualAPMoney
		{
			get	
			{	
				return m_actualAPMoney ;
			}
			set	
			{	
				m_actualAPMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 信用额度
		/// CustomerQucikQryDTO.Misc.信用额度
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
		/// 最后交易额
		/// CustomerQucikQryDTO.Misc.最后交易额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_lastTransMoney ;
		public System.Decimal LastTransMoney
		{
			get	
			{	
				return m_lastTransMoney ;
			}
			set	
			{	
				m_lastTransMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 最后收款金额
		/// CustomerQucikQryDTO.Misc.最后收款金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_lastRecMoney ;
		public System.Decimal LastRecMoney
		{
			get	
			{	
				return m_lastRecMoney ;
			}
			set	
			{	
				m_lastRecMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 税号
		/// CustomerQucikQryDTO.Misc.税号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_taxNo ;
		public System.String TaxNo
		{
			get	
			{	
				return m_taxNo ;
			}
			set	
			{	
				m_taxNo = value ;	
			}
		}
			
		

		/// <summary>
		/// 开户银行
		/// CustomerQucikQryDTO.Misc.开户银行
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_bankName ;
		public System.String BankName
		{
			get	
			{	
				return m_bankName ;
			}
			set	
			{	
				m_bankName = value ;	
			}
		}
			
		

		/// <summary>
		/// 说明
		/// CustomerQucikQryDTO.Misc.说明
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
		/// 地址
		/// CustomerQucikQryDTO.Misc.地址
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_address ;
		public System.String Address
		{
			get	
			{	
				return m_address ;
			}
			set	
			{	
				m_address = value ;	
			}
		}
			
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_customer_Saleser_SKey ;
		/// <summary>
		/// 客户_业务员 序列化Key属性。（传递跨组织序列列字段）
		/// CustomerQucikQryDTO.Misc.客户_业务员
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
		/// 客户_业务员
		/// CustomerQucikQryDTO.Misc.客户_业务员
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
		/// 客户分类
		/// CustomerQucikQryDTO.Misc.客户分类
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_customerCategoryName ;
		public System.String CustomerCategoryName
		{
			get	
			{	
				return m_customerCategoryName ;
			}
			set	
			{	
				m_customerCategoryName = value ;	
			}
		}
			
		

		/// <summary>
		/// 业务员
		/// CustomerQucikQryDTO.Misc.业务员
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_saleserName ;
		public System.String SaleserName
		{
			get	
			{	
				return m_saleserName ;
			}
			set	
			{	
				m_saleserName = value ;	
			}
		}
			
		

		/// <summary>
		/// ID
		/// CustomerQucikQryDTO.Misc.ID
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
			
		#endregion	

		#region Multi_Fields
						 
		/// <summary>
		/// 名称
		/// CustomerQucikQryDTO.Misc.名称
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
		/// CustomerQucikQryDTO.Misc.名称
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

	
