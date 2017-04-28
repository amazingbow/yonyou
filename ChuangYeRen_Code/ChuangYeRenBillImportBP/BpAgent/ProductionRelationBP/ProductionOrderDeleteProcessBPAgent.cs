








namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP.IProductionOrderDeleteProcessBP")]
    public interface IProductionOrderDeleteProcessBP
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
		void Do(IContext context, out IList<MessageBase> outMessages ,System.Int64 relationId);
    }
	[Serializable]    
    public class ProductionOrderDeleteProcessBPProxy : OperationProxyBase//, UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP.Proxy.IProductionOrderDeleteProcessBP
    {
	#region Fields	
				private System.Int64 relationId ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 相关表ID (该属性可为空,但有默认值)
		/// 生产订单删除处理.Misc.相关表ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 RelationId
		{
			get	
			{	
				return this.relationId;
			}

			set	
			{	
				this.relationId = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public ProductionOrderDeleteProcessBPProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public void Do()
        {
  			InitKeyList() ;
 			InvokeAgent<UFIDA.U9.Cust.ChuangYeRenBillImportBP.ProductionRelationBP.Proxy.IProductionOrderDeleteProcessBP>();
			
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IProductionOrderDeleteProcessBP channel = oChannel as IProductionOrderDeleteProcessBP;
            if (channel != null)
            {
				channel.Do(context, out returnMsgs, relationId);
	    }
            return  null;
        }
		#endregion
		
		#region  Init KeyList 
		//初始化SKey集合--由于接口不一样.BP.SV都要处理
		private void InitKeyList()
		{
			System.Collections.Hashtable dict = new System.Collections.Hashtable() ;
					
		}
		#endregion 

    }
}



