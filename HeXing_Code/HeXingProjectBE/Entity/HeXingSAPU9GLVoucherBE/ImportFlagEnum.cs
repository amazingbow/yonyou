using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE
{
    /// <summary>
    /// 可扩展枚举: 导入标志枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class ImportFlagEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.ImportFlagEnum");
        #region ctor & cctor 
        static ImportFlagEnum()
        {
            InitData();
        }
        private ImportFlagEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private ImportFlagEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,ImportFlagEnum>();
            notProcess = new ImportFlagEnum(0,"NotProcess") ;
            innerEnums.Add(0,notProcess) ;
            importSuccess = new ImportFlagEnum(1,"ImportSuccess") ;
            innerEnums.Add(1,importSuccess) ;
            importFailed = new ImportFlagEnum(2,"ImportFailed") ;
            innerEnums.Add(2,importFailed) ;
            empty = new ImportFlagEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static ImportFlagEnum empty;
        public static ImportFlagEnum Empty
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
        			case "NotProcess":
        				return this.Res_NotProcess; 
        			case "ImportSuccess":
        				return this.Res_ImportSuccess; 
        			case "ImportFailed":
        				return this.Res_ImportFailed; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static ImportFlagEnum notProcess ;
        /// <summary>
        /// 枚举值: 数据未处理  Value:0  
        /// 导入标志枚举.Misc.数据未处理
        /// </summary>
        public static ImportFlagEnum NotProcess
        {
            get
            {
                return  notProcess ;
            }
        }
        private static ImportFlagEnum importSuccess ;
        /// <summary>
        /// 枚举值: 导入成功  Value:1  
        /// 导入标志枚举.Misc.导入成功
        /// </summary>
        public static ImportFlagEnum ImportSuccess
        {
            get
            {
                return  importSuccess ;
            }
        }
        private static ImportFlagEnum importFailed ;
        /// <summary>
        /// 枚举值: 导入失败  Value:2  
        /// 导入标志枚举.Misc.导入失败
        /// </summary>
        public static ImportFlagEnum ImportFailed
        {
            get
            {
                return  importFailed ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, ImportFlagEnum> innerEnums;
        /// <summary>
        /// Get ImportFlagEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<ImportFlagEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get ImportFlagEnum By Value 
        /// </summary>
        public static ImportFlagEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						ImportFlagEnum newValue = new ImportFlagEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get ImportFlagEnum By Value 
        /// </summary>
        public static ImportFlagEnum GetFromValue(object value)
        {
			if (value == null)
				return ImportFlagEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get ImportFlagEnum By Name 
        /// </summary>
        public static ImportFlagEnum GetFromName(string name)
        {
            foreach (ImportFlagEnum obj in innerEnums.Values)
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
		/// 导入标志枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 导入标志枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.ImportFlagEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_NotProcess　{ get {return EnumRes.GetResource("NotProcess");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_ImportSuccess　{ get {return EnumRes.GetResource("ImportSuccess");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_ImportFailed　{ get {return EnumRes.GetResource("ImportFailed");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.HeXingProjectBE.HeXingSAPU9GLVoucherBE.ImportFlagEnum";　}　}

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