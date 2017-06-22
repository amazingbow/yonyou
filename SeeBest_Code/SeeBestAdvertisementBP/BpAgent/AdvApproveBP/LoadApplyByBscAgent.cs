








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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.ILoadApplyByBsc")]
    public interface ILoadApplyByBsc
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
		List<UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.ApplyInfoDtoData> Do(IContext context, out IList<MessageBase> outMessages ,System.Int64 custBscID, System.DateTime month);
    }
	[Serializable]    
    public class LoadApplyByBscProxy : OperationProxyBase//, UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.Proxy.ILoadApplyByBsc
    {
	#region Fields	
				private System.Int64 custBscID ;
						private System.DateTime month ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 办事处ID (该属性可为空,但有默认值)
		/// 根据办事处拉取申请单.Misc.办事处ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 CustBscID
		{
			get	
			{	
				return this.custBscID;
			}

			set	
			{	
				this.custBscID = value;	
			}
		}		
						

		/// <summary>
		/// 月份 (该属性可为空,且无默认值)
		/// 根据办事处拉取申请单.Misc.月份
		/// </summary>
		/// <value>System.Date</value>
		public System.DateTime Month
		{
			get	
			{	
				return this.month;
			}

			set	
			{	
				this.month = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public LoadApplyByBscProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public List<UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.ApplyInfoDtoData> Do()
        {
  			InitKeyList() ;
 			List<UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.ApplyInfoDtoData> result = (List<UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.ApplyInfoDtoData>)InvokeAgent<UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.Proxy.ILoadApplyByBsc>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            ILoadApplyByBsc channel = oChannel as ILoadApplyByBsc;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, custBscID, month);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private List<UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.ApplyInfoDtoData> GetRealResult(List<UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.ApplyInfoDtoData> result)
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



