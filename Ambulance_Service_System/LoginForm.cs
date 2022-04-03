using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ambulance_Service_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void forgotlabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.forgotPasswordForm.Closed += (s, arg) => this.Close();
            Program.forgotPasswordForm.Show();
        }

        private void createAccountLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.signupForm.Closed += (s, arg) => this.Close();
            Program.signupForm.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameLogin.Text;
            string password = passwordLogin.Text;
            if(username != "" && password != "")
            { 
                checkCredentials(username, password);
            }
            else
            {
                if (username == "")
                {
                    usernameLogin.PlaceholderText = "Fill in the box";
                    usernameLogin.PlaceholderForeColor = Color.Red;
                }
                if (password == "")
                {
                    passwordLogin.PlaceholderText = "Fill in the box";
                    passwordLogin.PlaceholderForeColor = Color.Red;
                }
            }
        }
        public void checkCredentials(string name, string pass)
        {
            Program.currentlyLoginEmployee = Program.incharge.allemployees.findNodeEmployee(name, pass);
            Program.currentlyLoginUser = Program.allUsers.findNodeUser(name, pass);
            if(Program.incharge.name == name && Program.incharge.password == pass)
            {
                this.Hide();
                Program.inchargeForm.Closed += (s, arg) => this.Close();
                Program.inchargeForm.UpdateHomePage();
                Program.inchargeForm.Show();
            }
            else if (Program.currentlyLoginEmployee != null)
            {
                if (Program.currentlyLoginEmployee.type == "CTWO")
                {
                    this.Hide();
                    Program.ctwoForm.Closed += (s, arg) => this.Close();
                    Program.ctwoForm.UpdateHomePage();
                    Program.ctwoForm.Show();
                }
                else if (Program.currentlyLoginEmployee.type == "WO")
                {
                    this.Hide();
                    Program.woForm.Closed += (s, arg) => this.Close();
                    Program.woForm.UpdateHomePage();
                    Program.woForm.Show();
                }
            }
            else if (Program.currentlyLoginUser != null)
            {
                this.Hide();
                Program.userForm.Closed += (s, arg) => this.Close();
                Program.userForm.Show();
            }
            else
            {
                usernameLogin.Text = "";
                usernameLogin.PlaceholderText = "Name / Email";
                passwordLogin.Text = "";
                passwordLogin.PlaceholderText = "Password";
            }
        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == false)
            {
                usernameLogin.Text = "";
                usernameLogin.PlaceholderText = "Name / Email";
                usernameLogin.PlaceholderForeColor = Color.Silver;
                passwordLogin.Text = "";
                passwordLogin.PlaceholderText = "Password";
                passwordLogin.PlaceholderForeColor = Color.Silver;
            }
        }
    }
}
