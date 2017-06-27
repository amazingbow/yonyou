using System;
using System.Collections.Generic;
using System.Web.UI;
using Telerik.WebControls;
/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
using UFIDA.U9.CBO.SCM.Item;
using UFIDA.U9.CBO.SCM.Item.Proxy;
using UFIDA.U9.UI.PDHelper;

namespace UFIDA.U9.Cust.FJGX.InvInfoQueryDQryUIModel
{
    public partial class InvInfoQueryDQryUIFormWebPart
    {
        #region Custome eventBind

        //BtnOutPut_Click...
        private void BtnOutPut_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            BtnOutPut_Click_DefaultImpl(sender, e);
        }

        //BtnPrint_Click...
        private void BtnPrint_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            BtnPrint_Click_DefaultImpl(sender, e);
        }

        //DDLCase_TextChanged...
        private void DDLCase_TextChanged_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            DDLCase_TextChanged_DefaultImpl(sender, e);
        }

        //OnLookCase_Click...
        private void OnLookCase_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            OnLookCase_Click_DefaultImpl(sender, e);
        }

        //btnSaveCurrentQueryCase_Click...
        private void btnSaveCurrentQueryCase_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            btnSaveCurrentQueryCase_Click_DefaultImpl(sender, e);
        }

        //CategoryTree0_NodeClick...
        private void CategoryTree0_NodeClick_Extend(object sender, RadTreeNodeEventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            CategoryTree0_NodeClick_DefaultImpl(sender, e);
            this.Action.QueryAdjust();
            string script = "<script>document.getElementById('" + this.CategoryTree0.SelectedNode.ClientID + "').scrollIntoView();</script>";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "ScrollToNode", script, false);
        }

        //CategoryTree0_NodeExpand...
        private void CategoryTree0_NodeExpand_Extend(object sender, RadTreeNodeEventArgs e)
        {
            CommonReferenceHelper.NodeExpand(this.CategoryTree0, this, e.NodeClicked);
            string script = "<script>document.getElementById('" + e.NodeClicked.ClientID + "').scrollIntoView();</script>";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "ScrollToNode", script, false);
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
        }

        public void AfterCreateChildControls()
        {
            AfterCreateChildControls_Qry_DefaultImpl(); //DTO查询自动产生的代码
            CreateTree();
        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {
            BeforeUIModelBinding_Qry_DefaultImpl(); //DTO查询自动产生的代码
        }

        public void AfterUIModelBinding()
        {
            AfterUIModelBinding_Qry_DefaultImpl(); //DTO查询自动产生的代码
        }

        #endregion

        #region 属性

        private ItemCategoryInfoDTOData _categoryInfo = null;

        private ItemCategoryInfoDTOData CategoryInfo
        {
            get
            {
                if (this._categoryInfo != null) return this._categoryInfo;
                GetItemCategoryInfo4ItemUIBPProxy proxy = new GetItemCategoryInfo4ItemUIBPProxy();
                this._categoryInfo = proxy.Do();
                return this._categoryInfo;
            }
        }


        #endregion

        #region 方法

        /// <summary>
        /// 创建树
        /// </summary>
        private void CreateTree()
        {
            CommonReferenceHelper.CreateTree(this.CategoryTree0, this);
        }

        /// <summary>
        /// 创建树
        /// </summary>
        /// <param name="list"></param>
        /// <param name="nodes"></param>
        /// <param name="parentID"></param>
        private void CreateTree(List<ItemCategoryTreeDTOData> list, RadTreeNodeCollection nodes, long parentID)
        {
            foreach (ItemCategoryTreeDTOData current in list)
            {
                if (current.ParentID != parentID) continue;
                RadTreeNode radTreeNode = new RadTreeNode(current.Code + " " + current.Name, current.Code);
                radTreeNode.ExpandMode = ExpandMode.ServerSide;
                nodes.Add(radTreeNode);
                this.CreateTree(list, radTreeNode.Nodes, current.ID);
            }
        }

        internal string GetTreeOPath()
        {
            string result;
             if (this.CategoryTree0.SelectedNode == null || string.IsNullOrEmpty(this.CategoryTree0.SelectedNode.Value))
            {
                result = "";
            }
            else
            {
                result = string.Concat(new object[]
				{
					"ItemMaster.MainItemCategory.Segment",
					this.CategoryInfo.SegmentNum,
					" like '",
					this.CategoryTree0.SelectedNode.Value,
					"%'"
				});
            }
            return result;
        }


        #endregion

        #endregion
    }
}