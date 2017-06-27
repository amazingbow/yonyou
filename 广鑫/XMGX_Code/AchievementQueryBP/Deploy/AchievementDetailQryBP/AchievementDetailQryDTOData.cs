



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.AchievementDetailQryBP
{
	/// <summary>
	/// AchievementDetailQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.FJGX.AchievementDetailQryBP.AchievementDetailQryDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class AchievementDetailQryDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public AchievementDetailQryDTOData()
		{
			initData();
		}
		private void initData()
		{
					ID= 0; 
				
		
		
		
		
		
					RecTotalMoney=0m; 

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
		public AchievementDetailQryDTOData(  System.Int64 iD  , System.DateTime recDate  , System.String recDocNo  , System.String customerCode  , System.String customerName  , System.String operatorsCode  , System.String operatorsName  , System.Decimal recTotalMoney  )
		{
			initData();
			this.ID = iD;
			this.RecDate = recDate;
			this.RecDocNo = recDocNo;
			this.CustomerCode = customerCode;
			this.CustomerName = customerName;
			this.OperatorsCode = operatorsCode;
			this.OperatorsName = operatorsName;
			this.RecTotalMoney = recTotalMoney;
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
		/// AchievementDetailQryDTO.Misc.ID
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
		/// 收款日期
		/// AchievementDetailQryDTO.Misc.收款日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_recDate ;
		public System.DateTime RecDate
		{
			get	
			{	
				return m_recDate ;
			}
			set	
			{	
				m_recDate = value ;	
			}
		}
			
		

		/// <summary>
		/// 收款单号
		/// AchievementDetailQryDTO.Misc.收款单号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_recDocNo ;
		public System.String RecDocNo
		{
			get	
			{	
				return m_recDocNo ;
			}
			set	
			{	
				m_recDocNo = value ;	
			}
		}
			
		

		/// <summary>
		/// 客户编码
		/// AchievementDetailQryDTO.Misc.客户编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_customerCode ;
		public System.String CustomerCode
		{
			get	
			{	
				return m_customerCode ;
			}
			set	
			{	
				m_customerCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 客户名称
		/// AchievementDetailQryDTO.Misc.客户名称
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
		/// 业务员编码
		/// AchievementDetailQryDTO.Misc.业务员编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_operatorsCode ;
		public System.String OperatorsCode
		{
			get	
			{	
				return m_operatorsCode ;
			}
			set	
			{	
				m_operatorsCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 业务员
		/// AchievementDetailQryDTO.Misc.业务员
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
		/// 收款金额
		/// AchievementDetailQryDTO.Misc.收款金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_recTotalMoney ;
		public System.Decimal RecTotalMoney
		{
			get	
			{	
				return m_recTotalMoney ;
			}
			set	
			{	
				m_recTotalMoney = value ;	
			}
		}
			
		#endregion	

		#region Multi_Fields
																
		#endregion 
	} 	
}

	
