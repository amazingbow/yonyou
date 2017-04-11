

namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabScrapBP
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
	public class ReturnLBMasterTest
	{
		private Proxy.ReturnLBMasterProxy obj = new Proxy.ReturnLBMasterProxy();

		public ReturnLBMasterTest()
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