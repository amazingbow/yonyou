







namespace UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.ISpeciFicItemInfoBP")]
    public interface ISpeciFicItemInfoBP
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
        System.String Do(IContext context ,out IList<MessageBase> outMessages ,List<UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.SpeciFicItemInfoDtoData> speciFicItemInfoDto, System.Int64 operators);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class SpeciFicItemInfoBPStub : OperationStubBase, ISpeciFicItemInfoBP
    {
        #region ISpeciFicItemInfoBP Members

        //[OperationBehavior]
        public System.String Do(IContext context ,out IList<MessageBase> outMessages, List<UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.SpeciFicItemInfoDtoData> speciFicItemInfoDto, System.Int64 operators)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, speciFicItemInfoDto, operators);
        }
        
        //[OperationBehavior]
        public System.String DoEx(ICommonDataContract commonData, List<UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.SpeciFicItemInfoDtoData> speciFicItemInfoDto, System.Int64 operators)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.SpeciFicItemInfoBP");                
                SpeciFicItemInfoBP objectRef = new SpeciFicItemInfoBP();
		

				if (speciFicItemInfoDto != null)
				{
					DeSerializeKey(speciFicItemInfoDto);
					List<UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.SpeciFicItemInfoDto> listSpeciFicItemInfoDto = new List<UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.SpeciFicItemInfoDto>();
					foreach (UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.SpeciFicItemInfoDtoData obj in speciFicItemInfoDto)
					{
						if (obj == null)
							continue;
				
						UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.SpeciFicItemInfoDto child = new UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.SpeciFicItemInfoDto();
						child.FromEntityData(obj);
						//值对象应该是依赖主创建的.但此处不是.可能的问题？
						listSpeciFicItemInfoDto.Add(child);
					}
					objectRef.SpeciFicItemInfoDto = listSpeciFicItemInfoDto;
				}
				objectRef.Operators = operators;

				//处理返回类型.
				System.String result = objectRef.Do();
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
				FinallyInvoke("UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.SpeciFicItemInfoBP");
            }
        }
	#endregion
    }
}
