







namespace UFIDA.U9.Cust.XMJL.ReceivementSV
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.ReceivementSV.IGetSRMRcv")]
    public interface IGetSRMRcv
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
        List<UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvQueryDTOData sRMRcvQueryDTO);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetSRMRcvStub : ServiceStubBase, IGetSRMRcv
    {
        #region IGetSRMRcv Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData> Do(IContext context ,out IList<MessageBase> outMessages, UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvQueryDTOData sRMRcvQueryDTO)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, sRMRcvQueryDTO);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData> DoEx(ICommonDataContract commonData, UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvQueryDTOData sRMRcvQueryDTO)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMJL.ReceivementSV.GetSRMRcv");                
                GetSRMRcv objectRef = new GetSRMRcv();
	
				if (sRMRcvQueryDTO != null)
				{
					DeSerializeKey(sRMRcvQueryDTO);
					UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvQueryDTO temp = new UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvQueryDTO();
					temp.FromEntityData(sRMRcvQueryDTO);
					objectRef.SRMRcvQueryDTO = temp;
				}

				//处理返回类型.
				List<UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData> list = new List<UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData>();
				foreach (UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.XMJL.ReceivementSV.GetSRMRcv");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.XMJL.ReceivementSV.GetSRMRcv");
            }
        }
	#endregion
    }
}
