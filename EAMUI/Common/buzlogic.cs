using EAMUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebGrease.Css.Ast.Selectors;

namespace EAMUI.Common
{
    public class buzlogic
    {
        public int getConScore(List<Consequence> conList, string assetSubType)
        {
            int result = 0;

            for (int i=0; i<conList.Count; i++)
            {
                if (assetSubType.ToUpper().Equals(conList[i].assetSubType.ToUpper()))
                {
                    result = conList[i].score;
                }
            }

            return result;
        }

        public int getLikelihood(List<Likelihood> likeList, double condition)
        {
            int result = 0;

            for (int i = 0; i < likeList.Count; i++)
            {
                if ((Math.Round(condition) >= likeList[i].criticalEnd) && (likeList[i].criticalStart >= Math.Round(condition)))
                {
                    result = likeList[i].score;
                }
            }

            return result;
        }

        public double getBudget(List<BudgetForecast> budgetList, string year)
        {
            double result = 0;
            for (int i = 0; i < budgetList.Count; i++)
            {
                if (budgetList[i].BudgetYear.Equals(year))
                {
                    result = budgetList[i].Budget;
                }
            }
            return result;
        }

    }
}