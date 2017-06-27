







namespace UFIDA.U9.Cust.XMJL.BOMSV
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.BOMSV.IGetBom")]
    public interface IGetBom
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
        List<UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,System.String manufactureNo, System.DateTime lastSynTimeStamp);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetBomStub : ServiceStubBase, IGetBom
    {
        #region IGetBom Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData> Do(IContext context ,out IList<MessageBase> outMessages, System.String manufactureNo, System.DateTime lastSynTimeStamp)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, manufactureNo, lastSynTimeStamp);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData> DoEx(ICommonDataContract commonData, System.String manufactureNo, System.DateTime lastSynTimeStamp)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMJL.BOMSV.GetBom");                
                GetBom objectRef = new GetBom();
		
				objectRef.ManufactureNo = manufactureNo;
				objectRef.LastSynTimeStamp = lastSynTimeStamp;

				//处理返回类型.
				List<UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData> list = new List<UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData>();
				foreach (UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.XMJL.BOMSV.GetBom");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.XMJL.BOMSV.GetBom");
            }
        }
	#endregion
    }
}
