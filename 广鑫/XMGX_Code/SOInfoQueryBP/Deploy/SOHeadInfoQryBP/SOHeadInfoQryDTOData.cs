



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP
{
	/// <summary>
	/// SOHeadInfoQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP.SOHeadInfoQryDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class SOHeadInfoQryDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public SOHeadInfoQryDTOData()
		{
			initData();
		}
		private void initData()
		{
					ID= 0; 
				
		
		
		
		
		
		
		
		
		
		
		
					SO_TotalMoneyAC=0m; 
		
		
		
					SumTotalMoney=0m; 
					TotalShipMoney=0m; 
					SumTotalShipMoney=0m; 

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
		public SOHeadInfoQryDTOData(  System.Int64 iD  , System.String sO_DocNo  , System.DateTime sO_BusinessDate  , System.String customer_Code  , System.String customer_Name  , System.String customerContact_Contact_Name  , Int64 sO_Seller  , System.String sO_Seller_Code  , System.String sO_Seller_Name  , Int64 sO_SaleDepartment  , System.String sO_SaleDepartment_Code  , System.String sO_SaleDepartment_Name  , System.Int64 sO_ID  , System.Decimal sO_TotalMoneyAC  , System.String customerContact_Contact_DefaultPhoneNum  , System.String customerContact_Contact_DefaultMobilNum  , Int64 customerContact_Contact  , System.Decimal sumTotalMoney  , System.Decimal totalShipMoney  , System.Decimal sumTotalShipMoney  )
		{
			initData();
			this.ID = iD;
			this.SO_DocNo = sO_DocNo;
			this.SO_BusinessDate = sO_BusinessDate;
			this.Customer_Code = customer_Code;
			this.Customer_Name = customer_Name;
			this.CustomerContact_Contact_Name = customerContact_Contact_Name;
			this.SO_Seller = sO_Seller;
			this.SO_Seller_Code = sO_Seller_Code;
			this.SO_Seller_Name = sO_Seller_Name;
			this.SO_SaleDepartment = sO_SaleDepartment;
			this.SO_SaleDepartment_Code = sO_SaleDepartment_Code;
			this.SO_SaleDepartment_Name = sO_SaleDepartment_Name;
			this.SO_ID = sO_ID;
			this.SO_TotalMoneyAC = sO_TotalMoneyAC;
			this.CustomerContact_Contact_DefaultPhoneNum = customerContact_Contact_DefaultPhoneNum;
			this.CustomerContact_Contact_DefaultMobilNum = customerContact_Contact_DefaultMobilNum;
			this.CustomerContact_Contact = customerContact_Contact;
			this.SumTotalMoney = sumTotalMoney;
			this.TotalShipMoney = totalShipMoney;
			this.SumTotalShipMoney = sumTotalShipMoney;
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
		/// SOHeadInfoQryDTO.Misc.ID
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
		/// SOHeadInfoQryDTO.Misc.单号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sO_DocNo ;
		public System.String SO_DocNo
		{
			get	
			{	
				return m_sO_DocNo ;
			}
			set	
			{	
				m_sO_DocNo = value ;	
			}
		}
			
		

		/// <summary>
		/// 单据日期
		/// SOHeadInfoQryDTO.Misc.单据日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_sO_BusinessDate ;
		public System.DateTime SO_BusinessDate
		{
			get	
			{	
				return m_sO_BusinessDate ;
			}
			set	
			{	
				m_sO_BusinessDate = value ;	
			}
		}
			
		

		/// <summary>
		/// 编码
		/// SOHeadInfoQryDTO.Misc.编码
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
			 	 	
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_sO_Seller_SKey ;
		/// <summary>
		/// 业务员 序列化Key属性。（传递跨组织序列列字段）
		/// SOHeadInfoQryDTO.Misc.业务员
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey SO_Seller_SKey
		{
			get 
			{
				return m_sO_Seller_SKey ;					
			}
			set
			{
				m_sO_Seller_SKey =value;	
			}
		}


		/// <summary>
		/// 业务员
		/// SOHeadInfoQryDTO.Misc.业务员
		/// </summary>
		[DataMember(IsRequired=false)]
		public Int64 SO_Seller
		{
			get	
			{	
				if (SO_Seller_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return SO_Seller_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					SO_Seller_SKey = null ;
				else
				{
					if (SO_Seller_SKey == null )
						SO_Seller_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.HR.Operator.Operators") ;
					else
						SO_Seller_SKey.ID = value ;
				}
			}
		}
			
		

		/// <summary>
		/// 编码
		/// SOHeadInfoQryDTO.Misc.编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sO_Seller_Code ;
		public System.String SO_Seller_Code
		{
			get	
			{	
				return m_sO_Seller_Code ;
			}
			set	
			{	
				m_sO_Seller_Code = value ;	
			}
		}
			 	
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_sO_SaleDepartment_SKey ;
		/// <summary>
		/// 部门 序列化Key属性。（传递跨组织序列列字段）
		/// SOHeadInfoQryDTO.Misc.部门
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey SO_SaleDepartment_SKey
		{
			get 
			{
				return m_sO_SaleDepartment_SKey ;					
			}
			set
			{
				m_sO_SaleDepartment_SKey =value;	
			}
		}


		/// <summary>
		/// 部门
		/// SOHeadInfoQryDTO.Misc.部门
		/// </summary>
		[DataMember(IsRequired=false)]
		public Int64 SO_SaleDepartment
		{
			get	
			{	
				if (SO_SaleDepartment_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return SO_SaleDepartment_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					SO_SaleDepartment_SKey = null ;
				else
				{
					if (SO_SaleDepartment_SKey == null )
						SO_SaleDepartment_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.HR.Department.Department") ;
					else
						SO_SaleDepartment_SKey.ID = value ;
				}
			}
		}
			
		

		/// <summary>
		/// 编码
		/// SOHeadInfoQryDTO.Misc.编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sO_SaleDepartment_Code ;
		public System.String SO_SaleDepartment_Code
		{
			get	
			{	
				return m_sO_SaleDepartment_Code ;
			}
			set	
			{	
				m_sO_SaleDepartment_Code = value ;	
			}
		}
			 	
		

		/// <summary>
		/// ID
		/// SOHeadInfoQryDTO.Misc.ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_sO_ID ;
		public System.Int64 SO_ID
		{
			get	
			{	
				return m_sO_ID ;
			}
			set	
			{	
				m_sO_ID = value ;	
			}
		}
			
		

		/// <summary>
		/// 金额
		/// SOHeadInfoQryDTO.Misc.金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_sO_TotalMoneyAC ;
		public System.Decimal SO_TotalMoneyAC
		{
			get	
			{	
				return m_sO_TotalMoneyAC ;
			}
			set	
			{	
				m_sO_TotalMoneyAC = value ;	
			}
		}
			
		

		/// <summary>
		/// 电话
		/// SOHeadInfoQryDTO.Misc.电话
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
			
		

		/// <summary>
		/// 手机
		/// SOHeadInfoQryDTO.Misc.手机
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
			
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_customerContact_Contact_SKey ;
		/// <summary>
		/// 负责人 序列化Key属性。（传递跨组织序列列字段）
		/// SOHeadInfoQryDTO.Misc.负责人
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
		/// 负责人
		/// SOHeadInfoQryDTO.Misc.负责人
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
		/// 合计金额
		/// SOHeadInfoQryDTO.Misc.合计金额
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
			
		

		/// <summary>
		/// 累计出货金额
		/// SOHeadInfoQryDTO.Misc.累计出货金额
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
		/// 标准出货
		/// SOHeadInfoQryDTO.Misc.标准出货
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_sumTotalShipMoney ;
		public System.Decimal SumTotalShipMoney
		{
			get	
			{	
				return m_sumTotalShipMoney ;
			}
			set	
			{	
				m_sumTotalShipMoney = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
										 
		/// <summary>
		/// 名称
		/// SOHeadInfoQryDTO.Misc.名称
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
		/// SOHeadInfoQryDTO.Misc.名称
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
		/// SOHeadInfoQryDTO.Misc.名称
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
		/// SOHeadInfoQryDTO.Misc.名称
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
		/// SOHeadInfoQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public string SO_Seller_Name
		{
			get
			{
				if (m_Multi_sO_Seller_Name == null)
					return String.Empty ;
				else
					return m_Multi_sO_Seller_Name.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_sO_Seller_Name == null)
					m_Multi_sO_Seller_Name = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_sO_Seller_Name.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_sO_Seller_Name ;
		/// <summary>
		/// 多语属性: 名称
		/// SOHeadInfoQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_SO_Seller_Name
		{
			get
			{
				return m_Multi_sO_Seller_Name;
			}
			set
			{
				m_Multi_sO_Seller_Name = value ;	
			}
		}
								 
		/// <summary>
		/// 名称
		/// SOHeadInfoQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public string SO_SaleDepartment_Name
		{
			get
			{
				if (m_Multi_sO_SaleDepartment_Name == null)
					return String.Empty ;
				else
					return m_Multi_sO_SaleDepartment_Name.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_sO_SaleDepartment_Name == null)
					m_Multi_sO_SaleDepartment_Name = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_sO_SaleDepartment_Name.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_sO_SaleDepartment_Name ;
		/// <summary>
		/// 多语属性: 名称
		/// SOHeadInfoQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_SO_SaleDepartment_Name
		{
			get
			{
				return m_Multi_sO_SaleDepartment_Name;
			}
			set
			{
				m_Multi_sO_SaleDepartment_Name = value ;	
			}
		}
																		
		#endregion 
	} 	
}

	
