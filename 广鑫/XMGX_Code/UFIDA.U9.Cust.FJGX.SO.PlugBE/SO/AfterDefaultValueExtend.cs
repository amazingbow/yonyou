using UFIDA.U9.CBO.SCM.ProjectTask;
using UFIDA.U9.Cust.FJGX.SM.PlugBE.Common;
using UFIDA.U9.SM.SO;
using UFSoft.UBF.Business;
using UFSoft.UBF.Eventing;
using UFSoft.UBF.PL.Engine;

namespace UFIDA.U9.Cust.FJGX.SM.PlugBE.SO
{
    /// <summary>
    ///     销售订单行-设置项目号的值
    /// </summary>
    public class AfterDefaultValueExtend : IEventSubscriber
    {
        public void Notify(params object[] args)
        {
            if (args == null || args.Length == 0 || !(args[0] is EntityEvent))
                return;
            BusinessEntity.EntityKey key = ((EntityEvent)args[0]).EntityKey;
            if (key == null) return;
            UFIDA.U9.SM.SO.SO currentSo = key.GetEntity() as UFIDA.U9.SM.SO.SO;
            //设置项目号的值
            if (currentSo != null)
            {
                SetValue_Project(currentSo);
            }
        }

        #region 设置项目号值

        internal static void SetValue_Project(U9.SM.SO.SO currentSo)
        {
            foreach (SOLine soLine in currentSo.SOLines)
            {
                //不是新增的不添加
                if (soLine.SysState != ObjectState.Inserted) continue;
                //料品是否有值
                if (soLine.ItemInfo == null || soLine.ItemInfo.ItemIDKey == null) continue;
                //只有满足以下判断条件时才生成项目号，否则不生成项目号：
                //a.判断该料品的编码为125开头的；
                //b.判断该料品对应料品档案上的【批号参数】字段不为空；
                //这两个条件只要满足一个则生成项目号，否则不生成。

                //2017年3月6日 15:21:27 添加两个830，831开头的
                if (soLine.ItemInfo.ItemCode.Substring(0, 3) != "125" && soLine.ItemInfo.ItemCode.Substring(0, 3) != "830"
                    && soLine.ItemInfo.ItemCode.Substring(0, 3) != "831" && soLine.ItemInfo.ItemID.InventoryInfo.LotParam == null) continue;
                //获取项目编码
                string projectCode = currentSo.DocNo + soLine.DocLineNo;
                //创建项目档案
                Project project = ProjectHelper.GetProjectByCode(projectCode) ??
                                  ProjectHelper.CreateProject(projectCode);
                if (project == null) continue;
                //赋值给销售订单行
                soLine.Project = project;
                soLine.ProjectKey = project.Key;
                //赋值给销售订单子行
                foreach (SOShipline soShipline in soLine.SOShiplines)
                {
                    soShipline.Project = project;
                    soShipline.ProjectKey = project.Key;
                }
            }
        }

        #endregion
    }
}