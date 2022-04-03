using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Service_System
{
    internal class LinkedListManager
    {
        private static LinkedListManager instance = null;
        public LinkedList userLinkedList;
        public LinkedList employeeLinkedList;
        public LinkedList emergencyCallForms;

        private LinkedListManager()
        {
            userLinkedList = new LinkedList();
            employeeLinkedList = new LinkedList();
            emergencyCallForms = new LinkedList();

        }
        public static LinkedListManager createInstance()
        {
            if (instance == null)
            {
                instance = new LinkedListManager();

            }
            return instance;
        }
    }
}
