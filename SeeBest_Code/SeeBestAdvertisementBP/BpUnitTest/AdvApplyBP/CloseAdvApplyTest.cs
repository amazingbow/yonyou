

namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApplyBP
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
	public class CloseAdvApplyTest
	{
		private Proxy.CloseAdvApplyProxy obj = new Proxy.CloseAdvApplyProxy();

		public CloseAdvApplyTest()
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