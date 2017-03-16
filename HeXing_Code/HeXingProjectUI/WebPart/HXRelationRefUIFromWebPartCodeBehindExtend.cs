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
using UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP.Proxy;
using UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP;
using System.Collections.Generic;
using UFIDA.U9.UI.Commands;
using UFSoft.UBF.UI;
using System.Web;
using UFSoft.UBF.Util.DataAccess;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.HeXingProjectUI.HXRelationRefUIModel
{
    public partial class HXRelationRefUIFromWebPart
    {
        #region Custome eventBind
	
		 
				//BtnFind_Click...
		private void BtnFind_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.Model.HXRelationRefShowView.Clear();
            this.Model.ClearErrorMessage();
            if (string.IsNullOrEmpty(this.Org161.Text))
            {
                throw new Exception("组织机构不能为空！");
            }
            if (string.IsNullOrEmpty(this.RelType89.Text))
            {
                throw new Exception("对照类型不能为空！");
            }
            if (string.IsNullOrEmpty(this.RelColumn152.Text))
            {
                throw new Exception("栏目不能为空！");
            }
            HeXingRelatiomShipBPProxy proxy = new HeXingRelatiomShipBPProxy();
            proxy.HOrg = this.Org161.Key;
            proxy.HRefType = this.RelType89.Text;
            proxy.HColumn = this.RelColumn152.Text;
            proxy.HStr = this.RelText82.Text;
            List<RelatiomShipBPDtoData> RecordList = proxy.Do();
            foreach (var record in RecordList)
            {
                HXRelationRefShowViewRecord ShowRecord = this.Model.HXRelationRefShowView.AddNewUIRecord();
                ShowRecord.RefCode = record.FCode;
                ShowRecord.RefName = record.FName;
                ShowRecord.RefID = record.FID;
            }
            //AtlasHelper.RegisterStartupScript((Control)base.Action.CurrentPart.TopLevelContainer, base.Action.CurrentPart.GetType(), "ReferenceReturn","", false);
			BtnFind_Click_DefaultImpl(sender,e);
            //CommandFactory.DoCommand("ReferenceConfirmClick", this.Action, sender, e);
		}	
		 
				//BtnClose_Click...
		private void BtnClose_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.CloseDialog(false); 
			BtnClose_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnOk_Click...
		private void BtnOk_Click_Extend(object sender, EventArgs  e)
		{
            CommandFactory.DoCommand("ReferenceConfirmClick", this.Action, sender, e);
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            //this.CloseDialog(true);
            
			BtnOk_Click_DefaultImpl(sender,e);
		}

        private void DataGrid_GridRowDbClicked_Extend(object sender, GridDBClickEventArgs e)
        {
            CommandFactory.DoCommand("ReferenceGridRowDbClicked", this.Action, sender, e);
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            //this.CloseDialog(true);

            DataGrid_GridRowDbClicked_DefaultImpl(sender, e);
        }

		
            
            

		#region 自定义数据初始化加载和数据收集
		private void OnLoadData_Extend(object sender)
		{	
			OnLoadData_DefaultImpl(sender);
            if (this.Model.HXRelationRefFindView.FocusedRecord == null)
                this.Model.HXRelationRefFindView.FocusedRecord = this.Model.HXRelationRefFindView.AddNewUIRecord();
		}
		private void OnDataCollect_Extend(object sender)
		{	
			OnDataCollect_DefaultImpl(sender);
		}
		#endregion  

        #region 自己扩展 Extended Event handler 
		public void AfterOnLoad()
		{
            string strSapCompCode = HttpContext.Current.Request.QueryString["SapCompCode"];
            if (string.IsNullOrEmpty(strSapCompCode) == false)
            {
                DataParamList lst1 = new DataParamList();
                lst1.Add(DataParamFactory.CreateInput("@SapCompCode", strSapCompCode, System.Data.DbType.String));
                System.Data.DataSet ds1 = new System.Data.DataSet();

                DataAccessor.RunSQL(DataAccessor.GetConn(), "select top 1 A1.ID as OrgID,A1.Code as OrgCode,A2.Name as OrgName from Base_Organization A1 left join Base_Organization_Trl A2 on A1.ID=A2.ID where A1.Code=(select top 1 A.U9Code from Cust_HeXing_HxRelationshipBE A where A.RefType=7 and A.RefStatus!=0 and A.SapCode=@SapCompCode)", lst1, out ds1);

                if (ds1 != null && ds1.Tables.Count > 0)
                {
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        if (Convert.ToInt64(ds1.Tables[0].Rows[0]["OrgID"].ToString()) > 0L)
                        {
                            this.Model.HXRelationRefFindView.FocusedRecord.Org = Convert.ToInt64(ds1.Tables[0].Rows[0]["OrgID"].ToString());
                            this.Model.HXRelationRefFindView.FocusedRecord.Org_Code = ds1.Tables[0].Rows[0]["OrgCode"].ToString();
                            this.Model.HXRelationRefFindView.FocusedRecord.Org_Name = ds1.Tables[0].Rows[0]["OrgName"].ToString();
                        }
                    }
                }
            }

            if (this.Model.HXRelationRefFindView.FocusedRecord.Org == -1L || this.Model.HXRelationRefFindView.FocusedRecord.Org == null)
            {
                this.Model.HXRelationRefFindView.FocusedRecord.Org = long.Parse(UFIDA.U9.UI.PDHelper.PDContext.Current.OrgID);
                this.Model.HXRelationRefFindView.FocusedRecord.Org_Code = UFIDA.U9.UI.PDHelper.PDContext.Current.OrgRef.CodeColumn;
                this.Model.HXRelationRefFindView.FocusedRecord.Org_Name = UFIDA.U9.UI.PDHelper.PDContext.Current.OrgRef.NameColumn;
            }

            //string strRawUrl = this.Page.RawUrl;
            string strRefType = HttpContext.Current.Request.QueryString["RefType"];
            if (string.IsNullOrEmpty(strRefType) == false)
            {
                this.Model.HXRelationRefFindView.FocusedRecord.RelType = Convert.ToInt32(strRefType);
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