

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
	public class GetSRMRcvTest
	{
		private Proxy.GetSRMRcvProxy obj = new Proxy.GetSRMRcvProxy();

		public GetSRMRcvTest()
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