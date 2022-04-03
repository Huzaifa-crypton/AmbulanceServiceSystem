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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            UpdateCallMakePage();
        }
        private void callBtn_Click(object sender, EventArgs e)
        {
            bunifuPages.SetPage("Call");
            UpdateCallMakePage();
            callBtn.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            historyBtn.BaseColor = Color.White;
            logoutBtn.BaseColor = Color.White;
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            bunifuPages.SetPage("History");
            UpdateHistoryPage();
            historyBtn.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            callBtn.BaseColor = Color.White;
            logoutBtn.BaseColor = Color.White;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.loginForm.Closed += (s, arg) => this.Close();
            Program.loginForm.Show();
        }

        private void closeBtn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void makeCallBtn_Click(object sender, EventArgs e)
        {
            if(citiesDropdown.SelectedIndex > 0 && emergencyTypeTextBox.Text != "")
            {
                Program.ECFID++;
                ECF call = new ECF(Program.currentlyLoginUser,Program.ECFID,citiesDropdown.SelectedItem.ToString(),emergencyTypeTextBox.Text,DateTime.Now.ToString("h:mm tt"),"","","");
                Program.allECFs.insertAtEnd(call);
                Program.currentlyLoginUser.allcalls.insertAtHead(call);
                NodeBST node = new NodeBST(call);
                Program.ecfNamesBST.insert(node, BSTTypes.NameBST);
                Program.ecfLocationBST.insert(node, BSTTypes.LocationBST);
                Program.ecfHospitalsBST.insert(node, BSTTypes.HospitalNameBST);
                NodeLinkedList node1 = Program.incharge.allemployees.getNode(0);
                NodeLinkedList node2 = Program.incharge.allemployees.getNode(1);
                NodeLinkedList node3 = Program.incharge.allemployees.getNode(2);
                if(node1 != null)
                {
                    node1.employee.addCall(call);
                }
                if (node2 != null)
                {
                    node2.employee.addCall(call);
                }
                if (node3 != null)
                {
                    node3.employee.addCall(call);
                }
                UpdateCallMakePage();
            }
            else
            {
                if(emergencyTypeTextBox.Text == "")
                {
                    emergencyTypeTextBox.PlaceholderText = "Fill the box";
                    emergencyTypeTextBox.PlaceholderForeColor = Color.Red;
                }
            }
        }

        private void UpdateCallMakePage()
        {
            if(Program.currentlyLoginUser!= null)
            {
                NodeLinkedList lastCall = Program.currentlyLoginUser.allcalls.head;
                if(lastCall == null || lastCall.call.dispatchtime != "")
                {
                    citiesDropdown.Visible = true;
                    emergencyTypeTextBox.Visible = true;
                    messageTextBox.Visible = false;
                    makeCallBtn.Visible = true;
                    makeCallBtn.Text = "Emergency Call";
                    makeCallBtn.FillColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    makeCallBtn.HoverState.FillColor = Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                }
                else
                {
                    if(lastCall.call.responsetime != "" && lastCall.call.dispatchtime != "")
                    {
                        citiesDropdown.Visible = false;
                        emergencyTypeTextBox.Visible = false;
                        messageTextBox.Visible = true;
                        makeCallBtn.Visible = true;
                        messageTextBox.Text = "When You Arrived at the Hospital with OUR Ambulance then Please Click here..";
                        makeCallBtn.Text = "Arrived";
                        makeCallBtn.FillColor = Color.MediumSeaGreen;
                        makeCallBtn.HoverState.FillColor = Color.SeaGreen;
                    }
                    else
                    {
                        citiesDropdown.Visible = false;
                        emergencyTypeTextBox.Visible = false;
                        messageTextBox.Visible = true;
                        makeCallBtn.Visible = false;
                        messageTextBox.Text = "OUR System is Working on Your Call! Wait Plaese..";
                    }
                }
            }
            emergencyTypeTextBox.PlaceholderForeColor = Color.Silver;
            emergencyTypeTextBox.PlaceholderText = "Emergency";
            citiesDropdown.Items.Clear();
            citiesDropdown.Items.Add("Select City");
            citiesDropdown.SelectedIndex = 0;
            emergencyTypeTextBox.Text = "";
            NodeLinkedList node = Program.incharge.allcities.head;
            while (node != null)
            {
                citiesDropdown.Items.Add(node.city.name);
                node = node.next;
            }
        }

        private void UpdateHistoryPage()
        {
            callsDataGridView.Rows.Clear();
            NodeLinkedList callNode = Program.currentlyLoginUser.allcalls.head;
            while (callNode != null)
            {
                callsDataGridView.Rows.Add(callNode.call.id,callNode.call.caller.name,callNode.call.location,callNode.call.caller.phonenumber,callNode.call.calltime,callNode.call.responsetime,callNode.call.dispatchtime,callNode.call.arrivaltime);
                callNode = callNode.next;
            }
        }

        private void UserForm_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == false)
            {
                UpdateCallMakePage();
                bunifuPages.SetPage("Call");
                callBtn.BaseColor = Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                historyBtn.BaseColor = Color.White;
                logoutBtn.BaseColor = Color.White;
            }
        }

        private void Call_Click(object sender, EventArgs e)
        {
            string location = selectCity.Text;
            string typeEmer = emrgencyType.Text;
            string calltime = DateTime.Now.ToString("HH:MM:SS");
            ECF eCF = new ECF(Program.currentlyLoginUser, Program.formNumber , location, calltime, "Waiting", "Waiting", "Waiting");
        
            /*Hospital bst is to be created when wo will fill the form*/
            BSTManager.createInstance().ecfNamesBST.insertECF(eCF, eCF.caller.name);
            Program.callQueue.enqueue(eCF);
            BSTManager.createInstance().ecfLocationBST.insertECF(eCF, eCF.location);
        }
    }
}