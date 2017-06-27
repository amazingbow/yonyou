







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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.APBillSV.IRcvPushAPComfirmSV")]
    public interface IRcvPushAPComfirmSV
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
        UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData Do(IContext context ,out IList<MessageBase> outMessages ,System.Boolean isMergerAPConfirm, System.Int64 rcvID, List<System.Int64> rcvLineIDs);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class RcvPushAPComfirmSVStub : ServiceStubBase, IRcvPushAPComfirmSV
    {
        #region IRcvPushAPComfirmSV Members

        //[OperationBehavior]
        public UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData Do(IContext context ,out IList<MessageBase> outMessages, System.Boolean isMergerAPConfirm, System.Int64 rcvID, List<System.Int64> rcvLineIDs)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, isMergerAPConfirm, rcvID, rcvLineIDs);
        }
        
        //[OperationBehavior]
        public UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData DoEx(ICommonDataContract commonData, System.Boolean isMergerAPConfirm, System.Int64 rcvID, List<System.Int64> rcvLineIDs)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMJL.APBillSV.RcvPushAPComfirmSV");                
                RcvPushAPComfirmSV objectRef = new RcvPushAPComfirmSV();
			
				objectRef.IsMergerAPConfirm = isMergerAPConfirm;
				objectRef.RcvID = rcvID;
				objectRef.RcvLineIDs = rcvLineIDs;

				//处理返回类型.
				UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTO result = objectRef.Do();

				if (result == null)
					return null ;
						UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData resultdata = result.ToEntityData();
				DoSerializeKey(resultdata, "UFIDA.U9.Cust.XMJL.APBillSV.RcvPushAPComfirmSV");
				return resultdata;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.XMJL.APBillSV.RcvPushAPComfirmSV");
            }
        }
	#endregion
    }
}
