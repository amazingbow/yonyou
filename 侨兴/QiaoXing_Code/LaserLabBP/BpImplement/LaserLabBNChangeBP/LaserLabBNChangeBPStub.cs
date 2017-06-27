







namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ServiceModel;
	using System.Runtime.Serialization;
	using System.IO;
	using UFSoft.UBF.Util.Context;
	using UFSoft.UBF;
	using UFSoft.UBF.Exceptions;
	using UFSoft.UBF.Service.Base ;

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.ILaserLabBNChangeBP")]
    public interface ILaserLabBNChangeBP
    {
	[OperationContract()]
        System.String Do(UFSoft.UBF.Service.ISVContext context ,List<System.String> lB, System.String bN, System.String amendBN);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class LaserLabBNChangeBPStub : ISVStubBase, ILaserLabBNChangeBP
    {
        #region ILaserLabBNChangeBP Members

        //[OperationBehavior]
        public System.String Do(UFSoft.UBF.Service.ISVContext context , List<System.String> lB, System.String bN, System.String amendBN)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context);
			return DoEx(commonData, lB, bN, amendBN);
        }
        
        //[OperationBehavior]
        public System.String DoEx(ICommonDataContract commonData, List<System.String> lB, System.String bN, System.String amendBN)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LaserLabBNChangeBP");                
                LaserLabBNChangeBP objectRef = new LaserLabBNChangeBP();
			
				objectRef.LB = lB;
				objectRef.BN = bN;
				objectRef.AmendBN = amendBN;

				//处理返回类型.
				System.String result = objectRef.Do();
				return result ;
						return result;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LaserLabBNChangeBP");
            }
        }
	#endregion
    }
}
