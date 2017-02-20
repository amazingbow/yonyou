﻿







namespace UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.IHeXingRelatiomShipBP")]
    public interface IHeXingRelatiomShipBP
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
        List<UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.RelatiomShipBPDtoData> Do(IContext context ,out IList<MessageBase> outMessages ,System.String hOrg, System.String hRefType, System.String hColumn, System.String hStr);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class HeXingRelatiomShipBPStub : OperationStubBase, IHeXingRelatiomShipBP
    {
        #region IHeXingRelatiomShipBP Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.RelatiomShipBPDtoData> Do(IContext context ,out IList<MessageBase> outMessages, System.String hOrg, System.String hRefType, System.String hColumn, System.String hStr)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, hOrg, hRefType, hColumn, hStr);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.RelatiomShipBPDtoData> DoEx(ICommonDataContract commonData, System.String hOrg, System.String hRefType, System.String hColumn, System.String hStr)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.HeXingRelatiomShipBP");                
                HeXingRelatiomShipBP objectRef = new HeXingRelatiomShipBP();
				
				objectRef.HOrg = hOrg;
				objectRef.HRefType = hRefType;
				objectRef.HColumn = hColumn;
				objectRef.HStr = hStr;

				//处理返回类型.
				List<UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.RelatiomShipBPDto> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.RelatiomShipBPDtoData> list = new List<UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.RelatiomShipBPDtoData>();
				foreach (UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.RelatiomShipBPDto obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.RelatiomShipBPDtoData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.HeXingRelatiomShipBP");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.HeXingRelatiomShipBP");
            }
        }
	#endregion
    }
}
