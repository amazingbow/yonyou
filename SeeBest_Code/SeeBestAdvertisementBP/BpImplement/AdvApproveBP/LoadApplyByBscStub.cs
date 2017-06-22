







namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.ILoadApplyByBsc")]
    public interface ILoadApplyByBsc
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
        List<UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.ApplyInfoDtoData> Do(IContext context ,out IList<MessageBase> outMessages ,System.Int64 custBscID, System.DateTime startDate, System.DateTime endDate);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class LoadApplyByBscStub : OperationStubBase, ILoadApplyByBsc
    {
        #region ILoadApplyByBsc Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.ApplyInfoDtoData> Do(IContext context ,out IList<MessageBase> outMessages, System.Int64 custBscID, System.DateTime startDate, System.DateTime endDate)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, custBscID, startDate, endDate);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.ApplyInfoDtoData> DoEx(ICommonDataContract commonData, System.Int64 custBscID, System.DateTime startDate, System.DateTime endDate)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.LoadApplyByBsc");                
                LoadApplyByBsc objectRef = new LoadApplyByBsc();
			
				objectRef.CustBscID = custBscID;
				objectRef.StartDate = startDate;
				objectRef.EndDate = endDate;

				//处理返回类型.
				List<UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.ApplyInfoDto> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.ApplyInfoDtoData> list = new List<UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.ApplyInfoDtoData>();
				foreach (UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.ApplyInfoDto obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.ApplyInfoDtoData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.LoadApplyByBsc");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.LoadApplyByBsc");
            }
        }
	#endregion
    }
}
