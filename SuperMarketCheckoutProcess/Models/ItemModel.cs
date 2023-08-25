using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketCheckoutProcess.Models
{
    public class ItemModel
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public double OfferedPrice { get; set; }
        public int OfferedQty { get; set; }
    }
}
