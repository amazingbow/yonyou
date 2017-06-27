using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFIDA.U9.Cust.XMJL.BommBE;
using System.Text.RegularExpressions;

namespace UFIDA.U9.Cust.XMJLBomOpBP
{
    public static class OQlAnalysis
    {
        public static Cust_Xmjl_MO_BomHead.EntityList GetBomHeadData(string opath, string ids)
        {
            //Regex.Matches(opath, "Cust_Xmjl_MO_BomHead");
            Regex reg = new Regex(@"\(Cust_Xmjl_MO_BomHead.*?\)");
            // 计算列
            Regex regCalc = new Regex(@"\(\(Cust_Xmjl_MO_BomHead.*?\d\) ");
            Regex regCalc1 = new Regex(@"\(\(Cust_Xmjl_MO_BomHead.*?\) \)");
            string headOpath = string.Empty;
            string deleteCal = opath;
            foreach (Match item in regCalc.Matches(opath))
            {
                headOpath += item.Value.Replace("Cust_Xmjl_MO_BomHead.", "") + " and ";
                deleteCal = deleteCal.Replace(item.Value, "");
            }
            foreach (Match item in regCalc1.Matches(deleteCal))
            {
                headOpath += item.Value.Replace("Cust_Xmjl_MO_BomHead.", "").TrimEnd(')') + " and ";
                deleteCal = deleteCal.Replace(item.Value, "");
            }
            foreach (Match item in reg.Matches(deleteCal))
            {
                Regex regCont = new Regex(@"\(");
                Regex regCont1 = new Regex(@"\)");
                string calc = item.Value;
                if (calc.Contains("Item."))
                {
                    if (regCont.Matches(calc).Count != regCont1.Matches(calc).Count)
                    {
                        calc += "')";
                    }
                }
                if (calc.Contains("in"))
                {
                    headOpath += calc.Replace("Cust_Xmjl_MO_BomHead.", "") + ") and ";
                }
                else
                {
                    headOpath += calc.Replace("Cust_Xmjl_MO_BomHead.", "") + " and ";
                }

            }
            headOpath += " Cust_Xmjl_MO_BomMain in (" + ids + ")";
            return Cust_Xmjl_MO_BomHead.Finder.FindAll(headOpath, null);
        }
    }
}
