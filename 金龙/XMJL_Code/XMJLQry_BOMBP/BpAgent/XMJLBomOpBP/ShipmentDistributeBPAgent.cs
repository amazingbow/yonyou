








namespace UFIDA.U9.Cust.XMJLBomOpBP.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJLBomOpBP.IShipmentDistributeBP")]
    public interface IShipmentDistributeBP
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
		System.String Do(IContext context, out IList<MessageBase> outMessages ,List<System.Int64> iDList);
    }
	[Serializable]    
    public class ShipmentDistributeBPProxy : OperationProxyBase//, UFIDA.U9.Cust.XMJLBomOpBP.Proxy.IShipmentDistributeBP
    {
	#region Fields	
				private List<System.Int64> iDList ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 杂发单ID (该属性可为空,且无默认值)
		/// 杂发单列表批量拣货.Misc.杂发单ID
		/// </summary>
		/// <value></value>
		public List<System.Int64> IDList
		{
			get	
			{	
				return this.iDList;
			}

			set	
			{	
				this.iDList = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public ShipmentDistributeBPProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public System.String Do()
        {
  			InitKeyList() ;
 			System.String result = (System.String)InvokeAgent<UFIDA.U9.Cust.XMJLBomOpBP.Proxy.IShipmentDistributeBP>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IShipmentDistributeBP channel = oChannel as IShipmentDistributeBP;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, iDList);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private System.String GetRealResult(System.String result)
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



