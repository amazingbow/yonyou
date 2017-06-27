





namespace UFIDA.U9.Cust.FJGX.CustomerDocListQryBP
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
		public List<UFIDA.U9.Cust.FJGX.CustomerDocListQryBP.CustomerDocListQryDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.FJGX.CustomerDocListQryBP.CustomerDocListQryDTO> result =  (List<UFIDA.U9.Cust.FJGX.CustomerDocListQryBP.CustomerDocListQryDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
