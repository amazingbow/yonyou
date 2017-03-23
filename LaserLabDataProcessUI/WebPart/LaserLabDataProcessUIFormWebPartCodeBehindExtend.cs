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
using System.IO;
using UFIDA.U9.UI.PDHelper;
using System.Web;
using System.Configuration;
using UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabDataProcessBP.Proxy;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace LaserLabDataProcessUIModel
{
    public partial class LaserLabDataProcessUIFormWebPart
    {
        #region Custome eventBind
        private string JYTXT = ConfigurationManager.AppSettings["ProcessFilePath"] + "STOCK1.txt";
        private string BZTXT = ConfigurationManager.AppSettings["ProcessFilePath"] + "STOCK2.txt";
        private string CHTXT = ConfigurationManager.AppSettings["ProcessFilePath"] + "STOCK3.txt";
        private string BFTXT = ConfigurationManager.AppSettings["ProcessFilePath"] + "SCRAP.txt";
        private string _ErrorFilePath = ConfigurationManager.AppSettings["ErrorFilePath"];
        //BtnCheckFile_Click...
        private void BtnCheckFile_Click_Extend(object sender, EventArgs e)
        {
            //config.Text
            StringBuilder sb = new StringBuilder();
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (File.Exists(JYTXT))
            {
                sb.Append("有金油数据可以转换！");
            }
            if (File.Exists(BZTXT))
            {
                sb.Append("有包装数据可以转换！");
            }
            if (File.Exists(CHTXT))
            {
                sb.Append("有出货数据可以转换！");
            }
            if (File.Exists(BFTXT))
            {
                sb.Append("有报废数据可以转换！");
            }
            string msg = sb.ToString();
            if (string.IsNullOrEmpty(msg))
            {
                msg = "没有文件可以转换！";
            }
            UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('" + msg + "');", true);
            BtnCheckFile_Click_DefaultImpl(sender, e);
        }

        //BtnChange_Click...
        private void BtnChange_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            LbDataProcessBPProxy proxy = new LbDataProcessBPProxy();
            proxy.ProcessType = this.RadioBoxList1.SelectedIndex;
            var result = proxy.Do();
            string resultMsg = string.Empty;
            if (result == 0)
            {
                resultMsg = "数据转换失败，请查看LaserLabProcessError文件夹下以Error结尾的文件，然后手动处理";
            }
            else if (result == 1)
            {
                resultMsg = "数据转换全部成功！";
            }
            else if (result == 2)
            {
                resultMsg = "文件不存在！";
            }
            else
            {
                resultMsg = "有非法数据出现，请查看LaserLabProcessError文件夹下以Fatal结尾的文件";
            }
            UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('" + resultMsg + "');", true);
            BtnChange_Click_DefaultImpl(sender, e);
        }
        //BtnJYForceChange_Click...
        private void BtnJYForceChange_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            ChangeType(1);
            BtnJYForceChange_Click_DefaultImpl(sender, e);
        }

        //BtnBZForceChange_Click...
        private void BtnBZForceChange_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            ChangeType(2);
            BtnBZForceChange_Click_DefaultImpl(sender, e);
        }

        //BtnCHForceChange_Click...
        private void BtnCHForceChange_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            ChangeType(3);
            BtnCHForceChange_Click_DefaultImpl(sender, e);
        }

        private void ChangeType(int changeCp)
        {
            if (!ValidateFilled())
            {
                return;
            }
            var batchNo = this.Model.LaserLabDataProcessView.FocusedRecord.BatchNo;
            var laserLab = this.Model.LaserLabDataProcessView.FocusedRecord.LaserLabCode;
            var type = this.Model.LaserLabDataProcessView.FocusedRecord.Type;
            var flowStart = this.Model.LaserLabDataProcessView.FocusedRecord.FlowNumStart;
            var flowEnd = this.Model.LaserLabDataProcessView.FocusedRecord.FlowNumEnd;
            SingleChangeBPProxy proxy = new SingleChangeBPProxy();
            proxy.BatchNo = batchNo;
            proxy.LaserLab = laserLab;
            proxy.Type = type;
            proxy.FlowStart = flowStart;
            proxy.FlowEnd = flowEnd;
            proxy.ChangeModel = this.TabControl0.SelectedIndex;
            proxy.ChangeCp = changeCp;
            proxy.ShipBatchNo = this.Model.LaserLabDataProcessView.FocusedRecord.ShipBatchNo;
            proxy.ShipDateTime = this.Model.LaserLabDataProcessView.FocusedRecord.ShipTime ?? DateTime.Now;  //如果时间不填写，就默认当前时间
            var result = proxy.Do();
            if (result)
            {
                UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('转换成功！');", true);
            }
            else
            {
                UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('转换失败！请查询数据库确认是否有数据');", true);
            }
        }

        private bool ValidateFilled()
        {
            if (this.TabControl0.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(this.Model.LaserLabDataProcessView.FocusedRecord.LaserLabCode))
                {
                    UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('请填写镭射标号');", true);
                    return false;
                }
                return true;
            }
            else
            {
                var batchNo = this.Model.LaserLabDataProcessView.FocusedRecord.BatchNo;
                var type = this.Model.LaserLabDataProcessView.FocusedRecord.Type;
                if (string.IsNullOrEmpty(batchNo))
                {
                    UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('请填写批次号和型号');", true);
                    return false;
                }
                return true;
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
        }

        public void AfterCreateChildControls()
        {



        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {
            //this.RadioBoxList1.AutoPostBack = true;
            this.RadioBoxList1.SelectedIndex = 0;
            //this.RadioBoxList1.
        }

        public void AfterUIModelBinding()
        {


        }


        #endregion

        #endregion

    }
}