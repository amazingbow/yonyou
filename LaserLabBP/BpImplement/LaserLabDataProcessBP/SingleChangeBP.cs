





namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabDataProcessBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 单个转换BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class SingleChangeBP
	{
	    #region Fields
		private System.String laserLab;
		private System.String batchNo;
		private System.String type;
		private System.Int32 flowStart;
		private System.Int32 flowEnd;
		private System.Int32 changeModel;
		private System.Int32 changeCp;
		
	    #endregion
		
	    #region constructor
		public SingleChangeBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 镭射标号	
		/// 单个转换BP.Misc.镭射标号
		/// </summary>
		/// <value></value>
		public System.String LaserLab
		{
			get
			{
				return this.laserLab;
			}
			set
			{
				laserLab = value;
			}
		}
		/// <summary>
		/// 批号	
		/// 单个转换BP.Misc.批号
		/// </summary>
		/// <value></value>
		public System.String BatchNo
		{
			get
			{
				return this.batchNo;
			}
			set
			{
				batchNo = value;
			}
		}
		/// <summary>
		/// 型号	
		/// 单个转换BP.Misc.型号
		/// </summary>
		/// <value></value>
		public System.String Type
		{
			get
			{
				return this.type;
			}
			set
			{
				type = value;
			}
		}
		/// <summary>
		/// 流水起码	
		/// 单个转换BP.Misc.流水起码
		/// </summary>
		/// <value></value>
		public System.Int32 FlowStart
		{
			get
			{
				return this.flowStart;
			}
			set
			{
				flowStart = value;
			}
		}
		/// <summary>
		/// 流水止码	
		/// 单个转换BP.Misc.流水止码
		/// </summary>
		/// <value></value>
		public System.Int32 FlowEnd
		{
			get
			{
				return this.flowEnd;
			}
			set
			{
				flowEnd = value;
			}
		}
		/// <summary>
		/// 改变方式	
		/// 单个转换BP.Misc.改变方式
		/// </summary>
		/// <value></value>
		public System.Int32 ChangeModel
		{
			get
			{
				return this.changeModel;
			}
			set
			{
				changeModel = value;
			}
		}
		/// <summary>
		/// 改变类型	
		/// 单个转换BP.Misc.改变类型
		/// </summary>
		/// <value></value>
		public System.Int32 ChangeCp
		{
			get
			{
				return this.changeCp;
			}
			set
			{
				changeCp = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public System.Boolean Do()
		{	
		    BaseStrategy selector = Select();	
				System.Boolean result =  (System.Boolean)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
