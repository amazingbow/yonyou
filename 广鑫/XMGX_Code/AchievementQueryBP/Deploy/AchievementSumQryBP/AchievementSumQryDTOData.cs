



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.AchievementSumQryBP
{
	/// <summary>
	/// AchievementSumQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.FJGX.AchievementSumQryBP.AchievementSumQryDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class AchievementSumQryDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public AchievementSumQryDTOData()
		{
			initData();
		}
		private void initData()
		{
					ID= 0; 
				
		
					RecTotalMoney=0m; 
					ARTotalMoney=0m; 
					BackMoneyRatio=0m; 
		
		
		

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
		public AchievementSumQryDTOData(  System.Int64 iD  , System.String operatorsCode  , System.String operatorsName  , System.Decimal recTotalMoney  , System.Decimal aRTotalMoney  , System.Decimal backMoneyRatio  , System.Decimal sumRecTotalMoney  , System.Decimal sumARTotalMoney  , System.DateTime businessDate  )
		{
			initData();
			this.ID = iD;
			this.OperatorsCode = operatorsCode;
			this.OperatorsName = operatorsName;
			this.RecTotalMoney = recTotalMoney;
			this.ARTotalMoney = aRTotalMoney;
			this.BackMoneyRatio = backMoneyRatio;
			this.SumRecTotalMoney = sumRecTotalMoney;
			this.SumARTotalMoney = sumARTotalMoney;
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
		/// ID
		/// AchievementSumQryDTO.Misc.ID
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
		/// 业务员编码
		/// AchievementSumQryDTO.Misc.业务员编码
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
		/// AchievementSumQryDTO.Misc.业务员
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
		/// AchievementSumQryDTO.Misc.收款金额
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
			
		

		/// <summary>
		/// 应收金额
		/// AchievementSumQryDTO.Misc.应收金额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_aRTotalMoney ;
		public System.Decimal ARTotalMoney
		{
			get	
			{	
				return m_aRTotalMoney ;
			}
			set	
			{	
				m_aRTotalMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 回款率
		/// AchievementSumQryDTO.Misc.回款率
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_backMoneyRatio ;
		public System.Decimal BackMoneyRatio
		{
			get	
			{	
				return m_backMoneyRatio ;
			}
			set	
			{	
				m_backMoneyRatio = value ;	
			}
		}
			
		

		/// <summary>
		/// 回款总额
		/// AchievementSumQryDTO.Misc.回款总额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_sumRecTotalMoney ;
		public System.Decimal SumRecTotalMoney
		{
			get	
			{	
				return m_sumRecTotalMoney ;
			}
			set	
			{	
				m_sumRecTotalMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 应收总额
		/// AchievementSumQryDTO.Misc.应收总额
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_sumARTotalMoney ;
		public System.Decimal SumARTotalMoney
		{
			get	
			{	
				return m_sumARTotalMoney ;
			}
			set	
			{	
				m_sumARTotalMoney = value ;	
			}
		}
			
		

		/// <summary>
		/// 业务日期
		/// AchievementSumQryDTO.Misc.业务日期
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

	
