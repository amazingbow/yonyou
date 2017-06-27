



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
	/// <summary>
	/// 缺件变更料品信息 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeItemDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class BomChangeItemDTOData : UFSoft.UBF.Business.DataTransObjectBase
	{
		public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
            knownTypes.Add(typeof(UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTOData));                                                                               
            knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public BomChangeItemDTOData()
		{
			initData();
		}
		private void initData()
		{
		
					Item= 0; 
							Supplier= 0; 
				
					DistQty=0m; 
		
		

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
	        			if (this.BomChangeDTO != null) 
			{
				this.BomChangeDTO.DoSerializeKeyList(dict);
			}
	        	        	        	        	        	        
		}
		#endregion 
		/// <summary>
		/// Constructor Full Argument
		/// </summary>
		public BomChangeItemDTOData(  UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTOData bomChangeDTO  , System.Int64 item  , System.Int64 supplier  , System.String workPlace  , System.Decimal distQty  , System.String itemCode  , System.String itemName  )
		{
			initData();
			this.BomChangeDTO = bomChangeDTO;
			this.Item = item;
			this.Supplier = supplier;
			this.WorkPlace = workPlace;
			this.DistQty = distQty;
			this.ItemCode = itemCode;
			this.ItemName = itemName;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 缺件变更头信息
		/// 缺件变更料品信息.Misc.缺件变更头信息
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTOData m_bomChangeDTO ;
		public UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomChangeDTOData BomChangeDTO
		{
			get	
			{	
				return m_bomChangeDTO ;
			}
			set	
			{	
				m_bomChangeDTO = value ;	
			}
		}
			
		

		/// <summary>
		/// 料品
		/// 缺件变更料品信息.Misc.料品
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_item ;
		public System.Int64 Item
		{
			get	
			{	
				return m_item ;
			}
			set	
			{	
				m_item = value ;	
			}
		}
			
		

		/// <summary>
		/// 供应商
		/// 缺件变更料品信息.Misc.供应商
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_supplier ;
		public System.Int64 Supplier
		{
			get	
			{	
				return m_supplier ;
			}
			set	
			{	
				m_supplier = value ;	
			}
		}
			
		

		/// <summary>
		/// 工位
		/// 缺件变更料品信息.Misc.工位
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_workPlace ;
		public System.String WorkPlace
		{
			get	
			{	
				return m_workPlace ;
			}
			set	
			{	
				m_workPlace = value ;	
			}
		}
			
		

		/// <summary>
		/// 发料数量
		/// 缺件变更料品信息.Misc.发料数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_distQty ;
		public System.Decimal DistQty
		{
			get	
			{	
				return m_distQty ;
			}
			set	
			{	
				m_distQty = value ;	
			}
		}
			
		

		/// <summary>
		/// 料品
		/// 缺件变更料品信息.Misc.料品
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
		/// 品名
		/// 缺件变更料品信息.Misc.品名
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
			
		#endregion	

		#region Multi_Fields
														
		#endregion 
	} 	
}

	
