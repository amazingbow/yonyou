
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.OperatorsDailyBE
{
	/// <summary>
	/// 业务员日志 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.FJGX.OperatorsDailyBE.OperatorsDailyData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class OperatorsDailyData : UFSoft.UBF.Business.DataTransObjectBase
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                        
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.Customer.CustomerData));
                        
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public OperatorsDailyData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     			
	     			
	     			


			//设置组合的集合属性为List<>对象. -目前直接在属性上处理.
			
			//调用默认值初始化服务进行配置方式初始化
			UFSoft.UBF.Service.DTOService.InitConfigDefault(this);
		}		
		[System.Runtime.Serialization.OnDeserializing]
        internal void OnDeserializing(System.Runtime.Serialization.StreamingContext context)
        {
			 initData();
        }
        
		#region System Fields
		///<summary>
		/// 实体类型. 
		/// </summary>
		[DataMember(IsRequired=false)]
		public override string SysEntityType
		{
			get { return "UFIDA.U9.Cust.FJGX.OperatorsDailyBE.OperatorsDaily" ;}
		}
		#endregion


		
		#region Properties Inner Component
	
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 业务员日志.Key.ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_iD ;
		public System.Int64 ID
		{
			get	
			{	
				return m_iD  ;
			}
			set	
			{	
				m_iD = value ;	
			}
		}
		

				/// <summary>
		/// 创建时间
		/// 业务员日志.Sys.创建时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_createdOn ;
		public System.DateTime CreatedOn
		{
			get	
			{	
				return m_createdOn  ;
			}
			set	
			{	
				m_createdOn = value ;	
			}
		}
		

				/// <summary>
		/// 创建人
		/// 业务员日志.Sys.创建人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_createdBy ;
		public System.String CreatedBy
		{
			get	
			{	
				return m_createdBy  ;
			}
			set	
			{	
				m_createdBy = value ;	
			}
		}
		

				/// <summary>
		/// 修改时间
		/// 业务员日志.Sys.修改时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_modifiedOn ;
		public System.DateTime ModifiedOn
		{
			get	
			{	
				return m_modifiedOn  ;
			}
			set	
			{	
				m_modifiedOn = value ;	
			}
		}
		

				/// <summary>
		/// 修改人
		/// 业务员日志.Sys.修改人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_modifiedBy ;
		public System.String ModifiedBy
		{
			get	
			{	
				return m_modifiedBy  ;
			}
			set	
			{	
				m_modifiedBy = value ;	
			}
		}
		

				/// <summary>
		/// 事务版本
		/// 业务员日志.Sys.事务版本
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_sysVersion ;
		public System.Int64 SysVersion
		{
			get	
			{	
				return m_sysVersion  ;
			}
			set	
			{	
				m_sysVersion = value ;	
			}
		}
		

				/// <summary>
		/// 日期
		/// 业务员日志.Misc.日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_dailyDate ;
		public System.DateTime DailyDate
		{
			get	
			{	
				return m_dailyDate  ;
			}
			set	
			{	
				m_dailyDate = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_customer_SKey ;
		/// <summary>
		/// 客户 序列化Key属性。（传递跨组织序列列字段）
		/// 业务员日志.Misc.客户
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Customer_SKey
		{
			get 
			{
				return m_customer_SKey ;					
			}
			set
			{
				 m_customer_SKey = value ;	
			}
		}
		/// <summary>
		/// 客户
		/// 业务员日志.Misc.客户
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 Customer
		{
			get	
			{	
				if (Customer_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Customer_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Customer_SKey = null ;
				else
				{
					if (Customer_SKey == null )
						Customer_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.SCM.Customer.Customer") ;
					else
						Customer_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 日志内容
		/// 业务员日志.Misc.日志内容
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_dailyContent ;
		public System.String DailyContent
		{
			get	
			{	
				return m_dailyContent  ;
			}
			set	
			{	
				m_dailyContent = value ;	
			}
		}
		
		#endregion	

		#region Multi_Fields
									
		#endregion 		
	}	

}

