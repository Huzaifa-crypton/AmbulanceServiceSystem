using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Service_System
{
    internal class City
    {
        public string name;
        public static int totalCities;
        public LinkedList allstations;
        public City(string name)
        {
            totalCities++;
            this.name = name;
            allstations = new LinkedList();
        }
        ~City()
        {
            totalCities--;
        }
    }
}
