

namespace UFIDA.U9.Cust.XMJL.SupplierSV
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
	public class QueryAllVerifiedSupplyTest
	{
		private Proxy.QueryAllVerifiedSupplyProxy obj = new Proxy.QueryAllVerifiedSupplyProxy();

		public QueryAllVerifiedSupplyTest()
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