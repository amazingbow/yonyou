


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
 * Form ID:e7a93a43-c47a-4fd6-9cd4-60d202fb5a29 
 * Form Name:SpecificItemInfoUIFrom
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.XMQX.SpecificItemInfoUI.SpecificItemInfoUIModel
{
	[FormRegister("UFIDA.U9.Cust.XMQX.SpecificItemInfoUI","UFIDA.U9.Cust.XMQX.SpecificItemInfoUI.SpecificItemInfoUIModel.SpecificItemInfoUIFromWebPart", "UFIDA.U9.Cust.XMQX.SpecificItemInfoUI.WebPart", "e7a93a43-c47a-4fd6-9cd4-60d202fb5a29","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.XMQX.SpecificItemInfoUI', 'UFIDA.U9.Cust.XMQX.SpecificItemInfoUI.SpecificItemInfoUIModel.SpecificItemInfoUIFromWebPart', 'UFIDA.U9.Cust.XMQX.SpecificItemInfoUI.WebPart', 'e7a93a43-c47a-4fd6-9cd4-60d202fb5a29')
	///<siteMapNode url="~/erp/simple.aspx?lnk=e7a93a43-c47a-4fd6-9cd4-60d202fb5a29" title="SpecificItemInfoUIFrom"/>
    public partial class SpecificItemInfoUIFromWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(SpecificItemInfoUIFromWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new SpecificItemInfoUIModelAction Action
		{
			get { return (SpecificItemInfoUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		SpecificItemInfoUIModelModel _uimodel=null;
		public new SpecificItemInfoUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new SpecificItemInfoUIModelModel();
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
                this.Model = value as SpecificItemInfoUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFCard Card4;
        IUFCard Card2;
        IUFLabel lblID44;
        IUFFldNumberControl ID44;
        IUFLabel lblSysVersion56;
        IUFFldNumberControl SysVersion56;
        IUFLabel lblWh83;
        IUFFldReference Wh83;
        IUFButton BtnFind;
        IUFButton BtnReqPRExe;
        IUFLabel lblItemMaster92;
        IUFFldReference ItemMaster92;
        IUFLabel lblLikeName182;
        IUFFldTextBox LikeName182;
        IUFLabel lblOperators215;
        IUFFldReference Operators215;
        IUFDataGrid DataGrid5;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public SpecificItemInfoUIFromWebPart()
        {
            FormID = "e7a93a43-c47a-4fd6-9cd4-60d202fb5a29";
            IsAutoSize = bool.Parse("True");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.BtnFind.Click += new EventHandler(BtnFind_Click);		
						
				//Button控件事件
			this.BtnReqPRExe.Click += new EventHandler(BtnReqPRExe_Click);		
						

		
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid5).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid5_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid5).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid5_GridCustomFilterHandler);

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
					this.Model = new SpecificItemInfoUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (SpecificItemInfoUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new SpecificItemInfoUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"SpecificItemInfoUIFrom",true,992,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 2, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(1,bool.Parse("True")),new GridRowDef(488,bool.Parse("False")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Card4(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card4, "2");		



	
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







	                   
        private IUFCard _BuilderControl_Card4(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card4",false,"none", true, true, "2","","232dae4c-104d-4a43-b65e-99c93e1272fb");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 488, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 2, 3, 0, 10, 10, 5, 10, 5);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 10,new GridColumnDef[]{new GridColumnDef(971,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(62,bool.Parse("True")),new GridRowDef(390,bool.Parse("True")),new GridRowDef(1,bool.Parse("False")),});
            this.Card4 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_Card2(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.Card2, "1");		


	
			_BuilderControl_DataGrid5(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid5, "2");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card2(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card2",true,"none", true, true, "1","f5143c21-9514-4aaa-9517-9ef5ce07059e","8b7e6ca8-6280-4041-acad-67e908116d1e");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 972, 62, 0, 0, 2, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 12, 2, 0, 10, 0, 5, 0, 5);
			InitViewBindingContainer(this, _UFCard,  this.Model.FindSpecificItemInfoMainView, "FindSpecificItemInfoMainView", "", null, 1, "FindSpecificItemInfoMainView");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 10,new GridColumnDef[]{new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),});
            this.Card2 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblID44 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID44", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","f5143c21-9514-4aaa-9517-9ef5ce07059e","991cf0f3-a345-43ef-8652-ebfb346ba2ca");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID44, "0");		


				this.ID44 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID44", "False", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID44","","f5143c21-9514-4aaa-9517-9ef5ce07059e","eecf91d3-f2de-4eb8-a5b0-0adb4f7e0904",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID44, "False", "ID", this.Model.FindSpecificItemInfoMainView, this.Model.FindSpecificItemInfoMainView.FieldID, "FindSpecificItemInfoMainView");
	
		
			UIControlBuilder.BuilderUFControl(this.ID44, "1");		
		 

				this.lblSysVersion56 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion56", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","b7c9a403-59fb-433e-8e36-3d6c7b0d7e4c","4c578ec8-e26a-45c1-be55-9100aea3f848");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion56, "2");		


				this.SysVersion56 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion56", "False", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion56","","b7c9a403-59fb-433e-8e36-3d6c7b0d7e4c","a4186996-5aef-4093-a105-15064d5b89af",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion56, "False", "SysVersion", this.Model.FindSpecificItemInfoMainView, this.Model.FindSpecificItemInfoMainView.FieldSysVersion, "FindSpecificItemInfoMainView");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion56, "3");		
		 

				this.lblWh83 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblWh83", "", "True", "True", "Right", 153, 20, 0, 0, 1, 1, "100","10dc971e-6432-43e3-8e63-2625173897fd","3022137e-4405-40d2-a19e-79be03c99d06");


								

		
			UIControlBuilder.BuilderUFControl(this.lblWh83, "4");		


				this.Wh83 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Wh83",true,true, true,153, 20, 2, 0, 1, 1, "100","5",false,false,true,"lblWh83","10dc971e-6432-43e3-8e63-2625173897fd","fb589491-3387-40ce-936f-2b3622bb37d6");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Wh83, "False", "Wh", this.Model.FindSpecificItemInfoMainView, this.Model.FindSpecificItemInfoMainView.FieldWh, "FindSpecificItemInfoMainView");
			UIControlBuilder.SetReferenceControlRefInfo(this.Wh83,"1dc5d0ff-a06e-4dd8-a056-f1b266104b57", 580,408, "Name","Code","ID", this.Model.FindSpecificItemInfoMainView.FieldWh_Code,this.Model.FindSpecificItemInfoMainView.FieldWh_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Wh83,"Wh83",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","MasterOrg_Name",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.Wh83, "5");		
		 

				this.BtnFind = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnFind", true, true, 152, 20, 6, 1, 1, 1, "100","", this.Model.ElementID,"",false,"c3c2daa2-5d7b-4bf0-a46f-069cbd1c4e8c","","c3c2daa2-5d7b-4bf0-a46f-069cbd1c4e8c");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnFind, "6");		


				this.BtnReqPRExe = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnReqPRExe", true, true, 152, 20, 10, 1, 1, 1, "100","", this.Model.ElementID,"",false,"57f7b89f-2e25-4f49-a01b-714da7004abf","","57f7b89f-2e25-4f49-a01b-714da7004abf");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnReqPRExe, "7");		


				this.lblItemMaster92 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblItemMaster92", "", "True", "True", "Right", 152, 20, 4, 0, 1, 1, "100","bac2f976-9b6b-4000-b1ae-1d842df87552","ce674eb5-6343-4e28-890a-6a24f39674ea");


								

		
			UIControlBuilder.BuilderUFControl(this.lblItemMaster92, "10");		


				this.ItemMaster92 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"ItemMaster92",true,true, true,152, 20, 6, 0, 1, 1, "100","11",false,false,true,"lblItemMaster92","bac2f976-9b6b-4000-b1ae-1d842df87552","7f5dc2f1-bc61-4193-b968-bbfb8a06ca30");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ItemMaster92, "False", "ItemMaster", this.Model.FindSpecificItemInfoMainView, this.Model.FindSpecificItemInfoMainView.FieldItemMaster, "FindSpecificItemInfoMainView");
			UIControlBuilder.SetReferenceControlRefInfo(this.ItemMaster92,"6e238bd9-9e6a-499a-8fde-c5f962b1f5bb", 580,408, "Name","Code","ID", this.Model.FindSpecificItemInfoMainView.FieldItemMaster_Code,this.Model.FindSpecificItemInfoMainView.FieldItemMaster_Name);
            //foreach Reference's input filter parameter
			ScriptBuilder.BuildReferenceControlInputScript(this.ItemMaster92,"ItemMaster92",new ReferenceInputParam[]{new ReferenceInputParam("CurDate","DateTime","Value","",2),});
 			//for personal
		 
         		
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.ItemMaster92,"ItemMaster92",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","SPECS",""),new ReferenceOutputParam("","Description",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.ItemMaster92, "11");		
		 

				this.lblLikeName182 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblLikeName182", "", "True", "True", "Right", 153, 20, 0, 1, 1, 1, "100","db74051f-188e-4396-9931-c9b47f43db78","ac8cff13-9185-400c-a8ad-306bf1e72ed6");


								

		
			UIControlBuilder.BuilderUFControl(this.lblLikeName182, "12");		


				this.LikeName182 = UIControlBuilder.BuilderTextBox(_UFCard, "LikeName182", "True", "True", "True", "False", "Left", 0, 60, 0, 153, 20, 2, 1, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblLikeName182","","50","db74051f-188e-4396-9931-c9b47f43db78","ab0c4f55-e58e-40f3-a28d-7b3503fc7e56");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.LikeName182, "False", "LikeName", this.Model.FindSpecificItemInfoMainView, this.Model.FindSpecificItemInfoMainView.FieldLikeName, "FindSpecificItemInfoMainView");


		
			UIControlBuilder.BuilderUFControl(this.LikeName182, "13");		
		 

				this.lblOperators215 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblOperators215", "", "True", "True", "Right", 152, 20, 8, 0, 1, 1, "100","18a20080-2972-47fd-be29-1b678b8e1e61","9c4952b0-7d31-4423-8ed3-6e5a131129ee");


								

		
			UIControlBuilder.BuilderUFControl(this.lblOperators215, "14");		


				this.Operators215 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Operators215",true,true, true,152, 20, 10, 0, 1, 1, "100","15",false,false,true,"lblOperators215","18a20080-2972-47fd-be29-1b678b8e1e61","912c61ab-d450-4999-87dc-99ee344764fe");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Operators215, "False", "Operators", this.Model.FindSpecificItemInfoMainView, this.Model.FindSpecificItemInfoMainView.FieldOperators, "FindSpecificItemInfoMainView");
			UIControlBuilder.SetReferenceControlRefInfo(this.Operators215,"a118cadb-1a8e-42f3-b0ab-4ec16749bcaa", 580,408, "Name","Code","ID", this.Model.FindSpecificItemInfoMainView.FieldOperators_Code,this.Model.FindSpecificItemInfoMainView.FieldOperators_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Operators215,"Operators215",new ReferenceOutputParam[]{new ReferenceOutputParam("Operators215","ID","Key"),new ReferenceOutputParam("Operators215","Code","Value"),new ReferenceOutputParam("Operators215","Name","Text"),});
				

		
			UIControlBuilder.BuilderUFControl(this.Operators215, "15");		
		 


						
			this.Wh83.IsMultiOrg  = false ;
			this.lblWh83.SetMultiOrgInfo(this.Wh83,false);
			
				
			this.ItemMaster92.IsMultiOrg  = true ;
			this.lblItemMaster92.SetMultiOrgInfo(this.ItemMaster92,true);
			
				
			this.Operators215.IsMultiOrg  = false ;
			this.lblOperators215.SetMultiOrgInfo(this.Operators215,false);
			


            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				

				

				

				





       
        private void _BuilderControl_DataGrid5(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid5", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, true, false,false,false,true,true,20,true, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "2");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 972, 401, 0, 1, 2, 2, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.ShowSpecificitemInfoMainView, "ShowSpecificitemInfoMainView", "", null, 20, "");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=true;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid5 = _UFGrid;
            container.Controls.Add(_UFGrid);
			//Grid所有页全选事件 
			((UFWebDataGridAdapter)this.DataGrid5).GridSelectAllPageHandler +=
				new GridSelectAllPageDelegate(UFIDA.U9.UI.PDHelper.PDListHelper.UFGridDataGrid_GridSelectAllPageDelegate);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID73","NumberColumnModel", "", 0,this.Model.ShowSpecificitemInfoMainView.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "",true, false,"","f92ec0a5-4214-4648-8226-f69695a42563","f92ec0a5-4214-4648-8226-f69695a42563","c630ca6b-5a6c-48c4-8d5f-0fc580db62f6");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion57","NumberColumnModel", "", 0,this.Model.ShowSpecificitemInfoMainView.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, false, 7, 100, "",true, false,"","69fa041f-e6c7-4188-9625-c73706e0aa37","69fa041f-e6c7-4188-9625-c73706e0aa37","a2c43ce8-afe9-4aea-bab6-22e7ce3ed8f7");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"IsReqPR0","CheckBoxColumnModel", "", 0,this.Model.ShowSpecificitemInfoMainView.Fields["IsReqPR"]/*IsReqPR*/,"IsReqPR", false, true, true, false, false, false, 22, 70, "1",false, false,"0","2896065f-29f0-45ff-870c-31ea738da144","2896065f-29f0-45ff-870c-31ea738da144","fc850424-512d-474e-a8b0-4b05b7d5b109");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ItemMaster_Code0","TextBoxColumnModel", "", 0,this.Model.ShowSpecificitemInfoMainView.Fields["ItemMaster_Code"]/*ItemMaster_Code*/,"ItemMaster_Code", false, true, false, false, false, false, 0, 100, "50",true, false,"0","f6f70f58-96bc-4786-9c0f-3ea842a41e7d","f6f70f58-96bc-4786-9c0f-3ea842a41e7d","39d50129-e6e9-4c61-81d6-ae96abe925e7");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ItemMaster0","ReferenceColumnModel", "", 0,this.Model.ShowSpecificitemInfoMainView.Fields["ItemMaster"]/*ItemMaster*/,"ItemMaster", false, true, false, false, false, false, 7, 100, "19.0",true, false,"","e7e20c0d-e285-4e2e-a995-b88b48873016","e7e20c0d-e285-4e2e-a995-b88b48873016","9a4c019f-346f-456b-bd85-1f1853b05a44");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.ShowSpecificitemInfoMainView.FieldItemMaster_Code/*ItemMaster_Code*/, this.Model.ShowSpecificitemInfoMainView.FieldItemMaster_Name/*ItemMaster_Name*/, "beedebc3-5398-46b5-a237-5a3a4d13ad4f"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "9a4c019f-346f-456b-bd85-1f1853b05a44";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = true ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SPECS0","TextBoxColumnModel", "", 0,this.Model.ShowSpecificitemInfoMainView.Fields["SPECS"]/*SPECS*/,"SPECS", false, true, true, false, false, true, 0, 100, "50",true, false,"","017894f8-3d5b-48a9-8840-00a3bcddefa4","017894f8-3d5b-48a9-8840-00a3bcddefa4","a9316402-0b7d-47aa-a539-f926203cdb27");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ItemMaster_Name0","TextBoxColumnModel", "", 0,this.Model.ShowSpecificitemInfoMainView.Fields["ItemMaster_Name"]/*ItemMaster_Name*/,"ItemMaster_Name", false, false, false, false, false, false, 0, 100, "50",true, false,"0","38e99e91-fe81-49f2-9a39-5641e0631281","38e99e91-fe81-49f2-9a39-5641e0631281","5779f7cb-b70f-499e-9307-cc0504bf9e3f");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Wh84","ReferenceColumnModel", "", 0,this.Model.ShowSpecificitemInfoMainView.Fields["Wh"]/*Wh*/,"Wh", false, true, false, false, false, false, 7, 100, "19.0",true, false,"","fce38c81-7b01-49df-96b3-229eb5436778","fce38c81-7b01-49df-96b3-229eb5436778","01a2ffe1-5ed6-4780-b95a-0e0414f69d6b");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.ShowSpecificitemInfoMainView.FieldWh_Code/*Wh_Code*/, this.Model.ShowSpecificitemInfoMainView.FieldWh_Name/*Wh_Name*/, "1dc5d0ff-a06e-4dd8-a056-f1b266104b57"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "01a2ffe1-5ed6-4780-b95a-0e0414f69d6b";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Code", "Wh_Code", "Value"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Name", "Wh_Name", "Value"));
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Wh_Code0","TextBoxColumnModel", "", 0,this.Model.ShowSpecificitemInfoMainView.Fields["Wh_Code"]/*Wh_Code*/,"Wh_Code", false, true, true, false, false, true, 0, 100, "50",true, false,"0","bb8cbe7a-d908-497e-b91d-3c551e533881","bb8cbe7a-d908-497e-b91d-3c551e533881","679b4dc9-277e-4ce7-be98-af055246df58");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"WhQty0","NumberColumnModel", "", 2,this.Model.ShowSpecificitemInfoMainView.Fields["WhQty"]/*WhQty*/,"WhQty", false, true, true, false, false, false, 8, 90, "18.0",true, false,"0","2e35f369-d086-4c5b-9d74-bf2f40a98c97","2e35f369-d086-4c5b-9d74-bf2f40a98c97","bf0e881a-acb0-4aad-8d1f-f5d42efb7ba3");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DoingPrQty0","NumberColumnModel", "", 2,this.Model.ShowSpecificitemInfoMainView.Fields["DoingPrQty"]/*DoingPrQty*/,"DoingPrQty", false, true, true, false, false, true, 8, 90, "18.0",true, false,"","4d7cf2b5-090e-4941-b29b-aed47572c756","4d7cf2b5-090e-4941-b29b-aed47572c756","50817a55-6ca0-4f06-8ec4-ec6ba51a23de");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DoingQty0","NumberColumnModel", "", 2,this.Model.ShowSpecificitemInfoMainView.Fields["DoingQty"]/*DoingQty*/,"DoingQty", false, true, true, false, false, false, 8, 90, "18.0",true, false,"0","b1338c95-3c30-476a-94d3-27728cc6e809","b1338c95-3c30-476a-94d3-27728cc6e809","f07d6b8d-e0ab-42d4-ab1b-c083cdda5584");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RecQty0","NumberColumnModel", "", 2,this.Model.ShowSpecificitemInfoMainView.Fields["RecQty"]/*RecQty*/,"RecQty", false, true, true, false, false, true, 8, 90, "18.0",true, false,"","525c0076-8a59-4375-838e-7e01250b94a1","525c0076-8a59-4375-838e-7e01250b94a1","a9bf71e8-de10-4fee-8cad-66aad82b5268");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"PrQty0","NumberColumnModel", "", 2,this.Model.ShowSpecificitemInfoMainView.Fields["PrQty"]/*PrQty*/,"PrQty", false, true, true, false, false, false, 8, 90, "18.0",true, false,"0","0388aa9b-b0e5-4ab1-b65a-5adc72deab0a","0388aa9b-b0e5-4ab1-b65a-5adc72deab0a","1cdaf6d6-5def-4ef3-ac98-442cfa7b5a0c");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ReqData1","DatePickerColumnModel", "", 0,this.Model.ShowSpecificitemInfoMainView.Fields["ReqData"]/*ReqData*/,"ReqData", false, true, true, false, false, true, 3, 80, "8",true, false,"","0a1af256-1be5-40a2-a0f9-eaf8908ca6e1","0a1af256-1be5-40a2-a0f9-eaf8908ca6e1","35c26e62-01d1-4004-bea8-a2dfca2b8bbc");
                   
			((IUFDatePickerColumn)column).DateTimeType = DateTimeType.Date;
            ((IUFDatePickerColumn)column).DateTimeFormat = CurrentState._I18N._DateTimeFormatInfo;
	  
		 
        }





		#endregion
		

	}
}
