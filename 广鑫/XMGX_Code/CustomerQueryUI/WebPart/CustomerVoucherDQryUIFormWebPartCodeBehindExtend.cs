using System;
using System.Web;
using UFIDA.U9.Cust.FJGX.UIHelper;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.Portal;
using UFSoft.UBF.UI.Portal.WebControls.WebParts;
using UFSoft.UBF.UI.ReviseLayout;
using UFSoft.UBF.UI.WebControls;

/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/

namespace UFIDA.U9.Cust.FJGX.CustomerVoucherDQryUIModel
{
    public partial class CustomerVoucherDQryUIFormWebPart
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


        //DataGrid1_GridRowDbClicked...
        private void DataGrid1_GridRowDbClicked_Extend(object sender, GridDBClickEventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            //DataGrid1_GridRowDbClicked_DefaultImpl(sender, e);
        }

        //列表 中 保存列宽的代码
        private void btnSaveCurrentQueryCase_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            //保存列宽的代码
            UFIDA.UBF.Query.CommonService.QryService.SaveQueryCaseColumnsWidth(this.Action, sender, e);
            btnSaveCurrentQueryCase_Click_DefaultImpl(sender, e);
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
        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {
            //this.Model.Properties["NeedRefresh"].Value = false;
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
            decimal sumMoney = this.Model.QueryView.Records.Count == 0 ? 0 :
                decimal.Parse(this.Model.QueryView.Records[0]["SumMoney"].ToString());
            this.Label2.Text = "应收款余额:"+sumMoney.ToString("F2");
        }

        #endregion

        protected override void Page_PreRenderComplete(object sender, EventArgs e)
        {
            base.Page_PreRenderComplete(sender, e);
            //重置界面布局
            ReviseHelper.ReviseLayoutExtend(this, base.WebPartManager, this.Context);
        }

        #endregion
    }
}