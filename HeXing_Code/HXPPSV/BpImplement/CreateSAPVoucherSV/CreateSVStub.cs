







namespace UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.ICreateSV")]
    public interface ICreateSV
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
        List<UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.CommonResultDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,List<UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherDTOData> sAPU9GLVoucherDTOS);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class CreateSVStub : ServiceStubBase, ICreateSV
    {
        #region ICreateSV Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.CommonResultDTOData> Do(IContext context ,out IList<MessageBase> outMessages, List<UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherDTOData> sAPU9GLVoucherDTOS)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, sAPU9GLVoucherDTOS);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.CommonResultDTOData> DoEx(ICommonDataContract commonData, List<UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherDTOData> sAPU9GLVoucherDTOS)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.CreateSV");                
                CreateSV objectRef = new CreateSV();
	

				if (sAPU9GLVoucherDTOS != null)
				{
					DeSerializeKey(sAPU9GLVoucherDTOS);
					List<UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherDTO> listSAPU9GLVoucherDTOS = new List<UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherDTO>();
					foreach (UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherDTOData obj in sAPU9GLVoucherDTOS)
					{
						if (obj == null)
							continue;
				
						UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherDTO child = new UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.SAPU9GLVoucherDTO();
						child.FromEntityData(obj);
						//值对象应该是依赖主创建的.但此处不是.可能的问题？
						listSAPU9GLVoucherDTOS.Add(child);
					}
					objectRef.SAPU9GLVoucherDTOS = listSAPU9GLVoucherDTOS;
				}

				//处理返回类型.
				List<UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.CommonResultDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.CommonResultDTOData> list = new List<UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.CommonResultDTOData>();
				foreach (UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.CommonResultDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.CommonResultDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.CreateSV");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV.CreateSV");
            }
        }
	#endregion
    }
}
