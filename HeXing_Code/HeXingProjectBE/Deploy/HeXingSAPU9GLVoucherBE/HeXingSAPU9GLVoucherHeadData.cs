
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE
{
	/// <summary>
	/// SAP与U9凭证对接中间表头 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHeadData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class HeXingSAPU9GLVoucherHeadData : UFSoft.UBF.Business.DataTransObjectBase
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(List<UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherLineData>));
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData));
                        
                        
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public HeXingSAPU9GLVoucherHeadData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     			
	     			
	     			
	     			
	     			
	     			
	     			
	     							PostedPeriod= 0; 			     			
	     			
	     			
	     			
	     							IsU9Successful= 0; 			     			
	     			
	     							U9VoucherID= 0; 			     							IsRepeat= 0; 		

			//设置组合的集合属性为List<>对象. -目前直接在属性上处理.
			
			//调用默认值初始化服务进行配置方式初始化
			UFSoft.UBF.Service.DTOService.InitConfigDefault(this);
		}		
		[System.Runtime.Serialization.OnDeserializing]
        internal void OnDeserializing(System.Runtime.Serialization.StreamingContext context)
        {
			 initData();
        }
        
		#region System Fields
		///<summary>
		/// 实体类型. 
		/// </summary>
		[DataMember(IsRequired=false)]
		public override string SysEntityType
		{
			get { return "UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherHead" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        					/// <summary>
		/// SAP与U9凭证对接中间表行
		/// SAP与U9凭证对接中间表头.Misc.SAP与U9凭证对接中间表行
		/// </summary>
		[DataMember(IsRequired=false)]
		private List<UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherLineData> m_heXingSAPU9GLVoucherLine;
		public List<UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherLineData> HeXingSAPU9GLVoucherLine
		{
			get	
			{	
				if (m_heXingSAPU9GLVoucherLine == null)
				{
					List<UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherLineData> m_list = new List<UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.HeXingSAPU9GLVoucherLineData>() ;
					m_heXingSAPU9GLVoucherLine = m_list;
				}
				return m_heXingSAPU9GLVoucherLine ;
			}
			set	
			{	
				m_heXingSAPU9GLVoucherLine = value ;
			}
		}		

			        					/// <summary>
		/// 是否写入U9凭证成功
		/// SAP与U9凭证对接中间表头.Misc.是否写入U9凭证成功
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_isU9Successful;
		public System.Int32 IsU9Successful
		{
			get	
			{	
				return m_isU9Successful ;
			}
			set	
			{	
				m_isU9Successful = value ;
			}
		}		

			
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// SAP与U9凭证对接中间表头.Key.ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_iD ;
		public System.Int64 ID
		{
			get	
			{	
				return m_iD  ;
			}
			set	
			{	
				m_iD = value ;	
			}
		}
		

				/// <summary>
		/// 创建时间
		/// SAP与U9凭证对接中间表头.Sys.创建时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_createdOn ;
		public System.DateTime CreatedOn
		{
			get	
			{	
				return m_createdOn  ;
			}
			set	
			{	
				m_createdOn = value ;	
			}
		}
		

				/// <summary>
		/// 创建人
		/// SAP与U9凭证对接中间表头.Sys.创建人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_createdBy ;
		public System.String CreatedBy
		{
			get	
			{	
				return m_createdBy  ;
			}
			set	
			{	
				m_createdBy = value ;	
			}
		}
		

				/// <summary>
		/// 修改时间
		/// SAP与U9凭证对接中间表头.Sys.修改时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_modifiedOn ;
		public System.DateTime ModifiedOn
		{
			get	
			{	
				return m_modifiedOn  ;
			}
			set	
			{	
				m_modifiedOn = value ;	
			}
		}
		

				/// <summary>
		/// 修改人
		/// SAP与U9凭证对接中间表头.Sys.修改人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_modifiedBy ;
		public System.String ModifiedBy
		{
			get	
			{	
				return m_modifiedBy  ;
			}
			set	
			{	
				m_modifiedBy = value ;	
			}
		}
		

				/// <summary>
		/// 事务版本
		/// SAP与U9凭证对接中间表头.Sys.事务版本
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_sysVersion ;
		public System.Int64 SysVersion
		{
			get	
			{	
				return m_sysVersion  ;
			}
			set	
			{	
				m_sysVersion = value ;	
			}
		}
		

				/// <summary>
		/// 公司代码
		/// SAP与U9凭证对接中间表头.Misc.公司代码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_companyCode ;
		public System.String CompanyCode
		{
			get	
			{	
				return m_companyCode  ;
			}
			set	
			{	
				m_companyCode = value ;	
			}
		}
		

				/// <summary>
		/// 公司名称
		/// SAP与U9凭证对接中间表头.Misc.公司名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_companyName ;
		public System.String CompanyName
		{
			get	
			{	
				return m_companyName  ;
			}
			set	
			{	
				m_companyName = value ;	
			}
		}
		

				/// <summary>
		/// SAP凭证号
		/// SAP与U9凭证对接中间表头.Misc.SAP凭证号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_sAPVoucherDisplayCode ;
		public System.String SAPVoucherDisplayCode
		{
			get	
			{	
				return m_sAPVoucherDisplayCode  ;
			}
			set	
			{	
				m_sAPVoucherDisplayCode = value ;	
			}
		}
		

				/// <summary>
		/// 凭证类型编码
		/// SAP与U9凭证对接中间表头.Misc.凭证类型编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_voucherCategoryCode ;
		public System.String VoucherCategoryCode
		{
			get	
			{	
				return m_voucherCategoryCode  ;
			}
			set	
			{	
				m_voucherCategoryCode = value ;	
			}
		}
		

				/// <summary>
		/// 凭证类型描述
		/// SAP与U9凭证对接中间表头.Misc.凭证类型描述
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_voucherCategoryDescription ;
		public System.String VoucherCategoryDescription
		{
			get	
			{	
				return m_voucherCategoryDescription  ;
			}
			set	
			{	
				m_voucherCategoryDescription = value ;	
			}
		}
		

				/// <summary>
		/// 记账日期
		/// SAP与U9凭证对接中间表头.Misc.记账日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_postDate ;
		public System.DateTime PostDate
		{
			get	
			{	
				return m_postDate  ;
			}
			set	
			{	
				m_postDate = value ;	
			}
		}
		

				/// <summary>
		/// 记账期间
		/// SAP与U9凭证对接中间表头.Misc.记账期间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_postedPeriod ;
		public System.Int32 PostedPeriod
		{
			get	
			{	
				return m_postedPeriod  ;
			}
			set	
			{	
				m_postedPeriod = value ;	
			}
		}
		

				/// <summary>
		/// 币种编码
		/// SAP与U9凭证对接中间表头.Misc.币种编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_currencyCode ;
		public System.String CurrencyCode
		{
			get	
			{	
				return m_currencyCode  ;
			}
			set	
			{	
				m_currencyCode = value ;	
			}
		}
		

				/// <summary>
		/// 货币描述
		/// SAP与U9凭证对接中间表头.Misc.货币描述
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_currencyDescription ;
		public System.String CurrencyDescription
		{
			get	
			{	
				return m_currencyDescription  ;
			}
			set	
			{	
				m_currencyDescription = value ;	
			}
		}
		

				/// <summary>
		/// 导入日期
		/// SAP与U9凭证对接中间表头.Misc.导入日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_importDate ;
		public System.DateTime ImportDate
		{
			get	
			{	
				return m_importDate  ;
			}
			set	
			{	
				m_importDate = value ;	
			}
		}
		

				/// <summary>
		/// 写入U9凭证时间
		/// SAP与U9凭证对接中间表头.Misc.写入U9凭证时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_completeU9Date ;
		public System.DateTime CompleteU9Date
		{
			get	
			{	
				return m_completeU9Date  ;
			}
			set	
			{	
				m_completeU9Date = value ;	
			}
		}
		

				/// <summary>
		/// 写入U9凭证时错误信息
		/// SAP与U9凭证对接中间表头.Misc.写入U9凭证时错误信息
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_u9ErrorResult ;
		public System.String U9ErrorResult
		{
			get	
			{	
				return m_u9ErrorResult  ;
			}
			set	
			{	
				m_u9ErrorResult = value ;	
			}
		}
		

				/// <summary>
		/// 实体扩展字段
		/// SAP与U9凭证对接中间表头.Misc.实体扩展字段
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData m_descFlexField ;
		public UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData DescFlexField
		{
			get	
			{	
				return m_descFlexField  ;
			}
			set	
			{	
				m_descFlexField = value ;	
			}
		}
		

				/// <summary>
		/// U9凭证ID
		/// SAP与U9凭证对接中间表头.Misc.U9凭证ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_u9VoucherID ;
		public System.Int64 U9VoucherID
		{
			get	
			{	
				return m_u9VoucherID  ;
			}
			set	
			{	
				m_u9VoucherID = value ;	
			}
		}
		

				/// <summary>
		/// 是否重复
		/// SAP与U9凭证对接中间表头.Misc.是否重复
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_isRepeat ;
		public System.Int32 IsRepeat
		{
			get	
			{	
				return m_isRepeat  ;
			}
			set	
			{	
				m_isRepeat = value ;	
			}
		}
		
		#endregion	

		#region Multi_Fields
																							
		#endregion 		
	}	

}

