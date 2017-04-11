







namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.ILookScrapInfoBP")]
    public interface ILookScrapInfoBP
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
        List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.LookScrapInfoDTOData> Do(IContext context ,out IList<MessageBase> outMessages );
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class LookScrapInfoBPStub : OperationStubBase, ILookScrapInfoBP
    {
        #region ILookScrapInfoBP Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.LookScrapInfoDTOData> Do(IContext context ,out IList<MessageBase> outMessages)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.LookScrapInfoDTOData> DoEx(ICommonDataContract commonData)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.LookScrapInfoBP");                
                LookScrapInfoBP objectRef = new LookScrapInfoBP();


				//处理返回类型.
				List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.LookScrapInfoDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.LookScrapInfoDTOData> list = new List<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.LookScrapInfoDTOData>();
				foreach (UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.LookScrapInfoDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.LookScrapInfoDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.LookScrapInfoBP");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.LookScrapInfoBP");
            }
        }
	#endregion
    }
}
