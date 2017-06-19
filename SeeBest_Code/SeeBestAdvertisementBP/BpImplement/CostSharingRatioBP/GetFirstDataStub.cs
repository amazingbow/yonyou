







namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.IGetFirstData")]
    public interface IGetFirstData
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
        UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.CostSharingRationDTOData Do(IContext context ,out IList<MessageBase> outMessages );
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetFirstDataStub : OperationStubBase, IGetFirstData
    {
        #region IGetFirstData Members

        //[OperationBehavior]
        public UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.CostSharingRationDTOData Do(IContext context ,out IList<MessageBase> outMessages)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData);
        }
        
        //[OperationBehavior]
        public UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.CostSharingRationDTOData DoEx(ICommonDataContract commonData)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.GetFirstData");                
                GetFirstData objectRef = new GetFirstData();


				//处理返回类型.
				UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.CostSharingRationDTO result = objectRef.Do();

				if (result == null)
					return null ;
						UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.CostSharingRationDTOData resultdata = result.ToEntityData();
				DoSerializeKey(resultdata, "UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.GetFirstData");
				return resultdata;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.GetFirstData");
            }
        }
	#endregion
    }
}
