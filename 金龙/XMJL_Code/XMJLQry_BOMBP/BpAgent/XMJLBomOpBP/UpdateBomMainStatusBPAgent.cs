








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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJLBomOpBP.IUpdateBomMainStatusBP")]
    public interface IUpdateBomMainStatusBP
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
		System.String Do(IContext context, out IList<MessageBase> outMessages ,List<System.String> manufactureNoList, System.Int32 disburseType);
    }
	[Serializable]    
    public class UpdateBomMainStatusBPProxy : OperationProxyBase//, UFIDA.U9.Cust.XMJLBomOpBP.Proxy.IUpdateBomMainStatusBP
    {
	#region Fields	
				private List<System.String> manufactureNoList ;
						private System.Int32 disburseType ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 缺件主表车号集合 (该属性可为空,且无默认值)
		/// 更新缺件主表状态和发料单号.Misc.缺件主表车号集合
		/// </summary>
		/// <value></value>
		public List<System.String> ManufactureNoList
		{
			get	
			{	
				return this.manufactureNoList;
			}

			set	
			{	
				this.manufactureNoList = value;	
			}
		}		
						

		/// <summary>
		/// 发料类型 (该属性可为空,但有默认值)
		/// 更新缺件主表状态和发料单号.Misc.发料类型
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
        public UpdateBomMainStatusBPProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public System.String Do()
        {
  			InitKeyList() ;
 			System.String result = (System.String)InvokeAgent<UFIDA.U9.Cust.XMJLBomOpBP.Proxy.IUpdateBomMainStatusBP>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IUpdateBomMainStatusBP channel = oChannel as IUpdateBomMainStatusBP;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, manufactureNoList, disburseType);
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
										
		}
		#endregion 

    }
}



