







namespace UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP.IQueryBP")]
    public interface IQueryBP
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
        List<UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP.SOHeadInfoQryDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,UFIDA.U9.Query.QueryCaseBP.QryCommonParaObjData qryInParameter);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class QueryBPStub : OperationStubBase, IQueryBP
    {
        #region IQueryBP Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP.SOHeadInfoQryDTOData> Do(IContext context ,out IList<MessageBase> outMessages, UFIDA.U9.Query.QueryCaseBP.QryCommonParaObjData qryInParameter)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, qryInParameter);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP.SOHeadInfoQryDTOData> DoEx(ICommonDataContract commonData, UFIDA.U9.Query.QueryCaseBP.QryCommonParaObjData qryInParameter)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP.QueryBP");                
                QueryBP objectRef = new QueryBP();
	
				if (qryInParameter != null)
				{
					DeSerializeKey(qryInParameter);
					UFIDA.U9.Query.QueryCaseBP.QryCommonParaObj temp = new UFIDA.U9.Query.QueryCaseBP.QryCommonParaObj();
					temp.FromEntityData(qryInParameter);
					objectRef.QryInParameter = temp;
				}

				//处理返回类型.
				List<UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP.SOHeadInfoQryDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP.SOHeadInfoQryDTOData> list = new List<UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP.SOHeadInfoQryDTOData>();
				foreach (UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP.SOHeadInfoQryDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP.SOHeadInfoQryDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP.QueryBP");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.FJGX.SOHeadInfoQryBP.QueryBP");
            }
        }
	#endregion
    }
}
