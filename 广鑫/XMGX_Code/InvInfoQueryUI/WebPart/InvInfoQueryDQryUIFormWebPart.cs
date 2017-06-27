


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
using UFIDA.UBF.Query.CommonService;
using UFIDA.U9.UI.PDHelper;


/***********************************************************************************************
 * Form ID:760c2587-22a1-4d0d-b103-656c1738f894 
 * Form Name:InvInfoQueryDQryUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.FJGX.InvInfoQueryDQryUIModel
{
	[FormRegister("UFIDA.U9.Cust.FJGX.InvInfoQueryUI","UFIDA.U9.Cust.FJGX.InvInfoQueryDQryUIModel.InvInfoQueryDQryUIFormWebPart", "UFIDA.U9.Cust.FJGX.InvInfoQueryUI.WebPart", "760c2587-22a1-4d0d-b103-656c1738f894","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.FJGX.InvInfoQueryUI', 'UFIDA.U9.Cust.FJGX.InvInfoQueryDQryUIModel.InvInfoQueryDQryUIFormWebPart', 'UFIDA.U9.Cust.FJGX.InvInfoQueryUI.WebPart', '760c2587-22a1-4d0d-b103-656c1738f894')
	///<siteMapNode url="~/erp/simple.aspx?lnk=760c2587-22a1-4d0d-b103-656c1738f894" title="InvInfoQueryDQryUIForm"/>
    public partial class InvInfoQueryDQryUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(InvInfoQueryDQryUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new InvInfoQueryDQryUIModelAction Action
		{
			get { return (InvInfoQueryDQryUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		InvInfoQueryDQryUIModelModel _uimodel=null;
		public new InvInfoQueryDQryUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new InvInfoQueryDQryUIModelModel();
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
                this.Model = value as InvInfoQueryDQryUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFToolbar Toolbar1;
        IUFButton BtnOutPut;
        IUFButton BtnPrint;
        IUFCard Card0;
        IUFLabel Label0;
        IUFFldDropDownList DDLCase;
        IUFButton OnLookCase;
        IUFButton btnSaveCurrentQueryCase;
        IUFCard Card3;
        IUFDataGrid DataGrid1;
        IUFCard Card4;
        IUFTreeControl CategoryTree0;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public InvInfoQueryDQryUIFormWebPart()
        {
            FormID = "760c2587-22a1-4d0d-b103-656c1738f894";
            IsAutoSize = bool.Parse("True");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.BtnOutPut.Click += new EventHandler(BtnOutPut_Click);		
						
				//Button控件事件
			this.BtnPrint.Click += new EventHandler(BtnPrint_Click);		
						
							
				//Button控件事件
			this.OnLookCase.Click += new EventHandler(OnLookCase_Click);		
						
				//Button控件事件
			this.btnSaveCurrentQueryCase.Click += new EventHandler(btnSaveCurrentQueryCase_Click);		
						
	
			//Tree控件事件
			this.CategoryTree0.NodeClick += new RadTreeView.RadTreeViewEventHandler(CategoryTree0_NodeClick);
						
	
			//Tree控件事件
			
			this.CategoryTree0.NodeExpand += new RadTreeView.RadTreeViewEventHandler(CategoryTree0_NodeExpand);
			

	
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
					this.Model = new InvInfoQueryDQryUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (InvInfoQueryDQryUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new InvInfoQueryDQryUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"InvInfoQueryDQryUIForm",true,992,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(28,bool.Parse("True")),new GridRowDef(421,bool.Parse("False")),new GridRowDef(25,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Toolbar1(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Toolbar1, "3");		


	
			_BuilderControl_Card0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card0, "4");		


	
			_BuilderControl_Card3(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card3, "5");		



			
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







				        
        private void _BuilderControl_Toolbar1(IUFContainer container)
        {
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar1",true, true, "3",992, 28, 0, 0, 1, 1,"100");
            this.Toolbar1 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.BtnOutPut = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnOutPut", "True", "True", 35, 28,"1", "",true,false,"688fd549-5a92-49cc-8072-6d5377f6409a","688fd549-5a92-49cc-8072-6d5377f6409a","557742a5-c151-49a2-96f7-d63494905f08");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnOutPut);
            this.BtnOutPut.UIModel = this.Model.ElementID;
            this.BtnOutPut.Action = "OnOutPut";
	                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 28,"2", "",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","91226a99-d3df-4c59-be98-d653a6da8ab2");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "OnPrint";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"none", true, true, "4","","2af00304-fd78-47e9-aaed-c64fb238b7e3");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 20, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.Label0 = UIControlBuilder.BuilderUFLabel(_UFCard, "Label0", "", "True", "True", "Right", 80, 20, 8, 0, 1, 1, "100","7fb97e0d-d794-43d8-9b10-4ea28a2d6bd3","010ecd06-ed37-4f32-afd7-504d9ac54316");


								

		
			UIControlBuilder.BuilderUFControl(this.Label0, "4");		


		        this.DDLCase = UIControlBuilder.BuilderDropDownList(_UFCard, "DDLCase", "", true,  true, true, "Left", 0, 60, 0, 120, 20, 10, 0, 1, 1, "100",true,false,"","","71f76ad9-feb4-4837-82c9-4402f7c97b5f");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DDLCase, "False", "", null, null, "");
			EnumControlsMap.Add(this.DDLCase, _UFCard);
			this.DDLCase.ContentChanged += new EventHandler(DDLCase_TextChanged);
			this.DDLCase.AutoPostBack = true;
		

		
			UIControlBuilder.BuilderUFControl(this.DDLCase, "5");		
		 

				this.OnLookCase = UIControlBuilder.BuilderUFButton(_UFCard, true, "OnLookCase", true, true, 80, 20, 0, 0, 1, 1, "100","", this.Model.ElementID,"OnLookCase",false,"5a367d09-6912-4f35-8675-dea3b64ad601","5a367d09-6912-4f35-8675-dea3b64ad601","8b08b0bd-88d0-478e-9768-8fcda46c9a96");
	

		
			UIControlBuilder.BuilderUFControl(this.OnLookCase, "6");		


				this.btnSaveCurrentQueryCase = UIControlBuilder.BuilderUFButton(_UFCard, true, "btnSaveCurrentQueryCase", true, true, 80, 20, 12, 0, 1, 1, "100","", this.Model.ElementID,"btnSaveCurrentQueryCase",false,"38a14474-b1f4-43fb-91c9-62a9bad6fa39","38a14474-b1f4-43fb-91c9-62a9bad6fa39","4040286d-adb2-4ce3-8135-1e512f00d9a2");
	

		
			UIControlBuilder.BuilderUFControl(this.btnSaveCurrentQueryCase, "7");		



				

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card3(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card3",false,"none", true, true, "5","","8bda53e0-7837-4ac8-b262-11b1a9153fe1");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 421, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 4, 2, 0, 5, 3, 0, 3, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(200,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(775,bool.Parse("False")),new GridColumnDef(1,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(415,bool.Parse("False")),new GridRowDef(1,bool.Parse("True")),});
            this.Card3 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_DataGrid1(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid1, "0");		


	
			_BuilderControl_Card4(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.Card4, "0");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				





       
        private void _BuilderControl_DataGrid1(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid1", UFSoft.UBF.UI.ControlModel.EditStatus.Browse, true, true,true,true,true,true,18,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "0");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 775, 421, 2, 0, 1, 2, "100");
			InitViewBindingContainer(this, _UFGrid,  null, "", "", null, 18, "");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid1 = _UFGrid;
            container.Controls.Add(_UFGrid);



        }

	                   
        private IUFCard _BuilderControl_Card4(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card4",false,"none", true, true, "0","","12352ecd-0afb-4b1b-b3c5-697b32cacfa4");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 200, 415, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 1, 3, 0, 5, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(200,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(365,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            this.Card4 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_CategoryTree0(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.CategoryTree0, "1");		



	

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	        private void _BuilderControl_CategoryTree0(IUFContainer container)
        {
            IUFTreeControl _RadTreeView = new UFWebTreeControlAdapter();
            _RadTreeView.ID = "CategoryTree0";
			UIControlBuilder.BuilderUFControl(_RadTreeView, "True", "True", "1");
            _RadTreeView.AutoPostBack = bool.Parse("True");
            _RadTreeView.LoadOnDemand = bool.Parse("False");
            _RadTreeView.CheckBoxes = bool.Parse("False");
            _RadTreeView.MultipleSelect = bool.Parse("False");
			CommonBuilder.GridLayoutPropBuilder(container, _RadTreeView, 200, 415, 0, 0, 1, 3, "100");
			InitViewBindingContainer(this, _RadTreeView,  null, "", "", null, -1, "");
            this.CategoryTree0 = _RadTreeView;
            container.Controls.Add(_RadTreeView);

			ITreeViewBinding treeViewBinding;
        }





		#endregion
		
		 
        #region DTO查询自动生成代码
      
       private void BeforeUIModelBinding_Qry_DefaultImpl()
        {
            if (QryService.IsCallInitCaseModel(this.DataGrid1))
            {
                this.Action.InitCaseModel();
            }
            if (QryService.IsCallAdjust(this.DataGrid1))
            {
                this.Action.QueryAdjust();
            }

            else
            {
                QryService.SetGridWidthToCase(this.CurrentState, FormID, this.DataGrid1);
            }
        }

        private void AfterUIModelBinding_Qry_DefaultImpl()
        {
            QryService.BindEnum("DDLCase", this, "125fe688-7233-492a-aeff-a142dfafe751");
        }

        private void AfterCreateChildControls_Qry_DefaultImpl()
        {
            QryService.GridBindView(this.DataGrid1, Action.MainView.Name);
	    AttachMakePageEvent();
        }

	private void AfterCreateChildControls_Qry_DefaultImpl(string bindViewName)
        {
            QryService.GridBindView(this.DataGrid1, bindViewName);
	    AttachMakePageEvent();
        }

	private void AttachMakePageEvent()
	{
            updatePanel.UpdateMode = UpdatePanelUpdateMode.Always;
            ((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)this.DataGrid1).GridMakePageEventHandler += new GridMakePageDelegate(InvInfoQueryDQryUIFormWebPart_GridMakePageEventHandler);

	}

        void InvInfoQueryDQryUIFormWebPart_GridMakePageEventHandler(object sender, GridMakePageEventArgs e)
        {
            GridNavigateAction action = new GridNavigateAction(this.DataGrid1, new UFIDA.U9.Cust.FJGX.InvInfoQueryQryBP.Proxy.QueryBPProxy(), "QryInParameter");

            action.FilterOpath = this.Action.CustomFilterOpath_Extend();
            switch (e.Action)
            {
                case enumPageAction.FirstPage:
                    action.FirstPage();
                    break;
                case enumPageAction.PreviousPage:
                    action.PrevPage();
                    break;
                case enumPageAction.NextPage:
                    action.NextPage();
                    break;
                case enumPageAction.LastPage:
                    action.LastPage();
                    break;
                case enumPageAction.GotoPage:
                    action.GotoPage(e.GotoPageNumber);
                    break;
            }
            this.DataGrid1.PageAction = e.Action;
        }
        
         #endregion

		 



	}
}
