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

        LandingPage theParentForm;
        public FormCompletionPage(LandingPage landingPage)
        {
            InitializeComponent();
            theParentForm = landingPage;

        }

        public FoodOrder FoodOrder
        {
            get
            {
                return pfoodOrder;
            }
            set
            {
                pfoodOrder = value;
                this.customerNameLabel.Text = FoodOrder.customerDetails.customerName;
                this.customerAddressLabel.Text = FoodOrder.customerDetails.customerAddress;
                this.customerPhoneNumberLabel.Text = FoodOrder.customerDetails.customerPhone;
                this.orderTracker1.UpdateOrderedFoodBlocks(FoodOrder.foodBlockList);

            }
        }

        private void CustomerPhoneNumberTextBox_Click(object sender, EventArgs e)
        {

        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            theParentForm.AddFoodOrder(pfoodOrder);
            this.Hide();
            theParentForm.Show();
            
        }
    }
}
