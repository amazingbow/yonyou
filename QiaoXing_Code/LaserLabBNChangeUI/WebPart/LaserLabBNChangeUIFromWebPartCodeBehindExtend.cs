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
            List<string> LBlist = new List<string>();
            LBlist.Add(this.TextBox1.Text);
            proxy.LB=LBlist;
            proxy.BN = this.TextBox2.Text;
            proxy.AmendBN = this.TextBox3.Text;
            var str = proxy.Do();
            if (str!="")
            {
                if (!string.IsNullOrEmpty(str))
                {
                    UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('修改成功！');", true);
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
            List<string> LBlist = new List<string>();
            LaserLabBNChangeBPProxy proxy = new LaserLabBNChangeBPProxy();
            foreach (IUIRecord selectRecord in selectRecordCollection)
            {
                LBlist.Add(selectRecord["LB"].ToString());            
            }
            proxy.LB = LBlist;
            proxy.BN = this.TextBox4.Text;
            proxy.AmendBN = this.TextBox6.Text;
            var str = proxy.Do();
            if (true)
            {
                UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('"+str+"');", true);
            }
            this.BtnFind_Click(sender, e);
			AllBtnExecute_Click_DefaultImpl(sender,e);
		}
        private void BtnFind_Click_Extend(object sender, EventArgs e)
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
                if (labinfo.CP == "报废" || labinfo.CP == "出货") continue;
                var BatchLaser = this.Model.BatchLaserLabBNChangeView.AddNewUIRecord();
                BatchLaser.LB = labinfo.LB;
                BatchLaser.BN = labinfo.BN;
                BatchLaser.CP = labinfo.CP;
                BatchLaser.MasterDT = labinfo.MasterDT;
            }


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