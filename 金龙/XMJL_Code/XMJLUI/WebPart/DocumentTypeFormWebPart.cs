


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
 * Form ID:083ac1d9-50d4-4748-ab40-7f86405e3da8 
 * Form Name:DocumentTypeForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace DocumentTypeModel
{
	[FormRegister("UFIDA.U9.Cust.XMJL.UI","DocumentTypeModel.DocumentTypeFormWebPart", "UFIDA.U9.Cust.XMJL.UI.WebPart", "083ac1d9-50d4-4748-ab40-7f86405e3da8","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.XMJL.UI', 'DocumentTypeModel.DocumentTypeFormWebPart', 'UFIDA.U9.Cust.XMJL.UI.WebPart', '083ac1d9-50d4-4748-ab40-7f86405e3da8')
	///<siteMapNode url="~/erp/simple.aspx?lnk=083ac1d9-50d4-4748-ab40-7f86405e3da8" title="DocumentTypeForm"/>
    public partial class DocumentTypeFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(DocumentTypeFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new DocumentTypeModelAction Action
		{
			get { return (DocumentTypeModelAction)base.Action; }
			set { base.Action = value; }
		}
		DocumentTypeModelModel _uimodel=null;
		public new DocumentTypeModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new DocumentTypeModelModel();
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
                this.Model = value as DocumentTypeModelModel;
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
        IUFButton BtnFind;
        IUFSeparator Separator3;
        IUFButton BtnFirstPage;
        IUFButton BtnPrevPage;
        IUFButton BtnNextPage;
        IUFButton BtnLastPage;
        IUFSeparator Separator4;
        IUFCard Card0;
        IUFButton BtnOk;
        IUFButton BtnClose;
        IUFCard Card2;
        IUFLabel lblID31;
        IUFFldNumberControl ID31;
        IUFLabel lblSysVersion31;
        IUFFldNumberControl SysVersion31;
        IUFLabel lblCode52;
        IUFFldTextBox Code52;
        IUFLabel lblName52;
        IUFFldTextBox Name52;
        IUFLabel lblShortName46;
        IUFFldTextBox ShortName46;
        IUFLabel lblDescription28;
        IUFFldTextBox Description28;
        IUFLine Line0;
        IUFLabel lblDocHeaderSequence37;
        IUFFldReference DocHeaderSequence37;
        IUFLine Line1;
        IUFLabel lblEffective_IsEffective61;
        IUFFldCheckBox Effective_IsEffective61;
        IUFLabel lblEffective_EffectiveDate43;
        IUFFldDatePicker Effective_EffectiveDate43;
        IUFLabel lblEffective_DisableDate58;
        IUFFldDatePicker Effective_DisableDate58;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public DocumentTypeFormWebPart()
        {
            FormID = "083ac1d9-50d4-4748-ab40-7f86405e3da8";
            IsAutoSize = bool.Parse("False");
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
			this.BtnFirstPage.Click += new EventHandler(BtnFirstPage_Click);		
						
				//Button控件事件
			this.BtnPrevPage.Click += new EventHandler(BtnPrevPage_Click);		
						
				//Button控件事件
			this.BtnNextPage.Click += new EventHandler(BtnNextPage_Click);		
						
				//Button控件事件
			this.BtnLastPage.Click += new EventHandler(BtnLastPage_Click);		
						
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
					this.Model = new DocumentTypeModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{new InParameterModel("Cust_Xmjl_DocumentType"),},new InParameterModel[]{new InParameterModel("Cust_Xmjl_DocumentType","@ID","ID"),});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (DocumentTypeModelModel)this.CurrentState[this.TaskId.ToString()];
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
				OnPreRenderConsumer(new InParameterModel[]{new InParameterModel("Cust_Xmjl_DocumentType"),},new InParameterModel[]{new InParameterModel("Cust_Xmjl_DocumentType","@ID","ID"),});
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
            this.Action = new DocumentTypeModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"DocumentTypeForm",true,992,504);
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
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 28,"1", "S",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","851546c7-8b0d-4936-ba2d-0c9d9055ecbc");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	                            this.BtnCancel = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCancel", "True", "True", 35, 28,"2", "Z",true,false,"f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","d8fd08ec-d04e-408c-84c3-c7fa559990c4");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCancel);
            this.BtnCancel.UIModel = this.Model.ElementID;
            this.BtnCancel.Action = "CancelClick";
	                            this.BtnAdd = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAdd", "True", "True", 35, 28,"3", "N",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","d679dd93-ebcd-4bce-8392-57bbd95c64b2");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAdd);
            this.BtnAdd.UIModel = this.Model.ElementID;
            this.BtnAdd.Action = "NewClick";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"4", "R",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","818cbbaa-0e4d-490b-8750-0ac49411049f");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "DeleteClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnCopy = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCopy", "True", "True", 35, 28,"6", "C",true,false,"be9f8d20-e484-464b-9818-a2c1b599b967","be9f8d20-e484-464b-9818-a2c1b599b967","e6e7fbc4-c5bf-4ed1-8a5e-b66b2cd5138b");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCopy);
            this.BtnCopy.UIModel = this.Model.ElementID;
            this.BtnCopy.Action = "CopyClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFind = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFind", "True", "True", 35, 28,"12", "F",true,false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","38eb2a1c-82bf-45e9-818d-d5fadc7cc7ca");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFind);
            this.BtnFind.UIModel = this.Model.ElementID;
            this.BtnFind.Action = "FindClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFirstPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFirstPage", "True", "True", 35, 28,"15", "[",true,false,"f229e163-fcd1-4f6a-a645-df86c0efd8ec","f229e163-fcd1-4f6a-a645-df86c0efd8ec","da79d5ad-3e21-4b5a-a7b3-20f836fa0b9e");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFirstPage);
            this.BtnFirstPage.UIModel = this.Model.ElementID;
            this.BtnFirstPage.Action = "FirstPage";
	                            this.BtnPrevPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrevPage", "True", "True", 35, 28,"16", ",",true,false,"5ed368d8-7616-4696-b671-3f1c895f3b43","5ed368d8-7616-4696-b671-3f1c895f3b43","65cb4c86-e487-49a2-99ce-6dd76313228b");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrevPage);
            this.BtnPrevPage.UIModel = this.Model.ElementID;
            this.BtnPrevPage.Action = "PrevPage";
	                            this.BtnNextPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnNextPage", "True", "True", 35, 28,"17", ".",true,false,"36afec41-957c-493a-97a4-eddb136af5b4","36afec41-957c-493a-97a4-eddb136af5b4","fef8db16-9214-484e-b883-3c819923e968");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnNextPage);
            this.BtnNextPage.UIModel = this.Model.ElementID;
            this.BtnNextPage.Action = "NextPage";
	                            this.BtnLastPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnLastPage", "True", "True", 35, 28,"18", "]",true,false,"dc4a37d1-35de-4016-81dd-582aef3cdeb0","dc4a37d1-35de-4016-81dd-582aef3cdeb0","938d6c31-7fcb-4603-9d9a-32444af25c64");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnLastPage);
            this.BtnLastPage.UIModel = this.Model.ElementID;
            this.BtnLastPage.Action = "LastPage";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"FunctionBar", true, true, "3","","79fd51d2-62de-4b61-9647-22c7c7ddbac0");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 22, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(71,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.BtnOk = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnOk", true, true, 80, 20, 18, 0, 1, 1, "100","", this.Model.ElementID,"OnOk",false,"626ebf9b-f65a-4dd5-8f32-96f84919878c","626ebf9b-f65a-4dd5-8f32-96f84919878c","46fef6b0-b103-4420-9d2d-df1d34fc7739");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnOk, "9");		


				this.BtnClose = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnClose", true, true, 80, 20, 20, 0, 1, 1, "100","Z", this.Model.ElementID,"OnClose",false,"020a5365-8f12-4970-b8df-17ce3ae60a68","020a5365-8f12-4970-b8df-17ce3ae60a68","8d1e965c-e06e-4e7b-a146-5bcd4938fde0");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnClose, "10");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card2(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card2",true,"none", true, true, "2","498a90f0-6b40-47c6-9b49-ea8594df53ba","4bedd19a-a128-4781-a645-e6461fbd4374");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 421, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 12, 17, 0, 5, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.Cust_Xmjl_DocumentType, "Cust_Xmjl_DocumentType", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(19,bool.Parse("False")),});
            this.Card2 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblID31 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID31", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","498a90f0-6b40-47c6-9b49-ea8594df53ba","9c7cd0fb-6497-4150-b72d-144f51fc35a3");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID31, "0");		


				this.ID31 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID31", "False", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID31","8.0","498a90f0-6b40-47c6-9b49-ea8594df53ba","3af218c5-e744-4ba7-bdf6-1e32d40b47f4",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID31, "False", "ID", this.Model.Cust_Xmjl_DocumentType, this.Model.Cust_Xmjl_DocumentType.FieldID, "Cust_Xmjl_DocumentType");
	
		
			UIControlBuilder.BuilderUFControl(this.ID31, "1");		
		 

				this.lblSysVersion31 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion31", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","d92f4537-1eef-45f5-ae6c-8ca29779eaa5","f7813f55-2113-44ce-94b5-d0bec54cdffd");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion31, "2");		


				this.SysVersion31 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion31", "True", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion31","8.0","d92f4537-1eef-45f5-ae6c-8ca29779eaa5","1550ffc6-0d28-4f59-b72d-c8423b3b804d",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion31, "False", "SysVersion", this.Model.Cust_Xmjl_DocumentType, this.Model.Cust_Xmjl_DocumentType.FieldSysVersion, "Cust_Xmjl_DocumentType");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion31, "3");		
		 

				this.lblCode52 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCode52", "", "True", "True", "Right", 153, 20, 0, 0, 1, 1, "100","996b1752-b596-4953-b803-7aa1bb9bd756","38822560-5d5d-4265-a4cd-919c7d88dad2");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCode52, "4");		


				this.Code52 = UIControlBuilder.BuilderTextBox(_UFCard, "Code52", "False", "True", "True", "False", "Left", 0, 60, 0, 153, 20, 2, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCode52","","50","996b1752-b596-4953-b803-7aa1bb9bd756","45c56f22-58fa-4b51-bcee-f6b86f27cb3f");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Code52, "False", "Code", this.Model.Cust_Xmjl_DocumentType, this.Model.Cust_Xmjl_DocumentType.FieldCode, "Cust_Xmjl_DocumentType");


		
			UIControlBuilder.BuilderUFControl(this.Code52, "5");		
		 

				this.lblName52 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblName52", "", "True", "True", "Right", 153, 20, 0, 1, 1, 1, "100","88772d7f-bdfe-45a8-80f6-4775a049b28e","afcaba41-2d65-44a6-8702-54406281065d");


								

		
			UIControlBuilder.BuilderUFControl(this.lblName52, "6");		


				this.Name52 = UIControlBuilder.BuilderTextBox(_UFCard, "Name52", "True", "True", "True", "False", "Left", 0, 60, 0, 153, 20, 2, 1, 1, 1, "True", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblName52","","50","88772d7f-bdfe-45a8-80f6-4775a049b28e","3060885f-a8fc-4b9d-9f01-0e44c96eda96");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Name52, "False", "Name", this.Model.Cust_Xmjl_DocumentType, this.Model.Cust_Xmjl_DocumentType.FieldName, "Cust_Xmjl_DocumentType");


		
			UIControlBuilder.BuilderUFControl(this.Name52, "7");		
		 

				this.lblShortName46 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblShortName46", "", "True", "True", "Right", 153, 20, 0, 2, 1, 1, "100","68813a40-0f78-44f2-a69c-00fa2a8d74ed","cc2eb5c6-d9f6-4837-b275-72bc08dbd19d");


								

		
			UIControlBuilder.BuilderUFControl(this.lblShortName46, "8");		


				this.ShortName46 = UIControlBuilder.BuilderTextBox(_UFCard, "ShortName46", "True", "True", "True", "False", "Left", 0, 60, 0, 153, 20, 2, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblShortName46","","50","68813a40-0f78-44f2-a69c-00fa2a8d74ed","268d2d20-1cde-47ef-8c64-856662759745");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ShortName46, "False", "ShortName", this.Model.Cust_Xmjl_DocumentType, this.Model.Cust_Xmjl_DocumentType.FieldShortName, "Cust_Xmjl_DocumentType");


		
			UIControlBuilder.BuilderUFControl(this.ShortName46, "9");		
		 

				this.lblDescription28 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDescription28", "", "True", "True", "Right", 153, 20, 0, 3, 1, 1, "100","f8eb1d57-9427-471a-9be2-4dc89d08da6a","8b4a62e1-fb2e-43f3-9395-664cf4ec3ce2");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDescription28, "10");		


				this.Description28 = UIControlBuilder.BuilderTextBox(_UFCard, "Description28", "True", "True", "True", "True", "Left", 0, 60, 0, 153, 45, 2, 3, 1, 2, "True", "100"
			,"",TextBoxMode.MultiLine,TextAlign.Left, true,false,"lblDescription28","","50","f8eb1d57-9427-471a-9be2-4dc89d08da6a","c51cad06-f671-4346-b165-8efabbb65773");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Description28, "False", "Description", this.Model.Cust_Xmjl_DocumentType, this.Model.Cust_Xmjl_DocumentType.FieldDescription, "Cust_Xmjl_DocumentType");


		
			UIControlBuilder.BuilderUFControl(this.Description28, "11");		
		 

				this.Line0 = UIControlBuilder.BuilderUFLine(_UFCard, "Line0", 311, "Horizontal", "True", 311, 20, 0, 5, 3, 1, "100","411ef7d0-d8cd-4093-89bb-73d45b472187","411ef7d0-d8cd-4093-89bb-73d45b472187");
	

		
			UIControlBuilder.BuilderUFControl(this.Line0, "12");		


				this.lblDocHeaderSequence37 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDocHeaderSequence37", "", "True", "True", "Right", 153, 20, 0, 6, 1, 1, "100","34d2c4c9-209b-4f28-a2e8-eeb495387302","25fe0fc4-4e06-4a46-b6fd-ab0644984bb4");

			UIControlBuilder.SetLabelFormReference(this.lblDocHeaderSequence37,"922bef2b-1cd8-4d51-9413-82d72bebcee7",true,992, 504);
			//foreach input parameter
	    	ScriptBuilder.BuildFormLinkInScript(this.lblDocHeaderSequence37,"lblDocHeaderSequence37", new FormLinkInParam[]{new FormLinkInParam("ID","","Value","DocHeaderSequence37",1),new FormLinkInParam("EntityFullName","","","",1), });
			//foreach output set data
	    	ScriptBuilder.BuildFormLinkOutScript(this.lblDocHeaderSequence37,"lblDocHeaderSequence37", new FormLinkOutParam[]{new FormLinkOutParam("ID","","Key","DocHeaderSequence37"),new FormLinkOutParam("Code","","Value","DocHeaderSequence37"),new FormLinkOutParam("Name","","Text","DocHeaderSequence37"),new FormLinkOutParam("EntityFullName","","",""), });
		
								

		
			UIControlBuilder.BuilderUFControl(this.lblDocHeaderSequence37, "13");		


				this.DocHeaderSequence37 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"DocHeaderSequence37",true,true, true,153, 20, 2, 6, 1, 1, "100","14",false,false,true,"lblDocHeaderSequence37","34d2c4c9-209b-4f28-a2e8-eeb495387302","346114ec-46d5-42bf-8c90-0fb411d992e6");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DocHeaderSequence37, "False", "DocHeaderSequence", this.Model.Cust_Xmjl_DocumentType, this.Model.Cust_Xmjl_DocumentType.FieldDocHeaderSequence, "Cust_Xmjl_DocumentType");
			UIControlBuilder.SetReferenceControlRefInfo(this.DocHeaderSequence37,"443cd54e-42c5-4614-a3fd-b6b7be535067", 580,408, "Name","Code","ID", this.Model.Cust_Xmjl_DocumentType.FieldDocHeaderSequence_Code,this.Model.Cust_Xmjl_DocumentType.FieldDocHeaderSequence_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.DocHeaderSequence37,"DocHeaderSequence37",new ReferenceOutputParam[]{new ReferenceOutputParam("DocHeaderSequence37","ID","Key"),new ReferenceOutputParam("DocHeaderSequence37","Code","Value"),new ReferenceOutputParam("DocHeaderSequence37","Name","Text"),});
				

		
			UIControlBuilder.BuilderUFControl(this.DocHeaderSequence37, "14");		
		 

				this.Line1 = UIControlBuilder.BuilderUFLine(_UFCard, "Line1", 311, "Horizontal", "True", 311, 20, 0, 7, 3, 1, "100","0dc4824b-87d4-48b3-9ab3-abf286763eac","0dc4824b-87d4-48b3-9ab3-abf286763eac");
	

		
			UIControlBuilder.BuilderUFControl(this.Line1, "15");		


				this.lblEffective_IsEffective61 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblEffective_IsEffective61", "", "True", "True", "Right", 153, 20, 0, 8, 1, 1, "100","69e51cb8-a018-41d4-972b-46c4969057c5","69e51cb8-a018-41d4-972b-46c4969057c5");


								

		
			UIControlBuilder.BuilderUFControl(this.lblEffective_IsEffective61, "16");		


				this.Effective_IsEffective61 = UIControlBuilder.BuilderUFCheckbox(_UFCard, "Effective_IsEffective61", true, true, "Left", 60, 0, 153, 20, 2, 8, 1, 1, "100",false,"lblEffective_IsEffective61","dd270cbf-f125-45b2-a3b7-545990a73513","6f9b2cb0-1790-48c8-8895-5f3f5c951592");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Effective_IsEffective61, "False", "Effective_IsEffective", this.Model.Cust_Xmjl_DocumentType, this.Model.Cust_Xmjl_DocumentType.FieldEffective_IsEffective, "Cust_Xmjl_DocumentType");
		

		
			UIControlBuilder.BuilderUFControl(this.Effective_IsEffective61, "17");		
		 

				this.lblEffective_EffectiveDate43 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblEffective_EffectiveDate43", "", "True", "True", "Right", 153, 20, 0, 9, 1, 1, "100","76ff1a2e-169d-4daa-9991-b675c63884f9","76ff1a2e-169d-4daa-9991-b675c63884f9");


								

		
			UIControlBuilder.BuilderUFControl(this.lblEffective_EffectiveDate43, "18");		


				this.Effective_EffectiveDate43 = UIControlBuilder.BuilderDatePicker(_UFCard, "Effective_EffectiveDate43", true, true, true, "Date","Left", 3, 60, 0, 153, 20, 2, 9, 1, 1, "100",true,false,"lblEffective_EffectiveDate43","115c6cd0-fb4a-4961-af87-ad5c57523524","42bf9863-b22c-4404-a870-a1e9a699d530");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Effective_EffectiveDate43, "False", "Effective_EffectiveDate", this.Model.Cust_Xmjl_DocumentType, this.Model.Cust_Xmjl_DocumentType.FieldEffective_EffectiveDate, "Cust_Xmjl_DocumentType");


		
			UIControlBuilder.BuilderUFControl(this.Effective_EffectiveDate43, "19");		
		 

				this.lblEffective_DisableDate58 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblEffective_DisableDate58", "", "True", "True", "Right", 153, 20, 0, 10, 1, 1, "100","a6561a0d-2fb5-45b6-91be-2d5b05804ce9","a6561a0d-2fb5-45b6-91be-2d5b05804ce9");


								

		
			UIControlBuilder.BuilderUFControl(this.lblEffective_DisableDate58, "20");		


				this.Effective_DisableDate58 = UIControlBuilder.BuilderDatePicker(_UFCard, "Effective_DisableDate58", true, true, true, "Date","Left", 3, 60, 0, 153, 20, 2, 10, 1, 1, "100",true,false,"lblEffective_DisableDate58","a8a2cf54-ccae-4bde-9eab-3d5fe5b8430a","d499a936-82dd-4f74-913a-7773287cd579");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Effective_DisableDate58, "False", "Effective_DisableDate", this.Model.Cust_Xmjl_DocumentType, this.Model.Cust_Xmjl_DocumentType.FieldEffective_DisableDate, "Cust_Xmjl_DocumentType");


		
			UIControlBuilder.BuilderUFControl(this.Effective_DisableDate58, "21");		
		 


															
			this.DocHeaderSequence37.IsMultiOrg  = false ;
			this.lblDocHeaderSequence37.SetMultiOrgInfo(this.DocHeaderSequence37,false);
			
							

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				





		#endregion
		

	}
}
