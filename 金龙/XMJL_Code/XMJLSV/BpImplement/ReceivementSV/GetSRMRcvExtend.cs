namespace UFIDA.U9.Cust.XMJL.ReceivementSV
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using System.Data;
    using UFSoft.UBF.PL;
    using UFIDA.U9.Base.Doc;
    using UFIDA.U9.PM.Rcv;

    /// <summary>
    /// GetSRMRcv partial 
    /// </summary>	
    public partial class GetSRMRcv
    {
        internal BaseStrategy Select()
        {
            return new GetSRMRcvImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetSRMRcvImpementStrategy : BaseStrategy
    {
        public GetSRMRcvImpementStrategy() { }

        public override object Do(object obj)
        {
            GetSRMRcv bpObj = (GetSRMRcv)obj;
            string vendorCode = bpObj.SRMRcvQueryDTO.VendorCode;

            int type = -99;
            if (bpObj.SRMRcvQueryDTO.Type == "正常")
            {
                type = BusinessTypeEnum.PM005.Value;
            }
            else if (bpObj.SRMRcvQueryDTO.Type == "代管")
            {
                type = BusinessTypeEnum.PM035.Value;
            }

            List<OqlParam> listParam = new List<OqlParam>();
            listParam.Add(new OqlParam("Org", UFIDA.U9.Base.Context.LoginOrg.ID));
            listParam.Add(new OqlParam("Type", type));
            listParam.Add(new OqlParam("VendorCode", vendorCode));

            string oql = "Org=@Org and BizType=@Type and Status=5 and Supplier.Supplier.Code=@VendorCode and RcvLines.APLastConfrimPostPeriod is null ";

            if (!string.IsNullOrEmpty(bpObj.SRMRcvQueryDTO.CPersonCode))
            {
                oql += " and RcvLines.PurOper.Code like @CPersonCode ";
                listParam.Add(new OqlParam("CPersonCode", "%" + bpObj.SRMRcvQueryDTO.CPersonCode + "%"));
            }

            if (!string.IsNullOrEmpty(bpObj.SRMRcvQueryDTO.DocNo))
            {
                oql += " and DocNo like @DocNo ";
                listParam.Add(new OqlParam("DocNo", "%" + bpObj.SRMRcvQueryDTO.DocNo + "%"));
            }

            if (bpObj.SRMRcvQueryDTO.InDateFrom != null)
            {
                oql += " and RcvLines.ConfirmDate >= @InDateFrom";
                listParam.Add(new OqlParam("InDateFrom", bpObj.SRMRcvQueryDTO.InDateFrom));
            }

            if (bpObj.SRMRcvQueryDTO.InDateTo != null)
            {
                oql += " and RcvLines.ConfirmDate <= @InDateTo";
                listParam.Add(new OqlParam("InDateTo", bpObj.SRMRcvQueryDTO.InDateTo));
            }

            Receivement.EntityList listRcv = Receivement.Finder.FindAll(oql, listParam.ToArray());
            List<SRMRcvDTO> result = new List<SRMRcvDTO>();
            foreach (Receivement rcv in listRcv)
            {
                //OQL查询有bug，有时候查出的数据有重复，排除掉重复项
                SRMRcvDTO haveAddedDTO = result.Find(delegate(SRMRcvDTO p) { return p.ID == rcv.ID; });
                if (haveAddedDTO != null)
                {
                    continue;
                }

                SRMRcvDTO headDto = new SRMRcvDTO();

                headDto.ID = rcv.ID;
                headDto.DocNo = rcv.DocNo;//单号
                headDto.STNO = rcv.DescFlexField.PrivateDescSeg3;
                headDto.Type = rcv.BizType == BusinessTypeEnum.PM005 ? "正常" : "代管";
                headDto.Status = rcv.Status.Value.ToString();//单据状态
                headDto.InType = rcv.BizType == BusinessTypeEnum.PM005 ? "普通采购" : "代管采购";//入库类型
                headDto.VendorCode = rcv.Supplier.Supplier.Code;//供应商.编码
                headDto.SrmRcvLine = new List<SrmRcvLineDTO>();

                string oql1 = "Receivement.ID=@ID and IsPresent=0";
                RcvLine.EntityList listLine = RcvLine.Finder.FindAll(oql1, new OqlParam[] { new OqlParam("ID", rcv.ID) });

                foreach (RcvLine line in listLine)
                {
                    headDto.InDate = line.ConfirmDate;//行.入库确认日                       
                    headDto.CPersonCode = line.PurOper != null ? line.PurOper.Code : "";//行.采购员                        
                    headDto.CMaker = line.WhMan != null ? line.WhMan.Code : "";//库管员
                    headDto.WareHouser = line.Wh != null ? line.Wh.Code : "";//行.存储地点                                      

                    SrmRcvLineDTO lineDto = new SrmRcvLineDTO();
                    lineDto.SRMRcvDTO = headDto;
                    lineDto.ID = line.ID;//ID
                    lineDto.LineNum = line.DocLineNo;//行号
                    lineDto.ItemCode = line.ItemInfo.ItemCode;//料品.料号
                    lineDto.InQty = rcv.ReceivementType == UFIDA.U9.CBO.SCM.Enums.ReceivementTypeEnum.RCV ? line.ArriveQtyTU : -line.RejectQtyTU;//数量（根据收货类型不同、获取字段不同）
                    lineDto.Price = line.FinallyPriceTC;//最终价

                    headDto.SrmRcvLine.Add(lineDto);
                }

                result.Add(headDto);
            }
            return result;
        }
    }

    #endregion


}
