





namespace UIFIA.U9.Cust.FJGX.RcvLineQryBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 查询BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class QueryBP
	{
	    #region Fields
		private UFIDA.U9.Query.QueryCaseBP.QryCommonParaObj qryInParameter;
		
	    #endregion
		
	    #region constructor
		public QueryBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 查询入口参数	
		/// 查询BP.Misc.查询入口参数
		/// </summary>
		/// <value></value>
		public UFIDA.U9.Query.QueryCaseBP.QryCommonParaObj QryInParameter
		{
			get
			{
				return this.qryInParameter;
			}
			set
			{
				qryInParameter = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UIFIA.U9.Cust.FJGX.RcvLineQryBP.RcvLineQryDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UIFIA.U9.Cust.FJGX.RcvLineQryBP.RcvLineQryDTO> result =  (List<UIFIA.U9.Cust.FJGX.RcvLineQryBP.RcvLineQryDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
