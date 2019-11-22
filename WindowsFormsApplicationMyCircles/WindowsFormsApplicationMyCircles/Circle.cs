using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationMyCircles
{
    class Circle
    {
        public static double pi = 3.14;
        public int radius;

        public double getArea()
        {
            return pi * radius * radius;
        }
    }
}
