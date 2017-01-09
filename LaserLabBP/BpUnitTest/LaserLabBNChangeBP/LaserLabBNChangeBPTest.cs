

namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP
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
	public class LaserLabBNChangeBPTest
	{
		private Proxy.LaserLabBNChangeBPProxy obj = new Proxy.LaserLabBNChangeBPProxy();

		public LaserLabBNChangeBPTest()
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