








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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJLBomOpBP.IGetAllWhBP")]
    public interface IGetAllWhBP
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
		List<UFIDA.U9.Cust.XMJLBomOpBP.WarehouseDTOData> Do(IContext context, out IList<MessageBase> outMessages ,System.Int64 org);
    }
	[Serializable]    
    public class GetAllWhBPProxy : OperationProxyBase//, UFIDA.U9.Cust.XMJLBomOpBP.Proxy.IGetAllWhBP
    {
	#region Fields	
				private System.Int64 org ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 组织 (该属性可为空,但有默认值)
		/// 获取所有存储地点BP.Misc.组织
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 Org
		{
			get	
			{	
				return this.org;
			}

			set	
			{	
				this.org = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public GetAllWhBPProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public List<UFIDA.U9.Cust.XMJLBomOpBP.WarehouseDTOData> Do()
        {
  			InitKeyList() ;
 			List<UFIDA.U9.Cust.XMJLBomOpBP.WarehouseDTOData> result = (List<UFIDA.U9.Cust.XMJLBomOpBP.WarehouseDTOData>)InvokeAgent<UFIDA.U9.Cust.XMJLBomOpBP.Proxy.IGetAllWhBP>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IGetAllWhBP channel = oChannel as IGetAllWhBP;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, org);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private List<UFIDA.U9.Cust.XMJLBomOpBP.WarehouseDTOData> GetRealResult(List<UFIDA.U9.Cust.XMJLBomOpBP.WarehouseDTOData> result)
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



