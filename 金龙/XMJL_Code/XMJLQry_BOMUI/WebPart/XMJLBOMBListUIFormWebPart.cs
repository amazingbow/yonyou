


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
 * Form ID:b0411add-f64e-4745-a7be-f02099549ccd 
 * Form Name:XMJLBOMBListUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.XMJL.Qry.XMJLBOMBListUIModel
{
	[FormRegister("UFIDA.U9.Cust.XMJL.Qry.BOMUI","UFIDA.U9.Cust.XMJL.Qry.XMJLBOMBListUIModel.XMJLBOMBListUIFormWebPart", "UFIDA.U9.Cust.XMJL.Qry.BOMUI.WebPart", "b0411add-f64e-4745-a7be-f02099549ccd","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.XMJL.Qry.BOMUI', 'UFIDA.U9.Cust.XMJL.Qry.XMJLBOMBListUIModel.XMJLBOMBListUIFormWebPart', 'UFIDA.U9.Cust.XMJL.Qry.BOMUI.WebPart', 'b0411add-f64e-4745-a7be-f02099549ccd')
	///<siteMapNode url="~/erp/simple.aspx?lnk=b0411add-f64e-4745-a7be-f02099549ccd" title="XMJLBOMBListUIForm"/>
    public partial class XMJLBOMBListUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(XMJLBOMBListUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new XMJLBOMBListUIModelAction Action
		{
			get { return (XMJLBOMBListUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		XMJLBOMBListUIModelModel _uimodel=null;
		public new XMJLBOMBListUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new XMJLBOMBListUIModelModel();
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
                this.Model = value as XMJLBOMBListUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFToolbar Toolbar1;
        IUFSeparator Separator0;
        IUFButton BtnOutPut;
        IUFButton BtnPrint;
        IUFButton BtnDelete;
        IUFCard Card0;
        IUFLabel Label0;
        IUFFldDropDownList DDLCase;
        IUFButton OnLookCase;
        IUFButton BtnChangeWH;
        IUFButton BtnUpdateSup;
        IUFButton BtnUpdateStat;
        IUFFldDropDownList DDLWareHouse;
        IUFButton BtnBatchIssue;
        IUFButton BtnRefresh;
        IUFButton BtnResetWH;
        IUFCard Card3;
        IUFDataGrid DataGrid1;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public XMJLBOMBListUIFormWebPart()
        {
            FormID = "b0411add-f64e-4745-a7be-f02099549ccd";
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
			this.BtnChangeWH.Click += new EventHandler(BtnChangeWH_Click);		
						
				//Button控件事件
			this.BtnUpdateSup.Click += new EventHandler(BtnUpdateSup_Click);		
						
				//Button控件事件
			this.BtnUpdateStat.Click += new EventHandler(BtnUpdateStat_Click);		
						
				//Button控件事件
			this.BtnBatchIssue.Click += new EventHandler(BtnBatchIssue_Click);		
						
				//Button控件事件
			this.BtnRefresh.Click += new EventHandler(BtnRefresh_Click);		
						
				//Button控件事件
			this.BtnResetWH.Click += new EventHandler(BtnResetWH_Click);		
						
				//Grid控件事件
			
			((UFWebDataGridAdapter)this.DataGrid1).RowDoubleClick += new GridRowDBClickedDelegate(DataGrid1_GridRowDbClicked);
			//((UFWebDataGridAdapter)this.DataGrid1).DBClickAutoPostBack = true;
						


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
					this.Model = new XMJLBOMBListUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (XMJLBOMBListUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new XMJLBOMBListUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"XMJLBOMBListUIForm",true,992,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(28,bool.Parse("True")),new GridRowDef(421,bool.Parse("False")),new GridRowDef(25,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Toolbar1(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Toolbar1, "1");		


	
			_BuilderControl_Card0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card0, "3");		


	
			_BuilderControl_Card3(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card3, "2");		



			
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







				        
        private void _BuilderControl_Toolbar1(IUFContainer container)
        {
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar1",true, true, "1",992, 28, 0, 0, 1, 1,"100");
            this.Toolbar1 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnOutPut = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnOutPut", "True", "True", 35, 28,"4", "O",true,false,"688fd549-5a92-49cc-8072-6d5377f6409a","688fd549-5a92-49cc-8072-6d5377f6409a","83d7736c-fb8a-4698-9f2c-674ac1dd55c3");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnOutPut);
            this.BtnOutPut.UIModel = this.Model.ElementID;
            this.BtnOutPut.Action = "OnOutPut";
	                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 28,"5", "P",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","c2ea5259-5921-421b-8111-d0157a924c78");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "OnPrint";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "False", "True", 47, 28,"6", "",false,false,"aac8d3a4-f5d1-4c61-b1c6-bf0bebe9bb19","","aac8d3a4-f5d1-4c61-b1c6-bf0bebe9bb19");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"FunctionBar", true, true, "3","","9449b511-9a38-489c-bfa5-4c3e472add60");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 18, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(120,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.Label0 = UIControlBuilder.BuilderUFLabel(_UFCard, "Label0", "", "True", "True", "Right", 80, 20, 15, 0, 1, 1, "100","7fb97e0d-d794-43d8-9b10-4ea28a2d6bd3","6fae9605-e20e-4a98-8626-b196c65df428");


								

		
			UIControlBuilder.BuilderUFControl(this.Label0, "2");		


		        this.DDLCase = UIControlBuilder.BuilderDropDownList(_UFCard, "DDLCase", "", true,  true, true, "Left", 0, 60, 0, 120, 20, 17, 0, 1, 1, "100",true,false,"","","d467ba59-6d13-4134-973f-c1024c919409");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DDLCase, "False", "", null, null, "");
			EnumControlsMap.Add(this.DDLCase, _UFCard);
			this.DDLCase.ContentChanged += new EventHandler(DDLCase_TextChanged);
			this.DDLCase.AutoPostBack = true;
		

		
			UIControlBuilder.BuilderUFControl(this.DDLCase, "3");		
		 

				this.OnLookCase = UIControlBuilder.BuilderUFButton(_UFCard, true, "OnLookCase", true, true, 80, 20, 0, 0, 1, 1, "100","", this.Model.ElementID,"OnLookCase",false,"e6c3a02b-c544-41f7-8da9-13813c68dbb0","e6c3a02b-c544-41f7-8da9-13813c68dbb0","9506a4e3-7048-4adb-89ea-261eeefd2b1e");
	

		
			UIControlBuilder.BuilderUFControl(this.OnLookCase, "1");		


				this.BtnChangeWH = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnChangeWH", true, true, 100, 20, 6, 0, 1, 1, "100","", this.Model.ElementID,"",false,"fa295eaf-6189-412a-a9cb-b9993c1d35ec","","fa295eaf-6189-412a-a9cb-b9993c1d35ec");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnChangeWH, "4");		


				this.BtnUpdateSup = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnUpdateSup", true, true, 100, 20, 2, 0, 1, 1, "100","", this.Model.ElementID,"",false,"bb03d681-0cd2-4014-8a6b-a3b6e391a055","","bb03d681-0cd2-4014-8a6b-a3b6e391a055");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnUpdateSup, "5");		


				this.BtnUpdateStat = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnUpdateStat", true, true, 100, 20, 4, 0, 1, 1, "100","", this.Model.ElementID,"",false,"22020f71-6fe0-47b7-b42f-c1477a66a9c9","","22020f71-6fe0-47b7-b42f-c1477a66a9c9");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnUpdateStat, "6");		


		        this.DDLWareHouse = UIControlBuilder.BuilderDropDownList(_UFCard, "DDLWareHouse", "", true,  true, true, "Left", 0, 60, 0, 120, 20, 8, 0, 1, 1, "100",true,false,"","","6a0e920a-3117-42a9-a023-29a4ea1dfa3d");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DDLWareHouse, "False", "", null, null, "");
			EnumControlsMap.Add(this.DDLWareHouse, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.DDLWareHouse, "7");		
		 

				this.BtnBatchIssue = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnBatchIssue", true, true, 80, 20, 12, 0, 1, 1, "100","", this.Model.ElementID,"",false,"ca672469-4c84-4b82-92ca-8817b13829c7","","ca672469-4c84-4b82-92ca-8817b13829c7");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnBatchIssue, "8");		


				this.BtnRefresh = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnRefresh", true, false, 80, 20, 0, 0, 1, 1, "100","", this.Model.ElementID,"",false,"82f5f859-b065-4753-8ed8-25e7feccc12c","","82f5f859-b065-4753-8ed8-25e7feccc12c");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnRefresh, "9");		


				this.BtnResetWH = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnResetWH", true, true, 80, 20, 10, 0, 1, 1, "100","", this.Model.ElementID,"",false,"133eb24a-c47a-4198-a824-20dd1d6fb6ee","","133eb24a-c47a-4198-a824-20dd1d6fb6ee");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnResetWH, "11");		



										

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card3(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card3",false,"none", true, true, "2","","ea9f90ef-6cdf-418c-94e1-addee66705f1");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 421, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 2, 2, 0, 5, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(971,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(415,bool.Parse("False")),new GridRowDef(1,bool.Parse("True")),});
            this.Card3 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_DataGrid1(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid1, "1");		



	

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				





       
        private void _BuilderControl_DataGrid1(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid1", UFSoft.UBF.UI.ControlModel.EditStatus.Browse, true, true,true,true,true,true,24,true, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "1");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 972, 421, 0, 0, 2, 2, "100");
			InitViewBindingContainer(this, _UFGrid,  null, "", "", null, 24, "");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=true;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid1 = _UFGrid;
            container.Controls.Add(_UFGrid);
			//Grid所有页全选事件 
			((UFWebDataGridAdapter)this.DataGrid1).GridSelectAllPageHandler +=
				new GridSelectAllPageDelegate(UFIDA.U9.UI.PDHelper.PDListHelper.UFGridDataGrid_GridSelectAllPageDelegate);



        }





		#endregion
		
		 

		  
        #region BE列表自动生成代码

		private void AfterOnLoad_Qry_DefaultImpl()
		{
			IUIModelProperty mp = this.Model.Properties[UFIDA.UBF.Query.CommonService.QuerySymbol.NeedRefresh];
			if ((mp != null && (bool)mp.Value == true) || !Page.IsPostBack)
			{
				this.Action.QueryAdjust();
				if (mp != null)
				{
					mp.Value = false;
				}
			}
			else
			{
				QryService.SetGridWidthToCase(this.CurrentState, FormID, this.DataGrid1);
			}
		}

		private void AfterCreateChildControls_Qry_DefaultImpl(string bindViewName)
		{
			QryService.GridBindView(this.DataGrid1, bindViewName);
			AttachMakePageEvent();
		}

		private void AfterCreateChildControls_Qry_DefaultImpl()
		{
			QryService.GridBindView(this.DataGrid1, Action.MainView.Name);
			AttachMakePageEvent();
		}

		private void AttachMakePageEvent()
		{
			string message = UFIDA.U9.UI.PDHelper.PDResource.GetDeleteConfirmInfo();
			PDFormMessage.ShowDelConfirmDialog(this.Page, message, "", this.BtnDelete);
			QryService.AttachMakePageEvent(this.Action, this.DataGrid1);
		}

		private void AfterUIModelBinding_Qry_DefaultImpl()
		{
			QryService.BindEnum("DDLCase", this, "c486b4dd-b98d-4647-b5ac-3a4c55c61bce");
		}

        #endregion
		 

	}
}
