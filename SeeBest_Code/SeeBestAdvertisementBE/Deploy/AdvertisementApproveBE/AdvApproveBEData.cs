﻿
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
	public partial class AdvApproveBEData : UFIDA.U9.Base.Doc.DocData
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
		
		#endregion	

		#region Multi_Fields
			
		#endregion 		
	}	

}

