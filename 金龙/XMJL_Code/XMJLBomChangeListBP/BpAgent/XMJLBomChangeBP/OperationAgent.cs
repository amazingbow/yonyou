








namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.IOperation")]
    public interface IOperation
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
		List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomInfoDTOData> Do(IContext context, out IList<MessageBase> outMessages ,System.String carCodeList);
    }
	[Serializable]    
    public class OperationProxy : OperationProxyBase//, UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.Proxy.IOperation
    {
	#region Fields	
				private System.String carCodeList ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 车号 (该属性可为空,且无默认值)
		/// 获取缺件信息.Misc.车号
		/// </summary>
		/// <value>System.String</value>
		public System.String CarCodeList
		{
			get	
			{	
				return this.carCodeList;
			}

			set	
			{	
				this.carCodeList = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public OperationProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomInfoDTOData> Do()
        {
  			InitKeyList() ;
 			List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomInfoDTOData> result = (List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomInfoDTOData>)InvokeAgent<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.Proxy.IOperation>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IOperation channel = oChannel as IOperation;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, carCodeList);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomInfoDTOData> GetRealResult(List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomInfoDTOData> result)
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



