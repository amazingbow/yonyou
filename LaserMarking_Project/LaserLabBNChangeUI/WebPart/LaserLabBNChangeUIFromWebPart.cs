


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
 * Form ID:841b7324-cdff-4913-8d16-a4ef94771d4e 
 * Form Name:LaserLabBNChangeUIFrom
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.XMJL.LaserLabBNChangeUI.LaserLabBNChangeUIModel
{
	[FormRegister("UFIDA.U9.Cust.XMQX.LaserLabBNChangeUI","UFIDA.U9.Cust.XMJL.LaserLabBNChangeUI.LaserLabBNChangeUIModel.LaserLabBNChangeUIFromWebPart", "UFIDA.U9.Cust.XMQX.LaserLabBNChangeUI.WebPart", "841b7324-cdff-4913-8d16-a4ef94771d4e","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.XMQX.LaserLabBNChangeUI', 'UFIDA.U9.Cust.XMJL.LaserLabBNChangeUI.LaserLabBNChangeUIModel.LaserLabBNChangeUIFromWebPart', 'UFIDA.U9.Cust.XMQX.LaserLabBNChangeUI.WebPart', '841b7324-cdff-4913-8d16-a4ef94771d4e')
	///<siteMapNode url="~/erp/simple.aspx?lnk=841b7324-cdff-4913-8d16-a4ef94771d4e" title="LaserLabBNChangeUIFrom"/>
    public partial class LaserLabBNChangeUIFromWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(LaserLabBNChangeUIFromWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new LaserLabBNChangeUIModelAction Action
		{
			get { return (LaserLabBNChangeUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		LaserLabBNChangeUIModelModel _uimodel=null;
		public new LaserLabBNChangeUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new LaserLabBNChangeUIModelModel();
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
                this.Model = value as LaserLabBNChangeUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFTabControl TabControl3;
        IUFTabPage TabPage0;
        IUFLine Line2;
        IUFLabel Label1;
        IUFFldTextBox TextBox1;
        IUFLabel Label2;
        IUFFldTextBox TextBox2;
        IUFLabel Label3;
        IUFFldTextBox TextBox3;
        IUFButton BtnExectue;
        IUFLine Line3;
        IUFLabel Label4;
        IUFFldTextBox TextBox4;
        IUFLabel Label5;
        IUFFldTextBox TextBox5;
        IUFLabel Label6;
        IUFFldTextBox TextBox6;
        IUFDataGrid DataGrid1;
        IUFButton AllBtnExecute;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public LaserLabBNChangeUIFromWebPart()
        {
            FormID = "841b7324-cdff-4913-8d16-a4ef94771d4e";
            IsAutoSize = bool.Parse("True");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.BtnExectue.Click += new EventHandler(BtnExectue_Click);		
						
				//Button控件事件
			this.BtnOk.Click += new EventHandler(BtnOk_Click);		
						
				//Button控件事件
			this.BtnClear.Click += new EventHandler(BtnClear_Click);		
						
				//Button控件事件
			this.AllBtnExecute.Click += new EventHandler(AllBtnExecute_Click);		
						

	
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid1).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid1_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid1).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid1_GridCustomFilterHandler);

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
					this.Model = new LaserLabBNChangeUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (LaserLabBNChangeUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new LaserLabBNChangeUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"LaserLabBNChangeUIFrom",true,992,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 0, 0, 0, 0, 0);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 0,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(1,bool.Parse("True")),new GridRowDef(502,bool.Parse("False")),new GridRowDef(1,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_TabControl3(_panel);

		
			UIControlBuilder.BuilderUFControl(this.TabControl3, "0");		



	
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







	         private void _BuilderControl_TabControl3(IUFContainer container)
        {
            IUFTabControl _UFTabControl = UIControlBuilder.BuildTabControl(container,"TabControl3",true, true, "0",EventResponseType.Client,992, 502, 0, 1, 1, 1, "100");
            ///foreach UFTabbedPane下的所有控件，增加到此容器
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage0(_UFTabControl));
            this.TabControl3 = _UFTabControl;
        }

	        private IUFTabPage _BuilderControl_TabPage0(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage0",true, true, "0","8a3faa05-5ad5-402c-83ea-cb37eab49498","8a3faa05-5ad5-402c-83ea-cb37eab49498");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 20, 14, 0, 10, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFTabPage,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 10,new GridColumnDef[]{new GridColumnDef(2,bool.Parse("False")),new GridColumnDef(40,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(40,bool.Parse("True")),new GridColumnDef(30,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(40,bool.Parse("True")),new GridColumnDef(70,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(40,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(2,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(6,bool.Parse("True")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),new GridRowDef(30,bool.Parse("False")),new GridRowDef(30,bool.Parse("False")),new GridRowDef(6,bool.Parse("True")),});
            ///foreach UFTab下的所有控件，增加到此容器





				this.Line2 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line2", 290, "Horizontal", "True", 290, 25, 1, 1, 5, 1, "100","9f706402-5883-4a1d-b266-da86e0207834","9f706402-5883-4a1d-b266-da86e0207834");
	

		
			UIControlBuilder.BuilderUFControl(this.Line2, "0");		


				this.Label1 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "Label1", "", "True", "True", "Right", 100, 25, 2, 2, 1, 1, "100","e14dea8f-2b8a-4783-8f60-b46767fe547b","e14dea8f-2b8a-4783-8f60-b46767fe547b");


								

		
			UIControlBuilder.BuilderUFControl(this.Label1, "1");		


				this.TextBox1 = UIControlBuilder.BuilderTextBox(_UFTabPage, "TextBox1", "True", "True", "True", "False", "Left", 0, 60, 0, 100, 25, 4, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"Label1","","","","d9907cd3-ab9f-427d-a88b-38d1b2ae9850");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.TextBox1, "False", "", null, null, "");


		
			UIControlBuilder.BuilderUFControl(this.TextBox1, "2");		
		 

				this.Label2 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "Label2", "", "True", "True", "Right", 100, 25, 2, 4, 1, 1, "100","3265bff4-1352-4ddc-94d6-df321a302bd9","3265bff4-1352-4ddc-94d6-df321a302bd9");


								

		
			UIControlBuilder.BuilderUFControl(this.Label2, "3");		


				this.TextBox2 = UIControlBuilder.BuilderTextBox(_UFTabPage, "TextBox2", "True", "True", "True", "False", "Left", 0, 60, 0, 100, 25, 4, 4, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"Label2","","","","9cb8783a-3cab-4c9b-bd5f-fbba92d6d759");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.TextBox2, "False", "", null, null, "");


		
			UIControlBuilder.BuilderUFControl(this.TextBox2, "4");		
		 

				this.Label3 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "Label3", "", "True", "True", "Right", 100, 25, 2, 6, 1, 1, "100","9777208f-0346-4d54-b6cd-6e14b259dcf5","9777208f-0346-4d54-b6cd-6e14b259dcf5");


								

		
			UIControlBuilder.BuilderUFControl(this.Label3, "5");		


				this.TextBox3 = UIControlBuilder.BuilderTextBox(_UFTabPage, "TextBox3", "True", "True", "True", "False", "Left", 0, 60, 0, 100, 25, 4, 6, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"Label3","","","","8035db20-fdb0-407e-bc6c-74e673312e3c");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.TextBox3, "False", "", null, null, "");


		
			UIControlBuilder.BuilderUFControl(this.TextBox3, "6");		
		 

				this.BtnExectue = UIControlBuilder.BuilderUFButton(_UFTabPage, true, "BtnExectue", true, true, 100, 30, 4, 12, 1, 1, "100","", this.Model.ElementID,"",false,"4e16d746-01bd-42d4-bec6-f62a28284f73","","4e16d746-01bd-42d4-bec6-f62a28284f73");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnExectue, "7");		


				this.Line3 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line3", 620, "Horizontal", "True", 620, 25, 7, 1, 11, 1, "100","db0fb785-2237-4b8a-817c-2e1e16d7e312","db0fb785-2237-4b8a-817c-2e1e16d7e312");
	

		
			UIControlBuilder.BuilderUFControl(this.Line3, "8");		


				this.Label4 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "Label4", "", "True", "True", "Right", 80, 25, 7, 2, 1, 1, "100","bb4674e3-c44c-458a-b9a8-651cabc3bb2a","bb4674e3-c44c-458a-b9a8-651cabc3bb2a");


								

		
			UIControlBuilder.BuilderUFControl(this.Label4, "9");		


				this.TextBox4 = UIControlBuilder.BuilderTextBox(_UFTabPage, "TextBox4", "True", "True", "True", "False", "Left", 0, 60, 0, 80, 25, 9, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"Label4","","","","26f90c2f-9374-4b7b-b41c-9098d7b0d6af");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.TextBox4, "False", "", null, null, "");


		
			UIControlBuilder.BuilderUFControl(this.TextBox4, "10");		
		 

				this.Label5 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "Label5", "", "True", "True", "Right", 70, 25, 11, 2, 1, 1, "100","e88b918b-b335-4a2f-aeeb-6739a2b5a6ac","e88b918b-b335-4a2f-aeeb-6739a2b5a6ac");


								

		
			UIControlBuilder.BuilderUFControl(this.Label5, "11");		


				this.TextBox5 = UIControlBuilder.BuilderTextBox(_UFTabPage, "TextBox5", "True", "True", "True", "False", "Left", 0, 60, 0, 80, 25, 13, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"Label5","","","","a7e7b1a0-552f-4afd-85c1-eaa79feb604b");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.TextBox5, "False", "", null, null, "");


		
			UIControlBuilder.BuilderUFControl(this.TextBox5, "12");		
		 

				this.Label6 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "Label6", "", "True", "True", "Right", 100, 25, 15, 2, 1, 1, "100","faddc403-542a-4f41-92c5-e17270d934f7","faddc403-542a-4f41-92c5-e17270d934f7");


								

		
			UIControlBuilder.BuilderUFControl(this.Label6, "13");		


				this.TextBox6 = UIControlBuilder.BuilderTextBox(_UFTabPage, "TextBox6", "True", "True", "True", "False", "Left", 0, 60, 0, 100, 25, 17, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"Label6","","","","d2771847-ef17-434b-93ef-1a47bd326c23");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.TextBox6, "False", "", null, null, "");


		
			UIControlBuilder.BuilderUFControl(this.TextBox6, "14");		
		 

	
			_BuilderControl_DataGrid1(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid1, "15");		


				this.AllBtnExecute = UIControlBuilder.BuilderUFButton(_UFTabPage, true, "AllBtnExecute", true, true, 100, 30, 17, 12, 1, 1, "100","", this.Model.ElementID,"",false,"e4c4b9d8-cadf-4eab-9c14-05e262d070cb","","e4c4b9d8-cadf-4eab-9c14-05e262d070cb");
	

		
			UIControlBuilder.BuilderUFControl(this.AllBtnExecute, "17");		



																	

            this.TabPage0 = _UFTabPage;
            return _UFTabPage;
        }

				





       
        private void _BuilderControl_DataGrid1(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid1", UFSoft.UBF.UI.ControlModel.EditStatus.Browse, false, false,true,false,true,true,20,true, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "15");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 620, 310, 7, 3, 11, 9, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.BatchLaserLabBNChangeView, "BatchLaserLabBNChangeView", "", null, 20, "批次号批量修改");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid1 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID78","NumberColumnModel", "", 0,this.Model.BatchLaserLabBNChangeView.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "",true, false,"","6552e376-2909-48c7-9c7a-39309ba330dd","6552e376-2909-48c7-9c7a-39309ba330dd","61a78af1-21c7-451a-99d7-535495ce9ad2");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion83","NumberColumnModel", "", 0,this.Model.BatchLaserLabBNChangeView.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, false, 7, 100, "",true, false,"","f625ac8e-63ef-4f31-b2e0-0e0ef2946b2c","f625ac8e-63ef-4f31-b2e0-0e0ef2946b2c","9ed39031-481b-4e34-b85d-f87e0782042f");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"LB0","TextBoxColumnModel", "", 0,this.Model.BatchLaserLabBNChangeView.Fields["LB"]/*LB*/,"LB", false, true, true, false, false, true, 0, 100, "50",true, false,"","3e074974-316f-4a18-bde4-79097174fdc1","3e074974-316f-4a18-bde4-79097174fdc1","d410d4d1-8a7f-4146-af71-5f690f60ebe7");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"BN0","TextBoxColumnModel", "", 0,this.Model.BatchLaserLabBNChangeView.Fields["BN"]/*BN*/,"BN", false, true, true, false, false, true, 0, 100, "50",true, false,"","9ff0ef42-d343-4ad8-af55-90fccb4841bb","9ff0ef42-d343-4ad8-af55-90fccb4841bb","bcf661c8-9a46-45ce-ad5a-ae8a1af2546e");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CP0","TextBoxColumnModel", "", 0,this.Model.BatchLaserLabBNChangeView.Fields["CP"]/*CP*/,"CP", false, true, true, false, false, true, 0, 100, "50",true, false,"","b92fca79-cc54-4c1f-9d21-19388a9fbee9","b92fca79-cc54-4c1f-9d21-19388a9fbee9","b0ce0ad7-6d50-47d5-aa90-8894028b5aad");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"MasterDT0","DatePickerColumnModel", "", 0,this.Model.BatchLaserLabBNChangeView.Fields["MasterDT"]/*MasterDT*/,"MasterDT", false, true, true, false, false, true, 5, 70, "17",true, false,"","bbf85650-3874-4566-b132-b1b8c45f9cf3","bbf85650-3874-4566-b132-b1b8c45f9cf3","71e22938-a69a-4c19-a17f-e3d6216aff3c");
                   
			((IUFDatePickerColumn)column).DateTimeType = DateTimeType.DateTime;
            ((IUFDatePickerColumn)column).DateTimeFormat = CurrentState._I18N._DateTimeFormatInfo;
	  
		 
        }





		#endregion
		

	}
}
