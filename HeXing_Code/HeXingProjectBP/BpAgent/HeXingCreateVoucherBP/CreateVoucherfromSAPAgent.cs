








namespace UFIDA.U9.Cust.HeXingProjectBP.HeXingCreateVoucherBP.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.HeXingProjectBP.HeXingCreateVoucherBP.ICreateVoucherfromSAP")]
    public interface ICreateVoucherfromSAP
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
		void Do(IContext context, out IList<MessageBase> outMessages );
    }
	[Serializable]    
    public class CreateVoucherfromSAPProxy : OperationProxyBase//, UFIDA.U9.Cust.HeXingProjectBP.HeXingCreateVoucherBP.Proxy.ICreateVoucherfromSAP
    {
	#region Fields	
	
	#endregion	
		
	#region Properties
	
	
	#endregion	


	#region Constructors
        public CreateVoucherfromSAPProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public void Do()
        {
  			InitKeyList() ;
 			InvokeAgent<UFIDA.U9.Cust.HeXingProjectBP.HeXingCreateVoucherBP.Proxy.ICreateVoucherfromSAP>();
			
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            ICreateVoucherfromSAP channel = oChannel as ICreateVoucherfromSAP;
            if (channel != null)
            {
				channel.Do(context, out returnMsgs);
	    }
            return  null;
        }
		#endregion
		
		#region  Init KeyList 
		//初始化SKey集合--由于接口不一样.BP.SV都要处理
		private void InitKeyList()
		{
			System.Collections.Hashtable dict = new System.Collections.Hashtable() ;

		}
		#endregion 

    }
}



