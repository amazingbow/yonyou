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
using UFIDA.U9.UI.PDHelper;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.Association.Adapter;
using UFSoft.UBF.UI.FormProcess;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace BOMUIModel
{
    public partial class BOMUIFormWebPart
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

        //BtnSubmit_Click...
        private void BtnSubmit_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnSubmit_Click_DefaultImpl(sender, e);
        }

        //BtnApprove_Click...
        private void BtnApprove_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnApprove_Click_DefaultImpl(sender, e);
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
            this.NavigatePage("Cust.XMJL.MO.BomListURL", null);

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

        //BtnPrint_Click...
        private void BtnPrint_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnPrint_Click_DefaultImpl(sender, e);
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
            //弹性域
            FlexFieldHelper.SetDescFlexField(
                            new DescFlexFieldParameter[] { new DescFlexFieldParameter(this.FlexFieldPicker0, this.Model.Cust_Xmjl_MO_BomMain) });
            FlexFieldHelper.SetDescFlexField(new DescFlexFieldParameter[] { 
                new DescFlexFieldParameter(this.DataGrid8, this.DataGrid8.Columns.Count - 1, "DescFlexField") });
            //开启个性化
            UFIDA.U9.UI.PDHelper.PersonalizationHelper.SetPersonalizationEnable((BaseWebForm)this, true);
            string paramWhere = null;
            PDFormMessage.ShowConfirmDialog(this.Page, "2b52251e-a16c-479a-b899-d52be784a92f", "580", "408",
                Title, wpFindID.ClientID, this.BtnFind, paramWhere);
            this.Status192.Enabled = false;
            //this.DataGrid8.Columns["Status"].Enabled = false;
            if (PDContext.Current.UserCode != "admin")
            {
                this.BtnDelete.Enabled = false;
            }
            //取得提示信息资源：是否删除当前记录
            string message = PDResource.GetDeleteConfirmInfo();
            //绑定注册弹出对话框到删除按钮
            PDFormMessage.ShowConfirmDialog(this.Page, message, "", this.BtnDelete);
            PDFormMessage.ShowConfirmDialog(this.Page, "确认放弃当前记录？", "", this.BtnCancel);
        }

        public void AfterCreateChildControls()
        {

            //注册callback事件，调BP获取料品单价
            // RegisterGridCellDataChangedCallBack();
            UFIDA.U9.UI.PDHelper.PersonalizationHelper.SetPersonalizationEnable(this, true);
        }

        #region 回调注册\处理专区
        /// <summary>
        /// 注册表格单元格内容改变的回调事件
        /// </summary>
        private void RegisterGridCellDataChangedCallBack()
        {
            AssociationControl gridRowChangedASC = new AssociationControl();       //基本固定代码
            gridRowChangedASC.SourceServerControl = this.DataGrid8;
            gridRowChangedASC.SourceControl.EventName = "OnRowChanged";


            //CallBack处理方案
            //((IUFClientAssoGrid)gridCellDataChangedASC.SourceControl).FireEventCols.Add("Item");
            ClientCallBackFrm gridRowChangedCBF = new ClientCallBackFrm();
            gridRowChangedCBF.ParameterControls.Add(this.DataGrid8);

            gridRowChangedCBF.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(gridRowChangedCBF_DoCustomerActionOfSubvillage);
            gridRowChangedCBF.Add(gridRowChangedASC);
            this.Controls.Add(gridRowChangedCBF);

        }

        /// <summary>
        /// 表格的CallBack处理方式
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private object gridRowChangedCBF_DoCustomerActionOfSubvillage(CustomerActionEventArgs args)
        {
            UFWebClientGridAdapter grid = new UFWebClientGridAdapter(this.DataGrid8);

            //取表格数据（当前行）
            ArrayList list = (ArrayList)args.ArgsHash[UFWebClientGridAdapter.ALL_GRIDDATA_SelectedRows]; //基本固定代码
            int curIndex = int.Parse(list[0].ToString());
            Hashtable table = (Hashtable)((ArrayList)args.ArgsHash[this.DataGrid8.ClientID])[curIndex];
            //long ItemID = long.Parse(table["Item"].ToString());
            //if (ItemID > 0)
            //{
            //    FuelPriceDTOData fuelPriceDTOData = new FuelPriceDTOData();
            //    GetFuelPriceProxy getFuelPriceProxy = new GetFuelPriceProxy();
            //    getFuelPriceProxy.FuelID = ItemID;
            //    getFuelPriceProxy.OrgID = long.Parse(PDContext.Current.OrgID);
            //    fuelPriceDTOData = getFuelPriceProxy.Do();
            //    //单价
            //     grid.CellValue.Add(new object[] { curIndex, "UnitPrice", new string[] { fuelPriceDTOData.FuelPrice.ToString(), fuelPriceDTOData.FuelPrice.ToString(), fuelPriceDTOData.FuelPrice.ToString() } });
            //         args.ArgsResult.Add(grid.ClientInstanceWithValue);
            //   ..........(略)
            //             }
            return args;
        }
        #endregion

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