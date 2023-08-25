using SuperMarketCheckoutProcess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketCheckoutProcess.Repository
{
    public static class ItemRepo
    {
        public static List<ItemModel> GetItems()
        {
            return new List<ItemModel> { new ItemModel { Name="A", UnitPrice=50, OfferedPrice=130,OfferedQty=3},
                new ItemModel { Name="B", UnitPrice=30, OfferedPrice=45,OfferedQty=2},
                new ItemModel { Name="C", UnitPrice=20, OfferedPrice=0,OfferedQty=0},
                new ItemModel { Name="A", UnitPrice=15, OfferedPrice=0,OfferedQty=0},
            };

        }
    }
}
