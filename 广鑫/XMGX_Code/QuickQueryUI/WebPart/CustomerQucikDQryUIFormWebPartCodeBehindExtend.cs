using System;
using System.Data;
using UFIDA.U9.UI.PDHelper;
using UFIDA.UBF.Query.CommonService;
using UFSoft.UBF.Exceptions;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI.IView;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.WebControls;

/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/

namespace UFIDA.U9.Cust.FJGX.CustomerQucikDQryUIModel
{
    public partial class CustomerQucikDQryUIFormWebPart
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

        //TabControl0_SelectedIndexChanged...
        private void TabControl0_SelectedIndexChanged_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            TabControl0_SelectedIndexChanged_DefaultImpl(sender, e);
            if (this.TabControl0.SelectedIndex != 1) return;
            CustomerDetailViewRecord detailViewRecord = this.Model.CustomerDetailView.FocusedRecord ?? this.Model.CustomerDetailView.AddNewUIRecord();
            if (this.Model.QueryView.FocusedRecord != null)
            {
                QueryViewRecord queryViewRecord = this.Model.QueryView.FocusedRecord;
                detailViewRecord.ID = queryViewRecord.ID;
                detailViewRecord.Name = queryViewRecord["Customer_Name"].ToString();
            }
            else
            {
                detailViewRecord.ID = -1;
                detailViewRecord.Name = string.Empty;
            }
            this.Model.CustomerDetailView.FocusedRecord = detailViewRecord;
        }

        //DataGrid1_GridRowDbClicked...
        private void DataGrid1_GridRowDbClicked_Extend(object sender, GridDBClickEventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.IsProviding = true;
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
            
        }

        public void AfterCreateChildControls()
        {
            //AfterCreateChildControls_Qry_DefaultImpl(); //DTO查询自动产生的代码
            QryService.GridBindView(this.DataGrid1, "QueryView");
            AttachMakePageEvent();
        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {
            BeforeUIModelBinding_Qry_DefaultImpl(); //DTO查询自动产生的代码
        }

        public void AfterUIModelBinding()
        {
            AfterUIModelBinding_Qry_DefaultImpl(); //DTO查询自动产生的代码
        }

        #endregion

        #region 其它

        /// <summary>
        ///     执行数据收集
        /// </summary>
        /// <param name="part"></param>
        public static void DoDataCollect(IPart part)
        {
            if (part == null) return;
            BaseWebForm baseWebForm = part as BaseWebForm;
            if (baseWebForm != null) baseWebForm.OnDataCollect(part); //当前事件先执行数据收集		    
            part.IsDataBinding = true; //当前事件执行后会进行数据绑定
            part.IsConsuming = false;
        }

        #endregion

        #endregion
    }
}