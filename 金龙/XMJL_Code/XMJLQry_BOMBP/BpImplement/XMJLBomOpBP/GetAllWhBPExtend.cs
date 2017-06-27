namespace UFIDA.U9.Cust.XMJLBomOpBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.CBO.SCM.Warehouse;
    using UFSoft.UBF.PL;
    using UFIDA.U9.Base;
    using UFIDA.U9.Base.UserRole;

    /// <summary>
    /// GetAllWhBP partial 
    /// </summary>	
    public partial class GetAllWhBP
    {
        internal BaseStrategy Select()
        {
            return new GetAllWhBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetAllWhBPImpementStrategy : BaseStrategy
    {
        public GetAllWhBPImpementStrategy() { }

        public override object Do(object obj)
        {
            GetAllWhBP bpObj = (GetAllWhBP)obj;

            //get business operation context is as follows
            //IContext context = ContextManager.Context	

            //auto generating code end,underside is user custom code
            //and if you Implement replace this Exception Code...
            var user=User.Finder.FindByID(Context.LoginUserID);
            var houseList = Warehouse.Finder.FindAll(" Org=" + bpObj.Org
                + " and DescFlexField.PrivateDescSeg1 like '%" + user.Code + "%'", null);
            List<WarehouseDTO> whList = new List<WarehouseDTO>();
            if (houseList == null) return null;
            for (int i = 0; i < houseList.Count; i++)
            {
                var item = houseList[i];
                WarehouseDTO dto = new WarehouseDTO
                {
                    ID = item.ID,
                    Code = item.Code,
                    Name = item.Name
                };
                whList.Add(dto);
            }
            return whList;
        }
    }

    #endregion


}