using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Rectangle
    {
        public void GetArea(double width,double hight)
        {
            Console.WriteLine("Area of Rectangle : " + width * hight);
        }

        public void GetPerimeter(double width, double hight)
        {
            Console.WriteLine("Perimeter of Rectangle : " + width * hight);
        }

    }
}
