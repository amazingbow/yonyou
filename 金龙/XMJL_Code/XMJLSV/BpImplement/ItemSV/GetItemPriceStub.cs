







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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.ItemSV.IGetItemPrice")]
    public interface IGetItemPrice
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
        UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTOData Do(IContext context ,out IList<MessageBase> outMessages ,System.String itemCode);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetItemPriceStub : ServiceStubBase, IGetItemPrice
    {
        #region IGetItemPrice Members

        //[OperationBehavior]
        public UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTOData Do(IContext context ,out IList<MessageBase> outMessages, System.String itemCode)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, itemCode);
        }
        
        //[OperationBehavior]
        public UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTOData DoEx(ICommonDataContract commonData, System.String itemCode)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMJL.ItemSV.GetItemPrice");                
                GetItemPrice objectRef = new GetItemPrice();
	
				objectRef.ItemCode = itemCode;

				//处理返回类型.
				UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTO result = objectRef.Do();

				if (result == null)
					return null ;
						UFIDA.U9.Cust.XMJL.ItemSV.ItemPriceDTOData resultdata = result.ToEntityData();
				DoSerializeKey(resultdata, "UFIDA.U9.Cust.XMJL.ItemSV.GetItemPrice");
				return resultdata;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.XMJL.ItemSV.GetItemPrice");
            }
        }
	#endregion
    }
}
