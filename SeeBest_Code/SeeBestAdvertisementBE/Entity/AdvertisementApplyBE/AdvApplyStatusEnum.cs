using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE
{
    /// <summary>
    /// 可扩展枚举: 广告申请单状态枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class AdvApplyStatusEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyStatusEnum");
        #region ctor & cctor 
        static AdvApplyStatusEnum()
        {
            InitData();
        }
        private AdvApplyStatusEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private AdvApplyStatusEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,AdvApplyStatusEnum>();
            openL = new AdvApplyStatusEnum(0,"OpenL") ;
            innerEnums.Add(0,openL) ;
            approving = new AdvApplyStatusEnum(1,"Approving") ;
            innerEnums.Add(1,approving) ;
            approved = new AdvApplyStatusEnum(2,"Approved") ;
            innerEnums.Add(2,approved) ;
            empty = new AdvApplyStatusEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static AdvApplyStatusEnum empty;
        public static AdvApplyStatusEnum Empty
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
        			case "OpenL":
        				return this.Res_OpenL; 
        			case "Approving":
        				return this.Res_Approving; 
        			case "Approved":
        				return this.Res_Approved; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static AdvApplyStatusEnum openL ;
        /// <summary>
        /// 枚举值: 开立  Value:0  
        /// 广告申请单状态枚举.Misc.开立
        /// </summary>
        public static AdvApplyStatusEnum OpenL
        {
            get
            {
                return  openL ;
            }
        }
        private static AdvApplyStatusEnum approving ;
        /// <summary>
        /// 枚举值: 审核中  Value:1  
        /// 广告申请单状态枚举.Misc.审核中
        /// </summary>
        public static AdvApplyStatusEnum Approving
        {
            get
            {
                return  approving ;
            }
        }
        private static AdvApplyStatusEnum approved ;
        /// <summary>
        /// 枚举值: 审核  Value:2  
        /// 广告申请单状态枚举.Misc.审核
        /// </summary>
        public static AdvApplyStatusEnum Approved
        {
            get
            {
                return  approved ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, AdvApplyStatusEnum> innerEnums;
        /// <summary>
        /// Get AdvApplyStatusEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<AdvApplyStatusEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get AdvApplyStatusEnum By Value 
        /// </summary>
        public static AdvApplyStatusEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						AdvApplyStatusEnum newValue = new AdvApplyStatusEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get AdvApplyStatusEnum By Value 
        /// </summary>
        public static AdvApplyStatusEnum GetFromValue(object value)
        {
			if (value == null)
				return AdvApplyStatusEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get AdvApplyStatusEnum By Name 
        /// </summary>
        public static AdvApplyStatusEnum GetFromName(string name)
        {
            foreach (AdvApplyStatusEnum obj in innerEnums.Values)
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
		/// 广告申请单状态枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 广告申请单状态枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyStatusEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_OpenL　{ get {return EnumRes.GetResource("OpenL");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Approving　{ get {return EnumRes.GetResource("Approving");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Approved　{ get {return EnumRes.GetResource("Approved");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE.AdvApplyStatusEnum";　}　}

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