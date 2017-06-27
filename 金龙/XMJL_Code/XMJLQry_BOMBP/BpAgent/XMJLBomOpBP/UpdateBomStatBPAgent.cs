








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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJLBomOpBP.IUpdateBomStatBP")]
    public interface IUpdateBomStatBP
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
		UFIDA.U9.Cust.XMJLBomOpBP.ReturnUpDTOData Do(IContext context, out IList<MessageBase> outMessages ,System.String oPath);
    }
	[Serializable]    
    public class UpdateBomStatBPProxy : OperationProxyBase//, UFIDA.U9.Cust.XMJLBomOpBP.Proxy.IUpdateBomStatBP
    {
	#region Fields	
				private System.String oPath ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// OQL查询条件 (该属性可为空,且无默认值)
		/// 更新缺件行状态.Misc.OQL查询条件
		/// </summary>
		/// <value>System.String</value>
		public System.String OPath
		{
			get	
			{	
				return this.oPath;
			}

			set	
			{	
				this.oPath = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public UpdateBomStatBPProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public UFIDA.U9.Cust.XMJLBomOpBP.ReturnUpDTOData Do()
        {
  			InitKeyList() ;
 			UFIDA.U9.Cust.XMJLBomOpBP.ReturnUpDTOData result = (UFIDA.U9.Cust.XMJLBomOpBP.ReturnUpDTOData)InvokeAgent<UFIDA.U9.Cust.XMJLBomOpBP.Proxy.IUpdateBomStatBP>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IUpdateBomStatBP channel = oChannel as IUpdateBomStatBP;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, oPath);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private UFIDA.U9.Cust.XMJLBomOpBP.ReturnUpDTOData GetRealResult(UFIDA.U9.Cust.XMJLBomOpBP.ReturnUpDTOData result)
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



