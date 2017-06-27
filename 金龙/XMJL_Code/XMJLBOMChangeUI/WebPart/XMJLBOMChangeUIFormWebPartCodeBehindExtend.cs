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
using System.Text.RegularExpressions;
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
using UFIDA.U9.UI.PDHelper;
using UFSoft.UBF.UI.WebControls.Association.Adapter;
using UFSoft.UBF.UI.WebControls.Association;
using UFIDA.U9.Cust.XMJL.XMJLBomChangeBP.Proxy;
using System.Collections.Generic;
using UFIDA.U9.Cust.XMJL.XMJLBomChangeBP;


/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.XMJL.XMJLBOMChangeUIModel
{
    public partial class XMJLBOMChangeUIFormWebPart
    {
        #region Custome eventBind


        //BtnSave_Click...
        private void BtnSave_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnSave_Click_DefaultImpl(sender, e);
        }

        //BtnCancel_Click...
        private void BtnCancel_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnCancel_Click_DefaultImpl(sender, e);
        }

        //BtnAdd_Click...
        private void BtnAdd_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnAdd_Click_DefaultImpl(sender, e);
        }

        //BtnDelete_Click...
        private void BtnDelete_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnDelete_Click_DefaultImpl(sender, e);
        }

        //BtnCopy_Click...
        private void BtnCopy_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnCopy_Click_DefaultImpl(sender, e);
        }

        //BtnFind_Click...
        private void BtnFind_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnFind_Click_DefaultImpl(sender, e);
        }

        //BtnList_Click...
        private void BtnList_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnList_Click_DefaultImpl(sender, e);
        }

        //BtnFirstPage_Click...
        private void BtnFirstPage_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnFirstPage_Click_DefaultImpl(sender, e);
        }

        //BtnPrevPage_Click...
        private void BtnPrevPage_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnPrevPage_Click_DefaultImpl(sender, e);
        }

        //BtnNextPage_Click...
        private void BtnNextPage_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnNextPage_Click_DefaultImpl(sender, e);
        }

        //BtnLastPage_Click...
        private void BtnLastPage_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnLastPage_Click_DefaultImpl(sender, e);
        }

        //BtnOk_Click...
        private void BtnOk_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            ChangeBomBPProxy proxy = new ChangeBomBPProxy();
            proxy.BomChangeIdList = new List<string>();
            proxy.BomChangeIdList.Add(this.Model.Cust_Xmjl_MO_BomChange.FocusedRecord.ID.ToString());
            var result = proxy.Do();
            if (string.IsNullOrEmpty(result))
            {
                UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('更新成功！');", true);
            }
            else
            {
                UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('" + result + "');", true);
            }
            this.Action.NavigateAction.Refresh(null, true);
            //foreach (var item in this.Model)
            //{
            //    BomChangeItemDTOData data = new BomChangeItemDTOData();
            //    data.DistQty=item.
            //    bomChange.BomChangeItem.Add(data);
            //}
            //BtnOk_Click_DefaultImpl(sender, e);
        }

        //BtnClose_Click...
        private void BtnClose_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnClose_Click_DefaultImpl(sender, e);
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
            //查询按钮设置
            string paramWhere = null;
            PDFormMessage.ShowConfirmDialog(this.Page, "5793f6a2-1489-4b7e-bae0-81634a59f09a", "580", "408",
                Title, wpFindID.ClientID, this.BtnFind, paramWhere);
            //弹性域设置
            FlexFieldHelper.SetDescFlexField(
                new DescFlexFieldParameter[] { new DescFlexFieldParameter(this.FlexFieldPicker0, this.Model.Cust_Xmjl_MO_BomChange) });
            //取得提示信息资源：是否删除当前记录
            string message = PDResource.GetDeleteConfirmInfo();
            //绑定注册弹出对话框到删除按钮
            PDFormMessage.ShowConfirmDialog(this.Page, message, "", this.BtnDelete);
            PDFormMessage.ShowConfirmDialog(this.Page, "确认放弃当前记录？", "", this.BtnCancel);
            this.ChangeReason233.AutoPostBack = false;
        }
        #region CallBack Register && 实现
        private void RegisterGridCellDataChangedCallBack()
        {
            #region 车号Grid
            AssociationControl gridCellDataChangedCar = new AssociationControl();       //基本固定代码
            gridCellDataChangedCar.SourceServerControl = this.DataGrid7;
            gridCellDataChangedCar.SourceControl.EventName = "OnCellDataValueChanged";
            //CallBack处理方案
            ((IUFClientAssoGrid)gridCellDataChangedCar.SourceControl).FireEventCols.Add("ManufactureNO");
            CodeBlock cb1 = new CodeBlock();
            UFWebClientGridAdapter grid7Adapter = new UFWebClientGridAdapter(this.DataGrid7);
            grid7Adapter.IsPostBack = true;
            grid7Adapter.PostBackTag = "OnCellDataValueChanged";
            cb1.TargetControls.addControl(grid7Adapter);
            gridCellDataChangedCar.addBlock(cb1);
            UFGrid itemGrid7 = this.DataGrid7 as UFGrid;
            itemGrid7.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(GridCellOnChanged_DoCustomerAction_Grid7);

            #endregion
            #region 料号Grid
            //AssociationControl gridCellDataChangedItem = new AssociationControl();       //基本固定代码
            //gridCellDataChangedItem.SourceServerControl = this.DataGrid9;
            //gridCellDataChangedItem.SourceControl.EventName = "OnCellDataChanged";
            ////CallBack处理方案
            //((IUFClientAssoGrid)gridCellDataChangedItem.SourceControl).FireEventCols.Add("Item");
            //ClientCallBackFrm gridCellDataChangedItemCBF = new ClientCallBackFrm();
            //gridCellDataChangedItemCBF.ParameterControls.Add(this.DataGrid7);
            //gridCellDataChangedItemCBF.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(gridCellDataChangedItemCBF_DoCustomerActionOfSubvillage);
            //gridCellDataChangedItemCBF.Add(gridCellDataChangedItem);
            #endregion

            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = this.DataGrid9;
            assocControl.SourceControl.EventName = "OnCellDataValueChanged";
            ((IUFClientAssoGrid)assocControl.SourceControl).FireEventCols.Add("Item");
            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid9);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "OnCellDataValueChanged";
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);
            UFGrid itemGrid = this.DataGrid9 as UFGrid;
            itemGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(GridCellOnChanged_DoCustomerAction_Grid9);

            //this.Controls.Add(gridCellDataChangedItemCBF);
        }
        /// <summary>
        /// 表格的CallBack处理方式
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private object gridCellDataChangedCarCBF_DoCustomerActionOfSubvillage(CustomerActionEventArgs args)
        {
            UFWebClientGridAdapter grid = new UFWebClientGridAdapter(this.DataGrid7);

            //取表格数据（当前行）
            // 2016年5月13日21:51:48 args参数把页面上所有的gridview信息都传递过来
            //然后把这些信息取到hashtable 里面
            //获取界面值
            ArrayList list = (ArrayList)args.ArgsHash[UFWebClientGridAdapter.ALL_GRIDDATA_SelectedRows]; //基本固定代码
            int curIndex = int.Parse(list[0].ToString());
            Hashtable table = (Hashtable)((ArrayList)args.ArgsHash[this.DataGrid7.ClientID])[curIndex];
            long qty = long.Parse(table["ManufactureNO"].ToString());
            //2016年5月13日22:00:20 运行逻辑代码
            //2016年5月13日22:00:28 运行完以后界面赋值

            grid.CellValue.Add(new object[] { curIndex, "ContractNo", new string[] { "1", "1", "1" } });
            grid.CellValue.Add(new object[] { curIndex, "CarType", new string[] { "1", "1", "1" } });
            //执行结果添加到返回值中，return出去以后会更新Model
            args.ArgsResult.Add(grid.ClientInstanceWithValue);

            return args;
        }
        private void GridCellOnChanged_DoCustomerAction_Grid7(object sender, GridCustomerPostBackEventArgs e)
        {
            //取到当前列的引用选择的数据
            string itemData = e.ParamNameValues["u$M$p0$DataGrid7$ManufactureNO$Hidden"].ToString();
            if (string.IsNullOrEmpty(itemData)) return;
            var listItem = itemData.Split(new string[] { "__&URS1&_" }, StringSplitOptions.RemoveEmptyEntries);
            var codeList = listItem[1].Split(',');
            GetBomInfoByCarNoBPProxy proxy = new GetBomInfoByCarNoBPProxy();
            List<string> list = new List<string>();
            foreach (var item in codeList)
            {
                list.Add(item);
            }
            proxy.CarIdList = list;
            List<XMJLBomChangeBP.BomInfoDTOData> bomList = proxy.Do();
            if (bomList == null || bomList.Count == 0)
            {
                throw new Exception("没有对应车号，请核查");
            }
            foreach (var item in bomList)
            {
                Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNoRecord rd =
                  this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.AddNewUIRecord();
                rd.ManufactureNO = item.CarNoId;
                rd.ManufactureNO_Code = item.CarNoCode;
                rd.ManufactureNO_Name = item.CarNoCode;
                rd.ContractNo = item.ContractNo;
                rd.CarType = item.CarType;
                rd.SetParentRecord(this.Model.Cust_Xmjl_MO_BomChange.FocusedRecord);
                DataGrid7.CollectData();
                DataGrid7.BindData();
            }
            //删除当前关注的列
            if (this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FocusedRecord != null)
            {
                this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeManufactureNo.FocusedRecord.Remove();
            }
            this.Model.Cust_Xmjl_MO_BomChange.FocusedRecord.ChangeReason = this.ChangeReason233.Text;
        }
        private void GridCellOnChanged_DoCustomerAction_Grid9(object sender, GridCustomerPostBackEventArgs e)
        {

            //取到当前列的引用选择的数据
            //1001606300006433__&URS1&_5031XJH-RB,5031XGC,5031XXY3,5031XXY28-4YJ-G__&URS1&_5031XJH-RB,5031XGC,5031XXY3,5031XXY28-4YJ-G
            string itemData = e.ParamNameValues["u$M$p0$DataGrid9$Item$Hidden"].ToString();
            /*
             %3CReferenceReturns%3E%3CReferenceReturns%3E%3CReferenceReturn%3E%3CReturnField%20name%3D%22ID%22%20value%3D%22
             * 1001606300006433%22%20%2F%3E%3CReturnField%20name%3D%22Code%22%20value%3D%225031XJH-RB%2C5031XGC%2C
             * 5031XXY3%2C5031XXY28-4YJ-G%22%20%2F%3E%3CReturnField%20name%3D%22Name%22%20value%3D%225031XJH-RB%2C5031XGC
             * %2C5031XXY3%2C5031XXY28-4YJ-G%22%20%2F%3E%3CReturnField%20name%3D%22Description%22%20value%3D%221001606300006406
             * %2C1001606300006407%2C1001606300006429%2C1001606300006433%22%20%2F%3E%3C%2FReferenceReturn%3E%3C%2FReferenceReturns
             * %3E%3C%2FReferenceReturns%3E*/
            string returnStr = e.ParamNameValues["u$M$p0$DataGrid9$Item$ReturnHidden"].ToString();
            //Regex reg = new Regex("%22[[0-9]+%2C]*[0-9]*%22");
            //var match = reg.Match(returnStr);
            //string value = match.Groups[1].Value;
            GetItemMainSupBPProxy proxy = new GetItemMainSupBPProxy();
            proxy.ItemIds = new List<long>();

            if (string.IsNullOrEmpty(itemData)) return;
            var listItem = itemData.Split(new string[] { "__&URS1&_" }, StringSplitOptions.RemoveEmptyEntries);
            string lastId = listItem[0];
            var strList = returnStr.Split(new string[] { "%22" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in strList)
            {
                if (item.Contains(lastId))
                {
                    var ids = item.Split(new string[] { "%2C" }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var id in ids)
                    {
                        if (id == lastId) continue;
                        proxy.ItemIds.Add(long.Parse(id));
                    }
                }
            }
            proxy.ItemIds.Add(long.Parse(lastId));
            var codeList = listItem[1].Split(',');
            var nameList = listItem[2].Split(',');

            var data = proxy.Do();
            for (int i = 0; i < proxy.ItemIds.Count; i++)
            {
                Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemRecord rd =
                    this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.AddNewUIRecord();
                rd.Item = proxy.ItemIds[i];
                rd.Item_Code = codeList[i];
                rd.Item_Name = nameList[i];
                if (data != null)
                {
                    var sup = data.Find(ii => ii.ItemId == rd.Item);
                    if (sup != null)
                    {
                        rd.Supplier = sup.Supply;
                        rd.Supplier_Code = sup.SupplyCode;
                        rd.Supplier_Name = sup.SupplyName;
                    }
                }
                rd.SetParentRecord(this.Model.Cust_Xmjl_MO_BomChange.FocusedRecord);
                DataGrid9.CollectData();
                DataGrid9.BindData();
            }
            //删除当前关注的列
            if (this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FocusedRecord != null)
            {
                this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.FocusedRecord.Remove();
            }
            this.Model.Cust_Xmjl_MO_BomChange.FocusedRecord.ChangeReason = this.ChangeReason233.Text;
            ////检验参照返回缓冲数据是否为空
            //if (this.CurrentState["ItemInfo"] == null)
            //{
            //    this.DataGrid9.CollectData();
            //    this.DataGrid9.BindData();
            //    return;
            //}
            //DataTable dt = this.CurrentState["ItemInfo"] as DataTable;
            //CurrentState.Remove("ItemInfo");
            ////校验DT是否为空
            //if (dt == null || dt.Rows.Count < 1)
            //{
            //    this.DataGrid9.CollectData(); this.DataGrid9.BindData(); return;
            //}
            ////获取最后的行号
            //int rowNo = 10;
            //int recordsCount = this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.RecordCount;
            //if (recordsCount != 0)
            //{
            //    rowNo = Convert.ToInt32(this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.Records[recordsCount - 1]["RowNO"]);
            //}
            ////若只返回一条，做数据收集即可 
            //if (dt.Rows.Count == 1)
            //{
            //    DataGrid9.CollectData();
            //    DataGrid9.BindData();
            //}
            ////循环传回来的表体,
            ////当多选参照界面点击确定返回时,Model默认添加了第一条记录,故不做处理
            //for (int i = 1; i < dt.Rows.Count; i++)
            //{
            //    Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItemRecord rd =
            //        this.Model.Cust_Xmjl_MO_BomChange_Cust_Xmjl_MO_BomChangeItem.AddNewUIRecord();
            //    rd.Item = !string.IsNullOrEmpty(dt.Rows[i]["ItemID"].ToString()) ? long.Parse(dt.Rows[i]["ItemID"].ToString()) : 0;
            //    rd.Item_Code = dt.Rows[i]["ItemCode"].ToString();
            //    rd.Item_Name = dt.Rows[i]["ItemName"].ToString();
            //    rd.SetParentRecord(this.Model.Cust_Xmjl_MO_BomChange.FocusedRecord);
            //    DataGrid9.CollectData();
            //    DataGrid9.BindData();
            //}
            //this.DataCollect();
            //this.DataBind();
        }
        #endregion
        public void AfterCreateChildControls()
        {
            RegisterGridCellDataChangedCallBack();
        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {

        }

        public void AfterUIModelBinding()
        {
            if (this.Model.Cust_Xmjl_MO_BomChange.FocusedRecord.ChangeStat.Value)
            {
                this.BtnSave.Enabled = false;
                this.BtnCancel.Enabled = false;
                this.BtnDelete.Enabled = false;
                this.BtnSave.Enabled = false;
                this.BtnSave.Enabled = false;
                this.DataGrid7.EditStatus = UFSoft.UBF.UI.ControlModel.EditStatus.Browse;
                this.DataGrid9.EditStatus = UFSoft.UBF.UI.ControlModel.EditStatus.Browse;
            }
            else
            {
                this.DataGrid7.EditStatus = UFSoft.UBF.UI.ControlModel.EditStatus.Edit;
                this.DataGrid9.EditStatus = UFSoft.UBF.UI.ControlModel.EditStatus.Edit;
            }
        }


        #endregion

        #endregion
    }
}