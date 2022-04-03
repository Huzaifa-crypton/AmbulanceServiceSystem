using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambulance_Service_System
{
    internal static class Program
    {
        public static WOForm woForm;
        public static CTWOForm ctwoForm;
        public static UserForm userForm;
        public static LoginForm loginForm;
        public static SignUpForm signupForm;
        public static InChargeForm inchargeForm;
        public static ForgotPasswordForm forgotPasswordForm;
        public static InCharge incharge;
        public static LinkedList allUsers;
        public static LinkedList allECFs;
        public static int ECFID = 0;
        public static BST ecfNamesBST;
        public static BST ecfHospitalsBST;
        public static BST ecfLocationBST;
        public static Employee currentlyLoginEmployee;
        public static int formNumber = 0;         //THIS NEEDS TO BE FIXED
        public static User currentlyLoginUser;
        public static string employeesPath = System.IO.Path.GetFullPath("../../Database/employees.csv");
        public static string usersPath = System.IO.Path.GetFullPath("../../Database/users.csv");
        public static string citiesPath = System.IO.Path.GetFullPath("../../DataBase/cities.csv");
        public static string stationsPath = System.IO.Path.GetFullPath("../../DataBase/stations.csv");
        public static string ambulancesPath = System.IO.Path.GetFullPath("../../DataBase/ambulances.csv");

        [STAThread]
        static void Main()
        {
            //Loading Data
            incharge = new InCharge("admin", "12345");
            allUsers = new LinkedList();
            allECFs = new LinkedList();
            ecfNamesBST = new BST();
            ecfHospitalsBST = new BST();
            ecfLocationBST = new BST();
            loadDataFromCSV();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Loading Forms
            loginForm = new LoginForm();
            signupForm = new SignUpForm();
            forgotPasswordForm = new ForgotPasswordForm();
            inchargeForm = new InChargeForm();
            ctwoForm = new CTWOForm();
            woForm = new WOForm();
            userForm = new UserForm();

            loginForm.Hide();
            signupForm.Hide();
            forgotPasswordForm.Hide();
            inchargeForm.Hide();
            ctwoForm.Hide();
            woForm.Hide();
            userForm.Hide();

            //Run Application         
            Application.Run(loginForm);
        }
        public static void loadDataFromCSV()
        {
            string[] dataEmployee = File.ReadAllLines(employeesPath);
            string[] dataUsers = File.ReadAllLines(usersPath);
            string[] dataCities = File.ReadAllLines(citiesPath);
            string[] dataStations = File.ReadAllLines(stationsPath);
            string[] dataAmbulances = File.ReadAllLines(ambulancesPath);

            foreach (string data in dataEmployee)
            {
                if (data != "")
                {
                    string[] columns = data.Split(',');
                    string employeeName = columns[0];
                    string employeePass = columns[1];
                    string employeeType = columns[2];
                    string employeeStart = columns[3];
                    string employeeEnd = columns[4];
                    Employee employee = new Employee(employeeName, employeePass, employeeType, employeeStart, employeeEnd);
                    incharge.allemployees.insertAtEnd(employee);
                }
            }
            foreach (string data in dataUsers)
            {
                if (data != "")
                {
                    string[] columns = data.Split(',');
                    string userName = columns[0];
                    string userEmail = columns[1];
                    string userPhonenumber = columns[2];
                    string userPass = columns[3];
                    User user = new User(userName, userEmail, userPhonenumber, userPass); ;
                    allUsers.insertAtEnd(user);
                }
            }

            foreach (string data in dataCities)
            {
                if (data != "")
                {
                    string[] columns = data.Split(',');
                    string name = columns[0];
                    City city = new City(name);
                    incharge.allcities.insertAtEnd(city);
                }
            }
            foreach (string data in dataStations)
            {
                if (data != "")
                {
                    string[] columns = data.Split(',');
                    string cityName = columns[0];
                    string stationName = columns[1];
                    string hospitalName = columns[2];
                    string stationLanes = columns[3];
                    string capacityPerLane = columns[4];
                    City city = incharge.allcities.findNodeCity(cityName);
                    if (city != null)
                    {
                        Station station = new Station(stationName, hospitalName, int.Parse(stationLanes), int.Parse(capacityPerLane));
                        city.allstations.insertAtEnd(station);
                    }
                }
            }
            foreach (string data in dataAmbulances)
            {
                if (data != "")
                {
                    string[] columns = data.Split(',');
                    string cityName = columns[0];
                    string stationName = columns[1];
                    string ambulancePlateNumber = columns[2];
                    string ambulanceModel = columns[3];
                    string ambulanceStatus = columns[4];
                    City city = incharge.allcities.findNodeCity(cityName);
                    if (city != null)
                    {
                        Station station = city.allstations.findNodeStation(stationName);
                        if(station != null)
                        {
                            Ambulance ambulance = new Ambulance(ambulancePlateNumber, ambulanceModel);
                            if(ambulanceStatus == "Free")
                            {
                                station.addAmbulance(ambulance);
                            }
                        }
                    }
                }
            }
        }
    }
}
