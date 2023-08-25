using SuperMarketCheckoutProcess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketCheckoutProcess.Interface
{
    public interface ICalculationService
    {
        double CalculateTotalCost(List<OrderedItem> orderedItems);
    }
}
