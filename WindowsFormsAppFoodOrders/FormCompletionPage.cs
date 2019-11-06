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
    public partial class FormCompletionPage : Form
    {
        FoodOrder pfoodOrder;
        public FoodOrder FoodOrder {
            get {
                return pfoodOrder;
            }
            set {
                pfoodOrder = value;
                this.customerNameLabel.Text = FoodOrder.customerDetails.customerName;
                this.customerAddressLabel.Text = FoodOrder.customerDetails.customerAddress;
                this.customerPhoneNumberLabel.Text = FoodOrder.customerDetails.customerPhone;
                this.orderTracker1.UpdateOrderedFoodBlocks(FoodOrder.foodBlockList);

            }
        }
        public FormCompletionPage()
        {
            InitializeComponent();
        }

        private void CustomerPhoneNumberTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
