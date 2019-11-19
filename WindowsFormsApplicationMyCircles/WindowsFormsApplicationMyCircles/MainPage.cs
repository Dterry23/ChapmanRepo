using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationMyCircles
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        class circle
        {
            public static double pi = 3.14;
            public int radius;

            public double getArea()
            {
                return pi * radius * radius;
            }
            
        }

        public static void main(String args[])
        {
            circle c1 = new circle();
            circle c2 = new circle();
            c1.radius = 5;
            c2.radius = 6;
            Console.WriteLine("c1's area is: " + c1.getArea());
            Console.WriteLine("c2's area is: " + c2.getArea());

            string myStr = "";
            double myNum;
            circle myCircle = new circle();
            myCircle.radius = Circle.CircleCount++;
            myNum = myCircle.getArea();

            myStr = string.Format("Radius {0, -5}, Circle Area {1, -10.02}, Diameter {3, -10.02}");
            Convert.ToString(myCircle.radius);
            Convert.ToString(myCircle.getArea());
            //Convert.ToString(myCircle.getCircumference);
            //Convert.ToString(myCircle.getDiameter);

            Circle.GList.Add(myStr);
            foreach (string s in Circle.GList);
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            circleDetailsTextBox.Text = 
        }
    }
}
