








namespace UFIDA.U9.Cust.XMJL.ReceivementSV.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.ReceivementSV.IGetSRMRcv")]
    public interface IGetSRMRcv
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
		List<UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData> Do(IContext context, out IList<MessageBase> outMessages ,UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvQueryDTOData sRMRcvQueryDTO);
    }
	[Serializable]    
    public class GetSRMRcvProxy : ServiceProxyBase//, UFIDA.U9.Cust.XMJL.ReceivementSV.Proxy.IGetSRMRcv
    {
	#region Fields	
				private UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvQueryDTOData sRMRcvQueryDTO ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// SRM入库单查询条件 (该属性可为空,且无默认值)
		/// 入库单查询.Misc.SRM入库单查询条件
		/// </summary>
		/// <value>UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvQueryDTO</value>
		public UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvQueryDTOData SRMRcvQueryDTO
		{
			get	
			{	
				return this.sRMRcvQueryDTO;
			}

			set	
			{	
				this.sRMRcvQueryDTO = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public GetSRMRcvProxy()
        {
        }
        #endregion
        
        #region 跨site调用
        public List<UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData> Do(string targetSite)
        {
  			InitKeyList() ;
			List<UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData> result = (List<UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData>)InvokeBySite<UFIDA.U9.Cust.XMJL.ReceivementSV.Proxy.IGetSRMRcv>(targetSite);
			return GetRealResult(result);
        }
        #endregion end跨site调用

		#region 跨组织调用
        public List<UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData> Do(long targetOrgId)
        {
  			InitKeyList() ;
			List<UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData> result = (List<UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData>)InvokeByOrg<UFIDA.U9.Cust.XMJL.ReceivementSV.Proxy.IGetSRMRcv>(targetOrgId);
			return GetRealResult(result);
        }
		#endregion end跨组织调用

		#region Public Method
		
        public List<UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData> Do()
        {
  			InitKeyList() ;
 			List<UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData> result = (List<UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData>)InvokeAgent<UFIDA.U9.Cust.XMJL.ReceivementSV.Proxy.IGetSRMRcv>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IGetSRMRcv channel = oChannel as IGetSRMRcv;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, sRMRcvQueryDTO);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private List<UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData> GetRealResult(List<UFIDA.U9.Cust.XMJL.ReceivementSV.SRMRcvDTOData> result)
		{
								return result ;
			}
		#region  Init KeyList 
		//初始化SKey集合--由于接口不一样.BP.SV都要处理
		private void InitKeyList()
		{
			System.Collections.Hashtable dict = new System.Collections.Hashtable() ;
						{
				if (SRMRcvQueryDTO != null)
				{
					SRMRcvQueryDTO.DoSerializeKeyList(dict);
				}
			}
		
		}
		#endregion 

    }
}



