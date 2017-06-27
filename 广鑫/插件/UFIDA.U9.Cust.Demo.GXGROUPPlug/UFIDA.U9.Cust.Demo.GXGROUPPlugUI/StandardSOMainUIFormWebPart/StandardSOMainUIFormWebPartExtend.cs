

namespace UFIDA.U9.Cust.Demo.GXGROUPPlugUI
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
    using UFSoft.UBF.UI.WebControls.Association.Adapter;
    using System.Collections;
    using UFSoft.UBF.Util.DataAccess;
    using System.Data;
    using UFSoft.UBF.UI.MD.Runtime;


    public partial class StandardSOMainUIFormWebPart
    {

        #region 字段与属性

        private UFIDA.U9.SCM.SM.SOUIModel.StandardSOMainUIFormWebPart _strongPart;

        #endregion


        private void Do_AfterInit(UFSoft.UBF.UI.IView.IPart part, EventArgs args)
        {
            #region 获取相关强类型数据

            _strongPart = part as UFIDA.U9.SCM.SM.SOUIModel.StandardSOMainUIFormWebPart;
            if (_strongPart == null)
                return;

            #endregion

            RegisterGridCellDataChangedCallBack();
            //Register_DataGrid_Customer_PoskBack();
            //Register_DataGrid_Customer_PoskBack1();
        }
        #region CallBack
        private void RegisterGridCellDataChangedCallBack()
        {
            AssociationControl gridCellDataChangedASC = new AssociationControl();       //基本固定代码
            IUFDataGrid datagrid = _strongPart.FindControl("DataGrid4") as IUFDataGrid;
            gridCellDataChangedASC.SourceServerControl = datagrid;                      //网格控件容器接口
            gridCellDataChangedASC.SourceControl.EventName = "OnCellDataChanged";

            // CallBack处理方案 DescFlexField_PrivateDescSeg9
            ((IUFClientAssoGrid)gridCellDataChangedASC.SourceControl).FireEventCols.Add("DescFlexField_PrivateDescSeg9");
            ((IUFClientAssoGrid)gridCellDataChangedASC.SourceControl).FireEventCols.Add("TU");
            ((IUFClientAssoGrid)gridCellDataChangedASC.SourceControl).FireEventCols.Add("OrderByQtyTU");
            ClientCallBackFrm gridCellDataChangedCBF = new ClientCallBackFrm();
            gridCellDataChangedCBF.ParameterControls.Add(datagrid);

            gridCellDataChangedCBF.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(gridCellDataChangedCBF_DoCustomerActionOfSubvillage);
            gridCellDataChangedCBF.Add(gridCellDataChangedASC);
            _strongPart.Controls.Add(gridCellDataChangedCBF);
        }

        /// <summary>
        // 表格的CallBack处理方式
        /// </summary>
        // <param name="args"></param>
        /// <summary>
        private object gridCellDataChangedCBF_DoCustomerActionOfSubvillage(CustomerActionEventArgs args)
        {

            IUFDataGridContainer datagrid = _strongPart.FindControl("DataGrid4") as IUFDataGrid;
            UFWebClientGridAdapter grid = new UFWebClientGridAdapter(_strongPart.FindControl("DataGrid4") as IUFDataGrid);
            //取表格数据（当前行）
            ArrayList list = (ArrayList)args.ArgsHash[UFWebClientGridAdapter.ALL_GRIDDATA_SelectedRows]; //基本固定代码
            int curIndex = int.Parse(list[0].ToString());
            Hashtable table = (Hashtable)((ArrayList)args.ArgsHash[datagrid.ClientID])[curIndex];
            decimal OrderPriceTC = decimal.Parse(string.IsNullOrEmpty(table["OrderPriceTC"].ToString()) ? "0" : table["OrderPriceTC"].ToString());//定价   
            decimal DiscountRate = decimal.Parse(string.IsNullOrEmpty(table["DescFlexField_PrivateDescSeg9"].ToString()) ? "0" : table["DescFlexField_PrivateDescSeg9"].ToString());
            decimal OrderByQtyTU = decimal.Parse(table["OrderByQtyTU"].ToString());
            string TC = table["TU_Code"].ToString();
            if (DiscountRate != 0)
            {
                if (TC == "L004" || TC == "L005" || TC == "S005")
                {
                    decimal DescFlexField_PrivateDescSeg2 = decimal.Parse(string.IsNullOrEmpty(table["ItemInfo_ItemID_DescFlexField_PrivateDescSeg2"].ToString()) ? "0" : table["ItemInfo_ItemID_DescFlexField_PrivateDescSeg2"].ToString());//米价
                    OrderPriceTC = DescFlexField_PrivateDescSeg2 * DiscountRate;
                }
                else
                {
                    decimal DescFlexField_PrivateDescSeg1 = decimal.Parse(string.IsNullOrEmpty(table["ItemInfo_ItemID_DescFlexField_PrivateDescSeg1"].ToString()) ? "0" : table["ItemInfo_ItemID_DescFlexField_PrivateDescSeg1"].ToString());//批发价
                    OrderPriceTC = DescFlexField_PrivateDescSeg1 * DiscountRate;
                }
                var TotalMoneyTC = decimal.Parse((OrderByQtyTU * OrderPriceTC).ToString("F2"));
                //多选的行 会focused和选中的不一致。
                _strongPart.Model.SO_SOLines.FocusedIndex = curIndex;
                _strongPart.Model.SO_SOLines.FocusedRecord.OrderPriceTC = OrderPriceTC;
                _strongPart.Model.SO_SOLines.FocusedRecord.TotalMoneyTC = TotalMoneyTC;
                _strongPart.Model.SO_SOLines.FocusedRecord.TotalMoneyFC = TotalMoneyTC;
                _strongPart.Model.SO_SOLines.FocusedRecord.TotalMoneyAC = TotalMoneyTC;
                _strongPart.Model.SO_SOLines.FocusedRecord.NetMoneyTC = TotalMoneyTC;
                _strongPart.Model.SO_SOLines.FocusedRecord.NetMoneyFC = TotalMoneyTC;
                _strongPart.Model.SO_SOLines.FocusedRecord.NetMontyAC = TotalMoneyTC;
                _strongPart.Model.SO_SOLines.FocusedRecord.TaxMoneyTC = 0;
                _strongPart.Model.SO_SOLines.FocusedRecord.TaxMoneyFC = 0;
                _strongPart.Model.SO_SOLines.FocusedRecord.TaxMoneyAC = 0;
                _strongPart.Model.SO_SOLines.FocusedRecord.FinallyPriceTC = OrderPriceTC;
                grid.CellValue.Add(new object[] { curIndex, "OrderPriceTC", new string[] { OrderPriceTC.ToString(), OrderPriceTC.ToString(), OrderPriceTC.ToString() } });
                grid.CellValue.Add(new object[] { curIndex, "TotalMoneyTC", new string[] { TotalMoneyTC.ToString(), TotalMoneyTC.ToString(), TotalMoneyTC.ToString() } });
                grid.CellValue.Add(new object[] { curIndex, "NetMoneyTC", new string[] { TotalMoneyTC.ToString(), TotalMoneyTC.ToString(), TotalMoneyTC.ToString() } });
                grid.CellValue.Add(new object[] { curIndex, "FinallyPriceTC", new string[] { OrderPriceTC.ToString(), OrderPriceTC.ToString(), OrderPriceTC.ToString() } });
                args.ArgsResult.Add(grid.ClientInstanceWithValue);
            }
            return args;
        }
        #endregion


    }
}