using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambulance_Service_System
{
    public partial class InChargeForm : Form
    {
        private int index = 0;
        private LinkedList addedStations;
        private LinkedList addedAmbulances;
        public InChargeForm()
        {
            InitializeComponent();

            addedStations = new LinkedList();
            addedAmbulances = new LinkedList();
            bstDropdown.SelectedIndex = 0;
            UpdateHomePage();
            UpdateCTWOWOPage();
            updateEmployeesData();
            UpdateAddCityPage();
            UpdateAddStationPage();
        }

        private void home_Click(object sender, EventArgs e)
        {
            UpdateHomePage();
            bunifuPages.SetPage("Home");
            homeBtn.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            operatorsBtn.BaseColor = Color.White;
            ecfBtn.BaseColor = Color.White;
            cityBtn.BaseColor = Color.White;
            stationBtn.BaseColor = Color.White;
            logoutBtn.BaseColor = Color.White;
        }

        private void ctwowo_Click(object sender, EventArgs e)
        {
            bunifuPages.SetPage("CTWOWO");
            updateEmployeesData();
            UpdateCTWOWOPage();
            homeBtn.BaseColor = Color.White;
            operatorsBtn.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ecfBtn.BaseColor = Color.White;
            cityBtn.BaseColor = Color.White;
            stationBtn.BaseColor = Color.White;
            logoutBtn.BaseColor = Color.White;
        }

        private void viewecf_Click(object sender, EventArgs e)
        {
            bunifuPages.SetPage("ViewRequests");
            UpdateViewECFPage();
            homeBtn.BaseColor = Color.White;
            operatorsBtn.BaseColor = Color.White;
            ecfBtn.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            cityBtn.BaseColor = Color.White;
            stationBtn.BaseColor = Color.White;
            logoutBtn.BaseColor = Color.White;
        }

        private void addcity_Click(object sender, EventArgs e)
        {
            bunifuPages.SetPage("AddCity");
            UpdateAddCityPage();
            homeBtn.BaseColor = Color.White;
            operatorsBtn.BaseColor = Color.White;
            ecfBtn.BaseColor = Color.White;
            cityBtn.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            stationBtn.BaseColor = Color.White;
            logoutBtn.BaseColor = Color.White;
        }

        private void addstation_Click(object sender, EventArgs e)
        {
            bunifuPages.SetPage("AddParkingStation");
            UpdateAddStationPage();
            homeBtn.BaseColor = Color.White;
            operatorsBtn.BaseColor = Color.White;
            ecfBtn.BaseColor = Color.White;
            cityBtn.BaseColor = Color.White;
            stationBtn.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            logoutBtn.BaseColor = Color.White;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.loginForm.Closed += (s, arg) => this.Close();
            Program.loginForm.Show();
        }

        private void closeBtn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            index++;
            if (index >= Program.incharge.allemployees.findLength())
            {
                index = 0;
            }
            UpdateHomePage();
        }

        public void UpdateHomePage()
        {
            usersLabel.Text = (User.totalUsers).ToString();
            ecfLabel.Text = (ECF.totalECFs).ToString();
            citiesLabel.Text = (City.totalCities).ToString();
            stationsLabel.Text = (Station.totalStations).ToString();
            NodeLinkedList node = Program.incharge.allemployees.getNode(index);
            if (node != null)
            {
                Employee employee = node.employee;
                employeeNameLabel.Text = employee.name;
                employeeTypeLabel.Text = employee.type;
                shifttimeLabel.Text = employee.starttime + " - " + employee.endtime;
                int totalCalls = employee.allcalls.findLength();
                int attendedCalls = employee.getAttendedCallsNo();
                callsLabel.Text = attendedCalls.ToString() + " / " + totalCalls.ToString();
                if (totalCalls != 0)
                {
                    circleProgress.Value = (attendedCalls / totalCalls) * 100;
                }
                else
                {
                    circleProgress.Value = 0;
                }
            }
        }

        public void UpdateCTWOWOPage()
        {
            ctwo1Nametb.PlaceholderForeColor = Color.Silver;
            ctwo1Nametb.PlaceholderText = "Full Name";
            ctwo1Passtb.PlaceholderForeColor = Color.Silver;
            ctwo1Passtb.PlaceholderText = "Password";
            ctwo2Nametb.PlaceholderForeColor = Color.Silver;
            ctwo2Nametb.PlaceholderText = "Full Name";
            ctwo2Passtb.PlaceholderForeColor = Color.Silver;
            ctwo2Passtb.PlaceholderText = "Password";
            ctwo3Nametb.PlaceholderForeColor = Color.Silver;
            ctwo3Nametb.PlaceholderText = "Full Name";
            ctwo3Passtb.PlaceholderForeColor = Color.Silver;
            ctwo3Passtb.PlaceholderText = "Password";
            wo1Nametb.PlaceholderForeColor = Color.Silver;
            wo1Nametb.PlaceholderText = "Full Name";
            wo1Passtb.PlaceholderForeColor = Color.Silver;
            wo1Passtb.PlaceholderText = "Password";
            wo2Nametb.PlaceholderForeColor = Color.Silver;
            wo2Nametb.PlaceholderText = "Full Name";
            wo2Passtb.PlaceholderForeColor = Color.Silver;
            wo2Passtb.PlaceholderText = "Password";
            wo3Nametb.PlaceholderForeColor = Color.Silver;
            wo3Nametb.PlaceholderText = "Full Name";
            wo3Passtb.PlaceholderForeColor = Color.Silver;
            wo3Passtb.PlaceholderText = "Password";
        }

        public void updateEmployeesData()
        {
            NodeLinkedList node1 = Program.incharge.allemployees.getNode(0);
            NodeLinkedList node2 = Program.incharge.allemployees.getNode(1);
            NodeLinkedList node3 = Program.incharge.allemployees.getNode(2);
            NodeLinkedList node4 = Program.incharge.allemployees.getNode(3);
            NodeLinkedList node5 = Program.incharge.allemployees.getNode(4);
            NodeLinkedList node6 = Program.incharge.allemployees.getNode(5);
            if (node1 != null)
            {
                ctwo1Nametb.Text = node1.employee.name;
                ctwo1Passtb.Text = node1.employee.password;
            }
            if (node2 != null)
            {
                ctwo2Nametb.Text = node2.employee.name;
                ctwo2Passtb.Text = node2.employee.password;
            }
            if (node3 != null)
            {
                ctwo3Nametb.Text = node3.employee.name;
                ctwo3Passtb.Text = node3.employee.password;
            }
            if (node4 != null)
            {
                wo1Nametb.Text = node4.employee.name;
                wo1Passtb.Text = node4.employee.password;
            }
            if (node5 != null)
            {
                wo2Nametb.Text = node5.employee.name;
                wo2Passtb.Text = node5.employee.password;
            }
            if (node6 != null)
            {
                wo3Nametb.Text = node6.employee.name;
                wo3Passtb.Text = node6.employee.password;
            }
        }
        public void UpdateAddCityPage()
        {
            cityNametb.Text = "";
            cityNametb.PlaceholderForeColor = Color.Silver;
            cityNametb.PlaceholderText = "Enter Name...";
            allStationstb.Text = "";
            stationsComboBox.Items.Clear();
            stationsComboBox.Items.Add("Select Station");
            stationsComboBox.SelectedIndex = 0;
            NodeLinkedList cityNode = Program.incharge.allcities.head;
            while (cityNode != null)
            {
                City city = cityNode.city;
                NodeLinkedList stationNode = city.allstations.head;
                while (stationNode != null)
                {
                    bool isFound = false;
                    Station station = stationNode.station;
                    for (int i = 0; i < stationsComboBox.Items.Count; i++)
                    {
                        if (stationsComboBox.Items[i].ToString() == station.name)
                        {
                            isFound = true;
                        }
                    }
                    if (isFound != true)
                    {
                        stationsComboBox.Items.Add(station.name);
                    }
                    stationNode = stationNode.next;
                }
                cityNode = cityNode.next;
            }
        }

        public void UpdateViewECFPage()
        {
            gridViewECF.Rows.Clear();
            if (bstDropdown.SelectedItem.ToString() == "Name" || bstDropdown.SelectedIndex == 0)
            {
                showData(Program.ecfNamesBST.root);
            }
            else if (bstDropdown.SelectedItem.ToString() == "Location" || bstDropdown.SelectedIndex == 1)
            {
                showData(Program.ecfLocationBST.root);
            }
            else if (bstDropdown.SelectedItem.ToString() == "Hospital Name" || bstDropdown.SelectedIndex == 2)
            {
                showData(Program.ecfHospitalsBST.root);
            }
        }

        private void showData(NodeBST node)
        {
            if (node != null)
            {
                showData(node.left);
                Station station = node.data.dispatchedStation;
                if (station != null)
                {
                    gridViewECF.Rows.Add(node.data.id, node.data.caller.name, node.data.location, station.hospitalname, node.data.caller.phonenumber, node.data.calltime, node.data.responsetime, node.data.dispatchtime, node.data.arrivaltime);
                }
                else
                {
                    gridViewECF.Rows.Add(node.data.id, node.data.caller.name, node.data.location, "", node.data.caller.phonenumber, node.data.calltime, node.data.responsetime, node.data.dispatchtime, node.data.arrivaltime);
                }
                showData(node.right);
            }
        }

        public void UpdateAddStationPage()
        {
            allCitiesComboBox.Items.Clear();
            allCitiesComboBox.Items.Add("Select City");
            allCitiesComboBox.SelectedIndex = 0;
            stationsLaneNumeric.Value = 0;
            capacityPerLaneNumeric.Value = 0;
            hospitalNametb.Text = "";
            hospitalNametb.PlaceholderForeColor = Color.Silver;
            hospitalNametb.PlaceholderText = "Enter Hospital Name";
            stationNametb.PlaceholderText = "Enter Parking Station Name";
            stationNametb.PlaceholderForeColor = Color.Silver;
            stationNametb.Text = "";
            ambulancemodeltb.Text = "";
            ambulancemodeltb.PlaceholderForeColor = Color.Silver;
            ambulancemodeltb.PlaceholderText = "Ambulance Model";
            ambulancemodeltb.Text = "";
            ambulancePlateNumbertb.PlaceholderForeColor = Color.Silver;
            ambulancePlateNumbertb.PlaceholderText = "Ambulance Plate Number";
            NodeLinkedList node = Program.incharge.allcities.head;
            while (node != null)
            {
                City city = node.city;
                allCitiesComboBox.Items.Add(city.name);
                node = node.next;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            gridViewECF.Rows.Clear();
            if (searchtb.Text != "")
            {
                if (bstDropdown.SelectedIndex == 0)
                {
                    NodeBST node = Program.ecfNamesBST.search(searchtb.Text, BSTTypes.NameBST);
                    while (node != null)
                    {
                        Station station = node.data.dispatchedStation;
                        if (station != null && (node.data.caller.name == searchtb.Text))
                        {
                            gridViewECF.Rows.Add(node.data.id, node.data.caller.name, node.data.location, station.hospitalname, node.data.caller.phonenumber, node.data.calltime, node.data.responsetime, node.data.dispatchtime, node.data.arrivaltime);
                        }
                        else
                        {
                            gridViewECF.Rows.Add(node.data.id, node.data.caller.name, node.data.location, "", node.data.caller.phonenumber, node.data.calltime, node.data.responsetime, node.data.dispatchtime, node.data.arrivaltime);
                        }
                        node = node.left;
                    }
                }
                else if (bstDropdown.SelectedIndex == 1)
                {
                    NodeBST node = Program.ecfLocationBST.search(searchtb.Text, BSTTypes.LocationBST);
                    while (node != null)
                    {
                        Station station = node.data.dispatchedStation;
                        if (station != null && (node.data.location == searchtb.Text))
                        {
                            gridViewECF.Rows.Add(node.data.id, node.data.caller.name, node.data.location, station.hospitalname, node.data.caller.phonenumber, node.data.calltime, node.data.responsetime, node.data.dispatchtime, node.data.arrivaltime);
                        }
                        else
                        {
                            gridViewECF.Rows.Add(node.data.id, node.data.caller.name, node.data.location, "", node.data.caller.phonenumber, node.data.calltime, node.data.responsetime, node.data.dispatchtime, node.data.arrivaltime);
                        }
                        node = node.left;
                    }
                }
                else if (bstDropdown.SelectedIndex == 2)
                {
                    NodeBST node = Program.ecfHospitalsBST.search(searchtb.Text, BSTTypes.HospitalNameBST);
                    while (node != null)
                    {
                        Station station = node.data.dispatchedStation;
                        if (station != null && (node.data.dispatchedStation.hospitalname == searchtb.Text))
                        {
                            gridViewECF.Rows.Add(node.data.id, node.data.caller.name, node.data.location, station.hospitalname, node.data.caller.phonenumber, node.data.calltime, node.data.responsetime, node.data.dispatchtime, node.data.arrivaltime);
                        }
                        else
                        {
                            gridViewECF.Rows.Add(node.data.id, node.data.caller.name, node.data.location, "", node.data.caller.phonenumber, node.data.calltime, node.data.responsetime, node.data.dispatchtime, node.data.arrivaltime);
                        }
                        node = node.left;
                    }
                }
            }
            else
            {
                UpdateViewECFPage();
            }
        }

        private void editBtn1_Click(object sender, EventArgs e)
        {
            if (ctwo1Nametb.Enabled == false)
            {
                //EDIT ON
                ctwo1Nametb.Enabled = true;
                ctwo1Passtb.Enabled = true;
                editBtn1.Image = Properties.Resources.tick;
                editBtn1.BaseColor = Color.MediumSeaGreen;
                editBtn1.OnHoverBaseColor = Color.SeaGreen;
            }
            else
            {
                //EDIT OFF
                if (ctwo1Nametb.Text != "" && ctwo1Passtb.Text != "")
                {
                    ctwo1Nametb.Enabled = false;
                    ctwo1Passtb.Enabled = false;
                    NodeLinkedList node = Program.incharge.allemployees.getNode(0);
                    if (node != null)
                    {
                        Employee employee = node.employee;
                        employee.name = ctwo1Nametb.Text;
                        employee.password = ctwo1Passtb.Text;
                    }
                    Program.incharge.allemployees.writeEmployeeLinkedListinCSV(Program.employeesPath);
                    editBtn1.Image = Properties.Resources.pencil;
                    editBtn1.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    editBtn1.OnHoverBaseColor = Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                }
                else
                {
                    if (ctwo1Nametb.Text == "")
                    {
                        ctwo1Nametb.PlaceholderForeColor = Color.Red;
                        ctwo1Nametb.PlaceholderText = "Fill the box";
                    }
                    if (ctwo1Passtb.Text == "")
                    {
                        ctwo1Passtb.PlaceholderForeColor = Color.Red;
                        ctwo1Passtb.PlaceholderText = "Fill the box";
                    }
                }
            }
        }

        private void editBtn2_Click(object sender, EventArgs e)
        {
            if (ctwo2Nametb.Enabled == false)
            {
                //EDIT ON
                ctwo2Nametb.Enabled = true;
                ctwo2Passtb.Enabled = true;
                editBtn2.Image = Properties.Resources.tick;
                editBtn2.BaseColor = Color.MediumSeaGreen;
                editBtn2.OnHoverBaseColor = Color.SeaGreen;
            }
            else
            {
                //EDIT OFF
                if (ctwo2Nametb.Text != "" && ctwo2Passtb.Text != "")
                {
                    ctwo2Nametb.Enabled = false;
                    ctwo2Passtb.Enabled = false;
                    NodeLinkedList node = Program.incharge.allemployees.getNode(1);
                    if (node != null)
                    {
                        Employee employee = node.employee;
                        employee.name = ctwo2Nametb.Text;
                        employee.password = ctwo2Passtb.Text;
                    }
                    Program.incharge.allemployees.writeEmployeeLinkedListinCSV(Program.employeesPath);
                    editBtn2.Image = Properties.Resources.pencil;
                    editBtn2.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    editBtn2.OnHoverBaseColor = Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                }
                else
                {
                    if (ctwo2Nametb.Text == "")
                    {
                        ctwo2Nametb.PlaceholderForeColor = Color.Red;
                        ctwo2Nametb.PlaceholderText = "Fill the box";
                    }
                    if (ctwo2Passtb.Text == "")
                    {
                        ctwo2Passtb.PlaceholderForeColor = Color.Red;
                        ctwo2Passtb.PlaceholderText = "Fill the box";
                    }
                }
            }
        }

        private void editBtn3_Click(object sender, EventArgs e)
        {
            if (ctwo3Nametb.Enabled == false)
            {
                //EDIT ON
                ctwo3Nametb.Enabled = true;
                ctwo3Passtb.Enabled = true;
                editBtn3.Image = Properties.Resources.tick;
                editBtn3.BaseColor = Color.MediumSeaGreen;
                editBtn3.OnHoverBaseColor = Color.SeaGreen;
            }
            else
            {
                //EDIT OFF
                if (ctwo3Nametb.Text != "" && ctwo3Passtb.Text != "")
                {
                    ctwo3Nametb.Enabled = false;
                    ctwo3Passtb.Enabled = false;
                    NodeLinkedList node = Program.incharge.allemployees.getNode(2);
                    if (node != null)
                    {
                        Employee employee = node.employee;
                        employee.name = ctwo3Nametb.Text;
                        employee.password = ctwo3Passtb.Text;
                    }
                    Program.incharge.allemployees.writeEmployeeLinkedListinCSV(Program.employeesPath);
                    editBtn3.Image = Properties.Resources.pencil;
                    editBtn3.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    editBtn3.OnHoverBaseColor = Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                }
                else
                {
                    if (ctwo3Nametb.Text == "")
                    {
                        ctwo3Nametb.PlaceholderForeColor = Color.Red;
                        ctwo3Nametb.PlaceholderText = "Fill the box";
                    }
                    if (ctwo3Passtb.Text == "")
                    {
                        ctwo3Passtb.PlaceholderForeColor = Color.Red;
                        ctwo3Passtb.PlaceholderText = "Fill the box";
                    }
                }
            }
        }

        private void editBtn4_Click(object sender, EventArgs e)
        {
            if (wo1Nametb.Enabled == false)
            {
                //EDIT ON
                wo1Nametb.Enabled = true;
                wo1Passtb.Enabled = true;
                editBtn4.Image = Properties.Resources.tick;
                editBtn4.BaseColor = Color.MediumSeaGreen;
                editBtn4.OnHoverBaseColor = Color.SeaGreen;
            }
            else
            {
                //EDIT OFF
                if (wo1Nametb.Text != "" && wo1Passtb.Text != "")
                {
                    wo1Nametb.Enabled = false;
                    wo1Passtb.Enabled = false;
                    NodeLinkedList node = Program.incharge.allemployees.getNode(3);
                    if (node != null)
                    {
                        Employee employee = node.employee;
                        employee.name = wo1Nametb.Text;
                        employee.password = wo1Passtb.Text;
                    }
                    Program.incharge.allemployees.writeEmployeeLinkedListinCSV(Program.employeesPath);
                    editBtn4.Image = Properties.Resources.pencil;
                    editBtn4.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    editBtn4.OnHoverBaseColor = Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                }
                else
                {
                    if (wo1Nametb.Text == "")
                    {
                        wo1Nametb.PlaceholderForeColor = Color.Red;
                        wo1Nametb.PlaceholderText = "Fill the box";
                    }
                    if (wo1Passtb.Text == "")
                    {
                        wo1Passtb.PlaceholderForeColor = Color.Red;
                        wo1Passtb.PlaceholderText = "Fill the box";
                    }
                }
            }
        }

        private void editBtn5_Click(object sender, EventArgs e)
        {
            if (wo1Nametb.Enabled == false)
            {
                //EDIT ON
                wo2Nametb.Enabled = true;
                wo2Passtb.Enabled = true;
                editBtn5.Image = Properties.Resources.tick;
                editBtn5.BaseColor = Color.MediumSeaGreen;
                editBtn5.OnHoverBaseColor = Color.SeaGreen;
            }
            else
            {
                //EDIT OFF
                if (wo2Nametb.Text != "" && wo2Passtb.Text != "")
                {
                    wo2Nametb.Enabled = false;
                    wo2Passtb.Enabled = false;
                    NodeLinkedList node = Program.incharge.allemployees.getNode(4);
                    if (node != null)
                    {
                        Employee employee = node.employee;
                        employee.name = wo2Nametb.Text;
                        employee.password = wo2Passtb.Text;
                    }
                    Program.incharge.allemployees.writeEmployeeLinkedListinCSV(Program.employeesPath);
                    editBtn5.Image = Properties.Resources.pencil;
                    editBtn5.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    editBtn5.OnHoverBaseColor = Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                }
                else
                {
                    if (wo2Nametb.Text == "")
                    {
                        wo2Nametb.PlaceholderForeColor = Color.Red;
                        wo2Nametb.PlaceholderText = "Fill the box";
                    }
                    if (wo2Passtb.Text == "")
                    {
                        wo2Passtb.PlaceholderForeColor = Color.Red;
                        wo2Passtb.PlaceholderText = "Fill the box";
                    }
                }
            }
        }

        private void editBtn6_Click(object sender, EventArgs e)
        {
            if (wo3Nametb.Enabled == false)
            {
                //EDIT ON
                wo3Nametb.Enabled = true;
                wo3Passtb.Enabled = true;
                editBtn6.Image = Properties.Resources.tick;
                editBtn6.BaseColor = Color.MediumSeaGreen;
                editBtn6.OnHoverBaseColor = Color.SeaGreen;
            }
            else
            {
                //EDIT OFF
                if (wo3Nametb.Text != "" && wo3Passtb.Text != "")
                {
                    wo3Nametb.Enabled = false;
                    wo3Passtb.Enabled = false;
                    NodeLinkedList node = Program.incharge.allemployees.getNode(5);
                    if (node != null)
                    {
                        Employee employee = node.employee;
                        employee.name = wo3Nametb.Text;
                        employee.password = wo3Passtb.Text;
                    }
                    Program.incharge.allemployees.writeEmployeeLinkedListinCSV(Program.employeesPath);
                    editBtn6.Image = Properties.Resources.pencil;
                    editBtn6.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    editBtn6.OnHoverBaseColor = Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                }
                else
                {
                    if (wo3Nametb.Text == "")
                    {
                        wo3Nametb.PlaceholderForeColor = Color.Red;
                        wo3Nametb.PlaceholderText = "Fill the box";
                    }
                    if (wo3Passtb.Text == "")
                    {
                        wo3Passtb.PlaceholderForeColor = Color.Red;
                        wo3Passtb.PlaceholderText = "Fill the box";
                    }
                }
            }
        }

        private void delBtn1_Click(object sender, EventArgs e)
        {
            ctwo1Nametb.Enabled = false;
            ctwo1Passtb.Enabled = false;
            ctwo1Nametb.Text = "";
            ctwo1Passtb.Text = "";
            NodeLinkedList node = Program.incharge.allemployees.getNode(0);
            if (node != null)
            {
                Employee employee = node.employee;
                employee.name = "";
                employee.password = "";
                employee.allcalls = null;
            }
            Program.incharge.allemployees.writeEmployeeLinkedListinCSV(Program.employeesPath);
        }

        private void delBtn2_Click(object sender, EventArgs e)
        {
            ctwo2Nametb.Enabled = false;
            ctwo2Passtb.Enabled = false;
            ctwo2Nametb.Text = "";
            ctwo2Passtb.Text = "";
            NodeLinkedList node = Program.incharge.allemployees.getNode(1);
            if (node != null)
            {
                Employee employee = node.employee;
                employee.name = "";
                employee.password = "";
                employee.allcalls = null;
            }
            Program.incharge.allemployees.writeEmployeeLinkedListinCSV(Program.employeesPath);
        }

        private void delBtn3_Click(object sender, EventArgs e)
        {
            ctwo3Nametb.Enabled = false;
            ctwo3Passtb.Enabled = false;
            ctwo3Nametb.Text = "";
            ctwo3Passtb.Text = "";
            NodeLinkedList node = Program.incharge.allemployees.getNode(2);
            if (node != null)
            {
                Employee employee = node.employee;
                employee.name = "";
                employee.password = "";
                employee.allcalls = null;
            }
            Program.incharge.allemployees.writeEmployeeLinkedListinCSV(Program.employeesPath);
        }

        private void delBtn4_Click(object sender, EventArgs e)
        {
            wo1Nametb.Enabled = false;
            wo1Passtb.Enabled = false;
            wo1Nametb.Text = "";
            wo1Passtb.Text = "";
            NodeLinkedList node = Program.incharge.allemployees.getNode(3);
            if (node != null)
            {
                Employee employee = node.employee;
                employee.name = "";
                employee.password = "";
                employee.allcalls = null;
            }
            Program.incharge.allemployees.writeEmployeeLinkedListinCSV(Program.employeesPath);
        }

        private void delBtn5_Click(object sender, EventArgs e)
        {
            wo2Nametb.Enabled = false;
            wo2Passtb.Enabled = false;
            wo2Nametb.Text = "";
            wo2Passtb.Text = "";
            NodeLinkedList node = Program.incharge.allemployees.getNode(4);
            if (node != null)
            {
                Employee employee = node.employee;
                employee.name = "";
                employee.password = "";
                employee.allcalls = null;
            }
            Program.incharge.allemployees.writeEmployeeLinkedListinCSV(Program.employeesPath);
        }

        private void delBtn6_Click(object sender, EventArgs e)
        {
            wo3Nametb.Enabled = false;
            wo3Passtb.Enabled = false;
            wo3Nametb.Text = "";
            wo3Passtb.Text = "";
            NodeLinkedList node = Program.incharge.allemployees.getNode(5);
            if (node != null)
            {
                Employee employee = node.employee;
                employee.name = "";
                employee.password = "";
                employee.allcalls = null;
            }
            Program.incharge.allemployees.writeEmployeeLinkedListinCSV(Program.employeesPath);
        }

        private void addcityBtn_Click(object sender, EventArgs e)
        {
            if (cityNametb.Text != "")
            {
                City anyCity = Program.incharge.allcities.findNodeCity(cityNametb.Text);
                if (anyCity == null)
                {
                    City city = new City(cityNametb.Text);
                    NodeLinkedList node = addedStations.head;
                    while (node != null)
                    {
                        Station station = node.station;
                        city.allstations.insertAtEnd(station);
                        node = node.next;
                    }
                    addedStations = new LinkedList();
                    Program.incharge.allcities.insertAtEnd(city);
                    Program.incharge.allcities.writeCityLinkedListinCSV(Program.citiesPath);
                    System.IO.File.WriteAllText(Program.stationsPath, String.Empty);
                    NodeLinkedList cityNode = Program.incharge.allcities.head;
                    while (cityNode != null)
                    {
                        cityNode.city.allstations.writeStationLinkedListinCSV(Program.stationsPath, cityNode.city.name);
                        cityNode = cityNode.next;
                    }
                    cityNametb.Text = "";
                    allStationstb.Text = "";
                    cityNametb.PlaceholderText = "Enter Name...";
                    cityNametb.PlaceholderForeColor = Color.Silver;

                }
                else
                {
                    MessageBox.Show("This City is Already Added!", "Try Another City!");
                }
            }
            else
            {
                cityNametb.PlaceholderText = "Fill the box";
                cityNametb.PlaceholderForeColor = Color.Red;
            }
        }

        private void attstationsBtn_Click(object sender, EventArgs e)
        {
            if (stationsComboBox.SelectedIndex > 0)
            {
                Station station = Program.incharge.getStation(stationsComboBox.Items[stationsComboBox.SelectedIndex].ToString());
                if (station != null)
                {
                    allStationstb.Text += station.name + " , ";
                    addedStations.insertAtEnd(station);
                }
            }
        }

        private void addstationBtn_Click(object sender, EventArgs e)
        {
            if (addedAmbulances.findLength() > 0 && addedAmbulances.findLength() <= (stationsLaneNumeric.Value * capacityPerLaneNumeric.Value) && stationNametb.Text != "" && hospitalNametb.Text != "" && allCitiesComboBox.SelectedIndex > 0 && (stationsLaneNumeric.Value) > 0 && (capacityPerLaneNumeric.Value) > 0)
            {
                Station station = new Station(stationNametb.Text, hospitalNametb.Text, int.Parse(stationsLaneNumeric.Value.ToString()), int.Parse(capacityPerLaneNumeric.Value.ToString()));
                NodeLinkedList node = Program.incharge.allcities.getNode(allCitiesComboBox.SelectedIndex - 1);
                City city = node.city;
                station.addAmbulances(addedAmbulances);
                city.allstations.insertAtEnd(station);
                addedAmbulances = new LinkedList();
                NodeLinkedList cityNode = Program.incharge.allcities.head;
                System.IO.File.WriteAllText(Program.stationsPath, String.Empty);
                System.IO.File.WriteAllText(Program.ambulancesPath, String.Empty);
                while (cityNode != null)
                {
                    cityNode.city.allstations.writeStationLinkedListinCSV(Program.stationsPath, cityNode.city.name);
                    NodeLinkedList stationNode = cityNode.city.allstations.head;
                    while (stationNode != null)
                    {
                        stationNode.station.allambulances.writeAmbulancesLinkedListinCSV(Program.ambulancesPath, cityNode.city.name, stationNode.station.name);
                        stationNode = stationNode.next;
                    }
                    cityNode = cityNode.next;
                }
                stationNametb.Text = "";
                hospitalNametb.Text = "";
                allAmbulancestb.Text = "";
                stationsLaneNumeric.Value = 0;
                capacityPerLaneNumeric.Value = 0;
                calculationAmbulancestb.Text = "Total Added Ambulances / Total Ambulances:    0 / 0";
            }
            else
            {
                if (stationNametb.Text == "")
                {
                    stationNametb.PlaceholderForeColor = Color.Red;
                    stationNametb.PlaceholderText = "Fill the box";
                }
                if (hospitalNametb.Text == "")
                {
                    hospitalNametb.PlaceholderForeColor = Color.Red;
                    hospitalNametb.PlaceholderText = "Fill the box";
                }
            }
        }

        private void addAmbulanceBtn_Click(object sender, EventArgs e)
        {
            if (ambulancePlateNumbertb.Text != "" && ambulancemodeltb.Text != "")
            {
                Ambulance ambulance = new Ambulance(ambulancePlateNumbertb.Text, ambulancemodeltb.Text);
                allAmbulancestb.Text += ambulance.platenumber + " , " + ambulance.modelnumber + " - ";
                addedAmbulances.insertAtEnd(ambulance);
                calculationAmbulancestb.Text = "Total Added Ambulances / Total Ambulances:    " + (addedAmbulances.findLength()) + "/" + (stationsLaneNumeric.Value * capacityPerLaneNumeric.Value);
                ambulancemodeltb.Text = "";
                ambulancePlateNumbertb.Text = "";
            }
            else
            {
                if (ambulancemodeltb.Text == "")
                {
                    ambulancemodeltb.PlaceholderForeColor = Color.Red;
                    ambulancemodeltb.PlaceholderText = "Fill the box";
                }
                if (ambulancePlateNumbertb.Text == "")
                {
                    ambulancePlateNumbertb.PlaceholderForeColor = Color.Red;
                    ambulancePlateNumbertb.PlaceholderText = "Fill the box";
                }
            }
        }

        private void stationsLaneNumeric_ValueChanged(object sender, EventArgs e)
        {
            addedAmbulances = new LinkedList();
            allAmbulancestb.Text = "";
            calculationAmbulancestb.Text = "Total Added Ambulances / Total Ambulances:    0 / " + (stationsLaneNumeric.Value * capacityPerLaneNumeric.Value);
        }

        private void capacityPerLaneNumeric_ValueChanged(object sender, EventArgs e)
        {
            addedAmbulances = new LinkedList();
            allAmbulancestb.Text = "";
            calculationAmbulancestb.Text = "Total Added Ambulances / Total Ambulances:    0 / " + (stationsLaneNumeric.Value * capacityPerLaneNumeric.Value);
        }

        private void InChargeForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                addedStations = new LinkedList();
                addedAmbulances = new LinkedList();
                bstDropdown.SelectedIndex = 0;
                UpdateHomePage();
                UpdateCTWOWOPage();
                updateEmployeesData();
                UpdateViewECFPage();
                UpdateAddCityPage();
                UpdateAddStationPage();
            }
        }
    }
}