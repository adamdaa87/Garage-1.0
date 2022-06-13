using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.Entities
{
    internal class Boat : Vehicle
    {
        public uint Length { get; set; }
        public Boat(string registerNumber, Color color, uint length, uint numberOfWheels = 0 ) : base (registerNumber, color, numberOfWheels)
        {
            Length = length;
        }

        public override string ToString() => "Boat " + base.ToString() + $", Length: {Length}";
    }
}
