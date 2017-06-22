namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.Util.Context;

	/// <summary>
	/// ModifyAdvApproveStatusBP partial 
	/// </summary>	
	public partial class ModifyAdvApproveStatusBP 
	{	
		internal BaseStrategy Select()
		{
			return new ModifyAdvApproveStatusBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ModifyAdvApproveStatusBPImpementStrategy : BaseStrategy
	{
		public ModifyAdvApproveStatusBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			ModifyAdvApproveStatusBP bpObj = (ModifyAdvApproveStatusBP)obj;
            bool retbool = false;

            AdvApproveBE advApprove = AdvApproveBE.Finder.FindByID(bpObj.ID);
            if (advApprove != null)
            {
                if (advApprove.SysVersion == bpObj.SysVersion)
                {
                    using (ISession session = Session.Open())
                    {
                        if (advApprove.AdvApproveDocType.ApproveType == Base.Doc.ApproveTypeEnum.WorkFlow)
                        {
                            #region 工作流审批
                            switch (advApprove.DocStatus.Value)
                            {
                                case 0:
                                    advApprove.StateMachineInstance.OpenLState_SubmitEventDriven(new SubmitEvent());
                                    break;
                                case 1:
                                    //调用工作流的标准审批页面，不是单据控制的
                                    break;
                                case 2:
                                    advApprove.StateMachineInstance.ApprovedState_UndoApproveEventDriven(new UndoApproveEvent());
                                    break;
                            }
                            #endregion
                        }
                        else
                        {
                            #region 确认作业
                            switch (advApprove.DocStatus.Value)
                            {
                                case 0:
                                    advApprove.DocStatus = AdvAppStatusEnum.Approving;
                                    break;
                                case 1:
                                    advApprove.DocStatus = AdvAppStatusEnum.Approved;
                                    break;
                                case 2:
                                    advApprove.DocStatus = AdvAppStatusEnum.OpenL;
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