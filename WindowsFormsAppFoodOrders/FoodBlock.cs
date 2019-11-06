using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppFoodOrders
{
    class FoodBlock
    {
        public string name;
        public decimal cost;
        public int quantity;
        public decimal calculateFoodBlockcost()
        {
            return cost * quantity;
        }

    }
}
