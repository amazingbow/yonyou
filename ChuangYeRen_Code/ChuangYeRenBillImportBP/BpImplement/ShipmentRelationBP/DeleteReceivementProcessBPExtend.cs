namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ShipmentRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using PublicDataTransObj;
    using UFIDA.U9.PM.Rcv;
    using UFIDA.U9.ISV.RCV.Proxy;
    using UFIDA.U9.ISV.RCV.DTO;
    using UFIDA.U9.Base;

	/// <summary>
	/// DeleteReceivementProcessBP partial 
	/// </summary>	
	public partial class DeleteReceivementProcessBP 
	{	
		internal BaseStrategy Select()
		{
			return new DeleteReceivementProcessBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class DeleteReceivementProcessBPImpementStrategy : BaseStrategy
	{
		public DeleteReceivementProcessBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			DeleteReceivementProcessBP bpObj = (DeleteReceivementProcessBP)obj;

            PublicReturnDTO pub = new PublicReturnDTO();
            pub.Flag = false;
            pub.Message = "";

            try
            {
                Receivement receivement = Receivement.Finder.FindByID(bpObj.RelationU9Id);
                if (receivement != null)
                {
                    //如果状态是业务关闭5，也就是审核了，需要先弃审再删除
                    if (receivement.Status.Value == 5)
                    {
                        pub.DocID = receivement.ID;
                        pub.DocNo = receivement.DocNo;
                        ApproveRCVSRVProxy approvedProxy = new ApproveRCVSRVProxy();
                        approvedProxy.ActType = 9;//9为弃审
                        approvedProxy.RCVLogicKeyINFOs = new List<RCVLogicKeyINFOData>();
                        RCVLogicKeyINFOData infoData = new RCVLogicKeyINFOData();
                        infoData.DocNo = receivement.DocNo;
                        infoData.Org = Context.LoginOrg.ID;
                        infoData.RcvID = receivement.ID;
                        approvedProxy.RCVLogicKeyINFOs.Add(infoData);
                        approvedProxy.Do();
                        DeleteRCVSRVProxy deleteProxy = new DeleteRCVSRVProxy();
                        deleteProxy.RCVKeyList = new List<long>();
                        deleteProxy.RCVKeyList.Add(receivement.ID);
                        deleteProxy.Do();
                        pub.Flag = true;
                        pub.Message = "删除成功！";
                    }
                    //如果状态不是业务关闭，直接做删除
                    else
                    {
                        pub.DocID = receivement.ID;
                        pub.DocNo = receivement.DocNo;
                        DeleteRCVSRVProxy deleteProxy = new DeleteRCVSRVProxy();
                        deleteProxy.RCVKeyList = new List<long>();
                        deleteProxy.RCVKeyList.Add(receivement.ID);
                        deleteProxy.Do();
                        pub.Flag = true;
                        pub.Message = "删除成功！";
                    }
                }
                else
                {
                    pub.Flag = false;
                    pub.Message = "删除失败！失败信息：在U9收货单没有找到对应的单据：ID：" + bpObj.RelationU9Id + "！";
                }
            }
            catch (Exception ex)
            {
                pub.Flag = false;
                pub.Message = "删除失败！失败信息：" + ex.Message;
            }

            return pub;
		}		
	}

	#endregion
	
	
}