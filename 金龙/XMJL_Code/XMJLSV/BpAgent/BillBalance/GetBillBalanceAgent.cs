








namespace UFIDA.U9.Cust.XMJL.BillBalanceSV.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.BillBalanceSV.IGetBillBalance")]
    public interface IGetBillBalance
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
		List<UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTOData> Do(IContext context, out IList<MessageBase> outMessages ,UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceQueryDTOData billBalanceQueryDTO);
    }
	[Serializable]    
    public class GetBillBalanceProxy : ServiceProxyBase//, UFIDA.U9.Cust.XMJL.BillBalanceSV.Proxy.IGetBillBalance
    {
	#region Fields	
				private UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceQueryDTOData billBalanceQueryDTO ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 应付明细账查询条件 (该属性可为空,且无默认值)
		/// 查询应付明细帐.Misc.应付明细账查询条件
		/// </summary>
		/// <value>UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceQueryDTO</value>
		public UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceQueryDTOData BillBalanceQueryDTO
		{
			get	
			{	
				return this.billBalanceQueryDTO;
			}

			set	
			{	
				this.billBalanceQueryDTO = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public GetBillBalanceProxy()
        {
        }
        #endregion
        
        #region 跨site调用
        public List<UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTOData> Do(string targetSite)
        {
  			InitKeyList() ;
			List<UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTOData> result = (List<UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTOData>)InvokeBySite<UFIDA.U9.Cust.XMJL.BillBalanceSV.Proxy.IGetBillBalance>(targetSite);
			return GetRealResult(result);
        }
        #endregion end跨site调用

		#region 跨组织调用
        public List<UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTOData> Do(long targetOrgId)
        {
  			InitKeyList() ;
			List<UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTOData> result = (List<UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTOData>)InvokeByOrg<UFIDA.U9.Cust.XMJL.BillBalanceSV.Proxy.IGetBillBalance>(targetOrgId);
			return GetRealResult(result);
        }
		#endregion end跨组织调用

		#region Public Method
		
        public List<UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTOData> Do()
        {
  			InitKeyList() ;
 			List<UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTOData> result = (List<UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTOData>)InvokeAgent<UFIDA.U9.Cust.XMJL.BillBalanceSV.Proxy.IGetBillBalance>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IGetBillBalance channel = oChannel as IGetBillBalance;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, billBalanceQueryDTO);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private List<UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTOData> GetRealResult(List<UFIDA.U9.Cust.XMJL.BillBalanceSV.BillBalanceDTOData> result)
		{
								return result ;
			}
		#region  Init KeyList 
		//初始化SKey集合--由于接口不一样.BP.SV都要处理
		private void InitKeyList()
		{
			System.Collections.Hashtable dict = new System.Collections.Hashtable() ;
						{
				if (BillBalanceQueryDTO != null)
				{
					BillBalanceQueryDTO.DoSerializeKeyList(dict);
				}
			}
		
		}
		#endregion 

    }
}



