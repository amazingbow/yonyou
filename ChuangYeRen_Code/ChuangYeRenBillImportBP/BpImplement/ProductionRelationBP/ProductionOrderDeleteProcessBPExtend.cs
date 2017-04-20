namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP
{
    using PublicDataTransObj;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Base;
    using UFIDA.U9.MO.MO;
    using UFIDA.U9.MO.MO.Proxy;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;

    /// <summary>
    /// ProductionOrderDeleteProcessBP partial 
    /// </summary>	
    public partial class ProductionOrderDeleteProcessBP
    {
        internal BaseStrategy Select()
        {
            return new ProductionOrderDeleteProcessBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ProductionOrderDeleteProcessBPImpementStrategy : BaseStrategy
    {
        public ProductionOrderDeleteProcessBPImpementStrategy() { }

        public override object Do(object obj)
        {
            ProductionOrderDeleteProcessBP bpObj = (ProductionOrderDeleteProcessBP)obj;
            PublicReturnDTO resultDto = new PublicReturnDTO();
            #region 生产订单 反开工
            try
            {
                AntiStartMOProxy antiStartProxy = new AntiStartMOProxy();
                antiStartProxy.AntiStarter = Context.LoginUser;
                antiStartProxy.AntiStartTime = DateTime.Now;
                antiStartProxy.MOStartInfolist = new List<long>();
                antiStartProxy.MOStartInfolist.Add(bpObj.ProductionID);
                antiStartProxy.Do();
            }
            catch (Exception ex)
            {
                resultDto.Message = "反开工失败：" + ex.Message;
                resultDto.Flag = false;
            }
            #endregion
            #region 生产订单山
            try
            {
                BatchAntiApproveMOBPProxy antiApproveProxy = new BatchAntiApproveMOBPProxy();
                antiApproveProxy.MOs = new List<BatchOperationDTOData>();
                BatchOperationDTOData dto = new BatchOperationDTOData { ID = bpObj.ProductionID };
            }
            catch (Exception ex)
            {
                resultDto.Message = "弃审失败：" + ex.Message;
                resultDto.Flag = false;
            }
            #endregion
            #region 生产订单删除
            try
            {
                DeleteMOProxy delete = new DeleteMOProxy();
                delete.MO = bpObj.ProductionID;
            }
            catch (Exception ex)
            {
                resultDto.Message = "删除失败：" + ex.Message;
                resultDto.Flag = false;
            }

            #endregion

            return resultDto;
        }
    }

    #endregion


}