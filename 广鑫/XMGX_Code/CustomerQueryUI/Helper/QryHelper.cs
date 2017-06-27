using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.Util.Context;

namespace UFIDA.U9.Cust.FJGX.UIHelper
{
    public static class QryHelper
    {
        /// <summary>
        ///     将设计态的过滤条件加入查询条件中
        /// </summary>
        /// <returns></returns>
        public static string BeforeGetModelFilter(IUIView mainView)
        {
            string modelOql =  mainView.CurrentFilter.OriginalOPath;
            foreach (IUIParameter para in mainView.CurrentFilter.Parameters)
            {
                if (!string.IsNullOrEmpty(mainView.CurrentFilter.OriginalOPath) &&
                    para.DataValue != null && !string.IsNullOrEmpty(para.DataValue.ToString()))
                {
                    switch (para.DataType)
                    {
                        case DbType.Int64:
                            modelOql = modelOql.Replace(para.Name, para.DataValue.ToString());
                            break;
                        case DbType.String:
                            modelOql = modelOql.Replace(para.Name, "'" + para.DataValue + "'");
                            break;
                        case DbType.DateTime:
                            modelOql = modelOql.Replace(para.Name, "'" + para.DataValue + "'");
                            break;
                        case DbType.Boolean:
                            modelOql = modelOql.Replace(para.Name, "'" + para.DataValue + "'");
                            break;
                        case DbType.Date:
                            modelOql = modelOql.Replace(para.Name, "'" + para.DataValue + "'");
                            break;
                        default:
                            modelOql = modelOql.Replace(para.Name, para.DataValue.ToString());
                            break;
                    }
                }
                else if (string.IsNullOrEmpty(mainView.CurrentFilter.OriginalOPath))
                {
                    return string.Empty;
                }
                else if (para.DataValue == null)
                {
                    return " 1=0 ";
                }
            }

            if (modelOql.IndexOf("#Context.Culture#") >= 0)
            {
                modelOql = modelOql.Replace("#Context.Culture#", "'" + PlatformContext.Current.Culture + "'");
            }
            if (modelOql.IndexOf("#Context.OrgID#") >= 0)
            {
                modelOql = modelOql.Replace("#Context.OrgID#", PlatformContext.Current.OrgID);
            }
            if (modelOql.IndexOf("#Context.DateTime#") >= 0)
            {
                modelOql = modelOql.Replace("#Context.DateTime#", "'" + PlatformContext.Current.DateTime + "'");
            }
            return modelOql;
        }
    }
}