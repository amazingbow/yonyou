








namespace UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.ISpeciFicItemInfoBP")]
    public interface ISpeciFicItemInfoBP
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
		System.String Do(IContext context, out IList<MessageBase> outMessages ,List<UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.SpeciFicItemInfoDtoData> speciFicItemInfoDto, System.Int64 operators);
    }
	[Serializable]    
    public class SpeciFicItemInfoBPProxy : OperationProxyBase//, UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.Proxy.ISpeciFicItemInfoBP
    {
	#region Fields	
				private List<UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.SpeciFicItemInfoDtoData> speciFicItemInfoDto ;
						private System.Int64 operators ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 特定物料DTO (该属性可为空,且无默认值)
		/// 特定物料BP.Misc.特定物料DTO
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.SpeciFicItemInfoDtoData> SpeciFicItemInfoDto
		{
			get	
			{	
				return this.speciFicItemInfoDto;
			}

			set	
			{	
				this.speciFicItemInfoDto = value;	
			}
		}		
						

		/// <summary>
		/// 业务员 (该属性可为空,但有默认值)
		/// 特定物料BP.Misc.业务员
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 Operators
		{
			get	
			{	
				return this.operators;
			}

			set	
			{	
				this.operators = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public SpeciFicItemInfoBPProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public System.String Do()
        {
  			InitKeyList() ;
 			System.String result = (System.String)InvokeAgent<UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.Proxy.ISpeciFicItemInfoBP>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            ISpeciFicItemInfoBP channel = oChannel as ISpeciFicItemInfoBP;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, speciFicItemInfoDto, operators);
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
						{
				if (SpeciFicItemInfoDto!=null)
				{
					foreach(UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.SpeciFicItemInfoDtoData objdata in SpeciFicItemInfoDto)
					{
						objdata.DoSerializeKeyList(dict);
					}
				}
			}
							
		}
		#endregion 

    }
}



