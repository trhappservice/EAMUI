using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAMUI.Models
{
    public class BudgetForecast
    {
        public string BudgetYear { get; set; }
        public double Budget { get; set; }

        public BudgetForecast() { }
        public BudgetForecast(string BudgetYear, double Budget)
        {
            this.BudgetYear = BudgetYear;
            this.Budget = Budget;
        }
    }
}