using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping.Services
{
    internal interface IShipping
    {
        public int GetCost(OrderService order);
        public int GetDate(OrderService order);
    }
}
