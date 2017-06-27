








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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJLBomOpBP.IGetBOMMainInfo")]
    public interface IGetBOMMainInfo
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
		List<UFIDA.U9.Cust.XMJLBomOpBP.BOMMainInfoDtoData> Do(IContext context, out IList<MessageBase> outMessages ,System.String manufactureNo, System.String contractNo, System.String carType, System.Int32 disburseType);
    }
	[Serializable]    
    public class GetBOMMainInfoProxy : OperationProxyBase//, UFIDA.U9.Cust.XMJLBomOpBP.Proxy.IGetBOMMainInfo
    {
	#region Fields	
				private System.String manufactureNo ;
						private System.String contractNo ;
						private System.String carType ;
						private System.Int32 disburseType ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 车号 (该属性可为空,且无默认值)
		/// 获取缺件主表信息.Misc.车号
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
		/// 合同号 (该属性可为空,且无默认值)
		/// 获取缺件主表信息.Misc.合同号
		/// </summary>
		/// <value>System.String</value>
		public System.String ContractNo
		{
			get	
			{	
				return this.contractNo;
			}

			set	
			{	
				this.contractNo = value;	
			}
		}		
						

		/// <summary>
		/// 车型 (该属性可为空,且无默认值)
		/// 获取缺件主表信息.Misc.车型
		/// </summary>
		/// <value>System.String</value>
		public System.String CarType
		{
			get	
			{	
				return this.carType;
			}

			set	
			{	
				this.carType = value;	
			}
		}		
						

		/// <summary>
		/// 发料类型 (该属性可为空,但有默认值)
		/// 获取缺件主表信息.Misc.发料类型
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 DisburseType
		{
			get	
			{	
				return this.disburseType;
			}

			set	
			{	
				this.disburseType = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public GetBOMMainInfoProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public List<UFIDA.U9.Cust.XMJLBomOpBP.BOMMainInfoDtoData> Do()
        {
  			InitKeyList() ;
 			List<UFIDA.U9.Cust.XMJLBomOpBP.BOMMainInfoDtoData> result = (List<UFIDA.U9.Cust.XMJLBomOpBP.BOMMainInfoDtoData>)InvokeAgent<UFIDA.U9.Cust.XMJLBomOpBP.Proxy.IGetBOMMainInfo>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IGetBOMMainInfo channel = oChannel as IGetBOMMainInfo;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, manufactureNo, contractNo, carType, disburseType);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private List<UFIDA.U9.Cust.XMJLBomOpBP.BOMMainInfoDtoData> GetRealResult(List<UFIDA.U9.Cust.XMJLBomOpBP.BOMMainInfoDtoData> result)
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



