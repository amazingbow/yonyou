







namespace UFIDA.U9.Cust.XMJL.XMJLBomChangeBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.ICheckItemInBomBP")]
    public interface ICheckItemInBomBP
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
        List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomPartInfoDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,List<System.String> itemIdList);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class CheckItemInBomBPStub : OperationStubBase, ICheckItemInBomBP
    {
        #region ICheckItemInBomBP Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomPartInfoDTOData> Do(IContext context ,out IList<MessageBase> outMessages, List<System.String> itemIdList)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, itemIdList);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomPartInfoDTOData> DoEx(ICommonDataContract commonData, List<System.String> itemIdList)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.CheckItemInBomBP");                
                CheckItemInBomBP objectRef = new CheckItemInBomBP();
	
				objectRef.ItemIdList = itemIdList;

				//处理返回类型.
				List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomPartInfoDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomPartInfoDTOData> listEntityList = new List<UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomPartInfoDTOData>();
				foreach (UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomPartInfoDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.BomPartInfoDTOData resultdata = obj.ToEntityData();
					listEntityList.Add(resultdata);
				}
				DoSerializeKey(listEntityList, "UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.CheckItemInBomBP");
				return listEntityList;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.CheckItemInBomBP");
            }
        }
	#endregion
    }
}
