

namespace UFIDA.U9.Cust.XMJL.PlugProject.UI
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
    using System.Web;


    public partial class SCMItemRefPlug
    {

        #region 字段与属性

        private UFIDA.U9.Base.FlexField.KeyFlexFieldCtrlRefUIModel.KeyFlexFieldCtrlRefUIFormWebPart _strongPart;

        #endregion

        private void Do_AfterLoad(UFSoft.UBF.UI.IView.IPart part, EventArgs args)
        {
            #region 获取相关强类型数据

            _strongPart = part as UFIDA.U9.Base.FlexField.KeyFlexFieldCtrlRefUIModel.KeyFlexFieldCtrlRefUIFormWebPart;
            if (_strongPart == null)
                return;
            string strRefType = HttpContext.Current.Request.QueryString["ValueByClick"];
            if (!string.IsNullOrEmpty(strRefType))
            {
                _strongPart.Model.KeyFlexFieldCtrl.FocusedRecord.Code = strRefType;
                (_strongPart.FindControl("Code") as UFWebTextBoxAdapter).Text = strRefType;
                (_strongPart.FindControl("Code") as UFWebTextBoxAdapter).Value = strRefType;
                (_strongPart.FindControl("DataGrid") as IUFDataGrid).IsMultiSelect = true;
            }
            _strongPart.FindButton_Click(part, args);
            //string strRefType = HttpContext.Current.Request.QueryString["RefType"];                                                                                  
            #endregion

        }
    }
}
