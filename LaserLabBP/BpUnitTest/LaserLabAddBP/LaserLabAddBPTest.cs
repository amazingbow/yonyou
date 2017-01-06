

namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabAddBP
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
	public class LaserLabAddBPTest
	{
		private Proxy.LaserLabAddBPProxy obj = new Proxy.LaserLabAddBPProxy();

		public LaserLabAddBPTest()
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