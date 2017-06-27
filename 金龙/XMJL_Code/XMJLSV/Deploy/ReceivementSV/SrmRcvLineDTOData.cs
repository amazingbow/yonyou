



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.ReceivementSV
{
	/// <summary>
	/// SRM入库行DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.ReceivementSV.SrmRcvLineDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class SrmRcvLineDTOData : UFSoft.UBF.Business.DataTransObjectBase
	{
		public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
            knownTypes.Add(typeof(UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData));                                                                  
            knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public SrmRcvLineDTOData()
		{
			initData();
		}
		private void initData()
		{
		
					ID= 0; 
							LineNum= 0; 
				
					InQty=0m; 
					Price=0m; 

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
	        			if (this.SRMRcvDTO != null) 
			{
				this.SRMRcvDTO.DoSerializeKeyList(dict);
			}
	        	        	        	        	        
		}
		#endregion 
		/// <summary>
		/// Constructor Full Argument
		/// </summary>
		public SrmRcvLineDTOData(  UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData sRMRcvDTO  , System.Int64 iD  , System.Int32 lineNum  , System.String itemCode  , System.Decimal inQty  , System.Decimal price  )
		{
			initData();
			this.SRMRcvDTO = sRMRcvDTO;
			this.ID = iD;
			this.LineNum = lineNum;
			this.ItemCode = itemCode;
			this.InQty = inQty;
			this.Price = price;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// SRM入库单DTO
		/// SRM入库行DTO.Misc.SRM入库单DTO
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData m_sRMRcvDTO ;
		public UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData SRMRcvDTO
		{
			get	
			{	
				return m_sRMRcvDTO ;
			}
			set	
			{	
				m_sRMRcvDTO = value ;	
			}
		}
			
		

		/// <summary>
		/// 行ID
		/// SRM入库行DTO.Misc.行ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_iD ;
		public System.Int64 ID
		{
			get	
			{	
				return m_iD ;
			}
			set	
			{	
				m_iD = value ;	
			}
		}
			
		

		/// <summary>
		/// 行号
		/// SRM入库行DTO.Misc.行号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_lineNum ;
		public System.Int32 LineNum
		{
			get	
			{	
				return m_lineNum ;
			}
			set	
			{	
				m_lineNum = value ;	
			}
		}
			
		

		/// <summary>
		/// 件号
		/// SRM入库行DTO.Misc.件号
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
		/// 入库数量
		/// SRM入库行DTO.Misc.入库数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_inQty ;
		public System.Decimal InQty
		{
			get	
			{	
				return m_inQty ;
			}
			set	
			{	
				m_inQty = value ;	
			}
		}
			
		

		/// <summary>
		/// 单价
		/// SRM入库行DTO.Misc.单价
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_price ;
		public System.Decimal Price
		{
			get	
			{	
				return m_price ;
			}
			set	
			{	
				m_price = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
												
		#endregion 
	} 	
}

	
