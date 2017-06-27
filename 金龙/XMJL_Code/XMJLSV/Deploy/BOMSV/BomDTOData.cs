



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.BOMSV
{
	/// <summary>
	/// BomDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.BOMSV.BomDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class BomDTOData : UFSoft.UBF.Business.DataTransObjectBase
	{
		public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
                                                                                          
            knownTypes.Add(typeof(UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData));                           
            knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public BomDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		
		
		
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
	        	        	        	        	        	        	        			if (this.ProductBomDTO != null) 
			{
				this.ProductBomDTO.DoSerializeKeyList(dict);
			}
	        	        
		}
		#endregion 
		/// <summary>
		/// Constructor Full Argument
		/// </summary>
		public BomDTOData(  System.String itemCode  , System.String itemName  , System.String vendorCode  , System.String vendorName  , System.Decimal qty  , System.String bomType  , UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData productBomDTO  , System.String uomCode  , System.String uomName  )
		{
			initData();
			this.ItemCode = itemCode;
			this.ItemName = itemName;
			this.VendorCode = vendorCode;
			this.VendorName = vendorName;
			this.Qty = qty;
			this.BomType = bomType;
			this.ProductBomDTO = productBomDTO;
			this.UomCode = uomCode;
			this.UomName = uomName;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 件号
		/// BomDTO.Misc.件号
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
		/// BomDTO.Misc.件名
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
		/// 供应商代码
		/// BomDTO.Misc.供应商代码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_vendorCode ;
		public System.String VendorCode
		{
			get	
			{	
				return m_vendorCode ;
			}
			set	
			{	
				m_vendorCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 供应商名称
		/// BomDTO.Misc.供应商名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_vendorName ;
		public System.String VendorName
		{
			get	
			{	
				return m_vendorName ;
			}
			set	
			{	
				m_vendorName = value ;	
			}
		}
			
		

		/// <summary>
		/// 数量
		/// BomDTO.Misc.数量
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
			
		

		/// <summary>
		/// Bom类型
		/// BomDTO.Misc.Bom类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_bomType ;
		public System.String BomType
		{
			get	
			{	
				return m_bomType ;
			}
			set	
			{	
				m_bomType = value ;	
			}
		}
			
		

		/// <summary>
		/// 车辆BomDTO
		/// BomDTO.Misc.车辆BomDTO
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData m_productBomDTO ;
		public UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData ProductBomDTO
		{
			get	
			{	
				return m_productBomDTO ;
			}
			set	
			{	
				m_productBomDTO = value ;	
			}
		}
			
		

		/// <summary>
		/// 单位编码
		/// BomDTO.Misc.单位编码
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
		/// BomDTO.Misc.单位名称
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
			
		#endregion	

		#region Multi_Fields
																		
		#endregion 
	} 	
}

	
