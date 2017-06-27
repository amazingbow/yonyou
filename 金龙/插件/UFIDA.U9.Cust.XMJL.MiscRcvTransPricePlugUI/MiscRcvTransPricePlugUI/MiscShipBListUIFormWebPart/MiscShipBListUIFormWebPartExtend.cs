

namespace UFIDA.U9.Cust.XMJL.MiscRcvTransPricePlugUI
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
    using System.Data;
    using UFIDA.U9.Cust.XMJLBomOpBP.Proxy;


    public partial class MiscShipBListUIFormWebPart
    {

        #region 字段与属性

        private UFIDA.U9.SCM.INV.MiscShipBListUIModel.MiscShipBListUIFormWebPart _strongPart;

        #endregion


        private void Do_AfterInit(UFSoft.UBF.UI.IView.IPart part, EventArgs args)
        {
            #region 获取相关强类型数据

            _strongPart = part as UFIDA.U9.SCM.INV.MiscShipBListUIModel.MiscShipBListUIFormWebPart;
            if (_strongPart == null)
                return;
            IUFButton btnBatchSelectSend = new UFWebButtonAdapter();
            btnBatchSelectSend.Text = "批量拣发";
            btnBatchSelectSend.ID = "btnBatchSelectSend";
            btnBatchSelectSend.AutoPostBack = true;
            ///（2）、加入功能栏Card中
            IUFCard card = (IUFCard)_strongPart.GetUFControlByName(_strongPart.TopLevelContainer, "Card0");
            card.Controls.Add(btnBatchSelectSend);
            ///（3）、设置按钮在容器中的位置
            TemplateClass.CommonFunction.Layout(card, btnBatchSelectSend, 12, 0, 80, 20);   //一般为从左往右按钮个数乘以2
            ///（4）、绑定按钮事件
            btnBatchSelectSend.Click += new EventHandler(btnBatchSelectSend_Click);
            #endregion

        }

        private void btnBatchSelectSend_Click(object sender, EventArgs e)
        {
            _strongPart.OnDataCollect(_strongPart);
            var selectRecord = _strongPart.Model.MiscShipment.Cache.GetSelectRecord();
            if (selectRecord == null) return;
            ShipmentDistributeBPProxy proxy = new ShipmentDistributeBPProxy();
            proxy.IDList = new List<long>();
            foreach (var item in selectRecord)
            {
                proxy.IDList.Add(long.Parse(item["ID"].ToString()));
            }
            proxy.Do();
        }
    }
}
