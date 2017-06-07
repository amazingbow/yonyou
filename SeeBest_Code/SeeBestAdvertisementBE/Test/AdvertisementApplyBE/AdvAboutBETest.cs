
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.TestSuite{

	/// <summary>
	/// AdvAboutBE Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class AdvAboutBETest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void AdvAboutBECRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateAdvAboutBE
					
					obj  = UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE.Create() ;
					UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBE n_advaboutbe =UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvAboutBE.Create(obj) ;


					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(AdvAboutBE).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE.EntityList list = UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveAdvAboutBE	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyBE).ToString() + "> failed.");
			}
		*/
		}
	}
}

