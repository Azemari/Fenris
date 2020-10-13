using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFenris.Models
{
    public class Settings
    {
        [Display(Name ="Preferred Currency")]
        public string Currency { get; set; }

        public char CurrencySymbol { get; set; }
    }

    enum Currencies
    {
        GBP,
        USD
    }
}
