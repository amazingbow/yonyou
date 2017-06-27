



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.ItemSV
{
	/// <summary>
	/// 物料库存DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class ItemStoreDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public ItemStoreDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					StoreQty=0m; 
		
		

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
		public ItemStoreDTOData(  System.String itemCode  , System.String itemName  , System.String uomCode  , System.String uomName  , System.String uomShortName  , System.Decimal storeQty  , System.String wHCode  , System.String wHName  )
		{
			initData();
			this.ItemCode = itemCode;
			this.ItemName = itemName;
			this.UomCode = uomCode;
			this.UomName = uomName;
			this.UomShortName = uomShortName;
			this.StoreQty = storeQty;
			this.WHCode = wHCode;
			this.WHName = wHName;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 件号
		/// 物料库存DTO.Misc.件号
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
		/// 物料库存DTO.Misc.件名
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
		/// 物料库存DTO.Misc.单位编码
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
		/// 物料库存DTO.Misc.单位名称
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
		/// 物料库存DTO.Misc.单位简称
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
		/// 库存数量
		/// 物料库存DTO.Misc.库存数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_storeQty ;
		public System.Decimal StoreQty
		{
			get	
			{	
				return m_storeQty ;
			}
			set	
			{	
				m_storeQty = value ;	
			}
		}
			
		

		/// <summary>
		/// 存储地点代码
		/// 物料库存DTO.Misc.存储地点代码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_wHCode ;
		public System.String WHCode
		{
			get	
			{	
				return m_wHCode ;
			}
			set	
			{	
				m_wHCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 存储地点名称
		/// 物料库存DTO.Misc.存储地点名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_wHName ;
		public System.String WHName
		{
			get	
			{	
				return m_wHName ;
			}
			set	
			{	
				m_wHName = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																
		#endregion 
	} 	
}

	
