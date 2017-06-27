


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
 * Form ID:823342da-6c12-4574-b762-4d59a1937f16 
 * Form Name:SuppplierVoucherDQryUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.FJGX.SuppplierVoucherDQryUIModel
{
	[FormRegister("UFIDA.U9.Cust.FJGX.SupplierQueryUI","UFIDA.U9.Cust.FJGX.SuppplierVoucherDQryUIModel.SuppplierVoucherDQryUIFormWebPart", "UFIDA.U9.Cust.FJGX.SupplierQueryUI.WebPart", "823342da-6c12-4574-b762-4d59a1937f16","WebPart", "True", 700, 250)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.FJGX.SupplierQueryUI', 'UFIDA.U9.Cust.FJGX.SuppplierVoucherDQryUIModel.SuppplierVoucherDQryUIFormWebPart', 'UFIDA.U9.Cust.FJGX.SupplierQueryUI.WebPart', '823342da-6c12-4574-b762-4d59a1937f16')
	///<siteMapNode url="~/erp/simple.aspx?lnk=823342da-6c12-4574-b762-4d59a1937f16" title="SuppplierVoucherDQryUIForm"/>
    public partial class SuppplierVoucherDQryUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(SuppplierVoucherDQryUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new SuppplierVoucherDQryUIModelAction Action
		{
			get { return (SuppplierVoucherDQryUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		SuppplierVoucherDQryUIModelModel _uimodel=null;
		public new SuppplierVoucherDQryUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new SuppplierVoucherDQryUIModelModel();
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
                this.Model = value as SuppplierVoucherDQryUIModelModel;
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
        IUFLabel Label2;
        IUFButton btnSaveCurrentQueryCase;
        IUFCard Card3;
        IUFDataGrid DataGrid1;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public SuppplierVoucherDQryUIFormWebPart()
        {
            FormID = "823342da-6c12-4574-b762-4d59a1937f16";
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
					this.Model = new SuppplierVoucherDQryUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{new InParameterModel("QueryView"),},new InParameterModel[]{new InParameterModel("QueryView","@SupplierID","@Parameter0"),});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (SuppplierVoucherDQryUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
				OnPreRenderConsumer(new InParameterModel[]{new InParameterModel("QueryView"),},new InParameterModel[]{new InParameterModel("QueryView","@SupplierID","@Parameter0"),});
				OnLoadData(this);//对吗？
			}
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
            this.Action = new SuppplierVoucherDQryUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"SuppplierVoucherDQryUIForm",true,700,250);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 5, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 5,new GridColumnDef[]{new GridColumnDef(700,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(1,bool.Parse("True")),new GridRowDef(209,bool.Parse("False")),new GridRowDef(25,bool.Parse("True")),});
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
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar1",true, true, "3",700, 1, 0, 0, 1, 1,"100");
            this.Toolbar1 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.BtnOutPut = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnOutPut", "True", "True", 35, 1,"1", "",true,false,"688fd549-5a92-49cc-8072-6d5377f6409a","688fd549-5a92-49cc-8072-6d5377f6409a","5ef55152-f00f-4ae7-8a84-e74adb2a34bd");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnOutPut);
            this.BtnOutPut.UIModel = this.Model.ElementID;
            this.BtnOutPut.Action = "OnOutPut";
	                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 1,"2", "",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","1a41de57-d362-41ad-ae2b-a22870199f0a");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "OnPrint";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"none", true, true, "4","","760ef580-9c43-48d8-bd11-937897f1bdea");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 700, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 10, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(40,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(55,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(384,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.Label0 = UIControlBuilder.BuilderUFLabel(_UFCard, "Label0", "", "True", "True", "Right", 55, 20, 2, 0, 1, 1, "100","7fb97e0d-d794-43d8-9b10-4ea28a2d6bd3","95c8db57-4a7f-494e-94b5-e1cfa63bcb6a");


								

		
			UIControlBuilder.BuilderUFControl(this.Label0, "4");		


		        this.DDLCase = UIControlBuilder.BuilderDropDownList(_UFCard, "DDLCase", "", true,  true, true, "Left", 0, 60, 0, 100, 20, 4, 0, 1, 1, "100",true,false,"","","9dff0291-5bfa-4559-b6a1-54d99c0cea44");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DDLCase, "False", "", null, null, "");
			EnumControlsMap.Add(this.DDLCase, _UFCard);
			this.DDLCase.ContentChanged += new EventHandler(DDLCase_TextChanged);
			this.DDLCase.AutoPostBack = true;
		

		
			UIControlBuilder.BuilderUFControl(this.DDLCase, "5");		
		 

				this.OnLookCase = UIControlBuilder.BuilderUFButton(_UFCard, true, "OnLookCase", true, true, 40, 20, 0, 0, 1, 1, "100","", this.Model.ElementID,"OnLookCase",false,"41ccec83-4368-4ed4-ab9f-94031b1261bb","41ccec83-4368-4ed4-ab9f-94031b1261bb","cc71e136-ea86-434d-b95b-63bc58f94843");
	

		
			UIControlBuilder.BuilderUFControl(this.OnLookCase, "6");		


				this.Label2 = UIControlBuilder.BuilderUFLabel(_UFCard, "Label2", "", "True", "True", "Left", 384, 20, 8, 0, 1, 1, "100","f4c04ce4-1e3f-43c9-932a-b718d9421396","f4c04ce4-1e3f-43c9-932a-b718d9421396");


								

		
			UIControlBuilder.BuilderUFControl(this.Label2, "9");		


				this.btnSaveCurrentQueryCase = UIControlBuilder.BuilderUFButton(_UFCard, true, "btnSaveCurrentQueryCase", true, true, 60, 20, 6, 0, 1, 1, "100","", this.Model.ElementID,"btnSaveCurrentQueryCase",false,"976f9a20-499c-4996-96fe-b81e09d9e019","976f9a20-499c-4996-96fe-b81e09d9e019","cd6abef9-2c13-4732-8bb6-7ae27ab234b3");
	

		
			UIControlBuilder.BuilderUFControl(this.btnSaveCurrentQueryCase, "10");		



					

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card3(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card3",false,"none", true, true, "5","","f61902e1-1b2d-49d6-898e-a807f463db78");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 700, 209, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 2, 2, 0, 5, 5, 0, 5, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(689,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(203,bool.Parse("True")),new GridRowDef(1,bool.Parse("False")),});
            this.Card3 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_DataGrid1(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid1, "0");		



	

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				





       
        private void _BuilderControl_DataGrid1(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid1", UFSoft.UBF.UI.ControlModel.EditStatus.Browse, true, true,true,true,true,true,18,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "0");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 690, 209, 0, 0, 2, 2, "100");
			InitViewBindingContainer(this, _UFGrid,  null, "", "", null, 18, "");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid1 = _UFGrid;
            container.Controls.Add(_UFGrid);



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
            QryService.BindEnum("DDLCase", this, "84ee70f6-4958-46c2-87d4-a82585f62f87");
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
            ((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)this.DataGrid1).GridMakePageEventHandler += new GridMakePageDelegate(SuppplierVoucherDQryUIFormWebPart_GridMakePageEventHandler);

	}

        void SuppplierVoucherDQryUIFormWebPart_GridMakePageEventHandler(object sender, GridMakePageEventArgs e)
        {
            GridNavigateAction action = new GridNavigateAction(this.DataGrid1, new UFIDA.U9.Cust.FJGX.SuppplierVoucherQryBP.Proxy.QueryBPProxy(), "QryInParameter");

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
