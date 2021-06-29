using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public int NumberOfSeats { get; set; }
        public int NumberOfWheels { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public string CompanyName { get; set; }
        public double TrunkSize { get; set; }
        public int NumberOfCupHolders { get; set; }
    }
}
