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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.loginForm.Closed += (s, arg) => this.Close();
            Program.loginForm.Show();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string name = nameSignup.Text;
            string email = emailSignup.Text;
            string password = passwordSignup.Text;
            string phone = phoneSignup.Text;
            if (name != "" && email != "" && password != "" && phone != "")
            {
                User user = new User(name, email, phone, password);
                Program.allUsers.insertAtEnd(user);
                Program.allUsers.writeUserLinkedListinCSV(Program.usersPath);
                this.Hide();
                Program.loginForm.Closed += (s, arg) => this.Close();
                Program.loginForm.Show();
            }
            else
            {
                if (name == "")
                {
                    nameSignup.PlaceholderText = "Fill in the box";
                    nameSignup.PlaceholderForeColor = Color.Red;
                }
                if (email == "")
                {
                    emailSignup.PlaceholderText = "Fill in the box";
                    emailSignup.PlaceholderForeColor = Color.Red;
                }
                if (password == "")
                {
                    passwordSignup.PlaceholderText = "Fill in the box";
                    passwordSignup.PlaceholderForeColor = Color.Red;
                }
                if (phone == "")
                {
                    phoneSignup.PlaceholderText = "Fill in the box";
                    phoneSignup.PlaceholderForeColor = Color.Red;
                }
            }
        }

        private void SignUpForm_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == false)
            {
                nameSignup.Text = "";
                emailSignup.Text = "";
                passwordSignup.Text = "";
                phoneSignup.Text = "";
                nameSignup.PlaceholderText = "Full Name";
                nameSignup.PlaceholderForeColor = Color.Silver;
                emailSignup.PlaceholderText = "Email";
                emailSignup.PlaceholderForeColor = Color.Silver;
                passwordSignup.PlaceholderText = "Password";
                passwordSignup.PlaceholderForeColor = Color.Silver;
                phoneSignup.PlaceholderText = "Phone Number";
                phoneSignup.PlaceholderForeColor = Color.Silver;
            }
        }
    }
}
