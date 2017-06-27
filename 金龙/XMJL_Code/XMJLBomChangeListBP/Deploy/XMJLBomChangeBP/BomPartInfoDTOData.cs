



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
	/// <summary>
	/// 缺件部分信息 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomPartInfoDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class BomPartInfoDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public BomPartInfoDTOData()
		{
			initData();
		}
		private void initData()
		{
					Item= 0; 
				
		
					Supplier= 0; 
				
		
		
					Qty=0m; 

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
		public BomPartInfoDTOData(  System.Int64 item  , System.String itemCode  , System.String itemName  , System.Int64 supplier  , System.String supplierCode  , System.String supplierName  , System.String workPlace  , System.Decimal qty  )
		{
			initData();
			this.Item = item;
			this.ItemCode = itemCode;
			this.ItemName = itemName;
			this.Supplier = supplier;
			this.SupplierCode = supplierCode;
			this.SupplierName = supplierName;
			this.WorkPlace = workPlace;
			this.Qty = qty;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 料品
		/// 缺件部分信息.Misc.料品
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
		/// 料品代码
		/// 缺件部分信息.Misc.料品代码
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
		/// 料品名称
		/// 缺件部分信息.Misc.料品名称
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
		/// 供应商
		/// 缺件部分信息.Misc.供应商
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
		/// 供应商代码
		/// 缺件部分信息.Misc.供应商代码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_supplierCode ;
		public System.String SupplierCode
		{
			get	
			{	
				return m_supplierCode ;
			}
			set	
			{	
				m_supplierCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 供应商名称
		/// 缺件部分信息.Misc.供应商名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_supplierName ;
		public System.String SupplierName
		{
			get	
			{	
				return m_supplierName ;
			}
			set	
			{	
				m_supplierName = value ;	
			}
		}
			
		

		/// <summary>
		/// 工位
		/// 缺件部分信息.Misc.工位
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
		/// 数量
		/// 缺件部分信息.Misc.数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_qty ;
		public System.Decimal Qty
		{
			get	
			{	
				return m_qty ;
			}
			set	
			{	
				m_qty = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																
		#endregion 
	} 	
}

	
