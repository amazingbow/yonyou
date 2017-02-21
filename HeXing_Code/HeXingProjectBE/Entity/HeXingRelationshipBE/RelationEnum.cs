using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE
{
    /// <summary>
    /// 可扩展枚举: 对照类型 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class RelationEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum");
        #region ctor & cctor 
        static RelationEnum()
        {
            InitData();
        }
        private RelationEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private RelationEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,RelationEnum>();
            currency = new RelationEnum(1,"Currency") ;
            innerEnums.Add(1,currency) ;
            customer = new RelationEnum(2,"Customer") ;
            innerEnums.Add(2,customer) ;
            supplier = new RelationEnum(3,"Supplier") ;
            innerEnums.Add(3,supplier) ;
            dept = new RelationEnum(4,"Dept") ;
            innerEnums.Add(4,dept) ;
            staff = new RelationEnum(5,"Staff") ;
            innerEnums.Add(5,staff) ;
            cash = new RelationEnum(6,"Cash") ;
            innerEnums.Add(6,cash) ;
            org = new RelationEnum(7,"Org") ;
            innerEnums.Add(7,org) ;
            voucherCategory = new RelationEnum(8,"VoucherCategory") ;
            innerEnums.Add(8,voucherCategory) ;
            project = new RelationEnum(9,"Project") ;
            innerEnums.Add(9,project) ;
            account = new RelationEnum(10,"Account") ;
            innerEnums.Add(10,account) ;
            empty = new RelationEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static RelationEnum empty;
        public static RelationEnum Empty
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
        			case "Currency":
        				return this.Res_Currency; 
        			case "Customer":
        				return this.Res_Customer; 
        			case "Supplier":
        				return this.Res_Supplier; 
        			case "Dept":
        				return this.Res_Dept; 
        			case "Staff":
        				return this.Res_Staff; 
        			case "Cash":
        				return this.Res_Cash; 
        			case "Org":
        				return this.Res_Org; 
        			case "VoucherCategory":
        				return this.Res_VoucherCategory; 
        			case "Project":
        				return this.Res_Project; 
        			case "Account":
        				return this.Res_Account; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static RelationEnum currency ;
        /// <summary>
        /// 枚举值: 币种  Value:1  
        /// 对照类型.Misc.币种
        /// </summary>
        public static RelationEnum Currency
        {
            get
            {
                return  currency ;
            }
        }
        private static RelationEnum customer ;
        /// <summary>
        /// 枚举值: 客户  Value:2  
        /// 对照类型.Misc.客户
        /// </summary>
        public static RelationEnum Customer
        {
            get
            {
                return  customer ;
            }
        }
        private static RelationEnum supplier ;
        /// <summary>
        /// 枚举值: 供应商  Value:3  
        /// 对照类型.Misc.供应商
        /// </summary>
        public static RelationEnum Supplier
        {
            get
            {
                return  supplier ;
            }
        }
        private static RelationEnum dept ;
        /// <summary>
        /// 枚举值: 部门  Value:4  
        /// 对照类型.Misc.部门
        /// </summary>
        public static RelationEnum Dept
        {
            get
            {
                return  dept ;
            }
        }
        private static RelationEnum staff ;
        /// <summary>
        /// 枚举值: 员工  Value:5  
        /// 对照类型.Misc.员工
        /// </summary>
        public static RelationEnum Staff
        {
            get
            {
                return  staff ;
            }
        }
        private static RelationEnum cash ;
        /// <summary>
        /// 枚举值: 现金流  Value:6  
        /// 对照类型.Misc.现金流
        /// </summary>
        public static RelationEnum Cash
        {
            get
            {
                return  cash ;
            }
        }
        private static RelationEnum org ;
        /// <summary>
        /// 枚举值: 组织  Value:7  
        /// 对照类型.Misc.组织
        /// </summary>
        public static RelationEnum Org
        {
            get
            {
                return  org ;
            }
        }
        private static RelationEnum voucherCategory ;
        /// <summary>
        /// 枚举值: 凭证类型  Value:8  
        /// 对照类型.Misc.凭证类型
        /// </summary>
        public static RelationEnum VoucherCategory
        {
            get
            {
                return  voucherCategory ;
            }
        }
        private static RelationEnum project ;
        /// <summary>
        /// 枚举值: 项目  Value:9  
        /// 对照类型.Misc.项目
        /// </summary>
        public static RelationEnum Project
        {
            get
            {
                return  project ;
            }
        }
        private static RelationEnum account ;
        /// <summary>
        /// 枚举值: 科目  Value:10  
        /// 对照类型.Misc.科目
        /// </summary>
        public static RelationEnum Account
        {
            get
            {
                return  account ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, RelationEnum> innerEnums;
        /// <summary>
        /// Get RelationEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<RelationEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get RelationEnum By Value 
        /// </summary>
        public static RelationEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						RelationEnum newValue = new RelationEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get RelationEnum By Value 
        /// </summary>
        public static RelationEnum GetFromValue(object value)
        {
			if (value == null)
				return RelationEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get RelationEnum By Name 
        /// </summary>
        public static RelationEnum GetFromName(string name)
        {
            foreach (RelationEnum obj in innerEnums.Values)
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
		/// 对照类型的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 对照类型的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Currency　{ get {return EnumRes.GetResource("Currency");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Customer　{ get {return EnumRes.GetResource("Customer");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Supplier　{ get {return EnumRes.GetResource("Supplier");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Dept　{ get {return EnumRes.GetResource("Dept");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Staff　{ get {return EnumRes.GetResource("Staff");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Cash　{ get {return EnumRes.GetResource("Cash");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Org　{ get {return EnumRes.GetResource("Org");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_VoucherCategory　{ get {return EnumRes.GetResource("VoucherCategory");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Project　{ get {return EnumRes.GetResource("Project");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Account　{ get {return EnumRes.GetResource("Account");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RelationEnum";　}　}

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