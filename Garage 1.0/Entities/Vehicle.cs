namespace Garage_1._0.Entities
{
    public class Vehicle 
    {
        public int Id { get; set; }
        public string RegisterNumber { get; set; }
        public Color Color { get; set; }
        public uint NumberOfWheels { get; set; }

        public  Vehicle(string registerNumber, Color color, uint numberOfWheels)
        {
                RegisterNumber = registerNumber;
                Color = color;
                NumberOfWheels = numberOfWheels;
        }

        public override string ToString() => $"Vehicle: Id: {Id}, RegisterNumber: {RegisterNumber}, Color: {Color}, NumberOfWheels: {NumberOfWheels}"; 

    }
}
