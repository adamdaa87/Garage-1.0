using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.Entities
{
    public class Garage <T>
    {
        private int index = 0;
        private T[] vehicles;
        
        public Garage(int size)
        { 
            vehicles = new T[size]; 
        }

        public void AddVehicle(T vehicle)
        {
            ++index;
            if(index < vehicles.Length)
                vehicles[index] = vehicle;
            else 
                Console.WriteLine("There is no enough place"); 
        }

        public void RemoveVehicle(T vehicle)
        {
            int numIndex = Array.IndexOf(vehicles, vehicle);
            vehicles = vehicles.Where((val, idx) => idx != numIndex).ToArray();
        }
    }
}
