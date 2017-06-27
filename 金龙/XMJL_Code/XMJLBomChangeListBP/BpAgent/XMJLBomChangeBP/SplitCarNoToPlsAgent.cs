








namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.ISplitCarNoToPls")]
    public interface ISplitCarNoToPls
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
		System.Boolean Do(IContext context, out IList<MessageBase> outMessages ,List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.SplitCarDTOData> splitCarDTOList);
    }
	[Serializable]    
    public class SplitCarNoToPlsProxy : OperationProxyBase//, UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.Proxy.ISplitCarNoToPls
    {
	#region Fields	
				private List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.SplitCarDTOData> splitCarDTOList ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 拆分车号数据列表 (该属性可为空,且无默认值)
		/// 生产线料品日计划拆分车号.Misc.拆分车号数据列表
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.SplitCarDTOData> SplitCarDTOList
		{
			get	
			{	
				return this.splitCarDTOList;
			}

			set	
			{	
				this.splitCarDTOList = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public SplitCarNoToPlsProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public System.Boolean Do()
        {
  			InitKeyList() ;
 			System.Boolean result = (System.Boolean)InvokeAgent<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.Proxy.ISplitCarNoToPls>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            ISplitCarNoToPls channel = oChannel as ISplitCarNoToPls;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, splitCarDTOList);
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
						{
				if (SplitCarDTOList!=null)
				{
					foreach(UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.SplitCarDTOData objdata in SplitCarDTOList)
					{
						objdata.DoSerializeKeyList(dict);
					}
				}
			}
		
		}
		#endregion 

    }
}



