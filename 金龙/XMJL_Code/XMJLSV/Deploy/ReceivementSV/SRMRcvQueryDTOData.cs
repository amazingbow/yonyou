



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.ReceivementSV
{
	/// <summary>
	/// SRM入库单查询条件DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvQueryDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class SRMRcvQueryDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public SRMRcvQueryDTOData()
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
		public SRMRcvQueryDTOData(  System.String vendorCode  , System.String cPersonCode  , System.String docNo  , System.String type  , System.DateTime inDateFrom  , System.DateTime inDateTo  )
		{
			initData();
			this.VendorCode = vendorCode;
			this.CPersonCode = cPersonCode;
			this.DocNo = docNo;
			this.Type = type;
			this.InDateFrom = inDateFrom;
			this.InDateTo = inDateTo;
		}
		#region System Fields 
		//--系统字段,目前没有.EntityData上有相应的字段,用于保存相关的实体状态信息,DTO上没有状态信息.	
		#endregion
		
		#region DTO Properties 
	
		

		/// <summary>
		/// 供应商代码
		/// SRM入库单查询条件DTO.Misc.供应商代码
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
		/// 采购员代码
		/// SRM入库单查询条件DTO.Misc.采购员代码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_cPersonCode ;
		public System.String CPersonCode
		{
			get	
			{	
				return m_cPersonCode ;
			}
			set	
			{	
				m_cPersonCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 入库单号
		/// SRM入库单查询条件DTO.Misc.入库单号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_docNo ;
		public System.String DocNo
		{
			get	
			{	
				return m_docNo ;
			}
			set	
			{	
				m_docNo = value ;	
			}
		}
			
		

		/// <summary>
		/// 单据类型
		/// SRM入库单查询条件DTO.Misc.单据类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_type ;
		public System.String Type
		{
			get	
			{	
				return m_type ;
			}
			set	
			{	
				m_type = value ;	
			}
		}
			
		

		/// <summary>
		/// 起始入库日期
		/// SRM入库单查询条件DTO.Misc.起始入库日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_inDateFrom ;
		public System.DateTime InDateFrom
		{
			get	
			{	
				return m_inDateFrom ;
			}
			set	
			{	
				m_inDateFrom = value ;	
			}
		}
			
		

		/// <summary>
		/// 截止入库日期
		/// SRM入库单查询条件DTO.Misc.截止入库日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_inDateTo ;
		public System.DateTime InDateTo
		{
			get	
			{	
				return m_inDateTo ;
			}
			set	
			{	
				m_inDateTo = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
												
		#endregion 
	} 	
}

	
