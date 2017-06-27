
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.HeXingProjectBE.RefVoucherInfoBE
{
	/// <summary>
	/// 对照关系被U9引用信息表 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.HeXingProjectBE.RefVoucherInfoBE.RefVoucherInfoBEData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class RefVoucherInfoBEData : UFSoft.UBF.Business.DataTransObjectBase
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
		public RefVoucherInfoBEData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     							HxRelationshipID= 0; 			     							VoucherID= 0; 			     			


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
			get { return "UFIDA.U9.Cust.HeXingProjectBE.RefVoucherInfoBE.RefVoucherInfoBE" ;}
		}
		#endregion


		
		#region Properties Inner Component
	
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 对照关系被U9引用信息表.Key.ID
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
		/// 对照关系被U9引用信息表.Sys.创建时间
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
		/// 对照关系被U9引用信息表.Sys.创建人
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
		/// 对照关系被U9引用信息表.Sys.修改时间
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
		/// 对照关系被U9引用信息表.Sys.修改人
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
		/// 对照关系被U9引用信息表.Sys.事务版本
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
		/// 关系对照表ID
		/// 对照关系被U9引用信息表.Misc.关系对照表ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_hxRelationshipID ;
		public System.Int64 HxRelationshipID
		{
			get	
			{	
				return m_hxRelationshipID  ;
			}
			set	
			{	
				m_hxRelationshipID = value ;	
			}
		}
		

				/// <summary>
		/// 凭证表ID
		/// 对照关系被U9引用信息表.Misc.凭证表ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_voucherID ;
		public System.Int64 VoucherID
		{
			get	
			{	
				return m_voucherID  ;
			}
			set	
			{	
				m_voucherID = value ;	
			}
		}
		

				/// <summary>
		/// 凭证号
		/// 对照关系被U9引用信息表.Misc.凭证号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_voucherDisplayCode ;
		public System.String VoucherDisplayCode
		{
			get	
			{	
				return m_voucherDisplayCode  ;
			}
			set	
			{	
				m_voucherDisplayCode = value ;	
			}
		}
		
		#endregion	

		#region Multi_Fields
									
		#endregion 		
	}	

}

