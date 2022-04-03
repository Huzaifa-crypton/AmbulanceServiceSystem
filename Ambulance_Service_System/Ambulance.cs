using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Service_System
{
    internal class Ambulance
    {
        public string platenumber;
        public string modelnumber;
        public Ambulance(string platenumber,string modelnumber)
        {
            this.platenumber = platenumber;
            this.modelnumber = modelnumber;
        }
    }
}
