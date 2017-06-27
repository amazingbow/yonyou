








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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.IGetItemMainSupBP")]
    public interface IGetItemMainSupBP
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
		List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.ItemSupplyDTOData> Do(IContext context, out IList<MessageBase> outMessages ,List<System.Int64> itemIds);
    }
	[Serializable]    
    public class GetItemMainSupBPProxy : OperationProxyBase//, UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.Proxy.IGetItemMainSupBP
    {
	#region Fields	
				private List<System.Int64> itemIds ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 料品ID  (该属性可为空,且无默认值)
		/// 获取料品主供应商信息.Misc.料品ID 
		/// </summary>
		/// <value></value>
		public List<System.Int64> ItemIds
		{
			get	
			{	
				return this.itemIds;
			}

			set	
			{	
				this.itemIds = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public GetItemMainSupBPProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.ItemSupplyDTOData> Do()
        {
  			InitKeyList() ;
 			List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.ItemSupplyDTOData> result = (List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.ItemSupplyDTOData>)InvokeAgent<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.Proxy.IGetItemMainSupBP>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IGetItemMainSupBP channel = oChannel as IGetItemMainSupBP;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, itemIds);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.ItemSupplyDTOData> GetRealResult(List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.ItemSupplyDTOData> result)
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



