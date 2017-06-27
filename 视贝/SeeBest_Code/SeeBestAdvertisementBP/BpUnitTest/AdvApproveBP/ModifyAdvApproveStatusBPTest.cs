

namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP
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
	public class ModifyAdvApproveStatusBPTest
	{
		private Proxy.ModifyAdvApproveStatusBPProxy obj = new Proxy.ModifyAdvApproveStatusBPProxy();

		public ModifyAdvApproveStatusBPTest()
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