using SuperMarketCheckoutProcess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketCheckoutProcess.Models
{
    public class CalculationServiceClient
    {
        public ICalculationService _calculationService;
        public CalculationServiceClient(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }
        public double GetTotalCost(List<OrderedItem> orderedItems)
        {
            return _calculationService.CalculateTotalCost(orderedItems);
        }
    }
}
