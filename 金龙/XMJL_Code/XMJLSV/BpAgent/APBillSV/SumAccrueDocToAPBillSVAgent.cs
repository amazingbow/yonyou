








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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.APBillSV.ISumAccrueDocToAPBillSV")]
    public interface ISumAccrueDocToAPBillSV
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
		UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData Do(IContext context, out IList<MessageBase> outMessages ,System.String supplierCode, System.Int64 currency, System.Int64 sRCOrgID, List<UFIDA.U9.Cust.XMJL.APBillSV.RCVLineInfoDTOData> rCVLineInfoDTO, System.String aPBillCode, System.String memo, System.String opCode, System.String opDptCode);
    }
	[Serializable]    
    public class SumAccrueDocToAPBillSVProxy : ServiceProxyBase//, UFIDA.U9.Cust.XMJL.APBillSV.Proxy.ISumAccrueDocToAPBillSV
    {
	#region Fields	
				private System.String supplierCode ;
						private System.Int64 currency ;
						private System.Int64 sRCOrgID ;
						private List<UFIDA.U9.Cust.XMJL.APBillSV.RCVLineInfoDTOData> rCVLineInfoDTO ;
						private System.String aPBillCode ;
						private System.String memo ;
						private System.String opCode ;
						private System.String opDptCode ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 立账供应商 (该属性可为空,且无默认值)
		/// 汇总立账生单.Misc.立账供应商
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
		/// 币种 (该属性可为空,但有默认值)
		/// 汇总立账生单.Misc.币种
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
		/// 汇总立账生单.Misc.来源组织ID
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
		/// 收货行信息 (该属性可为空,且无默认值)
		/// 汇总立账生单.Misc.收货行信息
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.XMJL.APBillSV.RCVLineInfoDTOData> RCVLineInfoDTO
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
		/// 发票号 (该属性可为空,且无默认值)
		/// 汇总立账生单.Misc.发票号
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
						

		/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 汇总立账生单.Misc.备注
		/// </summary>
		/// <value>System.String</value>
		public System.String Memo
		{
			get	
			{	
				return this.memo;
			}

			set	
			{	
				this.memo = value;	
			}
		}		
						

		/// <summary>
		/// 业务员代码 (该属性可为空,且无默认值)
		/// 汇总立账生单.Misc.业务员代码
		/// </summary>
		/// <value>System.String</value>
		public System.String OpCode
		{
			get	
			{	
				return this.opCode;
			}

			set	
			{	
				this.opCode = value;	
			}
		}		
						

		/// <summary>
		/// 业务员部门 (该属性可为空,且无默认值)
		/// 汇总立账生单.Misc.业务员部门
		/// </summary>
		/// <value>System.String</value>
		public System.String OpDptCode
		{
			get	
			{	
				return this.opDptCode;
			}

			set	
			{	
				this.opDptCode = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public SumAccrueDocToAPBillSVProxy()
        {
        }
        #endregion
        
        #region 跨site调用
        public UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData Do(string targetSite)
        {
  			InitKeyList() ;
			UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData result = (UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData)InvokeBySite<UFIDA.U9.Cust.XMJL.APBillSV.Proxy.ISumAccrueDocToAPBillSV>(targetSite);
			return GetRealResult(result);
        }
        #endregion end跨site调用

		#region 跨组织调用
        public UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData Do(long targetOrgId)
        {
  			InitKeyList() ;
			UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData result = (UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData)InvokeByOrg<UFIDA.U9.Cust.XMJL.APBillSV.Proxy.ISumAccrueDocToAPBillSV>(targetOrgId);
			return GetRealResult(result);
        }
		#endregion end跨组织调用

		#region Public Method
		
        public UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData Do()
        {
  			InitKeyList() ;
 			UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData result = (UFIDA.U9.Cust.XMJL.APBillSV.CommonResultDTOData)InvokeAgent<UFIDA.U9.Cust.XMJL.APBillSV.Proxy.ISumAccrueDocToAPBillSV>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            ISumAccrueDocToAPBillSV channel = oChannel as ISumAccrueDocToAPBillSV;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, supplierCode, currency, sRCOrgID, rCVLineInfoDTO, aPBillCode, memo, opCode, opDptCode);
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
																					{
				if (RCVLineInfoDTO!=null)
				{
					foreach(UFIDA.U9.Cust.XMJL.APBillSV.RCVLineInfoDTOData objdata in RCVLineInfoDTO)
					{
						objdata.DoSerializeKeyList(dict);
					}
				}
			}
																						
		}
		#endregion 

    }
}



