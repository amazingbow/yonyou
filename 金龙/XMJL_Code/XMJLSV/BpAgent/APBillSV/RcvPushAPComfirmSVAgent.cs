








namespace UFIDA.U9.Cust.XMJL.APBillSV.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.APBillSV.IRcvPushAPComfirmSV")]
    public interface IRcvPushAPComfirmSV
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
		UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData Do(IContext context, out IList<MessageBase> outMessages ,System.Boolean isMergerAPConfirm, System.Int64 rcvID, List<System.Int64> rcvLineIDs);
    }
	[Serializable]    
    public class RcvPushAPComfirmSVProxy : ServiceProxyBase//, UFIDA.U9.Cust.XMJL.APBillSV.Proxy.IRcvPushAPComfirmSV
    {
	#region Fields	
				private System.Boolean isMergerAPConfirm ;
						private System.Int64 rcvID ;
						private List<System.Int64> rcvLineIDs ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 是否合并立账 (该属性可为空,但有默认值)
		/// 收货单推式应付立账服务.Misc.是否合并立账
		/// </summary>
		/// <value>System.Boolean</value>
		public System.Boolean IsMergerAPConfirm
		{
			get	
			{	
				return this.isMergerAPConfirm;
			}

			set	
			{	
				this.isMergerAPConfirm = value;	
			}
		}		
						

		/// <summary>
		/// 收货单ID (该属性可为空,但有默认值)
		/// 收货单推式应付立账服务.Misc.收货单ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 RcvID
		{
			get	
			{	
				return this.rcvID;
			}

			set	
			{	
				this.rcvID = value;	
			}
		}		
						

		/// <summary>
		/// 收货单行ID集合 (该属性可为空,但有默认值)
		/// 收货单推式应付立账服务.Misc.收货单行ID集合
		/// </summary>
		/// <value></value>
		public List<System.Int64> RcvLineIDs
		{
			get	
			{	
				return this.rcvLineIDs;
			}

			set	
			{	
				this.rcvLineIDs = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public RcvPushAPComfirmSVProxy()
        {
        }
        #endregion
        
        #region 跨site调用
        public UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData Do(string targetSite)
        {
  			InitKeyList() ;
			UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData result = (UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData)InvokeBySite<UFIDA.U9.Cust.XMJL.APBillSV.Proxy.IRcvPushAPComfirmSV>(targetSite);
			return GetRealResult(result);
        }
        #endregion end跨site调用

		#region 跨组织调用
        public UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData Do(long targetOrgId)
        {
  			InitKeyList() ;
			UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData result = (UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData)InvokeByOrg<UFIDA.U9.Cust.XMJL.APBillSV.Proxy.IRcvPushAPComfirmSV>(targetOrgId);
			return GetRealResult(result);
        }
		#endregion end跨组织调用

		#region Public Method
		
        public UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData Do()
        {
  			InitKeyList() ;
 			UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData result = (UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData)InvokeAgent<UFIDA.U9.Cust.XMJL.APBillSV.Proxy.IRcvPushAPComfirmSV>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IRcvPushAPComfirmSV channel = oChannel as IRcvPushAPComfirmSV;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, isMergerAPConfirm, rcvID, rcvLineIDs);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData GetRealResult(UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData result)
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



