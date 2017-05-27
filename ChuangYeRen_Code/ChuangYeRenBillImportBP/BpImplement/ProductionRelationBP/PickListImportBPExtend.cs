namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using PublicDataTransObj;
    using UFIDA.U9.MO.MO;
    using pMakBomBE;
    using UFSoft.UBF.Business;
    using pMakGydGyBE;
    using pMakReqOrderBE;
    using UFIDA.U9.CBO.MFG.CostElement;
    using UFIDA.U9.CBO.MFG.Enums;
    using UFIDA.U9.CBO.SCM.Item;
    using UFIDA.U9.Base.FlexField.KeyFlexField;
    using UFIDA.U9.CBO.Enums;

    /// <summary>
    /// PickListImportBP partial 
    /// </summary>	
    public partial class PickListImportBP
    {
        internal BaseStrategy Select()
        {
            return new PickListImportBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class PickListImportBPImpementStrategy : BaseStrategy
    {
        public PickListImportBPImpementStrategy() { }

        public override object Do(object obj)
        {
            PickListImportBP bpObj = (PickListImportBP)obj;
            PublicReturnDTO pub = new PublicReturnDTO();
            var makbom = PMakBom.Finder.FindAll("MakReqID='" + bpObj.RelationId + "'");
            MO mo = MO.Finder.FindByID(bpObj.ProductionId);
            PMakReqOrder order = PMakReqOrder.Finder.FindByID(bpObj.RelationId);
            using (ISession session = Session.Open())
            {
                foreach (var item in makbom)
                {
                    MOPickList moPickList = MOPickList.Finder.Find("MO=" + bpObj.ProductionId + "Item.Code='" + item.ItemID.Code + "'");
                    var pmLst = PMakgydGy.Finder.FindAll("PMakGyd=" + order.GydID.ID + " and Dept=" + item.Dept.ID);
                    short opNum = 0;
                    foreach (var pm in pmLst)
                    {
                        if (opNum < pm.PX)
                        {
                            opNum = pm.PX;
                        }
                    }

                    if (moPickList != null)
                    {
                        moPickList.OperationNum = opNum.ToString();//取最大工序
                        moPickList.ActualReqQty = (decimal)item.FQty;
                        moPickList.QPA = item.FQty / (decimal)order.Qty;
                    }
                    else
                    {
                        MOPickList moPick = MOPickList.Create(mo);
                        moPick.IsControlPos = false;
                        moPick.IsControlSupplier = false;
                        //moPick.IsIssueOrgFixed = false;//特定供应组织 
                        moPick.IsCalcCost = true;//计算成本
                        moPick.CostElement = CostElement.FindByCode(mo.Org, "No101");
                        moPick.SupplyStyle = SupplyStyleEnum.Org;
                        moPick.ConsignProcessItemSrc = ConsignProcessItemSrcEnum.IssuedByConsignee;// 受托方领料  2  
                        moPick.IssueStyle = IssueStyleEnum.Push;
                        moPick.FromElement = ElementEnum.Empty;
                        moPick.ToElement = ElementEnum.Empty;
                        moPick.FromGrade = GradeEnum.Empty;
                        moPick.ToGrade = GradeEnum.Empty;
                        moPick.OperationNum = opNum.ToString();//取最大工序
                        moPick.ItemMaster = ItemMaster.Finder.Find("Code='" + item.ItemID.Code + "'");
                        moPick.ActualReqDate = (order.ReceiveDate <= DateTime.Parse("2015-1-1") ? DateTime.Parse("2015-1-1") : order.ReceiveDate);
                        moPick.ActualReqQty = (decimal)item.FQty;
                        moPick.QPA = item.FQty / (decimal)order.Qty;
                        moPick.QtyType = UsageQuantityTypeEnum.Variable;//变动
                    }
                }
                session.Commit();
            }

            return pub;

        }
    }

    #endregion


}