namespace Garage_1._0.Entities.Garage
{
    public interface IWriteGarage<in TVehicle>
    {
        void AddVehicle(TVehicle vehicle);
        void ReduseIndex();
        void RemoveVehicle(int index);
    }
    public interface IReadGarage<out TVehicle>
    {
        string FindVehicleByRegisterNumber(string registerNumber);
        bool CheckIndex(int index);
        IEnumerable<TVehicle> GetAll();
        void PrintAllToConsole();
        void GarageSummery();
    }
    public interface IGarage<TVehicle> : IReadGarage<TVehicle>, IWriteGarage<TVehicle> 
        where TVehicle : Vehicle
    {
        
    }
}