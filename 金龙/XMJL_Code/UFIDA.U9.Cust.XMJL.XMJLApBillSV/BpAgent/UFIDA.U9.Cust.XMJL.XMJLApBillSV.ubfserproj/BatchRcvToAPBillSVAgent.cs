








namespace UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.IBatchRcvToAPBillSV")]
    public interface IBatchRcvToAPBillSV
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
		System.Int64 Do(IContext context, out IList<MessageBase> outMessages ,List<UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.RCVLineInfoDTOData> rCVLineInfoDTO, System.Int64 sRCOrgID, System.Int64 currency, System.String supplierCode, System.String aPBillCode);
    }
	[Serializable]    
    public class BatchRcvToAPBillSVProxy : ServiceProxyBase//, UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.Proxy.IBatchRcvToAPBillSV
    {
	#region Fields	
				private List<UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.RCVLineInfoDTOData> rCVLineInfoDTO ;
						private System.Int64 sRCOrgID ;
						private System.Int64 currency ;
						private System.String supplierCode ;
						private System.String aPBillCode ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 行集合 (该属性可为空,且无默认值)
		/// 发票生成应付单.Misc.行集合
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.RCVLineInfoDTOData> RCVLineInfoDTO
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
		/// 组织ID (该属性可为空,但有默认值)
		/// 发票生成应付单.Misc.组织ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SRCOrgID
		{
			get	
			{	
				return this.sRCOrgID;
			}

			set	
			{	
				this.sRCOrgID = value;	
			}
		}		
						

		/// <summary>
		/// 币种 (该属性可为空,但有默认值)
		/// 发票生成应付单.Misc.币种
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
		/// 立账供应商 (该属性可为空,且无默认值)
		/// 发票生成应付单.Misc.立账供应商
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
		/// 应付单单号 (该属性可为空,且无默认值)
		/// 发票生成应付单.Misc.应付单单号
		/// </summary>
		/// <value>System.String</value>
		public System.String APBillCode
		{
			get	
			{	
				return this.aPBillCode;
			}

			set	
			{	
				this.aPBillCode = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public BatchRcvToAPBillSVProxy()
        {
        }
        #endregion
        
        #region 跨site调用
        public System.Int64 Do(string targetSite)
        {
  			InitKeyList() ;
			System.Int64 result = (System.Int64)InvokeBySite<UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.Proxy.IBatchRcvToAPBillSV>(targetSite);
			return GetRealResult(result);
        }
        #endregion end跨site调用

		#region 跨组织调用
        public System.Int64 Do(long targetOrgId)
        {
  			InitKeyList() ;
			System.Int64 result = (System.Int64)InvokeByOrg<UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.Proxy.IBatchRcvToAPBillSV>(targetOrgId);
			return GetRealResult(result);
        }
		#endregion end跨组织调用

		#region Public Method
		
        public System.Int64 Do()
        {
  			InitKeyList() ;
 			System.Int64 result = (System.Int64)InvokeAgent<UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.Proxy.IBatchRcvToAPBillSV>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IBatchRcvToAPBillSV channel = oChannel as IBatchRcvToAPBillSV;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, rCVLineInfoDTO, sRCOrgID, currency, supplierCode, aPBillCode);
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
					foreach(UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.RCVLineInfoDTOData objdata in RCVLineInfoDTO)
					{
						objdata.DoSerializeKeyList(dict);
					}
				}
			}
																						
		}
		#endregion 

    }
}



