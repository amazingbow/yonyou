namespace UFIDA.U9.Cust.XMJL.APBillSV
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.PM.Rcv.Proxy;
    using UFSoft.UBF.Service;
    using UFIDA.U9.AP.APBill;
    using UFSoft.UBF.PL;

    /// <summary>
    /// RcvPushAPComfirmSV partial 
    /// </summary>	
    public partial class RcvPushAPComfirmSV
    {
        internal BaseStrategy Select()
        {
            return new RcvPushAPComfirmSVImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class RcvPushAPComfirmSVImpementStrategy : BaseStrategy
    {
        public RcvPushAPComfirmSVImpementStrategy() { }

        public override object Do(object obj)
        {
            RcvPushAPComfirmSV bpObj = (RcvPushAPComfirmSV)obj;

            RcvPushAPComfirmBPProxy proxy = new RcvPushAPComfirmBPProxy();

            proxy.IsMergerAPConfirm = bpObj.IsMergerAPConfirm;
            //proxy.RcvID = bpObj.RcvID;
            proxy.RcvLineIDs = bpObj.RcvLineIDs;
            //proxy.IsCust = true;

            CommonResultDTO result = new CommonResultDTO()
            {
                Success = true
            };

            int i = 1;
            try
            {
                proxy.Do();

                i = 2;

                APBillLine line = APBillLine.Finder.Find("SrcBillRCVLineID = @SrcBillRCVLineID",
                    new OqlParam("SrcBillRCVLineID", bpObj.RcvLineIDs[0]));

                i = 3;

                if (line == null)
                {
                    result.Message = "未找到生成的应付单";
                    result.Success = false;
                }
                else
                {
                    result.Message = line.APBillHead.ID.ToString();
                }
            }
            catch (ServiceException ex)
            {
                result.Message = i.ToString() + ":" + ex.Message;
                result.Success = false;
            }
            catch (Exception ex)
            {
                result.Message = i.ToString() + ":" + ex.Message;
                result.Success = false;
            }

            return result;
        }
    }

    #endregion


}