



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.BillBalanceSV
{
	/// <summary>
	/// 应付明细账DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class BillBalanceDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public BillBalanceDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		
		
		
		
		
					APBillMoney=0m; 
					PayBillMoney=0m; 
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
		public BillBalanceDTOData(  System.DateTime accrueDate  , System.String voucherDisplayCode  , System.String abstracts  , System.String docType  , System.String docNo  , System.String aCName  , System.Decimal aPBillMoney  , System.Decimal payBillMoney  , System.Decimal balanceMoney  , System.String vendorCode  , System.String cPersonCode  )
		{
			initData();
			this.AccrueDate = accrueDate;
			this.VoucherDisplayCode = voucherDisplayCode;
			this.Abstracts = abstracts;
			this.DocType = docType;
			this.DocNo = docNo;
			this.ACName = aCName;
			this.APBillMoney = aPBillMoney;
			this.PayBillMoney = payBillMoney;
			this.BalanceMoney = balanceMoney;
			this.VendorCode = vendorCode;
			this.CPersonCode = cPersonCode;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 日期
		/// 应付明细账DTO.Misc.日期
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
		/// 凭证号
		/// 应付明细账DTO.Misc.凭证号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_voucherDisplayCode ;
		public System.String VoucherDisplayCode
		{
			get	
			{	
				return m_voucherDisplayCode ;
			}
			set	
			{	
				m_voucherDisplayCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 摘要
		/// 应付明细账DTO.Misc.摘要
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_abstracts ;
		public System.String Abstracts
		{
			get	
			{	
				return m_abstracts ;
			}
			set	
			{	
				m_abstracts = value ;	
			}
		}
			
		

		/// <summary>
		/// 单据类型
		/// 应付明细账DTO.Misc.单据类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_docType ;
		public System.String DocType
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
		/// 单据号
		/// 应付明细账DTO.Misc.单据号
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
		/// 币种
		/// 应付明细账DTO.Misc.币种
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_aCName ;
		public System.String ACName
		{
			get	
			{	
				return m_aCName ;
			}
			set	
			{	
				m_aCName = value ;	
			}
		}
			
		

		/// <summary>
		/// 本期应付金额
		/// 应付明细账DTO.Misc.本期应付金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_aPBillMoney ;
		public System.Decimal APBillMoney
		{
			get	
			{	
				return m_aPBillMoney ;
			}
			set	
			{	
				m_aPBillMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 本期付款金额
		/// 应付明细账DTO.Misc.本期付款金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_payBillMoney ;
		public System.Decimal PayBillMoney
		{
			get	
			{	
				return m_payBillMoney ;
			}
			set	
			{	
				m_payBillMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 余额
		/// 应付明细账DTO.Misc.余额
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
			
		

		/// <summary>
		/// 供应商
		/// 应付明细账DTO.Misc.供应商
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
		/// 业务员
		/// 应付明细账DTO.Misc.业务员
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_cPersonCode ;
		public System.String CPersonCode
		{
			get	
			{	
				return m_cPersonCode ;
			}
			set	
			{	
				m_cPersonCode = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																						
		#endregion 
	} 	
}

	
