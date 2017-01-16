








namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabAddBP.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabAddBP.ILaserLabAddBP")]
    public interface ILaserLabAddBP
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
		System.String Do(IContext context, out IList<MessageBase> outMessages ,System.String bN, System.String lB, System.String type, System.DateTime masterDT, System.String customer);
    }
	[Serializable]    
    public class LaserLabAddBPProxy : OperationProxyBase//, UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabAddBP.Proxy.ILaserLabAddBP
    {
	#region Fields	
				private System.String bN ;
						private System.String lB ;
						private System.String type ;
						private System.DateTime masterDT ;
						private System.String customer ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 批次号 (该属性可为空,且无默认值)
		/// 镭射标添加.Misc.批次号
		/// </summary>
		/// <value>System.String</value>
		public System.String BN
		{
			get	
			{	
				return this.bN;
			}

			set	
			{	
				this.bN = value;	
			}
		}		
						

		/// <summary>
		/// 镭射标 (该属性可为空,且无默认值)
		/// 镭射标添加.Misc.镭射标
		/// </summary>
		/// <value>System.String</value>
		public System.String LB
		{
			get	
			{	
				return this.lB;
			}

			set	
			{	
				this.lB = value;	
			}
		}		
						

		/// <summary>
		/// 型号 (该属性可为空,且无默认值)
		/// 镭射标添加.Misc.型号
		/// </summary>
		/// <value>System.String</value>
		public System.String Type
		{
			get	
			{	
				return this.type;
			}

			set	
			{	
				this.type = value;	
			}
		}		
						

		/// <summary>
		/// 物料时间 (该属性可为空,且无默认值)
		/// 镭射标添加.Misc.物料时间
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime MasterDT
		{
			get	
			{	
				return this.masterDT;
			}

			set	
			{	
				this.masterDT = value;	
			}
		}		
						

		/// <summary>
		/// 客户 (该属性可为空,且无默认值)
		/// 镭射标添加.Misc.客户
		/// </summary>
		/// <value>System.String</value>
		public System.String Customer
		{
			get	
			{	
				return this.customer;
			}

			set	
			{	
				this.customer = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public LaserLabAddBPProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public System.String Do()
        {
  			InitKeyList() ;
 			System.String result = (System.String)InvokeAgent<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabAddBP.Proxy.ILaserLabAddBP>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            ILaserLabAddBP channel = oChannel as ILaserLabAddBP;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, bN, lB, type, masterDT, customer);
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



