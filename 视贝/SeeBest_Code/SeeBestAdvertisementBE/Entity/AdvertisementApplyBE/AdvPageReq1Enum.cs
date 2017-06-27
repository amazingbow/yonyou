using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE
{
    /// <summary>
    /// 可扩展枚举: 版面要求1 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class AdvPageReq1Enum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvPageReq1Enum");
        #region ctor & cctor 
        static AdvPageReq1Enum()
        {
            InitData();
        }
        private AdvPageReq1Enum(int eValue)
        {
            this.currentValue = eValue;
        }
        private AdvPageReq1Enum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,AdvPageReq1Enum>();
            content1 = new AdvPageReq1Enum(0,"Content1") ;
            innerEnums.Add(0,content1) ;
            content2 = new AdvPageReq1Enum(1,"Content2") ;
            innerEnums.Add(1,content2) ;
            empty = new AdvPageReq1Enum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static AdvPageReq1Enum empty;
        public static AdvPageReq1Enum Empty
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
        			case "Content1":
        				return this.Res_Content1; 
        			case "Content2":
        				return this.Res_Content2; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static AdvPageReq1Enum content1 ;
        /// <summary>
        /// 枚举值: 客户内容与公司广告融合  Value:0  
        /// 版面要求1.Misc.客户内容与公司广告融合
        /// </summary>
        public static AdvPageReq1Enum Content1
        {
            get
            {
                return  content1 ;
            }
        }
        private static AdvPageReq1Enum content2 ;
        /// <summary>
        /// 枚举值: 客户内容与公司广告不融合  Value:1  
        /// 版面要求1.Misc.客户内容与公司广告不融合
        /// </summary>
        public static AdvPageReq1Enum Content2
        {
            get
            {
                return  content2 ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, AdvPageReq1Enum> innerEnums;
        /// <summary>
        /// Get AdvPageReq1Enum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<AdvPageReq1Enum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get AdvPageReq1Enum By Value 
        /// </summary>
        public static AdvPageReq1Enum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						AdvPageReq1Enum newValue = new AdvPageReq1Enum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get AdvPageReq1Enum By Value 
        /// </summary>
        public static AdvPageReq1Enum GetFromValue(object value)
        {
			if (value == null)
				return AdvPageReq1Enum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get AdvPageReq1Enum By Name 
        /// </summary>
        public static AdvPageReq1Enum GetFromName(string name)
        {
            foreach (AdvPageReq1Enum obj in innerEnums.Values)
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
		/// 版面要求1的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 版面要求1的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvPageReq1Enum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Content1　{ get {return EnumRes.GetResource("Content1");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Content2　{ get {return EnumRes.GetResource("Content2");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvPageReq1Enum";　}　}

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