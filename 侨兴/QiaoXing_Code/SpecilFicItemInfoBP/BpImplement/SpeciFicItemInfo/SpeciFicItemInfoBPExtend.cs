namespace UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo
{
    using System;
    using System.Collections.Generic;
    using UFIDA.U9.Base.DTOs;
    using UFIDA.U9.ISV.PRSV;
    using UFIDA.U9.ISV.PRSV.Proxy;
    using UFIDA.U9.PR.PurchaseRequest;
    using UFIDA.U9.PR.PurchaseRequest.Proxy;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.PL.Engine;

    /// <summary>
    /// SpeciFicItemInfoBP partial 
    /// </summary>	
    public partial class SpeciFicItemInfoBP
    {
        internal BaseStrategy Select()
        {
            return new SpeciFicItemInfoBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class SpeciFicItemInfoBPImpementStrategy : BaseStrategy
    {
        public SpeciFicItemInfoBPImpementStrategy() { }

        public override object Do(object obj)
        {
            SpeciFicItemInfoBP bpObj = (SpeciFicItemInfoBP)obj;
            var str = "";
            CreatePRSVForOtherSysProxy CreatePrProxy = new CreatePRSVForOtherSysProxy();
            List<OtherSystemPRDTOData> PRDtoList = new List<OtherSystemPRDTOData>();
            UFIDA.U9.CBO.HR.Operator.Operators Employee = UFIDA.U9.CBO.HR.Operator.Operators.Finder.FindByID(bpObj.Operators);
            try
            {
                OtherSystemPRDTOData PRDto = new OtherSystemPRDTOData();
                PRDto.PRDocType = new IDCodeNameDTOData();
                PRDto.PRDocType.Code = "PR03";//PR03
                PRDto.BusinessDate = System.DateTime.Now;
                //PRDto.Memo = ".net测试";
                PRDto.Org = new IDCodeNameDTOData();
                PRDto.Org.Code = "1";
                //PRDto.Org.Code = "201";  
                List<OtherSystemPRLineDTOData> PRLineList = new List<OtherSystemPRLineDTOData>();
                List<SpeciFicItemInfoDto> SpecificItemInfoDtoList = bpObj.SpeciFicItemInfoDto;
                var DocLineNo = 0;
                if (SpecificItemInfoDtoList.Count > 0)
                {
                    foreach (var specificItemInfo in SpecificItemInfoDtoList)
                    {
                        OtherSystemPRLineDTOData pRLine = new OtherSystemPRLineDTOData();
                        //pRLine.RegOrg = new IDCodeNameDTOData
                        //{
                        //    Code = "201",
                        //}; 
                        DocLineNo += 10;
                        pRLine.PurDepartment = new IDCodeNameDTOData
                        {
                            Code=Employee.Dept.Code,
                        };
                        pRLine.ReqEmployee = new IDCodeNameDTOData();
                        pRLine.ReqEmployee.Code = Employee.Code;
                        pRLine.DocLineNo = DocLineNo;
                        pRLine.ItemInfo = new CBO.SCM.Item.ItemInfoData
                        {
                            ItemCode = specificItemInfo.ItemMaster_Code,
                        };
                        pRLine.Warehouse = new IDCodeNameDTOData
                        {
                            Code = specificItemInfo.Wh_Code,
                        };
                        pRLine.RequiredDeliveryDate = specificItemInfo.ReqDate;
                        pRLine.DemandCode = 3362;
                        //pRLine.DemandCode = 2001;
                        pRLine.ReqQtyTU = specificItemInfo.ReqPRQty;
                        pRLine.SysState = ObjectState.Inserted;
                        PRLineList.Add(pRLine);
                    }
                    PRDto.PRLineList = PRLineList;
                    PRDto.SysState = ObjectState.Inserted;
                    PRDtoList.Add(PRDto);
                    CreatePrProxy.PRDTOList = PRDtoList;
                    var data = CreatePrProxy.Do();
                    str = "已生成相应请购单，单号为" + data[0].DocNo;
                    if (!string.IsNullOrEmpty(data[0].DocNo))
                    {
                        UFIDA.U9.PR.PurchaseRequest.PR Pr = UFIDA.U9.PR.PurchaseRequest.PR.Finder.Find("DocNo='" + data[0].DocNo + "'");
                        
                        using (ISession session = Session.Open())
                        {
                            //Pr.ReqDepartment = new CBO.HR.Department.Department();
                            if (Employee.Dept != null)
                            {
                                Pr.ReqDepartment = CBO.HR.Department.Department.Finder.FindByID(Employee.Dept.ID);
                            }
                            //Pr.ReqDepartment.Code = Employee.Dept.Code;
                            //Pr.ReqEmployee = new CBO.HR.Operator.Operators();
                            Pr.ReqEmployee = Employee;
                            session.Commit();
                        }
                        PRBatchActionBPProxy submitProxy = new PRBatchActionBPProxy();                        
                        //ApprovePRISVProxy submitProxy = new ApprovePRISVProxy();
                        UFIDA.U9.PR.PurchaseRequest.PR PRentity = UFIDA.U9.PR.PurchaseRequest.PR.Finder.Find("DocNo='" + data[0].DocNo + "'");
                        submitProxy.PRKeys = new List<long>();
                        submitProxy.PRKeys.Add(PRentity.ID);
                        submitProxy.ActionType = 7;
                        submitProxy.Do();
                        //UFIDA.U9.ISV.PRSV.Proxy.ApprovePRISVProxy appProxy = new ApprovePRISVProxy();
                        PRBatchActionBPProxy appProxy = new PRBatchActionBPProxy();
                        appProxy.PRKeys = new List<long>();
                        appProxy.PRKeys.Add(PRentity.ID);
                        appProxy.ActionType = 8;
                        appProxy.Do();
                    }
                }
                else
                {
                    str = "无数据变化";
                }
            }
            catch (Exception e)
            {
                str = e.Message;
            }
            return str;
        }
    }

    #endregion


}