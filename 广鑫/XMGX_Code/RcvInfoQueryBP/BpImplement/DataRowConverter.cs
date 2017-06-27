using System;
using System.Data;

namespace UIFIA.U9.Cust.FJGX.RcvInfoQueryBP.PubBase
{
    /// <summary>
    ///     DataRow值转化器
    /// </summary>
    public static class DataRowConverter
    {
        /// <summary>
        ///     DataRow字段是否为DBNull或string.Empty
        /// </summary>
        /// <param name="dataRow"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static bool IsDBNullOrEmpty(DataRow dataRow, string columnName)
        {
            return IsDBNullOrEmpty(dataRow[columnName]);
        }

        /// <summary>
        ///     DataRow字段是否为DBNull或string.Empty
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsDBNullOrEmpty(object value)
        {
            if (Convert.IsDBNull(value)) return true;
            return value.ToString() == string.Empty;
        }

        public static long AsLong(DataRow dataRow, string columnName)
        {
            return AsLong(dataRow, columnName, default(long));
        }

        public static long AsLong(DataRow dataRow, string columnName, long defaultValue)
        {
            object value = dataRow[columnName];
            return IsDBNullOrEmpty(value) ? defaultValue : Convert.ToInt64(value);
        }

        public static long? AsNullableLong(DataRow dataRow, string columnName)
        {
            object value = dataRow[columnName];
            return IsDBNullOrEmpty(value) ? default(long?) : Convert.ToInt64(value);
        }

        public static decimal AsDecimal(DataRow dataRow, string columnName)
        {
            return AsDecimal(dataRow, columnName, default(decimal));
        }

        public static decimal AsDecimal(DataRow dataRow, string columnName, decimal defaultValue)
        {
            object value = dataRow[columnName];
            return IsDBNullOrEmpty(value) ? defaultValue : Convert.ToDecimal(value);
        }

        public static decimal? AsNullableDecimal(DataRow dataRow, string columnName)
        {
            object value = dataRow[columnName];
            return IsDBNullOrEmpty(value) ? default(decimal?) : Convert.ToDecimal(value);
        }

        public static string AsString(DataRow dataRow, string columnName)
        {
            return AsString(dataRow, columnName, string.Empty);
        }

        public static string AsString(DataRow dataRow, string columnName, string defaultValue)
        {
            object value = dataRow[columnName];
            return Convert.IsDBNull(value) ? defaultValue : value.ToString();
        }

        public static string AsNullableString(DataRow dataRow, string columnName)
        {
            return AsString(dataRow, columnName, default(string));
        }

        public static DateTime AsDateTime(DataRow dataRow, string columnName)
        {
            return AsDateTime(dataRow, columnName, default(DateTime));
        }

        public static DateTime AsDateTime(DataRow dataRow, string columnName, DateTime defaultValue)
        {
            object value = dataRow[columnName];
            return IsDBNullOrEmpty(value) ? defaultValue : Convert.ToDateTime(value);
        }

        public static DateTime? AsNullableDateTime(DataRow dataRow, string columnName)
        {
            object value = dataRow[columnName];
            return IsDBNullOrEmpty(value) ? default(DateTime?) : Convert.ToDateTime(value);
        }

        public static int AsInt(DataRow dataRow, string columnName)
        {
            return AsInt(dataRow, columnName, default(int));
        }

        public static int AsInt(DataRow dataRow, string columnName, int defaultValue)
        {
            object value = dataRow[columnName];
            return IsDBNullOrEmpty(value) ? defaultValue : Convert.ToInt32(value);
        }

        public static int? AsNullableInt(DataRow dataRow, string columnName)
        {
            object value = dataRow[columnName];
            return IsDBNullOrEmpty(value) ? default(int?) : Convert.ToInt32(value);
        }

        public static bool AsBool(DataRow dataRow, string columnName)
        {
            return AsBool(dataRow, columnName, default(bool));
        }

        public static bool AsBool(DataRow dataRow, string columnName, bool defaultValue)
        {
            object value = dataRow[columnName];
            return IsDBNullOrEmpty(value) ? defaultValue : Convert.ToBoolean(value);
        }

        public static bool? AsNullableBool(DataRow dataRow, string columnName)
        {
            object value = dataRow[columnName];
            return IsDBNullOrEmpty(value) ? default(bool?) : Convert.ToBoolean(value);
        }
    }
}