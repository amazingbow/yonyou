








namespace UFIDA.U9.Cust.XMJL.SupplierSV.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.SupplierSV.IQueryAllVerifiedSupply")]
    public interface IQueryAllVerifiedSupply
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
		List<UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTOData> Do(IContext context, out IList<MessageBase> outMessages ,System.DateTime synDateTime);
    }
	[Serializable]    
    public class QueryAllVerifiedSupplyProxy : ServiceProxyBase//, UFIDA.U9.Cust.XMJL.SupplierSV.Proxy.IQueryAllVerifiedSupply
    {
	#region Fields	
				private System.DateTime synDateTime ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 最后同步时间 (该属性可为空,且无默认值)
		/// 获取全部已核准供应商.Misc.最后同步时间
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
        public QueryAllVerifiedSupplyProxy()
        {
        }
        #endregion
        
        #region 跨site调用
        public List<UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTOData> Do(string targetSite)
        {
  			InitKeyList() ;
			List<UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTOData> result = (List<UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTOData>)InvokeBySite<UFIDA.U9.Cust.XMJL.SupplierSV.Proxy.IQueryAllVerifiedSupply>(targetSite);
			return GetRealResult(result);
        }
        #endregion end跨site调用

		#region 跨组织调用
        public List<UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTOData> Do(long targetOrgId)
        {
  			InitKeyList() ;
			List<UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTOData> result = (List<UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTOData>)InvokeByOrg<UFIDA.U9.Cust.XMJL.SupplierSV.Proxy.IQueryAllVerifiedSupply>(targetOrgId);
			return GetRealResult(result);
        }
		#endregion end跨组织调用

		#region Public Method
		
        public List<UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTOData> Do()
        {
  			InitKeyList() ;
 			List<UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTOData> result = (List<UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTOData>)InvokeAgent<UFIDA.U9.Cust.XMJL.SupplierSV.Proxy.IQueryAllVerifiedSupply>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IQueryAllVerifiedSupply channel = oChannel as IQueryAllVerifiedSupply;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, synDateTime);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private List<UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTOData> GetRealResult(List<UFIDA.U9.Cust.XMJL.SupplierSV.SupplierDTOData> result)
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



