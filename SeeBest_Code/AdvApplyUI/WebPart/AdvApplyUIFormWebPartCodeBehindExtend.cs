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
using UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApplyBP.Proxy;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.AdvApplyUI.AdvApplyUIModel
{
    public partial class AdvApplyUIFormWebPart
    {
        #region Custome eventBind
        //Qty693_TextChanged...
        private void Qty693_TextChanged_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.Model.AdvApplyBE.FocusedRecord.TotalArea = this.Model.AdvApplyBE.FocusedRecord.BMArea * this.Model.AdvApplyBE.FocusedRecord.Qty;
            Qty693_TextChanged_DefaultImpl(sender, e);
        }
        //BMWidth146_TextChanged...
        private void BMWidth146_TextChanged_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.Model.AdvApplyBE.FocusedRecord.BMArea = this.Model.AdvApplyBE.FocusedRecord.BMWidth * this.Model.AdvApplyBE.FocusedRecord.BMHight;
            BMWidth146_TextChanged_DefaultImpl(sender, e);
        }
        //BMHight124_TextChanged...
        private void BMHight124_TextChanged_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.Model.AdvApplyBE.FocusedRecord.BMArea = this.Model.AdvApplyBE.FocusedRecord.BMWidth * this.Model.AdvApplyBE.FocusedRecord.BMHight;
            BMHight124_TextChanged_DefaultImpl(sender, e);
        }
        //BMArea187_TextChanged...
        private void BMArea187_TextChanged_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.Model.AdvApplyBE.FocusedRecord.TotalArea = this.Model.AdvApplyBE.FocusedRecord.BMArea * this.Model.AdvApplyBE.FocusedRecord.Qty;
            BMArea187_TextChanged_DefaultImpl(sender, e);
        }
        //DZWidth187_TextChanged...
        private void DZWidth187_TextChanged_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.Model.AdvApplyBE.FocusedRecord.DZArea = this.Model.AdvApplyBE.FocusedRecord.DZThick * this.Model.AdvApplyBE.FocusedRecord.DZWidth;
            DZWidth187_TextChanged_DefaultImpl(sender, e);
        }
        //DZThick224_TextChanged...
        private void DZThick224_TextChanged_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.Model.AdvApplyBE.FocusedRecord.DZArea = this.Model.AdvApplyBE.FocusedRecord.DZThick * this.Model.AdvApplyBE.FocusedRecord.DZWidth;
            DZThick224_TextChanged_DefaultImpl(sender, e);
        }

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

        //BtnNew_Click...
        private void BtnNew_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnNew_Click_DefaultImpl(sender, e);
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

            if (this.Model.AdvApplyBE.FocusedRecord.AdvApplyDocType_ApproveType.Value == Convert.ToInt32(UFIDA.U9.Base.Doc.ApproveTypeEnumData.WorkFlow))
            {
                UFIDA.U9.UI.PDHelper.PDPopWebPart.ApproveFlow_ApproveBatchUIWebPart(this);//工作流审批
            }

            BtnApprove_Click_DefaultImpl(sender, e);
        }

        //BtnUndoApprove_Click...
        private void BtnUndoApprove_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnUndoApprove_Click_DefaultImpl(sender, e);
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

        //BtnFlow_Click...
        private void BtnFlow_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnFlow_Click_DefaultImpl(sender, e);
        }

        //BtnPrint_Click...
        private void BtnPrint_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnPrint_Click_DefaultImpl(sender, e);
        }

        //CloseClick_Click...
        private void CloseClick_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            
            CloseClick_Click_DefaultImpl(sender, e);
        }

        //BtnOK_Click...
        private void BtnOK_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnOK_Click_DefaultImpl(sender, e);
        }

        //BtnGiveUp_Click...
        private void BtnGiveUp_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnGiveUp_Click_DefaultImpl(sender, e);
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
            #region 工作流配置
            string strIsAFKey = UFIDA.U9.UI.PDHelper.FormAuthorityHelper.GetIsApproveDocKey;
            this.CurrentState[strIsAFKey] = new SetIsApprovalDoc(SetIsApprovalDoc);
            #endregion
            #region 列表默认值
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
            #endregion

            //弹性域设置
            FlexFieldHelper.SetDescFlexField(new DescFlexFieldParameter[] { new DescFlexFieldParameter(this.FlexFieldPicker0, this.Model.AdvApplyBE) });
            //查找按钮设置
            string paramWhere = null;
            PDFormMessage.ShowConfirmDialog(this.Page, "b8bfae89-9037-45da-b7a9-3de49c5fe31d", "580", "408",
                Title, wpFindID.ClientID, this.BtnFind, paramWhere);
            //取得提示信息资源：是否删除当前记录
            string message = PDResource.GetDeleteConfirmInfo();
            //绑定注册弹出对话框到删除按钮
            PDFormMessage.ShowConfirmDialog(this.Page, message, "", this.BtnDelete);
            PDFormMessage.ShowConfirmDialog(this.Page, "确认放弃当前记录？", "", this.BtnCancel);
        }
        internal static bool SetIsApprovalDoc(IUIModel model)
        {
            bool isAF = false;
            AdvApplyUIModelModel curModel = model as AdvApplyUIModelModel;
            if (curModel != null && curModel.AdvApplyBE.FocusedRecord != null)
            {
                AdvApplyBERecord record = curModel.AdvApplyBE.FocusedRecord;
                isAF = record.AdvApplyDocType_ConfirmType == Convert.ToInt32(UFIDA.U9.Base.Doc.ConfirmTypeEnumData.ApproveFlow);
            }
            return isAF;
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