using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationMyCircles
{
    class Triangle
    {
        public int height;

        public int getArea()
        {
            return (height * height) / 2;
        }

        public int getPerim()
        {
            return height * 3;
        }
    }
}
