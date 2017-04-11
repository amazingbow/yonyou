



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP
{
	/// <summary>
	/// LB编码信息DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LabBNInfoDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class LabBNInfoDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public LabBNInfoDTOData()
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
		public LabBNInfoDTOData(  System.String lB  , System.String bN  , System.String cP  , System.DateTime masterDT  )
		{
			initData();
			this.LB = lB;
			this.BN = bN;
			this.CP = cP;
			this.MasterDT = masterDT;
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
		/// LB编码
		/// LB编码信息DTO.Misc.LB编码
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
		/// 批次号
		/// LB编码信息DTO.Misc.批次号
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
		/// 状态
		/// LB编码信息DTO.Misc.状态
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
		/// 物料时间
		/// LB编码信息DTO.Misc.物料时间
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
			
		#endregion	

		#region Multi_Fields
								
		#endregion 
	} 	
}

	
