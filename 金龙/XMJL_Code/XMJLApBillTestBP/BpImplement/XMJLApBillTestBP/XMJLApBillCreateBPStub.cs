







namespace UFIDA.U9.Cust.XMJL.XMJLApBillTestBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.XMJLApBillTestBP.IXMJLApBillCreateBP")]
    public interface IXMJLApBillCreateBP
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
        System.Int64 Do(IContext context ,out IList<MessageBase> outMessages ,System.String supplierCode, List<UFIDA.U9.Cust.XMJL.XMJLApBillTestBP.RCVLineInfoDTOData> rCVLineInfoDTO, System.Int64 currency, System.Int64 srcOrgID);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class XMJLApBillCreateBPStub : OperationStubBase, IXMJLApBillCreateBP
    {
        #region IXMJLApBillCreateBP Members

        //[OperationBehavior]
        public System.Int64 Do(IContext context ,out IList<MessageBase> outMessages, System.String supplierCode, List<UFIDA.U9.Cust.XMJL.XMJLApBillTestBP.RCVLineInfoDTOData> rCVLineInfoDTO, System.Int64 currency, System.Int64 srcOrgID)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, supplierCode, rCVLineInfoDTO, currency, srcOrgID);
        }
        
        //[OperationBehavior]
        public System.Int64 DoEx(ICommonDataContract commonData, System.String supplierCode, List<UFIDA.U9.Cust.XMJL.XMJLApBillTestBP.RCVLineInfoDTOData> rCVLineInfoDTO, System.Int64 currency, System.Int64 srcOrgID)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMJL.XMJLApBillTestBP.XMJLApBillCreateBP");                
                XMJLApBillCreateBP objectRef = new XMJLApBillCreateBP();
				
				objectRef.SupplierCode = supplierCode;

				if (rCVLineInfoDTO != null)
				{
					DeSerializeKey(rCVLineInfoDTO);
					List<UFIDA.U9.Cust.XMJL.XMJLApBillTestBP.RCVLineInfoDTO> listRCVLineInfoDTO = new List<UFIDA.U9.Cust.XMJL.XMJLApBillTestBP.RCVLineInfoDTO>();
					foreach (UFIDA.U9.Cust.XMJL.XMJLApBillTestBP.RCVLineInfoDTOData obj in rCVLineInfoDTO)
					{
						if (obj == null)
							continue;
				
						UFIDA.U9.Cust.XMJL.XMJLApBillTestBP.RCVLineInfoDTO child = new UFIDA.U9.Cust.XMJL.XMJLApBillTestBP.RCVLineInfoDTO();
						child.FromEntityData(obj);
						//值对象应该是依赖主创建的.但此处不是.可能的问题？
						listRCVLineInfoDTO.Add(child);
					}
					objectRef.RCVLineInfoDTO = listRCVLineInfoDTO;
				}
				objectRef.Currency = currency;
				objectRef.SrcOrgID = srcOrgID;

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
				FinallyInvoke("UFIDA.U9.Cust.XMJL.XMJLApBillTestBP.XMJLApBillCreateBP");
            }
        }
	#endregion
    }
}
