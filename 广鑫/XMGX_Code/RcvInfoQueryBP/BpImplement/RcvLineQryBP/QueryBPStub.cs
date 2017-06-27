







namespace UIFIA.U9.Cust.FJGX.RcvLineQryBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UIFIA.U9.Cust.FJGX.RcvLineQryBP.IQueryBP")]
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
        List<UIFIA.U9.Cust.FJGX.RcvLineQryBP.RcvLineQryDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,UFIDA.U9.Query.QueryCaseBP.QryCommonParaObjData qryInParameter);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class QueryBPStub : OperationStubBase, IQueryBP
    {
        #region IQueryBP Members

        //[OperationBehavior]
        public List<UIFIA.U9.Cust.FJGX.RcvLineQryBP.RcvLineQryDTOData> Do(IContext context ,out IList<MessageBase> outMessages, UFIDA.U9.Query.QueryCaseBP.QryCommonParaObjData qryInParameter)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, qryInParameter);
        }
        
        //[OperationBehavior]
        public List<UIFIA.U9.Cust.FJGX.RcvLineQryBP.RcvLineQryDTOData> DoEx(ICommonDataContract commonData, UFIDA.U9.Query.QueryCaseBP.QryCommonParaObjData qryInParameter)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UIFIA.U9.Cust.FJGX.RcvLineQryBP.QueryBP");                
                QueryBP objectRef = new QueryBP();
	
				if (qryInParameter != null)
				{
					DeSerializeKey(qryInParameter);
					UFIDA.U9.Query.QueryCaseBP.QryCommonParaObj temp = new UFIDA.U9.Query.QueryCaseBP.QryCommonParaObj();
					temp.FromEntityData(qryInParameter);
					objectRef.QryInParameter = temp;
				}

				//处理返回类型.
				List<UIFIA.U9.Cust.FJGX.RcvLineQryBP.RcvLineQryDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UIFIA.U9.Cust.FJGX.RcvLineQryBP.RcvLineQryDTOData> list = new List<UIFIA.U9.Cust.FJGX.RcvLineQryBP.RcvLineQryDTOData>();
				foreach (UIFIA.U9.Cust.FJGX.RcvLineQryBP.RcvLineQryDTO obj in result)
				{
					if (obj == null)
						continue;

					UIFIA.U9.Cust.FJGX.RcvLineQryBP.RcvLineQryDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UIFIA.U9.Cust.FJGX.RcvLineQryBP.QueryBP");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UIFIA.U9.Cust.FJGX.RcvLineQryBP.QueryBP");
            }
        }
	#endregion
    }
}
