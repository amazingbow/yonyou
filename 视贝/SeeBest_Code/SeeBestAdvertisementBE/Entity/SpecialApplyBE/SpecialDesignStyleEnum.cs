using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE
{
    /// <summary>
    /// 可扩展枚举: 专柜设计风格 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class SpecialDesignStyleEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialDesignStyleEnum");
        #region ctor & cctor 
        static SpecialDesignStyleEnum()
        {
            InitData();
        }
        private SpecialDesignStyleEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private SpecialDesignStyleEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,SpecialDesignStyleEnum>();
            blueSpecial = new SpecialDesignStyleEnum(1,"BlueSpecial") ;
            innerEnums.Add(1,blueSpecial) ;
            whiteSpecial = new SpecialDesignStyleEnum(2,"WhiteSpecial") ;
            innerEnums.Add(2,whiteSpecial) ;
            empty = new SpecialDesignStyleEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static SpecialDesignStyleEnum empty;
        public static SpecialDesignStyleEnum Empty
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
        			case "BlueSpecial":
        				return this.Res_BlueSpecial; 
        			case "WhiteSpecial":
        				return this.Res_WhiteSpecial; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static SpecialDesignStyleEnum blueSpecial ;
        /// <summary>
        /// 枚举值: 蓝色专柜方案  Value:1  
        /// 专柜设计风格.Misc.蓝色专柜方案
        /// </summary>
        public static SpecialDesignStyleEnum BlueSpecial
        {
            get
            {
                return  blueSpecial ;
            }
        }
        private static SpecialDesignStyleEnum whiteSpecial ;
        /// <summary>
        /// 枚举值: 白色专柜方案  Value:2  
        /// 专柜设计风格.Misc.白色专柜方案
        /// </summary>
        public static SpecialDesignStyleEnum WhiteSpecial
        {
            get
            {
                return  whiteSpecial ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, SpecialDesignStyleEnum> innerEnums;
        /// <summary>
        /// Get SpecialDesignStyleEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<SpecialDesignStyleEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get SpecialDesignStyleEnum By Value 
        /// </summary>
        public static SpecialDesignStyleEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						SpecialDesignStyleEnum newValue = new SpecialDesignStyleEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get SpecialDesignStyleEnum By Value 
        /// </summary>
        public static SpecialDesignStyleEnum GetFromValue(object value)
        {
			if (value == null)
				return SpecialDesignStyleEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get SpecialDesignStyleEnum By Name 
        /// </summary>
        public static SpecialDesignStyleEnum GetFromName(string name)
        {
            foreach (SpecialDesignStyleEnum obj in innerEnums.Values)
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
		/// 专柜设计风格的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 专柜设计风格的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialDesignStyleEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_BlueSpecial　{ get {return EnumRes.GetResource("BlueSpecial");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_WhiteSpecial　{ get {return EnumRes.GetResource("WhiteSpecial");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialDesignStyleEnum";　}　}

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