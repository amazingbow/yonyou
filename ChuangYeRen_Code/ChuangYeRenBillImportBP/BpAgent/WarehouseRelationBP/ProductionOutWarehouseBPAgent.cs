








namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP.IProductionOutWarehouseBP")]
    public interface IProductionOutWarehouseBP
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
		PublicDataTransObj.PublicReturnDTOData Do(IContext context, out IList<MessageBase> outMessages ,System.Int64 relationId, System.Int64 moId);
    }
	[Serializable]    
    public class ProductionOutWarehouseBPProxy : OperationProxyBase//, UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP.Proxy.IProductionOutWarehouseBP
    {
	#region Fields	
				private System.Int64 relationId ;
						private System.Int64 moId ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 相关ID (该属性可为空,但有默认值)
		/// 成品出库操作.Misc.相关ID
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
						

		/// <summary>
		/// 生产订单ID (该属性可为空,但有默认值)
		/// 成品出库操作.Misc.生产订单ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 MoId
		{
			get	
			{	
				return this.moId;
			}

			set	
			{	
				this.moId = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public ProductionOutWarehouseBPProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public PublicDataTransObj.PublicReturnDTOData Do()
        {
  			InitKeyList() ;
 			PublicDataTransObj.PublicReturnDTOData result = (PublicDataTransObj.PublicReturnDTOData)InvokeAgent<UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP.Proxy.IProductionOutWarehouseBP>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IProductionOutWarehouseBP channel = oChannel as IProductionOutWarehouseBP;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, relationId, moId);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private PublicDataTransObj.PublicReturnDTOData GetRealResult(PublicDataTransObj.PublicReturnDTOData result)
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



