using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Service_System
{
    internal class BSTManager
    {
        private static BSTManager instance = null;
        public BST ecfNamesBST;
        public BST ecfHospitalsBST;
        public BST ecfLocationBST;

        private BSTManager()
        {
            ecfLocationBST = new BST();
            ecfHospitalsBST = new BST();
            ecfNamesBST = new BST();

        }
        public static BSTManager createInstance()
        {
            if (instance == null)
            {
                instance = new BSTManager();

            }
            return instance;
        }
    }
}
