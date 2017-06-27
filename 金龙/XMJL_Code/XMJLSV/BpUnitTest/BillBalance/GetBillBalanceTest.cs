

namespace UFIDA.U9.Cust.XMJL.BillBalanceSV
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
	public class GetBillBalanceTest
	{
		private Proxy.GetBillBalanceProxy obj = new Proxy.GetBillBalanceProxy();

		public GetBillBalanceTest()
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