using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Suv : IVehicle, ICompany
    {
        public Suv()
        {
        }
        public int NumberOfSeats { get; set; }
        public int NumberOfWheels { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public string CompanyName { get; set; }
        public double CargoHoldSize { get; set; }
        public int NumberOfDvdPlayers { get; set; }
    }
}
