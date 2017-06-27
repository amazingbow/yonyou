using System;
using System.Web;
using System.Web.UI;
using UFIDA.U9.Cust.FJGX.UIHelper;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.Portal;
using UFSoft.UBF.UI.Portal.WebControls.WebParts;
using UFSoft.UBF.UI.ReviseLayout;
using UFSoft.UBF.UI.WebControls;
using System.Collections.Specialized;

/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/

namespace UFIDA.U9.Cust.FJGX.CustomerDQryUIModel
{
    public partial class CustomerDQryUIFormWebPart
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

        //DataGrid1_GridRowClicked_Extend...
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

        //OnLookCase_Click...
        private void BtnShowCustomerDocLine_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            BtnShowCustomerDocLine_Click_DefaultImpl(sender, e);
            if (this.Model.QueryView.FocusedRecord == null) return;
            NameValueCollection nv = new NameValueCollection();
            nv.Add("CustomerID", this.Model.QueryView.FocusedRecord["ID"].ToString());
            this.ShowModalDialog("36f81ab1-ce1c-4a33-9eea-74426ad67d1d", "出库记录", "992", "504", null, nv,
                false, true, false);
        }

        private void BtnOperatorsDaily_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            BtnOperatorsDaily_Click_DefaultImpl(sender, e);
            if (this.Model.QueryView.FocusedRecord == null) return;
            this.CurrentState["OperatorsDaily_CustomerID"] = this.Model.QueryView.FocusedRecord["ID"].ToString();
            this.CurrentState["OperatorsDaily_CustomerCode"] = this.Model.QueryView.FocusedRecord["Customer_Code"].ToString();
            this.CurrentState["OperatorsDaily_CustomerName"] = this.Model.QueryView.FocusedRecord["Customer_Name"].ToString();
            this.ShowModalDialog("6d3f628b-34ba-4bd4-9536-bbc3abdf64b0", "业务员日志", "992", "504", null, null,
                false, true, false);
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
            AfterCreateChildControls_Qry_DefaultImpl();
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
            decimal sumBalanceTotalMoney = this.Model.QueryView.Records.Count == 0 ? 0 :
                decimal.Parse(this.Model.QueryView.Records[0]["SumBalanceTotalMoney"].ToString());
            this.Label2.Text = "应收余额合计:" + sumBalanceTotalMoney.ToString("F2");
        }

        #endregion

        protected override void Page_PreRenderComplete(object sender, EventArgs e)
        {
            base.Page_PreRenderComplete(sender, e);
            //重置界面布局
            ReviseHelper.ReviseLayoutExtend(this, base.WebPartManager, this.Context);
        }

        public void ReviseLayout2()
        {
            if (this.IsAutoSize)
            {
                string text = this.Page.Session[ContextKey._KEY_SCREEN_PARAMS] as string;
                if (string.IsNullOrEmpty(text))
                {
                }
                else
                {
                    string[] array = text.Split(new char[]
					{
						':'
					});
                    string key = array[0] + array[1];
                    ReviseContext reviseContext = new ReviseContext(this);
                    if (reviseContext.ReviseTarget != null)
                    {
                        if (base.WebPartManager.WebParts.Count == 1)
                        {
                            reviseContext.ScreenAvailableWidth = Convert.ToDouble(array[2]);
                            reviseContext.ReviseRate = Convert.ToDouble(array[0]) / 1000.0 - 0.01;
                            reviseContext.NewRevise();
                        }
                    }
                }
            }
            else
            {
                string text2 = UFSoft.UBF.UI.Portal.Components.CSContext.Current.PageId.ToLower();
                string rawUrl = UFSoft.UBF.UI.Portal.Components.CSContext.Current.RawUrl;
                string b = "blank";
                string value = "display";
                bool flag = Convert.ToBoolean(UFSoft.UBF.UI.Portal.Components.CSContext.Current["orgChanged"]);
                try
                {
                    if (rawUrl.Contains(value) && text2 != b && base.WebPartManager.WebParts.Count >= 1 && !flag)
                    {
                        string text = this.Page.Session[ContextKey._KEY_SCREEN_PARAMS] as string;
                        if (string.IsNullOrEmpty(text))
                        {
                            HttpCookie httpCookie = this.Context.Session[ContextKey._KEY_SCREEN_PARAMS] as HttpCookie;
                            if (httpCookie != null)
                            {
                                text = httpCookie.Value;
                            }
                            if (string.IsNullOrEmpty(text))
                            {
                                return;
                            }
                        }
                        string[] array = text.Split(new char[]
						{
							':'
						});
                        string key = array[0] + array[1];
                        if (!(this is UFNoAccessPart))
                        {
                            if (ReviseConfigManager.ConfigExists())
                            {
                                ReviseConfig reviseConfig = ReviseConfigManager.Get();
                                if (reviseConfig.Resolutions.ContainsKey(key))
                                {
                                    if (reviseConfig.Revise)
                                    {
                                        this.Page.RegisterHiddenField("__Revise_KEY", "true");
                                        this.Page.Session["__Revise_KEY"] = reviseConfig.Revise;
                                        if (!reviseConfig.Inverse)
                                        {
                                            if (reviseConfig.ReviseForms.ContainsKey(text2))
                                            {
                                                ReviseContext reviseContext = new ReviseContext(this);
                                                if (reviseContext.ReviseTarget != null)
                                                {
                                                    if (base.WebPartManager.WebParts.Count == 1)
                                                    {
                                                        reviseContext.ScreenAvailableHeight = Convert.ToDouble(array[3]) - (double)reviseContext.ReviseDeviation;
                                                        reviseContext.ScreenAvailableWidth = Convert.ToDouble(array[2]);
                                                    }
                                                    else if (base.WebPartManager.WebParts.Count == 3 && reviseConfig.ReviseForms[text2].ToString().ToLower().IndexOf("left3布局") > 0)
                                                    {
                                                        double num = Convert.ToDouble(array[3]) - (double)reviseContext.ReviseDeviation;
                                                        double num2 = Convert.ToDouble(array[2]);
                                                        UFSoft.UBF.UI.Portal.Components.CSPage pageSettings = PageManagement.GetPageSettings();
                                                        double num3 = Convert.ToDouble(pageSettings.Zones[0].Parts[0].Width);
                                                        double num4 = Convert.ToDouble(pageSettings.Zones[0].Parts[0].Height);
                                                        double num5 = Convert.ToDouble(pageSettings.Zones[1].Parts[0].Width);
                                                        double num6 = Convert.ToDouble(pageSettings.Zones[1].Parts[0].Height);
                                                        double num7 = Convert.ToDouble(pageSettings.Zones[1].Parts[1].Width);
                                                        double num8 = Convert.ToDouble(pageSettings.Zones[1].Parts[1].Height);
                                                        if (this.Page.Session[rawUrl] == null)
                                                        {
                                                            reviseContext.ScreenAvailableHeight = num * num4 / ((num4 > num6 + num8) ? num4 : (num6 + num8));
                                                            reviseContext.ScreenAvailableWidth = num2 * num3 / (num3 + num5);
                                                            this.Page.Session[rawUrl] = 1;
                                                        }
                                                        else if (this.Page.Session[rawUrl] != null && (int)this.Page.Session[rawUrl] == 1)
                                                        {
                                                            reviseContext.ScreenAvailableHeight = num * num6 / (num6 + num8);
                                                            reviseContext.ScreenAvailableWidth = num2 * num5 / (num3 + num5);
                                                            this.Page.Session[rawUrl] = 2;
                                                        }
                                                        else if (this.Page.Session[rawUrl] != null && (int)this.Page.Session[rawUrl] == 2)
                                                        {
                                                            reviseContext.ScreenAvailableHeight = num * num8 / (num6 + num8);
                                                            reviseContext.ScreenAvailableWidth = num2 * num7 / (num3 + num5);
                                                            this.Page.Session[rawUrl] = null;
                                                        }
                                                    }
                                                    reviseContext.ReviseRate = Convert.ToDouble(array[0]) / 1000.0 - 0.01;
                                                    DateTime now = DateTime.Now;
                                                    reviseContext.Revise();
                                                    DateTime now2 = DateTime.Now;
                                                }
                                            }
                                        }
                                        else if (!reviseConfig.ReviseForms.ContainsKey(text2))
                                        {
                                            ReviseContext reviseContext = new ReviseContext(this);
                                            if (reviseContext.ReviseTarget != null)
                                            {
                                                reviseContext.ScreenAvailableHeight = Convert.ToDouble(array[3]) - (double)reviseContext.ReviseDeviation;
                                                reviseContext.ScreenAvailableWidth = Convert.ToDouble(array[2]);
                                                reviseContext.ReviseRate = Convert.ToDouble(array[0]) / 1000.0 - 0.01;
                                                DateTime now = DateTime.Now;
                                                reviseContext.Revise();
                                                DateTime now2 = DateTime.Now;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        #endregion
    }
}