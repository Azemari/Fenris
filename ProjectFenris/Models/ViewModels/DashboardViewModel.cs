using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFenris.Models.ViewModels
{
    public class DashboardViewModel
    {
        public List<Budget> Budget { get; set; }

        public Customer Customer { get; set; }
    }
}
