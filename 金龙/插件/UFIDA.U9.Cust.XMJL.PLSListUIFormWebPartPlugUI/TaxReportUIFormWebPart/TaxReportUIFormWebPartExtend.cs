

namespace UFIDA.U9.Cust.XMJL.PLSListUIFormWebPartPlugUI
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Collections.Specialized;
    using UFSoft.UBF.UI.ControlModel;
    using UFSoft.UBF.UI.WebControlAdapter;
    using UFSoft.UBF.UI.WebControls.ClientCallBack;
    using UFSoft.UBF.UI.WebControls.Association;
    using System.Web.UI.WebControls.WebParts;
    using UFSoft.UBF.UI.IView;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using UFSoft.UBF.UI.Controls;
    using UFSoft.UBF.UI.WebControls;
    using UFIDA.U9.UI.PDHelper;
    using UFSoft.UBF.UI.MD.Runtime.Common;
    using UFSoft.UBF.UI.MD.Runtime;


    public partial class PLSListUIFormWebPart
    {

        #region 字段与属性

        private UFIDA.U9.MFG.MO.PLSListUIModel.PLSListUIFormWebPart _strongPart;

        #endregion


        private void Do_AfterDataLoad(UFSoft.UBF.UI.IView.IPart Part)
        {
            #region 获取相关强类型数据

            _strongPart = Part as UFIDA.U9.MFG.MO.PLSListUIModel.PLSListUIFormWebPart;
            if (_strongPart == null)
                return;
            if (_strongPart.FindControl("BtnDownCarNum") == null)
            {
                //2、在功能区添加
                //（1）、实例化按钮
                IUFButton BtnDownCarNum = new UFWebButtonAdapter();
                BtnDownCarNum.Text = "拆车号";
                BtnDownCarNum.ID = "BtnDownCarNum";
                //BtnDownCarNum.
                BtnDownCarNum.AutoPostBack = true;
                //（2）、加入功能栏Card中
                IUFCard card = (IUFCard)Part.GetUFControlByName(Part.TopLevelContainer, "Card0");
                card.Controls.Add(BtnDownCarNum);
                //（3）、设置按钮在容器中的位置
                TemplateClass.CommonFunction.Layout(card, BtnDownCarNum, 10, 0, 80, 20);   //一般为从左往右按钮个数乘以2
                //（4）、绑定按钮事件
                BtnDownCarNum.Click += new EventHandler(BtnDownCarNum_Click);
            }
            var batchPrint = _strongPart.FindControl("batchPrint");
            if (batchPrint != null)
            {
                (batchPrint as UFWebButtonAdapter).Text = "批量打印";
            }
            #endregion

        }

        private void BtnDownCarNum_Click(object sender, EventArgs e)
        {
            if (_strongPart.FindControl("DataGrid1") != null)
            {
                var data = _strongPart.FindControl("DataGrid1") as UFWebDataGridAdapter;
                data.CollectData();
            }

            if (_strongPart.Model.PLS.Cache.GetSelectRecord().Count == 0)
            {
                UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(_strongPart.Page,
                    _strongPart.Page.GetType(), "JavaScriptExecQueue", "alert('请选择要拆分的计划！');", true);
                return;
            }
            NameValueCollection paramList = new NameValueCollection();
            IList<IUIRecord> record = _strongPart.Model.PLS.Cache.GetSelectRecord();
            string plsIDs = string.Empty;
            foreach (var item in record)
            {
                plsIDs += item["DocNo"].ToString() + "," + item["DemandCode"].ToString()+"," + item["Project_Name"].ToString()+";";
            }
            paramList.Add("DocNo", plsIDs.TrimEnd(';'));
            _strongPart.ShowAtlasModalDialog("0d5759d2-5904-4fde-b438-32705af3780a", "拆分车号", "960", "490", _strongPart.TaskId.ToString(), paramList, true, false, false);
        }
    }
}
