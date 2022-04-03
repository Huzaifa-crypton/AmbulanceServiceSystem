using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Service_System
{
    internal class NodeBST
    {
        public ECF data;
        public NodeBST left = null;
        public NodeBST right = null;
        public NodeBST parent = null;
        public NodeBST(ECF data)
        {
            this.data = data;
        }
    }
}
