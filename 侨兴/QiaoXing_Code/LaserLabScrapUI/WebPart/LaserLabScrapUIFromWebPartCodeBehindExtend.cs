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
using UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP.Proxy;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.XMQX.LaserLabScrapUI.LaserLabScrapUIModel
{
    public partial class LaserLabScrapUIFromWebPart
    {
        #region Custome eventBind


        //BtnOk_Click...
        private void BtnOk_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (string.IsNullOrEmpty(this.TextBox1.Text)) return;
            if (string.IsNullOrEmpty(this.DatePicker2.Text.ToString()))
            {
                throw new Exception("报废时间必须填写！");
            }
            LaserLabScrapBPProxy proxy = new LaserLabScrapBPProxy();
            proxy.LB = this.TextBox1.Text;
            proxy.ScrapDT = DateTime.Parse(this.DatePicker2.Text);
            var str = proxy.Do();
            if (!string.IsNullOrEmpty(str))
            {
                UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('" + str + "');", true);
            }
            BtnOk_Click_DefaultImpl(sender, e);
        }

        //BtnClear_Click...
        private void BtnClear_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.TextBox1.Text = null;
            this.DatePicker2.Text = null;
            //  this.Model.LaserLabSoloScrapView.ClearCache();
            //this.Model.LaserLabSoloScrapView.Records.Clear();
            this.Model.LaserLabSoloScrapView.FocusedRecord.BN = null;
            this.Model.LaserLabSoloScrapView.FocusedRecord.CP = null;
            this.Model.LaserLabSoloScrapView.FocusedRecord.Type = null;
            this.Model.LaserLabSoloScrapView.FocusedRecord.Date = null;
            this.Model.LaserLabSoloScrapView.FocusedRecord.Time = null;
            BtnClear_Click_DefaultImpl(sender, e);
        }
        private void BtnReturnMaster_Click_Extend(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.Model.LaserLabSoloScrapView.FocusedRecord.CP) && !string.IsNullOrEmpty(this.TextBox1.Text))
            {

                ReturnLBMasterProxy proxy = new ReturnLBMasterProxy();
                proxy.CP = this.Model.LaserLabSoloScrapView.FocusedRecord.CP;
                proxy.LB = this.TextBox1.Text;
                var str = proxy.Do();
                if (str == "True")
                {
                    UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('数据已经返还物料状态！');", true);
                }

            }

            BtnReturnMaster_Click_DefaultImpl(sender, e);
        }

        private void TabControl2_SelectedIndexChanged_Extend(object sender, EventArgs e)
        {
            if (this.TabControl2.SelectedIndex == 1)
            {
                this.Model.LaserLabScrapInfoView.Records.Clear();
                LookScrapInfoBPProxy proxy = new LookScrapInfoBPProxy();
                var ScrapInfo = proxy.Do();
                if (ScrapInfo.Count > 0)
                {
                    this.Model.LaserLabScrapInfoView.Clear();
                    foreach (var Record in ScrapInfo)
                    {
                        var Scrap = this.Model.LaserLabScrapInfoView.AddNewUIRecord();
                        Scrap.LB = Record.LB;
                        Scrap.BN = Record.BN;
                        Scrap.CP = Record.CP;
                        Scrap.Type = Record.TYPE;
                        Scrap.ScrapDT = Record.ScrapDT.ToString();

                    }
                }
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
            this.Model.ClearErrorMessage();
            this.TextBox1.Focus();
        }

        public void AfterCreateChildControls()
        {
            this.TextBox1.AutoPostBack = true;
        }

        public void AfterEventBind()
        {

        }

        public void BeforeUIModelBinding()
        {
            if (string.IsNullOrEmpty(this.TextBox1.Text)) return;
            //lthis.Model.LaserLabSoloScrapView.Records.Clear();
            ScarpGetLBInfoBPProxy proxy = new ScarpGetLBInfoBPProxy();
            proxy.LB = this.TextBox1.Text;
            var Record = proxy.Do();
            if (Record.BN == null || Record.CP == null)
            {
                this.Model.LaserLabSoloScrapView.FocusedRecord.BN = null;
                this.Model.LaserLabSoloScrapView.FocusedRecord.Type = null;
                this.Model.LaserLabSoloScrapView.FocusedRecord.CP = null;
                this.Model.LaserLabSoloScrapView.FocusedRecord.Date = null;
                this.Model.LaserLabSoloScrapView.FocusedRecord.Time = null;
            }
            else
            {
                this.Model.LaserLabSoloScrapView.FocusedRecord.BN = Record.BN;
                this.Model.LaserLabSoloScrapView.FocusedRecord.Type = Record.Type;
                this.Model.LaserLabSoloScrapView.FocusedRecord.CP = Record.CP;
                this.Model.LaserLabSoloScrapView.FocusedRecord.Date = Record.Date.ToString();
                this.Model.LaserLabSoloScrapView.FocusedRecord.Time = Record.Time.ToString().Split(' ')[1];
                this.DatePicker2.Value = System.DateTime.Now;
                if (this.Model.LaserLabSoloScrapView.FocusedRecord.CP == "Scrap")
                {
                    this.BtnOk.Enabled = false;
                    this.BtnReturnMaster.Enabled = true;
                }
                else if (this.Model.LaserLabSoloScrapView.FocusedRecord.CP == "Shipment")
                {
                    this.BtnOk.Enabled = false;
                }
                else
                {
                    this.BtnOk.Enabled = true;
                    this.BtnReturnMaster.Enabled = false;
                }
            }
        }

        public void AfterUIModelBinding()
        {
        }


        #endregion

        #endregion

    }
}