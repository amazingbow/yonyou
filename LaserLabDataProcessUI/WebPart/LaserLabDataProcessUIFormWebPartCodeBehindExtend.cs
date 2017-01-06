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



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace LaserLabDataProcessUIModel
{
    public partial class LaserLabDataProcessUIFormWebPart
    {
        #region Custome eventBind
        private const string JYTXT = "~/LaserLabProcessFiles/STOCK1.txt";
        private const string BZTXT = "~/LaserLabProcessFiles/STOCK2.txt";
        private const string CHTXT = "~/LaserLabProcessFiles/STOCK3.txt";
        private const string BFTXT = "~/LaserLabProcessFiles/SCRAP.txt";

        //BtnCheckFile_Click...
        private void BtnCheckFile_Click_Extend(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (File.Exists(HttpContext.Current.Server.MapPath(JYTXT)))
            {
                sb.AppendLine("有金油数据可以转换！");
            }
            if (File.Exists(HttpContext.Current.Server.MapPath(BZTXT)))
            {
                sb.AppendLine("有包装数据可以转换！");
            }
            if (File.Exists(HttpContext.Current.Server.MapPath(CHTXT)))
            {
                sb.AppendLine("有出货数据可以转换！");
            }
            if (File.Exists(HttpContext.Current.Server.MapPath(BFTXT)))
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
            
            StreamReader sr = new StreamReader("", Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line.ToString());
            }

            BtnChange_Click_DefaultImpl(sender, e);
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