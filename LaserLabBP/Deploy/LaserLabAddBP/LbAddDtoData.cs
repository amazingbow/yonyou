



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabAddBP
{
	/// <summary>
	/// 镭射标DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabAddBP.LbAddDtoData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class LbAddDtoData : UFSoft.UBF.Business.DataTransObjectBase
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
		public LbAddDtoData()
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
		public LbAddDtoData(  System.String bN  , System.String lB  , System.String type  , System.DateTime masterDT  , System.String customer  )
		{
			initData();
			this.BN = bN;
			this.LB = lB;
			this.Type = type;
			this.MasterDT = masterDT;
			this.Customer = customer;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 批次号
		/// 镭射标DTO.Misc.批次号
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
		/// 镭射标
		/// 镭射标DTO.Misc.镭射标
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
			
		

		/// <summary>
		/// 型号
		/// 镭射标DTO.Misc.型号
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
		/// 物料时间
		/// 镭射标DTO.Misc.物料时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_masterDT ;
		public System.DateTime MasterDT
		{
			get	
			{	
				return m_masterDT ;
			}
			set	
			{	
				m_masterDT = value ;	
			}
		}
			
		

		/// <summary>
		/// 客户
		/// 镭射标DTO.Misc.客户
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_customer ;
		public System.String Customer
		{
			get	
			{	
				return m_customer ;
			}
			set	
			{	
				m_customer = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
										
		#endregion 
	} 	
}

	
