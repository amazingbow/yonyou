



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.SupplierSV
{
	/// <summary>
	/// 供应商DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class SupplierDTOData : UFSoft.UBF.Business.DataTransObjectBase
	{
		public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
                                                   
            knownTypes.Add(typeof(UFIDA.U9.Base.Contact.ContactData));                                                     
            knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public SupplierDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		
		
		
		
		
		
		

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
		public SupplierDTOData(  System.String code  , System.String name  , System.String address  , UFIDA.U9.Base.Contact.ContactData contacts  , System.String bankName  , System.String bankAccount  , System.String bankLineNo  , System.String taxNo  )
		{
			initData();
			this.Code = code;
			this.Name = name;
			this.Address = address;
			this.Contacts = contacts;
			this.BankName = bankName;
			this.BankAccount = bankAccount;
			this.BankLineNo = bankLineNo;
			this.TaxNo = taxNo;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 编码
		/// 供应商DTO.Misc.编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_code ;
		public System.String Code
		{
			get	
			{	
				return m_code ;
			}
			set	
			{	
				m_code = value ;	
			}
		}
			
		

		/// <summary>
		/// 名称
		/// 供应商DTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_name ;
		public System.String Name
		{
			get	
			{	
				return m_name ;
			}
			set	
			{	
				m_name = value ;	
			}
		}
			
		

		/// <summary>
		/// 办公地址
		/// 供应商DTO.Misc.办公地址
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
			
		

		/// <summary>
		/// 联系人
		/// 供应商DTO.Misc.联系人
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Base.Contact.ContactData m_contacts ;
		public UFIDA.U9.Base.Contact.ContactData Contacts
		{
			get	
			{	
				return m_contacts ;
			}
			set	
			{	
				m_contacts = value ;	
			}
		}
			
		

		/// <summary>
		/// 银行名称
		/// 供应商DTO.Misc.银行名称
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
		/// 银行账号
		/// 供应商DTO.Misc.银行账号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_bankAccount ;
		public System.String BankAccount
		{
			get	
			{	
				return m_bankAccount ;
			}
			set	
			{	
				m_bankAccount = value ;	
			}
		}
			
		

		/// <summary>
		/// 银行联行号
		/// 供应商DTO.Misc.银行联行号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_bankLineNo ;
		public System.String BankLineNo
		{
			get	
			{	
				return m_bankLineNo ;
			}
			set	
			{	
				m_bankLineNo = value ;	
			}
		}
			
		

		/// <summary>
		/// 地税号
		/// 供应商DTO.Misc.地税号
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
			
		#endregion	

		#region Multi_Fields
																
		#endregion 
	} 	
}

	
