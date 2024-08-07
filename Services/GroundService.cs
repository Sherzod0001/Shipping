using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping.Services
{
    internal class GroundService : IShipping
    {
        public int GetCost(OrderService order)
        {
            if (order.GetTotal() > 100)
            {
                return 0;
            }

            return Math.Max(10,order.GetTotalWeight() * 2);
        }

        public int GetDate(OrderService order)
        {
            throw new NotImplementedException();
        }
    }
}
