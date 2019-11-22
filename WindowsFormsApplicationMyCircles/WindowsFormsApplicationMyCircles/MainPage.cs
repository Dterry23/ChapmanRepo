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

        public static void main(String[] args)
        {
       
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            string myStr = "";
            double myNum;
            Circle myCircle = new Circle();
            //ClassGlobals is static, meaning only one gets created
            //It needs to be its own class
            myCircle.radius = ClassGlobals.CircleCount++;
            myNum = myCircle.getArea();

            myStr = string.Format("Radius {0,-5} Circle Area {1,-10:D2}",
                Convert.ToString(myCircle.radius),
                Convert.ToString(myCircle.getArea()));


            ClassGlobals.GList.Add(myStr);

            circleDetailsTextBox.Text = "";
            foreach (string s in ClassGlobals.GList)
            {
                //+= appends, takes whatever was in the textbox to start with then appends something new to the end
                circleDetailsTextBox.Text += s + "\r\n";
            }
        }
    }
}
