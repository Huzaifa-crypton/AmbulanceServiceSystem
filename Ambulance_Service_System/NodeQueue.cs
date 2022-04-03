using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Service_System
{
    internal class NodeQueue
    {
        public ECF call;
        public NodeQueue next = null;
        public NodeQueue(ECF eCF)
        {
            call = eCF;
        }
    }
}
