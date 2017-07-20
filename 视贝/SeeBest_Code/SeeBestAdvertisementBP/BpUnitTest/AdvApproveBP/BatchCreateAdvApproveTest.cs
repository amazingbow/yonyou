

namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP
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
	public class BatchCreateAdvApproveTest
	{
		private Proxy.BatchCreateAdvApproveProxy obj = new Proxy.BatchCreateAdvApproveProxy();

		public BatchCreateAdvApproveTest()
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