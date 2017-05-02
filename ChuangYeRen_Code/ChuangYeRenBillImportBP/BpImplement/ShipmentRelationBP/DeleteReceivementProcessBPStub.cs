







namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.ShipmentRelationBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.ChuangYeRenBillImportBP.ShipmentRelationBP.IDeleteReceivementProcessBP")]
    public interface IDeleteReceivementProcessBP
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
        PublicDataTransObj.PublicReturnDTOData Do(IContext context ,out IList<MessageBase> outMessages ,System.Int64 relationU9Id);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class DeleteReceivementProcessBPStub : OperationStubBase, IDeleteReceivementProcessBP
    {
        #region IDeleteReceivementProcessBP Members

        //[OperationBehavior]
        public PublicDataTransObj.PublicReturnDTOData Do(IContext context ,out IList<MessageBase> outMessages, System.Int64 relationU9Id)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, relationU9Id);
        }
        
        //[OperationBehavior]
        public PublicDataTransObj.PublicReturnDTOData DoEx(ICommonDataContract commonData, System.Int64 relationU9Id)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.ChuangYeRenBillImportBP.ShipmentRelationBP.DeleteReceivementProcessBP");                
                DeleteReceivementProcessBP objectRef = new DeleteReceivementProcessBP();
	
				objectRef.RelationU9Id = relationU9Id;

				//处理返回类型.
				PublicDataTransObj.PublicReturnDTO result = objectRef.Do();

				if (result == null)
					return null ;
						PublicDataTransObj.PublicReturnDTOData resultdata = result.ToEntityData();
				DoSerializeKey(resultdata, "UFIDA.U9.Cust.ChuangYeRenBillImportBP.ShipmentRelationBP.DeleteReceivementProcessBP");
				return resultdata;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.ChuangYeRenBillImportBP.ShipmentRelationBP.DeleteReceivementProcessBP");
            }
        }
	#endregion
    }
}
