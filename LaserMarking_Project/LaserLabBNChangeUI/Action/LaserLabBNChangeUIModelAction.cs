/**************************************************************
 * Description:
 * LaserLabBNChangeUIModelAction.cs
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

namespace UFIDA.U9.Cust.XMJL.LaserLabBNChangeUI.LaserLabBNChangeUIModel
{
	public partial class LaserLabBNChangeUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(LaserLabBNChangeUIModelAction));
		//强类型化基类Model属性.
		public new LaserLabBNChangeUIModelModel CurrentModel 
		{
			get {
				return (LaserLabBNChangeUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public LaserLabBNChangeUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public LaserLabBNChangeUIModelAction(LaserLabBNChangeUIModelModel model) : base(model)
		{
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
