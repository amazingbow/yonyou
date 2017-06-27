using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CreateSAPVoucherSV.CreateSAPVoucherSV;

namespace CreateSAPVoucherSV
{
    /// <summary>
    /// CreateSAPVoucher 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class CreateSAPVoucher : System.Web.Services.WebService
    {

        [WebMethod]
        public List<CommonResult> Create(List<SAPU9GLVoucher> SAPU9GLVoucherS)
        {
            List<CommonResult> returnResult = new List<CommonResult>();

            CreateSAPVoucherSV.CreateSVStub sv = new CreateSAPVoucherSV.CreateSVStub();
            object context = CreateContextObj();
            MessageBase[] returnMsg;
            UFIDAU9CustHXPPSVCreateSAPVoucherSVSAPU9GLVoucherDTOData[] dtos = CreateSAPVoucherInfoList(SAPU9GLVoucherS);
            UFIDAU9CustHXPPSVCreateSAPVoucherSVCommonResultDTOData[] returnValLst;
            returnValLst = sv.Do(context, dtos, out returnMsg);
            foreach (var returnVal in returnValLst)
            {
                CommonResult commonResult = new CommonResult();
                commonResult.IsSuccess = returnVal.m_isSuccess;
                commonResult.Message = returnVal.m_message;
                commonResult.CompanyCode = returnVal.m_companyCode;
                commonResult.SAPVoucherDisplayCode = returnVal.m_sAPVoucherDisplayCode;
                commonResult.PostDate = "";
                if (returnVal.m_postDate != null)
                {
                    commonResult.PostDate = returnVal.m_postDate.ToString("yyyy-MM-dd");
                }
               
                commonResult.MiddleId = returnVal.m_middleId;
                returnResult.Add(commonResult);
            }
            return returnResult;
        }

        /// <summary>
        /// 创建传入参数集合
        /// </summary>
        /// <param name="Length"></param>
        /// <returns></returns>
        private static UFIDAU9CustHXPPSVCreateSAPVoucherSVSAPU9GLVoucherDTOData[] CreateSAPVoucherInfoList(List<SAPU9GLVoucher> SAPU9GLVoucherS)
        {
            UFIDAU9CustHXPPSVCreateSAPVoucherSVSAPU9GLVoucherDTOData[] vouchers = new UFIDAU9CustHXPPSVCreateSAPVoucherSVSAPU9GLVoucherDTOData[SAPU9GLVoucherS.Count];
            for (int i = 0; i < SAPU9GLVoucherS.Count; i++)
            {
                vouchers[i] = new UFIDAU9CustHXPPSVCreateSAPVoucherSVSAPU9GLVoucherDTOData();
                vouchers[i].m_companyCode = SAPU9GLVoucherS[i].CompanyCode;//公司代码
                vouchers[i].m_companyName = SAPU9GLVoucherS[i].CompanyName;//公司名称
                vouchers[i].m_sAPVoucherDisplayCode = SAPU9GLVoucherS[i].SAPVoucherDisplayCode;//SAP凭证号
                vouchers[i].m_voucherCategoryCode = SAPU9GLVoucherS[i].VoucherCategoryCode;//凭证类型编码
                vouchers[i].m_voucherCategoryDescription = SAPU9GLVoucherS[i].VoucherCategoryDescription;//凭证类型描述
                vouchers[i].m_postDate = SAPU9GLVoucherS[i].PostDate;//记账日期
                vouchers[i].m_postDateSpecified = true;
                vouchers[i].m_postedPeriod = SAPU9GLVoucherS[i].PostedPeriod;//记账期间
                vouchers[i].m_postedPeriodSpecified = true;
                vouchers[i].m_currencyCode = SAPU9GLVoucherS[i].CurrencyCode;//币种编码
                vouchers[i].m_currencyDescription = SAPU9GLVoucherS[i].CurrencyDescription;//货币描述
                vouchers[i].m_sapCreater = SAPU9GLVoucherS[i].SapCreater;//SAP凭证制单人
                vouchers[i].m_sapAuditor = SAPU9GLVoucherS[i].SapAuditor;//SAP凭证审核人
                vouchers[i].m_sapPoster = SAPU9GLVoucherS[i].SapPoster;//SAP凭证记账人
                vouchers[i].m_sapCashier = SAPU9GLVoucherS[i].SapCashier;//SAP凭证出纳人
                UFIDAU9CustHXPPSVCreateSAPVoucherSVSAPU9GLVoucherLineDTOData[] voucherlines = new UFIDAU9CustHXPPSVCreateSAPVoucherSVSAPU9GLVoucherLineDTOData[SAPU9GLVoucherS[i].SAPU9GLVoucherLineS.Count];
                for (int j = 0; j < SAPU9GLVoucherS[i].SAPU9GLVoucherLineS.Count; j++)
                {
                    voucherlines[j] = new UFIDAU9CustHXPPSVCreateSAPVoucherSVSAPU9GLVoucherLineDTOData();
                    voucherlines[j].m_serialNo = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].SerialNo;//行号
                    voucherlines[j].m_serialNoSpecified = true;
                    voucherlines[j].m_accountCode = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].AccountCode;//科目编码
                    voucherlines[j].m_accountDescription = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].AccountDescription;//科目描述
                    voucherlines[j].m_abstracts = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].Abstracts;//摘要
                    voucherlines[j].m_accountedDr = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].AccountedDr;//借方金额（本币）
                    voucherlines[j].m_accountedDrSpecified = true;
                    voucherlines[j].m_accountedCr = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].AccountedCr;//贷方金额（本币）
                    voucherlines[j].m_accountedCrSpecified = true;
                    voucherlines[j].m_enteredDr = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].EnteredDr;//借方金额（原币）
                    voucherlines[j].m_enteredDrSpecified = true;
                    voucherlines[j].m_enteredCr = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].EnteredCr;//贷方金额（原币）
                    voucherlines[j].m_enteredCrSpecified = true;
                    voucherlines[j].m_cashFlowCode = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].CashFlowCode;//现金流量项目编码
                    voucherlines[j].m_cashFlowDescription = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].CashFlowDescription;//现金流量项目描述
                    voucherlines[j].m_feeTypeEnumCode = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].FeeTypeEnumCode;//费用类型编码
                    voucherlines[j].m_feeTypeEnumDescription = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].FeeTypeEnumDescription;//费用类型描述
                    voucherlines[j].m_banks = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].Banks;//开户行
                    voucherlines[j].m_bankAccount = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].BankAccount;//银行账号
                    voucherlines[j].m_customerCode = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].CustomerCode;//客户编码
                    voucherlines[j].m_customerDescription = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].CustomerDescription;//客户名称
                    voucherlines[j].m_supplierCode = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].SupplierCode;//供应商编码
                    voucherlines[j].m_supplierDescription = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].SupplierDescription;//供应商名称
                    voucherlines[j].m_departmentCode = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].DepartmentCode;//部门编码
                    voucherlines[j].m_departmentName = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].DepartmentName;//部门名称
                    voucherlines[j].m_employeeCode = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].EmployeeCode;//员工编码
                    voucherlines[j].m_employeeName = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].EmployeeName;//员工名称
                    voucherlines[j].m_materialGroupCode = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].MaterialGroupCode;//物料组编码
                    voucherlines[j].m_materialGroupDescription = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].MaterialGroupDescription;//物料组描述
                    voucherlines[j].m_assetsCode = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].AssetsCode;//资产编号
                    voucherlines[j].m_assetsDescription = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].AssetsDescription;//资产描述
                    voucherlines[j].m_relCompCode = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].RelCompCode;//关系企业代码
                    voucherlines[j].m_relCompName = SAPU9GLVoucherS[i].SAPU9GLVoucherLineS[j].RelCompName;//关系企业名称
                }
                vouchers[i].m_sAPU9GLVoucherLineDTOS = voucherlines;
            }

            return vouchers;
        }

        /// <summary>
        /// 创建上下文
        /// </summary>
        /// <returns></returns>
        private static ThreadContext CreateContextObj()
        {
            // 实例化应用上下文对象
            ThreadContext thContext = new ThreadContext();

            List<ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType> cclist = new List<ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType>();

            String strOrgID = System.Configuration.ConfigurationManager.AppSettings["OrgID"];
            ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType cc = new ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType();
            cc.Key = "OrgID";
            cc.Value = strOrgID;
            cclist.Add(cc);
            String strUserID = System.Configuration.ConfigurationManager.AppSettings["UserID"];
            ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType cc1 = new ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType();
            cc1.Key = "UserID";
            cc1.Value = strUserID;
            cclist.Add(cc1);
            ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType cc2 = new ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType();
            cc2.Key = "CultureName";
            cc2.Value = "zh-CN";
            cclist.Add(cc2);
            String strEnterpriseID = System.Configuration.ConfigurationManager.AppSettings["EnterpriseID"];
            ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType cc3 = new ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType();
            cc3.Key = "EnterpriseID";
            cc3.Value = strEnterpriseID;
            cclist.Add(cc3);
            ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType cc4 = new ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType();
            cc4.Key = "DefaultCultureName";
            cc4.Value = "zh_CN";
            cclist.Add(cc4);
            ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType cc5 = new ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType();
            cc5.Key = "Support_CultureNameList";
            cc5.Value = "zh_CN";
            cclist.Add(cc5);

            thContext.nameValueHas = cclist.ToArray();
            return thContext;
        }
    }

    //SAP与U9凭证对接中间表
    public class SAPU9GLVoucher
    {
        public SAPU9GLVoucher()
        {

        }
        public System.String CompanyCode;//公司代码
        public System.String CompanyName;//公司名称
        public System.String SAPVoucherDisplayCode;//SAP凭证号
        public System.String VoucherCategoryCode;//凭证类型编码
        public System.String VoucherCategoryDescription;//凭证类型描述
        public System.DateTime PostDate;//记账日期
        public System.Int32 PostedPeriod;//记账期间
        public System.String CurrencyCode;//币种编码
        public System.String CurrencyDescription;//货币描述
        public System.String SapCreater;//SAP凭证制单人
        public System.String SapAuditor;//SAP凭证审核人
        public System.String SapPoster;//SAP凭证记账人
        public System.String SapCashier;//SAP凭证出纳人
        public List<SAPU9GLVoucherLine> SAPU9GLVoucherLineS;//SAP与U9凭证对接中间表行列表
    }

    //SAP与U9凭证对接中间表行
    public class SAPU9GLVoucherLine
    {
        public SAPU9GLVoucherLine()
        {

        }
        public System.Int32 SerialNo;//行号
        public System.String AccountCode;//科目编码
        public System.String AccountDescription;//科目描述
        public System.String Abstracts;//摘要
        public System.Decimal AccountedDr;//借方金额（本币）
        public System.Decimal AccountedCr;//贷方金额（本币）
        public System.Decimal EnteredDr;//借方金额（原币）
        public System.Decimal EnteredCr;//贷方金额（原币）
        public System.String CashFlowCode;//现金流量项目编码
        public System.String CashFlowDescription;//现金流量项目描述
        public System.String FeeTypeEnumCode;//费用类型编码
        public System.String FeeTypeEnumDescription;//费用类型描述
        public System.String Banks;//开户行
        public System.String BankAccount;//银行账号
        public System.String CustomerCode;//客户编码
        public System.String CustomerDescription;//客户名称
        public System.String SupplierCode;//供应商编码
        public System.String SupplierDescription;//供应商名称
        public System.String DepartmentCode;//部门编码
        public System.String DepartmentName;//部门名称
        public System.String EmployeeCode;//员工编码
        public System.String EmployeeName;//员工名称
        public System.String MaterialGroupCode;//物料组编码
        public System.String MaterialGroupDescription;//物料组描述
        public System.String AssetsCode;//资产编号
        public System.String AssetsDescription;//资产描述
        public System.String RelCompCode;//关系企业代码
        public System.String RelCompName;//关系企业名称
    }

    //通用返回结果对象
    public class CommonResult
    {
        public CommonResult()
        {

        }
        public System.Boolean IsSuccess;//是否成功
        public System.String Message;//消息
        public System.String CompanyCode
        {
            get;
            set;
        }
        public System.String SAPVoucherDisplayCode
        {
            get;
            set;
        }
        public System.String PostDate
        {
            get;
            set;
        }
        public System.Int64 MiddleId
        {
            get;
            set;
        }
    }
}
