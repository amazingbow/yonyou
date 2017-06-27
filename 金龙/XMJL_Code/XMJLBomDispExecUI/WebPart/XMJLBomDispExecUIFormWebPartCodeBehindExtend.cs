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
using UFIDA.U9.TH.CreateXmjlBP.Proxy;
using UFIDA.U9.BS.Job.RequestClient;
using UFIDA.U9.UI.PDHelper;
using System.Collections.Generic;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.XMJL.XMJLBomDispExecUIModel
{
    public partial class XMJLBomDispExecUIFormWebPart
    {
        #region Custome eventBind


        private void Button1_Click_Extend(object sender, EventArgs e) 
        {
            CreateMiscShipMentProxy proxy = new CreateMiscShipMentProxy();
            var wh = this.WareHouse35.Value != null ? this.WareHouse35.Value.ToString() : "";
            var carNo = this.ManufactureNo25.Value != null ? this.ManufactureNo25.Value.ToString() : "";
            var workPlace = this.WorkPlace34.Value != null ? this.WorkPlace34.Value.ToString() : "";
            if (string.IsNullOrEmpty(wh))
            {
                throw new Exception("请选择仓库！");
            }
            var start = this.StartDate109.Value != null ? this.StartDate109.Value.Value.ToString("yyyy-MM-dd") : "";
            var end = this.StartDate109.Value != null ? this.EndTime43.Value.Value.ToString("yyyy-MM-dd") : ""; 
            proxy.WareHouse = wh;
            proxy.ManufactureNo = carNo;
            proxy.WorkPlace = workPlace;
            proxy.BeginCreatedOn = start;
            proxy.EndCreatedOn = end; proxy.BomMainDocNo = "";
            proxy.Do();
        }
        //BtnDispExec_Click...
        private void BtnDispExec_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            var wh = this.WareHouse35.Value != null ? this.WareHouse35.Value.ToString() : "";
            //var carNo = this.ManufactureNo25.Value != null ? this.ManufactureNo25.Value.ToString() : "";
            //var workPlace = this.WorkPlace34.Value != null ? this.WorkPlace34.Value.ToString() : "";
            if (string.IsNullOrEmpty(wh))
            {
                throw new Exception("请选择仓库！");
            }
            var requestInfo="MiscShip"+DateTime.Now.ToString("yyyyMMddHHmmssfff");
            DoApproveAsynchronous("UFIDA.U9.TH.CreateXmjlBP.Proxy.CreateMiscShipMentProxy",
                "UFIDA.U9.TH.CreateXmjlBP.CreateMiscShipMent", DateTime.Now, requestInfo, requestInfo, requestInfo);
            //BtnDispExec_Click_DefaultImpl(sender, e);
            UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('缺件执行已提交，请等待');", true);
        }

        private long DoApproveAsynchronous(string ApproveProxyFullName, string BPFullName,
            DateTime ExecuteDate, string RequestCode, string RequestName, string RequestDescription)
        {
            DateTime date = PDContext.Current.LoginDate;

            if (ExecuteDate > date)
            {
                Random rnd = new Random(DateTime.Now.Millisecond);
                date = date.AddSeconds(rnd.Next(5, 59));
            }
            else
                return 0;
            string path = string.Empty;
            if (AppDomain.CurrentDomain.BaseDirectory.Contains("MailService"))
            {
                path = AppDomain.CurrentDomain.BaseDirectory + "Libs\\UFIDA.U9.Cust.GS.FT.FTBP.Agent.dll";
            }
            else
            {
                path = AppDomain.CurrentDomain.BaseDirectory + "ApplicationServer\\Libs\\UFIDA.U9.TH.CreateXmjlBP.Agent.dll";
            }
            //throw new Exception(path);
            System.Reflection.Assembly a = System.Reflection.Assembly.LoadFile(path);

            object o = a.CreateInstance(ApproveProxyFullName);
            Type t = o.GetType();
            UFSoft.UBF.Util.TypeLoader typeLoader = new UFSoft.UBF.Util.TypeLoader();
            var wh = this.WareHouse35.Value != null ? this.WareHouse35.Value.ToString() : "";
            var carNo = this.ManufactureNo25.Value != null ? this.ManufactureNo25.Value.ToString() : "";
            var workPlace = this.WorkPlace34.Value != null ? this.WorkPlace34.Value.ToString() : "";
            var start = this.StartDate109.Value!= null ?  this.StartDate109.Value.Value.ToString("yyyy-MM-dd"):"";
            var end = this.EndTime43.Value != null ? this.EndTime43.Value.Value.ToString("yyyy-MM-dd") : "";
            var item = this.Item49.Value != null ? this.Item49.Value.ToString() : "";
            var disStartDate = this.DistributeStartDate82.Value != null ? this.DistributeStartDate82.Value.Value.ToString("yyyy-MM-dd") : "";
            var disEndDate = this.DistributeEndDate174.Value != null ? this.DistributeEndDate174.Value.Value.ToString("yyyy-MM-dd") : "";
            var just = this.JustDisNegative175.Checked;
            //反射的参数设置
            if (t.GetProperty("WareHouse") != null)
                t.GetProperty("WareHouse").SetValue(o, wh, null);
            if (t.GetProperty("ManufactureNo") != null)
                t.GetProperty("ManufactureNo").SetValue(o, carNo, null);
            if (t.GetProperty("WorkPlace") != null)
                t.GetProperty("WorkPlace").SetValue(o, workPlace, null);
            if (t.GetProperty("BomMainDocNo") != null)
                t.GetProperty("BomMainDocNo").SetValue(o, RequestCode, null);

            if (t.GetProperty("BeginCreatedOn") != null)
                t.GetProperty("BeginCreatedOn").SetValue(o, start, null);
            if (t.GetProperty("EndCreatedOn") != null)
                t.GetProperty("EndCreatedOn").SetValue(o, end, null);

            if (t.GetProperty("ItemList") != null)
                t.GetProperty("ItemList").SetValue(o, item, null);
            if (t.GetProperty("DistributeStartDate") != null)
                t.GetProperty("DistributeStartDate").SetValue(o, disStartDate, null);
            if (t.GetProperty("DistributeEndDate") != null)
                t.GetProperty("DistributeEndDate").SetValue(o, disEndDate, null);
            if (t.GetProperty("JustDisNegative") != null)
                t.GetProperty("JustDisNegative").SetValue(o, just, null);

            if (t.GetProperty("IsJobServer") != null)
                t.GetProperty("IsJobServer").SetValue(o, false, null);

            RequestSubmit rsb = new RequestSubmit();
            rsb.Application = 3032;
            rsb.BPFullName = BPFullName;
            rsb.Priority = 1;
            rsb.RequestCode = RequestCode;
            PatternRunOnce once = new PatternRunOnce();
            rsb.SchedulerProject = once.PatternID(date);
            rsb.RequestDescription = RequestDescription;
            rsb.RequestName = RequestName;
            rsb.BPAgentObj = o;
            return rsb.Submit();
        }
        #region 自定义数据初始化加载和数据收集
        private void OnLoadData_Extend(object sender)
        {
            OnLoadData_DefaultImpl(sender);
            if (this.Model.BOMDispExecView.FocusedRecord == null)
                this.Model.BOMDispExecView.FocusedRecord = this.Model.BOMDispExecView.AddNewUIRecord();
        }
        private void OnDataCollect_Extend(object sender)
        {
            OnDataCollect_DefaultImpl(sender);
        }
        #endregion

        #region 自己扩展 Extended Event handler
        public void AfterOnLoad()
        {
            this.Button1.Visible = false;
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