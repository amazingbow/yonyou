



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.GLVoucherSecondQryBP
{
	/// <summary>
	/// GLVoucherSecondQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.FJGX.GLVoucherSecondQryBP.GLVoucherSecondQryDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class GLVoucherSecondQryDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public GLVoucherSecondQryDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					AccountedDr=0m; 
					AccountedCr=0m; 
					ID= 0; 
							SumDr=0m; 

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
		public GLVoucherSecondQryDTOData(  System.String companyName  , System.String aRDocNo  , System.DateTime createDate  , System.String createdBy  , System.String memo  , System.Decimal accountedDr  , System.Decimal accountedCr  , System.Int64 iD  , System.Decimal sumDr  )
		{
			initData();
			this.CompanyName = companyName;
			this.ARDocNo = aRDocNo;
			this.CreateDate = createDate;
			this.CreatedBy = createdBy;
			this.Memo = memo;
			this.AccountedDr = accountedDr;
			this.AccountedCr = accountedCr;
			this.ID = iD;
			this.SumDr = sumDr;
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
		/// 公司名称
		/// GLVoucherSecondQryDTO.Misc.公司名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_companyName ;
		public System.String CompanyName
		{
			get	
			{	
				return m_companyName ;
			}
			set	
			{	
				m_companyName = value ;	
			}
		}
			
		

		/// <summary>
		/// 应收单据
		/// GLVoucherSecondQryDTO.Misc.应收单据
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_aRDocNo ;
		public System.String ARDocNo
		{
			get	
			{	
				return m_aRDocNo ;
			}
			set	
			{	
				m_aRDocNo = value ;	
			}
		}
			
		

		/// <summary>
		/// 制单日期
		/// GLVoucherSecondQryDTO.Misc.制单日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_createDate ;
		public System.DateTime CreateDate
		{
			get	
			{	
				return m_createDate ;
			}
			set	
			{	
				m_createDate = value ;	
			}
		}
			
		

		/// <summary>
		/// 制单人
		/// GLVoucherSecondQryDTO.Misc.制单人
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
		/// 摘要
		/// GLVoucherSecondQryDTO.Misc.摘要
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
		/// 借方金额
		/// GLVoucherSecondQryDTO.Misc.借方金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_accountedDr ;
		public System.Decimal AccountedDr
		{
			get	
			{	
				return m_accountedDr ;
			}
			set	
			{	
				m_accountedDr = value ;	
			}
		}
			
		

		/// <summary>
		/// 贷方金额
		/// GLVoucherSecondQryDTO.Misc.贷方金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_accountedCr ;
		public System.Decimal AccountedCr
		{
			get	
			{	
				return m_accountedCr ;
			}
			set	
			{	
				m_accountedCr = value ;	
			}
		}
			
		

		/// <summary>
		/// ID
		/// GLVoucherSecondQryDTO.Misc.ID
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
		/// 小计
		/// GLVoucherSecondQryDTO.Misc.小计
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_sumDr ;
		public System.Decimal SumDr
		{
			get	
			{	
				return m_sumDr ;
			}
			set	
			{	
				m_sumDr = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																		
		#endregion 
	} 	
}

	
