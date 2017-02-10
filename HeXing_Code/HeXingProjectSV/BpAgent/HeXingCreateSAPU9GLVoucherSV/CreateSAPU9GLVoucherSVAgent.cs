








namespace UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.ICreateSAPU9GLVoucherSV")]
    public interface ICreateSAPU9GLVoucherSV
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
		UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.CommonResultDTOData Do(IContext context, out IList<MessageBase> outMessages ,List<UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherDTOData> sAPU9GLVoucherDTOS);
    }
	[Serializable]    
    public class CreateSAPU9GLVoucherSVProxy : ServiceProxyBase//, UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.Proxy.ICreateSAPU9GLVoucherSV
    {
	#region Fields	
				private List<UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherDTOData> sAPU9GLVoucherDTOS ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// SAP与U9凭证对接中间表列表 (该属性可为空,且无默认值)
		/// 创建SAP与U9凭证对接中间表服务.Misc.SAP与U9凭证对接中间表列表
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherDTOData> SAPU9GLVoucherDTOS
		{
			get	
			{	
				return this.sAPU9GLVoucherDTOS;
			}

			set	
			{	
				this.sAPU9GLVoucherDTOS = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public CreateSAPU9GLVoucherSVProxy()
        {
        }
        #endregion
        
        #region 跨site调用
        public UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.CommonResultDTOData Do(string targetSite)
        {
  			InitKeyList() ;
			UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.CommonResultDTOData result = (UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.CommonResultDTOData)InvokeBySite<UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.Proxy.ICreateSAPU9GLVoucherSV>(targetSite);
			return GetRealResult(result);
        }
        #endregion end跨site调用

		#region 跨组织调用
        public UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.CommonResultDTOData Do(long targetOrgId)
        {
  			InitKeyList() ;
			UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.CommonResultDTOData result = (UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.CommonResultDTOData)InvokeByOrg<UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.Proxy.ICreateSAPU9GLVoucherSV>(targetOrgId);
			return GetRealResult(result);
        }
		#endregion end跨组织调用

		#region Public Method
		
        public UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.CommonResultDTOData Do()
        {
  			InitKeyList() ;
 			UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.CommonResultDTOData result = (UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.CommonResultDTOData)InvokeAgent<UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.Proxy.ICreateSAPU9GLVoucherSV>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            ICreateSAPU9GLVoucherSV channel = oChannel as ICreateSAPU9GLVoucherSV;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, sAPU9GLVoucherDTOS);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.CommonResultDTOData GetRealResult(UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.CommonResultDTOData result)
		{

				return result ;
		}
		#region  Init KeyList 
		//初始化SKey集合--由于接口不一样.BP.SV都要处理
		private void InitKeyList()
		{
			System.Collections.Hashtable dict = new System.Collections.Hashtable() ;
						{
				if (SAPU9GLVoucherDTOS!=null)
				{
					foreach(UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.SAPU9GLVoucherDTOData objdata in SAPU9GLVoucherDTOS)
					{
						objdata.DoSerializeKeyList(dict);
					}
				}
			}
		
		}
		#endregion 

    }
}



