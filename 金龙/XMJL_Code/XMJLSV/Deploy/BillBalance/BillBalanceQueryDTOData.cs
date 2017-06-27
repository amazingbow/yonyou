



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.BillBalanceSV
{
	/// <summary>
	/// 应付明细账查询条件DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceQueryDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class BillBalanceQueryDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public BillBalanceQueryDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		
					Year= 0; 
							Month= 0; 
		
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
		public BillBalanceQueryDTOData(  System.String vendorCode  , System.String cPersonCode  , System.Int32 year  , System.Int32 month  )
		{
			initData();
			this.VendorCode = vendorCode;
			this.CPersonCode = cPersonCode;
			this.Year = year;
			this.Month = month;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 供应商代码
		/// 应付明细账查询条件DTO.Misc.供应商代码
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
		/// 应付明细账查询条件DTO.Misc.业务员
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
			
		

		/// <summary>
		/// 用友年度
		/// 应付明细账查询条件DTO.Misc.用友年度
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_year ;
		public System.Int32 Year
		{
			get	
			{	
				return m_year ;
			}
			set	
			{	
				m_year = value ;	
			}
		}
			
		

		/// <summary>
		/// 截止月份
		/// 应付明细账查询条件DTO.Misc.截止月份
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_month ;
		public System.Int32 Month
		{
			get	
			{	
				return m_month ;
			}
			set	
			{	
				m_month = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
								
		#endregion 
	} 	
}

	
