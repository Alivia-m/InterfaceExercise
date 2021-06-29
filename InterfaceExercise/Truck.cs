using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
   public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public int NumberOfSeats { get; set;}
        public int NumberOfWheels { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public string CompanyName { get; set;}
        public double BedSize { get; set; }
        public bool AcWorking { get; set; }
    }
}
