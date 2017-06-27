namespace UFIDA.U9.Cust.XMJL.APBillSV
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;

    using UFIDA.U9.PM.Rcv.Proxy;
    using UFIDA.U9.CBO.FI_SCM.DTOs;
    using UFIDA.U9.Base.Currency;
    using UFIDA.U9.CBO.SCM.Enums;
    using UFIDA.U9.Base.Organization.Proxy;
    using UFIDA.U9.CBO.FI.DTOs;
    using UFIDA.U9.AP.APBill;
    using UFIDA.U9.Base.PropertyTypes;
    using UFIDA.U9.GL.GLReportSrv.Proxy;
    using System.Data;
    using UFIDA.U9.PM.Rcv;
    using UFSoft.UBF.Sys.Database;
    using UFSoft.UBF.PL;
    using UFIDA.U9.CBO.HR.Operator;
    using UFIDA.U9.CBO.HR.Department;


    /// <summary>
    /// SumAccrueDocToAPBillSV partial 
    /// </summary>	
    public partial class SumAccrueDocToAPBillSV
    {
        internal BaseStrategy Select()
        {
            return new SumAccrueDocToAPBillSVImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class SumAccrueDocToAPBillSVImpementStrategy : BaseStrategy
    {

        public SumAccrueDocToAPBillSVImpementStrategy() { }

        public override object Do(object obj)
        {
            CommonResultDTO resultDTO = new CommonResultDTO();

            SumAccrueDocToAPBillSV bpObj = (SumAccrueDocToAPBillSV)obj;
            var data = CreateAPByItem(bpObj);
            if (!(data != null && data.Count > 0))
            {
                resultDTO.Success = false;
                resultDTO.Message = "生单失败";
                return resultDTO;
            }

            resultDTO.Success = true;
            resultDTO.Message = "";
            resultDTO.ResultObj = data[0];

            return resultDTO;
        }
        private List<long> CreateAPByItem(SumAccrueDocToAPBillSV bpObj)
        {
            //按rcv查询立账需要的数据
            StringBuilder sb = new StringBuilder();
            foreach (RCVLineInfoDTO dto in bpObj.RCVLineInfoDTO)
            {
                sb.Append(dto.RCVLine.ToString() + ",");
            }
            string str = "";
            if (sb.ToString().Length > 0)
            {
                str = sb.ToString().Remove(sb.ToString().Length - 1, 1);
            }

            string sql = @"select  A.[ID] as [ID], '收货行' as [DSNAME], 'UFIDA.U9.PM.Rcv.RcvLine' as [DSKEY], 0 as [AccrueDocType], A.[ConfirmAccording] as [AccrueBy], A1.[Code] as [AccrueBy_Code], A2.[Name] as [AccrueBy_Name], A.[AccountOrg] as [AccountOrg], A3.[Code] as [AccountOrg_Code],
A4.[Name] as [AccountOrg_Name], A.[CurrentOrg] as [SrcOrg], A5.[Code] as [SrcOrg_Code], A6.[Name] as [SrcOrg_Name], A.[PurOrg] as [BusinessOrg],
A7.[Code] as [BusinessOrg_Code], A8.[Name] as [BusinessOrg_Name], A9.[BalanceOrg] as [SettleOrg], A10.[Code] as [SettleOrg_Code], A11.[Name] as [SettleOrg_Name], A9.[BizType] as [SrcBusinessType],
0 as [AccrueType], 0 as [Direction], A9.[ID] as [DocHeadID], A9.[DocNo] as [DocNo], A9.[SysVersion] as [HeadSysVersion], A.[ID] as [DocLineID], A.[DocLineNo] as [LineNum], null as [SubLineNum], A.[SysVersion] as [SysVersion],
A9.[BusinessDate] as [BusinessDate], A.[APConfirmDate] as [AccrueDate], A.[PlanArrivedDate] as [PlanArrivedDate], A.[ArrivedTime] as [ArrivedDate], GetDate() as [Maturity], A.[ItemInfo_ItemID] as [Item], A12.[Code] as [Item_Code], A12.[Name] as [Item_Name], A.[ItemInfo_ItemCode] as [ItemCode],
A.[ItemInfo_ItemName] as [ItemName], A12.[Org] as [ItemOrg], A13.[Code] as [ItemOrg_Code], A14.[Name] as [ItemOrg_Name],
A12.[ItemFormAttribute] as [ItemType], A12.[Code1] as [ItemCode1], A12.[Code2] as [ItemCode2], A.[ProcessItem_ItemCode] as [ProcessItemCode], A.[ProcessItem_ItemName] as [ProcessItemName], A.[PriceUOM] as [PriceUOM], A15.[Code] as [PriceUOM_Code], A16.[Name] as [PriceUOM_Name], A.[PriceBaseUOM] as [PriceBaseUOM],
A17.[Code] as [PriceBaseUOM_Code], A18.[Name] as [PriceBaseUOM_Name], A.[PUToPBURate] as [PUToPBURate],
A.[TradeUOM] as [TradeUOM], A19.[Code] as [TradeUOM_Code], A20.[Name] as [TradeUOM_Name], A.[TradeBaseUOM] as [TradeBaseUOM], A21.[Code] as [TradeBaseUOM_Code], A22.[Name] as [TradeBaseUOM_Name], A9.[AC] as [AC], A23.[Code] as [AC_Code], A24.[Name] as [AC_Name], A.[ConfirmSupplier_Supplier] as [AccrueSupplier],
A25.[Code] as [AccrueSupplier_Code], A26.[Name] as [AccrueSupplier_Name], A.[BillToSite_SupplierSite] as [AccrueSupplierSite],
A27.[Code] as [AccrueSupplierSite_Code], A28.[Name] as [AccrueSupplierSite_Name], A.[Payer_Supplier] as [PayerSupplier], A29.[Code] as [PayerSupplier_Code], A30.[Name] as [PayerSupplier_Name], A.[PayerSite_SupplierSite] as [PayerSupplierSite], A31.[Code] as [PayerSupplierSite_Code],
A32.[Name] as [PayerSupplierSite_Name], A.[ShipToSite_SupplierSite] as [ShiptoSupplierSite], A33.[Code] as [ShiptoSupplierSite_Code],
A34.[Name] as [ShiptoSupplierSite_Name], A.[PurDept] as [Department], A35.[Code] as [Department_Code], A36.[Name] as [Department_Name], A.[PurOper] as [Operator], A37.[Code] as [Operator_Code], A38.[Name] as [Operator_Name], A.[Project] as [Project], A39.[Code] as [Project_Code],
A40.[Name] as [Project_Name], A.[Task] as [Task], A41.[Code] as [Task_Code], A42.[Name] as [Task_Name], A.[ConfirmTerm] as [ConfirmTerm],
A43.[Code] as [ConfirmTerm_Code], A44.[Name] as [ConfirmTerm_Name], A.[PaymentTerm] as [PaymentTerm], A45.[Code] as [PaymentTerm_Code], A46.[Name] as [PaymentTerm_Name], A.[TaxSchedule] as [TaxSchedule], A47.[Code] as [TaxSchedule_Code], A48.[Name] as [TaxSchedule_Name],
A49.[Memo] as [Memo], A.[SrcPurC_SrcDocNo] as [PCNo], A.[SrcPurC_SrcDoc_EntityID] as [PC_ID], A.[SrcDoc_SrcDocOrg] as [PCOrg], A50.[Code] as [PCOrg_Code],
A51.[Name] as [PCOrg_Name], A.[KITRcvMode] as [KitRcvMode], A.[SrcDoc_SrcDocNo] as [PODocNo], A.[SrcDoc_SrcDoc_EntityID] as [PO_ID], A.[SrcDoc_SrcDoc_EntityType] as [PO_EntityType], A.[SrcDoc_SrcDocOrg] as [POOrg], A50.[Code] as [POOrg_Code], A51.[Name] as [POOrg_Name],
A.[SrcDoc_SrcDocSubLine_EntityID] as [POShipLine_ID], A9.[ReceivementType] as [ReceivementType], null as [TransInDate], null as [Reason], null as [TransforInValue],
null as [TransOutDocNo], null as [TransOutDoc], '' as [TransOutDoc_Code], '' as [TransOutDoc_Name], null as [OutAssetOrg], '' as [OutAssetOrg_Code], '' as [OutAssetOrg_Name], null as [OutOwnerOrg], '' as [OutOwnerOrg_Code], '' as [OutOwnerOrg_Name], 0 as [FeeItemCount], null as [PaymentType],
0 as [IsChooseFee], 0 as [PurchaseFeeType], '' as [PurchaseFeeType_Code], '' as [PurchaseFeeType_Name], 0 as [DocType], '' as [DocType_Code],
'' as [DocType_Name], 0 as [BusinessType], 0 as [IsTaxPrice], 0.0 as [NoneTaxPrice], 0.0 as [Price], 0.0 as [MatchPUAmount], 0.0 as [MatchTUAmount], 0.0 as [PUAmount], 0.0 as [TUAmount], 0.0 as [TBUAmount], 0.0 as [NoneTaxMoney], 0.0 as [TaxMoney], 0.0 as [Money], 0.0 as [TotalFee], A.[EvaluationPricePU] as [EstimatePriceMnyAC],
0.0 as [MatchNoneTaxMoney], 0 as [IsCanMod_Money], 0 as [IsCanMod_AccrueAmount], 0 as [IsCanMod_MatchAmount], 0.0 as [IsCanMod_TaxSchedule],
0 as [CurrentNoneTaxPrice], 0.0 as [CurrentPrice], 0.0 as [CurrentPUAmount], 0.0 as [CurrentTUAmount], 0.0 as [CurrentTBUAmount], 0.0 as [CurrentMatchAmount], 0.0 as [CurrentNoneTaxMoney],
0.0 as [CurrentTaxMoney], 0.0 as [CurrentMoney], A15.[Round_Precision] as [PriceUOM_Round_Precision], A15.[Round_RoundType] as [PriceUOM_Round_RoundType], A15.[Round_RoundValue] as [PriceUOM_Round_RoundValue], A19.[Round_Precision] as [TradeUOM_Round_Precision],
A19.[Round_RoundType] as [TradeUOM_Round_RoundType],
A19.[Round_RoundValue] as [TradeUOM_Round_RoundValue], A21.[Round_Precision] as [TradeBaseUOM_Round_Precision], A21.[Round_RoundType] as [TradeBaseUOM_Round_RoundType], A21.[Round_RoundValue] as [TradeBaseUOM_Round_RoundValue], A23.[Symbol] as [AC_Symbol], A23.[PriceRound_Precision] as [AC_PriceRound_Precision],
A23.[PriceRound_RoundType] as [AC_PriceRound_RoundType],
A23.[PriceRound_RoundValue] as [AC_PriceRound_RoundValue], A23.[MoneyRound_Precision] as [AC_MoneyRound_Precision], A23.[MoneyRound_RoundType] as [AC_MoneyRound_RoundType], A23.[MoneyRound_RoundValue] as [AC_MoneyRound_RoundValue], 0 as [_ContinueTag_], 1 as [_DSSequence_], 1705769640 as [_DSID_],
null as [TransforInValue_Symbol], null as [TransforInValue_Precision], null as [TransforInValue_RoundType], null as [TransforInValue_RoundValue],
A23.[Symbol] as [NoneTaxPrice_Symbol], A23.[PriceRound_Precision] as [NoneTaxPrice_Precision], A23.[PriceRound_RoundType] as [NoneTaxPrice_RoundType], A23.[PriceRound_RoundValue] as [NoneTaxPrice_RoundValue], A23.[Symbol] as [Price_Symbol], A23.[PriceRound_Precision] as [Price_Precision],
A23.[PriceRound_RoundType] as [Price_RoundType], A23.[PriceRound_RoundValue] as [Price_RoundValue], '' as [MatchPUAmount_Symbol],
A15.[Round_Precision] as [MatchPUAmount_Precision], A15.[Round_RoundType] as [MatchPUAmount_RoundType], A15.[Round_RoundValue] as [MatchPUAmount_RoundValue], '' as [PUAmount_Symbol], A15.[Round_Precision] as [PUAmount_Precision], A15.[Round_RoundType] as [PUAmount_RoundType],
A15.[Round_RoundValue] as [PUAmount_RoundValue], A23.[Symbol] as [NoneTaxMoney_Symbol], A23.[MoneyRound_Precision] as [NoneTaxMoney_Precision],
A23.[MoneyRound_RoundType] as [NoneTaxMoney_RoundType], A23.[MoneyRound_RoundValue] as [NoneTaxMoney_RoundValue], A23.[Symbol] as [TaxMoney_Symbol], A23.[MoneyRound_Precision] as [TaxMoney_Precision], A23.[MoneyRound_RoundType] as [TaxMoney_RoundType], A23.[MoneyRound_RoundValue] as [TaxMoney_RoundValue],
A23.[Symbol] as [Money_Symbol], A23.[MoneyRound_Precision] as [Money_Precision], A23.[MoneyRound_RoundType] as [Money_RoundType],
A23.[MoneyRound_RoundValue] as [Money_RoundValue], A23.[Symbol] as [TotalFee_Symbol], A23.[MoneyRound_Precision] as [TotalFee_Precision], A23.[MoneyRound_RoundType] as [TotalFee_RoundType], A23.[MoneyRound_RoundValue] as [TotalFee_RoundValue], A23.[Symbol] as [EstimatePriceMnyAC_Symbol],
A23.[PriceRound_Precision] as [EstimatePriceMnyAC_Precision], A23.[PriceRound_RoundType] as [EstimatePriceMnyAC_RoundType],
A23.[PriceRound_RoundValue] as [EstimatePriceMnyAC_RoundValue], A23.[Symbol] as [MatchNoneTaxMoney_Symbol], A23.[MoneyRound_Precision] as [MatchNoneTaxMoney_Precision], A23.[MoneyRound_RoundType] as [MatchNoneTaxMoney_RoundType], A23.[MoneyRound_RoundValue] as [MatchNoneTaxMoney_RoundValue],
A23.[Symbol] as [CurrentNoneTaxPrice_Symbol], A23.[PriceRound_Precision] as [CurrentNoneTaxPrice_Precision],
A23.[PriceRound_RoundType] as [CurrentNoneTaxPrice_RoundType], A23.[PriceRound_RoundValue] as [CurrentNoneTaxPrice_RoundValue], A23.[Symbol] as [CurrentPrice_Symbol], A23.[PriceRound_Precision] as [CurrentPrice_Precision], A23.[PriceRound_RoundType] as [CurrentPrice_RoundType],
A23.[PriceRound_RoundValue] as [CurrentPrice_RoundValue], '' as [CurrentPUAmount_Symbol], A15.[Round_Precision] as [CurrentPUAmount_Precision],
A15.[Round_RoundType] as [CurrentPUAmount_RoundType], A15.[Round_RoundValue] as [CurrentPUAmount_RoundValue], '' as [CurrentTUAmount_Symbol], A19.[Round_Precision] as [CurrentTUAmount_Precision], A19.[Round_RoundType] as [CurrentTUAmount_RoundType], A19.[Round_RoundValue] as [CurrentTUAmount_RoundValue], '' as [CurrentMatchAmount_Symbol], A15.[Round_Precision] as [CurrentMatchAmount_Precision],
A15.[Round_RoundType] as [CurrentMatchAmount_RoundType],
A15.[Round_RoundValue] as [CurrentMatchAmount_RoundValue], A23.[Symbol] as [CurrentNoneTaxMoney_Symbol], A23.[MoneyRound_Precision] as [CurrentNoneTaxMoney_Precision], A23.[MoneyRound_RoundType] as [CurrentNoneTaxMoney_RoundType], A23.[MoneyRound_RoundValue] as [CurrentNoneTaxMoney_RoundValue],
A23.[Symbol] as [CurrentTaxMoney_Symbol], A23.[MoneyRound_Precision] as [CurrentTaxMoney_Precision],
A23.[MoneyRound_RoundType] as [CurrentTaxMoney_RoundType],
A23.[MoneyRound_RoundValue] as [CurrentTaxMoney_RoundValue], A23.[Symbol] as [CurrentMoney_Symbol], A23.[MoneyRound_Precision] as [CurrentMoney_Precision], A23.[MoneyRound_RoundType] as [CurrentMoney_RoundType], A23.[MoneyRound_RoundValue] as [CurrentMoney_RoundValue] from  PM_RcvLine as A  left join [CBO_AccrueBy] as A1 on (A.[ConfirmAccording] = A1.[ID])  left join [CBO_AccrueBy_Trl] as A2 on (A2.SysMlFlag = 'zh-CN') and (A1.[ID] = A2.[ID]) 
left join [Base_Organization] as A3 on (A.[AccountOrg] = A3.[ID])  left join [Base_Organization_Trl] as A4 on (A4.SysMlFlag = 'zh-CN') and (A3.[ID] = A4.[ID])  left join [Base_Organization] as A5 on (A.[CurrentOrg] = A5.[ID])  left join [Base_Organization_Trl] as A6 on (A6.SysMlFlag = 'zh-CN') and (A5.[ID] = A6.[ID])  left join [Base_Organization] as A7 on (A.[PurOrg] = A7.[ID])  left join [Base_Organization_Trl] as A8 on (A8.SysMlFlag = 'zh-CN') and (A7.[ID] = A8.[ID])
inner join [PM_Receivement] as A9 on (A.[Receivement] = A9.[ID])  left join [Base_Organization] as A10 on (A9.[BalanceOrg] = A10.[ID])  left join [Base_Organization_Trl] as A11 on (A11.SysMlFlag = 'zh-CN') and (A10.[ID] = A11.[ID])  left join [CBO_ItemMaster] as A12 on (A.[ItemInfo_ItemID] = A12.[ID])  left join [Base_Organization] as A13 on (A12.[Org] = A13.[ID])  left join [Base_Organization_Trl] as A14 on (A14.SysMlFlag = 'zh-CN') and (A13.[ID] = A14.[ID])
left join [Base_UOM] as A15 on (A.[PriceUOM] = A15.[ID])  left join [Base_UOM_Trl] as A16 on (A16.SysMlFlag = 'zh-CN') and (A15.[ID] = A16.[ID])  left join [Base_UOM] as A17 on (A.[PriceBaseUOM] = A17.[ID])  left join [Base_UOM_Trl] as A18 on (A18.SysMlFlag = 'zh-CN') and (A17.[ID] = A18.[ID])  left join [Base_UOM] as A19 on (A.[TradeUOM] = A19.[ID])  left join [Base_UOM_Trl] as A20 on (A20.SysMlFlag = 'zh-CN') and (A19.[ID] = A20.[ID])
left join [Base_UOM] as A21 on (A.[TradeBaseUOM] = A21.[ID])  left join [Base_UOM_Trl] as A22 on (A22.SysMlFlag = 'zh-CN') and (A21.[ID] = A22.[ID])  left join [Base_Currency] as A23 on (A9.[AC] = A23.[ID])  left join [Base_Currency_Trl] as A24 on (A24.SysMlFlag = 'zh-CN') and (A23.[ID] = A24.[ID])  left join [CBO_Supplier] as A25 on (A.[ConfirmSupplier_Supplier] = A25.[ID])  left join [CBO_Supplier_Trl] as A26 on (A26.SysMlFlag = 'zh-CN') and (A25.[ID] = A26.[ID])
left join [CBO_SupplierSite] as A27 on (A.[BillToSite_SupplierSite] = A27.[ID])  left join [CBO_SupplierSite_Trl] as A28 on (A28.SysMlFlag = 'zh-CN') and (A27.[ID] = A28.[ID])  left join [CBO_Supplier] as A29 on (A.[Payer_Supplier] = A29.[ID])  left join [CBO_Supplier_Trl] as A30 on (A30.SysMlFlag = 'zh-CN') and (A29.[ID] = A30.[ID])  left join [CBO_SupplierSite] as A31 on (A.[PayerSite_SupplierSite] = A31.[ID])
left join [CBO_SupplierSite_Trl] as A32 on (A32.SysMlFlag = 'zh-CN') and (A31.[ID] = A32.[ID])  left join [CBO_SupplierSite] as A33 on (A.[ShipToSite_SupplierSite] = A33.[ID])  left join [CBO_SupplierSite_Trl] as A34 on (A34.SysMlFlag = 'zh-CN') and (A33.[ID] = A34.[ID])  left join [CBO_Department] as A35 on (A.[PurDept] = A35.[ID])  left join [CBO_Department_Trl] as A36 on (A36.SysMlFlag = 'zh-CN') and (A35.[ID] = A36.[ID])
left join [CBO_Operators] as A37 on (A.[PurOper] = A37.[ID])  left join [CBO_Operators_Trl] as A38 on (A38.SysMlFlag = 'zh-CN') and (A37.[ID] = A38.[ID])  left join [CBO_Project] as A39 on (A.[Project] = A39.[ID])  left join [CBO_Project_Trl] as A40 on (A40.SysMlFlag = 'zh-CN') and (A39.[ID] = A40.[ID])  left join [CBO_Task] as A41 on (A.[Task] = A41.[ID])  left join [CBO_Task_Trl] as A42 on (A42.SysMlFlag = 'zh-CN') and (A41.[ID] = A42.[ID])
left join [CBO_APConfirmTerm] as A43 on (A.[ConfirmTerm] = A43.[ID])  left join [CBO_APConfirmTerm_Trl] as A44 on (A44.SysMlFlag = 'zh-CN') and (A43.[ID] = A44.[ID])  left join [CBO_PaymentTerm] as A45 on (A.[PaymentTerm] = A45.[ID])  left join [CBO_PaymentTerm_Trl] as A46 on (A46.SysMlFlag = 'zh-CN') and (A45.[ID] = A46.[ID])  left join [CBO_TaxSchedule] as A47 on (A.[TaxSchedule] = A47.[ID])  left join [CBO_TaxSchedule_Trl] as A48 on (A48.SysMlFlag = 'zh-CN')
and (A47.[ID] = A48.[ID])  left join [PM_RcvLine_Trl] as A49 on (A49.SysMlFlag = 'zh-CN') and (A.[ID] = A49.[ID])  left join [Base_Organization] as A50 on (A.[SrcDoc_SrcDocOrg] = A50.[ID])  left join [Base_Organization_Trl] as A51 on (A51.SysMlFlag = 'zh-CN') and (A50.[ID] = A51.[ID])  left join [PM_RcvDocType] as A52 on (A9.[RcvDocType] = A52.[ID])
 where   (A.[CurrentOrg] = " + bpObj.SRCOrgID + ")  and A9.[AC] = 1 and A25.[Code] = '" + bpObj.SupplierCode + "' and A.ID in (" + str + ")";

            DataSet dsTemp = null;
            IDbConnection conn = DatabaseManager.GetCurrentConnection();
            UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(conn, sql, null, out dsTemp);
            if (dsTemp == null || dsTemp.Tables == null || dsTemp.Tables[0].Rows.Count == 0)
                throw new Exception("没有可立账的收货单！");
            //除去不可立账的
            var resultDTODataSet = DisposalDS(dsTemp, bpObj);
            //立账

            List<long> apBillHeadIDSet = CreateAPBill(dsTemp, resultDTODataSet, bpObj);
            if (apBillHeadIDSet == null || apBillHeadIDSet.Count == 0) return null;
            long apbillids = apBillHeadIDSet[0];

            using (UFSoft.UBF.Business.ISession session = UFSoft.UBF.Business.Session.Open())
            {
                APBillHead apHead = APBillHead.Finder.FindByID(apbillids);
                var OpCode = Operators.FindByCode(bpObj.OpCode);
                var OpDptCode = Department.FindByCode(bpObj.OpDptCode);
                apHead.InvoiceNum = bpObj.APBillCode;
                apHead.DocNo = bpObj.APBillCode;
                apHead.Memo = bpObj.Memo;
                apHead.Transactor = OpCode;
                apHead.Dept = OpDptCode;
                foreach (APBillLine item in apHead.APBillLines)
                {
                    item.Transactor = OpCode;
                    item.Dept = OpDptCode;
                }
                //    APBillTaxDetail taxDetail = APBillTaxDetail.Finder.Find("APBillLine=@APBillLine", new OqlParam[] { new OqlParam("APBillLine", item.ID) });
                //    foreach (var data in bpObj.RCVLineInfoDTO)
                //    {
                //        if (item.SrcBillLineID == data.RCVLine)
                //        {
                //            item.APOCMoney.GoodsTax = data.Tax;
                //            item.APOCMoney.Tax = data.Tax;
                //            item.APFCMoney.Tax = data.Tax;
                //            item.APFCMoney.GoodsTax = data.Tax;
                //            item.APFCMoneyBalance.Tax = data.Tax;
                //            item.APFCMoneyBalance.GoodsTax = data.Tax;
                //            item.APOCMoneyBalance.Tax = data.Tax;
                //            item.APOCMoneyBalance.GoodsTax = data.Tax;
                //            if (taxDetail != null)
                //            {
                //                taxDetail.TaxMoney.FCMoney = data.Tax;
                //                taxDetail.TaxMoney.OCMoney = data.Tax;
                //            }
                //        }
                //    }
                //}
                session.Commit();
            }

            return apBillHeadIDSet;
        }
        /// <summary>
        /// 整理DS
        /// </summary>
        /// <param name="bpObj"></param>
        /// <param name="dsTemp"></param>
        private List<APDrawBillYDTOData> DisposalDS(DataSet dsTemp, SumAccrueDocToAPBillSV bpObj)
        {
            List<long> RcvLines = new List<long>();
            foreach (RCVLineInfoDTO dto in bpObj.RCVLineInfoDTO)
            {
                RcvLines.Add(dto.RCVLine);
            }
            GetCanConfirmRcvLinesForAPDrawBillSVProxy grlProxy =
                new GetCanConfirmRcvLinesForAPDrawBillSVProxy();
            grlProxy.DrawDocWay = (int)MakeBillModeEnumData.FromBill;
            grlProxy.RcvLines = RcvLines;
            grlProxy.ZAPIsPriceCalTax = 1;
            grlProxy.FAPIsPriceCalTax = 1;
            grlProxy.ZAPIsCalTax = 1;
            grlProxy.FAPIsCalTax = 1;
            grlProxy.IsReCalcArriveDate = true;
            grlProxy.ConfirmDate = Base.Context.LoginDate;
            grlProxy.BillDate = Base.Context.LoginDate;
            //  grlProxy.ApReCalcArriveDate = null;
            FeeAccrueDTOData feeAccrueDTOData = new FeeAccrueDTOData();
            feeAccrueDTOData.IsChoice = false;
            // 仅批拉有值
            grlProxy.FeeAPDTO = feeAccrueDTOData;
            List<APDrawBillYDTOData> resultDTODataSet = grlProxy.Do(Base.Context.LoginOrg.ID);//bpObj.SrcRCVOrg
            if (resultDTODataSet == null || resultDTODataSet.Count == 0)
            {
                throw new Exception("没有收货单符合立账要求！");
            }
            List<long> dtblDelDocs = new List<long>(); ;
            //UI里面调用实体的Finder方法就会提示 4月11号这个特殊的日子
            Currency cur = Currency.Finder.FindByID(1);
            foreach (DataRow row in dsTemp.Tables[0].Rows)
            {
                string dsKey = ConvertToString(row["DSKEY"]); // DSKEY
                long myID = ConvertToInt64(row["ID"], true);                // ID
                foreach (APDrawBillYDTOData data in resultDTODataSet)
                {
                    if (myID == data.LineID)
                    {
                        if (!data.IsAccure)
                        {
                            dtblDelDocs.Add(myID);
                            break;
                        }
                        else
                        {
                            if (row["ReceivementType"].ToString() == (ReceivementTypeEnum.RCV.Value).ToString())
                            {
                                row["AccrueDocType"] = (int)CBO.FI_SCM.DTOs.APAccrueDocTypeEnumData.RCV;
                                row["Direction"] = 0;
                            }
                            else if (row["ReceivementType"].ToString() == (CBO.SCM.Enums.ReceivementTypeEnum.PurReturn.Value).ToString())
                            {
                                row["AccrueDocType"] = (int)CBO.FI_SCM.DTOs.APAccrueDocTypeEnumData.RCVReturn;
                                row["Direction"] = 1;
                            }
                            // 来源订单相关信息处理
                            if (row["PO_EntityType"].ToString().Length > 0
                                && row["PO_EntityType"].ToString() != "UFIDA.U9.PM.PO.PurchaseOrder")
                            {
                                row["PODocNo"] = string.Empty;
                                row["PO_ID"] = -1;
                                row["PO_EntityType"] = string.Empty;
                                row["POOrg"] = -1;
                                row["POShipLine_ID"] = -1;
                            }
                            row["BusinessType"] = data.BusinessType;
                            row["IsTaxPrice"] = true;// ConvertToInt32(data.IsTaxPrice, false);
                            row["AccrueType"] = data.AccrueDocType;
                            // 可立账
                            row["MatchPUAmount"] = data.MatchPUAmount;
                            row["MatchTUAmount"] = data.MatchTUAmount;
                            row["PUAmount"] = data.PUAmount;
                            row["TUAmount"] = data.TUAmount;
                            row["TBUAmount"] = data.TBUAmount;
                            row["NoneTaxPrice"] = data.NonTaxPrice;
                            row["Price"] = data.WithTaxPrice;
                            row["NoneTaxMoney"] = data.NonTaxMoney;
                            row["Money"] = data.WithTaxMoney;
                            row["TaxMoney"] = data.TaxMoney;
                            // 本次立账
                            row["CurrentMatchAmount"] = data.MatchPUAmount;
                            row["CurrentPUAmount"] = data.PUAmount;
                            row["CurrentTUAmount"] = data.TUAmount;
                            row["CurrentTBUAmount"] = data.TBUAmount;
                            row["CurrentNoneTaxPrice"] = data.NonTaxPrice;
                            row["CurrentPrice"] = data.WithTaxPrice;
                            row["CurrentNoneTaxMoney"] = data.NonTaxMoney;
                            row["CurrentMoney"] = data.WithTaxMoney;
                            row["CurrentTaxMoney"] = data.TaxMoney;

                            foreach (RCVLineInfoDTO dto in bpObj.RCVLineInfoDTO)
                            {
                                if (dto.RCVLine == myID)
                                {
                                    row["CurrentMatchAmount"] = dto.Amount;
                                    row["CurrentPUAmount"] = dto.Amount;
                                    row["CurrentTUAmount"] = dto.Amount;
                                    row["CurrentTBUAmount"] = dto.Amount;
                                    if (dto.Amount == 0)
                                        throw new Exception("收货单行id" + dto.RCVLine + "立账数量为0，不能立账！");
                                    // row["CurrentNoneTaxPrice"] = data.NonTaxPrice;
                                    row["CurrentPrice"] = cur.PriceRound.GetRoundValue(dto.TotalMoney / dto.Amount);
                                    // row["CurrentNoneTaxMoney"] = data.NonTaxMoney;
                                    row["CurrentMoney"] = dto.TotalMoney;
                                    row["CurrentTaxMoney"] = dto.Tax;
                                    break;
                                }
                            }
                            row["CurrentNoneTaxMoney"] = ConvertToDecimal(row["CurrentMoney"]) - ConvertToDecimal(row["CurrentTaxMoney"]);
                            row["CurrentNoneTaxPrice"] = cur.PriceRound.GetRoundValue(ConvertToDecimal(row["CurrentNoneTaxMoney"]) / ConvertToDecimal(row["CurrentPUAmount"]));
                            #region For PO && Rcv
                            int feeItemCount = 0;
                            // 费用项目数量
                            row["FeeItemCount"] = feeItemCount;
                            // 可立账总费用
                            row["TotalFee"] = data.TotalFee;
                            row["EstimatePriceMnyAC"] = data.NonTaxPrice;
                            row["MatchNoneTaxMoney"] = data.MatchNonTaxMoney;
                            // 修改控制
                            row["IsCanMod_Money"] = data.IsCanModMoney;
                            row["IsCanMod_AccrueAmount"] = data.IsCanMod;
                            row["IsCanMod_MatchAmount"] = data.IsModMatchAmount;
                            row["IsCanMod_TaxSchedule"] = data.IsTaxScheduleEnable;
                            #endregion
                        }
                        break;
                    }
                }
            }

            //删除不能立账
            for (int i = dsTemp.Tables[0].Rows.Count - 1; i >= 0; i--)
            {
                foreach (long id in dtblDelDocs)
                {
                    if (id == ConvertToInt64(dsTemp.Tables[0].Rows[i]["ID"], false))
                    {
                        dsTemp.Tables[0].Rows[i].Delete();
                        break;
                    }
                }
            }
            return resultDTODataSet;
        }

        private List<long> CreateAPBill(DataSet dsTemp, List<APDrawBillYDTOData> resultDTODataSet, SumAccrueDocToAPBillSV bpObj)
        {
            #region 获取上游来源单据信息
            List<CBO.FI_SCM.DTOs.APBatchAccrueDocDTOData> accrueDocDTODataSet
               = new List<UFIDA.U9.CBO.FI_SCM.DTOs.APBatchAccrueDocDTOData>();
            CBO.FI_SCM.DTOs.APBatchAccrueDocDTOData accrueDocDTOData;

            foreach (DataRow rec in dsTemp.Tables[0].Rows)
            {
                long myID = Int64.Parse(rec["ID"].ToString());//ConvertToInt64(row["ID"], true);
                accrueDocDTOData = new UFIDA.U9.CBO.FI_SCM.DTOs.APBatchAccrueDocDTOData();
                accrueDocDTOData.DocTag = ConvertToInt64(rec["DocHeadID"], true);
                accrueDocDTOData.DocNo = ConvertToString(rec["DocNo"]);
                accrueDocDTOData.DocDirect = ConvertToInt32(rec["Direction"], false);
                #region 事务版本
                accrueDocDTOData.DocSysVersion = ConvertToInt32(rec["SysVersion"], false);
                #endregion
                #region 单行信息
                accrueDocDTOData.DocLineTag = ConvertToInt64(rec["DocLineID"], true);
                accrueDocDTOData.DocLineNo = ConvertToInt32(rec["LineNum"], false);
                #endregion
                accrueDocDTOData.AccrueBy = ConvertToString(rec["AccrueBy_Code"]);
                //  accrueDocDTOData.AccrueDocType = ConvertToInt32(rec["AccrueDocType"], true);
                accrueDocDTOData.AccrueDocType = 1;
                accrueDocDTOData.DocumentType = ConvertToInt64(rec["DocType"], true);
                accrueDocDTOData.BusinessType = ConvertToInt32(rec["BusinessType"], true);
                accrueDocDTOData.BusinessDate = ConvertToDateTime(rec["BusinessDate"]);
                accrueDocDTOData.SrcOrgID = ConvertToInt64(rec["SrcOrg"], true);
                accrueDocDTOData.SrcBusinessType = ConvertToInt32(rec["SrcBusinessType"], true);
                accrueDocDTOData.Memo = ConvertToString(rec["Memo"]);
                //accrueDocDTOData.PlanArrivedDate = ConvertToDateTime(rec["PlanArrivedDate"]);
                accrueDocDTOData.FactArrivedDate = ConvertToDateTime(rec["ArrivedDate"]);
                #region 料品信息

                accrueDocDTOData.Item = new UFIDA.U9.CBO.SCM.Item.ItemInfoData();
                accrueDocDTOData.Item.ItemID = ConvertToInt64(rec["Item"], true);
                accrueDocDTOData.Item.ItemCode = ConvertToString(rec["ItemCode"]);
                accrueDocDTOData.Item.ItemName = ConvertToString(rec["ItemName"]);
                accrueDocDTOData.ItemName = ConvertToString(rec["ItemName"]);
                accrueDocDTOData.ItemCode1 = ConvertToString(rec["ItemCode1"]);
                accrueDocDTOData.ItemCode2 = ConvertToString(rec["ItemCode2"]);
                accrueDocDTOData.ProcessItemCode = ConvertToString(rec["ProcessItemCode"]);
                accrueDocDTOData.ProcessItemName = ConvertToString(rec["ProcessItemName"]);
                #endregion

                #region 立账条件、付款条件
                // 立账条件
                accrueDocDTOData.AccrueTermDTO = new CBO.FI_SCM.DTOs.CodeNameIDDTOData();
                accrueDocDTOData.AccrueTermDTO.ID = ConvertToInt64(rec["ConfirmTerm"], true);
                accrueDocDTOData.AccrueTermDTO.Code = ConvertToString(rec["ConfirmTerm_Code"]);
                accrueDocDTOData.AccrueTermDTO.Name = ConvertToString(rec["ConfirmTerm_Name"]);
                // 付款条件
                accrueDocDTOData.PayTermDTO = new CBO.FI_SCM.DTOs.CodeNameIDDTOData();
                accrueDocDTOData.PayTermDTO.ID = ConvertToInt64(rec["PaymentTerm"], true);
                accrueDocDTOData.PayTermDTO.Code = ConvertToString(rec["PaymentTerm_Code"]);
                accrueDocDTOData.PayTermDTO.Name = ConvertToString(rec["PaymentTerm_Name"]);
                #endregion
                #region 部门、业务员
                // 部门
                accrueDocDTOData.DeptDTO = new CBO.FI_SCM.DTOs.CodeNameIDDTOData();
                accrueDocDTOData.DeptDTO.ID = ConvertToInt64(rec["Department"], true);
                accrueDocDTOData.DeptDTO.Code = ConvertToString(rec["Department_Code"]);
                accrueDocDTOData.DeptDTO.Name = ConvertToString(rec["Department_Name"]);
                // 业务员
                accrueDocDTOData.TransactorDTO = new CBO.FI_SCM.DTOs.CodeNameIDDTOData();
                accrueDocDTOData.TransactorDTO.ID = ConvertToInt64(rec["Operator"], true);
                accrueDocDTOData.TransactorDTO.Code = ConvertToString(rec["Operator_Code"]);
                accrueDocDTOData.TransactorDTO.Name = ConvertToString(rec["Operator_Name"]);
                #endregion

                #region 项目、任务
                // 项目
                //accrueDocDTOData.ProjectDTO = new CodeNameIDDTOData();
                //accrueDocDTOData.ProjectDTO.ID = ConvertToInt64(rec["Project"], true);
                //accrueDocDTOData.ProjectDTO.Code = ConvertToString(rec["Project_Code"]);
                //accrueDocDTOData.ProjectDTO.Name = ConvertToString(rec["Project_Name"]);
                //// 任务
                //accrueDocDTOData.TaskDTO = new CBO.FI_SCM.DTOs.CodeNameIDDTOData();
                //accrueDocDTOData.TaskDTO.ID = ConvertToInt64(rec["Task"], true);
                //accrueDocDTOData.TaskDTO.Code = ConvertToString(rec["Task_Code"]);
                //accrueDocDTOData.TaskDTO.Name = ConvertToString(rec["Task_Name"]);
                #endregion
                #region 供应商、供应商位置

                // 供应商
                accrueDocDTOData.Supp = new UFIDA.U9.CBO.SCM.Supplier.SupplierMISCInfoData();
                accrueDocDTOData.Supp.Supplier = ConvertToInt64(rec["AccrueSupplier"], true);
                accrueDocDTOData.Supp.Code = ConvertToString(rec["AccrueSupplier_Code"]);
                accrueDocDTOData.Supp.Name = ConvertToString(rec["AccrueSupplier_Name"]);

                // 供应商位置
                accrueDocDTOData.SuppSite = new UFIDA.U9.CBO.SCM.Supplier.SupplierSiteMISCInfoData();
                accrueDocDTOData.SuppSite.SupplierSite = ConvertToInt64(rec["AccrueSupplierSite"], true);
                accrueDocDTOData.SuppSite.Code = ConvertToString(rec["AccrueSupplierSite_Code"]);
                accrueDocDTOData.SuppSite.Name = ConvertToString(rec["AccrueSupplierSite_Name"]);

                // 发货供应商位置
                accrueDocDTOData.ShipToSite = new UFIDA.U9.CBO.SCM.Supplier.SupplierSiteMISCInfoData();
                accrueDocDTOData.ShipToSite.SupplierSite = ConvertToInt64(rec["ShiptoSupplierSite"], true);
                accrueDocDTOData.ShipToSite.Code = ConvertToString(rec["ShiptoSupplierSite_Code"]);
                accrueDocDTOData.ShipToSite.Name = ConvertToString(rec["ShiptoSupplierSite_Name"]);
                #endregion

                #region 税组合

                accrueDocDTOData.TaxSchedule = ConvertToInt64(rec["TaxSchedule"], true);
                accrueDocDTOData.TaxScheduleCodeName = new UFIDA.U9.CBO.FI_SCM.DTOs.CodeNameDTOForUIData();
                accrueDocDTOData.TaxScheduleCodeName.Code = ConvertToString(rec["TaxSchedule_Code"]);
                accrueDocDTOData.TaxScheduleCodeName.Name = ConvertToString(rec["TaxSchedule_Name"]);
                #endregion

                #region 合同信息、源单信息

                // 合同信息
                //accrueDocDTOData.ContactKey = ConvertToInt64(rec["PC_ID"], true);
                //accrueDocDTOData.ContactNum = ConvertToString(rec["PCNo"]);
                //accrueDocDTOData.ContactOrg = ConvertToInt64(rec["PCOrg"], true);
                //// 源单信息
                //accrueDocDTOData.SrcBillKey = ConvertToInt64(rec["PO_ID"], true);
                //accrueDocDTOData.SrcBillNum = ConvertToString(rec["PODocNo"]);
                //accrueDocDTOData.SrcBillOrg = ConvertToInt64(rec["POOrg"], true);
                #endregion

                #region KIT件成套收发货

                accrueDocDTOData.IsShipTogether = false;
                #endregion

                #region 数量信息

                #region 精度信息

                // 交易单位


                Round rounderTU = new UFIDA.U9.Base.PropertyTypes.Round(ConvertToInt32(rec["TradeUOM_Round_Precision"], false),
                             RoundTypeEnum.GetFromValue(ConvertToInt32(rec["TradeUOM_Round_RoundType"], true)),
                            ConvertToInt32(rec["TradeUOM_Round_RoundValue"], false));

                // 交易基准单位
                UFIDA.U9.Base.PropertyTypes.Round rounderTBU
                    = new UFIDA.U9.Base.PropertyTypes.Round(ConvertToInt32(rec["TradeBaseUOM_Round_Precision"], false),
                         RoundTypeEnum.GetFromValue(ConvertToInt32(rec["TradeBaseUOM_Round_RoundType"], true)),
                        ConvertToInt32(rec["TradeBaseUOM_Round_RoundValue"], false));
                #endregion

                accrueDocDTOData.PUAmount = ConvertToDecimal(rec["PUAmount"]);
                accrueDocDTOData.TUAmount = ConvertToDecimal(rec["TUAmount"]);
                accrueDocDTOData.TBUAmount = ConvertToDecimal(rec["TBUAmount"]);

                accrueDocDTOData.CurrentMatchPUAmount = ConvertToDecimal(rec["CurrentMatchAmount"]);
                accrueDocDTOData.CurrentPUAmount = ConvertToDecimal(rec["CurrentPUAmount"]);

                accrueDocDTOData.CurrentTUAmount = (accrueDocDTOData.PUAmount != 0)
                    ? rounderTU.GetRoundValue((accrueDocDTOData.TUAmount / accrueDocDTOData.PUAmount) * accrueDocDTOData.CurrentPUAmount)
                    : 0;
                accrueDocDTOData.CurrentTBUAmount = (accrueDocDTOData.PUAmount != 0)
                    ? rounderTBU.GetRoundValue((accrueDocDTOData.TBUAmount / accrueDocDTOData.PUAmount) * accrueDocDTOData.CurrentPUAmount)
                    : 0;

                // 计价单位
                accrueDocDTOData.PUom = ConvertToInt64(rec["PriceUOM"], true);

                accrueDocDTOData.PUomCodeName = new UFIDA.U9.CBO.FI_SCM.DTOs.CodeNameDTOForUIData();
                accrueDocDTOData.PUomCodeName.Code = ConvertToString(rec["PriceUOM_Code"]);
                accrueDocDTOData.PUomCodeName.Name = ConvertToString(rec["PriceUOM_Name"]);

                accrueDocDTOData.PUomToPBUom = ConvertToDecimal(rec["PUToPBURate"]);
                accrueDocDTOData.PBUom = ConvertToInt64(rec["PriceBaseUOM"], true);

                // 交易单位
                accrueDocDTOData.TUom = ConvertToInt64(rec["TradeUOM"], true);

                accrueDocDTOData.TUomCodeName = new UFIDA.U9.CBO.FI_SCM.DTOs.CodeNameDTOForUIData();
                accrueDocDTOData.TUomCodeName.Code = ConvertToString(rec["TradeUOM_Code"]);
                accrueDocDTOData.TUomCodeName.Name = ConvertToString(rec["TradeUOM_Name"]);

                accrueDocDTOData.TBUom = ConvertToInt64(rec["TradeBaseUOM"], true);

                accrueDocDTOData.TBUomCodeName = new UFIDA.U9.CBO.FI_SCM.DTOs.CodeNameDTOForUIData();
                accrueDocDTOData.TBUomCodeName.Code = ConvertToString(rec["TradeBaseUOM_Code"]);
                accrueDocDTOData.TBUomCodeName.Name = ConvertToString(rec["TradeBaseUOM_Name"]);
                #endregion

                #region 金额信息

                accrueDocDTOData.IsTaxPrice = ConvertToBoolean(rec["IsTaxPrice"]);

                accrueDocDTOData.NonTaxPrice = ConvertToDecimal(rec["NoneTaxPrice"]);
                accrueDocDTOData.WithTaxPrice = ConvertToDecimal(rec["Price"]);
                accrueDocDTOData.NonTaxMoney = ConvertToDecimal(rec["NoneTaxMoney"]);
                accrueDocDTOData.TaxMoney = ConvertToDecimal(rec["TaxMoney"]);
                accrueDocDTOData.WithTaxMoney = ConvertToDecimal(rec["Money"]);
                accrueDocDTOData.MatchNonTaxMoney = ConvertToDecimal(rec["MatchNoneTaxMoney"]);

                accrueDocDTOData.CurrentNonTaxPrice = ConvertToDecimal(rec["CurrentNoneTaxPrice"]);
                accrueDocDTOData.CurrentTaxPrice = ConvertToDecimal(rec["CurrentPrice"]);
                accrueDocDTOData.CurrentNonTaxMoney = ConvertToDecimal(rec["CurrentNoneTaxMoney"]);
                accrueDocDTOData.CurrentTaxMoney = ConvertToDecimal(rec["CurrentTaxMoney"]);
                accrueDocDTOData.CurrentWithTaxMoney = ConvertToDecimal(rec["CurrentMoney"]);

                accrueDocDTOData.TotalFee = ConvertToDecimal(rec["TotalFee"]);

                // 币种
                accrueDocDTOData.Currency = ConvertToInt64(rec["AC"], true);
                accrueDocDTOData.CurrencyCodeName = new UFIDA.U9.CBO.FI_SCM.DTOs.CodeNameDTOForUIData();
                accrueDocDTOData.CurrencyCodeName.Code = ConvertToString(rec["AC_Code"]);
                accrueDocDTOData.CurrencyCodeName.Name = ConvertToString(rec["AC_Name"]);
                #endregion

                #region 控制信息

                accrueDocDTOData.IsCanMod = true;//ConvertToBoolean(rec["IsCanMod_AccrueAmount"]);
                accrueDocDTOData.IsCanModMoney = true;//ConvertToBoolean(rec["IsCanMod_Money"]);
                accrueDocDTOData.IsModMatchAmount = true;//ConvertToBoolean(rec["IsCanMod_MatchAmount"]);
                //accrueDocDTOData.IsCanModMatchAmount = ConvertToBoolean(rec["IsCanMod_MatchAmount"]);
                accrueDocDTOData.IsTaxScheduleEnable = true;//ConvertToBoolean(rec["IsCanMod_TaxSchedule"]);
                #endregion

                #region 精度信息

                // 计价单位
                accrueDocDTOData.PUom_Round = new UFIDA.U9.Base.PropertyTypes.RoundData();
                accrueDocDTOData.PUom_Round.Precision = ConvertToInt32(rec["PriceUOM_Round_Precision"], false);
                accrueDocDTOData.PUom_Round.RoundType = ConvertToInt32(rec["PriceUOM_Round_RoundType"], true);
                accrueDocDTOData.PUom_Round.RoundValue = ConvertToInt32(rec["PriceUOM_Round_RoundValue"], false);

                // 核币
                accrueDocDTOData.AC_Symbol = ConvertToString(rec["AC_Symbol"]);

                accrueDocDTOData.AC_PriceRound = new UFIDA.U9.Base.PropertyTypes.RoundData();
                accrueDocDTOData.AC_PriceRound.Precision = ConvertToInt32(rec["AC_PriceRound_Precision"], false);
                accrueDocDTOData.AC_PriceRound.RoundType = ConvertToInt32(rec["AC_PriceRound_RoundType"], true);
                accrueDocDTOData.AC_PriceRound.RoundValue = ConvertToInt32(rec["AC_PriceRound_RoundValue"], false);

                accrueDocDTOData.AC_MoneyRound = new UFIDA.U9.Base.PropertyTypes.RoundData();
                accrueDocDTOData.AC_MoneyRound.Precision = ConvertToInt32(rec["AC_MoneyRound_Precision"], false);
                accrueDocDTOData.AC_MoneyRound.RoundType = ConvertToInt32(rec["AC_MoneyRound_RoundType"], true);
                accrueDocDTOData.AC_MoneyRound.RoundValue = ConvertToInt32(rec["AC_MoneyRound_RoundValue"], false);
                #endregion

                #region 费明细、税明细

                //// 税明细
                foreach (CBO.FI_SCM.DTOs.APDrawBillYDTOData item in resultDTODataSet)
                {
                    if (myID == item.LineID)
                    {
                        accrueDocDTOData.APAccrueTaxDetailDTO = item.APAccrueTaxDetailDTO;
                        accrueDocDTOData.APAccrueTaxDetailDTO.ForEach(i => i.CurrentTaxMoney = accrueDocDTOData.CurrentTaxMoney);
                    }
                }
                accrueDocDTOData.CurrentAccrueTaxDetailDTOs = accrueDocDTOData.APAccrueTaxDetailDTO;
                //// 费明细
                //accrueDocDTOData.APAccrueFeeDetailDTO = GetFeeDetailInfo(rec);

                #endregion

                accrueDocDTODataSet.Add(accrueDocDTOData);
            }
            #endregion
            // 获取组织相关信息
            // 调用BP
            GetOrgRefProxy gorProxy = new GetOrgRefProxy();
            gorProxy.OrgID = Base.Context.LoginOrg.ID;
            Base.Organization.OrgRefData orgRefDTOData = gorProxy.Do();

            // 获取生单方式
            CBO.FI_SCM.DTOs.MakeBillModeEnumData makeBillMode = CBO.FI_SCM.DTOs.MakeBillModeEnumData.FromUI;



            // 获取过滤条件配置信息
            CBO.FI_SCM.DTOs.APQryConfigureParaDTOData qryCfgDTOData = GetAllocConfigParaDTOData();
            qryCfgDTOData.IsAccrueDate = (makeBillMode == CBO.FI_SCM.DTOs.MakeBillModeEnumData.FromUI)
                ? true
                : false;
            // 批拉
            // 调用BP
            U9.AP.APBill.Proxy.BatchAccrueDocToAPBillBPProxy badProxy
                = new UFIDA.U9.AP.APBill.Proxy.BatchAccrueDocToAPBillBPProxy();
            badProxy.BatchAccrueDocDTO = accrueDocDTODataSet;
            badProxy.AccOrg = Base.Context.LoginOrg.ID;
            badProxy.SOB = orgRefDTOData.SOBID;
            badProxy.IsMerge = true;//你要设置为true
            badProxy.MakeBillMode = 1;//ConvertToInt32(makeBillMode, true);
            // 来源组织（仅针对固定资产调拨、配送对账单、管销费用单有效）
            badProxy.SrcOrg = Base.Context.LoginOrg.ID;
            badProxy.AccrueDate = Base.Context.LoginDate;
            U9.AP.APCommon.Proxy.GetNoCloseSOBAccountPeriodBPProxy gspProxy
              = new U9.AP.APCommon.Proxy.GetNoCloseSOBAccountPeriodBPProxy();
            gspProxy.AuditOrg = Base.Context.LoginOrg.ID;
            gspProxy.Date = badProxy.AccrueDate;
            SOBAccountingPeriodDTOData data = gspProxy.Do();

            if (data == null)
            { throw new Exception("应付单没有找到对应的记账期间！"); }

            badProxy.PostPeriond = data.ID;
            qryCfgDTOData.IsAccrueDate = false;

            // 合并开票配置
            badProxy.APMergeAccrueCfgDTO = new APMergeAccrueCfgDTOData();//你要传入合并条件
            badProxy.APMergeAccrueCfgDTO.PubDescSegConfigDTO = new PubDescSegConfigDTOData();
            // 过滤条件配置
            badProxy.APQryConfigureParaDTO = qryCfgDTOData;

            return badProxy.Do();
        }

        private bool ConvertToBoolean(object p)
        {
            try
            {
                switch (p.ToString())
                {
                    case "1":
                        return true;
                    default:
                        return false;
                }
            }
            catch (Exception)
            {
                return false; ;
            }
        }

        private DateTime ConvertToDateTime(object p)
        {
            try
            {
                return DateTime.Parse(p.ToString());
            }
            catch (Exception)
            {
                return DateTime.MinValue;
            }
        }

        private int ConvertToInt32(object p, bool p_2)
        {
            try
            {
                return Int32.Parse(p.ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private decimal ConvertToDecimal(object p)
        {
            try
            {
                return decimal.Parse(p.ToString());
            }
            catch (Exception)
            {
                return 0.0M;
            }
        }

        private string ConvertToString(object p)
        {
            return p.ToString();
        }

        private long ConvertToInt64(object p, bool p_2)
        {
            try
            {
                return Int64.Parse(p.ToString());
            }
            catch (Exception)
            {
                return 0L;
            }
        }
        // 分单条件配置信息
        private APQryConfigureParaDTOData GetAllocConfigParaDTOData()
        {
            APQryConfigureParaDTOData dtoData = new APQryConfigureParaDTOData();
            dtoData.IsOrg = true;
            dtoData.IsSrcOrg = true;
            dtoData.IsBizOrg = true;
            dtoData.IsAccrueBy = true;
            dtoData.IsAC = true;
            dtoData.IsSrcBusinessType = true;
            #region 可配置条件
            dtoData.IsSettleOrg = true;
            dtoData.IsAccrueSupp = true;
            dtoData.IsAccrueSuppSite = true;
            dtoData.IsPaySuppSite = false;
            dtoData.IsDept = false;
            dtoData.IsTransactor = false;
            dtoData.IsAccrueTerm = false;
            dtoData.IsPayTerm = false;
            dtoData.IsProject = false;
            dtoData.IsTask = false;
            dtoData.IsTaxSchedule = false;
            //来源单号
            dtoData.IsSrcDocNo = false;
            #endregion
            // 公共扩展字段（可选配置）
            //  dtoData.PubDescSegConfigDTO = GetPubDescConfigDTOData("Group2");
            return dtoData;
        }
    }

    #endregion


}