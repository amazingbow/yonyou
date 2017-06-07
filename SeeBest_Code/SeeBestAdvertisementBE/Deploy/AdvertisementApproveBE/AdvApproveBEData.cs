
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE
{
	/// <summary>
	/// 广告核销单 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBEData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class AdvApproveBEData : UFSoft.UBF.Business.DataTransObjectBase
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.Customer.CustomerData));
                        
                        
                                        knownTypes.Add(typeof(List<UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveLineData>));
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public AdvApproveBEData()
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
			get { return "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveBE" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        					/// <summary>
		/// 广告核销单行
		/// 广告核销单.Misc.广告核销单行
		/// </summary>
		[DataMember(IsRequired=false)]
		private List<UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveLineData> m_advApproveLine;
		public List<UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveLineData> AdvApproveLine
		{
			get	
			{	
				if (m_advApproveLine == null)
				{
					List<UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveLineData> m_list = new List<UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvApproveLineData>() ;
					m_advApproveLine = m_list;
				}
				return m_advApproveLine ;
			}
			set	
			{	
				m_advApproveLine = value ;
			}
		}		

			
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 广告核销单.Key.ID
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
		/// 广告核销单.Sys.创建时间
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
		/// 广告核销单.Sys.创建人
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
		/// 广告核销单.Sys.修改时间
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
		/// 广告核销单.Sys.修改人
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
		/// 广告核销单.Sys.事务版本
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
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_advApplyCust_SKey ;
		/// <summary>
		/// 办事处 序列化Key属性。（传递跨组织序列列字段）
		/// 广告核销单.Misc.办事处
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey AdvApplyCust_SKey
		{
			get 
			{
				return m_advApplyCust_SKey ;					
			}
			set
			{
				 m_advApplyCust_SKey = value ;	
			}
		}
		/// <summary>
		/// 办事处
		/// 广告核销单.Misc.办事处
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 AdvApplyCust
		{
			get	
			{	
				if (AdvApplyCust_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return AdvApplyCust_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					AdvApplyCust_SKey = null ;
				else
				{
					if (AdvApplyCust_SKey == null )
						AdvApplyCust_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.SCM.Customer.Customer") ;
					else
						AdvApplyCust_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 月份
		/// 广告核销单.Misc.月份
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_month ;
		public System.DateTime Month
		{
			get	
			{	
				return m_month  ;
			}
			set	
			{	
				m_month = value ;	
			}
		}
		

				/// <summary>
		/// 单号
		/// 广告核销单.Misc.单号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_docNo ;
		public System.String DocNo
		{
			get	
			{	
				return m_docNo  ;
			}
			set	
			{	
				m_docNo = value ;	
			}
		}
		
		#endregion	

		#region Multi_Fields
										
		#endregion 		
	}	

}

