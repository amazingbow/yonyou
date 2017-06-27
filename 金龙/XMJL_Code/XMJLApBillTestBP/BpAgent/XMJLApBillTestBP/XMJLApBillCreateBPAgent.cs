








namespace UFIDA.U9.Cust.XMJL.XMJLApBillTestBP.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.XMJLApBillTestBP.IXMJLApBillCreateBP")]
    public interface IXMJLApBillCreateBP
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
		System.Int64 Do(IContext context, out IList<MessageBase> outMessages ,System.String supplierCode, List<UFIDA.U9.Cust.XMJL.XMJLApBillTestBP.RCVLineInfoDTOData> rCVLineInfoDTO, System.Int64 currency, System.Int64 srcOrgID);
    }
	[Serializable]    
    public class XMJLApBillCreateBPProxy : OperationProxyBase//, UFIDA.U9.Cust.XMJL.XMJLApBillTestBP.Proxy.IXMJLApBillCreateBP
    {
	#region Fields	
				private System.String supplierCode ;
						private List<UFIDA.U9.Cust.XMJL.XMJLApBillTestBP.RCVLineInfoDTOData> rCVLineInfoDTO ;
						private System.Int64 currency ;
						private System.Int64 srcOrgID ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 立账供应商 (该属性可为空,且无默认值)
		/// XMJL应付单生成.Misc.立账供应商
		/// </summary>
		/// <value>System.String</value>
		public System.String SupplierCode
		{
			get	
			{	
				return this.supplierCode;
			}

			set	
			{	
				this.supplierCode = value;	
			}
		}		
						

		/// <summary>
		/// 收货行信息（退货） (该属性可为空,且无默认值)
		/// XMJL应付单生成.Misc.收货行信息（退货）
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.XMJL.XMJLApBillTestBP.RCVLineInfoDTOData> RCVLineInfoDTO
		{
			get	
			{	
				return this.rCVLineInfoDTO;
			}

			set	
			{	
				this.rCVLineInfoDTO = value;	
			}
		}		
						

		/// <summary>
		/// 币种 (该属性可为空,但有默认值)
		/// XMJL应付单生成.Misc.币种
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 Currency
		{
			get	
			{	
				return this.currency;
			}

			set	
			{	
				this.currency = value;	
			}
		}		
						

		/// <summary>
		/// 来源组织ID (该属性可为空,但有默认值)
		/// XMJL应付单生成.Misc.来源组织ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SrcOrgID
		{
			get	
			{	
				return this.srcOrgID;
			}

			set	
			{	
				this.srcOrgID = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public XMJLApBillCreateBPProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public System.Int64 Do()
        {
  			InitKeyList() ;
 			System.Int64 result = (System.Int64)InvokeAgent<UFIDA.U9.Cust.XMJL.XMJLApBillTestBP.Proxy.IXMJLApBillCreateBP>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IXMJLApBillCreateBP channel = oChannel as IXMJLApBillCreateBP;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, supplierCode, rCVLineInfoDTO, currency, srcOrgID);
	    }
            return  (System.Int64)0;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private System.Int64 GetRealResult(System.Int64 result)
		{

				return result ;
		}
		#region  Init KeyList 
		//初始化SKey集合--由于接口不一样.BP.SV都要处理
		private void InitKeyList()
		{
			System.Collections.Hashtable dict = new System.Collections.Hashtable() ;
											{
				if (RCVLineInfoDTO!=null)
				{
					foreach(UFIDA.U9.Cust.XMJL.XMJLApBillTestBP.RCVLineInfoDTOData objdata in RCVLineInfoDTO)
					{
						objdata.DoSerializeKeyList(dict);
					}
				}
			}
												
		}
		#endregion 

    }
}



