







namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabAddBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabAddBP.ILaserLabAddBP")]
    public interface ILaserLabAddBP
    {
		[ServiceKnownType(typeof(ApplicationContext))]
		[ServiceKnownType(typeof(PlatformContext))]
		[ServiceKnownType(typeof(ThreadContext))]
		[ServiceKnownType(typeof( UFSoft.UBF.Business.BusinessException))]
		[ServiceKnownType(typeof( UFSoft.UBF.Business.EntityNotExistException))]
		[ServiceKnownType(typeof( UFSoft.UBF.Business.AttributeInValidException))]
		[ServiceKnownType(typeof(UFSoft.UBF.Business.AttrsContainerException))]
		[ServiceKnownType(typeof(UFSoft.UBF.Exceptions.MessageBase))]
			[FaultContract(typeof(UFSoft.UBF.Service.ServiceLostException))]
		[FaultContract(typeof(UFSoft.UBF.Service.ServiceException))]
		[FaultContract(typeof(UFSoft.UBF.Service.ServiceExceptionDetail))]
		[FaultContract(typeof(ExceptionBase))]
		[FaultContract(typeof(Exception))]
		[OperationContract()]
        System.String Do(IContext context ,out IList<MessageBase> outMessages ,List<System.String> lBList, System.String bN, System.String type, System.String customer, System.DateTime masterDT);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class LaserLabAddBPStub : OperationStubBase, ILaserLabAddBP
    {
        #region ILaserLabAddBP Members

        //[OperationBehavior]
        public System.String Do(IContext context ,out IList<MessageBase> outMessages, List<System.String> lBList, System.String bN, System.String type, System.String customer, System.DateTime masterDT)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, lBList, bN, type, customer, masterDT);
        }
        
        //[OperationBehavior]
        public System.String DoEx(ICommonDataContract commonData, List<System.String> lBList, System.String bN, System.String type, System.String customer, System.DateTime masterDT)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabAddBP.LaserLabAddBP");                
                LaserLabAddBP objectRef = new LaserLabAddBP();
					
				objectRef.LBList = lBList;
				objectRef.BN = bN;
				objectRef.Type = type;
				objectRef.Customer = customer;
				objectRef.MasterDT = masterDT;

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
				FinallyInvoke("UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabAddBP.LaserLabAddBP");
            }
        }
	#endregion
    }
}
