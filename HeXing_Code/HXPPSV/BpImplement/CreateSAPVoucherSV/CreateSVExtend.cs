namespace UFIDA.U9.Cust.HXPPSV.CreateSAPVoucherSV
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE;

    /// <summary>
    /// CreateSV partial 
    /// </summary>	
    public partial class CreateSV
    {
        internal BaseStrategy Select()
        {
            return new CreateSVImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class CreateSVImpementStrategy : BaseStrategy
    {
        public CreateSVImpementStrategy() { }

        public override object Do(object obj)
        {
            CreateSV bpObj = (CreateSV)obj;
            List<SAPU9GLVoucherDTO> sAPU9GLVoucherDTOList = bpObj.SAPU9GLVoucherDTOS;
            List<CommonResultDTO> returnResult = new List<CommonResultDTO>();

            if (sAPU9GLVoucherDTOList.Count == 0)
            {
                CommonResultDTO commonResultDTO = new CommonResultDTO();
                commonResultDTO.IsSuccess = false;
                commonResultDTO.Message = "";
                commonResultDTO.IsSuccess = false;
                commonResultDTO.Message = "没有信息导入";
                returnResult.Add(commonResultDTO);
                return returnResult;
            }

            foreach (SAPU9GLVoucherDTO dto in sAPU9GLVoucherDTOList)
            {
                CommonResultDTO commonResultDTO = new CommonResultDTO();
                commonResultDTO.IsSuccess = false;
                commonResultDTO.Message = "";
                try
                {
                    if (string.IsNullOrEmpty(dto.CompanyCode))
                    {
                        throw new Exception("公司代码为空。");
                    }
                    if (string.IsNullOrEmpty(dto.CompanyName))
                    {
                        throw new Exception("公司名称为空。");
                    }
                    if (string.IsNullOrEmpty(dto.SAPVoucherDisplayCode))
                    {
                        throw new Exception("SAP凭证号为空。");
                    }
                    if (dto.PostDate == DateTime.MinValue || dto.PostDate == null)
                    {
                        throw new Exception("记账日期为空。");
                    }
                    if (dto.PostedPeriod == 0L)
                    {
                        throw new Exception("记账期间为空。");
                    }
                    if (string.IsNullOrEmpty(dto.CurrencyCode))
                    {
                        throw new Exception("币种编码为空。");
                    }
                    if (string.IsNullOrEmpty(dto.CurrencyDescription))
                    {
                        throw new Exception("货币描述为空。");
                    }
                    if (dto.SAPU9GLVoucherLineDTOS.Count == 0)
                    {
                        throw new Exception("行不能为空。");
                    }
                    using (ISession session = Session.Open())
                    {
                        HeXingSAPU9GLVoucherHead doc = HeXingSAPU9GLVoucherHead.Create();

                        doc.CompanyCode = dto.CompanyCode;//公司代码
                        doc.CompanyName = dto.CompanyName;//公司名称
                        doc.SAPVoucherDisplayCode = dto.SAPVoucherDisplayCode;//SAP凭证号
                        doc.VoucherCategoryCode = dto.VoucherCategoryCode;//凭证类型编码
                        doc.VoucherCategoryDescription = dto.VoucherCategoryDescription;//凭证类型描述
                        doc.PostDate = dto.PostDate;//记账日期
                        doc.PostedPeriod = dto.PostedPeriod;//记账期间
                        doc.CurrencyCode = dto.CurrencyCode;//币种编码
                        doc.CurrencyDescription = dto.CurrencyDescription;//货币描述
                        doc.ImportDate = System.DateTime.Now;//导入日期

                        foreach (SAPU9GLVoucherLineDTO dtoline in dto.SAPU9GLVoucherLineDTOS)
                        {
                            HeXingSAPU9GLVoucherLine docline = HeXingSAPU9GLVoucherLine.Create(doc);

                            docline.SerialNo = dtoline.SerialNo;//行号
                            docline.AccountCode = dtoline.AccountCode;//科目编码
                            docline.AccountDescription = dtoline.AccountDescription;//科目描述
                            docline.Abstracts = dtoline.Abstracts;//摘要
                            docline.AccountedDr = dtoline.AccountedDr;//借方金额（本币）
                            docline.AccountedCr = dtoline.AccountedCr;//贷方金额（本币）
                            docline.EnteredDr = dtoline.EnteredDr;//借方金额（原币）
                            docline.EnteredCr = dtoline.EnteredCr;//贷方金额（原币）
                            docline.CashFlowCode = dtoline.CashFlowCode;//现金流量项目编码
                            docline.CashFlowDescription = dtoline.CashFlowDescription;//现金流量项目描述
                            docline.FeeTypeEnumCode = dtoline.FeeTypeEnumCode;//费用类型编码
                            docline.FeeTypeEnumDescription = dtoline.FeeTypeEnumDescription;//费用类型描述
                            docline.Banks = dtoline.Banks;//开户行
                            docline.BankAccount = dtoline.BankAccount;//银行账号
                            docline.CustomerCode = dtoline.CustomerCode;//客户编码
                            docline.CustomerDescription = dtoline.CustomerDescription;//客户名称
                            docline.SupplierCode = dtoline.SupplierCode;//供应商编码
                            docline.SupplierDescription = dtoline.SupplierDescription;//供应商名称
                            docline.DepartmentCode = dtoline.DepartmentCode;//部门编码
                            docline.DepartmentName = dtoline.DepartmentName;//部门名称
                            docline.EmployeeCode = dtoline.EmployeeCode;//员工编码
                            docline.EmployeeName = dtoline.EmployeeName;//员工名称
                            docline.MaterialGroupCode = dtoline.MaterialGroupCode;//物料组编码
                            docline.MaterialGroupDescription = dtoline.MaterialGroupDescription;//物料组描述
                            docline.AssetsCode = dtoline.AssetsCode;//资产编号
                            docline.AssetsDescription = dtoline.AssetsDescription;//资产描述
                            docline.RelCompCode = dtoline.RelCompCode;//关系企业代码
                            docline.RelCompName = dtoline.RelCompName;//关系企业名称
                        }
                        session.Commit();
                        commonResultDTO.IsSuccess = true;
                        commonResultDTO.Message = doc.CompanyName + "," + dto.SAPVoucherDisplayCode + "对应中间表ID：" + doc.ID;
                        commonResultDTO.CompanyCode = dto.CompanyCode;
                        commonResultDTO.SAPVoucherDisplayCode = dto.SAPVoucherDisplayCode;
                        commonResultDTO.PostDate = dto.PostDate;
                        commonResultDTO.MiddleId = doc.ID;
                        returnResult.Add(commonResultDTO);
                    }
                }
                catch (Exception ex)
                {
                    commonResultDTO.Message = dto.SAPVoucherDisplayCode + ex.Message;
                    commonResultDTO.CompanyCode = dto.CompanyCode;
                    commonResultDTO.SAPVoucherDisplayCode = dto.SAPVoucherDisplayCode;
                    commonResultDTO.PostDate = dto.PostDate;
                    commonResultDTO.MiddleId = 0;
                    returnResult.Add(commonResultDTO);
                }
            }
            return returnResult;
        }
    }

    #endregion


}