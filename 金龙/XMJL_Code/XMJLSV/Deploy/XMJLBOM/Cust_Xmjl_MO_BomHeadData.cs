
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.XMJL.BomBE
{
	/// <summary>
	/// 缺件发料单 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.XMJL.BomBE.Cust_Xmjl_MO_BomHeadData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class Cust_Xmjl_MO_BomHeadData : UFSoft.UBF.Business.DataTransObjectBase
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.Item.ItemMasterData));
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.Supplier.SupplierData));
                                        knownTypes.Add(typeof(UFIDA.U9.CBO.SCM.Warehouse.WarehouseData));
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Base.UserRole.UserData));
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Cust.XMJL.BomBE.Cust_Xmjl_MO_BomMainData));
                                        knownTypes.Add(typeof(List<UFIDA.U9.Cust.XMJL.BomBE.Cust_Xmjl_MO_BomLineData>));
                                        knownTypes.Add(typeof(UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData));
                                        knownTypes.Add(typeof(UFIDA.U9.Base.Organization.OrganizationData));
                        
                        
                        
                        
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public Cust_Xmjl_MO_BomHeadData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     			
	     			
	     			
	     			
	     							Status= 0; 			     							Qty= 0; 			     							DisbursedQty= 0; 			     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     			
	     							FeeQty=0m; 
	     							BackQty=0m; 


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
			get { return "UFIDA.U9.Cust.XMJL.BomBE.Cust_Xmjl_MO_BomHead" ;}
		}
		#endregion


		
		#region Properties Inner Component
	        					/// <summary>
		/// 状态
		/// 缺件发料单.Misc.状态
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_status;
		public System.Int32 Status
		{
			get	
			{	
				return m_status ;
			}
			set	
			{	
				m_status = value ;
			}
		}		

			        			
			private UFSoft.UBF.Business.BusinessEntity.EntityKey m_bomMain_SKey ;
			/// <summary>
			/// 缺件发料主表 序列化Key属性。（传递跨组织序列列字段）
			/// 缺件发料单.Misc.缺件发料主表
			/// </summary>
			[DataMember(IsRequired=false)]
			public UFSoft.UBF.Business.BusinessEntity.EntityKey BomMain_SKey
			{
				get 
				{
					return m_bomMain_SKey ;					
				}
				set
				{
					m_bomMain_SKey = value ;	
				}
			}
		/// <summary>
		/// 缺件发料主表
		/// 缺件发料单.Misc.缺件发料主表
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Cust.XMJL.BomBE.Cust_Xmjl_MO_BomMainData m_bomMain;
		public UFIDA.U9.Cust.XMJL.BomBE.Cust_Xmjl_MO_BomMainData BomMain
		{
			get	
			{	
				return m_bomMain ;
			}
			set	
			{	
				m_bomMain = value ;
			}
		}		

			        					/// <summary>
		/// 缺件发料单子行
		/// 缺件发料单.Misc.缺件发料单子行
		/// </summary>
		[DataMember(IsRequired=false)]
		private List<UFIDA.U9.Cust.XMJL.BomBE.Cust_Xmjl_MO_BomLineData> m_bomLine;
		public List<UFIDA.U9.Cust.XMJL.BomBE.Cust_Xmjl_MO_BomLineData> BomLine
		{
			get	
			{	
				if (m_bomLine == null)
				{
					List<UFIDA.U9.Cust.XMJL.BomBE.Cust_Xmjl_MO_BomLineData> m_list = new List<UFIDA.U9.Cust.XMJL.BomBE.Cust_Xmjl_MO_BomLineData>() ;
					m_bomLine = m_list;
				}
				return m_bomLine ;
			}
			set	
			{	
				m_bomLine = value ;
			}
		}		

			
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 缺件发料单.Key.ID
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
		/// 缺件发料单.Sys.创建时间
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
		/// 缺件发料单.Sys.创建人
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
		/// 缺件发料单.Sys.修改时间
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
		/// 缺件发料单.Sys.修改人
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
		/// 缺件发料单.Sys.事务版本
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
		/// 缺件发料单.Misc.料品
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
		/// 缺件发料单.Misc.料品
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
		/// 缺件发料单.Misc.供应商
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
		/// 缺件发料单.Misc.供应商
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
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_wareHouse_SKey ;
		/// <summary>
		/// 仓库 序列化Key属性。（传递跨组织序列列字段）
		/// 缺件发料单.Misc.仓库
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey WareHouse_SKey
		{
			get 
			{
				return m_wareHouse_SKey ;					
			}
			set
			{
				 m_wareHouse_SKey = value ;	
			}
		}
		/// <summary>
		/// 仓库
		/// 缺件发料单.Misc.仓库
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 WareHouse
		{
			get	
			{	
				if (WareHouse_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return WareHouse_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					WareHouse_SKey = null ;
				else
				{
					if (WareHouse_SKey == null )
						WareHouse_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.SCM.Warehouse.Warehouse") ;
					else
						WareHouse_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 工位
		/// 缺件发料单.Misc.工位
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
		/// 缺件发料单.Misc.发料数量
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
		

				/// <summary>
		/// 已发料数量
		/// 缺件发料单.Misc.已发料数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_disbursedQty ;
		public System.Int32 DisbursedQty
		{
			get	
			{	
				return m_disbursedQty  ;
			}
			set	
			{	
				m_disbursedQty = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_rptBy_SKey ;
		/// <summary>
		/// 报告人员 序列化Key属性。（传递跨组织序列列字段）
		/// 缺件发料单.Misc.报告人员
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey RptBy_SKey
		{
			get 
			{
				return m_rptBy_SKey ;					
			}
			set
			{
				 m_rptBy_SKey = value ;	
			}
		}
		/// <summary>
		/// 报告人员
		/// 缺件发料单.Misc.报告人员
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 RptBy
		{
			get	
			{	
				if (RptBy_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return RptBy_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					RptBy_SKey = null ;
				else
				{
					if (RptBy_SKey == null )
						RptBy_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.UserRole.User") ;
					else
						RptBy_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 报告日期
		/// 缺件发料单.Misc.报告日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_rptOn ;
		public System.DateTime RptOn
		{
			get	
			{	
				return m_rptOn  ;
			}
			set	
			{	
				m_rptOn = value ;	
			}
		}
		

				/// <summary>
		/// 备注
		/// 缺件发料单.Misc.备注
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
		/// 缺件发料单.Misc.实体扩展字段
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
		/// 缺件发料单.Misc.组织
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
		/// 缺件发料单.Misc.组织
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
		

				/// <summary>
		/// 费用行ID
		/// 缺件发料单.Misc.费用行ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_feeID ;
		public System.String FeeID
		{
			get	
			{	
				return m_feeID  ;
			}
			set	
			{	
				m_feeID = value ;	
			}
		}
		

				/// <summary>
		/// 出库日期
		/// 缺件发料单.Misc.出库日期
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_outOn ;
		public System.DateTime OutOn
		{
			get	
			{	
				return m_outOn  ;
			}
			set	
			{	
				m_outOn = value ;	
			}
		}
		

				/// <summary>
		/// 生成费用行的数量
		/// 缺件发料单.Misc.生成费用行的数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_feeQty ;
		public System.Decimal FeeQty
		{
			get	
			{	
				return m_feeQty  ;
			}
			set	
			{	
				m_feeQty = value ;	
			}
		}
		

				/// <summary>
		/// 回冲数量
		/// 缺件发料单.Misc.回冲数量
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_backQty ;
		public System.Decimal BackQty
		{
			get	
			{	
				return m_backQty  ;
			}
			set	
			{	
				m_backQty = value ;	
			}
		}
		
		#endregion	

		#region Multi_Fields
																								
		#endregion 		
	}	

}

