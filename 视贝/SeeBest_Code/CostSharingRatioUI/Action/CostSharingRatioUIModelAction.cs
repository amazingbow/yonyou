/**************************************************************
 * Description:
 * CostSharingRatioUIModelAction.cs
 * Product: U9
 * Co.    : UFIDA Group
 * Author : Auto Generated
 * version: 2.0
 **************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.IView; 
using System.Data;

namespace UFIDA.U9.Cust.CostSharingRatioUIModel
{
	public partial class CostSharingRatioUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(CostSharingRatioUIModelAction));
		//强类型化基类Model属性.
		public new CostSharingRatioUIModelModel CurrentModel 
		{
			get {
				return (CostSharingRatioUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public CostSharingRatioUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public CostSharingRatioUIModelAction(CostSharingRatioUIModelModel model) : base(model)
		{
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void SaveClick(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.SaveClick_Extend);
		}
		private void SaveClick_DefaultImpl(object sender, UIActionEventArgs e)
		{
 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:SaveClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("SaveClick",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void CancelClick(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.CancelClick_Extend);
		}
		private void CancelClick_DefaultImpl(object sender, UIActionEventArgs e)
		{
 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:CancelClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("CancelClick",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void NewClick(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.NewClick_Extend);
		}
		private void NewClick_DefaultImpl(object sender, UIActionEventArgs e)
		{
 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:NewClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("NewClick",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void DeleteClick(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.DeleteClick_Extend);
		}
		private void DeleteClick_DefaultImpl(object sender, UIActionEventArgs e)
		{
 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:DeleteClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("DeleteClick",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void CopyClick(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.CopyClick_Extend);
		}
		private void CopyClick_DefaultImpl(object sender, UIActionEventArgs e)
		{
 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:CopyClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("CopyClick",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void SubmitClick(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.SubmitClick_Extend);
		}
		private void SubmitClick_DefaultImpl(object sender, UIActionEventArgs e)
		{
 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:SubmitClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("SubmitClick",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void ApproveClick(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.ApproveClick_Extend);
		}
		private void ApproveClick_DefaultImpl(object sender, UIActionEventArgs e)
		{
 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:ApproveClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("ApproveClick",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void FindClick(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.FindClick_Extend);
		}
		private void FindClick_DefaultImpl(object sender, UIActionEventArgs e)
		{
 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:FindClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("FindClick",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void ListClick(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.ListClick_Extend);
		}
		private void ListClick_DefaultImpl(object sender, UIActionEventArgs e)
		{
 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:ListClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("ListClick",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void FirstPage(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.FirstPage_Extend);
		}
		private void FirstPage_DefaultImpl(object sender, UIActionEventArgs e)
		{
 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:FirstPage
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("FirstPage",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void PrevPage(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.PrevPage_Extend);
		}
		private void PrevPage_DefaultImpl(object sender, UIActionEventArgs e)
		{
 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:PrevPage
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("PrevPage",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void NextPage(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.NextPage_Extend);
		}
		private void NextPage_DefaultImpl(object sender, UIActionEventArgs e)
		{
 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:NextPage
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("NextPage",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void LastPage(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.LastPage_Extend);
		}
		private void LastPage_DefaultImpl(object sender, UIActionEventArgs e)
		{
 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:LastPage
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("LastPage",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void AttachmentClick(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.AttachmentClick_Extend);
		}
		private void AttachmentClick_DefaultImpl(object sender, UIActionEventArgs e)
		{
 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:AttachmentClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("AttachmentClick",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void FlowClick(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.FlowClick_Extend);
		}
		private void FlowClick_DefaultImpl(object sender, UIActionEventArgs e)
		{
 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:FlowClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("FlowClick",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OutputClick(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OutputClick_Extend);
		}
		private void OutputClick_DefaultImpl(object sender, UIActionEventArgs e)
		{
 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:OutputClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("OutputClick",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void PrintClick(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.PrintClick_Extend);
		}
		private void PrintClick_DefaultImpl(object sender, UIActionEventArgs e)
		{
 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:PrintClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("PrintClick",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnOk(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnOk_Extend);
		}
		private void OnOk_DefaultImpl(object sender, UIActionEventArgs e)
		{
 
			//加入{action.Name}的代码模版:.\UITpls\WebPart\RefCodeBehindCommon.tpl,参数:OKClick


   			//模版中没有定义的相应操作内容.
			//throw new NotImplementedException();

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnClose(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnClose_Extend);
		}
		private void OnClose_DefaultImpl(object sender, UIActionEventArgs e)
		{
 
			//加入{action.Name}的代码模版:.\UITpls\WebPart\RefCodeBehindCommon.tpl,参数:CancelClick


   			//模版中没有定义的相应操作内容.
			//throw new NotImplementedException();

	  
		}
		#region Action的内置两个Action.
		/// <summary>
		/// Help: 数据加载(发生在Form的初始化加载时)
		/// </summary>
		public void OnLoadData(object sender, UIActionEventArgs e)
		{
			//UBF扩展处...
			this.OnLoadData_Extend(sender,e) ;
		}
		private void OnLoadData_DefaultImpl(object sender, UIActionEventArgs e)
		{

		     UFIDA.U9.UI.Commands.CommandFactory.DoCommand("DataLoad",this,sender,e);
		}
		/// <summary>
		/// Help: 数据收集(发生在Form的CallBack或者是PostBack时)
		/// </summary>
		public void OnDataCollect(object sender, UIActionEventArgs e)
		{
			//UBF扩展处...
			this.OnDataCollect_Extend(sender,e) ;
		}
		private void OnDataCollect_DefaultImpl(object sender, UIActionEventArgs e)
		{
		    UFIDA.U9.UI.Commands.CommandFactory.DoCommand("DataCollect",this,sender,e);
		}
		#endregion

	}
}
