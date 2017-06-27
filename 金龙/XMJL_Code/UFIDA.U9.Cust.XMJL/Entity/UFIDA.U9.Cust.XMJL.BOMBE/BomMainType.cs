using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.XMJL.BommBE
{
    /// <summary>
    /// 可扩展枚举: 缺件发料主表发料类型 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class BomMainType
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.XMJL.BommBE.BomMainType");
        #region ctor & cctor 
        static BomMainType()
        {
            InitData();
        }
        private BomMainType(int eValue)
        {
            this.currentValue = eValue;
        }
        private BomMainType(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,BomMainType>();
            batch = new BomMainType(1,"Batch") ;
            innerEnums.Add(1,batch) ;
            rtn = new BomMainType(2,"Rtn") ;
            innerEnums.Add(2,rtn) ;
            empty = new BomMainType(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static BomMainType empty;
        public static BomMainType Empty
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
        			case "Batch":
        				return this.Res_Batch; 
        			case "Rtn":
        				return this.Res_Rtn; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static BomMainType batch ;
        /// <summary>
        /// 枚举值: 批量发料  Value:1  
        /// 缺件发料主表发料类型.Misc.批量发料
        /// </summary>
        public static BomMainType Batch
        {
            get
            {
                return  batch ;
            }
        }
        private static BomMainType rtn ;
        /// <summary>
        /// 枚举值: 退库发料  Value:2  
        /// 缺件发料主表发料类型.Misc.退库发料
        /// </summary>
        public static BomMainType Rtn
        {
            get
            {
                return  rtn ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, BomMainType> innerEnums;
        /// <summary>
        /// Get BomMainType's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<BomMainType> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get BomMainType By Value 
        /// </summary>
        public static BomMainType GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						BomMainType newValue = new BomMainType(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get BomMainType By Value 
        /// </summary>
        public static BomMainType GetFromValue(object value)
        {
			if (value == null)
				return BomMainType.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get BomMainType By Name 
        /// </summary>
        public static BomMainType GetFromName(string name)
        {
            foreach (BomMainType obj in innerEnums.Values)
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
		/// 缺件发料主表发料类型的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 缺件发料主表发料类型的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.XMJL.BommBE.BomMainType")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Batch　{ get {return EnumRes.GetResource("Batch");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Rtn　{ get {return EnumRes.GetResource("Rtn");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.XMJL.BommBE.BomMainType";　}　}

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