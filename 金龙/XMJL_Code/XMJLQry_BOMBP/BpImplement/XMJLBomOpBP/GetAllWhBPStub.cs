







namespace UFIDA.U9.Cust.XMJLBomOpBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJLBomOpBP.IGetAllWhBP")]
    public interface IGetAllWhBP
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
        List<UFIDA.U9.Cust.XMJLBomOpBP.WarehouseDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,System.Int64 org);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetAllWhBPStub : OperationStubBase, IGetAllWhBP
    {
        #region IGetAllWhBP Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMJLBomOpBP.WarehouseDTOData> Do(IContext context ,out IList<MessageBase> outMessages, System.Int64 org)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, org);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMJLBomOpBP.WarehouseDTOData> DoEx(ICommonDataContract commonData, System.Int64 org)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMJLBomOpBP.GetAllWhBP");                
                GetAllWhBP objectRef = new GetAllWhBP();
	
				objectRef.Org = org;

				//处理返回类型.
				List<UFIDA.U9.Cust.XMJLBomOpBP.WarehouseDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.XMJLBomOpBP.WarehouseDTOData> list = new List<UFIDA.U9.Cust.XMJLBomOpBP.WarehouseDTOData>();
				foreach (UFIDA.U9.Cust.XMJLBomOpBP.WarehouseDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.XMJLBomOpBP.WarehouseDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.XMJLBomOpBP.GetAllWhBP");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.XMJLBomOpBP.GetAllWhBP");
            }
        }
	#endregion
    }
}
