using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProjectFenris.Models
{
    public class Budget
    {
        [Key]
        public int Id { get; set; }

        public BudgetType Type { get; set; }

        public Guid UserId { get; set; }

        public string Name { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastUpdate { get; set; }

        //Budget after calculations
        public int Remaining { get; set; }

        //Fuck
        //Budget dividing by days remaining
        [NotMapped]
        public int Estimate { get; set; }

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
