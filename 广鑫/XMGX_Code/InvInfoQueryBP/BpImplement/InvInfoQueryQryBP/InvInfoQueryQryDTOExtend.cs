



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.FJGX.InvInfoQueryQryBP {

	public partial class InvInfoQueryQryDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public InvInfoQueryQryDTO(  System.Int64 iD  , UFIDA.U9.CBO.SCM.Warehouse.Warehouse.EntityKey whQoh_Wh  , System.String whQoh_Wh_Name  , System.String itemMaster_Code  , System.String itemMaster_Name  , UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey itemMaster_MainItemCategory  , System.String itemMaster_SPECS  , UFIDA.U9.Lot.LotMaster.EntityKey whQoh_LotInfo_LotMaster_EntityID  , System.String whQoh_LotInfo_LotCode  , System.Decimal whQoh_StoreQty  , System.Decimal whQoh_StoreQtyCU  , System.Decimal resvStQty  , System.Decimal resvStQtyCU  , System.Decimal availableQty  , System.Decimal availableQtyCU  , System.Int32 whQoh_StoreUOM_Round_Precision  , UFIDA.U9.Base.PropertyTypes.RoundTypeEnum whQoh_StoreUOM_Round_RoundType  , System.Int32 whQoh_StoreUOM_Round_RoundValue  , System.String whQoh_StoreUOM_Name  , System.Int32 whQoh_CU_Round_Precision  , System.Int32 whQoh_CU_Round_RoundValue  , System.String whQoh_CU_Name  , System.Decimal packageNum  , System.Decimal wholesalePrice  , System.Decimal meterPrice  , System.Decimal itemMaster_InventoryInfo_InventoryMaxLimitQty  , System.Decimal itemMaster_InventoryInfo_InventoryMinLimitQty  , System.Decimal itemMaster_InventoryInfo_SafetyStockQty  , System.String itemMaster_MainItemCategory_Name  , UFIDA.U9.Base.PropertyTypes.RoundTypeEnum whQoh_CU_Round_RoundType  , UFIDA.U9.CBO.SCM.ProjectTask.Project.EntityKey whQoh_Project  , System.String whQoh_Project_Code  , UFIDA.U9.Base.Organization.Organization.EntityKey organization  )
		{
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
		#endregion	






		#region Model Methods
		#endregion

	}
}
