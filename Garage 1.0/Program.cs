using Garage_1._0.Entities;

namespace Garage_1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Garage<Vehicle> garage = new Garage<Vehicle>(10);
            garage.AddVehicle(new Vehicle(1,123456,"Red",4));
        }
    }
}