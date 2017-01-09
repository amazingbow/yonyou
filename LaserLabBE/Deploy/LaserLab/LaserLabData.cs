
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab
{
	/// <summary>
	/// 镭射标表 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLabData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class LaserLabData : UFSoft.UBF.Business.DataTransObjectBase
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
		public LaserLabData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     			
	     			
	     							Cp= -1; 			     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			


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
			get { return "UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        					/// <summary>
		/// 状态
		/// 镭射标表.Misc.状态
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_cp;
		public System.Int32 Cp
		{
			get	
			{	
				return m_cp ;
			}
			set	
			{	
				m_cp = value ;
			}
		}		

			
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 镭射标表.Key.ID
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
		/// 镭射标表.Sys.创建时间
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
		/// 镭射标表.Sys.创建人
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
		/// 镭射标表.Sys.修改时间
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
		/// 镭射标表.Sys.修改人
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
		/// 镭射标表.Sys.事务版本
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
		/// 批次号
		/// 镭射标表.Misc.批次号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_bN ;
		public System.String BN
		{
			get	
			{	
				return m_bN  ;
			}
			set	
			{	
				m_bN = value ;	
			}
		}
		

				/// <summary>
		/// 出货批次号
		/// 镭射标表.Misc.出货批次号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_shipBN ;
		public System.String ShipBN
		{
			get	
			{	
				return m_shipBN  ;
			}
			set	
			{	
				m_shipBN = value ;	
			}
		}
		

				/// <summary>
		/// 镭射标
		/// 镭射标表.Misc.镭射标
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_lB ;
		public System.String LB
		{
			get	
			{	
				return m_lB  ;
			}
			set	
			{	
				m_lB = value ;	
			}
		}
		

				/// <summary>
		/// 型号
		/// 镭射标表.Misc.型号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_type ;
		public System.String Type
		{
			get	
			{	
				return m_type  ;
			}
			set	
			{	
				m_type = value ;	
			}
		}
		

				/// <summary>
		/// 客户
		/// 镭射标表.Misc.客户
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_customer ;
		public System.String Customer
		{
			get	
			{	
				return m_customer  ;
			}
			set	
			{	
				m_customer = value ;	
			}
		}
		

				/// <summary>
		/// 物料时间
		/// 镭射标表.Misc.物料时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_masterDT ;
		public System.DateTime MasterDT
		{
			get	
			{	
				return m_masterDT  ;
			}
			set	
			{	
				m_masterDT = value ;	
			}
		}
		

				/// <summary>
		/// 金油时间
		/// 镭射标表.Misc.金油时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_goldOilDT ;
		public System.DateTime GoldOilDT
		{
			get	
			{	
				return m_goldOilDT  ;
			}
			set	
			{	
				m_goldOilDT = value ;	
			}
		}
		

				/// <summary>
		/// 包装时间
		/// 镭射标表.Misc.包装时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_packDT ;
		public System.DateTime PackDT
		{
			get	
			{	
				return m_packDT  ;
			}
			set	
			{	
				m_packDT = value ;	
			}
		}
		

				/// <summary>
		/// 出货时间
		/// 镭射标表.Misc.出货时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_shipDT ;
		public System.DateTime ShipDT
		{
			get	
			{	
				return m_shipDT  ;
			}
			set	
			{	
				m_shipDT = value ;	
			}
		}
		

				/// <summary>
		/// 报废时间
		/// 镭射标表.Misc.报废时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_scarpDT ;
		public System.DateTime ScarpDT
		{
			get	
			{	
				return m_scarpDT  ;
			}
			set	
			{	
				m_scarpDT = value ;	
			}
		}
		
		#endregion	

		#region Multi_Fields
																	
		#endregion 		
	}	

}

