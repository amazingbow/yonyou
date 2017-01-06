
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.TestSuite{

	/// <summary>
	/// LaserLab Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class LaserLabTest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void LaserLabCRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateLaserLab
										obj  = UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab.Create() ;
					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(LaserLab).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab.EntityList list = UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveLaserLab	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LaserLab).ToString() + "> failed.");
			}
		*/
		}
	}
}

