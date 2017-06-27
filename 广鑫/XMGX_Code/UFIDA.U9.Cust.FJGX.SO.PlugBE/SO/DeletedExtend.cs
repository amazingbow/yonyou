using UFIDA.U9.Cust.FJGX.SM.PlugBE.Common;
using UFSoft.UBF.Business;
using UFSoft.UBF.Eventing;

namespace UFIDA.U9.Cust.FJGX.SM.PlugBE.SO
{
    internal class DeletedExtend : IEventSubscriber
    {
        #region IEventSubscriber ≥…‘±

        public void Notify(params object[] args)
        {
            if (args == null || args.Length == 0 || !(args[0] is EntityEvent))
                return;
            BusinessEntity.EntityKey key = ((EntityEvent)args[0]).EntityKey;
            if (key == null) return;
            U9.SM.SO.SO soEntity = key.GetEntity() as U9.SM.SO.SO;
            if (soEntity == null) return;
            ProjectHelper.DeleteProject(soEntity);
        }

        #endregion
    }
}