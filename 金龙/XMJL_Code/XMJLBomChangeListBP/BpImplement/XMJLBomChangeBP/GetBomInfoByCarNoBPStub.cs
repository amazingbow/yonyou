







namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.IGetBomInfoByCarNoBP")]
    public interface IGetBomInfoByCarNoBP
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
        List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomInfoDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,List<System.String> carIdList);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetBomInfoByCarNoBPStub : OperationStubBase, IGetBomInfoByCarNoBP
    {
        #region IGetBomInfoByCarNoBP Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomInfoDTOData> Do(IContext context ,out IList<MessageBase> outMessages, List<System.String> carIdList)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, carIdList);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomInfoDTOData> DoEx(ICommonDataContract commonData, List<System.String> carIdList)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.GetBomInfoByCarNoBP");                
                GetBomInfoByCarNoBP objectRef = new GetBomInfoByCarNoBP();
	
				objectRef.CarIdList = carIdList;

				//处理返回类型.
				List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomInfoDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomInfoDTOData> list = new List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomInfoDTOData>();
				foreach (UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomInfoDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomInfoDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.GetBomInfoByCarNoBP");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.GetBomInfoByCarNoBP");
            }
        }
	#endregion
    }
}
