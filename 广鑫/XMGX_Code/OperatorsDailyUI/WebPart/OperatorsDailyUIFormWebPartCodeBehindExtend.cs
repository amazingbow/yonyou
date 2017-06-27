using System;
/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.WebControls;

namespace UFIDA.U9.Cust.FJGX.OperatorsDailyUIModel
{
    public partial class OperatorsDailyUIFormWebPart
    {
        #region Custome eventBind

        //BtnSave_Click...
        private void BtnSave_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            BtnSave_Click_DefaultImpl(sender, e);
            if (!this.Model.ErrorMessage.hasErrorMessage)
            {
                LoadListViewData();
            }
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
            //BtnAdd_Click_DefaultImpl(sender, e);
            OperatorsDailyRecord record = this.Model.OperatorsDaily.AddNewUIRecord();
            record.DailyDate = DateTime.Now;
            record.Customer = this.CustomerID;
            record.Customer_Code = this.CustomerCode;
            record.Customer_Name = this.CustomerName;
            this.Model.OperatorsDaily.FocusedRecord = record;
        }

        //BtnDelete_Click...
        private void BtnDelete_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            BtnDelete_Click_DefaultImpl(sender, e);
            if (!this.Model.ErrorMessage.hasErrorMessage)
            {
                LoadListViewData();
            }
        }

        //BtnOk_Click...
        private void BtnOk_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            //BtnOk_Click_DefaultImpl(sender, e);
            this.CloseDialog(false);
        }

        //BtnClose_Click...
        private void BtnClose_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            //BtnClose_Click_DefaultImpl(sender, e);
            this.CloseDialog(false);
        }

        private void DataGrid1_GridRowClicked_Extend(object sender, GridCallBackEventArgs e)
        {
            this.DataGrid1_GridRowClicked_DefaultImpl(sender, e);
            if (this.Model.ListView.FocusedRecord == null) return;
            if (this.Model.ListView.FocusedRecord.ID <= 0) return;
            this.Action.NavigateAction.MovePageAt(this.TabPage0, this.Model.ListView.FocusedRecord.ID);
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
            if (!this.Page.IsPostBack)
            {
                //加载列表
                LoadListViewData();
            }
        }

        public void AfterCreateChildControls()
        {
            this.Model.OperatorsDaily.FieldCustomer.DefaultValue = this.CustomerID;
            this.Model.OperatorsDaily.FieldCustomer_Code.DefaultValue = this.CustomerCode;
            this.Model.OperatorsDaily.FieldCustomer_Name.DefaultValue = this.CustomerName;
        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {
        }

        public void AfterUIModelBinding()
        {
            this.BtnOk.IsClientClose = true;
            this.BtnClose.IsClientClose = true;
            OperatorsDailyRecord focusedRecord = this.Model.OperatorsDaily.FocusedRecord;
            if (focusedRecord != null && focusedRecord.ID > 0)
            {
                this.BtnSave.Enabled = false;
                this.BtnAdd.Enabled = true;
                this.BtnCancel.Enabled = false;
                this.BtnDelete.Enabled = true;
                ((IUIFieldBindingDataBindControl)(this.DailyContent127)).ReadOnly = true;
            }
            else
            {
                this.BtnSave.Enabled = true;
                this.BtnAdd.Enabled = false;
                this.BtnCancel.Enabled = true;
                this.BtnDelete.Enabled = false;
                ((IUIFieldBindingDataBindControl)(this.DailyContent127)).ReadOnly = false;
            }
        }

        #endregion

        #region 自定义

        /// <summary>
        /// 客户
        /// </summary>
        private long CustomerID
        {
            get
            {
                return this.CurrentState.ContainsKey("OperatorsDaily_CustomerID")
                    ? long.Parse(this.CurrentState["OperatorsDaily_CustomerID"].ToString())
                    : -1;
            }
        }

        /// <summary>
        /// 客户编码
        /// </summary>
        private string CustomerCode
        {
            get
            {
                return this.CurrentState.ContainsKey("OperatorsDaily_CustomerCode")
                    ? this.CurrentState["OperatorsDaily_CustomerCode"].ToString()
                    : string.Empty;
            }
        }

        /// <summary>
        /// 客户名称
        /// </summary>
        private string CustomerName
        {
            get
            {
                return this.CurrentState.ContainsKey("OperatorsDaily_CustomerName")
                    ? this.CurrentState["OperatorsDaily_CustomerName"].ToString()
                    : string.Empty;
            }
        }

        /// <summary>
        /// 加载列表
        /// </summary>
        private void LoadListViewData()
        {
            this.Model.ListView.Clear();
            OperatorsDailyUIModelModel refreshModel = new OperatorsDailyUIModelModel();
            refreshModel.OperatorsDaily.PageStrategy.IsUsing = false;
            refreshModel.OperatorsDaily.CurrentFilter.OPath = "Customer = " + this.CustomerID;
            refreshModel.OperatorsDaily.CurrentFilter.OrderBy = " DailyDate desc ";
            this.Action.CommonAction.Load(refreshModel);
            foreach (OperatorsDailyRecord record in refreshModel.OperatorsDaily.Records)
            {
                ListViewRecord listViewRecord = this.Model.ListView.AddNewUIRecord();
                listViewRecord.ID = record.ID;
                listViewRecord.CreatedBy = record.CreatedBy;
                listViewRecord.CreatedOn = record.CreatedOn??DateTime.MinValue;
                listViewRecord.ModifiedBy = record.ModifiedBy ;
                listViewRecord.ModifiedOn = record.ModifiedOn ?? DateTime.MinValue;
                listViewRecord.Customer = record.Customer;
                listViewRecord.Customer_Code = record.Customer_Code;
                listViewRecord.Customer_Name = record.Customer_Name;
                listViewRecord.DailyDate = record.DailyDate;
                listViewRecord.DailyContent = record.DailyContent;
            }
        }

        #endregion

        #endregion
    }
}