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
    public partial class cowFilA : Form
    {
        LandingPage pParentPage;
        List<FoodBlock> foodOrderList;
        public cowFilA(LandingPage parentpage)
        {
            InitializeComponent();
            pParentPage = parentpage;
        }

        private void CowFilA_FormClosed(object sender, FormClosedEventArgs e)
        {
            pParentPage.Show();
        }

        private void CheckAllFoodItems()
        {
            foodOrderList = new List<FoodBlock>();
            CreateFoodBlock(this.SixOunceSteakLabel.Text, this.SixOunceSteakCostLabel.Text, (int)this.SixOunceSteakNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.EightOunceSteakLabel.Text, this.EightOunceSteakCostLabel.Text, (int)this.EightOunceSteakNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.TwelveOunceSteakLabel.Text, this.TwelveOunceSteakCostLabel.Text, (int)this.TwelveOunceSteakNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.RibsLabel.Text, this.RibsCostLabel.Text, (int)this.RibsNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.CaesarSaladLabel.Text, this.CaesarSaladCostLabel.Text, (int)this.CaesarSaladNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.GrilledBBQChickenLabel.Text, this.GrilledBBQChickenCostLabel.Text, (int)this.GrilledBBQChickenNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.GrilledSalmonLabel.Text, this.GrilledSalmonCostLabel.Text, (int)this.GrilledSalmonNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.FriesLabel.Text, this.FriesCostLabel.Text, (int)this.FriesNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.PotatoesLabel.Text, this.PotatoesCostLabel.Text, (int)this.PotatoesNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.BroccoliLabel.Text, this.BroccoliCostLabel.Text, (int)this.BroccoliNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.FriedPicklesLabel.Text, this.FriedPicklesCostLabel.Text, (int)this.FriedPicklesNumericUpDown.Value, foodOrderList);


            this.orderTracker1.UpdateOrderedFoodBlocks(foodOrderList);

        }
        private void CreateFoodBlock(string name, string cost, int quantity, List<FoodBlock> FoodOrderList)
        {
            if (quantity > 0)
            {
                FoodBlock CurrentFoodBlock = new FoodBlock();
                CurrentFoodBlock.name = name;
                CurrentFoodBlock.cost = decimal.Parse(cost, NumberStyles.AllowCurrencySymbol | NumberStyles.Number);
                CurrentFoodBlock.quantity = quantity;
                FoodOrderList.Add(CurrentFoodBlock);
            }
        }

        private void SixOunceSteakNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void EightOunceSteakNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void TwelveOunceSteakNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void RibsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void CaesarSaladNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void GrilledBBQChickenNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void GrilledSalmonNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void FriesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void PotatoesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void BroccoliNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void FriedPicklesNumericUpDown_ValueChanged(object sender, EventArgs e)
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
            var formCompletionPage = new FormCompletionPage(pParentPage);
            formCompletionPage.FoodOrder = foodOrder;
            formCompletionPage.Show();
        }
    }
}
