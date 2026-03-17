using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Sphere : Shape3D
    {
        public Sphere(Circle shape) : base(shape)
        {

        }

        public override double CalculateVolume()
        {
            Circle ourCircle = (Circle)BaseShape;
            double radius = ourCircle.Radius;
            return (BaseShape.CalculateArea()) * radius * 4d / 3d;
        }
    }
}
