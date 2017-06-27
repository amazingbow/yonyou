

namespace RecBillSV
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
	public class ApproveRecBillSVTest
	{
		private Proxy.ApproveRecBillSVProxy obj = new Proxy.ApproveRecBillSVProxy();

		public ApproveRecBillSVTest()
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