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
using UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.Proxy;
using UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP;
using System.Collections.Generic;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.XMQX.LaserLabBNChangeUI.LaserLabBNChangeUIModel
{
    public partial class LaserLabBNChangeUIFromWebPart
    {
        #region Custome eventBind
	
		 
				//BtnExectue_Click...
		private void BtnExectue_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (string.IsNullOrEmpty(this.TextBox1.Text)) return;
            if (string.IsNullOrEmpty(this.TextBox2.Text)) return;
            if (string.IsNullOrEmpty(this.TextBox2.Text)) return;
            LaserLabBNChangeBPProxy proxy = new LaserLabBNChangeBPProxy();
            proxy.LB = this.TextBox1.Text;
            proxy.BN = this.TextBox2.Text;
            proxy.AmendBN = this.TextBox3.Text;
            var str = proxy.Do();
            if (str != "Flase")
            {
                if (!string.IsNullOrEmpty(str))
                {
                    UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('LB编号为 " + this.TextBox1.Text + "的批次号 " + this.TextBox2.Text + "已成功改为 " + str + "');", true);
                }
            }
            else
            {
                throw new Exception("没有找到匹配的数据，请核对！");
            }
		
			BtnExectue_Click_DefaultImpl(sender,e);
		}	
		 
				//AllBtnExecute_Click...
		private void AllBtnExecute_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (string.IsNullOrEmpty(this.TextBox5.Text) && (string.IsNullOrEmpty(this.TextBox4.Text))) return;
            if (string.IsNullOrEmpty(this.TextBox6.Text))
            {
                throw new Exception("批量修改批次号不能为空，请输入修改的批次号！");
            }
            IUIRecordCollection selectRecordCollection = this.Model.BatchLaserLabBNChangeView.SelectRecords;
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.           
            if (selectRecordCollection.Count < 1) return;
            StringBuilder strbulder = new StringBuilder();
            StringBuilder strLB = new StringBuilder();
            foreach (IUIRecord selectRecord in selectRecordCollection)
            {
                LaserLabBNChangeBPProxy proxy = new LaserLabBNChangeBPProxy();
                proxy.LB = selectRecord["LB"].ToString();
                proxy.BN = selectRecord["BN"].ToString();
                proxy.AmendBN = this.TextBox6.Text;
                var str = proxy.Do();
                strbulder.Append(str + ",");
                strLB.Append(selectRecord["LB"].ToString() + ",");
            }
            var strend = strbulder.ToString().TrimEnd(new char[1] { ',' });
            var strLBend = strLB.ToString().TrimEnd(new char[1] { ',' });
            if (true)
            {
                UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('选中LB" + strLBend + "批号修改为" + strend + "');", true);
            }
            this.Action.NavigateAction.Refresh(this.DataGrid1, false);
			AllBtnExecute_Click_DefaultImpl(sender,e);
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
            this.Model.ClearErrorMessage();

		}

        public void AfterCreateChildControls()
        {


		
        }
        
        public void AfterEventBind()
        {
            this.TextBox5.AutoPostBack = true;
            this.TextBox4.AutoPostBack = true;
        }
        
		public void BeforeUIModelBinding()
		{
            if (string.IsNullOrEmpty(this.TextBox4.Text) && string.IsNullOrEmpty(this.TextBox5.Text)) return;
            this.Model.BatchLaserLabBNChangeView.Clear();
            LaserLaBGetInfoBPProxy proxy = new LaserLaBGetInfoBPProxy();
            proxy.BN = this.TextBox4.Text;
            proxy.Type = this.TextBox5.Text;
            List<LabBNInfoDTOData> record = proxy.Do();
            if (record == null) return;
            foreach (LabBNInfoDTOData labinfo in record)
            {
                var BatchLaser = this.Model.BatchLaserLabBNChangeView.AddNewUIRecord();
                BatchLaser.LB = labinfo.LB;
                BatchLaser.BN = labinfo.BN;
                BatchLaser.CP = labinfo.CP;
                BatchLaser.MasterDT = labinfo.MasterDT;
            }
		}

		public void AfterUIModelBinding()
		{


		}


        #endregion
		
        #endregion
		
    }
}