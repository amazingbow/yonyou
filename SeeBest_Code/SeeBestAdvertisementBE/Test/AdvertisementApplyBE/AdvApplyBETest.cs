
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace AdvertisementApplyBE.TestSuite{

	/// <summary>
	/// AdvApplyBE Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class AdvApplyBETest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void AdvApplyBECRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				AdvertisementApplyBE.AdvApplyBE obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateAdvApplyBE
										obj  = AdvertisementApplyBE.AdvApplyBE.Create() ;
					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(AdvApplyBE).ToString() + "> failed.");
					session.Commit();
				}
	
				AdvertisementApplyBE.AdvApplyBE.EntityList list = AdvertisementApplyBE.AdvApplyBE.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(AdvertisementApplyBE.AdvApplyBE).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveAdvApplyBE	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = AdvertisementApplyBE.AdvApplyBE.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(AdvertisementApplyBE.AdvApplyBE).ToString() + "> failed.");
			}
		*/
		}
	}
}

