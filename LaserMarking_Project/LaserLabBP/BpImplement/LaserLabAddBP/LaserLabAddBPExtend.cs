namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabAddBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.PL;
    using UFSoft.UBF.Util.Context;

	/// <summary>
	/// LaserLabAddBP partial 
	/// </summary>	
	public partial class LaserLabAddBP 
	{	
		internal BaseStrategy Select()
		{
			return new LaserLabAddBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class LaserLabAddBPImpementStrategy : BaseStrategy
	{
		public LaserLabAddBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			LaserLabAddBP bpObj = (LaserLabAddBP)obj;

            var str = "";
            LaserLab laser = LaserLab.Create();
            using (ISession session = Session.Open())
            {
              
                if (UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab.Finder.FindAll("LB=@LB", new OqlParam[] { new OqlParam("LB", bpObj.LB) }).Count >= 1)
                {
                    throw new Exception("镭射标：" + bpObj.LB + "在数据库中已存在相同镭射标！");
                }
                else
                {
                    laser.BN = bpObj.BN;
                    laser.LB = bpObj.LB;
                    laser.Type = bpObj.Type;
                    laser.MasterDT = bpObj.MasterDT;
                    laser.Cp = LBEnum.Master;
                    laser.Customer = bpObj.Customer;
                    str = bpObj.LB;
                    session.Commit();
                }
            }
            return str;
		}		
	}

	#endregion
	
	
}