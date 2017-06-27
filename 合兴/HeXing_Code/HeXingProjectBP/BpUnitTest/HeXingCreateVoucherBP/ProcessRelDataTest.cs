

namespace UFIDA.U9.Cust.HeXingProjectBP.HeXingCreateVoucherBP
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
	public class ProcessRelDataTest
	{
		private Proxy.ProcessRelDataProxy obj = new Proxy.ProcessRelDataProxy();

		public ProcessRelDataTest()
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