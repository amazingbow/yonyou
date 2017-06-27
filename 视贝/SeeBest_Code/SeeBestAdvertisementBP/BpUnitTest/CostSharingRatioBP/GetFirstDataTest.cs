

namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.CostSharingRatioBP
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
	public class GetFirstDataTest
	{
		private Proxy.GetFirstDataProxy obj = new Proxy.GetFirstDataProxy();

		public GetFirstDataTest()
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