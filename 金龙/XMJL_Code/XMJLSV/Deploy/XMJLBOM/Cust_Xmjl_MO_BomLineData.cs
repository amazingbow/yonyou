
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.BomBE
{
	/// <summary>
	/// 缺件发料单子行 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.BomBE.Cust_Xmjl_MO_BomLineData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class Cust_Xmjl_MO_BomLineData : UFSoft.UBF.Business.DataTransObjectBase
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                        
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.InvDoc.MiscShip.MiscShipmentLData));
                                        knownTypes.Add(typeof(UFIDA.U9.InvDoc.MiscRcv.MiscRcvTransLData));
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Cust.XMJL.BomBE.Cust_Xmjl_MO_BomHeadData));
                                        knownTypes.Add(typeof(UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData));
                                        knownTypes.Add(typeof(UFIDA.U9.Base.Organization.OrganizationData));
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public Cust_Xmjl_MO_BomLineData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     							Qty= 0; 			     			
	     			
	     			
	     			
	     			
	     			


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
			get { return "UFIDA.U9.Cust.XMJL.BomBE.Cust_Xmjl_MO_BomLine" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        			
			private UFSoft.UBF.Business.BusinessEntity.EntityKey m_bomHead_SKey ;
			/// <summary>
			/// 缺件发料单 序列化Key属性。（传递跨组织序列列字段）
			/// 缺件发料单子行.Misc.缺件发料单
			/// </summary>
			[DataMember(IsRequired=false)]
			public UFSoft.UBF.Business.BusinessEntity.EntityKey BomHead_SKey
			{
				get 
				{
					return m_bomHead_SKey ;					
				}
				set
				{
					m_bomHead_SKey = value ;	
				}
			}
		/// <summary>
		/// 缺件发料单
		/// 缺件发料单子行.Misc.缺件发料单
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Cust.XMJL.BomBE.Cust_Xmjl_MO_BomHeadData m_bomHead;
		public UFIDA.U9.Cust.XMJL.BomBE.Cust_Xmjl_MO_BomHeadData BomHead
		{
			get	
			{	
				return m_bomHead ;
			}
			set	
			{	
				m_bomHead = value ;
			}
		}		

			
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 缺件发料单子行.Key.ID
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
		/// 缺件发料单子行.Sys.创建时间
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
		/// 缺件发料单子行.Sys.创建人
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
		/// 缺件发料单子行.Sys.修改时间
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
		/// 缺件发料单子行.Sys.修改人
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
		/// 缺件发料单子行.Sys.事务版本
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
		/// 发料数量
		/// 缺件发料单子行.Misc.发料数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_qty ;
		public System.Int32 Qty
		{
			get	
			{	
				return m_qty  ;
			}
			set	
			{	
				m_qty = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_shipL_SKey ;
		/// <summary>
		/// 杂发单行 序列化Key属性。（传递跨组织序列列字段）
		/// 缺件发料单子行.Misc.杂发单行
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey ShipL_SKey
		{
			get 
			{
				return m_shipL_SKey ;					
			}
			set
			{
				 m_shipL_SKey = value ;	
			}
		}
		/// <summary>
		/// 杂发单行
		/// 缺件发料单子行.Misc.杂发单行
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 ShipL
		{
			get	
			{	
				if (ShipL_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return ShipL_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					ShipL_SKey = null ;
				else
				{
					if (ShipL_SKey == null )
						ShipL_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.InvDoc.MiscShip.MiscShipmentL") ;
					else
						ShipL_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_rcvTransL_SKey ;
		/// <summary>
		/// 杂收单行 序列化Key属性。（传递跨组织序列列字段）
		/// 缺件发料单子行.Misc.杂收单行
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey RcvTransL_SKey
		{
			get 
			{
				return m_rcvTransL_SKey ;					
			}
			set
			{
				 m_rcvTransL_SKey = value ;	
			}
		}
		/// <summary>
		/// 杂收单行
		/// 缺件发料单子行.Misc.杂收单行
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 RcvTransL
		{
			get	
			{	
				if (RcvTransL_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return RcvTransL_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					RcvTransL_SKey = null ;
				else
				{
					if (RcvTransL_SKey == null )
						RcvTransL_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.InvDoc.MiscRcv.MiscRcvTransL") ;
					else
						RcvTransL_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 备注
		/// 缺件发料单子行.Misc.备注
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_memo ;
		public System.String Memo
		{
			get	
			{	
				return m_memo  ;
			}
			set	
			{	
				m_memo = value ;	
			}
		}
		

				/// <summary>
		/// 实体扩展字段
		/// 缺件发料单子行.Misc.实体扩展字段
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
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_org_SKey ;
		/// <summary>
		/// 组织 序列化Key属性。（传递跨组织序列列字段）
		/// 缺件发料单子行.Misc.组织
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Org_SKey
		{
			get 
			{
				return m_org_SKey ;					
			}
			set
			{
				 m_org_SKey = value ;	
			}
		}
		/// <summary>
		/// 组织
		/// 缺件发料单子行.Misc.组织
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 Org
		{
			get	
			{	
				if (Org_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Org_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Org_SKey = null ;
				else
				{
					if (Org_SKey == null )
						Org_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.Organization.Organization") ;
					else
						Org_SKey.ID = value ;
				}
			}
		}
		
		#endregion	

		#region Multi_Fields
													
		#endregion 		
	}	

}

