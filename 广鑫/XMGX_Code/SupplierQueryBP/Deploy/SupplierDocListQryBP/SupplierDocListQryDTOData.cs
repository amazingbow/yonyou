



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.SupplierDocListQryBP
{
	/// <summary>
	/// SupplierDocListQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.FJGX.SupplierDocListQryBP.SupplierDocListQryDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class SupplierDocListQryDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public SupplierDocListQryDTOData()
		{
			initData();
		}
		private void initData()
		{
					ID= 0; 
				
		
					SumUnPayedMnyTC=0m; 
		
		
					SumTotalUnPayedMnyTC=0m; 

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
		public SupplierDocListQryDTOData(  System.Int64 iD  , System.String docNo  , System.DateTime businessDate  , System.Decimal sumUnPayedMnyTC  , System.String createdBy  , System.String operatorsName  , System.Decimal sumTotalUnPayedMnyTC  )
		{
			initData();
			this.ID = iD;
			this.DocNo = docNo;
			this.BusinessDate = businessDate;
			this.SumUnPayedMnyTC = sumUnPayedMnyTC;
			this.CreatedBy = createdBy;
			this.OperatorsName = operatorsName;
			this.SumTotalUnPayedMnyTC = sumTotalUnPayedMnyTC;
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
		/// ID
		/// SupplierDocListQryDTO.Misc.ID
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
		/// 单号
		/// SupplierDocListQryDTO.Misc.单号
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
		/// 入库时间
		/// SupplierDocListQryDTO.Misc.入库时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_businessDate ;
		public System.DateTime BusinessDate
		{
			get	
			{	
				return m_businessDate ;
			}
			set	
			{	
				m_businessDate = value ;	
			}
		}
			
		

		/// <summary>
		/// 应付余额
		/// SupplierDocListQryDTO.Misc.应付余额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_sumUnPayedMnyTC ;
		public System.Decimal SumUnPayedMnyTC
		{
			get	
			{	
				return m_sumUnPayedMnyTC ;
			}
			set	
			{	
				m_sumUnPayedMnyTC = value ;	
			}
		}
			
		

		/// <summary>
		/// 制单人
		/// SupplierDocListQryDTO.Misc.制单人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_createdBy ;
		public System.String CreatedBy
		{
			get	
			{	
				return m_createdBy ;
			}
			set	
			{	
				m_createdBy = value ;	
			}
		}
			
		

		/// <summary>
		/// 业务员
		/// SupplierDocListQryDTO.Misc.业务员
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_operatorsName ;
		public System.String OperatorsName
		{
			get	
			{	
				return m_operatorsName ;
			}
			set	
			{	
				m_operatorsName = value ;	
			}
		}
			
		

		/// <summary>
		/// 合计应付余额
		/// SupplierDocListQryDTO.Misc.合计应付余额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_sumTotalUnPayedMnyTC ;
		public System.Decimal SumTotalUnPayedMnyTC
		{
			get	
			{	
				return m_sumTotalUnPayedMnyTC ;
			}
			set	
			{	
				m_sumTotalUnPayedMnyTC = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
														
		#endregion 
	} 	
}

	
