using System;
using UFIDA.U9.Cust.FJGX.UIHelper;
using UFIDA.UBF.Query.CommonService;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.WebControls;

/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/

namespace UFIDA.U9.Cust.FJGX.AchievementSumDQryUIModel
{
    public partial class AchievementSumDQryUIFormWebPart
    {
        #region Custome eventBind

        //BtnOutPut_Click...
        private void BtnOutPut_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnOutPut_Click_DefaultImpl(sender, e);
        }

        //BtnPrint_Click...
        private void BtnPrint_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnPrint_Click_DefaultImpl(sender, e);
        }


        //DDLCase_TextChanged...
        private void DDLCase_TextChanged_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            DDLCase_TextChanged_DefaultImpl(sender, e);
        }

        //OnLookCase_Click...
        private void OnLookCase_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            OnLookCase_Click_DefaultImpl(sender, e);
        }

        //btnSaveCurrentQueryCase_Click...
        private void btnSaveCurrentQueryCase_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            QryService.SaveQueryCaseColumnsWidth(this.Action, sender, e);
            btnSaveCurrentQueryCase_Click_DefaultImpl(sender, e);
        }

        //DataGrid1_GridRowClicked...
        private void DataGrid1_GridRowClicked_Extend(object sender, GridCallBackEventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            DataGrid1_GridRowClicked_DefaultImpl(sender, e);
        }

        //DataGrid1_GridRowDbClicked...
        private void DataGrid1_GridRowDbClicked_Extend(object sender, GridDBClickEventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            DataGrid1_GridRowDbClicked_DefaultImpl(sender, e);
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
        }

        public void AfterCreateChildControls()
        {
            AfterCreateChildControls_Qry_DefaultImpl(); //DTO查询自动产生的代码
            //updatePanel.UpdateMode = UpdatePanelUpdateMode.Always;//【这里设置双击主part的一行，该part是否刷新】
            this.IsProviding = true;
        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {
            BeforeUIModelBinding_Qry_DefaultImpl(); //DTO查询自动产生的代码
            ShowSumMoney();
        }

        public void AfterUIModelBinding()
        {
            AfterUIModelBinding_Qry_DefaultImpl(); //DTO查询自动产生的代码
        }

        /// <summary>
        /// 显示总金额
        /// </summary>
        private void ShowSumMoney()
        {
            decimal sumRecTotalMoney = this.Model.QueryView.Records.Count == 0 ? 0 :
               decimal.Parse(this.Model.QueryView.Records[0]["sumRecTotalMoney"].ToString());
            decimal sumARTotalMoney = this.Model.QueryView.Records.Count == 0 ? 0 :
              decimal.Parse(this.Model.QueryView.Records[0]["sumARTotalMoney"].ToString());
            this.Label2.Text = sumRecTotalMoney.ToString("F2");
            this.Label4.Text = sumARTotalMoney.ToString("F2");
        }

        protected override void Page_PreRenderComplete(object sender, EventArgs e)
        {
            base.Page_PreRenderComplete(sender, e);
            //重置界面布局
            ReviseHelper.ReviseLayoutExtend(this, base.WebPartManager, this.Context);
        }

        #endregion

        #endregion
    }
}