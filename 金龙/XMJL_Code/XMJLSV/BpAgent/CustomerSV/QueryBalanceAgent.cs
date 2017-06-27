








namespace UFIDA.U9.Cust.XMJL.CustomerSV.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.CustomerSV.IQueryBalance")]
    public interface IQueryBalance
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
		List<UFIDA.U9.Cust.XMJL.CustomerSV.CustomerBalanceDTOData> Do(IContext context, out IList<MessageBase> outMessages ,List<System.String> codes);
    }
	[Serializable]    
    public class QueryBalanceProxy : ServiceProxyBase//, UFIDA.U9.Cust.XMJL.CustomerSV.Proxy.IQueryBalance
    {
	#region Fields	
				private List<System.String> codes ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 客户代码集合 (该属性可为空,且无默认值)
		/// 获取客户金额额度.Misc.客户代码集合
		/// </summary>
		/// <value></value>
		public List<System.String> Codes
		{
			get	
			{	
				return this.codes;
			}

			set	
			{	
				this.codes = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public QueryBalanceProxy()
        {
        }
        #endregion
        
        #region 跨site调用
        public List<UFIDA.U9.Cust.XMJL.CustomerSV.CustomerBalanceDTOData> Do(string targetSite)
        {
  			InitKeyList() ;
			List<UFIDA.U9.Cust.XMJL.CustomerSV.CustomerBalanceDTOData> result = (List<UFIDA.U9.Cust.XMJL.CustomerSV.CustomerBalanceDTOData>)InvokeBySite<UFIDA.U9.Cust.XMJL.CustomerSV.Proxy.IQueryBalance>(targetSite);
			return GetRealResult(result);
        }
        #endregion end跨site调用

		#region 跨组织调用
        public List<UFIDA.U9.Cust.XMJL.CustomerSV.CustomerBalanceDTOData> Do(long targetOrgId)
        {
  			InitKeyList() ;
			List<UFIDA.U9.Cust.XMJL.CustomerSV.CustomerBalanceDTOData> result = (List<UFIDA.U9.Cust.XMJL.CustomerSV.CustomerBalanceDTOData>)InvokeByOrg<UFIDA.U9.Cust.XMJL.CustomerSV.Proxy.IQueryBalance>(targetOrgId);
			return GetRealResult(result);
        }
		#endregion end跨组织调用

		#region Public Method
		
        public List<UFIDA.U9.Cust.XMJL.CustomerSV.CustomerBalanceDTOData> Do()
        {
  			InitKeyList() ;
 			List<UFIDA.U9.Cust.XMJL.CustomerSV.CustomerBalanceDTOData> result = (List<UFIDA.U9.Cust.XMJL.CustomerSV.CustomerBalanceDTOData>)InvokeAgent<UFIDA.U9.Cust.XMJL.CustomerSV.Proxy.IQueryBalance>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IQueryBalance channel = oChannel as IQueryBalance;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, codes);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private List<UFIDA.U9.Cust.XMJL.CustomerSV.CustomerBalanceDTOData> GetRealResult(List<UFIDA.U9.Cust.XMJL.CustomerSV.CustomerBalanceDTOData> result)
		{
								return result ;
			}
		#region  Init KeyList 
		//初始化SKey集合--由于接口不一样.BP.SV都要处理
		private void InitKeyList()
		{
			System.Collections.Hashtable dict = new System.Collections.Hashtable() ;
					
		}
		#endregion 

    }
}



