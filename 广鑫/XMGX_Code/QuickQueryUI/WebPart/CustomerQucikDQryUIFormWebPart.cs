


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
 * Form ID:9e7b6d80-75a4-47ea-b93b-c5ae356128f2 
 * Form Name:CustomerQucikDQryUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.FJGX.CustomerQucikDQryUIModel
{
	[FormRegister("UFIDA.U9.Cust.FJGX.QuickQueryUI","UFIDA.U9.Cust.FJGX.CustomerQucikDQryUIModel.CustomerQucikDQryUIFormWebPart", "UFIDA.U9.Cust.FJGX.QuickQueryUI.WebPart", "9e7b6d80-75a4-47ea-b93b-c5ae356128f2","WebPart", "True", 700, 300)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.FJGX.QuickQueryUI', 'UFIDA.U9.Cust.FJGX.CustomerQucikDQryUIModel.CustomerQucikDQryUIFormWebPart', 'UFIDA.U9.Cust.FJGX.QuickQueryUI.WebPart', '9e7b6d80-75a4-47ea-b93b-c5ae356128f2')
	///<siteMapNode url="~/erp/simple.aspx?lnk=9e7b6d80-75a4-47ea-b93b-c5ae356128f2" title="CustomerQucikDQryUIForm"/>
    public partial class CustomerQucikDQryUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(CustomerQucikDQryUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new CustomerQucikDQryUIModelAction Action
		{
			get { return (CustomerQucikDQryUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		CustomerQucikDQryUIModelModel _uimodel=null;
		public new CustomerQucikDQryUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new CustomerQucikDQryUIModelModel();
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
                this.Model = value as CustomerQucikDQryUIModelModel;
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
        IUFCard Card3;
        IUFTabControl TabControl0;
        IUFTabPage TabPage0;
        IUFDataGrid DataGrid1;
        IUFTabPage TabPage1;
        IUFLabel lblID34;
        IUFFldNumberControl ID34;
        IUFLabel lblSysVersion40;
        IUFFldNumberControl SysVersion40;
        IUFLabel lblName28;
        IUFFldTextBox Name28;
        IUFLabel lblEnterpriseLegalPerson43;
        IUFFldTextBox EnterpriseLegalPerson43;
        IUFLabel lblCreditMoney40;
        IUFFldNumberControl CreditMoney40;
        IUFLabel lblActualAPMoney52;
        IUFFldNumberControl ActualAPMoney52;
        IUFLabel lblMobileNo34;
        IUFFldTextBox MobileNo34;
        IUFLabel lblPhoneNo37;
        IUFFldTextBox PhoneNo37;
        IUFLabel lblFax52;
        IUFFldTextBox Fax52;
        IUFLabel lblSaleserNote76;
        IUFFldTextBox SaleserNote76;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public CustomerQucikDQryUIFormWebPart()
        {
            FormID = "9e7b6d80-75a4-47ea-b93b-c5ae356128f2";
            IsAutoSize = bool.Parse("False");
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
					this.Model = new CustomerQucikDQryUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (CustomerQucikDQryUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new CustomerQucikDQryUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"CustomerQucikDQryUIForm",true,700,300);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 2, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 2,new GridColumnDef[]{new GridColumnDef(700,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(1,bool.Parse("True")),new GridRowDef(265,bool.Parse("False")),new GridRowDef(25,bool.Parse("True")),});
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
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar1",true, true, "1",700, 1, 0, 0, 1, 1,"100");
            this.Toolbar1 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.BtnOutPut = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnOutPut", "True", "True", 35, 1,"1", "",true,false,"688fd549-5a92-49cc-8072-6d5377f6409a","688fd549-5a92-49cc-8072-6d5377f6409a","689ade94-68b2-4a84-82b6-234abc285ae8");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnOutPut);
            this.BtnOutPut.UIModel = this.Model.ElementID;
            this.BtnOutPut.Action = "OnOutPut";
	                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 1,"2", "",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","bbd57abf-d31b-4efd-b279-847410e0806c");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "OnPrint";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"none", true, true, "3","","58799f35-48c3-45e3-b5e3-05e71edf1aba");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 700, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 14, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.Label0 = UIControlBuilder.BuilderUFLabel(_UFCard, "Label0", "", "True", "True", "Right", 80, 20, 10, 0, 1, 1, "100","7fb97e0d-d794-43d8-9b10-4ea28a2d6bd3","8010285e-a04d-41eb-bd4c-2498c283ab0a");


								

		
			UIControlBuilder.BuilderUFControl(this.Label0, "2");		


		        this.DDLCase = UIControlBuilder.BuilderDropDownList(_UFCard, "DDLCase", "", true,  true, true, "Left", 0, 60, 0, 120, 20, 12, 0, 1, 1, "100",true,false,"","","f65ece53-ec5f-4d0a-9925-792d989c845e");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DDLCase, "False", "", null, null, "");
			EnumControlsMap.Add(this.DDLCase, _UFCard);
			this.DDLCase.ContentChanged += new EventHandler(DDLCase_TextChanged);
			this.DDLCase.AutoPostBack = true;
		

		
			UIControlBuilder.BuilderUFControl(this.DDLCase, "3");		
		 

				this.OnLookCase = UIControlBuilder.BuilderUFButton(_UFCard, true, "OnLookCase", true, true, 80, 20, 0, 0, 1, 1, "100","", this.Model.ElementID,"OnLookCase",false,"c7c929d4-0ab2-4f51-8335-cec4fd8a7abf","c7c929d4-0ab2-4f51-8335-cec4fd8a7abf","f37bd0d4-4090-4c9c-b233-8ab0ee78b2ff");
	

		
			UIControlBuilder.BuilderUFControl(this.OnLookCase, "1");		



			

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card3(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card3",false,"none", true, true, "2","","7371cfb9-8a94-4ad2-9531-772e8e6ef29e");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 700, 265, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 2, 3, 0, 5, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(670,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(140,bool.Parse("False")),new GridRowDef(105,bool.Parse("False")),new GridRowDef(1,bool.Parse("False")),});
            this.Card3 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_TabControl0(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.TabControl0, "1");		



	

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	         private void _BuilderControl_TabControl0(IUFContainer container)
        {
            IUFTabControl _UFTabControl = UIControlBuilder.BuildTabControl(container,"TabControl0",true, true, "1",EventResponseType.Server,670, 256, 0, 0, 1, 3, "100");
			_UFTabControl.SelectedIndexChanged += new EventHandler(TabControl0_SelectedIndexChanged);
            ///foreach UFTabbedPane下的所有控件，增加到此容器
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage0(_UFTabControl));
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage1(_UFTabControl));
            this.TabControl0 = _UFTabControl;
        }

	        private IUFTabPage _BuilderControl_TabPage0(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage0",true, true, "1","480d6c22-3fb5-494f-884c-f2cf337926a5","480d6c22-3fb5-494f-884c-f2cf337926a5");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 12, 10, 0, 5, 2, 2, 2, 2);
			InitViewBindingContainer(this, _UFTabPage,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(1,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(16,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





	
			_BuilderControl_DataGrid1(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid1, "1");		



	

            this.TabPage0 = _UFTabPage;
            return _UFTabPage;
        }

				





       
        private void _BuilderControl_DataGrid1(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid1", UFSoft.UBF.UI.ControlModel.EditStatus.Browse, true, true,true,true,true,true,18,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "1");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 655, 222, 0, 0, 12, 10, "100");
			InitViewBindingContainer(this, _UFGrid,  null, "", "", null, 18, "");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid1 = _UFGrid;
            container.Controls.Add(_UFGrid);



        }

	        private IUFTabPage _BuilderControl_TabPage1(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage1",true, true, "2","8c0d6f5b-58b1-4507-81e2-d38350f0271e","8c0d6f5b-58b1-4507-81e2-d38350f0271e");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 7, 9, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFTabPage,  this.Model.CustomerDetailView, "CustomerDetailView", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(200,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(210,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(6,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





				this.lblID34 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblID34", "", "False", "True", "Right", 100, 20, 0, 0, 1, 1, "100","c8f3b60d-1b36-48c2-8c5c-f1fb7fb68eb4","390afede-e33d-407f-bedf-2d998aac6ae4");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID34, "0");		


				this.ID34 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "ID34", "False", "False", "True", "Left", 7, 60, 0, 100, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID34","","c8f3b60d-1b36-48c2-8c5c-f1fb7fb68eb4","9d6e7b8c-c1cf-4fa6-8565-18ea19f9a279",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID34, "False", "ID", this.Model.CustomerDetailView, this.Model.CustomerDetailView.FieldID, "CustomerDetailView");
	
		
			UIControlBuilder.BuilderUFControl(this.ID34, "1");		
		 

				this.lblSysVersion40 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblSysVersion40", "", "False", "True", "Right", 100, 20, 0, 0, 1, 1, "100","ef641693-4379-48c8-87f1-7072f7ddde6d","a0eb90e2-d393-409c-b154-22c4f8e83df7");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion40, "2");		


				this.SysVersion40 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "SysVersion40", "False", "False", "True", "Left", 7, 60, 0, 100, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion40","","ef641693-4379-48c8-87f1-7072f7ddde6d","76287cef-8d5d-474a-b5ea-b245917d69c2",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion40, "False", "SysVersion", this.Model.CustomerDetailView, this.Model.CustomerDetailView.FieldSysVersion, "CustomerDetailView");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion40, "3");		
		 

				this.lblName28 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblName28", "", "True", "True", "Right", 100, 20, 0, 0, 1, 1, "100","d3d651bb-92c2-47b4-a6a1-db64b688da80","f6d5eb55-d51e-4723-a8b7-6cf087ac42e1");


								

		
			UIControlBuilder.BuilderUFControl(this.lblName28, "4");		


				this.Name28 = UIControlBuilder.BuilderTextBox(_UFTabPage, "Name28", "True", "True", "False", "False", "Left", 0, 60, 0, 200, 20, 2, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblName28","","200","d3d651bb-92c2-47b4-a6a1-db64b688da80","95f88c1e-2558-4f69-bd6f-84d24264a27c");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Name28, "False", "Name", this.Model.CustomerDetailView, this.Model.CustomerDetailView.FieldName, "CustomerDetailView");


		
			UIControlBuilder.BuilderUFControl(this.Name28, "5");		
		 

				this.lblEnterpriseLegalPerson43 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblEnterpriseLegalPerson43", "", "True", "True", "Right", 100, 20, 0, 1, 1, 1, "100","f63c72f7-dc10-495f-a7f2-c527efdc5609","ab1d452e-84ae-494a-a076-92a42ce721e4");


								

		
			UIControlBuilder.BuilderUFControl(this.lblEnterpriseLegalPerson43, "6");		


				this.EnterpriseLegalPerson43 = UIControlBuilder.BuilderTextBox(_UFTabPage, "EnterpriseLegalPerson43", "True", "True", "False", "False", "Left", 0, 60, 0, 200, 20, 2, 1, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblEnterpriseLegalPerson43","","50","f63c72f7-dc10-495f-a7f2-c527efdc5609","10469646-df3f-4033-92dd-70c78eb0507e");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.EnterpriseLegalPerson43, "False", "EnterpriseLegalPerson", this.Model.CustomerDetailView, this.Model.CustomerDetailView.FieldEnterpriseLegalPerson, "CustomerDetailView");


		
			UIControlBuilder.BuilderUFControl(this.EnterpriseLegalPerson43, "7");		
		 

				this.lblCreditMoney40 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblCreditMoney40", "", "True", "True", "Right", 100, 20, 0, 2, 1, 1, "100","ddfae648-f151-418a-bd27-b67fc5973c45","d99ed7bd-d538-4c48-bcc0-942ceb2d8469");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCreditMoney40, "8");		


				this.CreditMoney40 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "CreditMoney40", "True", "True", "False", "Left", 8, 60, 0, 200, 20, 2, 2, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblCreditMoney40","18.0","ddfae648-f151-418a-bd27-b67fc5973c45","d5086ce7-4431-4bd0-a5cc-c39d19b984c0",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CreditMoney40, "False", "CreditMoney", this.Model.CustomerDetailView, this.Model.CustomerDetailView.FieldCreditMoney, "CustomerDetailView");
	
		
			UIControlBuilder.BuilderUFControl(this.CreditMoney40, "9");		
		 

				this.lblActualAPMoney52 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblActualAPMoney52", "", "True", "True", "Right", 100, 20, 0, 3, 1, 1, "100","5d1d5417-bee3-4943-aae2-de93076e82e9","79eeded3-fa41-4661-a882-5e67f5cfab4d");


								

		
			UIControlBuilder.BuilderUFControl(this.lblActualAPMoney52, "10");		


				this.ActualAPMoney52 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "ActualAPMoney52", "True", "True", "False", "Left", 8, 60, 0, 200, 20, 2, 3, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblActualAPMoney52","18.0","5d1d5417-bee3-4943-aae2-de93076e82e9","3810cb01-c180-4681-b184-e05a669f5be1",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ActualAPMoney52, "False", "ActualAPMoney", this.Model.CustomerDetailView, this.Model.CustomerDetailView.FieldActualAPMoney, "CustomerDetailView");
	
		
			UIControlBuilder.BuilderUFControl(this.ActualAPMoney52, "11");		
		 

				this.lblMobileNo34 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblMobileNo34", "", "True", "True", "Right", 100, 20, 0, 4, 1, 1, "100","328319f2-3270-4e08-8b6b-d7ba0deaf5e7","80317535-c5d8-4c8d-96f1-42e3cb16c056");


								

		
			UIControlBuilder.BuilderUFControl(this.lblMobileNo34, "12");		


				this.MobileNo34 = UIControlBuilder.BuilderTextBox(_UFTabPage, "MobileNo34", "True", "True", "False", "False", "Left", 0, 60, 0, 200, 20, 2, 4, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblMobileNo34","","50","328319f2-3270-4e08-8b6b-d7ba0deaf5e7","9e950216-6eaf-4c1b-b76c-5559152fb78d");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.MobileNo34, "False", "MobileNo", this.Model.CustomerDetailView, this.Model.CustomerDetailView.FieldMobileNo, "CustomerDetailView");


		
			UIControlBuilder.BuilderUFControl(this.MobileNo34, "13");		
		 

				this.lblPhoneNo37 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblPhoneNo37", "", "True", "True", "Right", 100, 20, 0, 5, 1, 1, "100","38ca0732-77aa-40df-85bd-9f09f0a19da5","6afe27fe-351c-4bbd-af4f-04835348a81d");


								

		
			UIControlBuilder.BuilderUFControl(this.lblPhoneNo37, "14");		


				this.PhoneNo37 = UIControlBuilder.BuilderTextBox(_UFTabPage, "PhoneNo37", "True", "True", "False", "False", "Left", 0, 60, 0, 200, 20, 2, 5, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblPhoneNo37","","50","38ca0732-77aa-40df-85bd-9f09f0a19da5","b98b0861-713b-4e55-90fb-6754f5f4aaa6");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.PhoneNo37, "False", "PhoneNo", this.Model.CustomerDetailView, this.Model.CustomerDetailView.FieldPhoneNo, "CustomerDetailView");


		
			UIControlBuilder.BuilderUFControl(this.PhoneNo37, "15");		
		 

				this.lblFax52 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblFax52", "", "True", "True", "Right", 100, 20, 0, 6, 1, 1, "100","a8ceb210-65c8-4c89-84e2-820b5a477892","463fffb6-6157-4617-9f2f-d25b63551723");


								

		
			UIControlBuilder.BuilderUFControl(this.lblFax52, "16");		


				this.Fax52 = UIControlBuilder.BuilderTextBox(_UFTabPage, "Fax52", "True", "True", "False", "False", "Left", 0, 60, 0, 200, 20, 2, 6, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblFax52","","50","a8ceb210-65c8-4c89-84e2-820b5a477892","bf7150a7-d58a-4c2b-86cd-11873830efff");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Fax52, "False", "Fax", this.Model.CustomerDetailView, this.Model.CustomerDetailView.FieldFax, "CustomerDetailView");


		
			UIControlBuilder.BuilderUFControl(this.Fax52, "17");		
		 

				this.lblSaleserNote76 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblSaleserNote76", "", "True", "True", "Right", 100, 20, 4, 0, 1, 1, "100","5ef7c5a6-32d0-46bb-8f6a-8ad5537b12f6","c82390e7-58a3-4afa-9261-cba94c00f8aa");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSaleserNote76, "18");		


				this.SaleserNote76 = UIControlBuilder.BuilderTextBox(_UFTabPage, "SaleserNote76", "True", "True", "True", "True", "Left", 0, 60, 0, 210, 170, 6, 0, 1, 7, "False", "100"
			,"",TextBoxMode.MultiLine,TextAlign.Left, true,false,"lblSaleserNote76","","500","5ef7c5a6-32d0-46bb-8f6a-8ad5537b12f6","1c2dcc46-5137-4e54-8066-752218dbe401");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SaleserNote76, "False", "SaleserNote", this.Model.CustomerDetailView, this.Model.CustomerDetailView.FieldSaleserNote, "CustomerDetailView");


		
			UIControlBuilder.BuilderUFControl(this.SaleserNote76, "19");		
		 


																				

            this.TabPage1 = _UFTabPage;
            return _UFTabPage;
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
            QryService.BindEnum("DDLCase", this, "8e1fef24-e19c-491f-a5a9-ef3ca530c5e0");
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
            ((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)this.DataGrid1).GridMakePageEventHandler += new GridMakePageDelegate(CustomerQucikDQryUIFormWebPart_GridMakePageEventHandler);

	}

        void CustomerQucikDQryUIFormWebPart_GridMakePageEventHandler(object sender, GridMakePageEventArgs e)
        {
            GridNavigateAction action = new GridNavigateAction(this.DataGrid1, new UFIDA.U9.Cust.FJGX.CustomerQucikQryBP.Proxy.QueryBPProxy(), "QryInParameter");

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
