








namespace UFIDA.U9.Cust.XMJL.ItemSV.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.ItemSV.IQueryAllItemPrice")]
    public interface IQueryAllItemPrice
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
		List<UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTOData> Do(IContext context, out IList<MessageBase> outMessages );
    }
	[Serializable]    
    public class QueryAllItemPriceProxy : ServiceProxyBase//, UFIDA.U9.Cust.XMJL.ItemSV.Proxy.IQueryAllItemPrice
    {
	#region Fields	
	
	#endregion	
		
	#region Properties
	
	
	#endregion	


	#region Constructors
        public QueryAllItemPriceProxy()
        {
        }
        #endregion
        
        #region 跨site调用
        public List<UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTOData> Do(string targetSite)
        {
  			InitKeyList() ;
			List<UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTOData> result = (List<UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTOData>)InvokeBySite<UFIDA.U9.Cust.XMJL.ItemSV.Proxy.IQueryAllItemPrice>(targetSite);
			return GetRealResult(result);
        }
        #endregion end跨site调用

		#region 跨组织调用
        public List<UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTOData> Do(long targetOrgId)
        {
  			InitKeyList() ;
			List<UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTOData> result = (List<UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTOData>)InvokeByOrg<UFIDA.U9.Cust.XMJL.ItemSV.Proxy.IQueryAllItemPrice>(targetOrgId);
			return GetRealResult(result);
        }
		#endregion end跨组织调用

		#region Public Method
		
        public List<UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTOData> Do()
        {
  			InitKeyList() ;
 			List<UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTOData> result = (List<UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTOData>)InvokeAgent<UFIDA.U9.Cust.XMJL.ItemSV.Proxy.IQueryAllItemPrice>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IQueryAllItemPrice channel = oChannel as IQueryAllItemPrice;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private List<UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTOData> GetRealResult(List<UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTOData> result)
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



