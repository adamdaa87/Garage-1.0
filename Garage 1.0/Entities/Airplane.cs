using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.Entities
{
    public class Airplane : Vehicle
    {
        public uint NumberOfEngines { get; set; }
        public Airplane(string registerNumber, Color color, uint numberOfWheels, uint numberOfEngines): base(registerNumber, color, numberOfWheels) 
        {
            NumberOfEngines = numberOfEngines;
        }

        public override string ToString() => "Airplane " + base.ToString() + $", NumberOfEngines: {NumberOfEngines}";
    }
}
