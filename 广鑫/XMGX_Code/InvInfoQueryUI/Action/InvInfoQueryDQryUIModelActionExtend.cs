/**************************************************************
 * Description:
 * InvInfoQueryDQryUIModelAction.cs
 * Product: U9
 * Co.    : UFSoft Group
 * Author : Auto Generated 
 * version: 1.0
 **************************************************************/

using UFIDA.UBF.Query.CaseModel;
using UFIDA.UBF.Query.CommonService.QueryStrategy;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.ControlModel;

namespace UFIDA.U9.Cust.FJGX.InvInfoQueryDQryUIModel
{
    public partial class InvInfoQueryDQryUIModelAction
    {
        public override void OnInitAction()
        {
            base.OnInitAction();
            //提示:可注册你自己的方法到相应的事件中,如下.
            //this.CommonAction.BeforeLoad += new ActionLoadDelegate(CommonAction_BeforeLoad);
        }

        private void OnLookCase_Extend(object sender, UIActionEventArgs e)
        {
            //调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
            this.OnLookCase_DefaultImpl(sender, e);
        }

        private void OnCaseChanged_Extend(object sender, UIActionEventArgs e)
        {
            //调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
            this.OnCaseChanged_DefaultImpl(sender, e);
        }

        private void OnOutPut_Extend(object sender, UIActionEventArgs e)
        {
            //调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
            this.OnOutPut_DefaultImpl(sender, e);
        }

        private void OnNew_Extend(object sender, UIActionEventArgs e)
        {
            //调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
            this.OnNew_DefaultImpl(sender, e);
        }

        private void OnPrint_Extend(object sender, UIActionEventArgs e)
        {
            //调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
            this.OnPrint_DefaultImpl(sender, e);
        }

        private void OnDelete_Extend(object sender, UIActionEventArgs e)
        {
            //调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
            this.OnDelete_DefaultImpl(sender, e);
        }

        private void OnGridRowDbClick_Extend(object sender, UIActionEventArgs e)
        {
            //List Grid RowDbClic Code Demo...
            //string DataID = this.CurrentModel.PositionType.FocusedRecord.ID.ToString();
            //string CardPageID="Test";//在这里CardPageID表示卡片的URI
            //OnNavigatCard("Browse", DataID, CardPageID);
            //调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
            this.OnGridRowDbClick_DefaultImpl(sender, e);
        }

        private void btnSaveCurrentQueryCase_Extend(object sender, UIActionEventArgs e)
        {
            //调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
            this.btnSaveCurrentQueryCase_DefaultImpl(sender, e);
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

        #region DTO查询应用开发人员扩展代码段

        internal string CustomFilterOpath_Extend()
        {
            string filterOpath = "";
            filterOpath += ((InvInfoQueryDQryUIFormWebPart) (this.CurrentPart)).GetTreeOPath();
            return filterOpath;
        }

        private void AfterQryAdjust_Extend(IUFDataGrid UIGrid)
        {
        }


        private void BeforeGetQryModel_Extend(DTOQueryStrategyImpl dtoQryStrategyImpl)
        {
        }

        private void AfterGetQueryModel_Extend(CaseModel caseModel)
        {
        }

        #endregion
    }
}