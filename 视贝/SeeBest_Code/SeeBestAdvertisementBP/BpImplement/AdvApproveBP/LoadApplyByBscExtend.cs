namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE;
    using UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE;

    /// <summary>
    /// LoadApplyByBsc partial 
    /// </summary>	
    public partial class LoadApplyByBsc
    {
        internal BaseStrategy Select()
        {
            return new LoadApplyByBscImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class LoadApplyByBscImpementStrategy : BaseStrategy
    {
        public LoadApplyByBscImpementStrategy() { }

        public override object Do(object obj)
        {
            LoadApplyByBsc bpObj = (LoadApplyByBsc)obj;
            List<ApplyInfoDto> appDtoLst = new List<ApplyInfoDto>();
            if (true)
            {
                
            }
            AdvApproveLine.EntityList approveLineLst = AdvApproveLine.Finder.FindAll("1=1");
            string strIDLst = "";
            foreach (var approveLine in approveLineLst)
            {
                strIDLst = strIDLst + approveLine.OtherInfo.ToString() + ",";
            }
            strIDLst = strIDLst.TrimEnd(',');
            AdvApplyBE.EntityList applyLst;
            SpecialApplyBE.EntityList speLst;
            if (strIDLst == "" || string.IsNullOrEmpty(strIDLst))
            {
                applyLst = AdvApplyBE.Finder.FindAll("ApplyDept.ID=" + bpObj.CustBscID
                    + " and DocStatus=2 and (ApplyDate>='" + bpObj.StartDate.ToString("yyyy-MM-dd") + "' and ApplyDate<='" + bpObj.EndDate.ToString("yyyy-MM-dd 23:59:59") + "')");
                speLst = SpecialApplyBE.Finder.FindAll("ApplyDept.ID=" + bpObj.CustBscID
                    + " and Status=2 and (ApplyDate>='" + bpObj.StartDate.ToString("yyyy-MM-dd") + "' and ApplyDate<='" + bpObj.EndDate.ToString("yyyy-MM-dd 23:59:59") + "')");
            }
            else
            {
                strIDLst = "(" + strIDLst + ")";
                applyLst = AdvApplyBE.Finder.FindAll("ApplyDept.ID=" + bpObj.CustBscID
                    + " and (ID not in " + strIDLst
                    + ") and DocStatus=2 and (ApplyDate>='" + bpObj.StartDate.ToString("yyyy-MM-dd") + "' and ApplyDate<='" + bpObj.EndDate.ToString("yyyy-MM-dd 23:59:59") + "')");
                speLst = SpecialApplyBE.Finder.FindAll("ApplyDept.ID=" + bpObj.CustBscID
                    + " and (ID not in " + strIDLst
                    + ") and Status=2 and (ApplyDate>='" + bpObj.StartDate.ToString("yyyy-MM-dd") + "' and ApplyDate<='" + bpObj.EndDate.ToString("yyyy-MM-dd 23:59:59") + "')");
            }
            foreach (var app in applyLst)
            {
                //app.ApplyDate
                ApplyInfoDto appDto = new ApplyInfoDto();
                appDto.Location = app.LocationQY;
                string strVerificationLevel = "";
                string strAdvCarrierCode = "";
                if (app.ApplyDept != null)
                {
                    appDto.AdvAppCustName = app.ApplyDept.Name;
                    strVerificationLevel = app.ApplyDept.DescFlexField.PrivateDescSeg13;
                }
                else
                {
                    appDto.AdvAppCustName = "";
                    strVerificationLevel = "";
                }
                appDto.Country = app.LocationXZ;
                appDto.CustCounterName = app.CustConterName;
                appDto.RelPeople = app.RelPeople;
                appDto.RelPhone = app.CustPhone;
                appDto.CustAddress = app.CustAddress;
                appDto.Width = app.BMWidth;
                appDto.Thick = app.BMThick;
                appDto.Height = app.BMHight;
                appDto.Area = app.BMArea;
                appDto.ApplyQty = app.Qty;
                appDto.ApplyAdvCode = app.AdvCode;
                if (app.AdvCarrier != null)
                {
                    appDto.AdvCarrier = app.AdvCarrier.Name;
                    appDto.AdvCarrierCode = app.AdvCarrier.Code;
                    strAdvCarrierCode = app.AdvCarrier.Code;
                }
                else
                {
                    appDto.AdvCarrier = "";
                    appDto.AdvCarrierCode = "";
                    strAdvCarrierCode = "";
                }
                #region 根据办事处核销等级、广告载体物料自动匹配广告载体报销价目表的价格
                decimal deActualPrice = 0M;
                if (string.IsNullOrEmpty(strVerificationLevel) || string.IsNullOrEmpty(strAdvCarrierCode))
                {
                    deActualPrice = 0;
                }
                else
                {
                    UFIDA.U9.SPR.SalePriceList.SalePriceLine salePriceLine = UFIDA.U9.SPR.SalePriceList.SalePriceLine.Finder.Find("DescFlexField.PubDescSeg2='" + strVerificationLevel
                + "' and ItemInfo.ItemCode='" + strAdvCarrierCode
                + "' and (ToDate>='" + app.ApplyDate.ToString("yyyy-MM-dd") + "' and FromDate<='" + app.ApplyDate.ToString("yyyy-MM-dd 23:59:59") + "')");
                    if (salePriceLine != null)
                    {
                        deActualPrice = salePriceLine.Price;
                    }
                }
                #endregion
                //appDto.ActualPrice = deActualPrice;
                appDto.ActualPrice = 0;
                appDto.ApplyId = app.ID;
                appDto.Memo = "";
                appDto.ApplyDate = app.ApplyDate;
                foreach (var item in app.AdvAboutBE)
                {
                    appDto.AdvItem += item.Code + "/";
                }
                if (appDto.AdvItem != null)
                {
                    appDto.AdvItem = appDto.AdvItem.TrimEnd('/');
                }
                else
                {
                    appDto.AdvItem = "";
                }
                appDtoLst.Add(appDto);

                #region 如果广告申请单封底的面积>0，再新增一行数据
                if (app.DZArea > 0)
                {
                    ApplyInfoDto appDto1 = new ApplyInfoDto();
                    appDto1.Location = app.LocationQY;
                    if (app.ApplyDept != null)
                    {
                        appDto1.AdvAppCustName = app.ApplyDept.Name;
                    }
                    else
                    {
                        appDto1.AdvAppCustName = "";
                    }
                    appDto1.Country = app.LocationXZ;
                    appDto1.CustCounterName = app.CustConterName;
                    appDto1.RelPeople = app.RelPeople;
                    appDto1.RelPhone = app.CustPhone;
                    appDto1.CustAddress = app.CustAddress;
                    appDto1.Width = app.DZWidth;
                    appDto1.Thick = app.DZThick;
                    appDto1.Height = 0;
                    appDto1.Area = app.DZArea;
                    appDto1.ApplyQty = 0;
                    appDto1.ApplyAdvCode = app.AdvCode;
                    if (app.AdvCarrier != null)
                    {
                        appDto1.AdvCarrier = app.AdvCarrier.Name;
                        appDto1.AdvCarrierCode = app.AdvCarrier.Code;
                    }
                    else
                    {
                        appDto1.AdvCarrier = "";
                        appDto1.AdvCarrierCode = "";
                    }
                    //appDto1.ActualPrice = deActualPrice;
                    appDto1.ActualPrice = 0;
                    appDto1.ApplyId = app.ID;
                    appDto1.Memo = "封底";
                    appDto1.ApplyDate = app.ApplyDate;
                    foreach (var item in app.AdvAboutBE)
                    {
                        appDto1.AdvItem += item.Code + "/";
                    }
                    if (appDto1.AdvItem != null)
                    {
                        appDto1.AdvItem = appDto1.AdvItem.TrimEnd('/');
                    }
                    else
                    {
                        appDto1.AdvItem = "";
                    }
                    appDtoLst.Add(appDto1);
                }

                #endregion

            }
            foreach (var spe in speLst)
            {
                foreach (var item in spe.SpecialSizeBE)
                {
                    ApplyInfoDto appDto = new ApplyInfoDto();
                    string strVerificationLevel = "";
                    string strAdvCarrierCode = "";
                    if (spe.ApplyDept != null)
                    {
                        appDto.AdvAppCustName = spe.ApplyDept.Name;
                        strVerificationLevel = spe.ApplyDept.DescFlexField.PrivateDescSeg13;
                    }
                    else
                    {
                        appDto.AdvAppCustName = "";
                        strVerificationLevel = "";
                    }
                    appDto.Location = spe.LocationQY;
                    appDto.Country = spe.LocationXZ;
                    appDto.RelPeople = spe.CustName;
                    appDto.CustCounterName = spe.CustConterName;
                    appDto.RelPhone = spe.CustPhone;
                    appDto.CustAddress = spe.CustAddress;
                    appDto.Width = item.Width;
                    appDto.Thick = item.Thick;
                    appDto.Height = item.Hight;
                    appDto.Area = item.Area;
                    appDto.ApplyQty = item.Qty;
                    appDto.ApplyAdvCode = spe.AdvCode;
                    if (item.AdvCarrier != null)
                    {
                        appDto.AdvCarrier = item.AdvCarrier.Name;
                        appDto.AdvCarrierCode = item.AdvCarrier.Code;
                        strAdvCarrierCode = item.AdvCarrier.Code;
                    }
                    else
                    {
                        appDto.AdvCarrier = "";
                        appDto.AdvCarrierCode = "";
                        strAdvCarrierCode = "";
                    }
                    #region 根据办事处核销等级、广告载体物料自动匹配广告载体报销价目表的价格
                    decimal deActualPrice = 0M;
                    if (string.IsNullOrEmpty(strVerificationLevel) || string.IsNullOrEmpty(strAdvCarrierCode))
                    {
                        deActualPrice = 0;
                    }
                    else
                    {
                        UFIDA.U9.SPR.SalePriceList.SalePriceLine salePriceLine = UFIDA.U9.SPR.SalePriceList.SalePriceLine.Finder.Find("DescFlexField.PubDescSeg2='" + strVerificationLevel
                + "' and ItemInfo.ItemCode='" + strAdvCarrierCode
                + "' and (ToDate>='" + spe.ApplyDate.ToString("yyyy-MM-dd") + "' and FromDate<='" + spe.ApplyDate.ToString("yyyy-MM-dd 23:59:59") + "')");
                        if (salePriceLine != null)
                        {
                            deActualPrice = salePriceLine.Price;
                        }
                    }
                    #endregion
                    //appDto.ActualPrice = deActualPrice;
                    appDto.ActualPrice = 0;
                    if (item.DisplayProductType != null)
                    {
                        appDto.AdvItem = item.DisplayProductType.Description;
                    }
                    else
                    {
                        appDto.AdvItem = "";
                    }
                    appDto.ApplyId = spe.ID;
                    appDto.Memo = "";
                    appDto.ApplyDate = spe.ApplyDate;
                    appDtoLst.Add(appDto);
                }
            }
            return appDtoLst;
        }
    }

    #endregion


}