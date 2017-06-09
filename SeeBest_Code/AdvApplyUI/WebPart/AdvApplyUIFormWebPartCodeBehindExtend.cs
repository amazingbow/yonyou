﻿using System;
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
using UFIDA.U9.Cust.AdvApplyListBP.AdvApplyOp.Proxy;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.AdvApplyUI.AdvApplyUIModel
{
    public partial class AdvApplyUIFormWebPart
    {
        #region Custome eventBind

        #region
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

        //BtnAttachment_Click...
        private void BtnAttachment_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnAttachment_Click_DefaultImpl(sender, e);
        }

        //BtnFlow_Click...
        private void BtnFlow_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnFlow_Click_DefaultImpl(sender, e);
        }

        //BtnOutput_Click...
        private void BtnOutput_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnOutput_Click_DefaultImpl(sender, e);
        }

        //BtnPrint_Click...
        private void BtnPrint_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnPrint_Click_DefaultImpl(sender, e);
        }

        #endregion
        private void BMWidth146_TextChanged_Extend(object sender, EventArgs e)
        {
            this.Model.AdvApplyBE.FocusedRecord.BMArea = this.Model.AdvApplyBE.FocusedRecord.BMWidth * this.Model.AdvApplyBE.FocusedRecord.BMHight;
        }
        private void BMHight124_TextChanged_Extend(object sender, EventArgs e)
        {
            this.Model.AdvApplyBE.FocusedRecord.BMArea = this.Model.AdvApplyBE.FocusedRecord.BMWidth * this.Model.AdvApplyBE.FocusedRecord.BMHight;
        }
        private void Qty693_TextChanged_Extend(object sender, EventArgs e)
        {
            this.Model.AdvApplyBE.FocusedRecord.TotalArea = this.Model.AdvApplyBE.FocusedRecord.BMArea * this.Model.AdvApplyBE.FocusedRecord.Qty;
        }
        private void BMArea187_TextChanged_Extend(object sender, EventArgs e)
        {
            this.Model.AdvApplyBE.FocusedRecord.TotalArea = this.Model.AdvApplyBE.FocusedRecord.BMArea * this.Model.AdvApplyBE.FocusedRecord.Qty;
        }
        private void DZWidth187_TextChanged_Extend(object sender, EventArgs e)
        {
            this.Model.AdvApplyBE.FocusedRecord.DZArea = this.Model.AdvApplyBE.FocusedRecord.DZThick * this.Model.AdvApplyBE.FocusedRecord.DZWidth;
        }
        private void DZThick224_TextChanged_Extend(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
            if (this.Model.AdvApplyBE_AdvAboutBE.RecordCount == 0)
            {
                GetValueSetInfoProxy proxy = new GetValueSetInfoProxy();
                proxy.ValueCode = "Z106";
                var data = proxy.Do();
                foreach (var item in data)
                {
                    var newRecord = this.Model.AdvApplyBE_AdvAboutBE.AddNewUIRecord();
                    newRecord.Code = item.Code;
                    newRecord.Name = item.Name;
                    newRecord.Description = item.Description;
                    newRecord.IsSelected = false;
                }
            }
        }

        public void AfterCreateChildControls()
        {



        }

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