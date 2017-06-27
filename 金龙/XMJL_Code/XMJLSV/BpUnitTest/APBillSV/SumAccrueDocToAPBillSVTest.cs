

namespace UFIDA.U9.Cust.XMJL.APBillSV
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
	public class SumAccrueDocToAPBillSVTest
	{
		private Proxy.SumAccrueDocToAPBillSVProxy obj = new Proxy.SumAccrueDocToAPBillSVProxy();

		public SumAccrueDocToAPBillSVTest()
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