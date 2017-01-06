








namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.ILaserLaBGetInfoBP")]
    public interface ILaserLaBGetInfoBP
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
		List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LabBNInfoDTOData> Do(IContext context, out IList<MessageBase> outMessages ,System.String bN, System.String type);
    }
	[Serializable]    
    public class LaserLaBGetInfoBPProxy : OperationProxyBase//, UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.Proxy.ILaserLaBGetInfoBP
    {
	#region Fields	
				private System.String bN ;
						private System.String type ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 批次号 (该属性可为空,且无默认值)
		/// GetLB信息.Misc.批次号
		/// </summary>
		/// <value>System.String</value>
		public System.String BN
		{
			get	
			{	
				return this.bN;
			}

			set	
			{	
				this.bN = value;	
			}
		}		
						

		/// <summary>
		/// 型号 (该属性可为空,且无默认值)
		/// GetLB信息.Misc.型号
		/// </summary>
		/// <value>System.String</value>
		public System.String Type
		{
			get	
			{	
				return this.type;
			}

			set	
			{	
				this.type = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public LaserLaBGetInfoBPProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LabBNInfoDTOData> Do()
        {
  			InitKeyList() ;
 			List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LabBNInfoDTOData> result = (List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LabBNInfoDTOData>)InvokeAgent<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.Proxy.ILaserLaBGetInfoBP>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            ILaserLaBGetInfoBP channel = oChannel as ILaserLaBGetInfoBP;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, bN, type);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LabBNInfoDTOData> GetRealResult(List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LabBNInfoDTOData> result)
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



