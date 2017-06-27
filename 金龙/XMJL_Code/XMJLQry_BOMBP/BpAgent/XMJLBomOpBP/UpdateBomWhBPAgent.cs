








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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJLBomOpBP.IUpdateBomWhBP")]
    public interface IUpdateBomWhBP
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
		UFIDA.U9.Cust.XMJLBomOpBP.ReturnUpDTOData Do(IContext context, out IList<MessageBase> outMessages ,System.Int64 wareHouse, System.String oPath);
    }
	[Serializable]    
    public class UpdateBomWhBPProxy : OperationProxyBase//, UFIDA.U9.Cust.XMJLBomOpBP.Proxy.IUpdateBomWhBP
    {
	#region Fields	
				private System.Int64 wareHouse ;
						private System.String oPath ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 仓库ID (该属性可为空,但有默认值)
		/// 更新缺件仓库.Misc.仓库ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 WareHouse
		{
			get	
			{	
				return this.wareHouse;
			}

			set	
			{	
				this.wareHouse = value;	
			}
		}		
						

		/// <summary>
		/// OQL查询条件 (该属性可为空,且无默认值)
		/// 更新缺件仓库.Misc.OQL查询条件
		/// </summary>
		/// <value>System.String</value>
		public System.String OPath
		{
			get	
			{	
				return this.oPath;
			}

			set	
			{	
				this.oPath = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public UpdateBomWhBPProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public UFIDA.U9.Cust.XMJLBomOpBP.ReturnUpDTOData Do()
        {
  			InitKeyList() ;
 			UFIDA.U9.Cust.XMJLBomOpBP.ReturnUpDTOData result = (UFIDA.U9.Cust.XMJLBomOpBP.ReturnUpDTOData)InvokeAgent<UFIDA.U9.Cust.XMJLBomOpBP.Proxy.IUpdateBomWhBP>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IUpdateBomWhBP channel = oChannel as IUpdateBomWhBP;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, wareHouse, oPath);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private UFIDA.U9.Cust.XMJLBomOpBP.ReturnUpDTOData GetRealResult(UFIDA.U9.Cust.XMJLBomOpBP.ReturnUpDTOData result)
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



