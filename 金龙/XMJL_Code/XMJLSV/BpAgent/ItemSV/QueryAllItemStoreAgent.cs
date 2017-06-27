








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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.ItemSV.IQueryAllItemStore")]
    public interface IQueryAllItemStore
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
		List<UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTOData> Do(IContext context, out IList<MessageBase> outMessages ,System.Boolean isSum, List<System.String> excludeWHCode);
    }
	[Serializable]    
    public class QueryAllItemStoreProxy : ServiceProxyBase//, UFIDA.U9.Cust.XMJL.ItemSV.Proxy.IQueryAllItemStore
    {
	#region Fields	
				private System.Boolean isSum ;
						private List<System.String> excludeWHCode ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 是否合并存储地点统计数量 (该属性可为空,但有默认值)
		/// 获取所有的物料库存.Misc.是否合并存储地点统计数量
		/// </summary>
		/// <value>System.Boolean</value>
		public System.Boolean IsSum
		{
			get	
			{	
				return this.isSum;
			}

			set	
			{	
				this.isSum = value;	
			}
		}		
						

		/// <summary>
		/// 不查询的储存地点 (该属性可为空,且无默认值)
		/// 获取所有的物料库存.Misc.不查询的储存地点
		/// </summary>
		/// <value></value>
		public List<System.String> ExcludeWHCode
		{
			get	
			{	
				return this.excludeWHCode;
			}

			set	
			{	
				this.excludeWHCode = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public QueryAllItemStoreProxy()
        {
        }
        #endregion
        
        #region 跨site调用
        public List<UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTOData> Do(string targetSite)
        {
  			InitKeyList() ;
			List<UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTOData> result = (List<UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTOData>)InvokeBySite<UFIDA.U9.Cust.XMJL.ItemSV.Proxy.IQueryAllItemStore>(targetSite);
			return GetRealResult(result);
        }
        #endregion end跨site调用

		#region 跨组织调用
        public List<UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTOData> Do(long targetOrgId)
        {
  			InitKeyList() ;
			List<UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTOData> result = (List<UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTOData>)InvokeByOrg<UFIDA.U9.Cust.XMJL.ItemSV.Proxy.IQueryAllItemStore>(targetOrgId);
			return GetRealResult(result);
        }
		#endregion end跨组织调用

		#region Public Method
		
        public List<UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTOData> Do()
        {
  			InitKeyList() ;
 			List<UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTOData> result = (List<UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTOData>)InvokeAgent<UFIDA.U9.Cust.XMJL.ItemSV.Proxy.IQueryAllItemStore>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IQueryAllItemStore channel = oChannel as IQueryAllItemStore;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, isSum, excludeWHCode);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private List<UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTOData> GetRealResult(List<UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTOData> result)
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



