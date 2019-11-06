using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppFoodOrders
{
    public partial class FormOrderHistory : Form
    {
        FoodOrder[] foodOrderArray;
        public FormOrderHistory(FoodOrder[] foodOrders)
        {
            InitializeComponent();
            this.nameLabel.Text = "";
            this.addressLabel.Text = "";
            this.phoneLabel.Text = "";
            foodOrderArray = foodOrders;
            this.foodOrderListBox.DataSource = foodOrders;
            this.foodOrderListBox.DisplayMember = "orderNumber";
        }

        private void FoodOrderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodOrder selectedFoodOrder = (FoodOrder)this.foodOrderListBox.SelectedItem;
            this.orderTracker1.UpdateOrderedFoodBlocks(selectedFoodOrder.foodBlockList);
            this.nameLabel.Text = selectedFoodOrder.customerDetails.customerName;
            this.addressLabel.Text = selectedFoodOrder.customerDetails.customerAddress;
            this.phoneLabel.Text = selectedFoodOrder.customerDetails.customerPhone;
        }


    }
}
