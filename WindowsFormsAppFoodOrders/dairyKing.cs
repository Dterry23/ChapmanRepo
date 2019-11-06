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
    public partial class dairyKing : Form
    {
        LandingPage theParentForm;
        List<FoodBlock> foodOrderList;
        public dairyKing(LandingPage parentForm)
        {
            InitializeComponent();
            theParentForm = parentForm;
        }

        private void DairyKing_FormClosed(object sender, FormClosedEventArgs e)
        {
            theParentForm.Show();
        }

        private void HotDogsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }
        private void CheckAllFoodItems()
        {
            foodOrderList = new List<FoodBlock>();
            CreateFoodBlock(this.HotDogsLabel.Text, this.HotDogsCostLabel.Text, (int)this.HotDogsNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.CornDogLabel.Text, this.CornDogCostLabel.Text, (int)this.CornDogNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.BratzLabel.Text, this.BratzCostLabel.Text, (int)this.BratzNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.BurgerLabel.Text, this.BurgerCostLabel.Text, (int)this.BurgerNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.ChickenNuggetsLabel.Text, this.ChickenNuggetsCostLabel.Text, (int)this.ChickenNuggetsNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.SandwhichLabel.Text, this.SandwhichCostLabel.Text, (int)this.SandwhichNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.BreakfastBurritoLabel.Text, this.BreakfastBurritoCostLabel.Text, (int)this.BreakfastBurritoNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.FriesLabel.Text, this.FriesCostLabel.Text, (int)this.FriesNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.ChickenStripsLabel.Text, this.ChickenStripsCostLabel.Text, (int)this.ChickenStripsNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.PretzelSticksLabel.Text, this.PretzelSticksCostLabel.Text, (int)this.PretzelSticksNumericUpDown.Value, foodOrderList);
            CreateFoodBlock(this.SundaeLabel.Text, this.SundaeCostLabel.Text, (int)this.SundaeNumericUpDown.Value, foodOrderList);


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

        private void CornDogNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void BratzNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void BurgerNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void ChickenNuggetsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void SandwhichNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void BreakfastBurritoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void FriesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void ChickenStripsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void PretzelSticksNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CheckAllFoodItems();
        }

        private void SundaeNumericUpDown_ValueChanged(object sender, EventArgs e)
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
