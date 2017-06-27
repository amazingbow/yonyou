



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.APBillSV
{
	/// <summary>
	/// 汇总立账生单表头DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.APBillSV.APBillHeadDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class APBillHeadDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public APBillHeadDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		
		
		
		
		
		
					BusinessType= 0; 
		
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
		public APBillHeadDTOData(  System.String docTypeCode  , System.String vendorCode  , System.DateTime accrueDate  , System.DateTime invoiceDate  , System.String invoiceCode  , System.String currencyCode  , System.String memo  , System.Int32 businessType  )
		{
			initData();
			this.DocTypeCode = docTypeCode;
			this.VendorCode = vendorCode;
			this.AccrueDate = accrueDate;
			this.InvoiceDate = invoiceDate;
			this.InvoiceCode = invoiceCode;
			this.CurrencyCode = currencyCode;
			this.Memo = memo;
			this.BusinessType = businessType;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 单据类型
		/// 汇总立账生单表头DTO.Misc.单据类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_docTypeCode ;
		public System.String DocTypeCode
		{
			get	
			{	
				return m_docTypeCode ;
			}
			set	
			{	
				m_docTypeCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 供应商代码
		/// 汇总立账生单表头DTO.Misc.供应商代码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_vendorCode ;
		public System.String VendorCode
		{
			get	
			{	
				return m_vendorCode ;
			}
			set	
			{	
				m_vendorCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 立账日期
		/// 汇总立账生单表头DTO.Misc.立账日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_accrueDate ;
		public System.DateTime AccrueDate
		{
			get	
			{	
				return m_accrueDate ;
			}
			set	
			{	
				m_accrueDate = value ;	
			}
		}
			
		

		/// <summary>
		/// 发票日期
		/// 汇总立账生单表头DTO.Misc.发票日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_invoiceDate ;
		public System.DateTime InvoiceDate
		{
			get	
			{	
				return m_invoiceDate ;
			}
			set	
			{	
				m_invoiceDate = value ;	
			}
		}
			
		

		/// <summary>
		/// 发票号
		/// 汇总立账生单表头DTO.Misc.发票号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_invoiceCode ;
		public System.String InvoiceCode
		{
			get	
			{	
				return m_invoiceCode ;
			}
			set	
			{	
				m_invoiceCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 币种
		/// 汇总立账生单表头DTO.Misc.币种
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_currencyCode ;
		public System.String CurrencyCode
		{
			get	
			{	
				return m_currencyCode ;
			}
			set	
			{	
				m_currencyCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 备注
		/// 汇总立账生单表头DTO.Misc.备注
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
		/// 来源业务类型
		/// 汇总立账生单表头DTO.Misc.来源业务类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_businessType ;
		public System.Int32 BusinessType
		{
			get	
			{	
				return m_businessType ;
			}
			set	
			{	
				m_businessType = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																
		#endregion 
	} 	
}

	
