



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.ItemSV
{
	/// <summary>
	/// 物料DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.ItemSV.ItemDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class ItemDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public ItemDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		
		
		
		
		
		
					RefrenceCost= 0; 
		
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
		public ItemDTOData(  System.String itemCode  , System.String itemName  , System.String uomCode  , System.String uomName  , System.String uomShortName  , System.DateTime effectiveDate  , System.DateTime disableDate  , System.Double refrenceCost  )
		{
			initData();
			this.ItemCode = itemCode;
			this.ItemName = itemName;
			this.UomCode = uomCode;
			this.UomName = uomName;
			this.UomShortName = uomShortName;
			this.EffectiveDate = effectiveDate;
			this.DisableDate = disableDate;
			this.RefrenceCost = refrenceCost;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 件号
		/// 物料DTO.Misc.件号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_itemCode ;
		public System.String ItemCode
		{
			get	
			{	
				return m_itemCode ;
			}
			set	
			{	
				m_itemCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 件名
		/// 物料DTO.Misc.件名
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_itemName ;
		public System.String ItemName
		{
			get	
			{	
				return m_itemName ;
			}
			set	
			{	
				m_itemName = value ;	
			}
		}
			
		

		/// <summary>
		/// 单位编码
		/// 物料DTO.Misc.单位编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_uomCode ;
		public System.String UomCode
		{
			get	
			{	
				return m_uomCode ;
			}
			set	
			{	
				m_uomCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 单位名称
		/// 物料DTO.Misc.单位名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_uomName ;
		public System.String UomName
		{
			get	
			{	
				return m_uomName ;
			}
			set	
			{	
				m_uomName = value ;	
			}
		}
			
		

		/// <summary>
		/// 单位简称
		/// 物料DTO.Misc.单位简称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_uomShortName ;
		public System.String UomShortName
		{
			get	
			{	
				return m_uomShortName ;
			}
			set	
			{	
				m_uomShortName = value ;	
			}
		}
			
		

		/// <summary>
		/// 生效日期
		/// 物料DTO.Misc.生效日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_effectiveDate ;
		public System.DateTime EffectiveDate
		{
			get	
			{	
				return m_effectiveDate ;
			}
			set	
			{	
				m_effectiveDate = value ;	
			}
		}
			
		

		/// <summary>
		/// 失效日期
		/// 物料DTO.Misc.失效日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_disableDate ;
		public System.DateTime DisableDate
		{
			get	
			{	
				return m_disableDate ;
			}
			set	
			{	
				m_disableDate = value ;	
			}
		}
			
		

		/// <summary>
		/// 参考成本
		/// 物料DTO.Misc.参考成本
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Double m_refrenceCost ;
		public System.Double RefrenceCost
		{
			get	
			{	
				return m_refrenceCost ;
			}
			set	
			{	
				m_refrenceCost = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																
		#endregion 
	} 	
}

	
