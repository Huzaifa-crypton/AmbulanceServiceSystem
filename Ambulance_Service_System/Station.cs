using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Service_System
{
    internal class Station
    {
        public string name;
        public string hospitalname;
        public int stationLanes;
        public int capacityLane;
        public LinkedList allambulances;
        public static int totalStations;
        public int addedAmbulances;
        public Station(string name,string hospitalname,int stationLanes,int capacityLane)
        {
            totalStations++;
            this.name = name;
            this.addedAmbulances = 0;
            this.hospitalname = hospitalname;
            this.stationLanes = stationLanes;
            this.capacityLane = capacityLane;
            allambulances = new LinkedList();
            for(int i = 0; i < capacityLane; i++)
            {
               this.allambulances.insertAtHead(new Stack());
            }
        }
        public void addAmbulances(LinkedList ambulances)
        {
            NodeLinkedList node = ambulances.head;
            while (node != null)
            {
                Ambulance ambulance = node.ambulance;
                addAmbulance(ambulance);                
                node = node.next;
            }
        }
        public void addAmbulance(Ambulance ambulance)
        {
            addedAmbulances++;
            NodeLinkedList listNode = allambulances.head;
            while (listNode != null)
            {
                Stack ambulancesLane = listNode.ambulancesLane;
                if (ambulancesLane.findLength() < capacityLane)
                {
                    ambulancesLane.push(ambulance);
                    break;
                }
                listNode = listNode.next;
            }
        }
        public int currentNumberOfAmbulances()
        {
            int currentAmbulances = 0;
            NodeLinkedList node = allambulances.head;
            while (node != null)
            {
                Stack ambulancesLane = node.ambulancesLane;
                currentAmbulances += ambulancesLane.findLength();
                node = node.next;
            }
            return currentAmbulances;
        }
        ~Station()
        {
            totalStations--;
        }
    }
}
