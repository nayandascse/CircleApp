using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {
        public double radius;

        public double GetDiameter()
        {
            return radius*2;
        }

        public double GetPerimeter()
        {
            return 2*Math.PI*radius;
        }

        public double GetArea()
        {
            return Math.PI*radius*radius;
        }
    }
}
