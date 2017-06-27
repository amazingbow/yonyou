
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.CostSharingRatio.TestSuite{

	/// <summary>
	/// CostSharingRatioBE Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class CostSharingRatioBETest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void CostSharingRatioBECRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.SeeBestAdvertisementBE.CostSharingRatio.CostSharingRatioBE obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateCostSharingRatioBE
										obj  = UFIDA.U9.Cust.SeeBestAdvertisementBE.CostSharingRatio.CostSharingRatioBE.Create() ;
					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(CostSharingRatioBE).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.SeeBestAdvertisementBE.CostSharingRatio.CostSharingRatioBE.EntityList list = UFIDA.U9.Cust.SeeBestAdvertisementBE.CostSharingRatio.CostSharingRatioBE.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.SeeBestAdvertisementBE.CostSharingRatio.CostSharingRatioBE).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveCostSharingRatioBE	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.Cust.SeeBestAdvertisementBE.CostSharingRatio.CostSharingRatioBE.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.Cust.SeeBestAdvertisementBE.CostSharingRatio.CostSharingRatioBE).ToString() + "> failed.");
			}
		*/
		}
	}
}

