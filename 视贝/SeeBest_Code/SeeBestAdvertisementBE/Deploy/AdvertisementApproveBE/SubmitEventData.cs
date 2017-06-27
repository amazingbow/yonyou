



	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE
{
	/// <summary>
	/// EntityData: 提交事件
	/// 
	/// </summary>
	[Serializable]
	[DataContract(Name = "EventData", Namespace = "UFSoft.UBF.Eventing")]
	public partial class SubmitEventData : UFSoft.UBF.Eventing.EventData
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		//public SubmitEventData():this("UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.SubmitEvent,UFIDA.U9.Cust.SeeBestAdvertisementBE")
		//{
		//}
		//public SubmitEventData(string type):base(type)
		//{
		//}
		public SubmitEventData()
		{}

		public override string EventType {
			get {
				return "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.SubmitEvent";
			}
		}
		#region EventData Properties 
		//临时用，要改。？？？？???

		
		#endregion	


	} 
	
}