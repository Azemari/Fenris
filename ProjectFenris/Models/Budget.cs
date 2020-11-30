using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProjectFenris.Models
{
    public class Budget
    {
        public int Id { get; set; }

        public BudgetType Type { get; set; }

        public Guid UserId { get; set; }

        public char Currency { get; set; }

        public int Allowance { get; set; }

        public PeriodRange Range { get; set; }

        public int Expenditure { get; set; } 

        public int Income { get; set; }

        public int Users { get; set; }
    }

    public enum BudgetType
    {
        Individual,
        Group
    }

    public enum PeriodRange
    {
        Once,
        Daily,
        Weekly,
        Monthly
    }
}
