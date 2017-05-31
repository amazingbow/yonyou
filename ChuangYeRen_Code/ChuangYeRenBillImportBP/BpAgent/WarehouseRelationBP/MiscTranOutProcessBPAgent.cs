﻿








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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP.IMiscTranOutProcessBP")]
    public interface IMiscTranOutProcessBP
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
		PublicDataTransObj.PublicReturnDTOData Do(IContext context, out IList<MessageBase> outMessages ,System.Int64 relationID);
    }
	[Serializable]    
    public class MiscTranOutProcessBPProxy : OperationProxyBase//, UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP.Proxy.IMiscTranOutProcessBP
    {
	#region Fields	
				private System.Int64 relationID ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// RelationID (该属性可为空,但有默认值)
		/// 杂发操作.Misc.RelationID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 RelationID
		{
			get	
			{	
				return this.relationID;
			}

			set	
			{	
				this.relationID = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public MiscTranOutProcessBPProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public PublicDataTransObj.PublicReturnDTOData Do()
        {
  			InitKeyList() ;
 			PublicDataTransObj.PublicReturnDTOData result = (PublicDataTransObj.PublicReturnDTOData)InvokeAgent<UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP.Proxy.IMiscTranOutProcessBP>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IMiscTranOutProcessBP channel = oChannel as IMiscTranOutProcessBP;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, relationID);
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



