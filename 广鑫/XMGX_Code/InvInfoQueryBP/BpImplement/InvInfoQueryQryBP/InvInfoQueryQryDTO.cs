


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.FJGX.InvInfoQueryQryBP
{
	/// <summary>
	/// InvInfoQueryQryDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class InvInfoQueryQryDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public InvInfoQueryQryDTO(){
			initData();
		}
		private void initData()
		{
					ID = 0; 
		
		
		
		
		
		
		
		
					WhQoh_StoreQty = 0m; 
					WhQoh_StoreQtyCU = 0m; 
					ResvStQty = 0m; 
					ResvStQtyCU = 0m; 
					AvailableQty = 0m; 
					AvailableQtyCU = 0m; 
					WhQoh_StoreUOM_Round_Precision = 0; 
					WhQoh_StoreUOM_Round_RoundType =UFIDA.U9.Base.PropertyTypes.RoundTypeEnum.GetFromValue(0); 
					WhQoh_StoreUOM_Round_RoundValue = 0; 
		
					WhQoh_CU_Round_Precision = 0; 
					WhQoh_CU_Round_RoundValue = 0; 
		
					PackageNum = 0m; 
					WholesalePrice = 0m; 
					MeterPrice = 0m; 
					ItemMaster_InventoryInfo_InventoryMaxLimitQty = 0m; 
					ItemMaster_InventoryInfo_InventoryMinLimitQty = 0m; 
					ItemMaster_InventoryInfo_SafetyStockQty = 0m; 
		
					WhQoh_CU_Round_RoundType =UFIDA.U9.Base.PropertyTypes.RoundTypeEnum.GetFromValue(0); 
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// InvInfoQueryQryDTO.Misc.ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 ID
		{
			get	
			{	
				return (System.Int64)base.GetValue("ID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("ID",value);
			}
		}
				/// <summary>
		/// 存储地点 (该属性可为空,且无默认值)
		/// InvInfoQueryQryDTO.Misc.存储地点
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Warehouse.Warehouse</value>
		public UFIDA.U9.CBO.SCM.Warehouse.Warehouse.EntityKey WhQoh_Wh
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Warehouse.Warehouse.EntityKey)base.GetValue("WhQoh_Wh",typeof(UFIDA.U9.CBO.SCM.Warehouse.Warehouse.EntityKey));
			}

			 set	
			{
				base.SetValue("WhQoh_Wh",value);
			}
		}
		 
				/// <summary>
		/// 料号 (该属性不可为空,且无默认值)
		/// InvInfoQueryQryDTO.Misc.料号
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemMaster_Code
		{
			get	
			{	
				return (System.String)base.GetValue("ItemMaster_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemMaster_Code",value);
			}
		}
				/// <summary>
		/// 品名 (该属性不可为空,且无默认值)
		/// InvInfoQueryQryDTO.Misc.品名
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemMaster_Name
		{
			get	
			{	
				return (System.String)base.GetValue("ItemMaster_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemMaster_Name",value);
			}
		}
				/// <summary>
		/// 料品分类 (该属性可为空,且无默认值)
		/// InvInfoQueryQryDTO.Misc.料品分类
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Item.ItemCategory</value>
		public UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey ItemMaster_MainItemCategory
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey)base.GetValue("ItemMaster_MainItemCategory",typeof(UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey));
			}

			 set	
			{
				base.SetValue("ItemMaster_MainItemCategory",value);
			}
		}
				/// <summary>
		/// 规格 (该属性可为空,且无默认值)
		/// InvInfoQueryQryDTO.Misc.规格
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemMaster_SPECS
		{
			get	
			{	
				return (System.String)base.GetValue("ItemMaster_SPECS",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemMaster_SPECS",value);
			}
		}
				/// <summary>
		/// 批号 (该属性可为空,且无默认值)
		/// InvInfoQueryQryDTO.Misc.批号
		/// </summary>
		/// <value>UFIDA.U9.Lot.LotMaster</value>
		public UFIDA.U9.Lot.LotMaster.EntityKey WhQoh_LotInfo_LotMaster_EntityID
		{
			get	
			{	
				return (UFIDA.U9.Lot.LotMaster.EntityKey)base.GetValue("WhQoh_LotInfo_LotMaster_EntityID",typeof(UFIDA.U9.Lot.LotMaster.EntityKey));
			}

			 set	
			{
				base.SetValue("WhQoh_LotInfo_LotMaster_EntityID",value);
			}
		}
				/// <summary>
		/// 批号 (该属性可为空,且无默认值)
		/// InvInfoQueryQryDTO.Misc.批号
		/// </summary>
		/// <value>System.String</value>
		public System.String WhQoh_LotInfo_LotCode
		{
			get	
			{	
				return (System.String)base.GetValue("WhQoh_LotInfo_LotCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("WhQoh_LotInfo_LotCode",value);
			}
		}
				/// <summary>
		/// 结存数(库存单位) (该属性不可为空,但有默认值)
		/// InvInfoQueryQryDTO.Misc.结存数(库存单位)
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal WhQoh_StoreQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("WhQoh_StoreQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("WhQoh_StoreQty",value);
			}
		}
				/// <summary>
		/// 结存数(成本单位) (该属性可为空,但有默认值)
		/// InvInfoQueryQryDTO.Misc.结存数(成本单位)
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal WhQoh_StoreQtyCU
		{
			get	
			{	
				return (System.Decimal)base.GetValue("WhQoh_StoreQtyCU",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("WhQoh_StoreQtyCU",value);
			}
		}
				/// <summary>
		/// 预留量(库存单位) (该属性可为空,但有默认值)
		/// InvInfoQueryQryDTO.Misc.预留量(库存单位)
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ResvStQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ResvStQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ResvStQty",value);
			}
		}
				/// <summary>
		/// 预留量(成本单位) (该属性可为空,但有默认值)
		/// InvInfoQueryQryDTO.Misc.预留量(成本单位)
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ResvStQtyCU
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ResvStQtyCU",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ResvStQtyCU",value);
			}
		}
				/// <summary>
		/// 可用量(库存单位) (该属性可为空,但有默认值)
		/// InvInfoQueryQryDTO.Misc.可用量(库存单位)
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal AvailableQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("AvailableQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("AvailableQty",value);
			}
		}
				/// <summary>
		/// 可用量(成本单位) (该属性可为空,但有默认值)
		/// InvInfoQueryQryDTO.Misc.可用量(成本单位)
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal AvailableQtyCU
		{
			get	
			{	
				return (System.Decimal)base.GetValue("AvailableQtyCU",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("AvailableQtyCU",value);
			}
		}
				/// <summary>
		/// 库存在手量_库存单位_精度_精度 (该属性不可为空,但有默认值)
		/// InvInfoQueryQryDTO.Misc.库存在手量_库存单位_精度_精度
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 WhQoh_StoreUOM_Round_Precision
		{
			get	
			{	
				return (System.Int32)base.GetValue("WhQoh_StoreUOM_Round_Precision",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("WhQoh_StoreUOM_Round_Precision",value);
			}
		}
				/// <summary>
		/// 库存在手量_库存单位_精度_舍入类型 (该属性不可为空,但有默认值)
		/// InvInfoQueryQryDTO.Misc.库存在手量_库存单位_精度_舍入类型
		/// </summary>
		/// <value>UFIDA.U9.Base.PropertyTypes.RoundTypeEnum</value>
		public UFIDA.U9.Base.PropertyTypes.RoundTypeEnum WhQoh_StoreUOM_Round_RoundType
		{
			get	
			{	
				return (UFIDA.U9.Base.PropertyTypes.RoundTypeEnum)base.GetValue("WhQoh_StoreUOM_Round_RoundType",typeof(UFIDA.U9.Base.PropertyTypes.RoundTypeEnum));
			}

			 set	
			{
				base.SetValue("WhQoh_StoreUOM_Round_RoundType",value);
			}
		}
				/// <summary>
		/// 库存在手量_库存单位_精度_舍入值 (该属性可为空,但有默认值)
		/// InvInfoQueryQryDTO.Misc.库存在手量_库存单位_精度_舍入值
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 WhQoh_StoreUOM_Round_RoundValue
		{
			get	
			{	
				return (System.Int32)base.GetValue("WhQoh_StoreUOM_Round_RoundValue",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("WhQoh_StoreUOM_Round_RoundValue",value);
			}
		}
		 
				/// <summary>
		/// 库存在手量_成本单位_精度_精度 (该属性不可为空,但有默认值)
		/// InvInfoQueryQryDTO.Misc.库存在手量_成本单位_精度_精度
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 WhQoh_CU_Round_Precision
		{
			get	
			{	
				return (System.Int32)base.GetValue("WhQoh_CU_Round_Precision",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("WhQoh_CU_Round_Precision",value);
			}
		}
				/// <summary>
		/// 库存在手量_成本单位_精度_舍入值 (该属性可为空,但有默认值)
		/// InvInfoQueryQryDTO.Misc.库存在手量_成本单位_精度_舍入值
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 WhQoh_CU_Round_RoundValue
		{
			get	
			{	
				return (System.Int32)base.GetValue("WhQoh_CU_Round_RoundValue",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("WhQoh_CU_Round_RoundValue",value);
			}
		}
		 
				/// <summary>
		/// 包装数 (该属性可为空,但有默认值)
		/// InvInfoQueryQryDTO.Misc.包装数
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal PackageNum
		{
			get	
			{	
				return (System.Decimal)base.GetValue("PackageNum",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("PackageNum",value);
			}
		}
				/// <summary>
		/// 批发价 (该属性可为空,但有默认值)
		/// InvInfoQueryQryDTO.Misc.批发价
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal WholesalePrice
		{
			get	
			{	
				return (System.Decimal)base.GetValue("WholesalePrice",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("WholesalePrice",value);
			}
		}
				/// <summary>
		/// 米价 (该属性可为空,但有默认值)
		/// InvInfoQueryQryDTO.Misc.米价
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal MeterPrice
		{
			get	
			{	
				return (System.Decimal)base.GetValue("MeterPrice",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("MeterPrice",value);
			}
		}
				/// <summary>
		/// 最高库存 (该属性可为空,但有默认值)
		/// InvInfoQueryQryDTO.Misc.最高库存
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ItemMaster_InventoryInfo_InventoryMaxLimitQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ItemMaster_InventoryInfo_InventoryMaxLimitQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ItemMaster_InventoryInfo_InventoryMaxLimitQty",value);
			}
		}
				/// <summary>
		/// 最低库存 (该属性可为空,但有默认值)
		/// InvInfoQueryQryDTO.Misc.最低库存
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ItemMaster_InventoryInfo_InventoryMinLimitQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ItemMaster_InventoryInfo_InventoryMinLimitQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ItemMaster_InventoryInfo_InventoryMinLimitQty",value);
			}
		}
				/// <summary>
		/// 安全库存 (该属性可为空,但有默认值)
		/// InvInfoQueryQryDTO.Misc.安全库存
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ItemMaster_InventoryInfo_SafetyStockQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ItemMaster_InventoryInfo_SafetyStockQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ItemMaster_InventoryInfo_SafetyStockQty",value);
			}
		}
		 
				/// <summary>
		/// 库存在手量_成本单位_精度_舍入类型 (该属性不可为空,但有默认值)
		/// InvInfoQueryQryDTO.Misc.库存在手量_成本单位_精度_舍入类型
		/// </summary>
		/// <value>UFIDA.U9.Base.PropertyTypes.RoundTypeEnum</value>
		public UFIDA.U9.Base.PropertyTypes.RoundTypeEnum WhQoh_CU_Round_RoundType
		{
			get	
			{	
				return (UFIDA.U9.Base.PropertyTypes.RoundTypeEnum)base.GetValue("WhQoh_CU_Round_RoundType",typeof(UFIDA.U9.Base.PropertyTypes.RoundTypeEnum));
			}

			 set	
			{
				base.SetValue("WhQoh_CU_Round_RoundType",value);
			}
		}
				/// <summary>
		/// 项目 (该属性可为空,且无默认值)
		/// InvInfoQueryQryDTO.Misc.项目
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.ProjectTask.Project</value>
		public UFIDA.U9.CBO.SCM.ProjectTask.Project.EntityKey WhQoh_Project
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.ProjectTask.Project.EntityKey)base.GetValue("WhQoh_Project",typeof(UFIDA.U9.CBO.SCM.ProjectTask.Project.EntityKey));
			}

			 set	
			{
				base.SetValue("WhQoh_Project",value);
			}
		}
				/// <summary>
		/// 编码 (该属性不可为空,且无默认值)
		/// InvInfoQueryQryDTO.Misc.编码
		/// </summary>
		/// <value>System.String</value>
		public System.String WhQoh_Project_Code
		{
			get	
			{	
				return (System.String)base.GetValue("WhQoh_Project_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("WhQoh_Project_Code",value);
			}
		}
				/// <summary>
		/// 组织 (该属性可为空,且无默认值)
		/// InvInfoQueryQryDTO.Misc.组织
		/// </summary>
		/// <value>UFIDA.U9.Base.Organization.Organization</value>
		public UFIDA.U9.Base.Organization.Organization.EntityKey Organization
		{
			get	
			{	
				return (UFIDA.U9.Base.Organization.Organization.EntityKey)base.GetValue("Organization",typeof(UFIDA.U9.Base.Organization.Organization.EntityKey));
			}

			 set	
			{
				base.SetValue("Organization",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
			 
		/// <summary>
		/// 名称
		/// InvInfoQueryQryDTO.Misc.名称
		/// </summary>
		public string WhQoh_Wh_Name
		{
			get
			{
				return base.GetMultiLangProp("WhQoh_Wh_Name");
			}
			set
			{
				base.SetMultiLangProp("WhQoh_Wh_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_WhQoh_Wh_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_WhQoh_Wh_Name
		{
			get
			{
				return base.GetMultiLangPropDict("WhQoh_Wh_Name");
			}
			set
			{
				base.SetMultiLangPropDict("WhQoh_Wh_Name",value);	
			}
		}
																 
		/// <summary>
		/// 名称
		/// InvInfoQueryQryDTO.Misc.名称
		/// </summary>
		public string WhQoh_StoreUOM_Name
		{
			get
			{
				return base.GetMultiLangProp("WhQoh_StoreUOM_Name");
			}
			set
			{
				base.SetMultiLangProp("WhQoh_StoreUOM_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_WhQoh_StoreUOM_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_WhQoh_StoreUOM_Name
		{
			get
			{
				return base.GetMultiLangPropDict("WhQoh_StoreUOM_Name");
			}
			set
			{
				base.SetMultiLangPropDict("WhQoh_StoreUOM_Name",value);	
			}
		}
			 
		/// <summary>
		/// 名称
		/// InvInfoQueryQryDTO.Misc.名称
		/// </summary>
		public string WhQoh_CU_Name
		{
			get
			{
				return base.GetMultiLangProp("WhQoh_CU_Name");
			}
			set
			{
				base.SetMultiLangProp("WhQoh_CU_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_WhQoh_CU_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_WhQoh_CU_Name
		{
			get
			{
				return base.GetMultiLangPropDict("WhQoh_CU_Name");
			}
			set
			{
				base.SetMultiLangPropDict("WhQoh_CU_Name",value);	
			}
		}
							 
		/// <summary>
		/// 料品分类
		/// InvInfoQueryQryDTO.Misc.料品分类
		/// </summary>
		public string ItemMaster_MainItemCategory_Name
		{
			get
			{
				return base.GetMultiLangProp("ItemMaster_MainItemCategory_Name");
			}
			set
			{
				base.SetMultiLangProp("ItemMaster_MainItemCategory_Name",value);	
			}
		}
		//private UFSoft.UBF.Util.Data.MultiLangDataDict mul_ItemMaster_MainItemCategory_Name ;
		public UFSoft.UBF.Util.Data.MultiLangDataDict Multi_ItemMaster_MainItemCategory_Name
		{
			get
			{
				return base.GetMultiLangPropDict("ItemMaster_MainItemCategory_Name");
			}
			set
			{
				base.SetMultiLangPropDict("ItemMaster_MainItemCategory_Name",value);	
			}
		}
				
		#endregion 
		#region  QuaryDTO Add Prop
		private int m_recordCount ;
		public int  RecordCount 
		{
			get {return m_recordCount ;}
			set { m_recordCount = value ;}
		}
		#endregion 

		#region ModelResource
		/// <summary>
		/// InvInfoQueryQryDTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 存储地点的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WhQoh_Wh　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WhQoh_Wh_Name　{ get { return "";　}　}
		/// <summary>
		/// 料号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemMaster_Code　{ get { return "";　}　}
		/// <summary>
		/// 品名的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemMaster_Name　{ get { return "";　}　}
		/// <summary>
		/// 料品分类的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemMaster_MainItemCategory　{ get { return "";　}　}
		/// <summary>
		/// 规格的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemMaster_SPECS　{ get { return "";　}　}
		/// <summary>
		/// 批号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WhQoh_LotInfo_LotMaster_EntityID　{ get { return "";　}　}
		/// <summary>
		/// 批号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WhQoh_LotInfo_LotCode　{ get { return "";　}　}
		/// <summary>
		/// 结存数(库存单位)的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WhQoh_StoreQty　{ get { return "";　}　}
		/// <summary>
		/// 结存数(成本单位)的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WhQoh_StoreQtyCU　{ get { return "";　}　}
		/// <summary>
		/// 预留量(库存单位)的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ResvStQty　{ get { return "";　}　}
		/// <summary>
		/// 预留量(成本单位)的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ResvStQtyCU　{ get { return "";　}　}
		/// <summary>
		/// 可用量(库存单位)的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AvailableQty　{ get { return "";　}　}
		/// <summary>
		/// 可用量(成本单位)的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AvailableQtyCU　{ get { return "";　}　}
		/// <summary>
		/// 库存在手量_库存单位_精度_精度的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WhQoh_StoreUOM_Round_Precision　{ get { return "";　}　}
		/// <summary>
		/// 库存在手量_库存单位_精度_舍入类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WhQoh_StoreUOM_Round_RoundType　{ get { return "";　}　}
		/// <summary>
		/// 库存在手量_库存单位_精度_舍入值的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WhQoh_StoreUOM_Round_RoundValue　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WhQoh_StoreUOM_Name　{ get { return "";　}　}
		/// <summary>
		/// 库存在手量_成本单位_精度_精度的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WhQoh_CU_Round_Precision　{ get { return "";　}　}
		/// <summary>
		/// 库存在手量_成本单位_精度_舍入值的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WhQoh_CU_Round_RoundValue　{ get { return "";　}　}
		/// <summary>
		/// 名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WhQoh_CU_Name　{ get { return "";　}　}
		/// <summary>
		/// 包装数的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PackageNum　{ get { return "";　}　}
		/// <summary>
		/// 批发价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WholesalePrice　{ get { return "";　}　}
		/// <summary>
		/// 米价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_MeterPrice　{ get { return "";　}　}
		/// <summary>
		/// 最高库存的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemMaster_InventoryInfo_InventoryMaxLimitQty　{ get { return "";　}　}
		/// <summary>
		/// 最低库存的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemMaster_InventoryInfo_InventoryMinLimitQty　{ get { return "";　}　}
		/// <summary>
		/// 安全库存的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemMaster_InventoryInfo_SafetyStockQty　{ get { return "";　}　}
		/// <summary>
		/// 料品分类的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemMaster_MainItemCategory_Name　{ get { return "";　}　}
		/// <summary>
		/// 库存在手量_成本单位_精度_舍入类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WhQoh_CU_Round_RoundType　{ get { return "";　}　}
		/// <summary>
		/// 项目的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WhQoh_Project　{ get { return "";　}　}
		/// <summary>
		/// 编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_WhQoh_Project_Code　{ get { return "";　}　}
		/// <summary>
		/// 组织的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Organization　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(InvInfoQueryQryDTOData data)
		{
		

			if (data.WhQoh_Wh == -1 && data.WhQoh_Wh_SKey!=null)
				data.WhQoh_Wh = data.WhQoh_Wh_SKey.GetEntity().ID ;




			if (data.ItemMaster_MainItemCategory == -1 && data.ItemMaster_MainItemCategory_SKey!=null)
				data.ItemMaster_MainItemCategory = data.ItemMaster_MainItemCategory_SKey.GetEntity().ID ;


			if (data.WhQoh_LotInfo_LotMaster_EntityID == -1 && data.WhQoh_LotInfo_LotMaster_EntityID_SKey!=null)
				data.WhQoh_LotInfo_LotMaster_EntityID = data.WhQoh_LotInfo_LotMaster_EntityID_SKey.GetEntity().ID ;























			if (data.WhQoh_Project == -1 && data.WhQoh_Project_SKey!=null)
				data.WhQoh_Project = data.WhQoh_Project_SKey.GetEntity().ID ;


			if (data.Organization == -1 && data.Organization_SKey!=null)
				data.Organization = data.Organization_SKey.GetEntity().ID ;

		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(InvInfoQueryQryDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(InvInfoQueryQryDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
			this.RecordCount = data.RecordCount ;
		
			this.ID = data.ID;

			{
				if (data.WhQoh_Wh <= 0)
					this.WhQoh_Wh = null ;
				else
					this.WhQoh_Wh = new UFIDA.U9.CBO.SCM.Warehouse.Warehouse.EntityKey(data.WhQoh_Wh);
			}

			this.WhQoh_Wh_Name = data.WhQoh_Wh_Name;
			this.Multi_WhQoh_Wh_Name = data.Multi_WhQoh_Wh_Name ;

			this.ItemMaster_Code = data.ItemMaster_Code;

			this.ItemMaster_Name = data.ItemMaster_Name;

			{
				if (data.ItemMaster_MainItemCategory <= 0)
					this.ItemMaster_MainItemCategory = null ;
				else
					this.ItemMaster_MainItemCategory = new UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey(data.ItemMaster_MainItemCategory);
			}

			this.ItemMaster_SPECS = data.ItemMaster_SPECS;

			{
				if (data.WhQoh_LotInfo_LotMaster_EntityID <= 0)
					this.WhQoh_LotInfo_LotMaster_EntityID = null ;
				else
					this.WhQoh_LotInfo_LotMaster_EntityID = new UFIDA.U9.Lot.LotMaster.EntityKey(data.WhQoh_LotInfo_LotMaster_EntityID);
			}

			this.WhQoh_LotInfo_LotCode = data.WhQoh_LotInfo_LotCode;

			this.WhQoh_StoreQty = data.WhQoh_StoreQty;

			this.WhQoh_StoreQtyCU = data.WhQoh_StoreQtyCU;

			this.ResvStQty = data.ResvStQty;

			this.ResvStQtyCU = data.ResvStQtyCU;

			this.AvailableQty = data.AvailableQty;

			this.AvailableQtyCU = data.AvailableQtyCU;

			this.WhQoh_StoreUOM_Round_Precision = data.WhQoh_StoreUOM_Round_Precision;

			this.WhQoh_StoreUOM_Round_RoundType = UFIDA.U9.Base.PropertyTypes.RoundTypeEnum.GetFromValue(data.WhQoh_StoreUOM_Round_RoundType);

			this.WhQoh_StoreUOM_Round_RoundValue = data.WhQoh_StoreUOM_Round_RoundValue;

			this.WhQoh_StoreUOM_Name = data.WhQoh_StoreUOM_Name;
			this.Multi_WhQoh_StoreUOM_Name = data.Multi_WhQoh_StoreUOM_Name ;

			this.WhQoh_CU_Round_Precision = data.WhQoh_CU_Round_Precision;

			this.WhQoh_CU_Round_RoundValue = data.WhQoh_CU_Round_RoundValue;

			this.WhQoh_CU_Name = data.WhQoh_CU_Name;
			this.Multi_WhQoh_CU_Name = data.Multi_WhQoh_CU_Name ;

			this.PackageNum = data.PackageNum;

			this.WholesalePrice = data.WholesalePrice;

			this.MeterPrice = data.MeterPrice;

			this.ItemMaster_InventoryInfo_InventoryMaxLimitQty = data.ItemMaster_InventoryInfo_InventoryMaxLimitQty;

			this.ItemMaster_InventoryInfo_InventoryMinLimitQty = data.ItemMaster_InventoryInfo_InventoryMinLimitQty;

			this.ItemMaster_InventoryInfo_SafetyStockQty = data.ItemMaster_InventoryInfo_SafetyStockQty;

			this.ItemMaster_MainItemCategory_Name = data.ItemMaster_MainItemCategory_Name;
			this.Multi_ItemMaster_MainItemCategory_Name = data.Multi_ItemMaster_MainItemCategory_Name ;

			this.WhQoh_CU_Round_RoundType = UFIDA.U9.Base.PropertyTypes.RoundTypeEnum.GetFromValue(data.WhQoh_CU_Round_RoundType);

			{
				if (data.WhQoh_Project <= 0)
					this.WhQoh_Project = null ;
				else
					this.WhQoh_Project = new UFIDA.U9.CBO.SCM.ProjectTask.Project.EntityKey(data.WhQoh_Project);
			}

			this.WhQoh_Project_Code = data.WhQoh_Project_Code;

			{
				if (data.Organization <= 0)
					this.Organization = null ;
				else
					this.Organization = new UFIDA.U9.Base.Organization.Organization.EntityKey(data.Organization);
			}

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public InvInfoQueryQryDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public InvInfoQueryQryDTOData ToEntityData(InvInfoQueryQryDTOData data, IDictionary dict){
			if (data == null)
				data = new InvInfoQueryQryDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (InvInfoQueryQryDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			data.ID = this.ID;

			if (this.WhQoh_Wh!=null)
			{
				data.WhQoh_Wh = this.WhQoh_Wh.ID;

			}

			data.WhQoh_Wh_Name  = this.WhQoh_Wh_Name;
			data.Multi_WhQoh_Wh_Name  = this.Multi_WhQoh_Wh_Name;

			data.ItemMaster_Code = this.ItemMaster_Code;

			data.ItemMaster_Name = this.ItemMaster_Name;

			if (this.ItemMaster_MainItemCategory!=null)
			{
				data.ItemMaster_MainItemCategory = this.ItemMaster_MainItemCategory.ID;

			}

			data.ItemMaster_SPECS = this.ItemMaster_SPECS;

			if (this.WhQoh_LotInfo_LotMaster_EntityID!=null)
			{
				data.WhQoh_LotInfo_LotMaster_EntityID = this.WhQoh_LotInfo_LotMaster_EntityID.ID;

			}

			data.WhQoh_LotInfo_LotCode = this.WhQoh_LotInfo_LotCode;

			data.WhQoh_StoreQty = this.WhQoh_StoreQty;

			data.WhQoh_StoreQtyCU = this.WhQoh_StoreQtyCU;

			data.ResvStQty = this.ResvStQty;

			data.ResvStQtyCU = this.ResvStQtyCU;

			data.AvailableQty = this.AvailableQty;

			data.AvailableQtyCU = this.AvailableQtyCU;

			data.WhQoh_StoreUOM_Round_Precision = this.WhQoh_StoreUOM_Round_Precision;

			if (this.WhQoh_StoreUOM_Round_RoundType!=null)
			{
				data.WhQoh_StoreUOM_Round_RoundType = this.WhQoh_StoreUOM_Round_RoundType.Value;
			}

			data.WhQoh_StoreUOM_Round_RoundValue = this.WhQoh_StoreUOM_Round_RoundValue;

			data.WhQoh_StoreUOM_Name  = this.WhQoh_StoreUOM_Name;
			data.Multi_WhQoh_StoreUOM_Name  = this.Multi_WhQoh_StoreUOM_Name;

			data.WhQoh_CU_Round_Precision = this.WhQoh_CU_Round_Precision;

			data.WhQoh_CU_Round_RoundValue = this.WhQoh_CU_Round_RoundValue;

			data.WhQoh_CU_Name  = this.WhQoh_CU_Name;
			data.Multi_WhQoh_CU_Name  = this.Multi_WhQoh_CU_Name;

			data.PackageNum = this.PackageNum;

			data.WholesalePrice = this.WholesalePrice;

			data.MeterPrice = this.MeterPrice;

			data.ItemMaster_InventoryInfo_InventoryMaxLimitQty = this.ItemMaster_InventoryInfo_InventoryMaxLimitQty;

			data.ItemMaster_InventoryInfo_InventoryMinLimitQty = this.ItemMaster_InventoryInfo_InventoryMinLimitQty;

			data.ItemMaster_InventoryInfo_SafetyStockQty = this.ItemMaster_InventoryInfo_SafetyStockQty;

			data.ItemMaster_MainItemCategory_Name  = this.ItemMaster_MainItemCategory_Name;
			data.Multi_ItemMaster_MainItemCategory_Name  = this.Multi_ItemMaster_MainItemCategory_Name;

			if (this.WhQoh_CU_Round_RoundType!=null)
			{
				data.WhQoh_CU_Round_RoundType = this.WhQoh_CU_Round_RoundType.Value;
			}

			if (this.WhQoh_Project!=null)
			{
				data.WhQoh_Project = this.WhQoh_Project.ID;

			}

			data.WhQoh_Project_Code = this.WhQoh_Project_Code;

			if (this.Organization!=null)
			{
				data.Organization = this.Organization.ID;

			}

			return data ;
		}

		#endregion	
	}	
	
}