/**************************************************************
 * Description:
 * XMJLBomDispExecUIModelAction.cs
 * Product: U9
 * Co.    : UFSoft Group
 * Author : Auto Generated 
 * version: 1.0
 **************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;




namespace UFIDA.U9.Cust.XMJL.XMJLBomDispExecUIModel
{
    public partial class XMJLBomDispExecUIModelAction
    {
        public override void OnInitAction()
        {
            base.OnInitAction();
            //提示:可注册你自己的方法到相应的事件中,如下.
            //this.CommonAction.BeforeLoad += new ActionLoadDelegate(CommonAction_BeforeLoad);
        }
        private void DispExecClick_Extend(object sender, UIActionEventArgs e)
        {



            //调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
            this.DispExecClick_DefaultImpl(sender, e);
        }

        #region UBF 内置两数据处理Action
        //数据加载的扩展
        private void OnLoadData_Extend(object sender, UIActionEventArgs e)
        {
            this.OnLoadData_DefaultImpl(sender, e);
        }

        //数据收集的扩展
        private void OnDataCollect_Extend(object sender, UIActionEventArgs e)
        {
            this.OnDataCollect_DefaultImpl(sender, e);
        }
        #endregion


    }
}
