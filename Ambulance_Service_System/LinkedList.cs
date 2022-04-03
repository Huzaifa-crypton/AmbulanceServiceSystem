using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Service_System
{
    internal class LinkedList
    {
        public NodeLinkedList head;
        public LinkedList()
        {
            head = null;
        }
        private void insertAtHead(NodeLinkedList newNode)
        {
            NodeLinkedList node = head;
            if (head == null)
            {
                node = newNode;
                head = node;
            }
            else
            {
                head = newNode;
                newNode.next = node;
            }
        }
        private void insertAtEnd(NodeLinkedList newNode)
        {
            NodeLinkedList node = head;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                while (node.next != null)
                {
                    node = node.next;
                }
                node.next = newNode;
            }
        }
        public void insertAtHead(ECF call)
        {
            NodeLinkedList node = new NodeLinkedList(call);
            this.insertAtHead(node);
        }
        public void insertAtHead(City city)
        {
            NodeLinkedList node = new NodeLinkedList(city);
            this.insertAtHead(node);
        }
        public void insertAtHead(Station station)
        {
            NodeLinkedList node = new NodeLinkedList(station);
            this.insertAtHead(node);
        }
        public void insertAtHead(Stack ambulancesLane)
        {
            NodeLinkedList node = new NodeLinkedList(ambulancesLane);
            this.insertAtHead(node);
        }
        public void insertAtHead(User station)
        {
            NodeLinkedList node = new NodeLinkedList(station);
            this.insertAtHead(node);
        }
        public void insertAtHead(Employee ambulancesLane)
        {
            NodeLinkedList node = new NodeLinkedList(ambulancesLane);
            this.insertAtHead(node);
        }
        public void insertAtEnd(ECF call)
        {
            NodeLinkedList node = new NodeLinkedList(call);
            this.insertAtEnd(node);
        }
        public void insertAtEnd(City city)
        {
            NodeLinkedList node = new NodeLinkedList(city);
            this.insertAtEnd(node);
        }
        public void insertAtEnd(Station station)
        {
            NodeLinkedList node = new NodeLinkedList(station);
            this.insertAtEnd(node);
        }
        public void insertAtEnd(Stack ambulancesLane)
        {
            NodeLinkedList node = new NodeLinkedList(ambulancesLane);
            this.insertAtEnd(node);
        }
        public void insertAtEnd(Employee ambulancesLane)
        {
            NodeLinkedList node = new NodeLinkedList(ambulancesLane);
            this.insertAtEnd(node);
        }
        public void insertAtEnd(User user)
        {
            NodeLinkedList node = new NodeLinkedList(user);
            this.insertAtEnd(node);
        }
        public void insertAtEnd(Ambulance ambulance)
        {
            NodeLinkedList node = new NodeLinkedList(ambulance);
            this.insertAtEnd(node);
        }
        public Employee findNodeEmployee(string name, string pass)
        {
            NodeLinkedList nodeLinkedList = head;
            while (nodeLinkedList != null)
            {
                if (nodeLinkedList.employee.name == name && nodeLinkedList.employee.password == pass)
                {
                    return nodeLinkedList.employee;
                }
                nodeLinkedList = nodeLinkedList.next;
            }
            return null;
        }
        public User findNodeUser(string name, string pass)
        {
            NodeLinkedList nodeLinkedList = head;
            while (nodeLinkedList != null)
            {
                if ((nodeLinkedList.user.name == name || nodeLinkedList.user.email == name) && nodeLinkedList.user.password == pass)
                {
                    return nodeLinkedList.user;
                }
                nodeLinkedList = nodeLinkedList.next;
            }
            return null;
        }
        public User findNodeUser(string name)
        {
            NodeLinkedList nodeLinkedList = head;
            while (nodeLinkedList != null)
            {
                if (nodeLinkedList.user.name == name || nodeLinkedList.user.email == name)
                {
                    return nodeLinkedList.user;
                }
                nodeLinkedList = nodeLinkedList.next;
            }
            return null;
        }
        public City findNodeCity(string name)
        {
            NodeLinkedList nodeLinkedList = head;
            while (nodeLinkedList != null)
            {
                if (nodeLinkedList.city.name == name)
                {
                    return nodeLinkedList.city;
                }
                nodeLinkedList = nodeLinkedList.next;
            }
            return null;
        }
        public int findLength()
        {
            NodeLinkedList node = head;
            int counter = 0;
            while (node != null)
            {
                counter++;
                node = node.next;
            }
            return counter;
        }
        public NodeLinkedList getNode(int index)
        {
            NodeLinkedList node = head;
            int counter = 0;
            while (node != null)
            {
                if (counter == index)
                {
                    return node;
                }
                node = node.next;
                counter++;
            }
            return node;
        }
        public Station findNodeStation(string name)
        {
            NodeLinkedList nodeLinkedList = head;
            while (nodeLinkedList != null)
            {
                Station station = nodeLinkedList.station;
                if (station.name == name)
                {
                    return station;
                }
                nodeLinkedList = nodeLinkedList.next;
            }
            return null;
        }
        public void writeUserLinkedListinCSV(string path)
        {
            try
            {
                System.IO.File.WriteAllText(path, String.Empty);
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@path, false))
                {
                    NodeLinkedList nodeLinkedList = head;
                    while(nodeLinkedList != null)
                    {
                        User user = nodeLinkedList.user;
                        file.WriteLine(user.name + "," + user.email + "," + user.phonenumber + "," + user.password);
                        nodeLinkedList = nodeLinkedList.next;
                    }
                }
            }
            catch(Exception)
            {
                throw new ApplicationException("This program did not work");
            }
        }
        public void writeCityLinkedListinCSV(string path)
        {
            try
            {
                System.IO.File.WriteAllText(path, String.Empty);
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@path, false))
                {
                    NodeLinkedList nodeLinkedList = head;
                    while (nodeLinkedList != null)
                    {
                        City city = nodeLinkedList.city;
                        file.WriteLine(city.name);
                        nodeLinkedList = nodeLinkedList.next;
                    }
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("This program did not work");
            }
        }
        public void writeStationLinkedListinCSV(string path,string cityName)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@path, false))
                {
                    NodeLinkedList nodeLinkedList = head;
                    while (nodeLinkedList != null)
                    {
                        Station station = nodeLinkedList.station;
                        file.WriteLine(cityName+","+station.name+","+station.hospitalname+","+station.stationLanes+","+station.capacityLane+","+station.addedAmbulances);
                        nodeLinkedList = nodeLinkedList.next;
                    }
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("This program did not work");
            }
        }

        public void writeAmbulancesLinkedListinCSV(string path, string cityName,string stationName)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@path, false))
                {
                    NodeLinkedList nodeLinkedList = head;
                    while (nodeLinkedList != null)
                    {
                        Stack stack = nodeLinkedList.ambulancesLane;
                        NodeStack lane = stack.head;
                        while (lane != null)
                        {
                            Ambulance ambulance = lane.ambulance;
                            file.WriteLine(cityName +","+ stationName+","+ ambulance.platenumber+","+ambulance.modelnumber);
                            lane = lane.next;
                        }
                        nodeLinkedList = nodeLinkedList.next;
                    }
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("This program did not work");
            }
        }
        public void writeEmployeeLinkedListinCSV(string path)
        {
            try
            {
                System.IO.File.WriteAllText(path, String.Empty);
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@path, false))
                {
                    NodeLinkedList nodeLinkedList = head;
                    while (nodeLinkedList != null)
                    {
                        Employee employee = nodeLinkedList.employee;
                        file.WriteLine(employee.name + "," + employee.password + "," + employee.type + "," + employee.starttime +","+ employee.endtime);
                        nodeLinkedList = nodeLinkedList.next;
                    }
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("This program did not work");
            }
        }
    }
}
