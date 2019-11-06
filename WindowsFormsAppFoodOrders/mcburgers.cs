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
            List<FoodBlock> FoodOrderList = new List<FoodBlock>();
            CreateFoodBlock(this.BurgerLabel.Text, this.BurgerCostLabel.Text, (int)this.BurgerNumericUpDown.Value, FoodOrderList);
            CreateFoodBlock(this.ChickenSandwhichLabel.Text, this.ChickenSandwhichCostLabel.Text, (int)this.ChickenSandwhichNumericUpDown.Value, FoodOrderList);
            CreateFoodBlock(this.SaladLabel.Text, this.BurgerCostLabel.Text, (int)this.SaladNumericUpDown.Value, FoodOrderList);
            CreateFoodBlock(this.LargeDrinkLabel.Text, this.LargeDrinkCostLabel.Text, (int)this.LargeDrinkNumericUpDown.Value, FoodOrderList);
            CreateFoodBlock(this.MediumDrinkLabel.Text, this.MediumDrinkCostLabel.Text, (int)this.MediumDrinkNumericUpDown.Value, FoodOrderList);
            CreateFoodBlock(this.SmallDrinkLabel.Text, this.SmallDrinkCostLabel.Text, (int)this.SmallDrinkNumericUpDown.Value, FoodOrderList);
            CreateFoodBlock(this.WrapLabel.Text, this.WrapCostLabel.Text, (int)this.WrapNumericUpDown.Value, FoodOrderList);
            CreateFoodBlock(this.FriesLabel.Text, this.FriesCostLabel.Text, (int)this.FriesNumericUpDown.Value, FoodOrderList);
            CreateFoodBlock(this.SundaeLabel.Text, this.SundaeCostLabel.Text, (int)this.SundaeNumericUpDown.Value, FoodOrderList);
            CreateFoodBlock(this.CookieLabel.Text, this.CookieCostLabel.Text, (int)this.CookieNumericUpDown.Value, FoodOrderList);
            CreateFoodBlock(this.OnionRingsLabel.Text, this.OnionRingsCostLabel.Text, (int)this.OnionRingsNumericUpDown.Value, FoodOrderList);



            this.orderTracker1.UpdateOrderedFoodBlocks(FoodOrderList);
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
    }
}
