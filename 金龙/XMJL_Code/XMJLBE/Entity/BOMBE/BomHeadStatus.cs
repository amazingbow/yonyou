using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.XMJL.BommBE
{
    /// <summary>
    /// 可扩展枚举: 缺件发料单状态 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class BomHeadStatus
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.XMJL.BommBE.BomHeadStatus");
        #region ctor & cctor 
        static BomHeadStatus()
        {
            InitData();
        }
        private BomHeadStatus(int eValue)
        {
            this.currentValue = eValue;
        }
        private BomHeadStatus(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,BomHeadStatus>();
            partDisburse = new BomHeadStatus(1,"PartDisburse") ;
            innerEnums.Add(1,partDisburse) ;
            disbursed = new BomHeadStatus(2,"Disbursed") ;
            innerEnums.Add(2,disbursed) ;
            closed = new BomHeadStatus(3,"Closed") ;
            innerEnums.Add(3,closed) ;
            initStat = new BomHeadStatus(0,"InitStat") ;
            innerEnums.Add(0,initStat) ;
            empty = new BomHeadStatus(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static BomHeadStatus empty;
        public static BomHeadStatus Empty
        {
            get
            {
                return empty;
            }
        }
        #endregion 

        #region Intstance Propertites 
        private int currentValue;
        public System.Int32 Value
        {
            get
            {
				return currentValue ;         
            }
        }
        private string  name ;
        public string  Name 
        {
            get
            {
                return name;
            }
        }
        [System.Obsolete("已经废弃,请用EnumRes.GetResource(name)方式来获取显示名称. ")]
        public string Res_Name
        {
        	get 
        	{
        		switch ( this.Name )
        		{
        			case "PartDisburse":
        				return this.Res_PartDisburse; 
        			case "Disbursed":
        				return this.Res_Disbursed; 
        			case "Closed":
        				return this.Res_Closed; 
        			case "InitStat":
        				return this.Res_InitStat; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static BomHeadStatus partDisburse ;
        /// <summary>
        /// 枚举值: 部分发料  Value:1  
        /// 缺件发料单状态.Misc.部分发料
        /// </summary>
        public static BomHeadStatus PartDisburse
        {
            get
            {
                return  partDisburse ;
            }
        }
        private static BomHeadStatus disbursed ;
        /// <summary>
        /// 枚举值: 已发料  Value:2  
        /// 缺件发料单状态.Misc.已发料
        /// </summary>
        public static BomHeadStatus Disbursed
        {
            get
            {
                return  disbursed ;
            }
        }
        private static BomHeadStatus closed ;
        /// <summary>
        /// 枚举值: 已关闭  Value:3  
        /// 缺件发料单状态.Misc.已关闭
        /// </summary>
        public static BomHeadStatus Closed
        {
            get
            {
                return  closed ;
            }
        }
        private static BomHeadStatus initStat ;
        /// <summary>
        /// 枚举值: 初始状态  Value:0  
        /// 缺件发料单状态.Misc.初始状态
        /// </summary>
        public static BomHeadStatus InitStat
        {
            get
            {
                return  initStat ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, BomHeadStatus> innerEnums;
        /// <summary>
        /// Get BomHeadStatus's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<BomHeadStatus> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get BomHeadStatus By Value 
        /// </summary>
        public static BomHeadStatus GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						BomHeadStatus newValue = new BomHeadStatus(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get BomHeadStatus By Value 
        /// </summary>
        public static BomHeadStatus GetFromValue(object value)
        {
			if (value == null)
				return BomHeadStatus.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get BomHeadStatus By Name 
        /// </summary>
        public static BomHeadStatus GetFromName(string name)
        {
            foreach (BomHeadStatus obj in innerEnums.Values)
            {
                if (obj.Name == name)
                    return obj;
            }
            //don't need modify to return a Default Value .
            return null;
        }
        #endregion 


		#region ModelResource
		/// <summary>
		/// 缺件发料单状态的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 缺件发料单状态的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.XMJL.BommBE.BomHeadStatus")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_PartDisburse　{ get {return EnumRes.GetResource("PartDisburse");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Disbursed　{ get {return EnumRes.GetResource("Disbursed");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Closed　{ get {return EnumRes.GetResource("Closed");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_InitStat　{ get {return EnumRes.GetResource("InitStat");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.XMJL.BommBE.BomHeadStatus";　}　}

			/// <summary>
			///  获取资源接口,直接传了枚举对象.Name 就可.
			/// </summary>
			public static string GetResource(String attrName)
			{
				if (attrName== Enum_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEnumResource(Enum_FullName);
				return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEnumResource(Enum_FullName, attrName);
			}
			/// <summary>
			///  获取资源接口,直接传了枚举对象.Value 或Int32值 就可.
			/// </summary>
			public static string GetResourceByValue(Int32 value)
			{
				return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetNameForEnumValue(Enum_FullName, value);
			}
		}
		#endregion 
    }
}