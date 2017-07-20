








namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.IBatchCreateAdvApprove")]
    public interface IBatchCreateAdvApprove
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
		System.Int32 Do(IContext context, out IList<MessageBase> outMessages ,System.DateTime startDate, System.DateTime endDate);
    }
	[Serializable]    
    public class BatchCreateAdvApproveProxy : OperationProxyBase//, UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.Proxy.IBatchCreateAdvApprove
    {
	#region Fields	
				private System.DateTime startDate ;
						private System.DateTime endDate ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 开始日期 (该属性可为空,且无默认值)
		/// 批量生成核销单.Misc.开始日期
		/// </summary>
		/// <value>System.Date</value>
		public System.DateTime StartDate
		{
			get	
			{	
				return this.startDate;
			}

			set	
			{	
				this.startDate = value;	
			}
		}		
						

		/// <summary>
		/// 结束日期 (该属性可为空,且无默认值)
		/// 批量生成核销单.Misc.结束日期
		/// </summary>
		/// <value>System.Date</value>
		public System.DateTime EndDate
		{
			get	
			{	
				return this.endDate;
			}

			set	
			{	
				this.endDate = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public BatchCreateAdvApproveProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public System.Int32 Do()
        {
  			InitKeyList() ;
 			System.Int32 result = (System.Int32)InvokeAgent<UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.Proxy.IBatchCreateAdvApprove>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IBatchCreateAdvApprove channel = oChannel as IBatchCreateAdvApprove;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, startDate, endDate);
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



