using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Triangle : Shape
    {
        public double BaseLength;
        public double Height;

        public Triangle(double baseLength, double height)
        {
            this.BaseLength = baseLength;
            this.Height = height;
        }

        public override double CalculateArea()
        {
            double num = ((BaseLength * Height)/2);
            return num;
        }
    }
}
