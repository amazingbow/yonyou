








namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabDataProcessBP.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabDataProcessBP.ISingleChangeBP")]
    public interface ISingleChangeBP
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
		System.Boolean Do(IContext context, out IList<MessageBase> outMessages ,System.String laserLab, System.String batchNo, System.String type, System.Int32 flowStart, System.Int32 flowEnd, System.Int32 changeModel, System.Int32 changeCp, System.String shipBatchNo);
    }
	[Serializable]    
    public class SingleChangeBPProxy : OperationProxyBase//, UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabDataProcessBP.Proxy.ISingleChangeBP
    {
	#region Fields	
				private System.String laserLab ;
						private System.String batchNo ;
						private System.String type ;
						private System.Int32 flowStart ;
						private System.Int32 flowEnd ;
						private System.Int32 changeModel ;
						private System.Int32 changeCp ;
						private System.String shipBatchNo ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 镭射标号 (该属性可为空,且无默认值)
		/// 单个转换BP.Misc.镭射标号
		/// </summary>
		/// <value>System.String</value>
		public System.String LaserLab
		{
			get	
			{	
				return this.laserLab;
			}

			set	
			{	
				this.laserLab = value;	
			}
		}		
						

		/// <summary>
		/// 批号 (该属性可为空,且无默认值)
		/// 单个转换BP.Misc.批号
		/// </summary>
		/// <value>System.String</value>
		public System.String BatchNo
		{
			get	
			{	
				return this.batchNo;
			}

			set	
			{	
				this.batchNo = value;	
			}
		}		
						

		/// <summary>
		/// 型号 (该属性可为空,且无默认值)
		/// 单个转换BP.Misc.型号
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
		/// 流水起码 (该属性可为空,但有默认值)
		/// 单个转换BP.Misc.流水起码
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 FlowStart
		{
			get	
			{	
				return this.flowStart;
			}

			set	
			{	
				this.flowStart = value;	
			}
		}		
						

		/// <summary>
		/// 流水止码 (该属性可为空,但有默认值)
		/// 单个转换BP.Misc.流水止码
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 FlowEnd
		{
			get	
			{	
				return this.flowEnd;
			}

			set	
			{	
				this.flowEnd = value;	
			}
		}		
						

		/// <summary>
		/// 改变方式 (该属性可为空,但有默认值)
		/// 单个转换BP.Misc.改变方式
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 ChangeModel
		{
			get	
			{	
				return this.changeModel;
			}

			set	
			{	
				this.changeModel = value;	
			}
		}		
						

		/// <summary>
		/// 改变类型 (该属性可为空,但有默认值)
		/// 单个转换BP.Misc.改变类型
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 ChangeCp
		{
			get	
			{	
				return this.changeCp;
			}

			set	
			{	
				this.changeCp = value;	
			}
		}		
						

		/// <summary>
		/// 出货批次号 (该属性可为空,且无默认值)
		/// 单个转换BP.Misc.出货批次号
		/// </summary>
		/// <value>System.String</value>
		public System.String ShipBatchNo
		{
			get	
			{	
				return this.shipBatchNo;
			}

			set	
			{	
				this.shipBatchNo = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public SingleChangeBPProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public System.Boolean Do()
        {
  			InitKeyList() ;
 			System.Boolean result = (System.Boolean)InvokeAgent<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabDataProcessBP.Proxy.ISingleChangeBP>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            ISingleChangeBP channel = oChannel as ISingleChangeBP;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, laserLab, batchNo, type, flowStart, flowEnd, changeModel, changeCp, shipBatchNo);
	    }
            return  false;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private System.Boolean GetRealResult(System.Boolean result)
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



