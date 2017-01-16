



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP
{
	/// <summary>
	/// LB编码修改DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LaserLabBNChangeBPDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class LaserLabBNChangeBPDTOData : UFSoft.UBF.Business.DataTransObjectBase
	{
		public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
            knownTypes.Add(typeof(List<System.String>));             
            knownTypes.Add(typeof(List<System.String>));             
            knownTypes.Add(typeof(List<System.String>));             
            knownTypes.Add(typeof(List<System.DateTime>)); 
            knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public LaserLabBNChangeBPDTOData()
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
		public LaserLabBNChangeBPDTOData(  List<System.String> lB  , List<System.String> bN  , List<System.String> cP  , List<System.DateTime> masterDT  )
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
		/// LB编码修改DTO.Misc.LB编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private List<System.String> m_lB ;
		public List<System.String> LB
		{
			get	
			{	
				if (m_lB == null )
				{
					List<System.String> n_m_list = new List<System.String>() ;
					m_lB = n_m_list ;
				}
				return m_lB ;
			}
			set	
			{	
				m_lB = value ;	
			}
		}
			
		

		/// <summary>
		/// 批次号
		/// LB编码修改DTO.Misc.批次号
		/// </summary>
		[DataMember(IsRequired=false)]
		private List<System.String> m_bN ;
		public List<System.String> BN
		{
			get	
			{	
				if (m_bN == null )
				{
					List<System.String> n_m_list = new List<System.String>() ;
					m_bN = n_m_list ;
				}
				return m_bN ;
			}
			set	
			{	
				m_bN = value ;	
			}
		}
			
		

		/// <summary>
		/// 状态
		/// LB编码修改DTO.Misc.状态
		/// </summary>
		[DataMember(IsRequired=false)]
		private List<System.String> m_cP ;
		public List<System.String> CP
		{
			get	
			{	
				if (m_cP == null )
				{
					List<System.String> n_m_list = new List<System.String>() ;
					m_cP = n_m_list ;
				}
				return m_cP ;
			}
			set	
			{	
				m_cP = value ;	
			}
		}
			
		

		/// <summary>
		/// 物料时间
		/// LB编码修改DTO.Misc.物料时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private List<System.DateTime> m_masterDT ;
		public List<System.DateTime> MasterDT
		{
			get	
			{	
				if (m_masterDT == null )
				{
					List<System.DateTime> n_m_list = new List<System.DateTime>() ;
					m_masterDT = n_m_list ;
				}
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

	
