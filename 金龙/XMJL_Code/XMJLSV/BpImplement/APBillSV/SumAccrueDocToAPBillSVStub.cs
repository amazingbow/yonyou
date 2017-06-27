







namespace UFIDA.U9.Cust.XMJL.APBillSV
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.APBillSV.ISumAccrueDocToAPBillSV")]
    public interface ISumAccrueDocToAPBillSV
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
        UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData Do(IContext context ,out IList<MessageBase> outMessages ,System.String supplierCode, System.Int64 currency, System.Int64 sRCOrgID, List<UFIDA.U9.Cust.XMJL.APBillSV.RCVLineInfoDTOData> rCVLineInfoDTO, System.String aPBillCode, System.String memo, System.String opCode, System.String opDptCode);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class SumAccrueDocToAPBillSVStub : ServiceStubBase, ISumAccrueDocToAPBillSV
    {
        #region ISumAccrueDocToAPBillSV Members

        //[OperationBehavior]
        public UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData Do(IContext context ,out IList<MessageBase> outMessages, System.String supplierCode, System.Int64 currency, System.Int64 sRCOrgID, List<UFIDA.U9.Cust.XMJL.APBillSV.RCVLineInfoDTOData> rCVLineInfoDTO, System.String aPBillCode, System.String memo, System.String opCode, System.String opDptCode)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, supplierCode, currency, sRCOrgID, rCVLineInfoDTO, aPBillCode, memo, opCode, opDptCode);
        }
        
        //[OperationBehavior]
        public UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData DoEx(ICommonDataContract commonData, System.String supplierCode, System.Int64 currency, System.Int64 sRCOrgID, List<UFIDA.U9.Cust.XMJL.APBillSV.RCVLineInfoDTOData> rCVLineInfoDTO, System.String aPBillCode, System.String memo, System.String opCode, System.String opDptCode)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMJL.APBillSV.SumAccrueDocToAPBillSV");                
                SumAccrueDocToAPBillSV objectRef = new SumAccrueDocToAPBillSV();
								
				objectRef.SupplierCode = supplierCode;
				objectRef.Currency = currency;
				objectRef.SRCOrgID = sRCOrgID;

				if (rCVLineInfoDTO != null)
				{
					DeSerializeKey(rCVLineInfoDTO);
					List<UFIDA.U9.Cust.XMJL.APBillSV.RCVLineInfoDTO> listRCVLineInfoDTO = new List<UFIDA.U9.Cust.XMJL.APBillSV.RCVLineInfoDTO>();
					foreach (UFIDA.U9.Cust.XMJL.APBillSV.RCVLineInfoDTOData obj in rCVLineInfoDTO)
					{
						if (obj == null)
							continue;
				
						UFIDA.U9.Cust.XMJL.APBillSV.RCVLineInfoDTO child = new UFIDA.U9.Cust.XMJL.APBillSV.RCVLineInfoDTO();
						child.FromEntityData(obj);
						//值对象应该是依赖主创建的.但此处不是.可能的问题？
						listRCVLineInfoDTO.Add(child);
					}
					objectRef.RCVLineInfoDTO = listRCVLineInfoDTO;
				}
				objectRef.APBillCode = aPBillCode;
				objectRef.Memo = memo;
				objectRef.OpCode = opCode;
				objectRef.OpDptCode = opDptCode;

				//处理返回类型.
				UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTO result = objectRef.Do();

				if (result == null)
					return null ;
						UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData resultdata = result.ToEntityData();
				DoSerializeKey(resultdata, "UFIDA.U9.Cust.XMJL.APBillSV.SumAccrueDocToAPBillSV");
				return resultdata;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.XMJL.APBillSV.SumAccrueDocToAPBillSV");
            }
        }
	#endregion
    }
}
