
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJLBomChangeBE
{
	/// <summary>
	/// 缺件变更车号行 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNoData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class Cust_Xmjl_MO_BomChangeManufactureNoData : UFSoft.UBF.Business.DataTransObjectBase
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeData));
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.ProjectTask.ProjectData));
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData));
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public Cust_Xmjl_MO_BomChangeManufactureNoData()
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
			get { return "UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeManufactureNo" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        			
			private UFSoft.UBF.Business.BusinessEntity.EntityKey m_cust_Xmjl_MO_BomChange_SKey ;
			/// <summary>
			/// 缺件变更单 序列化Key属性。（传递跨组织序列列字段）
			/// 缺件变更车号行.Misc.缺件变更单
			/// </summary>
			[DataMember(IsRequired=false)]
			public UFSoft.UBF.Business.BusinessEntity.EntityKey Cust_Xmjl_MO_BomChange_SKey
			{
				get 
				{
					return m_cust_Xmjl_MO_BomChange_SKey ;					
				}
				set
				{
					m_cust_Xmjl_MO_BomChange_SKey = value ;	
				}
			}
		/// <summary>
		/// 缺件变更单
		/// 缺件变更车号行.Misc.缺件变更单
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeData m_cust_Xmjl_MO_BomChange;
		public UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeData Cust_Xmjl_MO_BomChange
		{
			get	
			{	
				return m_cust_Xmjl_MO_BomChange ;
			}
			set	
			{	
				m_cust_Xmjl_MO_BomChange = value ;
			}
		}		

			
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 缺件变更车号行.Key.ID
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
		/// 缺件变更车号行.Sys.创建时间
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
		/// 缺件变更车号行.Sys.创建人
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
		/// 缺件变更车号行.Sys.修改时间
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
		/// 缺件变更车号行.Sys.修改人
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
		/// 缺件变更车号行.Sys.事务版本
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
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_manufactureNO_SKey ;
		/// <summary>
		/// 车号 序列化Key属性。（传递跨组织序列列字段）
		/// 缺件变更车号行.Misc.车号
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey ManufactureNO_SKey
		{
			get 
			{
				return m_manufactureNO_SKey ;					
			}
			set
			{
				 m_manufactureNO_SKey = value ;	
			}
		}
		/// <summary>
		/// 车号
		/// 缺件变更车号行.Misc.车号
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 ManufactureNO
		{
			get	
			{	
				if (ManufactureNO_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return ManufactureNO_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					ManufactureNO_SKey = null ;
				else
				{
					if (ManufactureNO_SKey == null )
						ManufactureNO_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.SCM.ProjectTask.Project") ;
					else
						ManufactureNO_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 合同号
		/// 缺件变更车号行.Misc.合同号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_contractNo ;
		public System.String ContractNo
		{
			get	
			{	
				return m_contractNo  ;
			}
			set	
			{	
				m_contractNo = value ;	
			}
		}
		

				/// <summary>
		/// 车型
		/// 缺件变更车号行.Misc.车型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_carType ;
		public System.String CarType
		{
			get	
			{	
				return m_carType  ;
			}
			set	
			{	
				m_carType = value ;	
			}
		}
		

				/// <summary>
		/// 实体扩展字段
		/// 缺件变更车号行.Misc.实体扩展字段
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData m_descFlexField ;
		public UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData DescFlexField
		{
			get	
			{	
				return m_descFlexField  ;
			}
			set	
			{	
				m_descFlexField = value ;	
			}
		}
		
		#endregion	

		#region Multi_Fields
											
		#endregion 		
	}	

}

