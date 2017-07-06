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
using UFSoft.UBF.Util.DataAccess;
using UFSoft.UBF.UI.FormProcess;



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
            if (this.Model.AdvApplyBE.FocusedRecord != null)
            {
                if (this.Model.AdvApplyBE.FocusedRecord.ID > 0L)
                {
                    DataParamList lst1 = new DataParamList();
                    lst1.Add(DataParamFactory.CreateInput("@AdvApplyBEID", this.Model.AdvApplyBE.FocusedRecord.ID, System.Data.DbType.Int64));

                    DataAccessor.RunSQL(DataAccessor.GetConn(), "delete Cust_SeeBest_AdvAbout where AdvApplyBE=@AdvApplyBEID", lst1);

                }
            }
            this.Model.AdvApplyBE_AdvAboutBE.Clear();
            foreach (AdvCarrierListRecord item in this.Model.AdvCarrierList.Records)
            {
                if (item.IsSelected.Value)
                {
                    if (this.Model.AdvApplyBE_AdvAboutBE.RecordCount > 0)
                    {
                        bool hasFlag = false;
                        foreach (AdvApplyBE_AdvAboutBERecord about in this.Model.AdvApplyBE_AdvAboutBE.Records)
                        {
                            if (about.Code == item.Code)
                            {
                                hasFlag = true;
                            }
                        }
                        if (hasFlag)
                        {
                            continue;
                        }
                    }
                    var newRecord = this.Model.AdvApplyBE_AdvAboutBE.AddNewUIRecord();
                    newRecord.Code = item.Code;
                    newRecord.Name = item.Name;
                    newRecord.Description = item.Description;
                    newRecord.IsSelected = true;
                    newRecord.SetParentRecord(this.Model.AdvApplyBE.FocusedRecord);
                }
            }
            var errorMsg = CheckAdvDisplayItem();
            if (!string.IsNullOrEmpty(errorMsg))
            {
                throw new Exception(errorMsg);
            }
            BtnSave_Click_DefaultImpl(sender, e);
        }

        //BtnCancel_Click...
        private void BtnCancel_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnCancel_Click_DefaultImpl(sender, e);
            #region 列表默认值
            this.Model.AdvCarrierList.Clear();
            GetValueSetInfoProxy proxy = new GetValueSetInfoProxy();
            proxy.ValueCode = "Z106";
            var data = proxy.Do();
            foreach (var item in data)
            {
                var newRecord = this.Model.AdvCarrierList.AddNewUIRecord();
                newRecord.Code = item.Code;
                newRecord.Name = item.Name;
                newRecord.Description = item.Description;
                newRecord.IsSelected = false;
                if (this.Model.AdvApplyBE_AdvAboutBE.Records.Count > 0)
                {
                    foreach (AdvApplyBE_AdvAboutBERecord about in this.Model.AdvApplyBE_AdvAboutBE.Records)
                    {
                        if (about.Code == item.Code)
                        {
                            newRecord.IsSelected = true;
                            break;
                        }
                    }
                }
            }
            #endregion

            AssignDefaultValues();
        }

        //BtnNew_Click...
        private void BtnNew_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnNew_Click_DefaultImpl(sender, e);
            #region 列表默认值
            this.Model.AdvCarrierList.Clear();
            GetValueSetInfoProxy proxy = new GetValueSetInfoProxy();
            proxy.ValueCode = "Z106";
            var data = proxy.Do();
            foreach (var item in data)
            {
                var newRecord = this.Model.AdvCarrierList.AddNewUIRecord();
                newRecord.Code = item.Code;
                newRecord.Name = item.Name;
                newRecord.Description = item.Description;
                newRecord.IsSelected = false;
                if (this.Model.AdvApplyBE_AdvAboutBE.Records.Count > 0)
                {
                    foreach (AdvApplyBE_AdvAboutBERecord about in this.Model.AdvApplyBE_AdvAboutBE.Records)
                    {
                        if (about.Code == item.Code)
                        {
                            newRecord.IsSelected = true;
                            break;
                        }
                    }
                }
            }
            #endregion

            AssignDefaultValues();
        }

        //BtnDelete_Click...
        private void BtnDelete_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            
            if (this.Model.AdvApplyBE.FocusedRecord != null)
            {
                if (this.Model.AdvApplyBE.FocusedRecord.DocStatus.Value == 2)
                {
                    throw new Exception("这张专柜申请单已经被审核，不能删除！");
                }
            }
            BtnDelete_Click_DefaultImpl(sender, e);
            #region 列表默认值
            this.Model.AdvCarrierList.Clear();
            GetValueSetInfoProxy proxy = new GetValueSetInfoProxy();
            proxy.ValueCode = "Z106";
            var data = proxy.Do();
            foreach (var item in data)
            {
                var newRecord = this.Model.AdvCarrierList.AddNewUIRecord();
                newRecord.Code = item.Code;
                newRecord.Name = item.Name;
                newRecord.Description = item.Description;
                newRecord.IsSelected = false;
                if (this.Model.AdvApplyBE_AdvAboutBE.Records.Count > 0)
                {
                    foreach (AdvApplyBE_AdvAboutBERecord about in this.Model.AdvApplyBE_AdvAboutBE.Records)
                    {
                        if (about.Code == item.Code)
                        {
                            newRecord.IsSelected = true;
                            break;
                        }
                    }
                }
            }
            #endregion

            AssignDefaultValues();
        }

        //BtnCopy_Click...
        private void BtnCopy_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnCopy_Click_DefaultImpl(sender, e);
            if (this.Model.AdvApplyBE.FocusedRecord != null)
            {
                this.Model.AdvApplyBE.FocusedRecord.AdvCode = "";
                this.Model.AdvApplyBE.FocusedRecord.ApplyDate = System.DateTime.Now;
                this.Model.AdvApplyBE.FocusedRecord.DocNo = "";
                this.Model.AdvApplyBE.FocusedRecord.BusinessDate = System.DateTime.Now;
                this.Model.AdvApplyBE.FocusedRecord.DocStatus = 0;
            }
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

            #region 列表默认值
            this.Model.AdvCarrierList.Clear();
            GetValueSetInfoProxy proxy = new GetValueSetInfoProxy();
            proxy.ValueCode = "Z106";
            var data = proxy.Do();
            foreach (var item in data)
            {
                var newRecord = this.Model.AdvCarrierList.AddNewUIRecord();
                newRecord.Code = item.Code;
                newRecord.Name = item.Name;
                newRecord.Description = item.Description;
                newRecord.IsSelected = false;
                if (this.Model.AdvApplyBE_AdvAboutBE.Records.Count > 0)
                {
                    foreach (AdvApplyBE_AdvAboutBERecord about in this.Model.AdvApplyBE_AdvAboutBE.Records)
                    {
                        if (about.Code == item.Code)
                        {
                            newRecord.IsSelected = true;
                            break;
                        }
                    }
                }
            }
            #endregion
        }

        //BtnList_Click...
        private void BtnList_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnList_Click_DefaultImpl(sender, e);
            #region 列表默认值
            this.Model.AdvCarrierList.Clear();
            GetValueSetInfoProxy proxy = new GetValueSetInfoProxy();
            proxy.ValueCode = "Z106";
            var data = proxy.Do();
            foreach (var item in data)
            {
                var newRecord = this.Model.AdvCarrierList.AddNewUIRecord();
                newRecord.Code = item.Code;
                newRecord.Name = item.Name;
                newRecord.Description = item.Description;
                newRecord.IsSelected = false;
                if (this.Model.AdvApplyBE_AdvAboutBE.Records.Count > 0)
                {
                    foreach (AdvApplyBE_AdvAboutBERecord about in this.Model.AdvApplyBE_AdvAboutBE.Records)
                    {
                        if (about.Code == item.Code)
                        {
                            newRecord.IsSelected = true;
                            break;
                        }
                    }
                }
            }
            #endregion
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
            CloseAdvApplyProxy proxy = new CloseAdvApplyProxy();
            if (this.Model.AdvApplyBE.FocusedRecord != null)
            {
                proxy.ID = this.Model.AdvApplyBE.FocusedRecord.ID;
                proxy.Do();
            }
            CloseClick_Click_DefaultImpl(sender, e);
        }

        //BtnOK_Click...
        private void BtnOK_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            //BtnOK_Click_DefaultImpl(sender, e);
        }

        //BtnGiveUp_Click...
        private void BtnGiveUp_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            //BtnGiveUp_Click_DefaultImpl(sender, e);
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
            if (this.Model.AdvCarrierList.RecordCount == 0)
            {
                GetValueSetInfoProxy proxy = new GetValueSetInfoProxy();
                proxy.ValueCode = "Z106";
                var data = proxy.Do();
                foreach (var item in data)
                {
                    var newRecord = this.Model.AdvCarrierList.AddNewUIRecord();
                    newRecord.Code = item.Code;
                    newRecord.Name = item.Name;
                    newRecord.Description = item.Description;
                    newRecord.IsSelected = false;
                    if (this.Model.AdvApplyBE_AdvAboutBE.Records.Count > 0)
                    {
                        foreach (AdvApplyBE_AdvAboutBERecord about in this.Model.AdvApplyBE_AdvAboutBE.Records)
                        {
                            if (about.Code == item.Code)
                            {
                                newRecord.IsSelected = true;
                                break;
                            }
                        }
                    }
                    //this.Model.AdvApplyBE_AdvAboutBE.Records.Add(newRecord);
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
            AssignDefaultValues();
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

        private string CheckAdvDisplayItem()
        {
            string errorMsg = string.Empty;
            if (this.Model.AdvApplyBE.FocusedRecord.BMArea >= 4)
            {
                if (this.Model.AdvApplyBE_AdvAboutBE.RecordCount > 2)
                {
                    errorMsg = "版面面积大于等于4的时候，广告体现项目只能从LED照明、墙壁开光、插座选择，且只能选2个";
                    return errorMsg;
                }
                foreach (AdvApplyBE_AdvAboutBERecord item in this.Model.AdvApplyBE_AdvAboutBE.Records)
                {
                    if (item.Code != "001" && item.Code != "002" && item.Code != "003")
                    {
                        errorMsg = "版面面积大于等于4的时候，广告体现项目只能从LED照明、墙壁开光、插座选择，且只能选2个";
                        return errorMsg;
                    }
                }
            }
            else
            {
                if (this.Model.AdvApplyBE_AdvAboutBE.RecordCount > 1)
                {
                    errorMsg = "版面面积小于4的时候，广告体现项目只能选1个";
                    return errorMsg;
                }
            }
            return errorMsg;
        }

        private void AssignDefaultValues()
        {
            if (this.Model.AdvApplyBE.FocusedRecord != null)
            {
                //下单日期赋默认值
                if (this.Model.AdvApplyBE.FocusedRecord.ApplyDate == null || this.Model.AdvApplyBE.FocusedRecord.ApplyDate == System.DateTime.MinValue)
                {
                    this.Model.AdvApplyBE.FocusedRecord.ApplyDate = System.DateTime.Now;
                }

                //办事处赋默认值
                if (this.Model.AdvApplyBE.FocusedRecord.ApplyDept <= 0L)
                {
                    DataParamList lst1 = new DataParamList();
                    lst1.Add(DataParamFactory.CreateInput("@UserCode", UFIDA.U9.UI.PDHelper.PDContext.Current.UserCode, System.Data.DbType.String));
                    lst1.Add(DataParamFactory.CreateInput("@OrgID", UFIDA.U9.UI.PDHelper.PDContext.Current.OrgID, System.Data.DbType.Int64));
                    System.Data.DataSet ds1 = new System.Data.DataSet();

                    DataAccessor.RunSQL(DataAccessor.GetConn(), "select top 1 A1.ID as CustomerID,A1.Code as CustomerCode,A2.Name as CustomerName from CBO_Customer A1 left join CBO_Customer_Trl A2 on A1.ID=A2.ID where A1.DescFlexField_PrivateDescSeg14=@UserCode and A1.Org=@OrgID order by A1.Code", lst1, out ds1);

                    if (ds1 != null && ds1.Tables.Count > 0)
                    {
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            if (Convert.ToInt64(ds1.Tables[0].Rows[0]["CustomerID"].ToString()) > 0L)
                            {
                                this.Model.AdvApplyBE.FocusedRecord.ApplyDept = Convert.ToInt64(ds1.Tables[0].Rows[0]["CustomerID"].ToString());
                                this.Model.AdvApplyBE.FocusedRecord.ApplyDept_Code = ds1.Tables[0].Rows[0]["CustomerCode"].ToString();
                                this.Model.AdvApplyBE.FocusedRecord.ApplyDept_Name = ds1.Tables[0].Rows[0]["CustomerName"].ToString();
                            }
                        }
                    }
                }
                //业务日期赋默认值
                if (this.Model.AdvApplyBE.FocusedRecord.BusinessDate == null || this.Model.AdvApplyBE.FocusedRecord.BusinessDate == System.DateTime.MinValue)
                {
                    this.Model.AdvApplyBE.FocusedRecord.BusinessDate = System.DateTime.Now;
                }
                //单号赋默认值
                if (string.IsNullOrEmpty(this.Model.AdvApplyBE.FocusedRecord.DocNo))
                {
                    this.Model.AdvApplyBE.FocusedRecord.DocNo = "AdvApply" + System.DateTime.Now.ToString("yyyyMMddHHmmssfff");
                }
            }
        }

        public void AfterCreateChildControls()
        {
            //开启个性化
            UFIDA.U9.UI.PDHelper.PersonalizationHelper.SetPersonalizationEnable((BaseWebForm)this, true);
        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {

        }

        public void AfterUIModelBinding()
        {

            if (this.Model.AdvApplyBE.FocusedRecord != null)
            {
                this.BtnSubmit.Enabled = true;
                this.BtnApprove.Enabled = true;
                this.BtnUndoApprove.Enabled = true;
                switch (this.Model.AdvApplyBE.FocusedRecord.DocStatus.Value)
                {
                    case 0:
                        this.BtnApprove.Enabled = false;
                        this.BtnUndoApprove.Enabled = false;
                        break;
                    case 1:
                        this.BtnSubmit.Enabled = false;
                        this.BtnUndoApprove.Enabled = false;
                        break;
                    case 2:
                        this.BtnSubmit.Enabled = false;
                        this.BtnApprove.Enabled = false;
                        break;
                }

                if (this.Model.AdvApplyBE.FocusedRecord.ID > 0L)
                {
                    this.BtnDelete.Enabled = true;
                    this.BtnCopy.Enabled = true;
                }
                else
                {
                    this.BtnDelete.Enabled = false;
                    this.BtnCopy.Enabled = false;
                }
            }
            else
            {
                this.BtnDelete.Enabled = false;
                this.BtnCopy.Enabled = false;
            }

        }


        #endregion

        #endregion

    }
}