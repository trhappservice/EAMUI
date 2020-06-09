using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EAMUI.Models.Chart;

namespace EAMUI.Common
{
    public class util
    {
        public static string getEmailFromName(string username)
        {
            string result = username.Replace(" ", ".");
            result = result.ToLower();
            result += "@richmondhill.ca";
            return result;
        }

        public static double getTotalCost(string costYear, List<YearCost> resultList)
        {
            double result = 0.0;
            /**for (int i=0; i<resultList.Count;i++)
            {
                if (resultList[i].costYear.Equals(costYear))
                {
                    result += resultList[i].cost;
                }
            }**/
            foreach(YearCost tmp in resultList)
            {
                if (tmp.costYear.Equals(costYear))
                {
                    result += tmp.cost;
                }
            }
            return result;
        }
    }
}