using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationMyCircles
{
    class Square
    {
        public int height;

        public int getArea()
        {
            return height * height;
        }

        public int getPerim()
        {
            return height * 4;
        }
    }
}
