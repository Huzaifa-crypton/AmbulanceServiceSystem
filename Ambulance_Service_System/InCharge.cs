using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Service_System
{
    internal class InCharge
    {
        public string name;
        public string password;
        public LinkedList allemployees;
        public LinkedList allcities;
        public InCharge(string name,string password)
        {
            this.name = name;
            this.password = password;
            allemployees = new LinkedList();
            allcities = new LinkedList();
        }

        public Station getStation(string name)
        {
            NodeLinkedList cityNode = allcities.head;
            while (cityNode != null)
            {
                NodeLinkedList stationNode = cityNode.city.allstations.head;
                while (stationNode != null)
                {
                    Station station = stationNode.station;
                    if(station.name == name)
                    {
                        return station;
                    }
                    stationNode = stationNode.next;
                }
                cityNode = cityNode.next;
            }
            return null;
        }
    }
}
