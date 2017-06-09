








namespace UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.IGetValueSetInfo")]
    public interface IGetValueSetInfo
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
		List<UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.ReturnValueSetDefData> Do(IContext context, out IList<MessageBase> outMessages ,System.String valueCode);
    }
	[Serializable]    
    public class GetValueSetInfoProxy : OperationProxyBase//, UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.Proxy.IGetValueSetInfo
    {
	#region Fields	
				private System.String valueCode ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 属性 (该属性可为空,且无默认值)
		/// 根据值集代码获取值集值.Misc.属性
		/// </summary>
		/// <value>System.String</value>
		public System.String ValueCode
		{
			get	
			{	
				return this.valueCode;
			}

			set	
			{	
				this.valueCode = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public GetValueSetInfoProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public List<UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.ReturnValueSetDefData> Do()
        {
  			InitKeyList() ;
 			List<UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.ReturnValueSetDefData> result = (List<UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.ReturnValueSetDefData>)InvokeAgent<UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.Proxy.IGetValueSetInfo>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IGetValueSetInfo channel = oChannel as IGetValueSetInfo;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, valueCode);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private List<UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.ReturnValueSetDefData> GetRealResult(List<UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.ReturnValueSetDefData> result)
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



