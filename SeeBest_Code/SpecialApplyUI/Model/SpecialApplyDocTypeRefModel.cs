#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace SpecialApplyDocTypeRef
{
	[Serializable]
	public partial class SpecialApplyDocTypeRefModel : UIModel
	{
		#region Constructor
		public SpecialApplyDocTypeRefModel() : base("SpecialApplyDocTypeRef")
		{
			InitClass();
			this.SetResourceInfo("8dcb9af8-0bad-45d2-bff6-001388b09f77");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private SpecialApplyDocTypeRefModel(bool isInit) : base("SpecialApplyDocTypeRef")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new SpecialApplyDocTypeRefModel(false);
		}
		#endregion
		#region member
		#region views
		private cRefView viewcRef;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public cRefView cRef
		{
			get { return (cRefView)this["cRef"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewcRef = new cRefView(this);
			this.viewcRef.SetResourceInfo("76390bd2-ae60-4482-a986-57a7cd439119");
			this.Views.Add(this.viewcRef);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.SpecialApplyUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class cRefView : UIView
	{
		#region Constructor
		public cRefView(IUIModel model) : base(model,"cRef","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private cRefView():base(null,"cRef","UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new cRefView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldCode
		{
			get { return this.Fields["Code"]; }
		}
		public IUIField FieldName
		{
			get { return this.Fields["Name"]; }
		}
		public IUIField FieldShortName
		{
			get { return this.Fields["ShortName"]; }
		}
		public IUIField FieldConfirmType
		{
			get { return this.Fields["ConfirmType"]; }
		}
		public IUIField FieldApproveType
		{
			get { return this.Fields["ApproveType"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public cRefDefaultFilterFilter DefaultFilter
		{
			get { return (cRefDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","3be65ab8-c949-4dc0-b18d-10b8e0927bfb");
			UIModelRuntimeFactory.AddNewUIField(this,"Code", typeof(String), false,"","System.String", "Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5b3f1e12-fd04-40ea-a2d8-3976a5b949d9");
			UIModelRuntimeFactory.AddNewUIField(this,"Name", typeof(String), true,"","System.String", "Name", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1760aba7-6564-40dd-8821-a1594d48885c");
			UIModelRuntimeFactory.AddNewUIField(this,"ShortName", typeof(String), true,"","System.String", "ShortName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ed3a8c80-61ee-4e38-b298-03282c55f563");
			UIModelRuntimeFactory.AddNewUIField(this,"ConfirmType", typeof(Int32), false,"","UFIDA.U9.Base.Doc.ConfirmTypeEnum", "ConfirmType", true,true, false, "",false,(UIFieldType)2,"d232b8fb-1938-4ebe-a90c-41c911c0bc10","394cf8e6-b1f1-4cb7-af99-fdbe13471083");
			UIModelRuntimeFactory.AddNewUIField(this,"ApproveType", typeof(Int32), true,"","UFIDA.U9.Base.Doc.ApproveTypeEnum", "ApproveType", true,true, false, "",false,(UIFieldType)2,"d4b6e1a9-d80d-4516-8316-4b1d436cd449","92a367fa-b6e1-4818-a795-8d3e61511582");


			this.CurrentFilter = new cRefDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new cRefRecord(builder);
		}
		#endregion

		#region new method
		public new cRefRecord FocusedRecord
		{
			get { return (cRefRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new cRefRecord AddNewUIRecord()
		{	
			return (cRefRecord)base.AddNewUIRecord();
		}
		public new cRefRecord NewUIRecord()
		{	
			return (cRefRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class cRefRecord : UIRecord
	{
		#region Constructor
		public cRefRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private cRefView uiviewcRef
		{
			get { return (cRefView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new cRefRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewcRef.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewcRef.FieldID);
			}
			set{
				this[this.uiviewcRef.FieldID] = value;
			}
		}
		
		
		public  String Code
		{
			get{
				//object value = this[this.uiviewcRef.FieldCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldCode);
			}
			set{
				this[this.uiviewcRef.FieldCode] = value;
			}
		}
		
		
		public new String Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldName);
			}
			set{
				this[this.uiviewcRef.FieldName] = value;
			}
		}
		
		
		public  String ShortName
		{
			get{
				//object value = this[this.uiviewcRef.FieldShortName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldShortName);
			}
			set{
				this[this.uiviewcRef.FieldShortName] = value;
			}
		}
		
		
		public  Int32 ConfirmType
		{
			get{
				//object value = this[this.uiviewcRef.FieldConfirmType] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewcRef.FieldConfirmType);
			}
			set{
				this[this.uiviewcRef.FieldConfirmType] = value;
			}
		}
		
		
		public  Int32? ApproveType
		{
			get{
				//object value = this[this.uiviewcRef.FieldApproveType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewcRef.FieldApproveType);
			}
			set{
				this[this.uiviewcRef.FieldApproveType] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class cRefDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public cRefDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"Org.ID=#Context.OrgID#",@" order by Code asc")
		{
			InitClass();
		}
		//for Clone Constructor
		private cRefDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new cRefDefaultFilterFilter();
		}
		#endregion

		#region property
		#endregion
		
		#region function
		private void InitClass()
		{
		}
		#endregion

	}



}