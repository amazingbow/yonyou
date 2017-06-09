







namespace UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.IGetValueSetInfo")]
    public interface IGetValueSetInfo
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
        List<UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.ReturnValueSetDefData> Do(IContext context ,out IList<MessageBase> outMessages ,System.String valueCode);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetValueSetInfoStub : OperationStubBase, IGetValueSetInfo
    {
        #region IGetValueSetInfo Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.ReturnValueSetDefData> Do(IContext context ,out IList<MessageBase> outMessages, System.String valueCode)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, valueCode);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.ReturnValueSetDefData> DoEx(ICommonDataContract commonData, System.String valueCode)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.GetValueSetInfo");                
                GetValueSetInfo objectRef = new GetValueSetInfo();
	
				objectRef.ValueCode = valueCode;

				//处理返回类型.
				List<UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.ReturnValueSetDef> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.ReturnValueSetDefData> list = new List<UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.ReturnValueSetDefData>();
				foreach (UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.ReturnValueSetDef obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.ReturnValueSetDefData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.GetValueSetInfo");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.GetValueSetInfo");
            }
        }
	#endregion
    }
}
