

namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabDataProcessBP
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
	public class SingleChangeBPTest
	{
		private Proxy.SingleChangeBPProxy obj = new Proxy.SingleChangeBPProxy();

		public SingleChangeBPTest()
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