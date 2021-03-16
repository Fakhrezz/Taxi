using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Taxi
    {
        // properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0} ", DriverName);
            if (OnDuty == true)
            {
                Console.WriteLine("On Duty : yes", OnDuty);
            }
            else
            {
                Console.WriteLine("On Duty : no", OnDuty);
            }
            
            Console.WriteLine("Number of Passenger : {0} ", NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} Sedang menjemput penumpang", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} Sedang mengantar penumpang", DriverName);
        }

    }
}
