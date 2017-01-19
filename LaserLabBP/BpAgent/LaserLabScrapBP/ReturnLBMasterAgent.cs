








namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.IReturnLBMaster")]
    public interface IReturnLBMaster
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
		System.String Do(IContext context, out IList<MessageBase> outMessages ,System.String lB, System.String cP);
    }
	[Serializable]    
    public class ReturnLBMasterProxy : OperationProxyBase//, UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.Proxy.IReturnLBMaster
    {
	#region Fields	
				private System.String lB ;
						private System.String cP ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// LB编码 (该属性可为空,且无默认值)
		/// 返回物料状态.Misc.LB编码
		/// </summary>
		/// <value>System.String</value>
		public System.String LB
		{
			get	
			{	
				return this.lB;
			}

			set	
			{	
				this.lB = value;	
			}
		}		
						

		/// <summary>
		/// 状态 (该属性可为空,且无默认值)
		/// 返回物料状态.Misc.状态
		/// </summary>
		/// <value>System.String</value>
		public System.String CP
		{
			get	
			{	
				return this.cP;
			}

			set	
			{	
				this.cP = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public ReturnLBMasterProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public System.String Do()
        {
  			InitKeyList() ;
 			System.String result = (System.String)InvokeAgent<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.Proxy.IReturnLBMaster>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IReturnLBMaster channel = oChannel as IReturnLBMaster;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, lB, cP);
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



