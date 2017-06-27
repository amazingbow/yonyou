



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.SupplierQryBP
{
	/// <summary>
	/// SupplierQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.FJGX.SupplierQryBP.SupplierQryDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class SupplierQryDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public SupplierQryDTOData()
		{
			initData();
		}
		private void initData()
		{
					ID= 0; 
				
		
		
		
		
		
		
		
					APTotalMoney=0m; 
		
		
		
		
		
		
		
		
					SumAPTotalMoney=0m; 

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
		public SupplierQryDTOData(  System.Int64 iD  , System.String supplier_Code  , System.String supplier_Name  , Int64 supplierContact_Contact  , System.String supplierContact_Contact_Name  , System.String supplierContact_Contact_DefaultMobilNum  , Int64 supplier_Category  , System.String supplier_Category_Name  , System.String supplierContact_Contact_DefaultFaxNum  , System.Decimal aPTotalMoney  , System.String supplier_StateTaxNo  , System.String supplierBankAccount_Name  , System.String supplier_OfficialLocation_Name  , Int64 supplier_Purchaser  , System.String supplier_Purchaser_Name  , System.String supplier_Description  , System.Int64 supplier_ID  , System.String supplierContact_Contact_DefaultPhoneNum  , System.Decimal sumAPTotalMoney  )
		{
			initData();
			this.ID = iD;
			this.Supplier_Code = supplier_Code;
			this.Supplier_Name = supplier_Name;
			this.SupplierContact_Contact = supplierContact_Contact;
			this.SupplierContact_Contact_Name = supplierContact_Contact_Name;
			this.SupplierContact_Contact_DefaultMobilNum = supplierContact_Contact_DefaultMobilNum;
			this.Supplier_Category = supplier_Category;
			this.Supplier_Category_Name = supplier_Category_Name;
			this.SupplierContact_Contact_DefaultFaxNum = supplierContact_Contact_DefaultFaxNum;
			this.APTotalMoney = aPTotalMoney;
			this.Supplier_StateTaxNo = supplier_StateTaxNo;
			this.SupplierBankAccount_Name = supplierBankAccount_Name;
			this.Supplier_OfficialLocation_Name = supplier_OfficialLocation_Name;
			this.Supplier_Purchaser = supplier_Purchaser;
			this.Supplier_Purchaser_Name = supplier_Purchaser_Name;
			this.Supplier_Description = supplier_Description;
			this.Supplier_ID = supplier_ID;
			this.SupplierContact_Contact_DefaultPhoneNum = supplierContact_Contact_DefaultPhoneNum;
			this.SumAPTotalMoney = sumAPTotalMoney;
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
		/// SupplierQryDTO.Misc.ID
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
		/// 编码
		/// SupplierQryDTO.Misc.编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_supplier_Code ;
		public System.String Supplier_Code
		{
			get	
			{	
				return m_supplier_Code ;
			}
			set	
			{	
				m_supplier_Code = value ;	
			}
		}
			 	
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_supplierContact_Contact_SKey ;
		/// <summary>
		/// 联系人 序列化Key属性。（传递跨组织序列列字段）
		/// SupplierQryDTO.Misc.联系人
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey SupplierContact_Contact_SKey
		{
			get 
			{
				return m_supplierContact_Contact_SKey ;					
			}
			set
			{
				m_supplierContact_Contact_SKey =value;	
			}
		}


		/// <summary>
		/// 联系人
		/// SupplierQryDTO.Misc.联系人
		/// </summary>
		[DataMember(IsRequired=false)]
		public Int64 SupplierContact_Contact
		{
			get	
			{	
				if (SupplierContact_Contact_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return SupplierContact_Contact_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					SupplierContact_Contact_SKey = null ;
				else
				{
					if (SupplierContact_Contact_SKey == null )
						SupplierContact_Contact_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.Contact.Contact") ;
					else
						SupplierContact_Contact_SKey.ID = value ;
				}
			}
		}
			 	
		

		/// <summary>
		/// 手机
		/// SupplierQryDTO.Misc.手机
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_supplierContact_Contact_DefaultMobilNum ;
		public System.String SupplierContact_Contact_DefaultMobilNum
		{
			get	
			{	
				return m_supplierContact_Contact_DefaultMobilNum ;
			}
			set	
			{	
				m_supplierContact_Contact_DefaultMobilNum = value ;	
			}
		}
			
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_supplier_Category_SKey ;
		/// <summary>
		/// 分类 序列化Key属性。（传递跨组织序列列字段）
		/// SupplierQryDTO.Misc.分类
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Supplier_Category_SKey
		{
			get 
			{
				return m_supplier_Category_SKey ;					
			}
			set
			{
				m_supplier_Category_SKey =value;	
			}
		}


		/// <summary>
		/// 分类
		/// SupplierQryDTO.Misc.分类
		/// </summary>
		[DataMember(IsRequired=false)]
		public Int64 Supplier_Category
		{
			get	
			{	
				if (Supplier_Category_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Supplier_Category_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Supplier_Category_SKey = null ;
				else
				{
					if (Supplier_Category_SKey == null )
						Supplier_Category_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.SCM.Supplier.SupplierCategory") ;
					else
						Supplier_Category_SKey.ID = value ;
				}
			}
		}
			 	
		

		/// <summary>
		/// 传真
		/// SupplierQryDTO.Misc.传真
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_supplierContact_Contact_DefaultFaxNum ;
		public System.String SupplierContact_Contact_DefaultFaxNum
		{
			get	
			{	
				return m_supplierContact_Contact_DefaultFaxNum ;
			}
			set	
			{	
				m_supplierContact_Contact_DefaultFaxNum = value ;	
			}
		}
			
		

		/// <summary>
		/// 应付余额
		/// SupplierQryDTO.Misc.应付余额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_aPTotalMoney ;
		public System.Decimal APTotalMoney
		{
			get	
			{	
				return m_aPTotalMoney ;
			}
			set	
			{	
				m_aPTotalMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 税号
		/// SupplierQryDTO.Misc.税号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_supplier_StateTaxNo ;
		public System.String Supplier_StateTaxNo
		{
			get	
			{	
				return m_supplier_StateTaxNo ;
			}
			set	
			{	
				m_supplier_StateTaxNo = value ;	
			}
		}
			 	 	
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_supplier_Purchaser_SKey ;
		/// <summary>
		/// 业务员 序列化Key属性。（传递跨组织序列列字段）
		/// SupplierQryDTO.Misc.业务员
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Supplier_Purchaser_SKey
		{
			get 
			{
				return m_supplier_Purchaser_SKey ;					
			}
			set
			{
				m_supplier_Purchaser_SKey =value;	
			}
		}


		/// <summary>
		/// 业务员
		/// SupplierQryDTO.Misc.业务员
		/// </summary>
		[DataMember(IsRequired=false)]
		public Int64 Supplier_Purchaser
		{
			get	
			{	
				if (Supplier_Purchaser_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Supplier_Purchaser_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Supplier_Purchaser_SKey = null ;
				else
				{
					if (Supplier_Purchaser_SKey == null )
						Supplier_Purchaser_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.HR.Operator.Operators") ;
					else
						Supplier_Purchaser_SKey.ID = value ;
				}
			}
		}
			 	 	
		

		/// <summary>
		/// ID
		/// SupplierQryDTO.Misc.ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_supplier_ID ;
		public System.Int64 Supplier_ID
		{
			get	
			{	
				return m_supplier_ID ;
			}
			set	
			{	
				m_supplier_ID = value ;	
			}
		}
			
		

		/// <summary>
		/// 电话
		/// SupplierQryDTO.Misc.电话
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_supplierContact_Contact_DefaultPhoneNum ;
		public System.String SupplierContact_Contact_DefaultPhoneNum
		{
			get	
			{	
				return m_supplierContact_Contact_DefaultPhoneNum ;
			}
			set	
			{	
				m_supplierContact_Contact_DefaultPhoneNum = value ;	
			}
		}
			
		

		/// <summary>
		/// 合计应付金额
		/// SupplierQryDTO.Misc.合计应付金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_sumAPTotalMoney ;
		public System.Decimal SumAPTotalMoney
		{
			get	
			{	
				return m_sumAPTotalMoney ;
			}
			set	
			{	
				m_sumAPTotalMoney = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
						 
		/// <summary>
		/// 名称
		/// SupplierQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public string Supplier_Name
		{
			get
			{
				if (m_Multi_supplier_Name == null)
					return String.Empty ;
				else
					return m_Multi_supplier_Name.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_supplier_Name == null)
					m_Multi_supplier_Name = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_supplier_Name.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_supplier_Name ;
		/// <summary>
		/// 多语属性: 名称
		/// SupplierQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Supplier_Name
		{
			get
			{
				return m_Multi_supplier_Name;
			}
			set
			{
				m_Multi_supplier_Name = value ;	
			}
		}
						 
		/// <summary>
		/// 名称
		/// SupplierQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public string SupplierContact_Contact_Name
		{
			get
			{
				if (m_Multi_supplierContact_Contact_Name == null)
					return String.Empty ;
				else
					return m_Multi_supplierContact_Contact_Name.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_supplierContact_Contact_Name == null)
					m_Multi_supplierContact_Contact_Name = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_supplierContact_Contact_Name.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_supplierContact_Contact_Name ;
		/// <summary>
		/// 多语属性: 名称
		/// SupplierQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_SupplierContact_Contact_Name
		{
			get
			{
				return m_Multi_supplierContact_Contact_Name;
			}
			set
			{
				m_Multi_supplierContact_Contact_Name = value ;	
			}
		}
								 
		/// <summary>
		/// 名称
		/// SupplierQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public string Supplier_Category_Name
		{
			get
			{
				if (m_Multi_supplier_Category_Name == null)
					return String.Empty ;
				else
					return m_Multi_supplier_Category_Name.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_supplier_Category_Name == null)
					m_Multi_supplier_Category_Name = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_supplier_Category_Name.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_supplier_Category_Name ;
		/// <summary>
		/// 多语属性: 名称
		/// SupplierQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Supplier_Category_Name
		{
			get
			{
				return m_Multi_supplier_Category_Name;
			}
			set
			{
				m_Multi_supplier_Category_Name = value ;	
			}
		}
										 
		/// <summary>
		/// 开户银行
		/// SupplierQryDTO.Misc.开户银行
		/// </summary>
		[DataMember(IsRequired=false)]
		public string SupplierBankAccount_Name
		{
			get
			{
				if (m_Multi_supplierBankAccount_Name == null)
					return String.Empty ;
				else
					return m_Multi_supplierBankAccount_Name.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_supplierBankAccount_Name == null)
					m_Multi_supplierBankAccount_Name = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_supplierBankAccount_Name.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_supplierBankAccount_Name ;
		/// <summary>
		/// 多语属性: 开户银行
		/// SupplierQryDTO.Misc.开户银行
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_SupplierBankAccount_Name
		{
			get
			{
				return m_Multi_supplierBankAccount_Name;
			}
			set
			{
				m_Multi_supplierBankAccount_Name = value ;	
			}
		}
				 
		/// <summary>
		/// 名称
		/// SupplierQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public string Supplier_OfficialLocation_Name
		{
			get
			{
				if (m_Multi_supplier_OfficialLocation_Name == null)
					return String.Empty ;
				else
					return m_Multi_supplier_OfficialLocation_Name.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_supplier_OfficialLocation_Name == null)
					m_Multi_supplier_OfficialLocation_Name = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_supplier_OfficialLocation_Name.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_supplier_OfficialLocation_Name ;
		/// <summary>
		/// 多语属性: 名称
		/// SupplierQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Supplier_OfficialLocation_Name
		{
			get
			{
				return m_Multi_supplier_OfficialLocation_Name;
			}
			set
			{
				m_Multi_supplier_OfficialLocation_Name = value ;	
			}
		}
						 
		/// <summary>
		/// 名称
		/// SupplierQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public string Supplier_Purchaser_Name
		{
			get
			{
				if (m_Multi_supplier_Purchaser_Name == null)
					return String.Empty ;
				else
					return m_Multi_supplier_Purchaser_Name.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_supplier_Purchaser_Name == null)
					m_Multi_supplier_Purchaser_Name = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_supplier_Purchaser_Name.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_supplier_Purchaser_Name ;
		/// <summary>
		/// 多语属性: 名称
		/// SupplierQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Supplier_Purchaser_Name
		{
			get
			{
				return m_Multi_supplier_Purchaser_Name;
			}
			set
			{
				m_Multi_supplier_Purchaser_Name = value ;	
			}
		}
				 
		/// <summary>
		/// 描述
		/// SupplierQryDTO.Misc.描述
		/// </summary>
		[DataMember(IsRequired=false)]
		public string Supplier_Description
		{
			get
			{
				if (m_Multi_supplier_Description == null)
					return String.Empty ;
				else
					return m_Multi_supplier_Description.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_supplier_Description == null)
					m_Multi_supplier_Description = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_supplier_Description.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_supplier_Description ;
		/// <summary>
		/// 多语属性: 描述
		/// SupplierQryDTO.Misc.描述
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_Supplier_Description
		{
			get
			{
				return m_Multi_supplier_Description;
			}
			set
			{
				m_Multi_supplier_Description = value ;	
			}
		}
								
		#endregion 
	} 	
}

	
