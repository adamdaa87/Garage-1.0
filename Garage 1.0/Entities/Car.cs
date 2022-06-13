using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.Entities
{
    public class Car : Vehicle
    {
        public uint CylinderVolume { get; set; }
        public Car(string registerNumber, Color color, uint numberOfWheels, uint cylinderVolume) : base(registerNumber, color, numberOfWheels)
        {
            CylinderVolume = cylinderVolume;
        }

        public override string ToString() => "Car " + base.ToString() + $", CylinderVolume: {CylinderVolume}";
    }
}
