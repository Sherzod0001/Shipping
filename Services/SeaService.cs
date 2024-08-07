using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping.Services
{
    internal class SeaService : IShipping
    {
        public int GetCost(OrderService order)
        {   
            if(order.GetProductType() == "chinni")
            {
                
            }
            
            return Math.Max(20, order.GetTotalWeight() * 4);
        }

        public int GetDate(OrderService order)
        {
            throw new NotImplementedException();
        }
    }
}
