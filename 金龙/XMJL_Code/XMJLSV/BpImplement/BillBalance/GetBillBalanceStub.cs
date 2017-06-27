







namespace UFIDA.U9.Cust.XMJL.BillBalanceSV
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.BillBalanceSV.IGetBillBalance")]
    public interface IGetBillBalance
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
        List<UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceQueryDTOData billBalanceQueryDTO);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetBillBalanceStub : ServiceStubBase, IGetBillBalance
    {
        #region IGetBillBalance Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTOData> Do(IContext context ,out IList<MessageBase> outMessages, UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceQueryDTOData billBalanceQueryDTO)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, billBalanceQueryDTO);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTOData> DoEx(ICommonDataContract commonData, UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceQueryDTOData billBalanceQueryDTO)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMJL.BillBalanceSV.GetBillBalance");                
                GetBillBalance objectRef = new GetBillBalance();
	
				if (billBalanceQueryDTO != null)
				{
					DeSerializeKey(billBalanceQueryDTO);
					UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceQueryDTO temp = new UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceQueryDTO();
					temp.FromEntityData(billBalanceQueryDTO);
					objectRef.BillBalanceQueryDTO = temp;
				}

				//处理返回类型.
				List<UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTOData> list = new List<UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTOData>();
				foreach (UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.XMJL.BillBalanceSV.GetBillBalance");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.XMJL.BillBalanceSV.GetBillBalance");
            }
        }
	#endregion
    }
}
