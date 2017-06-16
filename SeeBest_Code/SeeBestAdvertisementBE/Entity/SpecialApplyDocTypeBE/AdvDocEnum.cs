using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE
{
    /// <summary>
    /// 可扩展枚举: 广告单据对象枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class AdvDocEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.AdvDocEnum");
        #region ctor & cctor 
        static AdvDocEnum()
        {
            InitData();
        }
        private AdvDocEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private AdvDocEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,AdvDocEnum>();
            specialDoc = new AdvDocEnum(0,"SpecialDoc") ;
            innerEnums.Add(0,specialDoc) ;
            advApplyDoc = new AdvDocEnum(1,"AdvApplyDoc") ;
            innerEnums.Add(1,advApplyDoc) ;
            advApproveDoc = new AdvDocEnum(2,"AdvApproveDoc") ;
            innerEnums.Add(2,advApproveDoc) ;
            empty = new AdvDocEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static AdvDocEnum empty;
        public static AdvDocEnum Empty
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
        			case "SpecialDoc":
        				return this.Res_SpecialDoc; 
        			case "AdvApplyDoc":
        				return this.Res_AdvApplyDoc; 
        			case "AdvApproveDoc":
        				return this.Res_AdvApproveDoc; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static AdvDocEnum specialDoc ;
        /// <summary>
        /// 枚举值: 专柜申请单单据  Value:0  
        /// 广告单据对象枚举.Misc.专柜申请单单据
        /// </summary>
        public static AdvDocEnum SpecialDoc
        {
            get
            {
                return  specialDoc ;
            }
        }
        private static AdvDocEnum advApplyDoc ;
        /// <summary>
        /// 枚举值: 广告申请单单据  Value:1  
        /// 广告单据对象枚举.Misc.广告申请单单据
        /// </summary>
        public static AdvDocEnum AdvApplyDoc
        {
            get
            {
                return  advApplyDoc ;
            }
        }
        private static AdvDocEnum advApproveDoc ;
        /// <summary>
        /// 枚举值: 广告核销单单据  Value:2  
        /// 广告单据对象枚举.Misc.广告核销单单据
        /// </summary>
        public static AdvDocEnum AdvApproveDoc
        {
            get
            {
                return  advApproveDoc ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, AdvDocEnum> innerEnums;
        /// <summary>
        /// Get AdvDocEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<AdvDocEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get AdvDocEnum By Value 
        /// </summary>
        public static AdvDocEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						AdvDocEnum newValue = new AdvDocEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get AdvDocEnum By Value 
        /// </summary>
        public static AdvDocEnum GetFromValue(object value)
        {
			if (value == null)
				return AdvDocEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get AdvDocEnum By Name 
        /// </summary>
        public static AdvDocEnum GetFromName(string name)
        {
            foreach (AdvDocEnum obj in innerEnums.Values)
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
		/// 广告单据对象枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 广告单据对象枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.AdvDocEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_SpecialDoc　{ get {return EnumRes.GetResource("SpecialDoc");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_AdvApplyDoc　{ get {return EnumRes.GetResource("AdvApplyDoc");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_AdvApproveDoc　{ get {return EnumRes.GetResource("AdvApproveDoc");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.AdvDocEnum";　}　}

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