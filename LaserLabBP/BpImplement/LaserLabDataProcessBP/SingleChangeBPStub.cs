







namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabDataProcessBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabDataProcessBP.ISingleChangeBP")]
    public interface ISingleChangeBP
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
        System.Boolean Do(IContext context ,out IList<MessageBase> outMessages ,System.String laserLab, System.String batchNo, System.String type, System.Int32 flowStart, System.Int32 flowEnd, System.Int32 changeModel, System.Int32 changeCp, System.String shipBatchNo, System.DateTime shipDateTime);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class SingleChangeBPStub : OperationStubBase, ISingleChangeBP
    {
        #region ISingleChangeBP Members

        //[OperationBehavior]
        public System.Boolean Do(IContext context ,out IList<MessageBase> outMessages, System.String laserLab, System.String batchNo, System.String type, System.Int32 flowStart, System.Int32 flowEnd, System.Int32 changeModel, System.Int32 changeCp, System.String shipBatchNo, System.DateTime shipDateTime)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, laserLab, batchNo, type, flowStart, flowEnd, changeModel, changeCp, shipBatchNo, shipDateTime);
        }
        
        //[OperationBehavior]
        public System.Boolean DoEx(ICommonDataContract commonData, System.String laserLab, System.String batchNo, System.String type, System.Int32 flowStart, System.Int32 flowEnd, System.Int32 changeModel, System.Int32 changeCp, System.String shipBatchNo, System.DateTime shipDateTime)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabDataProcessBP.SingleChangeBP");                
                SingleChangeBP objectRef = new SingleChangeBP();
									
				objectRef.LaserLab = laserLab;
				objectRef.BatchNo = batchNo;
				objectRef.Type = type;
				objectRef.FlowStart = flowStart;
				objectRef.FlowEnd = flowEnd;
				objectRef.ChangeModel = changeModel;
				objectRef.ChangeCp = changeCp;
				objectRef.ShipBatchNo = shipBatchNo;
				objectRef.ShipDateTime = shipDateTime;

				//处理返回类型.
				System.Boolean result = objectRef.Do();
				return result ;
						return result;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabDataProcessBP.SingleChangeBP");
            }
        }
	#endregion
    }
}
