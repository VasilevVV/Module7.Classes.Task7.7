using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Classes.Task7.Model
{
    public static class OrderExtensions
    {
        public static double CalculateOrderWeight(this Order<Delivery, Client> order)
        {
            double weight = 0;
            foreach (var item in order.Products)
            {
                weight += item.Weight;
            }
            return weight;
        }
    }
}
