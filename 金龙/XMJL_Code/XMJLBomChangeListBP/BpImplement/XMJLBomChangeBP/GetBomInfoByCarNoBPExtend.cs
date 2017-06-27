namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.XMJL.BommBE;
    using UFIDA.U9.CBO.SCM.ProjectTask;

    /// <summary>
    /// GetBomInfoByCarNoBP partial 
    /// </summary>	
    public partial class GetBomInfoByCarNoBP
    {
        internal BaseStrategy Select()
        {
            return new GetBomInfoByCarNoBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetBomInfoByCarNoBPImpementStrategy : BaseStrategy
    {
        public GetBomInfoByCarNoBPImpementStrategy() { }

        public override object Do(object obj)
        {
            GetBomInfoByCarNoBP bpObj = (GetBomInfoByCarNoBP)obj;
            List<BomInfoDTO> bomDtoList = new List<BomInfoDTO>();
            //bpObj.CarIdList 
            var bomMainList = Cust_Xmjl_MO_BomMain.Finder.FindAll(" ManufactureNo.Code in ('"
                + string.Join("','", bpObj.CarIdList.ToArray()) + "')");

            foreach (var item in bomMainList)
            {
                if (bomDtoList.FindAll(i => i.CarNoId == item.ManufactureNo.ID).Count > 0)
                    continue;
                BomInfoDTO bomDto = new BomInfoDTO();
                bomDto.CarNoId = item.ManufactureNo.ID;
                bomDto.CarNoCode = item.ManufactureNo.Code;
                bomDto.CarNoName = item.ManufactureNo.Name;
                bomDto.CarType = item.CarType;
                bomDto.ContractNo = item.ContractNo;
                bomDtoList.Add(bomDto);
            }
            var manu = Project.Finder.FindAll(" Code in ('"
            + string.Join("','", bpObj.CarIdList.ToArray()) + "')");
            if (manu.Count == 0) return bomDtoList;
            foreach (var item in manu)
            {
                if (bomDtoList.FindAll(i => i.CarNoId == item.ID).Count > 0)
                    continue;
                BomInfoDTO bomDto = new BomInfoDTO();
                bomDto.CarNoId = item.ID;
                bomDto.CarNoCode = item.Code;
                bomDto.CarNoName = item.Name;
                bomDto.CarType = "";
                bomDto.ContractNo = "";
                bomDtoList.Add(bomDto);
            }
            return bomDtoList;
        }
    }

    #endregion


}