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
using UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabAddBP.Proxy;

/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.XMQX.LaserLabAddUIModel
{
    public partial class LaserLabAddUIFromWebPart
    {
        #region eventBind
		 
				//MethodName:BtnSave_Click ActionName:
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
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

			//throw new NotImplementedException() ;
        
		
			
        }
		 
				//MethodName:BtnClear_Click ActionName:
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnClear_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnClear_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnClear_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

			//throw new NotImplementedException() ;
            
		
			
        }
		 
				//MethodName:BtnSoloRight_Click ActionName:
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnSoloRight_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnSoloRight_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnSoloRight_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

			//throw new NotImplementedException() ;
          

		
			
        }
		 
				//MethodName:BtnAllRight_Click ActionName:
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnAllRight_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnAllRight_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnAllRight_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

			//throw new NotImplementedException() ;
           
		
			
        }
		 
				//MethodName:BtnSoloLeft_Click ActionName:
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnSoloLeft_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnSoloLeft_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnSoloLeft_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

			//throw new NotImplementedException() ;
         

		
			
        }
		 
				//MethodName:BtnAllSave_Click ActionName:
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnAllSave_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnAllSave_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnAllSave_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

			//throw new NotImplementedException() ;
            

		
			
        }
		 
				//MethodName:BtnAllClear_Click ActionName:
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnAllClear_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnAllClear_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnAllClear_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

			//throw new NotImplementedException() ;
          
		
			
        }
		 
				//MethodName:BtnAllLeft_Click ActionName:
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void BtnAllLeft_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,BtnAllLeft_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void BtnAllLeft_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...

			//通用事件模版定义的相应操作内容.	

			//throw new NotImplementedException() ;
          
		
			
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
		
        #region Grid控件DataGrid8的分页事件	
        void UFGridDataGrid8_GridMakePageEventHandler(Object sender, GridMakePageEventArgs  e)
        {
            //Grid的首页、下页、上页、末页处理逻辑
			UFIDA.U9.UI.Commands.CommandFactory.DoCommand("GridMakePage",this.Action,this.DataGrid8,e);
        }
        #endregion

        #region Grid控件DataGrid8的客户化筛选事件	
        void UFGridDataGrid8_GridCustomFilterHandler(Object sender, GridCustomFilterArgs  e)
        {
            //Grid的客户化筛选，首条、上一条、下一条、末条处理逻辑
			UFIDA.U9.UI.Commands.CommandFactory.DoCommand("GridCustomFilter",this.Action,this.DataGrid8,e);
        }
        #endregion
	
        #region Grid控件DataGrid9的分页事件	
        void UFGridDataGrid9_GridMakePageEventHandler(Object sender, GridMakePageEventArgs  e)
        {
            //Grid的首页、下页、上页、末页处理逻辑
			UFIDA.U9.UI.Commands.CommandFactory.DoCommand("GridMakePage",this.Action,this.DataGrid9,e);
        }
        #endregion

        #region Grid控件DataGrid9的客户化筛选事件	
        void UFGridDataGrid9_GridCustomFilterHandler(Object sender, GridCustomFilterArgs  e)
        {
            //Grid的客户化筛选，首条、上一条、下一条、末条处理逻辑
			UFIDA.U9.UI.Commands.CommandFactory.DoCommand("GridCustomFilter",this.Action,this.DataGrid9,e);
        }
        #endregion

        #endregion
        
    }
}