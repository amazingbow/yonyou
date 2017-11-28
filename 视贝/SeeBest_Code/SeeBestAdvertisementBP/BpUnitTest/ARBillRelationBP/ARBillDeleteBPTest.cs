

namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.ARBillRelationBP
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
	public class ARBillDeleteBPTest
	{
		private Proxy.ARBillDeleteBPProxy obj = new Proxy.ARBillDeleteBPProxy();

		public ARBillDeleteBPTest()
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