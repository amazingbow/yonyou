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
            AdvApplyBE.EntityList applyLst = AdvApplyBE.Finder.FindAll("ApplyDept.ID=" + bpObj.CustBscID
                + " and (ApplyDate>='" + bpObj.StartDate.ToString("yyyy-MM-dd") + "' and ApplyDate<='" + bpObj.EndDate.ToString("yyyy-MM-dd") + "')");
            SpecialApplyBE.EntityList speLst = SpecialApplyBE.Finder.FindAll("ApplyDept.ID=" + bpObj.CustBscID
                + " and (ApplyDate>='" + bpObj.StartDate.ToString("yyyy-MM-dd") + "' and ApplyDate<='" + bpObj.EndDate.ToString("yyyy-MM-dd") + "')");
            foreach (var app in applyLst)
            {
                //app.ApplyDate
                ApplyInfoDto appDto = new ApplyInfoDto
                {
                    Location = app.LocationQY,
                    AdvAppCustName = app.ApplyDept.Name,
                    Country = app.LocationXZ,
                    CustCounterName = app.CustConterName,
                    RelPeople = app.RelPeople,
                    RelPhone = app.Phone,
                    CustAddress = app.CustAddress,
                    Width = app.BMWidth,
                    Thick = app.BMThick,
                    Height = app.BMHight,
                    ApplyAdvCode = app.AdvCode,
                    AdvCarrier = app.AdvCarrier.Name,
                    ApplyId = app.ID
                };
                foreach (var item in app.AdvAboutBE)
                {
                    appDto.AdvItem += item.Description + "/";
                }
                appDto.AdvItem = appDto.AdvItem.TrimEnd('/');
                appDtoLst.Add(appDto);
            }
            foreach (var spe in speLst)
            {
                foreach (var item in spe.SpecialSizeBE)
                {
                    ApplyInfoDto appDto = new ApplyInfoDto
                    {
                        AdvAppCustName = spe.ApplyDept.Name,
                        CustCounterName = spe.CustConterName,
                        RelPhone = spe.Phone,
                        CustAddress = spe.CustAddress,
                        Width = item.Width,
                        Thick = item.Thick,
                        Height = item.Hight,
                        ApplyAdvCode = spe.AdvCode,
                        AdvItem = item.DisplayProductType.Code,
                        ApplyId = spe.ID
                    };
                    appDtoLst.Add(appDto);
                }
            }
            return appDtoLst;
        }
    }

    #endregion


}