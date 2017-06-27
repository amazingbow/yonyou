using UFSoft.UBF.Business;
using UFSoft.UBF.Eventing;

namespace UFIDA.U9.Cust.FJGX.SM.PlugBE.SO
{
    internal class AfterInsertingExtend : IEventSubscriber
    {
        #region IEventSubscriber 成员

        public void Notify(params object[] args)
        {
            if (args == null || args.Length == 0 || !(args[0] is EntityEvent))
                return;
            BusinessEntity.EntityKey key = ((EntityEvent) args[0]).EntityKey;
            if (key == null) return;
            U9.SM.SO.SO currentSo = key.GetEntity() as U9.SM.SO.SO;
            if (currentSo == null) return;
            AfterDefaultValueExtend.SetValue_Project(currentSo); //设置项目号的值
        }

        #endregion
    }
}