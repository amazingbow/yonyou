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
using UFIDA.U9.Cust.XMJLBomOpBP.Proxy;
using System.Collections.Generic;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.XMJL.Qry.XMJLBatchIssueUIModel
{
    public partial class XMJLBatchIssueUIFormWebPart
    {
        #region Custome eventBind

        //List<BOMMainInfoViewRecord> _allSelectedRecord = new List<BOMMainInfoViewRecord>();
        //BtnBOMMainFind_Click...
        private void BtnBOMMainFind_Click_Extend(object sender, EventArgs e)
        {
            if (this.Model.FindBOMMainWhereView.FocusedRecord.DisburseType == null ||
                this.Model.FindBOMMainWhereView.FocusedRecord.DisburseType.Value == 0)
            {
                UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('请选择发料类型！');", true);
                return;
            }
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (this.Model.BOMMainInfoView.SelectRecords.Count > 0)
            {
                foreach (BOMMainInfoViewRecord record in this.Model.BOMMainInfoView.SelectRecords)
                {
                    var car = record.ManufactureNo.ToString();
                    if (this.ddlHiddenForSelect.Items.FindByValue(car) != null) return;
                    this.ddlHiddenForSelect.AddItem(car, car);
                }
            }
            if (this.Model.FindBOMMainWhereView.FocusedRecord != null)
            {
                this.Model.BOMMainInfoView.Clear();
                GetBOMMainInfoProxy proxy = new GetBOMMainInfoProxy();
                proxy.ManufactureNo = this.Model.FindBOMMainWhereView.FocusedRecord.ManufactureNo + "%";
                proxy.ContractNo = "%" + this.Model.FindBOMMainWhereView.FocusedRecord.ContractNo + "%";
                proxy.CarType = "%" + this.Model.FindBOMMainWhereView.FocusedRecord.CarType + "%";
                proxy.DisburseType = this.Model.FindBOMMainWhereView.FocusedRecord.DisburseType ?? 1;
                List<UFIDA.U9.Cust.XMJLBomOpBP.BOMMainInfoDtoData> bomMainInfoDtolist = proxy.Do();
                foreach (UFIDA.U9.Cust.XMJLBomOpBP.BOMMainInfoDtoData dto in bomMainInfoDtolist)
                {
                    BOMMainInfoViewRecord record = this.Model.BOMMainInfoView.AddNewUIRecord();
                    record.ManufactureNo = dto.ManufactureNo;//车号
                    record.ContractNo = dto.ContractNo;//合同号
                    record.CarType = dto.CarType;//车型
                    record.ManufactureNo_Code = dto.ManufactureNo_Code;//编码
                    record.ManufactureNo_Name = dto.ManufactureNo_Name;//项目名称
                    record.No = dto.No;//序号
                    record.DisburseType = proxy.DisburseType;
                }
            }
            BtnBOMMainFind_Click_DefaultImpl(sender, e);
            this.hasSelectedNum.Text = (this.ddlHiddenForSelect.ItemCount).ToString();
        }
        //BtnClose_Click...
        private void BtnClose_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.CloseDialog(false);
            BtnClose_Click_DefaultImpl(sender, e);
        }
        //BtnOk_Click...
        private void BtnOk_Click_Extend(object sender, EventArgs e)
        {
            List<string> manufactureNoList = new List<string>();
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (this.Model.BOMMainInfoView.SelectRecords.Count > 0)
            {
                foreach (BOMMainInfoViewRecord record in this.Model.BOMMainInfoView.SelectRecords)
                {
                    var car = record.ManufactureNo.ToString();
                    if (this.ddlHiddenForSelect.Items.FindByValue(car) != null) return;
                    this.ddlHiddenForSelect.AddItem(car, car);
                }
                foreach (ListItem item in this.ddlHiddenForSelect.Items)
                {
                    manufactureNoList.Add(item.Value);
                }
            }
            if (manufactureNoList.Count == 0)
            {
                UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('请选择要发料的车号！');", true);
                return;
            }
            UpdateBomMainStatusBPProxy proxy = new UpdateBomMainStatusBPProxy();
            proxy.ManufactureNoList = manufactureNoList;
            proxy.DisburseType = this.Model.BOMMainInfoView.FocusedRecord.DisburseType ?? 1;
            var result = proxy.Do();
            this.ddlHiddenForSelect.Items.Clear();
            UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('选择的车号已发料成功！发料单号： " + result + "');", true);
            BtnOk_Click_DefaultImpl(sender, e);
        }
        #region 自定义数据初始化加载和数据收集
        private void OnLoadData_Extend(object sender)
        {
            OnLoadData_DefaultImpl(sender);
            if (this.Model.FindBOMMainWhereView.FocusedRecord == null)
                this.Model.FindBOMMainWhereView.FocusedRecord = this.Model.FindBOMMainWhereView.AddNewUIRecord();
        }
        private void OnDataCollect_Extend(object sender)
        {
            OnDataCollect_DefaultImpl(sender);
        }

        private void BtnClear_Click_Extend(object sender, EventArgs e)
        {
            BtnBOMMainFind_Click_Extend(sender, e);
            this.ddlHiddenForSelect.ClearItems();
            this.hasSelectedNum.Text = "0";
        }

        private void DataGrid0_GridRowClicked_Extend(object sender, GridCallBackEventArgs e)
        {
            this.DataGrid0.CollectData();
            this.hasSelectedNum.Text = (this.ddlHiddenForSelect.ItemCount + this.Model.BOMMainInfoView.SelectRecords.Count).ToString();
        }
        #endregion

        #region 自己扩展 Extended Event handler
        public void AfterOnLoad()
        {
            this.ddlHiddenForSelect.Visible = false;
            this.DataGrid0.AllowSelectAllPage = true;
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

        #endregion

    }
}