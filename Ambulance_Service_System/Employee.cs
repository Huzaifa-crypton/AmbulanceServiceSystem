using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Service_System
{
    internal class Employee
    {
        public string name;
        public string password;
        public string type;
        public string starttime;
        public string endtime;
        public LinkedList allcalls;
        public Employee(string name,string password,string type,string starttime,string endtime)
        {
            this.name = name;
            this.password = password;
            this.type = type;
            this.starttime = starttime;
            this.endtime = endtime;
            allcalls = new LinkedList();
        }
        public int getAttendedCallsNo()
        {
            int attenedcalls = 0;
            NodeLinkedList node = allcalls.head;
            if (type == "CTWO")
            {
                while (node != null)
                {
                    ECF call = node.call;
                    if(call.responsetime != "")
                    {
                        attenedcalls++;
                    }
                    node = node.next;
                }
            }
            else if (type == "WO")
            {
                while (node != null)
                {
                    ECF call = node.call;
                    if (call.dispatchtime != "")
                    {
                        attenedcalls++;
                    }
                    node = node.next;
                }
            }
            return attenedcalls;
        }
        
        public void addCall(ECF call)
        {
            DateTime callTime = DateTime.ParseExact(call.calltime, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture);
            DateTime startTime = DateTime.ParseExact(starttime, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture);
            DateTime endTime = DateTime.ParseExact(endtime, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture);
            if (DateTime.Compare(callTime,startTime) > 0  && DateTime.Compare(callTime, endTime) < 0)
            {
                allcalls.insertAtHead(call);
            }
        }
    }
}
