

namespace UFIDA.U9.XMJL.FA.AssetCardAddMemoPlugUI
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Collections.Specialized;
    using UFSoft.UBF.UI.ControlModel;
    using UFSoft.UBF.UI.WebControlAdapter;
    using UFSoft.UBF.UI.WebControls.ClientCallBack;
    using UFSoft.UBF.UI.WebControls.Association;
    using System.Web.UI.WebControls.WebParts;
    using UFSoft.UBF.UI.IView;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using UFSoft.UBF.UI.Controls;
    using UFSoft.UBF.UI.WebControls;
    using UFSoft.UBF.UI.Engine.Builder;
    using UFIDA.U9.UI.PDHelper;
    using UFSoft.UBF.UI.MD.Runtime;


    public partial class FA_AssetCardMainUIFormWebPart
    {

        #region 字段与属性
        private UFIDA.U9.EAM.FA.FA_AssetCardUIModel.FA_AssetCardMainUIFormWebPart _strongPart;
        #endregion


        private void Do_AfterDataLoad(UFSoft.UBF.UI.IView.IPart Part)
        {
            #region 获取相关强类型数据

            _strongPart = Part as UFIDA.U9.EAM.FA.FA_AssetCardUIModel.FA_AssetCardMainUIFormWebPart;
            if (_strongPart == null)
                return;
            IUFTabPage MemoPage = new UFWebTabPageAdapter();
            IUFTabControl _TabControl = (IUFTabControl)_strongPart.FindControl("TabControl2");

            _TabControl.TabPages.Add(MemoPage);
            MemoPage.Title = "备注";
            MemoPage.ID = "MemoPage10";
            MemoPage.UIViewName = "AssetCard";
            //MemoPage = UIControlBuilder.BuildTabPageControl(_TabControl, "MemoPage10", true, true, "3", "5As405cd-9cs6-49e8-83t2-8671ca8f00f5", "5aa405ad-9rf6-49b8-83d2-867s7a8f00f5");
            CommonBuilder.ContainerGridLayoutPropBuilder(MemoPage, 3, 3, 0, 5, 5, 2, 5, 2);
            _strongPart.InitViewBindingContainer(_strongPart, MemoPage, _strongPart.Model.AssetCard, "AssetCard", "", null, 1, "资产卡片");
            UIControlBuilder.BuildContainerGridLayout(MemoPage, 5, new GridColumnDef[] { new GridColumnDef(70, bool.Parse("True")), new GridColumnDef(15, bool.Parse("True")), new GridColumnDef(860, bool.Parse("True")) }, new GridRowDef[] { new GridRowDef(20, bool.Parse("True")), new GridRowDef(20, bool.Parse("True")), new GridRowDef(20, bool.Parse("True")) });
            IUFLabel lblMemo111 = UIControlBuilder.BuilderUFLabel(MemoPage, "lblMemo187", "", "True", "True", "Right", 70, 20, 0, 0, 1, 1, "90", "34a05s0b-c286-4ef5-881e-1e4e4a8f7b58",
                "1149017d-0se1-4f4c-88cc-89d0cdd60et1");
            UIControlBuilder.BuilderUFControl(lblMemo111, "1");
            lblMemo111.Text = "备&nbsp注";
            IUFFldTextBox Memo111 = UIControlBuilder.BuilderTextBox(MemoPage, "Memo187", "True", "True", "True", "True", "Left", 0, 60, 0, 600, 70, 2, 0, 1, 3, "True", "90", 
                "",TextBoxMode.MultiLine, TextAlign.Left, true, false, "lblMemo187", "", "800", "34a05s0b-c286-4tf5-881d-1e4e4a8f7b58", "ca9s9866-t446-4468-bs3a-df9b1749d3b4");
            UIControlBuilder.BuilderUFControl(Memo111, "2");
            UIControlBuilder.BuilderUIFieldBindingControl(_strongPart, Memo111, "False", "DescFlexField_PrivateDescSeg1", _strongPart.Model.AssetCard, _strongPart.Model.AssetCard.FieldDescFlexField_PrivateDescSeg1,"AssetCard");
            //Memo111.Value = _strongPart.Model.AssetCard.FocusedRecord.DescFlexField_PrivateDescSeg1;      
            _strongPart.DataBind();
            Random random = new Random();
            int js = random.Next(1, 1000);
            if (_strongPart.Model.AssetCard.FocusedRecord != null)
            {
                UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(_strongPart, _strongPart.GetType(),
                         "JavaScriptExecQueue"+js, "$('#u_M_p0_Memo187_textbox').val('" + _strongPart.Model.AssetCard.FocusedRecord.DescFlexField_PrivateDescSeg1 + "');", true);
            }
        }
        //public override void AfterRender(IPart Part, EventArgs args)
        //{
        //    //base.AfterRender(Part, args);
        //    _strongPart = Part as UFIDA.U9.EAM.FA.FA_AssetCardUIModel.FA_AssetCardMainUIFormWebPart;
        //    Random random = new Random();
        //    int js = random.Next(1, 1000);
        //    if (_strongPart.Model.AssetCard.FocusedRecord != null)
        //    {
        //        UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(_strongPart, _strongPart.GetType(),
        //                 "JavaScriptExecQueue" + js, "$('#u_M_p0_Memo187_textbox').val('" + _strongPart.Model.AssetCard.FocusedRecord.DescFlexField_PrivateDescSeg1 + "');", true);
        //    }
        //}
        //箭头事件
        public override void BeforeEventProcess(IPart Part, string eventName, object sender, EventArgs args, out bool executeDefault)
        {
            base.BeforeEventProcess(Part, eventName, sender, args, out executeDefault);
            IUFButton btn = sender as IUFButton;
            if (btn == null) return;
            switch (btn.Action)
            {
                case "SaveClick":
                    _strongPart.Model.AssetCard.FocusedRecord.DescFlexField_PrivateDescSeg1 =
                        _strongPart.Model.AssetCard.FocusedRecord.DescFlexField_PrivateDescSeg1.Replace("(LangType:zh-CN LangValue:", "").Replace(" State:0 )", "");
                    break;
            }
        }

            #endregion
        //public void str_Changed(object sender, EventArgs e)
        //{
        //    if (_strongPart.FindControl("Memo187") != null)
        //    {
        //        var sa = _strongPart.FindControl("Memo187") as UFWebTextBoxAdapter;
        //        _strongPart.Model.AssetCard.FocusedRecord.DescFlexField_PrivateDescSeg1 = sa.Value.ToString();
        //    }

        //} 

    }

}

