
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace AdvertisementApproveBE.TestSuite{

	/// <summary>
	/// AdvApproveBE Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class AdvApproveBETest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void AdvApproveBECRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				AdvertisementApproveBE.AdvApproveBE obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateAdvApproveBE
										obj  = AdvertisementApproveBE.AdvApproveBE.Create() ;
					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(AdvApproveBE).ToString() + "> failed.");
					session.Commit();
				}
	
				AdvertisementApproveBE.AdvApproveBE.EntityList list = AdvertisementApproveBE.AdvApproveBE.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(AdvertisementApproveBE.AdvApproveBE).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveAdvApproveBE	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = AdvertisementApproveBE.AdvApproveBE.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(AdvertisementApproveBE.AdvApproveBE).ToString() + "> failed.");
			}
		*/
		}
	}
}

