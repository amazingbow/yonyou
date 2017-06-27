

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
	public class ARBillImportBPTest
	{
		private Proxy.ARBillImportBPProxy obj = new Proxy.ARBillImportBPProxy();

		public ARBillImportBPTest()
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