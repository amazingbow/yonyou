namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApplyBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.Util.Context;

    /// <summary>
    /// ModifyAdvApplyStatusBP partial 
    /// </summary>	
    public partial class ModifyAdvApplyStatusBP
    {
        internal BaseStrategy Select()
        {
            return new ModifyAdvApplyStatusBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ModifyAdvApplyStatusBPImpementStrategy : BaseStrategy
    {
        public ModifyAdvApplyStatusBPImpementStrategy() { }

        public override object Do(object obj)
        {
            ModifyAdvApplyStatusBP bpObj = (ModifyAdvApplyStatusBP)obj;
            bool retbool = false;

            AdvApplyBE advApply = AdvApplyBE.Finder.FindByID(bpObj.ID);
            if (advApply != null)
            {
                if (advApply.SysVersion == bpObj.SysVersion)
                {
                    using (ISession session = Session.Open())
                    {
                        if (advApply.AdvApplyDocType.ApproveType == Base.Doc.ApproveTypeEnum.WorkFlow)
                        {
                            #region 工作流审批
                            switch (advApply.DocStatus.Value)
                            {
                                case 0:
                                    advApply.StateMachineInstance.OpenLState_SubmitEventDriven(new SubmitEvent());
                                    break;
                                case 1:
                                    //调用工作流的标准审批页面，不是单据控制的
                                    break;
                                case 2:
                                    advApply.StateMachineInstance.ApprovedState_UndoApproveEventDriven(new UndoApproveEvent());
                                    break;
                            }
                            #endregion
                        }
                        else
                        {
                            #region 确认作业
                            switch (advApply.DocStatus.Value)
                            {
                                case 0:
                                    advApply.DocStatus = AdvApplyStatusEnum.Approving;
                                    break;
                                case 1:
                                    advApply.DocStatus = AdvApplyStatusEnum.Approved;
                                    break;
                                case 2:
                                    advApply.DocStatus = AdvApplyStatusEnum.OpenL;
                                    break;
                            }
                            #endregion
                        }
                        session.Commit();
                    }
                    retbool = true;
                }
                else
                {
                    throw new Exception("该单据已被修改，请刷新后再操作！");
                }
            }

            return retbool;
        }
    }

    #endregion


}