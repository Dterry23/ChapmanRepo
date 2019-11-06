using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppFoodOrders
{
    public partial class mcburgers : Form
    {
        
        LandingPage theLandingPage;
        List<FoodBlock> foodOrderList;

        public mcburgers(LandingPage parentForm)
        {
            InitializeComponent();
            theLandingPage = parentForm;
        }

        private void Mcburgers_FormClosed(object sender, FormClosedEventArgs e)
        {
            theLandingPage.Show();
        }

        private void BurgerNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void CheckAllFoodItems()
        {
            foodOrderList = new List<FoodBlock>();
            CreateFoodBlock(this.BurgerLabel.Text, this.BurgerCostLabel.Text, (int)this.BurgerNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.ChickenSandwhichLabel.Text, this.ChickenSandwhichCostLabel.Text, (int)this.ChickenSandwhichNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.SaladLabel.Text, this.BurgerCostLabel.Text, (int)this.SaladNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.LargeDrinkLabel.Text, this.LargeDrinkCostLabel.Text, (int)this.LargeDrinkNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.MediumDrinkLabel.Text, this.MediumDrinkCostLabel.Text, (int)this.MediumDrinkNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.SmallDrinkLabel.Text, this.SmallDrinkCostLabel.Text, (int)this.SmallDrinkNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.WrapLabel.Text, this.WrapCostLabel.Text, (int)this.WrapNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.FriesLabel.Text, this.FriesCostLabel.Text, (int)this.FriesNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.SundaeLabel.Text, this.SundaeCostLabel.Text, (int)this.SundaeNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.CookieLabel.Text, this.CookieCostLabel.Text, (int)this.CookieNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.OnionRingsLabel.Text, this.OnionRingsCostLabel.Text, (int)this.OnionRingsNumericUpDown.Value, foodOrderList);



            this.orderTracker1.UpdateOrderedFoodBlocks(foodOrderList);
        }



        private void CreateFoodBlock(string name, string cost, int quantity, List<FoodBlock> FoodOrderList) {
            if (quantity > 0)
            {
                FoodBlock CurrentFoodBlock = new FoodBlock();
                CurrentFoodBlock.name = name;
                CurrentFoodBlock.cost = decimal.Parse(cost, NumberStyles.AllowCurrencySymbol | NumberStyles.Number);
                CurrentFoodBlock.quantity = quantity;
                FoodOrderList.Add(CurrentFoodBlock);
            }
        }

        private void ChickenSandwhichNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void SaladNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void LargeDrinkNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void MediumDrinkNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void SmallDrinkNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void WrapNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void FriesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void SundaeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void CookieNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void OnionRingsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FoodOrder foodOrder = new FoodOrder();
            Random randomNumberGenerator = new Random();
            CustomerDetails customerDetails = new CustomerDetails();

            customerDetails.customerName = this.customerNameTextBox.Text;
            customerDetails.customerAddress = this.customerAddressTextBox.Text;
            customerDetails.customerPhone = this.customerPhoneNumberTextBox.Text;

            foodOrder.customerDetails = customerDetails;
            foodOrder.orderNumber = randomNumberGenerator.Next(1, 100);

            foodOrder.foodBlockList = foodOrderList;

            this.Hide();
            var formCompletionPage = new FormCompletionPage();
            formCompletionPage.FoodOrder = foodOrder;
            formCompletionPage.Show();
        }
    }
}
