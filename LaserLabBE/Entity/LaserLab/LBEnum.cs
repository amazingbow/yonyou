using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab
{
    /// <summary>
    /// 可扩展枚举: 镭射标状态 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class LBEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LBEnum");
        #region ctor & cctor 
        static LBEnum()
        {
            InitData();
        }
        private LBEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private LBEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,LBEnum>();
            master = new LBEnum(0,"Master") ;
            innerEnums.Add(0,master) ;
            goldOil = new LBEnum(1,"GoldOil") ;
            innerEnums.Add(1,goldOil) ;
            packing = new LBEnum(2,"Packing") ;
            innerEnums.Add(2,packing) ;
            shipment = new LBEnum(3,"Shipment") ;
            innerEnums.Add(3,shipment) ;
            scrap = new LBEnum(4,"Scrap") ;
            innerEnums.Add(4,scrap) ;
            empty = new LBEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static LBEnum empty;
        public static LBEnum Empty
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
        			case "Master":
        				return this.Res_Master; 
        			case "GoldOil":
        				return this.Res_GoldOil; 
        			case "Packing":
        				return this.Res_Packing; 
        			case "Shipment":
        				return this.Res_Shipment; 
        			case "Scrap":
        				return this.Res_Scrap; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static LBEnum master ;
        /// <summary>
        /// 枚举值: 物料  Value:0  
        /// 镭射标状态.Misc.物料
        /// </summary>
        public static LBEnum Master
        {
            get
            {
                return  master ;
            }
        }
        private static LBEnum goldOil ;
        /// <summary>
        /// 枚举值: 金油  Value:1  
        /// 镭射标状态.Misc.金油
        /// </summary>
        public static LBEnum GoldOil
        {
            get
            {
                return  goldOil ;
            }
        }
        private static LBEnum packing ;
        /// <summary>
        /// 枚举值: 包装  Value:2  
        /// 镭射标状态.Misc.包装
        /// </summary>
        public static LBEnum Packing
        {
            get
            {
                return  packing ;
            }
        }
        private static LBEnum shipment ;
        /// <summary>
        /// 枚举值: 出货  Value:3  
        /// 镭射标状态.Misc.出货
        /// </summary>
        public static LBEnum Shipment
        {
            get
            {
                return  shipment ;
            }
        }
        private static LBEnum scrap ;
        /// <summary>
        /// 枚举值: 报废  Value:4  
        /// 镭射标状态.Misc.报废
        /// </summary>
        public static LBEnum Scrap
        {
            get
            {
                return  scrap ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, LBEnum> innerEnums;
        /// <summary>
        /// Get LBEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<LBEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get LBEnum By Value 
        /// </summary>
        public static LBEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						LBEnum newValue = new LBEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get LBEnum By Value 
        /// </summary>
        public static LBEnum GetFromValue(object value)
        {
			if (value == null)
				return LBEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get LBEnum By Name 
        /// </summary>
        public static LBEnum GetFromName(string name)
        {
            foreach (LBEnum obj in innerEnums.Values)
            {
                if (obj.Name == name)
                    return obj;
            }
            //don't need modify to return a Default Value .
            return null;
        }
        #endregion 

		/// <summary>
		/// 可扩展枚举管理器
		/// </summary>
		[System.Obsolete("不再使用,枚举增删改接口由元数据服务提供.")]
        public static class ExtendManager
        {
            #region Common Method Operator ...
            /// <summary>
            /// 添加新枚举项
            /// </summary>
            [System.Obsolete("不再使用,新接口待提供.")]
            public static void NewValue(string name, Int32 value, string displayName, string description)
            {
                //EnumValue newValue = innerExtendableEnum.NewValue(name, value.ToString(), displayName, description);
                ////处理枚举项已经存在的情况下,比如自动创建的无name枚举项.
                //if (innerEnums.ContainsKey(value))
                //{
                //    innerEnums[value].currentValue.Name = name;
                //    innerEnums[value].currentValue.DisplayName = displayName;
                //    innerEnums[value].currentValue.Description = description;
                //}
                //else
                //    innerEnums.Add(value, new LBEnum(newValue));
            }

            /// <summary>
            /// 删除枚举项
            /// </summary>
            [System.Obsolete("不再使用,新接口待提供.")]
            public static void DeleteValue(LBEnum value)
            {
                //innerExtendableEnum.DeleteValue(value.Name);
                //innerEnums.Remove(value.Value);
            }
            #endregion
        }

		#region ModelResource
		/// <summary>
		/// 镭射标状态的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 镭射标状态的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LBEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Master　{ get {return EnumRes.GetResource("Master");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_GoldOil　{ get {return EnumRes.GetResource("GoldOil");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Packing　{ get {return EnumRes.GetResource("Packing");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Shipment　{ get {return EnumRes.GetResource("Shipment");}　}
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
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab.LBEnum";　}　}

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