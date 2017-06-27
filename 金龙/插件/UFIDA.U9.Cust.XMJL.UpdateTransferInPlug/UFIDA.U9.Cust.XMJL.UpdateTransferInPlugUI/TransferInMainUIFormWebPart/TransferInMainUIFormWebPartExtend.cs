

namespace UFIDA.U9.Cust.XMJL.UpdateTransferInPlugUI
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
    using UFSoft.UBF.Util.DataAccess;
    using System.Data;


    public partial class TransferInMainUIFormWebPart
    {

        #region 字段与属性

        private UFIDA.U9.SCM.INV.TransferInUIModel.TransferInMainUIFormWebPart _strongPart;

        #endregion


        private void Do_AfterLoad(UFSoft.UBF.UI.IView.IPart part, EventArgs args)
        {
            #region 获取相关强类型数据

            _strongPart = part as UFIDA.U9.SCM.INV.TransferInUIModel.TransferInMainUIFormWebPart;
            if (_strongPart == null)
                return;
            var wh = _strongPart.FindControl("TransOutWh0") as UFWebReferenceAdapter;
            wh.ContentChanged += new EventHandler(wh_ContentChanged);
            #endregion

        }
        void wh_ContentChanged(object sender, EventArgs e)
        {
            var wh = sender as UFWebReferenceAdapter;
            DataParamList lst = new DataParamList();
            lst.Add(DataParamFactory.CreateInput("@Code", wh.Value, System.Data.DbType.String));
            System.Data.DataSet ds = new System.Data.DataSet();
            DataAccessor.RunSQL(DataAccessor.GetConn(),
                "select A.DescFlexField_PrivateDescSeg1,A.DescFlexField_PrivateDescSeg2 from CBO_Wh A  where A.Code=@Code", lst, out ds);
            if (ds != null && ds.Tables.Count > 0)
            {
                System.Data.DataTable dataTable = ds.Tables[0];
                DataRow item = dataTable.Rows[0];
                _strongPart.Model.TransferIn.FocusedRecord.DescFlexField_PrivateDescSeg2=item[0].ToString();
            }

        }

        private void Do_AfterInit(UFSoft.UBF.UI.IView.IPart part, EventArgs args)
        {
            #region 获取相关强类型数据

            _strongPart = part as UFIDA.U9.SCM.INV.TransferInUIModel.TransferInMainUIFormWebPart;
            if (_strongPart == null)
                return;
            #endregion

        }
    }
}
