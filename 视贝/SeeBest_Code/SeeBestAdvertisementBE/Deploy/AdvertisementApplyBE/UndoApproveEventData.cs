



	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE
{
	/// <summary>
	/// EntityData: 弃审事件
	/// 
	/// </summary>
	[Serializable]
	[DataContract(Name = "EventData", Namespace = "UFSoft.UBF.Eventing")]
	public partial class UndoApproveEventData : UFSoft.UBF.Eventing.EventData
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		//public UndoApproveEventData():this("UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.UndoApproveEvent,UFIDA.U9.Cust.SeeBestAdvertisementBE")
		//{
		//}
		//public UndoApproveEventData(string type):base(type)
		//{
		//}
		public UndoApproveEventData()
		{}

		public override string EventType {
			get {
				return "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.UndoApproveEvent";
			}
		}
		#region EventData Properties 
		//临时用，要改。？？？？???

		
		#endregion	


	} 
	
}