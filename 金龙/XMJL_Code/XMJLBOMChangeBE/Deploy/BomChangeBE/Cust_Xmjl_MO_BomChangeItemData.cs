
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJLBomChangeBE
{
	/// <summary>
	/// 缺件变更料号行 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItemData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class Cust_Xmjl_MO_BomChangeItemData : UFSoft.UBF.Business.DataTransObjectBase
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeData));
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.Item.ItemMasterData));
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.Supplier.SupplierData));
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData));
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public Cust_Xmjl_MO_BomChangeItemData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     			
	     			
	     			
	     							RowNo= 0; 			     			
	     							DistQty=0m; 
	     			


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
			get { return "UFIDA.U9.Cust.XMJLBomChangeBE.Cust_Xmjl_MO_BomChangeItem" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        			
			private UFSoft.UBF.Business.BusinessEntity.EntityKey m_cust_Xmjl_MO_BomChange_SKey ;
			/// <summary>
			/// 缺件变更单 序列化Key属性。（传递跨组织序列列字段）
			/// 缺件变更料号行.Misc.缺件变更单
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
		/// 缺件变更料号行.Misc.缺件变更单
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
		/// 缺件变更料号行.Key.ID
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
		/// 缺件变更料号行.Sys.创建时间
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
		/// 缺件变更料号行.Sys.创建人
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
		/// 缺件变更料号行.Sys.修改时间
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
		/// 缺件变更料号行.Sys.修改人
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
		/// 缺件变更料号行.Sys.事务版本
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
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_item_SKey ;
		/// <summary>
		/// 料品 序列化Key属性。（传递跨组织序列列字段）
		/// 缺件变更料号行.Misc.料品
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Item_SKey
		{
			get 
			{
				return m_item_SKey ;					
			}
			set
			{
				 m_item_SKey = value ;	
			}
		}
		/// <summary>
		/// 料品
		/// 缺件变更料号行.Misc.料品
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 Item
		{
			get	
			{	
				if (Item_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Item_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Item_SKey = null ;
				else
				{
					if (Item_SKey == null )
						Item_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.SCM.Item.ItemMaster") ;
					else
						Item_SKey.ID = value ;
				}
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_supplier_SKey ;
		/// <summary>
		/// 供应商 序列化Key属性。（传递跨组织序列列字段）
		/// 缺件变更料号行.Misc.供应商
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Supplier_SKey
		{
			get 
			{
				return m_supplier_SKey ;					
			}
			set
			{
				 m_supplier_SKey = value ;	
			}
		}
		/// <summary>
		/// 供应商
		/// 缺件变更料号行.Misc.供应商
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 Supplier
		{
			get	
			{	
				if (Supplier_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Supplier_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Supplier_SKey = null ;
				else
				{
					if (Supplier_SKey == null )
						Supplier_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.SCM.Supplier.Supplier") ;
					else
						Supplier_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 行号
		/// 缺件变更料号行.Misc.行号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_rowNo ;
		public System.Int32 RowNo
		{
			get	
			{	
				return m_rowNo  ;
			}
			set	
			{	
				m_rowNo = value ;	
			}
		}
		

				/// <summary>
		/// 工位
		/// 缺件变更料号行.Misc.工位
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_workPlace ;
		public System.String WorkPlace
		{
			get	
			{	
				return m_workPlace  ;
			}
			set	
			{	
				m_workPlace = value ;	
			}
		}
		

				/// <summary>
		/// 发料数量
		/// 缺件变更料号行.Misc.发料数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_distQty ;
		public System.Decimal DistQty
		{
			get	
			{	
				return m_distQty  ;
			}
			set	
			{	
				m_distQty = value ;	
			}
		}
		

				/// <summary>
		/// 实体扩展字段
		/// 缺件变更料号行.Misc.实体扩展字段
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

