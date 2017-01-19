







namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.IReturnLBMaster")]
    public interface IReturnLBMaster
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
        System.String Do(IContext context ,out IList<MessageBase> outMessages ,System.String lB, System.String cP);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ReturnLBMasterStub : OperationStubBase, IReturnLBMaster
    {
        #region IReturnLBMaster Members

        //[OperationBehavior]
        public System.String Do(IContext context ,out IList<MessageBase> outMessages, System.String lB, System.String cP)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, lB, cP);
        }
        
        //[OperationBehavior]
        public System.String DoEx(ICommonDataContract commonData, System.String lB, System.String cP)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.ReturnLBMaster");                
                ReturnLBMaster objectRef = new ReturnLBMaster();
		
				objectRef.LB = lB;
				objectRef.CP = cP;

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
				FinallyInvoke("UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.ReturnLBMaster");
            }
        }
	#endregion
    }
}
