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
                        record.Location = item.Location;
                        record.AdvAppCustName = item.AdvAppCustName;
                        record.Country = item.Country;
                        record.CustCounterName = item.CustCounterName;
                        record.RelPeople = item.RelPeople;
                        record.RelPhone = item.RelPeople;
                        record.CustAddress = item.CustAddress;
                        record.Width = item.Width;
                        record.Thick = item.Thick;
                        record.Height = item.Height;
                        record.ApplyAdvCode = item.ApplyAdvCode;
                        record.AdvCarrier = item.AdvCarrier;
                        record.OtherInfo = item.ApplyId;
                        //record.BuildStatus=
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
            #region 根据单据状态控制页面控件可用
            if (this.Model.AdvApproveBE.FocusedRecord.DocStatus.Value != 0)
            {
                this.BtnGetApplyInfo.Enabled = false;
            }
            #endregion
            //业务日期赋默认值
            if (this.Model.AdvApproveBE.FocusedRecord == null)
                this.Model.AdvApproveBE.FocusedRecord = this.Model.AdvApproveBE.AddNewUIRecord();
            if (this.Model.AdvApproveBE.FocusedRecord.BusinessDate == null || this.Model.AdvApproveBE.FocusedRecord.BusinessDate == System.DateTime.MinValue)
            {
                this.Model.AdvApproveBE.FocusedRecord.BusinessDate = System.DateTime.Now;
            }
            //单号赋默认值 -- 客户简称+YYMM+2流水号
            if (string.IsNullOrEmpty(this.Model.AdvApproveBE.FocusedRecord.DocNo))
            {
                this.Model.AdvApproveBE.FocusedRecord.DocNo = "AdvApprove" + System.DateTime.Now.ToString("yyMM");
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
       }

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
                        break;
                    case 1:
                        this.BtnSubmit.Enabled = false;
                        this.BtnUndoApprove.Enabled = false;
                        break;
                    case 2:
                        this.BtnSubmit.Enabled = false;
                        this.BtnApprove.Enabled = false;
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