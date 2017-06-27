

namespace UFIDA.U9.Cust.XMJL.ReceivementSV
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
	public class ApproveRcvSVTest
	{
		private Proxy.ApproveRcvSVProxy obj = new Proxy.ApproveRcvSVProxy();

		public ApproveRcvSVTest()
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