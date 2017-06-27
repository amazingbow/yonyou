


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
 * Form ID:0d5759d2-5904-4fde-b438-32705af3780a 
 * Form Name:XMJLSplitCarNoUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.XMJL.XMJLSplitCarNoModel
{
	[FormRegister("UFIDA.U9.Cust.XMJL.XMJLSplitCarNo","UFIDA.U9.Cust.XMJL.XMJLSplitCarNoModel.XMJLSplitCarNoUIFormWebPart", "UFIDA.U9.Cust.XMJL.XMJLSplitCarNo.WebPart", "0d5759d2-5904-4fde-b438-32705af3780a","WebPart", "True", 952, 480)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.XMJL.XMJLSplitCarNo', 'UFIDA.U9.Cust.XMJL.XMJLSplitCarNoModel.XMJLSplitCarNoUIFormWebPart', 'UFIDA.U9.Cust.XMJL.XMJLSplitCarNo.WebPart', '0d5759d2-5904-4fde-b438-32705af3780a')
	///<siteMapNode url="~/erp/simple.aspx?lnk=0d5759d2-5904-4fde-b438-32705af3780a" title="XMJLSplitCarNoUIForm"/>
    public partial class XMJLSplitCarNoUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(XMJLSplitCarNoUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new XMJLSplitCarNoModelAction Action
		{
			get { return (XMJLSplitCarNoModelAction)base.Action; }
			set { base.Action = value; }
		}
		XMJLSplitCarNoModelModel _uimodel=null;
		public new XMJLSplitCarNoModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new XMJLSplitCarNoModelModel();
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
                this.Model = value as XMJLSplitCarNoModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFDataGrid DataGrid5;
        IUFDataGrid DataGrid6;
        IUFDataGrid DataGrid7;
        IUFButton BtnClose;
        IUFButton BtnClear;
        IUFButton BtnSave;
        IUFButton BtnDelete;
        IUFButton BtnOk;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public XMJLSplitCarNoUIFormWebPart()
        {
            FormID = "0d5759d2-5904-4fde-b438-32705af3780a";
            IsAutoSize = bool.Parse("False");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.BtnClose.Click += new EventHandler(BtnClose_Click);		
						
				//Button控件事件
			this.BtnClear.Click += new EventHandler(BtnClear_Click);		
						
				//Button控件事件
			this.BtnSave.Click += new EventHandler(BtnSave_Click);		
						
				//Button控件事件
			this.BtnDelete.Click += new EventHandler(BtnDelete_Click);		
						
				//Button控件事件
			this.BtnOk.Click += new EventHandler(BtnOk_Click);		
						

	
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid5).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid5_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid5).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid5_GridCustomFilterHandler);
	
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid6).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid6_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid6).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid6_GridCustomFilterHandler);
	
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid7).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid7_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid7).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid7_GridCustomFilterHandler);

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
					this.Model = new XMJLSplitCarNoModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (XMJLSplitCarNoModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new XMJLSplitCarNoModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"XMJLSplitCarNoUIForm",true,952,480);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 14, 15, 0, 10, 10, 10, 10, 10);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(176,bool.Parse("False")),new GridColumnDef(70,bool.Parse("False")),new GridColumnDef(47,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("False")),new GridColumnDef(80,bool.Parse("False")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(182,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(26,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(22,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(25,bool.Parse("False")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_DataGrid5(_panel);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid5, "0");		


	
			_BuilderControl_DataGrid6(_panel);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid6, "1");		


	
			_BuilderControl_DataGrid7(_panel);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid7, "2");		


				this.BtnClose = UIControlBuilder.BuilderUFButton(_panel, true, "BtnClose", true, true, 80, 25, 12, 14, 1, 1, "100","", this.Model.ElementID,"",false,"fb8a64d5-f16e-4480-9f13-de5b84f5c7c6","","fb8a64d5-f16e-4480-9f13-de5b84f5c7c6");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnClose, "3");		


				this.BtnClear = UIControlBuilder.BuilderUFButton(_panel, true, "BtnClear", true, true, 80, 25, 10, 14, 1, 1, "100","", this.Model.ElementID,"",false,"5c70e02e-a4c1-44de-8bee-0e3acb06d6fd","","5c70e02e-a4c1-44de-8bee-0e3acb06d6fd");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnClear, "4");		


				this.BtnSave = UIControlBuilder.BuilderUFButton(_panel, true, "BtnSave", true, true, 80, 25, 8, 14, 1, 1, "100","", this.Model.ElementID,"",false,"99d9971a-7c94-4b7f-b37a-ac3ed32a9d7a","","99d9971a-7c94-4b7f-b37a-ac3ed32a9d7a");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnSave, "5");		


				this.BtnDelete = UIControlBuilder.BuilderUFButton(_panel, true, "BtnDelete", true, true, 80, 25, 6, 14, 1, 1, "100","", this.Model.ElementID,"",false,"29316c34-9057-43e2-9be1-aded4e5fded0","","29316c34-9057-43e2-9be1-aded4e5fded0");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnDelete, "6");		


				this.BtnOk = UIControlBuilder.BuilderUFButton(_panel, true, "BtnOk", true, true, 80, 25, 4, 14, 1, 1, "100","", this.Model.ElementID,"",false,"fa224b55-8fa4-4797-b29b-efc05dbc1638","","fa224b55-8fa4-4797-b29b-efc05dbc1638");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnOk, "7");		



								
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







				





       
        private void _BuilderControl_DataGrid5(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid5", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, false, true,true,false,false,true,500,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "0");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 246, 418, 0, 0, 2, 14, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.ProjectView, "ProjectView", "", null, 500, "");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=true;
            this.DataGrid5 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ManufactureID1","NumberColumnModel", "", 0,this.Model.ProjectView.Fields["ManufactureID"]/*ManufactureID*/,"ManufactureID", false, false, true, false, false, true, 7, 100, "19.0",true, false,"","26e1a8f8-8187-40c7-a237-c7130f015d87","26e1a8f8-8187-40c7-a237-c7130f015d87","6a901aad-a833-42e5-bd82-a4b807d62566");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ManufactureNo1","TextBoxColumnModel", "", 0,this.Model.ProjectView.Fields["ManufactureNo"]/*ManufactureNo*/,"ManufactureNo", false, true, true, false, false, true, 0, 150, "50",true, false,"","77cf3d3c-6976-4d42-b9a0-f6527873227f","77cf3d3c-6976-4d42-b9a0-f6527873227f","d531337d-6863-42f0-bddb-0870f59f5570");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID0","NumberColumnModel", "", 0,this.Model.ProjectView.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "",true, false,"","11105a26-829a-48ff-81d5-69e970bba977","11105a26-829a-48ff-81d5-69e970bba977","09fcdfba-9956-4d09-be39-9fcd80fdf793");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 
        }

				





       
        private void _BuilderControl_DataGrid6(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid6", UFSoft.UBF.UI.ControlModel.EditStatus.Browse, false, true,true,false,false,true,200,true, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "1");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 679, 206, 2, 0, 12, 7, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.SplitView, "SplitView", "", null, 200, "");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid6 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ManufactureNo0","TextBoxColumnModel", "", 0,this.Model.SplitView.Fields["ManufactureNo"]/*ManufactureNo*/,"ManufactureNo", false, true, true, false, false, true, 0, 100, "50",true, false,"","1ae8190f-df46-4cbe-991b-3e7aac4099c5","1ae8190f-df46-4cbe-991b-3e7aac4099c5","39ae41cd-9722-47aa-b73b-a17f972c85ff");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ProdLine0","TextBoxColumnModel", "", 0,this.Model.SplitView.Fields["ProdLine"]/*ProdLine*/,"ProdLine", false, true, true, false, false, true, 0, 100, "50",true, false,"","8bf2922e-558b-4c95-af3c-8dc047fd6df1","8bf2922e-558b-4c95-af3c-8dc047fd6df1","893627af-0fd6-44f0-9d09-b04b6e1f36f6");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ReqCategory0","TextBoxColumnModel", "", 0,this.Model.SplitView.Fields["ReqCategory"]/*ReqCategory*/,"ReqCategory", false, true, true, false, false, true, 0, 100, "50",true, false,"","07477819-553f-4c61-8cce-c6d3ddbbd177","07477819-553f-4c61-8cce-c6d3ddbbd177","87ad54ff-8ba4-44d5-9796-aa6d57eeefeb");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CompanyContact0","TextBoxColumnModel", "", 0,this.Model.SplitView.Fields["CompanyContact"]/*CompanyContact*/,"CompanyContact", false, true, true, false, false, true, 0, 100, "50",true, false,"","25e55379-5f57-45bf-9e47-1fffe47bcbc0","25e55379-5f57-45bf-9e47-1fffe47bcbc0","19b55785-3613-48f0-acde-d9980048d998");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ProdDate0","DatePickerColumnModel", "", 0,this.Model.SplitView.Fields["ProdDate"]/*ProdDate*/,"ProdDate", false, true, true, false, false, true, 3, 70, "8",true, false,"2005-1-1","c54826b3-abd8-4b68-9b29-5c2e90c6d59a","c54826b3-abd8-4b68-9b29-5c2e90c6d59a","dfbf99cd-30d6-4b29-95f9-927b79eab10b");
                   
			((IUFDatePickerColumn)column).DateTimeType = DateTimeType.Date;
            ((IUFDatePickerColumn)column).DateTimeFormat = CurrentState._I18N._DateTimeFormatInfo;
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Sequence0","NumberColumnModel", "", 0,this.Model.SplitView.Fields["Sequence"]/*Sequence*/,"Sequence", false, true, true, false, false, true, 2, 100, "10.0",true, false,"","3ed311ed-dfa3-4ec5-9d7d-492a52c3c102","3ed311ed-dfa3-4ec5-9d7d-492a52c3c102","61008c1f-3d56-4729-b72b-57a6c8d656fd");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ProductQty0","NumberColumnModel", "", 0,this.Model.SplitView.Fields["ProductQty"]/*ProductQty*/,"ProductQty", false, true, true, false, false, true, 8, 100, "18.0",true, false,"","c56818dd-bf86-4bb3-9d56-23dc38ab0b4f","c56818dd-bf86-4bb3-9d56-23dc38ab0b4f","db08e847-dad9-49db-9009-599f95d9c5a8");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ContractNum0","NumberColumnModel", "", 0,this.Model.SplitView.Fields["ContractNum"]/*ContractNum*/,"ContractNum", false, true, true, false, false, true, 8, 100, "18.0",true, false,"","687e02a1-221a-4027-b88c-14604dbd7298","687e02a1-221a-4027-b88c-14604dbd7298","2ff4767a-0b1a-40de-a950-50f07d0af477");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CarType0","TextBoxColumnModel", "", 0,this.Model.SplitView.Fields["CarType"]/*CarType*/,"CarType", false, true, true, false, false, true, 0, 100, "50",true, false,"","fa135085-4e00-4c8a-a649-f9bc34450c81","fa135085-4e00-4c8a-a649-f9bc34450c81","aab5d2b6-d2da-4a94-973c-a15f806abc1e");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"StationName0","TextBoxColumnModel", "", 0,this.Model.SplitView.Fields["StationName"]/*StationName*/,"StationName", false, true, true, false, false, true, 0, 100, "50",true, false,"","2b9c02a7-e407-474b-b699-06e5c7fcfddb","2b9c02a7-e407-474b-b699-06e5c7fcfddb","c3b77186-5797-4607-ba79-405c488b0b45");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CustName0","TextBoxColumnModel", "", 0,this.Model.SplitView.Fields["CustName"]/*CustName*/,"CustName", false, true, true, false, false, true, 0, 100, "50",true, false,"","4a73096f-9f62-4721-9bf3-81fa0b8ec868","4a73096f-9f62-4721-9bf3-81fa0b8ec868","bd8b9510-a527-4d2c-b904-e743ee76c1cf");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ContractDelivery0","DatePickerColumnModel", "", 0,this.Model.SplitView.Fields["ContractDelivery"]/*ContractDelivery*/,"ContractDelivery", false, true, true, false, false, true, 3, 70, "8",true, false,"2005-1-1","e5e454cd-ec6e-4a68-bf34-d84098000a1c","e5e454cd-ec6e-4a68-bf34-d84098000a1c","fcce861c-5000-4560-a480-a79d896e2986");
                   
			((IUFDatePickerColumn)column).DateTimeType = DateTimeType.Date;
            ((IUFDatePickerColumn)column).DateTimeFormat = CurrentState._I18N._DateTimeFormatInfo;
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID2","NumberColumnModel", "", 0,this.Model.SplitView.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "",true, false,"","9be201f2-8556-46ce-889a-83d1d76f1798","9be201f2-8556-46ce-889a-83d1d76f1798","f32136dc-bb16-4b4d-b372-550f660a9b15");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"PlsID0","NumberColumnModel", "", 0,this.Model.SplitView.Fields["PlsID"]/*PlsID*/,"PlsID", false, false, true, false, false, true, 7, 100, "19.0",true, false,"","625f6384-a47d-4704-8c38-1743090a2fbf","625f6384-a47d-4704-8c38-1743090a2fbf","056820dc-28a9-4387-9274-98dc5e85952b");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SeibanCode0","TextBoxColumnModel", "", 0,this.Model.SplitView.Fields["SeibanCode"]/*SeibanCode*/,"SeibanCode", false, true, true, false, false, true, 0, 100, "50",true, false,"","ca5751bd-4a05-427b-b1ba-5aca54888117","ca5751bd-4a05-427b-b1ba-5aca54888117","f086655d-2a73-4e1a-a46f-edf0cfe5610e");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 
        }

				





       
        private void _BuilderControl_DataGrid7(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid7", UFSoft.UBF.UI.ControlModel.EditStatus.Browse, false, true,true,false,false,true,200,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "2");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 679, 202, 2, 7, 12, 7, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.SplitPlanView, "SplitPlanView", "", null, 200, "");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid7 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Scheduling0","NumberColumnModel", "", 0,this.Model.SplitPlanView.Fields["Scheduling"]/*Scheduling*/,"Scheduling", false, true, true, false, false, true, 2, 40, "10.0",true, false,"","c2ac6c15-3924-4c4f-bb6c-5eef1b4e41ad","c2ac6c15-3924-4c4f-bb6c-5eef1b4e41ad","869e5e06-9a5c-4334-8a3b-e7e44fa8044a");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ReqCategory1","TextBoxColumnModel", "", 0,this.Model.SplitPlanView.Fields["ReqCategory"]/*ReqCategory*/,"ReqCategory", false, true, true, false, false, true, 0, 120, "50",true, false,"","bd671333-878c-4b8a-9f01-39ff5025669a","bd671333-878c-4b8a-9f01-39ff5025669a","a142f3ea-94d4-4773-878f-3f7bbbf1b94a");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CompanyContract0","TextBoxColumnModel", "", 0,this.Model.SplitPlanView.Fields["CompanyContract"]/*CompanyContract*/,"CompanyContract", false, true, true, false, false, true, 0, 80, "50",true, false,"","9735182a-3765-4b74-91b0-64550e93897c","9735182a-3765-4b74-91b0-64550e93897c","7d8a621b-16b5-4808-a61d-c6bf10426d67");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ProdDate1","DatePickerColumnModel", "", 0,this.Model.SplitPlanView.Fields["ProdDate"]/*ProdDate*/,"ProdDate", false, true, true, false, false, true, 3, 70, "8",true, false,"2005-1-1","fb686af3-6b04-4383-92cf-e5bc376e0e19","fb686af3-6b04-4383-92cf-e5bc376e0e19","3c157545-d990-46b0-9e47-e6276bc46f86");
                   
			((IUFDatePickerColumn)column).DateTimeType = DateTimeType.Date;
            ((IUFDatePickerColumn)column).DateTimeFormat = CurrentState._I18N._DateTimeFormatInfo;
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Sequence1","NumberColumnModel", "", 0,this.Model.SplitPlanView.Fields["Sequence"]/*Sequence*/,"Sequence", false, true, true, false, false, true, 8, 60, "18.0",true, false,"","b57fa3fe-4e95-4c2d-96b7-7fe5a23b02b9","b57fa3fe-4e95-4c2d-96b7-7fe5a23b02b9","1a7007a7-70f0-49e7-9f43-3ab08c8ce775");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ProductQty1","NumberColumnModel", "", 0,this.Model.SplitPlanView.Fields["ProductQty"]/*ProductQty*/,"ProductQty", false, true, true, false, false, true, 8, 80, "18.0",true, false,"","495c54d9-70e0-41c2-ac93-3df800023f0f","495c54d9-70e0-41c2-ac93-3df800023f0f","14c62b53-8cc7-47df-9f38-77fd86c51ec2");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ContractNum1","NumberColumnModel", "", 0,this.Model.SplitPlanView.Fields["ContractNum"]/*ContractNum*/,"ContractNum", false, true, true, false, false, true, 8, 80, "18.0",true, false,"","9158e607-2389-4af1-b0c4-74430b383dae","9158e607-2389-4af1-b0c4-74430b383dae","673057dc-af98-4cbb-9af8-f1ced0510704");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CarType1","TextBoxColumnModel", "", 0,this.Model.SplitPlanView.Fields["CarType"]/*CarType*/,"CarType", false, true, true, false, false, true, 0, 100, "50",true, false,"","0dfd0200-ed86-47a9-8258-fcc2d91fdcc6","0dfd0200-ed86-47a9-8258-fcc2d91fdcc6","6a0d965d-f7c8-442b-8f76-e82e2b80c68e");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"StagnationContract0","TextBoxColumnModel", "", 0,this.Model.SplitPlanView.Fields["StagnationContract"]/*StagnationContract*/,"StagnationContract", false, true, true, false, false, true, 0, 100, "50",true, false,"","7286eaac-8ae6-49b5-927f-748144415c35","7286eaac-8ae6-49b5-927f-748144415c35","863ffec3-521e-4e89-9fbf-378a1dfdff4e");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"StationName1","TextBoxColumnModel", "", 0,this.Model.SplitPlanView.Fields["StationName"]/*StationName*/,"StationName", false, true, true, false, false, true, 0, 100, "50",true, false,"","9820b7e3-c43f-4b09-ac45-c5dac5b52bee","9820b7e3-c43f-4b09-ac45-c5dac5b52bee","91a1a16e-68cf-41a4-84fb-bd8dc1c4ed68");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CustName1","TextBoxColumnModel", "", 0,this.Model.SplitPlanView.Fields["CustName"]/*CustName*/,"CustName", false, true, true, false, false, true, 0, 200, "50",true, false,"","5e659718-3335-4210-9d11-e8e4c193699e","5e659718-3335-4210-9d11-e8e4c193699e","128b17a7-69d0-4323-863a-6fb8f7087493");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ContractDelivery1","DatePickerColumnModel", "", 0,this.Model.SplitPlanView.Fields["ContractDelivery"]/*ContractDelivery*/,"ContractDelivery", false, true, true, false, false, true, 3, 70, "8",true, false,"2005-1-1","68509e13-db1d-4868-880c-81088b5fc176","68509e13-db1d-4868-880c-81088b5fc176","66d5b8ec-1628-47fd-90e3-4e1623135e6c");
                   
			((IUFDatePickerColumn)column).DateTimeType = DateTimeType.Date;
            ((IUFDatePickerColumn)column).DateTimeFormat = CurrentState._I18N._DateTimeFormatInfo;
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID1","NumberColumnModel", "", 0,this.Model.SplitPlanView.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "",true, false,"","2d9d8f49-af5c-457b-9f87-6fd40a895c26","2d9d8f49-af5c-457b-9f87-6fd40a895c26","ea2391ed-cbde-481b-9de4-f67c0331ec97");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"PlsID1","NumberColumnModel", "", 0,this.Model.SplitPlanView.Fields["PlsID"]/*PlsID*/,"PlsID", false, false, true, false, false, true, 7, 100, "19.0",true, false,"","45911a8d-fcb8-4a30-a0a4-b5b91d42cc2f","45911a8d-fcb8-4a30-a0a4-b5b91d42cc2f","32d581c4-3a82-4fff-bad4-98a9018411aa");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SeibanCode1","TextBoxColumnModel", "", 0,this.Model.SplitPlanView.Fields["SeibanCode"]/*SeibanCode*/,"SeibanCode", false, true, true, false, false, true, 0, 100, "50",true, false,"","5d438961-ffea-444c-91b4-7c270389f530","5d438961-ffea-444c-91b4-7c270389f530","1ffe456a-9a14-4355-9ce8-592b5f346f10");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 
        }





		#endregion
		

	}
}
