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
using UFSoft.UBF.Business;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.Engine.Builder;
using UFSoft.UBF.UI;
using System.Collections.Generic;

/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.AdvApplyUI.AdvApplyUIModel
{
    public partial class AdvApplyUIFormWebPart
    {
        #region eventBind
		 

			

		//MethodName:Qty693_TextChanged ActionName:
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void Qty693_TextChanged(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,Qty693_TextChanged_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void Qty693_TextChanged_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

					//throw new NotImplementedException() ;
	 

		
			
        }
		 

			

		//MethodName:BMWidth146_TextChanged ActionName:
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BMWidth146_TextChanged(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BMWidth146_TextChanged_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BMWidth146_TextChanged_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

					//throw new NotImplementedException() ;
	 

		
			
        }
		 

			

		//MethodName:BMHight124_TextChanged ActionName:
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BMHight124_TextChanged(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BMHight124_TextChanged_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BMHight124_TextChanged_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

					//throw new NotImplementedException() ;
	 

		
			
        }
		 

			

		//MethodName:BMArea187_TextChanged ActionName:
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BMArea187_TextChanged(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BMArea187_TextChanged_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BMArea187_TextChanged_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

					//throw new NotImplementedException() ;
	 

		
			
        }
		 

			

		//MethodName:DZWidth187_TextChanged ActionName:
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void DZWidth187_TextChanged(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,DZWidth187_TextChanged_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void DZWidth187_TextChanged_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

					//throw new NotImplementedException() ;
	 

		
			
        }
		 

			

		//MethodName:DZThick224_TextChanged ActionName:
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void DZThick224_TextChanged(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,DZThick224_TextChanged_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void DZThick224_TextChanged_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

					//throw new NotImplementedException() ;
	 

		
			
        }
		 
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
		 
				//MethodName:BtnCancel_Click ActionName:CancelClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnCancel_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnCancel_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnCancel_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\ViewCodeBehindCommon.tpl,参数:CancelClick

	
		Action.CancelClick(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:BtnNew_Click ActionName:NewClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnNew_Click(object sender, EventArgs e)
        {
			//新增事件不进行数据收集，如果数据改变，Client端提示直接触发Save操作.


			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnNew_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnNew_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\ViewCodeBehindCommon.tpl,参数:NewClick

	
		Action.NewClick(sender,new UIActionEventArgs());

		
			
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
		 
				//MethodName:BtnCopy_Click ActionName:CopyClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnCopy_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnCopy_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnCopy_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\ViewCodeBehindCommon.tpl,参数:CopyClick

	
		Action.CopyClick(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:BtnSubmit_Click ActionName:SubmitClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnSubmit_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnSubmit_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnSubmit_Click_DefaultImpl(object sender, EventArgs e)
        {
			if (adjust.DoRequireCheck())
			{
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\ViewCodeBehindCommon.tpl,参数:SubmitClick

	
		Action.SubmitClick(sender,new UIActionEventArgs());

		
			

			}
        }
		 
				//MethodName:BtnApprove_Click ActionName:ApproveClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnApprove_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnApprove_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnApprove_Click_DefaultImpl(object sender, EventArgs e)
        {
			if (adjust.DoRequireCheck())
			{
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\ViewCodeBehindCommon.tpl,参数:ApproveClick

	
		Action.ApproveClick(sender,new UIActionEventArgs());

		
			

			}
        }
		 
				//MethodName:BtnUndoApprove_Click ActionName:UndoApproveClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnUndoApprove_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnUndoApprove_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnUndoApprove_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

	
		Action.UndoApproveClick(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:BtnFind_Click ActionName:FindClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnFind_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		
					
			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnFind_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnFind_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\ViewCodeBehindCommon.tpl,参数:FindClick

		UFIDA.U9.UI.Commands.CommandHelper.FindClickDoLoad(this.Action, long.Parse(wpFindID.Value));
	
		Action.FindClick(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:BtnList_Click ActionName:ListClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnList_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnList_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnList_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\ViewCodeBehindCommon.tpl,参数:ListClick

	
		Action.ListClick(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:BtnFlow_Click ActionName:FlowClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnFlow_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnFlow_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnFlow_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\ViewCodeBehindCommon.tpl,参数:FlowClick

	
		Action.FlowClick(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:BtnPrint_Click ActionName:PrintClick
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnPrint_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnPrint_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnPrint_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\ViewCodeBehindCommon.tpl,参数:PrintClick

	
		Action.PrintClick(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:CloseClick_Click ActionName:
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void CloseClick_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,CloseClick_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void CloseClick_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

			//throw new NotImplementedException() ;

		
			
        }
		 
				//MethodName:BtnOK_Click ActionName:OnOk
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnOK_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnOK_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnOK_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\RefCodeBehindCommon.tpl,参数:OKClick


	        UIActionEventArgs uie=new UIActionEventArgs();
			IList<string> outParameters = new List<string>();
		   uie["OutParameters"]=outParameters;
		   UFIDA.U9.UI.Commands.CommandFactory.DoCommand("OKClick",this.Action,sender,uie);

		
			
        }
		 
				//MethodName:BtnGiveUp_Click ActionName:OnClose
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnGiveUp_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnGiveUp_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnGiveUp_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\ViewCodeBehindCommon.tpl,参数:CancelClick

	
		Action.OnClose(sender,new UIActionEventArgs());

		
			
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
			
        #region Grid控件DataGrid0的分页事件	
        void UFGridDataGrid0_GridMakePageEventHandler(Object sender, GridMakePageEventArgs  e)
        {
            //Grid的首页、下页、上页、末页处理逻辑
			UFIDA.U9.UI.Commands.CommandFactory.DoCommand("GridMakePage",this.Action,this.DataGrid0,e);
        }
        #endregion

        #region Grid控件DataGrid0的客户化筛选事件	
        void UFGridDataGrid0_GridCustomFilterHandler(Object sender, GridCustomFilterArgs  e)
        {
            //Grid的客户化筛选，首条、上一条、下一条、末条处理逻辑
			UFIDA.U9.UI.Commands.CommandFactory.DoCommand("GridCustomFilter",this.Action,this.DataGrid0,e);
        }
        #endregion
		
        #endregion
        
    }
}