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

            myStr = string.Format("Radius {0,-5} Circle Area {1,-10:D2} Circum {2, -10:D2} Diameter {3, -10:D2}",
                Convert.ToString(myCircle.radius),
                Convert.ToString(myCircle.getArea()),
                Convert.ToString(myCircle.getCircum()),
                Convert.ToString(myCircle.getDiam()));


            ClassGlobals.GList.Add(myStr);

            circleDetailsTextBox.Text = "";
            foreach (string s in ClassGlobals.GList)
            {
                //+= appends, takes whatever was in the textbox to start with then appends something new to the end
                circleDetailsTextBox.Text += s + "\r\n";
            }
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            string myStr = "";
            double myNum;
            Square mySquare = new Square();
            mySquare.height = ClassGlobals.CircleCount++;
            myNum = mySquare.getArea();

            myStr = string.Format("All Sides {0,-5} Square Area {1,-10:D2} Perimeter {2,-10:D2}",
                Convert.ToString(mySquare.height),
                Convert.ToString(mySquare.getArea()),
                Convert.ToString(mySquare.getPerim()));

            ClassGlobals.GList.Add(myStr);

            circleDetailsTextBox.Text = "";
            foreach (string s in ClassGlobals.GList)

                circleDetailsTextBox.Text += s + "\r\n";

        }

        private void TriangleButton_Click(object sender, EventArgs e)
        {
            string myStr = "";
            float myNum;
            Triangle myTriangle = new Triangle();
            myTriangle.height = ClassGlobals.CircleCount++;
            myNum = myTriangle.getArea();

            myStr = string.Format("All Sides {0,-5} Triangle Area {1,-10:D2} Perimeter {2,-10:D2}",
                Convert.ToString(myTriangle.height),
                Convert.ToString(myTriangle.getArea()),
                Convert.ToString(myTriangle.getPerim()));

            ClassGlobals.GList.Add(myStr);

            circleDetailsTextBox.Text = "";
            foreach (string s in ClassGlobals.GList)

                circleDetailsTextBox.Text += s + "\r\n";
        }
    }
}
