using System;
using System.Text;
using System.Collections;
using System.Xml;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Threading;

using Telerik.WebControls;
using UFSoft.UBF.UI.WebControls;
using UFSoft.UBF.UI.Controls;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.Util.Globalization;

using UFSoft.UBF.UI.IView;
using UFSoft.UBF.UI.Engine;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.WebControls.ClientCallBack;
using UFIDA.U9.UI.PDHelper;
using UFSoft.UBF.Util.DataAccess;
using UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.Proxy;
using System.Collections.Generic;
using UFIDA.U9.Cust.XMJL.XMJLBomChangeBP;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.XMJL.XMJLSplitCarNoModel
{
    public partial class XMJLSplitCarNoUIFormWebPart
    {
        #region Custome eventBind
        #region 自定义数据初始化加载和数据收集
        private void OnLoadData_Extend(object sender)
        {
            OnLoadData_DefaultImpl(sender);
        }
        private void OnDataCollect_Extend(object sender)
        {
            OnDataCollect_DefaultImpl(sender);
        }
        #endregion

        #region 自己扩展 Extended Event handler
        public void AfterOnLoad()
        {
            if (this.Model.ProjectView.RecordCount != 0) return;
            #region 获取未使用车号
            DataSet data = null;
            //运行RunSQl传递oql查询条件.给缓存数据集中添加相应的查询字段
            DataAccessor.RunSQL(DataAccessor.GetConn(),
            "select Code,ID,DescFlexField_PrivateDescSeg1  from CBO_Project where  DescFlexField_PrivateDescSeg1 !='true'  order by Code", null, out data);
            if (data != null && data.Tables.Count > 0)
            {
                //将缓存的数据集用表承载
                System.Data.DataTable dataTable = data.Tables[0];
                //取出表中的行信息                         
                foreach (DataRow item in dataTable.Rows)
                {
                    //item[0]就是你的第一个属性值。
                    var ss = item[0].ToString();
                    ProjectViewRecord record = this.Model.ProjectView.AddNewUIRecord();
                    record.ManufactureNo = item[0].ToString(); //车号
                    record.ManufactureID = long.Parse(item[1].ToString());//车号
                }
            }
            this.DataGrid5.EditStatus = UFSoft.UBF.UI.ControlModel.EditStatus.Browse;
            #endregion
            #region 获取生产线料品日计划
            //            if (this.NameValues != null && this.NameValues["DocNo"] != null)
            //            {
            //                this.Model.SplitPlanView.Clear();
            //                string str = this.NameValues["DocNo"].ToString();
            //                string[] strarr = str.Split(',');
            //                foreach (var docNo in strarr)
            //                {
            //                    DataParamList lst = new DataParamList();
            //                    //为数据集添加字段
            //                    lst.Add(DataParamFactory.CreateInput("@DocNo", docNo));
            //                    //定义缓存数据
            //                    System.Data.DataSet ds = new System.Data.DataSet();
            //                    //运行RunSQl传递oql查询条件.给缓存数据集中添加相应的查询字段
            //                    DataAccessor.RunSQL(DataAccessor.GetConn(),
            //                   @"select D.Name,C.Name,ProductDate,ProductQty,B.Name,A.ID,A.DemandCode,B.ID  from MO_PLS A  left join CBO_ItemMaster B
            //                    on A.ItemMaster=B.ID left join CBO_ProductionLine_Trl C on A.ProductLine=C.ID left join  
            //                    (select t.EValue,tt.Name from UBF_Sys_ExtEnumValue t left join UBF_Sys_ExtEnumValue_Trl tt 
            //                        on t.ID=tt.ID left join UBF_Sys_ExtEnumType ttt on t.ExtEnumType=ttt.ID
            //                        where ttt.Code='UFIDA.U9.CBO.Enums.DemandCodeEnum') D on 
            //                        A.DemandCode=D.EValue where A.DocNo=@DocNo", lst, out ds);
            //                    if (ds != null && ds.Tables.Count > 0)
            //                    {
            //                        //将缓存的数据集用表承载
            //                        System.Data.DataTable dataTable = ds.Tables[0];
            //                        //取出表中的行信息                         
            //                        foreach (DataRow item in dataTable.Rows)
            //                        {
            //                            var reqCategory = item[0].ToString();
            //                            string companyCont = string.Empty;
            //                            if (reqCategory.Split('-').Length > 1)
            //                            {
            //                                companyCont = reqCategory.Split('-')[1];
            //                            }
            //                            DataParamList lst1 = new DataParamList();
            //                            lst1.Add(DataParamFactory.CreateInput("@DocNo", companyCont));
            //                            lst1.Add(DataParamFactory.CreateInput("@Name", item[4].ToString()));
            //                            DataSet ds1 = new DataSet();
            //                            DataAccessor.RunSQL(DataAccessor.GetConn(),
            //                            @"select D.Name,B.OrderByQtyPU,F.RequireDate from SM_SO A left join SM_SOLine B on a.ID=B.SO
            //                            left join CBO_ItemMaster C on B.ItemInfo_ItemID=C.ID left join CBO_Customer_Trl D 
            //                            on A.Payer_Customer=D.ID left join SM_SOShipline F on B.ID=F.SOLine
            //                            where A.DocNo=@DocNo and C.Name=@Name", lst1, out ds1);
            //                            DataTable dataTable1 = ds1.Tables[0];
            //                            DataRow item1 = dataTable1.Rows[0];

            //                            DataSet ds2 = new DataSet();
            //                            DataAccessor.RunSQL(DataAccessor.GetConn(),
            //                            @"select max(DescFlexField_PrivateDescSeg1) from MO_PLS where  DemandCode="
            //                            + item[6].ToString() + " and ItemMaster=" + item[7].ToString(), null, out ds2);
            //                            DataTable dataTable2 = ds2.Tables[0];
            //                            int sequence = 0;
            //                            if (dataTable2.Rows.Count > 0)
            //                            {
            //                                var temp = dataTable2.Rows[0][0].ToString();
            //                                if (!string.IsNullOrEmpty(temp))
            //                                {
            //                                    int.TryParse(temp, out sequence);
            //                                }
            //                            }
            //                            var carNum = decimal.Parse(item[3].ToString());
            //                            for (var sb = 0; sb < carNum; sb++)
            //                            {
            //                                var splitPlanViewRecord = this.Model.SplitPlanView.AddNewUIRecord();
            //                                splitPlanViewRecord.Scheduling = this.Model.SplitPlanView.RecordCount;
            //                                splitPlanViewRecord.ReqCategory = reqCategory;
            //                                splitPlanViewRecord.ProdLine = item[1].ToString();
            //                                splitPlanViewRecord.ProdDate = DateTime.Parse(item[2].ToString());
            //                                splitPlanViewRecord.ProductQty = decimal.Parse(item[6].ToString());
            //                                if (carNum == 1)//如果只有一条 说明椒改车号，车序不变
            //                                {
            //                                     splitPlanViewRecord.Sequence = sequence;
            //                                }
            //                                else
            //                                {
            //                                    splitPlanViewRecord.Sequence = ++sequence;
            //                                }
            //                                splitPlanViewRecord.CarType = item[4].ToString();
            //                                splitPlanViewRecord.CompanyContract = companyCont;
            //                                splitPlanViewRecord.CustName = item1[0].ToString();
            //                                splitPlanViewRecord.ContractNum = decimal.Parse(item1[1].ToString());
            //                                splitPlanViewRecord.ContractDelivery = DateTime.Parse(item1[2].ToString());
            //                                splitPlanViewRecord.PlsID = long.Parse(item[5].ToString());
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            #endregion

            #region 获取生产订单逻辑
            if (this.NameValues != null && this.NameValues["DocNo"] != null)
            {
                this.Model.SplitPlanView.Clear();
                string str = this.NameValues["DocNo"].ToString();
                string[] strarr = str.Split(',');
                foreach (var docNo in strarr)
                {
                    DataParamList lst = new DataParamList();
                    //为数据集添加字段
                    lst.Add(DataParamFactory.CreateInput("@DocNo", docNo));
                    //定义缓存数据
                    System.Data.DataSet ds = new System.Data.DataSet();
                    //运行RunSQl传递oql查询条件.给缓存数据集中添加相应的查询字段
                    DataAccessor.RunSQL(DataAccessor.GetConn(),
                   @"select D.Name,A.DescFlexField_PrivateDescSeg11,A.StartDate,A.ProductQty,B.Name,A.ID,A.DemandCode,B.ID,A.SeibanCode  from MO_MO A  
                    left join CBO_ItemMaster B on A.ItemMaster=B.ID left join  
                    (select t.EValue,tt.Name from UBF_Sys_ExtEnumValue t left join UBF_Sys_ExtEnumValue_Trl tt 
                        on t.ID=tt.ID left join UBF_Sys_ExtEnumType ttt on t.ExtEnumType=ttt.ID
                        where ttt.Code='UFIDA.U9.CBO.Enums.DemandCodeEnum') D on 
                        A.DemandCode=D.EValue where A.DocNo=@DocNo", lst, out ds);
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        //将缓存的数据集用表承载
                        System.Data.DataTable dataTable = ds.Tables[0];
                        //取出表中的行信息                         
                        foreach (DataRow item in dataTable.Rows)
                        {
                            var reqCategory = item[0].ToString();
                            string companyCont = string.Empty;
                            if (reqCategory.Split('-').Length > 1)
                            {
                                companyCont = reqCategory.Split('-')[1];
                            }
                            #region 根据需求分类的后半段+料品名称 去取。
                            DataParamList lst1 = new DataParamList();
                            lst1.Add(DataParamFactory.CreateInput("@DocNo", companyCont));
                            lst1.Add(DataParamFactory.CreateInput("@Name", item[4].ToString()));
                            DataSet ds1 = new DataSet();
                            DataAccessor.RunSQL(DataAccessor.GetConn(),
                            @"select D.Name,B.OrderByQtyPU,F.RequireDate from SM_SO A left join SM_SOLine B on a.ID=B.SO
                            left join CBO_ItemMaster C on B.ItemInfo_ItemID=C.ID left join CBO_Customer_Trl D 
                            on A.Payer_Customer=D.ID left join SM_SOShipline F on B.ID=F.SOLine
                            where A.DocNo=@DocNo and C.Name=@Name", lst1, out ds1);
                            DataTable dataTable1 = ds1.Tables[0];
                            string custName = string.Empty; decimal contractNum = 0; DateTime contractDelivery = DateTime.MinValue;
                            if (dataTable1.Rows.Count > 0)
                            {
                                DataRow item1 = dataTable1.Rows[0];
                                custName = item1[0].ToString();
                                contractNum = decimal.Parse(item1[1].ToString());
                                contractDelivery = DateTime.Parse(item1[2].ToString());
                            }

                            #endregion
                            DataSet ds2 = new DataSet();
                            DataAccessor.RunSQL(DataAccessor.GetConn(),
                            @"select max(DescFlexField_PrivateDescSeg4) from MO_MO where  DemandCode="
                            + item[6].ToString() + " and ItemMaster=" + item[7].ToString(), null, out ds2);
                            DataTable dataTable2 = ds2.Tables[0];
                            int sequence = 0;
                            if (dataTable2.Rows.Count > 0)
                            {
                                var temp = dataTable2.Rows[0][0].ToString();
                                if (!string.IsNullOrEmpty(temp))
                                {
                                    int.TryParse(temp, out sequence);
                                }
                            }
                            var carNum = decimal.Parse(item[3].ToString());
                            for (var sb = 0; sb < carNum; sb++)
                            {
                                var splitPlanViewRecord = this.Model.SplitPlanView.AddNewUIRecord();
                                splitPlanViewRecord.Scheduling = this.Model.SplitPlanView.RecordCount;
                                splitPlanViewRecord.ReqCategory = reqCategory;
                                splitPlanViewRecord.ProdLine = item[1].ToString();
                                splitPlanViewRecord.SeibanCode = item[8].ToString();//番号
                                splitPlanViewRecord.ProdDate = DateTime.Parse(item[2].ToString());
                                splitPlanViewRecord.ProductQty = decimal.Parse(item[6].ToString());
                                if (carNum == 1)//如果只有一条 说明椒改车号，车序不变
                                {
                                    splitPlanViewRecord.Sequence = sequence;
                                }
                                else
                                {
                                    splitPlanViewRecord.Sequence = ++sequence;
                                }
                                splitPlanViewRecord.CarType = item[4].ToString();
                                splitPlanViewRecord.CompanyContract = companyCont;
                                splitPlanViewRecord.CustName = custName;
                                splitPlanViewRecord.ContractNum = contractNum;
                                if (contractDelivery != DateTime.MinValue)
                                {
                                    splitPlanViewRecord.ContractDelivery = contractDelivery;
                                }
                                splitPlanViewRecord.PlsID = long.Parse(item[5].ToString());
                                //splitPlanViewRecord.StationName = "";//驻点名称
                                //splitPlanViewRecord.StagnationContract = "";//驻点合同  暂时不处理，据说 从销售订单中取
                            }
                        }
                    }
                }
            }
            #endregion
        }

        public void AfterCreateChildControls()
        {

        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {

        }

        public void AfterUIModelBinding()
        {

        }


        #endregion

        private void BtnClose_Click_Extend(object sender, EventArgs e)
        {
            this.CloseDialog(false);
        }
        private void BtnClear_Click_Extend(object sender, EventArgs e)
        {
            this.Model.SplitPlanView.Clear();
            this.Model.ProjectView.Clear();
            this.Model.SplitView.Clear();
            AfterOnLoad();
        }
        private void BtnSave_Click_Extend(object sender, EventArgs e)
        {
            SplitCarNoToPlsProxy proxy = new SplitCarNoToPlsProxy();
            proxy.SplitCarDTOList = new List<SplitCarDTOData>();
            this.DataGrid6.CollectData();
            foreach (SplitViewRecord item in this.Model.SplitView.Records)
            {
                SplitCarDTOData splitCarDTOData = new SplitCarDTOData
                {
                    ManufactureNo = item.ManufactureNo,
                    Sequence = item.Sequence.Value,
                    PlsID = (item.PlsID ?? item.PlsID.Value).ToString()
                };
                proxy.SplitCarDTOList.Add(splitCarDTOData);
            }
            if (proxy.Do())
            {
                this.CloseDialog(false);
            }
        }
        private void BtnDelete_Click_Extend(object sender, EventArgs e)
        {

            if (this.Model.SplitView.FocusedRecord != null)
            {
                SplitViewRecord splitPlanViewRecord = this.Model.SplitView.FocusedRecord;
                ProjectViewRecord projectViewRecord = this.Model.ProjectView.AddNewUIRecord();
                SplitPlanViewRecord record = this.Model.SplitPlanView.AddNewUIRecord();
                projectViewRecord.ManufactureNo = splitPlanViewRecord.ManufactureNo;
                record.ReqCategory = splitPlanViewRecord.ReqCategory;
                record.ProdLine = splitPlanViewRecord.ProdLine;
                record.ProdDate = splitPlanViewRecord.ProdDate;
                record.ProductQty = 1;
                record.CarType = splitPlanViewRecord.CarType;
                record.CompanyContract = splitPlanViewRecord.CompanyContact;
                record.CustName = splitPlanViewRecord.CustName;
                record.ContractNum = splitPlanViewRecord.ContractNum;
                record.ContractDelivery = splitPlanViewRecord.ContractDelivery;
                record.PlsID = splitPlanViewRecord.PlsID;
                record.Scheduling = this.Model.SplitPlanView.RecordCount;
                record.Sequence = splitPlanViewRecord.Sequence;
                this.Model.SplitView.FocusedRecord.Delete();
            }
        }
        private void BtnOk_Click_Extend(object sender, EventArgs e)
        {
            if (this.Model.ProjectView.FocusedRecord != null && this.Model.SplitPlanView.FocusedRecord != null)
            {
                SplitViewRecord record = this.Model.SplitView.AddNewUIRecord();
                SplitPlanViewRecord splitPlanViewRecord = this.Model.SplitPlanView.FocusedRecord;
                record.ManufactureNo = this.Model.ProjectView.FocusedRecord.ManufactureNo;
                record.ReqCategory = splitPlanViewRecord.ReqCategory;
                record.ProdLine = splitPlanViewRecord.ProdLine;
                record.ProdDate = splitPlanViewRecord.ProdDate;
                record.ProductQty = 1;
                record.CarType = splitPlanViewRecord.CarType;
                record.CompanyContact = splitPlanViewRecord.CompanyContract;
                record.CustName = splitPlanViewRecord.CustName;
                record.ContractNum = splitPlanViewRecord.ContractNum;
                record.ContractDelivery = splitPlanViewRecord.ContractDelivery;
                record.PlsID = splitPlanViewRecord.PlsID;
                record.Sequence = (int)splitPlanViewRecord.Sequence;
                this.Model.ProjectView.FocusedRecord.Delete();
                this.Model.SplitPlanView.FocusedRecord.Delete();
            }
        }
        #endregion

    }
}