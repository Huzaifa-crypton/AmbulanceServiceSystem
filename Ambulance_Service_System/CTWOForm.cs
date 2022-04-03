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
    public partial class CTWOForm : Form
    {
        public CTWOForm()
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
            logoutBtn.BaseColor = Color.White;
        }

        private void fillFormBtn_Click(object sender, EventArgs e)
        {
            bunifuPages.SetPage("FillForm");
            UpdateFillFormPage();
            fillFormBtn.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            homeBtn.BaseColor = Color.White;
            viewecfBtn.BaseColor = Color.White;
            logoutBtn.BaseColor = Color.White;
        }

        private void viewecfBtn_Click(object sender, EventArgs e)
        {
            bunifuPages.SetPage("Viewecf");
            UpdateCallsPage();
            viewecfBtn.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            fillFormBtn.BaseColor = Color.White;
            homeBtn.BaseColor = Color.White;
            logoutBtn.BaseColor = Color.White;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        { 
            this.Hide();
            Program.loginForm.Closed += (s, arg) => this.Close();
            Program.loginForm.Show();
        }

        private void closeBtn3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn1_Click(object sender, EventArgs e)
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
            if(Program.currentlyLoginEmployee != null)
            {
                if(Program.currentlyLoginEmployee.allcalls.findLength() > 0)
                {
                    formiddb.Items.Clear();
                    NodeLinkedList node = Program.currentlyLoginEmployee.allcalls.head;
                    while (node != null)
                    {
                        if(node.call.responsetime == "")
                        {
                            formiddb.Items.Add(node.call.id);
                        }
                    }
                }
            }
        }

        private void formiddb_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Program.currentlyLoginEmployee != null)
            {
                NodeLinkedList node = Program.currentlyLoginEmployee.allcalls.getNode(formiddb.SelectedIndex);
                if (node != null)
                {
                    nameecftb.Text = node.call.caller.name;
                    locationecftb.Text = node.call.location;
                    phoneecftb.Text = node.call.caller.phonenumber;
                    emergencyecftb.Text = node.call.emergency;
                    calltimeecftb.Text = node.call.calltime;
                }
            }
        }
        private void confirmcallBtn_Click(object sender, EventArgs e)
        {
            if (formiddb.Items.Count > 0)
            {
                NodeLinkedList node = Program.currentlyLoginEmployee.allcalls.getNode(formiddb.SelectedIndex);
                if(node.call.responsetime != "")
                {
                    node.call.responsetime = DateTime.Now.ToString("hh:mm tt");
                    NodeLinkedList node1 = Program.incharge.allemployees.getNode(3);
                    NodeLinkedList node2 = Program.incharge.allemployees.getNode(4);
                    NodeLinkedList node3 = Program.incharge.allemployees.getNode(5);
                    if (node1 != null)
                    {
                        node1.employee.addCall(node.call);
                    }
                    if (node2 != null)
                    {
                        node2.employee.addCall(node.call);
                    }
                    if (node3 != null)
                    {
                        node3.employee.addCall(node.call);
                    }
                }
                MessageBox.Show("ECF is Confirmed");
            }
        }

        public void CTWOForm_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == false)
            {
                UpdateHomePage();
                UpdateCallsPage();
                bunifuPages.SetPage("Home");
                homeBtn.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                fillFormBtn.BaseColor = Color.White;
                viewecfBtn.BaseColor = Color.White;
                logoutBtn.BaseColor = Color.White;
            }
        }
    }
}
