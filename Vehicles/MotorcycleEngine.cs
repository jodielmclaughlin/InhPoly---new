using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class MotorcycleEngine : Engine
    {
        public MotorcycleEngine(int horsepower, FuelType fuelType) : base(horsepower, fuelType)
        {
            Horsepower = 150;
            FuelType = FuelType.Unleaded;
        }
    }
}
