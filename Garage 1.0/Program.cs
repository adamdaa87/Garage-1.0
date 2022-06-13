using Garage_1._0.Entities;
using Garage_1._0.Entities.Garage;

namespace Garage_1._0
{
    internal class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Hello, World!");
            IGarage<Car> garage1 = new CarGarage<Car> (10);
            garage1.AddVehicle(new Car("SVA123", Color.black, 4, 1800));
            garage1.AddVehicle(new Car("SVA987", Color.white, 4, 1600));

            garage1.PrintAllToConsole();
            garage1.GarageSummery();
            garage1.RemoveVehicle(0);         
            garage1.AddVehicle(new Car("SVA981", Color.gray, 4, 2000));
            garage1.AddVehicle(new Car("SVA982", Color.gray, 4, 2200));
            garage1.AddVehicle(new Car("SVA983", Color.olive, 4, 2400));
            garage1.AddVehicle(new Car("SVA984", Color.black, 4, 1400));
            garage1.AddVehicle(new Car("SVA985", Color.black, 4, 1600));
            garage1.AddVehicle(new Car("SVA986", Color.white, 4, 1800));
            garage1.AddVehicle(new Car("SVA987", Color.white, 4, 2400));
            garage1.AddVehicle(new Car("SVA988", Color.white, 4, 2200));
            Console.WriteLine("-------final-------");
            garage1.PrintAllToConsole();
            garage1.FindVehicleByRegisterNumber("SVA981");

            IGarage<Bus> busGarage = new BusGarage<Bus>(10);
            busGarage.AddVehicle(new Bus("SVA876", Color.green, 8, 20));
            busGarage.PrintAllToConsole();

            IGarage<Boat> boatGarage = new BoatGarage<Boat>(10);
            boatGarage.AddVehicle(new Boat("SVA385", Color.fushsia, 300));
            boatGarage.PrintAllToConsole();

            IGarage<Airplane> airplaneGarage = new AirplaneGarage<Airplane>(10);
            airplaneGarage.AddVehicle(new Airplane("SVA198", Color.white, 3, 2));
            airplaneGarage.PrintAllToConsole();

            IGarage<Motorcycle> motorcycleGarage = new MotorcycleGarage<Motorcycle>(10);
            motorcycleGarage.AddVehicle(new Motorcycle("SVA162", Color.yellow, 2, 180));
            motorcycleGarage.PrintAllToConsole();
        }
    }
}