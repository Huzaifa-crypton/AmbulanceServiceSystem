using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Service_System
{
    internal class Queue
    {
        public NodeQueue head;
        public NodeQueue tail;
        public Queue()
        {
            head = null;
            tail = null;
        }
        public void enqueue(ECF eCF)
        {
            NodeQueue n = new NodeQueue(eCF);
            if (head == null)
            {
                head = n;
                tail = n;
            }
            else
            {
                tail.next = n;
                tail = n;
            }
        }
        public NodeQueue dequeue()
        {
            NodeQueue y = head;
            head = head.next;
            if (head == null)
            {
                tail = null;
            }
            return y;
        }
        public bool isEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void printQueue()
        {
            NodeQueue temp = head;
            while (temp != null)
            {
                /*Console.Write(temp.key.ToString(), " . ");*/
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
