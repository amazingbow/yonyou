



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.CustomerDocListQryBP
{
	/// <summary>
	/// CustomerDocListQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.FJGX.CustomerDocListQryBP.CustomerDocListQryDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class CustomerDocListQryDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public CustomerDocListQryDTOData()
		{
			initData();
		}
		private void initData()
		{
					ID= 0; 
				
		
		
		
		
		
		
		
					TotalMoney=0m; 
					DocType= 0; 
							SumTotalMoney=0m; 

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
		public CustomerDocListQryDTOData(  System.Int64 iD  , System.String docNo  , System.DateTime businessDate  , Int64 customer  , System.String customer_Name  , Int64 customerContact  , System.String customerContact_Contact_Name  , Int64 operators  , System.String operators_Name  , System.Decimal totalMoney  , System.Int32 docType  , System.Decimal sumTotalMoney  )
		{
			initData();
			this.ID = iD;
			this.DocNo = docNo;
			this.BusinessDate = businessDate;
			this.Customer = customer;
			this.Customer_Name = customer_Name;
			this.CustomerContact = customerContact;
			this.CustomerContact_Contact_Name = customerContact_Contact_Name;
			this.Operators = operators;
			this.Operators_Name = operators_Name;
			this.TotalMoney = totalMoney;
			this.DocType = docType;
			this.SumTotalMoney = sumTotalMoney;
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
		/// CustomerDocListQryDTO.Misc.ID
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
		/// 单据编号
		/// CustomerDocListQryDTO.Misc.单据编号
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
		/// CustomerDocListQryDTO.Misc.单据日期
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
			
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_customer_SKey ;
		/// <summary>
		/// 客户 序列化Key属性。（传递跨组织序列列字段）
		/// CustomerDocListQryDTO.Misc.客户
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
		/// CustomerDocListQryDTO.Misc.客户
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
			 	
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_customerContact_SKey ;
		/// <summary>
		/// 联系人 序列化Key属性。（传递跨组织序列列字段）
		/// CustomerDocListQryDTO.Misc.联系人
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey CustomerContact_SKey
		{
			get 
			{
				return m_customerContact_SKey ;					
			}
			set
			{
				m_customerContact_SKey =value;	
			}
		}


		/// <summary>
		/// 联系人
		/// CustomerDocListQryDTO.Misc.联系人
		/// </summary>
		[DataMember(IsRequired=false)]
		public Int64 CustomerContact
		{
			get	
			{	
				if (CustomerContact_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return CustomerContact_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					CustomerContact_SKey = null ;
				else
				{
					if (CustomerContact_SKey == null )
						CustomerContact_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.SCM.Customer.CustomerContact") ;
					else
						CustomerContact_SKey.ID = value ;
				}
			}
		}
			 	
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_operators_SKey ;
		/// <summary>
		/// 业务员 序列化Key属性。（传递跨组织序列列字段）
		/// CustomerDocListQryDTO.Misc.业务员
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Operators_SKey
		{
			get 
			{
				return m_operators_SKey ;					
			}
			set
			{
				m_operators_SKey =value;	
			}
		}


		/// <summary>
		/// 业务员
		/// CustomerDocListQryDTO.Misc.业务员
		/// </summary>
		[DataMember(IsRequired=false)]
		public Int64 Operators
		{
			get	
			{	
				if (Operators_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Operators_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Operators_SKey = null ;
				else
				{
					if (Operators_SKey == null )
						Operators_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.HR.Operator.Operators") ;
					else
						Operators_SKey.ID = value ;
				}
			}
		}
			 	
		

		/// <summary>
		/// 总金额
		/// CustomerDocListQryDTO.Misc.总金额
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
		/// 单据种类
		/// CustomerDocListQryDTO.Misc.单据种类
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_docType ;
		public System.Int32 DocType
		{
			get	
			{	
				return m_docType ;
			}
			set	
			{	
				m_docType = value ;	
			}
		}
			
		

		/// <summary>
		/// 合计总金额
		/// CustomerDocListQryDTO.Misc.合计总金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_sumTotalMoney ;
		public System.Decimal SumTotalMoney
		{
			get	
			{	
				return m_sumTotalMoney ;
			}
			set	
			{	
				m_sumTotalMoney = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
										 
		/// <summary>
		/// 名称
		/// CustomerDocListQryDTO.Misc.名称
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
		/// CustomerDocListQryDTO.Misc.名称
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
		/// 名称
		/// CustomerDocListQryDTO.Misc.名称
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
		/// CustomerDocListQryDTO.Misc.名称
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
		/// CustomerDocListQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public string Operators_Name
		{
			get
			{
				if (m_Multi_operators_Name == null)
					return String.Empty ;
				else
					return m_Multi_operators_Name.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_operators_Name == null)
					m_Multi_operators_Name = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_operators_Name.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_operators_Name ;
		/// <summary>
		/// 多语属性: 名称
		/// CustomerDocListQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Operators_Name
		{
			get
			{
				return m_Multi_operators_Name;
			}
			set
			{
				m_Multi_operators_Name = value ;	
			}
		}
								
		#endregion 
	} 	
}

	
