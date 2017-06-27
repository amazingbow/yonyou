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
using UFIDA.U9.Cust.XMJLBomOpBP.Proxy;
using UFIDA.U9.UI.PDHelper;
using System.Collections.Generic;
using System.Text.RegularExpressions;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.XMJL.Qry.XMJLBOMBListUIModel
{
    public partial class XMJLBOMBListUIFormWebPart
    {
        #region Custome eventBind


        //BtnOutPut_Click...
        private void BtnOutPut_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnOutPut_Click_DefaultImpl(sender, e);
        }

        //BtnPrint_Click...
        private void BtnPrint_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnPrint_Click_DefaultImpl(sender, e);
        }




        //DDLCase_TextChanged...
        private void DDLCase_TextChanged_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            DDLCase_TextChanged_DefaultImpl(sender, e);
        }

        //OnLookCase_Click...
        private void OnLookCase_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            OnLookCase_Click_DefaultImpl(sender, e);
        }


        /// <summary>
        /// 点击批量修改存储地点按钮弹出对话框，选择修改后的存储地点，点击确定，执行修改；
        ///批量修改的范围为通过查询方案过滤出来的数据；没过滤出来的数据不修改；
        ///2016年6月24日09:45:33 李杨
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnChangeWH_Click_Extend(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.DDLWareHouse.SelectedValue))
            {
                throw new Exception("请选择仓库号");
            }
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            var whId = long.Parse(this.DDLWareHouse.SelectedValue);
            UpdateBomWhBPProxy proxy = new UpdateBomWhBPProxy();
            string tempPath = this.Model.Cust_Xmjl_MO_BomMain.CurrentFilter.OPath;
            //this.Model.Cust_Xmjl_MO_BomMain.Cache.
            foreach (var item in this.Model.Cust_Xmjl_MO_BomMain.CurrentFilter.Parameters)
            {
                if (item.DataType != DbType.Decimal && item.DataType != DbType.Double && item.DataType != DbType.Int64)
                {
                    tempPath = tempPath.Replace("@" + item.Name, "'" + item.DataValue.ToString() + "'");
                }
                else
                {
                    tempPath = tempPath.Replace("@" + item.Name, item.DataValue.ToString());
                }
            }
            proxy.OPath = tempPath;
            proxy.WareHouse = whId;
            var result = proxy.Do();
            UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('" + result.Msg + "');", true);
            this.Action.NavigateAction.Refresh(null, true);
            BtnChangeWH_Click_DefaultImpl(sender, e);
        }
        private void BtnResetWH_Click_Extend(object sender, EventArgs e)
        {
            ResetBomWhBPProxy proxy = new ResetBomWhBPProxy();
            string tempPath = this.Model.Cust_Xmjl_MO_BomMain.CurrentFilter.OPath;
            //this.Model.Cust_Xmjl_MO_BomMain.Cache.
            foreach (var item in this.Model.Cust_Xmjl_MO_BomMain.CurrentFilter.Parameters)
            {
                if (item.DataType != DbType.Decimal && item.DataType != DbType.Double && item.DataType != DbType.Int64)
                {
                    tempPath = tempPath.Replace("@" + item.Name, "'" + item.DataValue.ToString() + "'");
                }
                else
                {
                    tempPath = tempPath.Replace("@" + item.Name, item.DataValue.ToString());
                }
            }
            proxy.OPath = tempPath;
            var result = proxy.Do();
            UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('" + result.Msg + "');", true);
            this.Action.NavigateAction.Refresh(null, true);
            BtnChangeWH_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 只针对发料数量为负数的行更新供应商字段；
        /// 通过改行的料号到库存在手量表中查找对应料号所对应的供应商的编码，更新到发料单行的供应商字段；
        /// 2016年6月24日09:46:08 李杨
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdateSup_Click_Extend(object sender, EventArgs e)
        {
            //UFGrid itemGrid = this.DataGrid1 as UFGrid;
            //var data = itemGrid.DataSource as DataTable;
            //List<string> headId = new List<string>();
            //foreach (DataRow item in data.Rows)
            //{
            //    var disQty = Decimal.Parse(item["Cust_Xmjl_MO_BomHead_DisbursedQty"].ToString());
            //    if (disQty < 0)
            //    {
            //        headId.Add(item["ID"].ToString());
            //    }
            //}
            UpdateBomSupBPProxy proxy = new UpdateBomSupBPProxy();

            string tempPath = this.Model.Cust_Xmjl_MO_BomMain.CurrentFilter.OPath;
            foreach (var item in this.Model.Cust_Xmjl_MO_BomMain.CurrentFilter.Parameters)
            {
                if (item.DataType == DbType.String)
                {
                    if (item.DataValue.ToString().Contains("<NewDataSet>"))
                    {
                        tempPath = tempPath.Replace("@" + item.Name, ProcessXML(item.DataValue.ToString()));
                    }
                    else
                    {
                        tempPath = tempPath.Replace("@" + item.Name, item.DataValue.ToString());
                    }
                }
                else if (item.DataType != DbType.Decimal && item.DataType != DbType.Double && item.DataType != DbType.Int64)
                {
                    tempPath = tempPath.Replace("@" + item.Name, "'" + item.DataValue.ToString() + "'");
                }
                else
                {
                    tempPath = tempPath.Replace("@" + item.Name, item.DataValue.ToString());
                }
            }
            proxy.OPath = tempPath;
            var result = proxy.Do();
            UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('" + result.Msg + "');", true);
            this.Action.NavigateAction.Refresh(null, true);
            BtnUpdateSup_Click_DefaultImpl(sender, e);
        }

        private string ProcessXML(string xmlStr)
        {
            string innerData = string.Empty;
            Regex reg = new Regex(@"\<IDT ID=.*?\/>");
            foreach (Match item in reg.Matches(xmlStr))
            {
                innerData += "'" + item.Value.Replace("<IDT ID=", "").Replace("/>", "").Trim(' ').Trim('\"') + "',";
            }
            return innerData.TrimEnd(',');
        }

        //BtnUpdateStat_Click...
        private void BtnUpdateStat_Click_Extend(object sender, EventArgs e)
        {
            this.OnDataCollect(this);
            UpdateBomStatBPProxy proxy = new UpdateBomStatBPProxy();
            string tempPath = "";
            //foreach (var item in this.Model.Cust_Xmjl_MO_BomMain.CurrentFilter.Parameters)
            //{
            //    if (item.DataType != DbType.Decimal && item.DataType != DbType.Double && item.DataType != DbType.Int64)
            //    {
            //        tempPath = tempPath.Replace("@" + item.Name, "'" + item.DataValue.ToString() + "'");
            //    }
            //    else
            //    {
            //        tempPath = tempPath.Replace("@" + item.Name, item.DataValue.ToString());
            //    }
            //}
            var selected = this.Model.Cust_Xmjl_MO_BomMain.Cache.GetSelectRecord();
            if (selected.Count == 0) return;
            foreach (var item in selected)
            {
                tempPath += item["ID"].ToString() + ",";
            }
            proxy.OPath = tempPath.TrimEnd(',');
            var result = proxy.Do();
            UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('" + result.Msg + "');", true);
            this.Action.NavigateAction.Refresh(null, true);
            BtnUpdateStat_Click_DefaultImpl(sender, e);
        }

        /// <summary>
        /// 弹出批量发料界面
        /// 2016年6月28日11:00:08 占炳源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBatchIssue_Click_Extend(object sender, EventArgs e)
        {
            this.ShowAtlasModalDialog(BtnRefresh, "afaf9aeb-b5ab-4967-b806-ac2e45e58871", "发料", "718", "510",
this.TaskId.ToString(), null, true, false, false);
        }

        private void BtnRefresh_Click_Extend(object sender, EventArgs e)
        {

        }


        //DataGrid1_GridRowDbClicked...
        private void DataGrid1_GridRowDbClicked_Extend(object sender, GridDBClickEventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            DataGrid1_GridRowDbClicked_DefaultImpl(sender, e);
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

            AfterOnLoad_Qry_DefaultImpl();//BE列表自动产生的代码
            this.BtnDelete.Visible = false;
            this.BtnBatchIssue.Visible = true;
            if (this.DDLWareHouse.ItemCount > 0) return;
            GetAllWhBPProxy proxy = new GetAllWhBPProxy();
            proxy.Org = long.Parse(PDContext.Current.OrgID);
            var data = proxy.Do();
            data.ForEach(item =>
            {
                if (item.Code != "20")
                {
                    this.DDLWareHouse.AddItem(item.Name, item.ID.ToString());
                }
            });
            var count = (this.DataGrid1 as UFGrid).TotalRows;
            PDFormMessage.ShowConfirmDialog(this.Page, "是否确认删除当前所选择的数据？", "", this.BtnUpdateStat);
        }

        public void AfterCreateChildControls()
        {
            AfterCreateChildControls_Qry_DefaultImpl();//BE列表自动产生的代码
        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {

        }

        public void AfterUIModelBinding()
        {

            AfterUIModelBinding_Qry_DefaultImpl();//BE列表自动产生的代码


        }


        #endregion

        #endregion

    }
}