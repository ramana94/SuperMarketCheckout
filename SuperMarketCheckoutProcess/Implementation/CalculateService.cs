using SuperMarketCheckoutProcess.Interface;
using SuperMarketCheckoutProcess.Models;
using SuperMarketCheckoutProcess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketCheckoutProcess.Implementation
{
    class CalculateService : ICalculationService
    {
        public double CalculateTotalCost(List<OrderedItem> orderedItems)
        {
            var itemsList = ItemRepo.GetItems();
            double totalCost = 0; 
            if (orderedItems.Any())
            {
                foreach (var OrderedItem in orderedItems)
                {
                    var repoItem = itemsList.FirstOrDefault(itm => itm.Name == OrderedItem.Name);
                    if (repoItem.OfferedQty > 0 && OrderedItem.OrderQty >= repoItem.OfferedQty)
                    {
                        totalCost += (OrderedItem.OrderQty / repoItem.OfferedQty) * repoItem.OfferedPrice;
                    }
                    else
                        totalCost += OrderedItem.OrderQty * repoItem.UnitPrice;
                }

            }
            return totalCost;
        }
    }
}
