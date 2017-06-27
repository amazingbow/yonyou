using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFIDA.U9.CBO.SCM.Item;

namespace UFIDA.U9.Cust.FJGX.SO.PlugBE.Common
{
    public static class ItemMasterHelper
    {

        /// <summary>
        /// 获取现有的项目号档案
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static ItemMaster GetItemMasterByCode(string code)
        {
            ItemMaster itemMaster = ItemMaster.Finder.FindByBusinessKey(Base.Context.LoginOrg, code);
            return itemMaster;
        }
    }
}
