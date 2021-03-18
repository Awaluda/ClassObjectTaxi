using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menmbuat_ClassObjectTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi() ;

            taxi.DriverName = "Awal";
            taxi.OnDuty = false;
            taxi.NumPassenger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
