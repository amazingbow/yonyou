



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV
{
	/// <summary>
	/// 通用返回结果对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.CommonResultDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class CommonResultDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public CommonResultDTOData()
		{
			initData();
		}
		private void initData()
		{
					IsSuccess=false; 
		
		
		
		
					MiddleId= 0; 
		
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
		public CommonResultDTOData(  System.Boolean isSuccess  , System.String message  , System.String companyCode  , System.String sAPVoucherDisplayCode  , System.DateTime postDate  , System.Int64 middleId  )
		{
			initData();
			this.IsSuccess = isSuccess;
			this.Message = message;
			this.CompanyCode = companyCode;
			this.SAPVoucherDisplayCode = sAPVoucherDisplayCode;
			this.PostDate = postDate;
			this.MiddleId = middleId;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 是否成功
		/// 通用返回结果对象.Misc.是否成功
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Boolean m_isSuccess ;
		public System.Boolean IsSuccess
		{
			get	
			{	
				return m_isSuccess ;
			}
			set	
			{	
				m_isSuccess = value ;	
			}
		}
			
		

		/// <summary>
		/// 消息
		/// 通用返回结果对象.Misc.消息
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_message ;
		public System.String Message
		{
			get	
			{	
				return m_message ;
			}
			set	
			{	
				m_message = value ;	
			}
		}
			
		

		/// <summary>
		/// 公司名称
		/// 通用返回结果对象.Misc.公司名称
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
		/// SAP凭证号
		/// 通用返回结果对象.Misc.SAP凭证号
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
		/// 记账日期
		/// 通用返回结果对象.Misc.记账日期
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
		/// 中间表ID
		/// 通用返回结果对象.Misc.中间表ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_middleId ;
		public System.Int64 MiddleId
		{
			get	
			{	
				return m_middleId ;
			}
			set	
			{	
				m_middleId = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
												
		#endregion 
	} 	
}

	
