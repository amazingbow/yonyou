







namespace UFIDA.U9.Cust.XMJLBomOpBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJLBomOpBP.IGetBOMMainInfo")]
    public interface IGetBOMMainInfo
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
        List<UFIDA.U9.Cust.XMJLBomOpBP.BOMMainInfoDtoData> Do(IContext context ,out IList<MessageBase> outMessages ,System.String manufactureNo, System.String contractNo, System.String carType, System.Int32 disburseType);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetBOMMainInfoStub : OperationStubBase, IGetBOMMainInfo
    {
        #region IGetBOMMainInfo Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMJLBomOpBP.BOMMainInfoDtoData> Do(IContext context ,out IList<MessageBase> outMessages, System.String manufactureNo, System.String contractNo, System.String carType, System.Int32 disburseType)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, manufactureNo, contractNo, carType, disburseType);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMJLBomOpBP.BOMMainInfoDtoData> DoEx(ICommonDataContract commonData, System.String manufactureNo, System.String contractNo, System.String carType, System.Int32 disburseType)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMJLBomOpBP.GetBOMMainInfo");                
                GetBOMMainInfo objectRef = new GetBOMMainInfo();
				
				objectRef.ManufactureNo = manufactureNo;
				objectRef.ContractNo = contractNo;
				objectRef.CarType = carType;
				objectRef.DisburseType = disburseType;

				//处理返回类型.
				List<UFIDA.U9.Cust.XMJLBomOpBP.BOMMainInfoDto> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.XMJLBomOpBP.BOMMainInfoDtoData> list = new List<UFIDA.U9.Cust.XMJLBomOpBP.BOMMainInfoDtoData>();
				foreach (UFIDA.U9.Cust.XMJLBomOpBP.BOMMainInfoDto obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.XMJLBomOpBP.BOMMainInfoDtoData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.XMJLBomOpBP.GetBOMMainInfo");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.XMJLBomOpBP.GetBOMMainInfo");
            }
        }
	#endregion
    }
}
