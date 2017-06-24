namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE;
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
            DateTime d1 = new DateTime(2017, 07, 1);
            DateTime d2 = d1.AddMonths(1).AddDays(-1);
            AdvApplyBE.EntityList applyLst = AdvApplyBE.Finder.FindAll("ApplyDept.ID=" + bpObj.CustBscID
                + " and (ApplyDate>='" + d1.ToString("yyyy-MM-dd") + "' and ApplyDate<='" + d2.ToString("yyyy-MM-dd") + "'");

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
                    RelPhone = app.RelPeople,
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
            return appDtoLst;
        }
    }

    #endregion


}