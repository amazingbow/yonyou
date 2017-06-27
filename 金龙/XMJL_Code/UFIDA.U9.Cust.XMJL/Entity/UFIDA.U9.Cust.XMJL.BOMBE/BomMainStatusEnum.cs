using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.XMJL.BommBE
{
    /// <summary>
    /// 可扩展枚举: 缺件发料主表状态 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class BomMainStatusEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.XMJL.BommBE.BomMainStatusEnum");
        #region ctor & cctor 
        static BomMainStatusEnum()
        {
            InitData();
        }
        private BomMainStatusEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private BomMainStatusEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,BomMainStatusEnum>();
            unDisburse = new BomMainStatusEnum(1,"UnDisburse") ;
            innerEnums.Add(1,unDisburse) ;
            disbursed = new BomMainStatusEnum(2,"Disbursed") ;
            innerEnums.Add(2,disbursed) ;
            report = new BomMainStatusEnum(3,"Report") ;
            innerEnums.Add(3,report) ;
            empty = new BomMainStatusEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static BomMainStatusEnum empty;
        public static BomMainStatusEnum Empty
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
        			case "UnDisburse":
        				return this.Res_UnDisburse; 
        			case "Disbursed":
        				return this.Res_Disbursed; 
        			case "Report":
        				return this.Res_Report; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static BomMainStatusEnum unDisburse ;
        /// <summary>
        /// 枚举值: 未发料  Value:1  
        /// 缺件发料主表状态.Misc.未发料
        /// </summary>
        public static BomMainStatusEnum UnDisburse
        {
            get
            {
                return  unDisburse ;
            }
        }
        private static BomMainStatusEnum disbursed ;
        /// <summary>
        /// 枚举值: 已发料  Value:2  
        /// 缺件发料主表状态.Misc.已发料
        /// </summary>
        public static BomMainStatusEnum Disbursed
        {
            get
            {
                return  disbursed ;
            }
        }
        private static BomMainStatusEnum report ;
        /// <summary>
        /// 枚举值: 已报告  Value:3  
        /// 缺件发料主表状态.Misc.已报告
        /// </summary>
        public static BomMainStatusEnum Report
        {
            get
            {
                return  report ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, BomMainStatusEnum> innerEnums;
        /// <summary>
        /// Get BomMainStatusEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<BomMainStatusEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get BomMainStatusEnum By Value 
        /// </summary>
        public static BomMainStatusEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						BomMainStatusEnum newValue = new BomMainStatusEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get BomMainStatusEnum By Value 
        /// </summary>
        public static BomMainStatusEnum GetFromValue(object value)
        {
			if (value == null)
				return BomMainStatusEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get BomMainStatusEnum By Name 
        /// </summary>
        public static BomMainStatusEnum GetFromName(string name)
        {
            foreach (BomMainStatusEnum obj in innerEnums.Values)
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
		/// 缺件发料主表状态的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 缺件发料主表状态的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.XMJL.BommBE.BomMainStatusEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_UnDisburse　{ get {return EnumRes.GetResource("UnDisburse");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Disbursed　{ get {return EnumRes.GetResource("Disbursed");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Report　{ get {return EnumRes.GetResource("Report");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.XMJL.BommBE.BomMainStatusEnum";　}　}

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