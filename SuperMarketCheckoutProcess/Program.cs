using SuperMarketCheckoutProcess.Implementation;
using SuperMarketCheckoutProcess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketCheckoutProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new CalculationServiceClient(new CalculateService());
            Console.WriteLine("Please enter Item Names with ',' seperated ");
            var orderedItems = Console.ReadLine().Split(',');
            Console.WriteLine($"{Environment.NewLine}Please enter Items Quantity respectively");
            var OrderedItemsQty = Console.ReadLine().Split(',');
            if(orderedItems.Count() != OrderedItemsQty.Count())
            {
                Console.WriteLine($"{Environment.NewLine}Invalid Imput Data");
            }
            else if(orderedItems.Count() == OrderedItemsQty.Count() && orderedItems.Count() > 0)
            {
                var orderedItemsList = new List<OrderedItem>();
                int i = 0;
                foreach (var item in orderedItems)
                {
                    var OrderedItem = new OrderedItem();
                    OrderedItem.Name = item;
                    OrderedItem.OrderQty = Convert.ToInt32(OrderedItemsQty[i]);
                    orderedItemsList.Add(OrderedItem);
                    i++;
                }
                Console.WriteLine($"{Environment.NewLine}The total Price is: {client.GetTotalCost(orderedItemsList)}");
            }
            Console.ReadKey(true);
        }
    }
}
