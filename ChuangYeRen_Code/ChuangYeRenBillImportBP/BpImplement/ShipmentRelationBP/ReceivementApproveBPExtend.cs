namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ShipmentRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using PublicDataTransObj;
    using UFIDA.U9.ISV.RCV.Proxy;
    using UFIDA.U9.ISV.RCV.DTO;
    using UFIDA.U9.Base;
    using UFIDA.U9.PM.Rcv;

	/// <summary>
	/// ReceivementApproveBP partial 
	/// </summary>	
	public partial class ReceivementApproveBP 
	{	
		internal BaseStrategy Select()
		{
			return new ReceivementApproveBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ReceivementApproveBPImpementStrategy : BaseStrategy
	{
		public ReceivementApproveBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			ReceivementApproveBP bpObj = (ReceivementApproveBP)obj;

            PublicReturnDTO pub = new PublicReturnDTO();
            pub.Flag = false;
            pub.Message = "";

            try
            {
                Receivement receivement = Receivement.Finder.FindByID(bpObj.RelationU9Id);
                if (receivement != null)
                {
                    pub.DocID = receivement.ID;
                    pub.DocNo = receivement.DocNo;
                    ApproveRCVSRVProxy approvedProxy = new ApproveRCVSRVProxy();
                    approvedProxy.ActType = 8;//8为审核
                    approvedProxy.RCVLogicKeyINFOs = new List<RCVLogicKeyINFOData>();
                    RCVLogicKeyINFOData infoData = new RCVLogicKeyINFOData();
                    infoData.DocNo = receivement.DocNo;
                    infoData.Org = Context.LoginOrg.ID;
                    infoData.RcvID = receivement.ID;
                    approvedProxy.RCVLogicKeyINFOs.Add(infoData);
                    approvedProxy.Do();
                    pub.Flag = true;
                    pub.Message = "审核成功！";
                }
                else
                {
                    pub.Flag = false;
                    pub.Message = "审核失败！失败信息：在U9收货单没有找到对应的单据：ID：" + bpObj.RelationU9Id + "！";
                }
            }
            catch (Exception ex)
            {
                pub.Flag = false;
                DeleteRCVSRVProxy deleteProxy = new DeleteRCVSRVProxy();
                deleteProxy.RCVKeyList = new List<long>();
                deleteProxy.RCVKeyList.Add(pub.DocID);
                deleteProxy.Do();
                pub.Message = "审核失败！相关U9单据" + pub.DocNo + "已经删除！失败信息：" + ex.Message;
                pub.DocID = 0L;
                pub.DocNo = "";
            }

            return pub;
		}		
	}

	#endregion
	
	
}