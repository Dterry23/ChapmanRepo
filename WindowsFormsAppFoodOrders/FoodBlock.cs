using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppFoodOrders
{
   public class FoodBlock
    {
        public string name { get; set; }
        public decimal cost { get; set; }
        public int quantity { get; set; }
        public decimal calculateFoodBlockcost()
        {
            return cost * quantity;
        }

    }
}
