using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping.Services
{
    internal class AirService : IShipping
    {
        public int GetCost(OrderService order)
        {
            return Math.Max(20, order.GetTotalWeight() * 3);
        }

        public int GetDate(OrderService order)
        {
            throw new NotImplementedException();
        }
    }
}
