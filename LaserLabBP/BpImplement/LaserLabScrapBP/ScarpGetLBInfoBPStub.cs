







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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.IScarpGetLBInfoBP")]
    public interface IScarpGetLBInfoBP
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
        UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.GetScrapLBInfoDtoData Do(IContext context ,out IList<MessageBase> outMessages ,System.String lB);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ScarpGetLBInfoBPStub : OperationStubBase, IScarpGetLBInfoBP
    {
        #region IScarpGetLBInfoBP Members

        //[OperationBehavior]
        public UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.GetScrapLBInfoDtoData Do(IContext context ,out IList<MessageBase> outMessages, System.String lB)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, lB);
        }
        
        //[OperationBehavior]
        public UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.GetScrapLBInfoDtoData DoEx(ICommonDataContract commonData, System.String lB)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.ScarpGetLBInfoBP");                
                ScarpGetLBInfoBP objectRef = new ScarpGetLBInfoBP();
	
				objectRef.LB = lB;

				//处理返回类型.
				UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.GetScrapLBInfoDto result = objectRef.Do();

				if (result == null)
					return null ;
						UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.GetScrapLBInfoDtoData resultdata = result.ToEntityData();
				DoSerializeKey(resultdata, "UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.ScarpGetLBInfoBP");
				return resultdata;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.ScarpGetLBInfoBP");
            }
        }
	#endregion
    }
}
