using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Service_System
{
    internal class NodeStack
    {

        public Ambulance ambulance;
        public NodeStack next = null;
        public NodeStack(Ambulance ambulance)
        {
            this.ambulance = ambulance;
        }
    }
}
