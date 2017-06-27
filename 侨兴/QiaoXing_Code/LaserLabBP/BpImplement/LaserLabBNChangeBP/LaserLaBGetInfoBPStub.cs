







namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.ILaserLaBGetInfoBP")]
    public interface ILaserLaBGetInfoBP
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
        List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LabBNInfoDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,System.String bN, System.String type);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class LaserLaBGetInfoBPStub : OperationStubBase, ILaserLaBGetInfoBP
    {
        #region ILaserLaBGetInfoBP Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LabBNInfoDTOData> Do(IContext context ,out IList<MessageBase> outMessages, System.String bN, System.String type)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, bN, type);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LabBNInfoDTOData> DoEx(ICommonDataContract commonData, System.String bN, System.String type)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LaserLaBGetInfoBP");                
                LaserLaBGetInfoBP objectRef = new LaserLaBGetInfoBP();
		
				objectRef.BN = bN;
				objectRef.Type = type;

				//处理返回类型.
				List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LabBNInfoDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LabBNInfoDTOData> list = new List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LabBNInfoDTOData>();
				foreach (UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LabBNInfoDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LabBNInfoDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LaserLaBGetInfoBP");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.LaserLaBGetInfoBP");
            }
        }
	#endregion
    }
}
