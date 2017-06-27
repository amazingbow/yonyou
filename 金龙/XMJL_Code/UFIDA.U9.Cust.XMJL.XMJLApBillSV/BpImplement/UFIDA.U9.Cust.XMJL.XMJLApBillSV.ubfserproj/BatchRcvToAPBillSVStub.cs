







namespace UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.IBatchRcvToAPBillSV")]
    public interface IBatchRcvToAPBillSV
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
        System.Int64 Do(IContext context ,out IList<MessageBase> outMessages ,List<UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.RCVLineInfoDTOData> rCVLineInfoDTO, System.Int64 sRCOrgID, System.Int64 currency, System.String supplierCode, System.String aPBillCode);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class BatchRcvToAPBillSVStub : ServiceStubBase, IBatchRcvToAPBillSV
    {
        #region IBatchRcvToAPBillSV Members

        //[OperationBehavior]
        public System.Int64 Do(IContext context ,out IList<MessageBase> outMessages, List<UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.RCVLineInfoDTOData> rCVLineInfoDTO, System.Int64 sRCOrgID, System.Int64 currency, System.String supplierCode, System.String aPBillCode)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, rCVLineInfoDTO, sRCOrgID, currency, supplierCode, aPBillCode);
        }
        
        //[OperationBehavior]
        public System.Int64 DoEx(ICommonDataContract commonData, List<UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.RCVLineInfoDTOData> rCVLineInfoDTO, System.Int64 sRCOrgID, System.Int64 currency, System.String supplierCode, System.String aPBillCode)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.BatchRcvToAPBillSV");                
                BatchRcvToAPBillSV objectRef = new BatchRcvToAPBillSV();
					

				if (rCVLineInfoDTO != null)
				{
					DeSerializeKey(rCVLineInfoDTO);
					List<UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.RCVLineInfoDTO> listRCVLineInfoDTO = new List<UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.RCVLineInfoDTO>();
					foreach (UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.RCVLineInfoDTOData obj in rCVLineInfoDTO)
					{
						if (obj == null)
							continue;
				
						UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.RCVLineInfoDTO child = new UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.RCVLineInfoDTO();
						child.FromEntityData(obj);
						//值对象应该是依赖主创建的.但此处不是.可能的问题？
						listRCVLineInfoDTO.Add(child);
					}
					objectRef.RCVLineInfoDTO = listRCVLineInfoDTO;
				}
				objectRef.SRCOrgID = sRCOrgID;
				objectRef.Currency = currency;
				objectRef.SupplierCode = supplierCode;
				objectRef.APBillCode = aPBillCode;

				//处理返回类型.
				System.Int64 result = objectRef.Do();
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
				FinallyInvoke("UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.BatchRcvToAPBillSV");
            }
        }
	#endregion
    }
}
