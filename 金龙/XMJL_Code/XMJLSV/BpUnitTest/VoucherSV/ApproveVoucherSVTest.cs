

namespace UFIDA.U9.Cust.XMJL.VoucherSV
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
	public class ApproveVoucherSVTest
	{
		private Proxy.ApproveVoucherSVProxy obj = new Proxy.ApproveVoucherSVProxy();

		public ApproveVoucherSVTest()
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