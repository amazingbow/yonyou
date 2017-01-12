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
namespace LaserLabDataProcessUIModel
{
    public partial class LaserLabDataProcessUIFormWebPart
    {
        #region eventBind
		 
				//MethodName:BtnCheckFile_Click ActionName:BtnCheckFileAction
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnCheckFile_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnCheckFile_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnCheckFile_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

	
		Action.BtnCheckFileAction(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:BtnChange_Click ActionName:BtnChangeAction
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnChange_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnChange_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnChange_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

	
		Action.BtnChangeAction(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:BtnJYForceChange_Click ActionName:BtnJYForceChangeAction
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnJYForceChange_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnJYForceChange_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnJYForceChange_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

	
		Action.BtnJYForceChangeAction(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:BtnBZForceChange_Click ActionName:BtnBZForceChangeAction
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnBZForceChange_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnBZForceChange_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnBZForceChange_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

	
		Action.BtnBZForceChangeAction(sender,new UIActionEventArgs());

		
			
        }
		 
				//MethodName:BtnCHForceChange_Click ActionName:BtnCHForceChangeAction
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnCHForceChange_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnCHForceChange_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnCHForceChange_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

	
		Action.BtnCHForceChangeAction(sender,new UIActionEventArgs());

		
			
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