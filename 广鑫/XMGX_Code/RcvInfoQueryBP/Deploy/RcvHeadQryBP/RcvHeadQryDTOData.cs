



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UIFIA.U9.Cust.FJGX.RcvHeadQryBP
{
	/// <summary>
	/// RcvHeadQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UIFIA.U9.Cust.FJGX.RcvHeadQryBP.RcvHeadQryDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class RcvHeadQryDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public RcvHeadQryDTOData()
		{
			initData();
		}
		private void initData()
		{
					ID= 0; 
				
		
		
		
		
		
		
		
					SumTotalMoney=0m; 

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
		public RcvHeadQryDTOData(  System.Int64 iD  , System.String docNo  , System.DateTime businessDate  , System.String supplierCode  , System.String supplierName  , System.String supplierContactName  , System.Decimal totalMoney  , System.String createdBy  , System.String memo  , System.Decimal sumTotalMoney  )
		{
			initData();
			this.ID = iD;
			this.DocNo = docNo;
			this.BusinessDate = businessDate;
			this.SupplierCode = supplierCode;
			this.SupplierName = supplierName;
			this.SupplierContactName = supplierContactName;
			this.TotalMoney = totalMoney;
			this.CreatedBy = createdBy;
			this.Memo = memo;
			this.SumTotalMoney = sumTotalMoney;
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
		/// RcvHeadQryDTO.Misc.ID
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
		/// 收发单据号
		/// RcvHeadQryDTO.Misc.收发单据号
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
		/// 单据日期
		/// RcvHeadQryDTO.Misc.单据日期
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
		/// 供应商编码
		/// RcvHeadQryDTO.Misc.供应商编码
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
		/// RcvHeadQryDTO.Misc.供应商名称
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
		/// 供应商联系人
		/// RcvHeadQryDTO.Misc.供应商联系人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_supplierContactName ;
		public System.String SupplierContactName
		{
			get	
			{	
				return m_supplierContactName ;
			}
			set	
			{	
				m_supplierContactName = value ;	
			}
		}
			
		

		/// <summary>
		/// 金额
		/// RcvHeadQryDTO.Misc.金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_totalMoney ;
		public System.Decimal TotalMoney
		{
			get	
			{	
				return m_totalMoney ;
			}
			set	
			{	
				m_totalMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 制单人
		/// RcvHeadQryDTO.Misc.制单人
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
		/// 备注
		/// RcvHeadQryDTO.Misc.备注
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_memo ;
		public System.String Memo
		{
			get	
			{	
				return m_memo ;
			}
			set	
			{	
				m_memo = value ;	
			}
		}
			
		

		/// <summary>
		/// 合计金额
		/// RcvHeadQryDTO.Misc.合计金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_sumTotalMoney ;
		public System.Decimal SumTotalMoney
		{
			get	
			{	
				return m_sumTotalMoney ;
			}
			set	
			{	
				m_sumTotalMoney = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																				
		#endregion 
	} 	
}

	
