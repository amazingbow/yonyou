using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace AdvertisementApplyBE
{
    /// <summary>
    /// 可扩展枚举: 版面类型 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class AdvDisplayTypeEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("AdvertisementApplyBE.AdvDisplayTypeEnum");
        #region ctor & cctor 
        static AdvDisplayTypeEnum()
        {
            InitData();
        }
        private AdvDisplayTypeEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private AdvDisplayTypeEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,AdvDisplayTypeEnum>();
            h = new AdvDisplayTypeEnum(1,"h") ;
            innerEnums.Add(1,h) ;
            v = new AdvDisplayTypeEnum(2,"V") ;
            innerEnums.Add(2,v) ;
            s = new AdvDisplayTypeEnum(3,"S") ;
            innerEnums.Add(3,s) ;
            empty = new AdvDisplayTypeEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static AdvDisplayTypeEnum empty;
        public static AdvDisplayTypeEnum Empty
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
        			case "H":
        				return this.Res_H; 
        			case "V":
        				return this.Res_V; 
        			case "S":
        				return this.Res_S; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static AdvDisplayTypeEnum h ;
        /// <summary>
        /// 枚举值: 横版版面  Value:1  
        /// 版面类型.Misc.横版版面
        /// </summary>
        public static AdvDisplayTypeEnum H
        {
            get
            {
                return  h ;
            }
        }
        private static AdvDisplayTypeEnum v ;
        /// <summary>
        /// 枚举值: 竖版版面  Value:2  
        /// 版面类型.Misc.竖版版面
        /// </summary>
        public static AdvDisplayTypeEnum V
        {
            get
            {
                return  v ;
            }
        }
        private static AdvDisplayTypeEnum s ;
        /// <summary>
        /// 枚举值: 方形版面  Value:3  
        /// 版面类型.Misc.方形版面
        /// </summary>
        public static AdvDisplayTypeEnum S
        {
            get
            {
                return  s ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, AdvDisplayTypeEnum> innerEnums;
        /// <summary>
        /// Get AdvDisplayTypeEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<AdvDisplayTypeEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get AdvDisplayTypeEnum By Value 
        /// </summary>
        public static AdvDisplayTypeEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						AdvDisplayTypeEnum newValue = new AdvDisplayTypeEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get AdvDisplayTypeEnum By Value 
        /// </summary>
        public static AdvDisplayTypeEnum GetFromValue(object value)
        {
			if (value == null)
				return AdvDisplayTypeEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get AdvDisplayTypeEnum By Name 
        /// </summary>
        public static AdvDisplayTypeEnum GetFromName(string name)
        {
            foreach (AdvDisplayTypeEnum obj in innerEnums.Values)
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
		/// 版面类型的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 版面类型的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("AdvertisementApplyBE.AdvDisplayTypeEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_H　{ get {return EnumRes.GetResource("h");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_V　{ get {return EnumRes.GetResource("V");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_S　{ get {return EnumRes.GetResource("S");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "AdvertisementApplyBE.AdvDisplayTypeEnum";　}　}

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