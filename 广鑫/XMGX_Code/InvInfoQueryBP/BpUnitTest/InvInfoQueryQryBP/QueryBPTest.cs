

namespace UFIDA.U9.Cust.FJGX.InvInfoQueryQryBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.IO;
	using NUnit.Framework;
	
	/// <summary>
	/// Business operation test
	/// </summary> 
	[TestFixture]		
	public class QueryBPTest
	{
		private Proxy.QueryBPProxy obj = new Proxy.QueryBPProxy();

		public QueryBPTest()
		{
		}
		#region AutoTestCode ...
		[Test]
		public void TestDo()
		{
			obj.Do() ;  
		
		}
		#endregion 				
	}
	
}