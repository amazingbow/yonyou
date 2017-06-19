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
using UFSoft.UBF.Business;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.Engine.Builder;
using UFSoft.UBF.UI;
using System.Collections.Generic;

/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.CostSharingRatioUIModel
{
    public partial class CostSharingRatioUIFormWebPart
    {
        #region eventBind
		 
				//MethodName:BtnSave_Click ActionName:SaveClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnSave_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnSave_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnSave_Click_DefaultImpl(object sender, EventArgs e)
        {
			if (adjust.DoRequireCheck())
			{
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\ViewCodeBehindCommon.tpl,参数:SaveClick

	
		Action.SaveClick(sender,new UIActionEventArgs());

		
			

			}
        }
		 
				//MethodName:BtnDelete_Click ActionName:DeleteClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnDelete_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnDelete_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnDelete_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\ViewCodeBehindCommon.tpl,参数:DeleteClick

	
		Action.DeleteClick(sender,new UIActionEventArgs());

		
			
        }
		#region  数据初始化加载和数据收集方法
		public void OnLoadData(object sender)
		{	
		    try
			{
			    OnLoadData_Extend(sender) ;
			}
			catch(Exception ex)
			{
				if (UFSoft.UBF.Exceptions.ExceptionHelper.IsUnknownException(ex, true)) {
                    throw;
                }
                IUIModel model = this.Model;
				this.Model.ErrorMessage.SetErrorMessage(ref model,ex);
			}			
		}		
		public void OnLoadData_DefaultImpl(object sender)
		{
			Action.OnLoadData(sender,new UIActionEventArgs());
		}
		
		public override void OnDataCollect(object sender)
		{
			try
			{
			    adjust.ProcessAdjustBeforeDataCollect(this);
			    OnDataCollect_Extend(sender);
			    adjust.ProcessAdjustAfterDataCollect(this);
			}
			catch(Exception ex)
			{
				if (UFSoft.UBF.Exceptions.ExceptionHelper.IsUnknownException(ex, true)) {
                    throw;
                }
                IUIModel model = this.Model;
				this.Model.ErrorMessage.SetErrorMessage(ref model,ex);
			}
		}
		private void OnDataCollect_DefaultImpl(object sender)
		{
			Action.OnDataCollect(sender,new UIActionEventArgs());			
		}

		#endregion 
	
        #endregion
        
    }
}