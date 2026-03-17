using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        public double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            double num = (Math.PI * (Radius * Radius));
            return num;
        }
    }
}
