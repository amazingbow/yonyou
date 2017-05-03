







namespace UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP
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
        PublicDataTransObj.PublicReturnDTOData Do(IContext context ,out IList<MessageBase> outMessages ,System.String relationID);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class MiscTranOutProcessBPStub : OperationStubBase, IMiscTranOutProcessBP
    {
        #region IMiscTranOutProcessBP Members

        //[OperationBehavior]
        public PublicDataTransObj.PublicReturnDTOData Do(IContext context ,out IList<MessageBase> outMessages, System.String relationID)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, relationID);
        }
        
        //[OperationBehavior]
        public PublicDataTransObj.PublicReturnDTOData DoEx(ICommonDataContract commonData, System.String relationID)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP.MiscTranOutProcessBP");                
                MiscTranOutProcessBP objectRef = new MiscTranOutProcessBP();
	
				objectRef.RelationID = relationID;

				//处理返回类型.
				PublicDataTransObj.PublicReturnDTO result = objectRef.Do();

				if (result == null)
					return null ;
						PublicDataTransObj.PublicReturnDTOData resultdata = result.ToEntityData();
				DoSerializeKey(resultdata, "UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP.MiscTranOutProcessBP");
				return resultdata;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.ChuangYeRenBillImportBP.WarehouseRelationBP.MiscTranOutProcessBP");
            }
        }
	#endregion
    }
}
