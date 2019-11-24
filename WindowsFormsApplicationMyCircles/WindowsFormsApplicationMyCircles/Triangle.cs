using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationMyCircles
{
    class Triangle
    {
        public float height;

        public float getArea()
        {
            return (height * height) / 2;
            
        }

        public float getPerim()
        {
            return height * 3;
        }
    }
}
