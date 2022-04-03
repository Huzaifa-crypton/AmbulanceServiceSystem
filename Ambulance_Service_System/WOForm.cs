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
    public partial class WOForm : Form
    {
        public WOForm()
        {
            InitializeComponent();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            bunifuPages.SetPage("Home");
            UpdateHomePage();
            homeBtn.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            fillFormBtn.BaseColor = Color.White;
            viewecfBtn.BaseColor = Color.White;
            stationsBtn.BaseColor = Color.White;
            logoutBtn.BaseColor = Color.White;
        }

        private void fillFormBtn_Click(object sender, EventArgs e)
        {
            bunifuPages.SetPage("FillForm");
            UpdateFillFormPage();
            fillFormBtn.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            homeBtn.BaseColor = Color.White;
            viewecfBtn.BaseColor = Color.White;
            stationsBtn.BaseColor = Color.White;
            logoutBtn.BaseColor = Color.White;
        }

        private void stationsBtn_Click(object sender, EventArgs e)
        {
            bunifuPages.SetPage("ViewStations");
            UpdateViewStationsPage();
            stationsBtn.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            fillFormBtn.BaseColor = Color.White;
            viewecfBtn.BaseColor = Color.White;
            homeBtn.BaseColor = Color.White;
            logoutBtn.BaseColor = Color.White;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.loginForm.Closed += (s, arg) => this.Close();
            Program.loginForm.Show();
        }

        private void viewecfBtn_Click(object sender, EventArgs e)
        {
            bunifuPages.SetPage("ViewECF");
            UpdateCallsPage();
            viewecfBtn.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            fillFormBtn.BaseColor = Color.White;
            stationsBtn.BaseColor = Color.White;
            homeBtn.BaseColor = Color.White;
            logoutBtn.BaseColor = Color.White;
        }

        private void closeBtn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void UpdateHomePage()
        {
            usersLabel.Text = (User.totalUsers).ToString();
            ecfLabel.Text = (ECF.totalECFs).ToString();
            citiesLabel.Text = (City.totalCities).ToString();
            stationsLabel.Text = (Station.totalStations).ToString();
            if (Program.currentlyLoginEmployee != null)
            {
                employeeNameLabel.Text = Program.currentlyLoginEmployee.name;
                employeeTypeLabel.Text = Program.currentlyLoginEmployee.type;
                shifttimeLabel.Text = Program.currentlyLoginEmployee.starttime + " - " + Program.currentlyLoginEmployee.endtime;
                int totalCalls = Program.currentlyLoginEmployee.allcalls.findLength();
                int attendedCalls = Program.currentlyLoginEmployee.getAttendedCallsNo();
                callsLabel.Text = attendedCalls.ToString() + " / " + totalCalls.ToString();
                if (totalCalls != 0)
                {
                    circleProgress.Value = (attendedCalls / totalCalls);
                }
                else
                {
                    circleProgress.Value = 0;
                }
            }
        }
        public void UpdateViewStationsPage()
        {
            dataGridViewStations.Rows.Clear();
            NodeLinkedList cityNode = Program.incharge.allcities.head;
            while (cityNode != null)
            {
                City city = cityNode.city;
                NodeLinkedList stationNode = city.allstations.head;
                while (stationNode != null)
                {
                    Station station = stationNode.station;
                    dataGridViewStations.Rows.Add(city.name,station.name,station.currentNumberOfAmbulances(),station.addedAmbulances,(station.stationLanes * station.capacityLane));
                    stationNode = stationNode.next;
                }
                cityNode = cityNode.next;
            }
        }

        public void UpdateCallsPage()
        {
            if (Program.currentlyLoginEmployee != null)
            {
                callsDataGridView.Rows.Clear();
                NodeLinkedList callNode = Program.currentlyLoginEmployee.allcalls.head;
                while (callNode != null)
                {
                    callsDataGridView.Rows.Add(callNode.call.id, callNode.call.caller.name, callNode.call.location, callNode.call.emergency, callNode.call.caller.phonenumber);
                    callNode = callNode.next;
                }
            }
        }
        public void UpdateFillFormPage()
        {
            if (Program.currentlyLoginEmployee != null)
            {
                if (Program.currentlyLoginEmployee.allcalls.findLength() > 0)
                {
                    formiddb.Items.Clear();
                    NodeLinkedList node = Program.currentlyLoginEmployee.allcalls.head;
                    while (node != null)
                    {
                        if (node.call.dispatchtime == "")
                        {
                            formiddb.Items.Add(node.call.id);
                        }
                    }
                }
            }
        }

        private void WOForm_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == false)
            {
                UpdateHomePage();
                UpdateFillFormPage();
                UpdateCallsPage();
                UpdateViewStationsPage();
                bunifuPages.SetPage("Home");
                homeBtn.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                fillFormBtn.BaseColor = Color.White;
                viewecfBtn.BaseColor = Color.White;
                stationsBtn.BaseColor = Color.White;
                logoutBtn.BaseColor = Color.White;
            }
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            if (formiddb.Items.Count > 0)
            {
                NodeLinkedList node = Program.currentlyLoginEmployee.allcalls.getNode(formiddb.SelectedIndex);
                if (node.call.dispatchtime != "")
                {
                    City cityNode = Program.incharge.allcities.findNodeCity(node.call.location);
                    NodeLinkedList stationNode = cityNode.allstations.head;
                    while(stationNode != null)
                    {
                        NodeLinkedList ambulancesLane = stationNode.station.allambulances.head;
                        while(ambulancesLane != null)
                        {
                            NodeStack ambulance = ambulancesLane.ambulancesLane.pop();
                            if(ambulance != null && node.call.dispatchedAmbulacne == null && node.call.dispatchedStation == null)
                            {
                                node.call.dispatchedAmbulacne = ambulance.ambulance;
                                node.call.dispatchedStation = stationNode.station;
                            }
                            ambulancesLane = ambulancesLane.next;
                        }
                        stationNode = stationNode.next;
                    }
                    node.call.dispatchtime = DateTime.Now.ToString("hh:mm tt");
                }
                MessageBox.Show("ECF is Confirmed");
            }
        }

        private void formiddb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.currentlyLoginEmployee != null)
            {
                NodeLinkedList node = Program.currentlyLoginEmployee.allcalls.getNode(formiddb.SelectedIndex);
                if (node != null)
                {
                    namecftb.Text = node.call.caller.name;
                    locationecftb.Text = node.call.location;
                    phoneecftb.Text = node.call.caller.phonenumber;
                    emergencytb.Text = node.call.emergency;
                    calltimeecftb.Text = node.call.calltime;
                    responsetimeecftb.Text = node.call.responsetime;
                }
            }
        }
    }
}
