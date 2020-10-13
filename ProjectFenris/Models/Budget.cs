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

        public Guid UserId { get; set; }

        public int Allowance { get; set; }

        public int Expenditure { get; set; }

        public int Income { get; set; }

        public int Users { get; set; }
    }
}
