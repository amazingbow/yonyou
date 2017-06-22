


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
 * Form ID:8167d4d5-c646-47b4-8ac0-570732c35302 
 * Form Name:AdvApproveUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.AdvApproveUI.AdvApproveUIModel
{
	[FormRegister("UFIDA.U9.Cust.AdvApproveUI","UFIDA.U9.Cust.AdvApproveUI.AdvApproveUIModel.AdvApproveUIFormWebPart", "UFIDA.U9.Cust.AdvApproveUI.WebPart", "8167d4d5-c646-47b4-8ac0-570732c35302","WebPart", "True", 1200, 536)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.AdvApproveUI', 'UFIDA.U9.Cust.AdvApproveUI.AdvApproveUIModel.AdvApproveUIFormWebPart', 'UFIDA.U9.Cust.AdvApproveUI.WebPart', '8167d4d5-c646-47b4-8ac0-570732c35302')
	///<siteMapNode url="~/erp/simple.aspx?lnk=8167d4d5-c646-47b4-8ac0-570732c35302" title="AdvApproveUIForm"/>
    public partial class AdvApproveUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(AdvApproveUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new AdvApproveUIModelAction Action
		{
			get { return (AdvApproveUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		AdvApproveUIModelModel _uimodel=null;
		public new AdvApproveUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new AdvApproveUIModelModel();
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
                this.Model = value as AdvApproveUIModelModel;
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
        IUFButton BtnSubmit;
        IUFButton BtnApprove;
        IUFButton BtnUndoApprove;
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
        IUFButton BtnFlow;
        IUFSeparator Separator5;
        IUFButton BtnOutput;
        IUFButton BtnPrint;
        IUFCard Card4;
        IUFCard Card2;
        IUFLabel lblAdvApplyCust95;
        IUFFldReference AdvApplyCust95;
        IUFButton BtnGetApplyInfo;
        IUFFldFlexFieldPicker FlexFieldPicker0;
        IUFLabel lblID167;
        IUFFldNumberControl ID167;
        IUFLabel lblSysVersion257;
        IUFFldNumberControl SysVersion257;
        IUFLabel lblDocStatus224;
        IUFFldDropDownList DocStatus224;
        IUFLabel lblAdvApproveDocType803;
        IUFFldReference AdvApproveDocType803;
        IUFLabel lblStartDate230;
        IUFFldDatePicker StartDate230;
        IUFLabel lblEndDate212;
        IUFFldDatePicker EndDate212;
        IUFDataGrid DataGrid0;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public AdvApproveUIFormWebPart()
        {
            FormID = "8167d4d5-c646-47b4-8ac0-570732c35302";
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
			this.BtnSubmit.Click += new EventHandler(BtnSubmit_Click);		
						
				//Button控件事件
			this.BtnApprove.Click += new EventHandler(BtnApprove_Click);		
						
				//Button控件事件
			this.BtnUndoApprove.Click += new EventHandler(BtnUndoApprove_Click);		
						
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
			this.BtnFlow.Click += new EventHandler(BtnFlow_Click);		
						
				//Button控件事件
			this.BtnOutput.Click += new EventHandler(BtnOutput_Click);		
						
				//Button控件事件
			this.BtnPrint.Click += new EventHandler(BtnPrint_Click);		
						
				//Button控件事件
			this.BtnGetApplyInfo.Click += new EventHandler(BtnGetApplyInfo_Click);		
						

		
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid0).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid0_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid0).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid0_GridCustomFilterHandler);

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
					this.Model = new AdvApproveUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (AdvApproveUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new AdvApproveUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"AdvApproveUIForm",true,1200,536);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 8, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 8,new GridColumnDef[]{new GridColumnDef(1000,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(28,bool.Parse("True")),new GridRowDef(441,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Toolbar2(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Toolbar2, "1");		


	
			_BuilderControl_Card4(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card4, "2");		



		
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







				        
        private void _BuilderControl_Toolbar2(IUFContainer container)
        {
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar2",true, true, "1",1000, 28, 0, 0, 1, 1,"100");
            this.Toolbar2 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 28,"1", "S",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","9e47da67-8390-486a-9510-a62aab90e3a5");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	                            this.BtnCancel = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCancel", "True", "True", 35, 28,"2", "Z",true,false,"f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","3ac0d522-56dd-4a91-9edf-730d4407f89a");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCancel);
            this.BtnCancel.UIModel = this.Model.ElementID;
            this.BtnCancel.Action = "CancelClick";
	                            this.BtnAdd = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAdd", "True", "True", 35, 28,"3", "N",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","8cede890-8e96-44c7-99dc-5323801e1c6e");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAdd);
            this.BtnAdd.UIModel = this.Model.ElementID;
            this.BtnAdd.Action = "NewClick";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"4", "R",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","ccb992bf-9514-4e7b-b8a1-a4278c6ab85c");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "DeleteClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnCopy = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCopy", "True", "True", 35, 28,"6", "C",true,false,"be9f8d20-e484-464b-9818-a2c1b599b967","be9f8d20-e484-464b-9818-a2c1b599b967","1680d5ab-7ba4-4460-8b65-941612d0077c");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCopy);
            this.BtnCopy.UIModel = this.Model.ElementID;
            this.BtnCopy.Action = "CopyClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnSubmit = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSubmit", "True", "True", 35, 28,"8", "T",true,false,"c42c0f21-2fd7-49b2-ac54-62f811747b18","c42c0f21-2fd7-49b2-ac54-62f811747b18","fade0ee7-10de-430c-a958-14c65ebee526");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSubmit);
            this.BtnSubmit.UIModel = this.Model.ElementID;
            this.BtnSubmit.Action = "SubmitClick";
	                            this.BtnApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnApprove", "True", "True", 35, 28,"9", "Y",true,false,"eb678a04-c7e1-44f1-b175-8f90f9903862","eb678a04-c7e1-44f1-b175-8f90f9903862","ada78297-df0b-471e-a076-02b810aeb7e1");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnApprove);
            this.BtnApprove.UIModel = this.Model.ElementID;
            this.BtnApprove.Action = "ApproveClick";
	                            this.BtnUndoApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnUndoApprove", "True", "True", 35, 28,"10", "",true,false,"ae796775-bce3-4aed-89a9-20eaa4648a67","ae796775-bce3-4aed-89a9-20eaa4648a67","a33bf9e3-bf10-45bb-a1c0-b5d43114ede0");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnUndoApprove);
            this.BtnUndoApprove.UIModel = this.Model.ElementID;
            this.BtnUndoApprove.Action = "UndoApproveClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFind = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFind", "True", "True", 35, 28,"12", "F",true,false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","705701cb-c354-4512-8c66-7b4b4d3464e1");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFind);
            this.BtnFind.UIModel = this.Model.ElementID;
            this.BtnFind.Action = "FindClick";
	                            this.BtnList = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnList", "True", "True", 35, 28,"13", "L",true,false,"c639596b-5a8c-4fc1-88bb-a3d670cda992","c639596b-5a8c-4fc1-88bb-a3d670cda992","5a9197af-dd28-4ac7-a0b6-a45b5d6434a9");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnList);
            this.BtnList.UIModel = this.Model.ElementID;
            this.BtnList.Action = "ListClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFirstPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFirstPage", "True", "True", 35, 28,"15", "[",true,false,"f229e163-fcd1-4f6a-a645-df86c0efd8ec","f229e163-fcd1-4f6a-a645-df86c0efd8ec","318d93a9-a4e9-4b6f-bdc7-5f71b4cee032");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFirstPage);
            this.BtnFirstPage.UIModel = this.Model.ElementID;
            this.BtnFirstPage.Action = "FirstPage";
	                            this.BtnPrevPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrevPage", "True", "True", 35, 28,"16", ",",true,false,"5ed368d8-7616-4696-b671-3f1c895f3b43","5ed368d8-7616-4696-b671-3f1c895f3b43","94ac4ddd-5f16-4398-af5e-0bc9f97f4554");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrevPage);
            this.BtnPrevPage.UIModel = this.Model.ElementID;
            this.BtnPrevPage.Action = "PrevPage";
	                            this.BtnNextPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnNextPage", "True", "True", 35, 28,"17", ".",true,false,"36afec41-957c-493a-97a4-eddb136af5b4","36afec41-957c-493a-97a4-eddb136af5b4","80f0be4d-c91c-4862-8095-48e6d81098fc");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnNextPage);
            this.BtnNextPage.UIModel = this.Model.ElementID;
            this.BtnNextPage.Action = "NextPage";
	                            this.BtnLastPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnLastPage", "True", "True", 35, 28,"18", "]",true,false,"dc4a37d1-35de-4016-81dd-582aef3cdeb0","dc4a37d1-35de-4016-81dd-582aef3cdeb0","9e80405b-2d25-404c-8bac-943168b6da0d");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnLastPage);
            this.BtnLastPage.UIModel = this.Model.ElementID;
            this.BtnLastPage.Action = "LastPage";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnAttachment = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAttachment", "True", "True", 35, 28,"20", "A",true,false,"92ccef79-ad54-438c-a16e-20a4fd407b97","92ccef79-ad54-438c-a16e-20a4fd407b97","6d5ebd61-b56c-44c4-ab54-4d1683003fb3");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAttachment);
            this.BtnAttachment.UIModel = this.Model.ElementID;
            this.BtnAttachment.Action = "AttachmentClick";
	                            this.BtnFlow = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFlow", "True", "True", 35, 28,"21", "F",true,false,"e222698c-ae3c-470a-8053-1b69905c510a","e222698c-ae3c-470a-8053-1b69905c510a","6b84977c-e680-4774-86fc-a1373ed089b1");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFlow);
            this.BtnFlow.UIModel = this.Model.ElementID;
            this.BtnFlow.Action = "FlowClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnOutput = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnOutput", "True", "True", 35, 28,"23", "O",true,false,"688fd549-5a92-49cc-8072-6d5377f6409a","688fd549-5a92-49cc-8072-6d5377f6409a","09996dd6-a396-4783-89f2-1301d48580bd");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnOutput);
            this.BtnOutput.UIModel = this.Model.ElementID;
            this.BtnOutput.Action = "OutputClick";
	                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 28,"24", "P",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","74811945-bcf9-4359-99ca-fbc59dca4ef2");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "PrintClick";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card4(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card4",false,"none", true, true, "2","","ebadcadd-0caf-427e-9df3-f397f136a7b4");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 1000, 441, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 2, 3, 0, 10, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 10,new GridColumnDef[]{new GridColumnDef(971,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(83,bool.Parse("True")),new GridRowDef(328,bool.Parse("True")),new GridRowDef(1,bool.Parse("False")),});
            this.Card4 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_Card2(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.Card2, "1");		


	
			_BuilderControl_DataGrid0(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid0, "2");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card2(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card2",true,"none", true, true, "1","54043f33-6248-4fda-9b0f-be0e8c952b0b","037ee0af-a2d2-4b48-b3c7-5b13c96444db");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 972, 83, 0, 0, 2, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 13, 3, 0, 10, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.AdvApproveBE, "AdvApproveBE", "", null, 1, "广告核销单");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 10,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(140,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(140,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(140,bool.Parse("True")),new GridColumnDef(20,bool.Parse("False")),new GridColumnDef(140,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("False")),});
            this.Card2 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblAdvApplyCust95 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblAdvApplyCust95", "", "True", "True", "Right", 100, 20, 0, 0, 1, 1, "100","54043f33-6248-4fda-9b0f-be0e8c952b0b","f4334883-93cc-4e3b-9a9e-d09856075b8e");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvApplyCust95, "0");		


				this.AdvApplyCust95 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"AdvApplyCust95",true,true, true,140, 20, 2, 0, 1, 1, "100","1",false,false,true,"lblAdvApplyCust95","54043f33-6248-4fda-9b0f-be0e8c952b0b","04702be2-013d-4d06-bc5a-f104df943d8c");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvApplyCust95, "False", "AdvApplyCust", this.Model.AdvApproveBE, this.Model.AdvApproveBE.FieldAdvApplyCust, "AdvApproveBE");
			UIControlBuilder.SetReferenceControlRefInfo(this.AdvApplyCust95,"d6428416-2436-4ab4-af0f-1464119d76e7", 580,408, "Name","Code","ID", this.Model.AdvApproveBE.FieldAdvApplyCust_Code,this.Model.AdvApproveBE.FieldAdvApplyCust_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.AdvApplyCust95,"AdvApplyCust95",new ReferenceOutputParam[]{new ReferenceOutputParam("AdvApplyCust95","ID","Key"),new ReferenceOutputParam("AdvApplyCust95","Code","Value"),new ReferenceOutputParam("AdvApplyCust95","Name","Text"),new ReferenceOutputParam("","Department_ID",""),new ReferenceOutputParam("","Department_Code",""),new ReferenceOutputParam("","Department_Name",""),new ReferenceOutputParam("","Saleser_ID",""),new ReferenceOutputParam("","Saleser_Code",""),new ReferenceOutputParam("","Saleser_Name",""),new ReferenceOutputParam("","TradeCurrency_ID",""),new ReferenceOutputParam("","TradeCurrency_Code",""),new ReferenceOutputParam("","TradeCurrency_Name",""),new ReferenceOutputParam("","ShortName",""),new ReferenceOutputParam("","CustomerCategory_Name",""),new ReferenceOutputParam("","Territory_Name",""),new ReferenceOutputParam("","TradeCurrency_Symbol",""),new ReferenceOutputParam("","TradeCurrency_PriceRound_Precision",""),new ReferenceOutputParam("","TradeCurrency_PriceRound_RoundValue",""),new ReferenceOutputParam("","TradeCurrency_PriceRound_RoundType",""),new ReferenceOutputParam("","TradeCurrency_MoneyRound_Precision",""),new ReferenceOutputParam("","TradeCurrency_MoneyRound_RoundValue",""),new ReferenceOutputParam("","TradeCurrency_MoneyRound_RoundType",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.AdvApplyCust95, "1");		
		 

				this.BtnGetApplyInfo = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnGetApplyInfo", true, true, 100, 20, 4, 2, 1, 1, "100","", this.Model.ElementID,"",false,"f4506f28-fed3-4d88-ada3-562568d14bbf","","f4506f28-fed3-4d88-ada3-562568d14bbf");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnGetApplyInfo, "6");		


				this.FlexFieldPicker0 = UIControlBuilder.BuilderFlexFieldPicker(_UFCard, "FlexFieldPicker0", "True", "True", "True", "Left", 0, "", '.', 60, 0, 140, 20, 12, 0, 1, 1, "100"
				,FlexFieldType.Key,true,false,"","","","72919895-846a-4598-9f3f-2c48a1e60528");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.FlexFieldPicker0, "False", "", null, null, "");
			if(this.FlexFieldPicker0.FlexFieldType==FlexFieldType.Key)
			{

			}
			else
			{		
					}
								

		
			UIControlBuilder.BuilderUFControl(this.FlexFieldPicker0, "7");		
		 

				this.lblID167 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID167", "", "False", "True", "Right", 100, 20, 0, 0, 1, 1, "100","bd58dc7c-7d1f-4435-a621-f51286dd0d29","edd63ffd-919c-4321-a8df-82aa7763a6b4");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID167, "10");		


				this.ID167 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID167", "False", "False", "True", "Left", 7, 60, 0, 140, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID167","8.0","bd58dc7c-7d1f-4435-a621-f51286dd0d29","2e10b39f-433b-4119-a642-ee4ce56c7599",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID167, "False", "ID", this.Model.AdvApproveBE, this.Model.AdvApproveBE.FieldID, "AdvApproveBE");
	
		
			UIControlBuilder.BuilderUFControl(this.ID167, "11");		
		 

				this.lblSysVersion257 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion257", "", "False", "True", "Right", 100, 20, 0, 0, 1, 1, "100","82ef21d4-8a05-4451-9232-50dca8de07be","da3ed156-3495-4601-a8c9-d1087b3e8c6a");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion257, "12");		


				this.SysVersion257 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion257", "True", "False", "True", "Left", 7, 60, 0, 140, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion257","8.0","82ef21d4-8a05-4451-9232-50dca8de07be","ae58f1d0-f3c1-43a8-b40d-f88556f3664b",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion257, "False", "SysVersion", this.Model.AdvApproveBE, this.Model.AdvApproveBE.FieldSysVersion, "AdvApproveBE");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion257, "13");		
		 

				this.lblDocStatus224 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDocStatus224", "", "True", "True", "Right", 100, 20, 8, 0, 1, 1, "100","e4e595ff-3cfc-4af7-9acc-31c85fc245fe","bc86fd42-7b8a-4b3f-b3a6-25f6f7eceb38");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDocStatus224, "14");		


		        this.DocStatus224 = UIControlBuilder.BuilderDropDownList(_UFCard, "DocStatus224", "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvAppStatusEnum", true,  true, true, "Left", 2, 60, 0, 140, 20, 10, 0, 1, 1, "100",true,true,"lblDocStatus224","e4e595ff-3cfc-4af7-9acc-31c85fc245fe","8086cfa4-1f00-4308-bfe4-4a7a54b4db79");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DocStatus224, "False", "DocStatus", this.Model.AdvApproveBE, this.Model.AdvApproveBE.FieldDocStatus, "AdvApproveBE");
			EnumTypeList.Add("UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvAppStatusEnum");
			EnumControlsMap.Add(this.DocStatus224, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.DocStatus224, "15");		
		 

				this.lblAdvApproveDocType803 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblAdvApproveDocType803", "", "True", "True", "Right", 100, 20, 4, 0, 1, 1, "100","752fe996-c5b0-4f32-ad7c-448cd4edde2e","fad3fc78-1156-452d-a357-b3654c64fc60");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvApproveDocType803, "16");		


				this.AdvApproveDocType803 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"AdvApproveDocType803",true,true, true,140, 20, 6, 0, 1, 1, "100","17",false,false,true,"lblAdvApproveDocType803","752fe996-c5b0-4f32-ad7c-448cd4edde2e","c7a53813-d2fc-4116-9e46-3ad45f681c43");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvApproveDocType803, "False", "AdvApproveDocType", this.Model.AdvApproveBE, this.Model.AdvApproveBE.FieldAdvApproveDocType, "AdvApproveBE");
			UIControlBuilder.SetReferenceControlRefInfo(this.AdvApproveDocType803,"741bf694-2ccf-4255-bc49-c3c5a0c067e1", 580,408, "","","ID", this.Model.AdvApproveBE.FieldAdvApproveDocType_Code,this.Model.AdvApproveBE.FieldAdvApproveDocType_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.AdvApproveDocType803,"AdvApproveDocType803",new ReferenceOutputParam[]{new ReferenceOutputParam("AdvApproveDocType803","ID","Key"),new ReferenceOutputParam("AdvApproveDocType803","Code","Value"),new ReferenceOutputParam("AdvApproveDocType803","Name","Text"),new ReferenceOutputParam("","ConfirmType",""),new ReferenceOutputParam("","ApproveType",""),new ReferenceOutputParam("","AdvDocEnum",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.AdvApproveDocType803, "17");		
		 

				this.lblStartDate230 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblStartDate230", "", "True", "True", "Right", 100, 20, 0, 1, 1, 1, "100","9b570f72-15f3-422c-a0be-8279b33ffc80","7a5cdf07-cbc0-4ade-8a75-7ecf13116f78");


								

		
			UIControlBuilder.BuilderUFControl(this.lblStartDate230, "18");		


				this.StartDate230 = UIControlBuilder.BuilderDatePicker(_UFCard, "StartDate230", true, true, true, "Date","Left", 3, 60, 0, 140, 20, 2, 1, 1, 1, "100",true,false,"lblStartDate230","9b570f72-15f3-422c-a0be-8279b33ffc80","7f805c7d-fd4d-46e5-83d7-d2eb88276b43");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.StartDate230, "False", "StartDate", this.Model.AdvApproveBE, this.Model.AdvApproveBE.FieldStartDate, "AdvApproveBE");


		
			UIControlBuilder.BuilderUFControl(this.StartDate230, "19");		
		 

				this.lblEndDate212 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblEndDate212", "", "True", "True", "Right", 100, 20, 0, 2, 1, 1, "100","e71c4f9c-74aa-401c-a523-66e4dcfa6c2a","043e9e65-3bec-4ed3-b456-3959c88b2896");


								

		
			UIControlBuilder.BuilderUFControl(this.lblEndDate212, "20");		


				this.EndDate212 = UIControlBuilder.BuilderDatePicker(_UFCard, "EndDate212", true, true, true, "Date","Left", 3, 60, 0, 140, 20, 2, 2, 1, 1, "100",true,false,"lblEndDate212","e71c4f9c-74aa-401c-a523-66e4dcfa6c2a","53209d9b-fc55-4612-89d4-7126df4c7587");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.EndDate212, "False", "EndDate", this.Model.AdvApproveBE, this.Model.AdvApproveBE.FieldEndDate, "AdvApproveBE");


		
			UIControlBuilder.BuilderUFControl(this.EndDate212, "21");		
		 


		
			this.AdvApplyCust95.IsMultiOrg  = false ;
			this.lblAdvApplyCust95.SetMultiOrgInfo(this.AdvApplyCust95,false);
			
										
			this.AdvApproveDocType803.IsMultiOrg  = false ;
			this.lblAdvApproveDocType803.SetMultiOrgInfo(this.AdvApproveDocType803,false);
			
				

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				

				

				





       
        private void _BuilderControl_DataGrid0(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid0", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, true, false,true,false,false,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "2");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 971, 328, 0, 1, 1, 1, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.AdvApproveBE_AdvApproveLine, "AdvApproveBE_AdvApproveLine", "", null, 20, "广告核销单.Misc.广告核销单行");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid0 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID168","NumberColumnModel", "", 0,this.Model.AdvApproveBE_AdvApproveLine.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "19.0",true, false,"","cd4f706b-cf8a-4f08-91e7-040297e1d4d8","cd4f706b-cf8a-4f08-91e7-040297e1d4d8","a559e8a4-5595-4ed7-a729-55f463a31af1");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion258","NumberColumnModel", "", 0,this.Model.AdvApproveBE_AdvApproveLine.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, true, 7, 100, "19.0",true, false,"0","326949eb-5fde-471b-b198-06b6b9a0272e","326949eb-5fde-471b-b198-06b6b9a0272e","84e46651-63b3-4acb-bd0f-0417dfb28d42");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ApplyAdvCode0","TextBoxColumnModel", "", 0,this.Model.AdvApproveBE_AdvApproveLine.Fields["ApplyAdvCode"]/*ApplyAdvCode*/,"ApplyAdvCode", false, true, false, false, false, true, 0, 100, "50",true, false,"","49c26963-1dc0-4523-ae55-00c31dd23c1d","49c26963-1dc0-4523-ae55-00c31dd23c1d","9e646a3f-50b3-419b-80fe-49bb50ef65da");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"AdvAppCustName0","TextBoxColumnModel", "", 0,this.Model.AdvApproveBE_AdvApproveLine.Fields["AdvAppCustName"]/*AdvAppCustName*/,"AdvAppCustName", false, true, false, false, false, true, 0, 100, "50",true, false,"","983c42d1-3efe-457b-b921-22e7d7bf0fcb","983c42d1-3efe-457b-b921-22e7d7bf0fcb","8f60e8bf-64e0-4e0a-84fb-2ec8cf1152c2");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Location0","TextBoxColumnModel", "", 0,this.Model.AdvApproveBE_AdvApproveLine.Fields["Location"]/*Location*/,"Location", false, true, false, false, false, true, 0, 100, "50",true, false,"","d0270885-cd3c-43f8-a3c1-12542e5bf66a","d0270885-cd3c-43f8-a3c1-12542e5bf66a","b0083971-7031-4fa4-8955-6ec358808867");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Country0","TextBoxColumnModel", "", 0,this.Model.AdvApproveBE_AdvApproveLine.Fields["Country"]/*Country*/,"Country", false, true, false, false, false, true, 0, 100, "50",true, false,"","8c0e33ca-10bc-4d6f-adaf-8dbc4037f3f1","8c0e33ca-10bc-4d6f-adaf-8dbc4037f3f1","264b6570-668a-4464-894b-a5745eed32e0");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CustCounterName0","TextBoxColumnModel", "", 0,this.Model.AdvApproveBE_AdvApproveLine.Fields["CustCounterName"]/*CustCounterName*/,"CustCounterName", false, true, false, false, false, true, 0, 100, "50",true, false,"","56beb045-b2fa-4356-9c6d-6b78c80318b6","56beb045-b2fa-4356-9c6d-6b78c80318b6","a8ea2148-ea36-4c21-868e-aaf8a8e7c1be");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RelPeople0","TextBoxColumnModel", "", 0,this.Model.AdvApproveBE_AdvApproveLine.Fields["RelPeople"]/*RelPeople*/,"RelPeople", false, true, false, false, false, true, 0, 100, "50",true, false,"","1a3e001b-e629-4f73-88b9-1a3eb58aaf4f","1a3e001b-e629-4f73-88b9-1a3eb58aaf4f","6ab43189-85e1-44ca-8404-9073aadd9126");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RelPhone0","TextBoxColumnModel", "", 0,this.Model.AdvApproveBE_AdvApproveLine.Fields["RelPhone"]/*RelPhone*/,"RelPhone", false, true, false, false, false, true, 0, 100, "50",true, false,"","45baf65d-d4c2-4a87-9877-cee830c95473","45baf65d-d4c2-4a87-9877-cee830c95473","9a2131ca-3aa1-4d82-b8f6-53e6d30c51f4");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CustAddress0","TextBoxColumnModel", "", 0,this.Model.AdvApproveBE_AdvApproveLine.Fields["CustAddress"]/*CustAddress*/,"CustAddress", false, true, false, false, false, true, 0, 100, "50",true, false,"","a45f2c53-bd89-427c-9702-43db83290d1f","a45f2c53-bd89-427c-9702-43db83290d1f","052790b5-24a1-4f4c-916d-d01326a9ef37");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Width0","NumberColumnModel", "", 2,this.Model.AdvApproveBE_AdvApproveLine.Fields["Width"]/*Width*/,"Width", false, true, false, false, false, true, 8, 100, "24.9",true, false,"","87ba5af0-8208-4aa7-b2cd-71b1bd7857aa","87ba5af0-8208-4aa7-b2cd-71b1bd7857aa","018f1021-3af6-4ca1-9a58-715ac08d4a75");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Thick0","NumberColumnModel", "", 2,this.Model.AdvApproveBE_AdvApproveLine.Fields["Thick"]/*Thick*/,"Thick", false, true, false, false, false, false, 8, 100, "24.9",true, false,"","b62ba3cd-9cb8-4f3e-8d49-6b5807b6c655","b62ba3cd-9cb8-4f3e-8d49-6b5807b6c655","940820be-3fe0-4127-a242-83647b64e7c6");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Height0","NumberColumnModel", "", 2,this.Model.AdvApproveBE_AdvApproveLine.Fields["Height"]/*Height*/,"Height", false, true, false, false, false, true, 8, 100, "24.9",true, false,"","555af42c-6726-45e4-b51c-e051f66f3cd9","555af42c-6726-45e4-b51c-e051f66f3cd9","d0fe35a7-9db5-482e-9deb-b5eb58e534dd");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Area0","NumberColumnModel", "", 2,this.Model.AdvApproveBE_AdvApproveLine.Fields["Area"]/*Area*/,"Area", false, true, false, false, false, true, 8, 100, "24.9",true, false,"","448b2763-2815-4bfd-9790-67152e6ea0b4","448b2763-2815-4bfd-9790-67152e6ea0b4","bb88e6ca-0f4b-4b9e-b6f6-c3836c38a0e3");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"AdvCarrier0","TextBoxColumnModel", "", 0,this.Model.AdvApproveBE_AdvApproveLine.Fields["AdvCarrier"]/*AdvCarrier*/,"AdvCarrier", false, true, false, false, false, true, 0, 100, "50",true, false,"","43420188-bde0-46d6-8af5-09ccb88795e5","43420188-bde0-46d6-8af5-09ccb88795e5","f6eb8ce4-32a7-4aeb-b139-fbd979bd6774");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"AdvItem0","TextBoxColumnModel", "", 0,this.Model.AdvApproveBE_AdvApproveLine.Fields["AdvItem"]/*AdvItem*/,"AdvItem", false, true, false, false, false, true, 0, 100, "50",true, false,"","195843a5-0a6a-4207-9749-749470b7ae99","195843a5-0a6a-4207-9749-749470b7ae99","085a8beb-98da-46d8-a193-2bc7a9a840f5");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ApplyQty0","NumberColumnModel", "", 2,this.Model.AdvApproveBE_AdvApproveLine.Fields["ApplyQty"]/*ApplyQty*/,"ApplyQty", false, true, true, false, false, true, 8, 100, "24.9",true, false,"","60f8ef23-90e6-489a-a012-86505d20e16f","60f8ef23-90e6-489a-a012-86505d20e16f","8637447a-0505-4de0-b154-b904a3c38d5d");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Price0","NumberColumnModel", "", 2,this.Model.AdvApproveBE_AdvApproveLine.Fields["Price"]/*Price*/,"Price", false, true, true, false, false, true, 8, 100, "24.9",true, false,"","a3a6757c-8e63-4689-a019-90203792dd83","a3a6757c-8e63-4689-a019-90203792dd83","ca196746-04ce-4314-859d-409dc856f96a");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"TotalMoney0","NumberColumnModel", "", 2,this.Model.AdvApproveBE_AdvApproveLine.Fields["TotalMoney"]/*TotalMoney*/,"TotalMoney", false, true, true, false, false, true, 8, 100, "24.9",true, false,"","807437d0-7571-4016-a9a2-05e9c8287f59","807437d0-7571-4016-a9a2-05e9c8287f59","ab417bd1-b33a-4a15-8963-393d137c65f9");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ReceiptNum0","TextBoxColumnModel", "", 0,this.Model.AdvApproveBE_AdvApproveLine.Fields["ReceiptNum"]/*ReceiptNum*/,"ReceiptNum", false, true, true, false, false, true, 0, 100, "50",true, false,"","26fbeeef-ad95-4126-b4c6-f3258015ae96","26fbeeef-ad95-4126-b4c6-f3258015ae96","14436134-4e5a-4bbf-912a-40e947290b8d");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Momo0","TextBoxColumnModel", "", 0,this.Model.AdvApproveBE_AdvApproveLine.Fields["Momo"]/*Momo*/,"Momo", false, true, true, false, false, true, 0, 100, "500",true, false,"","f7e69934-31db-447b-93a7-36a6c8373909","f7e69934-31db-447b-93a7-36a6c8373909","fb20e468-a11c-4a30-8d9b-e1144397e5cb");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","500") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ActualApproveQty0","NumberColumnModel", "", 2,this.Model.AdvApproveBE_AdvApproveLine.Fields["ActualApproveQty"]/*ActualApproveQty*/,"ActualApproveQty", false, true, true, false, false, true, 8, 100, "24.9",true, false,"","b5a1ea31-b248-4d16-adf9-079b1476c6a7","b5a1ea31-b248-4d16-adf9-079b1476c6a7","ba6fc16e-9088-46c9-8dcb-84689dfbb287");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ActualPrice0","NumberColumnModel", "", 2,this.Model.AdvApproveBE_AdvApproveLine.Fields["ActualPrice"]/*ActualPrice*/,"ActualPrice", false, true, true, false, false, true, 8, 100, "24.9",true, false,"","ca824933-4ae0-43af-ba86-d60dddeaa4d0","ca824933-4ae0-43af-ba86-d60dddeaa4d0","a1da3ce7-c671-408e-a8d2-e1f353a728b8");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Discount0","NumberColumnModel", "", 2,this.Model.AdvApproveBE_AdvApproveLine.Fields["Discount"]/*Discount*/,"Discount", false, true, true, false, false, true, 8, 100, "24.9",true, false,"","d57cac96-8aec-496c-9db9-a194b96c778a","d57cac96-8aec-496c-9db9-a194b96c778a","bc24bc92-9f22-4f8e-9264-4e15fff15c09");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ApproveMoney0","NumberColumnModel", "", 2,this.Model.AdvApproveBE_AdvApproveLine.Fields["ApproveMoney"]/*ApproveMoney*/,"ApproveMoney", false, true, true, false, false, true, 8, 100, "24.9",true, false,"","b46a26a9-0c4c-4a2f-ad3b-5d3bdf261601","b46a26a9-0c4c-4a2f-ad3b-5d3bdf261601","76ff531f-ea59-4ff8-96f9-9310bdabea6c");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 
        }





		#endregion
		

	}
}
