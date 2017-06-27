



using System; 
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.InvInfoQueryQryBP
{
	/// <summary>
	/// InvInfoQueryQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.Cust.FJGX.InvInfoQueryQryBP.InvInfoQueryQryDTOData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]
	[Serializable]
	[KnownType("GetKnownTypes")]
	public partial class InvInfoQueryQryDTOData : UFSoft.UBF.Business.DataTransObjectBase
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
		public InvInfoQueryQryDTOData()
		{
			initData();
		}
		private void initData()
		{
					ID= 0; 
				
		
		
		
		
		
		
		
					WhQoh_StoreQty=0m; 
					WhQoh_StoreQtyCU=0m; 
					ResvStQty=0m; 
					ResvStQtyCU=0m; 
					AvailableQty=0m; 
					AvailableQtyCU=0m; 
					WhQoh_StoreUOM_Round_Precision= 0; 
							WhQoh_StoreUOM_Round_RoundType= 0; 
							WhQoh_StoreUOM_Round_RoundValue= 0; 
				
					WhQoh_CU_Round_Precision= 0; 
							WhQoh_CU_Round_RoundValue= 0; 
				
					PackageNum=0m; 
					WholesalePrice=0m; 
					MeterPrice=0m; 
					ItemMaster_InventoryInfo_InventoryMaxLimitQty=0m; 
					ItemMaster_InventoryInfo_InventoryMinLimitQty=0m; 
					ItemMaster_InventoryInfo_SafetyStockQty=0m; 
		
					WhQoh_CU_Round_RoundType= 0; 
				
		
		

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
		public InvInfoQueryQryDTOData(  System.Int64 iD  , Int64 whQoh_Wh  , System.String whQoh_Wh_Name  , System.String itemMaster_Code  , System.String itemMaster_Name  , Int64 itemMaster_MainItemCategory  , System.String itemMaster_SPECS  , Int64 whQoh_LotInfo_LotMaster_EntityID  , System.String whQoh_LotInfo_LotCode  , System.Decimal whQoh_StoreQty  , System.Decimal whQoh_StoreQtyCU  , System.Decimal resvStQty  , System.Decimal resvStQtyCU  , System.Decimal availableQty  , System.Decimal availableQtyCU  , System.Int32 whQoh_StoreUOM_Round_Precision  , System.Int32 whQoh_StoreUOM_Round_RoundType  , System.Int32 whQoh_StoreUOM_Round_RoundValue  , System.String whQoh_StoreUOM_Name  , System.Int32 whQoh_CU_Round_Precision  , System.Int32 whQoh_CU_Round_RoundValue  , System.String whQoh_CU_Name  , System.Decimal packageNum  , System.Decimal wholesalePrice  , System.Decimal meterPrice  , System.Decimal itemMaster_InventoryInfo_InventoryMaxLimitQty  , System.Decimal itemMaster_InventoryInfo_InventoryMinLimitQty  , System.Decimal itemMaster_InventoryInfo_SafetyStockQty  , System.String itemMaster_MainItemCategory_Name  , System.Int32 whQoh_CU_Round_RoundType  , Int64 whQoh_Project  , System.String whQoh_Project_Code  , Int64 organization  )
		{
			initData();
			this.ID = iD;
			this.WhQoh_Wh = whQoh_Wh;
			this.WhQoh_Wh_Name = whQoh_Wh_Name;
			this.ItemMaster_Code = itemMaster_Code;
			this.ItemMaster_Name = itemMaster_Name;
			this.ItemMaster_MainItemCategory = itemMaster_MainItemCategory;
			this.ItemMaster_SPECS = itemMaster_SPECS;
			this.WhQoh_LotInfo_LotMaster_EntityID = whQoh_LotInfo_LotMaster_EntityID;
			this.WhQoh_LotInfo_LotCode = whQoh_LotInfo_LotCode;
			this.WhQoh_StoreQty = whQoh_StoreQty;
			this.WhQoh_StoreQtyCU = whQoh_StoreQtyCU;
			this.ResvStQty = resvStQty;
			this.ResvStQtyCU = resvStQtyCU;
			this.AvailableQty = availableQty;
			this.AvailableQtyCU = availableQtyCU;
			this.WhQoh_StoreUOM_Round_Precision = whQoh_StoreUOM_Round_Precision;
			this.WhQoh_StoreUOM_Round_RoundType = whQoh_StoreUOM_Round_RoundType;
			this.WhQoh_StoreUOM_Round_RoundValue = whQoh_StoreUOM_Round_RoundValue;
			this.WhQoh_StoreUOM_Name = whQoh_StoreUOM_Name;
			this.WhQoh_CU_Round_Precision = whQoh_CU_Round_Precision;
			this.WhQoh_CU_Round_RoundValue = whQoh_CU_Round_RoundValue;
			this.WhQoh_CU_Name = whQoh_CU_Name;
			this.PackageNum = packageNum;
			this.WholesalePrice = wholesalePrice;
			this.MeterPrice = meterPrice;
			this.ItemMaster_InventoryInfo_InventoryMaxLimitQty = itemMaster_InventoryInfo_InventoryMaxLimitQty;
			this.ItemMaster_InventoryInfo_InventoryMinLimitQty = itemMaster_InventoryInfo_InventoryMinLimitQty;
			this.ItemMaster_InventoryInfo_SafetyStockQty = itemMaster_InventoryInfo_SafetyStockQty;
			this.ItemMaster_MainItemCategory_Name = itemMaster_MainItemCategory_Name;
			this.WhQoh_CU_Round_RoundType = whQoh_CU_Round_RoundType;
			this.WhQoh_Project = whQoh_Project;
			this.WhQoh_Project_Code = whQoh_Project_Code;
			this.Organization = organization;
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
		/// InvInfoQueryQryDTO.Misc.ID
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
			
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_whQoh_Wh_SKey ;
		/// <summary>
		/// 存储地点 序列化Key属性。（传递跨组织序列列字段）
		/// InvInfoQueryQryDTO.Misc.存储地点
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey WhQoh_Wh_SKey
		{
			get 
			{
				return m_whQoh_Wh_SKey ;					
			}
			set
			{
				m_whQoh_Wh_SKey =value;	
			}
		}


		/// <summary>
		/// 存储地点
		/// InvInfoQueryQryDTO.Misc.存储地点
		/// </summary>
		[DataMember(IsRequired=false)]
		public Int64 WhQoh_Wh
		{
			get	
			{	
				if (WhQoh_Wh_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return WhQoh_Wh_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					WhQoh_Wh_SKey = null ;
				else
				{
					if (WhQoh_Wh_SKey == null )
						WhQoh_Wh_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.SCM.Warehouse.Warehouse") ;
					else
						WhQoh_Wh_SKey.ID = value ;
				}
			}
		}
			 	
		

		/// <summary>
		/// 料号
		/// InvInfoQueryQryDTO.Misc.料号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_itemMaster_Code ;
		public System.String ItemMaster_Code
		{
			get	
			{	
				return m_itemMaster_Code ;
			}
			set	
			{	
				m_itemMaster_Code = value ;	
			}
		}
			
		

		/// <summary>
		/// 品名
		/// InvInfoQueryQryDTO.Misc.品名
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_itemMaster_Name ;
		public System.String ItemMaster_Name
		{
			get	
			{	
				return m_itemMaster_Name ;
			}
			set	
			{	
				m_itemMaster_Name = value ;	
			}
		}
			
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_itemMaster_MainItemCategory_SKey ;
		/// <summary>
		/// 料品分类 序列化Key属性。（传递跨组织序列列字段）
		/// InvInfoQueryQryDTO.Misc.料品分类
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey ItemMaster_MainItemCategory_SKey
		{
			get 
			{
				return m_itemMaster_MainItemCategory_SKey ;					
			}
			set
			{
				m_itemMaster_MainItemCategory_SKey =value;	
			}
		}


		/// <summary>
		/// 料品分类
		/// InvInfoQueryQryDTO.Misc.料品分类
		/// </summary>
		[DataMember(IsRequired=false)]
		public Int64 ItemMaster_MainItemCategory
		{
			get	
			{	
				if (ItemMaster_MainItemCategory_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return ItemMaster_MainItemCategory_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					ItemMaster_MainItemCategory_SKey = null ;
				else
				{
					if (ItemMaster_MainItemCategory_SKey == null )
						ItemMaster_MainItemCategory_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.SCM.Item.ItemCategory") ;
					else
						ItemMaster_MainItemCategory_SKey.ID = value ;
				}
			}
		}
			
		

		/// <summary>
		/// 规格
		/// InvInfoQueryQryDTO.Misc.规格
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_itemMaster_SPECS ;
		public System.String ItemMaster_SPECS
		{
			get	
			{	
				return m_itemMaster_SPECS ;
			}
			set	
			{	
				m_itemMaster_SPECS = value ;	
			}
		}
			
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_whQoh_LotInfo_LotMaster_EntityID_SKey ;
		/// <summary>
		/// 批号 序列化Key属性。（传递跨组织序列列字段）
		/// InvInfoQueryQryDTO.Misc.批号
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey WhQoh_LotInfo_LotMaster_EntityID_SKey
		{
			get 
			{
				return m_whQoh_LotInfo_LotMaster_EntityID_SKey ;					
			}
			set
			{
				m_whQoh_LotInfo_LotMaster_EntityID_SKey =value;	
			}
		}


		/// <summary>
		/// 批号
		/// InvInfoQueryQryDTO.Misc.批号
		/// </summary>
		[DataMember(IsRequired=false)]
		public Int64 WhQoh_LotInfo_LotMaster_EntityID
		{
			get	
			{	
				if (WhQoh_LotInfo_LotMaster_EntityID_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return WhQoh_LotInfo_LotMaster_EntityID_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					WhQoh_LotInfo_LotMaster_EntityID_SKey = null ;
				else
				{
					if (WhQoh_LotInfo_LotMaster_EntityID_SKey == null )
						WhQoh_LotInfo_LotMaster_EntityID_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Lot.LotMaster") ;
					else
						WhQoh_LotInfo_LotMaster_EntityID_SKey.ID = value ;
				}
			}
		}
			
		

		/// <summary>
		/// 批号
		/// InvInfoQueryQryDTO.Misc.批号
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_whQoh_LotInfo_LotCode ;
		public System.String WhQoh_LotInfo_LotCode
		{
			get	
			{	
				return m_whQoh_LotInfo_LotCode ;
			}
			set	
			{	
				m_whQoh_LotInfo_LotCode = value ;	
			}
		}
			
		

		/// <summary>
		/// 结存数(库存单位)
		/// InvInfoQueryQryDTO.Misc.结存数(库存单位)
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_whQoh_StoreQty ;
		public System.Decimal WhQoh_StoreQty
		{
			get	
			{	
				return m_whQoh_StoreQty ;
			}
			set	
			{	
				m_whQoh_StoreQty = value ;	
			}
		}
			
		

		/// <summary>
		/// 结存数(成本单位)
		/// InvInfoQueryQryDTO.Misc.结存数(成本单位)
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_whQoh_StoreQtyCU ;
		public System.Decimal WhQoh_StoreQtyCU
		{
			get	
			{	
				return m_whQoh_StoreQtyCU ;
			}
			set	
			{	
				m_whQoh_StoreQtyCU = value ;	
			}
		}
			
		

		/// <summary>
		/// 预留量(库存单位)
		/// InvInfoQueryQryDTO.Misc.预留量(库存单位)
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_resvStQty ;
		public System.Decimal ResvStQty
		{
			get	
			{	
				return m_resvStQty ;
			}
			set	
			{	
				m_resvStQty = value ;	
			}
		}
			
		

		/// <summary>
		/// 预留量(成本单位)
		/// InvInfoQueryQryDTO.Misc.预留量(成本单位)
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_resvStQtyCU ;
		public System.Decimal ResvStQtyCU
		{
			get	
			{	
				return m_resvStQtyCU ;
			}
			set	
			{	
				m_resvStQtyCU = value ;	
			}
		}
			
		

		/// <summary>
		/// 可用量(库存单位)
		/// InvInfoQueryQryDTO.Misc.可用量(库存单位)
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_availableQty ;
		public System.Decimal AvailableQty
		{
			get	
			{	
				return m_availableQty ;
			}
			set	
			{	
				m_availableQty = value ;	
			}
		}
			
		

		/// <summary>
		/// 可用量(成本单位)
		/// InvInfoQueryQryDTO.Misc.可用量(成本单位)
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_availableQtyCU ;
		public System.Decimal AvailableQtyCU
		{
			get	
			{	
				return m_availableQtyCU ;
			}
			set	
			{	
				m_availableQtyCU = value ;	
			}
		}
			
		

		/// <summary>
		/// 库存在手量_库存单位_精度_精度
		/// InvInfoQueryQryDTO.Misc.库存在手量_库存单位_精度_精度
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_whQoh_StoreUOM_Round_Precision ;
		public System.Int32 WhQoh_StoreUOM_Round_Precision
		{
			get	
			{	
				return m_whQoh_StoreUOM_Round_Precision ;
			}
			set	
			{	
				m_whQoh_StoreUOM_Round_Precision = value ;	
			}
		}
			
		

		/// <summary>
		/// 库存在手量_库存单位_精度_舍入类型
		/// InvInfoQueryQryDTO.Misc.库存在手量_库存单位_精度_舍入类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_whQoh_StoreUOM_Round_RoundType ;
		public System.Int32 WhQoh_StoreUOM_Round_RoundType
		{
			get	
			{	
				return m_whQoh_StoreUOM_Round_RoundType ;
			}
			set	
			{	
				m_whQoh_StoreUOM_Round_RoundType = value ;	
			}
		}
			
		

		/// <summary>
		/// 库存在手量_库存单位_精度_舍入值
		/// InvInfoQueryQryDTO.Misc.库存在手量_库存单位_精度_舍入值
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_whQoh_StoreUOM_Round_RoundValue ;
		public System.Int32 WhQoh_StoreUOM_Round_RoundValue
		{
			get	
			{	
				return m_whQoh_StoreUOM_Round_RoundValue ;
			}
			set	
			{	
				m_whQoh_StoreUOM_Round_RoundValue = value ;	
			}
		}
			 	
		

		/// <summary>
		/// 库存在手量_成本单位_精度_精度
		/// InvInfoQueryQryDTO.Misc.库存在手量_成本单位_精度_精度
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_whQoh_CU_Round_Precision ;
		public System.Int32 WhQoh_CU_Round_Precision
		{
			get	
			{	
				return m_whQoh_CU_Round_Precision ;
			}
			set	
			{	
				m_whQoh_CU_Round_Precision = value ;	
			}
		}
			
		

		/// <summary>
		/// 库存在手量_成本单位_精度_舍入值
		/// InvInfoQueryQryDTO.Misc.库存在手量_成本单位_精度_舍入值
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_whQoh_CU_Round_RoundValue ;
		public System.Int32 WhQoh_CU_Round_RoundValue
		{
			get	
			{	
				return m_whQoh_CU_Round_RoundValue ;
			}
			set	
			{	
				m_whQoh_CU_Round_RoundValue = value ;	
			}
		}
			 	
		

		/// <summary>
		/// 包装数
		/// InvInfoQueryQryDTO.Misc.包装数
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_packageNum ;
		public System.Decimal PackageNum
		{
			get	
			{	
				return m_packageNum ;
			}
			set	
			{	
				m_packageNum = value ;	
			}
		}
			
		

		/// <summary>
		/// 批发价
		/// InvInfoQueryQryDTO.Misc.批发价
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_wholesalePrice ;
		public System.Decimal WholesalePrice
		{
			get	
			{	
				return m_wholesalePrice ;
			}
			set	
			{	
				m_wholesalePrice = value ;	
			}
		}
			
		

		/// <summary>
		/// 米价
		/// InvInfoQueryQryDTO.Misc.米价
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_meterPrice ;
		public System.Decimal MeterPrice
		{
			get	
			{	
				return m_meterPrice ;
			}
			set	
			{	
				m_meterPrice = value ;	
			}
		}
			
		

		/// <summary>
		/// 最高库存
		/// InvInfoQueryQryDTO.Misc.最高库存
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_itemMaster_InventoryInfo_InventoryMaxLimitQty ;
		public System.Decimal ItemMaster_InventoryInfo_InventoryMaxLimitQty
		{
			get	
			{	
				return m_itemMaster_InventoryInfo_InventoryMaxLimitQty ;
			}
			set	
			{	
				m_itemMaster_InventoryInfo_InventoryMaxLimitQty = value ;	
			}
		}
			
		

		/// <summary>
		/// 最低库存
		/// InvInfoQueryQryDTO.Misc.最低库存
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_itemMaster_InventoryInfo_InventoryMinLimitQty ;
		public System.Decimal ItemMaster_InventoryInfo_InventoryMinLimitQty
		{
			get	
			{	
				return m_itemMaster_InventoryInfo_InventoryMinLimitQty ;
			}
			set	
			{	
				m_itemMaster_InventoryInfo_InventoryMinLimitQty = value ;	
			}
		}
			
		

		/// <summary>
		/// 安全库存
		/// InvInfoQueryQryDTO.Misc.安全库存
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Decimal m_itemMaster_InventoryInfo_SafetyStockQty ;
		public System.Decimal ItemMaster_InventoryInfo_SafetyStockQty
		{
			get	
			{	
				return m_itemMaster_InventoryInfo_SafetyStockQty ;
			}
			set	
			{	
				m_itemMaster_InventoryInfo_SafetyStockQty = value ;	
			}
		}
			 	
		

		/// <summary>
		/// 库存在手量_成本单位_精度_舍入类型
		/// InvInfoQueryQryDTO.Misc.库存在手量_成本单位_精度_舍入类型
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int32 m_whQoh_CU_Round_RoundType ;
		public System.Int32 WhQoh_CU_Round_RoundType
		{
			get	
			{	
				return m_whQoh_CU_Round_RoundType ;
			}
			set	
			{	
				m_whQoh_CU_Round_RoundType = value ;	
			}
		}
			
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_whQoh_Project_SKey ;
		/// <summary>
		/// 项目 序列化Key属性。（传递跨组织序列列字段）
		/// InvInfoQueryQryDTO.Misc.项目
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey WhQoh_Project_SKey
		{
			get 
			{
				return m_whQoh_Project_SKey ;					
			}
			set
			{
				m_whQoh_Project_SKey =value;	
			}
		}


		/// <summary>
		/// 项目
		/// InvInfoQueryQryDTO.Misc.项目
		/// </summary>
		[DataMember(IsRequired=false)]
		public Int64 WhQoh_Project
		{
			get	
			{	
				if (WhQoh_Project_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return WhQoh_Project_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					WhQoh_Project_SKey = null ;
				else
				{
					if (WhQoh_Project_SKey == null )
						WhQoh_Project_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.CBO.SCM.ProjectTask.Project") ;
					else
						WhQoh_Project_SKey.ID = value ;
				}
			}
		}
			
		

		/// <summary>
		/// 编码
		/// InvInfoQueryQryDTO.Misc.编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_whQoh_Project_Code ;
		public System.String WhQoh_Project_Code
		{
			get	
			{	
				return m_whQoh_Project_Code ;
			}
			set	
			{	
				m_whQoh_Project_Code = value ;	
			}
		}
			
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_organization_SKey ;
		/// <summary>
		/// 组织 序列化Key属性。（传递跨组织序列列字段）
		/// InvInfoQueryQryDTO.Misc.组织
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Organization_SKey
		{
			get 
			{
				return m_organization_SKey ;					
			}
			set
			{
				m_organization_SKey =value;	
			}
		}


		/// <summary>
		/// 组织
		/// InvInfoQueryQryDTO.Misc.组织
		/// </summary>
		[DataMember(IsRequired=false)]
		public Int64 Organization
		{
			get	
			{	
				if (Organization_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Organization_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Organization_SKey = null ;
				else
				{
					if (Organization_SKey == null )
						Organization_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.Organization.Organization") ;
					else
						Organization_SKey.ID = value ;
				}
			}
		}
			
		#endregion	

		#region Multi_Fields
						 
		/// <summary>
		/// 名称
		/// InvInfoQueryQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public string WhQoh_Wh_Name
		{
			get
			{
				if (m_Multi_whQoh_Wh_Name == null)
					return String.Empty ;
				else
					return m_Multi_whQoh_Wh_Name.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_whQoh_Wh_Name == null)
					m_Multi_whQoh_Wh_Name = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_whQoh_Wh_Name.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_whQoh_Wh_Name ;
		/// <summary>
		/// 多语属性: 名称
		/// InvInfoQueryQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_WhQoh_Wh_Name
		{
			get
			{
				return m_Multi_whQoh_Wh_Name;
			}
			set
			{
				m_Multi_whQoh_Wh_Name = value ;	
			}
		}
																																		 
		/// <summary>
		/// 名称
		/// InvInfoQueryQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public string WhQoh_StoreUOM_Name
		{
			get
			{
				if (m_Multi_whQoh_StoreUOM_Name == null)
					return String.Empty ;
				else
					return m_Multi_whQoh_StoreUOM_Name.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_whQoh_StoreUOM_Name == null)
					m_Multi_whQoh_StoreUOM_Name = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_whQoh_StoreUOM_Name.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_whQoh_StoreUOM_Name ;
		/// <summary>
		/// 多语属性: 名称
		/// InvInfoQueryQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_WhQoh_StoreUOM_Name
		{
			get
			{
				return m_Multi_whQoh_StoreUOM_Name;
			}
			set
			{
				m_Multi_whQoh_StoreUOM_Name = value ;	
			}
		}
								 
		/// <summary>
		/// 名称
		/// InvInfoQueryQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public string WhQoh_CU_Name
		{
			get
			{
				if (m_Multi_whQoh_CU_Name == null)
					return String.Empty ;
				else
					return m_Multi_whQoh_CU_Name.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_whQoh_CU_Name == null)
					m_Multi_whQoh_CU_Name = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_whQoh_CU_Name.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_whQoh_CU_Name ;
		/// <summary>
		/// 多语属性: 名称
		/// InvInfoQueryQryDTO.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_WhQoh_CU_Name
		{
			get
			{
				return m_Multi_whQoh_CU_Name;
			}
			set
			{
				m_Multi_whQoh_CU_Name = value ;	
			}
		}
																 
		/// <summary>
		/// 料品分类
		/// InvInfoQueryQryDTO.Misc.料品分类
		/// </summary>
		[DataMember(IsRequired=false)]
		public string ItemMaster_MainItemCategory_Name
		{
			get
			{
				if (m_Multi_itemMaster_MainItemCategory_Name == null)
					return String.Empty ;
				else
					return m_Multi_itemMaster_MainItemCategory_Name.DefaultLangValue ;
			}
			set
			{
				if (m_Multi_itemMaster_MainItemCategory_Name == null)
					m_Multi_itemMaster_MainItemCategory_Name = new  UFSoft.UBF.Util.Data.MultiLangDataDict() ;
				m_Multi_itemMaster_MainItemCategory_Name.DefaultLangValue = value ;
			}
		}
		private UFSoft.UBF.Util.Data.MultiLangDataDict m_Multi_itemMaster_MainItemCategory_Name ;
		/// <summary>
		/// 多语属性: 料品分类
		/// InvInfoQueryQryDTO.Misc.料品分类
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_ItemMaster_MainItemCategory_Name
		{
			get
			{
				return m_Multi_itemMaster_MainItemCategory_Name;
			}
			set
			{
				m_Multi_itemMaster_MainItemCategory_Name = value ;	
			}
		}
										
		#endregion 
	} 	
}

	
