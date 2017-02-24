using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE
{
    /// <summary>
    /// 可扩展枚举: 栏目 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class ColumnEmun
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.ColumnEmun");
        #region ctor & cctor 
        static ColumnEmun()
        {
            InitData();
        }
        private ColumnEmun(int eValue)
        {
            this.currentValue = eValue;
        }
        private ColumnEmun(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,ColumnEmun>();
            lCode = new ColumnEmun(0,"LCode") ;
            innerEnums.Add(0,lCode) ;
            lName = new ColumnEmun(1,"LName") ;
            innerEnums.Add(1,lName) ;
            empty = new ColumnEmun(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static ColumnEmun empty;
        public static ColumnEmun Empty
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
        			case "LCode":
        				return this.Res_LCode; 
        			case "LName":
        				return this.Res_LName; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static ColumnEmun lCode ;
        /// <summary>
        /// 枚举值: 编码  Value:0  
        /// 栏目.Misc.编码
        /// </summary>
        public static ColumnEmun LCode
        {
            get
            {
                return  lCode ;
            }
        }
        private static ColumnEmun lName ;
        /// <summary>
        /// 枚举值: 名称  Value:1  
        /// 栏目.Misc.名称
        /// </summary>
        public static ColumnEmun LName
        {
            get
            {
                return  lName ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, ColumnEmun> innerEnums;
        /// <summary>
        /// Get ColumnEmun's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<ColumnEmun> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get ColumnEmun By Value 
        /// </summary>
        public static ColumnEmun GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						ColumnEmun newValue = new ColumnEmun(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get ColumnEmun By Value 
        /// </summary>
        public static ColumnEmun GetFromValue(object value)
        {
			if (value == null)
				return ColumnEmun.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get ColumnEmun By Name 
        /// </summary>
        public static ColumnEmun GetFromName(string name)
        {
            foreach (ColumnEmun obj in innerEnums.Values)
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
		/// 栏目的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 栏目的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.ColumnEmun")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_LCode　{ get {return EnumRes.GetResource("LCode");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_LName　{ get {return EnumRes.GetResource("LName");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.ColumnEmun";　}　}

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