








namespace UFIDA.U9.Cust.FJGX.SOLineInfoQryBP.Proxy
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.IO;
	using System.ServiceModel;
	using System.Runtime.Serialization;
	using UFSoft.UBF;
	using UFSoft.UBF.Exceptions;
	using UFSoft.UBF.Util.Context;
	using UFSoft.UBF.Service;
	using UFSoft.UBF.Service.Base ;

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.FJGX.SOLineInfoQryBP.IQueryBP")]
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
		List<UFIDA.U9.Cust.FJGX.SOLineInfoQryBP.SOLineInfoQryDTOData> Do(IContext context, out IList<MessageBase> outMessages ,UFIDA.U9.Query.QueryCaseBP.QryCommonParaObjData qryInParameter);
    }
	[Serializable]    
    public class QueryBPProxy : OperationProxyBase//, UFIDA.U9.Cust.FJGX.SOLineInfoQryBP.Proxy.IQueryBP
    {
	#region Fields	
				private UFIDA.U9.Query.QueryCaseBP.QryCommonParaObjData qryInParameter ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 查询入口参数 (该属性可为空,且无默认值)
		/// 查询BP.Misc.查询入口参数
		/// </summary>
		/// <value>UFIDA.U9.Query.QueryCaseBP.QryCommonParaObj</value>
		public UFIDA.U9.Query.QueryCaseBP.QryCommonParaObjData QryInParameter
		{
			get	
			{	
				return this.qryInParameter;
			}

			set	
			{	
				this.qryInParameter = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public QueryBPProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public List<UFIDA.U9.Cust.FJGX.SOLineInfoQryBP.SOLineInfoQryDTOData> Do()
        {
  			InitKeyList() ;
 			List<UFIDA.U9.Cust.FJGX.SOLineInfoQryBP.SOLineInfoQryDTOData> result = (List<UFIDA.U9.Cust.FJGX.SOLineInfoQryBP.SOLineInfoQryDTOData>)InvokeAgent<UFIDA.U9.Cust.FJGX.SOLineInfoQryBP.Proxy.IQueryBP>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IQueryBP channel = oChannel as IQueryBP;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, qryInParameter);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private List<UFIDA.U9.Cust.FJGX.SOLineInfoQryBP.SOLineInfoQryDTOData> GetRealResult(List<UFIDA.U9.Cust.FJGX.SOLineInfoQryBP.SOLineInfoQryDTOData> result)
		{
								return result ;
			}
		#region  Init KeyList 
		//初始化SKey集合--由于接口不一样.BP.SV都要处理
		private void InitKeyList()
		{
			System.Collections.Hashtable dict = new System.Collections.Hashtable() ;
						{
				if (QryInParameter != null)
				{
					QryInParameter.DoSerializeKeyList(dict);
				}
			}
		
		}
		#endregion 

    }
}



