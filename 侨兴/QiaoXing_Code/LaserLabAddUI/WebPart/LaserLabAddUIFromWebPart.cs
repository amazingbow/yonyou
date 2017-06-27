


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
 * Form ID:91c2cd56-7e24-4b0c-9737-54f6a11a8637 
 * Form Name:LaserLabAddUIFrom
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.XMQX.LaserLabAddUIModel
{
	[FormRegister("UFIDA.U9.Cust.XMQX.LaserLabAddUI","UFIDA.U9.Cust.XMQX.LaserLabAddUIModel.LaserLabAddUIFromWebPart", "UFIDA.U9.Cust.XMQX.LaserLabAddUI.WebPart", "91c2cd56-7e24-4b0c-9737-54f6a11a8637","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.XMQX.LaserLabAddUI', 'UFIDA.U9.Cust.XMQX.LaserLabAddUIModel.LaserLabAddUIFromWebPart', 'UFIDA.U9.Cust.XMQX.LaserLabAddUI.WebPart', '91c2cd56-7e24-4b0c-9737-54f6a11a8637')
	///<siteMapNode url="~/erp/simple.aspx?lnk=91c2cd56-7e24-4b0c-9737-54f6a11a8637" title="LaserLabAddUIFrom"/>
    public partial class LaserLabAddUIFromWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(LaserLabAddUIFromWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new LaserLabAddUIModelAction Action
		{
			get { return (LaserLabAddUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		LaserLabAddUIModelModel _uimodel=null;
		public new LaserLabAddUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new LaserLabAddUIModelModel();
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
                this.Model = value as LaserLabAddUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFCard Card3;
        IUFTabControl TabControl1;
        IUFTabPage TabPage9;
        IUFLabel lblID95;
        IUFFldNumberControl ID95;
        IUFLabel lblSysVersion92;
        IUFFldNumberControl SysVersion92;
        IUFLabel lblBN71;
        IUFFldTextBox BN71;
        IUFLabel lblLB101;
        IUFFldTextBox LB101;
        IUFLabel lblType89;
        IUFFldTextBox Type89;
        IUFLabel lblCustomer104;
        IUFFldTextBox Customer104;
        IUFButton BtnSave;
        IUFButton BtnClear;
        IUFTabPage TabPage2;
        IUFLabel Label1;
        IUFFldTextBox TextBox1;
        IUFLabel Label2;
        IUFFldTextBox TextBox2;
        IUFLabel Label3;
        IUFFldTextBox TextBox3;
        IUFLabel Label4;
        IUFLabel Label5;
        IUFLabel Label6;
        IUFFldTextBox TextBox5;
        IUFLabel Label7;
        IUFDataGrid DataGrid8;
        IUFButton BtnSoloRight;
        IUFButton BtnAllRight;
        IUFButton BtnSoloLeft;
        IUFDataGrid DataGrid9;
        IUFButton BtnAllSave;
        IUFButton BtnAllClear;
        IUFButton BtnAllLeft;
        IUFFldNumberControl NumberControl1;
        IUFFldNumberControl NumberControl2;
        IUFFldNumberControl NumberControl3;
        IUFButton BtnCreateLB;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public LaserLabAddUIFromWebPart()
        {
            FormID = "91c2cd56-7e24-4b0c-9737-54f6a11a8637";
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
			this.BtnClear.Click += new EventHandler(BtnClear_Click);		
						
				//Button控件事件
			this.BtnSoloRight.Click += new EventHandler(BtnSoloRight_Click);		
						
				//Button控件事件
			this.BtnAllRight.Click += new EventHandler(BtnAllRight_Click);		
						
				//Button控件事件
			this.BtnSoloLeft.Click += new EventHandler(BtnSoloLeft_Click);		
						
				//Button控件事件
			this.BtnAllSave.Click += new EventHandler(BtnAllSave_Click);		
						
				//Button控件事件
			this.BtnAllClear.Click += new EventHandler(BtnAllClear_Click);		
						
				//Button控件事件
			this.BtnAllLeft.Click += new EventHandler(BtnAllLeft_Click);		
						
				//Button控件事件
			this.BtnCreateLB.Click += new EventHandler(BtnCreateLB_Click);		
						

		
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid8).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid8_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid8).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid8_GridCustomFilterHandler);
	
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid9).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid9_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid9).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid9_GridCustomFilterHandler);

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
					this.Model = new LaserLabAddUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (LaserLabAddUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new LaserLabAddUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"LaserLabAddUIFrom",true,992,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 5, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 5,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(2,bool.Parse("True")),new GridRowDef(480,bool.Parse("False")),new GridRowDef(2,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Card3(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card3, "2");		



	
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







	                   
        private IUFCard _BuilderControl_Card3(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card3",false,"none", true, true, "2","","7c83f3a6-90cb-40d9-bd4f-bd718ba61452");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 480, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 2, 2, 0, 10, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 10,new GridColumnDef[]{new GridColumnDef(971,bool.Parse("False")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(468,bool.Parse("False")),new GridRowDef(1,bool.Parse("False")),});
            this.Card3 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_TabControl1(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.TabControl1, "1");		



	

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	         private void _BuilderControl_TabControl1(IUFContainer container)
        {
            IUFTabControl _UFTabControl = UIControlBuilder.BuildTabControl(container,"TabControl1",true, true, "1",EventResponseType.Client,972, 479, 0, 0, 2, 2, "100");
            ///foreach UFTabbedPane下的所有控件，增加到此容器
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage9(_UFTabControl));
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage2(_UFTabControl));
            this.TabControl1 = _UFTabControl;
        }

	        private IUFTabPage _BuilderControl_TabPage9(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage9",true, true, "1","c9b937fa-95d5-4814-b61a-1e052e81aaaf","c9b937fa-95d5-4814-b61a-1e052e81aaaf");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 15, 10, 0, 12, 5, 5, 5, 5);
			InitViewBindingContainer(this, _UFTabPage,  this.Model.SoloLaserLabAddView, "SoloLaserLabAddView", "", null, 1, "编码录入-单个录入模型");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 12,new GridColumnDef[]{new GridColumnDef(87,bool.Parse("False")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(40,bool.Parse("True")),new GridColumnDef(65,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(145,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(40,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(87,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(1,bool.Parse("False")),new GridRowDef(64,bool.Parse("True")),new GridRowDef(30,bool.Parse("True")),new GridRowDef(30,bool.Parse("True")),new GridRowDef(30,bool.Parse("True")),new GridRowDef(30,bool.Parse("True")),new GridRowDef(45,bool.Parse("True")),new GridRowDef(35,bool.Parse("True")),new GridRowDef(65,bool.Parse("True")),new GridRowDef(1,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





				this.lblID95 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblID95", "", "False", "True", "Right", 105, 30, 0, 0, 1, 1, "100","41177e8d-dd77-46b3-aa6b-b7b4348b29b6","8374e369-dcbf-49e7-ae52-229f09503e54");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID95, "0");		


				this.ID95 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "ID95", "False", "False", "True", "Left", 7, 60, 0, 105, 30, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID95","","41177e8d-dd77-46b3-aa6b-b7b4348b29b6","cf07c55b-50cb-4c89-8287-18c31133a387",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID95, "False", "ID", this.Model.SoloLaserLabAddView, this.Model.SoloLaserLabAddView.FieldID, "SoloLaserLabAddView");
	
		
			UIControlBuilder.BuilderUFControl(this.ID95, "1");		
		 

				this.lblSysVersion92 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblSysVersion92", "", "False", "True", "Right", 105, 30, 0, 0, 1, 1, "100","0ef7756b-6344-4e92-bd56-059d4556ea0a","e473053c-9f3f-402c-b523-a80b1dd8a985");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion92, "2");		


				this.SysVersion92 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "SysVersion92", "False", "False", "True", "Left", 7, 60, 0, 105, 30, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion92","","0ef7756b-6344-4e92-bd56-059d4556ea0a","9d79959b-5ad8-4a7e-b489-7c562b45222f",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion92, "False", "SysVersion", this.Model.SoloLaserLabAddView, this.Model.SoloLaserLabAddView.FieldSysVersion, "SoloLaserLabAddView");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion92, "3");		
		 

				this.lblBN71 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblBN71", "", "True", "True", "Right", 65, 30, 6, 2, 1, 1, "100","15adc8c6-5d6e-4939-9097-10a383be4057","15adc8c6-5d6e-4939-9097-10a383be4057");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBN71, "4");		


				this.BN71 = UIControlBuilder.BuilderTextBox(_UFTabPage, "BN71", "True", "True", "True", "False", "Left", 0, 60, 0, 145, 30, 8, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblBN71","","50","603140db-6b79-4ad4-9e46-0f8003d41d3c","817c449d-cdff-438b-add5-c54ee806277e");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BN71, "False", "BN", this.Model.SoloLaserLabAddView, this.Model.SoloLaserLabAddView.FieldBN, "SoloLaserLabAddView");


		
			UIControlBuilder.BuilderUFControl(this.BN71, "5");		
		 

				this.lblLB101 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblLB101", "", "True", "True", "Right", 65, 30, 6, 3, 1, 1, "100","464637e9-56ce-4356-bbc3-5248b9b5dac7","464637e9-56ce-4356-bbc3-5248b9b5dac7");


								

		
			UIControlBuilder.BuilderUFControl(this.lblLB101, "6");		


				this.LB101 = UIControlBuilder.BuilderTextBox(_UFTabPage, "LB101", "True", "True", "True", "False", "Left", 0, 60, 0, 145, 30, 8, 3, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblLB101","","50","9c8384d8-8321-4fb3-b76a-7784f711595f","f90ff370-4d8b-45bd-947b-fa6d0572136f");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.LB101, "False", "LB", this.Model.SoloLaserLabAddView, this.Model.SoloLaserLabAddView.FieldLB, "SoloLaserLabAddView");


		
			UIControlBuilder.BuilderUFControl(this.LB101, "7");		
		 

				this.lblType89 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblType89", "", "True", "True", "Right", 65, 30, 6, 4, 1, 1, "100","c609b09e-2bb0-4ef0-951e-1e0f2a6c51d6","c609b09e-2bb0-4ef0-951e-1e0f2a6c51d6");


								

		
			UIControlBuilder.BuilderUFControl(this.lblType89, "8");		


				this.Type89 = UIControlBuilder.BuilderTextBox(_UFTabPage, "Type89", "True", "True", "True", "False", "Left", 0, 60, 0, 145, 30, 8, 4, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblType89","","50","9ed42a1b-05ac-478d-9fd5-d34c8fb4a08a","565e3e6b-43c7-4e32-a778-068b23f7d0b3");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Type89, "False", "Type", this.Model.SoloLaserLabAddView, this.Model.SoloLaserLabAddView.FieldType, "SoloLaserLabAddView");


		
			UIControlBuilder.BuilderUFControl(this.Type89, "9");		
		 

				this.lblCustomer104 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblCustomer104", "", "True", "True", "Right", 65, 30, 6, 5, 1, 1, "100","ae84fad4-c6fc-4606-a223-5fcfcce2b64b","ae84fad4-c6fc-4606-a223-5fcfcce2b64b");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustomer104, "10");		


				this.Customer104 = UIControlBuilder.BuilderTextBox(_UFTabPage, "Customer104", "True", "True", "True", "False", "Left", 0, 60, 0, 145, 30, 8, 5, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCustomer104","","50","5c88c4cb-db70-4abd-84d9-5fcfcf3d7d6b","88922db0-f46f-470b-8873-21316aa99ca3");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Customer104, "False", "Customer", this.Model.SoloLaserLabAddView, this.Model.SoloLaserLabAddView.FieldCustomer, "SoloLaserLabAddView");


		
			UIControlBuilder.BuilderUFControl(this.Customer104, "11");		
		 

				this.BtnSave = UIControlBuilder.BuilderUFButton(_UFTabPage, true, "BtnSave", true, true, 80, 35, 9, 7, 1, 1, "100","", this.Model.ElementID,"",false,"4119dc0c-f5e8-42f1-9822-3a6373237758","","4119dc0c-f5e8-42f1-9822-3a6373237758");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnSave, "12");		


				this.BtnClear = UIControlBuilder.BuilderUFButton(_UFTabPage, true, "BtnClear", true, true, 80, 35, 11, 7, 1, 1, "100","", this.Model.ElementID,"",false,"9472c5ba-c380-4214-bd44-2e0792a30f07","","9472c5ba-c380-4214-bd44-2e0792a30f07");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnClear, "13");		



														

            this.TabPage9 = _UFTabPage;
            return _UFTabPage;
        }

	        private IUFTabPage _BuilderControl_TabPage2(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage2",true, true, "2","c9230f25-ee66-4fbf-a413-69bb95647882","c9230f25-ee66-4fbf-a413-69bb95647882");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 22, 18, 0, 5, 5, 5, 5, 5);
			InitViewBindingContainer(this, _UFTabPage,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(17,bool.Parse("False")),new GridColumnDef(45,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(40,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(15,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(15,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(55,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(70,bool.Parse("True")),new GridColumnDef(50,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(17,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(1,bool.Parse("True")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(30,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(30,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(30,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(30,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(10,bool.Parse("False")),new GridRowDef(1,bool.Parse("True")),});
            ///foreach UFTab下的所有控件，增加到此容器





				this.Label1 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "Label1", "", "True", "True", "Right", 60, 20, 2, 2, 1, 1, "100","8b2cdd50-0a52-4c5c-b4a4-7f4da23b2f4b","8b2cdd50-0a52-4c5c-b4a4-7f4da23b2f4b");


								

		
			UIControlBuilder.BuilderUFControl(this.Label1, "0");		


				this.TextBox1 = UIControlBuilder.BuilderTextBox(_UFTabPage, "TextBox1", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 4, 2, 2, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"Label1","","","","bda2f87e-9d8d-4b01-9419-9b83484a675a");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.TextBox1, "False", "", null, null, "");


		
			UIControlBuilder.BuilderUFControl(this.TextBox1, "1");		
		 

				this.Label2 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "Label2", "", "True", "True", "Right", 60, 20, 7, 2, 1, 1, "100","ac462058-4490-4589-9aef-ea7b8f706118","ac462058-4490-4589-9aef-ea7b8f706118");


								

		
			UIControlBuilder.BuilderUFControl(this.Label2, "2");		


				this.TextBox2 = UIControlBuilder.BuilderTextBox(_UFTabPage, "TextBox2", "True", "True", "True", "False", "Left", 0, 60, 0, 75, 20, 9, 2, 2, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"Label2","","","","e3896280-efde-4e6d-8874-9500d0b3e5d0");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.TextBox2, "False", "", null, null, "");


		
			UIControlBuilder.BuilderUFControl(this.TextBox2, "3");		
		 

				this.Label3 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "Label3", "", "True", "True", "Right", 55, 20, 12, 2, 1, 1, "100","8b7f1eba-f74d-420b-b7de-3583823aa460","8b7f1eba-f74d-420b-b7de-3583823aa460");


								

		
			UIControlBuilder.BuilderUFControl(this.Label3, "4");		


				this.TextBox3 = UIControlBuilder.BuilderTextBox(_UFTabPage, "TextBox3", "True", "True", "True", "False", "Left", 0, 60, 0, 70, 20, 14, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"Label3","","","","deb11d77-5703-4f2b-9dbd-5c18de502a21");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.TextBox3, "False", "", null, null, "");


		
			UIControlBuilder.BuilderUFControl(this.TextBox3, "5");		
		 

				this.Label4 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "Label4", "", "True", "True", "Right", 80, 20, 16, 2, 1, 1, "100","00b7aba7-384f-412e-826e-9e70844f744e","00b7aba7-384f-412e-826e-9e70844f744e");


								

		
			UIControlBuilder.BuilderUFControl(this.Label4, "7");		


				this.Label5 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "Label5", "", "True", "True", "Right", 60, 20, 2, 3, 1, 1, "100","e063ae8e-3629-40b1-b413-d2839f1c625d","e063ae8e-3629-40b1-b413-d2839f1c625d");


								

		
			UIControlBuilder.BuilderUFControl(this.Label5, "8");		


				this.Label6 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "Label6", "", "True", "True", "Right", 60, 20, 7, 3, 1, 1, "100","6680ef48-4821-4c0e-aca1-701b9ce51f96","6680ef48-4821-4c0e-aca1-701b9ce51f96");


								

		
			UIControlBuilder.BuilderUFControl(this.Label6, "9");		


				this.TextBox5 = UIControlBuilder.BuilderTextBox(_UFTabPage, "TextBox5", "True", "True", "True", "False", "Left", 0, 60, 0, 80, 20, 4, 3, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"Label5","","","","c8eedf46-1650-4001-9fd3-237f398c812e");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.TextBox5, "False", "", null, null, "");


		
			UIControlBuilder.BuilderUFControl(this.TextBox5, "10");		
		 

				this.Label7 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "Label7", "", "True", "True", "Right", 55, 20, 12, 3, 1, 1, "100","4ced92d8-fe5b-4212-b7bd-1d75a7b19115","4ced92d8-fe5b-4212-b7bd-1d75a7b19115");


								

		
			UIControlBuilder.BuilderUFControl(this.Label7, "12");		


	
			_BuilderControl_DataGrid8(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid8, "14");		


				this.BtnSoloRight = UIControlBuilder.BuilderUFButton(_UFTabPage, true, "BtnSoloRight", true, true, 60, 30, 9, 6, 1, 1, "100","", this.Model.ElementID,"",false,"79f369d2-ca71-4ecb-afc8-1a5d37f86444","","79f369d2-ca71-4ecb-afc8-1a5d37f86444");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnSoloRight, "15");		


				this.BtnAllRight = UIControlBuilder.BuilderUFButton(_UFTabPage, true, "BtnAllRight", true, true, 60, 30, 9, 8, 1, 1, "100","", this.Model.ElementID,"",false,"1be10acf-cdd8-4938-8e7f-a98bff2e6894","","1be10acf-cdd8-4938-8e7f-a98bff2e6894");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnAllRight, "16");		


				this.BtnSoloLeft = UIControlBuilder.BuilderUFButton(_UFTabPage, true, "BtnSoloLeft", true, true, 60, 30, 9, 10, 1, 1, "100","", this.Model.ElementID,"",false,"aa968e8a-1f52-486a-8ed6-e096743dfcea","","aa968e8a-1f52-486a-8ed6-e096743dfcea");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnSoloLeft, "17");		


	
			_BuilderControl_DataGrid9(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid9, "18");		


				this.BtnAllSave = UIControlBuilder.BuilderUFButton(_UFTabPage, true, "BtnAllSave", true, true, 60, 30, 20, 10, 1, 1, "100","", this.Model.ElementID,"",false,"4db991fd-bbcd-4425-afcd-910053d141ba","","4db991fd-bbcd-4425-afcd-910053d141ba");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnAllSave, "19");		


				this.BtnAllClear = UIControlBuilder.BuilderUFButton(_UFTabPage, true, "BtnAllClear", true, true, 60, 30, 20, 12, 1, 1, "100","", this.Model.ElementID,"",false,"72611f7b-4c27-4aab-96ea-7e5f2a8058c1","","72611f7b-4c27-4aab-96ea-7e5f2a8058c1");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnAllClear, "20");		


				this.BtnAllLeft = UIControlBuilder.BuilderUFButton(_UFTabPage, true, "BtnAllLeft", true, true, 60, 30, 9, 12, 1, 1, "100","", this.Model.ElementID,"",false,"7fdcca23-584a-4376-be8b-4f074e324838","","7fdcca23-584a-4376-be8b-4f074e324838");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnAllLeft, "21");		


				this.NumberControl1 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "NumberControl1", "True", "True", "True", "Left", 0, 60, 0, 60, 20, 18, 2, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Left,0,true,false,true,"Label4","","","0360faeb-00d1-490d-942f-7490f0d0e5da",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.NumberControl1, "False", "", null, null, "");
	
		
			UIControlBuilder.BuilderUFControl(this.NumberControl1, "22");		
		 

				this.NumberControl2 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "NumberControl2", "True", "True", "True", "Left", 0, 60, 0, 75, 20, 9, 3, 2, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Left,0,true,false,true,"Label6","","","c72f1af5-9210-46da-b0aa-e6a1430cd951",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.NumberControl2, "False", "", null, null, "");
	
		
			UIControlBuilder.BuilderUFControl(this.NumberControl2, "23");		
		 

				this.NumberControl3 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "NumberControl3", "True", "True", "True", "Left", 0, 60, 0, 70, 20, 14, 3, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Left,0,true,false,true,"Label7","","","da744b78-16c8-40a9-9b0e-1c5b3a030f92",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.NumberControl3, "False", "", null, null, "");
	
		
			UIControlBuilder.BuilderUFControl(this.NumberControl3, "24");		
		 

				this.BtnCreateLB = UIControlBuilder.BuilderUFButton(_UFTabPage, true, "BtnCreateLB", true, true, 60, 20, 20, 3, 1, 1, "100","", this.Model.ElementID,"",false,"e1fae196-80cd-4af8-829f-42d09ee118d7","","e1fae196-80cd-4af8-829f-42d09ee118d7");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnCreateLB, "25");		



																							

            this.TabPage2 = _UFTabPage;
            return _UFTabPage;
        }

				





       
        private void _BuilderControl_DataGrid8(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid8", UFSoft.UBF.UI.ControlModel.EditStatus.Browse, false, false,false,false,false,true,20,true, true) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "14");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 355, 285, 1, 5, 7, 10, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.AllLaserLabCreateView, "AllLaserLabCreateView", "", null, 20, "编码录入-批量生成模型");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=true;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=true;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=true;
            this.DataGrid8 = _UFGrid;
            container.Controls.Add(_UFGrid);
			//Grid所有页全选事件 
			((UFWebDataGridAdapter)this.DataGrid8).GridSelectAllPageHandler +=
				new GridSelectAllPageDelegate(UFIDA.U9.UI.PDHelper.PDListHelper.UFGridDataGrid_GridSelectAllPageDelegate);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID96","NumberColumnModel", "", 0,this.Model.AllLaserLabCreateView.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "",true, false,"","8452cfc7-b42c-4b03-a63a-44326be74eff","8452cfc7-b42c-4b03-a63a-44326be74eff","cc9f3ecb-2028-42c1-813c-7c98e6f6b21a");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion93","NumberColumnModel", "", 0,this.Model.AllLaserLabCreateView.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, false, 7, 100, "",true, false,"","87b46493-5a96-4b1e-848a-44a3d2e5c4cb","87b46493-5a96-4b1e-848a-44a3d2e5c4cb","f876788c-2fcf-4d75-8578-10e60b04925d");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"BN72","TextBoxColumnModel", "", 0,this.Model.AllLaserLabCreateView.Fields["BN"]/*BN*/,"BN", false, true, true, false, false, true, 0, 100, "50",true, false,"","f3151ab6-9a0b-4729-bd56-f4e5261e786c","f3151ab6-9a0b-4729-bd56-f4e5261e786c","d14a30b4-0fce-4710-8ac2-8da33f94e426");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"LB102","TextBoxColumnModel", "", 0,this.Model.AllLaserLabCreateView.Fields["LB"]/*LB*/,"LB", false, true, true, false, false, true, 0, 100, "50",true, false,"","a4102ca5-2063-4393-a8bd-022591d9b748","a4102ca5-2063-4393-a8bd-022591d9b748","3c71d519-bb14-4f6e-90c2-d687e0146c82");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Type90","TextBoxColumnModel", "", 0,this.Model.AllLaserLabCreateView.Fields["Type"]/*Type*/,"Type", false, true, true, false, false, true, 0, 100, "50",true, false,"","8c26deb4-94ad-474e-a3df-df5888b0f79f","8c26deb4-94ad-474e-a3df-df5888b0f79f","c1b101f9-a19c-4bac-9b22-f2104e400ef8");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Customer105","TextBoxColumnModel", "", 0,this.Model.AllLaserLabCreateView.Fields["Customer"]/*Customer*/,"Customer", false, true, true, false, false, true, 0, 100, "50",true, false,"","7ad4741b-64e9-4130-b141-59d34ce0ea75","7ad4741b-64e9-4130-b141-59d34ce0ea75","3411890b-12ad-4cc5-a6cd-c112f65fdec9");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 
        }

				





       
        private void _BuilderControl_DataGrid9(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid9", UFSoft.UBF.UI.ControlModel.EditStatus.Browse, false, false,false,false,false,true,20,true, true) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "18");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 395, 285, 11, 5, 8, 10, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.AllLaserLabAddView, "AllLaserLabAddView", "", null, 20, "编码录入-批量录入模型");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=true;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=true;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=true;
            this.DataGrid9 = _UFGrid;
            container.Controls.Add(_UFGrid);
			//Grid所有页全选事件 
			((UFWebDataGridAdapter)this.DataGrid9).GridSelectAllPageHandler +=
				new GridSelectAllPageDelegate(UFIDA.U9.UI.PDHelper.PDListHelper.UFGridDataGrid_GridSelectAllPageDelegate);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID97","NumberColumnModel", "", 0,this.Model.AllLaserLabAddView.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "",true, false,"","710693a4-45d0-439a-a800-b54e46b17350","710693a4-45d0-439a-a800-b54e46b17350","943b0104-7528-43bc-b227-eb10da186042");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion94","NumberColumnModel", "", 0,this.Model.AllLaserLabAddView.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, false, 7, 100, "",true, false,"","77b58339-aa3c-4cc7-9965-88379ec705c4","77b58339-aa3c-4cc7-9965-88379ec705c4","189c299a-8ee7-4c47-bc56-62c871e792e3");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"BN73","TextBoxColumnModel", "", 0,this.Model.AllLaserLabAddView.Fields["BN"]/*BN*/,"BN", false, true, true, false, false, true, 0, 100, "50",true, false,"","7192ad66-2e3c-43f0-adb9-f28192d8bc41","7192ad66-2e3c-43f0-adb9-f28192d8bc41","e79d6c81-f586-4250-85c4-8610739d0920");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"LB103","TextBoxColumnModel", "", 0,this.Model.AllLaserLabAddView.Fields["LB"]/*LB*/,"LB", false, true, true, false, false, true, 0, 100, "50",true, false,"","143e7173-ba55-463f-aee5-ee2906635336","143e7173-ba55-463f-aee5-ee2906635336","8155f661-a3bf-4176-bd43-8c7da2ad69ef");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Type91","TextBoxColumnModel", "", 0,this.Model.AllLaserLabAddView.Fields["Type"]/*Type*/,"Type", false, true, true, false, false, true, 0, 100, "50",true, false,"","92fd6749-f5be-400d-9893-f95dd171cfc3","92fd6749-f5be-400d-9893-f95dd171cfc3","e2272a6d-b886-489b-af65-54302a47b0a3");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Customer106","TextBoxColumnModel", "", 0,this.Model.AllLaserLabAddView.Fields["Customer"]/*Customer*/,"Customer", false, true, true, false, false, true, 0, 100, "50",true, false,"","675ca4cb-eab2-462e-8d71-81fd5ca6dcc7","675ca4cb-eab2-462e-8d71-81fd5ca6dcc7","018013eb-7083-4809-93ee-777e112187a8");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 
        }





		#endregion
		

	}
}
