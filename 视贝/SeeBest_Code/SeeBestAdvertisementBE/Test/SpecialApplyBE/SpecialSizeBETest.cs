
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.TestSuite{

	/// <summary>
	/// SpecialSizeBE Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class SpecialSizeBETest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void SpecialSizeBECRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateSpecialSizeBE
					
					obj  = UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE.Create() ;
					UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBE n_specialsizebe =UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialSizeBE.Create(obj) ;


					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(SpecialSizeBE).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE.EntityList list = UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveSpecialSizeBE	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE).ToString() + "> failed.");
			}
		*/
		}
	}
}

