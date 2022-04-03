using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Service_System
{
    internal class Stack
    {

        public NodeStack head;
        public Stack()
        {
            head = null;
        }
        public void push(Ambulance ambulance)
        {
            NodeStack node = new NodeStack(ambulance);
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }
        public NodeStack pop()
        {
            NodeStack temp = head;
            if (head != null)
            {
                head = head.next;
            }
            return temp;
        }
        public int findLength()
        {
            int size = 0;
            NodeStack temp = head;
            while(temp != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
        }
    }
}
