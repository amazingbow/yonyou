using UFIDA.U9.CBO.SCM.ProjectTask;
using UFIDA.U9.Cust.FJGX.SM.PlugBE.Common;
using UFIDA.U9.SM.SO;
using UFSoft.UBF.Business;
using UFSoft.UBF.Eventing;
using UFSoft.UBF.PL.Engine;

namespace UFIDA.U9.Cust.FJGX.SM.PlugBE.SO
{
    /// <summary>
    ///     ���۶�����-������Ŀ�ŵ�ֵ
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
            //������Ŀ�ŵ�ֵ
            if (currentSo != null)
            {
                SetValue_Project(currentSo);
            }
        }

        #region ������Ŀ��ֵ

        internal static void SetValue_Project(U9.SM.SO.SO currentSo)
        {
            foreach (SOLine soLine in currentSo.SOLines)
            {
                //���������Ĳ����
                if (soLine.SysState != ObjectState.Inserted) continue;
                //��Ʒ�Ƿ���ֵ
                if (soLine.ItemInfo == null || soLine.ItemInfo.ItemIDKey == null) continue;
                //ֻ�����������ж�����ʱ��������Ŀ�ţ�����������Ŀ�ţ�
                //a.�жϸ���Ʒ�ı���Ϊ125��ͷ�ģ�
                //b.�жϸ���Ʒ��Ӧ��Ʒ�����ϵġ����Ų������ֶβ�Ϊ�գ�
                //����������ֻҪ����һ����������Ŀ�ţ��������ɡ�

                //2017��3��6�� 15:21:27 �������830��831��ͷ��
                if (soLine.ItemInfo.ItemCode.Substring(0, 3) != "125" && soLine.ItemInfo.ItemCode.Substring(0, 3) != "830"
                    && soLine.ItemInfo.ItemCode.Substring(0, 3) != "831" && soLine.ItemInfo.ItemID.InventoryInfo.LotParam == null) continue;
                //��ȡ��Ŀ����
                string projectCode = currentSo.DocNo + soLine.DocLineNo;
                //������Ŀ����
                Project project = ProjectHelper.GetProjectByCode(projectCode) ??
                                  ProjectHelper.CreateProject(projectCode);
                if (project == null) continue;
                //��ֵ�����۶�����
                soLine.Project = project;
                soLine.ProjectKey = project.Key;
                //��ֵ�����۶�������
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