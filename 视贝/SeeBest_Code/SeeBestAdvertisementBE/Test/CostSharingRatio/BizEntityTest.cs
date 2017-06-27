
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.CostSharingRatio.TestSuite{

	/// <summary>
	/// BizEntity Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class BizEntityTest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void BizEntityCRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.Cust.SeeBestAdvertisementBE.CostSharingRatio.BizEntity obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateBizEntity
										obj  = UFIDA.U9.Cust.SeeBestAdvertisementBE.CostSharingRatio.BizEntity.Create() ;
					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(BizEntity).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.Cust.SeeBestAdvertisementBE.CostSharingRatio.BizEntity.EntityList list = UFIDA.U9.Cust.SeeBestAdvertisementBE.CostSharingRatio.BizEntity.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.Cust.SeeBestAdvertisementBE.CostSharingRatio.BizEntity).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveBizEntity	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.Cust.SeeBestAdvertisementBE.CostSharingRatio.BizEntity.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.Cust.SeeBestAdvertisementBE.CostSharingRatio.BizEntity).ToString() + "> failed.");
			}
		*/
		}
	}
}

