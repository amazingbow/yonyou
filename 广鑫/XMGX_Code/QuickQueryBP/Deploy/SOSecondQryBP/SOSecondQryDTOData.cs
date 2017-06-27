



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.SOSecondQryBP
{
	/// <summary>
	/// SOSecondQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.FJGX.SOSecondQryBP.SOSecondQryDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class SOSecondQryDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public SOSecondQryDTOData()
		{
			initData();
		}
		private void initData()
		{
		
		
		
		
					TotalMoney=0m; 
					ID= 0; 
				

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
		public SOSecondQryDTOData(  System.String docNo  , System.String customerName  , System.String enterpriseLegalPerson  , System.String saleserName  , System.Decimal totalMoney  , System.Int64 iD  , System.DateTime businessDate  )
		{
			initData();
			this.DocNo = docNo;
			this.CustomerName = customerName;
			this.EnterpriseLegalPerson = enterpriseLegalPerson;
			this.SaleserName = saleserName;
			this.TotalMoney = totalMoney;
			this.ID = iD;
			this.BusinessDate = businessDate;
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
		/// 单据编号
		/// SOSecondQryDTO.Misc.单据编号
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
		/// 客户名称
		/// SOSecondQryDTO.Misc.客户名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_customerName ;
		public System.String CustomerName
		{
			get	
			{	
				return m_customerName ;
			}
			set	
			{	
				m_customerName = value ;	
			}
		}
			
		

		/// <summary>
		/// 负责人
		/// SOSecondQryDTO.Misc.负责人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_enterpriseLegalPerson ;
		public System.String EnterpriseLegalPerson
		{
			get	
			{	
				return m_enterpriseLegalPerson ;
			}
			set	
			{	
				m_enterpriseLegalPerson = value ;	
			}
		}
			
		

		/// <summary>
		/// 业务员
		/// SOSecondQryDTO.Misc.业务员
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_saleserName ;
		public System.String SaleserName
		{
			get	
			{	
				return m_saleserName ;
			}
			set	
			{	
				m_saleserName = value ;	
			}
		}
			
		

		/// <summary>
		/// 金额
		/// SOSecondQryDTO.Misc.金额
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
		/// ID
		/// SOSecondQryDTO.Misc.ID
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
		/// 业务日期
		/// SOSecondQryDTO.Misc.业务日期
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
			
		#endregion	

		#region Multi_Fields
														
		#endregion 
	} 	
}

	
