








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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.ItemSV.IQueryAllEffectiveItem")]
    public interface IQueryAllEffectiveItem
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
		List<UFIDA.U9.Cust.XMJL.ItemSV.ItemDTOData> Do(IContext context, out IList<MessageBase> outMessages ,System.DateTime synDateTime);
    }
	[Serializable]    
    public class QueryAllEffectiveItemProxy : ServiceProxyBase//, UFIDA.U9.Cust.XMJL.ItemSV.Proxy.IQueryAllEffectiveItem
    {
	#region Fields	
				private System.DateTime synDateTime ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 最后同步时间 (该属性可为空,且无默认值)
		/// 获取所有在用的料品.Misc.最后同步时间
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime SynDateTime
		{
			get	
			{	
				return this.synDateTime;
			}

			set	
			{	
				this.synDateTime = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public QueryAllEffectiveItemProxy()
        {
        }
        #endregion
        
        #region 跨site调用
        public List<UFIDA.U9.Cust.XMJL.ItemSV.ItemDTOData> Do(string targetSite)
        {
  			InitKeyList() ;
			List<UFIDA.U9.Cust.XMJL.ItemSV.ItemDTOData> result = (List<UFIDA.U9.Cust.XMJL.ItemSV.ItemDTOData>)InvokeBySite<UFIDA.U9.Cust.XMJL.ItemSV.Proxy.IQueryAllEffectiveItem>(targetSite);
			return GetRealResult(result);
        }
        #endregion end跨site调用

		#region 跨组织调用
        public List<UFIDA.U9.Cust.XMJL.ItemSV.ItemDTOData> Do(long targetOrgId)
        {
  			InitKeyList() ;
			List<UFIDA.U9.Cust.XMJL.ItemSV.ItemDTOData> result = (List<UFIDA.U9.Cust.XMJL.ItemSV.ItemDTOData>)InvokeByOrg<UFIDA.U9.Cust.XMJL.ItemSV.Proxy.IQueryAllEffectiveItem>(targetOrgId);
			return GetRealResult(result);
        }
		#endregion end跨组织调用

		#region Public Method
		
        public List<UFIDA.U9.Cust.XMJL.ItemSV.ItemDTOData> Do()
        {
  			InitKeyList() ;
 			List<UFIDA.U9.Cust.XMJL.ItemSV.ItemDTOData> result = (List<UFIDA.U9.Cust.XMJL.ItemSV.ItemDTOData>)InvokeAgent<UFIDA.U9.Cust.XMJL.ItemSV.Proxy.IQueryAllEffectiveItem>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IQueryAllEffectiveItem channel = oChannel as IQueryAllEffectiveItem;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, synDateTime);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private List<UFIDA.U9.Cust.XMJL.ItemSV.ItemDTOData> GetRealResult(List<UFIDA.U9.Cust.XMJL.ItemSV.ItemDTOData> result)
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



