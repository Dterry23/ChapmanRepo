using System;
using System.Collections;
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
    public partial class LandingPage : Form
    {
        FoodOrder[] FoodOrderArray = new FoodOrder[10];


        public LandingPage()
        {
            InitializeComponent();
        }

        public void AddFoodOrder(FoodOrder foodOrder)
        {
            int index = 0;
            while (FoodOrderArray[index] != null)
            {
                index++;
            }
            if(FoodOrderArray[index] == null)
            {
                FoodOrderArray[index] = foodOrder;
            } else
            {
                Array.Resize(ref FoodOrderArray, FoodOrderArray.Length + 10);
                index++;
                FoodOrderArray[index] = foodOrder;
            }
            
        }


        private void McBurgerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var McBurger = new mcburgers(this);
            McBurger.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var McBurger = new mcburgers(this);
            McBurger.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cowFilA = new cowFilA(this);
            cowFilA.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cowFilA = new cowFilA(this);
            cowFilA.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dairyKing = new dairyKing(this);
            dairyKing.Show();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dairyKing = new dairyKing(this);
            dairyKing.Show();
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {

        }
    }
}
