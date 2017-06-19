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
using UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP.Proxy;
using UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.CostSharingRatioUIModel
{
    public partial class CostSharingRatioUIFormWebPart
    {
        #region Custome eventBind






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
            GetFirstDataProxy proxy = new GetFirstDataProxy();
            CostSharingRationDTOData data = proxy.Do();
            if (data != null)
            {
                if (this.Model.CostSharingRatioBE.FocusedRecord == null)
                {
                    this.Model.CostSharingRatioBE.FocusedRecord = this.Model.CostSharingRatioBE.AddNewUIRecord();
                }
                this.Model.CostSharingRatioBE.FocusedRecord.ID = data.ID;
                this.Model.CostSharingRatioBE.FocusedRecord.SysVersion = data.SysVersion;
                this.Model.CostSharingRatioBE.FocusedRecord.Ratio = data.Ratio;
            }
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