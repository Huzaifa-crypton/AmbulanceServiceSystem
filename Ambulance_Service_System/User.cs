using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Service_System
{
    internal class User
    {
        public string name;
        public string email;
        public string phonenumber;
        public string password;
        public LinkedList allcalls;
        public static int totalUsers;
        public User(string name,string email,string phonenumber,string password)
        {
            totalUsers++;
            this.name = name;
            this.email = email;
            this.phonenumber = phonenumber;
            this.password = password;
            this.allcalls = new LinkedList();
        }
        ~User()
        {
            totalUsers--;
        }
    }
}
