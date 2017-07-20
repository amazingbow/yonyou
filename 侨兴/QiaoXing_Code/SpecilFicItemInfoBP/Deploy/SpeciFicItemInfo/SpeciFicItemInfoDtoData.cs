



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo
{
	/// <summary>
	/// 特定物料DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.SpeciFicItemInfoDtoData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class SpeciFicItemInfoDtoData : UFSoft.UBF.Business.DataTransObjectBase
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
		public SpeciFicItemInfoDtoData()
		{
			initData();
		}
		private void initData()
		{
					ItemMaster= 0; 
				
		
					Wh= 0; 
				
		
					ReqPRQty=0m; 
		

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
		public SpeciFicItemInfoDtoData(  System.Int64 itemMaster  , System.String itemMaster_Code  , System.String itemMaster_Name  , System.Int64 wh  , System.String wh_Code  , System.String wh_Name  , System.Decimal reqPRQty  , System.DateTime reqDate  )
		{
			initData();
			this.ItemMaster = itemMaster;
			this.ItemMaster_Code = itemMaster_Code;
			this.ItemMaster_Name = itemMaster_Name;
			this.Wh = wh;
			this.Wh_Code = wh_Code;
			this.Wh_Name = wh_Name;
			this.ReqPRQty = reqPRQty;
			this.ReqDate = reqDate;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 料品
		/// 特定物料DTO.Misc.料品
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_itemMaster ;
		public System.Int64 ItemMaster
		{
			get	
			{	
				return m_itemMaster ;
			}
			set	
			{	
				m_itemMaster = value ;	
			}
		}
			
		

		/// <summary>
		/// 料品_编码
		/// 特定物料DTO.Misc.料品_编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_itemMaster_Code ;
		public System.String ItemMaster_Code
		{
			get	
			{	
				return m_itemMaster_Code ;
			}
			set	
			{	
				m_itemMaster_Code = value ;	
			}
		}
			
		

		/// <summary>
		/// 料品_名称
		/// 特定物料DTO.Misc.料品_名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_itemMaster_Name ;
		public System.String ItemMaster_Name
		{
			get	
			{	
				return m_itemMaster_Name ;
			}
			set	
			{	
				m_itemMaster_Name = value ;	
			}
		}
			
		

		/// <summary>
		/// 存储地点
		/// 特定物料DTO.Misc.存储地点
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_wh ;
		public System.Int64 Wh
		{
			get	
			{	
				return m_wh ;
			}
			set	
			{	
				m_wh = value ;	
			}
		}
			
		

		/// <summary>
		/// 存储地点_编码
		/// 特定物料DTO.Misc.存储地点_编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_wh_Code ;
		public System.String Wh_Code
		{
			get	
			{	
				return m_wh_Code ;
			}
			set	
			{	
				m_wh_Code = value ;	
			}
		}
			
		

		/// <summary>
		/// 存储地点_名称
		/// 特定物料DTO.Misc.存储地点_名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_wh_Name ;
		public System.String Wh_Name
		{
			get	
			{	
				return m_wh_Name ;
			}
			set	
			{	
				m_wh_Name = value ;	
			}
		}
			
		

		/// <summary>
		/// 请购数量
		/// 特定物料DTO.Misc.请购数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_reqPRQty ;
		public System.Decimal ReqPRQty
		{
			get	
			{	
				return m_reqPRQty ;
			}
			set	
			{	
				m_reqPRQty = value ;	
			}
		}
			
		

		/// <summary>
		/// 交期
		/// 特定物料DTO.Misc.交期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_reqDate ;
		public System.DateTime ReqDate
		{
			get	
			{	
				return m_reqDate ;
			}
			set	
			{	
				m_reqDate = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																
		#endregion 
	} 	
}

	
