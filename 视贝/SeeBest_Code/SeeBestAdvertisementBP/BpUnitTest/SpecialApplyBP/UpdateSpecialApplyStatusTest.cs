

namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.SpecialApplyBP
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
	public class UpdateSpecialApplyStatusTest
	{
		private Proxy.UpdateSpecialApplyStatusProxy obj = new Proxy.UpdateSpecialApplyStatusProxy();

		public UpdateSpecialApplyStatusTest()
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