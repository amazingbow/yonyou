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
namespace SpecialApplyCustomerRef
{
    public partial class SpecialApplyCustomerRefWebPart
    {
        #region eventBind
		 
				//MethodName:FindButton_Click ActionName:
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void FindButton_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		
			
				UFIDA.U9.UI.Commands.CommandHelper.SaveRefFindScheme(this);		    
		
			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,FindButton_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void FindButton_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\RefCodeBehindCommon.tpl,参数:FindClick


            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("ReferenceFind",this.Action,sender,e);

		
			
        }
		 
				//MethodName:QryButton_Click ActionName:
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void QryButton_Click(object sender, EventArgs e)
        {
					

			this.IsDataBinding = false ;
			this.IsConsuming = false;
			this.InvokeMethod(sender,e,QryButton_Click_DefaultImpl) ;

			
        }

        //default implement by tpl ...
        private void QryButton_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\RefCodeBehindCommon.tpl,参数:RefQryClick


            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("QryClick",this.Action,sender,e);
            

		
			
        }
		 

			

		//MethodName:DDLCase_TextChanged ActionName:
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void DDLCase_TextChanged(object sender, EventArgs e)
        {
					

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
			this.InvokeMethod(sender,e,DDLCase_TextChanged_DefaultImpl) ;

			
        }

        //default implement by tpl ...
        private void DDLCase_TextChanged_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\RefCodeBehindCommon.tpl,参数:RefCaseChange


			UFIDA.UBF.Query.CommonService.RefQueryHelper.OnCaseChanged_Qry_DefaultImpl(this.Action);
            UFIDA.U9.UI.Commands.CommandHelper.InitReferenceDropDownList(this);

		
			
        }
		 
				//MethodName:ConfirmButton_Click ActionName:
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void ConfirmButton_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,ConfirmButton_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void ConfirmButton_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\RefCodeBehindCommon.tpl,参数:ConfirmClick


	        UFIDA.U9.UI.Commands.CommandFactory.DoCommand("ReferenceConfirmClick",this.Action,sender,e);


		
			
        }
		 
				//MethodName:CancelButton_Click ActionName:
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void CancelButton_Click(object sender, EventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					
			this.InvokeMethod(sender,e,CancelButton_Click_Extend) ;
	
			
        }

        //default implement by tpl ...
        private void CancelButton_Click_DefaultImpl(object sender, EventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\RefCodeBehindCommon.tpl,参数:CancelClick


		   UFIDA.U9.UI.Commands.CommandFactory.DoCommand("RefCancelClick",this.Action,sender,e);

		
			
        }
		 
			
				

		//MethodName:DataGrid_GridRowDbClicked ActionName:
        /// <summary>
        /// Help Info : {varEvent.Help}
        /// </summary>
        public void DataGrid_GridRowDbClicked(object sender, GridDBClickEventArgs e)
        {
			
				OnDataCollect(this); //当前事件先执行数据收集		    
		

			this.IsDataBinding = true ; //当前事件执行后会进行数据绑定
			this.IsConsuming = false;
					try
			{				
				DataGrid_GridRowDbClicked_Extend(sender,e) ;			
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

        //default implement by tpl ...
        private void DataGrid_GridRowDbClicked_DefaultImpl(object sender, GridDBClickEventArgs e)
        {
			//Template (tpl) Code here...
			//加入{action.Name}的代码模版:.\UITpls\WebPart\RefCodeBehindCommon.tpl,参数:GridDoubleClick


	        UFIDA.U9.UI.Commands.CommandFactory.DoCommand("ReferenceGridRowDbClicked",this.Action,sender,e);


		
			
        }
		#region  数据初始化加载和数据收集方法
		public void OnLoadData(object sender)
		{	
		    try
			{
					UFIDA.U9.UI.Commands.CommandHelper.LoadRefFindScheme(this);
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
		

            Action.OnLoadData(sender, new UIActionEventArgs());

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
	
        #region Grid控件DataGrid的分页事件	
        void UFGridDataGrid_GridMakePageEventHandler(Object sender, GridMakePageEventArgs  e)
        {
            //Grid的首页、下页、上页、末页处理逻辑
			UFIDA.U9.UI.Commands.CommandFactory.DoCommand("GridMakePage",this.Action,this.DataGrid,e);
        }
        #endregion

        #region Grid控件DataGrid的客户化筛选事件	
        void UFGridDataGrid_GridCustomFilterHandler(Object sender, GridCustomFilterArgs  e)
        {
            //Grid的客户化筛选，首条、上一条、下一条、末条处理逻辑
			UFIDA.U9.UI.Commands.CommandFactory.DoCommand("GridCustomFilter",this.Action,this.DataGrid,e);
        }
        #endregion

        #endregion
        
    }
}