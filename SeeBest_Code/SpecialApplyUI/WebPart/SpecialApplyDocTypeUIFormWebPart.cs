


using System;
using System.Text;
using System.Collections;
using System.Xml;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Threading;

using Telerik.WebControls;
using UFSoft.UBF.UI.WebControls;
using UFSoft.UBF.UI.WebControls.InterActionComponenet;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.Util.Context;

//using MagicAjax.UI.Controls;
using UFSoft.UBF.Report.UI.ReportView.Web;
using UFSoft.UBF.UI.WebControlAdapter;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI.IView;
using UFSoft.UBF.UI.Engine;
using UFSoft.UBF.UI.Engine.Builder;
using UFSoft.UBF.UI.Engine.Authorization;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.Controls;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.ClientCallBack;
using System.Web.UI;
using UFSoft.UBF.UI.UIFormPersonalization;
using System.Collections.Specialized;


/***********************************************************************************************
 * Form ID:dc378576-49be-43be-b4e5-577f0a1528ea 
 * Form Name:SpecialApplyDocTypeUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.SpecialApplyUI.SpecialApplyDocTypeUIModel
{
	[FormRegister("UFIDA.U9.Cust.SpecialApplyUI","UFIDA.U9.Cust.SpecialApplyUI.SpecialApplyDocTypeUIModel.SpecialApplyDocTypeUIFormWebPart", "UFIDA.U9.Cust.SpecialApplyUI.WebPart", "dc378576-49be-43be-b4e5-577f0a1528ea","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.SpecialApplyUI', 'UFIDA.U9.Cust.SpecialApplyUI.SpecialApplyDocTypeUIModel.SpecialApplyDocTypeUIFormWebPart', 'UFIDA.U9.Cust.SpecialApplyUI.WebPart', 'dc378576-49be-43be-b4e5-577f0a1528ea')
	///<siteMapNode url="~/erp/simple.aspx?lnk=dc378576-49be-43be-b4e5-577f0a1528ea" title="SpecialApplyDocTypeUIForm"/>
    public partial class SpecialApplyDocTypeUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(SpecialApplyDocTypeUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new SpecialApplyDocTypeUIModelAction Action
		{
			get { return (SpecialApplyDocTypeUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		SpecialApplyDocTypeUIModelModel _uimodel=null;
		public new SpecialApplyDocTypeUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new SpecialApplyDocTypeUIModelModel();
			     }
			     return _uimodel; 
			}
			set { _uimodel = value; }
		}
        protected override IUIModel UIModel{
            get{
                return this.Model;
            }
            set{
                this.Model = value as SpecialApplyDocTypeUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFToolbar Toolbar2;
        IUFButton BtnSave;
        IUFButton BtnCancel;
        IUFButton BtnAdd;
        IUFButton BtnDelete;
        IUFSeparator Separator0;
        IUFButton BtnCopy;
        IUFSeparator Separator1;
        IUFSeparator Separator2;
        IUFButton BtnFind;
        IUFButton BtnList;
        IUFSeparator Separator3;
        IUFButton BtnFirstPage;
        IUFButton BtnPrevPage;
        IUFButton BtnNextPage;
        IUFButton BtnLastPage;
        IUFSeparator Separator4;
        IUFButton BtnAttachment;
        IUFSeparator Separator5;
        IUFButton BtnOutput;
        IUFButton BtnPrint;
        IUFCard Card0;
        IUFButton BtnOk;
        IUFButton BtnClose;
        IUFCard Card2;
        IUFLabel lblID62;
        IUFFldNumberControl ID62;
        IUFLabel lblSysVersion79;
        IUFFldNumberControl SysVersion79;
        IUFLine Line0;
        IUFLabel lblCode64;
        IUFFldTextBox Code64;
        IUFLabel lblName58;
        IUFFldTextBox Name58;
        IUFLabel lblShortName64;
        IUFFldTextBox ShortName64;
        IUFLabel lblDescription49;
        IUFFldTextBox Description49;
        IUFLine Line1;
        IUFLabel lblConfirmType67;
        IUFFldDropDownList ConfirmType67;
        IUFLabel lblApproveType70;
        IUFFldDropDownList ApproveType70;
        IUFLine Line2;
        IUFLabel lblEffective_IsEffective37;
        IUFFldCheckBox Effective_IsEffective37;
        IUFLabel lblEffective_EffectiveDate61;
        IUFFldDatePicker Effective_EffectiveDate61;
        IUFLabel lblEffective_DisableDate49;
        IUFFldDatePicker Effective_DisableDate49;
        IUFFldFlexFieldPicker FlexFieldPicker0;
        IUFLabel lblAdvDocEnum118;
        IUFFldDropDownList AdvDocEnum118;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public SpecialApplyDocTypeUIFormWebPart()
        {
            FormID = "dc378576-49be-43be-b4e5-577f0a1528ea";
            IsAutoSize = bool.Parse("True");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.BtnSave.Click += new EventHandler(BtnSave_Click);		
						
				//Button控件事件
			this.BtnCancel.Click += new EventHandler(BtnCancel_Click);		
						
				//Button控件事件
			this.BtnAdd.Click += new EventHandler(BtnAdd_Click);		
						
				//Button控件事件
			this.BtnDelete.Click += new EventHandler(BtnDelete_Click);		
						
				//Button控件事件
			this.BtnCopy.Click += new EventHandler(BtnCopy_Click);		
						
				//Button控件事件
			this.BtnFind.Click += new EventHandler(BtnFind_Click);		
						
				//Button控件事件
			this.BtnList.Click += new EventHandler(BtnList_Click);		
						
				//Button控件事件
			this.BtnFirstPage.Click += new EventHandler(BtnFirstPage_Click);		
						
				//Button控件事件
			this.BtnPrevPage.Click += new EventHandler(BtnPrevPage_Click);		
						
				//Button控件事件
			this.BtnNextPage.Click += new EventHandler(BtnNextPage_Click);		
						
				//Button控件事件
			this.BtnLastPage.Click += new EventHandler(BtnLastPage_Click);		
						
				//Button控件事件
			this.BtnAttachment.Click += new EventHandler(BtnAttachment_Click);		
						
				//Button控件事件
			this.BtnOutput.Click += new EventHandler(BtnOutput_Click);		
						
				//Button控件事件
			this.BtnPrint.Click += new EventHandler(BtnPrint_Click);		
						
				//Button控件事件
			this.BtnOk.Click += new EventHandler(BtnOk_Click);		
						
				//Button控件事件
			this.BtnClose.Click += new EventHandler(BtnClose_Click);		
						

	
            AfterEventBind();
        }
        #endregion            
        
		#region override method
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad2(e);
		}
		protected override void OnLoadDataDo(EventArgs e)
		{
		    adjust.ProcessAdjustBeforeOnLoad(this);
			if (UIEngineHelper.IsDataBind(PageStatus, this))
			{
				if(this.Model==null){				        
					this.Model = new SpecialApplyDocTypeUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{new InParameterModel("SpecialApplyDocType"),},new InParameterModel[]{new InParameterModel("SpecialApplyDocType","@ID","ID"),});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (SpecialApplyDocTypeUIModelModel)this.CurrentState[this.TaskId.ToString()];
			}
			adjust.ProcessAdjustAfterOnLoadData(this);
		            AfterOnLoad();
            
            adjust.ProcessAdjustAfterOnLoad(this);
		}
		protected override void OnPreRender(EventArgs e)
		{
			base.OnPreRender2(e);
		}
        protected override void OnPreRenderDo(EventArgs e)
        {
            adjust.ProcessAdjustBeforeOnPreRender(this);
			base.OnPreRender(e);
    		if(this.Consumer.Count > 0 && this.IsConsuming)
			{
				OnPreRenderConsumer(new InParameterModel[]{new InParameterModel("SpecialApplyDocType"),},new InParameterModel[]{new InParameterModel("SpecialApplyDocType","@ID","ID"),});
				OnLoadData(this);//对吗？
			}
			this.CurrentState[this.TaskId.ToString()] = this.Model;
			RegisterClearWebPartPadding();
            UFIDA.U9.UI.PDHelper.FormAuthorityHelper.SetWebPartAuthorization(this);
            
			if (IsDataBinding) //2006-9-7 可由开发人员控制
			{
				BeforeUIModelBinding();
				//BtnFind对应隐藏域的数据传递。:True
				UFIDA.U9.UI.PDHelper.CommonReferenceHelper.BindingBtnFindParam(this);
								if(!Page.IsPostBack)
				{
					EnumTypeBinding.BindEnumControls(this);
				}
				UFIDA.U9.UI.Commands.CommandHelper.BindFlexData(this);
				adjust.ProcessAdjustBeforeDataBinding(this);
				if (this.IsOnlyDataBinding)
				{
					this.DataBinding();
				}
				adjust.ProcessAdjustAfterDataBinding(this);

				AfterUIModelBinding();
			}
			adjust.ProcessAdjustAfterOnPreRender(this);
        }
		protected override void OnInit(EventArgs e)
		{
			base.OnInit2(e);
		}
		protected override void OnInitDo(EventArgs e)
		{			 
			this.Page.InitComplete += new EventHandler(Page_InitComplete);
			WebPartBuilder.InitWebPart(this);
            this.Action = new SpecialApplyDocTypeUIModelAction(this);
            adjust = new FormAdjust();
		    CreateFormChildControls();
		}
        void Page_InitComplete(object sender, EventArgs e)
        {

            adjust.ProcessInit(this);
        }
        #endregion

      
        
        #endregion

	
		/// <summary>
        /// WebPart View
        /// </summary>
        #region view Create Contorls
        private void CreateFormChildControls()
        {
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"SpecialApplyDocTypeUIForm",true,992,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(28,bool.Parse("True")),new GridRowDef(421,bool.Parse("False")),new GridRowDef(25,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Toolbar2(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Toolbar2, "1");		


	
			_BuilderControl_Card0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card0, "3");		


	
			_BuilderControl_Card2(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card2, "2");		



			
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







				        
        private void _BuilderControl_Toolbar2(IUFContainer container)
        {
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar2",true, true, "1",992, 28, 0, 0, 1, 1,"100");
            this.Toolbar2 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 28,"1", "",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","e2e1e75f-bc51-4130-be18-ca611090c5fe");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	                            this.BtnCancel = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCancel", "True", "True", 35, 28,"2", "",true,false,"f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","e5683246-0970-42a5-bdda-43d8c8481c87");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCancel);
            this.BtnCancel.UIModel = this.Model.ElementID;
            this.BtnCancel.Action = "CancelClick";
	                            this.BtnAdd = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAdd", "True", "True", 35, 28,"3", "",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","390cd6dd-6c4a-4024-917d-7b7349850a87");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAdd);
            this.BtnAdd.UIModel = this.Model.ElementID;
            this.BtnAdd.Action = "NewClick";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"4", "",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","97b45697-1ef4-4cc4-89ff-2bdb647657f8");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "DeleteClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnCopy = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCopy", "True", "True", 35, 28,"6", "",true,false,"be9f8d20-e484-464b-9818-a2c1b599b967","be9f8d20-e484-464b-9818-a2c1b599b967","135552a4-cd97-44ae-a588-900b1cae4600");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCopy);
            this.BtnCopy.UIModel = this.Model.ElementID;
            this.BtnCopy.Action = "CopyClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFind = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFind", "True", "True", 35, 28,"12", "",true,false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","7b47cabf-591f-4543-bb10-dadc25b64fd7");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFind);
            this.BtnFind.UIModel = this.Model.ElementID;
            this.BtnFind.Action = "FindClick";
	                            this.BtnList = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnList", "True", "True", 35, 28,"13", "",true,false,"c639596b-5a8c-4fc1-88bb-a3d670cda992","c639596b-5a8c-4fc1-88bb-a3d670cda992","d477d7a0-ea49-4e53-8977-b7915d8308c1");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnList);
            this.BtnList.UIModel = this.Model.ElementID;
            this.BtnList.Action = "ListClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFirstPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFirstPage", "True", "True", 35, 28,"15", "",true,false,"f229e163-fcd1-4f6a-a645-df86c0efd8ec","f229e163-fcd1-4f6a-a645-df86c0efd8ec","729d86a3-e384-4108-bb06-228221109199");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFirstPage);
            this.BtnFirstPage.UIModel = this.Model.ElementID;
            this.BtnFirstPage.Action = "FirstPage";
	                            this.BtnPrevPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrevPage", "True", "True", 35, 28,"16", "",true,false,"5ed368d8-7616-4696-b671-3f1c895f3b43","5ed368d8-7616-4696-b671-3f1c895f3b43","89085929-d451-4dae-a411-16b4de2afdac");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrevPage);
            this.BtnPrevPage.UIModel = this.Model.ElementID;
            this.BtnPrevPage.Action = "PrevPage";
	                            this.BtnNextPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnNextPage", "True", "True", 35, 28,"17", "",true,false,"36afec41-957c-493a-97a4-eddb136af5b4","36afec41-957c-493a-97a4-eddb136af5b4","8272fcc1-ba37-4657-85a8-6970cda38a1d");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnNextPage);
            this.BtnNextPage.UIModel = this.Model.ElementID;
            this.BtnNextPage.Action = "NextPage";
	                            this.BtnLastPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnLastPage", "True", "True", 35, 28,"18", "",true,false,"dc4a37d1-35de-4016-81dd-582aef3cdeb0","dc4a37d1-35de-4016-81dd-582aef3cdeb0","2e1554ca-0a6b-4adf-88bb-863ddf2cee0b");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnLastPage);
            this.BtnLastPage.UIModel = this.Model.ElementID;
            this.BtnLastPage.Action = "LastPage";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnAttachment = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAttachment", "True", "True", 35, 28,"20", "",true,false,"92ccef79-ad54-438c-a16e-20a4fd407b97","92ccef79-ad54-438c-a16e-20a4fd407b97","4050ff12-26ac-4a86-8dcb-0431ad823092");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAttachment);
            this.BtnAttachment.UIModel = this.Model.ElementID;
            this.BtnAttachment.Action = "AttachmentClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnOutput = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnOutput", "True", "True", 35, 28,"23", "",true,false,"688fd549-5a92-49cc-8072-6d5377f6409a","688fd549-5a92-49cc-8072-6d5377f6409a","67c0fc13-6698-4bad-aa54-ea07b40df198");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnOutput);
            this.BtnOutput.UIModel = this.Model.ElementID;
            this.BtnOutput.Action = "OutputClick";
	                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 28,"24", "",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","ec53bbf8-78d8-494d-8780-fafdfe07f644");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "PrintClick";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"FunctionBar", true, true, "3","","a6344b55-f4e5-4551-8489-57f39c7a7773");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 22, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(71,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.BtnOk = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnOk", true, true, 80, 20, 18, 0, 1, 1, "100","", this.Model.ElementID,"OnOk",false,"626ebf9b-f65a-4dd5-8f32-96f84919878c","626ebf9b-f65a-4dd5-8f32-96f84919878c","41da13df-383b-41ad-88db-cc034cfb5bf1");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnOk, "9");		


				this.BtnClose = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnClose", true, true, 80, 20, 20, 0, 1, 1, "100","Z", this.Model.ElementID,"OnClose",false,"020a5365-8f12-4970-b8df-17ce3ae60a68","020a5365-8f12-4970-b8df-17ce3ae60a68","fdb260ab-bf88-41a3-9dc2-ae6a589bc2e1");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnClose, "10");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card2(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card2",true,"none", true, true, "2","e4ab52a9-9a02-4a6a-87a4-07e8399dab83","988c6e4c-1858-43c4-9725-88fd35bba475");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 421, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 12, 17, 0, 5, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.SpecialApplyDocType, "SpecialApplyDocType", "", null, 1, "专柜申请单单据类型");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(19,bool.Parse("False")),});
            this.Card2 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblID62 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID62", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","e4ab52a9-9a02-4a6a-87a4-07e8399dab83","ae1e2958-102e-4ea0-85c1-f8fbb969e428");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID62, "0");		


				this.ID62 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID62", "False", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID62","8.0","e4ab52a9-9a02-4a6a-87a4-07e8399dab83","4d236682-536d-4166-809a-6b27135c5d5e",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID62, "False", "ID", this.Model.SpecialApplyDocType, this.Model.SpecialApplyDocType.FieldID, "SpecialApplyDocType");
	
		
			UIControlBuilder.BuilderUFControl(this.ID62, "1");		
		 

				this.lblSysVersion79 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion79", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","c37a9fd9-65b7-4a22-9ac0-d54cab9f85bc","de8b4afc-5f89-4a11-960f-48ceb1b80c8d");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion79, "2");		


				this.SysVersion79 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion79", "True", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion79","8.0","c37a9fd9-65b7-4a22-9ac0-d54cab9f85bc","e38e13de-9022-40b9-8ac6-6f646b407539",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion79, "False", "SysVersion", this.Model.SpecialApplyDocType, this.Model.SpecialApplyDocType.FieldSysVersion, "SpecialApplyDocType");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion79, "3");		
		 

				this.Line0 = UIControlBuilder.BuilderUFLine(_UFCard, "Line0", 311, "Horizontal", "True", 311, 20, 0, 0, 3, 1, "100","c1532353-cb5b-4aa3-9243-7b051d4b7df9","c1532353-cb5b-4aa3-9243-7b051d4b7df9");
	

		
			UIControlBuilder.BuilderUFControl(this.Line0, "4");		


				this.lblCode64 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCode64", "", "True", "True", "Right", 153, 20, 0, 2, 1, 1, "100","c222ea85-f222-4d6b-8138-633973885eea","ec4bfb7f-db81-43ff-a0ff-2c61583fc27a");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCode64, "5");		


				this.Code64 = UIControlBuilder.BuilderTextBox(_UFCard, "Code64", "False", "True", "True", "False", "Left", 0, 60, 0, 153, 20, 2, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCode64","","50","c222ea85-f222-4d6b-8138-633973885eea","025d7054-270d-4b35-bd4b-007c6bb9f841");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Code64, "False", "Code", this.Model.SpecialApplyDocType, this.Model.SpecialApplyDocType.FieldCode, "SpecialApplyDocType");


		
			UIControlBuilder.BuilderUFControl(this.Code64, "6");		
		 

				this.lblName58 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblName58", "", "True", "True", "Right", 153, 20, 0, 3, 1, 1, "100","3884702f-4ec7-4d16-8f24-76e8f6e219ab","34deac3c-3ff9-4337-bcd3-31dd26e805a3");


								

		
			UIControlBuilder.BuilderUFControl(this.lblName58, "7");		


				this.Name58 = UIControlBuilder.BuilderTextBox(_UFCard, "Name58", "True", "True", "True", "False", "Left", 0, 60, 0, 153, 20, 2, 3, 1, 1, "True", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblName58","","50","3884702f-4ec7-4d16-8f24-76e8f6e219ab","09eba1c0-834f-4ae4-a12d-2aecbc00f6a2");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Name58, "False", "Name", this.Model.SpecialApplyDocType, this.Model.SpecialApplyDocType.FieldName, "SpecialApplyDocType");


		
			UIControlBuilder.BuilderUFControl(this.Name58, "8");		
		 

				this.lblShortName64 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblShortName64", "", "True", "True", "Right", 153, 20, 0, 4, 1, 1, "100","08549905-d51d-4747-8d1f-b9cd08649ac5","7addee3d-c14d-46e3-ad7e-ff9a6df8a337");


								

		
			UIControlBuilder.BuilderUFControl(this.lblShortName64, "9");		


				this.ShortName64 = UIControlBuilder.BuilderTextBox(_UFCard, "ShortName64", "True", "True", "True", "False", "Left", 0, 60, 0, 153, 20, 2, 4, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblShortName64","","50","08549905-d51d-4747-8d1f-b9cd08649ac5","dafda5af-00d9-4e7f-8ef9-e9dd3c6f1837");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ShortName64, "False", "ShortName", this.Model.SpecialApplyDocType, this.Model.SpecialApplyDocType.FieldShortName, "SpecialApplyDocType");


		
			UIControlBuilder.BuilderUFControl(this.ShortName64, "10");		
		 

				this.lblDescription49 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDescription49", "", "True", "True", "Right", 153, 20, 0, 5, 1, 1, "100","12557d5f-8990-4f62-9f86-44b91cd759d0","fe6b03ee-8ea0-443c-9f52-2dbcca82519e");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDescription49, "11");		


				this.Description49 = UIControlBuilder.BuilderTextBox(_UFCard, "Description49", "True", "True", "True", "True", "Left", 0, 60, 0, 153, 45, 2, 5, 1, 2, "True", "100"
			,"",TextBoxMode.MultiLine,TextAlign.Left, true,false,"lblDescription49","","50","12557d5f-8990-4f62-9f86-44b91cd759d0","7c8d78d3-d84b-46a8-bcf8-f895a45ef560");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Description49, "False", "Description", this.Model.SpecialApplyDocType, this.Model.SpecialApplyDocType.FieldDescription, "SpecialApplyDocType");


		
			UIControlBuilder.BuilderUFControl(this.Description49, "12");		
		 

				this.Line1 = UIControlBuilder.BuilderUFLine(_UFCard, "Line1", 311, "Horizontal", "True", 311, 20, 0, 7, 3, 1, "100","9c6700e2-4699-4019-a06d-1ce11fbecc0f","9c6700e2-4699-4019-a06d-1ce11fbecc0f");
	

		
			UIControlBuilder.BuilderUFControl(this.Line1, "13");		


				this.lblConfirmType67 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblConfirmType67", "", "True", "True", "Right", 153, 20, 0, 8, 1, 1, "100","acb9e620-03eb-4f30-ab1f-245f193b6325","2d13a47e-21ea-4e6c-929b-65bca8095ea2");


								

		
			UIControlBuilder.BuilderUFControl(this.lblConfirmType67, "14");		


		        this.ConfirmType67 = UIControlBuilder.BuilderDropDownList(_UFCard, "ConfirmType67", "UFIDA.U9.Base.Doc.ConfirmTypeEnum", false,  true, true, "Left", 2, 60, 0, 153, 20, 2, 8, 1, 1, "100",true,false,"lblConfirmType67","acb9e620-03eb-4f30-ab1f-245f193b6325","c50baa41-f13c-4d94-aa72-8dcac6692101");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ConfirmType67, "False", "ConfirmType", this.Model.SpecialApplyDocType, this.Model.SpecialApplyDocType.FieldConfirmType, "SpecialApplyDocType");
			EnumTypeList.Add("UFIDA.U9.Base.Doc.ConfirmTypeEnum");
			EnumControlsMap.Add(this.ConfirmType67, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.ConfirmType67, "15");		
		 

				this.lblApproveType70 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblApproveType70", "", "True", "True", "Right", 153, 20, 0, 9, 1, 1, "100","5010d348-7550-4f03-8a2a-3f2554be327a","d445331d-ea93-4c33-9208-d0b10f3147ed");


								

		
			UIControlBuilder.BuilderUFControl(this.lblApproveType70, "16");		


		        this.ApproveType70 = UIControlBuilder.BuilderDropDownList(_UFCard, "ApproveType70", "UFIDA.U9.Base.Doc.ApproveTypeEnum", true,  true, true, "Left", 2, 60, 0, 153, 20, 2, 9, 1, 1, "100",true,false,"lblApproveType70","5010d348-7550-4f03-8a2a-3f2554be327a","cc65d085-bc50-4c84-9d39-bbc2535933e8");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ApproveType70, "False", "ApproveType", this.Model.SpecialApplyDocType, this.Model.SpecialApplyDocType.FieldApproveType, "SpecialApplyDocType");
			EnumTypeList.Add("UFIDA.U9.Base.Doc.ApproveTypeEnum");
			EnumControlsMap.Add(this.ApproveType70, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.ApproveType70, "17");		
		 

				this.Line2 = UIControlBuilder.BuilderUFLine(_UFCard, "Line2", 311, "Horizontal", "True", 311, 20, 0, 10, 3, 1, "100","a208c5a3-c000-4955-a7c2-a9f0c0ac617d","a208c5a3-c000-4955-a7c2-a9f0c0ac617d");
	

		
			UIControlBuilder.BuilderUFControl(this.Line2, "18");		


				this.lblEffective_IsEffective37 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblEffective_IsEffective37", "", "True", "True", "Right", 153, 20, 0, 11, 1, 1, "100","a4c2d251-de22-41a1-8aca-5c4f153d9de5","a4c2d251-de22-41a1-8aca-5c4f153d9de5");


								

		
			UIControlBuilder.BuilderUFControl(this.lblEffective_IsEffective37, "19");		


				this.Effective_IsEffective37 = UIControlBuilder.BuilderUFCheckbox(_UFCard, "Effective_IsEffective37", true, true, "Left", 60, 0, 153, 20, 2, 11, 1, 1, "100",false,"lblEffective_IsEffective37","3fe570d8-9a4e-4c27-bb99-9cf1337bbd39","bd3508cc-bfaf-4166-8c6f-2604898a33fe");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Effective_IsEffective37, "False", "Effective_IsEffective", this.Model.SpecialApplyDocType, this.Model.SpecialApplyDocType.FieldEffective_IsEffective, "SpecialApplyDocType");
		

		
			UIControlBuilder.BuilderUFControl(this.Effective_IsEffective37, "20");		
		 

				this.lblEffective_EffectiveDate61 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblEffective_EffectiveDate61", "", "True", "True", "Right", 153, 20, 0, 12, 1, 1, "100","69271e26-dbb6-49c0-a57a-8510c3ea46ce","69271e26-dbb6-49c0-a57a-8510c3ea46ce");


								

		
			UIControlBuilder.BuilderUFControl(this.lblEffective_EffectiveDate61, "21");		


				this.Effective_EffectiveDate61 = UIControlBuilder.BuilderDatePicker(_UFCard, "Effective_EffectiveDate61", true, true, true, "Date","Left", 3, 60, 0, 153, 20, 2, 12, 1, 1, "100",true,false,"lblEffective_EffectiveDate61","8289129f-34f4-4973-81a1-26632aafb9d6","96f61486-0f47-4b51-aad0-e6dd525fd9d1");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Effective_EffectiveDate61, "False", "Effective_EffectiveDate", this.Model.SpecialApplyDocType, this.Model.SpecialApplyDocType.FieldEffective_EffectiveDate, "SpecialApplyDocType");


		
			UIControlBuilder.BuilderUFControl(this.Effective_EffectiveDate61, "22");		
		 

				this.lblEffective_DisableDate49 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblEffective_DisableDate49", "", "True", "True", "Right", 153, 20, 0, 13, 1, 1, "100","00a03aaa-7cde-46dc-85b8-339c757a3c1b","00a03aaa-7cde-46dc-85b8-339c757a3c1b");


								

		
			UIControlBuilder.BuilderUFControl(this.lblEffective_DisableDate49, "23");		


				this.Effective_DisableDate49 = UIControlBuilder.BuilderDatePicker(_UFCard, "Effective_DisableDate49", true, true, true, "Date","Left", 3, 60, 0, 153, 20, 2, 13, 1, 1, "100",true,false,"lblEffective_DisableDate49","f9e6dcea-fafa-4950-a5fa-85d1e709cd96","2322bd62-b073-4936-a8fe-0507bf4fc5e0");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Effective_DisableDate49, "False", "Effective_DisableDate", this.Model.SpecialApplyDocType, this.Model.SpecialApplyDocType.FieldEffective_DisableDate, "SpecialApplyDocType");


		
			UIControlBuilder.BuilderUFControl(this.Effective_DisableDate49, "24");		
		 

				this.FlexFieldPicker0 = UIControlBuilder.BuilderFlexFieldPicker(_UFCard, "FlexFieldPicker0", "True", "True", "True", "Left", 0, "", '.', 60, 0, 153, 20, 2, 14, 1, 1, "100"
				,FlexFieldType.Key,true,false,"","","","334375d7-a2d3-418b-8c35-475b1583bbd3");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.FlexFieldPicker0, "False", "", null, null, "");
			if(this.FlexFieldPicker0.FlexFieldType==FlexFieldType.Key)
			{

			}
			else
			{		
					}
								

		
			UIControlBuilder.BuilderUFControl(this.FlexFieldPicker0, "25");		
		 

				this.lblAdvDocEnum118 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblAdvDocEnum118", "", "True", "True", "Right", 153, 20, 0, 1, 1, 1, "100","d69b24dd-6cbe-475e-938b-b32009a1e841","7a97e772-8d66-4ac2-9436-47c79d5d6ad0");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvDocEnum118, "26");		


		        this.AdvDocEnum118 = UIControlBuilder.BuilderDropDownList(_UFCard, "AdvDocEnum118", "UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.AdvDocEnum", false,  true, true, "Left", 2, 60, 0, 153, 20, 2, 1, 1, 1, "100",true,false,"lblAdvDocEnum118","d69b24dd-6cbe-475e-938b-b32009a1e841","02af32bc-d193-462e-a992-bd176f105144");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvDocEnum118, "False", "AdvDocEnum", this.Model.SpecialApplyDocType, this.Model.SpecialApplyDocType.FieldAdvDocEnum, "SpecialApplyDocType");
			EnumTypeList.Add("UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.AdvDocEnum");
			EnumControlsMap.Add(this.AdvDocEnum118, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.AdvDocEnum118, "27");		
		 


																												

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }





		#endregion
		

	}
}
