using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Service_System
{
    internal class NodeLinkedList
    {
        public ECF call;
        public City city;
        public Station station;
        public Stack ambulancesLane;
        public Employee employee;
        public Ambulance ambulance;
        public User user;
        public NodeLinkedList next = null;
        public NodeLinkedList(ECF call)
        {
            this.call = call;
        }
        public NodeLinkedList(Employee employee)
        {
            this.employee = employee;
        }
        public NodeLinkedList(User user)
        {
            this.user = user;
        }
        public NodeLinkedList(Ambulance ambulance)
        {
            this.ambulance = ambulance;
        }
        public NodeLinkedList(City city)
        {
            this.city = city;
        }
        public NodeLinkedList(Station station)
        {
            this.station = station;
        }
        public NodeLinkedList(Stack ambulancesLane)
        {
            this.ambulancesLane = ambulancesLane;
        }
    }
}