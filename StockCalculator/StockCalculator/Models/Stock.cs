using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCalculator.Models
{
    public class Stock
    {
        public string Code { get; set; }
        public string Company { get; set; }

        public decimal Current { get; set; }
        public decimal Low { get; set; }
        public decimal High { get; set; }

        public bool Berish { get; set; }

        public int Percentage { get; set; }



    }
}
