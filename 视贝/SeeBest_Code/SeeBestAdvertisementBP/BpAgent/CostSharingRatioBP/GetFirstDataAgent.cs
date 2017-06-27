








namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.IGetFirstData")]
    public interface IGetFirstData
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
		UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.CostSharingRationDTOData Do(IContext context, out IList<MessageBase> outMessages );
    }
	[Serializable]    
    public class GetFirstDataProxy : OperationProxyBase//, UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.Proxy.IGetFirstData
    {
	#region Fields	
	
	#endregion	
		
	#region Properties
	
	
	#endregion	


	#region Constructors
        public GetFirstDataProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.CostSharingRationDTOData Do()
        {
  			InitKeyList() ;
 			UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.CostSharingRationDTOData result = (UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.CostSharingRationDTOData)InvokeAgent<UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.Proxy.IGetFirstData>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IGetFirstData channel = oChannel as IGetFirstData;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.CostSharingRationDTOData GetRealResult(UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.CostSharingRationDTOData result)
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



