








namespace UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.Proxy
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.IHeXingRelatiomShipBP")]
    public interface IHeXingRelatiomShipBP
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
		List<UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.RelatiomShipBPDtoData> Do(IContext context, out IList<MessageBase> outMessages ,System.String hOrg, System.String hRefType, System.String hColumn, System.String hStr);
    }
	[Serializable]    
    public class HeXingRelatiomShipBPProxy : OperationProxyBase//, UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.Proxy.IHeXingRelatiomShipBP
    {
	#region Fields	
				private System.String hOrg ;
						private System.String hRefType ;
						private System.String hColumn ;
						private System.String hStr ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 组织 (该属性可为空,且无默认值)
		/// 对照信息查询操作.Misc.组织
		/// </summary>
		/// <value>System.String</value>
		public System.String HOrg
		{
			get	
			{	
				return this.hOrg;
			}

			set	
			{	
				this.hOrg = value;	
			}
		}		
						

		/// <summary>
		/// 关系类型 (该属性可为空,且无默认值)
		/// 对照信息查询操作.Misc.关系类型
		/// </summary>
		/// <value>System.String</value>
		public System.String HRefType
		{
			get	
			{	
				return this.hRefType;
			}

			set	
			{	
				this.hRefType = value;	
			}
		}		
						

		/// <summary>
		/// 栏目 (该属性可为空,且无默认值)
		/// 对照信息查询操作.Misc.栏目
		/// </summary>
		/// <value>System.String</value>
		public System.String HColumn
		{
			get	
			{	
				return this.hColumn;
			}

			set	
			{	
				this.hColumn = value;	
			}
		}		
						

		/// <summary>
		/// 字符 (该属性可为空,且无默认值)
		/// 对照信息查询操作.Misc.字符
		/// </summary>
		/// <value>System.String</value>
		public System.String HStr
		{
			get	
			{	
				return this.hStr;
			}

			set	
			{	
				this.hStr = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public HeXingRelatiomShipBPProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public List<UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.RelatiomShipBPDtoData> Do()
        {
  			InitKeyList() ;
 			List<UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.RelatiomShipBPDtoData> result = (List<UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.RelatiomShipBPDtoData>)InvokeAgent<UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.Proxy.IHeXingRelatiomShipBP>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            IHeXingRelatiomShipBP channel = oChannel as IHeXingRelatiomShipBP;
            if (channel != null)
            {
				return channel.Do(context, out returnMsgs, hOrg, hRefType, hColumn, hStr);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private List<UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.RelatiomShipBPDtoData> GetRealResult(List<UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.RelatiomShipBPDtoData> result)
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



