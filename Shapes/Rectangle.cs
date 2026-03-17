using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : Shape
    {
        public double Length;
        public double Width;

        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }

        public override double CalculateArea()
        {
            double num = (Length * Width);
            return num;
        }
        
    }
}
