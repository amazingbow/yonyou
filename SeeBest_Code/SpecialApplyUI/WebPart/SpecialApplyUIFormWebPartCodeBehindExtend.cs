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
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.Util.DataAccess;
using UFIDA.U9.Cust.SpecialApplyUI.SpecialApplyDocTypeUIModel;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.SpecialApplyUI.SpecialApplyUIModel
{
    public partial class SpecialApplyUIFormWebPart
    {
        #region Custome eventBind
	
		 
				//BtnSave_Click...
		private void BtnSave_Click_Extend(object sender, EventArgs  e)
		{
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            if (this.Model.SpecialApplyBE.FocusedRecord != null)
            {
                if (this.Model.SpecialApplyBE.FocusedRecord.Status.Value == 2)
                {
                    throw new Exception("这张专柜申请单已经被审核，不能再做修改！");
                }
            }

            BtnSave_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnCancel_Click...
		private void BtnCancel_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnCancel_Click_DefaultImpl(sender,e);

            //赋默认值
            this.AssignDefaultValues();
		}	
		 
				//BtnAdd_Click...
		private void BtnAdd_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnAdd_Click_DefaultImpl(sender,e);

            //赋默认值
            this.AssignDefaultValues();
		}	
		 
				//BtnDelete_Click...
		private void BtnDelete_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            if (this.Model.SpecialApplyBE.FocusedRecord != null)
            {
                if (this.Model.SpecialApplyBE.FocusedRecord.Status.Value == 2)
                {
                    throw new Exception("这张专柜申请单已经被审核，不能删除！");
                }
            }
		
			BtnDelete_Click_DefaultImpl(sender,e);

            //赋默认值
            this.AssignDefaultValues();
		}	
		 
				//BtnCopy_Click...
		private void BtnCopy_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnCopy_Click_DefaultImpl(sender,e);

            if (this.Model.SpecialApplyBE.FocusedRecord != null)
            {
                this.Model.SpecialApplyBE.FocusedRecord.AdvCode = "";
                this.Model.SpecialApplyBE.FocusedRecord.ApplyDate = System.DateTime.Now;
                this.Model.SpecialApplyBE.FocusedRecord.DocNo = "";
                this.Model.SpecialApplyBE.FocusedRecord.BusinessDate = System.DateTime.Now;
                this.Model.SpecialApplyBE.FocusedRecord.Status = 0;
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

            if (this.Model.SpecialApplyBE.FocusedRecord.SpecialApplyDocType_ApproveType.Value == Convert.ToInt32(UFIDA.U9.Base.Doc.ApproveTypeEnumData.WorkFlow))
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
		private void BtnFind_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnFind_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnList_Click...
		private void BtnList_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnList_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnFirstPage_Click...
		private void BtnFirstPage_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnFirstPage_Click_DefaultImpl(sender,e);

            //赋默认值
            this.AssignDefaultValues();
		}	
		 
				//BtnPrevPage_Click...
		private void BtnPrevPage_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnPrevPage_Click_DefaultImpl(sender,e);

            //赋默认值
            this.AssignDefaultValues();
		}	
		 
				//BtnNextPage_Click...
		private void BtnNextPage_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnNextPage_Click_DefaultImpl(sender,e);

            //赋默认值
            this.AssignDefaultValues();
		}	
		 
				//BtnLastPage_Click...
		private void BtnLastPage_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnLastPage_Click_DefaultImpl(sender,e);

            //赋默认值
            this.AssignDefaultValues();
		}	
		 
				//BtnAttachment_Click...
		private void BtnAttachment_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnAttachment_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnFlow_Click...
		private void BtnFlow_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnFlow_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnOutput_Click...
		private void BtnOutput_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnOutput_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnPrint_Click...
		private void BtnPrint_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnPrint_Click_DefaultImpl(sender,e);
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
            string strIsAFKey = UFIDA.U9.UI.PDHelper.FormAuthorityHelper.GetIsApproveDocKey;
            this.CurrentState[strIsAFKey] = new SetIsApprovalDoc(SetIsApprovalDoc);

            //弹性域设置
            FlexFieldHelper.SetDescFlexField(new DescFlexFieldParameter[] { new DescFlexFieldParameter(this.FlexFieldPicker0, this.Model.SpecialApplyBE) });
            FlexFieldHelper.SetDescFlexField(new DescFlexFieldParameter[] { new DescFlexFieldParameter(this.DataGrid14, this.DataGrid14.Columns.Count - 1, "DescFlexField") });

            //查找按钮设置
            string paramWhere = null;
            PDFormMessage.ShowConfirmDialog(this.Page, "0b7636d4-a26a-469c-b4ef-c8f61a800554", "580", "408",
                Title, wpFindID.ClientID, this.BtnFind, paramWhere);

            //取得提示信息资源：是否删除当前记录
            string message = PDResource.GetDeleteConfirmInfo();

            //绑定注册弹出对话框到删除按钮
            PDFormMessage.ShowConfirmDialog(this.Page, message, "", this.BtnDelete);
            PDFormMessage.ShowConfirmDialog(this.Page, "确认放弃当前记录？", "", this.BtnCancel);

            //赋默认值
            this.AssignDefaultValues();

		}

        internal static bool SetIsApprovalDoc(IUIModel model)
        {
            bool isAF = false;
            SpecialApplyUIModelModel curModel = model as SpecialApplyUIModelModel;
            if (curModel != null && curModel.SpecialApplyBE.FocusedRecord != null)
            {
                SpecialApplyBERecord record = curModel.SpecialApplyBE.FocusedRecord;
                isAF = record.SpecialApplyDocType_ConfirmType == Convert.ToInt32(UFIDA.U9.Base.Doc.ConfirmTypeEnumData.ApproveFlow);
            }
            return isAF;
        }

        //默认值
        private void AssignDefaultValues()
        {
            if (this.Model.SpecialApplyBE.FocusedRecord != null)
            {
                //下单日期赋默认值
                if (this.Model.SpecialApplyBE.FocusedRecord.ApplyDate == null || this.Model.SpecialApplyBE.FocusedRecord.ApplyDate == System.DateTime.MinValue)
                {
                    this.Model.SpecialApplyBE.FocusedRecord.ApplyDate = System.DateTime.Now;
                }

                //办事处赋默认值
                if (this.Model.SpecialApplyBE.FocusedRecord.ApplyDept <= 0L)
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
                                this.Model.SpecialApplyBE.FocusedRecord.ApplyDept = Convert.ToInt64(ds1.Tables[0].Rows[0]["CustomerID"].ToString());
                                this.Model.SpecialApplyBE.FocusedRecord.ApplyDept_Code = ds1.Tables[0].Rows[0]["CustomerCode"].ToString();
                                this.Model.SpecialApplyBE.FocusedRecord.ApplyDept_Name = ds1.Tables[0].Rows[0]["CustomerName"].ToString();
                            }
                        }
                    }
                }

                //业务日期赋默认值
                if (this.Model.SpecialApplyBE.FocusedRecord.BusinessDate == null || this.Model.SpecialApplyBE.FocusedRecord.BusinessDate == System.DateTime.MinValue)
                {
                    this.Model.SpecialApplyBE.FocusedRecord.BusinessDate = System.DateTime.Now;
                }

                //单号赋默认值
                if (string.IsNullOrEmpty(this.Model.SpecialApplyBE.FocusedRecord.DocNo))
                {
                    this.Model.SpecialApplyBE.FocusedRecord.DocNo = System.DateTime.Now.ToString("yyyyMMddHHmmssfff");
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
            //this.BtnFlow.Visible = false;
            this.BtnFirstPage.Visible = false;
            this.BtnPrevPage.Visible = false;
            this.BtnNextPage.Visible = false;
            this.BtnLastPage.Visible = false;
            this.ApplyDate131.Enabled = false;
            this.Status101.Enabled = false;
		}

		public void AfterUIModelBinding()
		{
            if (this.Model.SpecialApplyBE.FocusedRecord != null)
            {
                this.BtnSubmit.Enabled = true;
                this.BtnApprove.Enabled = true;
                this.BtnUndoApprove.Enabled = true;
                switch (this.Model.SpecialApplyBE.FocusedRecord.Status.Value)
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

                if (this.Model.SpecialApplyBE.FocusedRecord.ID > 0L)
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