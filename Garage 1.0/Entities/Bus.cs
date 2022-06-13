using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.Entities
{
    public class Bus : Vehicle
    {
        public uint NumberOfSeats { get; set; }
        public Bus (string registerNumber, Color color, uint numberOfWheels, uint numberOfSeats) : base(registerNumber, color, numberOfWheels)
        {
            NumberOfSeats = numberOfSeats;
        }

        public override string ToString() => "Bus " + base.ToString() + $", NumberOfSeats: {NumberOfSeats}";
    }
}
