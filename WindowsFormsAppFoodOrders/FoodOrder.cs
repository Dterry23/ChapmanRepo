using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppFoodOrders
{
    public class FoodOrder
    {
        public CustomerDetails customerDetails { get; set; }

        public override string ToString()
        {
            return this.orderNumber.ToString() + " - " + this.customerDetails.restaurantName + " Order....." ;
        }

        public int orderNumber { get; set; }
        public List<FoodBlock> foodBlockList { get; set; }

        public Boolean isValidOrder()
        {
            Boolean isValid = false;
            if (foodBlockList.Count >= 1) { isValid = true; }
            return isValid;
        }

    }
}
