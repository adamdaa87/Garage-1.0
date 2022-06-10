namespace Garage_1._0.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public uint RegisterNumber { get; set; }
        public string Color { get; set; }
        public uint NumberOfWheels { get; set; }

        public  Vehicle(int id, uint registerNumber, string color, uint numberOfWheels)
        {
            Id = id;
            RegisterNumber = registerNumber;
            Color = color;
            NumberOfWheels = numberOfWheels;
        }

        public override string ToString() => $"Id: {Id}, RegisterNumber: {RegisterNumber}";
    }
}
