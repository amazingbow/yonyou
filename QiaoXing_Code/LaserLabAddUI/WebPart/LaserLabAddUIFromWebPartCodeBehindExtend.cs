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
using UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabAddBP.Proxy;
using System.Collections.Generic;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.XMQX.LaserLabAddUIModel
{
    public partial class LaserLabAddUIFromWebPart
    {
        #region Custome eventBind
	
		 
				//BtnSave_Click...
		private void BtnSave_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.Model.SoloLaserLabAddView.ClearErrorMessage();		
			
            var str = "";
            if (string.IsNullOrEmpty(this.Model.SoloLaserLabAddView.FocusedRecord.BN))
            {
                throw new Exception("批次号不能为空！"); 
            }
            if (string.IsNullOrEmpty(this.Model.SoloLaserLabAddView.FocusedRecord.LB))
            {
                throw new Exception("LB编码不能为空！"); 
            }
            if (string.IsNullOrEmpty(this.Model.SoloLaserLabAddView.FocusedRecord.Type))
            {
                throw new Exception("型号不能为空！");
            }
            List<string> LB = new List<string>();
            LB.Add(this.Model.SoloLaserLabAddView.FocusedRecord.LB);
            LaserLabAddBPProxy proxy = new LaserLabAddBPProxy();
            proxy.BN = this.Model.SoloLaserLabAddView.FocusedRecord.BN;
            proxy.LBList = LB;
            proxy.Customer = this.Model.SoloLaserLabAddView.FocusedRecord.Customer;
            proxy.MasterDT = this.Model.SoloLaserLabAddView.FocusedRecord.CreatedOn;
            proxy.Type = this.Model.SoloLaserLabAddView.FocusedRecord.Type;
            str = proxy.Do();
            if (!string.IsNullOrEmpty(str.ToString()))
            {
                UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('"+str+"');", true);
            }
            BtnSave_Click_DefaultImpl(sender, e);
		}	
		 
				//BtnClear_Click...
		private void BtnClear_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.Model.SoloLaserLabAddView.Clear();
		
			BtnClear_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnSoloRight_Click...
		private void BtnSoloRight_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            IUIRecordCollection GroupRecord = this.Model.AllLaserLabCreateView.SelectRecords;
            foreach (var record in GroupRecord)
            {
                var checkLB = record["LB"].ToString();
                if (this.Model.AllLaserLabAddView.Records.FindAll("LB", checkLB).Count >= 1) continue;
                var SavrRecord = this.Model.AllLaserLabAddView.AddNewUIRecord();
                SavrRecord.BN = record["BN"].ToString();
                SavrRecord.LB = record["LB"].ToString();
                SavrRecord.Customer = record["Customer"].ToString();
                SavrRecord.Type = record["Type"].ToString();
            }
		
			BtnSoloRight_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnAllRight_Click...
		private void BtnAllRight_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            IUIRecordCollection GroupRecord = this.Model.AllLaserLabCreateView.Records;
            foreach (var record in GroupRecord)
            {
                var checkLB = record["LB"].ToString();
                if (this.Model.AllLaserLabAddView.Records.FindAll("LB", checkLB).Count >= 1) continue;
                var SavrRecord = this.Model.AllLaserLabAddView.AddNewUIRecord();
                SavrRecord.BN = record["BN"].ToString();
                SavrRecord.LB = record["LB"].ToString();
                SavrRecord.Customer = record["Customer"].ToString();
                SavrRecord.Type = record["Type"].ToString();
            }

		
			BtnAllRight_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnSoloLeft_Click...
		private void BtnSoloLeft_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            IUIRecordCollection Recrod = this.Model.AllLaserLabAddView.Records;
            var select = this.Model.AllLaserLabAddView.SelectRecords;
            foreach (var selectrecord in select)
            {
                Recrod.Remove(selectrecord);

            }
		
			BtnSoloLeft_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnAllSave_Click...
		private void BtnAllSave_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (this.Model.AllLaserLabAddView.Records.Count < 1) return;
            IUIRecordCollection Record = this.Model.AllLaserLabAddView.Records;
            List<string> Lb = new List<string>();
            if (this.Model.AllLaserLabAddView.FocusedRecord == null) return;
            LaserLabAddBPProxy proxy = new LaserLabAddBPProxy();
            proxy.BN = this.TextBox1.Text;
            proxy.Type = this.TextBox2.Text;
            proxy.Customer = this.TextBox3.Text;
            foreach (var Rec in Record)
            { 
                Lb.Add(Rec["LB"].ToString());
            }
            proxy.LBList = Lb;
            proxy.MasterDT = System.DateTime.Now;
            var str =proxy.Do();
            if (!string.IsNullOrEmpty(str.ToString()))
            {
                UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('"+str+"');", true);
            }
            
			BtnAllSave_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnAllClear_Click...
		private void BtnAllClear_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.TextBox1.Text = null;
            this.TextBox2.Text = null;
            this.TextBox3.Text = null;
            this.TextBox5.Text = null;
            this.NumberControl2.Value = null;
            this.NumberControl1.Value = null;
            this.NumberControl3.Value = null;
            this.Model.AllLaserLabCreateView.Clear();
            this.Model.AllLaserLabAddView.Clear();
			BtnAllClear_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnAllLeft_Click...
		private void BtnAllLeft_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.Model.AllLaserLabAddView.Clear();
			BtnAllLeft_Click_DefaultImpl(sender,e);
		}
        private void BtnCreateLB_Click_Extend(object sender, EventArgs e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.Model.AllLaserLabCreateView.Clear();
            this.Model.AllLaserLabCreateView.ClearErrorMessage();
            //批次号
            if (string.IsNullOrEmpty(this.TextBox1.Text)) return;
            //型号
            if (string.IsNullOrEmpty(this.TextBox2.Text)) return;
            //镭射标长度
            if (int.Parse(this.NumberControl1.Text) <= 0) return;
            //开始字母
            if (string.IsNullOrEmpty(this.TextBox5.Text)) return;
            //客户
            if (string.IsNullOrEmpty(this.TextBox3.Text)) return;
            //起始号
            if (string.IsNullOrEmpty(this.NumberControl2.Text)) return;
            //截止号
            if (string.IsNullOrEmpty(this.NumberControl3.Text)) return;
            if (decimal.Parse(this.NumberControl1.Text) <= this.TextBox5.Text.Length)
                throw new Exception("镭射标长度必须大于开始字母长度");
            var lenth = int.Parse(this.NumberControl1.Text);
            var star = decimal.Parse(this.NumberControl2.Text);
            var end = decimal.Parse(this.NumberControl3.Text);
            #region 批量生成镭射标
            for (var i = star; i <= end; i++)
            {
                var Grouprecord = this.Model.AllLaserLabCreateView.AddNewUIRecord();
                StringBuilder LB = new StringBuilder();
                LB.Append(this.TextBox5.Text);
                if (LB.Length < lenth)
                {
                    if (star.ToString().Length <= (lenth - LB.Length))
                    {
                        var stbadd = i.ToString().PadLeft((lenth - LB.Length), '0');
                        LB.Append(stbadd);
                    }

                }
                else
                {
                    throw new Exception("开始字母长度大于或等于镭射标长度！");
                }

                Grouprecord.BN = this.TextBox1.Text;
                Grouprecord.LB = LB.ToString();
                Grouprecord.Type = this.TextBox2.Text;
                Grouprecord.Customer = this.TextBox3.Text;
            }
            #endregion


            BtnCreateLB_Click_DefaultImpl(sender, e);
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