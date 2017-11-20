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
using UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP.Proxy;
using UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP;
using System.Collections.Generic;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.Util.DataAccess;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.Association.Adapter;
using UFIDA.U9.Cust.SeeBestAdvertisementBP.ARBillRelationBP.Proxy;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.AdvApproveUI.AdvApproveUIModel
{
    public partial class AdvApproveUIFormWebPart
    {
        #region Custome eventBind


        //BtnSave_Click...
        private void BtnSave_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            #region not used
            //foreach (AdvApproveLinesRecord item in this.Model.AdvApproveLines.Records)
            //{
            //    bool hasFlag = false;
            //    if (this.Model.AdvApproveBE_AdvApproveLine.RecordCount > 0)
            //    {
            //        foreach (AdvApproveBE_AdvApproveLineRecord about in this.Model.AdvApproveBE_AdvApproveLine.Records)
            //        {
            //            if (about.OtherInfo == item.ApplyID)
            //            {
            //                about.ApplyQty = item.ApplyQty;
            //                about.Price = item.Price;
            //                about.TotalMoney = item.TotalMoney;
            //                about.ReceiptNum = item.ReceiptNum;
            //                about.Momo = item.Memo;
            //                about.ActualApproveQty = item.ActualApproveQty;
            //                about.ActualPrice = item.ActualPrice;
            //                about.Discount = item.Discount;
            //                about.ApproveMoney = item.ApproveMoney;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        var record = this.Model.AdvApproveBE_AdvApproveLine.AddNewUIRecord();
            //        record.Location = item.Location;
            //        record.AdvAppCustName = item.AdvAppCustName;
            //        record.Country = item.Country;
            //        record.CustCounterName = item.CustCounterName;
            //        record.RelPeople = item.RelPeople;
            //        record.RelPhone = item.RelPeople;
            //        record.CustAddress = item.CustAddress;
            //        record.Width = item.Width;
            //        record.Thick = item.Thick;
            //        record.Height = item.Height;
            //        record.ApplyAdvCode = item.ApplyAdvCode;
            //        record.AdvCarrier = item.AdvCarrier;
            //        record.ApplyQty = item.ApplyQty;
            //        record.Price = item.Price;
            //        record.TotalMoney = item.TotalMoney;
            //        record.ReceiptNum = item.ReceiptNum;
            //        record.Momo = item.Memo;
            //        record.ActualApproveQty = item.ActualApproveQty;
            //        record.ActualPrice = item.ActualPrice;
            //        record.Discount = item.Discount;
            //        record.ApproveMoney = item.ApproveMoney;
            //        record.OtherInfo = item.ApplyID;
            //    }
            //}
            #endregion

            if (this.Model.AdvApproveBE.FocusedRecord != null)
            {
                if (this.Model.AdvApproveBE.FocusedRecord.DocStatus.Value == 2)
                {
                    this.Model.ClearErrorMessage();
                    throw new Exception("这张广告核销单已经被审核，不能再修改保存！");
                }
            }

            if (this.Model.AdvApproveBE.FocusedRecord != null)
            {
                if (this.Model.AdvApproveBE.FocusedRecord.ID > 0L)
                {
                    if (this.Model.AdvApproveBE_AdvApproveLine.FocusedRecord != null)
                    {
                        if (this.Model.AdvApproveBE_AdvApproveLine.FocusedRecord.DataRecordState == DataRowState.Added)
                        {
                            DataParamList lst1 = new DataParamList();
                            lst1.Add(DataParamFactory.CreateInput("@AdvApproveBEID", this.Model.AdvApproveBE.FocusedRecord.ID, System.Data.DbType.Int64));

                            DataAccessor.RunSQL(DataAccessor.GetConn(), "delete Cust_SeeBest_AdvApproveLine where AdvApproveBE=@AdvApproveBEID", lst1);
                        }
                    }

                }
            }

            BtnSave_Click_DefaultImpl(sender, e);
        }

        //BtnCancel_Click...
        private void BtnCancel_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnCancel_Click_DefaultImpl(sender, e);
        }

        //BtnAdd_Click...
        private void BtnAdd_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnAdd_Click_DefaultImpl(sender, e);
        }

        //BtnDelete_Click...
        private void BtnDelete_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            if (this.Model.AdvApproveBE.FocusedRecord != null)
            {
                if (this.Model.AdvApproveBE.FocusedRecord.DocStatus.Value == 2)
                {
                    this.Model.ClearErrorMessage();
                    throw new Exception("这张广告核销单已经被审核，不能删除！");
                }
            }

            BtnDelete_Click_DefaultImpl(sender, e);
        }

        //BtnCopy_Click...
        private void BtnCopy_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnCopy_Click_DefaultImpl(sender, e);
        }

        //BtnSubmit_Click...
        private void BtnSubmit_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnSubmit_Click_DefaultImpl(sender, e);
        }

        //BtnApprove_Click...
        private void BtnApprove_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (this.Model.AdvApproveBE.FocusedRecord.AdvApproveDocType_ApproveType.Value == Convert.ToInt32(UFIDA.U9.Base.Doc.ApproveTypeEnumData.WorkFlow))
            {
                UFIDA.U9.UI.PDHelper.PDPopWebPart.ApproveFlow_ApproveBatchUIWebPart(this);//工作流审批
            }


            BtnApprove_Click_DefaultImpl(sender, e);
        }

        //BtnUndoApprove_Click...
        private void BtnUndoApprove_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnUndoApprove_Click_DefaultImpl(sender, e);
        }

        //BtnFind_Click...
        private void BtnFind_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnFind_Click_DefaultImpl(sender, e);
        }

        //BtnList_Click...
        private void BtnList_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnList_Click_DefaultImpl(sender, e);
        }

        //BtnFirstPage_Click...
        private void BtnFirstPage_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnFirstPage_Click_DefaultImpl(sender, e);
        }

        //BtnPrevPage_Click...
        private void BtnPrevPage_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnPrevPage_Click_DefaultImpl(sender, e);
        }

        //BtnNextPage_Click...
        private void BtnNextPage_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnNextPage_Click_DefaultImpl(sender, e);
        }

        //BtnLastPage_Click...
        private void BtnLastPage_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnLastPage_Click_DefaultImpl(sender, e);
        }

        //BtnAttachment_Click...
        private void BtnAttachment_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnAttachment_Click_DefaultImpl(sender, e);
        }

        //BtnFlow_Click...
        private void BtnFlow_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnFlow_Click_DefaultImpl(sender, e);
        }

        //BtnOutput_Click...
        private void BtnOutput_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnOutput_Click_DefaultImpl(sender, e);
        }

        //BtnPrint_Click...
        private void BtnPrint_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnPrint_Click_DefaultImpl(sender, e);
        }

        //BtnGetApplyInfo_Click...
        private void BtnGetApplyInfo_Click_Extend(object sender, EventArgs e)
        {
            BtnGetApplyInfo_Click_DefaultImpl(sender, e);
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.Model.ClearErrorMessage();
            if (this.Model.AdvApproveBE_AdvApproveLine.RecordCount > 0)
            {
                this.Model.AdvApproveBE_AdvApproveLine.Records.Clear();
            }
            if (this.Model.AdvApproveBE.FocusedRecord != null)
            {
                if (this.Model.AdvApproveBE.FocusedRecord.AdvApplyCust != null
                    && this.Model.AdvApproveBE.FocusedRecord.StartDate != null
                    && this.Model.AdvApproveBE.FocusedRecord.EndDate != null)
                {
                    LoadApplyByBscProxy proxy = new LoadApplyByBscProxy();
                    proxy.CustBscID = this.Model.AdvApproveBE.FocusedRecord.AdvApplyCust.Value;
                    proxy.StartDate = this.Model.AdvApproveBE.FocusedRecord.StartDate.Value;
                    proxy.EndDate = this.Model.AdvApproveBE.FocusedRecord.EndDate.Value;
                    List<ApplyInfoDtoData> result = proxy.Do();
                    foreach (var item in result)
                    {
                        AdvApproveBE_AdvApproveLineRecord record = this.Model.AdvApproveBE_AdvApproveLine.AddNewUIRecord();
                        record.Location = item.Location;
                        //record.Location = item.Location;
                        record.AdvAppCustName = item.AdvAppCustName;
                        record.Country = item.Country;
                        record.CustCounterName = item.CustCounterName;
                        record.RelPeople = item.RelPeople;
                        record.RelPhone = item.RelPhone;
                        record.CustAddress = item.CustAddress;
                        record.Width = item.Width;
                        record.Thick = item.Thick;
                        record.Height = item.Height;
                        record.Area = item.Area;
                        record.ApplyQty = item.ApplyQty;
                        record.ActualApproveQty = item.ApplyQty;
                        record.ApplyAdvCode = item.ApplyAdvCode;
                        record.AdvCarrier = item.AdvCarrier;
                        record.AdvCarrierCode = item.AdvCarrierCode;
                        record.AdvItem = item.AdvItem;
                        record.OtherInfo = item.ApplyId;
                        record.Momo = item.Memo;
                        record.ApplyDate = item.ApplyDate;
                        record.ActualPrice = item.ActualPrice;
                        record.Discount = 1;
                        if (record.Momo == "封底")
                        {
                            record.TotalMoney = record.Price * record.Area;
                            record.ApproveMoney = record.Area * record.ActualPrice * record.Discount;
                        }
                        else
                        {
                            record.TotalMoney = record.Price * record.ApplyQty * record.Area;
                            record.ApproveMoney = record.ActualApproveQty * record.Area * record.ActualPrice * record.Discount;
                        }
                        //record.BuildStatus=
                        //record.ActualApproveQty=
                        record.SetParentRecord(this.Model.AdvApproveBE.FocusedRecord);
                    }
                }
                else
                {
                    throw new Exception("请输入办事处，开始日期，结束日期！");
                }

                this.DataGrid0.PageCount=this.Model.AdvApproveBE_AdvApproveLine.RecordCount;
                this.DataGrid0.CollectData();
                this.DataGrid0.BindData();
            }
        }
        //BtnCreateAdvApprove_Click...
        private void BtnCreateAdvApprove_Click_Extend(object sender, EventArgs e)
        {
            BtnCreateAdvApprove_Click_DefaultImpl(sender, e);
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            if (this.Model.AdvApproveBE.FocusedRecord != null)
            {
                if (this.Model.AdvApproveBE.FocusedRecord.StartDate != null
                    && this.Model.AdvApproveBE.FocusedRecord.EndDate != null)
                {
                    BatchCreateAdvApproveProxy proxy = new BatchCreateAdvApproveProxy();
                    proxy.StartDate = this.Model.AdvApproveBE.FocusedRecord.StartDate.Value;
                    proxy.EndDate = this.Model.AdvApproveBE.FocusedRecord.EndDate.Value;
                    int iBatchCreateQty = proxy.Do();

                    if (iBatchCreateQty > 0)
                    {
                        UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('批量生成" + iBatchCreateQty + "条核销单成功！');", true);
                    }
                    else
                    {
                        UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('该日期范围内没有需要创建的核销单！');", true);
                    }
                }
                else
                {
                    throw new Exception("请输入开始日期，结束日期！");
                }
            }

        }

        //BtnCreateARBill_Click...
        private void BtnCreateARBill_Click_Extend(object sender, EventArgs e)
        {
            if (this.Model.AdvApproveBE.FocusedRecord != null)
            {
                if (this.Model.AdvApproveBE.FocusedRecord.DocStatus.Value != 2)
                {
                    this.Model.ClearErrorMessage();
                    throw new Exception("这张广告核销单还未被审核，不能生成应收单！");
                }
            }

            if (this.Model.AdvApproveBE.FocusedRecord != null)
            {
                if (this.Model.AdvApproveBE.FocusedRecord.ID > 0L)
                {
                    if (string.IsNullOrEmpty(this.Model.AdvApproveBE.FocusedRecord.DescFlexField_PrivateDescSeg2))
                    {
                        ARBillImportBPProxy proxy = new ARBillImportBPProxy();
                        proxy.RelationId = this.Model.AdvApproveBE.FocusedRecord.ID;
                        SeeBestAdvertisementBP.ARBillRelationBP.ARBillReturnDTOData returnVal;
                        returnVal = proxy.Do();
                        if (returnVal.Flag)
                        {
                            UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('创建应收单成功，对应应收单单号：" + returnVal.DocNo + "！');", true);
                        }
                        else
                        {
                            UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('" + returnVal.Message + "');", true);
                        }
                        this.Action.NavigateAction.Refresh(null, false);
                    }
                    else
                    {
                        UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('这张广告核销单已经生成对应的应收单，单号：" + this.Model.AdvApproveBE.FocusedRecord.DescFlexField_PrivateDescSeg2 + "，不需要再重新生成应收单！');", true);
                    }
                }
            }

            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            BtnCreateARBill_Click_DefaultImpl(sender, e);

        }

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
            #region 工作流配置
            string strIsAFKey = UFIDA.U9.UI.PDHelper.FormAuthorityHelper.GetIsApproveDocKey;
            this.CurrentState[strIsAFKey] = new SetIsApprovalDoc(SetIsApprovalDoc);
            #endregion
            //弹性域设置
            FlexFieldHelper.SetDescFlexField(new DescFlexFieldParameter[] { new DescFlexFieldParameter(this.FlexFieldPicker0, this.Model.AdvApproveBE) });
            //查找按钮设置
            string paramWhere = null;
            PDFormMessage.ShowConfirmDialog(this.Page, "038f82f5-97ce-4aab-a61f-01b02bffc951", "580", "408",
                Title, wpFindID.ClientID, this.BtnFind, paramWhere);
            //取得提示信息资源：是否删除当前记录
            string message = PDResource.GetDeleteConfirmInfo();
            //绑定注册弹出对话框到删除按钮
            PDFormMessage.ShowConfirmDialog(this.Page, message, "", this.BtnDelete);
            PDFormMessage.ShowConfirmDialog(this.Page, "确认放弃当前记录？", "", this.BtnCancel);
            PDFormMessage.ShowConfirmDialog(this.Page, "确认按照开始日期与结束日期，批量生成所有办事处的核销单？", "批量生成核销单确认", this.BtnCreateAdvApprove);
            PDFormMessage.ShowConfirmDialog(this.Page, "确认生成这张广告核销单对应的应收单嘛？", "生成应收单确认", this.BtnCreateARBill);
            #region 根据单据状态控制页面控件可用
            //if (this.Model.AdvApproveBE.FocusedRecord.DocStatus.Value != 0)
            //{
            //    this.BtnGetApplyInfo.Enabled = false;
            //}
            //else
            //{
            //    this.BtnGetApplyInfo.Enabled = true;
            //}
            #endregion
            //业务日期赋默认值
            if (this.Model.AdvApproveBE.FocusedRecord == null)
                this.Model.AdvApproveBE.FocusedRecord = this.Model.AdvApproveBE.AddNewUIRecord();
            if (this.Model.AdvApproveBE.FocusedRecord.BusinessDate == null || this.Model.AdvApproveBE.FocusedRecord.BusinessDate == System.DateTime.MinValue)
            {
                this.Model.AdvApproveBE.FocusedRecord.BusinessDate = System.DateTime.Now;
            }
            if (string.IsNullOrEmpty(this.Model.AdvApproveBE.FocusedRecord.DocNo))
            {
                this.Model.AdvApproveBE.FocusedRecord.DocNo = "自动编号";
            }
        }
        internal static bool SetIsApprovalDoc(IUIModel model)
        {
            bool isAF = false;
            AdvApproveUIModelModel curModel = model as AdvApproveUIModelModel;
            if (curModel != null && curModel.AdvApproveBE.FocusedRecord != null)
            {
                AdvApproveBERecord record = curModel.AdvApproveBE.FocusedRecord;
                isAF = record.AdvApproveDocType_ConfirmType == Convert.ToInt32(UFIDA.U9.Base.Doc.ConfirmTypeEnumData.ApproveFlow);
            }
            return isAF;
        }
        public void AfterCreateChildControls()
        {
            //开启个性化
            UFIDA.U9.UI.PDHelper.PersonalizationHelper.SetPersonalizationEnable((BaseWebForm)this, true);

            RegisterGridCellDataChangedCallBack();
        }

        #region CallBack

        /// <summary>
        /// 注册表格单元格内容改变的回调事件
        /// </summary>
        private void RegisterGridCellDataChangedCallBack()
        {
            AssociationControl gridCellDataChangedASC = new AssociationControl();       //基本固定代码
            gridCellDataChangedASC.SourceServerControl = this.DataGrid0;
            gridCellDataChangedASC.SourceControl.EventName = "OnCellDataChanged";


            //CallBack处理方案
            ((IUFClientAssoGrid)gridCellDataChangedASC.SourceControl).FireEventCols.Add("Area");
            ((IUFClientAssoGrid)gridCellDataChangedASC.SourceControl).FireEventCols.Add("ApplyQty");
            ((IUFClientAssoGrid)gridCellDataChangedASC.SourceControl).FireEventCols.Add("Price");
            ((IUFClientAssoGrid)gridCellDataChangedASC.SourceControl).FireEventCols.Add("ActualApproveQty");
            ((IUFClientAssoGrid)gridCellDataChangedASC.SourceControl).FireEventCols.Add("ActualPrice");
            ((IUFClientAssoGrid)gridCellDataChangedASC.SourceControl).FireEventCols.Add("Discount");
            ClientCallBackFrm gridCellDataChangedCBF = new ClientCallBackFrm();
            gridCellDataChangedCBF.ParameterControls.Add(this.DataGrid0);

            gridCellDataChangedCBF.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(gridCellDataChangedCBF_DoCustomerActionOfSubvillage);
            gridCellDataChangedCBF.Add(gridCellDataChangedASC);
            this.Controls.Add(gridCellDataChangedCBF);

        }

        /// <summary>
        /// 表格的CallBack处理方式
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private object gridCellDataChangedCBF_DoCustomerActionOfSubvillage(CustomerActionEventArgs args)
        {
            UFWebClientGridAdapter grid = new UFWebClientGridAdapter(this.DataGrid0);

            //取表格数据（当前行）
            ArrayList list = (ArrayList)args.ArgsHash[UFWebClientGridAdapter.ALL_GRIDDATA_SelectedRows]; //基本固定代码
            int curIndex = int.Parse(list[0].ToString());
            Hashtable table = (Hashtable)((ArrayList)args.ArgsHash[this.DataGrid0.ClientID])[curIndex];
            decimal Area = decimal.Parse(table["Area"].ToString());
            decimal ApplyQty = decimal.Parse(table["ApplyQty"].ToString());
            decimal Price = decimal.Parse(table["Price"].ToString());
            decimal ActualApproveQty = decimal.Parse(table["ActualApproveQty"].ToString());
            decimal ActualPrice = decimal.Parse(table["ActualPrice"].ToString());
            decimal Discount = decimal.Parse(table["Discount"].ToString());
            decimal TotalMoney = 0M;
            decimal ApproveMoney = 0M;
            if (table["Momo"].ToString() == "封底")
            {
                TotalMoney = Price * Area;
                ApproveMoney = Area * ActualPrice * Discount;
            }
            else
            {
                TotalMoney = Price * ApplyQty * Area;
                ApproveMoney = ActualApproveQty * Area * ActualPrice * Discount;
            }

            //金额
            grid.CellValue.Add(new object[] { curIndex, "TotalMoney", new string[] { TotalMoney.ToString(), TotalMoney.ToString(), TotalMoney.ToString() } });
            //核销金额
            grid.CellValue.Add(new object[] { curIndex, "ApproveMoney", new string[] { ApproveMoney.ToString(), ApproveMoney.ToString(), ApproveMoney.ToString() } });
            args.ArgsResult.Add(grid.ClientInstanceWithValue);
            //..........(略)
            return args;
        }

        #endregion

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {

        }

        public void AfterUIModelBinding()
        {

            if (this.Model.AdvApproveBE.FocusedRecord != null)
            {
                this.BtnSubmit.Enabled = true;
                this.BtnApprove.Enabled = true;
                this.BtnUndoApprove.Enabled = true;
                switch (this.Model.AdvApproveBE.FocusedRecord.DocStatus.Value)
                {
                    case 0:
                        this.BtnApprove.Enabled = false;
                        this.BtnUndoApprove.Enabled = false;
                        this.BtnGetApplyInfo.Enabled = true;
                        this.BtnCreateARBill.Enabled = false;
                        break;
                    case 1:
                        this.BtnSubmit.Enabled = false;
                        this.BtnUndoApprove.Enabled = false;
                        this.BtnGetApplyInfo.Enabled = false;
                        this.BtnCreateARBill.Enabled = false;
                        break;
                    case 2:
                        this.BtnSubmit.Enabled = false;
                        this.BtnApprove.Enabled = false;
                        this.BtnGetApplyInfo.Enabled = false;
                        this.BtnCreateARBill.Enabled = true;
                        break;
                }

                if (this.Model.AdvApproveBE.FocusedRecord.ID > 0L)
                {
                    this.BtnDelete.Enabled = true;
                    this.BtnCopy.Enabled = true;
                }
                else
                {
                    this.BtnDelete.Enabled = false;
                    this.BtnCopy.Enabled = false;
                }
            }
            else
            {
                this.BtnDelete.Enabled = false;
                this.BtnCopy.Enabled = false;
            }

        }


        #endregion

        #endregion

    }
}