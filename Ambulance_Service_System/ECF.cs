using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Service_System
{
    internal class ECF
    {
        public User caller;
        public Ambulance dispatchedAmbulacne;
        public Station dispatchedStation;
        public int id;
        public string location;
        public string emergency;
        public string calltime;
        public string responsetime;
        public string dispatchtime;
        public string arrivaltime;
        public static int totalECFs;
        public ECF(User caller,int id,string location,string emergency,string calltime,string responsetime,string dispatchtime,string arrivaltime)
        {
            totalECFs++;
            this.caller = caller;
            this.id = id;
            this.location = location;
            this.calltime = calltime;
            this.emergency = emergency;
            this.responsetime = responsetime;
            this.dispatchtime = dispatchtime;
            this.arrivaltime = arrivaltime;
        }
        public static int findLargestNode(ECF call1, ECF call2,BSTTypes type)
        {
            if(type == BSTTypes.NameBST)
            {
                return string.Compare(call1.caller.name, call2.caller.name);
            }
            if( type == BSTTypes.LocationBST)
            {
                return string.Compare(call1.location, call2.location);
            }
            if (type == BSTTypes.HospitalNameBST)
            {
                return string.Compare(call1.dispatchedStation.hospitalname, call2.dispatchedStation.hospitalname);
            }
            return 0;
        }
        public static int findLargestNode(ECF call, string data, BSTTypes type)
        {
            if (type == BSTTypes.NameBST)
            {
                return string.Compare(call.caller.name, data);
            }
            if (type == BSTTypes.LocationBST)
            {
                return string.Compare(call.location, data);
            }
            if (type == BSTTypes.HospitalNameBST)
            {
                return string.Compare(call.dispatchedStation.hospitalname, data);
            }
            return 0;
        }
        ~ECF()
        {
            totalECFs--;
        }
    }
}