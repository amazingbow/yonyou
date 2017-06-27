



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
	/// <summary>
	/// 料品供应商 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.ItemSupplyDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class ItemSupplyDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public ItemSupplyDTOData()
		{
			initData();
		}
		private void initData()
		{
					ItemId= 0; 
							Supply= 0; 
				
		

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
		public ItemSupplyDTOData(  System.Int64 itemId  , System.Int64 supply  , System.String supplyCode  , System.String supplyName  )
		{
			initData();
			this.ItemId = itemId;
			this.Supply = supply;
			this.SupplyCode = supplyCode;
			this.SupplyName = supplyName;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 料品ID
		/// 料品供应商.Misc.料品ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_itemId ;
		public System.Int64 ItemId
		{
			get	
			{	
				return m_itemId ;
			}
			set	
			{	
				m_itemId = value ;	
			}
		}
			
		

		/// <summary>
		/// 供应商ID
		/// 料品供应商.Misc.供应商ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_supply ;
		public System.Int64 Supply
		{
			get	
			{	
				return m_supply ;
			}
			set	
			{	
				m_supply = value ;	
			}
		}
			
		

		/// <summary>
		/// 供应商Code
		/// 料品供应商.Misc.供应商Code
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_supplyCode ;
		public System.String SupplyCode
		{
			get	
			{	
				return m_supplyCode ;
			}
			set	
			{	
				m_supplyCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 供应商Name
		/// 料品供应商.Misc.供应商Name
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_supplyName ;
		public System.String SupplyName
		{
			get	
			{	
				return m_supplyName ;
			}
			set	
			{	
				m_supplyName = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
								
		#endregion 
	} 	
}

	
