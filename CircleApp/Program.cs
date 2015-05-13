using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle aCircle = new Circle();
            Console.WriteLine("Enter radius of circle.");
            aCircle.radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Diameter of the circle is = "+aCircle.GetDiameter());
            Console.WriteLine("Perimeter of the circle is = "+aCircle.GetPerimeter());
            Console.WriteLine("Area of the Circle is = "+aCircle.GetArea());
            Console.ReadKey();
        }
    }
}
