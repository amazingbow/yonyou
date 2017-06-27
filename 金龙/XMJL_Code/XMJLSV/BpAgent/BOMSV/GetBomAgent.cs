








namespace UFIDA.U9.Cust.XMJL.BOMSV.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.BOMSV.IGetBom")]
    public interface IGetBom
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
		List<UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData> Do(IContext context, out IList<MessageBase> outMessages ,System.String manufactureNo, System.DateTime lastSynTimeStamp);
    }
	[Serializable]    
    public class GetBomProxy : ServiceProxyBase//, UFIDA.U9.Cust.XMJL.BOMSV.Proxy.IGetBom
    {
	#region Fields	
				private System.String manufactureNo ;
						private System.DateTime lastSynTimeStamp ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 车号 (该属性可为空,且无默认值)
		/// 获取车辆单台料单.Misc.车号
		/// </summary>
		/// <value>System.String</value>
		public System.String ManufactureNo
		{
			get	
			{	
				return this.manufactureNo;
			}

			set	
			{	
				this.manufactureNo = value;	
			}
		}		
						

		/// <summary>
		/// 最后同步时间 (该属性可为空,且无默认值)
		/// 获取车辆单台料单.Misc.最后同步时间
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime LastSynTimeStamp
		{
			get	
			{	
				return this.lastSynTimeStamp;
			}

			set	
			{	
				this.lastSynTimeStamp = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public GetBomProxy()
        {
        }
        #endregion
        
        #region 跨site调用
        public List<UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData> Do(string targetSite)
        {
  			InitKeyList() ;
			List<UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData> result = (List<UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData>)InvokeBySite<UFIDA.U9.Cust.XMJL.BOMSV.Proxy.IGetBom>(targetSite);
			return GetRealResult(result);
        }
        #endregion end跨site调用

		#region 跨组织调用
        public List<UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData> Do(long targetOrgId)
        {
  			InitKeyList() ;
			List<UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData> result = (List<UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData>)InvokeByOrg<UFIDA.U9.Cust.XMJL.BOMSV.Proxy.IGetBom>(targetOrgId);
			return GetRealResult(result);
        }
		#endregion end跨组织调用

		#region Public Method
		
        public List<UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData> Do()
        {
  			InitKeyList() ;
 			List<UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData> result = (List<UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData>)InvokeAgent<UFIDA.U9.Cust.XMJL.BOMSV.Proxy.IGetBom>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IGetBom channel = oChannel as IGetBom;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, manufactureNo, lastSynTimeStamp);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private List<UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData> GetRealResult(List<UFIDA.U9.Cust.XMJL.BOMSV.ProductBomDTOData> result)
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



