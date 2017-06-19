

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
	public class GetValueSetInfoTest
	{
		private Proxy.GetValueSetInfoProxy obj = new Proxy.GetValueSetInfoProxy();

		public GetValueSetInfoTest()
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