








namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.Proxy
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.IO;
	using System.ServiceModel;
	using System.Runtime.Serialization;
	using UFSoft.UBF;
	using UFSoft.UBF.Exceptions;
	using UFSoft.UBF.Util.Context;
	using UFSoft.UBF.Service;
	using UFSoft.UBF.Service.Base ;

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.ILaserLabBNChangeBP")]
    public interface ILaserLabBNChangeBP
    {
		[OperationContract()]
		System.String Do(UFSoft.UBF.Service.ISVContext context ,List<System.String> lB, System.String bN, System.String amendBN);
    }
	[Serializable]    
    public class LaserLabBNChangeBPProxy : OperationProxyBase//, UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.Proxy.ILaserLabBNChangeBP
    {
	#region Fields	
				private List<System.String> lB ;
						private System.String bN ;
						private System.String amendBN ;
			
	#endregion	
		
	#region Properties
	
				

		/// <summary>
		/// 镭射标 (该属性可为空,且无默认值)
		/// LB批号修改.Misc.镭射标
		/// </summary>
		/// <value></value>
		public List<System.String> LB
		{
			get	
			{	
				return this.lB;
			}

			set	
			{	
				this.lB = value;	
			}
		}		
						

		/// <summary>
		/// 批次号 (该属性可为空,且无默认值)
		/// LB批号修改.Misc.批次号
		/// </summary>
		/// <value>System.String</value>
		public System.String BN
		{
			get	
			{	
				return this.bN;
			}

			set	
			{	
				this.bN = value;	
			}
		}		
						

		/// <summary>
		/// 修改批号 (该属性可为空,且无默认值)
		/// LB批号修改.Misc.修改批号
		/// </summary>
		/// <value>System.String</value>
		public System.String AmendBN
		{
			get	
			{	
				return this.amendBN;
			}

			set	
			{	
				this.amendBN = value;	
			}
		}		
			
	#endregion	


	#region Constructors
        public LaserLabBNChangeBPProxy()
        {
        }
        #endregion
        

		#region Public Method
		
        public System.String Do()
        {
  			InitKeyList() ;
 			System.String result = (System.String)InvokeAgent<UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabBNChangeBP.Proxy.ILaserLabBNChangeBP>();
			return GetRealResult(result);
        }
        
		protected override object InvokeImplement<T>(T oChannel)
        {
			IContext context = ContextManager.Context;			

            ILaserLabBNChangeBP channel = oChannel as ILaserLabBNChangeBP;
            if (channel != null)
            {
				UFSoft.UBF.Service.ISVContext isvContext =  GetISVContext(context);
				return channel.Do(isvContext , lB, bN, amendBN);
	    }
            return  null;
        }
		#endregion
		
		//处理由于序列化导致的返回值接口变化，而进行返回值的实际类型转换处理．
		private System.String GetRealResult(System.String result)
		{

				return result ;
		}
		#region  Init KeyList 
		//初始化SKey集合--由于接口不一样.BP.SV都要处理
		private void InitKeyList()
		{
			System.Collections.Hashtable dict = new System.Collections.Hashtable() ;
															
		}
		#endregion 

    }
}



