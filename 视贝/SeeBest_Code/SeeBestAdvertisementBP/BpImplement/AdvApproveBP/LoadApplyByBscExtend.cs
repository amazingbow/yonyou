namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE;
    using UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;

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
            AdvApplyBE.EntityList applyLst = AdvApplyBE.Finder.FindAll("ApplyDept.ID=" + bpObj.CustBscID
                + " and (ApplyDate>='" + bpObj.StartDate.ToString("yyyy-MM-dd") + "' and ApplyDate<='" + bpObj.EndDate.ToString("yyyy-MM-dd 23:59:59") + "')");
            SpecialApplyBE.EntityList speLst = SpecialApplyBE.Finder.FindAll("ApplyDept.ID=" + bpObj.CustBscID
                + " and (ApplyDate>='" + bpObj.StartDate.ToString("yyyy-MM-dd") + "' and ApplyDate<='" + bpObj.EndDate.ToString("yyyy-MM-dd 23:59:59") + "')");
            foreach (var app in applyLst)
            {
                //app.ApplyDate
                ApplyInfoDto appDto = new ApplyInfoDto();
                appDto.Location = app.LocationQY;
                if (app.ApplyDept != null)
                {
                    appDto.AdvAppCustName = app.ApplyDept.Name;
                }
                else
                {
                    appDto.AdvAppCustName = "";
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
                }
                else
                {
                    appDto.AdvCarrier = "";
                }
                appDto.ApplyId = app.ID;
                foreach (var item in app.AdvAboutBE)
                {
                    appDto.AdvItem += item.Description + "/";
                }
                appDto.AdvItem = appDto.AdvItem.TrimEnd('/');
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
                    }
                    else
                    {
                        appDto1.AdvCarrier = "";
                    }
                    appDto1.ApplyId = app.ID;
                    foreach (var item in app.AdvAboutBE)
                    {
                        appDto1.AdvItem += item.Description + "/";
                    }
                    appDto1.AdvItem = appDto1.AdvItem.TrimEnd('/');
                    appDtoLst.Add(appDto1);
                }

                #endregion

            }
            foreach (var spe in speLst)
            {
                foreach (var item in spe.SpecialSizeBE)
                {
                    ApplyInfoDto appDto = new ApplyInfoDto();
                    if (spe.ApplyDept != null)
                    {
                        appDto.AdvAppCustName = spe.ApplyDept.Name;
                    }
                    else
                    {
                        appDto.AdvAppCustName = "";
                    }
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
                    }
                    else
                    {
                        appDto.AdvCarrier = "";
                    }
                    if (item.DisplayProductType != null)
                    {
                        appDto.AdvItem = item.DisplayProductType.Description;
                    }
                    else
                    {
                        appDto.AdvItem = "";
                    }
                    appDto.ApplyId = spe.ID;
                    appDtoLst.Add(appDto);
                }
            }
            return appDtoLst;
        }
    }

    #endregion


}