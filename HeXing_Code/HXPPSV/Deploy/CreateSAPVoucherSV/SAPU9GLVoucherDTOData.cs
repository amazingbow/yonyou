



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV
{
	/// <summary>
	/// SAP与U9凭证对接中间表DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class SAPU9GLVoucherDTOData : UFSoft.UBF.Business.DataTransObjectBase
	{
		public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
                                                                                                                                 
            knownTypes.Add(typeof(List<UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherLineDTOData>)); 
            knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public SAPU9GLVoucherDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		
		
		
		
		
					PostedPeriod= 0; 
				
		
		

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
	        	        	        	        	        	        	        	        	        	        			if (this.SAPU9GLVoucherLineDTOS!=null)
			{
				foreach(UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherLineDTOData objdata in this.SAPU9GLVoucherLineDTOS)
				{
					objdata.DoSerializeKeyList(dict);
				}
			}
			
		}
		#endregion 
		/// <summary>
		/// Constructor Full Argument
		/// </summary>
		public SAPU9GLVoucherDTOData(  System.String companyCode  , System.String companyName  , System.String sAPVoucherDisplayCode  , System.String voucherCategoryCode  , System.String voucherCategoryDescription  , System.DateTime postDate  , System.Int32 postedPeriod  , System.String currencyCode  , System.String currencyDescription  , List<UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherLineDTOData> sAPU9GLVoucherLineDTOS  )
		{
			initData();
			this.CompanyCode = companyCode;
			this.CompanyName = companyName;
			this.SAPVoucherDisplayCode = sAPVoucherDisplayCode;
			this.VoucherCategoryCode = voucherCategoryCode;
			this.VoucherCategoryDescription = voucherCategoryDescription;
			this.PostDate = postDate;
			this.PostedPeriod = postedPeriod;
			this.CurrencyCode = currencyCode;
			this.CurrencyDescription = currencyDescription;
			this.SAPU9GLVoucherLineDTOS = sAPU9GLVoucherLineDTOS;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 公司代码
		/// SAP与U9凭证对接中间表DTO.Misc.公司代码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_companyCode ;
		public System.String CompanyCode
		{
			get	
			{	
				return m_companyCode ;
			}
			set	
			{	
				m_companyCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 公司名称
		/// SAP与U9凭证对接中间表DTO.Misc.公司名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_companyName ;
		public System.String CompanyName
		{
			get	
			{	
				return m_companyName ;
			}
			set	
			{	
				m_companyName = value ;	
			}
		}
			
		

		/// <summary>
		/// SAP凭证号
		/// SAP与U9凭证对接中间表DTO.Misc.SAP凭证号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sAPVoucherDisplayCode ;
		public System.String SAPVoucherDisplayCode
		{
			get	
			{	
				return m_sAPVoucherDisplayCode ;
			}
			set	
			{	
				m_sAPVoucherDisplayCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 凭证类型编码
		/// SAP与U9凭证对接中间表DTO.Misc.凭证类型编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_voucherCategoryCode ;
		public System.String VoucherCategoryCode
		{
			get	
			{	
				return m_voucherCategoryCode ;
			}
			set	
			{	
				m_voucherCategoryCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 凭证类型描述
		/// SAP与U9凭证对接中间表DTO.Misc.凭证类型描述
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_voucherCategoryDescription ;
		public System.String VoucherCategoryDescription
		{
			get	
			{	
				return m_voucherCategoryDescription ;
			}
			set	
			{	
				m_voucherCategoryDescription = value ;	
			}
		}
			
		

		/// <summary>
		/// 记账日期
		/// SAP与U9凭证对接中间表DTO.Misc.记账日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_postDate ;
		public System.DateTime PostDate
		{
			get	
			{	
				return m_postDate ;
			}
			set	
			{	
				m_postDate = value ;	
			}
		}
			
		

		/// <summary>
		/// 记账期间
		/// SAP与U9凭证对接中间表DTO.Misc.记账期间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_postedPeriod ;
		public System.Int32 PostedPeriod
		{
			get	
			{	
				return m_postedPeriod ;
			}
			set	
			{	
				m_postedPeriod = value ;	
			}
		}
			
		

		/// <summary>
		/// 币种编码
		/// SAP与U9凭证对接中间表DTO.Misc.币种编码
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
		/// 货币描述
		/// SAP与U9凭证对接中间表DTO.Misc.货币描述
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_currencyDescription ;
		public System.String CurrencyDescription
		{
			get	
			{	
				return m_currencyDescription ;
			}
			set	
			{	
				m_currencyDescription = value ;	
			}
		}
			
		

		/// <summary>
		/// SAP与U9凭证对接中间表行列表
		/// SAP与U9凭证对接中间表DTO.Misc.SAP与U9凭证对接中间表行列表
		/// </summary>
		[DataMember(IsRequired=false)]
		private List<UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherLineDTOData> m_sAPU9GLVoucherLineDTOS ;
		public List<UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherLineDTOData> SAPU9GLVoucherLineDTOS
		{
			get	
			{	
				if (m_sAPU9GLVoucherLineDTOS == null )
				{
					List<UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherLineDTOData> n_m_list = new List<UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherLineDTOData>() ;
					m_sAPU9GLVoucherLineDTOS = n_m_list ;
				}
				return m_sAPU9GLVoucherLineDTOS ;
			}
			set	
			{	
				m_sAPU9GLVoucherLineDTOS = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																				
		#endregion 
	} 	
}

	
