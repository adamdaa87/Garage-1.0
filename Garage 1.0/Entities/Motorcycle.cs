using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.Entities
{
    internal class Motorcycle : Vehicle
    {
        public uint Length { get; set; }
        public Motorcycle(string registerNumber, Color color, uint numberOfWheels, uint length) : base (registerNumber, color, numberOfWheels)
        {
            Length = length;
        }

        public override string ToString() => "Motorcycle " + base.ToString() + $", Length: {Length}";
    }
}
