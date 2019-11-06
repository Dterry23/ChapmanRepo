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
            List<FoodBlock> FoodOrderList = new List<FoodBlock>();
            CreateFoodBlock(this.HotDogsLabel.Text, this.HotDogsCostLabel.Text, (int)this.HotDogsNumericUpDown.Value, FoodOrderList);
            CreateFoodBlock(this.CornDogLabel.Text, this.CornDogCostLabel.Text, (int)this.CornDogNumericUpDown.Value, FoodOrderList);
            CreateFoodBlock(this.BratzLabel.Text, this.BratzCostLabel.Text, (int)this.BratzNumericUpDown.Value, FoodOrderList);
            CreateFoodBlock(this.BurgerLabel.Text, this.BurgerCostLabel.Text, (int)this.BurgerNumericUpDown.Value, FoodOrderList);
            CreateFoodBlock(this.ChickenNuggetsLabel.Text, this.ChickenNuggetsCostLabel.Text, (int)this.ChickenNuggetsNumericUpDown.Value, FoodOrderList);
            CreateFoodBlock(this.SandwhichLabel.Text, this.SandwhichCostLabel.Text, (int)this.SandwhichNumericUpDown.Value, FoodOrderList);
            CreateFoodBlock(this.BreakfastBurritoLabel.Text, this.BreakfastBurritoCostLabel.Text, (int)this.BreakfastBurritoNumericUpDown.Value, FoodOrderList);
            CreateFoodBlock(this.FriesLabel.Text, this.FriesCostLabel.Text, (int)this.FriesNumericUpDown.Value, FoodOrderList);
            CreateFoodBlock(this.ChickenStripsLabel.Text, this.ChickenStripsCostLabel.Text, (int)this.ChickenStripsNumericUpDown.Value, FoodOrderList);
            CreateFoodBlock(this.PretzelSticksLabel.Text, this.PretzelSticksCostLabel.Text, (int)this.PretzelSticksNumericUpDown.Value, FoodOrderList);
            CreateFoodBlock(this.SundaeLabel.Text, this.SundaeCostLabel.Text, (int)this.SundaeNumericUpDown.Value, FoodOrderList);


            this.orderTracker1.UpdateOrderedFoodBlocks(FoodOrderList);

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
    }
}
