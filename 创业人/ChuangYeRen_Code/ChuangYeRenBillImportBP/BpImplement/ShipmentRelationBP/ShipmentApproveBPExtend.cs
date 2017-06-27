namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ShipmentRelationBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using PublicDataTransObj;
    using UFIDA.U9.SM.Ship;
    using UFIDA.U9.SM.Ship.Proxy;
    using UFIDA.U9.SM.Common;
    using UFSoft.UBF.PL.Engine;
    using UFIDA.U9.ISV.SM.Proxy;
    using UFIDA.U9.ISV.SM;

	/// <summary>
	/// ShipmentApproveBP partial 
	/// </summary>	
	public partial class ShipmentApproveBP 
	{	
		internal BaseStrategy Select()
		{
			return new ShipmentApproveBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ShipmentApproveBPImpementStrategy : BaseStrategy
	{
		public ShipmentApproveBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			ShipmentApproveBP bpObj = (ShipmentApproveBP)obj;

            PublicReturnDTO pub = new PublicReturnDTO();
            pub.Flag = false;
            pub.Message = "";

            Ship ship = Ship.Finder.FindByID(bpObj.RelationU9Id);
            if (ship != null)
            {
                pub.DocID = ship.ID;
                pub.DocNo = ship.DocNo;
                ShipmentApproveProxy approvedProxy = new ShipmentApproveProxy();
                approvedProxy.IsUnApprove = false;
                approvedProxy.ShipmentKey = pub.DocID;
                approvedProxy.SysVersion = ship.SysVersion;
                ErrorMessageDTOData errordata = approvedProxy.Do();

                if ((errordata != null) && !string.IsNullOrEmpty(errordata.ErrorMessage))
                {
                    pub.Flag = false;
                    pub.Message = "审核失败！失败信息：" + errordata.ErrorMessage;
                    return pub;
                }
                pub.Flag = true;
                pub.Message = "审核成功！";
            }
            else
            {
                pub.Flag = false;
                pub.Message = "审核失败！失败信息：在U9出货单没有找到对应的单据：ID：" + bpObj.RelationU9Id + "！";
            }

            return pub;
		}		
	}

	#endregion
	
	
}