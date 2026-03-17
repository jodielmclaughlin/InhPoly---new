using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Cylinder : Shape3D
    {
        public double Height;

        public Cylinder(Circle shape, double height) : base(shape)
        {
            Height = height;
            //shape = Circle;
        }

        public override double CalculateVolume()
        {
            
            return (BaseShape.CalculateArea()) * Height;
        }
    }
}
