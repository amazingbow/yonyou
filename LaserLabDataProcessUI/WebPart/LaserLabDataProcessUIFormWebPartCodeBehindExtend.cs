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
using UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab;
using System.Configuration;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace LaserLabDataProcessUIModel
{
    public partial class LaserLabDataProcessUIFormWebPart
    {
        #region Custome eventBind
        private const string JYTXT = "STOCK1.txt";
        private const string BZTXT = "STOCK2.txt";
        private const string CHTXT = "STOCK3.txt";
        private const string BFTXT = "SCRAP.txt";
        private string _ProcessFilePath;
        private string _ErrorFilePath;
        //BtnCheckFile_Click...
        private void BtnCheckFile_Click_Extend(object sender, EventArgs e)
        {
            //config.Text
            StringBuilder sb = new StringBuilder();
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (File.Exists(_ProcessFilePath + JYTXT))
            {
                sb.AppendLine("有金油数据可以转换！");
            }
            if (File.Exists(_ProcessFilePath + BZTXT))
            {
                sb.AppendLine("有包装数据可以转换！");
            }
            if (File.Exists(_ProcessFilePath + CHTXT))
            {
                sb.AppendLine("有出货数据可以转换！");
            }
            if (File.Exists(_ProcessFilePath + BFTXT))
            {
                sb.AppendLine("有报废数据可以转换！");
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
            switch (this.RadioBoxList1.SelectedIndex)
            {
                case 0:
                    GoldenOilProcess(_ProcessFilePath + JYTXT);
                    break;
                case 1:
                    PackingProcess(_ProcessFilePath + BZTXT);
                    break;
                case 2:
                    ShipmentProcess(_ProcessFilePath + CHTXT);
                    break;
                case 3:
                    ScrapProcess(_ProcessFilePath + BFTXT);
                    break;
                default:
                    break;
            }
            BtnChange_Click_DefaultImpl(sender, e);
        }

        private void ScrapProcess(string path)
        {
            throw new NotImplementedException();
        }

        private void ShipmentProcess(string path)
        {
            StreamReader sr = new StreamReader(path, Encoding.Default);
            string errFileName = _ErrorFilePath + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            String line;
            bool flag = false;
            StreamWriter sw = null;
            while ((line = sr.ReadLine()) != null)
            {
                //LaserLab
                line = line.Trim();
                if (line.Length > 20)
                {
                    string batch = line.Substring(0, 5);
                    string tempstr = line.Substring(6).Trim();

                    string tempTime = tempstr.Substring(tempstr.Length - 15).Trim();
                    string time = tempTime.Substring(0, 8);
                    string laserLab = tempstr.Replace(tempTime, "").Trim();
                    LaserLab lab = LaserLab.Finder.Find("BN='" + batch + "' and LB='" + laserLab + "'");
                    if (lab == null)
                    {
                        flag = true;
                        if (File.Exists(errFileName) == false)//如果不存在就创建file文件夹
                        {
                            File.Create(errFileName);//创建该文件
                        }
                        sw = new StreamWriter(errFileName);
                        sw.WriteLine(line, Encoding.Default);
                    }
                }
            }
            if (sw != null)
            {
                sw.Close();
            }
            sr.Close();
        }

        private void PackingProcess(string path)
        {
            throw new NotImplementedException();
        }

        private void GoldenOilProcess(string path)
        {
            throw new NotImplementedException();
        }
        //BtnJYForceChange_Click...
        private void BtnJYForceChange_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnJYForceChange_Click_DefaultImpl(sender, e);
        }

        //BtnBZForceChange_Click...
        private void BtnBZForceChange_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnBZForceChange_Click_DefaultImpl(sender, e);
        }

        //BtnCHForceChange_Click...
        private void BtnCHForceChange_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnCHForceChange_Click_DefaultImpl(sender, e);
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
            _ProcessFilePath = ConfigurationManager.AppSettings["ProcessFilePath"];
            _ErrorFilePath = ConfigurationManager.AppSettings["ErrorFilePath"];
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