using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping.Services
{
    internal class OrderService
    {
        private int lineItems;
        private IShipping shipping;

        public int GetTotal()
        {
            return 5;
        }

        public int GetTotalWeight()
        {
            return 5;
        }

        public void GetShippingType()
        {

        }

        public void GetShippingCost()
        {

        }

        public void GetShippingDate()
        {

        }

        public string GetProductType(string name)
        {

            return name;
        }
    }
}
