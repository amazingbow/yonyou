﻿


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
 * Form ID:e64f3280-ab80-447f-83b3-41dfdbad9053 
 * Form Name:AdvApplyUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.AdvApplyUI.AdvApplyUIModel
{
	[FormRegister("UFIDA.U9.Cust.AdvApplyUI","UFIDA.U9.Cust.AdvApplyUI.AdvApplyUIModel.AdvApplyUIFormWebPart", "UFIDA.U9.Cust.AdvApplyUI.WebPart", "e64f3280-ab80-447f-83b3-41dfdbad9053","WebPart", "True", 1024, 728)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.AdvApplyUI', 'UFIDA.U9.Cust.AdvApplyUI.AdvApplyUIModel.AdvApplyUIFormWebPart', 'UFIDA.U9.Cust.AdvApplyUI.WebPart', 'e64f3280-ab80-447f-83b3-41dfdbad9053')
	///<siteMapNode url="~/erp/simple.aspx?lnk=e64f3280-ab80-447f-83b3-41dfdbad9053" title="AdvApplyUIForm"/>
    public partial class AdvApplyUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(AdvApplyUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new AdvApplyUIModelAction Action
		{
			get { return (AdvApplyUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		AdvApplyUIModelModel _uimodel=null;
		public new AdvApplyUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new AdvApplyUIModelModel();
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
                this.Model = value as AdvApplyUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFTabControl TabControl6;
        IUFTabPage TabPage25;
        IUFLine Line0;
        IUFLabel lblApplier106;
        IUFFldTextBox Applier106;
        IUFLabel lblPhone218;
        IUFFldTextBox Phone218;
        IUFLabel lblQQ157;
        IUFFldTextBox QQ157;
        IUFLabel lblApplyDate268;
        IUFFldDatePicker ApplyDate268;
        IUFLine Line1;
        IUFLabel lblCustConterName115;
        IUFFldTextBox CustConterName115;
        IUFLabel lblRelPeople158;
        IUFFldTextBox RelPeople158;
        IUFLabel lblCustAddress133;
        IUFFldTextBox CustAddress133;
        IUFLabel lblCustPhone184;
        IUFFldTextBox CustPhone184;
        IUFLabel lblLocationQY196;
        IUFFldTextBox LocationQY196;
        IUFLabel lblLocationXZ172;
        IUFFldTextBox LocationXZ172;
        IUFFldFlexFieldPicker FlexFieldPicker0;
        IUFLabel lblApplyDept233;
        IUFFldReference ApplyDept233;
        IUFTabPage TabPage32;
        IUFLine Line3;
        IUFLabel lblQty693;
        IUFFldNumberControl Qty693;
        IUFLabel lblTotalArea333;
        IUFFldNumberControl TotalArea333;
        IUFLine Line4;
        IUFLine Line5;
        IUFLabel lblBMWidth146;
        IUFFldNumberControl BMWidth146;
        IUFLabel lblBMHight124;
        IUFFldNumberControl BMHight124;
        IUFLabel lblBMThick115;
        IUFFldNumberControl BMThick115;
        IUFLabel lblBMArea187;
        IUFFldNumberControl BMArea187;
        IUFLabel lblDZWidth187;
        IUFFldNumberControl DZWidth187;
        IUFLabel lblDZThick224;
        IUFFldNumberControl DZThick224;
        IUFLabel lblDZArea338;
        IUFFldNumberControl DZArea338;
        IUFLine Line7;
        IUFLine Line12;
        IUFLabel lblAdvDisplayType588;
        IUFFldDropDownList AdvDisplayType588;
        IUFImage Image12;
        IUFImage Image13;
        IUFImage Image14;
        IUFLabel lblAdvDispInfo111851;
        IUFFldDropDownList AdvDispInfo111851;
        IUFLabel lblAdvDispInfo222913;
        IUFFldDropDownList AdvDispInfo222913;
        IUFLabel lblAdvCarrier146;
        IUFFldReference AdvCarrier146;
        IUFDataGrid DataGrid0;
        IUFTabPage TabPage33;
        IUFLine Line8;
        IUFFldTextBox AdvMemo802;
        IUFCard Card7;
        IUFLabel lblAdvApplyDocType216;
        IUFFldReference AdvApplyDocType216;
        IUFLabel lblDocStatus162;
        IUFFldDropDownList DocStatus162;
        IUFLabel lblID67;
        IUFFldNumberControl ID67;
        IUFLabel lblSysVersion94;
        IUFFldNumberControl SysVersion94;
        IUFLabel lblAdvCode605;
        IUFFldTextBox AdvCode605;
        IUFToolbar Toolbar5;
        IUFButton BtnSave;
        IUFButton BtnCancel;
        IUFButton BtnNew;
        IUFButton BtnDelete;
        IUFSeparator Separator12;
        IUFButton BtnCopy;
        IUFSeparator Separator13;
        IUFButton BtnSubmit;
        IUFButton BtnApprove;
        IUFButton BtnUndoApprove;
        IUFSeparator Separator14;
        IUFButton BtnFind;
        IUFButton BtnList;
        IUFSeparator Separator15;
        IUFSeparator Separator16;
        IUFButton BtnFlow;
        IUFSeparator Separator17;
        IUFButton BtnPrint;
        IUFCard Card8;
        IUFDropDownButton DropDownButton0;
        IUFMenu CloseClick;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public AdvApplyUIFormWebPart()
        {
            FormID = "e64f3280-ab80-447f-83b3-41dfdbad9053";
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
			this.BtnNew.Click += new EventHandler(BtnNew_Click);		
						
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
			this.BtnFlow.Click += new EventHandler(BtnFlow_Click);		
						
				//Button控件事件
			this.BtnPrint.Click += new EventHandler(BtnPrint_Click);		
						
				//DropDownButton下面的MenuModel控件事件
			this.CloseClick.ItemClick += new MenuItemHandle(CloseClick_Click);
			((PopMenuItem)this.CloseClick).MethodName = "CloseClick_Click";				
				

			
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
					this.Model = new AdvApplyUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (AdvApplyUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new AdvApplyUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"AdvApplyUIForm",true,1024,728);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 4, 0, 5, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 5,new GridColumnDef[]{new GridColumnDef(1000,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(28,bool.Parse("True")),new GridRowDef(36,bool.Parse("True")),new GridRowDef(611,bool.Parse("False")),new GridRowDef(32,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_TabControl6(_panel);

		
			UIControlBuilder.BuilderUFControl(this.TabControl6, "3");		


	
			_BuilderControl_Card7(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card7, "0");		


	
			_BuilderControl_Toolbar5(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Toolbar5, "1");		


	
			_BuilderControl_Card8(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card8, "3");		



				
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







	         private void _BuilderControl_TabControl6(IUFContainer container)
        {
            IUFTabControl _UFTabControl = UIControlBuilder.BuildTabControl(container,"TabControl6",true, true, "3",EventResponseType.Client,1000, 611, 0, 2, 1, 1, "100");
            ///foreach UFTabbedPane下的所有控件，增加到此容器
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage25(_UFTabControl));
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage32(_UFTabControl));
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage33(_UFTabControl));
            this.TabControl6 = _UFTabControl;
        }

	        private IUFTabPage _BuilderControl_TabPage25(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage25",true, true, "1","3b4f3759-9fe7-45de-9467-c38efbeea061","3b4f3759-9fe7-45de-9467-c38efbeea061");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 15, 16, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFTabPage,  this.Model.AdvApplyBE, "AdvApplyBE", "", null, 1, "广告申请单");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





				this.Line0 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line0", 950, "Horizontal", "True", 950, 20, 0, 0, 15, 1, "100","2d2d328f-953a-45d6-ad70-d974c6a9222d","2d2d328f-953a-45d6-ad70-d974c6a9222d");
	

		
			UIControlBuilder.BuilderUFControl(this.Line0, "2");		


				this.lblApplier106 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblApplier106", "", "True", "True", "Right", 100, 20, 0, 2, 1, 1, "100","88898774-77ed-4647-ae73-04a6260fccc1","4d7d4875-959c-48f2-9ba4-aa54bb646825");


								

		
			UIControlBuilder.BuilderUFControl(this.lblApplier106, "5");		


				this.Applier106 = UIControlBuilder.BuilderTextBox(_UFTabPage, "Applier106", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 2, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblApplier106","","50","88898774-77ed-4647-ae73-04a6260fccc1","92265e05-7bee-44ed-8566-da99bb87977e");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Applier106, "False", "Applier", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldApplier, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.Applier106, "6");		
		 

				this.lblPhone218 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblPhone218", "", "True", "True", "Right", 100, 20, 4, 1, 1, 1, "100","0c16ae75-6ab0-448d-b39f-62a72b9a6d2f","01e4de13-bec8-4607-a41c-7e7504c5ed9f");


								

		
			UIControlBuilder.BuilderUFControl(this.lblPhone218, "7");		


				this.Phone218 = UIControlBuilder.BuilderTextBox(_UFTabPage, "Phone218", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 6, 1, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblPhone218","","50","0c16ae75-6ab0-448d-b39f-62a72b9a6d2f","5a1a6dc7-147a-43e0-9f0d-a4eb0c92da0b");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Phone218, "False", "Phone", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldPhone, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.Phone218, "8");		
		 

				this.lblQQ157 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblQQ157", "", "True", "True", "Right", 100, 20, 4, 2, 1, 1, "100","47f73963-a3c5-4539-a893-ee1668984fe5","55b1568d-b192-4d67-9874-0386e5402979");


								

		
			UIControlBuilder.BuilderUFControl(this.lblQQ157, "9");		


				this.QQ157 = UIControlBuilder.BuilderTextBox(_UFTabPage, "QQ157", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 6, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblQQ157","","50","47f73963-a3c5-4539-a893-ee1668984fe5","9f4e5091-194c-491e-b73f-61073f1ce036");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.QQ157, "False", "QQ", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldQQ, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.QQ157, "10");		
		 

				this.lblApplyDate268 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblApplyDate268", "", "True", "True", "Right", 100, 20, 8, 1, 1, 1, "100","96090f17-fc32-4518-8b32-016e9765756e","b24110ac-a2bc-413b-b04d-526928c2022f");


								

		
			UIControlBuilder.BuilderUFControl(this.lblApplyDate268, "11");		


				this.ApplyDate268 = UIControlBuilder.BuilderDatePicker(_UFTabPage, "ApplyDate268", true, true, true, "Date","Left", 3, 60, 0, 120, 20, 10, 1, 1, 1, "100",true,true,"lblApplyDate268","96090f17-fc32-4518-8b32-016e9765756e","a9dde658-d7d6-49c0-a7db-2a08b41b3db9");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ApplyDate268, "False", "ApplyDate", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldApplyDate, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.ApplyDate268, "12");		
		 

				this.Line1 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line1", 950, "Horizontal", "True", 950, 20, 0, 3, 15, 1, "100","07c16f9a-9291-4b2b-87a9-d132e1622457","07c16f9a-9291-4b2b-87a9-d132e1622457");
	

		
			UIControlBuilder.BuilderUFControl(this.Line1, "13");		


				this.lblCustConterName115 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblCustConterName115", "", "True", "True", "Right", 100, 20, 0, 4, 1, 1, "100","4938bf60-3a01-47a4-b66f-21f37db88257","170bbc4c-fce4-48b7-87b9-56a62173e24b");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustConterName115, "14");		


				this.CustConterName115 = UIControlBuilder.BuilderTextBox(_UFTabPage, "CustConterName115", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 2, 4, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCustConterName115","","50","4938bf60-3a01-47a4-b66f-21f37db88257","b47fab72-3023-4b53-9ddc-638f12a2307b");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CustConterName115, "False", "CustConterName", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldCustConterName, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.CustConterName115, "15");		
		 

				this.lblRelPeople158 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblRelPeople158", "", "True", "True", "Right", 100, 20, 4, 4, 1, 1, "100","3f02ff6d-6292-4915-a6b3-5ca541a13620","a1330a6f-f0fa-44fe-a46a-16441350f806");


								

		
			UIControlBuilder.BuilderUFControl(this.lblRelPeople158, "16");		


				this.RelPeople158 = UIControlBuilder.BuilderTextBox(_UFTabPage, "RelPeople158", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 6, 4, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblRelPeople158","","50","3f02ff6d-6292-4915-a6b3-5ca541a13620","63eb549b-ff32-47d8-8868-65c0e38b2444");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.RelPeople158, "False", "RelPeople", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldRelPeople, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.RelPeople158, "17");		
		 

				this.lblCustAddress133 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblCustAddress133", "", "True", "True", "Right", 100, 20, 0, 5, 1, 1, "100","ed7d9987-fd4f-4ce3-9c07-f2e9aa9d4587","f8302aad-6d73-4098-aa0f-d22675dda2d8");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustAddress133, "18");		


				this.CustAddress133 = UIControlBuilder.BuilderTextBox(_UFTabPage, "CustAddress133", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 2, 5, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCustAddress133","","50","ed7d9987-fd4f-4ce3-9c07-f2e9aa9d4587","2e734cbb-36ba-486d-a826-ba5ff3f0833e");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CustAddress133, "False", "CustAddress", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldCustAddress, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.CustAddress133, "19");		
		 

				this.lblCustPhone184 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblCustPhone184", "", "True", "True", "Right", 100, 20, 4, 5, 1, 1, "100","01d9cd92-bb77-4862-820d-a86179f2c939","780befdd-6d35-4a94-ac28-2ebc292c36f6");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustPhone184, "20");		


				this.CustPhone184 = UIControlBuilder.BuilderTextBox(_UFTabPage, "CustPhone184", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 6, 5, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCustPhone184","","50","01d9cd92-bb77-4862-820d-a86179f2c939","3e11622f-25ec-4246-8f0f-1ab6a7527c03");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CustPhone184, "False", "CustPhone", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldCustPhone, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.CustPhone184, "21");		
		 

				this.lblLocationQY196 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblLocationQY196", "", "True", "True", "Right", 100, 20, 8, 4, 1, 1, "100","04d4fd5d-66a1-451d-b463-ff637490a75f","67d3d3d4-833c-4772-ac6d-8dc675263b78");


								

		
			UIControlBuilder.BuilderUFControl(this.lblLocationQY196, "22");		


				this.LocationQY196 = UIControlBuilder.BuilderTextBox(_UFTabPage, "LocationQY196", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 10, 4, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblLocationQY196","","50","04d4fd5d-66a1-451d-b463-ff637490a75f","cef2adef-dd86-4869-8e5b-da52ab21297a");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.LocationQY196, "False", "LocationQY", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldLocationQY, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.LocationQY196, "23");		
		 

				this.lblLocationXZ172 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblLocationXZ172", "", "True", "True", "Right", 100, 20, 8, 5, 1, 1, "100","b33a26a8-4d8f-45f9-b27d-7486bf736102","10cdf19a-9269-40ae-ba7b-f7aee0ece3ea");


								

		
			UIControlBuilder.BuilderUFControl(this.lblLocationXZ172, "24");		


				this.LocationXZ172 = UIControlBuilder.BuilderTextBox(_UFTabPage, "LocationXZ172", "True", "True", "True", "False", "Left", 0, 60, 0, 120, 20, 10, 5, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblLocationXZ172","","50","b33a26a8-4d8f-45f9-b27d-7486bf736102","f4c04665-8011-4160-beb0-8793d51606c5");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.LocationXZ172, "False", "LocationXZ", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldLocationXZ, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.LocationXZ172, "25");		
		 

				this.FlexFieldPicker0 = UIControlBuilder.BuilderFlexFieldPicker(_UFTabPage, "FlexFieldPicker0", "True", "True", "True", "Left", 0, "", '.', 60, 0, 100, 20, 8, 2, 1, 1, "100"
				,FlexFieldType.Key,true,false,"","","","ccc188f9-ce70-4c88-aea0-17a1bb029e9b");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.FlexFieldPicker0, "False", "", null, null, "");
			if(this.FlexFieldPicker0.FlexFieldType==FlexFieldType.Key)
			{

			}
			else
			{		
					}
								

		
			UIControlBuilder.BuilderUFControl(this.FlexFieldPicker0, "26");		
		 

				this.lblApplyDept233 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblApplyDept233", "", "True", "True", "Right", 100, 20, 0, 1, 1, 1, "100","4173579c-5182-48af-9c2b-1906636a232e","3367cd35-119c-411a-b1b7-11987eb6b9f6");


								

		
			UIControlBuilder.BuilderUFControl(this.lblApplyDept233, "27");		


				this.ApplyDept233 = UIControlBuilder.BuilderRefrenceControl(_UFTabPage,"ApplyDept233",false,true, true,120, 20, 2, 1, 1, 1, "100","28",false,false,true,"lblApplyDept233","4173579c-5182-48af-9c2b-1906636a232e","76ee49ff-bd7f-4123-9561-df213bf5424d");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ApplyDept233, "False", "ApplyDept", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldApplyDept, "AdvApplyBE");
			UIControlBuilder.SetReferenceControlRefInfo(this.ApplyDept233,"874cc1b6-f844-486c-b3f5-f8cca21fe1e0", 580,408, "Name","Code","ID", this.Model.AdvApplyBE.FieldApplyDept_Code,this.Model.AdvApplyBE.FieldApplyDept_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.ApplyDept233,"ApplyDept233",new ReferenceOutputParam[]{new ReferenceOutputParam("ApplyDept233","ID","Key"),new ReferenceOutputParam("ApplyDept233","Code","Value"),new ReferenceOutputParam("ApplyDept233","Name","Text"),new ReferenceOutputParam("","CustomerCategory_Name",""),new ReferenceOutputParam("","Description",""),new ReferenceOutputParam("","Org_Name",""),new ReferenceOutputParam("","DescFlexField_PrivateDescSeg14",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.ApplyDept233, "28");		
		 


																									
			this.ApplyDept233.IsMultiOrg  = false ;
			this.lblApplyDept233.SetMultiOrgInfo(this.ApplyDept233,false);
			


            this.TabPage25 = _UFTabPage;
            return _UFTabPage;
        }

				

	        private IUFTabPage _BuilderControl_TabPage32(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage32",true, true, "0","c73192be-1408-46bf-9ba8-f74e7a93701c","c73192be-1408-46bf-9ba8-f74e7a93701c");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 15, 30, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFTabPage,  this.Model.AdvApplyBE, "AdvApplyBE", "", null, 1, "广告申请单");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(118,bool.Parse("True")),new GridColumnDef(12,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(19,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





				this.Line3 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line3", 950, "Horizontal", "True", 950, 20, 0, 0, 15, 1, "100","005cdc8b-0b79-4e7c-a684-d4467f18f419","005cdc8b-0b79-4e7c-a684-d4467f18f419");
	

		
			UIControlBuilder.BuilderUFControl(this.Line3, "0");		


				this.lblQty693 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblQty693", "", "True", "True", "Right", 100, 20, 8, 1, 1, 1, "100","578b9158-ca19-4eef-9085-976fb441113e","80707eec-a117-49e6-a387-c50d5728c412");


								

		
			UIControlBuilder.BuilderUFControl(this.lblQty693, "3");		


				this.Qty693 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "Qty693", "True", "True", "True", "Left", 8, 60, 0, 120, 20, 10, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblQty693","24.9","578b9158-ca19-4eef-9085-976fb441113e","dd73a494-a9e6-4c12-8383-bac217618f05",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Qty693, "False", "Qty", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldQty, "AdvApplyBE");
			this.Qty693.ContentChanged += new EventHandler(Qty693_TextChanged);
			this.Qty693.AutoPostBack = true;
	
		
			UIControlBuilder.BuilderUFControl(this.Qty693, "4");		
		 

				this.lblTotalArea333 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblTotalArea333", "", "True", "True", "Right", 100, 20, 12, 1, 1, 1, "100","7c6e9240-1a1b-46c2-93a7-bfd1059217ff","2b340961-8de1-41c4-81ae-c50699bc0fae");


								

		
			UIControlBuilder.BuilderUFControl(this.lblTotalArea333, "5");		


				this.TotalArea333 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "TotalArea333", "True", "True", "True", "Left", 8, 60, 0, 120, 20, 14, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,true,true,"lblTotalArea333","24.9","7c6e9240-1a1b-46c2-93a7-bfd1059217ff","69352b3f-0c95-4f6c-ad6d-87457271f5fb",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.TotalArea333, "False", "TotalArea", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldTotalArea, "AdvApplyBE");
	
		
			UIControlBuilder.BuilderUFControl(this.TotalArea333, "6");		
		 

				this.Line4 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line4", 470, "Horizontal", "True", 470, 20, 0, 2, 7, 1, "100","f6347aaf-e15c-4451-8090-b13322eec721","f6347aaf-e15c-4451-8090-b13322eec721");
	

		
			UIControlBuilder.BuilderUFControl(this.Line4, "7");		


				this.Line5 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line5", 470, "Horizontal", "True", 470, 20, 8, 2, 7, 1, "100","aa16b041-18f0-4698-afa6-683fadb3fbf4","aa16b041-18f0-4698-afa6-683fadb3fbf4");
	

		
			UIControlBuilder.BuilderUFControl(this.Line5, "8");		


				this.lblBMWidth146 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblBMWidth146", "", "True", "True", "Right", 100, 20, 0, 3, 1, 1, "100","5fdfce09-6cc4-4694-ac3d-208013aec390","e67cebca-fc33-466e-be18-c411e2240fc5");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBMWidth146, "9");		


				this.BMWidth146 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "BMWidth146", "True", "True", "True", "Left", 8, 60, 0, 118, 20, 2, 3, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblBMWidth146","24.9","5fdfce09-6cc4-4694-ac3d-208013aec390","a586ba7a-7e1c-477d-ab79-476d4dcb4437",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BMWidth146, "False", "BMWidth", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldBMWidth, "AdvApplyBE");
			this.BMWidth146.ContentChanged += new EventHandler(BMWidth146_TextChanged);
			this.BMWidth146.AutoPostBack = true;
	
		
			UIControlBuilder.BuilderUFControl(this.BMWidth146, "10");		
		 

				this.lblBMHight124 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblBMHight124", "", "True", "True", "Right", 100, 20, 0, 4, 1, 1, "100","ae7c9dde-fa4b-4f1d-a47b-f234a67413e0","4565e25d-786c-4edc-b356-011f7bd0708b");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBMHight124, "11");		


				this.BMHight124 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "BMHight124", "True", "True", "True", "Left", 8, 60, 0, 118, 20, 2, 4, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblBMHight124","24.9","ae7c9dde-fa4b-4f1d-a47b-f234a67413e0","b9f96968-bdce-4b3b-9b85-01f4bfa6ffea",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BMHight124, "False", "BMHight", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldBMHight, "AdvApplyBE");
			this.BMHight124.ContentChanged += new EventHandler(BMHight124_TextChanged);
			this.BMHight124.AutoPostBack = true;
	
		
			UIControlBuilder.BuilderUFControl(this.BMHight124, "12");		
		 

				this.lblBMThick115 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblBMThick115", "", "True", "True", "Right", 100, 20, 4, 3, 1, 1, "100","5b842a90-21bc-45c7-b35d-7f451724faf0","e44c3fc2-b790-43c3-9505-56430a305519");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBMThick115, "13");		


				this.BMThick115 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "BMThick115", "True", "True", "True", "Left", 8, 60, 0, 120, 20, 6, 3, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblBMThick115","24.9","5b842a90-21bc-45c7-b35d-7f451724faf0","7af01b4c-d010-4b85-8a3a-bd3a35204733",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BMThick115, "False", "BMThick", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldBMThick, "AdvApplyBE");
	
		
			UIControlBuilder.BuilderUFControl(this.BMThick115, "14");		
		 

				this.lblBMArea187 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblBMArea187", "", "True", "True", "Right", 100, 20, 4, 4, 1, 1, "100","342a27d0-ab2e-4417-bd8f-6b099b6dffe5","dff1ba12-5514-446f-a5a6-9d8561315d97");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBMArea187, "15");		


				this.BMArea187 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "BMArea187", "True", "True", "True", "Left", 8, 60, 0, 120, 20, 6, 4, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,true,true,"lblBMArea187","24.9","342a27d0-ab2e-4417-bd8f-6b099b6dffe5","a793b009-bbdd-461f-9642-48c0dbe1dc83",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BMArea187, "False", "BMArea", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldBMArea, "AdvApplyBE");
			this.BMArea187.ContentChanged += new EventHandler(BMArea187_TextChanged);
			this.BMArea187.AutoPostBack = true;
	
		
			UIControlBuilder.BuilderUFControl(this.BMArea187, "16");		
		 

				this.lblDZWidth187 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblDZWidth187", "", "True", "True", "Right", 100, 20, 8, 3, 1, 1, "100","6dd7fd92-325c-4888-9831-078e1a6b5847","7e08637c-fe2f-4436-8926-7556ee54a8b2");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDZWidth187, "17");		


				this.DZWidth187 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "DZWidth187", "True", "True", "True", "Left", 8, 60, 0, 120, 20, 10, 3, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblDZWidth187","24.9","6dd7fd92-325c-4888-9831-078e1a6b5847","7fcf58b5-942f-48ae-a3e0-ecdb165bac96",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DZWidth187, "False", "DZWidth", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldDZWidth, "AdvApplyBE");
			this.DZWidth187.ContentChanged += new EventHandler(DZWidth187_TextChanged);
			this.DZWidth187.AutoPostBack = true;
	
		
			UIControlBuilder.BuilderUFControl(this.DZWidth187, "18");		
		 

				this.lblDZThick224 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblDZThick224", "", "True", "True", "Right", 100, 20, 8, 4, 1, 1, "100","546bb334-2cc7-4c33-a847-eece4b6dd000","7ad105a5-e355-4222-8c25-7cddfc9e1c84");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDZThick224, "19");		


				this.DZThick224 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "DZThick224", "True", "True", "True", "Left", 8, 60, 0, 120, 20, 10, 4, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblDZThick224","24.9","546bb334-2cc7-4c33-a847-eece4b6dd000","1c44f940-42ea-4107-bb23-7941a804741d",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DZThick224, "False", "DZThick", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldDZThick, "AdvApplyBE");
			this.DZThick224.ContentChanged += new EventHandler(DZThick224_TextChanged);
			this.DZThick224.AutoPostBack = true;
	
		
			UIControlBuilder.BuilderUFControl(this.DZThick224, "20");		
		 

				this.lblDZArea338 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblDZArea338", "", "True", "True", "Right", 100, 20, 12, 3, 1, 1, "100","43d1faad-c6ad-4c2f-8eeb-d52b9391c241","be1d20cc-6872-42e3-be05-aa80ceb4bd08");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDZArea338, "21");		


				this.DZArea338 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "DZArea338", "True", "True", "True", "Left", 8, 60, 0, 120, 20, 14, 3, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,true,true,"lblDZArea338","24.9","43d1faad-c6ad-4c2f-8eeb-d52b9391c241","56055a54-b456-43b9-9f92-7aa3ca192a1f",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DZArea338, "False", "DZArea", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldDZArea, "AdvApplyBE");
	
		
			UIControlBuilder.BuilderUFControl(this.DZArea338, "22");		
		 

				this.Line7 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line7", 950, "Horizontal", "True", 950, 20, 0, 18, 15, 1, "100","e91ee868-d4e6-4df8-96a1-0bec6f755371","e91ee868-d4e6-4df8-96a1-0bec6f755371");
	

		
			UIControlBuilder.BuilderUFControl(this.Line7, "33");		


				this.Line12 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line12", 950, "Horizontal", "True", 950, 20, 0, 5, 15, 1, "100","6cd0b020-c5ce-46cc-8359-942d05f2e65e","6cd0b020-c5ce-46cc-8359-942d05f2e65e");
	

		
			UIControlBuilder.BuilderUFControl(this.Line12, "23");		


				this.lblAdvDisplayType588 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblAdvDisplayType588", "", "True", "True", "Right", 100, 20, 0, 6, 1, 1, "100","97af5541-bb31-42ec-a2f4-280c2d363eea","558b31da-225f-42fb-9b44-f13a9eef6a81");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvDisplayType588, "35");		


		        this.AdvDisplayType588 = UIControlBuilder.BuilderDropDownList(_UFTabPage, "AdvDisplayType588", "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvDisplayTypeEnum", true,  true, true, "Left", 2, 60, 0, 118, 20, 2, 6, 1, 1, "100",true,false,"lblAdvDisplayType588","97af5541-bb31-42ec-a2f4-280c2d363eea","8978aef7-ef80-44ee-8137-f693bf3ab625");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvDisplayType588, "False", "AdvDisplayType", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldAdvDisplayType, "AdvApplyBE");
			EnumTypeList.Add("UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvDisplayTypeEnum");
			EnumControlsMap.Add(this.AdvDisplayType588, _UFTabPage);
		

		
			UIControlBuilder.BuilderUFControl(this.AdvDisplayType588, "36");		
		 

	
			_BuilderControl_Image12(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.Image12, "41");		


	
			_BuilderControl_Image13(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.Image13, "42");		


	
			_BuilderControl_Image14(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.Image14, "43");		


				this.lblAdvDispInfo111851 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblAdvDispInfo111851", "", "True", "True", "Right", 100, 20, 4, 6, 1, 1, "100","ea8b6132-04a8-480f-8ff4-17cc69d47b4c","2c670da9-0242-4d8c-9000-943d86e16645");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvDispInfo111851, "44");		


		        this.AdvDispInfo111851 = UIControlBuilder.BuilderDropDownList(_UFTabPage, "AdvDispInfo111851", "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvPageReq1Enum", true,  true, true, "Left", 2, 60, 0, 230, 20, 6, 6, 3, 1, "100",true,false,"lblAdvDispInfo111851","ea8b6132-04a8-480f-8ff4-17cc69d47b4c","5ba4c9a7-f82e-425d-8bd7-0ad570fdeb76");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvDispInfo111851, "False", "AdvDispInfo1", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldAdvDispInfo1, "AdvApplyBE");
			EnumTypeList.Add("UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvPageReq1Enum");
			EnumControlsMap.Add(this.AdvDispInfo111851, _UFTabPage);
		

		
			UIControlBuilder.BuilderUFControl(this.AdvDispInfo111851, "45");		
		 

				this.lblAdvDispInfo222913 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblAdvDispInfo222913", "", "True", "True", "Right", 120, 20, 10, 6, 1, 1, "100","1a326bea-0f00-49bc-b8dc-5f97a9a7de2d","8f834465-1600-4513-9461-4d3297309bf8");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvDispInfo222913, "46");		


		        this.AdvDispInfo222913 = UIControlBuilder.BuilderDropDownList(_UFTabPage, "AdvDispInfo222913", "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvPageReq2Enum", true,  true, true, "Left", 2, 60, 0, 230, 20, 12, 6, 3, 1, "100",true,false,"lblAdvDispInfo222913","1a326bea-0f00-49bc-b8dc-5f97a9a7de2d","4974fbc7-a659-4b64-83a3-5e6389b711a3");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvDispInfo222913, "False", "AdvDispInfo2", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldAdvDispInfo2, "AdvApplyBE");
			EnumTypeList.Add("UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvPageReq2Enum");
			EnumControlsMap.Add(this.AdvDispInfo222913, _UFTabPage);
		

		
			UIControlBuilder.BuilderUFControl(this.AdvDispInfo222913, "47");		
		 

				this.lblAdvCarrier146 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblAdvCarrier146", "", "True", "True", "Right", 100, 20, 0, 1, 1, 1, "100","96260a2b-42a8-4ec6-baf8-a0dfd338337a","24b4a733-4bd6-40cc-b31f-488ea37f08af");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvCarrier146, "48");		


				this.AdvCarrier146 = UIControlBuilder.BuilderRefrenceControl(_UFTabPage,"AdvCarrier146",true,true, true,230, 20, 2, 1, 3, 1, "100","49",false,false,true,"lblAdvCarrier146","96260a2b-42a8-4ec6-baf8-a0dfd338337a","938746bd-11dc-4c75-b7c9-9fda862371f9");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvCarrier146, "False", "AdvCarrier", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldAdvCarrier, "AdvApplyBE");
			UIControlBuilder.SetReferenceControlRefInfo(this.AdvCarrier146,"40f9b5a0-1f46-4c51-8036-11e1fcd8ab08", 580,408, "Name","Code","ID", this.Model.AdvApplyBE.FieldAdvCarrier_Code,this.Model.AdvApplyBE.FieldAdvCarrier_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.AdvCarrier146,"AdvCarrier146",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","Description",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.AdvCarrier146, "49");		
		 

	
			_BuilderControl_DataGrid0(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid0, "50");		



																																		
			this.AdvCarrier146.IsMultiOrg  = false ;
			this.lblAdvCarrier146.SetMultiOrgInfo(this.AdvCarrier146,false);
			
	

            this.TabPage32 = _UFTabPage;
            return _UFTabPage;
        }

	        private void _BuilderControl_Image12(IUFContainer container)
        {
            IUFImage _Image = UIControlBuilder.BuildImageControl(container,"Image12",true, true, "41");
			_Image.ImageUrl = @"~\/Images/CustU9/1.bmp";
			CommonBuilder.GridLayoutPropBuilder(container, _Image, 340, 120, 0, 7, 5, 5, "100");
            this.Image12 = _Image;
        }

	        private void _BuilderControl_Image13(IUFContainer container)
        {
            IUFImage _Image = UIControlBuilder.BuildImageControl(container,"Image13",true, true, "42");
			_Image.ImageUrl = @"~\/Images/CustU9/2.bmp";
			CommonBuilder.GridLayoutPropBuilder(container, _Image, 120, 270, 6, 7, 1, 11, "100");
            this.Image13 = _Image;
        }

	        private void _BuilderControl_Image14(IUFContainer container)
        {
            IUFImage _Image = UIControlBuilder.BuildImageControl(container,"Image14",true, true, "43");
			_Image.ImageUrl = @"~\/Images/CustU9/3.bmp";
			CommonBuilder.GridLayoutPropBuilder(container, _Image, 240, 245, 8, 7, 4, 10, "100");
            this.Image14 = _Image;
        }

				

				





       
        private void _BuilderControl_DataGrid0(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid0", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, false, false,false,false,false,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "50");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 470, 219, 0, 19, 7, 9, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.AdvCarrierList, "AdvCarrierList", "", null, 20, "");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid0 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"IsSelected0","CheckBoxColumnModel", "", 0,this.Model.AdvCarrierList.Fields["IsSelected"]/*IsSelected*/,"IsSelected", false, true, true, false, false, true, 22, 120, "1",true, false,"false","9798c1d3-c13c-400f-941d-0636a1be7266","9798c1d3-c13c-400f-941d-0636a1be7266","73402eab-3423-489c-a318-49719a49187f");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Code0","TextBoxColumnModel", "", 0,this.Model.AdvCarrierList.Fields["Code"]/*Code*/,"Code", false, true, false, false, false, true, 0, 100, "50",true, false,"","d9dbcbae-7f0f-4ae9-838c-9c87116f4a08","d9dbcbae-7f0f-4ae9-838c-9c87116f4a08","4220e31d-af6c-46b4-b4bd-e93305c9e107");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Name0","TextBoxColumnModel", "", 0,this.Model.AdvCarrierList.Fields["Name"]/*Name*/,"Name", false, true, false, false, false, true, 0, 100, "50",true, false,"","708d9a03-9b22-4446-b217-8f94a441a9d8","708d9a03-9b22-4446-b217-8f94a441a9d8","7a02df4f-8d7d-4227-80a5-63923d6452f6");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Description0","TextBoxColumnModel", "", 0,this.Model.AdvCarrierList.Fields["Description"]/*Description*/,"Description", false, true, false, false, false, true, 0, 100, "50",true, false,"","d6c8effe-41f3-413c-b060-c053334ade7f","d6c8effe-41f3-413c-b060-c053334ade7f","45ebdc50-cb71-421e-bb41-ee7f6a008df9");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID72","NumberColumnModel", "", 0,this.Model.AdvCarrierList.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "",true, false,"","55a5e707-4f40-4ca6-a5c0-f42feb0e3f93","55a5e707-4f40-4ca6-a5c0-f42feb0e3f93","d88aa9e2-475c-4e0d-b52a-9ad7c3f5b8f2");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 
        }

	        private IUFTabPage _BuilderControl_TabPage33(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage33",true, true, "0","036fb0c2-cef8-43eb-88da-2f78d09f64fb","036fb0c2-cef8-43eb-88da-2f78d09f64fb");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 15, 18, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFTabPage,  this.Model.AdvApplyBE, "AdvApplyBE", "", null, 1, "广告申请单");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(105,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





				this.Line8 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line8", 865, "Horizontal", "True", 865, 20, 0, 0, 15, 1, "100","5d9b18cb-2f2a-4ae9-86f6-5bae94edafed","5d9b18cb-2f2a-4ae9-86f6-5bae94edafed");
	

		
			UIControlBuilder.BuilderUFControl(this.Line8, "0");		


				this.AdvMemo802 = UIControlBuilder.BuilderTextBox(_UFTabPage, "AdvMemo802", "True", "True", "True", "True", "Left", 0, 60, 0, 635, 395, 1, 1, 11, 16, "False", "100"
			,"",TextBoxMode.MultiLine,TextAlign.Left, true,false,"","","2000","175057c2-2a35-48d7-9e30-403d5b451375","bf6588ef-57a6-4b56-ad5d-09771f78f621");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvMemo802, "False", "AdvMemo", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldAdvMemo, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.AdvMemo802, "2");		
		 


		

            this.TabPage33 = _UFTabPage;
            return _UFTabPage;
        }

	                   
        private IUFCard _BuilderControl_Card7(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card7",false,"none", true, true, "0","a3a90268-cecf-429a-ba35-1cb4c309cb2d","8a34bf70-88a8-45c7-9a48-931ca74dca61");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 1000, 36, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 11, 1, 0, 5, 5, 5, 5, 5);
			InitViewBindingContainer(this, _UFCard,  this.Model.AdvApplyBE, "AdvApplyBE", "", null, 1, "广告申请单");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(160,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.Card7 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblAdvApplyDocType216 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblAdvApplyDocType216", "", "True", "True", "Right", 100, 20, 4, 0, 1, 1, "100","a3a90268-cecf-429a-ba35-1cb4c309cb2d","a593540c-c3b9-45da-8a0e-37402c1ac30e");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvApplyDocType216, "2");		


				this.AdvApplyDocType216 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"AdvApplyDocType216",true,true, true,120, 20, 6, 0, 1, 1, "100","3",false,false,true,"lblAdvApplyDocType216","a3a90268-cecf-429a-ba35-1cb4c309cb2d","f83243d4-3e34-4ac1-b584-8acde1e5caea");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvApplyDocType216, "False", "AdvApplyDocType", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldAdvApplyDocType, "AdvApplyBE");
			UIControlBuilder.SetReferenceControlRefInfo(this.AdvApplyDocType216,"11ab3eef-9012-47dd-8cc2-f377e148a2c1", 580,408, "Name","Code","ID", this.Model.AdvApplyBE.FieldAdvApplyDocType_Code,this.Model.AdvApplyBE.FieldAdvApplyDocType_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.AdvApplyDocType216,"AdvApplyDocType216",new ReferenceOutputParam[]{new ReferenceOutputParam("AdvApplyDocType216","ID","Key"),new ReferenceOutputParam("","AdvDocEnum",""),new ReferenceOutputParam("AdvApplyDocType216","Code","Value"),new ReferenceOutputParam("AdvApplyDocType216","Name","Text"),new ReferenceOutputParam("","Org_Code",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.AdvApplyDocType216, "3");		
		 

				this.lblDocStatus162 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDocStatus162", "", "True", "True", "Right", 100, 20, 8, 0, 1, 1, "100","27264278-a7f6-4c14-9baa-5f9a4012a0dd","581051b7-097c-4e4c-a928-d94e1a7e9779");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDocStatus162, "4");		


		        this.DocStatus162 = UIControlBuilder.BuilderDropDownList(_UFCard, "DocStatus162", "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyStatusEnum", true,  true, true, "Left", 2, 60, 0, 120, 20, 10, 0, 1, 1, "100",true,true,"lblDocStatus162","27264278-a7f6-4c14-9baa-5f9a4012a0dd","bb776121-f32c-40d7-b9d3-2e08030e639d");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DocStatus162, "False", "DocStatus", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldDocStatus, "AdvApplyBE");
			EnumTypeList.Add("UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyStatusEnum");
			EnumControlsMap.Add(this.DocStatus162, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.DocStatus162, "5");		
		 

				this.lblID67 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID67", "", "False", "True", "Right", 100, 20, 0, 0, 1, 1, "100","63182282-485a-4366-ab2e-7e38cf2b96a8","7a4c9c8b-fed8-4181-a189-42d0da1936b3");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID67, "6");		


				this.ID67 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID67", "False", "False", "True", "Left", 7, 60, 0, 120, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID67","8.0","63182282-485a-4366-ab2e-7e38cf2b96a8","df2de135-9c44-418c-aab3-72c1a7cc2550",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID67, "False", "ID", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldID, "AdvApplyBE");
	
		
			UIControlBuilder.BuilderUFControl(this.ID67, "7");		
		 

				this.lblSysVersion94 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion94", "", "False", "True", "Right", 100, 20, 0, 0, 1, 1, "100","a8bbead4-85da-452c-953f-d6220e65b177","db84a4b5-238d-4408-819e-6b6fe1f5ea27");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion94, "8");		


				this.SysVersion94 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion94", "True", "False", "True", "Left", 7, 60, 0, 120, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion94","8.0","a8bbead4-85da-452c-953f-d6220e65b177","d3fd578b-8282-44f1-95a9-f264befc9dab",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion94, "False", "SysVersion", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldSysVersion, "AdvApplyBE");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion94, "9");		
		 

				this.lblAdvCode605 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblAdvCode605", "", "True", "True", "Right", 100, 20, 0, 0, 1, 1, "100","a5994f4f-99b6-42c9-9506-1579b4ef175d","9677d0b5-5ba8-4931-9af8-ec2d6ed718e0");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAdvCode605, "10");		


				this.AdvCode605 = UIControlBuilder.BuilderTextBox(_UFCard, "AdvCode605", "True", "True", "True", "False", "Left", 0, 60, 0, 160, 20, 2, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,true,"lblAdvCode605","","50","a5994f4f-99b6-42c9-9506-1579b4ef175d","c7576af6-9d8a-4564-83f5-231c49082691");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AdvCode605, "False", "AdvCode", this.Model.AdvApplyBE, this.Model.AdvApplyBE.FieldAdvCode, "AdvApplyBE");


		
			UIControlBuilder.BuilderUFControl(this.AdvCode605, "11");		
		 


		
			this.AdvApplyDocType216.IsMultiOrg  = false ;
			this.lblAdvApplyDocType216.SetMultiOrgInfo(this.AdvApplyDocType216,false);
			
								

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				

				        
        private void _BuilderControl_Toolbar5(IUFContainer container)
        {
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar5",true, true, "1",1000, 28, 0, 0, 1, 1,"100");
            this.Toolbar5 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 28,"1", "S",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","2ecf3169-b8b7-470b-bfde-5480a79415b6");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	                            this.BtnCancel = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCancel", "True", "True", 35, 28,"2", "Z",true,false,"f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","4d9245bb-39f0-4661-9572-79dc4690fd7f");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCancel);
            this.BtnCancel.UIModel = this.Model.ElementID;
            this.BtnCancel.Action = "CancelClick";
	                            this.BtnNew = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnNew", "True", "True", 35, 28,"3", "N",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","d1daf3b6-8fd7-4176-958f-fb1ca78b5b01");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnNew);
            this.BtnNew.UIModel = this.Model.ElementID;
            this.BtnNew.Action = "NewClick";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"4", "R",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","9fd61183-361f-44c8-8d5a-b6b8ace89c9c");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "DeleteClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnCopy = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCopy", "True", "True", 35, 28,"6", "C",true,false,"be9f8d20-e484-464b-9818-a2c1b599b967","be9f8d20-e484-464b-9818-a2c1b599b967","f529687b-3db2-4032-87d0-b9159f07cdb7");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCopy);
            this.BtnCopy.UIModel = this.Model.ElementID;
            this.BtnCopy.Action = "CopyClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnSubmit = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSubmit", "True", "True", 35, 28,"8", "T",true,false,"c42c0f21-2fd7-49b2-ac54-62f811747b18","c42c0f21-2fd7-49b2-ac54-62f811747b18","8c54df9b-3cbe-4f2a-8a91-6ee505c4422e");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSubmit);
            this.BtnSubmit.UIModel = this.Model.ElementID;
            this.BtnSubmit.Action = "SubmitClick";
	                            this.BtnApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnApprove", "True", "True", 35, 28,"9", "Y",true,false,"eb678a04-c7e1-44f1-b175-8f90f9903862","eb678a04-c7e1-44f1-b175-8f90f9903862","f72d6282-921d-4b69-a832-454d92bc3474");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnApprove);
            this.BtnApprove.UIModel = this.Model.ElementID;
            this.BtnApprove.Action = "ApproveClick";
	                            this.BtnUndoApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnUndoApprove", "True", "True", 35, 28,"10", "",true,false,"ae796775-bce3-4aed-89a9-20eaa4648a67","ae796775-bce3-4aed-89a9-20eaa4648a67","f1cf1b21-82ca-40ac-808f-8325b9c80c49");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnUndoApprove);
            this.BtnUndoApprove.UIModel = this.Model.ElementID;
            this.BtnUndoApprove.Action = "UndoApproveClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFind = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFind", "True", "True", 35, 28,"12", "F",true,false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","6c5dd351-dd23-4833-8885-e09c634df51a");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFind);
            this.BtnFind.UIModel = this.Model.ElementID;
            this.BtnFind.Action = "FindClick";
	                            this.BtnList = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnList", "True", "True", 35, 28,"13", "L",true,false,"c639596b-5a8c-4fc1-88bb-a3d670cda992","c639596b-5a8c-4fc1-88bb-a3d670cda992","c4c35dc4-1327-4a93-b9d9-d54b6834f3f7");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnList);
            this.BtnList.UIModel = this.Model.ElementID;
            this.BtnList.Action = "ListClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFlow = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFlow", "True", "True", 35, 28,"21", "F",true,false,"e222698c-ae3c-470a-8053-1b69905c510a","e222698c-ae3c-470a-8053-1b69905c510a","053679c5-f3bd-46cb-b408-6957fc498bfe");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFlow);
            this.BtnFlow.UIModel = this.Model.ElementID;
            this.BtnFlow.Action = "FlowClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 28,"24", "P",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","196ebaa9-4b49-4569-b010-29d24a89bc8f");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "PrintClick";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card8(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card8",false,"FunctionBar", true, true, "3","","615fb65d-1a69-4a22-bc25-7c3b8ec96b02");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 1000, 32, 0, 3, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 22, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(71,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card8 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_DropDownButton0(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DropDownButton0, "1");		



	

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				       
        private void _BuilderControl_DropDownButton0(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DropDownButton0",true, true,"1"
            , 80, 20, 0, 0, 1, 1, "100","c4e31736-3819-479a-9f0a-2a306ba44bec","22fef3a6-0357-4095-ae57-70a35de485b5");
            this.DropDownButton0 = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
	                 this.CloseClick = UIControlBuilder.BuildDropDownButtonMenu(container,_dropDownButton,0,"CloseClick","", true, true,true,false,"","c6c6e9e1-4e44-44d9-a273-1c5858656ee7","","c6c6e9e1-4e44-44d9-a273-1c5858656ee7") ;
		 			
        }





		#endregion
		

	}
}
