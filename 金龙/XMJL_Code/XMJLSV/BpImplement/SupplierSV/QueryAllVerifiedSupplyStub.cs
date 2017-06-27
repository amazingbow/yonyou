







namespace UFIDA.U9.Cust.XMJL.SupplierSV
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.SupplierSV.IQueryAllVerifiedSupply")]
    public interface IQueryAllVerifiedSupply
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
        List<UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,System.DateTime synDateTime);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class QueryAllVerifiedSupplyStub : ServiceStubBase, IQueryAllVerifiedSupply
    {
        #region IQueryAllVerifiedSupply Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTOData> Do(IContext context ,out IList<MessageBase> outMessages, System.DateTime synDateTime)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, synDateTime);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTOData> DoEx(ICommonDataContract commonData, System.DateTime synDateTime)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMJL.SupplierSV.QueryAllVerifiedSupply");                
                QueryAllVerifiedSupply objectRef = new QueryAllVerifiedSupply();
	
				objectRef.SynDateTime = synDateTime;

				//处理返回类型.
				List<UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTOData> list = new List<UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTOData>();
				foreach (UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.XMJL.SupplierSV.QueryAllVerifiedSupply");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.XMJL.SupplierSV.QueryAllVerifiedSupply");
            }
        }
	#endregion
    }
}
