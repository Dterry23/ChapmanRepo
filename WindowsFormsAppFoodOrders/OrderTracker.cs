using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppFoodOrders
{
    public partial class OrderTracker : UserControl
    {
        private List<FoodBlock> MyOrderedFoodBlocks;
        private List<Label> FoodTextBoxes;
        private List<Label> AmountTextBoxes;

        public OrderTracker()
        {
            InitializeComponent();
            FoodTextBoxes = new List<Label>();
            AmountTextBoxes = new List<Label>();

        }

        internal void UpdateOrderedFoodBlocks(List<FoodBlock> OrderedFoodBlocks)
        {
            MyOrderedFoodBlocks = OrderedFoodBlocks;
            removeExistingOrders();
            addNewOrders();

        }

        private void removeExistingOrders()
        {
            foreach (Label CurrentLabel in FoodTextBoxes){
                this.Controls.Remove(CurrentLabel);
                CurrentLabel.Dispose();
            }
            FoodTextBoxes = new List<Label>();

            foreach (Label CurrentLabel in AmountTextBoxes)
            {
                this.Controls.Remove(CurrentLabel);
                CurrentLabel.Dispose();
            }
            AmountTextBoxes = new List<Label>();

        }

        private void addNewOrders()
        {
            int currentItem = 1;
            decimal grandTotal = 0;
            foreach (FoodBlock CurrentFoodBlock in MyOrderedFoodBlocks)
            {
                Label FoodTextBox = new Label();
                FoodTextBox.AutoSize = true;
                FoodTextBox.Left = 15;
                FoodTextBox.Top = currentItem * 25;
                FoodTextBox.Text = CurrentFoodBlock.name;
                this.splitContainer2.Panel1.Controls.Add(FoodTextBox);
                FoodTextBoxes.Add(FoodTextBox);

                Label AmountTextBox = new Label();
                FoodTextBox.AutoSize = true;
                AmountTextBox.Left = 135;
                AmountTextBox.Top = currentItem * 25;
                AmountTextBox.Text = CurrentFoodBlock.calculateFoodBlockcost().ToString();
                this.splitContainer2.Panel1.Controls.Add(AmountTextBox);
                AmountTextBoxes.Add(AmountTextBox);

                grandTotal += CurrentFoodBlock.calculateFoodBlockcost();
                currentItem++;
            }

            this.GrandTotalFoodCost.Text = '$' + grandTotal.ToString();



        }

        private void SplitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
