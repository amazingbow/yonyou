namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.SpecialApplyBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE;
    using UFSoft.UBF.Business;

	/// <summary>
	/// UpdateSpecialApplyStatus partial 
	/// </summary>	
	public partial class UpdateSpecialApplyStatus 
	{	
		internal BaseStrategy Select()
		{
			return new UpdateSpecialApplyStatusImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class UpdateSpecialApplyStatusImpementStrategy : BaseStrategy
	{
		public UpdateSpecialApplyStatusImpementStrategy() { }

		public override object Do(object obj)
		{						
			UpdateSpecialApplyStatus bpObj = (UpdateSpecialApplyStatus)obj;

            bool retbool = false;

            SpecialApplyBE SpecialApply = SpecialApplyBE.Finder.FindByID(bpObj.ID);
            if (SpecialApply != null)
            {
                if (SpecialApply.SysVersion == bpObj.SysVersion)
                {
                    using (ISession session = Session.Open())
                    {
                        if (SpecialApply.SpecialApplyDocType.ApproveType == Base.Doc.ApproveTypeEnum.WorkFlow)
                        {
                            #region 工作流审批
                            switch (SpecialApply.Status.Value)
                            {
                                case 0:
                                    SpecialApply.StateMachineInstance.OpenLState_SubmitEventDriven(new SubmitEvent());
                                    break;
                                case 1:
                                    //调用工作流的标准审批页面，不是单据控制的
                                    break;
                                case 2:
                                    SpecialApply.StateMachineInstance.ApprovedState_UndoApproveEventDriven(new UndoApproveEvent());
                                    break;
                            }
                            #endregion
                        }
                        else
                        {
                            #region 确认作业
                            switch (SpecialApply.Status.Value)
                            {
                                case 0:
                                    SpecialApply.Status = SpecialApplyStatusEnum.Approving;
                                    break;
                                case 1:
                                    SpecialApply.Status = SpecialApplyStatusEnum.Approved;
                                    break;
                                case 2:
                                    SpecialApply.Status = SpecialApplyStatusEnum.OpenL;
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