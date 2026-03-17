using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }
        public Motorcycle(string make, string model, bool hasSidecar, Engine engineType) : base(make, model, engineType)
        {
            
            HasSidecar = hasSidecar;
        }
        protected override void Accelerate()
        {
            
        }
    }
}
