








namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabDataProcessBP.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabDataProcessBP.ILbDataProcessBP")]
    public interface ILbDataProcessBP
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
		System.Int32 Do(IContext context, out IList<MessageBase> outMessages ,System.Int32 processType);
    }
	[Serializable]    
    public class LbDataProcessBPProxy : OperationProxyBase//, UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabDataProcessBP.Proxy.ILbDataProcessBP
    {
	#region Fields	
				private System.Int32 processType ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 数据转换类型 (该属性可为空,但有默认值)
		/// 镭射表数据处理.Misc.数据转换类型
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 ProcessType
		{
			get	
			{	
				return this.processType;
			}

			set	
			{	
				this.processType = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public LbDataProcessBPProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public System.Int32 Do()
        {
  			InitKeyList() ;
 			System.Int32 result = (System.Int32)InvokeAgent<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabDataProcessBP.Proxy.ILbDataProcessBP>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            ILbDataProcessBP channel = oChannel as ILbDataProcessBP;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, processType);
	    }
            return  (System.Int32)0;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private System.Int32 GetRealResult(System.Int32 result)
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



