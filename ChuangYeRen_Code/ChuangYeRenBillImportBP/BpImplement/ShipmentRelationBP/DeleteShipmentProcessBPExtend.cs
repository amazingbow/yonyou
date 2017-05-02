namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ShipmentRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using PublicDataTransObj;
    using UFIDA.U9.SM.Ship;
    using UFIDA.U9.ISV.SM.Proxy;
    using UFIDA.U9.ISV.SM;
    using UFIDA.U9.SM.Ship.Proxy;

	/// <summary>
	/// DeleteShipmentProcessBP partial 
	/// </summary>	
	public partial class DeleteShipmentProcessBP 
	{	
		internal BaseStrategy Select()
		{
			return new DeleteShipmentProcessBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class DeleteShipmentProcessBPImpementStrategy : BaseStrategy
	{
		public DeleteShipmentProcessBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			DeleteShipmentProcessBP bpObj = (DeleteShipmentProcessBP)obj;

            PublicReturnDTO pub = new PublicReturnDTO();
            pub.Flag = false;
            pub.Message = "";

            try
            {
                Ship ship = Ship.Finder.FindByID(bpObj.RelationU9Id);
                if (ship != null)
                {
                    //如果状态是已核准3，也就是审核了，需要先弃审再删除
                    if (ship.Status.Value == 3)
                    {
                        pub.DocID = ship.ID;
                        pub.DocNo = ship.DocNo;
                        ShipmentApproveProxy approvedProxy = new ShipmentApproveProxy();
                        approvedProxy.IsUnApprove = true;
                        approvedProxy.ShipmentKey = pub.DocID;
                        approvedProxy.SysVersion = ship.SysVersion;
                        approvedProxy.Do();
                        DeleteShipProxy deleteProxy = new DeleteShipProxy();
                        deleteProxy.ShipIDs = new List<long>();
                        deleteProxy.ShipIDs.Add(pub.DocID);
                        deleteProxy.Do();
                        pub.Flag = true;
                        pub.Message = "删除成功！";
                    }
                    //如果状态不是业务关闭，直接做删除
                    else
                    {
                        pub.DocID = ship.ID;
                        pub.DocNo = ship.DocNo;
                        DeleteShipProxy deleteProxy = new DeleteShipProxy();
                        deleteProxy.ShipIDs = new List<long>();
                        deleteProxy.ShipIDs.Add(pub.DocID);
                        deleteProxy.Do();
                        pub.Flag = true;
                        pub.Message = "删除成功！";
                    }
                }
                else
                {
                    pub.Flag = false;
                    pub.Message = "删除失败！失败信息：在U9出货单没有找到对应的单据：ID：" + bpObj.RelationU9Id + "！";
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