namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP
{
    using PublicDataTransObj;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.CBO.Pub.Controller;
    using UFIDA.U9.ISV.MiscShipISV;
    using UFIDA.U9.ISV.MiscShipISV.Proxy;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;

	/// <summary>
	/// MiscTranOutProcessBP partial 
	/// </summary>	
	public partial class MiscTranOutProcessBP 
	{	
		internal BaseStrategy Select()
		{
			return new MiscTranOutProcessBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class MiscTranOutProcessBPImpementStrategy : BaseStrategy
	{
		public MiscTranOutProcessBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			MiscTranOutProcessBP bpObj = (MiscTranOutProcessBP)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}
        //#region 生成杂发单
        //private PublicReturnDTO CreateMiscShipMent(List<IC_MiscShipmentDTOData> callERPApiInputParamLst)
        //{
        //    PublicReturnDTO pubResult = new PublicReturnDTO();
        //    List<CommonArchiveDataDTOData> apiRtnLst = new List<CommonArchiveDataDTOData>();
        //    #region 调用标准产品API进行推单处理
        //    try
        //    {
        //        CommonCreateMiscShipProxy createMiscShipProxy = new CommonCreateMiscShipProxy();
        //        createMiscShipProxy.TargetOrgName = null;
        //        createMiscShipProxy.MiscShipmentDTOList = new List<IC_MiscShipmentDTOData>();
        //        createMiscShipProxy.MiscShipmentDTOList = callERPApiInputParamLst;
        //        apiRtnLst = createMiscShipProxy.Do();
        //        if (apiRtnLst.Count == 0) throw new Exception("未查询到数据!");
        //    }
        //    catch (Exception ex)
        //    {
        //        pubResult.Flag = false;
        //        pubResult.Message = "生成杂发单失败：" + ex.Message;
        //    }
        //    // 审核杂发单
        //    try
        //    {
        //        CommonApproveMiscShipSVProxy approveMiscShipSVProxy = new CommonApproveMiscShipSVProxy();
        //        approveMiscShipSVProxy.MiscShipmentKeyList = apiRtnLst;
        //        approveMiscShipSVProxy.Do();
        //    }
        //    catch (Exception e)
        //    {
        //        //删除杂发单
        //        //CommonDeleteMiscShipProxy deleteMiscShip = new CommonDeleteMiscShipProxy();
        //        //deleteMiscShip.MiscShipmentKeyList = apiRtnLst;
        //        //deleteMiscShip.Do();
        //        throw e;
        //    }
        //    #endregion
        //    return pubResult;
        //}

        //private string CreateMiscShipMentBX(object obj)
        //{
        //    #region 调用标准产品API进行推单处理;
        //    try
        //    {
        //        List<IC_MiscShipmentDTOData> callERPApiInputParamLst = obj as List<IC_MiscShipmentDTOData>;

        //        UFIDA.U9.TH.CreateMSBP.Proxy.CreateMSProxy proxy = new CreateMSBP.Proxy.CreateMSProxy();
        //        proxy.InfoDTODataList = callERPApiInputParamLst;
        //        proxy.Do();
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    return "";
        //    #endregion
        //}
        //private List<IC_MiscShipmentDTOData> CheckMS(object obj)
        //{
        //    //审核杂发单
        //    try
        //    {
        //        List<CommonArchiveDataDTOData> apiRtnLst = obj as List<CommonArchiveDataDTOData>;
        //        CommonApproveMiscShipSVProxy approveMiscShipSVProxy = new CommonApproveMiscShipSVProxy();
        //        approveMiscShipSVProxy.MiscShipmentKeyList = apiRtnLst;
        //        return approveMiscShipSVProxy.Do();

        //    }
        //    catch (Exception e)
        //    {
        //        //删除杂发单
        //        //CommonDeleteMiscShipProxy deleteMiscShip = new CommonDeleteMiscShipProxy();
        //        //deleteMiscShip.MiscShipmentKeyList = apiRtnLst;
        //        //deleteMiscShip.Do();
        //        throw e;
        //    }
        //}

        //#region 暂时不用
        ///// <summary>
        ///// 杂发单头信息
        ///// </summary>
        ///// <returns></returns>
        //private IC_MiscShipmentDTOData GetHeadInfoData(Cust_Xmjl_MO_BomMain bomMain, MO.MO.MO mo)
        //{
        //    #region 做成标准产品API入口参数

        //    //List<IC_MiscShipmentDTOData> callERPApiInputParamLst = new List<IC_MiscShipmentDTOData>();
        //    IC_MiscShipmentDTOData inputMiscShipmentDTO;


        //    #region 做成杂发单表头

        //    //sourceDocType = miscShipDTO.SourceDocType.Name;
        //    //sourceDocID = miscShipDTO.SourceDocID;

        //    inputMiscShipmentDTO = new IC_MiscShipmentDTOData();
        //    //组织
        //    inputMiscShipmentDTO.Org = new CommonArchiveDataDTOData(Base.Context.LoginOrg.ID, Base.Context.LoginOrg.Code, Base.Context.LoginOrg.Name);
        //    //业务日期
        //    inputMiscShipmentDTO.BusinessDate = DateTime.Today;
        //    //inputMiscShipmentDTO.DescFlexField = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData();
        //    //单据类型
        //    //MiscShipDocType miscShipDocType = MiscShipDocType.Finder.FindByID(1000904300300201);
        //    string DtCode = "ZF02";

        //    if (mo == null || mo.DocState.Value == 3) //完工
        //    {
        //        DtCode = "ZF99";
        //    }

        //    MiscShipDocType miscShipDocType = MiscShipDocType.Finder.Find(string.Format(" Org={0} and Code='{1}' and Effective.IsEffective=1", Base.Context.LoginOrg.ID, DtCode));
        //    inputMiscShipmentDTO.MiscShipDocType = new CommonArchiveDataDTOData(miscShipDocType.ID, miscShipDocType.Code, miscShipDocType.Name);
        //    //inputMiscShipmentDTO.DescFlexField = GetTargetDocDescFlexSegmentsData(subItemIssueHead, subItemIssueHead.DescFlexField, SubItemIssue.EntityRes.BE_FullName);
        //    //inputMiscShipmentDTO.DescFlexField.PrivateDescSeg1 = subItemIssueHead.DocNo;
        //    //inputMiscShipmentDTO.DescFlexField.PrivateDescSeg30 = subItemIssueID.ToString();
        //    // 数据状态
        //    inputMiscShipmentDTO.SysState = UFSoft.UBF.PL.Engine.ObjectState.Inserted;
        //    // 描述
        //    inputMiscShipmentDTO.Memo = "本单据由缺件发料主表[" + bomMain.DocNo + "]自动生成";
        //    inputMiscShipmentDTO.DescFlexField = new Base.FlexField.DescFlexField.DescFlexSegmentsData();
        //    //合同号
        //    inputMiscShipmentDTO.DescFlexField.PrivateDescSeg3 = bomMain.ContractNo;
        //    //车型
        //    inputMiscShipmentDTO.DescFlexField.PrivateDescSeg2 = bomMain.CarType;
        //    #endregion
        //    return inputMiscShipmentDTO;


        //    #endregion
        //}
        ///// <summary>
        ///// 杂发单行信息
        ///// </summary>
        ///// <param name="bomHead"></param>
        ///// <returns></returns>
        //private IC_MiscShipmentLDTOData GetLineInfoData(Cust_Xmjl_MO_BomHead bomHead, int msRowNo, decimal Qty, Lot.LotMaster lotMaster, WhQoh whQoh, MO.MO.MO mo)
        //{
        //    IC_MiscShipmentLDTOData inputMiscShipmentLineDTO;
        //    inputMiscShipmentLineDTO = new IC_MiscShipmentLDTOData();

        //    //SubItemIssueLine subItemIssueLine = SubItemIssueLine.Finder.FindByID(dto.SubItemIssueLineID);
        //    inputMiscShipmentLineDTO.ItemInfo = new UFIDA.U9.CBO.SCM.Item.ItemInfoData();
        //    inputMiscShipmentLineDTO.ItemInfo.ItemID = bomHead.Item.ID;
        //    inputMiscShipmentLineDTO.ItemInfo.ItemCode = bomHead.Item.Code;
        //    inputMiscShipmentLineDTO.ItemInfo.ItemName = bomHead.Item.Name;
        //    if (bomHead.Supplier != null)
        //    {
        //        inputMiscShipmentLineDTO.SupplierInfo = new CBO.SCM.Supplier.SupplierMISCInfoData();
        //        inputMiscShipmentLineDTO.SupplierInfo.Supplier = bomHead.Supplier.ID;
        //        inputMiscShipmentLineDTO.SupplierInfo.Code = bomHead.Supplier.Code;
        //        inputMiscShipmentLineDTO.SupplierInfo.Name = bomHead.Supplier.Name;
        //        inputMiscShipmentLineDTO.SupplierInfo.ShortName = bomHead.Supplier.ShortName;
        //    }
        //    else if (whQoh.SupplierInfo != null && whQoh.SupplierInfo.Supplier != null)
        //    {
        //        inputMiscShipmentLineDTO.SupplierInfo = new CBO.SCM.Supplier.SupplierMISCInfoData();
        //        inputMiscShipmentLineDTO.SupplierInfo.Supplier = whQoh.SupplierInfo.Supplier.ID;
        //        inputMiscShipmentLineDTO.SupplierInfo.Code = whQoh.SupplierInfo.Supplier.Code;
        //        inputMiscShipmentLineDTO.SupplierInfo.Name = whQoh.SupplierInfo.Supplier.Name;
        //        inputMiscShipmentLineDTO.SupplierInfo.ShortName = whQoh.SupplierInfo.Supplier.ShortName;
        //    }
        //    if (lotMaster != null)
        //    {
        //        inputMiscShipmentLineDTO.LotInfo = new UFIDA.U9.CBO.SCM.PropertyTypes.LotInfoData();
        //        inputMiscShipmentLineDTO.LotInfo.LotMaster = new UFIDA.U9.Base.PropertyTypes.BizEntityKeyData();
        //        inputMiscShipmentLineDTO.LotInfo.LotMaster.EntityID = lotMaster.ID;
        //        inputMiscShipmentLineDTO.LotInfo.LotMaster.EntityType = lotMaster.Key.EntityType;
        //        inputMiscShipmentLineDTO.LotInfo.LotCode = lotMaster.LotCode;
        //    }
        //    inputMiscShipmentLineDTO.StoreType = 4;

        //    inputMiscShipmentLineDTO.DocLineNo = msRowNo;
        //    //inputMiscShipmentLineDTO.BOMLineNO = msRowNo.ToString();

        //    inputMiscShipmentLineDTO.StoreUOMQty = Qty;
        //    inputMiscShipmentLineDTO.Memo = bomHead.ID.ToString();
        //    ////单价
        //    //inputMiscShipmentLineDTO.CostPrice = subItemIssueLine.Univalence;
        //    //存储地点
        //    if (bomHead.WareHouse != null)
        //        inputMiscShipmentLineDTO.Wh = new CommonArchiveDataDTOData(bomHead.WareHouse.ID, bomHead.WareHouse.Code, bomHead.WareHouse.Name);
        //    //受益组织
        //    inputMiscShipmentLineDTO.BenefitOrg = Base.Context.LoginOrg.ID;
        //    //受益货主组织
        //    inputMiscShipmentLineDTO.BenefitOwnerOrg = Base.Context.LoginOrg.ID;
        //    //受益存储地点
        //    if (bomHead.WareHouse != null)
        //        inputMiscShipmentLineDTO.BenefitWh = bomHead.WareHouse.ID;


        //    if (mo != null && mo.DocState.Value != 3) //完工
        //    {
        //        //生成相关
        //        inputMiscShipmentLineDTO.IsMFG = true;
        //        //生产订单号
        //        inputMiscShipmentLineDTO.MoDocNo = bomHead.Cust_Xmjl_MO_BomMain.ManufactureNo.Code;
        //        inputMiscShipmentLineDTO.MoDocEntity = mo.ID;
        //    }
        //    //else
        //    //{
        //    //    inputMiscShipmentLineDTO.DescFlexSegments = new Base.FlexField.DescFlexField.DescFlexSegmentsData();
        //    //    inputMiscShipmentLineDTO.DescFlexSegments.PrivateDescSeg1 = bomHead.Cust_Xmjl_MO_BomMain.ManufactureNo.Code;       
        //    //}
        //    inputMiscShipmentLineDTO.DescFlexSegments = new Base.FlexField.DescFlexField.DescFlexSegmentsData();
        //    inputMiscShipmentLineDTO.DescFlexSegments.PrivateDescSeg1 = bomHead.Cust_Xmjl_MO_BomMain.ManufactureNo.Code;

        //    //inputMiscShipmentLineDTO.Project
        //    //受益部门
        //    //if (subItemIssueHead.FetchDepartment != null)
        //    //    inputMiscShipmentLineDTO.BenefitDept = new CommonArchiveDataDTOData(subItemIssueHead.FetchDepartment.ID, subItemIssueHead.FetchDepartment.Code, subItemIssueHead.FetchDepartment.Name);
        //    //库管员
        //    //if (subItemIssueHead.WhMan != null)
        //    //    inputMiscShipmentLineDTO.WhMan = new CommonArchiveDataDTOData(subItemIssueHead.WhMan.ID, subItemIssueHead.WhMan.Code, subItemIssueHead.WhMan.Name);

        //    //弹性域
        //    //inputMiscShipmentLineDTO.DescFlexSegments = GetTargetDocDescFlexSegmentsData(subItemIssueLine, subItemIssueLine.DescFlexField, SubItemIssueLine.EntityRes.BE_FullName);
        //    //金额
        //    //inputMiscShipmentLineDTO.DescFlexSegments = new DescFlexSegmentsData();
        //    //inputMiscShipmentLineDTO.DescFlexSegments.PrivateDescSeg1 = subItemIssueLine.Money.ToString();

        //    return inputMiscShipmentLineDTO;
        //}
        //#endregion

        ///// <summary>
        ///// 杂发单头信息
        ///// </summary>
        ///// <returns></returns>
        //private IC_MiscShipmentDTOData GetHeadInfoData(string bomMainDocNo, string DtCode, string ContractNo, string CarType)
        //{
        //    #region 做成标准产品API入口参数

        //    //List<IC_MiscShipmentDTOData> callERPApiInputParamLst = new List<IC_MiscShipmentDTOData>();
        //    IC_MiscShipmentDTOData inputMiscShipmentDTO;


        //    #region 做成杂发单表头

        //    //sourceDocType = miscShipDTO.SourceDocType.Name;
        //    //sourceDocID = miscShipDTO.SourceDocID;

        //    inputMiscShipmentDTO = new IC_MiscShipmentDTOData();
        //    //组织
        //    inputMiscShipmentDTO.Org = new CommonArchiveDataDTOData(Base.Context.LoginOrg.ID, Base.Context.LoginOrg.Code, Base.Context.LoginOrg.Name);
        //    //业务日期
        //    inputMiscShipmentDTO.BusinessDate = DateTime.Today;
        //    //inputMiscShipmentDTO.DescFlexField = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegmentsData();
        //    //单据类型
        //    //MiscShipDocType miscShipDocType = MiscShipDocType.Finder.FindByID(1000904300300201);


        //    MiscShipDocType miscShipDocType = MiscShipDocType.Finder.Find(string.Format(" Org={0} and Code='{1}' and Effective.IsEffective=1", Base.Context.LoginOrg.ID, DtCode));
        //    inputMiscShipmentDTO.MiscShipDocType = new CommonArchiveDataDTOData(miscShipDocType.ID, miscShipDocType.Code, miscShipDocType.Name);
        //    //inputMiscShipmentDTO.DescFlexField = GetTargetDocDescFlexSegmentsData(subItemIssueHead, subItemIssueHead.DescFlexField, SubItemIssue.EntityRes.BE_FullName);
        //    //inputMiscShipmentDTO.DescFlexField.PrivateDescSeg1 = subItemIssueHead.DocNo;
        //    //inputMiscShipmentDTO.DescFlexField.PrivateDescSeg30 = subItemIssueID.ToString();
        //    // 数据状态
        //    inputMiscShipmentDTO.SysState = UFSoft.UBF.PL.Engine.ObjectState.Inserted;
        //    // 描述
        //    inputMiscShipmentDTO.Memo = "本单据由缺件发料主表[" + bomMainDocNo + "]自动生成";
        //    inputMiscShipmentDTO.DescFlexField = new Base.FlexField.DescFlexField.DescFlexSegmentsData();
        //    //合同号
        //    inputMiscShipmentDTO.DescFlexField.PrivateDescSeg3 = ContractNo;
        //    //车型
        //    inputMiscShipmentDTO.DescFlexField.PrivateDescSeg2 = CarType;
        //    #endregion
        //    return inputMiscShipmentDTO;


        //    #endregion
        //}
        ///// <summary>
        ///// 杂发单行信息
        ///// </summary>
        ///// <param name="bomHead"></param>
        ///// <returns></returns>
        //private IC_MiscShipmentLDTOData GetLineInfoData(string BeadID, long ItemID, string ItemCode, string ItemName,
        //    long Supplier, string SupplierCode, string SupplierName, string SupplierShortName,
        //    long WareHouse, string WareHouseCode, string WareHouseName,
        //    long MoID, string MoDocNo, int MoDocState,
        //    int msRowNo, decimal Qty, Lot.LotMaster lotMaster, WhQoh whQoh, string DescFlexField_PrivateDescSeg3)
        //{
        //    IC_MiscShipmentLDTOData inputMiscShipmentLineDTO;
        //    inputMiscShipmentLineDTO = new IC_MiscShipmentLDTOData();

        //    //SubItemIssueLine subItemIssueLine = SubItemIssueLine.Finder.FindByID(dto.SubItemIssueLineID);
        //    inputMiscShipmentLineDTO.ItemInfo = new UFIDA.U9.CBO.SCM.Item.ItemInfoData();
        //    inputMiscShipmentLineDTO.ItemInfo.ItemID = ItemID;
        //    inputMiscShipmentLineDTO.ItemInfo.ItemCode = ItemCode;
        //    inputMiscShipmentLineDTO.ItemInfo.ItemName = ItemName;
        //    if (Supplier > 0)
        //    {
        //        inputMiscShipmentLineDTO.SupplierInfo = new CBO.SCM.Supplier.SupplierMISCInfoData();
        //        inputMiscShipmentLineDTO.SupplierInfo.Supplier = Supplier;
        //        inputMiscShipmentLineDTO.SupplierInfo.Code = SupplierCode;
        //        inputMiscShipmentLineDTO.SupplierInfo.Name = SupplierName;
        //        inputMiscShipmentLineDTO.SupplierInfo.ShortName = SupplierShortName;
        //    }
        //    else if (whQoh.SupplierInfo != null && whQoh.SupplierInfo.Supplier != null)
        //    {
        //        inputMiscShipmentLineDTO.SupplierInfo = new CBO.SCM.Supplier.SupplierMISCInfoData();
        //        inputMiscShipmentLineDTO.SupplierInfo.Supplier = whQoh.SupplierInfo.Supplier.ID;
        //        inputMiscShipmentLineDTO.SupplierInfo.Code = whQoh.SupplierInfo.Supplier.Code;
        //        inputMiscShipmentLineDTO.SupplierInfo.Name = whQoh.SupplierInfo.Supplier.Name;
        //        inputMiscShipmentLineDTO.SupplierInfo.ShortName = whQoh.SupplierInfo.Supplier.ShortName;
        //    }
        //    if (lotMaster != null)
        //    {
        //        inputMiscShipmentLineDTO.LotInfo = new UFIDA.U9.CBO.SCM.PropertyTypes.LotInfoData();
        //        inputMiscShipmentLineDTO.LotInfo.LotMaster = new UFIDA.U9.Base.PropertyTypes.BizEntityKeyData();
        //        inputMiscShipmentLineDTO.LotInfo.LotMaster.EntityID = lotMaster.ID;
        //        inputMiscShipmentLineDTO.LotInfo.LotMaster.EntityType = lotMaster.Key.EntityType;
        //        inputMiscShipmentLineDTO.LotInfo.LotCode = lotMaster.LotCode;
        //    }
        //    inputMiscShipmentLineDTO.StoreType = 4;

        //    inputMiscShipmentLineDTO.DocLineNo = msRowNo;
        //    //inputMiscShipmentLineDTO.BOMLineNO = msRowNo.ToString();

        //    inputMiscShipmentLineDTO.StoreUOMQty = Qty;
        //    inputMiscShipmentLineDTO.Memo = BeadID;
        //    ////单价
        //    //inputMiscShipmentLineDTO.CostPrice = subItemIssueLine.Univalence;
        //    //存储地点
        //    if (WareHouse > 0)
        //    {
        //        inputMiscShipmentLineDTO.Wh = new CommonArchiveDataDTOData(WareHouse, WareHouseCode, WareHouseName);
        //        //受益存储地点
        //        inputMiscShipmentLineDTO.BenefitWh = WareHouse;
        //    }
        //    //受益组织
        //    inputMiscShipmentLineDTO.BenefitOrg = Base.Context.LoginOrg.ID;
        //    //受益货主组织
        //    inputMiscShipmentLineDTO.BenefitOwnerOrg = Base.Context.LoginOrg.ID;


        //    if (MoDocNo != "" && MoDocState != 3) //完工
        //    {
        //        //生成相关
        //        inputMiscShipmentLineDTO.IsMFG = true;
        //        //生产订单号
        //        inputMiscShipmentLineDTO.MoDocNo = MoDocNo;
        //        inputMiscShipmentLineDTO.MoDocEntity = MoID;
        //    }
        //    //else
        //    //{
        //    //    inputMiscShipmentLineDTO.DescFlexSegments = new Base.FlexField.DescFlexField.DescFlexSegmentsData();
        //    //    inputMiscShipmentLineDTO.DescFlexSegments.PrivateDescSeg1 = bomHead.Cust_Xmjl_MO_BomMain.ManufactureNo.Code;       
        //    //}
        //    inputMiscShipmentLineDTO.DescFlexSegments = new Base.FlexField.DescFlexField.DescFlexSegmentsData();
        //    inputMiscShipmentLineDTO.DescFlexSegments.PrivateDescSeg1 = MoDocNo;
        //    inputMiscShipmentLineDTO.DescFlexSegments.PrivateDescSeg2 = DescFlexField_PrivateDescSeg3;

        //    //inputMiscShipmentLineDTO.Project
        //    //受益部门
        //    //if (subItemIssueHead.FetchDepartment != null)
        //    //    inputMiscShipmentLineDTO.BenefitDept = new CommonArchiveDataDTOData(subItemIssueHead.FetchDepartment.ID, subItemIssueHead.FetchDepartment.Code, subItemIssueHead.FetchDepartment.Name);
        //    //库管员
        //    //if (subItemIssueHead.WhMan != null)
        //    //    inputMiscShipmentLineDTO.WhMan = new CommonArchiveDataDTOData(subItemIssueHead.WhMan.ID, subItemIssueHead.WhMan.Code, subItemIssueHead.WhMan.Name);

        //    //弹性域
        //    //inputMiscShipmentLineDTO.DescFlexSegments = GetTargetDocDescFlexSegmentsData(subItemIssueLine, subItemIssueLine.DescFlexField, SubItemIssueLine.EntityRes.BE_FullName);
        //    //金额
        //    //inputMiscShipmentLineDTO.DescFlexSegments = new DescFlexSegmentsData();
        //    //inputMiscShipmentLineDTO.DescFlexSegments.PrivateDescSeg1 = subItemIssueLine.Money.ToString();

        //    return inputMiscShipmentLineDTO;
        //}
        //#endregion
	}

	#endregion
	
	
}