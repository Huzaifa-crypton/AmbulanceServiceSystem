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
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }
        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.loginForm.Closed += (s, arg) => this.Close();
            Program.loginForm.Show();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            string name = nameForgot.Text;
            string newPass = newPassForgot.Text;
            string confirmPass = confirmpassForgot.Text;
            if (name != "" && newPass != "" && confirmPass != "")
            {
                if (newPass != confirmPass)
                {
                    confirmpassForgot.PlaceholderForeColor = Color.Red;
                    confirmpassForgot.PlaceholderText = "Password not confirmed";
                }
                else
                {
                    User node = Program.allUsers.findNodeUser(name);
                    if (node != null)
                    {
                        node.password = newPass;
                        Program.allUsers.writeUserLinkedListinCSV(Program.usersPath);
                        this.Hide();
                        Program.loginForm.Closed += (s, arg) => this.Close();
                        Program.loginForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("User Not Found","Error");
                    }
                }
            }
            else
            {
                if (name == "")
                {
                    nameForgot.PlaceholderText = "Fill in the box";
                    nameForgot.PlaceholderForeColor = Color.Red;
                }
                if (newPass == "")
                {
                    newPassForgot.PlaceholderText = "Fill in the box";
                    newPassForgot.PlaceholderForeColor = Color.Red;
                }
                if (confirmPass == "")
                {
                    confirmpassForgot.PlaceholderText = "Fill in the box";
                    confirmpassForgot.PlaceholderForeColor = Color.Red;
                }
            }
        }

        private void ForgotPasswordForm_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == false)
            {
                nameForgot.Text = "";
                newPassForgot.Text = "";
                confirmpassForgot.Text = "";
                nameForgot.PlaceholderText = "Name / Email";
                nameForgot.PlaceholderForeColor = Color.Silver;
                newPassForgot.PlaceholderText = "New Password";
                newPassForgot.PlaceholderForeColor = Color.Silver;
                confirmpassForgot.PlaceholderText = "Confirm Password";
                confirmpassForgot.PlaceholderForeColor = Color.Silver;
            }
        }
    }
}
