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
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.Association.Adapter;
using UFSoft.UBF.Util.DataAccess;
using UFIDA.U9.Cust.HeXingProjectBP.HeXingCreateVoucherBP.Proxy;
using System.Collections.Generic;
using UFIDA.U9.UI.PDHelper;
using UFSoft.UBF.UI.FormProcess;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.HeXingProjectUI.HeXingRelationshipUIModel
{
    public partial class HeXingRelationshipUIFormWebPart
    {
        #region Custome eventBind
	
		 
				//BtnSave_Click...
		private void BtnSave_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            if (this.Model.HxRelationshipBE.Records.Count > 0)
            {
                foreach (HxRelationshipBERecord record in this.Model.HxRelationshipBE.Records)
                {
                    //if (record.IsDataChanged == true)
                    //{
                    //    record.DataRecordState = System.Data.DataRowState.Modified;
                    //}
                    //else
                    //{
                    //    record.DataRecordState = System.Data.DataRowState.Unchanged;
                    //}
                    if (record.IsDataChanged == true)
                    {
                        record.U9EntityId = 1;
                    }
                }
            }
            BtnSave_Click_DefaultImpl(sender, e);
		}
		 
				//BtnCancel_Click...
		private void BtnCancel_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnCancel_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnAdd_Click...
		private void BtnAdd_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnAdd_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnDelete_Click...
		private void BtnDelete_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            if (this.Model.HxRelationshipBE.FocusedRecord != null)
            {
                if (this.Model.HxRelationshipBE.FocusedRecord.RefStatus == 1)
                {
                    this.Model.HxRelationshipBE.FocusedRecord.RefStatus = 0;
                    BtnSave_Click_DefaultImpl(sender, e);
                }
                else
                {
                    UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('当前记录不是初始状态，不能被废弃！');", true);
                }
            }
		
            //BtnDelete_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnCopy_Click...
		private void BtnCopy_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnCopy_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnSubmit_Click...
		private void BtnSubmit_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnSubmit_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnApprove_Click...
		private void BtnApprove_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            if (this.Model.HxRelationshipBE.FocusedRecord != null)
            {
                if (string.IsNullOrEmpty(this.Model.HxRelationshipBE.FocusedRecord.U9Code))
                {
                    UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('当前记录没有维护对应的U9信息，不能做审核！');", true);
                }
                else
                {
                    if (this.Model.HxRelationshipBE.FocusedRecord.RefStatus == 1)
                    {
                        this.Model.HxRelationshipBE.FocusedRecord.RefStatus = 2;
                        BtnSave_Click_DefaultImpl(sender, e);
                    }
                    else
                    {
                        UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('当前记录不是初始状态，不能做审核！');", true);
                    }
                }
            }
		
            //BtnApprove_Click_DefaultImpl(sender,e);
		}

        //BtnUndoApprove_Click...
        private void BtnUndoApprove_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            if (this.Model.HxRelationshipBE.FocusedRecord != null)
            {
                if (this.Model.HxRelationshipBE.FocusedRecord.RefStatus == 2)
                {
                    string VoucherDisplayCodes = "";
                    DataParamList lst1 = new DataParamList();
                    lst1.Add(DataParamFactory.CreateInput("@HxRelationshipID", this.Model.HxRelationshipBE.FocusedRecord.ID, System.Data.DbType.Int64));
                    System.Data.DataSet ds1 = new System.Data.DataSet();

                    DataAccessor.RunSQL(DataAccessor.GetConn(), "select * from Cust_HeXing_RefVoucherInfoBE where HxRelationshipID=@HxRelationshipID ", lst1, out ds1);

                    if (ds1 != null && ds1.Tables.Count > 0)
                    {
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                            {
                                if (ds1.Tables[0].Rows[i]["VoucherDisplayCode"].ToString() != "" && ds1.Tables[0].Rows[i]["VoucherDisplayCode"].ToString() != "null")
                                {
                                    VoucherDisplayCodes = VoucherDisplayCodes + ds1.Tables[0].Rows[i]["VoucherDisplayCode"].ToString() + "，";
                                }
                            }
                            if (VoucherDisplayCodes != "")
                            {
                                UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('当前记录不能做弃审，因为以下U9凭证已经使用到当前对照关系，凭证号如下：" + VoucherDisplayCodes + "');", true);
                            }
                        }
                        else
                        {
                            this.Model.HxRelationshipBE.FocusedRecord.RefStatus = 1;
                            BtnSave_Click_DefaultImpl(sender, e);
                        }
                    }
                }
                else
                {
                    UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('当前记录不是审核状态，不能做弃审！');", true);
                }
            }

            //BtnUndoApprove_Click_DefaultImpl(sender, e);
        }	
		 
				//BtnFind_Click...
		private void BtnFind_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            //this.Action.NavigateAction.MovePageAt(null, long.Parse(this.wpFindID.Value));

			BtnFind_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnList_Click...
		private void BtnList_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnList_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnFirstPage_Click...
        //private void BtnFirstPage_Click_Extend(object sender, EventArgs  e)
        //{
        //    //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
        //    BtnFirstPage_Click_DefaultImpl(sender,e);
        //}	
		 
				//BtnPrevPage_Click...
        //private void BtnPrevPage_Click_Extend(object sender, EventArgs  e)
        //{
        //    //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
        //    BtnPrevPage_Click_DefaultImpl(sender,e);
        //}	
		 
				//BtnNextPage_Click...
        //private void BtnNextPage_Click_Extend(object sender, EventArgs  e)
        //{
        //    //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
        //    BtnNextPage_Click_DefaultImpl(sender,e);
        //}	
		 
				//BtnLastPage_Click...
        //private void BtnLastPage_Click_Extend(object sender, EventArgs  e)
        //{
        //    //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
        //    BtnLastPage_Click_DefaultImpl(sender,e);
        //}	
		 
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

        private void BtnExecute_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            try
            {
                ProcessRelDataProxy proxy = new ProcessRelDataProxy();
                List<string> returns = proxy.Do();
                if (returns.Count > 0)
                {
                    UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('执行导入关系对照数据成功！');", true);
                    InitializationRefresh();
                }
                else
                {
                    UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('没有需要做关系对照的数据！');", true);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "没有需要做关系对照的数据！")
                {
                    UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('" + ex.Message + "');", true);
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            
        }

		
        
            
            
            

		#region 自定义数据初始化加载和数据收集
		private void OnLoadData_Extend(object sender)
		{
            InitializationRefresh();

            //OnLoadData_DefaultImpl(sender);
		}
		private void OnDataCollect_Extend(object sender)
		{	
			OnDataCollect_DefaultImpl(sender);
		}
		#endregion  

        private void InitializationRefresh()
        {
            this.Model.HxRelationshipBE.Clear();
            this.Model.ClearErrorMessage();

            this.Model.HxRelationshipBE.CurrentFilter.OPath = "RefStatus=1";
            this.Action.CommonAction.Load(this.Model.HxRelationshipBE);

            #region
            //string strRefStatus = "1";
            //DataParamList lst1 = new DataParamList();
            //lst1.Add(DataParamFactory.CreateInput("@RefStatus", strRefStatus, System.Data.DbType.Int32));
            //System.Data.DataSet ds1 = new System.Data.DataSet();

            //DataAccessor.RunSQL(DataAccessor.GetConn(), "select * from Cust_HeXing_HxRelationshipBE where RefStatus=@RefStatus order by CreatedOn desc,RefStatus,SapCode", lst1, out ds1);

            //if (ds1 != null && ds1.Tables.Count > 0)
            //{
            //    if (ds1.Tables[0].Rows.Count > 0)
            //    {
            //        for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            //        {
            //            if (Convert.ToInt64(ds1.Tables[0].Rows[i]["ID"].ToString()) > 0L)
            //            {
            //                HxRelationshipBERecord record = this.Model.HxRelationshipBE.AddNewUIRecord();

            //                record.ID = Convert.ToInt64(ds1.Tables[0].Rows[i]["ID"].ToString());
            //                record.RefType = Convert.ToInt32(ds1.Tables[0].Rows[i]["RefType"].ToString());
            //                record.SapCode = ds1.Tables[0].Rows[i]["SapCode"].ToString();
            //                record.SapName = ds1.Tables[0].Rows[i]["SapName"].ToString();
            //                record.SapCompCode = ds1.Tables[0].Rows[i]["SapCompCode"].ToString();
            //                record.SapCompName = ds1.Tables[0].Rows[i]["SapCompName"].ToString();
            //                record.SapMasterCode = ds1.Tables[0].Rows[i]["SapMasterCode"].ToString();
            //                record.SapMasterName = ds1.Tables[0].Rows[i]["SapMasterName"].ToString();
            //                record.SapAssetsCode = ds1.Tables[0].Rows[i]["SapAssetsCode"].ToString();
            //                record.SapAssetsName = ds1.Tables[0].Rows[i]["SapAssetsName"].ToString();
            //                record.SapFeeCode = ds1.Tables[0].Rows[i]["SapFeeCode"].ToString();
            //                record.SapFeeName = ds1.Tables[0].Rows[i]["SapFeeName"].ToString();
            //                record.U9Code = ds1.Tables[0].Rows[i]["U9Code"].ToString();
            //                record.U9Name = ds1.Tables[0].Rows[i]["U9Name"].ToString();
            //                if (string.IsNullOrEmpty(ds1.Tables[0].Rows[i]["U9EntityId"].ToString()))
            //                {
            //                    record.U9EntityId = 0L;
            //                }
            //                else
            //                {
            //                    record.U9EntityId = Convert.ToInt64(ds1.Tables[0].Rows[i]["U9EntityId"].ToString());
            //                }
            //                record.Memo = ds1.Tables[0].Rows[i]["Memo"].ToString();
            //                record.RefStatus = Convert.ToInt32(ds1.Tables[0].Rows[i]["RefStatus"].ToString());
            //            }

            //        }

            //    }

            //}
            #endregion

        }

        #region 自己扩展 Extended Event handler 
		public void AfterOnLoad()
		{

            if (this.CurrentSessionState["HXOPath"] != null)
            {
                this.Model.HxRelationshipBE.Clear();
                this.Model.ClearErrorMessage();

                this.Model.HxRelationshipBE.CurrentFilter.OPath = this.CurrentSessionState["HXOPath"].ToString();
                this.Action.CommonAction.Load(this.Model.HxRelationshipBE);
                this.CurrentSessionState["HXOPath"] = null;
            }

            //绑定注册弹出对话框到删除按钮
            PDFormMessage.ShowConfirmDialog(this.Page, "是否要废弃当前记录？", "废弃确认", this.BtnDelete);
            //PDFormMessage.ShowConfirmDialog(this.Page, "确认放弃当前记录？", "", this.BtnCancel);
            PDFormMessage.ShowConfirmDialog(this.Page, "是否要审核当前记录？", "审核确认", this.BtnApprove);

		}

        public void AfterCreateChildControls()
        {

            //取得当前卡片参照的属性变量：FormID、Width、Height、Title；
            //传递隐藏域wpFindID的客户端ID；注意：隐藏域wpFindID会记录参照选择的记录ID；
            UFIDA.U9.UI.PDHelper.PDFormMessage.ShowConfirmDialog(this.Page, "1fcb4da9-d87f-43e8-baf3-ce8a6da7577f", "580", "408", Title, wpFindID.ClientID, this.BtnFind, null);

            //开启个性化

            UFIDA.U9.UI.PDHelper.PersonalizationHelper.SetPersonalizationEnable((BaseWebForm)this, true);
		
        }
        
        public void AfterEventBind()
        {
        }
        
		public void BeforeUIModelBinding()
		{
            this.BtnAdd.Visible = false;
            this.BtnCopy.Visible = false;
            this.BtnSubmit.Visible = false;
            this.BtnAttachment.Visible = false;
            this.BtnFlow.Visible = false;
            this.BtnDelete.Text = "废弃";
		}

		public void AfterUIModelBinding()
		{
            
            if (this.Model.HxRelationshipBE.FocusedRecord != null)
            {
                this.BtnDelete.Enabled = true;
                this.BtnApprove.Enabled = true;
                this.BtnUndoApprove.Enabled = true;
                UFGrid grid1 = this.DataGrid1 as UFGrid;
                int i=0;
                foreach (HxRelationshipBERecord record in this.Model.HxRelationshipBE.Records)
                {
                    if (record.RefStatus != 1)
                    {
                        grid1.SetCellDisabled(i, "U9EntityId");
                    }
                    i++;
                }
            }
            else
            {
                this.BtnDelete.Enabled = false;
                this.BtnApprove.Enabled = false;
                this.BtnUndoApprove.Enabled = false;
            }

		}


        #endregion
		
        #endregion
		
    }
}