using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcompanies_Price_Calculator.Entities {
    public class MarketItem {
        public int Id { get; set; }
        public int Kind { get; set; }
        public int Quantity { get; set; }
        public int Quality { get; set; }
        public decimal Price { get; set; }  

    }
}
