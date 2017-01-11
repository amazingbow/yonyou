



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP
{
	/// <summary>
	/// 报废操作获取LB信息DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.GetScrapLBInfoDtoData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class GetScrapLBInfoDtoData : UFSoft.UBF.Business.DataTransObjectBase
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
		public GetScrapLBInfoDtoData()
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
		public GetScrapLBInfoDtoData(  System.String bN  , System.String type  , System.DateTime date  , System.DateTime time  , System.String cP  , System.String lB  )
		{
			initData();
			this.BN = bN;
			this.Type = type;
			this.Date = date;
			this.Time = time;
			this.CP = cP;
			this.LB = lB;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 批次号
		/// 报废操作获取LB信息DTO.Misc.批次号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_bN ;
		public System.String BN
		{
			get	
			{	
				return m_bN ;
			}
			set	
			{	
				m_bN = value ;	
			}
		}
			
		

		/// <summary>
		/// 型号
		/// 报废操作获取LB信息DTO.Misc.型号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_type ;
		public System.String Type
		{
			get	
			{	
				return m_type ;
			}
			set	
			{	
				m_type = value ;	
			}
		}
			
		

		/// <summary>
		/// 日期
		/// 报废操作获取LB信息DTO.Misc.日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_date ;
		public System.DateTime Date
		{
			get	
			{	
				return m_date ;
			}
			set	
			{	
				m_date = value ;	
			}
		}
			
		

		/// <summary>
		/// 时间
		/// 报废操作获取LB信息DTO.Misc.时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_time ;
		public System.DateTime Time
		{
			get	
			{	
				return m_time ;
			}
			set	
			{	
				m_time = value ;	
			}
		}
			
		

		/// <summary>
		/// 状态
		/// 报废操作获取LB信息DTO.Misc.状态
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_cP ;
		public System.String CP
		{
			get	
			{	
				return m_cP ;
			}
			set	
			{	
				m_cP = value ;	
			}
		}
			
		

		/// <summary>
		/// LB编码
		/// 报废操作获取LB信息DTO.Misc.LB编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_lB ;
		public System.String LB
		{
			get	
			{	
				return m_lB ;
			}
			set	
			{	
				m_lB = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
												
		#endregion 
	} 	
}

	
