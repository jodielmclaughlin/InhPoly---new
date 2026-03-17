using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(string make, string model, Engine engineType) : base(make, model, engineType)
        {
            
        }

        protected override void Accelerate()
        {
           
        }
    }

}
