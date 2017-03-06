using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE
{
    /// <summary>
    /// 可扩展枚举: 对照表状态枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class RefStatusEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RefStatusEnum");
        #region ctor & cctor 
        static RefStatusEnum()
        {
            InitData();
        }
        private RefStatusEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private RefStatusEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,RefStatusEnum>();
            oraginal = new RefStatusEnum(1,"Oraginal") ;
            innerEnums.Add(1,oraginal) ;
            approval = new RefStatusEnum(2,"Approval") ;
            innerEnums.Add(2,approval) ;
            used = new RefStatusEnum(3,"Used") ;
            innerEnums.Add(3,used) ;
            scrap = new RefStatusEnum(0,"Scrap") ;
            innerEnums.Add(0,scrap) ;
            empty = new RefStatusEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static RefStatusEnum empty;
        public static RefStatusEnum Empty
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
        			case "Oraginal":
        				return this.Res_Oraginal; 
        			case "Approval":
        				return this.Res_Approval; 
        			case "Used":
        				return this.Res_Used; 
        			case "Scrap":
        				return this.Res_Scrap; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static RefStatusEnum oraginal ;
        /// <summary>
        /// 枚举值: 初始状态  Value:1  
        /// 对照表状态枚举.Misc.初始状态
        /// </summary>
        public static RefStatusEnum Oraginal
        {
            get
            {
                return  oraginal ;
            }
        }
        private static RefStatusEnum approval ;
        /// <summary>
        /// 枚举值: 审核  Value:2  
        /// 对照表状态枚举.Misc.审核
        /// </summary>
        public static RefStatusEnum Approval
        {
            get
            {
                return  approval ;
            }
        }
        private static RefStatusEnum used ;
        /// <summary>
        /// 枚举值: 使用中  Value:3  
        /// 对照表状态枚举.Misc.使用中
        /// </summary>
        public static RefStatusEnum Used
        {
            get
            {
                return  used ;
            }
        }
        private static RefStatusEnum scrap ;
        /// <summary>
        /// 枚举值: 废弃  Value:0  
        /// 对照表状态枚举.Misc.废弃
        /// </summary>
        public static RefStatusEnum Scrap
        {
            get
            {
                return  scrap ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, RefStatusEnum> innerEnums;
        /// <summary>
        /// Get RefStatusEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<RefStatusEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get RefStatusEnum By Value 
        /// </summary>
        public static RefStatusEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						RefStatusEnum newValue = new RefStatusEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get RefStatusEnum By Value 
        /// </summary>
        public static RefStatusEnum GetFromValue(object value)
        {
			if (value == null)
				return RefStatusEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get RefStatusEnum By Name 
        /// </summary>
        public static RefStatusEnum GetFromName(string name)
        {
            foreach (RefStatusEnum obj in innerEnums.Values)
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
		/// 对照表状态枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 对照表状态枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RefStatusEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Oraginal　{ get {return EnumRes.GetResource("Oraginal");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Approval　{ get {return EnumRes.GetResource("Approval");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Used　{ get {return EnumRes.GetResource("Used");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Scrap　{ get {return EnumRes.GetResource("Scrap");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.HeXingProjectBE.HeXingRelationshipBE.RefStatusEnum";　}　}

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