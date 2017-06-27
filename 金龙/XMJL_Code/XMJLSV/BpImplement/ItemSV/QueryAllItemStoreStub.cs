







namespace UFIDA.U9.Cust.XMJL.ItemSV
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ServiceModel;
	using System.Runtime.Serialization;
	using System.IO;
	using UFSoft.UBF.Util.Context;
	using UFSoft.UBF;
	using UFSoft.UBF.Exceptions;
	using UFSoft.UBF.Service.Base ;

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.ItemSV.IQueryAllItemStore")]
    public interface IQueryAllItemStore
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
        List<UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,System.Boolean isSum, List<System.String> excludeWHCode);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class QueryAllItemStoreStub : ServiceStubBase, IQueryAllItemStore
    {
        #region IQueryAllItemStore Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTOData> Do(IContext context ,out IList<MessageBase> outMessages, System.Boolean isSum, List<System.String> excludeWHCode)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, isSum, excludeWHCode);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTOData> DoEx(ICommonDataContract commonData, System.Boolean isSum, List<System.String> excludeWHCode)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMJL.ItemSV.QueryAllItemStore");                
                QueryAllItemStore objectRef = new QueryAllItemStore();
		
				objectRef.IsSum = isSum;
				objectRef.ExcludeWHCode = excludeWHCode;

				//处理返回类型.
				List<UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTOData> list = new List<UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTOData>();
				foreach (UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.XMJL.ItemSV.ItemStoreDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.XMJL.ItemSV.QueryAllItemStore");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.XMJL.ItemSV.QueryAllItemStore");
            }
        }
	#endregion
    }
}
