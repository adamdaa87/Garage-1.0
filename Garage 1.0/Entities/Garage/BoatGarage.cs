using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.Entities.Garage
{
   public class BoatGarage<TVehicle> : IGarage<TVehicle> where TVehicle : Vehicle
    {
        private int index = 0;
        private int size = 0;
        private readonly TVehicle[] vehicles;

        public BoatGarage(int size)
        {
            vehicles = new TVehicle[size];
            this.size = size;
        }

        public void AddVehicle(TVehicle vehicle)
        {
            if (index < vehicles.Length)
            {
                vehicle.Id = index + 1;
                vehicles[index++] = vehicle;
            }
            else
                Console.WriteLine("There is no enough places");

        }

        public bool CheckIndex(int index)
        {
            if (index < vehicles.Length)
                return true;
            else
                return false;

        }
        private void MoveElementsOneStepToLeft(int index)
        {
            for (int i = index + 1; i < vehicles.Length; i++)
            {
                vehicles[i - 1] = vehicles[i];
                vehicles[i] = null;
            }

            int j = 0;
            while (vehicles[j] != null)
            {
                vehicles[j].Id = vehicles[j].Id - 1;
                j++;
            }
        }

        public void ReduseIndex()
        {
            index--;
        }
        public void RemoveVehicle(int index)
        {
            if (CheckIndex(index))
            {
                vehicles[index] = null;
                MoveElementsOneStepToLeft(index);
                ReduseIndex();
            }
        }

        public string FindVehicleByRegisterNumber(string registerNumber)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null && vehicles[i].RegisterNumber.ToLower().Trim() == registerNumber.ToLower().Trim())
                {
                    Console.WriteLine("The car was found: " + vehicles[i].ToString());
                    break;
                }
            }
            return "The car doesn't exist!";
        }

        public void PrintAllToConsole()
        {
            var items = GetAll();
            foreach (TVehicle vehicle in items)
            {
                if (vehicle != null)
                    Console.WriteLine(vehicle.ToString());
                else
                    break;
            }
        }
        public IEnumerable<TVehicle> GetAll()
        {
            return vehicles.ToList();
        }
        public void GarageSummery()
        {
            Console.WriteLine("-------------------------GarageSummery-----------------------------");
            Console.WriteLine($"Vehicle Type: {typeof(TVehicle).Name}, In the garage there are {index} vehicles " +
                $"and the garage still has {size - index} empty places");
        }
    }
}
